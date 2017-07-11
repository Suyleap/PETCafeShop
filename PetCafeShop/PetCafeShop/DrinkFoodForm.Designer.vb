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
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mistral", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(560, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 57)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pet Cafe Shop"
        '
        'rdoFrab
        '
        Me.rdoFrab.AutoSize = True
        Me.rdoFrab.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFrab.Location = New System.Drawing.Point(536, 158)
        Me.rdoFrab.Name = "rdoFrab"
        Me.rdoFrab.Size = New System.Drawing.Size(95, 28)
        Me.rdoFrab.TabIndex = 3
        Me.rdoFrab.TabStop = True
        Me.rdoFrab.Text = "Frappe"
        Me.rdoFrab.UseVisualStyleBackColor = True
        '
        'rdoIce
        '
        Me.rdoIce.AutoSize = True
        Me.rdoIce.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoIce.Location = New System.Drawing.Point(464, 158)
        Me.rdoIce.Name = "rdoIce"
        Me.rdoIce.Size = New System.Drawing.Size(56, 28)
        Me.rdoIce.TabIndex = 2
        Me.rdoIce.TabStop = True
        Me.rdoIce.Text = "Ice"
        Me.rdoIce.UseVisualStyleBackColor = True
        '
        'rdoHot
        '
        Me.rdoHot.AutoSize = True
        Me.rdoHot.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoHot.Location = New System.Drawing.Point(373, 158)
        Me.rdoHot.Name = "rdoHot"
        Me.rdoHot.Size = New System.Drawing.Size(60, 28)
        Me.rdoHot.TabIndex = 1
        Me.rdoHot.TabStop = True
        Me.rdoHot.Text = "Hot"
        Me.rdoHot.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mistral", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(260, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 38)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Drink"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mistral", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(260, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 38)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Mistral", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(260, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 38)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Mistral", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(260, 326)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 38)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Price"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(411, 223)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(303, 20)
        Me.txtID.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(411, 281)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(303, 20)
        Me.txtName.TabIndex = 6
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(411, 340)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(303, 20)
        Me.txtPrice.TabIndex = 7
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(352, 446)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(121, 54)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(606, 446)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(121, 54)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(733, 446)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(121, 54)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(860, 446)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(121, 54)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'dtg
        '
        Me.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg.Location = New System.Drawing.Point(734, 158)
        Me.dtg.Name = "dtg"
        Me.dtg.Size = New System.Drawing.Size(478, 244)
        Me.dtg.TabIndex = 26
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(479, 446)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(121, 54)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'rdoFood
        '
        Me.rdoFood.AutoSize = True
        Me.rdoFood.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFood.Location = New System.Drawing.Point(637, 158)
        Me.rdoFood.Name = "rdoFood"
        Me.rdoFood.Size = New System.Drawing.Size(77, 28)
        Me.rdoFood.TabIndex = 4
        Me.rdoFood.TabStop = True
        Me.rdoFood.Text = "Food"
        Me.rdoFood.UseVisualStyleBackColor = True
        '
        'DrinkFoodForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.rdoFood)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.dtg)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rdoFrab)
        Me.Controls.Add(Me.rdoIce)
        Me.Controls.Add(Me.rdoHot)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DrinkFoodForm"
        Me.Text = "DrinkForm"
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
