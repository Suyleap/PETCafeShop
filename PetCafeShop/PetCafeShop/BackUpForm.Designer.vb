<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackUpForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gb = New System.Windows.Forms.GroupBox()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.gb.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb
        '
        Me.gb.Controls.Add(Me.btnRestore)
        Me.gb.Controls.Add(Me.btnBackup)
        Me.gb.Location = New System.Drawing.Point(62, 39)
        Me.gb.Name = "gb"
        Me.gb.Size = New System.Drawing.Size(310, 178)
        Me.gb.TabIndex = 0
        Me.gb.TabStop = False
        Me.gb.Text = "Activity"
        '
        'btnBackup
        '
        Me.btnBackup.Location = New System.Drawing.Point(66, 40)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(182, 43)
        Me.btnBackup.TabIndex = 0
        Me.btnBackup.Text = "BackUp"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'btnRestore
        '
        Me.btnRestore.Location = New System.Drawing.Point(66, 89)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(182, 43)
        Me.btnRestore.TabIndex = 1
        Me.btnRestore.Text = "Restore"
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'BackUpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 253)
        Me.Controls.Add(Me.gb)
        Me.Name = "BackUpForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BackUpForm"
        Me.gb.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb As System.Windows.Forms.GroupBox
    Friend WithEvents btnRestore As System.Windows.Forms.Button
    Friend WithEvents btnBackup As System.Windows.Forms.Button
End Class
