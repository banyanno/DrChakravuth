<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UPatientIssueReceipt
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
        Dim InvoiceList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UPatientIssueReceipt))
        Dim ParaList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim ConsultationList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim OrderList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnIssueReceipt = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRefreshIssueReceipt = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnNewExpend = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnSetExchangeRate = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDeletePreInvoice = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.InvoiceList = New Janus.Windows.GridEX.GridEX
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage2 = New Janus.Windows.UI.Tab.UITabPage
        Me.ParaList = New Janus.Windows.GridEX.GridEX
        Me.ContextMenuExam = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnAddParaExam = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDeleteParaExam = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.ConsultationService = New System.Windows.Forms.TabPage
        Me.ConsultationList = New Janus.Windows.GridEX.GridEX
        Me.ContextMenuConsultService = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnEditConsultation = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnDeleteConsultation = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnAddConsult = New System.Windows.Forms.ToolStripMenuItem
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.SaleMedicine = New System.Windows.Forms.TabPage
        Me.OrderList = New Janus.Windows.GridEX.GridEX
        Me.ContextMenuMedicine = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnAddMedicince = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDeleteMedicince = New System.Windows.Forms.ToolStripMenuItem
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtsubtotalusd = New System.Windows.Forms.TextBox
        Me.txttotalusd = New System.Windows.Forms.TextBox
        Me.txtSubtotalriel = New System.Windows.Forms.TextBox
        Me.txtcash = New System.Windows.Forms.TextBox
        Me.txtexchangerate = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtdiscount = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtchange = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.InvoiceList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.UiTabPage2.SuspendLayout()
        CType(Me.ParaList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuExam.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.ConsultationService.SuspendLayout()
        CType(Me.ConsultationList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuConsultService.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.SaleMedicine.SuspendLayout()
        CType(Me.OrderList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuMedicine.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnIssueReceipt, Me.ToolStripSeparator1, Me.BtnRefreshIssueReceipt, Me.ToolStripSeparator2, Me.BtnNewExpend, Me.ToolStripSeparator7, Me.BtnSetExchangeRate, Me.ToolStripSeparator8, Me.BtnDeletePreInvoice})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1312, 37)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnIssueReceipt
        '
        Me.BtnIssueReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIssueReceipt.ForeColor = System.Drawing.Color.Blue
        Me.BtnIssueReceipt.Image = Global.Clinic_Management_System.My.Resources.Resources.register
        Me.BtnIssueReceipt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnIssueReceipt.Name = "BtnIssueReceipt"
        Me.BtnIssueReceipt.Size = New System.Drawing.Size(169, 34)
        Me.BtnIssueReceipt.Text = "Issue Invoice (F4)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 37)
        '
        'BtnRefreshIssueReceipt
        '
        Me.BtnRefreshIssueReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefreshIssueReceipt.ForeColor = System.Drawing.Color.Blue
        Me.BtnRefreshIssueReceipt.Image = Global.Clinic_Management_System.My.Resources.Resources.refresh
        Me.BtnRefreshIssueReceipt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefreshIssueReceipt.Name = "BtnRefreshIssueReceipt"
        Me.BtnRefreshIssueReceipt.Size = New System.Drawing.Size(162, 34)
        Me.BtnRefreshIssueReceipt.Text = "Refresh List (F5)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 37)
        '
        'BtnNewExpend
        '
        Me.BtnNewExpend.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewExpend.ForeColor = System.Drawing.Color.Blue
        Me.BtnNewExpend.Image = Global.Clinic_Management_System.My.Resources.Resources.CashReceipt
        Me.BtnNewExpend.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewExpend.Name = "BtnNewExpend"
        Me.BtnNewExpend.Size = New System.Drawing.Size(132, 34)
        Me.BtnNewExpend.Text = "New Expend"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 37)
        '
        'BtnSetExchangeRate
        '
        Me.BtnSetExchangeRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSetExchangeRate.ForeColor = System.Drawing.Color.Blue
        Me.BtnSetExchangeRate.Image = Global.Clinic_Management_System.My.Resources.Resources.invoice
        Me.BtnSetExchangeRate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSetExchangeRate.Name = "BtnSetExchangeRate"
        Me.BtnSetExchangeRate.Size = New System.Drawing.Size(182, 34)
        Me.BtnSetExchangeRate.Text = "Set Exchange Rate"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 37)
        '
        'BtnDeletePreInvoice
        '
        Me.BtnDeletePreInvoice.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnDeletePreInvoice.ForeColor = System.Drawing.Color.Blue
        Me.BtnDeletePreInvoice.Image = Global.Clinic_Management_System.My.Resources.Resources.delete_appointment
        Me.BtnDeletePreInvoice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDeletePreInvoice.Name = "BtnDeletePreInvoice"
        Me.BtnDeletePreInvoice.Size = New System.Drawing.Size(180, 34)
        Me.BtnDeletePreInvoice.Text = "Delete Issue Invoice"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 37)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1312, 1077)
        Me.SplitContainer1.SplitterDistance = 296
        Me.SplitContainer1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SplitContainer3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1312, 296)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of Patient Waiting for Invoice"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 23)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.InvoiceList)
        Me.SplitContainer3.Panel2Collapsed = True
        Me.SplitContainer3.Size = New System.Drawing.Size(1306, 270)
        Me.SplitContainer3.SplitterDistance = 795
        Me.SplitContainer3.TabIndex = 1
        '
        'InvoiceList
        '
        Me.InvoiceList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        InvoiceList_DesignTimeLayout.LayoutString = resources.GetString("InvoiceList_DesignTimeLayout.LayoutString")
        Me.InvoiceList.DesignTimeLayout = InvoiceList_DesignTimeLayout
        Me.InvoiceList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InvoiceList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.InvoiceList.GroupByBoxVisible = False
        Me.InvoiceList.HeaderFormatStyle.FontSize = 12.0!
        Me.InvoiceList.HeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.InvoiceList.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.InvoiceList.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.InvoiceList.Location = New System.Drawing.Point(0, 0)
        Me.InvoiceList.Name = "InvoiceList"
        Me.InvoiceList.RecordNavigator = True
        Me.InvoiceList.RowHeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.InvoiceList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.InvoiceList.SelectedInactiveFormatStyle.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.InvoiceList.Size = New System.Drawing.Size(1306, 270)
        Me.InvoiceList.TabIndex = 3
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer4)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtsubtotalusd)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txttotalusd)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtSubtotalriel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtcash)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtexchangerate)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtdiscount)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtchange)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer2.Panel2Collapsed = True
        Me.SplitContainer2.Size = New System.Drawing.Size(1312, 777)
        Me.SplitContainer2.SplitterDistance = 696
        Me.SplitContainer2.TabIndex = 0
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.SplitContainer5)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.TabControl2)
        Me.SplitContainer4.Size = New System.Drawing.Size(1312, 777)
        Me.SplitContainer4.SplitterDistance = 306
        Me.SplitContainer4.TabIndex = 1
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer5.Name = "SplitContainer5"
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.UiTab1)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer5.Size = New System.Drawing.Size(1312, 306)
        Me.SplitContainer5.SplitterDistance = 723
        Me.SplitContainer5.TabIndex = 4
        '
        'UiTab1
        '
        Me.UiTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiTab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiTab1.Location = New System.Drawing.Point(0, 0)
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.Size = New System.Drawing.Size(723, 306)
        Me.UiTab1.TabIndex = 0
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage2})
        Me.UiTab1.TabsStateStyles.FormatStyle.FontSize = 11.0!
        '
        'UiTabPage2
        '
        Me.UiTabPage2.Controls.Add(Me.ParaList)
        Me.UiTabPage2.Key = "Examination Service"
        Me.UiTabPage2.Location = New System.Drawing.Point(1, 26)
        Me.UiTabPage2.Name = "UiTabPage2"
        Me.UiTabPage2.Size = New System.Drawing.Size(719, 277)
        Me.UiTabPage2.TabStop = True
        Me.UiTabPage2.Text = "Para Examination Service (F3)"
        '
        'ParaList
        '
        Me.ParaList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.ParaList.ContextMenuStrip = Me.ContextMenuExam
        ParaList_DesignTimeLayout.LayoutString = resources.GetString("ParaList_DesignTimeLayout.LayoutString")
        Me.ParaList.DesignTimeLayout = ParaList_DesignTimeLayout
        Me.ParaList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ParaList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ParaList.GroupByBoxVisible = False
        Me.ParaList.HeaderFormatStyle.FontSize = 11.0!
        Me.ParaList.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.ParaList.Location = New System.Drawing.Point(0, 0)
        Me.ParaList.Name = "ParaList"
        Me.ParaList.RecordNavigator = True
        Me.ParaList.RowHeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.ParaList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.ParaList.Size = New System.Drawing.Size(719, 277)
        Me.ParaList.TabIndex = 3
        '
        'ContextMenuExam
        '
        Me.ContextMenuExam.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ContextMenuExam.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnAddParaExam, Me.ToolStripSeparator3, Me.BtnDeleteParaExam, Me.ToolStripSeparator4})
        Me.ContextMenuExam.Name = "ContextMenuStrip1"
        Me.ContextMenuExam.Size = New System.Drawing.Size(270, 64)
        '
        'BtnAddParaExam
        '
        Me.BtnAddParaExam.Name = "BtnAddParaExam"
        Me.BtnAddParaExam.Size = New System.Drawing.Size(269, 24)
        Me.BtnAddParaExam.Text = "Add Para Examination (F3)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(266, 6)
        '
        'BtnDeleteParaExam
        '
        Me.BtnDeleteParaExam.Name = "BtnDeleteParaExam"
        Me.BtnDeleteParaExam.Size = New System.Drawing.Size(269, 24)
        Me.BtnDeleteParaExam.Text = "Delete Para Examination"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(266, 6)
        Me.ToolStripSeparator4.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.ConsultationService)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(585, 306)
        Me.TabControl1.TabIndex = 0
        '
        'ConsultationService
        '
        Me.ConsultationService.Controls.Add(Me.ConsultationList)
        Me.ConsultationService.Location = New System.Drawing.Point(4, 27)
        Me.ConsultationService.Name = "ConsultationService"
        Me.ConsultationService.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.ConsultationService.Size = New System.Drawing.Size(577, 275)
        Me.ConsultationService.TabIndex = 0
        Me.ConsultationService.Text = "Consultation Service"
        Me.ConsultationService.UseVisualStyleBackColor = True
        '
        'ConsultationList
        '
        Me.ConsultationList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.ConsultationList.ContextMenuStrip = Me.ContextMenuConsultService
        ConsultationList_DesignTimeLayout.LayoutString = resources.GetString("ConsultationList_DesignTimeLayout.LayoutString")
        Me.ConsultationList.DesignTimeLayout = ConsultationList_DesignTimeLayout
        Me.ConsultationList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConsultationList.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.ConsultationList.GroupByBoxVisible = False
        Me.ConsultationList.HeaderFormatStyle.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.ConsultationList.HeaderFormatStyle.FontSize = 11.0!
        Me.ConsultationList.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.ConsultationList.Location = New System.Drawing.Point(3, 3)
        Me.ConsultationList.Name = "ConsultationList"
        Me.ConsultationList.RecordNavigator = True
        Me.ConsultationList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.ConsultationList.Size = New System.Drawing.Size(571, 269)
        Me.ConsultationList.TabIndex = 2
        '
        'ContextMenuConsultService
        '
        Me.ContextMenuConsultService.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ContextMenuConsultService.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnEditConsultation, Me.ToolStripMenuItem1, Me.btnDeleteConsultation, Me.ToolStripMenuItem2, Me.BtnAddConsult})
        Me.ContextMenuConsultService.Name = "ContextMenuStrip1"
        Me.ContextMenuConsultService.Size = New System.Drawing.Size(216, 88)
        '
        'BtnEditConsultation
        '
        Me.BtnEditConsultation.Name = "BtnEditConsultation"
        Me.BtnEditConsultation.Size = New System.Drawing.Size(215, 24)
        Me.BtnEditConsultation.Text = "Edit Consultation"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(212, 6)
        Me.ToolStripMenuItem1.Visible = False
        '
        'btnDeleteConsultation
        '
        Me.btnDeleteConsultation.Name = "btnDeleteConsultation"
        Me.btnDeleteConsultation.Size = New System.Drawing.Size(215, 24)
        Me.btnDeleteConsultation.Text = "Delete Consultation"
        Me.btnDeleteConsultation.Visible = False
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(212, 6)
        Me.ToolStripMenuItem2.Visible = False
        '
        'BtnAddConsult
        '
        Me.BtnAddConsult.Name = "BtnAddConsult"
        Me.BtnAddConsult.Size = New System.Drawing.Size(215, 24)
        Me.BtnAddConsult.Text = "Add Consultation"
        Me.BtnAddConsult.Visible = False
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.SaleMedicine)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1312, 467)
        Me.TabControl2.TabIndex = 0
        '
        'SaleMedicine
        '
        Me.SaleMedicine.Controls.Add(Me.OrderList)
        Me.SaleMedicine.Location = New System.Drawing.Point(4, 29)
        Me.SaleMedicine.Name = "SaleMedicine"
        Me.SaleMedicine.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.SaleMedicine.Size = New System.Drawing.Size(1304, 434)
        Me.SaleMedicine.TabIndex = 0
        Me.SaleMedicine.Text = "Sale Medicine (F2)"
        Me.SaleMedicine.UseVisualStyleBackColor = True
        '
        'OrderList
        '
        Me.OrderList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.OrderList.ContextMenuStrip = Me.ContextMenuMedicine
        OrderList_DesignTimeLayout.LayoutString = resources.GetString("OrderList_DesignTimeLayout.LayoutString")
        Me.OrderList.DesignTimeLayout = OrderList_DesignTimeLayout
        Me.OrderList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.OrderList.GroupByBoxVisible = False
        Me.OrderList.HeaderFormatStyle.FontSize = 11.0!
        Me.OrderList.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.OrderList.Location = New System.Drawing.Point(3, 3)
        Me.OrderList.Name = "OrderList"
        Me.OrderList.RecordNavigator = True
        Me.OrderList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.OrderList.Size = New System.Drawing.Size(1298, 428)
        Me.OrderList.TabIndex = 4
        '
        'ContextMenuMedicine
        '
        Me.ContextMenuMedicine.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ContextMenuMedicine.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnAddMedicince, Me.ToolStripSeparator5, Me.BtnDeleteMedicince})
        Me.ContextMenuMedicine.Name = "ContextMenuStrip1"
        Me.ContextMenuMedicine.Size = New System.Drawing.Size(208, 80)
        '
        'BtnAddMedicince
        '
        Me.BtnAddMedicince.Name = "BtnAddMedicince"
        Me.BtnAddMedicince.Size = New System.Drawing.Size(207, 24)
        Me.BtnAddMedicince.Text = "Add Medicine (F2)"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(204, 6)
        '
        'BtnDeleteMedicince
        '
        Me.BtnDeleteMedicince.Name = "BtnDeleteMedicince"
        Me.BtnDeleteMedicince.Size = New System.Drawing.Size(207, 24)
        Me.BtnDeleteMedicince.Text = "Delete Medicine"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 25)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Sub Total (KHR):"
        '
        'txtsubtotalusd
        '
        Me.txtsubtotalusd.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubtotalusd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtsubtotalusd.Location = New System.Drawing.Point(188, 209)
        Me.txtsubtotalusd.Name = "txtsubtotalusd"
        Me.txtsubtotalusd.ReadOnly = True
        Me.txtsubtotalusd.Size = New System.Drawing.Size(284, 32)
        Me.txtsubtotalusd.TabIndex = 12
        Me.txtsubtotalusd.Text = "0"
        Me.txtsubtotalusd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttotalusd
        '
        Me.txttotalusd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalusd.Location = New System.Drawing.Point(188, 62)
        Me.txttotalusd.Name = "txttotalusd"
        Me.txttotalusd.ReadOnly = True
        Me.txttotalusd.Size = New System.Drawing.Size(284, 30)
        Me.txttotalusd.TabIndex = 11
        Me.txttotalusd.Text = "0"
        Me.txttotalusd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubtotalriel
        '
        Me.txtSubtotalriel.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotalriel.ForeColor = System.Drawing.Color.Black
        Me.txtSubtotalriel.Location = New System.Drawing.Point(188, 245)
        Me.txtSubtotalriel.Name = "txtSubtotalriel"
        Me.txtSubtotalriel.ReadOnly = True
        Me.txtSubtotalriel.Size = New System.Drawing.Size(284, 32)
        Me.txtSubtotalriel.TabIndex = 10
        Me.txtSubtotalriel.Text = "0"
        Me.txtSubtotalriel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtcash
        '
        Me.txtcash.BackColor = System.Drawing.Color.Red
        Me.txtcash.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcash.Location = New System.Drawing.Point(188, 26)
        Me.txtcash.Name = "txtcash"
        Me.txtcash.Size = New System.Drawing.Size(284, 30)
        Me.txtcash.TabIndex = 6
        Me.txtcash.Text = "0"
        Me.txtcash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtexchangerate
        '
        Me.txtexchangerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtexchangerate.Location = New System.Drawing.Point(188, 173)
        Me.txtexchangerate.Name = "txtexchangerate"
        Me.txtexchangerate.Size = New System.Drawing.Size(284, 30)
        Me.txtexchangerate.TabIndex = 9
        Me.txtexchangerate.Text = "4000"
        Me.txtexchangerate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Discount:"
        '
        'txtdiscount
        '
        Me.txtdiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiscount.Location = New System.Drawing.Point(188, 98)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.Size = New System.Drawing.Size(284, 30)
        Me.txtdiscount.TabIndex = 8
        Me.txtdiscount.Text = "0"
        Me.txtdiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Exchange Rate:"
        '
        'txtchange
        '
        Me.txtchange.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchange.Location = New System.Drawing.Point(188, 137)
        Me.txtchange.Name = "txtchange"
        Me.txtchange.ReadOnly = True
        Me.txtchange.Size = New System.Drawing.Size(284, 32)
        Me.txtchange.TabIndex = 7
        Me.txtchange.Text = "0"
        Me.txtchange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sub Total (USD):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total (USD):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Change(USD):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cash Received:"
        '
        'UPatientIssueReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "UPatientIssueReceipt"
        Me.Size = New System.Drawing.Size(1312, 1114)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.InvoiceList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        Me.SplitContainer5.ResumeLayout(False)
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        Me.UiTabPage2.ResumeLayout(False)
        CType(Me.ParaList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuExam.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ConsultationService.ResumeLayout(False)
        CType(Me.ConsultationList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuConsultService.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.SaleMedicine.ResumeLayout(False)
        CType(Me.OrderList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuMedicine.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnRefreshIssueReceipt As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnIssueReceipt As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage2 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents SaleMedicine As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txttotalusd As System.Windows.Forms.TextBox
    Friend WithEvents txtSubtotalriel As System.Windows.Forms.TextBox
    Friend WithEvents txtexchangerate As System.Windows.Forms.TextBox
    Friend WithEvents txtdiscount As System.Windows.Forms.TextBox
    Friend WithEvents txtchange As System.Windows.Forms.TextBox
    Friend WithEvents txtcash As System.Windows.Forms.TextBox
    Friend WithEvents InvoiceList As Janus.Windows.GridEX.GridEX
    Friend WithEvents ConsultationService As System.Windows.Forms.TabPage
    Friend WithEvents ConsultationList As Janus.Windows.GridEX.GridEX
    Friend WithEvents ParaList As Janus.Windows.GridEX.GridEX
    Friend WithEvents OrderList As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtsubtotalusd As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDeletePreInvoice As System.Windows.Forms.ToolStripButton
    Friend WithEvents ContextMenuConsultService As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnEditConsultation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDeleteConsultation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnAddConsult As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuExam As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnAddParaExam As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDeleteParaExam As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContextMenuMedicine As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnAddMedicince As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDeleteMedicince As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnNewExpend As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnSetExchangeRate As System.Windows.Forms.ToolStripButton

End Class
