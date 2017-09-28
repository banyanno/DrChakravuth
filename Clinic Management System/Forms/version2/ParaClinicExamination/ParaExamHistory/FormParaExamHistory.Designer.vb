<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormParaExamHistory
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
        Dim BloodResultList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormParaExamHistory))
        Dim FibroConclusionList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim NasoConclusionList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim ColoConclusionList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim EchoConclusionList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.BtnSave = New System.Windows.Forms.Button
        Me.Cancel = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CboDiagnosis = New System.Windows.Forms.ComboBox
        Me.LblRequestID = New System.Windows.Forms.Label
        Me.BtnFindPatient = New System.Windows.Forms.Button
        Me.lblpatientid = New System.Windows.Forms.Label
        Me.txtno = New System.Windows.Forms.TextBox
        Me.dtrequest = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.txtdatebirth = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtsex = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.BloodChecked = New System.Windows.Forms.TabPage
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtBloodResult = New System.Windows.Forms.TextBox
        Me.BloodResultList = New Janus.Windows.GridEX.GridEX
        Me.btnDeleteItem = New System.Windows.Forms.Button
        Me.cboitem = New System.Windows.Forms.ComboBox
        Me.btnAddItem = New System.Windows.Forms.Button
        Me.Fibroscopy = New System.Windows.Forms.TabPage
        Me.cboFibroConclusion = New System.Windows.Forms.ComboBox
        Me.BtnRemoveFibroConclusion = New System.Windows.Forms.Button
        Me.BtnAddFibroConclusion = New System.Windows.Forms.Button
        Me.ConclusionGroup = New System.Windows.Forms.GroupBox
        Me.FibroConclusionList = New Janus.Windows.GridEX.GridEX
        Me.Label26 = New System.Windows.Forms.Label
        Me.Nasogastro = New System.Windows.Forms.TabPage
        Me.BtnRemoveNasoConclusion = New System.Windows.Forms.Button
        Me.BtnAddNasoConclusion = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.NasoConclusionList = New Janus.Windows.GridEX.GridEX
        Me.Label27 = New System.Windows.Forms.Label
        Me.cboNasoConclusion = New System.Windows.Forms.ComboBox
        Me.Coloscopy = New System.Windows.Forms.TabPage
        Me.cboColoConclusion = New System.Windows.Forms.ComboBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.ColoConclusionList = New Janus.Windows.GridEX.GridEX
        Me.BtnRemoveColoConclusion = New System.Windows.Forms.Button
        Me.BtnAddColoConclusion = New System.Windows.Forms.Button
        Me.Label42 = New System.Windows.Forms.Label
        Me.Echo = New System.Windows.Forms.TabPage
        Me.txtechomoreinfo = New System.Windows.Forms.TextBox
        Me.BtnRemoveEchoConclusion = New System.Windows.Forms.Button
        Me.BtnAddEchoConclusion = New System.Windows.Forms.Button
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.EchoConclusionList = New Janus.Windows.GridEX.GridEX
        Me.cboEchoConclusion = New System.Windows.Forms.ComboBox
        Me.Label63 = New System.Windows.Forms.Label
        Me.Scan = New System.Windows.Forms.TabPage
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txtScan = New System.Windows.Forms.TextBox
        Me.MRI = New System.Windows.Forms.TabPage
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.txtmri = New System.Windows.Forms.TextBox
        Me.FibroScan = New System.Windows.Forms.TabPage
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.txtfibroscan = New System.Windows.Forms.TextBox
        Me.CFAnapath = New System.Windows.Forms.TabPage
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.TxtCFAnapath = New System.Windows.Forms.TextBox
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.BloodChecked.SuspendLayout()
        CType(Me.BloodResultList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Fibroscopy.SuspendLayout()
        Me.ConclusionGroup.SuspendLayout()
        CType(Me.FibroConclusionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Nasogastro.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NasoConclusionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Coloscopy.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ColoConclusionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Echo.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.EchoConclusionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Scan.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.MRI.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.FibroScan.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.CFAnapath.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(817, 593)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(91, 31)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancel.Location = New System.Drawing.Point(914, 593)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(91, 31)
        Me.Cancel.TabIndex = 2
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.CboDiagnosis)
        Me.GroupBox2.Controls.Add(Me.LblRequestID)
        Me.GroupBox2.Controls.Add(Me.BtnFindPatient)
        Me.GroupBox2.Controls.Add(Me.lblpatientid)
        Me.GroupBox2.Controls.Add(Me.txtno)
        Me.GroupBox2.Controls.Add(Me.dtrequest)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtname)
        Me.GroupBox2.Controls.Add(Me.txtaddress)
        Me.GroupBox2.Controls.Add(Me.txtdatebirth)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtsex)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1001, 129)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Patient Information"
        '
        'CboDiagnosis
        '
        Me.CboDiagnosis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDiagnosis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDiagnosis.FormattingEnabled = True
        Me.CboDiagnosis.Location = New System.Drawing.Point(755, 91)
        Me.CboDiagnosis.Name = "CboDiagnosis"
        Me.CboDiagnosis.Size = New System.Drawing.Size(232, 28)
        Me.CboDiagnosis.TabIndex = 43
        '
        'LblRequestID
        '
        Me.LblRequestID.AutoSize = True
        Me.LblRequestID.Location = New System.Drawing.Point(725, 35)
        Me.LblRequestID.Name = "LblRequestID"
        Me.LblRequestID.Size = New System.Drawing.Size(13, 13)
        Me.LblRequestID.TabIndex = 42
        Me.LblRequestID.Text = "0"
        Me.LblRequestID.Visible = False
        '
        'BtnFindPatient
        '
        Me.BtnFindPatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFindPatient.Location = New System.Drawing.Point(314, 26)
        Me.BtnFindPatient.Name = "BtnFindPatient"
        Me.BtnFindPatient.Size = New System.Drawing.Size(39, 24)
        Me.BtnFindPatient.TabIndex = 41
        Me.BtnFindPatient.Text = "..."
        Me.BtnFindPatient.UseVisualStyleBackColor = True
        Me.BtnFindPatient.Visible = False
        '
        'lblpatientid
        '
        Me.lblpatientid.AutoSize = True
        Me.lblpatientid.Location = New System.Drawing.Point(598, 33)
        Me.lblpatientid.Name = "lblpatientid"
        Me.lblpatientid.Size = New System.Drawing.Size(47, 13)
        Me.lblpatientid.TabIndex = 40
        Me.lblpatientid.Text = "patientid"
        Me.lblpatientid.Visible = False
        '
        'txtno
        '
        Me.txtno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtno.Location = New System.Drawing.Point(116, 26)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(194, 24)
        Me.txtno.TabIndex = 0
        '
        'dtrequest
        '
        Me.dtrequest.CustomFormat = "dd/MM/yyyy"
        Me.dtrequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtrequest.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtrequest.Location = New System.Drawing.Point(601, 93)
        Me.dtrequest.Name = "dtrequest"
        Me.dtrequest.Size = New System.Drawing.Size(148, 26)
        Me.dtrequest.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(597, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Examination Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Khmer OS System", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(61, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 27)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "ឈ្មោះ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(17, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 30)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "លេខសំគាល់"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.White
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtname.Location = New System.Drawing.Point(117, 58)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(195, 24)
        Me.txtname.TabIndex = 2
        '
        'txtaddress
        '
        Me.txtaddress.BackColor = System.Drawing.Color.White
        Me.txtaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtaddress.Location = New System.Drawing.Point(117, 95)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.ReadOnly = True
        Me.txtaddress.Size = New System.Drawing.Size(460, 24)
        Me.txtaddress.TabIndex = 4
        '
        'txtdatebirth
        '
        Me.txtdatebirth.BackColor = System.Drawing.Color.White
        Me.txtdatebirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtdatebirth.Location = New System.Drawing.Point(483, 26)
        Me.txtdatebirth.Name = "txtdatebirth"
        Me.txtdatebirth.ReadOnly = True
        Me.txtdatebirth.Size = New System.Drawing.Size(94, 24)
        Me.txtdatebirth.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Khmer OS System", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(362, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 27)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "ថ្ងៃខែឆ្នាំ កំណើត"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtsex
        '
        Me.txtsex.BackColor = System.Drawing.Color.White
        Me.txtsex.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtsex.Location = New System.Drawing.Point(483, 56)
        Me.txtsex.Name = "txtsex"
        Me.txtsex.ReadOnly = True
        Me.txtsex.Size = New System.Drawing.Size(94, 24)
        Me.txtsex.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Khmer OS System", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(23, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 27)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "អាស័យដ្ឋាន"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(436, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 30)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "ភេទ"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.TabControl1)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 152)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1001, 435)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Request Examination:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.BloodChecked)
        Me.TabControl1.Controls.Add(Me.Fibroscopy)
        Me.TabControl1.Controls.Add(Me.Nasogastro)
        Me.TabControl1.Controls.Add(Me.Coloscopy)
        Me.TabControl1.Controls.Add(Me.Echo)
        Me.TabControl1.Controls.Add(Me.Scan)
        Me.TabControl1.Controls.Add(Me.MRI)
        Me.TabControl1.Controls.Add(Me.FibroScan)
        Me.TabControl1.Controls.Add(Me.CFAnapath)
        Me.TabControl1.Location = New System.Drawing.Point(6, 18)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(991, 411)
        Me.TabControl1.TabIndex = 7
        '
        'BloodChecked
        '
        Me.BloodChecked.Controls.Add(Me.Label8)
        Me.BloodChecked.Controls.Add(Me.Label1)
        Me.BloodChecked.Controls.Add(Me.TxtBloodResult)
        Me.BloodChecked.Controls.Add(Me.BloodResultList)
        Me.BloodChecked.Controls.Add(Me.btnDeleteItem)
        Me.BloodChecked.Controls.Add(Me.cboitem)
        Me.BloodChecked.Controls.Add(Me.btnAddItem)
        Me.BloodChecked.Location = New System.Drawing.Point(4, 22)
        Me.BloodChecked.Name = "BloodChecked"
        Me.BloodChecked.Padding = New System.Windows.Forms.Padding(3)
        Me.BloodChecked.Size = New System.Drawing.Size(983, 385)
        Me.BloodChecked.TabIndex = 0
        Me.BloodChecked.Text = "Blood Checked"
        Me.BloodChecked.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(354, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Result:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Blood Check:"
        '
        'TxtBloodResult
        '
        Me.TxtBloodResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBloodResult.Location = New System.Drawing.Point(400, 14)
        Me.TxtBloodResult.Name = "TxtBloodResult"
        Me.TxtBloodResult.Size = New System.Drawing.Size(216, 26)
        Me.TxtBloodResult.TabIndex = 4
        '
        'BloodResultList
        '
        Me.BloodResultList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.BloodResultList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        BloodResultList_DesignTimeLayout.LayoutString = resources.GetString("BloodResultList_DesignTimeLayout.LayoutString")
        Me.BloodResultList.DesignTimeLayout = BloodResultList_DesignTimeLayout
        Me.BloodResultList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BloodResultList.GroupByBoxVisible = False
        Me.BloodResultList.HeaderFormatStyle.FontSize = 10.0!
        Me.BloodResultList.Location = New System.Drawing.Point(6, 49)
        Me.BloodResultList.Name = "BloodResultList"
        Me.BloodResultList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.BloodResultList.Size = New System.Drawing.Size(971, 330)
        Me.BloodResultList.TabIndex = 3
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteItem.Location = New System.Drawing.Point(683, 14)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(43, 26)
        Me.btnDeleteItem.TabIndex = 2
        Me.btnDeleteItem.Text = "-"
        Me.btnDeleteItem.UseVisualStyleBackColor = True
        '
        'cboitem
        '
        Me.cboitem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboitem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboitem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboitem.FormattingEnabled = True
        Me.cboitem.Location = New System.Drawing.Point(91, 12)
        Me.cboitem.Name = "cboitem"
        Me.cboitem.Size = New System.Drawing.Size(252, 28)
        Me.cboitem.TabIndex = 0
        '
        'btnAddItem
        '
        Me.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddItem.Location = New System.Drawing.Point(633, 14)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(43, 26)
        Me.btnAddItem.TabIndex = 1
        Me.btnAddItem.Text = "+"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'Fibroscopy
        '
        Me.Fibroscopy.Controls.Add(Me.cboFibroConclusion)
        Me.Fibroscopy.Controls.Add(Me.BtnRemoveFibroConclusion)
        Me.Fibroscopy.Controls.Add(Me.BtnAddFibroConclusion)
        Me.Fibroscopy.Controls.Add(Me.ConclusionGroup)
        Me.Fibroscopy.Controls.Add(Me.Label26)
        Me.Fibroscopy.Location = New System.Drawing.Point(4, 22)
        Me.Fibroscopy.Name = "Fibroscopy"
        Me.Fibroscopy.Padding = New System.Windows.Forms.Padding(3)
        Me.Fibroscopy.Size = New System.Drawing.Size(983, 385)
        Me.Fibroscopy.TabIndex = 1
        Me.Fibroscopy.Text = "Fibroscopy"
        Me.Fibroscopy.UseVisualStyleBackColor = True
        '
        'cboFibroConclusion
        '
        Me.cboFibroConclusion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboFibroConclusion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboFibroConclusion.DropDownWidth = 300
        Me.cboFibroConclusion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFibroConclusion.FormattingEnabled = True
        Me.cboFibroConclusion.Location = New System.Drawing.Point(92, 17)
        Me.cboFibroConclusion.Name = "cboFibroConclusion"
        Me.cboFibroConclusion.Size = New System.Drawing.Size(421, 26)
        Me.cboFibroConclusion.TabIndex = 47
        '
        'BtnRemoveFibroConclusion
        '
        Me.BtnRemoveFibroConclusion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemoveFibroConclusion.Location = New System.Drawing.Point(565, 17)
        Me.BtnRemoveFibroConclusion.Name = "BtnRemoveFibroConclusion"
        Me.BtnRemoveFibroConclusion.Size = New System.Drawing.Size(33, 25)
        Me.BtnRemoveFibroConclusion.TabIndex = 44
        Me.BtnRemoveFibroConclusion.Text = "-"
        Me.BtnRemoveFibroConclusion.UseVisualStyleBackColor = True
        '
        'BtnAddFibroConclusion
        '
        Me.BtnAddFibroConclusion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddFibroConclusion.Location = New System.Drawing.Point(527, 17)
        Me.BtnAddFibroConclusion.Name = "BtnAddFibroConclusion"
        Me.BtnAddFibroConclusion.Size = New System.Drawing.Size(33, 25)
        Me.BtnAddFibroConclusion.TabIndex = 43
        Me.BtnAddFibroConclusion.Text = "+"
        Me.BtnAddFibroConclusion.UseVisualStyleBackColor = True
        '
        'ConclusionGroup
        '
        Me.ConclusionGroup.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConclusionGroup.Controls.Add(Me.FibroConclusionList)
        Me.ConclusionGroup.Location = New System.Drawing.Point(12, 56)
        Me.ConclusionGroup.Name = "ConclusionGroup"
        Me.ConclusionGroup.Size = New System.Drawing.Size(965, 299)
        Me.ConclusionGroup.TabIndex = 45
        Me.ConclusionGroup.TabStop = False
        Me.ConclusionGroup.Text = "List of conclusion"
        '
        'FibroConclusionList
        '
        Me.FibroConclusionList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        FibroConclusionList_DesignTimeLayout.LayoutString = resources.GetString("FibroConclusionList_DesignTimeLayout.LayoutString")
        Me.FibroConclusionList.DesignTimeLayout = FibroConclusionList_DesignTimeLayout
        Me.FibroConclusionList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FibroConclusionList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FibroConclusionList.GroupByBoxVisible = False
        Me.FibroConclusionList.HeaderFormatStyle.FontSize = 10.0!
        Me.FibroConclusionList.Location = New System.Drawing.Point(3, 16)
        Me.FibroConclusionList.Name = "FibroConclusionList"
        Me.FibroConclusionList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.FibroConclusionList.Size = New System.Drawing.Size(959, 280)
        Me.FibroConclusionList.TabIndex = 0
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(10, 26)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(76, 16)
        Me.Label26.TabIndex = 46
        Me.Label26.Text = "Conclusion:"
        '
        'Nasogastro
        '
        Me.Nasogastro.Controls.Add(Me.BtnRemoveNasoConclusion)
        Me.Nasogastro.Controls.Add(Me.BtnAddNasoConclusion)
        Me.Nasogastro.Controls.Add(Me.GroupBox1)
        Me.Nasogastro.Controls.Add(Me.Label27)
        Me.Nasogastro.Controls.Add(Me.cboNasoConclusion)
        Me.Nasogastro.Location = New System.Drawing.Point(4, 22)
        Me.Nasogastro.Name = "Nasogastro"
        Me.Nasogastro.Padding = New System.Windows.Forms.Padding(3)
        Me.Nasogastro.Size = New System.Drawing.Size(983, 385)
        Me.Nasogastro.TabIndex = 2
        Me.Nasogastro.Text = "Nasogastro"
        Me.Nasogastro.UseVisualStyleBackColor = True
        '
        'BtnRemoveNasoConclusion
        '
        Me.BtnRemoveNasoConclusion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemoveNasoConclusion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemoveNasoConclusion.Location = New System.Drawing.Point(514, 15)
        Me.BtnRemoveNasoConclusion.Name = "BtnRemoveNasoConclusion"
        Me.BtnRemoveNasoConclusion.Size = New System.Drawing.Size(35, 25)
        Me.BtnRemoveNasoConclusion.TabIndex = 44
        Me.BtnRemoveNasoConclusion.Text = "-"
        Me.BtnRemoveNasoConclusion.UseVisualStyleBackColor = True
        '
        'BtnAddNasoConclusion
        '
        Me.BtnAddNasoConclusion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddNasoConclusion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddNasoConclusion.Location = New System.Drawing.Point(476, 15)
        Me.BtnAddNasoConclusion.Name = "BtnAddNasoConclusion"
        Me.BtnAddNasoConclusion.Size = New System.Drawing.Size(35, 25)
        Me.BtnAddNasoConclusion.TabIndex = 43
        Me.BtnAddNasoConclusion.Text = "+"
        Me.BtnAddNasoConclusion.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.NasoConclusionList)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(971, 317)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of conclusion"
        '
        'NasoConclusionList
        '
        Me.NasoConclusionList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        NasoConclusionList_DesignTimeLayout.LayoutString = resources.GetString("NasoConclusionList_DesignTimeLayout.LayoutString")
        Me.NasoConclusionList.DesignTimeLayout = NasoConclusionList_DesignTimeLayout
        Me.NasoConclusionList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NasoConclusionList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NasoConclusionList.GroupByBoxVisible = False
        Me.NasoConclusionList.HeaderFormatStyle.FontSize = 10.0!
        Me.NasoConclusionList.Location = New System.Drawing.Point(3, 18)
        Me.NasoConclusionList.Name = "NasoConclusionList"
        Me.NasoConclusionList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.NasoConclusionList.Size = New System.Drawing.Size(965, 296)
        Me.NasoConclusionList.TabIndex = 0
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(6, 24)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(76, 16)
        Me.Label27.TabIndex = 46
        Me.Label27.Text = "Conclusion:"
        '
        'cboNasoConclusion
        '
        Me.cboNasoConclusion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboNasoConclusion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboNasoConclusion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNasoConclusion.FormattingEnabled = True
        Me.cboNasoConclusion.Location = New System.Drawing.Point(88, 16)
        Me.cboNasoConclusion.Name = "cboNasoConclusion"
        Me.cboNasoConclusion.Size = New System.Drawing.Size(382, 28)
        Me.cboNasoConclusion.TabIndex = 42
        '
        'Coloscopy
        '
        Me.Coloscopy.Controls.Add(Me.cboColoConclusion)
        Me.Coloscopy.Controls.Add(Me.GroupBox4)
        Me.Coloscopy.Controls.Add(Me.BtnRemoveColoConclusion)
        Me.Coloscopy.Controls.Add(Me.BtnAddColoConclusion)
        Me.Coloscopy.Controls.Add(Me.Label42)
        Me.Coloscopy.Location = New System.Drawing.Point(4, 22)
        Me.Coloscopy.Name = "Coloscopy"
        Me.Coloscopy.Padding = New System.Windows.Forms.Padding(3)
        Me.Coloscopy.Size = New System.Drawing.Size(983, 385)
        Me.Coloscopy.TabIndex = 3
        Me.Coloscopy.Text = "Coloscopy"
        Me.Coloscopy.UseVisualStyleBackColor = True
        '
        'cboColoConclusion
        '
        Me.cboColoConclusion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboColoConclusion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboColoConclusion.DropDownWidth = 250
        Me.cboColoConclusion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboColoConclusion.FormattingEnabled = True
        Me.cboColoConclusion.Location = New System.Drawing.Point(97, 10)
        Me.cboColoConclusion.Name = "cboColoConclusion"
        Me.cboColoConclusion.Size = New System.Drawing.Size(407, 26)
        Me.cboColoConclusion.TabIndex = 67
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.ColoConclusionList)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(6, 47)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(971, 321)
        Me.GroupBox4.TabIndex = 65
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "List of conclusion"
        '
        'ColoConclusionList
        '
        Me.ColoConclusionList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        ColoConclusionList_DesignTimeLayout.LayoutString = resources.GetString("ColoConclusionList_DesignTimeLayout.LayoutString")
        Me.ColoConclusionList.DesignTimeLayout = ColoConclusionList_DesignTimeLayout
        Me.ColoConclusionList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ColoConclusionList.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColoConclusionList.GroupByBoxVisible = False
        Me.ColoConclusionList.HeaderFormatStyle.FontSize = 10.0!
        Me.ColoConclusionList.Location = New System.Drawing.Point(3, 18)
        Me.ColoConclusionList.Name = "ColoConclusionList"
        Me.ColoConclusionList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.ColoConclusionList.Size = New System.Drawing.Size(965, 300)
        Me.ColoConclusionList.TabIndex = 0
        '
        'BtnRemoveColoConclusion
        '
        Me.BtnRemoveColoConclusion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemoveColoConclusion.Location = New System.Drawing.Point(546, 11)
        Me.BtnRemoveColoConclusion.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRemoveColoConclusion.Name = "BtnRemoveColoConclusion"
        Me.BtnRemoveColoConclusion.Size = New System.Drawing.Size(34, 24)
        Me.BtnRemoveColoConclusion.TabIndex = 64
        Me.BtnRemoveColoConclusion.Text = "-"
        Me.BtnRemoveColoConclusion.UseVisualStyleBackColor = True
        '
        'BtnAddColoConclusion
        '
        Me.BtnAddColoConclusion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddColoConclusion.Location = New System.Drawing.Point(509, 11)
        Me.BtnAddColoConclusion.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAddColoConclusion.Name = "BtnAddColoConclusion"
        Me.BtnAddColoConclusion.Size = New System.Drawing.Size(34, 24)
        Me.BtnAddColoConclusion.TabIndex = 63
        Me.BtnAddColoConclusion.Text = "+"
        Me.BtnAddColoConclusion.UseVisualStyleBackColor = True
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(5, 18)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(76, 16)
        Me.Label42.TabIndex = 66
        Me.Label42.Text = "Conclusion:"
        '
        'Echo
        '
        Me.Echo.Controls.Add(Me.txtechomoreinfo)
        Me.Echo.Controls.Add(Me.BtnRemoveEchoConclusion)
        Me.Echo.Controls.Add(Me.BtnAddEchoConclusion)
        Me.Echo.Controls.Add(Me.GroupBox9)
        Me.Echo.Controls.Add(Me.cboEchoConclusion)
        Me.Echo.Controls.Add(Me.Label63)
        Me.Echo.Location = New System.Drawing.Point(4, 22)
        Me.Echo.Name = "Echo"
        Me.Echo.Padding = New System.Windows.Forms.Padding(3)
        Me.Echo.Size = New System.Drawing.Size(983, 385)
        Me.Echo.TabIndex = 4
        Me.Echo.Text = "Echo"
        Me.Echo.UseVisualStyleBackColor = True
        '
        'txtechomoreinfo
        '
        Me.txtechomoreinfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtechomoreinfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtechomoreinfo.Location = New System.Drawing.Point(6, 6)
        Me.txtechomoreinfo.Multiline = True
        Me.txtechomoreinfo.Name = "txtechomoreinfo"
        Me.txtechomoreinfo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtechomoreinfo.Size = New System.Drawing.Size(965, 373)
        Me.txtechomoreinfo.TabIndex = 19
        '
        'BtnRemoveEchoConclusion
        '
        Me.BtnRemoveEchoConclusion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemoveEchoConclusion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemoveEchoConclusion.Location = New System.Drawing.Point(1019, 40)
        Me.BtnRemoveEchoConclusion.Name = "BtnRemoveEchoConclusion"
        Me.BtnRemoveEchoConclusion.Size = New System.Drawing.Size(32, 24)
        Me.BtnRemoveEchoConclusion.TabIndex = 17
        Me.BtnRemoveEchoConclusion.Text = "-"
        Me.BtnRemoveEchoConclusion.UseVisualStyleBackColor = True
        Me.BtnRemoveEchoConclusion.Visible = False
        '
        'BtnAddEchoConclusion
        '
        Me.BtnAddEchoConclusion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddEchoConclusion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddEchoConclusion.Location = New System.Drawing.Point(983, 40)
        Me.BtnAddEchoConclusion.Name = "BtnAddEchoConclusion"
        Me.BtnAddEchoConclusion.Size = New System.Drawing.Size(32, 24)
        Me.BtnAddEchoConclusion.TabIndex = 16
        Me.BtnAddEchoConclusion.Text = "+"
        Me.BtnAddEchoConclusion.UseVisualStyleBackColor = True
        Me.BtnAddEchoConclusion.Visible = False
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.EchoConclusionList)
        Me.GroupBox9.Location = New System.Drawing.Point(900, 75)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(77, 293)
        Me.GroupBox9.TabIndex = 18
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "List of conclusion"
        Me.GroupBox9.Visible = False
        '
        'EchoConclusionList
        '
        Me.EchoConclusionList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        EchoConclusionList_DesignTimeLayout.LayoutString = resources.GetString("EchoConclusionList_DesignTimeLayout.LayoutString")
        Me.EchoConclusionList.DesignTimeLayout = EchoConclusionList_DesignTimeLayout
        Me.EchoConclusionList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EchoConclusionList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EchoConclusionList.GroupByBoxVisible = False
        Me.EchoConclusionList.Location = New System.Drawing.Point(3, 16)
        Me.EchoConclusionList.Name = "EchoConclusionList"
        Me.EchoConclusionList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.EchoConclusionList.Size = New System.Drawing.Size(71, 274)
        Me.EchoConclusionList.TabIndex = 0
        '
        'cboEchoConclusion
        '
        Me.cboEchoConclusion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboEchoConclusion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEchoConclusion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEchoConclusion.FormattingEnabled = True
        Me.cboEchoConclusion.Location = New System.Drawing.Point(910, 40)
        Me.cboEchoConclusion.Name = "cboEchoConclusion"
        Me.cboEchoConclusion.Size = New System.Drawing.Size(257, 24)
        Me.cboEchoConclusion.TabIndex = 15
        Me.cboEchoConclusion.Visible = False
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(842, 51)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(62, 13)
        Me.Label63.TabIndex = 14
        Me.Label63.Text = "Conclusion:"
        Me.Label63.Visible = False
        '
        'Scan
        '
        Me.Scan.Controls.Add(Me.GroupBox5)
        Me.Scan.Location = New System.Drawing.Point(4, 22)
        Me.Scan.Name = "Scan"
        Me.Scan.Padding = New System.Windows.Forms.Padding(3)
        Me.Scan.Size = New System.Drawing.Size(983, 385)
        Me.Scan.TabIndex = 5
        Me.Scan.Text = "Scan"
        Me.Scan.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtScan)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Size = New System.Drawing.Size(977, 379)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Result of Scan"
        '
        'txtScan
        '
        Me.txtScan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtScan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScan.Location = New System.Drawing.Point(2, 15)
        Me.txtScan.Margin = New System.Windows.Forms.Padding(2)
        Me.txtScan.Multiline = True
        Me.txtScan.Name = "txtScan"
        Me.txtScan.Size = New System.Drawing.Size(973, 362)
        Me.txtScan.TabIndex = 0
        '
        'MRI
        '
        Me.MRI.Controls.Add(Me.GroupBox6)
        Me.MRI.Location = New System.Drawing.Point(4, 22)
        Me.MRI.Name = "MRI"
        Me.MRI.Padding = New System.Windows.Forms.Padding(3)
        Me.MRI.Size = New System.Drawing.Size(983, 385)
        Me.MRI.TabIndex = 6
        Me.MRI.Text = "M-R-I"
        Me.MRI.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtmri)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Size = New System.Drawing.Size(977, 379)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Result of M-R-I"
        '
        'txtmri
        '
        Me.txtmri.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtmri.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmri.Location = New System.Drawing.Point(2, 15)
        Me.txtmri.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmri.Multiline = True
        Me.txtmri.Name = "txtmri"
        Me.txtmri.Size = New System.Drawing.Size(973, 362)
        Me.txtmri.TabIndex = 0
        '
        'FibroScan
        '
        Me.FibroScan.Controls.Add(Me.GroupBox7)
        Me.FibroScan.Location = New System.Drawing.Point(4, 22)
        Me.FibroScan.Name = "FibroScan"
        Me.FibroScan.Padding = New System.Windows.Forms.Padding(3)
        Me.FibroScan.Size = New System.Drawing.Size(983, 385)
        Me.FibroScan.TabIndex = 7
        Me.FibroScan.Text = "Fibro Scan"
        Me.FibroScan.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtfibroscan)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox7.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Size = New System.Drawing.Size(977, 379)
        Me.GroupBox7.TabIndex = 4
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Fibro Scan"
        '
        'txtfibroscan
        '
        Me.txtfibroscan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtfibroscan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfibroscan.Location = New System.Drawing.Point(2, 15)
        Me.txtfibroscan.Margin = New System.Windows.Forms.Padding(2)
        Me.txtfibroscan.Multiline = True
        Me.txtfibroscan.Name = "txtfibroscan"
        Me.txtfibroscan.Size = New System.Drawing.Size(973, 362)
        Me.txtfibroscan.TabIndex = 0
        '
        'CFAnapath
        '
        Me.CFAnapath.Controls.Add(Me.GroupBox8)
        Me.CFAnapath.Location = New System.Drawing.Point(4, 22)
        Me.CFAnapath.Name = "CFAnapath"
        Me.CFAnapath.Size = New System.Drawing.Size(983, 385)
        Me.CFAnapath.TabIndex = 8
        Me.CFAnapath.Text = "CF-Anapath"
        Me.CFAnapath.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.TxtCFAnapath)
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox8.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(983, 385)
        Me.GroupBox8.TabIndex = 1
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Ana-Path"
        '
        'TxtCFAnapath
        '
        Me.TxtCFAnapath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtCFAnapath.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCFAnapath.Location = New System.Drawing.Point(3, 16)
        Me.TxtCFAnapath.Multiline = True
        Me.TxtCFAnapath.Name = "TxtCFAnapath"
        Me.TxtCFAnapath.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtCFAnapath.Size = New System.Drawing.Size(977, 366)
        Me.TxtCFAnapath.TabIndex = 0
        '
        'FormParaExamHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 625)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormParaExamHistory"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Para Exam History"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.BloodChecked.ResumeLayout(False)
        Me.BloodChecked.PerformLayout()
        CType(Me.BloodResultList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Fibroscopy.ResumeLayout(False)
        Me.Fibroscopy.PerformLayout()
        Me.ConclusionGroup.ResumeLayout(False)
        CType(Me.FibroConclusionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Nasogastro.ResumeLayout(False)
        Me.Nasogastro.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.NasoConclusionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Coloscopy.ResumeLayout(False)
        Me.Coloscopy.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.ColoConclusionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Echo.ResumeLayout(False)
        Me.Echo.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.EchoConclusionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Scan.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.MRI.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.FibroScan.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.CFAnapath.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFindPatient As System.Windows.Forms.Button
    Friend WithEvents lblpatientid As System.Windows.Forms.Label
    Friend WithEvents txtno As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtdatebirth As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtsex As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtrequest As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtBloodResult As System.Windows.Forms.TextBox
    Friend WithEvents btnDeleteItem As System.Windows.Forms.Button
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents BloodResultList As Janus.Windows.GridEX.GridEX
    Friend WithEvents cboitem As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents BloodChecked As System.Windows.Forms.TabPage
    Friend WithEvents Fibroscopy As System.Windows.Forms.TabPage
    Friend WithEvents Nasogastro As System.Windows.Forms.TabPage
    Friend WithEvents Coloscopy As System.Windows.Forms.TabPage
    Friend WithEvents Echo As System.Windows.Forms.TabPage
    Friend WithEvents Scan As System.Windows.Forms.TabPage
    Friend WithEvents MRI As System.Windows.Forms.TabPage
    Friend WithEvents FibroScan As System.Windows.Forms.TabPage
    Friend WithEvents cboFibroConclusion As System.Windows.Forms.ComboBox
    Friend WithEvents BtnRemoveFibroConclusion As System.Windows.Forms.Button
    Friend WithEvents BtnAddFibroConclusion As System.Windows.Forms.Button
    Friend WithEvents ConclusionGroup As System.Windows.Forms.GroupBox
    Friend WithEvents FibroConclusionList As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents BtnRemoveNasoConclusion As System.Windows.Forms.Button
    Friend WithEvents BtnAddNasoConclusion As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents NasoConclusionList As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cboNasoConclusion As System.Windows.Forms.ComboBox
    Friend WithEvents cboColoConclusion As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ColoConclusionList As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnRemoveColoConclusion As System.Windows.Forms.Button
    Friend WithEvents BtnAddColoConclusion As System.Windows.Forms.Button
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents CFAnapath As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtScan As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtmri As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtfibroscan As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtCFAnapath As System.Windows.Forms.TextBox
    Friend WithEvents BtnRemoveEchoConclusion As System.Windows.Forms.Button
    Friend WithEvents BtnAddEchoConclusion As System.Windows.Forms.Button
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents EchoConclusionList As Janus.Windows.GridEX.GridEX
    Friend WithEvents cboEchoConclusion As System.Windows.Forms.ComboBox
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtechomoreinfo As System.Windows.Forms.TextBox
    Friend WithEvents LblRequestID As System.Windows.Forms.Label
    Friend WithEvents CboDiagnosis As System.Windows.Forms.ComboBox
End Class
