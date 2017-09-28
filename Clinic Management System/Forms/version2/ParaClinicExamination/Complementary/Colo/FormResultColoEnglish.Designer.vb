<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormResultColoEnglish
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormResultColoEnglish))
        Dim ConclusionList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.DateResultExam = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox15 = New System.Windows.Forms.GroupBox
        Me.TxtProcedure = New System.Windows.Forms.RichTextBox
        Me.LblProcedure = New System.Windows.Forms.Label
        Me.TxtImpression = New System.Windows.Forms.TextBox
        Me.TxtFinding = New System.Windows.Forms.TextBox
        Me.TxtRecalExam = New System.Windows.Forms.TextBox
        Me.TxtXylocainegel = New System.Windows.Forms.TextBox
        Me.TxtPropofol = New System.Windows.Forms.TextBox
        Me.txtFentanyL = New System.Windows.Forms.TextBox
        Me.TxtIndication = New System.Windows.Forms.TextBox
        Me.TxtIntroduction = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboColoConclusion = New System.Windows.Forms.ComboBox
        Me.txtcolomoreinfo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ConclusionList = New Janus.Windows.GridEX.GridEX
        Me.BtnRemoveConclusion = New System.Windows.Forms.Button
        Me.BtnAddConclusion = New System.Windows.Forms.Button
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.cboColoDocteur = New System.Windows.Forms.ComboBox
        Me.Label42 = New System.Windows.Forms.Label
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
        Me.lblPatientName = New System.Windows.Forms.Label
        Me.LblPatientNo = New System.Windows.Forms.Label
        Me.ErrAlert = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnSave = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnCancel = New System.Windows.Forms.ToolStripButton
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ConclusionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox14.SuspendLayout()
        CType(Me.ErrAlert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
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
        Me.GroupBox7.Location = New System.Drawing.Point(2, 28)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(1008, 661)
        Me.GroupBox7.TabIndex = 1
        Me.GroupBox7.TabStop = False
        '
        'DateResultExam
        '
        Me.DateResultExam.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateResultExam.CustomFormat = "dd/MM/yyyy"
        Me.DateResultExam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateResultExam.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateResultExam.Location = New System.Drawing.Point(258, 28)
        Me.DateResultExam.Name = "DateResultExam"
        Me.DateResultExam.Size = New System.Drawing.Size(135, 26)
        Me.DateResultExam.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(172, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Date Result:"
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.LblPatientNo)
        Me.GroupBox15.Controls.Add(Me.lblPatientName)
        Me.GroupBox15.Controls.Add(Me.TxtProcedure)
        Me.GroupBox15.Controls.Add(Me.LblProcedure)
        Me.GroupBox15.Controls.Add(Me.TxtImpression)
        Me.GroupBox15.Controls.Add(Me.TxtFinding)
        Me.GroupBox15.Controls.Add(Me.TxtRecalExam)
        Me.GroupBox15.Controls.Add(Me.TxtXylocainegel)
        Me.GroupBox15.Controls.Add(Me.TxtPropofol)
        Me.GroupBox15.Controls.Add(Me.txtFentanyL)
        Me.GroupBox15.Controls.Add(Me.TxtIndication)
        Me.GroupBox15.Controls.Add(Me.TxtIntroduction)
        Me.GroupBox15.Controls.Add(Me.Label3)
        Me.GroupBox15.Controls.Add(Me.Label4)
        Me.GroupBox15.Controls.Add(Me.Label5)
        Me.GroupBox15.Controls.Add(Me.cboColoConclusion)
        Me.GroupBox15.Controls.Add(Me.txtcolomoreinfo)
        Me.GroupBox15.Controls.Add(Me.Label1)
        Me.GroupBox15.Controls.Add(Me.GroupBox1)
        Me.GroupBox15.Controls.Add(Me.BtnRemoveConclusion)
        Me.GroupBox15.Controls.Add(Me.BtnAddConclusion)
        Me.GroupBox15.Controls.Add(Me.Label50)
        Me.GroupBox15.Controls.Add(Me.Label49)
        Me.GroupBox15.Controls.Add(Me.Label48)
        Me.GroupBox15.Controls.Add(Me.Label47)
        Me.GroupBox15.Controls.Add(Me.Label46)
        Me.GroupBox15.Controls.Add(Me.Label45)
        Me.GroupBox15.Controls.Add(Me.cboColoDocteur)
        Me.GroupBox15.Controls.Add(Me.Label42)
        Me.GroupBox15.Controls.Add(Me.Label43)
        Me.GroupBox15.Controls.Add(Me.Label44)
        Me.GroupBox15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox15.Location = New System.Drawing.Point(3, 97)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(990, 558)
        Me.GroupBox15.TabIndex = 4
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Result of Coloscopy"
        '
        'TxtProcedure
        '
        Me.TxtProcedure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtProcedure.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProcedure.Location = New System.Drawing.Point(107, 270)
        Me.TxtProcedure.Name = "TxtProcedure"
        Me.TxtProcedure.Size = New System.Drawing.Size(373, 130)
        Me.TxtProcedure.TabIndex = 76
        Me.TxtProcedure.Text = resources.GetString("TxtProcedure.Text")
        '
        'LblProcedure
        '
        Me.LblProcedure.AutoSize = True
        Me.LblProcedure.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProcedure.Location = New System.Drawing.Point(16, 273)
        Me.LblProcedure.Name = "LblProcedure"
        Me.LblProcedure.Size = New System.Drawing.Size(71, 16)
        Me.LblProcedure.TabIndex = 75
        Me.LblProcedure.Text = "Procedure:"
        '
        'TxtImpression
        '
        Me.TxtImpression.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtImpression.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImpression.Location = New System.Drawing.Point(11, 489)
        Me.TxtImpression.Multiline = True
        Me.TxtImpression.Name = "TxtImpression"
        Me.TxtImpression.Size = New System.Drawing.Size(464, 56)
        Me.TxtImpression.TabIndex = 73
        '
        'TxtFinding
        '
        Me.TxtFinding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFinding.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFinding.Location = New System.Drawing.Point(11, 421)
        Me.TxtFinding.Multiline = True
        Me.TxtFinding.Name = "TxtFinding"
        Me.TxtFinding.Size = New System.Drawing.Size(464, 46)
        Me.TxtFinding.TabIndex = 72
        '
        'TxtRecalExam
        '
        Me.TxtRecalExam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRecalExam.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRecalExam.Location = New System.Drawing.Point(107, 238)
        Me.TxtRecalExam.Name = "TxtRecalExam"
        Me.TxtRecalExam.Size = New System.Drawing.Size(370, 26)
        Me.TxtRecalExam.TabIndex = 71
        '
        'TxtXylocainegel
        '
        Me.TxtXylocainegel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtXylocainegel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtXylocainegel.Location = New System.Drawing.Point(107, 204)
        Me.TxtXylocainegel.Name = "TxtXylocainegel"
        Me.TxtXylocainegel.Size = New System.Drawing.Size(370, 26)
        Me.TxtXylocainegel.TabIndex = 70
        '
        'TxtPropofol
        '
        Me.TxtPropofol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPropofol.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPropofol.Location = New System.Drawing.Point(107, 170)
        Me.TxtPropofol.Name = "TxtPropofol"
        Me.TxtPropofol.Size = New System.Drawing.Size(370, 26)
        Me.TxtPropofol.TabIndex = 69
        '
        'txtFentanyL
        '
        Me.txtFentanyL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFentanyL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFentanyL.Location = New System.Drawing.Point(107, 136)
        Me.txtFentanyL.Name = "txtFentanyL"
        Me.txtFentanyL.Size = New System.Drawing.Size(370, 26)
        Me.txtFentanyL.TabIndex = 68
        '
        'TxtIndication
        '
        Me.TxtIndication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIndication.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIndication.Location = New System.Drawing.Point(107, 50)
        Me.TxtIndication.Name = "TxtIndication"
        Me.TxtIndication.Size = New System.Drawing.Size(370, 26)
        Me.TxtIndication.TabIndex = 67
        '
        'TxtIntroduction
        '
        Me.TxtIntroduction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIntroduction.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIntroduction.Location = New System.Drawing.Point(107, 20)
        Me.TxtIntroduction.Name = "TxtIntroduction"
        Me.TxtIntroduction.Size = New System.Drawing.Size(370, 26)
        Me.TxtIntroduction.TabIndex = 66
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 470)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Impression :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 402)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Finding :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 16)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Rectal exam :"
        '
        'cboColoConclusion
        '
        Me.cboColoConclusion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboColoConclusion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboColoConclusion.DropDownWidth = 500
        Me.cboColoConclusion.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboColoConclusion.FormattingEnabled = True
        Me.cboColoConclusion.Location = New System.Drawing.Point(606, 17)
        Me.cboColoConclusion.Name = "cboColoConclusion"
        Me.cboColoConclusion.Size = New System.Drawing.Size(296, 24)
        Me.cboColoConclusion.TabIndex = 62
        '
        'txtcolomoreinfo
        '
        Me.txtcolomoreinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcolomoreinfo.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtcolomoreinfo.Location = New System.Drawing.Point(629, 291)
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
        Me.Label1.Location = New System.Drawing.Point(569, 289)
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
        Me.GroupBox1.Location = New System.Drawing.Point(483, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(494, 188)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of Recommendation :"
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
        Me.ConclusionList.Size = New System.Drawing.Size(488, 167)
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
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(12, 210)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(96, 16)
        Me.Label50.TabIndex = 54
        Me.Label50.Text = "- Xylocainegel :"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(12, 176)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(63, 16)
        Me.Label49.TabIndex = 53
        Me.Label49.Text = "-Propofol:"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(12, 142)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(70, 16)
        Me.Label48.TabIndex = 52
        Me.Label48.Text = "-Fentanyl :"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(12, 108)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(75, 16)
        Me.Label47.TabIndex = 51
        Me.Label47.Text = "Medication:"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(10, 80)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(77, 16)
        Me.Label46.TabIndex = 50
        Me.Label46.Text = "Anesthesia:"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(8, 56)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(67, 16)
        Me.Label45.TabIndex = 49
        Me.Label45.Text = "Indication:"
        '
        'cboColoDocteur
        '
        Me.cboColoDocteur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboColoDocteur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboColoDocteur.Enabled = False
        Me.cboColoDocteur.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cboColoDocteur.FormattingEnabled = True
        Me.cboColoDocteur.Location = New System.Drawing.Point(629, 257)
        Me.cboColoDocteur.Name = "cboColoDocteur"
        Me.cboColoDocteur.Size = New System.Drawing.Size(344, 26)
        Me.cboColoDocteur.TabIndex = 7
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(483, 22)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(117, 16)
        Me.Label42.TabIndex = 47
        Me.Label42.Text = "Recommendation :"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(569, 260)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(50, 16)
        Me.Label43.TabIndex = 44
        Me.Label43.Text = "Doctor:"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(8, 26)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(79, 16)
        Me.Label44.TabIndex = 43
        Me.Label44.Text = "Introduction:"
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
        Me.GroupBox14.Location = New System.Drawing.Point(400, 16)
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
        Me.Label41.Size = New System.Drawing.Size(78, 16)
        Me.Label41.TabIndex = 9
        Me.Label41.Text = "Request by:"
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
        Me.cboColoPreparation.Location = New System.Drawing.Point(257, 61)
        Me.cboColoPreparation.Name = "cboColoPreparation"
        Me.cboColoPreparation.Size = New System.Drawing.Size(136, 24)
        Me.cboColoPreparation.TabIndex = 2
        '
        'txtColoEva
        '
        Me.txtColoEva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtColoEva.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColoEva.Location = New System.Drawing.Point(66, 62)
        Me.txtColoEva.Name = "txtColoEva"
        Me.txtColoEva.Size = New System.Drawing.Size(101, 22)
        Me.txtColoEva.TabIndex = 1
        '
        'txtColoDuree
        '
        Me.txtColoDuree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtColoDuree.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColoDuree.Location = New System.Drawing.Point(67, 29)
        Me.txtColoDuree.Name = "txtColoDuree"
        Me.txtColoDuree.Size = New System.Drawing.Size(101, 22)
        Me.txtColoDuree.TabIndex = 0
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(175, 65)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(78, 16)
        Me.Label39.TabIndex = 1
        Me.Label39.Text = "Preparation:"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(9, 68)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(38, 16)
        Me.Label38.TabIndex = 1
        Me.Label38.Text = "EVA:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(9, 35)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(60, 16)
        Me.Label37.TabIndex = 0
        Me.Label37.Text = "Duration:"
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Location = New System.Drawing.Point(569, 503)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(106, 16)
        Me.lblPatientName.TabIndex = 13
        Me.lblPatientName.Text = "lblPatientName"
        Me.lblPatientName.Visible = False
        '
        'LblPatientNo
        '
        Me.LblPatientNo.AutoSize = True
        Me.LblPatientNo.Location = New System.Drawing.Point(626, 458)
        Me.LblPatientNo.Name = "LblPatientNo"
        Me.LblPatientNo.Size = New System.Drawing.Size(90, 16)
        Me.LblPatientNo.TabIndex = 12
        Me.LblPatientNo.Text = "LblPatientNo"
        Me.LblPatientNo.Visible = False
        '
        'ErrAlert
        '
        Me.ErrAlert.ContainerControl = Me
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnSave, Me.ToolStripSeparator1, Me.BtnCancel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1127, 47)
        Me.ToolStrip1.TabIndex = 16
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnSave
        '
        Me.BtnSave.ForeColor = System.Drawing.Color.Blue
        Me.BtnSave.Image = Global.Clinic_Management_System.My.Resources.Resources.store
        Me.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(65, 44)
        Me.BtnSave.Text = "     Save     "
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 47)
        '
        'BtnCancel
        '
        Me.BtnCancel.ForeColor = System.Drawing.Color.Blue
        Me.BtnCancel.Image = Global.Clinic_Management_System.My.Resources.Resources.Close
        Me.BtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(77, 44)
        Me.BtnCancel.Text = "     Cancel     "
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FormResultColoEnglish
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 829)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormResultColoEnglish"
        Me.Text = "Result Colo English"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ConclusionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        CType(Me.ErrAlert, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents DateResultExam As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents cboColoConclusion As System.Windows.Forms.ComboBox
    Friend WithEvents txtcolomoreinfo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ConclusionList As Janus.Windows.GridEX.GridEX
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
    Friend WithEvents lblPatientName As System.Windows.Forms.Label
    Friend WithEvents LblPatientNo As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtImpression As System.Windows.Forms.TextBox
    Friend WithEvents TxtFinding As System.Windows.Forms.TextBox
    Friend WithEvents TxtRecalExam As System.Windows.Forms.TextBox
    Friend WithEvents TxtXylocainegel As System.Windows.Forms.TextBox
    Friend WithEvents TxtPropofol As System.Windows.Forms.TextBox
    Friend WithEvents txtFentanyL As System.Windows.Forms.TextBox
    Friend WithEvents TxtIndication As System.Windows.Forms.TextBox
    Friend WithEvents TxtIntroduction As System.Windows.Forms.TextBox
    Friend WithEvents ErrAlert As System.Windows.Forms.ErrorProvider
    Friend WithEvents LblProcedure As System.Windows.Forms.Label
    Friend WithEvents TxtProcedure As System.Windows.Forms.RichTextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnCancel As System.Windows.Forms.ToolStripButton
End Class
