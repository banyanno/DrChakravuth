<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvoiceDetial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InvoiceDetial))
        Dim GridExpend_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitInvoiceAndExpend = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.InvoiceList = New Janus.Windows.GridEX.GridEX
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GridExpend = New Janus.Windows.GridEX.GridEX
        Me.VisualStyleManager1 = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton
        Me.BtnInvoice = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.InvoiceAsEnglishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnUpdateExpend = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnViewListExpend = New System.Windows.Forms.ToolStripButton
        Me.BtnFindingInvoice = New System.Windows.Forms.ToolStripButton
        Me.bgloadingReport = New System.ComponentModel.BackgroundWorker
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitInvoiceAndExpend.Panel1.SuspendLayout()
        Me.SplitInvoiceAndExpend.Panel2.SuspendLayout()
        Me.SplitInvoiceAndExpend.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.InvoiceList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridExpend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 56)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitInvoiceAndExpend)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.CrystalReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1280, 634)
        Me.SplitContainer1.SplitterDistance = 275
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitInvoiceAndExpend
        '
        Me.SplitInvoiceAndExpend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitInvoiceAndExpend.Location = New System.Drawing.Point(0, 0)
        Me.SplitInvoiceAndExpend.Name = "SplitInvoiceAndExpend"
        '
        'SplitInvoiceAndExpend.Panel1
        '
        Me.SplitInvoiceAndExpend.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitInvoiceAndExpend.Panel1Collapsed = True
        '
        'SplitInvoiceAndExpend.Panel2
        '
        Me.SplitInvoiceAndExpend.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitInvoiceAndExpend.Size = New System.Drawing.Size(1280, 275)
        Me.SplitInvoiceAndExpend.SplitterDistance = 696
        Me.SplitInvoiceAndExpend.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.InvoiceList)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(696, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of Invoice Information"
        '
        'InvoiceList
        '
        InvoiceList_DesignTimeLayout.LayoutString = resources.GetString("InvoiceList_DesignTimeLayout.LayoutString")
        Me.InvoiceList.DesignTimeLayout = InvoiceList_DesignTimeLayout
        Me.InvoiceList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InvoiceList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.InvoiceList.GroupByBoxVisible = False
        Me.InvoiceList.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.InvoiceList.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.InvoiceList.Hierarchical = True
        Me.InvoiceList.Location = New System.Drawing.Point(3, 22)
        Me.InvoiceList.Name = "InvoiceList"
        Me.InvoiceList.RecordNavigator = True
        Me.InvoiceList.RowHeaderFormatStyle.FontSize = 10.0!
        Me.InvoiceList.SelectedInactiveFormatStyle.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.InvoiceList.Size = New System.Drawing.Size(690, 75)
        Me.InvoiceList.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridExpend)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1280, 275)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List of Expend Information"
        '
        'GridExpend
        '
        Me.GridExpend.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridExpend_DesignTimeLayout.LayoutString = resources.GetString("GridExpend_DesignTimeLayout.LayoutString")
        Me.GridExpend.DesignTimeLayout = GridExpend_DesignTimeLayout
        Me.GridExpend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridExpend.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridExpend.GroupByBoxVisible = False
        Me.GridExpend.HeaderFormatStyle.FontSize = 12.0!
        Me.GridExpend.HeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.GridExpend.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridExpend.Location = New System.Drawing.Point(3, 22)
        Me.GridExpend.Name = "GridExpend"
        Me.GridExpend.Office2007CustomColor = System.Drawing.Color.White
        Me.GridExpend.RecordNavigator = True
        Me.GridExpend.Size = New System.Drawing.Size(1274, 250)
        Me.GridExpend.TabIndex = 0
        Me.GridExpend.VisualStyleManager = Me.VisualStyleManager1
        '
        'VisualStyleManager1
        '
        JanusColorScheme2.HighlightTextColor = System.Drawing.Color.Black
        JanusColorScheme2.MenuColor = System.Drawing.SystemColors.Control
        JanusColorScheme2.Name = "Scheme0"
        JanusColorScheme2.Office2007CustomColor = System.Drawing.Color.White
        JanusColorScheme2.UseThemes = False
        JanusColorScheme2.VisualStyle = Janus.Windows.Common.VisualStyle.Standard
        JanusColorScheme2.WindowColor = System.Drawing.Color.White
        Me.VisualStyleManager1.ColorSchemes.Add(JanusColorScheme2)
        Me.VisualStyleManager1.DefaultColorScheme = "Scheme0"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1280, 355)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AllowItemReorder = True
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1, Me.ToolStripSeparator1, Me.BtnUpdateExpend, Me.ToolStripSeparator2, Me.BtnViewListExpend, Me.BtnFindingInvoice})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1280, 56)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DropDownButtonWidth = 25
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnInvoice, Me.ToolStripMenuItem1, Me.InvoiceAsEnglishToolStripMenuItem})
        Me.ToolStripSplitButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripSplitButton1.Image = Global.Clinic_Management_System.My.Resources.Resources.preview
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(147, 53)
        Me.ToolStripSplitButton1.Text = "     Invoices     "
        Me.ToolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripSplitButton1.Visible = False
        '
        'BtnInvoice
        '
        Me.BtnInvoice.ForeColor = System.Drawing.Color.Blue
        Me.BtnInvoice.Name = "BtnInvoice"
        Me.BtnInvoice.Size = New System.Drawing.Size(205, 24)
        Me.BtnInvoice.Text = "Invoice as Khmer"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(202, 6)
        '
        'InvoiceAsEnglishToolStripMenuItem
        '
        Me.InvoiceAsEnglishToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.InvoiceAsEnglishToolStripMenuItem.Name = "InvoiceAsEnglishToolStripMenuItem"
        Me.InvoiceAsEnglishToolStripMenuItem.Size = New System.Drawing.Size(205, 24)
        Me.InvoiceAsEnglishToolStripMenuItem.Text = "Invoice as English"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 56)
        '
        'BtnUpdateExpend
        '
        Me.BtnUpdateExpend.ForeColor = System.Drawing.Color.White
        Me.BtnUpdateExpend.Image = Global.Clinic_Management_System.My.Resources.Resources.edit
        Me.BtnUpdateExpend.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUpdateExpend.Name = "BtnUpdateExpend"
        Me.BtnUpdateExpend.Size = New System.Drawing.Size(111, 53)
        Me.BtnUpdateExpend.Text = "Upate Expend"
        Me.BtnUpdateExpend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 56)
        '
        'BtnViewListExpend
        '
        Me.BtnViewListExpend.ForeColor = System.Drawing.Color.White
        Me.BtnViewListExpend.Image = Global.Clinic_Management_System.My.Resources.Resources._1342235074_navigation_down_button_blue
        Me.BtnViewListExpend.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnViewListExpend.Name = "BtnViewListExpend"
        Me.BtnViewListExpend.Size = New System.Drawing.Size(133, 53)
        Me.BtnViewListExpend.Text = "View List Expend"
        Me.BtnViewListExpend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnViewListExpend.Visible = False
        '
        'BtnFindingInvoice
        '
        Me.BtnFindingInvoice.ForeColor = System.Drawing.Color.White
        Me.BtnFindingInvoice.Image = CType(resources.GetObject("BtnFindingInvoice.Image"), System.Drawing.Image)
        Me.BtnFindingInvoice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFindingInvoice.Name = "BtnFindingInvoice"
        Me.BtnFindingInvoice.Size = New System.Drawing.Size(121, 53)
        Me.BtnFindingInvoice.Text = "Finding Invoice"
        Me.BtnFindingInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bgloadingReport
        '
        Me.bgloadingReport.WorkerSupportsCancellation = True
        '
        'InvoiceDetial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "InvoiceDetial"
        Me.Size = New System.Drawing.Size(1280, 690)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitInvoiceAndExpend.Panel1.ResumeLayout(False)
        Me.SplitInvoiceAndExpend.Panel2.ResumeLayout(False)
        Me.SplitInvoiceAndExpend.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.InvoiceList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridExpend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents InvoiceList As Janus.Windows.GridEX.GridEX
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents bgloadingReport As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SplitInvoiceAndExpend As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridExpend As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnUpdateExpend As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnViewListExpend As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents BtnInvoice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents InvoiceAsEnglishToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisualStyleManager1 As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents BtnFindingInvoice As System.Windows.Forms.ToolStripButton

End Class
