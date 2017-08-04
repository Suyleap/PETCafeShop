<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DrinkFoodForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdoFrab = New System.Windows.Forms.RadioButton()
        Me.rdoIce = New System.Windows.Forms.RadioButton()
        Me.rdoHot = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dtg = New System.Windows.Forms.DataGridView()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.rdoFood = New System.Windows.Forms.RadioButton()
        Me.gbItem = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbDrinkFood = New System.Windows.Forms.GroupBox()
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbItem.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbDrinkFood.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(565, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 50)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pet Cafe Shop"
        '
        'rdoFrab
        '
        Me.rdoFrab.AutoSize = True
        Me.rdoFrab.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFrab.Location = New System.Drawing.Point(308, 55)
        Me.rdoFrab.Name = "rdoFrab"
        Me.rdoFrab.Size = New System.Drawing.Size(88, 25)
        Me.rdoFrab.TabIndex = 3
        Me.rdoFrab.TabStop = True
        Me.rdoFrab.Text = "Frappe"
        Me.rdoFrab.UseVisualStyleBackColor = True
        '
        'rdoIce
        '
        Me.rdoIce.AutoSize = True
        Me.rdoIce.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoIce.Location = New System.Drawing.Point(236, 55)
        Me.rdoIce.Name = "rdoIce"
        Me.rdoIce.Size = New System.Drawing.Size(55, 25)
        Me.rdoIce.TabIndex = 2
        Me.rdoIce.TabStop = True
        Me.rdoIce.Text = "Ice"
        Me.rdoIce.UseVisualStyleBackColor = True
        '
        'rdoHot
        '
        Me.rdoHot.AutoSize = True
        Me.rdoHot.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoHot.Location = New System.Drawing.Point(145, 55)
        Me.rdoHot.Name = "rdoHot"
        Me.rdoHot.Size = New System.Drawing.Size(61, 25)
        Me.rdoHot.TabIndex = 1
        Me.rdoHot.TabStop = True
        Me.rdoHot.Text = "Hot"
        Me.rdoHot.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 34)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Drink"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 34)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 34)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 34)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Price"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(177, 115)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(303, 25)
        Me.txtID.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(177, 173)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(303, 25)
        Me.txtName.TabIndex = 6
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(177, 232)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(303, 25)
        Me.txtPrice.TabIndex = 7
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(52, 58)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(121, 54)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(306, 58)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(121, 54)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(433, 58)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(121, 54)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(560, 58)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(121, 54)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "Close"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'dtg
        '
        Me.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg.Location = New System.Drawing.Point(558, 55)
        Me.dtg.Name = "dtg"
        Me.dtg.Size = New System.Drawing.Size(493, 281)
        Me.dtg.TabIndex = 26
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(179, 58)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(121, 54)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'rdoFood
        '
        Me.rdoFood.AutoSize = True
        Me.rdoFood.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFood.Location = New System.Drawing.Point(409, 55)
        Me.rdoFood.Name = "rdoFood"
        Me.rdoFood.Size = New System.Drawing.Size(71, 25)
        Me.rdoFood.TabIndex = 4
        Me.rdoFood.TabStop = True
        Me.rdoFood.Text = "Food"
        Me.rdoFood.UseVisualStyleBackColor = True
        '
        'gbItem
        '
        Me.gbItem.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbItem.Controls.Add(Me.txtName)
        Me.gbItem.Controls.Add(Me.rdoFood)
        Me.gbItem.Controls.Add(Me.Label3)
        Me.gbItem.Controls.Add(Me.rdoHot)
        Me.gbItem.Controls.Add(Me.rdoIce)
        Me.gbItem.Controls.Add(Me.rdoFrab)
        Me.gbItem.Controls.Add(Me.Label2)
        Me.gbItem.Controls.Add(Me.Label4)
        Me.gbItem.Controls.Add(Me.Label5)
        Me.gbItem.Controls.Add(Me.txtPrice)
        Me.gbItem.Controls.Add(Me.txtID)
        Me.gbItem.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbItem.Location = New System.Drawing.Point(41, 55)
        Me.gbItem.Name = "gbItem"
        Me.gbItem.Size = New System.Drawing.Size(511, 281)
        Me.gbItem.TabIndex = 1
        Me.gbItem.TabStop = False
        Me.gbItem.Text = "Item"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.btnBack)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(167, 356)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(731, 136)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Activity"
        '
        'gbDrinkFood
        '
        Me.gbDrinkFood.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbDrinkFood.Controls.Add(Me.gbItem)
        Me.gbDrinkFood.Controls.Add(Me.GroupBox1)
        Me.gbDrinkFood.Controls.Add(Me.dtg)
        Me.gbDrinkFood.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDrinkFood.Location = New System.Drawing.Point(149, 99)
        Me.gbDrinkFood.Name = "gbDrinkFood"
        Me.gbDrinkFood.Size = New System.Drawing.Size(1082, 514)
        Me.gbDrinkFood.TabIndex = 29
        Me.gbDrinkFood.TabStop = False
        Me.gbDrinkFood.Text = "Drink-Food-Form"
        '
        'DrinkFoodForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PetCafeShop.My.Resources.Resources._63795646_table_wallpapers
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.gbDrinkFood)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DrinkFoodForm"
        Me.Text = "DrinkForm"
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbItem.ResumeLayout(False)
        Me.gbItem.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.gbDrinkFood.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdoFrab As System.Windows.Forms.RadioButton
    Friend WithEvents rdoIce As System.Windows.Forms.RadioButton
    Friend WithEvents rdoHot As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents dtg As System.Windows.Forms.DataGridView
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents rdoFood As System.Windows.Forms.RadioButton
    Friend WithEvents gbItem As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbDrinkFood As System.Windows.Forms.GroupBox
End Class
