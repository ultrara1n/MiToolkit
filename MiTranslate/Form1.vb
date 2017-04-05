Imports System.IO
Imports System.Net
Imports System.Security.Cryptography

Public Class Form1
    Private Sub cmdCheckConnection_Click(sender As Object, e As EventArgs) Handles cmdCheckConnection.Click
        Dim adbResult As String = checkADB()

        If adbResult = "" Then
            MsgBox("Es konnte kein Gerät gefunden werden." & vbCrLf &
                   "Stelle sicher das ADB Debugging aktiviert ist und das Handy vom PC erkannt wird." & vbCrLf &
                   "Manchmal kann ein anderer USB Port oder Kabel Abhilfe schaffen.", MsgBoxStyle.Critical)
            Exit Sub
        Else
            txtDevice.Text = adbResult
            Me.Height = 336
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 214
    End Sub
    Dim WithEvents WC As New WebClient
    Dim WithEvents WC2 As New WebClient
    Private Sub cmdGetVersions_Click(sender As Object, e As EventArgs) Handles cmdGetVersions.Click
        Dim erweiterung() As String
        Dim homeapp() As String
        Using client = New WebClient()
            Dim result() As String = Split(client.DownloadString("https://philippwensauer.com/mi/versions.txt"), vbCrLf)
            homeapp = Split(result(0), ";")
            erweiterung = Split(result(1), ";")

        End Using
        txtMiHome.Text = homeapp(1)
        txtErweiterung.Text = erweiterung(1)

        'Daten zwischenspeichern
        txtHomeVersion.Text = homeapp(3)
        txtHomeMD5.Text = UCase(homeapp(4))
        txtErweiterungVersion.Text = erweiterung(3)
        txtErweiterungMD5.Text = UCase(erweiterung(4))

        'Prüfen ob Dateien schon heruntergeladen wurden (Home)
        If My.Computer.FileSystem.FileExists("apk/" & homeapp(3)) Then
            'Datei schon vorhanden, Text einblenden
            lblHomeExists.Visible = True
        Else
            'Datei noch nicht vorhanden, Progressbar einblenden
            pbHome.Visible = True
            WC.DownloadFileAsync(New Uri("https://philippwensauer.com/mi/" & homeapp(3)), "apk/" & homeapp(3))
        End If

        'Prüfen ob Dateien schon heruntergeladen wurden (Erweiterung)
        If My.Computer.FileSystem.FileExists("apk/" & erweiterung(3)) Then
            'Datei schon vorhanden, Text einblenden
            lblErweiterungExists.Visible = True
        Else
            'Datei noch nicht vorhanden, Progressbar einblenden
            pbErweiterung.Visible = True
            WC2.DownloadFileAsync(New Uri("https://philippwensauer.com/mi/" & erweiterung(3)), "apk/" & erweiterung(3))
        End If
        If lblErweiterungExists.Visible = True And lblHomeExists.Visible = True Then
            Me.Height = 369
        End If
    End Sub
    Private Sub WC_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles WC.DownloadProgressChanged
        pbHome.Value = e.ProgressPercentage
    End Sub
    Private Sub WC2_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles WC2.DownloadProgressChanged
        pbErweiterung.Value = e.ProgressPercentage
    End Sub

    Private Sub WC_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles WC.DownloadFileCompleted
        'MD5 Hash prüfen
        If (txtHomeMD5.Text <> MD5FileHash("apk/" & txtHomeVersion.Text)) Then
            MsgBox("Fehler beim Download, bitte Ordner apk/ leeren und erneut Versuchen.")
        Else
            Me.Height = 369
        End If
    End Sub

    Private Sub WC2_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles WC2.DownloadFileCompleted
        'MD5 Hash prüfen
        If (txtErweiterungMD5.Text <> MD5FileHash("apk/" & txtErweiterungVersion.Text)) Then
            MsgBox("Fehler beim Download, bitte Ordner apk/ leeren und erneut Versuchen.")
        End If
    End Sub

    Public Function MD5FileHash(ByVal sFile As String) As String
        Dim MD5 As New MD5CryptoServiceProvider
        Dim Hash As Byte()
        Dim Result As String = ""
        Dim Tmp As String = ""

        Dim FN As New FileStream(sFile, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        MD5.ComputeHash(FN)
        FN.Close()

        Hash = MD5.Hash
        For i As Integer = 0 To Hash.Length - 1
            Tmp = Hex(Hash(i))
            If Len(Tmp) = 1 Then Tmp = "0" & Tmp
            Result += Tmp
        Next
        Return Result
    End Function

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
            Dim oStartInfo As New ProcessStartInfo("adb/adb.exe", "install -r apk/" & txtHomeVersion.Text)
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

            Me.Height = 455
        End If
    End Sub

    Private Sub cmdSicherung_Click(sender As Object, e As EventArgs) Handles cmdSicherung.Click
        'Sicherungsordner leeren
        Dim directoryName As String = "save/"
        For Each deleteFile In Directory.GetFiles(directoryName, "*.*", SearchOption.TopDirectoryOnly)
            File.Delete(deleteFile)
        Next

        MsgBox("Bei der Sicherung KEIN Passwort vergeben!")

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

        If backupFileSize < 20000000 Then
            MsgBox("Es scheint ein Fehler aufgetreten zu sein, das Backup ist viel zu klein.")
        Else
            Me.Height = 539
        End If
    End Sub

    Private Sub cmdExtract_Click(sender As Object, e As EventArgs) Handles cmdExtract.Click
        'apps leeren
        Dim directoryName As String = "apps/"
        For Each deleteFile In Directory.GetFiles(directoryName, "*", SearchOption.TopDirectoryOnly)
            File.Delete(deleteFile)
        Next

        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo("java", "-jar abe.jar unpack save/backup.ab save/backup.tar")
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

        Me.Height = 573
    End Sub

    Private Sub cmdCopyTranslation_Click(sender As Object, e As EventArgs) Handles cmdCopyTranslation.Click
        'Alte Plugin Datei löschen
        Dim directoryName As String = "apps/com.xiaomi.smarthome/f/plugin/install/mpk/134"
        For Each deleteFile In Directory.GetFiles(directoryName, "*.apk*", SearchOption.TopDirectoryOnly)
            File.Delete(deleteFile)
        Next

        'Neue Plugin Datei kopieren
        File.Copy("apk/" & txtErweiterungVersion.Text, directoryName & "/" & txtErweiterungVersion.Text)

        'Sicherung wieder komprimieren
        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo("star.exe", "-c -v -f save/newbackup.tar -no-dirslash list=save/backup.list")
        oStartInfo.UseShellExecute = False
        oStartInfo.CreateNoWindow = True
        oProcess.StartInfo = oStartInfo
        oProcess.Start()
        oProcess.WaitForExit()

        Dim oProcess3 As New Process()
        Dim oStartInfo3 As New ProcessStartInfo("tar.exe", "-rf save/newbackup.tar apps/com.xiaomi.smarthome/_manifest")
        oStartInfo3.UseShellExecute = False
        oStartInfo3.CreateNoWindow = True
        oProcess3.StartInfo = oStartInfo3
        oProcess3.Start()
        oProcess3.WaitForExit()

        Dim oProcess2 As New Process()
        Dim oStartInfo2 As New ProcessStartInfo("java", "-jar abe.jar pack save/newbackup.tar save/newbackup.ab")
        oStartInfo2.UseShellExecute = False
        oStartInfo2.CreateNoWindow = True
        oProcess2.StartInfo = oStartInfo2
        oProcess2.Start()
        oProcess2.WaitForExit()

        Me.Height = 605
    End Sub

    Private Sub cmdRestore_Click(sender As Object, e As EventArgs) Handles cmdRestore.Click
        Dim adbResult As String = checkADB()
        If adbResult = "" Then
            MsgBox("Das Gerät ist verschwunden, wurde es getrennt?", MsgBoxStyle.Critical)
            Exit Sub
        Else
            'MiHome Task killen
            Dim oProcess2 As New Process()
            Dim oStartInfo2 As New ProcessStartInfo("adb/adb.exe", "shell am force-stop com.xiaomi.smarthome")
            oStartInfo2.UseShellExecute = False
            oStartInfo2.CreateNoWindow = True
            oProcess2.StartInfo = oStartInfo2
            oProcess2.Start()
            oProcess2.WaitForExit()

            Dim oProcess As New Process()
            Dim oStartInfo As New ProcessStartInfo("adb/adb.exe", "restore save/newbackup.ab")
            oStartInfo.UseShellExecute = False
            oStartInfo.CreateNoWindow = True
            oProcess.StartInfo = oStartInfo
            oProcess.Start()
            oProcess.WaitForExit()

            'Mi Home App starten
            Dim oProcess3 As New Process()
            Dim oStartInfo3 As New ProcessStartInfo("adb/adb.exe", "shell monkey -p com.xiaomi.smarthome -c android.intent.category.LAUNCHER 1")
            oStartInfo3.UseShellExecute = False
            oStartInfo3.CreateNoWindow = True
            oProcess3.StartInfo = oStartInfo3
            oProcess3.Start()
            oProcess3.WaitForExit()
        End If
    End Sub

    Private Sub cmdForceNext_Click(sender As Object, e As EventArgs) Handles cmdForceNext.Click
        Me.Height = 455
    End Sub

    Private Sub cmdDebug_Click(sender As Object, e As EventArgs) Handles cmdDebug.Click
        Me.Height = 605
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Help.AxShockwaveFlash1.Movie = "https://www.youtube.com/v/a7zEniOcET0"
        Help.Text = "USB Debugging aktivieren"
        Help.Show()
        Me.Enabled = False
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        MsgBox("Der größte Dank geht an Henne78 für seine Übersetzungsarbeit!" & vbCrLf &
               "Danke an SlaveofPain für sein Übersetzungstool!" & vbCrLf &
               "Programmiert von blacksn0w.")
    End Sub

    Function checkADB()
        'Prüfen ob ADB Gerät immer noch verbunden ist
        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo("adb/adb.exe", "devices -l")
        oStartInfo.UseShellExecute = False
        oStartInfo.CreateNoWindow = True
        oStartInfo.RedirectStandardOutput = True
        oProcess.StartInfo = oStartInfo
        oProcess.Start()

        Dim sOutput As String
        Using oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
            sOutput = oStreamReader.ReadToEnd()
        End Using

        'Ergebnis etwas anpassen damit es genutzt werden kann
        Dim result() As String = Split(sOutput, vbCrLf)

        'Array durchlaufen um zu schauen ob Gerät verbunden ist
        For Each output As String In result
            If (output.Contains("product")) Then
                'Gerät gefunden
                Dim modelinfos() As String = Split(output, ":")
                checkADB = modelinfos(3)
            End If
        Next
    End Function

    Private Sub cmdCheckJava_Click(sender As Object, e As EventArgs) Handles cmdCheckJava.Click
        'Java Installation prüfen
        Dim JavaProc As New Process()
        Dim JavaProcInfo As New ProcessStartInfo("java", "-version")

        With JavaProcInfo
            .UseShellExecute = False
            .RedirectStandardError = True
            .CreateNoWindow = True
        End With

        With JavaProc
            .StartInfo = JavaProcInfo
            .Start()
        End With

        Dim sOutput As String
        Using sReader As System.IO.StreamReader = JavaProc.StandardError
            sOutput = sReader.ReadToEnd()
        End Using

        Dim info() As String = Split(sOutput, vbCrLf)

        For Each output As String In info
            If (output.Contains("Runtime Environment")) Then
                MsgBox(output)
            End If
        Next
    End Sub
End Class
