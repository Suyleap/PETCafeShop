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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gb.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb
        '
        Me.gb.Controls.Add(Me.btnClose)
        Me.gb.Controls.Add(Me.btnRestore)
        Me.gb.Controls.Add(Me.btnBackup)
        Me.gb.Location = New System.Drawing.Point(111, 75)
        Me.gb.Name = "gb"
        Me.gb.Size = New System.Drawing.Size(463, 257)
        Me.gb.TabIndex = 0
        Me.gb.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(66, 170)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(314, 59)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnRestore
        '
        Me.btnRestore.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRestore.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestore.Location = New System.Drawing.Point(66, 105)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(314, 59)
        Me.btnRestore.TabIndex = 1
        Me.btnRestore.Text = "Restore"
        Me.btnRestore.UseVisualStyleBackColor = False
        '
        'btnBackup
        '
        Me.btnBackup.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBackup.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.Location = New System.Drawing.Point(66, 40)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(314, 59)
        Me.btnBackup.TabIndex = 0
        Me.btnBackup.Text = "BackUp"
        Me.btnBackup.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(185, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 50)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Pet Cafe Shop"
        '
        'BackUpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 368)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gb)
        Me.Name = "BackUpForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gb.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gb As System.Windows.Forms.GroupBox
    Friend WithEvents btnRestore As System.Windows.Forms.Button
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
