<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffForm
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
        Me.dgvStaff = New System.Windows.Forms.DataGridView()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpSWD = New System.Windows.Forms.DateTimePicker()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnDS = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnUpdateAcc = New System.Windows.Forms.Button()
        Me.gbStaffItem = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.gbButton = New System.Windows.Forms.GroupBox()
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbStaffItem.SuspendLayout()
        Me.gbButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvStaff
        '
        Me.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStaff.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvStaff.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStaff.Location = New System.Drawing.Point(12, 488)
        Me.dgvStaff.Name = "dgvStaff"
        Me.dgvStaff.Size = New System.Drawing.Size(1338, 241)
        Me.dgvStaff.TabIndex = 14
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(313, 45)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(176, 72)
        Me.btnEdit.TabIndex = 13
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Female", "Male"})
        Me.cboGender.Location = New System.Drawing.Point(140, 162)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(235, 33)
        Me.cboGender.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(140, 37)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(235, 30)
        Me.txtID.TabIndex = 1
        '
        'dtpDOB
        '
        Me.dtpDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDOB.Location = New System.Drawing.Point(140, 220)
        Me.dtpDOB.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(235, 30)
        Me.dtpDOB.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(413, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Start Work day"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(413, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Salary"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(413, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(413, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Phone"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 350)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 24)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Age"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 24)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "DOB"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 24)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Gender"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 24)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Name"
        '
        'dtpSWD
        '
        Me.dtpSWD.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSWD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSWD.Location = New System.Drawing.Point(570, 279)
        Me.dtpSWD.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtpSWD.Name = "dtpSWD"
        Me.dtpSWD.Size = New System.Drawing.Size(200, 30)
        Me.dtpSWD.TabIndex = 11
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(140, 97)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(235, 30)
        Me.txtName.TabIndex = 2
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(140, 281)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(235, 30)
        Me.txtAge.TabIndex = 5
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(140, 346)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(235, 30)
        Me.txtAddress.TabIndex = 6
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(570, 37)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(200, 30)
        Me.txtPhone.TabIndex = 7
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(570, 97)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(200, 30)
        Me.txtEmail.TabIndex = 8
        '
        'txtSalary
        '
        Me.txtSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalary.Location = New System.Drawing.Point(570, 222)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(200, 30)
        Me.txtSalary.TabIndex = 10
        '
        'txtPosition
        '
        Me.txtPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosition.Location = New System.Drawing.Point(570, 162)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(200, 30)
        Me.txtPosition.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(413, 166)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 24)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Position"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(24, 43)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(175, 70)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(24, 151)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(175, 68)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(313, 151)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(176, 68)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(149, 327)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 30)
        Me.txtSearch.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(50, 334)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 24)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Search"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(355, 317)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(144, 56)
        Me.btnSearch.TabIndex = 31
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnDS
        '
        Me.btnDS.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDS.Location = New System.Drawing.Point(355, 317)
        Me.btnDS.Name = "btnDS"
        Me.btnDS.Size = New System.Drawing.Size(144, 56)
        Me.btnDS.TabIndex = 18
        Me.btnDS.Text = "Disable Search"
        Me.btnDS.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(313, 46)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(176, 70)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(173, 239)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(176, 70)
        Me.btnNew.TabIndex = 32
        Me.btnNew.Text = "NEW ACCOUNT"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnUpdateAcc
        '
        Me.btnUpdateAcc.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateAcc.Location = New System.Drawing.Point(173, 239)
        Me.btnUpdateAcc.Name = "btnUpdateAcc"
        Me.btnUpdateAcc.Size = New System.Drawing.Size(176, 70)
        Me.btnUpdateAcc.TabIndex = 16
        Me.btnUpdateAcc.Text = "UPDATE ACCOUNT"
        Me.btnUpdateAcc.UseVisualStyleBackColor = True
        '
        'gbStaffItem
        '
        Me.gbStaffItem.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbStaffItem.Controls.Add(Me.txtID)
        Me.gbStaffItem.Controls.Add(Me.cboGender)
        Me.gbStaffItem.Controls.Add(Me.Label1)
        Me.gbStaffItem.Controls.Add(Me.dtpDOB)
        Me.gbStaffItem.Controls.Add(Me.Label2)
        Me.gbStaffItem.Controls.Add(Me.Label3)
        Me.gbStaffItem.Controls.Add(Me.Label4)
        Me.gbStaffItem.Controls.Add(Me.Label5)
        Me.gbStaffItem.Controls.Add(Me.Label6)
        Me.gbStaffItem.Controls.Add(Me.Label7)
        Me.gbStaffItem.Controls.Add(Me.Label8)
        Me.gbStaffItem.Controls.Add(Me.txtPosition)
        Me.gbStaffItem.Controls.Add(Me.Label9)
        Me.gbStaffItem.Controls.Add(Me.Label11)
        Me.gbStaffItem.Controls.Add(Me.Label10)
        Me.gbStaffItem.Controls.Add(Me.txtSalary)
        Me.gbStaffItem.Controls.Add(Me.dtpSWD)
        Me.gbStaffItem.Controls.Add(Me.txtEmail)
        Me.gbStaffItem.Controls.Add(Me.txtName)
        Me.gbStaffItem.Controls.Add(Me.txtPhone)
        Me.gbStaffItem.Controls.Add(Me.txtAge)
        Me.gbStaffItem.Controls.Add(Me.txtAddress)
        Me.gbStaffItem.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbStaffItem.Location = New System.Drawing.Point(12, 101)
        Me.gbStaffItem.Name = "gbStaffItem"
        Me.gbStaffItem.Size = New System.Drawing.Size(791, 381)
        Me.gbStaffItem.TabIndex = 34
        Me.gbStaffItem.TabStop = False
        Me.gbStaffItem.Text = "Staff Register"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(538, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(305, 50)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Pet Cafe Shop"
        '
        'gbButton
        '
        Me.gbButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbButton.Controls.Add(Me.btnAdd)
        Me.gbButton.Controls.Add(Me.btnEdit)
        Me.gbButton.Controls.Add(Me.btnClose)
        Me.gbButton.Controls.Add(Me.btnUpdateAcc)
        Me.gbButton.Controls.Add(Me.btnDelete)
        Me.gbButton.Controls.Add(Me.btnNew)
        Me.gbButton.Controls.Add(Me.Label13)
        Me.gbButton.Controls.Add(Me.btnUpdate)
        Me.gbButton.Controls.Add(Me.txtSearch)
        Me.gbButton.Controls.Add(Me.btnDS)
        Me.gbButton.Controls.Add(Me.btnSearch)
        Me.gbButton.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbButton.Location = New System.Drawing.Point(837, 94)
        Me.gbButton.Name = "gbButton"
        Me.gbButton.Size = New System.Drawing.Size(513, 388)
        Me.gbButton.TabIndex = 12
        Me.gbButton.TabStop = False
        Me.gbButton.Text = "Activity"
        '
        'StaffForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PetCafeShop.My.Resources.Resources._63795646_table_wallpapers
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbButton)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.gbStaffItem)
        Me.Controls.Add(Me.dgvStaff)
        Me.Name = "StaffForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbStaffItem.ResumeLayout(False)
        Me.gbStaffItem.PerformLayout()
        Me.gbButton.ResumeLayout(False)
        Me.gbButton.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvStaff As System.Windows.Forms.DataGridView

    Friend WithEvents btnEdit As System.Windows.Forms.Button

    Friend WithEvents cboGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpSWD As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnDS As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnUpdateAcc As System.Windows.Forms.Button
    Friend WithEvents gbStaffItem As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents gbButton As System.Windows.Forms.GroupBox
End Class
