<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoctorFee
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
        Dim GridDoctorFee_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DoctorFee))
        Me.GridDoctorFee = New Janus.Windows.GridEX.GridEX
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnPreview = New System.Windows.Forms.Button
        Me.BtnView = New System.Windows.Forms.Button
        Me.DateConsultTo = New System.Windows.Forms.DateTimePicker
        Me.DateConsultFrom = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboDoctor = New System.Windows.Forms.ComboBox
        Me.RadByDoctor = New System.Windows.Forms.RadioButton
        Me.RadAllDoctor = New System.Windows.Forms.RadioButton
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ErrDoctorInfo = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.GridDoctorFee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.ErrDoctorInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridDoctorFee
        '
        Me.GridDoctorFee.AllowColumnDrag = False
        Me.GridDoctorFee.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridDoctorFee_DesignTimeLayout.LayoutString = resources.GetString("GridDoctorFee_DesignTimeLayout.LayoutString")
        Me.GridDoctorFee.DesignTimeLayout = GridDoctorFee_DesignTimeLayout
        Me.GridDoctorFee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDoctorFee.GroupByBoxVisible = False
        Me.GridDoctorFee.Location = New System.Drawing.Point(0, 0)
        Me.GridDoctorFee.Name = "GridDoctorFee"
        Me.GridDoctorFee.RecordNavigator = True
        Me.GridDoctorFee.Size = New System.Drawing.Size(854, 310)
        Me.GridDoctorFee.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1154, 620)
        Me.SplitContainer1.SplitterDistance = 296
        Me.SplitContainer1.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(296, 620)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(288, 591)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Doctor Fee Information"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnPreview)
        Me.GroupBox1.Controls.Add(Me.BtnView)
        Me.GroupBox1.Controls.Add(Me.DateConsultTo)
        Me.GroupBox1.Controls.Add(Me.DateConsultFrom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboDoctor)
        Me.GroupBox1.Controls.Add(Me.RadByDoctor)
        Me.GroupBox1.Controls.Add(Me.RadAllDoctor)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 585)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'BtnPreview
        '
        Me.BtnPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPreview.Location = New System.Drawing.Point(167, 244)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(109, 29)
        Me.BtnPreview.TabIndex = 8
        Me.BtnPreview.Text = "Print Preview"
        Me.BtnPreview.UseVisualStyleBackColor = True
        '
        'BtnView
        '
        Me.BtnView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnView.Location = New System.Drawing.Point(59, 244)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(101, 29)
        Me.BtnView.TabIndex = 7
        Me.BtnView.Text = "View"
        Me.BtnView.UseVisualStyleBackColor = True
        '
        'DateConsultTo
        '
        Me.DateConsultTo.CustomFormat = "dd/MM/yyyy"
        Me.DateConsultTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateConsultTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateConsultTo.Location = New System.Drawing.Point(86, 76)
        Me.DateConsultTo.Name = "DateConsultTo"
        Me.DateConsultTo.Size = New System.Drawing.Size(190, 24)
        Me.DateConsultTo.TabIndex = 6
        '
        'DateConsultFrom
        '
        Me.DateConsultFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateConsultFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateConsultFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateConsultFrom.Location = New System.Drawing.Point(86, 34)
        Me.DateConsultFrom.Name = "DateConsultFrom"
        Me.DateConsultFrom.Size = New System.Drawing.Size(190, 24)
        Me.DateConsultFrom.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Date To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Date From:"
        '
        'cboDoctor
        '
        Me.cboDoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDoctor.Enabled = False
        Me.cboDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDoctor.FormattingEnabled = True
        Me.cboDoctor.Location = New System.Drawing.Point(6, 195)
        Me.cboDoctor.Name = "cboDoctor"
        Me.cboDoctor.Size = New System.Drawing.Size(270, 28)
        Me.cboDoctor.TabIndex = 2
        '
        'RadByDoctor
        '
        Me.RadByDoctor.AutoSize = True
        Me.RadByDoctor.Location = New System.Drawing.Point(6, 168)
        Me.RadByDoctor.Name = "RadByDoctor"
        Me.RadByDoctor.Size = New System.Drawing.Size(121, 21)
        Me.RadByDoctor.TabIndex = 1
        Me.RadByDoctor.Text = "View By Doctor"
        Me.RadByDoctor.UseVisualStyleBackColor = True
        '
        'RadAllDoctor
        '
        Me.RadAllDoctor.AutoSize = True
        Me.RadAllDoctor.Checked = True
        Me.RadAllDoctor.Location = New System.Drawing.Point(6, 125)
        Me.RadAllDoctor.Name = "RadAllDoctor"
        Me.RadAllDoctor.Size = New System.Drawing.Size(120, 21)
        Me.RadAllDoctor.TabIndex = 0
        Me.RadAllDoctor.TabStop = True
        Me.RadAllDoctor.Text = "View All Doctor"
        Me.RadAllDoctor.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GridDoctorFee)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.CrystalReportViewer1)
        Me.SplitContainer2.Size = New System.Drawing.Size(854, 620)
        Me.SplitContainer2.SplitterDistance = 310
        Me.SplitContainer2.TabIndex = 2
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
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(854, 306)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'ErrDoctorInfo
        '
        Me.ErrDoctorInfo.ContainerControl = Me
        '
        'DoctorFee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "DoctorFee"
        Me.Size = New System.Drawing.Size(1154, 620)
        CType(Me.GridDoctorFee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.ErrDoctorInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridDoctorFee As Janus.Windows.GridEX.GridEX
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboDoctor As System.Windows.Forms.ComboBox
    Friend WithEvents RadByDoctor As System.Windows.Forms.RadioButton
    Friend WithEvents RadAllDoctor As System.Windows.Forms.RadioButton
    Friend WithEvents DateConsultTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateConsultFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnPreview As System.Windows.Forms.Button
    Friend WithEvents BtnView As System.Windows.Forms.Button
    Friend WithEvents ErrDoctorInfo As System.Windows.Forms.ErrorProvider
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer

End Class
