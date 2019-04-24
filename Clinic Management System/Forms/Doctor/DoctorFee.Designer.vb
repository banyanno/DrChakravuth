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
        Dim JanusColorScheme5 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Dim GridConsultation_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DoctorFee))
        Dim GridParaExam_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.VisualStyleManager1 = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadAllParaExam = New System.Windows.Forms.RadioButton
        Me.GSelectDoctor = New System.Windows.Forms.GroupBox
        Me.RadAllDoctor = New System.Windows.Forms.RadioButton
        Me.RadByDoctor = New System.Windows.Forms.RadioButton
        Me.cboDoctor = New System.Windows.Forms.ComboBox
        Me.RadByDoctorParaExam = New System.Windows.Forms.RadioButton
        Me.RadByDoctorCounsultation = New System.Windows.Forms.RadioButton
        Me.BtnPreview = New System.Windows.Forms.Button
        Me.BtnView = New System.Windows.Forms.Button
        Me.DateConsultTo = New System.Windows.Forms.DateTimePicker
        Me.DateConsultFrom = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GridConsultation = New Janus.Windows.GridEX.GridEX
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GridParaExam = New Janus.Windows.GridEX.GridEX
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ErrDoctorInfo = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BGLoadingReport = New System.ComponentModel.BackgroundWorker
        Me.BGLoadDataCounsult = New System.ComponentModel.BackgroundWorker
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GSelectDoctor.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridConsultation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GridParaExam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrDoctorInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VisualStyleManager1
        '
        JanusColorScheme5.HighlightTextColor = System.Drawing.SystemColors.HotTrack
        JanusColorScheme5.Name = "Scheme0"
        JanusColorScheme5.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme5.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        JanusColorScheme5.UseThemes = False
        JanusColorScheme5.VisualStyle = Janus.Windows.Common.VisualStyle.Standard
        Me.VisualStyleManager1.ColorSchemes.Add(JanusColorScheme5)
        Me.VisualStyleManager1.DefaultColorScheme = "Scheme0"
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
        Me.GroupBox1.Controls.Add(Me.RadAllParaExam)
        Me.GroupBox1.Controls.Add(Me.GSelectDoctor)
        Me.GroupBox1.Controls.Add(Me.RadByDoctorParaExam)
        Me.GroupBox1.Controls.Add(Me.RadByDoctorCounsultation)
        Me.GroupBox1.Controls.Add(Me.BtnPreview)
        Me.GroupBox1.Controls.Add(Me.BtnView)
        Me.GroupBox1.Controls.Add(Me.DateConsultTo)
        Me.GroupBox1.Controls.Add(Me.DateConsultFrom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 585)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'RadAllParaExam
        '
        Me.RadAllParaExam.AutoSize = True
        Me.RadAllParaExam.Location = New System.Drawing.Point(10, 169)
        Me.RadAllParaExam.Name = "RadAllParaExam"
        Me.RadAllParaExam.Size = New System.Drawing.Size(128, 21)
        Me.RadAllParaExam.TabIndex = 12
        Me.RadAllParaExam.Text = "View Para-Exam"
        Me.RadAllParaExam.UseVisualStyleBackColor = True
        '
        'GSelectDoctor
        '
        Me.GSelectDoctor.Controls.Add(Me.RadAllDoctor)
        Me.GSelectDoctor.Controls.Add(Me.RadByDoctor)
        Me.GSelectDoctor.Controls.Add(Me.cboDoctor)
        Me.GSelectDoctor.Location = New System.Drawing.Point(10, 196)
        Me.GSelectDoctor.Name = "GSelectDoctor"
        Me.GSelectDoctor.Size = New System.Drawing.Size(266, 116)
        Me.GSelectDoctor.TabIndex = 11
        Me.GSelectDoctor.TabStop = False
        Me.GSelectDoctor.Text = "Select Doctor"
        '
        'RadAllDoctor
        '
        Me.RadAllDoctor.AutoSize = True
        Me.RadAllDoctor.Checked = True
        Me.RadAllDoctor.Location = New System.Drawing.Point(8, 22)
        Me.RadAllDoctor.Name = "RadAllDoctor"
        Me.RadAllDoctor.Size = New System.Drawing.Size(120, 21)
        Me.RadAllDoctor.TabIndex = 0
        Me.RadAllDoctor.TabStop = True
        Me.RadAllDoctor.Text = "View All Doctor"
        Me.RadAllDoctor.UseVisualStyleBackColor = True
        '
        'RadByDoctor
        '
        Me.RadByDoctor.AutoSize = True
        Me.RadByDoctor.Location = New System.Drawing.Point(8, 49)
        Me.RadByDoctor.Name = "RadByDoctor"
        Me.RadByDoctor.Size = New System.Drawing.Size(121, 21)
        Me.RadByDoctor.TabIndex = 1
        Me.RadByDoctor.Text = "View By Doctor"
        Me.RadByDoctor.UseVisualStyleBackColor = True
        '
        'cboDoctor
        '
        Me.cboDoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDoctor.Enabled = False
        Me.cboDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDoctor.FormattingEnabled = True
        Me.cboDoctor.Location = New System.Drawing.Point(8, 76)
        Me.cboDoctor.Name = "cboDoctor"
        Me.cboDoctor.Size = New System.Drawing.Size(236, 28)
        Me.cboDoctor.TabIndex = 2
        '
        'RadByDoctorParaExam
        '
        Me.RadByDoctorParaExam.AutoSize = True
        Me.RadByDoctorParaExam.Location = New System.Drawing.Point(10, 138)
        Me.RadByDoctorParaExam.Name = "RadByDoctorParaExam"
        Me.RadByDoctorParaExam.Size = New System.Drawing.Size(194, 21)
        Me.RadByDoctorParaExam.TabIndex = 10
        Me.RadByDoctorParaExam.Text = "View By Doctor-Para Exam"
        Me.RadByDoctorParaExam.UseVisualStyleBackColor = True
        '
        'RadByDoctorCounsultation
        '
        Me.RadByDoctorCounsultation.AutoSize = True
        Me.RadByDoctorCounsultation.Checked = True
        Me.RadByDoctorCounsultation.Location = New System.Drawing.Point(10, 108)
        Me.RadByDoctorCounsultation.Name = "RadByDoctorCounsultation"
        Me.RadByDoctorCounsultation.Size = New System.Drawing.Size(187, 21)
        Me.RadByDoctorCounsultation.TabIndex = 9
        Me.RadByDoctorCounsultation.TabStop = True
        Me.RadByDoctorCounsultation.Text = "View By Doc-Consultation"
        Me.RadByDoctorCounsultation.UseVisualStyleBackColor = True
        '
        'BtnPreview
        '
        Me.BtnPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPreview.Location = New System.Drawing.Point(167, 318)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(109, 29)
        Me.BtnPreview.TabIndex = 8
        Me.BtnPreview.Text = "Print Preview"
        Me.BtnPreview.UseVisualStyleBackColor = True
        '
        'BtnView
        '
        Me.BtnView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnView.Location = New System.Drawing.Point(59, 318)
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
        Me.DateConsultTo.Location = New System.Drawing.Point(86, 59)
        Me.DateConsultTo.Name = "DateConsultTo"
        Me.DateConsultTo.Size = New System.Drawing.Size(190, 24)
        Me.DateConsultTo.TabIndex = 6
        '
        'DateConsultFrom
        '
        Me.DateConsultFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateConsultFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateConsultFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateConsultFrom.Location = New System.Drawing.Point(86, 17)
        Me.DateConsultFrom.Name = "DateConsultFrom"
        Me.DateConsultFrom.Size = New System.Drawing.Size(190, 24)
        Me.DateConsultFrom.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Date To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Date From:"
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.CrystalReportViewer1)
        Me.SplitContainer2.Size = New System.Drawing.Size(854, 620)
        Me.SplitContainer2.SplitterDistance = 310
        Me.SplitContainer2.TabIndex = 2
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.GroupBox3)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer3.Size = New System.Drawing.Size(854, 310)
        Me.SplitContainer3.SplitterDistance = 421
        Me.SplitContainer3.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GridConsultation)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(421, 310)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Patient Consultation ..."
        '
        'GridConsultation
        '
        Me.GridConsultation.AllowColumnDrag = False
        Me.GridConsultation.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridConsultation_DesignTimeLayout.LayoutString = resources.GetString("GridConsultation_DesignTimeLayout.LayoutString")
        Me.GridConsultation.DesignTimeLayout = GridConsultation_DesignTimeLayout
        Me.GridConsultation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridConsultation.ExpandableCards = False
        Me.GridConsultation.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridConsultation.GroupByBoxVisible = False
        Me.GridConsultation.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.GridConsultation.Location = New System.Drawing.Point(3, 16)
        Me.GridConsultation.Name = "GridConsultation"
        Me.GridConsultation.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.GridConsultation.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridConsultation.RecordNavigator = True
        Me.GridConsultation.SelectedFormatStyle.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GridConsultation.Size = New System.Drawing.Size(415, 291)
        Me.GridConsultation.TabIndex = 1
        Me.GridConsultation.VisualStyleManager = Me.VisualStyleManager1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GridParaExam)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(429, 310)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Patient Para Exam..."
        '
        'GridParaExam
        '
        Me.GridParaExam.AllowColumnDrag = False
        Me.GridParaExam.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridParaExam_DesignTimeLayout.LayoutString = resources.GetString("GridParaExam_DesignTimeLayout.LayoutString")
        Me.GridParaExam.DesignTimeLayout = GridParaExam_DesignTimeLayout
        Me.GridParaExam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridParaExam.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridParaExam.GroupByBoxVisible = False
        Me.GridParaExam.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.GridParaExam.Location = New System.Drawing.Point(3, 16)
        Me.GridParaExam.Name = "GridParaExam"
        Me.GridParaExam.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.GridParaExam.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridParaExam.RecordNavigator = True
        Me.GridParaExam.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridParaExam.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridParaExam.SelectedFormatStyle.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GridParaExam.Size = New System.Drawing.Size(423, 291)
        Me.GridParaExam.TabIndex = 2
        Me.GridParaExam.VisualStyleManager = Me.VisualStyleManager1
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
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(854, 306)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'ErrDoctorInfo
        '
        Me.ErrDoctorInfo.ContainerControl = Me
        '
        'BGLoadingReport
        '
        '
        'DoctorFee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "DoctorFee"
        Me.Size = New System.Drawing.Size(1154, 620)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GSelectDoctor.ResumeLayout(False)
        Me.GSelectDoctor.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.GridConsultation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.GridParaExam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrDoctorInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
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
    Friend WithEvents VisualStyleManager1 As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents GSelectDoctor As System.Windows.Forms.GroupBox
    Friend WithEvents RadByDoctorParaExam As System.Windows.Forms.RadioButton
    Friend WithEvents RadByDoctorCounsultation As System.Windows.Forms.RadioButton
    Friend WithEvents RadAllParaExam As System.Windows.Forms.RadioButton
    Friend WithEvents GridConsultation As Janus.Windows.GridEX.GridEX
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GridParaExam As Janus.Windows.GridEX.GridEX
    Friend WithEvents BGLoadingReport As System.ComponentModel.BackgroundWorker
    Friend WithEvents BGLoadDataCounsult As System.ComponentModel.BackgroundWorker

End Class
