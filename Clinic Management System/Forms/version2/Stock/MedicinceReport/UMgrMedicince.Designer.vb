<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UMgrMedicince
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
        Dim GridMedicalReceive_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UMgrMedicince))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.GridMedicalReceive = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnNew = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnBupdate = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDelete = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnPrintPreview = New System.Windows.Forms.Button
        Me.BtnFind = New System.Windows.Forms.Button
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.RadAllProduct = New System.Windows.Forms.RadioButton
        Me.TxtReferenceNo = New System.Windows.Forms.TextBox
        Me.RadReferenceNO = New System.Windows.Forms.RadioButton
        Me.CboProduct = New System.Windows.Forms.ComboBox
        Me.RadProductName = New System.Windows.Forms.RadioButton
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GridMedicalReceive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.CrystalReportViewer1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridMedicalReceive)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1294, 650)
        Me.SplitContainer1.SplitterDistance = 996
        Me.SplitContainer1.TabIndex = 0
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(568, 148)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(343, 293)
        Me.CrystalReportViewer1.TabIndex = 2
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        Me.CrystalReportViewer1.Visible = False
        '
        'GridMedicalReceive
        '
        Me.GridMedicalReceive.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridMedicalReceive_DesignTimeLayout.LayoutString = resources.GetString("GridMedicalReceive_DesignTimeLayout.LayoutString")
        Me.GridMedicalReceive.DesignTimeLayout = GridMedicalReceive_DesignTimeLayout
        Me.GridMedicalReceive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridMedicalReceive.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridMedicalReceive.GroupByBoxVisible = False
        Me.GridMedicalReceive.GroupRowFormatStyle.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridMedicalReceive.GroupRowFormatStyle.FontSize = 12.0!
        Me.GridMedicalReceive.Location = New System.Drawing.Point(20, 54)
        Me.GridMedicalReceive.Name = "GridMedicalReceive"
        Me.GridMedicalReceive.RecordNavigator = True
        Me.GridMedicalReceive.Size = New System.Drawing.Size(959, 436)
        Me.GridMedicalReceive.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(35, 35)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNew, Me.ToolStripSeparator1, Me.BtnBupdate, Me.ToolStripSeparator2, Me.BtnDelete})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(996, 42)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNew
        '
        Me.BtnNew.ForeColor = System.Drawing.Color.Blue
        Me.BtnNew.Image = Global.Clinic_Management_System.My.Resources.Resources._1342235074_navigation_down_button_blue
        Me.BtnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(138, 39)
        Me.BtnNew.Text = "New Receive"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 42)
        '
        'BtnBupdate
        '
        Me.BtnBupdate.ForeColor = System.Drawing.Color.Blue
        Me.BtnBupdate.Image = Global.Clinic_Management_System.My.Resources.Resources.edit
        Me.BtnBupdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnBupdate.Name = "BtnBupdate"
        Me.BtnBupdate.Size = New System.Drawing.Size(99, 39)
        Me.BtnBupdate.Text = "Update"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 42)
        Me.ToolStripSeparator2.Visible = False
        '
        'BtnDelete
        '
        Me.BtnDelete.ForeColor = System.Drawing.Color.Blue
        Me.BtnDelete.Image = Global.Clinic_Management_System.My.Resources.Resources.delete_appointment
        Me.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(93, 39)
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnPrintPreview)
        Me.GroupBox1.Controls.Add(Me.BtnFind)
        Me.GroupBox1.Controls.Add(Me.DateTo)
        Me.GroupBox1.Controls.Add(Me.DateFrom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.RadAllProduct)
        Me.GroupBox1.Controls.Add(Me.TxtReferenceNo)
        Me.GroupBox1.Controls.Add(Me.RadReferenceNO)
        Me.GroupBox1.Controls.Add(Me.CboProduct)
        Me.GroupBox1.Controls.Add(Me.RadProductName)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 650)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Find Medicince Received"
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintPreview.Location = New System.Drawing.Point(129, 300)
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(116, 34)
        Me.BtnPrintPreview.TabIndex = 10
        Me.BtnPrintPreview.Text = "Print Preview"
        Me.BtnPrintPreview.UseVisualStyleBackColor = True
        '
        'BtnFind
        '
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.Location = New System.Drawing.Point(7, 300)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(116, 34)
        Me.BtnFind.TabIndex = 9
        Me.BtnFind.Text = "Find"
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'DateTo
        '
        Me.DateTo.CalendarForeColor = System.Drawing.Color.Blue
        Me.DateTo.CalendarTitleForeColor = System.Drawing.Color.Blue
        Me.DateTo.CustomFormat = "        dd-MM-yyyy      "
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(101, 255)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(187, 26)
        Me.DateTo.TabIndex = 8
        '
        'DateFrom
        '
        Me.DateFrom.CalendarForeColor = System.Drawing.Color.Blue
        Me.DateFrom.CustomFormat = "        dd-MM-yyyy      "
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(101, 212)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(187, 26)
        Me.DateFrom.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Date To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Date From:"
        '
        'RadAllProduct
        '
        Me.RadAllProduct.AutoSize = True
        Me.RadAllProduct.Checked = True
        Me.RadAllProduct.Location = New System.Drawing.Point(7, 28)
        Me.RadAllProduct.Name = "RadAllProduct"
        Me.RadAllProduct.Size = New System.Drawing.Size(86, 24)
        Me.RadAllProduct.TabIndex = 4
        Me.RadAllProduct.TabStop = True
        Me.RadAllProduct.Text = "View All "
        Me.RadAllProduct.UseVisualStyleBackColor = True
        '
        'TxtReferenceNo
        '
        Me.TxtReferenceNo.Enabled = False
        Me.TxtReferenceNo.Location = New System.Drawing.Point(6, 166)
        Me.TxtReferenceNo.Name = "TxtReferenceNo"
        Me.TxtReferenceNo.Size = New System.Drawing.Size(282, 26)
        Me.TxtReferenceNo.TabIndex = 3
        '
        'RadReferenceNO
        '
        Me.RadReferenceNO.AutoSize = True
        Me.RadReferenceNO.Location = New System.Drawing.Point(6, 136)
        Me.RadReferenceNO.Name = "RadReferenceNO"
        Me.RadReferenceNO.Size = New System.Drawing.Size(130, 24)
        Me.RadReferenceNO.TabIndex = 2
        Me.RadReferenceNO.Text = "Reference No:"
        Me.RadReferenceNO.UseVisualStyleBackColor = True
        '
        'CboProduct
        '
        Me.CboProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboProduct.Enabled = False
        Me.CboProduct.FormattingEnabled = True
        Me.CboProduct.Location = New System.Drawing.Point(6, 98)
        Me.CboProduct.Name = "CboProduct"
        Me.CboProduct.Size = New System.Drawing.Size(282, 28)
        Me.CboProduct.TabIndex = 1
        '
        'RadProductName
        '
        Me.RadProductName.AutoSize = True
        Me.RadProductName.Location = New System.Drawing.Point(6, 68)
        Me.RadProductName.Name = "RadProductName"
        Me.RadProductName.Size = New System.Drawing.Size(106, 24)
        Me.RadProductName.TabIndex = 0
        Me.RadProductName.Text = "Expend On"
        Me.RadProductName.UseVisualStyleBackColor = True
        '
        'UMgrMedicince
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UMgrMedicince"
        Me.Size = New System.Drawing.Size(1294, 650)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GridMedicalReceive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnBupdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridMedicalReceive As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CboProduct As System.Windows.Forms.ComboBox
    Friend WithEvents RadProductName As System.Windows.Forms.RadioButton
    Friend WithEvents RadAllProduct As System.Windows.Forms.RadioButton
    Friend WithEvents TxtReferenceNo As System.Windows.Forms.TextBox
    Friend WithEvents RadReferenceNO As System.Windows.Forms.RadioButton
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer

End Class
