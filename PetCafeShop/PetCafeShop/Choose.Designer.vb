<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Choose
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
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnSell = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStaff
        '
        Me.btnStaff.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaff.Location = New System.Drawing.Point(316, 59)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(250, 54)
        Me.btnStaff.TabIndex = 2
        Me.btnStaff.Text = "Staff Form"
        Me.btnStaff.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRight.Location = New System.Drawing.Point(60, 119)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(250, 54)
        Me.btnRight.TabIndex = 3
        Me.btnRight.Text = "Right Management"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnSell
        '
        Me.btnSell.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSell.Location = New System.Drawing.Point(60, 59)
        Me.btnSell.Name = "btnSell"
        Me.btnSell.Size = New System.Drawing.Size(250, 54)
        Me.btnSell.TabIndex = 1
        Me.btnSell.Text = "Sell Form"
        Me.btnSell.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(316, 179)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(250, 54)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.btnReport)
        Me.GroupBox1.Controls.Add(Me.btnBackup)
        Me.GroupBox1.Controls.Add(Me.btnStaff)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnRight)
        Me.GroupBox1.Controls.Add(Me.btnSell)
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(43, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(637, 251)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ITEAM-CHOOSE"
        '
        'btnReport
        '
        Me.btnReport.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Location = New System.Drawing.Point(316, 119)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(250, 54)
        Me.btnReport.TabIndex = 4
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnBackup
        '
        Me.btnBackup.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.Location = New System.Drawing.Point(60, 178)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(250, 54)
        Me.btnBackup.TabIndex = 5
        Me.btnBackup.Text = "BackUp"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(226, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(305, 50)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Pet Cafe Shop"
        '
        'Choose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 368)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Choose"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStaff As System.Windows.Forms.Button
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents btnSell As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents btnReport As System.Windows.Forms.Button
End Class
