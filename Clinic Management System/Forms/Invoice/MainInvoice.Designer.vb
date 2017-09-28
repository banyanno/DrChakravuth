<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainInvoice
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
        Dim ExplorerBarItem1 As Janus.Windows.ExplorerBar.ExplorerBarItem = New Janus.Windows.ExplorerBar.ExplorerBarItem
        Dim ExplorerBarGroup2 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
        Dim ExplorerBarItem2 As Janus.Windows.ExplorerBar.ExplorerBarItem = New Janus.Windows.ExplorerBar.ExplorerBarItem
        Me.ExplorerBarContainerControl1 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtPatientName = New System.Windows.Forms.TextBox
        Me.RadPatientName = New System.Windows.Forms.RadioButton
        Me.btnsearch = New System.Windows.Forms.Button
        Me.txtinvoiceno = New System.Windows.Forms.TextBox
        Me.txtpatientid = New System.Windows.Forms.TextBox
        Me.RadByInvoiceNo = New System.Windows.Forms.RadioButton
        Me.RadByPatientID = New System.Windows.Forms.RadioButton
        Me.BtnFilterInvoice = New System.Windows.Forms.Button
        Me.dtTo = New System.Windows.Forms.DateTimePicker
        Me.dtFrom = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ExplorerBarContainerControl2 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
        Me.GroupIncome = New System.Windows.Forms.GroupBox
        Me.BtnIncomeShow = New System.Windows.Forms.Button
        Me.dtincometo = New System.Windows.Forms.DateTimePicker
        Me.dtincomefrom = New System.Windows.Forms.DateTimePicker
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.RadByExam = New System.Windows.Forms.RadioButton
        Me.RadByConsulation = New System.Windows.Forms.RadioButton
        Me.RadBySale = New System.Windows.Forms.RadioButton
        Me.RadByAll = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ExplorerBar1 = New Janus.Windows.ExplorerBar.ExplorerBar
        Me.ErrValidate = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BgLoading = New System.ComponentModel.BackgroundWorker
        Me.ExplorerBarContainerControl1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ExplorerBarContainerControl2.SuspendLayout()
        Me.GroupIncome.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ExplorerBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExplorerBar1.SuspendLayout()
        CType(Me.ErrValidate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExplorerBarContainerControl1
        '
        Me.ExplorerBarContainerControl1.BackColor = System.Drawing.SystemColors.Control
        Me.ExplorerBarContainerControl1.Controls.Add(Me.GroupBox1)
        Me.ExplorerBarContainerControl1.Location = New System.Drawing.Point(4, 26)
        Me.ExplorerBarContainerControl1.Name = "ExplorerBarContainerControl1"
        Me.ExplorerBarContainerControl1.Size = New System.Drawing.Size(217, 336)
        Me.ExplorerBarContainerControl1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.BtnFilterInvoice)
        Me.GroupBox1.Controls.Add(Me.dtTo)
        Me.GroupBox1.Controls.Add(Me.dtFrom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 336)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TxtPatientName)
        Me.GroupBox2.Controls.Add(Me.RadPatientName)
        Me.GroupBox2.Controls.Add(Me.btnsearch)
        Me.GroupBox2.Controls.Add(Me.txtinvoiceno)
        Me.GroupBox2.Controls.Add(Me.txtpatientid)
        Me.GroupBox2.Controls.Add(Me.RadByInvoiceNo)
        Me.GroupBox2.Controls.Add(Me.RadByPatientID)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 114)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(208, 216)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Invoice By:"
        '
        'TxtPatientName
        '
        Me.TxtPatientName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientName.Location = New System.Drawing.Point(-11, 155)
        Me.TxtPatientName.Name = "TxtPatientName"
        Me.TxtPatientName.Size = New System.Drawing.Size(202, 26)
        Me.TxtPatientName.TabIndex = 6
        '
        'RadPatientName
        '
        Me.RadPatientName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPatientName.AutoSize = True
        Me.RadPatientName.Location = New System.Drawing.Point(-11, 128)
        Me.RadPatientName.Name = "RadPatientName"
        Me.RadPatientName.Size = New System.Drawing.Size(92, 17)
        Me.RadPatientName.TabIndex = 5
        Me.RadPatientName.Text = "Patient Name:"
        Me.RadPatientName.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Location = New System.Drawing.Point(92, 185)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(103, 30)
        Me.btnsearch.TabIndex = 4
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'txtinvoiceno
        '
        Me.txtinvoiceno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtinvoiceno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinvoiceno.Location = New System.Drawing.Point(-11, 42)
        Me.txtinvoiceno.Name = "txtinvoiceno"
        Me.txtinvoiceno.Size = New System.Drawing.Size(202, 26)
        Me.txtinvoiceno.TabIndex = 3
        '
        'txtpatientid
        '
        Me.txtpatientid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtpatientid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpatientid.Location = New System.Drawing.Point(-11, 97)
        Me.txtpatientid.Name = "txtpatientid"
        Me.txtpatientid.Size = New System.Drawing.Size(202, 26)
        Me.txtpatientid.TabIndex = 2
        '
        'RadByInvoiceNo
        '
        Me.RadByInvoiceNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadByInvoiceNo.AutoSize = True
        Me.RadByInvoiceNo.Checked = True
        Me.RadByInvoiceNo.Location = New System.Drawing.Point(-11, 19)
        Me.RadByInvoiceNo.Name = "RadByInvoiceNo"
        Me.RadByInvoiceNo.Size = New System.Drawing.Size(80, 17)
        Me.RadByInvoiceNo.TabIndex = 1
        Me.RadByInvoiceNo.TabStop = True
        Me.RadByInvoiceNo.Text = "Invoice No:"
        Me.RadByInvoiceNo.UseVisualStyleBackColor = True
        '
        'RadByPatientID
        '
        Me.RadByPatientID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadByPatientID.AutoSize = True
        Me.RadByPatientID.Location = New System.Drawing.Point(-11, 74)
        Me.RadByPatientID.Name = "RadByPatientID"
        Me.RadByPatientID.Size = New System.Drawing.Size(75, 17)
        Me.RadByPatientID.TabIndex = 0
        Me.RadByPatientID.Text = "Patient ID:"
        Me.RadByPatientID.UseVisualStyleBackColor = True
        '
        'BtnFilterInvoice
        '
        Me.BtnFilterInvoice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFilterInvoice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFilterInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFilterInvoice.Location = New System.Drawing.Point(93, 81)
        Me.BtnFilterInvoice.Name = "BtnFilterInvoice"
        Me.BtnFilterInvoice.Size = New System.Drawing.Size(103, 27)
        Me.BtnFilterInvoice.TabIndex = 4
        Me.BtnFilterInvoice.Text = "Filter"
        Me.BtnFilterInvoice.UseVisualStyleBackColor = True
        '
        'dtTo
        '
        Me.dtTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtTo.CustomFormat = "dd/MM/yyyy"
        Me.dtTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTo.Location = New System.Drawing.Point(31, 52)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.ShowCheckBox = True
        Me.dtTo.Size = New System.Drawing.Size(166, 26)
        Me.dtTo.TabIndex = 3
        '
        'dtFrom
        '
        Me.dtFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFrom.Location = New System.Drawing.Point(31, 16)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.ShowCheckBox = True
        Me.dtFrom.Size = New System.Drawing.Size(166, 26)
        Me.dtFrom.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-9, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "To:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From:"
        '
        'ExplorerBarContainerControl2
        '
        Me.ExplorerBarContainerControl2.Controls.Add(Me.GroupIncome)
        Me.ExplorerBarContainerControl2.Location = New System.Drawing.Point(4, 387)
        Me.ExplorerBarContainerControl2.Name = "ExplorerBarContainerControl2"
        Me.ExplorerBarContainerControl2.Size = New System.Drawing.Size(217, 534)
        Me.ExplorerBarContainerControl2.TabIndex = 4
        '
        'GroupIncome
        '
        Me.GroupIncome.BackColor = System.Drawing.SystemColors.Control
        Me.GroupIncome.Controls.Add(Me.BtnIncomeShow)
        Me.GroupIncome.Controls.Add(Me.dtincometo)
        Me.GroupIncome.Controls.Add(Me.dtincomefrom)
        Me.GroupIncome.Controls.Add(Me.GroupBox4)
        Me.GroupIncome.Controls.Add(Me.Label3)
        Me.GroupIncome.Controls.Add(Me.Label4)
        Me.GroupIncome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupIncome.Enabled = False
        Me.GroupIncome.Location = New System.Drawing.Point(0, 0)
        Me.GroupIncome.Name = "GroupIncome"
        Me.GroupIncome.Size = New System.Drawing.Size(217, 534)
        Me.GroupIncome.TabIndex = 0
        Me.GroupIncome.TabStop = False
        '
        'BtnIncomeShow
        '
        Me.BtnIncomeShow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnIncomeShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIncomeShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIncomeShow.Location = New System.Drawing.Point(-5, 186)
        Me.BtnIncomeShow.Name = "BtnIncomeShow"
        Me.BtnIncomeShow.Size = New System.Drawing.Size(200, 34)
        Me.BtnIncomeShow.TabIndex = 9
        Me.BtnIncomeShow.Text = "Print Preview"
        Me.BtnIncomeShow.UseVisualStyleBackColor = True
        '
        'dtincometo
        '
        Me.dtincometo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtincometo.CustomFormat = "dd/MM/yyyy"
        Me.dtincometo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtincometo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtincometo.Location = New System.Drawing.Point(31, 55)
        Me.dtincometo.Name = "dtincometo"
        Me.dtincometo.ShowCheckBox = True
        Me.dtincometo.Size = New System.Drawing.Size(166, 26)
        Me.dtincometo.TabIndex = 7
        '
        'dtincomefrom
        '
        Me.dtincomefrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtincomefrom.CustomFormat = "dd/MM/yyyy"
        Me.dtincomefrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtincomefrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtincomefrom.Location = New System.Drawing.Point(31, 19)
        Me.dtincomefrom.Name = "dtincomefrom"
        Me.dtincomefrom.ShowCheckBox = True
        Me.dtincomefrom.Size = New System.Drawing.Size(166, 26)
        Me.dtincomefrom.TabIndex = 6
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.RadByExam)
        Me.GroupBox4.Controls.Add(Me.RadByConsulation)
        Me.GroupBox4.Controls.Add(Me.RadBySale)
        Me.GroupBox4.Controls.Add(Me.RadByAll)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(-5, 102)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(202, 69)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Income Type:"
        '
        'RadByExam
        '
        Me.RadByExam.AutoSize = True
        Me.RadByExam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadByExam.Location = New System.Drawing.Point(36, 124)
        Me.RadByExam.Name = "RadByExam"
        Me.RadByExam.Size = New System.Drawing.Size(158, 20)
        Me.RadByExam.TabIndex = 0
        Me.RadByExam.Text = "Para Examination Fee"
        Me.RadByExam.UseVisualStyleBackColor = True
        Me.RadByExam.Visible = False
        '
        'RadByConsulation
        '
        Me.RadByConsulation.AutoSize = True
        Me.RadByConsulation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadByConsulation.Location = New System.Drawing.Point(36, 64)
        Me.RadByConsulation.Name = "RadByConsulation"
        Me.RadByConsulation.Size = New System.Drawing.Size(126, 20)
        Me.RadByConsulation.TabIndex = 0
        Me.RadByConsulation.Text = "Consultation Fee"
        Me.RadByConsulation.UseVisualStyleBackColor = True
        Me.RadByConsulation.Visible = False
        '
        'RadBySale
        '
        Me.RadBySale.AutoSize = True
        Me.RadBySale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadBySale.Location = New System.Drawing.Point(36, 94)
        Me.RadBySale.Name = "RadBySale"
        Me.RadBySale.Size = New System.Drawing.Size(112, 20)
        Me.RadBySale.TabIndex = 0
        Me.RadBySale.Text = "Medicine Sale"
        Me.RadBySale.UseVisualStyleBackColor = True
        Me.RadBySale.Visible = False
        '
        'RadByAll
        '
        Me.RadByAll.AutoSize = True
        Me.RadByAll.Checked = True
        Me.RadByAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadByAll.Location = New System.Drawing.Point(17, 38)
        Me.RadByAll.Name = "RadByAll"
        Me.RadByAll.Size = New System.Drawing.Size(88, 20)
        Me.RadByAll.TabIndex = 0
        Me.RadByAll.TabStop = True
        Me.RadByAll.Text = "All Income"
        Me.RadByAll.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-26, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "To:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-26, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "From:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ExplorerBar1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1172, 938)
        Me.SplitContainer1.SplitterDistance = 943
        Me.SplitContainer1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(943, 938)
        Me.Panel1.TabIndex = 0
        '
        'ExplorerBar1
        '
        Me.ExplorerBar1.BackgroundFormatStyle.BackColor = System.Drawing.SystemColors.Control
        Me.ExplorerBar1.BackgroundFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.ExplorerBar1.BlendColor = System.Drawing.SystemColors.Control
        Me.ExplorerBar1.Controls.Add(Me.ExplorerBarContainerControl1)
        Me.ExplorerBar1.Controls.Add(Me.ExplorerBarContainerControl2)
        Me.ExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill
        ExplorerBarItem1.Container = True
        ExplorerBarItem1.ContainerControl = Me.ExplorerBarContainerControl1
        ExplorerBarItem1.ContainerHeight = 336
        ExplorerBarItem1.Key = "Item1"
        ExplorerBarItem1.Selected = True
        ExplorerBarItem1.Text = "New Item"
        ExplorerBarGroup1.Items.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarItem() {ExplorerBarItem1})
        ExplorerBarGroup1.Key = "Invoice"
        ExplorerBarGroup1.StateStyles.FormatStyle.FontSize = 12.0!
        ExplorerBarGroup1.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.Red
        ExplorerBarGroup1.Text = "Invoice"
        ExplorerBarItem2.Container = True
        ExplorerBarItem2.ContainerControl = Me.ExplorerBarContainerControl2
        ExplorerBarItem2.ContainerHeight = 534
        ExplorerBarItem2.Key = "Item1"
        ExplorerBarItem2.Text = "New Item"
        ExplorerBarGroup2.Items.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarItem() {ExplorerBarItem2})
        ExplorerBarGroup2.Key = "Income and Expense"
        ExplorerBarGroup2.StateStyles.FormatStyle.FontSize = 12.0!
        ExplorerBarGroup2.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.Red
        ExplorerBarGroup2.Text = "Income and Expense"
        Me.ExplorerBar1.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1, ExplorerBarGroup2})
        Me.ExplorerBar1.GroupsStateStyles.FormatStyle.BackColor = System.Drawing.SystemColors.Control
        Me.ExplorerBar1.Location = New System.Drawing.Point(0, 0)
        Me.ExplorerBar1.Name = "ExplorerBar1"
        Me.ExplorerBar1.Size = New System.Drawing.Size(225, 938)
        Me.ExplorerBar1.TabIndex = 0
        Me.ExplorerBar1.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.VS2005
        '
        'ErrValidate
        '
        Me.ErrValidate.ContainerControl = Me
        '
        'BgLoading
        '
        '
        'MainInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "MainInvoice"
        Me.Size = New System.Drawing.Size(1172, 938)
        Me.ExplorerBarContainerControl1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ExplorerBarContainerControl2.ResumeLayout(False)
        Me.GroupIncome.ResumeLayout(False)
        Me.GroupIncome.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ExplorerBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExplorerBar1.ResumeLayout(False)
        CType(Me.ErrValidate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ExplorerBar1 As Janus.Windows.ExplorerBar.ExplorerBar
    Friend WithEvents ExplorerBarContainerControl1 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnFilterInvoice As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtinvoiceno As System.Windows.Forms.TextBox
    Friend WithEvents txtpatientid As System.Windows.Forms.TextBox
    Friend WithEvents RadByInvoiceNo As System.Windows.Forms.RadioButton
    Friend WithEvents RadByPatientID As System.Windows.Forms.RadioButton
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ErrValidate As System.Windows.Forms.ErrorProvider
    Friend WithEvents ExplorerBarContainerControl2 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
    Friend WithEvents GroupIncome As System.Windows.Forms.GroupBox
    Friend WithEvents dtincometo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtincomefrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RadBySale As System.Windows.Forms.RadioButton
    Friend WithEvents RadByExam As System.Windows.Forms.RadioButton
    Friend WithEvents RadByConsulation As System.Windows.Forms.RadioButton
    Friend WithEvents RadByAll As System.Windows.Forms.RadioButton
    Friend WithEvents BtnIncomeShow As System.Windows.Forms.Button
    Friend WithEvents BgLoading As System.ComponentModel.BackgroundWorker
    Friend WithEvents TxtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents RadPatientName As System.Windows.Forms.RadioButton

End Class
