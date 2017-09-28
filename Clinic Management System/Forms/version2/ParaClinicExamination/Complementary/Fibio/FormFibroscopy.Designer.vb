<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFibroscopy
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
        Dim conclusionlist_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFibroscopy))
        Me.GroupBox17 = New System.Windows.Forms.GroupBox
        Me.cboFibroDemander = New System.Windows.Forms.ComboBox
        Me.cboFibroAnesthegiste = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.chkFibroAnesthegiste = New System.Windows.Forms.CheckBox
        Me.txtFibroTolerance = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.cboFibroConclusion = New System.Windows.Forms.ComboBox
        Me.ChAnaPath = New System.Windows.Forms.CheckBox
        Me.txtfibromoreinfo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnRemoveConclusion = New System.Windows.Forms.Button
        Me.BtnAddConclusion = New System.Windows.Forms.Button
        Me.ConclusionGroup = New System.Windows.Forms.GroupBox
        Me.conclusionlist = New Janus.Windows.GridEX.GridEX
        Me.cboFibroDocteur = New System.Windows.Forms.ComboBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtFibroD1 = New System.Windows.Forms.TextBox
        Me.txtFibroBulbe = New System.Windows.Forms.TextBox
        Me.txtFibroAntre = New System.Windows.Forms.TextBox
        Me.txtFibroFundus = New System.Windows.Forms.TextBox
        Me.txtFibroPylore = New System.Windows.Forms.TextBox
        Me.txtFibroGrosse = New System.Windows.Forms.TextBox
        Me.txtFibroLac = New System.Windows.Forms.TextBox
        Me.txtFibroEsto = New System.Windows.Forms.TextBox
        Me.txtFibroOeso = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.cboFibroMotify = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.ErrAlert = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.DateResultExam = New System.Windows.Forms.DateTimePicker
        Me.LblPatientNo = New System.Windows.Forms.Label
        Me.lblPatientName = New System.Windows.Forms.Label
        Me.GroupBox17.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.ConclusionGroup.SuspendLayout()
        CType(Me.conclusionlist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrAlert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.cboFibroDemander)
        Me.GroupBox17.Controls.Add(Me.cboFibroAnesthegiste)
        Me.GroupBox17.Controls.Add(Me.Label10)
        Me.GroupBox17.Controls.Add(Me.chkFibroAnesthegiste)
        Me.GroupBox17.Controls.Add(Me.txtFibroTolerance)
        Me.GroupBox17.Controls.Add(Me.Label11)
        Me.GroupBox17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox17.Location = New System.Drawing.Point(2, 3)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(664, 99)
        Me.GroupBox17.TabIndex = 0
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
        Me.cboFibroAnesthegiste.Location = New System.Drawing.Point(443, 57)
        Me.cboFibroAnesthegiste.Name = "cboFibroAnesthegiste"
        Me.cboFibroAnesthegiste.Size = New System.Drawing.Size(205, 28)
        Me.cboFibroAnesthegiste.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(22, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 16)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Demander par:"
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
        Me.txtFibroTolerance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFibroTolerance.Location = New System.Drawing.Point(120, 61)
        Me.txtFibroTolerance.Name = "txtFibroTolerance"
        Me.txtFibroTolerance.Size = New System.Drawing.Size(205, 26)
        Me.txtFibroTolerance.TabIndex = 1
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
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.cboFibroConclusion)
        Me.GroupBox12.Controls.Add(Me.ChAnaPath)
        Me.GroupBox12.Controls.Add(Me.txtfibromoreinfo)
        Me.GroupBox12.Controls.Add(Me.Label1)
        Me.GroupBox12.Controls.Add(Me.BtnRemoveConclusion)
        Me.GroupBox12.Controls.Add(Me.BtnAddConclusion)
        Me.GroupBox12.Controls.Add(Me.ConclusionGroup)
        Me.GroupBox12.Controls.Add(Me.cboFibroDocteur)
        Me.GroupBox12.Controls.Add(Me.Label26)
        Me.GroupBox12.Controls.Add(Me.txtFibroD1)
        Me.GroupBox12.Controls.Add(Me.txtFibroBulbe)
        Me.GroupBox12.Controls.Add(Me.txtFibroAntre)
        Me.GroupBox12.Controls.Add(Me.txtFibroFundus)
        Me.GroupBox12.Controls.Add(Me.txtFibroPylore)
        Me.GroupBox12.Controls.Add(Me.txtFibroGrosse)
        Me.GroupBox12.Controls.Add(Me.txtFibroLac)
        Me.GroupBox12.Controls.Add(Me.txtFibroEsto)
        Me.GroupBox12.Controls.Add(Me.txtFibroOeso)
        Me.GroupBox12.Controls.Add(Me.Label22)
        Me.GroupBox12.Controls.Add(Me.Label21)
        Me.GroupBox12.Controls.Add(Me.Label20)
        Me.GroupBox12.Controls.Add(Me.Label19)
        Me.GroupBox12.Controls.Add(Me.Label18)
        Me.GroupBox12.Controls.Add(Me.Label17)
        Me.GroupBox12.Controls.Add(Me.Label16)
        Me.GroupBox12.Controls.Add(Me.Label15)
        Me.GroupBox12.Controls.Add(Me.Label14)
        Me.GroupBox12.Controls.Add(Me.cboFibroMotify)
        Me.GroupBox12.Controls.Add(Me.Label13)
        Me.GroupBox12.Controls.Add(Me.Label12)
        Me.GroupBox12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox12.Location = New System.Drawing.Point(4, 105)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(1161, 514)
        Me.GroupBox12.TabIndex = 1
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Result of Fibro"
        '
        'cboFibroConclusion
        '
        Me.cboFibroConclusion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboFibroConclusion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboFibroConclusion.DropDownWidth = 500
        Me.cboFibroConclusion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFibroConclusion.FormattingEnabled = True
        Me.cboFibroConclusion.Location = New System.Drawing.Point(783, 75)
        Me.cboFibroConclusion.Name = "cboFibroConclusion"
        Me.cboFibroConclusion.Size = New System.Drawing.Size(283, 26)
        Me.cboFibroConclusion.TabIndex = 42
        '
        'ChAnaPath
        '
        Me.ChAnaPath.AutoSize = True
        Me.ChAnaPath.Location = New System.Drawing.Point(170, 482)
        Me.ChAnaPath.Name = "ChAnaPath"
        Me.ChAnaPath.Size = New System.Drawing.Size(103, 20)
        Me.ChAnaPath.TabIndex = 14
        Me.ChAnaPath.Text = "C.F Ana-path"
        Me.ChAnaPath.UseVisualStyleBackColor = True
        '
        'txtfibromoreinfo
        '
        Me.txtfibromoreinfo.Location = New System.Drawing.Point(805, 336)
        Me.txtfibromoreinfo.Multiline = True
        Me.txtfibromoreinfo.Name = "txtfibromoreinfo"
        Me.txtfibromoreinfo.Size = New System.Drawing.Size(337, 101)
        Me.txtfibromoreinfo.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(755, 378)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Other:"
        '
        'BtnRemoveConclusion
        '
        Me.BtnRemoveConclusion.Location = New System.Drawing.Point(1113, 76)
        Me.BtnRemoveConclusion.Name = "BtnRemoveConclusion"
        Me.BtnRemoveConclusion.Size = New System.Drawing.Size(35, 24)
        Me.BtnRemoveConclusion.TabIndex = 8
        Me.BtnRemoveConclusion.Text = "-"
        Me.BtnRemoveConclusion.UseVisualStyleBackColor = True
        '
        'BtnAddConclusion
        '
        Me.BtnAddConclusion.Location = New System.Drawing.Point(1072, 76)
        Me.BtnAddConclusion.Name = "BtnAddConclusion"
        Me.BtnAddConclusion.Size = New System.Drawing.Size(35, 24)
        Me.BtnAddConclusion.TabIndex = 7
        Me.BtnAddConclusion.Text = "+"
        Me.BtnAddConclusion.UseVisualStyleBackColor = True
        '
        'ConclusionGroup
        '
        Me.ConclusionGroup.Controls.Add(Me.conclusionlist)
        Me.ConclusionGroup.Location = New System.Drawing.Point(704, 121)
        Me.ConclusionGroup.Name = "ConclusionGroup"
        Me.ConclusionGroup.Size = New System.Drawing.Size(443, 162)
        Me.ConclusionGroup.TabIndex = 9
        Me.ConclusionGroup.TabStop = False
        Me.ConclusionGroup.Text = "List of conclusion"
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
        Me.conclusionlist.Size = New System.Drawing.Size(437, 141)
        Me.conclusionlist.TabIndex = 0
        '
        'cboFibroDocteur
        '
        Me.cboFibroDocteur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboFibroDocteur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboFibroDocteur.Enabled = False
        Me.cboFibroDocteur.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFibroDocteur.FormattingEnabled = True
        Me.cboFibroDocteur.Location = New System.Drawing.Point(805, 298)
        Me.cboFibroDocteur.Name = "cboFibroDocteur"
        Me.cboFibroDocteur.Size = New System.Drawing.Size(343, 26)
        Me.cboFibroDocteur.TabIndex = 15
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(701, 84)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(76, 16)
        Me.Label26.TabIndex = 35
        Me.Label26.Text = "Conclusion:"
        '
        'txtFibroD1
        '
        Me.txtFibroD1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFibroD1.Location = New System.Drawing.Point(171, 437)
        Me.txtFibroD1.Name = "txtFibroD1"
        Me.txtFibroD1.Size = New System.Drawing.Size(508, 26)
        Me.txtFibroD1.TabIndex = 5
        Me.txtFibroD1.Text = "Normaux."
        '
        'txtFibroBulbe
        '
        Me.txtFibroBulbe.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFibroBulbe.Location = New System.Drawing.Point(170, 396)
        Me.txtFibroBulbe.Name = "txtFibroBulbe"
        Me.txtFibroBulbe.Size = New System.Drawing.Size(509, 26)
        Me.txtFibroBulbe.TabIndex = 13
        Me.txtFibroBulbe.Text = "Normal."
        '
        'txtFibroAntre
        '
        Me.txtFibroAntre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFibroAntre.Location = New System.Drawing.Point(171, 296)
        Me.txtFibroAntre.Multiline = True
        Me.txtFibroAntre.Name = "txtFibroAntre"
        Me.txtFibroAntre.Size = New System.Drawing.Size(508, 44)
        Me.txtFibroAntre.TabIndex = 12
        Me.txtFibroAntre.Text = "normal. 1Biopsie sur l'angulus et 2 autres biopsies sur la muqueuse saine à la re" & _
            "cherche d'Hp."
        '
        'txtFibroFundus
        '
        Me.txtFibroFundus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFibroFundus.Location = New System.Drawing.Point(171, 257)
        Me.txtFibroFundus.Name = "txtFibroFundus"
        Me.txtFibroFundus.Size = New System.Drawing.Size(508, 26)
        Me.txtFibroFundus.TabIndex = 11
        Me.txtFibroFundus.Text = "normal. 2 Biopsies sur la muqueuse saine à la recherche d'Hp."
        '
        'txtFibroPylore
        '
        Me.txtFibroPylore.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFibroPylore.Location = New System.Drawing.Point(169, 357)
        Me.txtFibroPylore.Name = "txtFibroPylore"
        Me.txtFibroPylore.Size = New System.Drawing.Size(510, 26)
        Me.txtFibroPylore.TabIndex = 10
        Me.txtFibroPylore.Text = "Normal."
        '
        'txtFibroGrosse
        '
        Me.txtFibroGrosse.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFibroGrosse.Location = New System.Drawing.Point(171, 217)
        Me.txtFibroGrosse.Name = "txtFibroGrosse"
        Me.txtFibroGrosse.Size = New System.Drawing.Size(508, 26)
        Me.txtFibroGrosse.TabIndex = 4
        Me.txtFibroGrosse.Text = "normale"
        '
        'txtFibroLac
        '
        Me.txtFibroLac.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFibroLac.Location = New System.Drawing.Point(170, 179)
        Me.txtFibroLac.Name = "txtFibroLac"
        Me.txtFibroLac.Size = New System.Drawing.Size(509, 26)
        Me.txtFibroLac.TabIndex = 3
        '
        'txtFibroEsto
        '
        Me.txtFibroEsto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFibroEsto.Location = New System.Drawing.Point(170, 145)
        Me.txtFibroEsto.Multiline = True
        Me.txtFibroEsto.Name = "txtFibroEsto"
        Me.txtFibroEsto.Size = New System.Drawing.Size(509, 22)
        Me.txtFibroEsto.TabIndex = 2
        '
        'txtFibroOeso
        '
        Me.txtFibroOeso.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFibroOeso.Location = New System.Drawing.Point(169, 76)
        Me.txtFibroOeso.Multiline = True
        Me.txtFibroOeso.Name = "txtFibroOeso"
        Me.txtFibroOeso.Size = New System.Drawing.Size(510, 61)
        Me.txtFibroOeso.TabIndex = 1
        Me.txtFibroOeso.Text = "Muqueuse normale. Cardia en place à  cm des arcades dentaires."
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(27, 442)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(110, 16)
        Me.Label22.TabIndex = 21
        Me.Label22.Text = "D1, début de D2 :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(78, 401)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 16)
        Me.Label21.TabIndex = 20
        Me.Label21.Text = "BULBE :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(68, 369)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 16)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "PYLORE :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(90, 306)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 16)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Antre :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(81, 267)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 16)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Fundus :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(21, 227)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(119, 16)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Grosse tubérosité :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(56, 191)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(94, 16)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Lac muqueux :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(57, 150)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 16)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "ESTOMAC :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(32, 100)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 16)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "OESOPHAGE:"
        '
        'cboFibroMotify
        '
        Me.cboFibroMotify.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboFibroMotify.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboFibroMotify.DropDownWidth = 400
        Me.cboFibroMotify.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFibroMotify.FormattingEnabled = True
        Me.cboFibroMotify.Location = New System.Drawing.Point(169, 23)
        Me.cboFibroMotify.Name = "cboFibroMotify"
        Me.cboFibroMotify.Size = New System.Drawing.Size(343, 26)
        Me.cboFibroMotify.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(701, 303)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 16)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Docteur:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(88, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 16)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Motif:"
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(935, 630)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(112, 32)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(1053, 630)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(112, 32)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'ErrAlert
        '
        Me.ErrAlert.ContainerControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(672, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Date Result:"
        '
        'DateResultExam
        '
        Me.DateResultExam.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateResultExam.CustomFormat = "dd/MM/yyyy"
        Me.DateResultExam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateResultExam.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateResultExam.Location = New System.Drawing.Point(744, 62)
        Me.DateResultExam.Name = "DateResultExam"
        Me.DateResultExam.Size = New System.Drawing.Size(124, 26)
        Me.DateResultExam.TabIndex = 7
        '
        'LblPatientNo
        '
        Me.LblPatientNo.AutoSize = True
        Me.LblPatientNo.Location = New System.Drawing.Point(904, 20)
        Me.LblPatientNo.Name = "LblPatientNo"
        Me.LblPatientNo.Size = New System.Drawing.Size(68, 13)
        Me.LblPatientNo.TabIndex = 8
        Me.LblPatientNo.Text = "LblPatientNo"
        Me.LblPatientNo.Visible = False
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Location = New System.Drawing.Point(904, 49)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(78, 13)
        Me.lblPatientName.TabIndex = 9
        Me.lblPatientName.Text = "lblPatientName"
        Me.lblPatientName.Visible = False
        '
        'FormFibroscopy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 669)
        Me.Controls.Add(Me.lblPatientName)
        Me.Controls.Add(Me.LblPatientNo)
        Me.Controls.Add(Me.DateResultExam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox12)
        Me.Controls.Add(Me.GroupBox17)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormFibroscopy"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fibroscopy Result"
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.ConclusionGroup.ResumeLayout(False)
        CType(Me.conclusionlist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrAlert, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents cboFibroDocteur As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtFibroD1 As System.Windows.Forms.TextBox
    Friend WithEvents txtFibroBulbe As System.Windows.Forms.TextBox
    Friend WithEvents txtFibroAntre As System.Windows.Forms.TextBox
    Friend WithEvents txtFibroFundus As System.Windows.Forms.TextBox
    Friend WithEvents txtFibroPylore As System.Windows.Forms.TextBox
    Friend WithEvents txtFibroGrosse As System.Windows.Forms.TextBox
    Friend WithEvents txtFibroLac As System.Windows.Forms.TextBox
    Friend WithEvents txtFibroEsto As System.Windows.Forms.TextBox
    Friend WithEvents txtFibroOeso As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboFibroMotify As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ConclusionGroup As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAddConclusion As System.Windows.Forms.Button
    Friend WithEvents BtnRemoveConclusion As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents txtfibromoreinfo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents conclusionlist As Janus.Windows.GridEX.GridEX
    Friend WithEvents ErrAlert As System.Windows.Forms.ErrorProvider
    Friend WithEvents ChAnaPath As System.Windows.Forms.CheckBox
    Friend WithEvents cboFibroConclusion As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateResultExam As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblPatientName As System.Windows.Forms.Label
    Friend WithEvents LblPatientNo As System.Windows.Forms.Label
End Class
