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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSell = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStaff
        '
        Me.btnStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaff.Location = New System.Drawing.Point(12, 128)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(207, 85)
        Me.btnStaff.TabIndex = 0
        Me.btnStaff.Text = "Staff Form"
        Me.btnStaff.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRight.Location = New System.Drawing.Point(515, 128)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(207, 85)
        Me.btnRight.TabIndex = 1
        Me.btnRight.Text = "Right Management"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(230, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 46)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "<- CHOOSE ->"
        '
        'btnSell
        '
        Me.btnSell.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSell.Location = New System.Drawing.Point(268, 128)
        Me.btnSell.Name = "btnSell"
        Me.btnSell.Size = New System.Drawing.Size(207, 85)
        Me.btnSell.TabIndex = 3
        Me.btnSell.Text = "Sell Form"
        Me.btnSell.UseVisualStyleBackColor = True
        '
        'Choose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 268)
        Me.Controls.Add(Me.btnSell)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnStaff)
        Me.Name = "Choose"
        Me.Text = "Choose"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStaff As System.Windows.Forms.Button
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSell As System.Windows.Forms.Button
End Class
