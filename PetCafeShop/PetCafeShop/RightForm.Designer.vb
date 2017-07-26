<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RightForm
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
        Me.dgvRight = New System.Windows.Forms.DataGridView()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboStaffForm = New System.Windows.Forms.CheckBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboRight = New System.Windows.Forms.CheckBox()
        Me.cboSellForm = New System.Windows.Forms.CheckBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        CType(Me.dgvRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRight
        '
        Me.dgvRight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRight.Location = New System.Drawing.Point(12, 120)
        Me.dgvRight.Name = "dgvRight"
        Me.dgvRight.Size = New System.Drawing.Size(343, 329)
        Me.dgvRight.TabIndex = 0
        '
        'btnADD
        '
        Me.btnADD.Location = New System.Drawing.Point(420, 337)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(122, 65)
        Me.btnADD.TabIndex = 1
        Me.btnADD.Text = "ADD"
        Me.btnADD.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(374, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "UserName"
        '
        'cboStaffForm
        '
        Me.cboStaffForm.AutoSize = True
        Me.cboStaffForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStaffForm.Location = New System.Drawing.Point(420, 204)
        Me.cboStaffForm.Margin = New System.Windows.Forms.Padding(9)
        Me.cboStaffForm.Name = "cboStaffForm"
        Me.cboStaffForm.Size = New System.Drawing.Size(121, 29)
        Me.cboStaffForm.TabIndex = 3
        Me.cboStaffForm.Text = "Staff Form"
        Me.cboStaffForm.UseVisualStyleBackColor = True
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(526, 125)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.ReadOnly = True
        Me.txtUser.Size = New System.Drawing.Size(238, 30)
        Me.txtUser.TabIndex = 4
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(85, 71)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(201, 30)
        Me.txtSearch.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Search"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(292, 70)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(85, 39)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(237, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(321, 39)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Rights Management"
        '
        'cboRight
        '
        Me.cboRight.AutoSize = True
        Me.cboRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRight.Location = New System.Drawing.Point(478, 256)
        Me.cboRight.Name = "cboRight"
        Me.cboRight.Size = New System.Drawing.Size(195, 29)
        Me.cboRight.TabIndex = 9
        Me.cboRight.Text = "Right Management"
        Me.cboRight.UseVisualStyleBackColor = True
        '
        'cboSellForm
        '
        Me.cboSellForm.AutoSize = True
        Me.cboSellForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSellForm.Location = New System.Drawing.Point(616, 204)
        Me.cboSellForm.Name = "cboSellForm"
        Me.cboSellForm.Size = New System.Drawing.Size(114, 29)
        Me.cboSellForm.TabIndex = 10
        Me.cboSellForm.Text = "Sell Form"
        Me.cboSellForm.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(616, 337)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(122, 65)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(420, 337)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(122, 65)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(292, 70)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(85, 39)
        Me.btnStop.TabIndex = 13
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'RightForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(782, 461)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.cboSellForm)
        Me.Controls.Add(Me.cboRight)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.cboStaffForm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnADD)
        Me.Controls.Add(Me.dgvRight)
        Me.Name = "RightForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RightForm"
        CType(Me.dgvRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvRight As System.Windows.Forms.DataGridView
    Friend WithEvents btnADD As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboStaffForm As System.Windows.Forms.CheckBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboRight As System.Windows.Forms.CheckBox
    Friend WithEvents cboSellForm As System.Windows.Forms.CheckBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
End Class
