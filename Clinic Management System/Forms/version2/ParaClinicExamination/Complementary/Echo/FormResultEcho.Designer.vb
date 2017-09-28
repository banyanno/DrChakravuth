<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormResultEcho
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormResultEcho))
        Dim ConclusionList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridImage_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.CboDoctorExam = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtResult = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtechomoreinfo = New System.Windows.Forms.TextBox
        Me.DateResultExam = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.BtnRemoveConclusion = New System.Windows.Forms.Button
        Me.cboEchoConclusion = New System.Windows.Forms.ComboBox
        Me.txtEchoIndication = New System.Windows.Forms.TextBox
        Me.BtnAddConclusion = New System.Windows.Forms.Button
        Me.Label53 = New System.Windows.Forms.Label
        Me.cboEchoDemander = New System.Windows.Forms.ComboBox
        Me.Label52 = New System.Windows.Forms.Label
        Me.GroupBox18 = New System.Windows.Forms.GroupBox
        Me.txtEchoLaVessie = New System.Windows.Forms.TextBox
        Me.txtEchoLaProstate = New System.Windows.Forms.TextBox
        Me.txtEchoLesReins = New System.Windows.Forms.TextBox
        Me.txtEchoLaRate = New System.Windows.Forms.TextBox
        Me.txtEchoLePancreas = New System.Windows.Forms.TextBox
        Me.txtEchoLesVoies = New System.Windows.Forms.TextBox
        Me.txtEchoLaVesicule = New System.Windows.Forms.TextBox
        Me.txtEchoLaVeine = New System.Windows.Forms.TextBox
        Me.txtEchoLeFoie = New System.Windows.Forms.TextBox
        Me.Label62 = New System.Windows.Forms.Label
        Me.Label61 = New System.Windows.Forms.Label
        Me.Label60 = New System.Windows.Forms.Label
        Me.Label59 = New System.Windows.Forms.Label
        Me.Label58 = New System.Windows.Forms.Label
        Me.Label57 = New System.Windows.Forms.Label
        Me.Label56 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ConclusionList = New Janus.Windows.GridEX.GridEX
        Me.ErrAlert = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblPatientName = New System.Windows.Forms.Label
        Me.LblPatientNo = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnSaveEcho = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnAddImg = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRemoveImg = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnClose = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GridImage = New Janus.Windows.GridEX.GridEX
        Me.GroupBox8.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox18.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ConclusionList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrAlert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GridImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.CboDoctorExam)
        Me.GroupBox8.Controls.Add(Me.Label1)
        Me.GroupBox8.Controls.Add(Me.SplitContainer1)
        Me.GroupBox8.Controls.Add(Me.DateResultExam)
        Me.GroupBox8.Controls.Add(Me.Label6)
        Me.GroupBox8.Controls.Add(Me.LblSaveOption)
        Me.GroupBox8.Controls.Add(Me.BtnRemoveConclusion)
        Me.GroupBox8.Controls.Add(Me.cboEchoConclusion)
        Me.GroupBox8.Controls.Add(Me.txtEchoIndication)
        Me.GroupBox8.Controls.Add(Me.BtnAddConclusion)
        Me.GroupBox8.Controls.Add(Me.Label53)
        Me.GroupBox8.Controls.Add(Me.cboEchoDemander)
        Me.GroupBox8.Controls.Add(Me.Label52)
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox8.Location = New System.Drawing.Point(0, 38)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(1478, 728)
        Me.GroupBox8.TabIndex = 0
        Me.GroupBox8.TabStop = False
        '
        'CboDoctorExam
        '
        Me.CboDoctorExam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDoctorExam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDoctorExam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDoctorExam.FormattingEnabled = True
        Me.CboDoctorExam.Location = New System.Drawing.Point(815, 19)
        Me.CboDoctorExam.Name = "CboDoctorExam"
        Me.CboDoctorExam.Size = New System.Drawing.Size(293, 28)
        Me.CboDoctorExam.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(752, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Exam By Dr."
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Location = New System.Drawing.Point(8, 57)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1465, 666)
        Me.SplitContainer1.SplitterDistance = 332
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 17
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtResult)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1463, 330)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Result of Echo"
        '
        'TxtResult
        '
        Me.TxtResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtResult.Location = New System.Drawing.Point(3, 22)
        Me.TxtResult.Multiline = True
        Me.TxtResult.Name = "TxtResult"
        Me.TxtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtResult.Size = New System.Drawing.Size(1457, 305)
        Me.TxtResult.TabIndex = 0
        Me.TxtResult.Text = resources.GetString("TxtResult.Text")
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtechomoreinfo)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(566, 329)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Conclusion:"
        '
        'txtechomoreinfo
        '
        Me.txtechomoreinfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtechomoreinfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtechomoreinfo.Location = New System.Drawing.Point(2, 21)
        Me.txtechomoreinfo.Multiline = True
        Me.txtechomoreinfo.Name = "txtechomoreinfo"
        Me.txtechomoreinfo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtechomoreinfo.Size = New System.Drawing.Size(562, 306)
        Me.txtechomoreinfo.TabIndex = 14
        '
        'DateResultExam
        '
        Me.DateResultExam.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateResultExam.CustomFormat = "dd/MM/yyyy"
        Me.DateResultExam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateResultExam.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateResultExam.Location = New System.Drawing.Point(620, 21)
        Me.DateResultExam.Name = "DateResultExam"
        Me.DateResultExam.Size = New System.Drawing.Size(124, 26)
        Me.DateResultExam.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(548, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Date Result:"
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(1291, 30)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(13, 13)
        Me.LblSaveOption.TabIndex = 3
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'BtnRemoveConclusion
        '
        Me.BtnRemoveConclusion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemoveConclusion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemoveConclusion.Location = New System.Drawing.Point(1144, 21)
        Me.BtnRemoveConclusion.Name = "BtnRemoveConclusion"
        Me.BtnRemoveConclusion.Size = New System.Drawing.Size(27, 21)
        Me.BtnRemoveConclusion.TabIndex = 12
        Me.BtnRemoveConclusion.Text = "-"
        Me.BtnRemoveConclusion.UseVisualStyleBackColor = True
        Me.BtnRemoveConclusion.Visible = False
        '
        'cboEchoConclusion
        '
        Me.cboEchoConclusion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboEchoConclusion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEchoConclusion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEchoConclusion.FormattingEnabled = True
        Me.cboEchoConclusion.Location = New System.Drawing.Point(1177, 21)
        Me.cboEchoConclusion.Name = "cboEchoConclusion"
        Me.cboEchoConclusion.Size = New System.Drawing.Size(64, 24)
        Me.cboEchoConclusion.TabIndex = 10
        Me.cboEchoConclusion.Visible = False
        '
        'txtEchoIndication
        '
        Me.txtEchoIndication.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEchoIndication.Location = New System.Drawing.Point(371, 21)
        Me.txtEchoIndication.Name = "txtEchoIndication"
        Me.txtEchoIndication.Size = New System.Drawing.Size(166, 26)
        Me.txtEchoIndication.TabIndex = 1
        '
        'BtnAddConclusion
        '
        Me.BtnAddConclusion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddConclusion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddConclusion.Location = New System.Drawing.Point(1114, 21)
        Me.BtnAddConclusion.Name = "BtnAddConclusion"
        Me.BtnAddConclusion.Size = New System.Drawing.Size(27, 21)
        Me.BtnAddConclusion.TabIndex = 11
        Me.BtnAddConclusion.Text = "+"
        Me.BtnAddConclusion.UseVisualStyleBackColor = True
        Me.BtnAddConclusion.Visible = False
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(311, 34)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(56, 13)
        Me.Label53.TabIndex = 9
        Me.Label53.Text = "Indication:"
        '
        'cboEchoDemander
        '
        Me.cboEchoDemander.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboEchoDemander.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEchoDemander.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEchoDemander.FormattingEnabled = True
        Me.cboEchoDemander.Location = New System.Drawing.Point(93, 19)
        Me.cboEchoDemander.Name = "cboEchoDemander"
        Me.cboEchoDemander.Size = New System.Drawing.Size(205, 28)
        Me.cboEchoDemander.TabIndex = 0
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(12, 34)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(77, 13)
        Me.Label52.TabIndex = 7
        Me.Label52.Text = "Demander par:"
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.txtEchoLaVessie)
        Me.GroupBox18.Controls.Add(Me.txtEchoLaProstate)
        Me.GroupBox18.Controls.Add(Me.txtEchoLesReins)
        Me.GroupBox18.Controls.Add(Me.txtEchoLaRate)
        Me.GroupBox18.Controls.Add(Me.txtEchoLePancreas)
        Me.GroupBox18.Controls.Add(Me.txtEchoLesVoies)
        Me.GroupBox18.Controls.Add(Me.txtEchoLaVesicule)
        Me.GroupBox18.Controls.Add(Me.txtEchoLaVeine)
        Me.GroupBox18.Controls.Add(Me.txtEchoLeFoie)
        Me.GroupBox18.Controls.Add(Me.Label62)
        Me.GroupBox18.Controls.Add(Me.Label61)
        Me.GroupBox18.Controls.Add(Me.Label60)
        Me.GroupBox18.Controls.Add(Me.Label59)
        Me.GroupBox18.Controls.Add(Me.Label58)
        Me.GroupBox18.Controls.Add(Me.Label57)
        Me.GroupBox18.Controls.Add(Me.Label56)
        Me.GroupBox18.Controls.Add(Me.Label55)
        Me.GroupBox18.Controls.Add(Me.Label54)
        Me.GroupBox18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox18.Location = New System.Drawing.Point(1027, 11)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(120, 261)
        Me.GroupBox18.TabIndex = 2
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "Result of Echo"
        Me.GroupBox18.Visible = False
        '
        'txtEchoLaVessie
        '
        Me.txtEchoLaVessie.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEchoLaVessie.Location = New System.Drawing.Point(158, 296)
        Me.txtEchoLaVessie.Name = "txtEchoLaVessie"
        Me.txtEchoLaVessie.Size = New System.Drawing.Size(389, 24)
        Me.txtEchoLaVessie.TabIndex = 9
        '
        'txtEchoLaProstate
        '
        Me.txtEchoLaProstate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEchoLaProstate.Location = New System.Drawing.Point(158, 265)
        Me.txtEchoLaProstate.Name = "txtEchoLaProstate"
        Me.txtEchoLaProstate.Size = New System.Drawing.Size(389, 24)
        Me.txtEchoLaProstate.TabIndex = 8
        '
        'txtEchoLesReins
        '
        Me.txtEchoLesReins.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEchoLesReins.Location = New System.Drawing.Point(158, 234)
        Me.txtEchoLesReins.Name = "txtEchoLesReins"
        Me.txtEchoLesReins.Size = New System.Drawing.Size(389, 24)
        Me.txtEchoLesReins.TabIndex = 7
        '
        'txtEchoLaRate
        '
        Me.txtEchoLaRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEchoLaRate.Location = New System.Drawing.Point(158, 203)
        Me.txtEchoLaRate.Name = "txtEchoLaRate"
        Me.txtEchoLaRate.Size = New System.Drawing.Size(389, 24)
        Me.txtEchoLaRate.TabIndex = 6
        '
        'txtEchoLePancreas
        '
        Me.txtEchoLePancreas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEchoLePancreas.Location = New System.Drawing.Point(159, 172)
        Me.txtEchoLePancreas.Name = "txtEchoLePancreas"
        Me.txtEchoLePancreas.Size = New System.Drawing.Size(389, 24)
        Me.txtEchoLePancreas.TabIndex = 5
        '
        'txtEchoLesVoies
        '
        Me.txtEchoLesVoies.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEchoLesVoies.Location = New System.Drawing.Point(159, 141)
        Me.txtEchoLesVoies.Name = "txtEchoLesVoies"
        Me.txtEchoLesVoies.Size = New System.Drawing.Size(389, 24)
        Me.txtEchoLesVoies.TabIndex = 4
        '
        'txtEchoLaVesicule
        '
        Me.txtEchoLaVesicule.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEchoLaVesicule.Location = New System.Drawing.Point(159, 80)
        Me.txtEchoLaVesicule.Name = "txtEchoLaVesicule"
        Me.txtEchoLaVesicule.Size = New System.Drawing.Size(389, 24)
        Me.txtEchoLaVesicule.TabIndex = 2
        '
        'txtEchoLaVeine
        '
        Me.txtEchoLaVeine.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEchoLaVeine.Location = New System.Drawing.Point(159, 51)
        Me.txtEchoLaVeine.Name = "txtEchoLaVeine"
        Me.txtEchoLaVeine.Size = New System.Drawing.Size(389, 24)
        Me.txtEchoLaVeine.TabIndex = 1
        '
        'txtEchoLeFoie
        '
        Me.txtEchoLeFoie.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEchoLeFoie.Location = New System.Drawing.Point(159, 22)
        Me.txtEchoLeFoie.Name = "txtEchoLeFoie"
        Me.txtEchoLeFoie.Size = New System.Drawing.Size(389, 24)
        Me.txtEchoLeFoie.TabIndex = 0
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(11, 302)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(60, 15)
        Me.Label62.TabIndex = 0
        Me.Label62.Text = "La Vessie"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(12, 271)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(72, 15)
        Me.Label61.TabIndex = 0
        Me.Label61.Text = "La Prostate:"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(12, 240)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(60, 15)
        Me.Label60.TabIndex = 0
        Me.Label60.Text = "Les reins:"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(11, 209)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(48, 15)
        Me.Label59.TabIndex = 0
        Me.Label59.Text = "La rate:"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(10, 178)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(78, 15)
        Me.Label58.TabIndex = 0
        Me.Label58.Text = "Le pancreas:"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(10, 113)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(241, 15)
        Me.Label57.TabIndex = 3
        Me.Label57.Text = "Les voies biliaires intra et extra hepatiques:"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(12, 84)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(112, 15)
        Me.Label56.TabIndex = 0
        Me.Label56.Text = "La vesicule Biliaire:"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(11, 57)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(87, 15)
        Me.Label55.TabIndex = 0
        Me.Label55.Text = "La veine porte:"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(11, 28)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(51, 15)
        Me.Label54.TabIndex = 0
        Me.Label54.Text = "Le Foie:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ConclusionList)
        Me.GroupBox1.Location = New System.Drawing.Point(1138, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(62, 40)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of conclusion"
        Me.GroupBox1.Visible = False
        '
        'ConclusionList
        '
        Me.ConclusionList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        ConclusionList_DesignTimeLayout.LayoutString = resources.GetString("ConclusionList_DesignTimeLayout.LayoutString")
        Me.ConclusionList.DesignTimeLayout = ConclusionList_DesignTimeLayout
        Me.ConclusionList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConclusionList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConclusionList.GroupByBoxVisible = False
        Me.ConclusionList.Location = New System.Drawing.Point(3, 16)
        Me.ConclusionList.Name = "ConclusionList"
        Me.ConclusionList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.ConclusionList.Size = New System.Drawing.Size(56, 21)
        Me.ConclusionList.TabIndex = 0
        Me.ConclusionList.Visible = False
        '
        'ErrAlert
        '
        Me.ErrAlert.ContainerControl = Me
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Location = New System.Drawing.Point(79, 741)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(78, 13)
        Me.lblPatientName.TabIndex = 15
        Me.lblPatientName.Text = "lblPatientName"
        Me.lblPatientName.Visible = False
        '
        'LblPatientNo
        '
        Me.LblPatientNo.AutoSize = True
        Me.LblPatientNo.Location = New System.Drawing.Point(5, 744)
        Me.LblPatientNo.Name = "LblPatientNo"
        Me.LblPatientNo.Size = New System.Drawing.Size(68, 13)
        Me.LblPatientNo.TabIndex = 14
        Me.LblPatientNo.Text = "LblPatientNo"
        Me.LblPatientNo.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnSaveEcho, Me.ToolStripSeparator1, Me.BtnAddImg, Me.ToolStripSeparator2, Me.BtnRemoveImg, Me.ToolStripSeparator3, Me.BtnClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1478, 38)
        Me.ToolStrip1.TabIndex = 17
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnSaveEcho
        '
        Me.BtnSaveEcho.ForeColor = System.Drawing.Color.Blue
        Me.BtnSaveEcho.Image = Global.Clinic_Management_System.My.Resources.Resources.save
        Me.BtnSaveEcho.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSaveEcho.Name = "BtnSaveEcho"
        Me.BtnSaveEcho.Size = New System.Drawing.Size(56, 35)
        Me.BtnSaveEcho.Text = "   Save    "
        Me.BtnSaveEcho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 38)
        '
        'BtnAddImg
        '
        Me.BtnAddImg.ForeColor = System.Drawing.Color.Blue
        Me.BtnAddImg.Image = Global.Clinic_Management_System.My.Resources.Resources.db_add
        Me.BtnAddImg.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAddImg.Name = "BtnAddImg"
        Me.BtnAddImg.Size = New System.Drawing.Size(69, 35)
        Me.BtnAddImg.Text = "Add Image"
        Me.BtnAddImg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 38)
        '
        'BtnRemoveImg
        '
        Me.BtnRemoveImg.ForeColor = System.Drawing.Color.Blue
        Me.BtnRemoveImg.Image = Global.Clinic_Management_System.My.Resources.Resources.delete_appointment
        Me.BtnRemoveImg.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRemoveImg.Name = "BtnRemoveImg"
        Me.BtnRemoveImg.Size = New System.Drawing.Size(90, 35)
        Me.BtnRemoveImg.Text = "Remove Image"
        Me.BtnRemoveImg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 38)
        '
        'BtnClose
        '
        Me.BtnClose.ForeColor = System.Drawing.Color.Blue
        Me.BtnClose.Image = Global.Clinic_Management_System.My.Resources.Resources.cancel
        Me.BtnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(40, 35)
        Me.BtnClose.Text = "Close"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer2.Size = New System.Drawing.Size(1463, 329)
        Me.SplitContainer2.SplitterDistance = 566
        Me.SplitContainer2.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GridImage)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(893, 329)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Image Echo"
        '
        'GridImage
        '
        Me.GridImage.CardHeaders = False
        GridImage_DesignTimeLayout.LayoutString = resources.GetString("GridImage_DesignTimeLayout.LayoutString")
        Me.GridImage.DesignTimeLayout = GridImage_DesignTimeLayout
        Me.GridImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridImage.GroupByBoxVisible = False
        Me.GridImage.Location = New System.Drawing.Point(3, 22)
        Me.GridImage.Name = "GridImage"
        Me.GridImage.Size = New System.Drawing.Size(887, 304)
        Me.GridImage.TabIndex = 0
        Me.GridImage.View = Janus.Windows.GridEX.View.CardView
        '
        'FormResultEcho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1478, 766)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lblPatientName)
        Me.Controls.Add(Me.LblPatientNo)
        Me.Controls.Add(Me.GroupBox18)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormResultEcho"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Result Echo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox18.ResumeLayout(False)
        Me.GroupBox18.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ConclusionList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrAlert, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.GridImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEchoIndication As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox18 As System.Windows.Forms.GroupBox
    Friend WithEvents cboEchoConclusion As System.Windows.Forms.ComboBox
    Friend WithEvents txtEchoLaVessie As System.Windows.Forms.TextBox
    Friend WithEvents txtEchoLaProstate As System.Windows.Forms.TextBox
    Friend WithEvents txtEchoLesReins As System.Windows.Forms.TextBox
    Friend WithEvents txtEchoLaRate As System.Windows.Forms.TextBox
    Friend WithEvents txtEchoLePancreas As System.Windows.Forms.TextBox
    Friend WithEvents txtEchoLesVoies As System.Windows.Forms.TextBox
    Friend WithEvents txtEchoLaVesicule As System.Windows.Forms.TextBox
    Friend WithEvents txtEchoLaVeine As System.Windows.Forms.TextBox
    Friend WithEvents txtEchoLeFoie As System.Windows.Forms.TextBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents cboEchoDemander As System.Windows.Forms.ComboBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtechomoreinfo As System.Windows.Forms.TextBox
    Friend WithEvents BtnRemoveConclusion As System.Windows.Forms.Button
    Friend WithEvents BtnAddConclusion As System.Windows.Forms.Button
    Friend WithEvents ConclusionList As Janus.Windows.GridEX.GridEX
    Friend WithEvents ErrAlert As System.Windows.Forms.ErrorProvider
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtResult As System.Windows.Forms.TextBox
    Friend WithEvents DateResultExam As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblPatientName As System.Windows.Forms.Label
    Friend WithEvents LblPatientNo As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboDoctorExam As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnSaveEcho As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnAddImg As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRemoveImg As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GridImage As Janus.Windows.GridEX.GridEX
End Class
