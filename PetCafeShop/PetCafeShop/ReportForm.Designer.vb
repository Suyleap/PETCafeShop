<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportForm
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
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.dptEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgInformation = New System.Windows.Forms.DataGridView()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalDollar = New System.Windows.Forms.TextBox()
        Me.txtTotalRiel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.tblypnMidle = New System.Windows.Forms.TableLayoutPanel()
        Me.pnBoss = New System.Windows.Forms.Panel()
        Me.gbTotal = New System.Windows.Forms.GroupBox()
        Me.gbDate = New System.Windows.Forms.GroupBox()
        Me.tblypnTop = New System.Windows.Forms.TableLayoutPanel()
        Me.pnMidle = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dtgInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblypnMidle.SuspendLayout()
        Me.pnBoss.SuspendLayout()
        Me.gbTotal.SuspendLayout()
        Me.gbDate.SuspendLayout()
        Me.tblypnTop.SuspendLayout()
        Me.pnMidle.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpStart
        '
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStart.Location = New System.Drawing.Point(279, 21)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(200, 28)
        Me.dtpStart.TabIndex = 1
        '
        'dptEnd
        '
        Me.dptEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dptEnd.Location = New System.Drawing.Point(667, 18)
        Me.dptEnd.Name = "dptEnd"
        Me.dptEnd.Size = New System.Drawing.Size(200, 28)
        Me.dptEnd.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(619, 34)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "                                                   Report"
        '
        'dtgInformation
        '
        Me.dtgInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgInformation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgInformation.Location = New System.Drawing.Point(3, 3)
        Me.dtgInformation.Name = "dtgInformation"
        Me.dtgInformation.Size = New System.Drawing.Size(1169, 544)
        Me.dtgInformation.TabIndex = 3
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLoad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLoad.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(1219, 29)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(253, 107)
        Me.btnLoad.TabIndex = 3
        Me.btnLoad.Text = "&Load"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "From Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(586, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "To Date"
        '
        'txtTotalDollar
        '
        Me.txtTotalDollar.Location = New System.Drawing.Point(15, 80)
        Me.txtTotalDollar.Name = "txtTotalDollar"
        Me.txtTotalDollar.Size = New System.Drawing.Size(175, 28)
        Me.txtTotalDollar.TabIndex = 7
        '
        'txtTotalRiel
        '
        Me.txtTotalRiel.Location = New System.Drawing.Point(15, 178)
        Me.txtTotalRiel.Name = "txtTotalRiel"
        Me.txtTotalRiel.Size = New System.Drawing.Size(175, 28)
        Me.txtTotalRiel.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Grand Total Dollar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Grand Total Riel "
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClose.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(1215, 70)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(267, 95)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'tblypnMidle
        '
        Me.tblypnMidle.ColumnCount = 2
        Me.tblypnMidle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblypnMidle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 234.0!))
        Me.tblypnMidle.Controls.Add(Me.gbTotal, 1, 0)
        Me.tblypnMidle.Controls.Add(Me.dtgInformation, 0, 0)
        Me.tblypnMidle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblypnMidle.Location = New System.Drawing.Point(0, 0)
        Me.tblypnMidle.Name = "tblypnMidle"
        Me.tblypnMidle.RowCount = 1
        Me.tblypnMidle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblypnMidle.Size = New System.Drawing.Size(1409, 550)
        Me.tblypnMidle.TabIndex = 0
        '
        'pnBoss
        '
        Me.pnBoss.Controls.Add(Me.pnMidle)
        Me.pnBoss.Controls.Add(Me.tblypnTop)
        Me.pnBoss.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnBoss.Location = New System.Drawing.Point(0, 0)
        Me.pnBoss.Name = "pnBoss"
        Me.pnBoss.Size = New System.Drawing.Size(1409, 666)
        Me.pnBoss.TabIndex = 12
        '
        'gbTotal
        '
        Me.gbTotal.Controls.Add(Me.Label7)
        Me.gbTotal.Controls.Add(Me.Label6)
        Me.gbTotal.Controls.Add(Me.txtTotalDollar)
        Me.gbTotal.Controls.Add(Me.txtTotalRiel)
        Me.gbTotal.Controls.Add(Me.Label4)
        Me.gbTotal.Controls.Add(Me.Label5)
        Me.gbTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbTotal.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTotal.Location = New System.Drawing.Point(1178, 3)
        Me.gbTotal.Name = "gbTotal"
        Me.gbTotal.Size = New System.Drawing.Size(228, 544)
        Me.gbTotal.TabIndex = 13
        Me.gbTotal.TabStop = False
        Me.gbTotal.Text = "Total"
        '
        'gbDate
        '
        Me.gbDate.Controls.Add(Me.dtpStart)
        Me.gbDate.Controls.Add(Me.Label2)
        Me.gbDate.Controls.Add(Me.dptEnd)
        Me.gbDate.Controls.Add(Me.Label3)
        Me.gbDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbDate.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDate.Location = New System.Drawing.Point(3, 61)
        Me.gbDate.Name = "gbDate"
        Me.gbDate.Size = New System.Drawing.Size(1155, 52)
        Me.gbDate.TabIndex = 1
        Me.gbDate.TabStop = False
        Me.gbDate.Text = "Month/Day/Year"
        '
        'tblypnTop
        '
        Me.tblypnTop.ColumnCount = 2
        Me.tblypnTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.46983!))
        Me.tblypnTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.53016!))
        Me.tblypnTop.Controls.Add(Me.btnClose, 1, 1)
        Me.tblypnTop.Controls.Add(Me.gbDate, 0, 1)
        Me.tblypnTop.Controls.Add(Me.btnLoad, 1, 0)
        Me.tblypnTop.Controls.Add(Me.Label1, 0, 0)
        Me.tblypnTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblypnTop.Location = New System.Drawing.Point(0, 0)
        Me.tblypnTop.Name = "tblypnTop"
        Me.tblypnTop.RowCount = 2
        Me.tblypnTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblypnTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblypnTop.Size = New System.Drawing.Size(1409, 116)
        Me.tblypnTop.TabIndex = 1
        '
        'pnMidle
        '
        Me.pnMidle.Controls.Add(Me.tblypnMidle)
        Me.pnMidle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnMidle.Location = New System.Drawing.Point(0, 116)
        Me.pnMidle.Name = "pnMidle"
        Me.pnMidle.Size = New System.Drawing.Size(1409, 550)
        Me.pnMidle.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(168, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "$"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(166, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 21)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "R"
        '
        'ReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PetCafeShop.My.Resources.Resources._63795646_table_wallpapers
        Me.ClientSize = New System.Drawing.Size(1409, 666)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnBoss)
        Me.Name = "ReportForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dtgInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblypnMidle.ResumeLayout(False)
        Me.pnBoss.ResumeLayout(False)
        Me.gbTotal.ResumeLayout(False)
        Me.gbTotal.PerformLayout()
        Me.gbDate.ResumeLayout(False)
        Me.gbDate.PerformLayout()
        Me.tblypnTop.ResumeLayout(False)
        Me.tblypnTop.PerformLayout()
        Me.pnMidle.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents dptEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtgInformation As System.Windows.Forms.DataGridView
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTotalDollar As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalRiel As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents tblypnMidle As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gbTotal As System.Windows.Forms.GroupBox
    Friend WithEvents pnBoss As System.Windows.Forms.Panel
    Friend WithEvents pnMidle As System.Windows.Forms.Panel
    Friend WithEvents tblypnTop As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gbDate As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
