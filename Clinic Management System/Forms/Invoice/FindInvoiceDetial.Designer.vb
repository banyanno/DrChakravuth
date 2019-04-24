<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindInvoiceDetial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FindInvoiceDetial))
        Dim InvoiceList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnInvoiceKH = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnInvoiceEnglish = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.InvoiceList = New Janus.Windows.GridEX.GridEX
        Me.VisualStyleManager1 = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TxtPatientName = New System.Windows.Forms.TextBox
        Me.RadPatientName = New System.Windows.Forms.RadioButton
        Me.btnsearch = New System.Windows.Forms.Button
        Me.txtinvoiceno = New System.Windows.Forms.TextBox
        Me.txtpatientid = New System.Windows.Forms.TextBox
        Me.RadByInvoiceNo = New System.Windows.Forms.RadioButton
        Me.RadByPatientID = New System.Windows.Forms.RadioButton
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ErrValidate = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.bgloadingReport = New System.ComponentModel.BackgroundWorker
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.InvoiceList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ErrValidate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnInvoiceKH, Me.ToolStripSeparator2, Me.BtnInvoiceEnglish, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1156, 56)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnInvoiceKH
        '
        Me.BtnInvoiceKH.ForeColor = System.Drawing.Color.White
        Me.BtnInvoiceKH.Image = CType(resources.GetObject("BtnInvoiceKH.Image"), System.Drawing.Image)
        Me.BtnInvoiceKH.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnInvoiceKH.Name = "BtnInvoiceKH"
        Me.BtnInvoiceKH.Size = New System.Drawing.Size(135, 53)
        Me.BtnInvoiceKH.Text = "Invoice as Khmer"
        Me.BtnInvoiceKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 56)
        '
        'BtnInvoiceEnglish
        '
        Me.BtnInvoiceEnglish.ForeColor = System.Drawing.Color.White
        Me.BtnInvoiceEnglish.Image = CType(resources.GetObject("BtnInvoiceEnglish.Image"), System.Drawing.Image)
        Me.BtnInvoiceEnglish.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnInvoiceEnglish.Name = "BtnInvoiceEnglish"
        Me.BtnInvoiceEnglish.Size = New System.Drawing.Size(140, 53)
        Me.BtnInvoiceEnglish.Text = "Invoice as English"
        Me.BtnInvoiceEnglish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 56)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.InvoiceList)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(853, 241)
        Me.GroupBox1.TabIndex = 3
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
        Me.InvoiceList.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.InvoiceList.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.InvoiceList.RecordNavigator = True
        Me.InvoiceList.RowHeaderFormatStyle.FontSize = 10.0!
        Me.InvoiceList.SelectedInactiveFormatStyle.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.InvoiceList.Size = New System.Drawing.Size(847, 216)
        Me.InvoiceList.TabIndex = 0
        Me.InvoiceList.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.InvoiceList.VisualStyleManager = Me.VisualStyleManager1
        '
        'VisualStyleManager1
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme1.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        JanusColorScheme1.UseThemes = False
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Standard
        Me.VisualStyleManager1.ColorSchemes.Add(JanusColorScheme1)
        Me.VisualStyleManager1.DefaultColorScheme = "Scheme0"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 56)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.CrystalReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1156, 726)
        Me.SplitContainer1.SplitterDistance = 241
        Me.SplitContainer1.TabIndex = 4
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1156, 241)
        Me.SplitContainer2.SplitterDistance = 853
        Me.SplitContainer2.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtPatientName)
        Me.GroupBox3.Controls.Add(Me.RadPatientName)
        Me.GroupBox3.Controls.Add(Me.btnsearch)
        Me.GroupBox3.Controls.Add(Me.txtinvoiceno)
        Me.GroupBox3.Controls.Add(Me.txtpatientid)
        Me.GroupBox3.Controls.Add(Me.RadByInvoiceNo)
        Me.GroupBox3.Controls.Add(Me.RadByPatientID)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(299, 241)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search Invoice By:"
        '
        'TxtPatientName
        '
        Me.TxtPatientName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPatientName.Enabled = False
        Me.TxtPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientName.Location = New System.Drawing.Point(9, 166)
        Me.TxtPatientName.Name = "TxtPatientName"
        Me.TxtPatientName.Size = New System.Drawing.Size(268, 26)
        Me.TxtPatientName.TabIndex = 6
        '
        'RadPatientName
        '
        Me.RadPatientName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPatientName.AutoSize = True
        Me.RadPatientName.Location = New System.Drawing.Point(9, 139)
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
        Me.btnsearch.Location = New System.Drawing.Point(9, 198)
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
        Me.txtinvoiceno.Location = New System.Drawing.Point(9, 53)
        Me.txtinvoiceno.Name = "txtinvoiceno"
        Me.txtinvoiceno.Size = New System.Drawing.Size(268, 26)
        Me.txtinvoiceno.TabIndex = 3
        '
        'txtpatientid
        '
        Me.txtpatientid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtpatientid.Enabled = False
        Me.txtpatientid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpatientid.Location = New System.Drawing.Point(9, 108)
        Me.txtpatientid.Name = "txtpatientid"
        Me.txtpatientid.Size = New System.Drawing.Size(268, 26)
        Me.txtpatientid.TabIndex = 2
        '
        'RadByInvoiceNo
        '
        Me.RadByInvoiceNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadByInvoiceNo.AutoSize = True
        Me.RadByInvoiceNo.Checked = True
        Me.RadByInvoiceNo.Location = New System.Drawing.Point(9, 30)
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
        Me.RadByPatientID.Location = New System.Drawing.Point(9, 85)
        Me.RadByPatientID.Name = "RadByPatientID"
        Me.RadByPatientID.Size = New System.Drawing.Size(75, 17)
        Me.RadByPatientID.TabIndex = 0
        Me.RadByPatientID.Text = "Patient ID:"
        Me.RadByPatientID.UseVisualStyleBackColor = True
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
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1156, 481)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'ErrValidate
        '
        Me.ErrValidate.ContainerControl = Me
        '
        'bgloadingReport
        '
        Me.bgloadingReport.WorkerSupportsCancellation = True
        '
        'FindInvoiceDetial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 782)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FindInvoiceDetial"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Invoice"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.InvoiceList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ErrValidate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnInvoiceKH As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnInvoiceEnglish As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents InvoiceList As Janus.Windows.GridEX.GridEX
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents VisualStyleManager1 As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents RadPatientName As System.Windows.Forms.RadioButton
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents txtinvoiceno As System.Windows.Forms.TextBox
    Friend WithEvents txtpatientid As System.Windows.Forms.TextBox
    Friend WithEvents RadByInvoiceNo As System.Windows.Forms.RadioButton
    Friend WithEvents RadByPatientID As System.Windows.Forms.RadioButton
    Friend WithEvents ErrValidate As System.Windows.Forms.ErrorProvider
    Friend WithEvents bgloadingReport As System.ComponentModel.BackgroundWorker
End Class
