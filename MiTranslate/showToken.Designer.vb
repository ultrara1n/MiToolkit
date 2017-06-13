<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class showToken
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbToken = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'tbToken
        '
        Me.tbToken.Location = New System.Drawing.Point(12, 10)
        Me.tbToken.Name = "tbToken"
        Me.tbToken.Size = New System.Drawing.Size(450, 155)
        Me.tbToken.TabIndex = 0
        Me.tbToken.Text = ""
        '
        'showToken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 177)
        Me.Controls.Add(Me.tbToken)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "showToken"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Token"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbToken As RichTextBox
End Class
