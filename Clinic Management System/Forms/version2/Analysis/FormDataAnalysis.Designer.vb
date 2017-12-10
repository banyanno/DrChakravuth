<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataAnalysis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDataAnalysis))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ChViewDetialData = New System.Windows.Forms.CheckBox
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage
        Me.ChProvice = New System.Windows.Forms.CheckBox
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.RadAllProvince = New System.Windows.Forms.RadioButton
        Me.RadEachProvince = New System.Windows.Forms.RadioButton
        Me.CboProvince = New System.Windows.Forms.ComboBox
        Me.CboSexProvince = New System.Windows.Forms.ComboBox
        Me.ChSexProvince = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CboPDiagnosis = New System.Windows.Forms.ComboBox
        Me.RadOnePDiagnosis = New System.Windows.Forms.RadioButton
        Me.RadPAllDiagnosis = New System.Windows.Forms.RadioButton
        Me.BtnProvincePreview = New System.Windows.Forms.Button
        Me.UiTabPage2 = New Janus.Windows.UI.Tab.UITabPage
        Me.CboSexComplain = New System.Windows.Forms.ComboBox
        Me.chSexComplaint = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RadByPhysical = New System.Windows.Forms.RadioButton
        Me.RadByMedicalHistory = New System.Windows.Forms.RadioButton
        Me.RadByComplaint = New System.Windows.Forms.RadioButton
        Me.BtnPreviewDiagnosis = New System.Windows.Forms.Button
        Me.cbodiagnosis = New System.Windows.Forms.ComboBox
        Me.RadEachDiagnosis = New System.Windows.Forms.RadioButton
        Me.RadAllDiagnosis = New System.Windows.Forms.RadioButton
        Me.UiTabPage3 = New Janus.Windows.UI.Tab.UITabPage
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.ByBlood = New System.Windows.Forms.TabPage
        Me.CboSexBlood = New System.Windows.Forms.ComboBox
        Me.ChSexBlood = New System.Windows.Forms.CheckBox
        Me.RadParaAllDiagnosis = New System.Windows.Forms.RadioButton
        Me.cboParaDiagnosis = New System.Windows.Forms.ComboBox
        Me.RadParaOneDiagnosis = New System.Windows.Forms.RadioButton
        Me.btnParaExamViewer = New System.Windows.Forms.Button
        Me.Fibroscopy = New System.Windows.Forms.TabPage
        Me.CboSexFibros = New System.Windows.Forms.ComboBox
        Me.ChSexFibros = New System.Windows.Forms.CheckBox
        Me.CboFibroDiagnosis = New System.Windows.Forms.ComboBox
        Me.ChViewFibroDiagnosis = New System.Windows.Forms.CheckBox
        Me.RadFibMotif = New System.Windows.Forms.RadioButton
        Me.CboFibroMotif = New System.Windows.Forms.ComboBox
        Me.RadFibOneMotif = New System.Windows.Forms.RadioButton
        Me.BtnFibPrintPreview = New System.Windows.Forms.Button
        Me.Nasogastro = New System.Windows.Forms.TabPage
        Me.CboSexNasoga = New System.Windows.Forms.ComboBox
        Me.ChSexNasogo = New System.Windows.Forms.CheckBox
        Me.CboDiagnosisNasogastgro = New System.Windows.Forms.ComboBox
        Me.ChDiagnosisNaso = New System.Windows.Forms.CheckBox
        Me.RadNasoAllMotif = New System.Windows.Forms.RadioButton
        Me.CboNasoMotif = New System.Windows.Forms.ComboBox
        Me.RadNasoByMotif = New System.Windows.Forms.RadioButton
        Me.BtnNasoPrintPreview = New System.Windows.Forms.Button
        Me.Coloscopy = New System.Windows.Forms.TabPage
        Me.CboSexColoscopy = New System.Windows.Forms.ComboBox
        Me.ChSexColosco = New System.Windows.Forms.CheckBox
        Me.CboDiagnosisColoscopy = New System.Windows.Forms.ComboBox
        Me.ChViewDiagnosisColoscopy = New System.Windows.Forms.CheckBox
        Me.RadColoAllDiagnosis = New System.Windows.Forms.RadioButton
        Me.cboColoMotify = New System.Windows.Forms.ComboBox
        Me.RadColoOneDiagnosis = New System.Windows.Forms.RadioButton
        Me.BtnColoPrintPreview = New System.Windows.Forms.Button
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ErrAnalysis = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnClose = New System.Windows.Forms.Button
        Me.BgLoadAnalysis = New System.ComponentModel.BackgroundWorker
        Me.GroupBox1.SuspendLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.UiTabPage1.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        Me.UiTabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.UiTabPage3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.ByBlood.SuspendLayout()
        Me.Fibroscopy.SuspendLayout()
        Me.Nasogastro.SuspendLayout()
        Me.Coloscopy.SuspendLayout()
        CType(Me.ErrAnalysis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChViewDetialData)
        Me.GroupBox1.Controls.Add(Me.UiTab1)
        Me.GroupBox1.Controls.Add(Me.DateTo)
        Me.GroupBox1.Controls.Add(Me.DateFrom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(843, 403)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date To Date"
        '
        'ChViewDetialData
        '
        Me.ChViewDetialData.AutoSize = True
        Me.ChViewDetialData.ForeColor = System.Drawing.Color.Red
        Me.ChViewDetialData.Location = New System.Drawing.Point(477, 42)
        Me.ChViewDetialData.Name = "ChViewDetialData"
        Me.ChViewDetialData.Size = New System.Drawing.Size(131, 24)
        Me.ChViewDetialData.TabIndex = 8
        Me.ChViewDetialData.Text = "View in Details"
        Me.ChViewDetialData.UseVisualStyleBackColor = True
        '
        'UiTab1
        '
        Me.UiTab1.FlatBorderColor = System.Drawing.SystemColors.Control
        Me.UiTab1.Location = New System.Drawing.Point(16, 81)
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom
        Me.UiTab1.Office2007CustomColor = System.Drawing.SystemColors.Control
        Me.UiTab1.Size = New System.Drawing.Size(812, 308)
        Me.UiTab1.TabIndex = 2
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage1, Me.UiTabPage2, Me.UiTabPage3})
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.ChProvice)
        Me.UiTabPage1.Controls.Add(Me.UiGroupBox1)
        Me.UiTabPage1.Controls.Add(Me.CboSexProvince)
        Me.UiTabPage1.Controls.Add(Me.ChSexProvince)
        Me.UiTabPage1.Controls.Add(Me.Label3)
        Me.UiTabPage1.Controls.Add(Me.CboPDiagnosis)
        Me.UiTabPage1.Controls.Add(Me.RadOnePDiagnosis)
        Me.UiTabPage1.Controls.Add(Me.RadPAllDiagnosis)
        Me.UiTabPage1.Controls.Add(Me.BtnProvincePreview)
        Me.UiTabPage1.Key = "By Province"
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 28)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(808, 277)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "Analys By Province Or Diagnosis"
        '
        'ChProvice
        '
        Me.ChProvice.AutoSize = True
        Me.ChProvice.Location = New System.Drawing.Point(9, 115)
        Me.ChProvice.Name = "ChProvice"
        Me.ChProvice.Size = New System.Drawing.Size(137, 24)
        Me.ChProvice.TabIndex = 13
        Me.ChProvice.Text = "Select Province"
        Me.ChProvice.UseVisualStyleBackColor = True
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.BackColor = System.Drawing.Color.CadetBlue
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.TabPage
        Me.UiGroupBox1.Controls.Add(Me.RadAllProvince)
        Me.UiGroupBox1.Controls.Add(Me.RadEachProvince)
        Me.UiGroupBox1.Controls.Add(Me.CboProvince)
        Me.UiGroupBox1.Enabled = False
        Me.UiGroupBox1.Location = New System.Drawing.Point(9, 151)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom
        Me.UiGroupBox1.Size = New System.Drawing.Size(519, 123)
        Me.UiGroupBox1.TabIndex = 12
        Me.UiGroupBox1.Text = "Select province"
        Me.UiGroupBox1.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center
        Me.UiGroupBox1.TextOffset = 1
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'RadAllProvince
        '
        Me.RadAllProvince.AutoSize = True
        Me.RadAllProvince.BackColor = System.Drawing.Color.Transparent
        Me.RadAllProvince.Location = New System.Drawing.Point(21, 25)
        Me.RadAllProvince.Name = "RadAllProvince"
        Me.RadAllProvince.Size = New System.Drawing.Size(146, 24)
        Me.RadAllProvince.TabIndex = 0
        Me.RadAllProvince.Text = "View All Province"
        Me.RadAllProvince.UseVisualStyleBackColor = False
        '
        'RadEachProvince
        '
        Me.RadEachProvince.AutoSize = True
        Me.RadEachProvince.BackColor = System.Drawing.Color.Transparent
        Me.RadEachProvince.Location = New System.Drawing.Point(21, 61)
        Me.RadEachProvince.Name = "RadEachProvince"
        Me.RadEachProvince.Size = New System.Drawing.Size(150, 24)
        Me.RadEachProvince.TabIndex = 1
        Me.RadEachProvince.Text = "View One Provice"
        Me.RadEachProvince.UseVisualStyleBackColor = False
        '
        'CboProvince
        '
        Me.CboProvince.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboProvince.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboProvince.Enabled = False
        Me.CboProvince.FormattingEnabled = True
        Me.CboProvince.Location = New System.Drawing.Point(21, 89)
        Me.CboProvince.Name = "CboProvince"
        Me.CboProvince.Size = New System.Drawing.Size(331, 28)
        Me.CboProvince.TabIndex = 2
        '
        'CboSexProvince
        '
        Me.CboSexProvince.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboSexProvince.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboSexProvince.Enabled = False
        Me.CboSexProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CboSexProvince.FormattingEnabled = True
        Me.CboSexProvince.Items.AddRange(New Object() {"Male", "Female"})
        Me.CboSexProvince.Location = New System.Drawing.Point(534, 59)
        Me.CboSexProvince.Name = "CboSexProvince"
        Me.CboSexProvince.Size = New System.Drawing.Size(107, 28)
        Me.CboSexProvince.TabIndex = 10
        '
        'ChSexProvince
        '
        Me.ChSexProvince.AutoSize = True
        Me.ChSexProvince.BackColor = System.Drawing.Color.Transparent
        Me.ChSexProvince.ForeColor = System.Drawing.Color.Red
        Me.ChSexProvince.Location = New System.Drawing.Point(536, 28)
        Me.ChSexProvince.Name = "ChSexProvince"
        Me.ChSexProvince.Size = New System.Drawing.Size(55, 24)
        Me.ChSexProvince.TabIndex = 9
        Me.ChSexProvince.Text = "Sex"
        Me.ChSexProvince.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(9, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(518, 2)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "-"
        '
        'CboPDiagnosis
        '
        Me.CboPDiagnosis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboPDiagnosis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboPDiagnosis.Enabled = False
        Me.CboPDiagnosis.FormattingEnabled = True
        Me.CboPDiagnosis.Location = New System.Drawing.Point(197, 59)
        Me.CboPDiagnosis.Name = "CboPDiagnosis"
        Me.CboPDiagnosis.Size = New System.Drawing.Size(331, 28)
        Me.CboPDiagnosis.TabIndex = 6
        '
        'RadOnePDiagnosis
        '
        Me.RadOnePDiagnosis.AutoSize = True
        Me.RadOnePDiagnosis.BackColor = System.Drawing.Color.Transparent
        Me.RadOnePDiagnosis.Location = New System.Drawing.Point(22, 63)
        Me.RadOnePDiagnosis.Name = "RadOnePDiagnosis"
        Me.RadOnePDiagnosis.Size = New System.Drawing.Size(169, 24)
        Me.RadOnePDiagnosis.TabIndex = 5
        Me.RadOnePDiagnosis.Text = "View One Diagnosis"
        Me.RadOnePDiagnosis.UseVisualStyleBackColor = False
        '
        'RadPAllDiagnosis
        '
        Me.RadPAllDiagnosis.AutoSize = True
        Me.RadPAllDiagnosis.BackColor = System.Drawing.Color.Transparent
        Me.RadPAllDiagnosis.Checked = True
        Me.RadPAllDiagnosis.Location = New System.Drawing.Point(22, 27)
        Me.RadPAllDiagnosis.Name = "RadPAllDiagnosis"
        Me.RadPAllDiagnosis.Size = New System.Drawing.Size(156, 24)
        Me.RadPAllDiagnosis.TabIndex = 4
        Me.RadPAllDiagnosis.TabStop = True
        Me.RadPAllDiagnosis.Text = "View All Diagnosis"
        Me.RadPAllDiagnosis.UseVisualStyleBackColor = False
        '
        'BtnProvincePreview
        '
        Me.BtnProvincePreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProvincePreview.Location = New System.Drawing.Point(536, 115)
        Me.BtnProvincePreview.Name = "BtnProvincePreview"
        Me.BtnProvincePreview.Size = New System.Drawing.Size(164, 30)
        Me.BtnProvincePreview.TabIndex = 3
        Me.BtnProvincePreview.Text = "Print Preview"
        Me.BtnProvincePreview.UseVisualStyleBackColor = True
        '
        'UiTabPage2
        '
        Me.UiTabPage2.Controls.Add(Me.CboSexComplain)
        Me.UiTabPage2.Controls.Add(Me.chSexComplaint)
        Me.UiTabPage2.Controls.Add(Me.GroupBox2)
        Me.UiTabPage2.Controls.Add(Me.BtnPreviewDiagnosis)
        Me.UiTabPage2.Controls.Add(Me.cbodiagnosis)
        Me.UiTabPage2.Controls.Add(Me.RadEachDiagnosis)
        Me.UiTabPage2.Controls.Add(Me.RadAllDiagnosis)
        Me.UiTabPage2.Key = "Analys By Diagnosis"
        Me.UiTabPage2.Location = New System.Drawing.Point(1, 28)
        Me.UiTabPage2.Name = "UiTabPage2"
        Me.UiTabPage2.Size = New System.Drawing.Size(808, 277)
        Me.UiTabPage2.TabStop = True
        Me.UiTabPage2.Text = "Analys By Diagnosis With other"
        '
        'CboSexComplain
        '
        Me.CboSexComplain.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboSexComplain.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboSexComplain.Enabled = False
        Me.CboSexComplain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CboSexComplain.FormattingEnabled = True
        Me.CboSexComplain.Items.AddRange(New Object() {"Male", "Female"})
        Me.CboSexComplain.Location = New System.Drawing.Point(613, 100)
        Me.CboSexComplain.Name = "CboSexComplain"
        Me.CboSexComplain.Size = New System.Drawing.Size(107, 28)
        Me.CboSexComplain.TabIndex = 12
        '
        'chSexComplaint
        '
        Me.chSexComplaint.AutoSize = True
        Me.chSexComplaint.BackColor = System.Drawing.Color.Transparent
        Me.chSexComplaint.Enabled = False
        Me.chSexComplaint.ForeColor = System.Drawing.Color.Red
        Me.chSexComplaint.Location = New System.Drawing.Point(613, 71)
        Me.chSexComplaint.Name = "chSexComplaint"
        Me.chSexComplaint.Size = New System.Drawing.Size(55, 24)
        Me.chSexComplaint.TabIndex = 11
        Me.chSexComplaint.Text = "Sex"
        Me.chSexComplaint.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadByPhysical)
        Me.GroupBox2.Controls.Add(Me.RadByMedicalHistory)
        Me.GroupBox2.Controls.Add(Me.RadByComplaint)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(264, 141)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "With"
        '
        'RadByPhysical
        '
        Me.RadByPhysical.AutoSize = True
        Me.RadByPhysical.Location = New System.Drawing.Point(44, 85)
        Me.RadByPhysical.Name = "RadByPhysical"
        Me.RadByPhysical.Size = New System.Drawing.Size(144, 24)
        Me.RadByPhysical.TabIndex = 2
        Me.RadByPhysical.Text = "View By Physical"
        Me.RadByPhysical.UseVisualStyleBackColor = True
        '
        'RadByMedicalHistory
        '
        Me.RadByMedicalHistory.AutoSize = True
        Me.RadByMedicalHistory.Location = New System.Drawing.Point(44, 55)
        Me.RadByMedicalHistory.Name = "RadByMedicalHistory"
        Me.RadByMedicalHistory.Size = New System.Drawing.Size(194, 24)
        Me.RadByMedicalHistory.TabIndex = 1
        Me.RadByMedicalHistory.Text = "View By Medical History"
        Me.RadByMedicalHistory.UseVisualStyleBackColor = True
        '
        'RadByComplaint
        '
        Me.RadByComplaint.AutoSize = True
        Me.RadByComplaint.Checked = True
        Me.RadByComplaint.Location = New System.Drawing.Point(44, 25)
        Me.RadByComplaint.Name = "RadByComplaint"
        Me.RadByComplaint.Size = New System.Drawing.Size(158, 24)
        Me.RadByComplaint.TabIndex = 0
        Me.RadByComplaint.TabStop = True
        Me.RadByComplaint.Text = "View By Complaint"
        Me.RadByComplaint.UseVisualStyleBackColor = True
        '
        'BtnPreviewDiagnosis
        '
        Me.BtnPreviewDiagnosis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPreviewDiagnosis.Location = New System.Drawing.Point(276, 135)
        Me.BtnPreviewDiagnosis.Name = "BtnPreviewDiagnosis"
        Me.BtnPreviewDiagnosis.Size = New System.Drawing.Size(233, 32)
        Me.BtnPreviewDiagnosis.TabIndex = 4
        Me.BtnPreviewDiagnosis.Text = "Print Preview Diagnosis"
        Me.BtnPreviewDiagnosis.UseVisualStyleBackColor = True
        '
        'cbodiagnosis
        '
        Me.cbodiagnosis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbodiagnosis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbodiagnosis.Enabled = False
        Me.cbodiagnosis.FormattingEnabled = True
        Me.cbodiagnosis.Location = New System.Drawing.Point(276, 100)
        Me.cbodiagnosis.Name = "cbodiagnosis"
        Me.cbodiagnosis.Size = New System.Drawing.Size(331, 28)
        Me.cbodiagnosis.TabIndex = 2
        '
        'RadEachDiagnosis
        '
        Me.RadEachDiagnosis.AutoSize = True
        Me.RadEachDiagnosis.BackColor = System.Drawing.Color.Transparent
        Me.RadEachDiagnosis.Location = New System.Drawing.Point(276, 64)
        Me.RadEachDiagnosis.Name = "RadEachDiagnosis"
        Me.RadEachDiagnosis.Size = New System.Drawing.Size(169, 24)
        Me.RadEachDiagnosis.TabIndex = 1
        Me.RadEachDiagnosis.Text = "View One Diagnosis"
        Me.RadEachDiagnosis.UseVisualStyleBackColor = False
        '
        'RadAllDiagnosis
        '
        Me.RadAllDiagnosis.AutoSize = True
        Me.RadAllDiagnosis.BackColor = System.Drawing.Color.Transparent
        Me.RadAllDiagnosis.Checked = True
        Me.RadAllDiagnosis.Location = New System.Drawing.Point(276, 34)
        Me.RadAllDiagnosis.Name = "RadAllDiagnosis"
        Me.RadAllDiagnosis.Size = New System.Drawing.Size(156, 24)
        Me.RadAllDiagnosis.TabIndex = 0
        Me.RadAllDiagnosis.TabStop = True
        Me.RadAllDiagnosis.Text = "View All Diagnosis"
        Me.RadAllDiagnosis.UseVisualStyleBackColor = False
        '
        'UiTabPage3
        '
        Me.UiTabPage3.Controls.Add(Me.TabControl1)
        Me.UiTabPage3.Key = "AnalysParaExam"
        Me.UiTabPage3.Location = New System.Drawing.Point(1, 28)
        Me.UiTabPage3.Name = "UiTabPage3"
        Me.UiTabPage3.Size = New System.Drawing.Size(808, 277)
        Me.UiTabPage3.TabStop = True
        Me.UiTabPage3.Text = "Analys By Para Exam"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.ByBlood)
        Me.TabControl1.Controls.Add(Me.Fibroscopy)
        Me.TabControl1.Controls.Add(Me.Nasogastro)
        Me.TabControl1.Controls.Add(Me.Coloscopy)
        Me.TabControl1.Location = New System.Drawing.Point(3, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(804, 264)
        Me.TabControl1.TabIndex = 4
        '
        'ByBlood
        '
        Me.ByBlood.Controls.Add(Me.CboSexBlood)
        Me.ByBlood.Controls.Add(Me.ChSexBlood)
        Me.ByBlood.Controls.Add(Me.RadParaAllDiagnosis)
        Me.ByBlood.Controls.Add(Me.cboParaDiagnosis)
        Me.ByBlood.Controls.Add(Me.RadParaOneDiagnosis)
        Me.ByBlood.Controls.Add(Me.btnParaExamViewer)
        Me.ByBlood.Location = New System.Drawing.Point(4, 29)
        Me.ByBlood.Name = "ByBlood"
        Me.ByBlood.Padding = New System.Windows.Forms.Padding(3)
        Me.ByBlood.Size = New System.Drawing.Size(796, 231)
        Me.ByBlood.TabIndex = 0
        Me.ByBlood.Text = "By Blood"
        Me.ByBlood.UseVisualStyleBackColor = True
        '
        'CboSexBlood
        '
        Me.CboSexBlood.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboSexBlood.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboSexBlood.Enabled = False
        Me.CboSexBlood.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CboSexBlood.FormattingEnabled = True
        Me.CboSexBlood.Items.AddRange(New Object() {"Male", "Female"})
        Me.CboSexBlood.Location = New System.Drawing.Point(390, 157)
        Me.CboSexBlood.Name = "CboSexBlood"
        Me.CboSexBlood.Size = New System.Drawing.Size(107, 28)
        Me.CboSexBlood.TabIndex = 12
        '
        'ChSexBlood
        '
        Me.ChSexBlood.AutoSize = True
        Me.ChSexBlood.BackColor = System.Drawing.Color.Transparent
        Me.ChSexBlood.ForeColor = System.Drawing.Color.Red
        Me.ChSexBlood.Location = New System.Drawing.Point(390, 128)
        Me.ChSexBlood.Name = "ChSexBlood"
        Me.ChSexBlood.Size = New System.Drawing.Size(55, 24)
        Me.ChSexBlood.TabIndex = 11
        Me.ChSexBlood.Text = "Sex"
        Me.ChSexBlood.UseVisualStyleBackColor = False
        '
        'RadParaAllDiagnosis
        '
        Me.RadParaAllDiagnosis.AutoSize = True
        Me.RadParaAllDiagnosis.Checked = True
        Me.RadParaAllDiagnosis.Location = New System.Drawing.Point(53, 97)
        Me.RadParaAllDiagnosis.Name = "RadParaAllDiagnosis"
        Me.RadParaAllDiagnosis.Size = New System.Drawing.Size(156, 24)
        Me.RadParaAllDiagnosis.TabIndex = 0
        Me.RadParaAllDiagnosis.TabStop = True
        Me.RadParaAllDiagnosis.Text = "View All Diagnosis"
        Me.RadParaAllDiagnosis.UseVisualStyleBackColor = True
        '
        'cboParaDiagnosis
        '
        Me.cboParaDiagnosis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboParaDiagnosis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboParaDiagnosis.Enabled = False
        Me.cboParaDiagnosis.FormattingEnabled = True
        Me.cboParaDiagnosis.Location = New System.Drawing.Point(53, 157)
        Me.cboParaDiagnosis.Name = "cboParaDiagnosis"
        Me.cboParaDiagnosis.Size = New System.Drawing.Size(331, 28)
        Me.cboParaDiagnosis.TabIndex = 3
        '
        'RadParaOneDiagnosis
        '
        Me.RadParaOneDiagnosis.AutoSize = True
        Me.RadParaOneDiagnosis.Location = New System.Drawing.Point(53, 127)
        Me.RadParaOneDiagnosis.Name = "RadParaOneDiagnosis"
        Me.RadParaOneDiagnosis.Size = New System.Drawing.Size(169, 24)
        Me.RadParaOneDiagnosis.TabIndex = 1
        Me.RadParaOneDiagnosis.Text = "View One Diagnosis"
        Me.RadParaOneDiagnosis.UseVisualStyleBackColor = True
        '
        'btnParaExamViewer
        '
        Me.btnParaExamViewer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnParaExamViewer.Location = New System.Drawing.Point(53, 191)
        Me.btnParaExamViewer.Name = "btnParaExamViewer"
        Me.btnParaExamViewer.Size = New System.Drawing.Size(210, 38)
        Me.btnParaExamViewer.TabIndex = 2
        Me.btnParaExamViewer.Text = "Print Preview Blood"
        Me.btnParaExamViewer.UseVisualStyleBackColor = True
        '
        'Fibroscopy
        '
        Me.Fibroscopy.Controls.Add(Me.CboSexFibros)
        Me.Fibroscopy.Controls.Add(Me.ChSexFibros)
        Me.Fibroscopy.Controls.Add(Me.CboFibroDiagnosis)
        Me.Fibroscopy.Controls.Add(Me.ChViewFibroDiagnosis)
        Me.Fibroscopy.Controls.Add(Me.RadFibMotif)
        Me.Fibroscopy.Controls.Add(Me.CboFibroMotif)
        Me.Fibroscopy.Controls.Add(Me.RadFibOneMotif)
        Me.Fibroscopy.Controls.Add(Me.BtnFibPrintPreview)
        Me.Fibroscopy.Location = New System.Drawing.Point(4, 29)
        Me.Fibroscopy.Name = "Fibroscopy"
        Me.Fibroscopy.Padding = New System.Windows.Forms.Padding(3)
        Me.Fibroscopy.Size = New System.Drawing.Size(796, 231)
        Me.Fibroscopy.TabIndex = 1
        Me.Fibroscopy.Text = "By Fibroscopy"
        Me.Fibroscopy.UseVisualStyleBackColor = True
        '
        'CboSexFibros
        '
        Me.CboSexFibros.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboSexFibros.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboSexFibros.Enabled = False
        Me.CboSexFibros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CboSexFibros.FormattingEnabled = True
        Me.CboSexFibros.Items.AddRange(New Object() {"Male", "Female"})
        Me.CboSexFibros.Location = New System.Drawing.Point(629, 148)
        Me.CboSexFibros.Name = "CboSexFibros"
        Me.CboSexFibros.Size = New System.Drawing.Size(107, 28)
        Me.CboSexFibros.TabIndex = 12
        '
        'ChSexFibros
        '
        Me.ChSexFibros.AutoSize = True
        Me.ChSexFibros.BackColor = System.Drawing.Color.Transparent
        Me.ChSexFibros.ForeColor = System.Drawing.Color.Red
        Me.ChSexFibros.Location = New System.Drawing.Point(630, 119)
        Me.ChSexFibros.Name = "ChSexFibros"
        Me.ChSexFibros.Size = New System.Drawing.Size(55, 24)
        Me.ChSexFibros.TabIndex = 11
        Me.ChSexFibros.Text = "Sex"
        Me.ChSexFibros.UseVisualStyleBackColor = False
        '
        'CboFibroDiagnosis
        '
        Me.CboFibroDiagnosis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboFibroDiagnosis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboFibroDiagnosis.DropDownWidth = 500
        Me.CboFibroDiagnosis.Enabled = False
        Me.CboFibroDiagnosis.FormattingEnabled = True
        Me.CboFibroDiagnosis.Location = New System.Drawing.Point(333, 148)
        Me.CboFibroDiagnosis.Name = "CboFibroDiagnosis"
        Me.CboFibroDiagnosis.Size = New System.Drawing.Size(291, 28)
        Me.CboFibroDiagnosis.TabIndex = 10
        '
        'ChViewFibroDiagnosis
        '
        Me.ChViewFibroDiagnosis.AutoSize = True
        Me.ChViewFibroDiagnosis.ForeColor = System.Drawing.Color.Black
        Me.ChViewFibroDiagnosis.Location = New System.Drawing.Point(333, 119)
        Me.ChViewFibroDiagnosis.Name = "ChViewFibroDiagnosis"
        Me.ChViewFibroDiagnosis.Size = New System.Drawing.Size(165, 24)
        Me.ChViewFibroDiagnosis.TabIndex = 9
        Me.ChViewFibroDiagnosis.Text = "View with diagnosis"
        Me.ChViewFibroDiagnosis.UseVisualStyleBackColor = True
        '
        'RadFibMotif
        '
        Me.RadFibMotif.AutoSize = True
        Me.RadFibMotif.Checked = True
        Me.RadFibMotif.Location = New System.Drawing.Point(33, 88)
        Me.RadFibMotif.Name = "RadFibMotif"
        Me.RadFibMotif.Size = New System.Drawing.Size(206, 24)
        Me.RadFibMotif.TabIndex = 4
        Me.RadFibMotif.TabStop = True
        Me.RadFibMotif.Text = "View all Motif's fibroscopy"
        Me.RadFibMotif.UseVisualStyleBackColor = True
        '
        'CboFibroMotif
        '
        Me.CboFibroMotif.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboFibroMotif.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboFibroMotif.DropDownWidth = 500
        Me.CboFibroMotif.Enabled = False
        Me.CboFibroMotif.FormattingEnabled = True
        Me.CboFibroMotif.Location = New System.Drawing.Point(33, 148)
        Me.CboFibroMotif.Name = "CboFibroMotif"
        Me.CboFibroMotif.Size = New System.Drawing.Size(291, 28)
        Me.CboFibroMotif.TabIndex = 7
        '
        'RadFibOneMotif
        '
        Me.RadFibOneMotif.AutoSize = True
        Me.RadFibOneMotif.Location = New System.Drawing.Point(33, 118)
        Me.RadFibOneMotif.Name = "RadFibOneMotif"
        Me.RadFibOneMotif.Size = New System.Drawing.Size(209, 24)
        Me.RadFibOneMotif.TabIndex = 5
        Me.RadFibOneMotif.Text = "View By Motif's fibroscopy"
        Me.RadFibOneMotif.UseVisualStyleBackColor = True
        '
        'BtnFibPrintPreview
        '
        Me.BtnFibPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFibPrintPreview.Location = New System.Drawing.Point(31, 183)
        Me.BtnFibPrintPreview.Name = "BtnFibPrintPreview"
        Me.BtnFibPrintPreview.Size = New System.Drawing.Size(210, 38)
        Me.BtnFibPrintPreview.TabIndex = 6
        Me.BtnFibPrintPreview.Text = "Print Preview Fibroscopy"
        Me.BtnFibPrintPreview.UseVisualStyleBackColor = True
        '
        'Nasogastro
        '
        Me.Nasogastro.Controls.Add(Me.CboSexNasoga)
        Me.Nasogastro.Controls.Add(Me.ChSexNasogo)
        Me.Nasogastro.Controls.Add(Me.CboDiagnosisNasogastgro)
        Me.Nasogastro.Controls.Add(Me.ChDiagnosisNaso)
        Me.Nasogastro.Controls.Add(Me.RadNasoAllMotif)
        Me.Nasogastro.Controls.Add(Me.CboNasoMotif)
        Me.Nasogastro.Controls.Add(Me.RadNasoByMotif)
        Me.Nasogastro.Controls.Add(Me.BtnNasoPrintPreview)
        Me.Nasogastro.Location = New System.Drawing.Point(4, 29)
        Me.Nasogastro.Name = "Nasogastro"
        Me.Nasogastro.Padding = New System.Windows.Forms.Padding(3)
        Me.Nasogastro.Size = New System.Drawing.Size(796, 231)
        Me.Nasogastro.TabIndex = 2
        Me.Nasogastro.Text = "By Nasogastro"
        Me.Nasogastro.UseVisualStyleBackColor = True
        '
        'CboSexNasoga
        '
        Me.CboSexNasoga.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboSexNasoga.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboSexNasoga.Enabled = False
        Me.CboSexNasoga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CboSexNasoga.FormattingEnabled = True
        Me.CboSexNasoga.Items.AddRange(New Object() {"Male", "Female"})
        Me.CboSexNasoga.Location = New System.Drawing.Point(653, 148)
        Me.CboSexNasoga.Name = "CboSexNasoga"
        Me.CboSexNasoga.Size = New System.Drawing.Size(107, 28)
        Me.CboSexNasoga.TabIndex = 14
        '
        'ChSexNasogo
        '
        Me.ChSexNasogo.AutoSize = True
        Me.ChSexNasogo.BackColor = System.Drawing.Color.Transparent
        Me.ChSexNasogo.ForeColor = System.Drawing.Color.Red
        Me.ChSexNasogo.Location = New System.Drawing.Point(654, 119)
        Me.ChSexNasogo.Name = "ChSexNasogo"
        Me.ChSexNasogo.Size = New System.Drawing.Size(55, 24)
        Me.ChSexNasogo.TabIndex = 13
        Me.ChSexNasogo.Text = "Sex"
        Me.ChSexNasogo.UseVisualStyleBackColor = False
        '
        'CboDiagnosisNasogastgro
        '
        Me.CboDiagnosisNasogastgro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDiagnosisNasogastgro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDiagnosisNasogastgro.DropDownWidth = 500
        Me.CboDiagnosisNasogastgro.Enabled = False
        Me.CboDiagnosisNasogastgro.FormattingEnabled = True
        Me.CboDiagnosisNasogastgro.Location = New System.Drawing.Point(397, 149)
        Me.CboDiagnosisNasogastgro.Name = "CboDiagnosisNasogastgro"
        Me.CboDiagnosisNasogastgro.Size = New System.Drawing.Size(251, 28)
        Me.CboDiagnosisNasogastgro.TabIndex = 12
        '
        'ChDiagnosisNaso
        '
        Me.ChDiagnosisNaso.AutoSize = True
        Me.ChDiagnosisNaso.ForeColor = System.Drawing.Color.Black
        Me.ChDiagnosisNaso.Location = New System.Drawing.Point(397, 120)
        Me.ChDiagnosisNaso.Name = "ChDiagnosisNaso"
        Me.ChDiagnosisNaso.Size = New System.Drawing.Size(165, 24)
        Me.ChDiagnosisNaso.TabIndex = 11
        Me.ChDiagnosisNaso.Text = "View with diagnosis"
        Me.ChDiagnosisNaso.UseVisualStyleBackColor = True
        '
        'RadNasoAllMotif
        '
        Me.RadNasoAllMotif.AutoSize = True
        Me.RadNasoAllMotif.Checked = True
        Me.RadNasoAllMotif.Location = New System.Drawing.Point(60, 89)
        Me.RadNasoAllMotif.Name = "RadNasoAllMotif"
        Me.RadNasoAllMotif.Size = New System.Drawing.Size(216, 24)
        Me.RadNasoAllMotif.TabIndex = 4
        Me.RadNasoAllMotif.TabStop = True
        Me.RadNasoAllMotif.Text = "View all motif's Nasogastro"
        Me.RadNasoAllMotif.UseVisualStyleBackColor = True
        '
        'CboNasoMotif
        '
        Me.CboNasoMotif.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboNasoMotif.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboNasoMotif.Enabled = False
        Me.CboNasoMotif.FormattingEnabled = True
        Me.CboNasoMotif.Location = New System.Drawing.Point(60, 149)
        Me.CboNasoMotif.Name = "CboNasoMotif"
        Me.CboNasoMotif.Size = New System.Drawing.Size(331, 28)
        Me.CboNasoMotif.TabIndex = 7
        '
        'RadNasoByMotif
        '
        Me.RadNasoByMotif.AutoSize = True
        Me.RadNasoByMotif.Location = New System.Drawing.Point(60, 119)
        Me.RadNasoByMotif.Name = "RadNasoByMotif"
        Me.RadNasoByMotif.Size = New System.Drawing.Size(219, 24)
        Me.RadNasoByMotif.TabIndex = 5
        Me.RadNasoByMotif.Text = "View By motif's Nasogastro"
        Me.RadNasoByMotif.UseVisualStyleBackColor = True
        '
        'BtnNasoPrintPreview
        '
        Me.BtnNasoPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNasoPrintPreview.Location = New System.Drawing.Point(60, 183)
        Me.BtnNasoPrintPreview.Name = "BtnNasoPrintPreview"
        Me.BtnNasoPrintPreview.Size = New System.Drawing.Size(210, 38)
        Me.BtnNasoPrintPreview.TabIndex = 6
        Me.BtnNasoPrintPreview.Text = "Print Preview Nasogastro"
        Me.BtnNasoPrintPreview.UseVisualStyleBackColor = True
        '
        'Coloscopy
        '
        Me.Coloscopy.Controls.Add(Me.CboSexColoscopy)
        Me.Coloscopy.Controls.Add(Me.ChSexColosco)
        Me.Coloscopy.Controls.Add(Me.CboDiagnosisColoscopy)
        Me.Coloscopy.Controls.Add(Me.ChViewDiagnosisColoscopy)
        Me.Coloscopy.Controls.Add(Me.RadColoAllDiagnosis)
        Me.Coloscopy.Controls.Add(Me.cboColoMotify)
        Me.Coloscopy.Controls.Add(Me.RadColoOneDiagnosis)
        Me.Coloscopy.Controls.Add(Me.BtnColoPrintPreview)
        Me.Coloscopy.Location = New System.Drawing.Point(4, 29)
        Me.Coloscopy.Name = "Coloscopy"
        Me.Coloscopy.Padding = New System.Windows.Forms.Padding(3)
        Me.Coloscopy.Size = New System.Drawing.Size(796, 231)
        Me.Coloscopy.TabIndex = 3
        Me.Coloscopy.Text = "By Coloscopy"
        Me.Coloscopy.UseVisualStyleBackColor = True
        '
        'CboSexColoscopy
        '
        Me.CboSexColoscopy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboSexColoscopy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboSexColoscopy.Enabled = False
        Me.CboSexColoscopy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CboSexColoscopy.FormattingEnabled = True
        Me.CboSexColoscopy.Items.AddRange(New Object() {"Male", "Female"})
        Me.CboSexColoscopy.Location = New System.Drawing.Point(663, 164)
        Me.CboSexColoscopy.Name = "CboSexColoscopy"
        Me.CboSexColoscopy.Size = New System.Drawing.Size(107, 28)
        Me.CboSexColoscopy.TabIndex = 14
        '
        'ChSexColosco
        '
        Me.ChSexColosco.AutoSize = True
        Me.ChSexColosco.BackColor = System.Drawing.Color.Transparent
        Me.ChSexColosco.ForeColor = System.Drawing.Color.Red
        Me.ChSexColosco.Location = New System.Drawing.Point(664, 135)
        Me.ChSexColosco.Name = "ChSexColosco"
        Me.ChSexColosco.Size = New System.Drawing.Size(55, 24)
        Me.ChSexColosco.TabIndex = 13
        Me.ChSexColosco.Text = "Sex"
        Me.ChSexColosco.UseVisualStyleBackColor = False
        '
        'CboDiagnosisColoscopy
        '
        Me.CboDiagnosisColoscopy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDiagnosisColoscopy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDiagnosisColoscopy.DropDownWidth = 500
        Me.CboDiagnosisColoscopy.Enabled = False
        Me.CboDiagnosisColoscopy.FormattingEnabled = True
        Me.CboDiagnosisColoscopy.Location = New System.Drawing.Point(367, 164)
        Me.CboDiagnosisColoscopy.Name = "CboDiagnosisColoscopy"
        Me.CboDiagnosisColoscopy.Size = New System.Drawing.Size(291, 28)
        Me.CboDiagnosisColoscopy.TabIndex = 12
        '
        'ChViewDiagnosisColoscopy
        '
        Me.ChViewDiagnosisColoscopy.AutoSize = True
        Me.ChViewDiagnosisColoscopy.ForeColor = System.Drawing.Color.Black
        Me.ChViewDiagnosisColoscopy.Location = New System.Drawing.Point(367, 135)
        Me.ChViewDiagnosisColoscopy.Name = "ChViewDiagnosisColoscopy"
        Me.ChViewDiagnosisColoscopy.Size = New System.Drawing.Size(165, 24)
        Me.ChViewDiagnosisColoscopy.TabIndex = 11
        Me.ChViewDiagnosisColoscopy.Text = "View with diagnosis"
        Me.ChViewDiagnosisColoscopy.UseVisualStyleBackColor = True
        '
        'RadColoAllDiagnosis
        '
        Me.RadColoAllDiagnosis.AutoSize = True
        Me.RadColoAllDiagnosis.Checked = True
        Me.RadColoAllDiagnosis.Location = New System.Drawing.Point(30, 103)
        Me.RadColoAllDiagnosis.Name = "RadColoAllDiagnosis"
        Me.RadColoAllDiagnosis.Size = New System.Drawing.Size(156, 24)
        Me.RadColoAllDiagnosis.TabIndex = 4
        Me.RadColoAllDiagnosis.TabStop = True
        Me.RadColoAllDiagnosis.Text = "View All coloscopy"
        Me.RadColoAllDiagnosis.UseVisualStyleBackColor = True
        '
        'cboColoMotify
        '
        Me.cboColoMotify.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboColoMotify.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboColoMotify.Enabled = False
        Me.cboColoMotify.FormattingEnabled = True
        Me.cboColoMotify.Location = New System.Drawing.Point(30, 164)
        Me.cboColoMotify.Name = "cboColoMotify"
        Me.cboColoMotify.Size = New System.Drawing.Size(331, 28)
        Me.cboColoMotify.TabIndex = 7
        '
        'RadColoOneDiagnosis
        '
        Me.RadColoOneDiagnosis.AutoSize = True
        Me.RadColoOneDiagnosis.Location = New System.Drawing.Point(30, 134)
        Me.RadColoOneDiagnosis.Name = "RadColoOneDiagnosis"
        Me.RadColoOneDiagnosis.Size = New System.Drawing.Size(169, 24)
        Me.RadColoOneDiagnosis.TabIndex = 5
        Me.RadColoOneDiagnosis.Text = "View One coloscopy"
        Me.RadColoOneDiagnosis.UseVisualStyleBackColor = True
        '
        'BtnColoPrintPreview
        '
        Me.BtnColoPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnColoPrintPreview.Location = New System.Drawing.Point(30, 199)
        Me.BtnColoPrintPreview.Name = "BtnColoPrintPreview"
        Me.BtnColoPrintPreview.Size = New System.Drawing.Size(210, 38)
        Me.BtnColoPrintPreview.TabIndex = 6
        Me.BtnColoPrintPreview.Text = "Print Preview Coloscopy"
        Me.BtnColoPrintPreview.UseVisualStyleBackColor = True
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd/MM/yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(311, 36)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(139, 29)
        Me.DateTo.TabIndex = 1
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(111, 36)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(139, 29)
        Me.DateFrom.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(269, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date From:"
        '
        'ErrAnalysis
        '
        Me.ErrAnalysis.ContainerControl = Me
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(741, 419)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(111, 34)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'BgLoadAnalysis
        '
        '
        'FormDataAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 463)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormDataAnalysis"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Analysis By"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        Me.UiTabPage1.ResumeLayout(False)
        Me.UiTabPage1.PerformLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        Me.UiTabPage2.ResumeLayout(False)
        Me.UiTabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.UiTabPage3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ByBlood.ResumeLayout(False)
        Me.ByBlood.PerformLayout()
        Me.Fibroscopy.ResumeLayout(False)
        Me.Fibroscopy.PerformLayout()
        Me.Nasogastro.ResumeLayout(False)
        Me.Nasogastro.PerformLayout()
        Me.Coloscopy.ResumeLayout(False)
        Me.Coloscopy.PerformLayout()
        CType(Me.ErrAnalysis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage2 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents CboProvince As System.Windows.Forms.ComboBox
    Friend WithEvents RadEachProvince As System.Windows.Forms.RadioButton
    Friend WithEvents RadAllProvince As System.Windows.Forms.RadioButton
    Friend WithEvents BtnProvincePreview As System.Windows.Forms.Button
    Friend WithEvents ErrAnalysis As System.Windows.Forms.ErrorProvider
    Friend WithEvents RadEachDiagnosis As System.Windows.Forms.RadioButton
    Friend WithEvents RadAllDiagnosis As System.Windows.Forms.RadioButton
    Friend WithEvents BtnPreviewDiagnosis As System.Windows.Forms.Button
    Friend WithEvents cbodiagnosis As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadByPhysical As System.Windows.Forms.RadioButton
    Friend WithEvents RadByMedicalHistory As System.Windows.Forms.RadioButton
    Friend WithEvents RadByComplaint As System.Windows.Forms.RadioButton
    Friend WithEvents RadOnePDiagnosis As System.Windows.Forms.RadioButton
    Friend WithEvents RadPAllDiagnosis As System.Windows.Forms.RadioButton
    Friend WithEvents CboPDiagnosis As System.Windows.Forms.ComboBox
    Friend WithEvents UiTabPage3 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents RadParaOneDiagnosis As System.Windows.Forms.RadioButton
    Friend WithEvents RadParaAllDiagnosis As System.Windows.Forms.RadioButton
    Friend WithEvents btnParaExamViewer As System.Windows.Forms.Button
    Friend WithEvents cboParaDiagnosis As System.Windows.Forms.ComboBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents ByBlood As System.Windows.Forms.TabPage
    Friend WithEvents Fibroscopy As System.Windows.Forms.TabPage
    Friend WithEvents Nasogastro As System.Windows.Forms.TabPage
    Friend WithEvents Coloscopy As System.Windows.Forms.TabPage
    Friend WithEvents RadFibMotif As System.Windows.Forms.RadioButton
    Friend WithEvents CboFibroMotif As System.Windows.Forms.ComboBox
    Friend WithEvents RadFibOneMotif As System.Windows.Forms.RadioButton
    Friend WithEvents BtnFibPrintPreview As System.Windows.Forms.Button
    Friend WithEvents RadNasoAllMotif As System.Windows.Forms.RadioButton
    Friend WithEvents CboNasoMotif As System.Windows.Forms.ComboBox
    Friend WithEvents RadNasoByMotif As System.Windows.Forms.RadioButton
    Friend WithEvents BtnNasoPrintPreview As System.Windows.Forms.Button
    Friend WithEvents RadColoAllDiagnosis As System.Windows.Forms.RadioButton
    Friend WithEvents cboColoMotify As System.Windows.Forms.ComboBox
    Friend WithEvents RadColoOneDiagnosis As System.Windows.Forms.RadioButton
    Friend WithEvents BtnColoPrintPreview As System.Windows.Forms.Button
    Friend WithEvents BgLoadAnalysis As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ChViewDetialData As System.Windows.Forms.CheckBox
    Friend WithEvents CboFibroDiagnosis As System.Windows.Forms.ComboBox
    Friend WithEvents ChViewFibroDiagnosis As System.Windows.Forms.CheckBox
    Friend WithEvents CboDiagnosisNasogastgro As System.Windows.Forms.ComboBox
    Friend WithEvents ChDiagnosisNaso As System.Windows.Forms.CheckBox
    Friend WithEvents CboDiagnosisColoscopy As System.Windows.Forms.ComboBox
    Friend WithEvents ChViewDiagnosisColoscopy As System.Windows.Forms.CheckBox
    Friend WithEvents ChSexProvince As System.Windows.Forms.CheckBox
    Friend WithEvents CboSexProvince As System.Windows.Forms.ComboBox
    Friend WithEvents CboSexComplain As System.Windows.Forms.ComboBox
    Friend WithEvents chSexComplaint As System.Windows.Forms.CheckBox
    Friend WithEvents CboSexBlood As System.Windows.Forms.ComboBox
    Friend WithEvents ChSexBlood As System.Windows.Forms.CheckBox
    Friend WithEvents CboSexFibros As System.Windows.Forms.ComboBox
    Friend WithEvents ChSexFibros As System.Windows.Forms.CheckBox
    Friend WithEvents CboSexNasoga As System.Windows.Forms.ComboBox
    Friend WithEvents ChSexNasogo As System.Windows.Forms.CheckBox
    Friend WithEvents CboSexColoscopy As System.Windows.Forms.ComboBox
    Friend WithEvents ChSexColosco As System.Windows.Forms.CheckBox
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents ChProvice As System.Windows.Forms.CheckBox
End Class
