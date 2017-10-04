Public Class frmToken
    Private Sub frmToken_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmStart.Enabled = True
    End Sub

    Private Sub cmdGetToken_Click(sender As Object, e As EventArgs) Handles cmdGetToken.Click
        'Mi Home App starten
        Dim oProcess2 As New Process()
        Dim oStartInfo2 As New ProcessStartInfo("adb/" & My.Settings.adb & "/adb.exe", "shell monkey -p com.xiaomi.smarthome -c android.intent.category.LAUNCHER 1")
        oStartInfo2.UseShellExecute = False
        oStartInfo2.CreateNoWindow = True
        oProcess2.StartInfo = oStartInfo2
        oProcess2.Start()
        oProcess2.WaitForExit()
        If doBackup() < 20000000 Then
            Dim strBackupError As String
            If My.Settings.language = "de" Then
                strBackupError = "Es scheint ein Fehler aufgetreten zu sein, das Backup ist viel zu klein."
            ElseIf My.Settings.language = "en" Then
                strBackupError = "There seems to be an error with the backup, it is way too small."
            End If
            MsgBox(strBackupError)
        Else
            Dim strBackupExtract As String
            If My.Settings.language = "de" Then
                strBackupExtract = "Backup erfolgreich, wird jetzt entpackt."
            ElseIf My.Settings.language = "en" Then
                strBackupExtract = "Backup successful, starting extraction."
            End If
            MsgBox(strBackupExtract)
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
                tbToken.AppendText(SQLreader(2) & " - " & SQLreader(0) & " - " & SQLreader(1) & vbCrLf)
            End While
            command.Dispose()
            connect.Close()
        End If
    End Sub
End Class