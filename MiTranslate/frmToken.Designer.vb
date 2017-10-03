<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmToken
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmToken))
        Me.cmdGetToken = New System.Windows.Forms.Button()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.tbToken = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdGetToken
        '
        Me.cmdGetToken.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetToken.Location = New System.Drawing.Point(112, 215)
        Me.cmdGetToken.Name = "cmdGetToken"
        Me.cmdGetToken.Size = New System.Drawing.Size(189, 35)
        Me.cmdGetToken.TabIndex = 0
        Me.cmdGetToken.Text = "Token auslesen"
        Me.cmdGetToken.UseVisualStyleBackColor = True
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(12, 9)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(380, 182)
        Me.lblDescription.TabIndex = 1
        Me.lblDescription.Text = resources.GetString("lblDescription.Text")
        '
        'tbToken
        '
        Me.tbToken.Location = New System.Drawing.Point(12, 267)
        Me.tbToken.Multiline = True
        Me.tbToken.Name = "tbToken"
        Me.tbToken.Size = New System.Drawing.Size(436, 169)
        Me.tbToken.TabIndex = 2
        '
        'frmToken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 453)
        Me.Controls.Add(Me.tbToken)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.cmdGetToken)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmToken"
        Me.Text = "MiToolkit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdGetToken As Button
    Friend WithEvents lblDescription As Label
    Friend WithEvents tbToken As TextBox
End Class
