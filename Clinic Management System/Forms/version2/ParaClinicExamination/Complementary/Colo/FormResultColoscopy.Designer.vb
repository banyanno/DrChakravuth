<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormResultColoscopy
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
        Dim ConclusionList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormResultColoscopy))
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.DateResultExam = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox15 = New System.Windows.Forms.GroupBox
        Me.cboColoConclusion = New System.Windows.Forms.ComboBox
        Me.txtnewfield = New System.Windows.Forms.TextBox
        Me.txtcolomoreinfo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ConclusionList = New Janus.Windows.GridEX.GridEX
        Me.BtnRemoveConclusion = New System.Windows.Forms.Button
        Me.BtnAddConclusion = New System.Windows.Forms.Button
        Me.txtColoRectum = New System.Windows.Forms.TextBox
        Me.txtColoSigmoide = New System.Windows.Forms.TextBox
        Me.txtColonGauche = New System.Windows.Forms.TextBox
        Me.txtColoColonTransverse = New System.Windows.Forms.TextBox
        Me.txtColoColonDroit = New System.Windows.Forms.TextBox
        Me.txtColoCaecum = New System.Windows.Forms.TextBox
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.cboColoDocteur = New System.Windows.Forms.ComboBox
        Me.Label42 = New System.Windows.Forms.Label
        Me.cboColoMotify = New System.Windows.Forms.ComboBox
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.GroupBox14 = New System.Windows.Forms.GroupBox
        Me.cboColoDemander = New System.Windows.Forms.ComboBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.txtColoTolerance = New System.Windows.Forms.TextBox
        Me.cboColoAnesthegiste = New System.Windows.Forms.ComboBox
        Me.chkColoAnesthegiste = New System.Windows.Forms.CheckBox
        Me.cboColoPreparation = New System.Windows.Forms.ComboBox
        Me.txtColoEva = New System.Windows.Forms.TextBox
        Me.txtColoDuree = New System.Windows.Forms.TextBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.ErrAlert = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblPatientName = New System.Windows.Forms.Label
        Me.LblPatientNo = New System.Windows.Forms.Label
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ConclusionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox14.SuspendLayout()
        CType(Me.ErrAlert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.DateResultExam)
        Me.GroupBox7.Controls.Add(Me.Label6)
        Me.GroupBox7.Controls.Add(Me.GroupBox15)
        Me.GroupBox7.Controls.Add(Me.GroupBox14)
        Me.GroupBox7.Controls.Add(Me.cboColoPreparation)
        Me.GroupBox7.Controls.Add(Me.txtColoEva)
        Me.GroupBox7.Controls.Add(Me.txtColoDuree)
        Me.GroupBox7.Controls.Add(Me.Label39)
        Me.GroupBox7.Controls.Add(Me.Label38)
        Me.GroupBox7.Controls.Add(Me.Label37)
        Me.GroupBox7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(10, 11)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(1005, 421)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        '
        'DateResultExam
        '
        Me.DateResultExam.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateResultExam.CustomFormat = "dd/MM/yyyy"
        Me.DateResultExam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateResultExam.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateResultExam.Location = New System.Drawing.Point(253, 11)
        Me.DateResultExam.Name = "DateResultExam"
        Me.DateResultExam.Size = New System.Drawing.Size(135, 26)
        Me.DateResultExam.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(167, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Date Result:"
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.cboColoConclusion)
        Me.GroupBox15.Controls.Add(Me.txtnewfield)
        Me.GroupBox15.Controls.Add(Me.txtcolomoreinfo)
        Me.GroupBox15.Controls.Add(Me.Label1)
        Me.GroupBox15.Controls.Add(Me.GroupBox1)
        Me.GroupBox15.Controls.Add(Me.BtnRemoveConclusion)
        Me.GroupBox15.Controls.Add(Me.BtnAddConclusion)
        Me.GroupBox15.Controls.Add(Me.txtColoRectum)
        Me.GroupBox15.Controls.Add(Me.txtColoSigmoide)
        Me.GroupBox15.Controls.Add(Me.txtColonGauche)
        Me.GroupBox15.Controls.Add(Me.txtColoColonTransverse)
        Me.GroupBox15.Controls.Add(Me.txtColoColonDroit)
        Me.GroupBox15.Controls.Add(Me.txtColoCaecum)
        Me.GroupBox15.Controls.Add(Me.Label50)
        Me.GroupBox15.Controls.Add(Me.Label49)
        Me.GroupBox15.Controls.Add(Me.Label48)
        Me.GroupBox15.Controls.Add(Me.Label47)
        Me.GroupBox15.Controls.Add(Me.Label46)
        Me.GroupBox15.Controls.Add(Me.Label45)
        Me.GroupBox15.Controls.Add(Me.cboColoDocteur)
        Me.GroupBox15.Controls.Add(Me.Label42)
        Me.GroupBox15.Controls.Add(Me.cboColoMotify)
        Me.GroupBox15.Controls.Add(Me.Label43)
        Me.GroupBox15.Controls.Add(Me.Label44)
        Me.GroupBox15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox15.Location = New System.Drawing.Point(3, 84)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(990, 323)
        Me.GroupBox15.TabIndex = 4
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Result of Coloscopy"
        '
        'cboColoConclusion
        '
        Me.cboColoConclusion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboColoConclusion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboColoConclusion.DropDownWidth = 500
        Me.cboColoConclusion.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboColoConclusion.FormattingEnabled = True
        Me.cboColoConclusion.Location = New System.Drawing.Point(629, 17)
        Me.cboColoConclusion.Name = "cboColoConclusion"
        Me.cboColoConclusion.Size = New System.Drawing.Size(273, 24)
        Me.cboColoConclusion.TabIndex = 62
        '
        'txtnewfield
        '
        Me.txtnewfield.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewfield.Location = New System.Drawing.Point(160, 49)
        Me.txtnewfield.Multiline = True
        Me.txtnewfield.Name = "txtnewfield"
        Me.txtnewfield.Size = New System.Drawing.Size(379, 42)
        Me.txtnewfield.TabIndex = 61
        Me.txtnewfield.Text = "L'examen a été mené sur un côlon moyen préparé jusqu'à bas fond coecal."
        '
        'txtcolomoreinfo
        '
        Me.txtcolomoreinfo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcolomoreinfo.Location = New System.Drawing.Point(630, 232)
        Me.txtcolomoreinfo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcolomoreinfo.Multiline = True
        Me.txtcolomoreinfo.Name = "txtcolomoreinfo"
        Me.txtcolomoreinfo.Size = New System.Drawing.Size(348, 65)
        Me.txtcolomoreinfo.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(583, 238)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Other:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ConclusionList)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(550, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 145)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of conclusion"
        '
        'ConclusionList
        '
        Me.ConclusionList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        ConclusionList_DesignTimeLayout.LayoutString = resources.GetString("ConclusionList_DesignTimeLayout.LayoutString")
        Me.ConclusionList.DesignTimeLayout = ConclusionList_DesignTimeLayout
        Me.ConclusionList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConclusionList.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConclusionList.GroupByBoxVisible = False
        Me.ConclusionList.HeaderFormatStyle.FontSize = 10.0!
        Me.ConclusionList.Location = New System.Drawing.Point(3, 18)
        Me.ConclusionList.Name = "ConclusionList"
        Me.ConclusionList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.ConclusionList.Size = New System.Drawing.Size(421, 124)
        Me.ConclusionList.TabIndex = 0
        '
        'BtnRemoveConclusion
        '
        Me.BtnRemoveConclusion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemoveConclusion.Location = New System.Drawing.Point(944, 18)
        Me.BtnRemoveConclusion.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRemoveConclusion.Name = "BtnRemoveConclusion"
        Me.BtnRemoveConclusion.Size = New System.Drawing.Size(34, 24)
        Me.BtnRemoveConclusion.TabIndex = 10
        Me.BtnRemoveConclusion.Text = "-"
        Me.BtnRemoveConclusion.UseVisualStyleBackColor = True
        '
        'BtnAddConclusion
        '
        Me.BtnAddConclusion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddConclusion.Location = New System.Drawing.Point(907, 18)
        Me.BtnAddConclusion.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAddConclusion.Name = "BtnAddConclusion"
        Me.BtnAddConclusion.Size = New System.Drawing.Size(34, 24)
        Me.BtnAddConclusion.TabIndex = 9
        Me.BtnAddConclusion.Text = "+"
        Me.BtnAddConclusion.UseVisualStyleBackColor = True
        '
        'txtColoRectum
        '
        Me.txtColoRectum.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColoRectum.Location = New System.Drawing.Point(160, 262)
        Me.txtColoRectum.Name = "txtColoRectum"
        Me.txtColoRectum.Size = New System.Drawing.Size(379, 22)
        Me.txtColoRectum.TabIndex = 6
        Me.txtColoRectum.Text = "Normal."
        '
        'txtColoSigmoide
        '
        Me.txtColoSigmoide.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColoSigmoide.Location = New System.Drawing.Point(160, 230)
        Me.txtColoSigmoide.Name = "txtColoSigmoide"
        Me.txtColoSigmoide.Size = New System.Drawing.Size(379, 22)
        Me.txtColoSigmoide.TabIndex = 5
        Me.txtColoSigmoide.Text = "Normal."
        '
        'txtColonGauche
        '
        Me.txtColonGauche.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColonGauche.Location = New System.Drawing.Point(160, 199)
        Me.txtColonGauche.Name = "txtColonGauche"
        Me.txtColonGauche.Size = New System.Drawing.Size(379, 22)
        Me.txtColonGauche.TabIndex = 4
        Me.txtColonGauche.Text = "Normal."
        '
        'txtColoColonTransverse
        '
        Me.txtColoColonTransverse.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColoColonTransverse.Location = New System.Drawing.Point(160, 168)
        Me.txtColoColonTransverse.Name = "txtColoColonTransverse"
        Me.txtColoColonTransverse.Size = New System.Drawing.Size(379, 22)
        Me.txtColoColonTransverse.TabIndex = 3
        Me.txtColoColonTransverse.Text = "Normal."
        '
        'txtColoColonDroit
        '
        Me.txtColoColonDroit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColoColonDroit.Location = New System.Drawing.Point(160, 136)
        Me.txtColoColonDroit.Name = "txtColoColonDroit"
        Me.txtColoColonDroit.Size = New System.Drawing.Size(379, 22)
        Me.txtColoColonDroit.TabIndex = 2
        Me.txtColoColonDroit.Text = "Normal."
        '
        'txtColoCaecum
        '
        Me.txtColoCaecum.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColoCaecum.Location = New System.Drawing.Point(160, 103)
        Me.txtColoCaecum.Name = "txtColoCaecum"
        Me.txtColoCaecum.Size = New System.Drawing.Size(379, 22)
        Me.txtColoCaecum.TabIndex = 1
        Me.txtColoCaecum.Text = "Normal."
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(88, 264)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(66, 16)
        Me.Label50.TabIndex = 54
        Me.Label50.Text = "RECTUM:"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(78, 233)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(76, 16)
        Me.Label49.TabIndex = 53
        Me.Label49.Text = "SIGMOÏDE:"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(38, 202)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(116, 16)
        Me.Label48.TabIndex = 52
        Me.Label48.Text = "COLON GAUCHE:"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(5, 171)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(149, 16)
        Me.Label47.TabIndex = 51
        Me.Label47.Text = "COLON TRANSVERSE:"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(56, 138)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(98, 16)
        Me.Label46.TabIndex = 50
        Me.Label46.Text = "COLON DROIT:"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(86, 105)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(68, 16)
        Me.Label45.TabIndex = 49
        Me.Label45.Text = "CAECUM:"
        '
        'cboColoDocteur
        '
        Me.cboColoDocteur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboColoDocteur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboColoDocteur.Enabled = False
        Me.cboColoDocteur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboColoDocteur.FormattingEnabled = True
        Me.cboColoDocteur.Location = New System.Drawing.Point(630, 198)
        Me.cboColoDocteur.Name = "cboColoDocteur"
        Me.cboColoDocteur.Size = New System.Drawing.Size(344, 24)
        Me.cboColoDocteur.TabIndex = 7
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(547, 24)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(76, 16)
        Me.Label42.TabIndex = 47
        Me.Label42.Text = "Conclusion:"
        '
        'cboColoMotify
        '
        Me.cboColoMotify.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboColoMotify.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboColoMotify.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboColoMotify.FormattingEnabled = True
        Me.cboColoMotify.Location = New System.Drawing.Point(160, 19)
        Me.cboColoMotify.Name = "cboColoMotify"
        Me.cboColoMotify.Size = New System.Drawing.Size(379, 24)
        Me.cboColoMotify.TabIndex = 0
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(570, 201)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(57, 16)
        Me.Label43.TabIndex = 44
        Me.Label43.Text = "Docteur:"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(107, 23)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(47, 16)
        Me.Label44.TabIndex = 43
        Me.Label44.Text = "Motify:"
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.cboColoDemander)
        Me.GroupBox14.Controls.Add(Me.Label41)
        Me.GroupBox14.Controls.Add(Me.Label40)
        Me.GroupBox14.Controls.Add(Me.txtColoTolerance)
        Me.GroupBox14.Controls.Add(Me.cboColoAnesthegiste)
        Me.GroupBox14.Controls.Add(Me.chkColoAnesthegiste)
        Me.GroupBox14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox14.Location = New System.Drawing.Point(400, 9)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(593, 73)
        Me.GroupBox14.TabIndex = 3
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "From"
        '
        'cboColoDemander
        '
        Me.cboColoDemander.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboColoDemander.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboColoDemander.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboColoDemander.FormattingEnabled = True
        Me.cboColoDemander.Location = New System.Drawing.Point(104, 15)
        Me.cboColoDemander.Name = "cboColoDemander"
        Me.cboColoDemander.Size = New System.Drawing.Size(203, 24)
        Me.cboColoDemander.TabIndex = 0
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(5, 18)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(93, 16)
        Me.Label41.TabIndex = 9
        Me.Label41.Text = "Demander par:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(5, 51)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(67, 16)
        Me.Label40.TabIndex = 10
        Me.Label40.Text = "Tolérance:"
        '
        'txtColoTolerance
        '
        Me.txtColoTolerance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColoTolerance.Location = New System.Drawing.Point(104, 45)
        Me.txtColoTolerance.Name = "txtColoTolerance"
        Me.txtColoTolerance.Size = New System.Drawing.Size(203, 22)
        Me.txtColoTolerance.TabIndex = 1
        '
        'cboColoAnesthegiste
        '
        Me.cboColoAnesthegiste.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboColoAnesthegiste.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboColoAnesthegiste.Enabled = False
        Me.cboColoAnesthegiste.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboColoAnesthegiste.FormattingEnabled = True
        Me.cboColoAnesthegiste.Location = New System.Drawing.Point(333, 40)
        Me.cboColoAnesthegiste.Name = "cboColoAnesthegiste"
        Me.cboColoAnesthegiste.Size = New System.Drawing.Size(210, 24)
        Me.cboColoAnesthegiste.TabIndex = 2
        '
        'chkColoAnesthegiste
        '
        Me.chkColoAnesthegiste.AutoSize = True
        Me.chkColoAnesthegiste.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkColoAnesthegiste.Location = New System.Drawing.Point(331, 16)
        Me.chkColoAnesthegiste.Name = "chkColoAnesthegiste"
        Me.chkColoAnesthegiste.Size = New System.Drawing.Size(107, 20)
        Me.chkColoAnesthegiste.TabIndex = 11
        Me.chkColoAnesthegiste.Text = "Anesthegiste:"
        Me.chkColoAnesthegiste.UseVisualStyleBackColor = True
        '
        'cboColoPreparation
        '
        Me.cboColoPreparation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboColoPreparation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboColoPreparation.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboColoPreparation.FormattingEnabled = True
        Me.cboColoPreparation.Location = New System.Drawing.Point(252, 44)
        Me.cboColoPreparation.Name = "cboColoPreparation"
        Me.cboColoPreparation.Size = New System.Drawing.Size(136, 24)
        Me.cboColoPreparation.TabIndex = 2
        '
        'txtColoEva
        '
        Me.txtColoEva.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColoEva.Location = New System.Drawing.Point(61, 45)
        Me.txtColoEva.Name = "txtColoEva"
        Me.txtColoEva.Size = New System.Drawing.Size(101, 22)
        Me.txtColoEva.TabIndex = 1
        '
        'txtColoDuree
        '
        Me.txtColoDuree.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColoDuree.Location = New System.Drawing.Point(62, 12)
        Me.txtColoDuree.Name = "txtColoDuree"
        Me.txtColoDuree.Size = New System.Drawing.Size(101, 22)
        Me.txtColoDuree.TabIndex = 0
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(170, 48)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(78, 16)
        Me.Label39.TabIndex = 1
        Me.Label39.Text = "Preparation:"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(19, 47)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(38, 16)
        Me.Label38.TabIndex = 1
        Me.Label38.Text = "EVA:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(12, 14)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(46, 16)
        Me.Label37.TabIndex = 0
        Me.Label37.Text = "Duree:"
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(850, 446)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(80, 32)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(935, 446)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(80, 32)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'ErrAlert
        '
        Me.ErrAlert.ContainerControl = Me
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Location = New System.Drawing.Point(95, 446)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(78, 13)
        Me.lblPatientName.TabIndex = 11
        Me.lblPatientName.Text = "lblPatientName"
        Me.lblPatientName.Visible = False
        '
        'LblPatientNo
        '
        Me.LblPatientNo.AutoSize = True
        Me.LblPatientNo.Location = New System.Drawing.Point(10, 435)
        Me.LblPatientNo.Name = "LblPatientNo"
        Me.LblPatientNo.Size = New System.Drawing.Size(68, 13)
        Me.LblPatientNo.TabIndex = 10
        Me.LblPatientNo.Text = "LblPatientNo"
        Me.LblPatientNo.Visible = False
        '
        'FormResultColoscopy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 492)
        Me.Controls.Add(Me.lblPatientName)
        Me.Controls.Add(Me.LblPatientNo)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormResultColoscopy"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coloscopy Result"
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ConclusionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        CType(Me.ErrAlert, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnRemoveConclusion As System.Windows.Forms.Button
    Friend WithEvents BtnAddConclusion As System.Windows.Forms.Button
    Friend WithEvents cboColoDocteur As System.Windows.Forms.ComboBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents cboColoDemander As System.Windows.Forms.ComboBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txtColoTolerance As System.Windows.Forms.TextBox
    Friend WithEvents cboColoAnesthegiste As System.Windows.Forms.ComboBox
    Friend WithEvents chkColoAnesthegiste As System.Windows.Forms.CheckBox
    Friend WithEvents cboColoPreparation As System.Windows.Forms.ComboBox
    Friend WithEvents txtColoEva As System.Windows.Forms.TextBox
    Friend WithEvents txtColoDuree As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ConclusionList As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcolomoreinfo As System.Windows.Forms.TextBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents ErrAlert As System.Windows.Forms.ErrorProvider
    Friend WithEvents cboColoConclusion As System.Windows.Forms.ComboBox
    Friend WithEvents DateResultExam As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblPatientName As System.Windows.Forms.Label
    Friend WithEvents LblPatientNo As System.Windows.Forms.Label
    Friend WithEvents txtnewfield As System.Windows.Forms.TextBox
    Friend WithEvents txtColoRectum As System.Windows.Forms.TextBox
    Friend WithEvents txtColoSigmoide As System.Windows.Forms.TextBox
    Friend WithEvents txtColonGauche As System.Windows.Forms.TextBox
    Friend WithEvents txtColoColonTransverse As System.Windows.Forms.TextBox
    Friend WithEvents txtColoColonDroit As System.Windows.Forms.TextBox
    Friend WithEvents txtColoCaecum As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents cboColoMotify As System.Windows.Forms.ComboBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
End Class
