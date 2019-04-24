<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardHepatiteB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardHepatiteB))
        Dim GridHepatiteB_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Dim GridHistoryHepatite_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ToolBarHepatite = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton
        Me.NewHepatiteBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.UpdateHepatiteBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSplitButton2 = New System.Windows.Forms.ToolStripSplitButton
        Me.NewResultHepatiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.UpdateResultHepatiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnReports = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.GridHepatiteB = New Janus.Windows.GridEX.GridEX
        Me.VisualStyleManager1 = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadAllHepatite = New System.Windows.Forms.RadioButton
        Me.DateFindTo = New System.Windows.Forms.DateTimePicker
        Me.DateFindFrom = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnFind = New System.Windows.Forms.Button
        Me.TxtFindByTel = New System.Windows.Forms.TextBox
        Me.TxtFindPatientName = New System.Windows.Forms.TextBox
        Me.TxtFindPatientNo = New System.Windows.Forms.TextBox
        Me.RadByPhone = New System.Windows.Forms.RadioButton
        Me.RadByName = New System.Windows.Forms.RadioButton
        Me.RadByPatientNo = New System.Windows.Forms.RadioButton
        Me.GridHistoryHepatite = New Janus.Windows.GridEX.GridEX
        Me.Label3 = New System.Windows.Forms.Label
        Me.ToolBarHepatite.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.GridHepatiteB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridHistoryHepatite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBarHepatite
        '
        Me.ToolBarHepatite.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ToolBarHepatite.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolBarHepatite.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolBarHepatite.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolBarHepatite.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator5, Me.ToolStripSplitButton1, Me.ToolStripSeparator6, Me.ToolStripSplitButton2, Me.ToolStripSeparator7, Me.BtnReports, Me.ToolStripSeparator10})
        Me.ToolBarHepatite.Location = New System.Drawing.Point(0, 0)
        Me.ToolBarHepatite.Name = "ToolBarHepatite"
        Me.ToolBarHepatite.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolBarHepatite.Size = New System.Drawing.Size(1021, 53)
        Me.ToolBarHepatite.TabIndex = 32
        Me.ToolBarHepatite.Text = "ToolStrip1"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 53)
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DropDownButtonWidth = 20
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewHepatiteBToolStripMenuItem, Me.ToolStripMenuItem1, Me.UpdateHepatiteBToolStripMenuItem})
        Me.ToolStripSplitButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(146, 50)
        Me.ToolStripSplitButton1.Text = "​​​​​     Hepatite B​​​​​​​​     "
        Me.ToolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'NewHepatiteBToolStripMenuItem
        '
        Me.NewHepatiteBToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.NewHepatiteBToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.NewHepatiteBToolStripMenuItem.Name = "NewHepatiteBToolStripMenuItem"
        Me.NewHepatiteBToolStripMenuItem.Size = New System.Drawing.Size(287, 26)
        Me.NewHepatiteBToolStripMenuItem.Text = "New Patient Hepatite B"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(284, 6)
        '
        'UpdateHepatiteBToolStripMenuItem
        '
        Me.UpdateHepatiteBToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.UpdateHepatiteBToolStripMenuItem.Name = "UpdateHepatiteBToolStripMenuItem"
        Me.UpdateHepatiteBToolStripMenuItem.Size = New System.Drawing.Size(287, 26)
        Me.UpdateHepatiteBToolStripMenuItem.Text = "Update Patient Info Hepatite B"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 53)
        Me.ToolStripSeparator6.Visible = False
        '
        'ToolStripSplitButton2
        '
        Me.ToolStripSplitButton2.DropDownButtonWidth = 20
        Me.ToolStripSplitButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewResultHepatiteToolStripMenuItem, Me.ToolStripMenuItem2, Me.UpdateResultHepatiteToolStripMenuItem})
        Me.ToolStripSplitButton2.ForeColor = System.Drawing.Color.White
        Me.ToolStripSplitButton2.Image = CType(resources.GetObject("ToolStripSplitButton2.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton2.Name = "ToolStripSplitButton2"
        Me.ToolStripSplitButton2.Size = New System.Drawing.Size(193, 50)
        Me.ToolStripSplitButton2.Text = "     Result Hepatite B     "
        Me.ToolStripSplitButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'NewResultHepatiteToolStripMenuItem
        '
        Me.NewResultHepatiteToolStripMenuItem.Name = "NewResultHepatiteToolStripMenuItem"
        Me.NewResultHepatiteToolStripMenuItem.Size = New System.Drawing.Size(239, 26)
        Me.NewResultHepatiteToolStripMenuItem.Text = "New Result Hepatite"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(236, 6)
        '
        'UpdateResultHepatiteToolStripMenuItem
        '
        Me.UpdateResultHepatiteToolStripMenuItem.Name = "UpdateResultHepatiteToolStripMenuItem"
        Me.UpdateResultHepatiteToolStripMenuItem.Size = New System.Drawing.Size(239, 26)
        Me.UpdateResultHepatiteToolStripMenuItem.Text = "Update Result Hepatite"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 53)
        '
        'BtnReports
        '
        Me.BtnReports.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.BtnReports.ForeColor = System.Drawing.Color.White
        Me.BtnReports.Image = CType(resources.GetObject("BtnReports.Image"), System.Drawing.Image)
        Me.BtnReports.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnReports.Name = "BtnReports"
        Me.BtnReports.Size = New System.Drawing.Size(143, 50)
        Me.BtnReports.Text = "Report Hepatite"
        Me.BtnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnReports.Visible = False
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 53)
        Me.ToolStripSeparator10.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 53)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GridHistoryHepatite)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1021, 467)
        Me.SplitContainer1.SplitterDistance = 282
        Me.SplitContainer1.TabIndex = 33
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.GridHepatiteB)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1021, 282)
        Me.SplitContainer2.SplitterDistance = 796
        Me.SplitContainer2.TabIndex = 1
        '
        'GridHepatiteB
        '
        Me.GridHepatiteB.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridHepatiteB_DesignTimeLayout.LayoutString = resources.GetString("GridHepatiteB_DesignTimeLayout.LayoutString")
        Me.GridHepatiteB.DesignTimeLayout = GridHepatiteB_DesignTimeLayout
        Me.GridHepatiteB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridHepatiteB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GridHepatiteB.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridHepatiteB.GroupByBoxVisible = False
        Me.GridHepatiteB.Location = New System.Drawing.Point(0, 0)
        Me.GridHepatiteB.Name = "GridHepatiteB"
        Me.GridHepatiteB.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.GridHepatiteB.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridHepatiteB.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridHepatiteB.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridHepatiteB.Size = New System.Drawing.Size(796, 282)
        Me.GridHepatiteB.TabIndex = 0
        Me.GridHepatiteB.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridHepatiteB.VisualStyleManager = Me.VisualStyleManager1
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadAllHepatite)
        Me.GroupBox1.Controls.Add(Me.DateFindTo)
        Me.GroupBox1.Controls.Add(Me.DateFindFrom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnFind)
        Me.GroupBox1.Controls.Add(Me.TxtFindByTel)
        Me.GroupBox1.Controls.Add(Me.TxtFindPatientName)
        Me.GroupBox1.Controls.Add(Me.TxtFindPatientNo)
        Me.GroupBox1.Controls.Add(Me.RadByPhone)
        Me.GroupBox1.Controls.Add(Me.RadByName)
        Me.GroupBox1.Controls.Add(Me.RadByPatientNo)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(221, 282)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Finding By"
        '
        'RadAllHepatite
        '
        Me.RadAllHepatite.AutoSize = True
        Me.RadAllHepatite.Checked = True
        Me.RadAllHepatite.Location = New System.Drawing.Point(8, 77)
        Me.RadAllHepatite.Name = "RadAllHepatite"
        Me.RadAllHepatite.Size = New System.Drawing.Size(62, 17)
        Me.RadAllHepatite.TabIndex = 11
        Me.RadAllHepatite.TabStop = True
        Me.RadAllHepatite.Text = "View All"
        Me.RadAllHepatite.UseVisualStyleBackColor = True
        '
        'DateFindTo
        '
        Me.DateFindTo.CustomFormat = "dd/MM/yyyy"
        Me.DateFindTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFindTo.Location = New System.Drawing.Point(111, 47)
        Me.DateFindTo.Name = "DateFindTo"
        Me.DateFindTo.Size = New System.Drawing.Size(99, 20)
        Me.DateFindTo.TabIndex = 10
        '
        'DateFindFrom
        '
        Me.DateFindFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateFindFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFindFrom.Location = New System.Drawing.Point(7, 47)
        Me.DateFindFrom.Name = "DateFindFrom"
        Me.DateFindFrom.Size = New System.Drawing.Size(99, 20)
        Me.DateFindFrom.TabIndex = 9
        Me.DateFindFrom.Value = New Date(1969, 1, 1, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(105, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Date To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Date From:"
        '
        'BtnFind
        '
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.Location = New System.Drawing.Point(8, 252)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(75, 26)
        Me.BtnFind.TabIndex = 6
        Me.BtnFind.Text = "Find Patient"
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'TxtFindByTel
        '
        Me.TxtFindByTel.Enabled = False
        Me.TxtFindByTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFindByTel.Location = New System.Drawing.Point(8, 224)
        Me.TxtFindByTel.Name = "TxtFindByTel"
        Me.TxtFindByTel.Size = New System.Drawing.Size(203, 26)
        Me.TxtFindByTel.TabIndex = 5
        '
        'TxtFindPatientName
        '
        Me.TxtFindPatientName.Enabled = False
        Me.TxtFindPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFindPatientName.Location = New System.Drawing.Point(8, 175)
        Me.TxtFindPatientName.Name = "TxtFindPatientName"
        Me.TxtFindPatientName.Size = New System.Drawing.Size(203, 26)
        Me.TxtFindPatientName.TabIndex = 4
        '
        'TxtFindPatientNo
        '
        Me.TxtFindPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFindPatientNo.Location = New System.Drawing.Point(8, 122)
        Me.TxtFindPatientNo.Name = "TxtFindPatientNo"
        Me.TxtFindPatientNo.Size = New System.Drawing.Size(203, 26)
        Me.TxtFindPatientNo.TabIndex = 3
        '
        'RadByPhone
        '
        Me.RadByPhone.AutoSize = True
        Me.RadByPhone.Location = New System.Drawing.Point(8, 204)
        Me.RadByPhone.Name = "RadByPhone"
        Me.RadByPhone.Size = New System.Drawing.Size(79, 17)
        Me.RadByPhone.TabIndex = 2
        Me.RadByPhone.Text = "Telephone:"
        Me.RadByPhone.UseVisualStyleBackColor = True
        '
        'RadByName
        '
        Me.RadByName.AutoSize = True
        Me.RadByName.Location = New System.Drawing.Point(8, 156)
        Me.RadByName.Name = "RadByName"
        Me.RadByName.Size = New System.Drawing.Size(56, 17)
        Me.RadByName.TabIndex = 1
        Me.RadByName.Text = "Name:"
        Me.RadByName.UseVisualStyleBackColor = True
        '
        'RadByPatientNo
        '
        Me.RadByPatientNo.AutoSize = True
        Me.RadByPatientNo.Location = New System.Drawing.Point(8, 102)
        Me.RadByPatientNo.Name = "RadByPatientNo"
        Me.RadByPatientNo.Size = New System.Drawing.Size(78, 17)
        Me.RadByPatientNo.TabIndex = 0
        Me.RadByPatientNo.Text = "Patient No:"
        Me.RadByPatientNo.UseVisualStyleBackColor = True
        '
        'GridHistoryHepatite
        '
        Me.GridHistoryHepatite.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridHistoryHepatite_DesignTimeLayout.LayoutString = resources.GetString("GridHistoryHepatite_DesignTimeLayout.LayoutString")
        Me.GridHistoryHepatite.DesignTimeLayout = GridHistoryHepatite_DesignTimeLayout
        Me.GridHistoryHepatite.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridHistoryHepatite.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridHistoryHepatite.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridHistoryHepatite.GroupByBoxVisible = False
        Me.GridHistoryHepatite.Location = New System.Drawing.Point(0, 23)
        Me.GridHistoryHepatite.Name = "GridHistoryHepatite"
        Me.GridHistoryHepatite.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.GridHistoryHepatite.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridHistoryHepatite.RecordNavigator = True
        Me.GridHistoryHepatite.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridHistoryHepatite.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridHistoryHepatite.Size = New System.Drawing.Size(1021, 158)
        Me.GridHistoryHepatite.TabIndex = 0
        Me.GridHistoryHepatite.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridHistoryHepatite.VisualStyleManager = Me.VisualStyleManager1
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Kh Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1021, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "តារាង កាលវិភាគ"
        '
        'DashboardHepatiteB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolBarHepatite)
        Me.Name = "DashboardHepatiteB"
        Me.Size = New System.Drawing.Size(1021, 520)
        Me.ToolBarHepatite.ResumeLayout(False)
        Me.ToolBarHepatite.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.GridHepatiteB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridHistoryHepatite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolBarHepatite As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnReports As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridHepatiteB As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridHistoryHepatite As Janus.Windows.GridEX.GridEX
    Friend WithEvents VisualStyleManager1 As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadByPhone As System.Windows.Forms.RadioButton
    Friend WithEvents RadByName As System.Windows.Forms.RadioButton
    Friend WithEvents RadByPatientNo As System.Windows.Forms.RadioButton
    Friend WithEvents TxtFindByTel As System.Windows.Forms.TextBox
    Friend WithEvents TxtFindPatientName As System.Windows.Forms.TextBox
    Friend WithEvents TxtFindPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateFindTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFindFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents RadAllHepatite As System.Windows.Forms.RadioButton
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents NewHepatiteBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UpdateHepatiteBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSplitButton2 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents NewResultHepatiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UpdateResultHepatiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
