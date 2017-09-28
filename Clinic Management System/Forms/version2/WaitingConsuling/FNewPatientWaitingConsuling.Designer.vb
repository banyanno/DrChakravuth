<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FNewPatientWaitingConsuling
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
        Dim GridPreComplaint_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FNewPatientWaitingConsuling))
        Dim GridPreMedicalHistory_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridPrePhysical_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnParaExamHistory = New System.Windows.Forms.Button
        Me.BtnExam = New System.Windows.Forms.Button
        Me.BtnMedical = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtno = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.txtdatebirth = New System.Windows.Forms.TextBox
        Me.txtsex = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dtwaiting = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtdesc = New System.Windows.Forms.TextBox
        Me.txtwaitno = New System.Windows.Forms.TextBox
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.Err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.MedicalHistory = New System.Windows.Forms.TabPage
        Me.CRPatientDocViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.GridPreComplaint = New Janus.Windows.GridEX.GridEX
        Me.BtnRemovePreComplaint = New System.Windows.Forms.Button
        Me.BtnAddPreComplaint = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.TxtComplainDescription = New System.Windows.Forms.TextBox
        Me.CboComplaint = New System.Windows.Forms.ComboBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.GridPreMedicalHistory = New Janus.Windows.GridEX.GridEX
        Me.BtnRemoveMedicalHistory = New System.Windows.Forms.Button
        Me.BtnAddMedicalHistor = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtMedicalNote = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.CboMedical = New System.Windows.Forms.ComboBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.GridPrePhysical = New Janus.Windows.GridEX.GridEX
        Me.BtnRemovePrePhysical = New System.Windows.Forms.Button
        Me.BtnAddPrePhysical = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.TxtPhysicalNote = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.CboPhysicalExam = New System.Windows.Forms.ComboBox
        Me.BgLoadingPatient = New System.ComponentModel.BackgroundWorker
        Me.AutocompleteMenu1 = New AutocompleteMenuNS.AutocompleteMenu
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.MedicalHistory.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.GridPreComplaint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.GridPreMedicalHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.GridPrePhysical, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BtnParaExamHistory)
        Me.GroupBox1.Controls.Add(Me.BtnExam)
        Me.GroupBox1.Controls.Add(Me.BtnMedical)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtno)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.txtaddress)
        Me.GroupBox1.Controls.Add(Me.txtdatebirth)
        Me.GroupBox1.Controls.Add(Me.txtsex)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1157, 145)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Information"
        '
        'BtnParaExamHistory
        '
        Me.BtnParaExamHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnParaExamHistory.Location = New System.Drawing.Point(610, 101)
        Me.BtnParaExamHistory.Name = "BtnParaExamHistory"
        Me.BtnParaExamHistory.Size = New System.Drawing.Size(194, 33)
        Me.BtnParaExamHistory.TabIndex = 47
        Me.BtnParaExamHistory.Text = "Para Exam History"
        Me.BtnParaExamHistory.UseVisualStyleBackColor = True
        '
        'BtnExam
        '
        Me.BtnExam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExam.Location = New System.Drawing.Point(610, 62)
        Me.BtnExam.Name = "BtnExam"
        Me.BtnExam.Size = New System.Drawing.Size(194, 33)
        Me.BtnExam.TabIndex = 46
        Me.BtnExam.Text = "Para Exam"
        Me.BtnExam.UseVisualStyleBackColor = True
        '
        'BtnMedical
        '
        Me.BtnMedical.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMedical.Location = New System.Drawing.Point(610, 20)
        Me.BtnMedical.Name = "BtnMedical"
        Me.BtnMedical.Size = New System.Drawing.Size(194, 35)
        Me.BtnMedical.TabIndex = 45
        Me.BtnMedical.Text = "Medical History"
        Me.BtnMedical.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(53, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 14)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Address:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(356, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 14)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Gender:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(325, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 14)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Date of Birth:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 14)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Full Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 14)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Patient No:"
        '
        'txtno
        '
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.txtno, Nothing)
        Me.txtno.BackColor = System.Drawing.Color.White
        Me.txtno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtno.Location = New System.Drawing.Point(117, 26)
        Me.txtno.Name = "txtno"
        Me.txtno.ReadOnly = True
        Me.txtno.Size = New System.Drawing.Size(194, 26)
        Me.txtno.TabIndex = 30
        '
        'txtname
        '
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.txtname, Nothing)
        Me.txtname.BackColor = System.Drawing.Color.White
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(117, 66)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(195, 26)
        Me.txtname.TabIndex = 33
        '
        'txtaddress
        '
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.txtaddress, Nothing)
        Me.txtaddress.BackColor = System.Drawing.Color.White
        Me.txtaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(117, 106)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.ReadOnly = True
        Me.txtaddress.Size = New System.Drawing.Size(475, 26)
        Me.txtaddress.TabIndex = 34
        '
        'txtdatebirth
        '
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.txtdatebirth, Nothing)
        Me.txtdatebirth.BackColor = System.Drawing.Color.White
        Me.txtdatebirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdatebirth.Location = New System.Drawing.Point(417, 31)
        Me.txtdatebirth.Name = "txtdatebirth"
        Me.txtdatebirth.ReadOnly = True
        Me.txtdatebirth.Size = New System.Drawing.Size(175, 26)
        Me.txtdatebirth.TabIndex = 31
        '
        'txtsex
        '
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.txtsex, Nothing)
        Me.txtsex.BackColor = System.Drawing.Color.White
        Me.txtsex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsex.Location = New System.Drawing.Point(417, 71)
        Me.txtsex.Name = "txtsex"
        Me.txtsex.ReadOnly = True
        Me.txtsex.Size = New System.Drawing.Size(175, 26)
        Me.txtsex.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(350, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Waitnig No:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Description:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dtwaiting)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtdesc)
        Me.GroupBox2.Controls.Add(Me.txtwaitno)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 160)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1157, 128)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Waiting Information"
        '
        'dtwaiting
        '
        Me.dtwaiting.CustomFormat = "dd/MM/yyyy"
        Me.dtwaiting.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtwaiting.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtwaiting.Location = New System.Drawing.Point(117, 29)
        Me.dtwaiting.Name = "dtwaiting"
        Me.dtwaiting.Size = New System.Drawing.Size(200, 26)
        Me.dtwaiting.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 14)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Waiting Date:"
        '
        'txtdesc
        '
        Me.txtdesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.txtdesc, Me.AutocompleteMenu1)
        Me.txtdesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesc.Location = New System.Drawing.Point(117, 73)
        Me.txtdesc.Multiline = True
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(1027, 39)
        Me.txtdesc.TabIndex = 4
        '
        'txtwaitno
        '
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.txtwaitno, Nothing)
        Me.txtwaitno.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtwaitno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtwaitno.Location = New System.Drawing.Point(432, 31)
        Me.txtwaitno.MaxLength = 10
        Me.txtwaitno.Name = "txtwaitno"
        Me.txtwaitno.Size = New System.Drawing.Size(84, 26)
        Me.txtwaitno.TabIndex = 3
        Me.txtwaitno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSave.Location = New System.Drawing.Point(954, 667)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(114, 30)
        Me.BtnSave.TabIndex = 4
        Me.BtnSave.Text = "Send Patient"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnCancel.Location = New System.Drawing.Point(1074, 667)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(83, 30)
        Me.BtnCancel.TabIndex = 5
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'Err
        '
        Me.Err.ContainerControl = Me
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.TabControl1)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 292)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1157, 369)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Consultation Information"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.MedicalHistory)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 19)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1151, 347)
        Me.TabControl1.TabIndex = 0
        '
        'MedicalHistory
        '
        Me.MedicalHistory.Controls.Add(Me.CRPatientDocViewer)
        Me.MedicalHistory.Location = New System.Drawing.Point(4, 25)
        Me.MedicalHistory.Name = "MedicalHistory"
        Me.MedicalHistory.Padding = New System.Windows.Forms.Padding(3)
        Me.MedicalHistory.Size = New System.Drawing.Size(1143, 318)
        Me.MedicalHistory.TabIndex = 3
        Me.MedicalHistory.Text = "Medical History"
        Me.MedicalHistory.UseVisualStyleBackColor = True
        '
        'CRPatientDocViewer
        '
        Me.CRPatientDocViewer.ActiveViewIndex = -1
        Me.CRPatientDocViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRPatientDocViewer.DisplayGroupTree = False
        Me.CRPatientDocViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRPatientDocViewer.Location = New System.Drawing.Point(3, 3)
        Me.CRPatientDocViewer.Name = "CRPatientDocViewer"
        Me.CRPatientDocViewer.SelectionFormula = ""
        Me.CRPatientDocViewer.ShowCloseButton = False
        Me.CRPatientDocViewer.ShowGroupTreeButton = False
        Me.CRPatientDocViewer.Size = New System.Drawing.Size(1137, 312)
        Me.CRPatientDocViewer.TabIndex = 1
        Me.CRPatientDocViewer.ViewTimeSelectionFormula = ""
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.GroupBox10)
        Me.TabPage1.Controls.Add(Me.BtnRemovePreComplaint)
        Me.TabPage1.Controls.Add(Me.BtnAddPreComplaint)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.TxtComplainDescription)
        Me.TabPage1.Controls.Add(Me.CboComplaint)
        Me.TabPage1.ForeColor = System.Drawing.Color.Blue
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1143, 318)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "   Patient Complaint   "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox10.Controls.Add(Me.GridPreComplaint)
        Me.GroupBox10.Location = New System.Drawing.Point(6, 47)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(477, 256)
        Me.GroupBox10.TabIndex = 39
        Me.GroupBox10.TabStop = False
        '
        'GridPreComplaint
        '
        GridPreComplaint_DesignTimeLayout.LayoutString = resources.GetString("GridPreComplaint_DesignTimeLayout.LayoutString")
        Me.GridPreComplaint.DesignTimeLayout = GridPreComplaint_DesignTimeLayout
        Me.GridPreComplaint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPreComplaint.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GridPreComplaint.GroupByBoxVisible = False
        Me.GridPreComplaint.Location = New System.Drawing.Point(3, 19)
        Me.GridPreComplaint.Name = "GridPreComplaint"
        Me.GridPreComplaint.RecordNavigator = True
        Me.GridPreComplaint.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridPreComplaint.Size = New System.Drawing.Size(471, 234)
        Me.GridPreComplaint.TabIndex = 1
        '
        'BtnRemovePreComplaint
        '
        Me.BtnRemovePreComplaint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemovePreComplaint.Location = New System.Drawing.Point(558, 17)
        Me.BtnRemovePreComplaint.Name = "BtnRemovePreComplaint"
        Me.BtnRemovePreComplaint.Size = New System.Drawing.Size(57, 23)
        Me.BtnRemovePreComplaint.TabIndex = 38
        Me.BtnRemovePreComplaint.Text = "-"
        Me.BtnRemovePreComplaint.UseVisualStyleBackColor = True
        '
        'BtnAddPreComplaint
        '
        Me.BtnAddPreComplaint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddPreComplaint.Location = New System.Drawing.Point(492, 17)
        Me.BtnAddPreComplaint.Name = "BtnAddPreComplaint"
        Me.BtnAddPreComplaint.Size = New System.Drawing.Size(57, 23)
        Me.BtnAddPreComplaint.TabIndex = 37
        Me.BtnAddPreComplaint.Text = "+"
        Me.BtnAddPreComplaint.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(489, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 16)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Note:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(16, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 16)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Complaint:"
        '
        'TxtComplainDescription
        '
        Me.TxtComplainDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.TxtComplainDescription, Me.AutocompleteMenu1)
        Me.TxtComplainDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtComplainDescription.Location = New System.Drawing.Point(492, 70)
        Me.TxtComplainDescription.Multiline = True
        Me.TxtComplainDescription.Name = "TxtComplainDescription"
        Me.TxtComplainDescription.Size = New System.Drawing.Size(645, 233)
        Me.TxtComplainDescription.TabIndex = 5
        '
        'CboComplaint
        '
        Me.CboComplaint.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboComplaint.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboComplaint.DropDownWidth = 500
        Me.CboComplaint.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboComplaint.Location = New System.Drawing.Point(100, 15)
        Me.CboComplaint.Name = "CboComplaint"
        Me.CboComplaint.Size = New System.Drawing.Size(380, 25)
        Me.CboComplaint.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.Controls.Add(Me.GroupBox8)
        Me.TabPage2.Controls.Add(Me.BtnRemoveMedicalHistory)
        Me.TabPage2.Controls.Add(Me.BtnAddMedicalHistor)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.TxtMedicalNote)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.CboMedical)
        Me.TabPage2.ForeColor = System.Drawing.Color.Blue
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1143, 318)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "    Medical History   "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox8.Controls.Add(Me.GridPreMedicalHistory)
        Me.GroupBox8.Location = New System.Drawing.Point(3, 46)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(455, 263)
        Me.GroupBox8.TabIndex = 38
        Me.GroupBox8.TabStop = False
        '
        'GridPreMedicalHistory
        '
        GridPreMedicalHistory_DesignTimeLayout.LayoutString = resources.GetString("GridPreMedicalHistory_DesignTimeLayout.LayoutString")
        Me.GridPreMedicalHistory.DesignTimeLayout = GridPreMedicalHistory_DesignTimeLayout
        Me.GridPreMedicalHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPreMedicalHistory.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GridPreMedicalHistory.GroupByBoxVisible = False
        Me.GridPreMedicalHistory.Location = New System.Drawing.Point(3, 19)
        Me.GridPreMedicalHistory.Name = "GridPreMedicalHistory"
        Me.GridPreMedicalHistory.RecordNavigator = True
        Me.GridPreMedicalHistory.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridPreMedicalHistory.Size = New System.Drawing.Size(449, 241)
        Me.GridPreMedicalHistory.TabIndex = 1
        '
        'BtnRemoveMedicalHistory
        '
        Me.BtnRemoveMedicalHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemoveMedicalHistory.Location = New System.Drawing.Point(533, 20)
        Me.BtnRemoveMedicalHistory.Name = "BtnRemoveMedicalHistory"
        Me.BtnRemoveMedicalHistory.Size = New System.Drawing.Size(57, 23)
        Me.BtnRemoveMedicalHistory.TabIndex = 37
        Me.BtnRemoveMedicalHistory.Text = "-"
        Me.BtnRemoveMedicalHistory.UseVisualStyleBackColor = True
        '
        'BtnAddMedicalHistor
        '
        Me.BtnAddMedicalHistor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddMedicalHistor.Location = New System.Drawing.Point(467, 20)
        Me.BtnAddMedicalHistor.Name = "BtnAddMedicalHistor"
        Me.BtnAddMedicalHistor.Size = New System.Drawing.Size(57, 23)
        Me.BtnAddMedicalHistor.TabIndex = 36
        Me.BtnAddMedicalHistor.Text = "+"
        Me.BtnAddMedicalHistor.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(464, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 16)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Note:"
        '
        'TxtMedicalNote
        '
        Me.TxtMedicalNote.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.TxtMedicalNote, Me.AutocompleteMenu1)
        Me.TxtMedicalNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMedicalNote.Location = New System.Drawing.Point(467, 75)
        Me.TxtMedicalNote.Multiline = True
        Me.TxtMedicalNote.Name = "TxtMedicalNote"
        Me.TxtMedicalNote.Size = New System.Drawing.Size(670, 234)
        Me.TxtMedicalNote.TabIndex = 34
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(34, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 16)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "History:"
        '
        'CboMedical
        '
        Me.CboMedical.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboMedical.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboMedical.DropDownWidth = 500
        Me.CboMedical.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMedical.Location = New System.Drawing.Point(100, 15)
        Me.CboMedical.Name = "CboMedical"
        Me.CboMedical.Size = New System.Drawing.Size(361, 25)
        Me.CboMedical.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Transparent
        Me.TabPage3.Controls.Add(Me.GroupBox9)
        Me.TabPage3.Controls.Add(Me.BtnRemovePrePhysical)
        Me.TabPage3.Controls.Add(Me.BtnAddPrePhysical)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.TxtPhysicalNote)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.CboPhysicalExam)
        Me.TabPage3.ForeColor = System.Drawing.Color.Blue
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1143, 318)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "   Physical Exam   "
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox9.Controls.Add(Me.GridPrePhysical)
        Me.GroupBox9.Location = New System.Drawing.Point(6, 59)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(545, 252)
        Me.GroupBox9.TabIndex = 42
        Me.GroupBox9.TabStop = False
        '
        'GridPrePhysical
        '
        Me.GridPrePhysical.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridPrePhysical_DesignTimeLayout.LayoutString = resources.GetString("GridPrePhysical_DesignTimeLayout.LayoutString")
        Me.GridPrePhysical.DesignTimeLayout = GridPrePhysical_DesignTimeLayout
        Me.GridPrePhysical.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPrePhysical.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GridPrePhysical.GroupByBoxVisible = False
        Me.GridPrePhysical.Location = New System.Drawing.Point(3, 19)
        Me.GridPrePhysical.Name = "GridPrePhysical"
        Me.GridPrePhysical.RecordNavigator = True
        Me.GridPrePhysical.Size = New System.Drawing.Size(539, 230)
        Me.GridPrePhysical.TabIndex = 0
        '
        'BtnRemovePrePhysical
        '
        Me.BtnRemovePrePhysical.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemovePrePhysical.Location = New System.Drawing.Point(623, 17)
        Me.BtnRemovePrePhysical.Name = "BtnRemovePrePhysical"
        Me.BtnRemovePrePhysical.Size = New System.Drawing.Size(57, 23)
        Me.BtnRemovePrePhysical.TabIndex = 41
        Me.BtnRemovePrePhysical.Text = "-"
        Me.BtnRemovePrePhysical.UseVisualStyleBackColor = True
        '
        'BtnAddPrePhysical
        '
        Me.BtnAddPrePhysical.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddPrePhysical.Location = New System.Drawing.Point(560, 17)
        Me.BtnAddPrePhysical.Name = "BtnAddPrePhysical"
        Me.BtnAddPrePhysical.Size = New System.Drawing.Size(57, 23)
        Me.BtnAddPrePhysical.TabIndex = 40
        Me.BtnAddPrePhysical.Text = "+"
        Me.BtnAddPrePhysical.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(557, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 16)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Note:"
        '
        'TxtPhysicalNote
        '
        Me.TxtPhysicalNote.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.TxtPhysicalNote, Me.AutocompleteMenu1)
        Me.TxtPhysicalNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPhysicalNote.Location = New System.Drawing.Point(560, 66)
        Me.TxtPhysicalNote.Multiline = True
        Me.TxtPhysicalNote.Name = "TxtPhysicalNote"
        Me.TxtPhysicalNote.Size = New System.Drawing.Size(577, 239)
        Me.TxtPhysicalNote.TabIndex = 38
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(8, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 16)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Physical Exam:"
        '
        'CboPhysicalExam
        '
        Me.CboPhysicalExam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboPhysicalExam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboPhysicalExam.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboPhysicalExam.Location = New System.Drawing.Point(120, 15)
        Me.CboPhysicalExam.Name = "CboPhysicalExam"
        Me.CboPhysicalExam.Size = New System.Drawing.Size(434, 25)
        Me.CboPhysicalExam.TabIndex = 36
        '
        'BgLoadingPatient
        '
        '
        'AutocompleteMenu1
        '
        Me.AutocompleteMenu1.AppearInterval = 50
        Me.AutocompleteMenu1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.AutocompleteMenu1.ImageList = Nothing
        Me.AutocompleteMenu1.Items = New String(-1) {}
        Me.AutocompleteMenu1.MinFragmentLength = 1
        Me.AutocompleteMenu1.TargetControlWrapper = Nothing
        '
        'FNewPatientWaitingConsuling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1174, 704)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FNewPatientWaitingConsuling"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New patient waiting"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.MedicalHistory.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        CType(Me.GridPreComplaint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.GridPreMedicalHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.GridPrePhysical, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents txtwaitno As System.Windows.Forms.TextBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents txtno As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtdatebirth As System.Windows.Forms.TextBox
    Friend WithEvents txtsex As System.Windows.Forms.TextBox
    Friend WithEvents dtwaiting As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Err As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents CboComplaint As System.Windows.Forms.ComboBox
    Friend WithEvents TxtComplainDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtMedicalNote As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CboMedical As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtPhysicalNote As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CboPhysicalExam As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MedicalHistory As System.Windows.Forms.TabPage
    Friend WithEvents CRPatientDocViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BtnMedical As System.Windows.Forms.Button
    Friend WithEvents BgLoadingPatient As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnExam As System.Windows.Forms.Button
    Friend WithEvents BtnParaExamHistory As System.Windows.Forms.Button
    Friend WithEvents AutocompleteMenu1 As AutocompleteMenuNS.AutocompleteMenu
    Friend WithEvents BtnRemoveMedicalHistory As System.Windows.Forms.Button
    Friend WithEvents BtnAddMedicalHistor As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents GridPreMedicalHistory As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnRemovePreComplaint As System.Windows.Forms.Button
    Friend WithEvents BtnAddPreComplaint As System.Windows.Forms.Button
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents GridPreComplaint As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnRemovePrePhysical As System.Windows.Forms.Button
    Friend WithEvents BtnAddPrePhysical As System.Windows.Forms.Button
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents GridPrePhysical As Janus.Windows.GridEX.GridEX
End Class
