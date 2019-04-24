<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditConsultation
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
        Dim GridPrePhysical_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditConsultation))
        Dim GridPreComplaint_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridPreMedicalHistory_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim PrescriptionList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.TxtPhysicalNote = New System.Windows.Forms.TextBox
        Me.cboUsage = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.BtnRemovePrePhysical = New System.Windows.Forms.Button
        Me.BtnAddPrePhysical = New System.Windows.Forms.Button
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.GridPrePhysical = New Janus.Windows.GridEX.GridEX
        Me.Label16 = New System.Windows.Forms.Label
        Me.CboPhysicalExam = New System.Windows.Forms.ComboBox
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage6 = New Janus.Windows.UI.Tab.UITabPage
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.GridPreComplaint = New Janus.Windows.GridEX.GridEX
        Me.CboComplaint = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TxtComplainDescription = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.UiTabPage7 = New Janus.Windows.UI.Tab.UITabPage
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.BtnRemoveMedicalHistory = New System.Windows.Forms.Button
        Me.BtnAddMedicalHistor = New System.Windows.Forms.Button
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.GridPreMedicalHistory = New Janus.Windows.GridEX.GridEX
        Me.Label14 = New System.Windows.Forms.Label
        Me.CboMedical = New System.Windows.Forms.ComboBox
        Me.TxtMedicalNote = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.UiTabPage8 = New Janus.Windows.UI.Tab.UITabPage
        Me.UiTabPage2 = New Janus.Windows.UI.Tab.UITabPage
        Me.GroupBox19 = New System.Windows.Forms.GroupBox
        Me.TxtTotalUse = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.BtnRemovePrescription = New System.Windows.Forms.Button
        Me.PrescriptionList = New Janus.Windows.GridEX.GridEX
        Me.BtnAddPrescription = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtdosage = New System.Windows.Forms.TextBox
        Me.txtduration = New System.Windows.Forms.TextBox
        Me.cbomedicine = New System.Windows.Forms.ComboBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblUserID = New System.Windows.Forms.Label
        Me.txtDoctor = New System.Windows.Forms.TextBox
        Me.BtnParaExamHistory = New System.Windows.Forms.Button
        Me.BtnRequestExam = New System.Windows.Forms.Button
        Me.lblPrintPrescription = New System.Windows.Forms.Label
        Me.dtprescription = New System.Windows.Forms.DateTimePicker
        Me.cbodoc = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cbodiagnosis = New System.Windows.Forms.ComboBox
        Me.cboconsulttype = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtremark = New System.Windows.Forms.TextBox
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnSavePrint = New System.Windows.Forms.Button
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.bgLoadingData = New System.ComponentModel.BackgroundWorker
        Me.UiTab2 = New Janus.Windows.UI.Tab.UITab
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtPatientNo = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtsex = New System.Windows.Forms.TextBox
        Me.ErrPrescription = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.AutocompleteMenu1 = New AutocompleteMenuNS.AutocompleteMenu
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.GridPrePhysical, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.UiTabPage6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.GridPreComplaint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabPage7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.GridPreMedicalHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabPage8.SuspendLayout()
        Me.UiTabPage2.SuspendLayout()
        Me.GroupBox19.SuspendLayout()
        CType(Me.PrescriptionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.UiTabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.UiTab2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrPrescription, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtPhysicalNote
        '
        Me.TxtPhysicalNote.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.TxtPhysicalNote, Me.AutocompleteMenu1)
        Me.TxtPhysicalNote.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPhysicalNote.Location = New System.Drawing.Point(426, 71)
        Me.TxtPhysicalNote.Multiline = True
        Me.TxtPhysicalNote.Name = "TxtPhysicalNote"
        Me.TxtPhysicalNote.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtPhysicalNote.Size = New System.Drawing.Size(1093, 213)
        Me.TxtPhysicalNote.TabIndex = 1
        '
        'cboUsage
        '
        Me.cboUsage.DropDownWidth = 400
        Me.cboUsage.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUsage.FormattingEnabled = True
        Me.cboUsage.Location = New System.Drawing.Point(718, 17)
        Me.cboUsage.Name = "cboUsage"
        Me.cboUsage.Size = New System.Drawing.Size(298, 35)
        Me.cboUsage.TabIndex = 58
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(423, 52)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 16)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Note:"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.BtnRemovePrePhysical)
        Me.GroupBox7.Controls.Add(Me.BtnAddPrePhysical)
        Me.GroupBox7.Controls.Add(Me.GroupBox9)
        Me.GroupBox7.Controls.Add(Me.Label16)
        Me.GroupBox7.Controls.Add(Me.CboPhysicalExam)
        Me.GroupBox7.Controls.Add(Me.TxtPhysicalNote)
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox7.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(1527, 290)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        '
        'BtnRemovePrePhysical
        '
        Me.BtnRemovePrePhysical.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemovePrePhysical.Location = New System.Drawing.Point(477, 16)
        Me.BtnRemovePrePhysical.Name = "BtnRemovePrePhysical"
        Me.BtnRemovePrePhysical.Size = New System.Drawing.Size(57, 27)
        Me.BtnRemovePrePhysical.TabIndex = 16
        Me.BtnRemovePrePhysical.Text = "-"
        Me.BtnRemovePrePhysical.UseVisualStyleBackColor = True
        '
        'BtnAddPrePhysical
        '
        Me.BtnAddPrePhysical.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddPrePhysical.Location = New System.Drawing.Point(414, 16)
        Me.BtnAddPrePhysical.Name = "BtnAddPrePhysical"
        Me.BtnAddPrePhysical.Size = New System.Drawing.Size(57, 27)
        Me.BtnAddPrePhysical.TabIndex = 15
        Me.BtnAddPrePhysical.Text = "+"
        Me.BtnAddPrePhysical.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox9.Controls.Add(Me.GridPrePhysical)
        Me.GroupBox9.Location = New System.Drawing.Point(9, 63)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(411, 221)
        Me.GroupBox9.TabIndex = 12
        Me.GroupBox9.TabStop = False
        '
        'GridPrePhysical
        '
        Me.GridPrePhysical.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridPrePhysical_DesignTimeLayout.LayoutString = resources.GetString("GridPrePhysical_DesignTimeLayout.LayoutString")
        Me.GridPrePhysical.DesignTimeLayout = GridPrePhysical_DesignTimeLayout
        Me.GridPrePhysical.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPrePhysical.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridPrePhysical.GroupByBoxVisible = False
        Me.GridPrePhysical.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[False]
        Me.GridPrePhysical.Location = New System.Drawing.Point(3, 18)
        Me.GridPrePhysical.Name = "GridPrePhysical"
        Me.GridPrePhysical.RecordNavigator = True
        Me.GridPrePhysical.Size = New System.Drawing.Size(405, 200)
        Me.GridPrePhysical.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(9, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(138, 16)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Physical Examination:"
        '
        'CboPhysicalExam
        '
        Me.CboPhysicalExam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboPhysicalExam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboPhysicalExam.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboPhysicalExam.Location = New System.Drawing.Point(153, 17)
        Me.CboPhysicalExam.Name = "CboPhysicalExam"
        Me.CboPhysicalExam.Size = New System.Drawing.Size(255, 26)
        Me.CboPhysicalExam.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(2, 17)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.UiTab1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer2.Panel2.Controls.Add(Me.BtnCancel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.BtnSavePrint)
        Me.SplitContainer2.Size = New System.Drawing.Size(1540, 598)
        Me.SplitContainer2.SplitterDistance = 418
        Me.SplitContainer2.TabIndex = 20
        '
        'UiTab1
        '
        Me.UiTab1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiTab1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiTab1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UiTab1.Location = New System.Drawing.Point(3, 97)
        Me.UiTab1.Margin = New System.Windows.Forms.Padding(2)
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.Size = New System.Drawing.Size(1531, 317)
        Me.UiTab1.TabIndex = 1
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage6, Me.UiTabPage7, Me.UiTabPage8, Me.UiTabPage2})
        Me.UiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Normal
        '
        'UiTabPage6
        '
        Me.UiTabPage6.Controls.Add(Me.GroupBox5)
        Me.UiTabPage6.Location = New System.Drawing.Point(1, 24)
        Me.UiTabPage6.Name = "UiTabPage6"
        Me.UiTabPage6.Size = New System.Drawing.Size(1527, 290)
        Me.UiTabPage6.TabStop = True
        Me.UiTabPage6.Text = "    Patient Complaint    "
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Controls.Add(Me.GroupBox10)
        Me.GroupBox5.Controls.Add(Me.CboComplaint)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.TxtComplainDescription)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1527, 290)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(408, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 28)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(347, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(57, 28)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox10.Controls.Add(Me.GridPreComplaint)
        Me.GroupBox10.Location = New System.Drawing.Point(10, 56)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(354, 228)
        Me.GroupBox10.TabIndex = 38
        Me.GroupBox10.TabStop = False
        '
        'GridPreComplaint
        '
        GridPreComplaint_DesignTimeLayout.LayoutString = resources.GetString("GridPreComplaint_DesignTimeLayout.LayoutString")
        Me.GridPreComplaint.DesignTimeLayout = GridPreComplaint_DesignTimeLayout
        Me.GridPreComplaint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPreComplaint.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GridPreComplaint.GroupByBoxVisible = False
        Me.GridPreComplaint.HeaderFormatStyle.FontItalic = Janus.Windows.GridEX.TriState.[False]
        Me.GridPreComplaint.Location = New System.Drawing.Point(3, 18)
        Me.GridPreComplaint.Name = "GridPreComplaint"
        Me.GridPreComplaint.RecordNavigator = True
        Me.GridPreComplaint.RowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[False]
        Me.GridPreComplaint.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridPreComplaint.Size = New System.Drawing.Size(348, 207)
        Me.GridPreComplaint.TabIndex = 1
        '
        'CboComplaint
        '
        Me.CboComplaint.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboComplaint.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboComplaint.DropDownWidth = 350
        Me.CboComplaint.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboComplaint.Location = New System.Drawing.Point(83, 22)
        Me.CboComplaint.Name = "CboComplaint"
        Me.CboComplaint.Size = New System.Drawing.Size(258, 26)
        Me.CboComplaint.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(7, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 16)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Complaint:"
        '
        'TxtComplainDescription
        '
        Me.TxtComplainDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.TxtComplainDescription, Me.AutocompleteMenu1)
        Me.TxtComplainDescription.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtComplainDescription.Location = New System.Drawing.Point(370, 78)
        Me.TxtComplainDescription.Multiline = True
        Me.TxtComplainDescription.Name = "TxtComplainDescription"
        Me.TxtComplainDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtComplainDescription.Size = New System.Drawing.Size(1209, 206)
        Me.TxtComplainDescription.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(369, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 16)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Note:"
        '
        'UiTabPage7
        '
        Me.UiTabPage7.Controls.Add(Me.GroupBox6)
        Me.UiTabPage7.Location = New System.Drawing.Point(1, 24)
        Me.UiTabPage7.Name = "UiTabPage7"
        Me.UiTabPage7.Size = New System.Drawing.Size(1527, 290)
        Me.UiTabPage7.TabStop = True
        Me.UiTabPage7.Text = "   Medical History   "
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.BtnRemoveMedicalHistory)
        Me.GroupBox6.Controls.Add(Me.BtnAddMedicalHistor)
        Me.GroupBox6.Controls.Add(Me.GroupBox8)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.CboMedical)
        Me.GroupBox6.Controls.Add(Me.TxtMedicalNote)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1527, 290)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        '
        'BtnRemoveMedicalHistory
        '
        Me.BtnRemoveMedicalHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemoveMedicalHistory.Location = New System.Drawing.Point(438, 23)
        Me.BtnRemoveMedicalHistory.Name = "BtnRemoveMedicalHistory"
        Me.BtnRemoveMedicalHistory.Size = New System.Drawing.Size(57, 27)
        Me.BtnRemoveMedicalHistory.TabIndex = 14
        Me.BtnRemoveMedicalHistory.Text = "-"
        Me.BtnRemoveMedicalHistory.UseVisualStyleBackColor = True
        '
        'BtnAddMedicalHistor
        '
        Me.BtnAddMedicalHistor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddMedicalHistor.Location = New System.Drawing.Point(374, 23)
        Me.BtnAddMedicalHistor.Name = "BtnAddMedicalHistor"
        Me.BtnAddMedicalHistor.Size = New System.Drawing.Size(57, 27)
        Me.BtnAddMedicalHistor.TabIndex = 13
        Me.BtnAddMedicalHistor.Text = "+"
        Me.BtnAddMedicalHistor.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox8.Controls.Add(Me.GridPreMedicalHistory)
        Me.GroupBox8.Location = New System.Drawing.Point(10, 72)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(414, 213)
        Me.GroupBox8.TabIndex = 11
        Me.GroupBox8.TabStop = False
        '
        'GridPreMedicalHistory
        '
        GridPreMedicalHistory_DesignTimeLayout.LayoutString = resources.GetString("GridPreMedicalHistory_DesignTimeLayout.LayoutString")
        Me.GridPreMedicalHistory.DesignTimeLayout = GridPreMedicalHistory_DesignTimeLayout
        Me.GridPreMedicalHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPreMedicalHistory.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridPreMedicalHistory.GroupByBoxVisible = False
        Me.GridPreMedicalHistory.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[False]
        Me.GridPreMedicalHistory.Location = New System.Drawing.Point(3, 18)
        Me.GridPreMedicalHistory.Name = "GridPreMedicalHistory"
        Me.GridPreMedicalHistory.RecordNavigator = True
        Me.GridPreMedicalHistory.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridPreMedicalHistory.Size = New System.Drawing.Size(408, 192)
        Me.GridPreMedicalHistory.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(7, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 16)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "History Name:"
        '
        'CboMedical
        '
        Me.CboMedical.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboMedical.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboMedical.DropDownWidth = 350
        Me.CboMedical.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMedical.Location = New System.Drawing.Point(104, 23)
        Me.CboMedical.Name = "CboMedical"
        Me.CboMedical.Size = New System.Drawing.Size(265, 26)
        Me.CboMedical.TabIndex = 0
        '
        'TxtMedicalNote
        '
        Me.TxtMedicalNote.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.TxtMedicalNote, Me.AutocompleteMenu1)
        Me.TxtMedicalNote.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMedicalNote.Location = New System.Drawing.Point(430, 78)
        Me.TxtMedicalNote.Multiline = True
        Me.TxtMedicalNote.Name = "TxtMedicalNote"
        Me.TxtMedicalNote.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtMedicalNote.Size = New System.Drawing.Size(1089, 206)
        Me.TxtMedicalNote.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(425, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 16)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Description:"
        '
        'UiTabPage8
        '
        Me.UiTabPage8.Controls.Add(Me.GroupBox7)
        Me.UiTabPage8.Location = New System.Drawing.Point(1, 24)
        Me.UiTabPage8.Name = "UiTabPage8"
        Me.UiTabPage8.Size = New System.Drawing.Size(1527, 290)
        Me.UiTabPage8.TabStop = True
        Me.UiTabPage8.Text = "    Physical Exam   "
        '
        'UiTabPage2
        '
        Me.UiTabPage2.Controls.Add(Me.GroupBox19)
        Me.UiTabPage2.Location = New System.Drawing.Point(1, 24)
        Me.UiTabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.UiTabPage2.Name = "UiTabPage2"
        Me.UiTabPage2.Size = New System.Drawing.Size(1527, 290)
        Me.UiTabPage2.TabStop = True
        Me.UiTabPage2.Text = "   Prescription   "
        '
        'GroupBox19
        '
        Me.GroupBox19.Controls.Add(Me.TxtTotalUse)
        Me.GroupBox19.Controls.Add(Me.Label7)
        Me.GroupBox19.Controls.Add(Me.cboUsage)
        Me.GroupBox19.Controls.Add(Me.Label6)
        Me.GroupBox19.Controls.Add(Me.BtnRemovePrescription)
        Me.GroupBox19.Controls.Add(Me.PrescriptionList)
        Me.GroupBox19.Controls.Add(Me.BtnAddPrescription)
        Me.GroupBox19.Controls.Add(Me.Label1)
        Me.GroupBox19.Controls.Add(Me.txtdosage)
        Me.GroupBox19.Controls.Add(Me.txtduration)
        Me.GroupBox19.Controls.Add(Me.cbomedicine)
        Me.GroupBox19.Controls.Add(Me.Label35)
        Me.GroupBox19.Controls.Add(Me.Label51)
        Me.GroupBox19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox19.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(1527, 290)
        Me.GroupBox19.TabIndex = 0
        Me.GroupBox19.TabStop = False
        '
        'TxtTotalUse
        '
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.TxtTotalUse, Nothing)
        Me.TxtTotalUse.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalUse.Location = New System.Drawing.Point(1090, 23)
        Me.TxtTotalUse.Name = "TxtTotalUse"
        Me.TxtTotalUse.Size = New System.Drawing.Size(75, 26)
        Me.TxtTotalUse.TabIndex = 59
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(1026, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Duration"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(665, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Usage:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnRemovePrescription
        '
        Me.BtnRemovePrescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemovePrescription.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemovePrescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRemovePrescription.Location = New System.Drawing.Point(1249, 19)
        Me.BtnRemovePrescription.Name = "BtnRemovePrescription"
        Me.BtnRemovePrescription.Size = New System.Drawing.Size(69, 28)
        Me.BtnRemovePrescription.TabIndex = 4
        Me.BtnRemovePrescription.Text = "Remove"
        Me.BtnRemovePrescription.UseVisualStyleBackColor = True
        '
        'PrescriptionList
        '
        Me.PrescriptionList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.PrescriptionList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        PrescriptionList_DesignTimeLayout.LayoutString = resources.GetString("PrescriptionList_DesignTimeLayout.LayoutString")
        Me.PrescriptionList.DesignTimeLayout = PrescriptionList_DesignTimeLayout
        Me.PrescriptionList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrescriptionList.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.PrescriptionList.GroupByBoxVisible = False
        Me.PrescriptionList.HeaderFormatStyle.FontSize = 10.0!
        Me.PrescriptionList.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.PrescriptionList.Location = New System.Drawing.Point(6, 58)
        Me.PrescriptionList.Name = "PrescriptionList"
        Me.PrescriptionList.RecordNavigator = True
        Me.PrescriptionList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.PrescriptionList.Size = New System.Drawing.Size(1513, 225)
        Me.PrescriptionList.TabIndex = 5
        '
        'BtnAddPrescription
        '
        Me.BtnAddPrescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddPrescription.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddPrescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnAddPrescription.Location = New System.Drawing.Point(1174, 19)
        Me.BtnAddPrescription.Name = "BtnAddPrescription"
        Me.BtnAddPrescription.Size = New System.Drawing.Size(69, 28)
        Me.BtnAddPrescription.TabIndex = 3
        Me.BtnAddPrescription.Text = "Add"
        Me.BtnAddPrescription.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(271, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Dosage:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdosage
        '
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.txtdosage, Nothing)
        Me.txtdosage.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdosage.Location = New System.Drawing.Point(329, 23)
        Me.txtdosage.Name = "txtdosage"
        Me.txtdosage.Size = New System.Drawing.Size(124, 26)
        Me.txtdosage.TabIndex = 1
        '
        'txtduration
        '
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.txtduration, Nothing)
        Me.txtduration.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtduration.Location = New System.Drawing.Point(526, 23)
        Me.txtduration.Name = "txtduration"
        Me.txtduration.Size = New System.Drawing.Size(121, 26)
        Me.txtduration.TabIndex = 2
        '
        'cbomedicine
        '
        Me.cbomedicine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbomedicine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbomedicine.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbomedicine.Location = New System.Drawing.Point(77, 22)
        Me.cbomedicine.Name = "cbomedicine"
        Me.cbomedicine.Size = New System.Drawing.Size(184, 26)
        Me.cbomedicine.TabIndex = 0
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label35.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label35.Location = New System.Drawing.Point(466, 28)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(62, 16)
        Me.Label35.TabIndex = 52
        Me.Label35.Text = "Total Use"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label51.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label51.Location = New System.Drawing.Point(11, 27)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(64, 16)
        Me.Label51.TabIndex = 46
        Me.Label51.Text = "Medicine:"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.lblUserID)
        Me.GroupBox3.Controls.Add(Me.txtDoctor)
        Me.GroupBox3.Controls.Add(Me.BtnParaExamHistory)
        Me.GroupBox3.Controls.Add(Me.BtnRequestExam)
        Me.GroupBox3.Controls.Add(Me.lblPrintPrescription)
        Me.GroupBox3.Controls.Add(Me.dtprescription)
        Me.GroupBox3.Controls.Add(Me.cbodoc)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.cbodiagnosis)
        Me.GroupBox3.Controls.Add(Me.cboconsulttype)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1531, 92)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Issure Prescription:"
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Location = New System.Drawing.Point(856, 54)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(58, 16)
        Me.lblUserID.TabIndex = 52
        Me.lblUserID.Text = "Label17"
        Me.lblUserID.Visible = False
        '
        'txtDoctor
        '
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.txtDoctor, Nothing)
        Me.txtDoctor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctor.Location = New System.Drawing.Point(509, 54)
        Me.txtDoctor.Name = "txtDoctor"
        Me.txtDoctor.ReadOnly = True
        Me.txtDoctor.Size = New System.Drawing.Size(287, 26)
        Me.txtDoctor.TabIndex = 51
        '
        'BtnParaExamHistory
        '
        Me.BtnParaExamHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnParaExamHistory.Location = New System.Drawing.Point(1072, 24)
        Me.BtnParaExamHistory.Name = "BtnParaExamHistory"
        Me.BtnParaExamHistory.Size = New System.Drawing.Size(194, 57)
        Me.BtnParaExamHistory.TabIndex = 50
        Me.BtnParaExamHistory.Text = "Para Exam History"
        Me.BtnParaExamHistory.UseVisualStyleBackColor = True
        '
        'BtnRequestExam
        '
        Me.BtnRequestExam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRequestExam.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnRequestExam.Location = New System.Drawing.Point(931, 24)
        Me.BtnRequestExam.Name = "BtnRequestExam"
        Me.BtnRequestExam.Size = New System.Drawing.Size(135, 57)
        Me.BtnRequestExam.TabIndex = 49
        Me.BtnRequestExam.Text = "Request For Para Examination"
        Me.BtnRequestExam.UseVisualStyleBackColor = True
        '
        'lblPrintPrescription
        '
        Me.lblPrintPrescription.AutoSize = True
        Me.lblPrintPrescription.Location = New System.Drawing.Point(822, 24)
        Me.lblPrintPrescription.Name = "lblPrintPrescription"
        Me.lblPrintPrescription.Size = New System.Drawing.Size(15, 16)
        Me.lblPrintPrescription.TabIndex = 17
        Me.lblPrintPrescription.Text = "0"
        Me.lblPrintPrescription.Visible = False
        '
        'dtprescription
        '
        Me.dtprescription.Checked = False
        Me.dtprescription.CustomFormat = "dd/MM/yyyy"
        Me.dtprescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtprescription.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtprescription.Location = New System.Drawing.Point(153, 25)
        Me.dtprescription.Name = "dtprescription"
        Me.dtprescription.ShowCheckBox = True
        Me.dtprescription.Size = New System.Drawing.Size(192, 23)
        Me.dtprescription.TabIndex = 0
        '
        'cbodoc
        '
        Me.cbodoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbodoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbodoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodoc.Location = New System.Drawing.Point(1194, 54)
        Me.cbodoc.Name = "cbodoc"
        Me.cbodoc.Size = New System.Drawing.Size(287, 24)
        Me.cbodoc.TabIndex = 3
        Me.cbodoc.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Prescription Date:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(78, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 14)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Diagnosis:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(455, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 14)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Doctor:"
        '
        'cbodiagnosis
        '
        Me.cbodiagnosis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbodiagnosis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbodiagnosis.DropDownWidth = 250
        Me.cbodiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodiagnosis.Location = New System.Drawing.Point(154, 55)
        Me.cbodiagnosis.Name = "cbodiagnosis"
        Me.cbodiagnosis.Size = New System.Drawing.Size(192, 24)
        Me.cbodiagnosis.TabIndex = 2
        '
        'cboconsulttype
        '
        Me.cboconsulttype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboconsulttype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboconsulttype.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboconsulttype.Location = New System.Drawing.Point(509, 24)
        Me.cboconsulttype.Name = "cboconsulttype"
        Me.cboconsulttype.Size = New System.Drawing.Size(287, 24)
        Me.cboconsulttype.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(381, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 14)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Consultation Type:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.txtremark)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(10, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1521, 122)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Remark"
        '
        'txtremark
        '
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.txtremark, Me.AutocompleteMenu1)
        Me.txtremark.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtremark.Location = New System.Drawing.Point(3, 18)
        Me.txtremark.Multiline = True
        Me.txtremark.Name = "txtremark"
        Me.txtremark.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtremark.Size = New System.Drawing.Size(1515, 101)
        Me.txtremark.TabIndex = 1
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCancel.Location = New System.Drawing.Point(1337, 131)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(97, 32)
        Me.BtnCancel.TabIndex = 40
        Me.BtnCancel.Text = "Close"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnSavePrint
        '
        Me.BtnSavePrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSavePrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSavePrint.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSavePrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSavePrint.Location = New System.Drawing.Point(1237, 131)
        Me.BtnSavePrint.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSavePrint.Name = "BtnSavePrint"
        Me.BtnSavePrint.Size = New System.Drawing.Size(96, 32)
        Me.BtnSavePrint.TabIndex = 16
        Me.BtnSavePrint.Text = "Update"
        Me.BtnSavePrint.UseVisualStyleBackColor = True
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.GroupBox2)
        Me.UiTabPage1.Key = "Consultation on"
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 24)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(1544, 617)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "Consultation on"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.SplitContainer2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(1544, 617)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'UiTab2
        '
        Me.UiTab2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiTab2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiTab2.Location = New System.Drawing.Point(0, 70)
        Me.UiTab2.Name = "UiTab2"
        Me.UiTab2.Size = New System.Drawing.Size(1548, 644)
        Me.UiTab2.TabIndex = 47
        Me.UiTab2.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage1})
        Me.UiTab2.TabsStateStyles.FormatStyle.FontSize = 10.0!
        Me.UiTab2.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Normal
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 14)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Patient No:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(257, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 14)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Full Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(543, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 14)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Sex:"
        '
        'TxtPatientNo
        '
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.TxtPatientNo, Nothing)
        Me.TxtPatientNo.BackColor = System.Drawing.Color.White
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.Location = New System.Drawing.Point(105, 24)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.ReadOnly = True
        Me.TxtPatientNo.Size = New System.Drawing.Size(146, 26)
        Me.TxtPatientNo.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtPatientNo)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.txtsex)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1548, 64)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Information"
        '
        'txtname
        '
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.txtname, Nothing)
        Me.txtname.BackColor = System.Drawing.Color.White
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(336, 24)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(193, 26)
        Me.txtname.TabIndex = 1
        '
        'txtsex
        '
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.txtsex, Nothing)
        Me.txtsex.BackColor = System.Drawing.Color.White
        Me.txtsex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsex.Location = New System.Drawing.Point(584, 22)
        Me.txtsex.Name = "txtsex"
        Me.txtsex.ReadOnly = True
        Me.txtsex.Size = New System.Drawing.Size(154, 26)
        Me.txtsex.TabIndex = 32
        '
        'ErrPrescription
        '
        Me.ErrPrescription.ContainerControl = Me
        '
        'AutocompleteMenu1
        '
        Me.AutocompleteMenu1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.AutocompleteMenu1.ImageList = Nothing
        Me.AutocompleteMenu1.Items = New String(-1) {}
        Me.AutocompleteMenu1.MinFragmentLength = 1
        Me.AutocompleteMenu1.TargetControlWrapper = Nothing
        Me.AutocompleteMenu1.ToolTipDuration = 3000
        '
        'EditConsultation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1444, 714)
        Me.Controls.Add(Me.UiTab2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditConsultation"
        Me.ShowInTaskbar = False
        Me.Text = "Edit Consultation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.GridPrePhysical, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        Me.UiTabPage6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        CType(Me.GridPreComplaint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabPage7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.GridPreMedicalHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabPage8.ResumeLayout(False)
        Me.UiTabPage2.ResumeLayout(False)
        Me.GroupBox19.ResumeLayout(False)
        Me.GroupBox19.PerformLayout()
        CType(Me.PrescriptionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.UiTabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.UiTab2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrPrescription, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtPhysicalNote As System.Windows.Forms.TextBox
    Friend WithEvents cboUsage As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CboPhysicalExam As System.Windows.Forms.ComboBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage6 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents CboComplaint As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtComplainDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents UiTabPage7 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CboMedical As System.Windows.Forms.ComboBox
    Friend WithEvents TxtMedicalNote As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents UiTabPage8 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage2 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GroupBox19 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnRemovePrescription As System.Windows.Forms.Button
    Friend WithEvents PrescriptionList As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnAddPrescription As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdosage As System.Windows.Forms.TextBox
    Friend WithEvents txtduration As System.Windows.Forms.TextBox
    Friend WithEvents cbomedicine As System.Windows.Forms.ComboBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPrintPrescription As System.Windows.Forms.Label
    Friend WithEvents dtprescription As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbodoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbodiagnosis As System.Windows.Forms.ComboBox
    Friend WithEvents cboconsulttype As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtremark As System.Windows.Forms.TextBox
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents bgLoadingData As System.ComponentModel.BackgroundWorker
    Friend WithEvents UiTab2 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSavePrint As System.Windows.Forms.Button
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtsex As System.Windows.Forms.TextBox
    Friend WithEvents ErrPrescription As System.Windows.Forms.ErrorProvider
    Friend WithEvents TxtTotalUse As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnParaExamHistory As System.Windows.Forms.Button
    Friend WithEvents BtnRequestExam As System.Windows.Forms.Button
    Friend WithEvents AutocompleteMenu1 As AutocompleteMenuNS.AutocompleteMenu
    Friend WithEvents txtDoctor As System.Windows.Forms.TextBox
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents GridPreComplaint As Janus.Windows.GridEX.GridEX
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents GridPreMedicalHistory As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnRemoveMedicalHistory As System.Windows.Forms.Button
    Friend WithEvents BtnAddMedicalHistor As System.Windows.Forms.Button
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents GridPrePhysical As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnRemovePrePhysical As System.Windows.Forms.Button
    Friend WithEvents BtnAddPrePhysical As System.Windows.Forms.Button
End Class
