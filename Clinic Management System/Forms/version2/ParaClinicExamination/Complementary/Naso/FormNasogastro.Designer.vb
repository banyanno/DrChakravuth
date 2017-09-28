<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNasogastro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNasogastro))
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.DateResultExam = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox16 = New System.Windows.Forms.GroupBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtNasoTolerance = New System.Windows.Forms.TextBox
        Me.cboNasoDemander = New System.Windows.Forms.ComboBox
        Me.GroupBox13 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ChAnaPath = New System.Windows.Forms.CheckBox
        Me.BtnRemoveConclusion = New System.Windows.Forms.Button
        Me.BtnAddConclusion = New System.Windows.Forms.Button
        Me.txtnasomoreinfo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.conclusionlist = New Janus.Windows.GridEX.GridEX
        Me.txtNasoD1 = New System.Windows.Forms.TextBox
        Me.txtNasoBulbe = New System.Windows.Forms.TextBox
        Me.TxtLacMuquex = New System.Windows.Forms.TextBox
        Me.TxtGrosseTuberose = New System.Windows.Forms.TextBox
        Me.TxtFundus = New System.Windows.Forms.TextBox
        Me.TxtAntre = New System.Windows.Forms.TextBox
        Me.txtNasoPylore = New System.Windows.Forms.TextBox
        Me.txtNasoEsto = New System.Windows.Forms.TextBox
        Me.txtNasoOeso = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.cboNasoDocteur = New System.Windows.Forms.ComboBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.cboNasoConclusion = New System.Windows.Forms.ComboBox
        Me.cboNasoMotify = New System.Windows.Forms.ComboBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.ErrAlert = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblPatientName = New System.Windows.Forms.Label
        Me.LblPatientNo = New System.Windows.Forms.Label
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.conclusionlist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrAlert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DateResultExam)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.GroupBox16)
        Me.GroupBox6.Controls.Add(Me.GroupBox13)
        Me.GroupBox6.Location = New System.Drawing.Point(10, 2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1040, 565)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
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
        'GroupBox13
        '
        Me.GroupBox13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox13.Controls.Add(Me.Label5)
        Me.GroupBox13.Controls.Add(Me.Label4)
        Me.GroupBox13.Controls.Add(Me.Label3)
        Me.GroupBox13.Controls.Add(Me.Label2)
        Me.GroupBox13.Controls.Add(Me.ChAnaPath)
        Me.GroupBox13.Controls.Add(Me.BtnRemoveConclusion)
        Me.GroupBox13.Controls.Add(Me.BtnAddConclusion)
        Me.GroupBox13.Controls.Add(Me.txtnasomoreinfo)
        Me.GroupBox13.Controls.Add(Me.Label1)
        Me.GroupBox13.Controls.Add(Me.GroupBox1)
        Me.GroupBox13.Controls.Add(Me.txtNasoD1)
        Me.GroupBox13.Controls.Add(Me.txtNasoBulbe)
        Me.GroupBox13.Controls.Add(Me.TxtLacMuquex)
        Me.GroupBox13.Controls.Add(Me.TxtGrosseTuberose)
        Me.GroupBox13.Controls.Add(Me.TxtFundus)
        Me.GroupBox13.Controls.Add(Me.TxtAntre)
        Me.GroupBox13.Controls.Add(Me.txtNasoPylore)
        Me.GroupBox13.Controls.Add(Me.txtNasoEsto)
        Me.GroupBox13.Controls.Add(Me.txtNasoOeso)
        Me.GroupBox13.Controls.Add(Me.Label34)
        Me.GroupBox13.Controls.Add(Me.Label33)
        Me.GroupBox13.Controls.Add(Me.Label32)
        Me.GroupBox13.Controls.Add(Me.Label31)
        Me.GroupBox13.Controls.Add(Me.Label30)
        Me.GroupBox13.Controls.Add(Me.cboNasoDocteur)
        Me.GroupBox13.Controls.Add(Me.Label27)
        Me.GroupBox13.Controls.Add(Me.cboNasoConclusion)
        Me.GroupBox13.Controls.Add(Me.cboNasoMotify)
        Me.GroupBox13.Controls.Add(Me.Label28)
        Me.GroupBox13.Controls.Add(Me.Label29)
        Me.GroupBox13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox13.Location = New System.Drawing.Point(6, 106)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(1028, 451)
        Me.GroupBox13.TabIndex = 1
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Result of Nasogastro"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(79, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 16)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Antre :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(79, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Fundus :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 16)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Grosse tubérosité :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 16)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Lac muqueux :"
        '
        'ChAnaPath
        '
        Me.ChAnaPath.AutoSize = True
        Me.ChAnaPath.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChAnaPath.Location = New System.Drawing.Point(589, 405)
        Me.ChAnaPath.Name = "ChAnaPath"
        Me.ChAnaPath.Size = New System.Drawing.Size(102, 20)
        Me.ChAnaPath.TabIndex = 6
        Me.ChAnaPath.Text = "C.f: Anapath."
        Me.ChAnaPath.UseVisualStyleBackColor = True
        '
        'BtnRemoveConclusion
        '
        Me.BtnRemoveConclusion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemoveConclusion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemoveConclusion.Location = New System.Drawing.Point(981, 26)
        Me.BtnRemoveConclusion.Name = "BtnRemoveConclusion"
        Me.BtnRemoveConclusion.Size = New System.Drawing.Size(35, 25)
        Me.BtnRemoveConclusion.TabIndex = 10
        Me.BtnRemoveConclusion.Text = "-"
        Me.BtnRemoveConclusion.UseVisualStyleBackColor = True
        '
        'BtnAddConclusion
        '
        Me.BtnAddConclusion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddConclusion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddConclusion.Location = New System.Drawing.Point(943, 26)
        Me.BtnAddConclusion.Name = "BtnAddConclusion"
        Me.BtnAddConclusion.Size = New System.Drawing.Size(35, 25)
        Me.BtnAddConclusion.TabIndex = 9
        Me.BtnAddConclusion.Text = "+"
        Me.BtnAddConclusion.UseVisualStyleBackColor = True
        '
        'txtnasomoreinfo
        '
        Me.txtnasomoreinfo.Location = New System.Drawing.Point(658, 270)
        Me.txtnasomoreinfo.Multiline = True
        Me.txtnasomoreinfo.Name = "txtnasomoreinfo"
        Me.txtnasomoreinfo.Size = New System.Drawing.Size(360, 57)
        Me.txtnasomoreinfo.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(608, 288)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Other:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.conclusionlist)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(655, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 165)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of conclusion"
        '
        'conclusionlist
        '
        Me.conclusionlist.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        conclusionlist_DesignTimeLayout.LayoutString = resources.GetString("conclusionlist_DesignTimeLayout.LayoutString")
        Me.conclusionlist.DesignTimeLayout = conclusionlist_DesignTimeLayout
        Me.conclusionlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.conclusionlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.conclusionlist.GroupByBoxVisible = False
        Me.conclusionlist.HeaderFormatStyle.FontSize = 10.0!
        Me.conclusionlist.Location = New System.Drawing.Point(3, 18)
        Me.conclusionlist.Name = "conclusionlist"
        Me.conclusionlist.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.conclusionlist.Size = New System.Drawing.Size(355, 144)
        Me.conclusionlist.TabIndex = 0
        '
        'txtNasoD1
        '
        Me.txtNasoD1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNasoD1.Location = New System.Drawing.Point(126, 403)
        Me.txtNasoD1.Name = "txtNasoD1"
        Me.txtNasoD1.Size = New System.Drawing.Size(429, 26)
        Me.txtNasoD1.TabIndex = 5
        Me.txtNasoD1.Text = "Normaux."
        '
        'txtNasoBulbe
        '
        Me.txtNasoBulbe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNasoBulbe.Location = New System.Drawing.Point(126, 368)
        Me.txtNasoBulbe.Name = "txtNasoBulbe"
        Me.txtNasoBulbe.Size = New System.Drawing.Size(429, 26)
        Me.txtNasoBulbe.TabIndex = 4
        Me.txtNasoBulbe.Text = "Normal."
        '
        'TxtLacMuquex
        '
        Me.TxtLacMuquex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLacMuquex.Location = New System.Drawing.Point(144, 164)
        Me.TxtLacMuquex.Name = "TxtLacMuquex"
        Me.TxtLacMuquex.Size = New System.Drawing.Size(447, 26)
        Me.TxtLacMuquex.TabIndex = 3
        '
        'TxtGrosseTuberose
        '
        Me.TxtGrosseTuberose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGrosseTuberose.Location = New System.Drawing.Point(144, 202)
        Me.TxtGrosseTuberose.Name = "TxtGrosseTuberose"
        Me.TxtGrosseTuberose.Size = New System.Drawing.Size(447, 26)
        Me.TxtGrosseTuberose.TabIndex = 3
        Me.TxtGrosseTuberose.Text = "Normal"
        '
        'TxtFundus
        '
        Me.TxtFundus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFundus.Location = New System.Drawing.Point(144, 241)
        Me.TxtFundus.Name = "TxtFundus"
        Me.TxtFundus.Size = New System.Drawing.Size(447, 26)
        Me.TxtFundus.TabIndex = 3
        Me.TxtFundus.Text = "normal. 2 Biopsies sur la muqueuse saine à la recherche d'Hp."
        '
        'TxtAntre
        '
        Me.TxtAntre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAntre.Location = New System.Drawing.Point(144, 282)
        Me.TxtAntre.Name = "TxtAntre"
        Me.TxtAntre.Size = New System.Drawing.Size(447, 26)
        Me.TxtAntre.TabIndex = 3
        Me.TxtAntre.Text = "normal. 1Biopsie sur l'angulus et 2 autres biopsies sur la muqueuse saine à la re" & _
            "cherche d'Hp."
        '
        'txtNasoPylore
        '
        Me.txtNasoPylore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNasoPylore.Location = New System.Drawing.Point(126, 332)
        Me.txtNasoPylore.Name = "txtNasoPylore"
        Me.txtNasoPylore.Size = New System.Drawing.Size(429, 26)
        Me.txtNasoPylore.TabIndex = 3
        Me.txtNasoPylore.Text = "Normal."
        '
        'txtNasoEsto
        '
        Me.txtNasoEsto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNasoEsto.Location = New System.Drawing.Point(126, 117)
        Me.txtNasoEsto.Name = "txtNasoEsto"
        Me.txtNasoEsto.Size = New System.Drawing.Size(429, 26)
        Me.txtNasoEsto.TabIndex = 2
        '
        'txtNasoOeso
        '
        Me.txtNasoOeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNasoOeso.Location = New System.Drawing.Point(126, 56)
        Me.txtNasoOeso.Multiline = True
        Me.txtNasoOeso.Name = "txtNasoOeso"
        Me.txtNasoOeso.Size = New System.Drawing.Size(429, 43)
        Me.txtNasoOeso.TabIndex = 1
        Me.txtNasoOeso.Text = "Muqueuse normale." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cardia en place à  cm d'orifice nasale."
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(10, 409)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(110, 16)
        Me.Label34.TabIndex = 47
        Me.Label34.Text = "D1, début de D2 :"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(61, 378)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(59, 16)
        Me.Label33.TabIndex = 46
        Me.Label33.Text = "BULBE :"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(51, 332)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(69, 16)
        Me.Label32.TabIndex = 45
        Me.Label32.Text = "PYLORE :"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(44, 124)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(76, 16)
        Me.Label31.TabIndex = 44
        Me.Label31.Text = "ESTOMAC:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(24, 68)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(96, 16)
        Me.Label30.TabIndex = 43
        Me.Label30.Text = "OESOPHAGE:"
        '
        'cboNasoDocteur
        '
        Me.cboNasoDocteur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboNasoDocteur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboNasoDocteur.Enabled = False
        Me.cboNasoDocteur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNasoDocteur.FormattingEnabled = True
        Me.cboNasoDocteur.Location = New System.Drawing.Point(658, 239)
        Me.cboNasoDocteur.Name = "cboNasoDocteur"
        Me.cboNasoDocteur.Size = New System.Drawing.Size(355, 24)
        Me.cboNasoDocteur.TabIndex = 7
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(573, 31)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(76, 16)
        Me.Label27.TabIndex = 41
        Me.Label27.Text = "Conclusion:"
        '
        'cboNasoConclusion
        '
        Me.cboNasoConclusion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboNasoConclusion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboNasoConclusion.DropDownWidth = 500
        Me.cboNasoConclusion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNasoConclusion.FormattingEnabled = True
        Me.cboNasoConclusion.Location = New System.Drawing.Point(655, 27)
        Me.cboNasoConclusion.Name = "cboNasoConclusion"
        Me.cboNasoConclusion.Size = New System.Drawing.Size(284, 24)
        Me.cboNasoConclusion.TabIndex = 8
        '
        'cboNasoMotify
        '
        Me.cboNasoMotify.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboNasoMotify.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboNasoMotify.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNasoMotify.FormattingEnabled = True
        Me.cboNasoMotify.Location = New System.Drawing.Point(126, 26)
        Me.cboNasoMotify.Name = "cboNasoMotify"
        Me.cboNasoMotify.Size = New System.Drawing.Size(429, 24)
        Me.cboNasoMotify.TabIndex = 0
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(595, 243)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(57, 16)
        Me.Label28.TabIndex = 38
        Me.Label28.Text = "Docteur:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(73, 31)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(40, 16)
        Me.Label29.TabIndex = 37
        Me.Label29.Text = "Motif:"
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(962, 583)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(89, 34)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(866, 583)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(89, 34)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'ErrAlert
        '
        Me.ErrAlert.ContainerControl = Me
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Location = New System.Drawing.Point(127, 594)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(78, 13)
        Me.lblPatientName.TabIndex = 13
        Me.lblPatientName.Text = "lblPatientName"
        Me.lblPatientName.Visible = False
        '
        'LblPatientNo
        '
        Me.LblPatientNo.AutoSize = True
        Me.LblPatientNo.Location = New System.Drawing.Point(42, 583)
        Me.LblPatientNo.Name = "LblPatientNo"
        Me.LblPatientNo.Size = New System.Drawing.Size(68, 13)
        Me.LblPatientNo.TabIndex = 12
        Me.LblPatientNo.Text = "LblPatientNo"
        Me.LblPatientNo.Visible = False
        '
        'FormNasogastro
        '
        Me.AcceptButton = Me.BtnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 629)
        Me.Controls.Add(Me.lblPatientName)
        Me.Controls.Add(Me.LblPatientNo)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormNasogastro"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nasogastro Result"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.conclusionlist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrAlert, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtNasoTolerance As System.Windows.Forms.TextBox
    Friend WithEvents cboNasoDemander As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNasoD1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNasoBulbe As System.Windows.Forms.TextBox
    Friend WithEvents txtNasoPylore As System.Windows.Forms.TextBox
    Friend WithEvents txtNasoEsto As System.Windows.Forms.TextBox
    Friend WithEvents txtNasoOeso As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents cboNasoDocteur As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cboNasoConclusion As System.Windows.Forms.ComboBox
    Friend WithEvents cboNasoMotify As System.Windows.Forms.ComboBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtnasomoreinfo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnRemoveConclusion As System.Windows.Forms.Button
    Friend WithEvents BtnAddConclusion As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents conclusionlist As Janus.Windows.GridEX.GridEX
    Friend WithEvents ErrAlert As System.Windows.Forms.ErrorProvider
    Friend WithEvents ChAnaPath As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtLacMuquex As System.Windows.Forms.TextBox
    Friend WithEvents TxtGrosseTuberose As System.Windows.Forms.TextBox
    Friend WithEvents TxtFundus As System.Windows.Forms.TextBox
    Friend WithEvents TxtAntre As System.Windows.Forms.TextBox
    Friend WithEvents DateResultExam As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblPatientName As System.Windows.Forms.Label
    Friend WithEvents LblPatientNo As System.Windows.Forms.Label
End Class
