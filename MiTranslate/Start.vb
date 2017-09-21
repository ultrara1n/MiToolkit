Imports System.IO
Imports System.Net
Imports Microsoft.Win32
Imports System.Globalization
Imports System.Threading

Public Class frmTranslation
    Private Sub cmdCheckConnection_Click(sender As Object, e As EventArgs) Handles cmdCheckConnection.Click
        Dim adbResult As String = checkADB()

        If adbResult = "" Then
            MsgBox("Es konnte kein Gerät gefunden werden." & vbCrLf &
                   "Stelle sicher das ADB Debugging aktiviert ist und das Handy vom PC erkannt wird." & vbCrLf &
                   "Manchmal kann ein anderer USB Port oder Kabel Abhilfe schaffen.", MsgBoxStyle.Critical)
            Exit Sub
        Else
            txtDeviceModel.Text = adbResult

            getADBInfos()
            txtDeviceAndroid.Text = globalData.androidVersion
            txtDeviceAPI.Text = globalData.androidAPI

            'Prüfen ob Verschlüsselt
            If globalData.androidEncryption = "encrypted" Then
                pbSchloss.Visible = True

                'Java Verzeichnis herausfinden
                'Hier kann es passieren das eine Exception kommt, also fahren wir das über einen Catch
                Dim javaKey As String = "SOFTWARE\JavaSoft\Java Runtime Environment"
                Dim javaPath As String
                Dim javaVersion As String
                Try
                    Using baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(javaKey)
                        javaVersion = baseKey.GetValue("CurrentVersion").ToString()
                        Using homeKey = baseKey.OpenSubKey(javaVersion)
                            javaPath = homeKey.GetValue("JavaHome").ToString()
                        End Using
                    End Using
                Catch Exc As System.NullReferenceException
                    MsgBox("Leider konnte der Java Ordner nicht automatisch ermittelt werden, bitte wähle ihn manuell aus.")
                    If fdbJava.ShowDialog() = DialogResult.OK Then
                        javaPath = fdbJava.SelectedPath
                        If (File.Exists(javaPath & "\bin\java.exe")) Then
                        Else
                            MsgBox("Der Ordner scheint nicht zu stimmen, in " & javaPath & "\bin\ befindet sich keine java.exe")
                            Exit Sub
                        End If
                    Else
                        MsgBox("Ohne den Java Ordner kommen wir leider nicht weiter.")
                        Exit Sub
                    End If
                End Try

                'Java Version festlegen
                checkJava()
                Dim javaVersionSmall As Integer
                If globalData.javaInfo.Contains("1.8") Then
                    javaVersionSmall = 8
                ElseIf globalData.javaInfo.Contains("1.7") Then
                    javaVersionSmall = 7
                End If

                'Zu betrachtende Dateien
                Dim pathLocalPolicyNew = "java/" & javaVersionSmall & "/local_policy.jar"
                Dim pathLocalPolicyOld = javaPath & "\lib\security\local_policy.jar"
                Dim pathUSExportNew = "java/" & javaVersionSmall & "/US_export_policy.jar"
                Dim pathUSExportOld = javaPath & "\lib\security\US_export_policy.jar"

                'Prüfen wir vorab ob die Security Files möglicherweise schon aktuell sind
                'Damit könnten wir uns das Admin Zeug sparen
                Dim sumLocalPolicyNew As String = MD5FileHash(pathLocalPolicyNew)
                Dim sumLocalPolicyOld As String = MD5FileHash(pathLocalPolicyOld)
                Dim sumUSExportNew As String = MD5FileHash(pathUSExportNew)
                Dim sumUSExportOld As String = MD5FileHash(pathUSExportOld)
                Dim checkInt As Integer = 0

                If sumLocalPolicyNew = sumLocalPolicyOld Then
                    checkInt = checkInt + 1
                End If
                If sumUSExportNew = sumUSExportOld Then
                    checkInt = checkInt + 1
                End If

                If (checkInt = 2) Then
                    MsgBox("Deine Security Files sind aktuell, keine Aktualisierung notwendig.")
                Else
                    MsgBox("Deine Security Files nicht nicht aktuell, Aktualisierung wird gestartet.")
                    Try
                        'Alte Security Files löschen
                        File.Delete(javaPath & "\lib\security\local_policy.jar")
                        File.Delete(javaPath & "\lib\security\US_export_policy.jar")
                        'Neue kopieren
                        File.Copy(pathLocalPolicyNew, pathLocalPolicyOld)
                        File.Copy(pathUSExportNew, pathUSExportOld)
                    Catch Exc As System.UnauthorizedAccessException
                        MsgBox("Leider besteht keine Schreibberechtigung auf das Java Verzeichnis, bitte starte das Programm im Administrator Modus neu. " & vbCrLf &
                               "Rechtsklick -> Als Administrator ausführen")
                        Exit Sub
                    End Try
                End If
            Else
            End If
            Me.Height = 361
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 234
    End Sub
    Dim WithEvents wcHome As New WebClient
    Dim WithEvents wcVacuum As New WebClient

    Private Sub cmdGetVersions_Click(sender As Object, e As EventArgs) Handles cmdGetVersions.Click
        Dim homeapp() As String
        Dim vacuum() As String
        Using client = New WebClient()
            Dim result() As String = Split(client.DownloadString("https://philippwensauer.com/mi/versions.txt?v=" & frmStart.lblVersion.Text), vbCrLf)
            homeapp = Split(result(0), ";")
            vacuum = Split(result(1), ";")
        End Using
        txtMiHome.Text = homeapp(1)
        txtErweiterung.Text = vacuum(1)

        'Daten zwischenspeichern
        globalData.homeVersion = homeapp(3)
        globalData.homeMD5 = UCase(homeapp(4))
        globalData.vacuumVersion = vacuum(3)
        globalData.vacuumMD5 = UCase(vacuum(4))

        'Prüfen ob Dateien schon heruntergeladen wurden (Home)
        If My.Computer.FileSystem.FileExists("apk/" & homeapp(3)) Then
            'Datei schon vorhanden, Text einblenden
            lblHomeExists.Visible = True
        Else
            'Datei noch nicht vorhanden, Progressbar einblenden
            pbHome.Visible = True
            wcHome.DownloadFileAsync(New Uri("https://philippwensauer.com/mi/" & homeapp(3)), "apk/" & homeapp(3))
        End If

        'Prüfen ob Dateien schon heruntergeladen wurden (Erweiterung)
        If My.Computer.FileSystem.FileExists("apk/" & vacuum(3)) Then
            'Prüfen ob diese auch richtig sind, sonst löschen und noch mal laden
            If (globalData.vacuumMD5 <> MD5FileHash("apk/" & globalData.vacuumVersion)) Then
                pbErweiterung.Visible = True
                File.Delete("apk/" & globalData.vacuumVersion)
                wcVacuum.DownloadFileAsync(New Uri("https://philippwensauer.com/mi/" & vacuum(3)), "apk/" & vacuum(3))
            Else
                'Datei schon vorhanden und richtig, Text einblenden
                lblErweiterungExists.Visible = True
            End If
        Else
            'Datei noch nicht vorhanden, Progressbar einblenden
            pbErweiterung.Visible = True
            wcVacuum.DownloadFileAsync(New Uri("https://philippwensauer.com/mi/" & vacuum(3)), "apk/" & vacuum(3))
        End If
        If lblErweiterungExists.Visible = True And lblHomeExists.Visible = True Then
            Me.Height = 335
        End If
    End Sub
    Private Sub wcHome_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles wcHome.DownloadProgressChanged
        pbHome.Value = e.ProgressPercentage
    End Sub
    Private Sub wcVacuum_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles wcVacuum.DownloadProgressChanged
        pbErweiterung.Value = e.ProgressPercentage
    End Sub

    Private Sub wcHome_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles wcHome.DownloadFileCompleted
        'MD5 Hash prüfen
        If (globalData.homeMD5 <> MD5FileHash("apk/" & globalData.homeVersion)) Then
            MsgBox("Fehler beim Download, bitte Ordner apk/ leeren und erneut Versuchen.")
        Else
            Me.Height = 397
        End If
    End Sub

    Private Sub wcVacuum_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles wcVacuum.DownloadFileCompleted
        'MD5 Hash prüfen
        If (globalData.vacuumMD5 <> MD5FileHash("apk/" & globalData.vacuumVersion)) Then
            MsgBox("Fehler beim Download, bitte Ordner apk/ leeren und erneut Versuchen.")
        ElseIf lblHomeExists.Visible Then
            Me.Height = 397
        End If
    End Sub

    Private Sub cmdInstallMiHome_Click(sender As Object, e As EventArgs) Handles cmdInstallMiHome.Click
        Dim adbResult As String = checkADB()
        If adbResult = "" Then
            MsgBox("Das Gerät ist verschwunden, wurde es getrennt?", MsgBoxStyle.Critical)
            Exit Sub
        Else
            'Mi Home deinstallieren
            Dim oProcess3 As New Process()
            Dim oStartInfo3 As New ProcessStartInfo("adb/adb.exe", "uninstall com.xiaomi.smarthome")
            oStartInfo3.UseShellExecute = False
            oStartInfo3.CreateNoWindow = True
            oProcess3.StartInfo = oStartInfo3
            oProcess3.Start()
            oProcess3.WaitForExit()

            'Mi Home App installieren
            Dim oProcess As New Process()
            Dim oStartInfo As New ProcessStartInfo("adb/adb.exe", "install -r apk/" & globalData.homeVersion)
            oStartInfo.UseShellExecute = False
            oStartInfo.CreateNoWindow = True
            oProcess.StartInfo = oStartInfo
            oProcess.Start()
            oProcess.WaitForExit()

            'Mi Home App starten
            Dim oProcess2 As New Process()
            Dim oStartInfo2 As New ProcessStartInfo("adb/adb.exe", "shell monkey -p com.xiaomi.smarthome -c android.intent.category.LAUNCHER 1")
            oStartInfo2.UseShellExecute = False
            oStartInfo2.CreateNoWindow = True
            oProcess2.StartInfo = oStartInfo2
            oProcess2.Start()
            oProcess2.WaitForExit()
            'Video zeigen
            Help.AxShockwaveFlash1.Movie = "https://www.youtube.com/v/BOUZ8J2NsM0"
            Help.Text = "MiHome App vorbereiten"
            Help.Show()
            Me.Enabled = False
            Me.Height = 482
        End If
    End Sub

    Private Sub cmdSicherung_Click(sender As Object, e As EventArgs) Handles cmdSicherung.Click
        If doBackup() < 20000000 Then
            MsgBox("Es scheint ein Fehler aufgetreten zu sein, das Backup ist viel zu klein.")
        Else
            Me.Height = 566
        End If
    End Sub

    Private Sub cmdExtract_Click(sender As Object, e As EventArgs) Handles cmdExtract.Click
        extractBackup()

        Me.Height = 597
    End Sub

    Private Sub cmdCopyTranslation_Click(sender As Object, e As EventArgs) Handles cmdCopyTranslation.Click
        'Alte Plugin Datei löschen
        Dim directoryName As String = "apps/com.xiaomi.smarthome/f/plugin/install/mpk/134"
        For Each deleteFile In Directory.GetFiles(directoryName, "*.apk*", SearchOption.TopDirectoryOnly)
            File.Delete(deleteFile)
        Next

        'Neue Plugin Datei kopieren
        File.Copy("apk/" & globalData.vacuumVersion, directoryName & "/" & globalData.vacuumVersion)

        'Sicherung wieder komprimieren
        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo("star.exe", "-c -v -f save/newbackup.tar -no-dirslash list=save/backup.list")
        'Dim oStartInfo As New ProcessStartInfo("tar.exe", "cf save/newbackup.tar -T save/backup.list")
        oStartInfo.UseShellExecute = False
        oStartInfo.CreateNoWindow = True
        oProcess.StartInfo = oStartInfo
        oProcess.Start()
        oProcess.WaitForExit()

        Dim oProcess2 As New Process()
        Dim restoreOption As String = "-jar abe.jar pack save/newbackup.tar save/newbackup.ab"
        If pbSchloss.Visible = True Then
            restoreOption = "-jar abe.jar pack save/newbackup.tar save/newbackup.ab 123"
        End If
        Dim oStartInfo2 As New ProcessStartInfo("java", restoreOption)
        oStartInfo2.UseShellExecute = False
        oStartInfo2.CreateNoWindow = True
        oProcess2.StartInfo = oStartInfo2
        oProcess2.Start()
        oProcess2.WaitForExit()

        Me.Height = 610
    End Sub

    Private Sub cmdRestore_Click(sender As Object, e As EventArgs) Handles cmdRestore.Click
        Dim adbResult As String = checkADB()
        If adbResult = "" Then
            MsgBox("Das Gerät ist verschwunden, wurde es getrennt?", MsgBoxStyle.Critical)
            Exit Sub
        Else
            'MiHome Task killen
            Dim processStopApp As New Process()
            Dim infoStopApp As New ProcessStartInfo("adb/adb.exe", "shell am force-stop com.xiaomi.smarthome")
            infoStopApp.UseShellExecute = False
            infoStopApp.CreateNoWindow = True
            processStopApp.StartInfo = infoStopApp
            processStopApp.Start()
            processStopApp.WaitForExit()
            'Backup wiederherstellen
            If pbSchloss.Visible = True Then
                MsgBox("Als Passwort 123 eingeben!", MsgBoxStyle.Information)
            End If
            Dim processRestoreBackup As New Process()
            Dim infoRestoreBackup As New ProcessStartInfo("adb/adb.exe", "restore save/newbackup.ab")
            infoRestoreBackup.UseShellExecute = False
            infoRestoreBackup.CreateNoWindow = True
            processRestoreBackup.StartInfo = infoRestoreBackup
            processRestoreBackup.Start()
            processRestoreBackup.WaitForExit()
            'Mi Home App starten
            Dim processStartApp As New Process()
            Dim infoStartApp As New ProcessStartInfo("adb/adb.exe", "shell monkey -p com.xiaomi.smarthome -c android.intent.category.LAUNCHER 1")
            infoStartApp.UseShellExecute = False
            infoStartApp.CreateNoWindow = True
            processStartApp.StartInfo = infoStartApp
            processStartApp.Start()
            processStartApp.WaitForExit()
        End If
    End Sub

    Private Sub cmdForceNext_Click(sender As Object, e As EventArgs) Handles cmdForceNext.Click
        Me.Height = 455
    End Sub

    Private Sub cmdDebug_Click(sender As Object, e As EventArgs) Handles cmdDebug.Click
        Me.Height = 610
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Help.AxShockwaveFlash1.Movie = "https://www.youtube.com/v/a7zEniOcET0"
        Help.Text = "USB Debugging aktivieren"
        Help.Show()
        Me.Enabled = False
    End Sub

    Private Sub cmdCheckJava_Click(sender As Object, e As EventArgs) Handles cmdCheckJava.Click
        checkJava()
        If (globalData.javaInfo = "ERROR") Then
            MsgBox("Konnte kein Java Runtime Environment finden. Sicher das es installiert ist?", MsgBoxStyle.Critical)
            Process.Start("https://java.com/de/download/")
        ElseIf globalData.javaInfo <> "" Then
            MsgBox("Java gefunden: " & globalData.javaInfo)
        End If
    End Sub

    Private Sub cmdGetToken_Click(sender As Object, e As EventArgs) Handles cmdGetToken.Click
        'Mi Home App starten
        Dim oProcess2 As New Process()
        Dim oStartInfo2 As New ProcessStartInfo("adb/adb.exe", "shell monkey -p com.xiaomi.smarthome -c android.intent.category.LAUNCHER 1")
        oStartInfo2.UseShellExecute = False
        oStartInfo2.CreateNoWindow = True
        oProcess2.StartInfo = oStartInfo2
        oProcess2.Start()
        oProcess2.WaitForExit()
        If doBackup() < 20000000 Then
            MsgBox("Es scheint ein Fehler aufgetreten zu sein, das Backup ist viel zu klein.")
        Else
            MsgBox("Backup erfolgreich, wird jetzt entpackt.")
            extractBackup()
            Dim connect As New SQLite.SQLiteConnection()
            Dim command As SQLite.SQLiteCommand
            connect.ConnectionString = "Data Source=apps/com.xiaomi.smarthome/db/miio2.db;"
            connect.Open()
            command = connect.CreateCommand
            'command.CommandText = "SELECT name, token, model FROM devicerecord WHERE model = 'rockrobo.vacuum.v1'"
            command.CommandText = "SELECT name, token, model FROM devicerecord"
            Dim SQLreader As SQLite.SQLiteDataReader = command.ExecuteReader()
            While SQLreader.Read()
                showToken.tbToken.AppendText(SQLreader(2) & " - " & SQLreader(0) & " - " & SQLreader(1) & vbCrLf)
                showToken.Show()
            End While
            command.Dispose()
            connect.Close()
        End If
    End Sub

    Function doBackup()
        'Sicherungsordner leeren
        Dim directoryName As String = "save/"
        For Each deleteFile In Directory.GetFiles(directoryName, "*.*", SearchOption.TopDirectoryOnly)
            File.Delete(deleteFile)
        Next

        If pbSchloss.Visible = True Then
            MsgBox("Als Passwort 123 eingeben!", MsgBoxStyle.Information)
        Else
            MsgBox("Bei der Sicherung KEIN Passwort vergeben!")
        End If

        'Sicherung starten
        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo("adb/adb.exe", "backup -f save/backup.ab -apk com.xiaomi.smarthome")
        oStartInfo.UseShellExecute = False
        oStartInfo.CreateNoWindow = True
        oStartInfo.RedirectStandardOutput = True
        oProcess.StartInfo = oStartInfo
        oProcess.Start()

        Dim sOutput As String
        Using oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
            sOutput = oStreamReader.ReadToEnd()
        End Using

        'Backupgröße testen, sonst Fehler auswerfen
        Dim backupFile As New FileInfo("save/backup.ab")
        Dim backupFileSize As Long = backupFile.Length

        Return backupFileSize
    End Function

    Function extractBackup()
        'apps/ leeren
        Dim directoryName As String = "apps/"
        For Each deleteFile In Directory.GetFiles(directoryName, "*", SearchOption.TopDirectoryOnly)
            File.Delete(deleteFile)
        Next

        Dim oProcess As New Process()
        Dim backupOption As String = "-jar abe.jar unpack save/backup.ab save/backup.tar"
        If pbSchloss.Visible = True Then
            backupOption = "-jar abe.jar unpack save/backup.ab save/backup.tar 123"
        End If
        Dim oStartInfo As New ProcessStartInfo("java", backupOption)
        oStartInfo.UseShellExecute = False
        oStartInfo.CreateNoWindow = True
        oProcess.StartInfo = oStartInfo
        oProcess.Start()
        oProcess.WaitForExit()

        Dim oProcess2 As New Process()
        Dim oStartInfo2 As New ProcessStartInfo("tar.exe", "-xvf save/backup.tar")
        oStartInfo2.UseShellExecute = False
        oStartInfo2.CreateNoWindow = True
        oProcess2.StartInfo = oStartInfo2
        oProcess2.Start()
        oProcess2.WaitForExit()

        Dim oProcess4 As New Process()
        Dim oStartInfo4 As New ProcessStartInfo("list.cmd")
        oStartInfo4.UseShellExecute = False
        oStartInfo4.CreateNoWindow = True
        oProcess4.StartInfo = oStartInfo4
        oProcess4.Start()
    End Function

    Private Sub frmTranslation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmStart.Enabled = True
    End Sub
End Class

