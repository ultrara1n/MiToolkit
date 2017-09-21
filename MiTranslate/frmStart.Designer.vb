<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStart
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStart))
        Me.cmdTranslation = New System.Windows.Forms.Button()
        Me.cmdToken = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblContributors = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ADBVersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblADB32 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblADB36 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblADB39 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnLanguage = New System.Windows.Forms.ToolStripDropDownButton()
        Me.EnglischToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeutschToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdTranslation
        '
        resources.ApplyResources(Me.cmdTranslation, "cmdTranslation")
        Me.cmdTranslation.Name = "cmdTranslation"
        Me.cmdTranslation.UseVisualStyleBackColor = True
        '
        'cmdToken
        '
        resources.ApplyResources(Me.cmdToken, "cmdToken")
        Me.cmdToken.Name = "cmdToken"
        Me.cmdToken.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblContributors, Me.lblVersion, Me.ToolStripDropDownButton2, Me.btnLanguage})
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.SizingGrip = False
        '
        'lblContributors
        '
        Me.lblContributors.Name = "lblContributors"
        resources.ApplyResources(Me.lblContributors, "lblContributors")
        '
        'lblVersion
        '
        Me.lblVersion.Name = "lblVersion"
        resources.ApplyResources(Me.lblVersion, "lblVersion")
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADBVersionToolStripMenuItem})
        resources.ApplyResources(Me.ToolStripDropDownButton2, "ToolStripDropDownButton2")
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        '
        'ADBVersionToolStripMenuItem
        '
        Me.ADBVersionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblADB32, Me.lblADB36, Me.lblADB39})
        Me.ADBVersionToolStripMenuItem.Name = "ADBVersionToolStripMenuItem"
        resources.ApplyResources(Me.ADBVersionToolStripMenuItem, "ADBVersionToolStripMenuItem")
        '
        'lblADB32
        '
        Me.lblADB32.Name = "lblADB32"
        resources.ApplyResources(Me.lblADB32, "lblADB32")
        '
        'lblADB36
        '
        Me.lblADB36.Name = "lblADB36"
        resources.ApplyResources(Me.lblADB36, "lblADB36")
        '
        'lblADB39
        '
        Me.lblADB39.Name = "lblADB39"
        resources.ApplyResources(Me.lblADB39, "lblADB39")
        '
        'btnLanguage
        '
        Me.btnLanguage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnLanguage.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnglischToolStripMenuItem, Me.DeutschToolStripMenuItem})
        Me.btnLanguage.Image = Global.MiToolkit.My.Resources.Resources.DE
        resources.ApplyResources(Me.btnLanguage, "btnLanguage")
        Me.btnLanguage.Name = "btnLanguage"
        '
        'EnglischToolStripMenuItem
        '
        Me.EnglischToolStripMenuItem.Image = Global.MiToolkit.My.Resources.Resources.US
        Me.EnglischToolStripMenuItem.Name = "EnglischToolStripMenuItem"
        resources.ApplyResources(Me.EnglischToolStripMenuItem, "EnglischToolStripMenuItem")
        '
        'DeutschToolStripMenuItem
        '
        Me.DeutschToolStripMenuItem.Image = Global.MiToolkit.My.Resources.Resources.DE
        Me.DeutschToolStripMenuItem.Name = "DeutschToolStripMenuItem"
        resources.ApplyResources(Me.DeutschToolStripMenuItem, "DeutschToolStripMenuItem")
        '
        'frmStart
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.cmdToken)
        Me.Controls.Add(Me.cmdTranslation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmStart"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdTranslation As Button
    Friend WithEvents cmdToken As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblContributors As ToolStripStatusLabel
    Friend WithEvents lblVersion As ToolStripStatusLabel
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents btnLanguage As ToolStripDropDownButton
    Friend WithEvents EnglischToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeutschToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ADBVersionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblADB32 As ToolStripMenuItem
    Friend WithEvents lblADB36 As ToolStripMenuItem
    Friend WithEvents lblADB39 As ToolStripMenuItem
End Class
