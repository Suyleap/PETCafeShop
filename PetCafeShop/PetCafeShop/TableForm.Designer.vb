﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TableForm
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
        Me.flpnTable = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.gbtable = New System.Windows.Forms.GroupBox()
        Me.gbTablelable = New System.Windows.Forms.GroupBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnDrinkFood = New System.Windows.Forms.Button()
        Me.txtStaffId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLoadTableForm = New System.Windows.Forms.Button()
        Me.gbtable.SuspendLayout()
        Me.gbTablelable.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(537, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pet Cafe Shop"
        '
        'flpnTable
        '
        Me.flpnTable.AutoScroll = True
        Me.flpnTable.Location = New System.Drawing.Point(6, 39)
        Me.flpnTable.Name = "flpnTable"
        Me.flpnTable.Size = New System.Drawing.Size(839, 516)
        Me.flpnTable.TabIndex = 14
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(6, 140)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(170, 61)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(191, 57)
        Me.txtID.Multiline = True
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(182, 29)
        Me.txtID.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mistral", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(83, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 33)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "ID        :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Mistral", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(83, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 33)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Number :"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(191, 92)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(182, 29)
        Me.txtName.TabIndex = 6
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Modern No. 20", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Red
        Me.btnClose.Location = New System.Drawing.Point(1131, 411)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(179, 63)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(259, 140)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(170, 61)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'gbtable
        '
        Me.gbtable.BackColor = System.Drawing.SystemColors.ControlDark
        Me.gbtable.Controls.Add(Me.txtID)
        Me.gbtable.Controls.Add(Me.btnAdd)
        Me.gbtable.Controls.Add(Me.btnDelete)
        Me.gbtable.Controls.Add(Me.Label3)
        Me.gbtable.Controls.Add(Me.Label4)
        Me.gbtable.Controls.Add(Me.txtName)
        Me.gbtable.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtable.Location = New System.Drawing.Point(907, 112)
        Me.gbtable.Name = "gbtable"
        Me.gbtable.Size = New System.Drawing.Size(435, 226)
        Me.gbtable.TabIndex = 4
        Me.gbtable.TabStop = False
        Me.gbtable.Text = "Add-Table"
        '
        'gbTablelable
        '
        Me.gbTablelable.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbTablelable.Controls.Add(Me.flpnTable)
        Me.gbTablelable.Font = New System.Drawing.Font("Mistral", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTablelable.Location = New System.Drawing.Point(28, 91)
        Me.gbTablelable.Name = "gbTablelable"
        Me.gbTablelable.Size = New System.Drawing.Size(851, 561)
        Me.gbTablelable.TabIndex = 24
        Me.gbTablelable.TabStop = False
        Me.gbTablelable.Text = "Table"
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Modern No. 20", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.Green
        Me.btnNew.Location = New System.Drawing.Point(937, 344)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(179, 63)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "NEW"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnDrinkFood
        '
        Me.btnDrinkFood.Font = New System.Drawing.Font("Modern No. 20", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrinkFood.ForeColor = System.Drawing.Color.Green
        Me.btnDrinkFood.Location = New System.Drawing.Point(1131, 344)
        Me.btnDrinkFood.Name = "btnDrinkFood"
        Me.btnDrinkFood.Size = New System.Drawing.Size(179, 63)
        Me.btnDrinkFood.TabIndex = 2
        Me.btnDrinkFood.Text = "Add-Drink-Food"
        Me.btnDrinkFood.UseVisualStyleBackColor = True
        '
        'txtStaffId
        '
        Me.txtStaffId.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffId.Location = New System.Drawing.Point(104, 64)
        Me.txtStaffId.Name = "txtStaffId"
        Me.txtStaffId.ReadOnly = True
        Me.txtStaffId.Size = New System.Drawing.Size(188, 25)
        Me.txtStaffId.TabIndex = 25
        Me.txtStaffId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mistral", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 22)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Staff-Id :"
        '
        'btnLoadTableForm
        '
        Me.btnLoadTableForm.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadTableForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLoadTableForm.Location = New System.Drawing.Point(937, 411)
        Me.btnLoadTableForm.Name = "btnLoadTableForm"
        Me.btnLoadTableForm.Size = New System.Drawing.Size(179, 65)
        Me.btnLoadTableForm.TabIndex = 27
        Me.btnLoadTableForm.Text = "&Reload"
        Me.btnLoadTableForm.UseVisualStyleBackColor = True
        '
        'TableForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImage = Global.PetCafeShop.My.Resources.Resources._63795646_table_wallpapers
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnLoadTableForm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtStaffId)
        Me.Controls.Add(Me.btnDrinkFood)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.gbTablelable)
        Me.Controls.Add(Me.gbtable)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TableForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gbtable.ResumeLayout(False)
        Me.gbtable.PerformLayout()
        Me.gbTablelable.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents flpnTable As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents gbtable As System.Windows.Forms.GroupBox
    Friend WithEvents gbTablelable As System.Windows.Forms.GroupBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnDrinkFood As System.Windows.Forms.Button
    Friend WithEvents txtStaffId As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnLoadTableForm As System.Windows.Forms.Button

End Class
