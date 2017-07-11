<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rdoHot = New System.Windows.Forms.RadioButton()
        Me.rdoIce = New System.Windows.Forms.RadioButton()
        Me.rdoFrab = New System.Windows.Forms.RadioButton()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.rdoFood = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.flpnDrink = New System.Windows.Forms.FlowLayoutPanel()
        Me.flpnbuttonFood = New System.Windows.Forms.FlowLayoutPanel()
        Me.flpnOrders = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTable = New System.Windows.Forms.TextBox()
        Me.txtInvoice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSeller = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotalDollar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotalRiel = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mistral", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(585, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 57)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pet Cafe Shop"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mistral", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 38)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Order"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mistral", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(415, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 38)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Drink"
        '
        'rdoHot
        '
        Me.rdoHot.AutoSize = True
        Me.rdoHot.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoHot.Location = New System.Drawing.Point(606, 119)
        Me.rdoHot.Name = "rdoHot"
        Me.rdoHot.Size = New System.Drawing.Size(60, 28)
        Me.rdoHot.TabIndex = 8
        Me.rdoHot.TabStop = True
        Me.rdoHot.Text = "Hot"
        Me.rdoHot.UseVisualStyleBackColor = True
        '
        'rdoIce
        '
        Me.rdoIce.AutoSize = True
        Me.rdoIce.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoIce.Location = New System.Drawing.Point(702, 119)
        Me.rdoIce.Name = "rdoIce"
        Me.rdoIce.Size = New System.Drawing.Size(56, 28)
        Me.rdoIce.TabIndex = 9
        Me.rdoIce.TabStop = True
        Me.rdoIce.Text = "Ice"
        Me.rdoIce.UseVisualStyleBackColor = True
        '
        'rdoFrab
        '
        Me.rdoFrab.AutoSize = True
        Me.rdoFrab.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFrab.Location = New System.Drawing.Point(798, 119)
        Me.rdoFrab.Name = "rdoFrab"
        Me.rdoFrab.Size = New System.Drawing.Size(95, 28)
        Me.rdoFrab.TabIndex = 10
        Me.rdoFrab.TabStop = True
        Me.rdoFrab.Text = "Frappe"
        Me.rdoFrab.UseVisualStyleBackColor = True
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(423, 624)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(166, 55)
        Me.btnTotal.TabIndex = 0
        Me.btnTotal.Text = "Total"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(595, 624)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(167, 55)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'rdoFood
        '
        Me.rdoFood.AutoSize = True
        Me.rdoFood.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFood.Location = New System.Drawing.Point(606, 371)
        Me.rdoFood.Name = "rdoFood"
        Me.rdoFood.Size = New System.Drawing.Size(77, 28)
        Me.rdoFood.TabIndex = 18
        Me.rdoFood.TabStop = True
        Me.rdoFood.Text = "Food"
        Me.rdoFood.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Mistral", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(416, 369)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 38)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Food"
        '
        'flpnDrink
        '
        Me.flpnDrink.AutoScroll = True
        Me.flpnDrink.Location = New System.Drawing.Point(423, 153)
        Me.flpnDrink.Name = "flpnDrink"
        Me.flpnDrink.Size = New System.Drawing.Size(579, 213)
        Me.flpnDrink.TabIndex = 20
        '
        'flpnbuttonFood
        '
        Me.flpnbuttonFood.AutoScroll = True
        Me.flpnbuttonFood.Location = New System.Drawing.Point(422, 405)
        Me.flpnbuttonFood.Name = "flpnbuttonFood"
        Me.flpnbuttonFood.Size = New System.Drawing.Size(580, 213)
        Me.flpnbuttonFood.TabIndex = 21
        '
        'flpnOrders
        '
        Me.flpnOrders.Location = New System.Drawing.Point(55, 213)
        Me.flpnOrders.Name = "flpnOrders"
        Me.flpnOrders.Size = New System.Drawing.Size(362, 395)
        Me.flpnOrders.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Mistral", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(97, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 33)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Table"
        '
        'txtTable
        '
        Me.txtTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTable.Location = New System.Drawing.Point(186, 176)
        Me.txtTable.Name = "txtTable"
        Me.txtTable.ReadOnly = True
        Me.txtTable.Size = New System.Drawing.Size(185, 26)
        Me.txtTable.TabIndex = 24
        Me.txtTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtInvoice
        '
        Me.txtInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoice.Location = New System.Drawing.Point(186, 143)
        Me.txtInvoice.Name = "txtInvoice"
        Me.txtInvoice.ReadOnly = True
        Me.txtInvoice.Size = New System.Drawing.Size(185, 26)
        Me.txtInvoice.TabIndex = 26
        Me.txtInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Mistral", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(97, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 33)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Invoice"
        '
        'txtSeller
        '
        Me.txtSeller.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeller.Location = New System.Drawing.Point(186, 110)
        Me.txtSeller.Name = "txtSeller"
        Me.txtSeller.ReadOnly = True
        Me.txtSeller.Size = New System.Drawing.Size(185, 26)
        Me.txtSeller.TabIndex = 28
        Me.txtSeller.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Mistral", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(97, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 33)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Seller"
        '
        'txtTotalDollar
        '
        Me.txtTotalDollar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDollar.Location = New System.Drawing.Point(205, 616)
        Me.txtTotalDollar.Name = "txtTotalDollar"
        Me.txtTotalDollar.ReadOnly = True
        Me.txtTotalDollar.Size = New System.Drawing.Size(185, 26)
        Me.txtTotalDollar.TabIndex = 34
        Me.txtTotalDollar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Mistral", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(57, 611)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 33)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "GrandTotal-$"
        '
        'txtTotalRiel
        '
        Me.txtTotalRiel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalRiel.Location = New System.Drawing.Point(205, 652)
        Me.txtTotalRiel.Name = "txtTotalRiel"
        Me.txtTotalRiel.ReadOnly = True
        Me.txtTotalRiel.Size = New System.Drawing.Size(185, 26)
        Me.txtTotalRiel.TabIndex = 32
        Me.txtTotalRiel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Mistral", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(57, 647)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 33)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "GrandTotal-R"
        '
        'OrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.txtTotalDollar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTotalRiel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSeller)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtInvoice)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTable)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.flpnOrders)
        Me.Controls.Add(Me.flpnbuttonFood)
        Me.Controls.Add(Me.flpnDrink)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rdoFood)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.rdoFrab)
        Me.Controls.Add(Me.rdoIce)
        Me.Controls.Add(Me.rdoHot)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "OrderForm"
        Me.Text = "OrderForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rdoHot As System.Windows.Forms.RadioButton
    Friend WithEvents rdoIce As System.Windows.Forms.RadioButton
    Friend WithEvents rdoFrab As System.Windows.Forms.RadioButton
    Friend WithEvents btnTotal As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents rdoFood As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents flpnDrink As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents flpnbuttonFood As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents flpnOrders As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTable As System.Windows.Forms.TextBox
    Friend WithEvents txtInvoice As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSeller As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotalDollar As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTotalRiel As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
