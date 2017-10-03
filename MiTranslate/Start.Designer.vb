<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTranslation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTranslation))
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
        Me.cmdCheckJava = New System.Windows.Forms.Button()
        Me.lblDevice = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDeviceAndroid = New System.Windows.Forms.TextBox()
        Me.txtDeviceAPI = New System.Windows.Forms.TextBox()
        Me.fdbJava = New System.Windows.Forms.FolderBrowserDialog()
        Me.pbSchloss = New System.Windows.Forms.PictureBox()
        CType(Me.pbSchloss, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCheckConnection
        '
        resources.ApplyResources(Me.cmdCheckConnection, "cmdCheckConnection")
        Me.cmdCheckConnection.Name = "cmdCheckConnection"
        Me.cmdCheckConnection.UseVisualStyleBackColor = True
        '
        'txtDeviceModel
        '
        resources.ApplyResources(Me.txtDeviceModel, "txtDeviceModel")
        Me.txtDeviceModel.Name = "txtDeviceModel"
        '
        'lblIntroduction
        '
        resources.ApplyResources(Me.lblIntroduction, "lblIntroduction")
        Me.lblIntroduction.BackColor = System.Drawing.Color.Transparent
        Me.lblIntroduction.Name = "lblIntroduction"
        '
        'cmdGetVersions
        '
        resources.ApplyResources(Me.cmdGetVersions, "cmdGetVersions")
        Me.cmdGetVersions.Name = "cmdGetVersions"
        Me.cmdGetVersions.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'txtMiHome
        '
        resources.ApplyResources(Me.txtMiHome, "txtMiHome")
        Me.txtMiHome.Name = "txtMiHome"
        '
        'txtErweiterung
        '
        resources.ApplyResources(Me.txtErweiterung, "txtErweiterung")
        Me.txtErweiterung.Name = "txtErweiterung"
        '
        'pbHome
        '
        resources.ApplyResources(Me.pbHome, "pbHome")
        Me.pbHome.Name = "pbHome"
        '
        'pbErweiterung
        '
        resources.ApplyResources(Me.pbErweiterung, "pbErweiterung")
        Me.pbErweiterung.Name = "pbErweiterung"
        '
        'lblHomeExists
        '
        resources.ApplyResources(Me.lblHomeExists, "lblHomeExists")
        Me.lblHomeExists.Name = "lblHomeExists"
        '
        'lblErweiterungExists
        '
        resources.ApplyResources(Me.lblErweiterungExists, "lblErweiterungExists")
        Me.lblErweiterungExists.Name = "lblErweiterungExists"
        '
        'cmdInstallMiHome
        '
        resources.ApplyResources(Me.cmdInstallMiHome, "cmdInstallMiHome")
        Me.cmdInstallMiHome.Name = "cmdInstallMiHome"
        Me.cmdInstallMiHome.UseVisualStyleBackColor = True
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'cmdSicherung
        '
        resources.ApplyResources(Me.cmdSicherung, "cmdSicherung")
        Me.cmdSicherung.Name = "cmdSicherung"
        Me.cmdSicherung.UseVisualStyleBackColor = True
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'cmdExtract
        '
        resources.ApplyResources(Me.cmdExtract, "cmdExtract")
        Me.cmdExtract.Name = "cmdExtract"
        Me.cmdExtract.UseVisualStyleBackColor = True
        '
        'cmdCopyTranslation
        '
        resources.ApplyResources(Me.cmdCopyTranslation, "cmdCopyTranslation")
        Me.cmdCopyTranslation.Name = "cmdCopyTranslation"
        Me.cmdCopyTranslation.UseVisualStyleBackColor = True
        '
        'cmdRestore
        '
        resources.ApplyResources(Me.cmdRestore, "cmdRestore")
        Me.cmdRestore.Name = "cmdRestore"
        Me.cmdRestore.UseVisualStyleBackColor = True
        '
        'cmdForceNext
        '
        resources.ApplyResources(Me.cmdForceNext, "cmdForceNext")
        Me.cmdForceNext.Name = "cmdForceNext"
        Me.cmdForceNext.UseVisualStyleBackColor = True
        '
        'cmdDebug
        '
        resources.ApplyResources(Me.cmdDebug, "cmdDebug")
        Me.cmdDebug.Name = "cmdDebug"
        Me.cmdDebug.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        resources.ApplyResources(Me.LinkLabel1, "LinkLabel1")
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.TabStop = True
        '
        'cmdCheckJava
        '
        resources.ApplyResources(Me.cmdCheckJava, "cmdCheckJava")
        Me.cmdCheckJava.Name = "cmdCheckJava"
        Me.cmdCheckJava.UseVisualStyleBackColor = True
        '
        'lblDevice
        '
        resources.ApplyResources(Me.lblDevice, "lblDevice")
        Me.lblDevice.Name = "lblDevice"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'txtDeviceAndroid
        '
        resources.ApplyResources(Me.txtDeviceAndroid, "txtDeviceAndroid")
        Me.txtDeviceAndroid.Name = "txtDeviceAndroid"
        '
        'txtDeviceAPI
        '
        resources.ApplyResources(Me.txtDeviceAPI, "txtDeviceAPI")
        Me.txtDeviceAPI.Name = "txtDeviceAPI"
        '
        'fdbJava
        '
        resources.ApplyResources(Me.fdbJava, "fdbJava")
        Me.fdbJava.ShowNewFolderButton = False
        '
        'pbSchloss
        '
        Me.pbSchloss.Image = Global.MiToolkit.My.Resources.Resources.schloss
        resources.ApplyResources(Me.pbSchloss, "pbSchloss")
        Me.pbSchloss.Name = "pbSchloss"
        Me.pbSchloss.TabStop = False
        '
        'frmTranslation
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtDeviceAPI)
        Me.Controls.Add(Me.txtDeviceAndroid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdCheckJava)
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
        Me.MaximizeBox = False
        Me.Name = "frmTranslation"
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
    Friend WithEvents cmdCheckJava As Button
    Friend WithEvents lblDevice As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDeviceAndroid As TextBox
    Friend WithEvents txtDeviceAPI As TextBox
    Friend WithEvents pbSchloss As PictureBox
    Friend WithEvents fdbJava As FolderBrowserDialog
End Class
