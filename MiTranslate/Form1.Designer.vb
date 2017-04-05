<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cmdCheckConnection = New System.Windows.Forms.Button()
        Me.lblDevice = New System.Windows.Forms.Label()
        Me.txtDevice = New System.Windows.Forms.TextBox()
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
        Me.txtHomeVersion = New System.Windows.Forms.TextBox()
        Me.txtHomeMD5 = New System.Windows.Forms.TextBox()
        Me.txtErweiterungMD5 = New System.Windows.Forms.TextBox()
        Me.txtErweiterungVersion = New System.Windows.Forms.TextBox()
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmdCheckJava = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCheckConnection
        '
        Me.cmdCheckConnection.Location = New System.Drawing.Point(12, 85)
        Me.cmdCheckConnection.Name = "cmdCheckConnection"
        Me.cmdCheckConnection.Size = New System.Drawing.Size(123, 23)
        Me.cmdCheckConnection.TabIndex = 0
        Me.cmdCheckConnection.Text = "Verbindung prüfen"
        Me.cmdCheckConnection.UseVisualStyleBackColor = True
        '
        'lblDevice
        '
        Me.lblDevice.AutoSize = True
        Me.lblDevice.Location = New System.Drawing.Point(12, 124)
        Me.lblDevice.Name = "lblDevice"
        Me.lblDevice.Size = New System.Drawing.Size(102, 13)
        Me.lblDevice.TabIndex = 1
        Me.lblDevice.Text = "Verbundenes Gerät:"
        '
        'txtDevice
        '
        Me.txtDevice.Enabled = False
        Me.txtDevice.Location = New System.Drawing.Point(120, 121)
        Me.txtDevice.Name = "txtDevice"
        Me.txtDevice.Size = New System.Drawing.Size(133, 20)
        Me.txtDevice.TabIndex = 2
        '
        'lblIntroduction
        '
        Me.lblIntroduction.AutoSize = True
        Me.lblIntroduction.BackColor = System.Drawing.Color.Transparent
        Me.lblIntroduction.Location = New System.Drawing.Point(12, 9)
        Me.lblIntroduction.Name = "lblIntroduction"
        Me.lblIntroduction.Size = New System.Drawing.Size(250, 65)
        Me.lblIntroduction.TabIndex = 4
        Me.lblIntroduction.Text = "Stelle sicher das USB-Debugging aktiviert ist" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "und du alle nötigen Gerätetreiber " &
    "installiert hast." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Eine Anleitung wie der Debug Modus aktiviert wird, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "erhäls" &
    "t du"
        '
        'cmdGetVersions
        '
        Me.cmdGetVersions.Location = New System.Drawing.Point(12, 154)
        Me.cmdGetVersions.Name = "cmdGetVersions"
        Me.cmdGetVersions.Size = New System.Drawing.Size(147, 23)
        Me.cmdGetVersions.TabIndex = 5
        Me.cmdGetVersions.Text = "Aktuelle Versionen laden"
        Me.cmdGetVersions.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "MiHome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(162, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Vacuum Erweiterung"
        '
        'txtMiHome
        '
        Me.txtMiHome.Enabled = False
        Me.txtMiHome.Location = New System.Drawing.Point(12, 214)
        Me.txtMiHome.Name = "txtMiHome"
        Me.txtMiHome.Size = New System.Drawing.Size(123, 20)
        Me.txtMiHome.TabIndex = 8
        '
        'txtErweiterung
        '
        Me.txtErweiterung.Enabled = False
        Me.txtErweiterung.Location = New System.Drawing.Point(165, 214)
        Me.txtErweiterung.Name = "txtErweiterung"
        Me.txtErweiterung.Size = New System.Drawing.Size(123, 20)
        Me.txtErweiterung.TabIndex = 9
        '
        'pbHome
        '
        Me.pbHome.Location = New System.Drawing.Point(12, 240)
        Me.pbHome.Name = "pbHome"
        Me.pbHome.Size = New System.Drawing.Size(123, 23)
        Me.pbHome.TabIndex = 10
        Me.pbHome.Visible = False
        '
        'pbErweiterung
        '
        Me.pbErweiterung.Location = New System.Drawing.Point(165, 240)
        Me.pbErweiterung.Name = "pbErweiterung"
        Me.pbErweiterung.Size = New System.Drawing.Size(123, 23)
        Me.pbErweiterung.TabIndex = 11
        Me.pbErweiterung.Visible = False
        '
        'lblHomeExists
        '
        Me.lblHomeExists.AutoSize = True
        Me.lblHomeExists.Location = New System.Drawing.Point(9, 240)
        Me.lblHomeExists.Name = "lblHomeExists"
        Me.lblHomeExists.Size = New System.Drawing.Size(119, 13)
        Me.lblHomeExists.TabIndex = 12
        Me.lblHomeExists.Text = "Bereits heruntergeladen"
        Me.lblHomeExists.Visible = False
        '
        'lblErweiterungExists
        '
        Me.lblErweiterungExists.AutoSize = True
        Me.lblErweiterungExists.Location = New System.Drawing.Point(162, 240)
        Me.lblErweiterungExists.Name = "lblErweiterungExists"
        Me.lblErweiterungExists.Size = New System.Drawing.Size(119, 13)
        Me.lblErweiterungExists.TabIndex = 13
        Me.lblErweiterungExists.Text = "Bereits heruntergeladen"
        Me.lblErweiterungExists.Visible = False
        '
        'txtHomeVersion
        '
        Me.txtHomeVersion.Location = New System.Drawing.Point(168, 154)
        Me.txtHomeVersion.Name = "txtHomeVersion"
        Me.txtHomeVersion.Size = New System.Drawing.Size(23, 20)
        Me.txtHomeVersion.TabIndex = 14
        Me.txtHomeVersion.Visible = False
        '
        'txtHomeMD5
        '
        Me.txtHomeMD5.Location = New System.Drawing.Point(197, 154)
        Me.txtHomeMD5.Name = "txtHomeMD5"
        Me.txtHomeMD5.Size = New System.Drawing.Size(23, 20)
        Me.txtHomeMD5.TabIndex = 16
        Me.txtHomeMD5.Visible = False
        '
        'txtErweiterungMD5
        '
        Me.txtErweiterungMD5.Location = New System.Drawing.Point(273, 154)
        Me.txtErweiterungMD5.Name = "txtErweiterungMD5"
        Me.txtErweiterungMD5.Size = New System.Drawing.Size(23, 20)
        Me.txtErweiterungMD5.TabIndex = 18
        Me.txtErweiterungMD5.Visible = False
        '
        'txtErweiterungVersion
        '
        Me.txtErweiterungVersion.Location = New System.Drawing.Point(244, 154)
        Me.txtErweiterungVersion.Name = "txtErweiterungVersion"
        Me.txtErweiterungVersion.Size = New System.Drawing.Size(23, 20)
        Me.txtErweiterungVersion.TabIndex = 17
        Me.txtErweiterungVersion.Visible = False
        '
        'cmdInstallMiHome
        '
        Me.cmdInstallMiHome.Location = New System.Drawing.Point(12, 274)
        Me.cmdInstallMiHome.Name = "cmdInstallMiHome"
        Me.cmdInstallMiHome.Size = New System.Drawing.Size(147, 23)
        Me.cmdInstallMiHome.TabIndex = 19
        Me.cmdInstallMiHome.Text = "MiHome App installieren"
        Me.cmdInstallMiHome.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 311)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(293, 39)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Nach erfolgreicher Installation wird sich MiHome automatisch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "öffnen. Bitte einma" &
    "l den Roboter öffnen um das aktuelle " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Plugin zu laden. "
        '
        'cmdSicherung
        '
        Me.cmdSicherung.Location = New System.Drawing.Point(12, 359)
        Me.cmdSicherung.Name = "cmdSicherung"
        Me.cmdSicherung.Size = New System.Drawing.Size(131, 23)
        Me.cmdSicherung.TabIndex = 21
        Me.cmdSicherung.Text = "Sicherung durchführen"
        Me.cmdSicherung.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 395)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(300, 39)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Die Sicherung scheint erfolgreich gewesen zu sein, jetzt kann " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "diese entsprechen" &
    "d modifiziert und wieder zurück geladen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "werden"
        '
        'cmdExtract
        '
        Me.cmdExtract.Location = New System.Drawing.Point(57, 444)
        Me.cmdExtract.Name = "cmdExtract"
        Me.cmdExtract.Size = New System.Drawing.Size(205, 23)
        Me.cmdExtract.TabIndex = 23
        Me.cmdExtract.Text = "Sicherung extrahieren"
        Me.cmdExtract.UseVisualStyleBackColor = True
        '
        'cmdCopyTranslation
        '
        Me.cmdCopyTranslation.Location = New System.Drawing.Point(57, 478)
        Me.cmdCopyTranslation.Name = "cmdCopyTranslation"
        Me.cmdCopyTranslation.Size = New System.Drawing.Size(205, 23)
        Me.cmdCopyTranslation.TabIndex = 24
        Me.cmdCopyTranslation.Text = "Übersetzung kopieren und verpacken"
        Me.cmdCopyTranslation.UseVisualStyleBackColor = True
        '
        'cmdRestore
        '
        Me.cmdRestore.Location = New System.Drawing.Point(57, 512)
        Me.cmdRestore.Name = "cmdRestore"
        Me.cmdRestore.Size = New System.Drawing.Size(205, 23)
        Me.cmdRestore.TabIndex = 25
        Me.cmdRestore.Text = "Backup zurückspielen"
        Me.cmdRestore.UseVisualStyleBackColor = True
        '
        'cmdForceNext
        '
        Me.cmdForceNext.Location = New System.Drawing.Point(165, 274)
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
        Me.LinkLabel1.Location = New System.Drawing.Point(61, 61)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(24, 13)
        Me.LinkLabel1.TabIndex = 28
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "hier"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 544)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(308, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 29
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(73, 17)
        Me.ToolStripStatusLabel1.Text = "Mitwirkende"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(28, 17)
        Me.ToolStripStatusLabel2.Text = "v1.1"
        '
        'cmdCheckJava
        '
        Me.cmdCheckJava.Location = New System.Drawing.Point(178, 85)
        Me.cmdCheckJava.Name = "cmdCheckJava"
        Me.cmdCheckJava.Size = New System.Drawing.Size(75, 23)
        Me.cmdCheckJava.TabIndex = 30
        Me.cmdCheckJava.Text = "Java prüfen"
        Me.cmdCheckJava.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 566)
        Me.Controls.Add(Me.cmdCheckJava)
        Me.Controls.Add(Me.StatusStrip1)
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
        Me.Controls.Add(Me.txtErweiterungMD5)
        Me.Controls.Add(Me.txtErweiterungVersion)
        Me.Controls.Add(Me.txtHomeMD5)
        Me.Controls.Add(Me.txtHomeVersion)
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
        Me.Controls.Add(Me.txtDevice)
        Me.Controls.Add(Me.lblDevice)
        Me.Controls.Add(Me.cmdCheckConnection)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "MiToolkit"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdCheckConnection As Button
    Friend WithEvents lblDevice As Label
    Friend WithEvents txtDevice As TextBox
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
    Friend WithEvents txtHomeVersion As TextBox
    Friend WithEvents txtHomeMD5 As TextBox
    Friend WithEvents txtErweiterungMD5 As TextBox
    Friend WithEvents txtErweiterungVersion As TextBox
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
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents cmdCheckJava As Button
End Class
