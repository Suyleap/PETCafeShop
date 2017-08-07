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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rdoHot = New System.Windows.Forms.RadioButton()
        Me.rdoIce = New System.Windows.Forms.RadioButton()
        Me.rdoFrab = New System.Windows.Forms.RadioButton()
        Me.btnPn = New System.Windows.Forms.Button()
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
        Me.gb = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtRmr = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtRmd = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCmr = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCmd = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.gbDiscount = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnPlt = New System.Windows.Forms.Button()
        Me.btnuplt = New System.Windows.Forms.Button()
        Me.btnupn = New System.Windows.Forms.Button()
        Me.gbOrders = New System.Windows.Forms.GroupBox()
        Me.gbItem = New System.Windows.Forms.GroupBox()
        Me.gbPrint = New System.Windows.Forms.GroupBox()
        Me.btnpplt = New System.Windows.Forms.Button()
        Me.gb.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbDiscount.SuspendLayout()
        Me.gbOrders.SuspendLayout()
        Me.gbItem.SuspendLayout()
        Me.gbPrint.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(585, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 50)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pet Cafe Shop"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Drink"
        '
        'rdoHot
        '
        Me.rdoHot.AutoSize = True
        Me.rdoHot.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoHot.Location = New System.Drawing.Point(161, 38)
        Me.rdoHot.Name = "rdoHot"
        Me.rdoHot.Size = New System.Drawing.Size(76, 33)
        Me.rdoHot.TabIndex = 8
        Me.rdoHot.TabStop = True
        Me.rdoHot.Text = "Hot"
        Me.rdoHot.UseVisualStyleBackColor = True
        '
        'rdoIce
        '
        Me.rdoIce.AutoSize = True
        Me.rdoIce.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoIce.Location = New System.Drawing.Point(257, 38)
        Me.rdoIce.Name = "rdoIce"
        Me.rdoIce.Size = New System.Drawing.Size(67, 33)
        Me.rdoIce.TabIndex = 9
        Me.rdoIce.TabStop = True
        Me.rdoIce.Text = "Ice"
        Me.rdoIce.UseVisualStyleBackColor = True
        '
        'rdoFrab
        '
        Me.rdoFrab.AutoSize = True
        Me.rdoFrab.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFrab.Location = New System.Drawing.Point(353, 38)
        Me.rdoFrab.Name = "rdoFrab"
        Me.rdoFrab.Size = New System.Drawing.Size(115, 33)
        Me.rdoFrab.TabIndex = 10
        Me.rdoFrab.TabStop = True
        Me.rdoFrab.Text = "Frappe"
        Me.rdoFrab.UseVisualStyleBackColor = True
        '
        'btnPn
        '
        Me.btnPn.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPn.Location = New System.Drawing.Point(447, 664)
        Me.btnPn.Name = "btnPn"
        Me.btnPn.Size = New System.Drawing.Size(166, 55)
        Me.btnPn.TabIndex = 0
        Me.btnPn.Text = "Pay-Now"
        Me.btnPn.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Red
        Me.btnCancel.Location = New System.Drawing.Point(791, 664)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(167, 55)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'rdoFood
        '
        Me.rdoFood.AutoSize = True
        Me.rdoFood.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFood.Location = New System.Drawing.Point(197, 312)
        Me.rdoFood.Name = "rdoFood"
        Me.rdoFood.Size = New System.Drawing.Size(89, 33)
        Me.rdoFood.TabIndex = 18
        Me.rdoFood.TabStop = True
        Me.rdoFood.Text = "Food"
        Me.rdoFood.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 314)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 29)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Food"
        '
        'flpnDrink
        '
        Me.flpnDrink.AutoScroll = True
        Me.flpnDrink.BackColor = System.Drawing.SystemColors.Control
        Me.flpnDrink.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flpnDrink.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.flpnDrink.Location = New System.Drawing.Point(16, 78)
        Me.flpnDrink.Name = "flpnDrink"
        Me.flpnDrink.Size = New System.Drawing.Size(579, 213)
        Me.flpnDrink.TabIndex = 20
        '
        'flpnbuttonFood
        '
        Me.flpnbuttonFood.AutoScroll = True
        Me.flpnbuttonFood.BackColor = System.Drawing.SystemColors.Control
        Me.flpnbuttonFood.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flpnbuttonFood.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.flpnbuttonFood.Location = New System.Drawing.Point(15, 353)
        Me.flpnbuttonFood.Name = "flpnbuttonFood"
        Me.flpnbuttonFood.Size = New System.Drawing.Size(580, 213)
        Me.flpnbuttonFood.TabIndex = 21
        '
        'flpnOrders
        '
        Me.flpnOrders.AutoScroll = True
        Me.flpnOrders.BackColor = System.Drawing.SystemColors.Control
        Me.flpnOrders.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flpnOrders.Location = New System.Drawing.Point(21, 131)
        Me.flpnOrders.Name = "flpnOrders"
        Me.flpnOrders.Size = New System.Drawing.Size(362, 395)
        Me.flpnOrders.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(94, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 29)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Table"
        '
        'txtTable
        '
        Me.txtTable.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTable.Location = New System.Drawing.Point(198, 100)
        Me.txtTable.Name = "txtTable"
        Me.txtTable.ReadOnly = True
        Me.txtTable.Size = New System.Drawing.Size(185, 25)
        Me.txtTable.TabIndex = 24
        Me.txtTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtInvoice
        '
        Me.txtInvoice.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoice.Location = New System.Drawing.Point(198, 67)
        Me.txtInvoice.Name = "txtInvoice"
        Me.txtInvoice.ReadOnly = True
        Me.txtInvoice.Size = New System.Drawing.Size(185, 25)
        Me.txtInvoice.TabIndex = 26
        Me.txtInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(94, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 29)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Invoice"
        '
        'txtSeller
        '
        Me.txtSeller.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeller.Location = New System.Drawing.Point(198, 34)
        Me.txtSeller.Name = "txtSeller"
        Me.txtSeller.ReadOnly = True
        Me.txtSeller.Size = New System.Drawing.Size(185, 25)
        Me.txtSeller.TabIndex = 28
        Me.txtSeller.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(94, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 29)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Seller"
        '
        'txtTotalDollar
        '
        Me.txtTotalDollar.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDollar.Location = New System.Drawing.Point(198, 556)
        Me.txtTotalDollar.Name = "txtTotalDollar"
        Me.txtTotalDollar.ReadOnly = True
        Me.txtTotalDollar.Size = New System.Drawing.Size(185, 30)
        Me.txtTotalDollar.TabIndex = 34
        Me.txtTotalDollar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 559)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 24)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "GrandTotal-$"
        '
        'txtTotalRiel
        '
        Me.txtTotalRiel.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalRiel.Location = New System.Drawing.Point(198, 592)
        Me.txtTotalRiel.Name = "txtTotalRiel"
        Me.txtTotalRiel.ReadOnly = True
        Me.txtTotalRiel.Size = New System.Drawing.Size(185, 30)
        Me.txtTotalRiel.TabIndex = 32
        Me.txtTotalRiel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(17, 595)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 24)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "GrandTotal-R"
        '
        'gb
        '
        Me.gb.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.gb.Controls.Add(Me.Label14)
        Me.gb.Controls.Add(Me.txtRmr)
        Me.gb.Controls.Add(Me.Label16)
        Me.gb.Controls.Add(Me.txtRmd)
        Me.gb.Controls.Add(Me.Label11)
        Me.gb.Controls.Add(Me.Label10)
        Me.gb.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb.Location = New System.Drawing.Point(1049, 203)
        Me.gb.Name = "gb"
        Me.gb.Size = New System.Drawing.Size(293, 142)
        Me.gb.TabIndex = 35
        Me.gb.TabStop = False
        Me.gb.Text = "Receive-Money"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Mistral", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(262, 76)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(25, 29)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "R"
        '
        'txtRmr
        '
        Me.txtRmr.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRmr.Location = New System.Drawing.Point(112, 78)
        Me.txtRmr.Name = "txtRmr"
        Me.txtRmr.Size = New System.Drawing.Size(175, 25)
        Me.txtRmr.TabIndex = 7
        Me.txtRmr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Mistral", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(264, 39)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(23, 29)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "$"
        '
        'txtRmd
        '
        Me.txtRmd.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRmd.Location = New System.Drawing.Point(112, 41)
        Me.txtRmd.Name = "txtRmd"
        Me.txtRmd.Size = New System.Drawing.Size(175, 25)
        Me.txtRmd.TabIndex = 7
        Me.txtRmd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 25)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Riel R:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 25)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Dolar$:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtCmr)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtCmd)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1049, 353)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 142)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Change-Money"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Mistral", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(262, 76)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(25, 29)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "R"
        '
        'txtCmr
        '
        Me.txtCmr.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCmr.Location = New System.Drawing.Point(112, 78)
        Me.txtCmr.Name = "txtCmr"
        Me.txtCmr.ReadOnly = True
        Me.txtCmr.Size = New System.Drawing.Size(175, 25)
        Me.txtCmr.TabIndex = 7
        Me.txtCmr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Mistral", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(264, 39)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(23, 29)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "$"
        '
        'txtCmd
        '
        Me.txtCmd.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCmd.Location = New System.Drawing.Point(112, 41)
        Me.txtCmd.Name = "txtCmd"
        Me.txtCmd.ReadOnly = True
        Me.txtCmd.Size = New System.Drawing.Size(175, 25)
        Me.txtCmd.TabIndex = 7
        Me.txtCmd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 25)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Riel R:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 25)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Dolar$:"
        '
        'gbDiscount
        '
        Me.gbDiscount.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.gbDiscount.Controls.Add(Me.Label23)
        Me.gbDiscount.Controls.Add(Me.txtDiscount)
        Me.gbDiscount.Controls.Add(Me.Label15)
        Me.gbDiscount.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDiscount.Location = New System.Drawing.Point(1049, 86)
        Me.gbDiscount.Name = "gbDiscount"
        Me.gbDiscount.Size = New System.Drawing.Size(293, 111)
        Me.gbDiscount.TabIndex = 37
        Me.gbDiscount.TabStop = False
        Me.gbDiscount.Text = "Discount"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Mistral", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(259, 41)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(28, 29)
        Me.Label23.TabIndex = 43
        Me.Label23.Text = "%"
        '
        'txtDiscount
        '
        Me.txtDiscount.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Location = New System.Drawing.Point(112, 41)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(175, 25)
        Me.txtDiscount.TabIndex = 7
        Me.txtDiscount.Text = "0"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 39)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 25)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Percents"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Mistral", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(358, 591)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(25, 29)
        Me.Label19.TabIndex = 47
        Me.Label19.Text = "R"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Mistral", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(360, 557)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(23, 29)
        Me.Label20.TabIndex = 46
        Me.Label20.Text = "$"
        '
        'btnPlt
        '
        Me.btnPlt.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlt.Location = New System.Drawing.Point(619, 664)
        Me.btnPlt.Name = "btnPlt"
        Me.btnPlt.Size = New System.Drawing.Size(166, 55)
        Me.btnPlt.TabIndex = 48
        Me.btnPlt.Text = "Pay-Latter"
        Me.btnPlt.UseVisualStyleBackColor = True
        '
        'btnuplt
        '
        Me.btnuplt.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnuplt.Location = New System.Drawing.Point(619, 664)
        Me.btnuplt.Name = "btnuplt"
        Me.btnuplt.Size = New System.Drawing.Size(166, 55)
        Me.btnuplt.TabIndex = 49
        Me.btnuplt.Text = "Update-Pay-Latter"
        Me.btnuplt.UseVisualStyleBackColor = True
        '
        'btnupn
        '
        Me.btnupn.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupn.Location = New System.Drawing.Point(447, 664)
        Me.btnupn.Name = "btnupn"
        Me.btnupn.Size = New System.Drawing.Size(166, 55)
        Me.btnupn.TabIndex = 50
        Me.btnupn.Text = "Update-Pay-Now"
        Me.btnupn.UseVisualStyleBackColor = True
        '
        'gbOrders
        '
        Me.gbOrders.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbOrders.Controls.Add(Me.flpnOrders)
        Me.gbOrders.Controls.Add(Me.Label5)
        Me.gbOrders.Controls.Add(Me.txtTable)
        Me.gbOrders.Controls.Add(Me.Label6)
        Me.gbOrders.Controls.Add(Me.Label19)
        Me.gbOrders.Controls.Add(Me.txtInvoice)
        Me.gbOrders.Controls.Add(Me.Label7)
        Me.gbOrders.Controls.Add(Me.Label20)
        Me.gbOrders.Controls.Add(Me.txtSeller)
        Me.gbOrders.Controls.Add(Me.txtTotalDollar)
        Me.gbOrders.Controls.Add(Me.Label9)
        Me.gbOrders.Controls.Add(Me.txtTotalRiel)
        Me.gbOrders.Controls.Add(Me.Label8)
        Me.gbOrders.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOrders.Location = New System.Drawing.Point(7, 58)
        Me.gbOrders.Name = "gbOrders"
        Me.gbOrders.Size = New System.Drawing.Size(409, 663)
        Me.gbOrders.TabIndex = 51
        Me.gbOrders.TabStop = False
        Me.gbOrders.Text = "Orders"
        '
        'gbItem
        '
        Me.gbItem.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbItem.Controls.Add(Me.flpnDrink)
        Me.gbItem.Controls.Add(Me.Label3)
        Me.gbItem.Controls.Add(Me.rdoHot)
        Me.gbItem.Controls.Add(Me.rdoIce)
        Me.gbItem.Controls.Add(Me.rdoFrab)
        Me.gbItem.Controls.Add(Me.rdoFood)
        Me.gbItem.Controls.Add(Me.Label4)
        Me.gbItem.Controls.Add(Me.flpnbuttonFood)
        Me.gbItem.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbItem.Location = New System.Drawing.Point(422, 78)
        Me.gbItem.Name = "gbItem"
        Me.gbItem.Size = New System.Drawing.Size(601, 582)
        Me.gbItem.TabIndex = 52
        Me.gbItem.TabStop = False
        Me.gbItem.Text = "Item"
        '
        'gbPrint
        '
        Me.gbPrint.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.gbPrint.Controls.Add(Me.btnpplt)
        Me.gbPrint.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPrint.Location = New System.Drawing.Point(1049, 501)
        Me.gbPrint.Name = "gbPrint"
        Me.gbPrint.Size = New System.Drawing.Size(293, 103)
        Me.gbPrint.TabIndex = 53
        Me.gbPrint.TabStop = False
        Me.gbPrint.Text = "Print-Invoice"
        '
        'btnpplt
        '
        Me.btnpplt.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpplt.Location = New System.Drawing.Point(66, 39)
        Me.btnpplt.Name = "btnpplt"
        Me.btnpplt.Size = New System.Drawing.Size(166, 55)
        Me.btnpplt.TabIndex = 52
        Me.btnpplt.Text = "Print-Pay-Latter"
        Me.btnpplt.UseVisualStyleBackColor = True
        '
        'OrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PetCafeShop.My.Resources.Resources._63795646_table_wallpapers
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.gbPrint)
        Me.Controls.Add(Me.gbItem)
        Me.Controls.Add(Me.gbOrders)
        Me.Controls.Add(Me.btnupn)
        Me.Controls.Add(Me.btnuplt)
        Me.Controls.Add(Me.btnPlt)
        Me.Controls.Add(Me.gbDiscount)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gb)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "OrderForm"
        Me.Text = "OrderForm"
        Me.gb.ResumeLayout(False)
        Me.gb.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbDiscount.ResumeLayout(False)
        Me.gbDiscount.PerformLayout()
        Me.gbOrders.ResumeLayout(False)
        Me.gbOrders.PerformLayout()
        Me.gbItem.ResumeLayout(False)
        Me.gbItem.PerformLayout()
        Me.gbPrint.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rdoHot As System.Windows.Forms.RadioButton
    Friend WithEvents rdoIce As System.Windows.Forms.RadioButton
    Friend WithEvents rdoFrab As System.Windows.Forms.RadioButton
    Friend WithEvents btnPn As System.Windows.Forms.Button
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
    Friend WithEvents gb As System.Windows.Forms.GroupBox
    Friend WithEvents txtRmr As System.Windows.Forms.TextBox
    Friend WithEvents txtRmd As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCmr As System.Windows.Forms.TextBox
    Friend WithEvents txtCmd As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents gbDiscount As System.Windows.Forms.GroupBox
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btnPlt As System.Windows.Forms.Button
    Friend WithEvents btnuplt As System.Windows.Forms.Button
    Friend WithEvents btnupn As System.Windows.Forms.Button
    Friend WithEvents gbOrders As System.Windows.Forms.GroupBox
    Friend WithEvents gbItem As System.Windows.Forms.GroupBox
    Friend WithEvents gbPrint As System.Windows.Forms.GroupBox
    Friend WithEvents btnpplt As System.Windows.Forms.Button
End Class
