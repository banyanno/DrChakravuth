<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewInvoice
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
        Dim ParaList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewInvoice))
        Dim PrescriptionList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim OrderList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtsex = New System.Windows.Forms.TextBox
        Me.txtage = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtid = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.txtconsultfee = New System.Windows.Forms.TextBox
        Me.txtconsulttype = New System.Windows.Forms.TextBox
        Me.labelcon = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.DtInvoiceDate = New System.Windows.Forms.DateTimePicker
        Me.txtinvoiceno = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.ParaList = New Janus.Windows.GridEX.GridEX
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.PrescriptionList = New Janus.Windows.GridEX.GridEX
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.OrderList = New Janus.Windows.GridEX.GridEX
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtdollar = New System.Windows.Forms.TextBox
        Me.txtriel = New System.Windows.Forms.TextBox
        Me.txtexchangerate = New System.Windows.Forms.TextBox
        Me.txtdiscount = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.OrderContextMenu = New Janus.Windows.Ribbon.RibbonContextMenu(Me.components)
        Me.BtnAddOrder = New Janus.Windows.Ribbon.DropDownCommand
        Me.BtnDeleteOrder = New Janus.Windows.Ribbon.DropDownCommand
        Me.txtparacharge = New System.Windows.Forms.TextBox
        Me.Err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OfficeFormAdorner1 = New Janus.Windows.Ribbon.OfficeFormAdorner(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolSave = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolCancel = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ParaList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PrescriptionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.OrderList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        CType(Me.Err, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfficeFormAdorner1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtsex)
        Me.GroupBox1.Controls.Add(Me.txtage)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(466, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pateint Info."
        '
        'txtsex
        '
        Me.txtsex.BackColor = System.Drawing.Color.White
        Me.txtsex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsex.Location = New System.Drawing.Point(307, 56)
        Me.txtsex.Name = "txtsex"
        Me.txtsex.ReadOnly = True
        Me.txtsex.Size = New System.Drawing.Size(146, 26)
        Me.txtsex.TabIndex = 29
        '
        'txtage
        '
        Me.txtage.BackColor = System.Drawing.Color.White
        Me.txtage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.Location = New System.Drawing.Point(72, 56)
        Me.txtage.Name = "txtage"
        Me.txtage.ReadOnly = True
        Me.txtage.Size = New System.Drawing.Size(146, 26)
        Me.txtage.TabIndex = 28
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.White
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(307, 19)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(146, 26)
        Me.txtname.TabIndex = 27
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.Color.White
        Me.txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(72, 19)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(146, 26)
        Me.txtid.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(227, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Sex"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Age:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(227, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Patient Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Patient No:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.GroupBox7)
        Me.GroupBox2.Controls.Add(Me.DtInvoiceDate)
        Me.GroupBox2.Controls.Add(Me.txtinvoiceno)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(481, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(572, 100)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Invoice Info."
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.Controls.Add(Me.txtconsultfee)
        Me.GroupBox7.Controls.Add(Me.txtconsulttype)
        Me.GroupBox7.Controls.Add(Me.labelcon)
        Me.GroupBox7.Controls.Add(Me.Label8)
        Me.GroupBox7.Location = New System.Drawing.Point(259, 7)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(304, 81)
        Me.GroupBox7.TabIndex = 30
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Consultation"
        '
        'txtconsultfee
        '
        Me.txtconsultfee.BackColor = System.Drawing.Color.White
        Me.txtconsultfee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconsultfee.Location = New System.Drawing.Point(107, 49)
        Me.txtconsultfee.Name = "txtconsultfee"
        Me.txtconsultfee.ReadOnly = True
        Me.txtconsultfee.Size = New System.Drawing.Size(167, 26)
        Me.txtconsultfee.TabIndex = 30
        '
        'txtconsulttype
        '
        Me.txtconsulttype.BackColor = System.Drawing.Color.White
        Me.txtconsulttype.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconsulttype.Location = New System.Drawing.Point(107, 12)
        Me.txtconsulttype.Name = "txtconsulttype"
        Me.txtconsulttype.ReadOnly = True
        Me.txtconsulttype.Size = New System.Drawing.Size(167, 26)
        Me.txtconsulttype.TabIndex = 29
        '
        'labelcon
        '
        Me.labelcon.AutoSize = True
        Me.labelcon.Location = New System.Drawing.Point(6, 57)
        Me.labelcon.Name = "labelcon"
        Me.labelcon.Size = New System.Drawing.Size(89, 13)
        Me.labelcon.TabIndex = 1
        Me.labelcon.Text = "Consultation Fee:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Consultation Type:"
        '
        'DtInvoiceDate
        '
        Me.DtInvoiceDate.Checked = False
        Me.DtInvoiceDate.CustomFormat = "dd/MM/yyyy"
        Me.DtInvoiceDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtInvoiceDate.Location = New System.Drawing.Point(85, 56)
        Me.DtInvoiceDate.Name = "DtInvoiceDate"
        Me.DtInvoiceDate.ShowCheckBox = True
        Me.DtInvoiceDate.Size = New System.Drawing.Size(167, 26)
        Me.DtInvoiceDate.TabIndex = 29
        '
        'txtinvoiceno
        '
        Me.txtinvoiceno.BackColor = System.Drawing.Color.White
        Me.txtinvoiceno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinvoiceno.Location = New System.Drawing.Point(85, 19)
        Me.txtinvoiceno.Name = "txtinvoiceno"
        Me.txtinvoiceno.ReadOnly = True
        Me.txtinvoiceno.Size = New System.Drawing.Size(167, 26)
        Me.txtinvoiceno.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Invoice Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Invoice No:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.SplitContainer2)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 144)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1044, 494)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Prescription for Ordinances"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 16)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox6)
        Me.SplitContainer2.Size = New System.Drawing.Size(1038, 475)
        Me.SplitContainer2.SplitterDistance = 175
        Me.SplitContainer2.TabIndex = 4
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox4)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox5)
        Me.SplitContainer1.Size = New System.Drawing.Size(1038, 175)
        Me.SplitContainer1.SplitterDistance = 505
        Me.SplitContainer1.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ParaList)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(505, 175)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Para Examination"
        '
        'ParaList
        '
        Me.ParaList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        ParaList_DesignTimeLayout.LayoutString = resources.GetString("ParaList_DesignTimeLayout.LayoutString")
        Me.ParaList.DesignTimeLayout = ParaList_DesignTimeLayout
        Me.ParaList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ParaList.GroupByBoxVisible = False
        Me.ParaList.Location = New System.Drawing.Point(3, 16)
        Me.ParaList.Name = "ParaList"
        Me.ParaList.RecordNavigator = True
        Me.ParaList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.ParaList.Size = New System.Drawing.Size(499, 156)
        Me.ParaList.TabIndex = 2
        Me.ParaList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.PrescriptionList)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(529, 175)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Prescription"
        '
        'PrescriptionList
        '
        Me.PrescriptionList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        PrescriptionList_DesignTimeLayout.LayoutString = resources.GetString("PrescriptionList_DesignTimeLayout.LayoutString")
        Me.PrescriptionList.DesignTimeLayout = PrescriptionList_DesignTimeLayout
        Me.PrescriptionList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrescriptionList.GroupByBoxVisible = False
        Me.PrescriptionList.Location = New System.Drawing.Point(3, 16)
        Me.PrescriptionList.Name = "PrescriptionList"
        Me.PrescriptionList.RecordNavigator = True
        Me.PrescriptionList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.PrescriptionList.Size = New System.Drawing.Size(523, 156)
        Me.PrescriptionList.TabIndex = 2
        Me.PrescriptionList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.OrderList)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1038, 296)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Order Medicine"
        '
        'OrderList
        '
        Me.OrderList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.OrderContextMenu.SetContextMenu(Me.OrderList, True)
        OrderList_DesignTimeLayout.LayoutString = resources.GetString("OrderList_DesignTimeLayout.LayoutString")
        Me.OrderList.DesignTimeLayout = OrderList_DesignTimeLayout
        Me.OrderList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderList.GroupByBoxVisible = False
        Me.OrderList.Location = New System.Drawing.Point(3, 16)
        Me.OrderList.Name = "OrderList"
        Me.OrderList.RecordNavigator = True
        Me.OrderList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.OrderList.Size = New System.Drawing.Size(1032, 277)
        Me.OrderList.TabIndex = 3
        Me.OrderList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'GroupBox8
        '
        Me.GroupBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox8.Controls.Add(Me.Label11)
        Me.GroupBox8.Controls.Add(Me.Label10)
        Me.GroupBox8.Controls.Add(Me.Label14)
        Me.GroupBox8.Controls.Add(Me.Label9)
        Me.GroupBox8.Controls.Add(Me.txtdollar)
        Me.GroupBox8.Controls.Add(Me.txtriel)
        Me.GroupBox8.Controls.Add(Me.txtexchangerate)
        Me.GroupBox8.Controls.Add(Me.txtdiscount)
        Me.GroupBox8.Controls.Add(Me.Label13)
        Me.GroupBox8.Controls.Add(Me.Label12)
        Me.GroupBox8.Font = New System.Drawing.Font("Khmer OS System", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(379, 639)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(674, 102)
        Me.GroupBox8.TabIndex = 6
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "ទូទាត់សរុប"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Khmer OS System", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(35, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 25)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "អត្រាប្តូរប្រាក់ ៖"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Khmer OS System", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(34, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 25)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "បញ្ចុះតំលៃ ៖"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Khmer OS System", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(612, 67)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 25)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "ដូល្លារ"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Khmer OS System", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(612, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 25)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "រៀល"
        '
        'txtdollar
        '
        Me.txtdollar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtdollar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdollar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtdollar.Location = New System.Drawing.Point(411, 61)
        Me.txtdollar.Name = "txtdollar"
        Me.txtdollar.ReadOnly = True
        Me.txtdollar.Size = New System.Drawing.Size(195, 31)
        Me.txtdollar.TabIndex = 7
        Me.txtdollar.Text = "0"
        Me.txtdollar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtriel
        '
        Me.txtriel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtriel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtriel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtriel.Location = New System.Drawing.Point(411, 19)
        Me.txtriel.Name = "txtriel"
        Me.txtriel.ReadOnly = True
        Me.txtriel.Size = New System.Drawing.Size(195, 31)
        Me.txtriel.TabIndex = 6
        Me.txtriel.Text = "0"
        Me.txtriel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtexchangerate
        '
        Me.txtexchangerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtexchangerate.Location = New System.Drawing.Point(155, 65)
        Me.txtexchangerate.Name = "txtexchangerate"
        Me.txtexchangerate.Size = New System.Drawing.Size(131, 29)
        Me.txtexchangerate.TabIndex = 5
        Me.txtexchangerate.Text = "4000"
        Me.txtexchangerate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtdiscount
        '
        Me.txtdiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiscount.Location = New System.Drawing.Point(155, 26)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.Size = New System.Drawing.Size(131, 29)
        Me.txtdiscount.TabIndex = 4
        Me.txtdiscount.Text = "0"
        Me.txtdiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Khmer OS System", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(292, 67)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 25)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "សរុប (ដូល្លារ) ​៖"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Khmer OS System", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(292, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 25)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "សរុប (រៀល) ៖"
        '
        'OrderContextMenu
        '
        Me.OrderContextMenu.Commands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.BtnAddOrder, Me.BtnDeleteOrder})
        Me.OrderContextMenu.Name = "OrderContextMenu"
        '
        'BtnAddOrder
        '
        Me.BtnAddOrder.Key = "DropDownCommand1"
        Me.BtnAddOrder.Name = "BtnAddOrder"
        Me.BtnAddOrder.Text = "Add Medicine Order"
        '
        'BtnDeleteOrder
        '
        Me.BtnDeleteOrder.Key = "DropDownCommand2"
        Me.BtnDeleteOrder.Name = "BtnDeleteOrder"
        Me.BtnDeleteOrder.Text = "Delete Medicine Order"
        '
        'txtparacharge
        '
        Me.txtparacharge.Location = New System.Drawing.Point(12, 650)
        Me.txtparacharge.Name = "txtparacharge"
        Me.txtparacharge.Size = New System.Drawing.Size(125, 20)
        Me.txtparacharge.TabIndex = 7
        Me.txtparacharge.Text = "0"
        Me.txtparacharge.Visible = False
        '
        'Err
        '
        Me.Err.ContainerControl = Me
        '
        'OfficeFormAdorner1
        '
        Me.OfficeFormAdorner1.Form = Me
        Me.OfficeFormAdorner1.Office2007CustomColor = System.Drawing.Color.Empty
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.AliceBlue
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolSave, Me.ToolStripSeparator1, Me.ToolCancel, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1062, 32)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolSave
        '
        Me.ToolSave.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ToolSave.ForeColor = System.Drawing.Color.Blue
        Me.ToolSave.Image = CType(resources.GetObject("ToolSave.Image"), System.Drawing.Image)
        Me.ToolSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolSave.Name = "ToolSave"
        Me.ToolSave.Size = New System.Drawing.Size(172, 29)
        Me.ToolSave.Text = "   Save and Print"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'ToolCancel
        '
        Me.ToolCancel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ToolCancel.ForeColor = System.Drawing.Color.Blue
        Me.ToolCancel.Image = CType(resources.GetObject("ToolCancel.Image"), System.Drawing.Image)
        Me.ToolCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolCancel.Name = "ToolCancel"
        Me.ToolCancel.Size = New System.Drawing.Size(70, 29)
        Me.ToolCancel.Text = "Exit"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(29, 29)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'NewInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1062, 742)
        Me.Controls.Add(Me.txtparacharge)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewInvoice"
        Me.ShowInTaskbar = False
        Me.Text = "New Invoice"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.ParaList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.PrescriptionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.OrderList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.Err, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfficeFormAdorner1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents ParaList As Janus.Windows.GridEX.GridEX
    Friend WithEvents PrescriptionList As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtsex As System.Windows.Forms.TextBox
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtinvoiceno As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DtInvoiceDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents labelcon As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtconsultfee As System.Windows.Forms.TextBox
    Friend WithEvents txtconsulttype As System.Windows.Forms.TextBox
    Friend WithEvents OrderList As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtdollar As System.Windows.Forms.TextBox
    Friend WithEvents txtriel As System.Windows.Forms.TextBox
    Friend WithEvents txtexchangerate As System.Windows.Forms.TextBox
    Friend WithEvents OrderContextMenu As Janus.Windows.Ribbon.RibbonContextMenu
    Friend WithEvents BtnAddOrder As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents BtnDeleteOrder As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtparacharge As System.Windows.Forms.TextBox
    Friend WithEvents Err As System.Windows.Forms.ErrorProvider
    Friend WithEvents OfficeFormAdorner1 As Janus.Windows.Ribbon.OfficeFormAdorner
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
