<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNasograstroEng
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNasograstroEng))
        Dim conclusionlist_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.lblPatientName = New System.Windows.Forms.Label
        Me.LblPatientNo = New System.Windows.Forms.Label
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.TxtMoreInfo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtStomach = New System.Windows.Forms.RichTextBox
        Me.TxtAssessment = New System.Windows.Forms.TextBox
        Me.TxtEsophagus = New System.Windows.Forms.TextBox
        Me.TxtXylocainegel = New System.Windows.Forms.TextBox
        Me.TxtPropofol = New System.Windows.Forms.TextBox
        Me.TxtFentanyl = New System.Windows.Forms.TextBox
        Me.TxtMedication = New System.Windows.Forms.TextBox
        Me.TxtIndication = New System.Windows.Forms.TextBox
        Me.TxtIntroduction = New System.Windows.Forms.TextBox
        Me.cboNasoConclusion = New System.Windows.Forms.ComboBox
        Me.BtnRemoveConclusion = New System.Windows.Forms.Button
        Me.BtnAddConclusion = New System.Windows.Forms.Button
        Me.ConclusionGroup = New System.Windows.Forms.GroupBox
        Me.conclusionlist = New Janus.Windows.GridEX.GridEX
        Me.cboNasoDocteur = New System.Windows.Forms.ComboBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.DateResultExam = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox16 = New System.Windows.Forms.GroupBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtNasoTolerance = New System.Windows.Forms.TextBox
        Me.cboNasoDemander = New System.Windows.Forms.ComboBox
        Me.ErrAlert = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.ConclusionGroup.SuspendLayout()
        CType(Me.conclusionlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox16.SuspendLayout()
        CType(Me.ErrAlert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lblPatientName)
        Me.GroupBox6.Controls.Add(Me.LblPatientNo)
        Me.GroupBox6.Controls.Add(Me.GroupBox12)
        Me.GroupBox6.Controls.Add(Me.DateResultExam)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.GroupBox16)
        Me.GroupBox6.Location = New System.Drawing.Point(5, 41)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1071, 588)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Location = New System.Drawing.Point(844, 58)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(78, 13)
        Me.lblPatientName.TabIndex = 17
        Me.lblPatientName.Text = "lblPatientName"
        Me.lblPatientName.Visible = False
        '
        'LblPatientNo
        '
        Me.LblPatientNo.AutoSize = True
        Me.LblPatientNo.Location = New System.Drawing.Point(832, 30)
        Me.LblPatientNo.Name = "LblPatientNo"
        Me.LblPatientNo.Size = New System.Drawing.Size(68, 13)
        Me.LblPatientNo.TabIndex = 16
        Me.LblPatientNo.Text = "LblPatientNo"
        Me.LblPatientNo.Visible = False
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.TxtMoreInfo)
        Me.GroupBox12.Controls.Add(Me.Label1)
        Me.GroupBox12.Controls.Add(Me.TxtStomach)
        Me.GroupBox12.Controls.Add(Me.TxtAssessment)
        Me.GroupBox12.Controls.Add(Me.TxtEsophagus)
        Me.GroupBox12.Controls.Add(Me.TxtXylocainegel)
        Me.GroupBox12.Controls.Add(Me.TxtPropofol)
        Me.GroupBox12.Controls.Add(Me.TxtFentanyl)
        Me.GroupBox12.Controls.Add(Me.TxtMedication)
        Me.GroupBox12.Controls.Add(Me.TxtIndication)
        Me.GroupBox12.Controls.Add(Me.TxtIntroduction)
        Me.GroupBox12.Controls.Add(Me.cboNasoConclusion)
        Me.GroupBox12.Controls.Add(Me.BtnRemoveConclusion)
        Me.GroupBox12.Controls.Add(Me.BtnAddConclusion)
        Me.GroupBox12.Controls.Add(Me.ConclusionGroup)
        Me.GroupBox12.Controls.Add(Me.cboNasoDocteur)
        Me.GroupBox12.Controls.Add(Me.Label26)
        Me.GroupBox12.Controls.Add(Me.Label21)
        Me.GroupBox12.Controls.Add(Me.Label20)
        Me.GroupBox12.Controls.Add(Me.Label19)
        Me.GroupBox12.Controls.Add(Me.Label18)
        Me.GroupBox12.Controls.Add(Me.Label17)
        Me.GroupBox12.Controls.Add(Me.Label16)
        Me.GroupBox12.Controls.Add(Me.Label15)
        Me.GroupBox12.Controls.Add(Me.Label14)
        Me.GroupBox12.Controls.Add(Me.Label13)
        Me.GroupBox12.Controls.Add(Me.Label12)
        Me.GroupBox12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox12.Location = New System.Drawing.Point(7, 105)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(1064, 474)
        Me.GroupBox12.TabIndex = 15
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Result of Fibro"
        '
        'TxtMoreInfo
        '
        Me.TxtMoreInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMoreInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMoreInfo.Location = New System.Drawing.Point(551, 379)
        Me.TxtMoreInfo.Multiline = True
        Me.TxtMoreInfo.Name = "TxtMoreInfo"
        Me.TxtMoreInfo.Size = New System.Drawing.Size(486, 81)
        Me.TxtMoreInfo.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(548, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Other:"
        '
        'TxtStomach
        '
        Me.TxtStomach.Location = New System.Drawing.Point(6, 276)
        Me.TxtStomach.Name = "TxtStomach"
        Me.TxtStomach.Size = New System.Drawing.Size(529, 184)
        Me.TxtStomach.TabIndex = 52
        Me.TxtStomach.Text = resources.GetString("TxtStomach.Text")
        '
        'TxtAssessment
        '
        Me.TxtAssessment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAssessment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAssessment.Location = New System.Drawing.Point(551, 276)
        Me.TxtAssessment.Multiline = True
        Me.TxtAssessment.Name = "TxtAssessment"
        Me.TxtAssessment.Size = New System.Drawing.Size(486, 81)
        Me.TxtAssessment.TabIndex = 51
        '
        'TxtEsophagus
        '
        Me.TxtEsophagus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEsophagus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEsophagus.Location = New System.Drawing.Point(128, 217)
        Me.TxtEsophagus.Name = "TxtEsophagus"
        Me.TxtEsophagus.Size = New System.Drawing.Size(323, 26)
        Me.TxtEsophagus.TabIndex = 49
        Me.TxtEsophagus.Text = "the gastro-esophageal junction was ..40 cm"
        '
        'TxtXylocainegel
        '
        Me.TxtXylocainegel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtXylocainegel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtXylocainegel.Location = New System.Drawing.Point(128, 183)
        Me.TxtXylocainegel.Name = "TxtXylocainegel"
        Me.TxtXylocainegel.Size = New System.Drawing.Size(323, 26)
        Me.TxtXylocainegel.TabIndex = 48
        '
        'TxtPropofol
        '
        Me.TxtPropofol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPropofol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPropofol.Location = New System.Drawing.Point(128, 151)
        Me.TxtPropofol.Name = "TxtPropofol"
        Me.TxtPropofol.Size = New System.Drawing.Size(323, 26)
        Me.TxtPropofol.TabIndex = 47
        '
        'TxtFentanyl
        '
        Me.TxtFentanyl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFentanyl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFentanyl.Location = New System.Drawing.Point(128, 119)
        Me.TxtFentanyl.Name = "TxtFentanyl"
        Me.TxtFentanyl.Size = New System.Drawing.Size(323, 26)
        Me.TxtFentanyl.TabIndex = 46
        '
        'TxtMedication
        '
        Me.TxtMedication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMedication.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMedication.Location = New System.Drawing.Point(128, 86)
        Me.TxtMedication.Name = "TxtMedication"
        Me.TxtMedication.Size = New System.Drawing.Size(323, 26)
        Me.TxtMedication.TabIndex = 45
        '
        'TxtIndication
        '
        Me.TxtIndication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIndication.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIndication.Location = New System.Drawing.Point(128, 53)
        Me.TxtIndication.Name = "TxtIndication"
        Me.TxtIndication.Size = New System.Drawing.Size(323, 26)
        Me.TxtIndication.TabIndex = 44
        '
        'TxtIntroduction
        '
        Me.TxtIntroduction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIntroduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIntroduction.Location = New System.Drawing.Point(128, 21)
        Me.TxtIntroduction.Name = "TxtIntroduction"
        Me.TxtIntroduction.Size = New System.Drawing.Size(323, 26)
        Me.TxtIntroduction.TabIndex = 43
        '
        'cboNasoConclusion
        '
        Me.cboNasoConclusion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboNasoConclusion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboNasoConclusion.DropDownWidth = 500
        Me.cboNasoConclusion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNasoConclusion.FormattingEnabled = True
        Me.cboNasoConclusion.Location = New System.Drawing.Point(596, 20)
        Me.cboNasoConclusion.Name = "cboNasoConclusion"
        Me.cboNasoConclusion.Size = New System.Drawing.Size(359, 26)
        Me.cboNasoConclusion.TabIndex = 42
        '
        'BtnRemoveConclusion
        '
        Me.BtnRemoveConclusion.Location = New System.Drawing.Point(1002, 22)
        Me.BtnRemoveConclusion.Name = "BtnRemoveConclusion"
        Me.BtnRemoveConclusion.Size = New System.Drawing.Size(35, 24)
        Me.BtnRemoveConclusion.TabIndex = 8
        Me.BtnRemoveConclusion.Text = "-"
        Me.BtnRemoveConclusion.UseVisualStyleBackColor = True
        '
        'BtnAddConclusion
        '
        Me.BtnAddConclusion.Location = New System.Drawing.Point(961, 22)
        Me.BtnAddConclusion.Name = "BtnAddConclusion"
        Me.BtnAddConclusion.Size = New System.Drawing.Size(35, 24)
        Me.BtnAddConclusion.TabIndex = 7
        Me.BtnAddConclusion.Text = "+"
        Me.BtnAddConclusion.UseVisualStyleBackColor = True
        '
        'ConclusionGroup
        '
        Me.ConclusionGroup.Controls.Add(Me.conclusionlist)
        Me.ConclusionGroup.Location = New System.Drawing.Point(482, 53)
        Me.ConclusionGroup.Name = "ConclusionGroup"
        Me.ConclusionGroup.Size = New System.Drawing.Size(478, 162)
        Me.ConclusionGroup.TabIndex = 9
        Me.ConclusionGroup.TabStop = False
        Me.ConclusionGroup.Text = "List of Recommendation:"
        '
        'conclusionlist
        '
        Me.conclusionlist.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        conclusionlist_DesignTimeLayout.LayoutString = resources.GetString("conclusionlist_DesignTimeLayout.LayoutString")
        Me.conclusionlist.DesignTimeLayout = conclusionlist_DesignTimeLayout
        Me.conclusionlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.conclusionlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.conclusionlist.GroupByBoxVisible = False
        Me.conclusionlist.HeaderFormatStyle.FontSize = 10.0!
        Me.conclusionlist.Location = New System.Drawing.Point(3, 18)
        Me.conclusionlist.Name = "conclusionlist"
        Me.conclusionlist.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.conclusionlist.Size = New System.Drawing.Size(472, 141)
        Me.conclusionlist.TabIndex = 0
        '
        'cboNasoDocteur
        '
        Me.cboNasoDocteur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboNasoDocteur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboNasoDocteur.Enabled = False
        Me.cboNasoDocteur.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNasoDocteur.FormattingEnabled = True
        Me.cboNasoDocteur.Location = New System.Drawing.Point(617, 223)
        Me.cboNasoDocteur.Name = "cboNasoDocteur"
        Me.cboNasoDocteur.Size = New System.Drawing.Size(343, 26)
        Me.cboNasoDocteur.TabIndex = 15
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(479, 29)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(113, 16)
        Me.Label26.TabIndex = 35
        Me.Label26.Text = "Recommendation:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(554, 257)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(89, 16)
        Me.Label21.TabIndex = 20
        Me.Label21.Text = "Assessment :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 257)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(155, 16)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "Stomach and Duodenum:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(25, 223)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 16)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Esophagus : "
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(25, 188)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 16)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "- Xylocainegel :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(25, 154)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 16)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "-Propofol:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(25, 126)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 16)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "-Fentanyl :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(25, 96)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 16)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Medication:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(25, 63)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 16)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Indication: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(554, 233)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 16)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Docteur:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(25, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 16)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Introduction:"
        '
        'DateResultExam
        '
        Me.DateResultExam.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateResultExam.CustomFormat = "dd/MM/yyyy"
        Me.DateResultExam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateResultExam.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateResultExam.Location = New System.Drawing.Point(664, 58)
        Me.DateResultExam.Name = "DateResultExam"
        Me.DateResultExam.Size = New System.Drawing.Size(124, 26)
        Me.DateResultExam.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(592, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Date Result:"
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.Label25)
        Me.GroupBox16.Controls.Add(Me.Label24)
        Me.GroupBox16.Controls.Add(Me.txtNasoTolerance)
        Me.GroupBox16.Controls.Add(Me.cboNasoDemander)
        Me.GroupBox16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox16.Location = New System.Drawing.Point(6, 13)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(570, 81)
        Me.GroupBox16.TabIndex = 0
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "From:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(27, 21)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(93, 16)
        Me.Label25.TabIndex = 8
        Me.Label25.Text = "Demander par:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(53, 51)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(67, 16)
        Me.Label24.TabIndex = 9
        Me.Label24.Text = "Tolérance:"
        '
        'txtNasoTolerance
        '
        Me.txtNasoTolerance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNasoTolerance.Location = New System.Drawing.Point(126, 48)
        Me.txtNasoTolerance.Name = "txtNasoTolerance"
        Me.txtNasoTolerance.Size = New System.Drawing.Size(429, 23)
        Me.txtNasoTolerance.TabIndex = 1
        '
        'cboNasoDemander
        '
        Me.cboNasoDemander.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboNasoDemander.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboNasoDemander.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNasoDemander.FormattingEnabled = True
        Me.cboNasoDemander.Location = New System.Drawing.Point(126, 17)
        Me.cboNasoDemander.Name = "cboNasoDemander"
        Me.cboNasoDemander.Size = New System.Drawing.Size(429, 24)
        Me.cboNasoDemander.TabIndex = 0
        '
        'ErrAlert
        '
        Me.ErrAlert.ContainerControl = Me
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1317, 44)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton1.Image = Global.Clinic_Management_System.My.Resources.Resources.store
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(91, 41)
        Me.ToolStripButton1.Text = "      Save     "
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 44)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton2.Image = Global.Clinic_Management_System.My.Resources.Resources.Close
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(112, 41)
        Me.ToolStripButton2.Text = "       Cancel      "
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FormNasograstroEng
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1317, 635)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormNasograstroEng"
        Me.Text = "Nasograstro English"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.ConclusionGroup.ResumeLayout(False)
        CType(Me.conclusionlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        CType(Me.ErrAlert, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents DateResultExam As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtNasoTolerance As System.Windows.Forms.TextBox
    Friend WithEvents cboNasoDemander As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtAssessment As System.Windows.Forms.TextBox
    Friend WithEvents TxtEsophagus As System.Windows.Forms.TextBox
    Friend WithEvents TxtXylocainegel As System.Windows.Forms.TextBox
    Friend WithEvents TxtPropofol As System.Windows.Forms.TextBox
    Friend WithEvents TxtFentanyl As System.Windows.Forms.TextBox
    Friend WithEvents TxtMedication As System.Windows.Forms.TextBox
    Friend WithEvents TxtIndication As System.Windows.Forms.TextBox
    Friend WithEvents TxtIntroduction As System.Windows.Forms.TextBox
    Friend WithEvents cboNasoConclusion As System.Windows.Forms.ComboBox
    Friend WithEvents BtnRemoveConclusion As System.Windows.Forms.Button
    Friend WithEvents BtnAddConclusion As System.Windows.Forms.Button
    Friend WithEvents ConclusionGroup As System.Windows.Forms.GroupBox
    Friend WithEvents conclusionlist As Janus.Windows.GridEX.GridEX
    Friend WithEvents cboNasoDocteur As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblPatientName As System.Windows.Forms.Label
    Friend WithEvents LblPatientNo As System.Windows.Forms.Label
    Friend WithEvents ErrAlert As System.Windows.Forms.ErrorProvider
    Friend WithEvents TxtStomach As System.Windows.Forms.RichTextBox
    Friend WithEvents TxtMoreInfo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
End Class
