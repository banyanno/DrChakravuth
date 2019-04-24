<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFibroEnglish
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFibroEnglish))
        Dim conclusionlist_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.GroupBox17 = New System.Windows.Forms.GroupBox
        Me.cboFibroDemander = New System.Windows.Forms.ComboBox
        Me.cboFibroAnesthegiste = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.LblPatientNo = New System.Windows.Forms.Label
        Me.chkFibroAnesthegiste = New System.Windows.Forms.CheckBox
        Me.txtFibroTolerance = New System.Windows.Forms.TextBox
        Me.DateResultExam = New System.Windows.Forms.DateTimePicker
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblPatientName = New System.Windows.Forms.Label
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.TxtOther = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtAssessment = New System.Windows.Forms.TextBox
        Me.TxtStomach = New System.Windows.Forms.TextBox
        Me.TxtEsophagus = New System.Windows.Forms.TextBox
        Me.TxtXylocainegel = New System.Windows.Forms.TextBox
        Me.TxtPropofol = New System.Windows.Forms.TextBox
        Me.TxtFentanyl = New System.Windows.Forms.TextBox
        Me.TxtMedication = New System.Windows.Forms.TextBox
        Me.TxtIndication = New System.Windows.Forms.TextBox
        Me.TxtIntroduction = New System.Windows.Forms.TextBox
        Me.cboFibroConclusion = New System.Windows.Forms.ComboBox
        Me.BtnRemoveConclusion = New System.Windows.Forms.Button
        Me.BtnAddConclusion = New System.Windows.Forms.Button
        Me.ConclusionGroup = New System.Windows.Forms.GroupBox
        Me.conclusionlist = New Janus.Windows.GridEX.GridEX
        Me.cboFibroDocteur = New System.Windows.Forms.ComboBox
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
        Me.ErrAlert = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.GroupBox17.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.ConclusionGroup.SuspendLayout()
        CType(Me.conclusionlist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrAlert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.cboFibroDemander)
        Me.GroupBox17.Controls.Add(Me.cboFibroAnesthegiste)
        Me.GroupBox17.Controls.Add(Me.Label10)
        Me.GroupBox17.Controls.Add(Me.LblPatientNo)
        Me.GroupBox17.Controls.Add(Me.chkFibroAnesthegiste)
        Me.GroupBox17.Controls.Add(Me.txtFibroTolerance)
        Me.GroupBox17.Controls.Add(Me.DateResultExam)
        Me.GroupBox17.Controls.Add(Me.Label11)
        Me.GroupBox17.Controls.Add(Me.Label2)
        Me.GroupBox17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox17.Location = New System.Drawing.Point(8, 54)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(1056, 99)
        Me.GroupBox17.TabIndex = 1
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "From"
        '
        'cboFibroDemander
        '
        Me.cboFibroDemander.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFibroDemander.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFibroDemander.FormattingEnabled = True
        Me.cboFibroDemander.Location = New System.Drawing.Point(120, 17)
        Me.cboFibroDemander.Name = "cboFibroDemander"
        Me.cboFibroDemander.Size = New System.Drawing.Size(315, 28)
        Me.cboFibroDemander.TabIndex = 0
        '
        'cboFibroAnesthegiste
        '
        Me.cboFibroAnesthegiste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFibroAnesthegiste.Enabled = False
        Me.cboFibroAnesthegiste.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFibroAnesthegiste.FormattingEnabled = True
        Me.cboFibroAnesthegiste.Location = New System.Drawing.Point(453, 57)
        Me.cboFibroAnesthegiste.Name = "cboFibroAnesthegiste"
        Me.cboFibroAnesthegiste.Size = New System.Drawing.Size(211, 28)
        Me.cboFibroAnesthegiste.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(22, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 16)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Requested By:"
        '
        'LblPatientNo
        '
        Me.LblPatientNo.AutoSize = True
        Me.LblPatientNo.Location = New System.Drawing.Point(695, 16)
        Me.LblPatientNo.Name = "LblPatientNo"
        Me.LblPatientNo.Size = New System.Drawing.Size(90, 16)
        Me.LblPatientNo.TabIndex = 12
        Me.LblPatientNo.Text = "LblPatientNo"
        Me.LblPatientNo.Visible = False
        '
        'chkFibroAnesthegiste
        '
        Me.chkFibroAnesthegiste.AutoSize = True
        Me.chkFibroAnesthegiste.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFibroAnesthegiste.Location = New System.Drawing.Point(333, 63)
        Me.chkFibroAnesthegiste.Name = "chkFibroAnesthegiste"
        Me.chkFibroAnesthegiste.Size = New System.Drawing.Size(107, 20)
        Me.chkFibroAnesthegiste.TabIndex = 5
        Me.chkFibroAnesthegiste.Text = "Anesthegiste:"
        Me.chkFibroAnesthegiste.UseVisualStyleBackColor = True
        '
        'txtFibroTolerance
        '
        Me.txtFibroTolerance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFibroTolerance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFibroTolerance.Location = New System.Drawing.Point(120, 61)
        Me.txtFibroTolerance.Name = "txtFibroTolerance"
        Me.txtFibroTolerance.Size = New System.Drawing.Size(205, 26)
        Me.txtFibroTolerance.TabIndex = 1
        '
        'DateResultExam
        '
        Me.DateResultExam.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateResultExam.CustomFormat = "dd/MM/yyyy"
        Me.DateResultExam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateResultExam.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateResultExam.Location = New System.Drawing.Point(540, 17)
        Me.DateResultExam.Name = "DateResultExam"
        Me.DateResultExam.Size = New System.Drawing.Size(124, 26)
        Me.DateResultExam.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(48, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 16)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Tolérance:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(450, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Date Result:"
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Location = New System.Drawing.Point(914, 73)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(78, 13)
        Me.lblPatientName.TabIndex = 13
        Me.lblPatientName.Text = "lblPatientName"
        Me.lblPatientName.Visible = False
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.TxtOther)
        Me.GroupBox12.Controls.Add(Me.Label1)
        Me.GroupBox12.Controls.Add(Me.TxtAssessment)
        Me.GroupBox12.Controls.Add(Me.TxtStomach)
        Me.GroupBox12.Controls.Add(Me.TxtEsophagus)
        Me.GroupBox12.Controls.Add(Me.TxtXylocainegel)
        Me.GroupBox12.Controls.Add(Me.TxtPropofol)
        Me.GroupBox12.Controls.Add(Me.TxtFentanyl)
        Me.GroupBox12.Controls.Add(Me.TxtMedication)
        Me.GroupBox12.Controls.Add(Me.TxtIndication)
        Me.GroupBox12.Controls.Add(Me.TxtIntroduction)
        Me.GroupBox12.Controls.Add(Me.cboFibroConclusion)
        Me.GroupBox12.Controls.Add(Me.BtnRemoveConclusion)
        Me.GroupBox12.Controls.Add(Me.BtnAddConclusion)
        Me.GroupBox12.Controls.Add(Me.ConclusionGroup)
        Me.GroupBox12.Controls.Add(Me.cboFibroDocteur)
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
        Me.GroupBox12.Location = New System.Drawing.Point(9, 162)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(1064, 457)
        Me.GroupBox12.TabIndex = 14
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Result of Fibro"
        '
        'TxtOther
        '
        Me.TxtOther.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOther.Location = New System.Drawing.Point(561, 387)
        Me.TxtOther.Multiline = True
        Me.TxtOther.Name = "TxtOther"
        Me.TxtOther.Size = New System.Drawing.Size(396, 48)
        Me.TxtOther.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(558, 368)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Other:"
        '
        'TxtAssessment
        '
        Me.TxtAssessment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAssessment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAssessment.Location = New System.Drawing.Point(561, 309)
        Me.TxtAssessment.Multiline = True
        Me.TxtAssessment.Name = "TxtAssessment"
        Me.TxtAssessment.Size = New System.Drawing.Size(396, 53)
        Me.TxtAssessment.TabIndex = 51
        '
        'TxtStomach
        '
        Me.TxtStomach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStomach.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStomach.Location = New System.Drawing.Point(15, 271)
        Me.TxtStomach.Multiline = True
        Me.TxtStomach.Name = "TxtStomach"
        Me.TxtStomach.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtStomach.Size = New System.Drawing.Size(500, 166)
        Me.TxtStomach.TabIndex = 50
        Me.TxtStomach.Text = resources.GetString("TxtStomach.Text")
        '
        'TxtEsophagus
        '
        Me.TxtEsophagus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEsophagus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEsophagus.Location = New System.Drawing.Point(128, 217)
        Me.TxtEsophagus.Name = "TxtEsophagus"
        Me.TxtEsophagus.Size = New System.Drawing.Size(827, 26)
        Me.TxtEsophagus.TabIndex = 49
        Me.TxtEsophagus.Text = "The gastro-esophageal junction was .40 cm, There was no evidence of esophagitis."
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
        'cboFibroConclusion
        '
        Me.cboFibroConclusion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboFibroConclusion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboFibroConclusion.DropDownWidth = 500
        Me.cboFibroConclusion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFibroConclusion.FormattingEnabled = True
        Me.cboFibroConclusion.Location = New System.Drawing.Point(596, 20)
        Me.cboFibroConclusion.Name = "cboFibroConclusion"
        Me.cboFibroConclusion.Size = New System.Drawing.Size(359, 26)
        Me.cboFibroConclusion.TabIndex = 42
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
        Me.ConclusionGroup.Size = New System.Drawing.Size(478, 156)
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
        Me.conclusionlist.Size = New System.Drawing.Size(472, 135)
        Me.conclusionlist.TabIndex = 0
        '
        'cboFibroDocteur
        '
        Me.cboFibroDocteur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboFibroDocteur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboFibroDocteur.Enabled = False
        Me.cboFibroDocteur.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFibroDocteur.FormattingEnabled = True
        Me.cboFibroDocteur.Location = New System.Drawing.Point(617, 253)
        Me.cboFibroDocteur.Name = "cboFibroDocteur"
        Me.cboFibroDocteur.Size = New System.Drawing.Size(343, 26)
        Me.cboFibroDocteur.TabIndex = 15
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
        Me.Label21.Location = New System.Drawing.Point(558, 290)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(89, 16)
        Me.Label21.TabIndex = 20
        Me.Label21.Text = "Assessment :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(15, 252)
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
        Me.Label13.Location = New System.Drawing.Point(554, 263)
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
        'ErrAlert
        '
        Me.ErrAlert.ContainerControl = Me
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1076, 53)
        Me.ToolStrip1.TabIndex = 17
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton1.Image = Global.Clinic_Management_System.My.Resources.Resources.store
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(87, 50)
        Me.ToolStripButton1.Text = "     Save     "
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 53)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton2.Image = Global.Clinic_Management_System.My.Resources.Resources.Close
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(100, 50)
        Me.ToolStripButton2.Text = "     Cancel     "
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FormFibroEnglish
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 682)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox12)
        Me.Controls.Add(Me.lblPatientName)
        Me.Controls.Add(Me.GroupBox17)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormFibroEnglish"
        Me.Text = "Fibro English"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.ConclusionGroup.ResumeLayout(False)
        CType(Me.conclusionlist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrAlert, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox17 As System.Windows.Forms.GroupBox
    Friend WithEvents cboFibroDemander As System.Windows.Forms.ComboBox
    Friend WithEvents cboFibroAnesthegiste As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chkFibroAnesthegiste As System.Windows.Forms.CheckBox
    Friend WithEvents txtFibroTolerance As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblPatientName As System.Windows.Forms.Label
    Friend WithEvents LblPatientNo As System.Windows.Forms.Label
    Friend WithEvents DateResultExam As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents cboFibroConclusion As System.Windows.Forms.ComboBox
    Friend WithEvents BtnRemoveConclusion As System.Windows.Forms.Button
    Friend WithEvents BtnAddConclusion As System.Windows.Forms.Button
    Friend WithEvents ConclusionGroup As System.Windows.Forms.GroupBox
    Friend WithEvents conclusionlist As Janus.Windows.GridEX.GridEX
    Friend WithEvents cboFibroDocteur As System.Windows.Forms.ComboBox
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
    Friend WithEvents TxtAssessment As System.Windows.Forms.TextBox
    Friend WithEvents TxtStomach As System.Windows.Forms.TextBox
    Friend WithEvents TxtEsophagus As System.Windows.Forms.TextBox
    Friend WithEvents TxtXylocainegel As System.Windows.Forms.TextBox
    Friend WithEvents TxtPropofol As System.Windows.Forms.TextBox
    Friend WithEvents TxtFentanyl As System.Windows.Forms.TextBox
    Friend WithEvents TxtMedication As System.Windows.Forms.TextBox
    Friend WithEvents TxtIndication As System.Windows.Forms.TextBox
    Friend WithEvents TxtIntroduction As System.Windows.Forms.TextBox
    Friend WithEvents ErrAlert As System.Windows.Forms.ErrorProvider
    Friend WithEvents TxtOther As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
End Class
