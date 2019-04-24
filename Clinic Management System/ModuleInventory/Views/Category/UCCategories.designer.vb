<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCCategories
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
        Dim gridItems_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCCategories))
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Dim gridItemPrice_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim gridItemRecTrans_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridExpireDetail_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim gridItemProvider_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.TVCategories = New System.Windows.Forms.TreeView
        Me.MenuCreateCatAndItem = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.NewItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.gridItems = New Janus.Windows.GridEX.GridEX
        Me.VisualStyleManager1 = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtItemName = New System.Windows.Forms.TextBox
        Me.PicItem = New System.Windows.Forms.PictureBox
        Me.TxtBarcodeNo = New System.Windows.Forms.TextBox
        Me.RadItemName = New System.Windows.Forms.RadioButton
        Me.RadBarcodNo = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage3 = New Janus.Windows.UI.Tab.UITabPage
        Me.gridItemPrice = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.TBNewPrice = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnEditPrice = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.TBSetCurPrice = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.TBCurrentPrice = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRefreshData = New System.Windows.Forms.ToolStripButton
        Me.UiTabPage2 = New Janus.Windows.UI.Tab.UITabPage
        Me.gridItemRecTrans = New Janus.Windows.GridEX.GridEX
        Me.UiTabPage5 = New Janus.Windows.UI.Tab.UITabPage
        Me.GridExpireDetail = New Janus.Windows.GridEX.GridEX
        Me.UiTabPage4 = New Janus.Windows.UI.Tab.UITabPage
        Me.gridItemProvider = New Janus.Windows.GridEX.GridEX
        Me.lblCateName = New System.Windows.Forms.Label
        Me.ImageListCate = New System.Windows.Forms.ImageList(Me.components)
        Me.BgLoadingCategories = New System.ComponentModel.BackgroundWorker
        Me.BgAfterTVSelected = New System.ComponentModel.BackgroundWorker
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator
        Me.RefreshItemInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.MenuCreateCatAndItem.SuspendLayout()
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.UiTabPage3.SuspendLayout()
        CType(Me.gridItemPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.UiTabPage2.SuspendLayout()
        CType(Me.gridItemRecTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabPage5.SuspendLayout()
        CType(Me.GridExpireDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabPage4.SuspendLayout()
        CType(Me.gridItemProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TVCategories
        '
        Me.TVCategories.BackColor = System.Drawing.SystemColors.Window
        Me.TVCategories.ContextMenuStrip = Me.MenuCreateCatAndItem
        Me.TVCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TVCategories.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TVCategories.HideSelection = False
        Me.TVCategories.Location = New System.Drawing.Point(0, 0)
        Me.TVCategories.Name = "TVCategories"
        Me.TVCategories.Size = New System.Drawing.Size(232, 202)
        Me.TVCategories.TabIndex = 6
        '
        'MenuCreateCatAndItem
        '
        Me.MenuCreateCatAndItem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewCategoryToolStripMenuItem, Me.ToolStripMenuItem3, Me.NewItemToolStripMenuItem})
        Me.MenuCreateCatAndItem.Name = "MenuCreateCatAndItem"
        Me.MenuCreateCatAndItem.Size = New System.Drawing.Size(150, 54)
        '
        'NewCategoryToolStripMenuItem
        '
        Me.NewCategoryToolStripMenuItem.Name = "NewCategoryToolStripMenuItem"
        Me.NewCategoryToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.NewCategoryToolStripMenuItem.Text = "New Category"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(146, 6)
        '
        'NewItemToolStripMenuItem
        '
        Me.NewItemToolStripMenuItem.Name = "NewItemToolStripMenuItem"
        Me.NewItemToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.NewItemToolStripMenuItem.Text = "New Item"
        '
        'gridItems
        '
        Me.gridItems.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridItems_DesignTimeLayout.LayoutString = resources.GetString("gridItems_DesignTimeLayout.LayoutString")
        Me.gridItems.DesignTimeLayout = gridItems_DesignTimeLayout
        Me.gridItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridItems.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.gridItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.gridItems.GroupByBoxVisible = False
        Me.gridItems.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.gridItems.Location = New System.Drawing.Point(0, 0)
        Me.gridItems.Name = "gridItems"
        Me.gridItems.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.gridItems.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gridItems.RecordNavigator = True
        Me.gridItems.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.gridItems.SelectedFormatStyle.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.gridItems.SelectedInactiveFormatStyle.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.gridItems.Size = New System.Drawing.Size(876, 190)
        Me.gridItems.TabIndex = 7
        Me.gridItems.VisualStyleManager = Me.VisualStyleManager1
        Me.gridItems.WatermarkImage.Alpha = 150
        Me.gridItems.WatermarkImage.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.gridItems.WatermarkImage.Size = New System.Drawing.Size(150, 150)
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
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 57)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblCateName)
        Me.SplitContainer1.Size = New System.Drawing.Size(1112, 492)
        Me.SplitContainer1.SplitterDistance = 232
        Me.SplitContainer1.TabIndex = 8
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer3.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.TVCategories)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer3.Size = New System.Drawing.Size(232, 467)
        Me.SplitContainer3.SplitterDistance = 202
        Me.SplitContainer3.SplitterWidth = 3
        Me.SplitContainer3.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtItemName)
        Me.GroupBox1.Controls.Add(Me.PicItem)
        Me.GroupBox1.Controls.Add(Me.TxtBarcodeNo)
        Me.GroupBox1.Controls.Add(Me.RadItemName)
        Me.GroupBox1.Controls.Add(Me.RadBarcodNo)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(232, 262)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Find Item By"
        '
        'TxtItemName
        '
        Me.TxtItemName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemName.Location = New System.Drawing.Point(4, 88)
        Me.TxtItemName.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtItemName.Name = "TxtItemName"
        Me.TxtItemName.Size = New System.Drawing.Size(224, 26)
        Me.TxtItemName.TabIndex = 4
        '
        'PicItem
        '
        Me.PicItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicItem.Location = New System.Drawing.Point(4, 201)
        Me.PicItem.Margin = New System.Windows.Forms.Padding(2)
        Me.PicItem.Name = "PicItem"
        Me.PicItem.Size = New System.Drawing.Size(224, 89)
        Me.PicItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicItem.TabIndex = 3
        Me.PicItem.TabStop = False
        '
        'TxtBarcodeNo
        '
        Me.TxtBarcodeNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBarcodeNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBarcodeNo.Location = New System.Drawing.Point(4, 40)
        Me.TxtBarcodeNo.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBarcodeNo.Name = "TxtBarcodeNo"
        Me.TxtBarcodeNo.Size = New System.Drawing.Size(224, 26)
        Me.TxtBarcodeNo.TabIndex = 1
        '
        'RadItemName
        '
        Me.RadItemName.AutoSize = True
        Me.RadItemName.Location = New System.Drawing.Point(4, 67)
        Me.RadItemName.Margin = New System.Windows.Forms.Padding(2)
        Me.RadItemName.Name = "RadItemName"
        Me.RadItemName.Size = New System.Drawing.Size(79, 17)
        Me.RadItemName.TabIndex = 0
        Me.RadItemName.Text = "Item Name:"
        Me.RadItemName.UseVisualStyleBackColor = True
        '
        'RadBarcodNo
        '
        Me.RadBarcodNo.AutoSize = True
        Me.RadBarcodNo.Checked = True
        Me.RadBarcodNo.Location = New System.Drawing.Point(4, 19)
        Me.RadBarcodNo.Margin = New System.Windows.Forms.Padding(2)
        Me.RadBarcodNo.Name = "RadBarcodNo"
        Me.RadBarcodNo.Size = New System.Drawing.Size(85, 17)
        Me.RadBarcodNo.TabIndex = 0
        Me.RadBarcodNo.TabStop = True
        Me.RadBarcodNo.Text = "Barcode No:"
        Me.RadBarcodNo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(232, 25)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Categories"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 26)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.gridItems)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer2.Size = New System.Drawing.Size(876, 466)
        Me.SplitContainer2.SplitterDistance = 190
        Me.SplitContainer2.TabIndex = 15
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.UiTab1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(876, 272)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'UiTab1
        '
        Me.UiTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiTab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.UiTab1.Location = New System.Drawing.Point(3, 16)
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiTab1.Size = New System.Drawing.Size(870, 253)
        Me.UiTab1.TabIndex = 0
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage3, Me.UiTabPage2, Me.UiTabPage5, Me.UiTabPage4})
        Me.UiTab1.VisualStyleManager = Me.VisualStyleManager1
        '
        'UiTabPage3
        '
        Me.UiTabPage3.Controls.Add(Me.gridItemPrice)
        Me.UiTabPage3.Controls.Add(Me.ToolStrip2)
        Me.UiTabPage3.Location = New System.Drawing.Point(1, 23)
        Me.UiTabPage3.Name = "UiTabPage3"
        Me.UiTabPage3.Size = New System.Drawing.Size(868, 229)
        Me.UiTabPage3.TabStop = True
        Me.UiTabPage3.Text = "Item Price"
        '
        'gridItemPrice
        '
        Me.gridItemPrice.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridItemPrice_DesignTimeLayout.LayoutString = resources.GetString("gridItemPrice_DesignTimeLayout.LayoutString")
        Me.gridItemPrice.DesignTimeLayout = gridItemPrice_DesignTimeLayout
        Me.gridItemPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridItemPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.gridItemPrice.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.gridItemPrice.GroupByBoxVisible = False
        Me.gridItemPrice.Location = New System.Drawing.Point(0, 25)
        Me.gridItemPrice.Name = "gridItemPrice"
        Me.gridItemPrice.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.gridItemPrice.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gridItemPrice.RecordNavigator = True
        Me.gridItemPrice.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.gridItemPrice.Size = New System.Drawing.Size(868, 204)
        Me.gridItemPrice.TabIndex = 7
        Me.gridItemPrice.VisualStyleManager = Me.VisualStyleManager1
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TBNewPrice, Me.ToolStripSeparator2, Me.BtnEditPrice, Me.ToolStripSeparator6, Me.TBSetCurPrice, Me.ToolStripSeparator3, Me.TBCurrentPrice, Me.ToolStripSeparator5, Me.BtnRefreshData})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(868, 25)
        Me.ToolStrip2.TabIndex = 8
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'TBNewPrice
        '
        Me.TBNewPrice.Image = Global.Clinic_Management_System.My.Resources.Resources.price
        Me.TBNewPrice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TBNewPrice.Name = "TBNewPrice"
        Me.TBNewPrice.Size = New System.Drawing.Size(87, 22)
        Me.TBNewPrice.Text = "New Price"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BtnEditPrice
        '
        Me.BtnEditPrice.Image = Global.Clinic_Management_System.My.Resources.Resources.edit
        Me.BtnEditPrice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditPrice.Name = "BtnEditPrice"
        Me.BtnEditPrice.Size = New System.Drawing.Size(84, 22)
        Me.BtnEditPrice.Text = "Edit Price"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'TBSetCurPrice
        '
        Me.TBSetCurPrice.Image = Global.Clinic_Management_System.My.Resources.Resources.check
        Me.TBSetCurPrice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TBSetCurPrice.Name = "TBSetCurPrice"
        Me.TBSetCurPrice.Size = New System.Drawing.Size(150, 22)
        Me.TBSetCurPrice.Text = "Set As Current Price"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'TBCurrentPrice
        '
        Me.TBCurrentPrice.Image = Global.Clinic_Management_System.My.Resources.Resources.preview
        Me.TBCurrentPrice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TBCurrentPrice.Name = "TBCurrentPrice"
        Me.TBCurrentPrice.Size = New System.Drawing.Size(108, 22)
        Me.TBCurrentPrice.Text = "Current Price"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator5.Visible = False
        '
        'BtnRefreshData
        '
        Me.BtnRefreshData.Image = Global.Clinic_Management_System.My.Resources.Resources.view_refresh
        Me.BtnRefreshData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefreshData.Name = "BtnRefreshData"
        Me.BtnRefreshData.Size = New System.Drawing.Size(107, 22)
        Me.BtnRefreshData.Text = "Refresh Data"
        Me.BtnRefreshData.Visible = False
        '
        'UiTabPage2
        '
        Me.UiTabPage2.Controls.Add(Me.gridItemRecTrans)
        Me.UiTabPage2.Location = New System.Drawing.Point(1, 23)
        Me.UiTabPage2.Name = "UiTabPage2"
        Me.UiTabPage2.Size = New System.Drawing.Size(868, 229)
        Me.UiTabPage2.TabStop = True
        Me.UiTabPage2.Text = "Item Received Transaction"
        '
        'gridItemRecTrans
        '
        Me.gridItemRecTrans.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridItemRecTrans_DesignTimeLayout.LayoutString = resources.GetString("gridItemRecTrans_DesignTimeLayout.LayoutString")
        Me.gridItemRecTrans.DesignTimeLayout = gridItemRecTrans_DesignTimeLayout
        Me.gridItemRecTrans.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridItemRecTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.gridItemRecTrans.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.gridItemRecTrans.GroupByBoxVisible = False
        Me.gridItemRecTrans.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.gridItemRecTrans.Location = New System.Drawing.Point(0, 0)
        Me.gridItemRecTrans.Name = "gridItemRecTrans"
        Me.gridItemRecTrans.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.gridItemRecTrans.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gridItemRecTrans.RecordNavigator = True
        Me.gridItemRecTrans.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.gridItemRecTrans.Size = New System.Drawing.Size(868, 229)
        Me.gridItemRecTrans.TabIndex = 8
        Me.gridItemRecTrans.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.gridItemRecTrans.VisualStyleManager = Me.VisualStyleManager1
        '
        'UiTabPage5
        '
        Me.UiTabPage5.Controls.Add(Me.GridExpireDetail)
        Me.UiTabPage5.Location = New System.Drawing.Point(1, 23)
        Me.UiTabPage5.Name = "UiTabPage5"
        Me.UiTabPage5.Size = New System.Drawing.Size(740, 240)
        Me.UiTabPage5.TabStop = True
        Me.UiTabPage5.Text = "QTY Expire Date"
        '
        'GridExpireDetail
        '
        Me.GridExpireDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridExpireDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridExpireDetail_DesignTimeLayout.LayoutString = resources.GetString("GridExpireDetail_DesignTimeLayout.LayoutString")
        Me.GridExpireDetail.DesignTimeLayout = GridExpireDetail_DesignTimeLayout
        Me.GridExpireDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridExpireDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GridExpireDetail.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridExpireDetail.GroupByBoxVisible = False
        Me.GridExpireDetail.Location = New System.Drawing.Point(0, 0)
        Me.GridExpireDetail.Name = "GridExpireDetail"
        Me.GridExpireDetail.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.GridExpireDetail.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridExpireDetail.RecordNavigator = True
        Me.GridExpireDetail.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridExpireDetail.Size = New System.Drawing.Size(740, 240)
        Me.GridExpireDetail.TabIndex = 10
        Me.GridExpireDetail.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridExpireDetail.VisualStyleManager = Me.VisualStyleManager1
        '
        'UiTabPage4
        '
        Me.UiTabPage4.Controls.Add(Me.gridItemProvider)
        Me.UiTabPage4.Location = New System.Drawing.Point(1, 23)
        Me.UiTabPage4.Name = "UiTabPage4"
        Me.UiTabPage4.Size = New System.Drawing.Size(868, 229)
        Me.UiTabPage4.TabStop = True
        Me.UiTabPage4.Text = "Item Provider"
        '
        'gridItemProvider
        '
        Me.gridItemProvider.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridItemProvider_DesignTimeLayout.LayoutString = resources.GetString("gridItemProvider_DesignTimeLayout.LayoutString")
        Me.gridItemProvider.DesignTimeLayout = gridItemProvider_DesignTimeLayout
        Me.gridItemProvider.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridItemProvider.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.gridItemProvider.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.gridItemProvider.GroupByBoxVisible = False
        Me.gridItemProvider.Location = New System.Drawing.Point(0, 0)
        Me.gridItemProvider.Name = "gridItemProvider"
        Me.gridItemProvider.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.gridItemProvider.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gridItemProvider.RecordNavigator = True
        Me.gridItemProvider.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.gridItemProvider.Size = New System.Drawing.Size(868, 229)
        Me.gridItemProvider.TabIndex = 9
        Me.gridItemProvider.VisualStyleManager = Me.VisualStyleManager1
        '
        'lblCateName
        '
        Me.lblCateName.BackColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblCateName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCateName.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCateName.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCateName.ForeColor = System.Drawing.Color.White
        Me.lblCateName.Location = New System.Drawing.Point(0, 0)
        Me.lblCateName.Name = "lblCateName"
        Me.lblCateName.Size = New System.Drawing.Size(876, 26)
        Me.lblCateName.TabIndex = 14
        Me.lblCateName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ImageListCate
        '
        Me.ImageListCate.ImageStream = CType(resources.GetObject("ImageListCate.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListCate.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListCate.Images.SetKeyName(0, "Category 30px.png")
        '
        'BgLoadingCategories
        '
        '
        'BgAfterTVSelected
        '
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ToolStrip1.GripMargin = New System.Windows.Forms.Padding(1)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator8, Me.ToolStripButton3, Me.ToolStripSeparator9, Me.ToolStripButton2, Me.ToolStripSeparator10, Me.ToolStripButton4, Me.ToolStripSeparator11, Me.ToolStripButton5, Me.ToolStripSeparator12, Me.ToolStripButton6, Me.ToolStripSeparator13, Me.ToolStripButton7, Me.ToolStripSeparator14, Me.ToolStripSplitButton1, Me.ToolStripSeparator1, Me.btnDeleteItem})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1112, 57)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(129, 54)
        Me.ToolStripButton1.Text = "   New category   "
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 57)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(101, 54)
        Me.ToolStripButton3.Text = "Edit category"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 57)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(101, 54)
        Me.ToolStripButton2.Text = "   New item   "
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 57)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(73, 54)
        Me.ToolStripButton4.Text = "Edit item"
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 57)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(93, 54)
        Me.ToolStripButton5.Text = "Adjust stock"
        Me.ToolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 57)
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(120, 54)
        Me.ToolStripButton6.Text = "Veiw item detial"
        Me.ToolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 57)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(118, 54)
        Me.ToolStripButton7.Text = "Print list of item"
        Me.ToolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(6, 57)
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DropDownButtonWidth = 30
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem7, Me.RefreshItemInformationToolStripMenuItem})
        Me.ToolStripSplitButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(129, 54)
        Me.ToolStripSplitButton1.Text = "Refresh Data"
        Me.ToolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(240, 6)
        Me.ToolStripMenuItem7.Visible = False
        '
        'RefreshItemInformationToolStripMenuItem
        '
        Me.RefreshItemInformationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RefreshItemInformationToolStripMenuItem.Name = "RefreshItemInformationToolStripMenuItem"
        Me.RefreshItemInformationToolStripMenuItem.Size = New System.Drawing.Size(243, 24)
        Me.RefreshItemInformationToolStripMenuItem.Text = "Refresh Item Information"
        Me.RefreshItemInformationToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 57)
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.ForeColor = System.Drawing.Color.White
        Me.btnDeleteItem.Image = CType(resources.GetObject("btnDeleteItem.Image"), System.Drawing.Image)
        Me.btnDeleteItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(111, 54)
        Me.btnDeleteItem.Text = "  Delete Item   "
        Me.btnDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'UCCategories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "UCCategories"
        Me.Size = New System.Drawing.Size(1112, 549)
        Me.MenuCreateCatAndItem.ResumeLayout(False)
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PicItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        Me.UiTabPage3.ResumeLayout(False)
        Me.UiTabPage3.PerformLayout()
        CType(Me.gridItemPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.UiTabPage2.ResumeLayout(False)
        CType(Me.gridItemRecTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabPage5.ResumeLayout(False)
        CType(Me.GridExpireDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabPage4.ResumeLayout(False)
        CType(Me.gridItemProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TVCategories As System.Windows.Forms.TreeView
    Friend WithEvents gridItems As Janus.Windows.GridEX.GridEX
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ImageListCate As System.Windows.Forms.ImageList
    Friend WithEvents BgLoadingCategories As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCateName As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage3 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents gridItemPrice As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents RadItemName As System.Windows.Forms.RadioButton
    Friend WithEvents RadBarcodNo As System.Windows.Forms.RadioButton
    Friend WithEvents TxtBarcodeNo As System.Windows.Forms.TextBox
    Friend WithEvents PicItem As System.Windows.Forms.PictureBox
    Friend WithEvents MenuCreateCatAndItem As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewCategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BgAfterTVSelected As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtItemName As System.Windows.Forms.TextBox
    Friend WithEvents UiTabPage2 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents gridItemRecTrans As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiTabPage4 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents gridItemProvider As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents TBNewPrice As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnEditPrice As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TBSetCurPrice As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TBCurrentPrice As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefreshData As System.Windows.Forms.ToolStripButton
    Friend WithEvents UiTabPage5 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridExpireDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents VisualStyleManager1 As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshItemInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDeleteItem As System.Windows.Forms.ToolStripButton

End Class
