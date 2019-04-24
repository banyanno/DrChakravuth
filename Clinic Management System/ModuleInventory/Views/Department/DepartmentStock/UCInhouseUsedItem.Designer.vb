<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCInhouseUsedItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCInhouseUsedItem))
        Dim gridItemUsed_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Dim GridUsedDetail_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Search = New System.Windows.Forms.GroupBox
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbItem = New System.Windows.Forms.ComboBox
        Me.dptToDate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.dptFromDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnNewInhouseUsed = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRefreshData = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.gridItemUsed = New Janus.Windows.GridEX.GridEX
        Me.VisualStyleManager1 = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GridUsedDetail = New Janus.Windows.GridEX.GridEX
        Me.BgLoadingData = New System.ComponentModel.BackgroundWorker
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnFind = New System.Windows.Forms.Button
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Search.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.gridItemUsed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridUsedDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Search)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1141, 504)
        Me.SplitContainer1.SplitterDistance = 117
        Me.SplitContainer1.TabIndex = 0
        '
        'Search
        '
        Me.Search.Controls.Add(Me.BtnFind)
        Me.Search.Controls.Add(Me.BtnPrint)
        Me.Search.Controls.Add(Me.Label4)
        Me.Search.Controls.Add(Me.cbItem)
        Me.Search.Controls.Add(Me.dptToDate)
        Me.Search.Controls.Add(Me.Label1)
        Me.Search.Controls.Add(Me.dptFromDate)
        Me.Search.Controls.Add(Me.Label2)
        Me.Search.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Search.Location = New System.Drawing.Point(0, 52)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(1141, 65)
        Me.Search.TabIndex = 1
        Me.Search.TabStop = False
        Me.Search.Text = "Print"
        '
        'BtnPrint
        '
        Me.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPrint.Location = New System.Drawing.Point(392, 14)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(139, 32)
        Me.BtnPrint.TabIndex = 13
        Me.BtnPrint.Text = "Print Preview"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(649, 33)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Item Name:"
        '
        'cbItem
        '
        Me.cbItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbItem.FormattingEnabled = True
        Me.cbItem.Location = New System.Drawing.Point(715, 18)
        Me.cbItem.Name = "cbItem"
        Me.cbItem.Size = New System.Drawing.Size(258, 28)
        Me.cbItem.TabIndex = 11
        '
        'dptToDate
        '
        Me.dptToDate.Checked = False
        Me.dptToDate.CustomFormat = "dd/MM/yyyy"
        Me.dptToDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dptToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dptToDate.Location = New System.Drawing.Point(245, 20)
        Me.dptToDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dptToDate.Name = "dptToDate"
        Me.dptToDate.Size = New System.Drawing.Size(131, 26)
        Me.dptToDate.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(194, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "To Date:"
        '
        'dptFromDate
        '
        Me.dptFromDate.Checked = False
        Me.dptFromDate.CustomFormat = "dd/MM/yyyy"
        Me.dptFromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dptFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dptFromDate.Location = New System.Drawing.Point(62, 20)
        Me.dptFromDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dptFromDate.Name = "dptFromDate"
        Me.dptFromDate.Size = New System.Drawing.Size(128, 26)
        Me.dptFromDate.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 33)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "From Date:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewInhouseUsed, Me.ToolStripSeparator4, Me.BtnRefreshData, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1141, 52)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNewInhouseUsed
        '
        Me.BtnNewInhouseUsed.ForeColor = System.Drawing.Color.White
        Me.BtnNewInhouseUsed.Image = CType(resources.GetObject("BtnNewInhouseUsed.Image"), System.Drawing.Image)
        Me.BtnNewInhouseUsed.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewInhouseUsed.Name = "BtnNewInhouseUsed"
        Me.BtnNewInhouseUsed.Size = New System.Drawing.Size(132, 49)
        Me.BtnNewInhouseUsed.Text = "   In-house Used Item   "
        Me.BtnNewInhouseUsed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 52)
        '
        'BtnRefreshData
        '
        Me.BtnRefreshData.ForeColor = System.Drawing.Color.White
        Me.BtnRefreshData.Image = CType(resources.GetObject("BtnRefreshData.Image"), System.Drawing.Image)
        Me.BtnRefreshData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefreshData.Name = "BtnRefreshData"
        Me.BtnRefreshData.Size = New System.Drawing.Size(101, 49)
        Me.BtnRefreshData.Text = "    Refresh Data    "
        Me.BtnRefreshData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.gridItemUsed)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1141, 383)
        Me.SplitContainer2.SplitterDistance = 667
        Me.SplitContainer2.TabIndex = 6
        '
        'gridItemUsed
        '
        gridItemUsed_DesignTimeLayout.LayoutString = resources.GetString("gridItemUsed_DesignTimeLayout.LayoutString")
        Me.gridItemUsed.DesignTimeLayout = gridItemUsed_DesignTimeLayout
        Me.gridItemUsed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridItemUsed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.gridItemUsed.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.gridItemUsed.GroupByBoxVisible = False
        Me.gridItemUsed.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.gridItemUsed.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.gridItemUsed.Location = New System.Drawing.Point(0, 0)
        Me.gridItemUsed.Name = "gridItemUsed"
        Me.gridItemUsed.Office2007CustomColor = System.Drawing.Color.White
        Me.gridItemUsed.RecordNavigator = True
        Me.gridItemUsed.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.gridItemUsed.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.gridItemUsed.Size = New System.Drawing.Size(667, 383)
        Me.gridItemUsed.TabIndex = 4
        Me.gridItemUsed.VisualStyleManager = Me.VisualStyleManager1
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridUsedDetail)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(470, 383)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item used detial"
        '
        'GridUsedDetail
        '
        Me.GridUsedDetail.BackColor = System.Drawing.Color.White
        GridUsedDetail_DesignTimeLayout.LayoutString = resources.GetString("GridUsedDetail_DesignTimeLayout.LayoutString")
        Me.GridUsedDetail.DesignTimeLayout = GridUsedDetail_DesignTimeLayout
        Me.GridUsedDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridUsedDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GridUsedDetail.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridUsedDetail.GroupByBoxVisible = False
        Me.GridUsedDetail.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.GridUsedDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridUsedDetail.Hierarchical = True
        Me.GridUsedDetail.Location = New System.Drawing.Point(3, 16)
        Me.GridUsedDetail.Name = "GridUsedDetail"
        Me.GridUsedDetail.Office2007CustomColor = System.Drawing.Color.White
        Me.GridUsedDetail.RecordNavigator = True
        Me.GridUsedDetail.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridUsedDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridUsedDetail.Size = New System.Drawing.Size(464, 364)
        Me.GridUsedDetail.TabIndex = 5
        Me.GridUsedDetail.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridUsedDetail.VisualStyleManager = Me.VisualStyleManager1
        '
        'BgLoadingData
        '
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 52)
        '
        'BtnFind
        '
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFind.Location = New System.Drawing.Point(976, 17)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(110, 30)
        Me.BtnFind.TabIndex = 14
        Me.BtnFind.Text = "Find"
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'UCInhouseUsedItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UCInhouseUsedItem"
        Me.Size = New System.Drawing.Size(1141, 504)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Search.ResumeLayout(False)
        Me.Search.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.gridItemUsed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridUsedDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Search As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbItem As System.Windows.Forms.ComboBox
    Friend WithEvents dptToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dptFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewInhouseUsed As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefreshData As System.Windows.Forms.ToolStripButton
    Friend WithEvents gridItemUsed As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BgLoadingData As System.ComponentModel.BackgroundWorker
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GridUsedDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents VisualStyleManager1 As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnFind As System.Windows.Forms.Button

End Class
