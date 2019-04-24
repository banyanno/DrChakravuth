<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvoiceMedicineV2
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InvoiceMedicineV2))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LblSubUnitQTY = New System.Windows.Forms.Label
        Me.LblMainUnitQTY = New System.Windows.Forms.Label
        Me.TxtMainStockUnit = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtCurrentQTY = New System.Windows.Forms.TextBox
        Me.TxtPrice = New System.Windows.Forms.TextBox
        Me.cboItem = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtBarCode = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtSaleQty = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ErrCheckItem = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtUnitName = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrCheckItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblSubUnitQTY)
        Me.GroupBox1.Controls.Add(Me.LblMainUnitQTY)
        Me.GroupBox1.Controls.Add(Me.TxtMainStockUnit)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtCurrentQTY)
        Me.GroupBox1.Controls.Add(Me.TxtPrice)
        Me.GroupBox1.Controls.Add(Me.cboItem)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 175)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select medicince info:"
        '
        'LblSubUnitQTY
        '
        Me.LblSubUnitQTY.AutoSize = True
        Me.LblSubUnitQTY.Location = New System.Drawing.Point(329, 77)
        Me.LblSubUnitQTY.Name = "LblSubUnitQTY"
        Me.LblSubUnitQTY.Size = New System.Drawing.Size(18, 20)
        Me.LblSubUnitQTY.TabIndex = 11
        Me.LblSubUnitQTY.Text = "0"
        Me.LblSubUnitQTY.Visible = False
        '
        'LblMainUnitQTY
        '
        Me.LblMainUnitQTY.AutoSize = True
        Me.LblMainUnitQTY.Location = New System.Drawing.Point(318, 27)
        Me.LblMainUnitQTY.Name = "LblMainUnitQTY"
        Me.LblMainUnitQTY.Size = New System.Drawing.Size(18, 20)
        Me.LblMainUnitQTY.TabIndex = 10
        Me.LblMainUnitQTY.Text = "0"
        Me.LblMainUnitQTY.Visible = False
        '
        'TxtMainStockUnit
        '
        Me.TxtMainStockUnit.BackColor = System.Drawing.Color.White
        Me.TxtMainStockUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMainStockUnit.Location = New System.Drawing.Point(348, 83)
        Me.TxtMainStockUnit.Name = "TxtMainStockUnit"
        Me.TxtMainStockUnit.ReadOnly = True
        Me.TxtMainStockUnit.Size = New System.Drawing.Size(134, 30)
        Me.TxtMainStockUnit.TabIndex = 9
        Me.TxtMainStockUnit.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(342, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Main Unit Stock:"
        Me.Label7.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(245, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Sub-Unit Stock"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Price in Sub-Unit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Item Name:"
        '
        'TxtCurrentQTY
        '
        Me.TxtCurrentQTY.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtCurrentQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCurrentQTY.Location = New System.Drawing.Point(216, 119)
        Me.TxtCurrentQTY.Name = "TxtCurrentQTY"
        Me.TxtCurrentQTY.ReadOnly = True
        Me.TxtCurrentQTY.Size = New System.Drawing.Size(196, 30)
        Me.TxtCurrentQTY.TabIndex = 3
        '
        'TxtPrice
        '
        Me.TxtPrice.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrice.Location = New System.Drawing.Point(23, 119)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.ReadOnly = True
        Me.TxtPrice.Size = New System.Drawing.Size(187, 30)
        Me.TxtPrice.TabIndex = 2
        '
        'cboItem
        '
        Me.cboItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboItem.FormattingEnabled = True
        Me.cboItem.Location = New System.Drawing.Point(23, 51)
        Me.cboItem.Name = "cboItem"
        Me.cboItem.Size = New System.Drawing.Size(389, 32)
        Me.cboItem.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(435, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Item Code"
        Me.Label2.Visible = False
        '
        'TxtBarCode
        '
        Me.TxtBarCode.BackColor = System.Drawing.Color.White
        Me.TxtBarCode.Location = New System.Drawing.Point(438, 224)
        Me.TxtBarCode.Name = "TxtBarCode"
        Me.TxtBarCode.ReadOnly = True
        Me.TxtBarCode.Size = New System.Drawing.Size(214, 20)
        Me.TxtBarCode.TabIndex = 1
        Me.TxtBarCode.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(66, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Sale Qty"
        '
        'TxtSaleQty
        '
        Me.TxtSaleQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtSaleQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSaleQty.Location = New System.Drawing.Point(31, 226)
        Me.TxtSaleQty.Name = "TxtSaleQty"
        Me.TxtSaleQty.Size = New System.Drawing.Size(187, 32)
        Me.TxtSaleQty.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(247, 281)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(201, 20)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Press Key: F1 to close form"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(11, 281)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(211, 20)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Press Key: Enter to add Item"
        '
        'ErrCheckItem
        '
        Me.ErrCheckItem.ContainerControl = Me
        '
        'txtUnitName
        '
        Me.txtUnitName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtUnitName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtUnitName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUnitName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtUnitName.Location = New System.Drawing.Point(224, 226)
        Me.txtUnitName.Name = "txtUnitName"
        Me.txtUnitName.Size = New System.Drawing.Size(196, 32)
        Me.txtUnitName.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(265, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Unit Nam:"
        '
        'InvoiceMedicineV2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 318)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtUnitName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtSaleQty)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtBarCode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InvoiceMedicineV2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Medicince"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrCheckItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboItem As System.Windows.Forms.ComboBox
    Friend WithEvents TxtBarCode As System.Windows.Forms.TextBox
    Friend WithEvents TxtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtCurrentQTY As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtSaleQty As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ErrCheckItem As System.Windows.Forms.ErrorProvider
    Friend WithEvents TxtMainStockUnit As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LblSubUnitQTY As System.Windows.Forms.Label
    Friend WithEvents LblMainUnitQTY As System.Windows.Forms.Label
    Friend WithEvents txtUnitName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
