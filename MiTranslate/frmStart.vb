Imports System.Globalization
Imports System.Threading

Public Class frmStart
    Public Sub New()
        'Sprache setzen
        Thread.CurrentThread.CurrentUICulture = New CultureInfo(My.Settings.language)
        'Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
    End Sub
    Private Sub DeutschToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeutschToolStripMenuItem.Click
        My.Settings.language = "de"
        System.Windows.Forms.Application.Restart()
    End Sub

    Private Sub EnglischToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnglischToolStripMenuItem.Click
        My.Settings.language = "en"
        System.Windows.Forms.Application.Restart()
    End Sub

    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sprachflagge richtig setzen
        If My.Settings.language = "de" Then
            btnLanguage.Image = Global.MiToolkit.My.Resources.Resources.DE
        ElseIf My.Settings.language = "en" Then
            btnLanguage.Image = Global.MiToolkit.My.Resources.Resources.US
        End If

        'ADB Version setzen
        If My.Settings.adb = 32 Then
            lblADB32.Text = "32 ✔"
        ElseIf My.Settings.adb = 36 Then
            lblADB36.Text = "36 ✔"
        ElseIf My.Settings.adb = 39 Then
            lblADB39.Text = "39 ✔"
        End If
    End Sub

    Private Sub cmdTranslation_Click(sender As Object, e As EventArgs) Handles cmdTranslation.Click
        Me.Enabled = False
        frmTranslation.Show()
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles lblContributors.Click
        MsgBox("Der größte Dank geht an Henne78 für seine Übersetzungsarbeit!" & vbCrLf &
               "Danke an SlaveofPain für sein Batch-Übersetzungstool!" & vbCrLf &
               "Programmiert von blacksn0w.")
    End Sub

    Private Sub lblADB32_Click(sender As Object, e As EventArgs) Handles lblADB32.Click
        lblADB32.Text = "32 ✔"
        lblADB36.Text = "36"
        lblADB39.Text = "39"
        My.Settings.adb = 32
    End Sub

    Private Sub lblADB36_Click(sender As Object, e As EventArgs) Handles lblADB36.Click
        lblADB32.Text = "32"
        lblADB36.Text = "36 ✔"
        lblADB39.Text = "39"
        My.Settings.adb = 36
    End Sub

    Private Sub lblADB39_Click(sender As Object, e As EventArgs) Handles lblADB39.Click
        lblADB32.Text = "32"
        lblADB36.Text = "36"
        lblADB39.Text = "39 ✔"
        My.Settings.adb = 39
    End Sub

    Private Sub cmdToken_Click(sender As Object, e As EventArgs) Handles cmdToken.Click
        'Mi Home App starten
        Dim oProcess2 As New Process()
        Dim oStartInfo2 As New ProcessStartInfo("adb/" & My.Settings.adb & "/adb.exe", "shell monkey -p com.xiaomi.smarthome -c android.intent.category.LAUNCHER 1")
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
End Class
