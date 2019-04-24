<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceivedItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReceivedItem))
        Dim GridEXReceive_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Dim GridEXReceiveDetail_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridExpend_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.BtnExpend = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.BtnFindRefer = New System.Windows.Forms.Button
        Me.TxtReferentNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.BtnFind = New System.Windows.Forms.Button
        Me.CboSupplier = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnPrintPreview = New System.Windows.Forms.Button
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.GridEXReceive = New Janus.Windows.GridEX.GridEX
        Me.VisualStyleManager1 = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.GridEXReceiveDetail = New Janus.Windows.GridEX.GridEX
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
        Me.GridExpend = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.GridEXReceive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.GridEXReceiveDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.GridExpend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.BtnExpend, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.ShowItemToolTips = False
        Me.ToolStrip1.Size = New System.Drawing.Size(1043, 58)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(148, 55)
        Me.ToolStripButton1.Text = "New Receive Order"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 58)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(173, 55)
        Me.ToolStripButton2.Text = "Refresh all information"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 58)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(74, 55)
        Me.ToolStripButton3.Text = "     Delete     "
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton3.Visible = False
        '
        'BtnExpend
        '
        Me.BtnExpend.ForeColor = System.Drawing.Color.White
        Me.BtnExpend.Image = CType(resources.GetObject("BtnExpend.Image"), System.Drawing.Image)
        Me.BtnExpend.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnExpend.Name = "BtnExpend"
        Me.BtnExpend.Size = New System.Drawing.Size(82, 55)
        Me.BtnExpend.Text = "     Expend      "
        Me.BtnExpend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 58)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 58)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1043, 678)
        Me.SplitContainer1.SplitterDistance = 115
        Me.SplitContainer1.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.BtnFindRefer)
        Me.Panel3.Controls.Add(Me.TxtReferentNo)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(474, 16)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(221, 87)
        Me.Panel3.TabIndex = 2
        '
        'BtnFindRefer
        '
        Me.BtnFindRefer.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnFindRefer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFindRefer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFindRefer.ForeColor = System.Drawing.Color.White
        Me.BtnFindRefer.Location = New System.Drawing.Point(109, 54)
        Me.BtnFindRefer.Name = "BtnFindRefer"
        Me.BtnFindRefer.Size = New System.Drawing.Size(107, 28)
        Me.BtnFindRefer.TabIndex = 7
        Me.BtnFindRefer.Text = "Find"
        Me.BtnFindRefer.UseVisualStyleBackColor = False
        '
        'TxtReferentNo
        '
        Me.TxtReferentNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReferentNo.Location = New System.Drawing.Point(7, 28)
        Me.TxtReferentNo.Name = "TxtReferentNo"
        Me.TxtReferentNo.Size = New System.Drawing.Size(209, 23)
        Me.TxtReferentNo.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Referrent invoice no:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BtnFind)
        Me.Panel2.Controls.Add(Me.CboSupplier)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(245, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(221, 87)
        Me.Panel2.TabIndex = 1
        '
        'BtnFind
        '
        Me.BtnFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFind.ForeColor = System.Drawing.Color.White
        Me.BtnFind.Location = New System.Drawing.Point(106, 54)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(107, 28)
        Me.BtnFind.TabIndex = 6
        Me.BtnFind.Text = "Find"
        Me.BtnFind.UseVisualStyleBackColor = False
        '
        'CboSupplier
        '
        Me.CboSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSupplier.FormattingEnabled = True
        Me.CboSupplier.Location = New System.Drawing.Point(3, 27)
        Me.CboSupplier.Name = "CboSupplier"
        Me.CboSupplier.Size = New System.Drawing.Size(209, 24)
        Me.CboSupplier.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Find by supplier:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnPrintPreview)
        Me.Panel1.Controls.Add(Me.DateTo)
        Me.Panel1.Controls.Add(Me.DateFrom)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(11, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(225, 87)
        Me.Panel1.TabIndex = 0
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrintPreview.ForeColor = System.Drawing.Color.White
        Me.BtnPrintPreview.Location = New System.Drawing.Point(111, 54)
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(107, 28)
        Me.BtnPrintPreview.TabIndex = 2
        Me.BtnPrintPreview.Text = "Find"
        Me.BtnPrintPreview.UseVisualStyleBackColor = False
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd/MM/yyyy"
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(70, 31)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(147, 20)
        Me.DateTo.TabIndex = 6
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(70, 7)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(147, 20)
        Me.DateFrom.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "From:"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GridEXReceive)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1043, 559)
        Me.SplitContainer2.SplitterDistance = 247
        Me.SplitContainer2.TabIndex = 2
        '
        'GridEXReceive
        '
        Me.GridEXReceive.BackColor = System.Drawing.SystemColors.Menu
        Me.GridEXReceive.ControlStyle.ControlColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridEXReceive.ControlStyle.ControlTextColor = System.Drawing.Color.Black
        Me.GridEXReceive.ControlStyle.HoverBaseColor = System.Drawing.Color.Honeydew
        Me.GridEXReceive.ControlStyle.ScrollBarColor = System.Drawing.Color.White
        Me.GridEXReceive.ControlStyle.WindowTextColor = System.Drawing.Color.Yellow
        Me.GridEXReceive.DefaultBackColorAlphaMode = Janus.Windows.GridEX.AlphaMode.Opaque
        GridEXReceive_DesignTimeLayout.LayoutString = resources.GetString("GridEXReceive_DesignTimeLayout.LayoutString")
        Me.GridEXReceive.DesignTimeLayout = GridEXReceive_DesignTimeLayout
        Me.GridEXReceive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEXReceive.FlatBorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.GridEXReceive.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.GridEXReceive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEXReceive.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridEXReceive.GroupByBoxVisible = False
        Me.GridEXReceive.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Red
        Me.GridEXReceive.HeaderFormatStyle.FontSize = 10.0!
        Me.GridEXReceive.HeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.GridEXReceive.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridEXReceive.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridEXReceive.Location = New System.Drawing.Point(0, 0)
        Me.GridEXReceive.Name = "GridEXReceive"
        Me.GridEXReceive.Office2007CustomColor = System.Drawing.Color.White
        Me.GridEXReceive.PreviewRowFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Flat
        Me.GridEXReceive.RecordNavigator = True
        Me.GridEXReceive.RowFormatStyle.Alpha = 1
        Me.GridEXReceive.RowFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Flat
        Me.GridEXReceive.RowHeaderFormatStyle.Alpha = 0
        Me.GridEXReceive.RowHeaderFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.RaisedLight
        Me.GridEXReceive.Size = New System.Drawing.Size(1043, 247)
        Me.GridEXReceive.TabIndex = 1
        Me.GridEXReceive.TableHeaderFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Flat
        Me.GridEXReceive.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridEXReceive.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEXReceive.VisualStyleManager = Me.VisualStyleManager1
        '
        'VisualStyleManager1
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.Color.Black
        JanusColorScheme1.MenuColor = System.Drawing.SystemColors.Control
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.Office2007CustomColor = System.Drawing.Color.White
        JanusColorScheme1.UseThemes = False
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Standard
        JanusColorScheme1.WindowColor = System.Drawing.Color.White
        Me.VisualStyleManager1.ColorSchemes.Add(JanusColorScheme1)
        Me.VisualStyleManager1.DefaultColorScheme = "Scheme0"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.UiGroupBox1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.UiGroupBox2)
        Me.SplitContainer3.Size = New System.Drawing.Size(1043, 308)
        Me.SplitContainer3.SplitterDistance = 662
        Me.SplitContainer3.TabIndex = 1
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Controls.Add(Me.GridEXReceiveDetail)
        Me.UiGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiGroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UiGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(662, 308)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.Text = "Item receive detail"
        '
        'GridEXReceiveDetail
        '
        Me.GridEXReceiveDetail.ControlStyle.ControlColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridEXReceiveDetail.ControlStyle.ControlTextColor = System.Drawing.Color.Black
        Me.GridEXReceiveDetail.ControlStyle.HoverBaseColor = System.Drawing.Color.Honeydew
        Me.GridEXReceiveDetail.ControlStyle.ScrollBarColor = System.Drawing.Color.White
        Me.GridEXReceiveDetail.ControlStyle.WindowTextColor = System.Drawing.Color.Yellow
        Me.GridEXReceiveDetail.DefaultBackColorAlphaMode = Janus.Windows.GridEX.AlphaMode.Opaque
        GridEXReceiveDetail_DesignTimeLayout.LayoutString = resources.GetString("GridEXReceiveDetail_DesignTimeLayout.LayoutString")
        Me.GridEXReceiveDetail.DesignTimeLayout = GridEXReceiveDetail_DesignTimeLayout
        Me.GridEXReceiveDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEXReceiveDetail.FlatBorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.GridEXReceiveDetail.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.GridEXReceiveDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridEXReceiveDetail.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridEXReceiveDetail.GroupByBoxVisible = False
        Me.GridEXReceiveDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Red
        Me.GridEXReceiveDetail.HeaderFormatStyle.FontSize = 10.0!
        Me.GridEXReceiveDetail.HeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.GridEXReceiveDetail.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridEXReceiveDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridEXReceiveDetail.Location = New System.Drawing.Point(3, 22)
        Me.GridEXReceiveDetail.Name = "GridEXReceiveDetail"
        Me.GridEXReceiveDetail.Office2007CustomColor = System.Drawing.Color.White
        Me.GridEXReceiveDetail.PreviewRowFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Flat
        Me.GridEXReceiveDetail.RecordNavigator = True
        Me.GridEXReceiveDetail.RowFormatStyle.Alpha = 1
        Me.GridEXReceiveDetail.RowFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Flat
        Me.GridEXReceiveDetail.RowHeaderFormatStyle.Alpha = 0
        Me.GridEXReceiveDetail.RowHeaderFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.RaisedLight
        Me.GridEXReceiveDetail.Size = New System.Drawing.Size(656, 283)
        Me.GridEXReceiveDetail.TabIndex = 2
        Me.GridEXReceiveDetail.TableHeaderFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Flat
        Me.GridEXReceiveDetail.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridEXReceiveDetail.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEXReceiveDetail.VisualStyleManager = Me.VisualStyleManager1
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Controls.Add(Me.GridExpend)
        Me.UiGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiGroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UiGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Size = New System.Drawing.Size(377, 308)
        Me.UiGroupBox2.TabIndex = 1
        Me.UiGroupBox2.Text = "Expend Detail"
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
        Me.GridExpend.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridExpend.Location = New System.Drawing.Point(3, 22)
        Me.GridExpend.Name = "GridExpend"
        Me.GridExpend.Office2007CustomColor = System.Drawing.Color.White
        Me.GridExpend.RecordNavigator = True
        Me.GridExpend.Size = New System.Drawing.Size(371, 283)
        Me.GridExpend.TabIndex = 1
        Me.GridExpend.VisualStyleManager = Me.VisualStyleManager1
        '
        'ReceivedItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "ReceivedItem"
        Me.Size = New System.Drawing.Size(1043, 736)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.GridEXReceive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.GridEXReceiveDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        CType(Me.GridExpend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GridEXReceive As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents CboSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents GridEXReceiveDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents VisualStyleManager1 As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnFindRefer As System.Windows.Forms.Button
    Friend WithEvents TxtReferentNo As System.Windows.Forms.TextBox
    Friend WithEvents BtnExpend As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents GridExpend As Janus.Windows.GridEX.GridEX

End Class
