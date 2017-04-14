<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Start
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Start))
        Me.cmdCheckConnection = New System.Windows.Forms.Button()
        Me.txtDeviceModel = New System.Windows.Forms.TextBox()
        Me.lblIntroduction = New System.Windows.Forms.Label()
        Me.cmdGetVersions = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMiHome = New System.Windows.Forms.TextBox()
        Me.txtErweiterung = New System.Windows.Forms.TextBox()
        Me.pbHome = New System.Windows.Forms.ProgressBar()
        Me.pbErweiterung = New System.Windows.Forms.ProgressBar()
        Me.lblHomeExists = New System.Windows.Forms.Label()
        Me.lblErweiterungExists = New System.Windows.Forms.Label()
        Me.cmdInstallMiHome = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdSicherung = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdExtract = New System.Windows.Forms.Button()
        Me.cmdCopyTranslation = New System.Windows.Forms.Button()
        Me.cmdRestore = New System.Windows.Forms.Button()
        Me.cmdForceNext = New System.Windows.Forms.Button()
        Me.cmdDebug = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ssFooter = New System.Windows.Forms.StatusStrip()
        Me.lblMitwirkende = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmdCheckJava = New System.Windows.Forms.Button()
        Me.lblDevice = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDeviceAndroid = New System.Windows.Forms.TextBox()
        Me.txtDeviceAPI = New System.Windows.Forms.TextBox()
        Me.pbSchloss = New System.Windows.Forms.PictureBox()
        Me.fdbJava = New System.Windows.Forms.FolderBrowserDialog()
        Me.ssFooter.SuspendLayout()
        CType(Me.pbSchloss, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCheckConnection
        '
        Me.cmdCheckConnection.Location = New System.Drawing.Point(12, 83)
        Me.cmdCheckConnection.Name = "cmdCheckConnection"
        Me.cmdCheckConnection.Size = New System.Drawing.Size(123, 23)
        Me.cmdCheckConnection.TabIndex = 0
        Me.cmdCheckConnection.Text = "Verbindung prüfen"
        Me.cmdCheckConnection.UseVisualStyleBackColor = True
        '
        'txtDeviceModel
        '
        Me.txtDeviceModel.Enabled = False
        Me.txtDeviceModel.Location = New System.Drawing.Point(75, 112)
        Me.txtDeviceModel.Name = "txtDeviceModel"
        Me.txtDeviceModel.Size = New System.Drawing.Size(133, 20)
        Me.txtDeviceModel.TabIndex = 2
        '
        'lblIntroduction
        '
        Me.lblIntroduction.AutoSize = True
        Me.lblIntroduction.BackColor = System.Drawing.Color.Transparent
        Me.lblIntroduction.Location = New System.Drawing.Point(12, 9)
        Me.lblIntroduction.Name = "lblIntroduction"
        Me.lblIntroduction.Size = New System.Drawing.Size(230, 65)
        Me.lblIntroduction.TabIndex = 4
        Me.lblIntroduction.Text = "Stelle sicher, dass USB-Debugging aktiviert ist" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "und du alle nötigen Gerätetreibe" &
    "r installiert hast." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Eine Video-Anleitung zum Aktivieren von" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "USB-Debugging gi" &
    "bt es"
        '
        'cmdGetVersions
        '
        Me.cmdGetVersions.Location = New System.Drawing.Point(12, 195)
        Me.cmdGetVersions.Name = "cmdGetVersions"
        Me.cmdGetVersions.Size = New System.Drawing.Size(147, 23)
        Me.cmdGetVersions.TabIndex = 5
        Me.cmdGetVersions.Text = "Aktuelle Versionen laden"
        Me.cmdGetVersions.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "MiHome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(162, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Vacuum Erweiterung"
        '
        'txtMiHome
        '
        Me.txtMiHome.Enabled = False
        Me.txtMiHome.Location = New System.Drawing.Point(12, 241)
        Me.txtMiHome.Name = "txtMiHome"
        Me.txtMiHome.Size = New System.Drawing.Size(123, 20)
        Me.txtMiHome.TabIndex = 8
        '
        'txtErweiterung
        '
        Me.txtErweiterung.Enabled = False
        Me.txtErweiterung.Location = New System.Drawing.Point(165, 241)
        Me.txtErweiterung.Name = "txtErweiterung"
        Me.txtErweiterung.Size = New System.Drawing.Size(123, 20)
        Me.txtErweiterung.TabIndex = 9
        '
        'pbHome
        '
        Me.pbHome.Location = New System.Drawing.Point(12, 267)
        Me.pbHome.Name = "pbHome"
        Me.pbHome.Size = New System.Drawing.Size(123, 23)
        Me.pbHome.TabIndex = 10
        Me.pbHome.Visible = False
        '
        'pbErweiterung
        '
        Me.pbErweiterung.Location = New System.Drawing.Point(165, 267)
        Me.pbErweiterung.Name = "pbErweiterung"
        Me.pbErweiterung.Size = New System.Drawing.Size(123, 23)
        Me.pbErweiterung.TabIndex = 11
        Me.pbErweiterung.Visible = False
        '
        'lblHomeExists
        '
        Me.lblHomeExists.AutoSize = True
        Me.lblHomeExists.Location = New System.Drawing.Point(9, 267)
        Me.lblHomeExists.Name = "lblHomeExists"
        Me.lblHomeExists.Size = New System.Drawing.Size(119, 13)
        Me.lblHomeExists.TabIndex = 12
        Me.lblHomeExists.Text = "Bereits heruntergeladen"
        Me.lblHomeExists.Visible = False
        '
        'lblErweiterungExists
        '
        Me.lblErweiterungExists.AutoSize = True
        Me.lblErweiterungExists.Location = New System.Drawing.Point(162, 267)
        Me.lblErweiterungExists.Name = "lblErweiterungExists"
        Me.lblErweiterungExists.Size = New System.Drawing.Size(119, 13)
        Me.lblErweiterungExists.TabIndex = 13
        Me.lblErweiterungExists.Text = "Bereits heruntergeladen"
        Me.lblErweiterungExists.Visible = False
        '
        'cmdInstallMiHome
        '
        Me.cmdInstallMiHome.Location = New System.Drawing.Point(12, 301)
        Me.cmdInstallMiHome.Name = "cmdInstallMiHome"
        Me.cmdInstallMiHome.Size = New System.Drawing.Size(147, 23)
        Me.cmdInstallMiHome.TabIndex = 19
        Me.cmdInstallMiHome.Text = "MiHome App installieren"
        Me.cmdInstallMiHome.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(298, 39)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Nach erfolgreicher Installation wird sich MiHome automatisch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "öffnen. Den Roboter" &
    " öffnen um das aktuelle Plugin zu laden.  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MiHome sollte für die Sicherung offe" &
    "n sein!"
        '
        'cmdSicherung
        '
        Me.cmdSicherung.Location = New System.Drawing.Point(12, 386)
        Me.cmdSicherung.Name = "cmdSicherung"
        Me.cmdSicherung.Size = New System.Drawing.Size(131, 23)
        Me.cmdSicherung.TabIndex = 21
        Me.cmdSicherung.Text = "Sicherung durchführen"
        Me.cmdSicherung.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 422)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(300, 39)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Die Sicherung scheint erfolgreich gewesen zu sein, jetzt kann " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "diese entsprechen" &
    "d modifiziert und wieder zurück geladen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "werden"
        '
        'cmdExtract
        '
        Me.cmdExtract.Location = New System.Drawing.Point(57, 471)
        Me.cmdExtract.Name = "cmdExtract"
        Me.cmdExtract.Size = New System.Drawing.Size(205, 23)
        Me.cmdExtract.TabIndex = 23
        Me.cmdExtract.Text = "Sicherung extrahieren"
        Me.cmdExtract.UseVisualStyleBackColor = True
        '
        'cmdCopyTranslation
        '
        Me.cmdCopyTranslation.Location = New System.Drawing.Point(57, 505)
        Me.cmdCopyTranslation.Name = "cmdCopyTranslation"
        Me.cmdCopyTranslation.Size = New System.Drawing.Size(205, 23)
        Me.cmdCopyTranslation.TabIndex = 24
        Me.cmdCopyTranslation.Text = "Übersetzung kopieren und verpacken"
        Me.cmdCopyTranslation.UseVisualStyleBackColor = True
        '
        'cmdRestore
        '
        Me.cmdRestore.Location = New System.Drawing.Point(57, 539)
        Me.cmdRestore.Name = "cmdRestore"
        Me.cmdRestore.Size = New System.Drawing.Size(205, 23)
        Me.cmdRestore.TabIndex = 25
        Me.cmdRestore.Text = "Backup zurückspielen"
        Me.cmdRestore.UseVisualStyleBackColor = True
        '
        'cmdForceNext
        '
        Me.cmdForceNext.Location = New System.Drawing.Point(165, 301)
        Me.cmdForceNext.Name = "cmdForceNext"
        Me.cmdForceNext.Size = New System.Drawing.Size(123, 23)
        Me.cmdForceNext.TabIndex = 26
        Me.cmdForceNext.Text = "Überspringen"
        Me.cmdForceNext.UseVisualStyleBackColor = True
        Me.cmdForceNext.Visible = False
        '
        'cmdDebug
        '
        Me.cmdDebug.Location = New System.Drawing.Point(250, 4)
        Me.cmdDebug.Name = "cmdDebug"
        Me.cmdDebug.Size = New System.Drawing.Size(52, 23)
        Me.cmdDebug.TabIndex = 27
        Me.cmdDebug.Text = "Debug"
        Me.cmdDebug.UseVisualStyleBackColor = True
        Me.cmdDebug.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(127, 61)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(24, 13)
        Me.LinkLabel1.TabIndex = 28
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "hier"
        '
        'ssFooter
        '
        Me.ssFooter.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblMitwirkende, Me.lblVersion})
        Me.ssFooter.Location = New System.Drawing.Point(0, 570)
        Me.ssFooter.Name = "ssFooter"
        Me.ssFooter.Size = New System.Drawing.Size(308, 22)
        Me.ssFooter.SizingGrip = False
        Me.ssFooter.TabIndex = 29
        Me.ssFooter.Text = "StatusStrip1"
        '
        'lblMitwirkende
        '
        Me.lblMitwirkende.Name = "lblMitwirkende"
        Me.lblMitwirkende.Size = New System.Drawing.Size(73, 17)
        Me.lblMitwirkende.Text = "Mitwirkende"
        '
        'lblVersion
        '
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(37, 17)
        Me.lblVersion.Text = "v1.3.3"
        '
        'cmdCheckJava
        '
        Me.cmdCheckJava.Location = New System.Drawing.Point(178, 83)
        Me.cmdCheckJava.Name = "cmdCheckJava"
        Me.cmdCheckJava.Size = New System.Drawing.Size(124, 23)
        Me.cmdCheckJava.TabIndex = 30
        Me.cmdCheckJava.Text = "Java Installation prüfen"
        Me.cmdCheckJava.UseVisualStyleBackColor = True
        '
        'lblDevice
        '
        Me.lblDevice.AutoSize = True
        Me.lblDevice.Location = New System.Drawing.Point(12, 119)
        Me.lblDevice.Name = "lblDevice"
        Me.lblDevice.Size = New System.Drawing.Size(39, 13)
        Me.lblDevice.TabIndex = 1
        Me.lblDevice.Text = "Model:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Android:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "API Level:"
        '
        'txtDeviceAndroid
        '
        Me.txtDeviceAndroid.Enabled = False
        Me.txtDeviceAndroid.Location = New System.Drawing.Point(75, 138)
        Me.txtDeviceAndroid.Name = "txtDeviceAndroid"
        Me.txtDeviceAndroid.Size = New System.Drawing.Size(133, 20)
        Me.txtDeviceAndroid.TabIndex = 33
        '
        'txtDeviceAPI
        '
        Me.txtDeviceAPI.Enabled = False
        Me.txtDeviceAPI.Location = New System.Drawing.Point(75, 168)
        Me.txtDeviceAPI.Name = "txtDeviceAPI"
        Me.txtDeviceAPI.Size = New System.Drawing.Size(133, 20)
        Me.txtDeviceAPI.TabIndex = 34
        '
        'pbSchloss
        '
        Me.pbSchloss.Image = Global.MiToolkit.My.Resources.Resources.schloss
        Me.pbSchloss.Location = New System.Drawing.Point(214, 112)
        Me.pbSchloss.Name = "pbSchloss"
        Me.pbSchloss.Size = New System.Drawing.Size(82, 77)
        Me.pbSchloss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSchloss.TabIndex = 35
        Me.pbSchloss.TabStop = False
        Me.pbSchloss.Visible = False
        '
        'fdbJava
        '
        Me.fdbJava.Description = "Bitte den Ordner der JRE auswählen, dieser befindet sich in deinem Java Ordner (b" &
    "spw. C:\Programme\Java\jre1.8.0_121)"
        Me.fdbJava.ShowNewFolderButton = False
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 592)
        Me.Controls.Add(Me.txtDeviceAPI)
        Me.Controls.Add(Me.txtDeviceAndroid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdCheckJava)
        Me.Controls.Add(Me.ssFooter)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.cmdDebug)
        Me.Controls.Add(Me.cmdForceNext)
        Me.Controls.Add(Me.cmdRestore)
        Me.Controls.Add(Me.cmdCopyTranslation)
        Me.Controls.Add(Me.cmdExtract)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdSicherung)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdInstallMiHome)
        Me.Controls.Add(Me.lblErweiterungExists)
        Me.Controls.Add(Me.lblHomeExists)
        Me.Controls.Add(Me.pbErweiterung)
        Me.Controls.Add(Me.pbHome)
        Me.Controls.Add(Me.txtErweiterung)
        Me.Controls.Add(Me.txtMiHome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdGetVersions)
        Me.Controls.Add(Me.lblIntroduction)
        Me.Controls.Add(Me.txtDeviceModel)
        Me.Controls.Add(Me.lblDevice)
        Me.Controls.Add(Me.cmdCheckConnection)
        Me.Controls.Add(Me.pbSchloss)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Start"
        Me.Text = "MiToolkit"
        Me.ssFooter.ResumeLayout(False)
        Me.ssFooter.PerformLayout()
        CType(Me.pbSchloss, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdCheckConnection As Button
    Friend WithEvents txtDeviceModel As TextBox
    Friend WithEvents lblIntroduction As Label
    Friend WithEvents cmdGetVersions As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMiHome As TextBox
    Friend WithEvents txtErweiterung As TextBox
    Friend WithEvents pbHome As ProgressBar
    Friend WithEvents pbErweiterung As ProgressBar
    Friend WithEvents lblHomeExists As Label
    Friend WithEvents lblErweiterungExists As Label
    Friend WithEvents cmdInstallMiHome As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdSicherung As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdExtract As Button
    Friend WithEvents cmdCopyTranslation As Button
    Friend WithEvents cmdRestore As Button
    Friend WithEvents cmdForceNext As Button
    Friend WithEvents cmdDebug As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents ssFooter As StatusStrip
    Friend WithEvents lblMitwirkende As ToolStripStatusLabel
    Friend WithEvents lblVersion As ToolStripStatusLabel
    Friend WithEvents cmdCheckJava As Button
    Friend WithEvents lblDevice As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDeviceAndroid As TextBox
    Friend WithEvents txtDeviceAPI As TextBox
    Friend WithEvents pbSchloss As PictureBox
    Friend WithEvents fdbJava As FolderBrowserDialog
End Class
