<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewPrescription
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
        Dim ComplaintList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewPrescription))
        Dim HistoryList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim PhysicalList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim ParaList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim PrescriptionList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.dtprescription = New System.Windows.Forms.DateTimePicker
        Me.btnSave = New System.Windows.Forms.Button
        Me.cbodoctor = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.cbodiagnosis = New System.Windows.Forms.ComboBox
        Me.cboconsulttype = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblpatientId = New System.Windows.Forms.Label
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.txtphone = New System.Windows.Forms.TextBox
        Me.txtsex = New System.Windows.Forms.TextBox
        Me.txtage = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtid = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage5 = New Janus.Windows.UI.Tab.UITabPage
        Me.ComplaintList = New Janus.Windows.GridEX.GridEX
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BtnAddComplaint = New System.Windows.Forms.Button
        Me.cbocomplaint = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtcomplaintdesc = New System.Windows.Forms.TextBox
        Me.UiTabPage6 = New Janus.Windows.UI.Tab.UITabPage
        Me.HistoryList = New Janus.Windows.GridEX.GridEX
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.BtnAddMedical = New System.Windows.Forms.Button
        Me.cbohistory = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtmedicaldesc = New System.Windows.Forms.TextBox
        Me.UiTabPage7 = New Janus.Windows.UI.Tab.UITabPage
        Me.PhysicalList = New Janus.Windows.GridEX.GridEX
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.BtnAddPhysical = New System.Windows.Forms.Button
        Me.cboexamination = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtphysicaldesc = New System.Windows.Forms.TextBox
        Me.UiTabPage8 = New Janus.Windows.UI.Tab.UITabPage
        Me.ParaList = New Janus.Windows.GridEX.GridEX
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.BtnAddPara = New System.Windows.Forms.Button
        Me.CboParaClinic = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtparadesc = New System.Windows.Forms.TextBox
        Me.UiTabPage9 = New Janus.Windows.UI.Tab.UITabPage
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.PrescriptionList = New Janus.Windows.GridEX.GridEX
        Me.BtnAddPrescription = New System.Windows.Forms.Button
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtdosage = New System.Windows.Forms.TextBox
        Me.txtduration = New System.Windows.Forms.TextBox
        Me.cbomedicine = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage
        Me.txtremark = New System.Windows.Forms.TextBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.ErrPrescription = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BtnDeleteComplaint = New Janus.Windows.Ribbon.DropDownCommand
        Me.BtnEditComplaint = New Janus.Windows.Ribbon.DropDownCommand
        Me.ComplaintContextMenu = New Janus.Windows.Ribbon.RibbonContextMenu(Me.components)
        Me.BtnAddNewComplaint = New Janus.Windows.Ribbon.DropDownCommand
        Me.HistoryContextMenu = New Janus.Windows.Ribbon.RibbonContextMenu(Me.components)
        Me.BtnAddNewHistory = New Janus.Windows.Ribbon.DropDownCommand
        Me.BtnEditHistory = New Janus.Windows.Ribbon.DropDownCommand
        Me.BtnDeleteHistory = New Janus.Windows.Ribbon.DropDownCommand
        Me.PhysicalContextMenu = New Janus.Windows.Ribbon.RibbonContextMenu(Me.components)
        Me.BtnAddNewPhysical = New Janus.Windows.Ribbon.DropDownCommand
        Me.BtnEditPhysical = New Janus.Windows.Ribbon.DropDownCommand
        Me.BtnDeletePhysical = New Janus.Windows.Ribbon.DropDownCommand
        Me.ParaContextMenu = New Janus.Windows.Ribbon.RibbonContextMenu(Me.components)
        Me.BtnAddNewPara = New Janus.Windows.Ribbon.DropDownCommand
        Me.BtnEditPara = New Janus.Windows.Ribbon.DropDownCommand
        Me.BtnDeletePara = New Janus.Windows.Ribbon.DropDownCommand
        Me.PrescriptionContextMenu = New Janus.Windows.Ribbon.RibbonContextMenu(Me.components)
        Me.BtnAddNewPrescription = New Janus.Windows.Ribbon.DropDownCommand
        Me.BtnEditPrescription = New Janus.Windows.Ribbon.DropDownCommand
        Me.BtnDeletePrescription = New Janus.Windows.Ribbon.DropDownCommand
        Me.OfficeFormAdorner1 = New Janus.Windows.Ribbon.OfficeFormAdorner(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.UiTabPage5.SuspendLayout()
        CType(Me.ComplaintList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.UiTabPage6.SuspendLayout()
        CType(Me.HistoryList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.UiTabPage7.SuspendLayout()
        CType(Me.PhysicalList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.UiTabPage8.SuspendLayout()
        CType(Me.ParaList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.UiTabPage9.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.PrescriptionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabPage1.SuspendLayout()
        CType(Me.ErrPrescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfficeFormAdorner1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox8)
        Me.GroupBox1.Controls.Add(Me.lblpatientId)
        Me.GroupBox1.Controls.Add(Me.txtaddress)
        Me.GroupBox1.Controls.Add(Me.txtphone)
        Me.GroupBox1.Controls.Add(Me.txtsex)
        Me.GroupBox1.Controls.Add(Me.txtage)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(988, 120)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Information"
        '
        'GroupBox8
        '
        Me.GroupBox8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox8.Controls.Add(Me.dtprescription)
        Me.GroupBox8.Controls.Add(Me.btnSave)
        Me.GroupBox8.Controls.Add(Me.cbodoctor)
        Me.GroupBox8.Controls.Add(Me.Label1)
        Me.GroupBox8.Controls.Add(Me.Label3)
        Me.GroupBox8.Controls.Add(Me.Label10)
        Me.GroupBox8.Controls.Add(Me.cbodiagnosis)
        Me.GroupBox8.Controls.Add(Me.cboconsulttype)
        Me.GroupBox8.Controls.Add(Me.Label2)
        Me.GroupBox8.Location = New System.Drawing.Point(468, 12)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(514, 98)
        Me.GroupBox8.TabIndex = 16
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Issure Prescription:"
        '
        'dtprescription
        '
        Me.dtprescription.Checked = False
        Me.dtprescription.CustomFormat = "dd/MM/yyyy"
        Me.dtprescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtprescription.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtprescription.Location = New System.Drawing.Point(102, 24)
        Me.dtprescription.Name = "dtprescription"
        Me.dtprescription.ShowCheckBox = True
        Me.dtprescription.Size = New System.Drawing.Size(192, 26)
        Me.dtprescription.TabIndex = 5
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(293, 15)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(103, 34)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'cbodoctor
        '
        Me.cbodoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbodoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodoctor.FormattingEnabled = True
        Me.cbodoctor.Location = New System.Drawing.Point(402, 62)
        Me.cbodoctor.Name = "cbodoctor"
        Me.cbodoctor.Size = New System.Drawing.Size(242, 28)
        Me.cbodoctor.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Prescription Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Diagnosis:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(354, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Doctor:"
        '
        'cbodiagnosis
        '
        Me.cbodiagnosis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbodiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodiagnosis.FormattingEnabled = True
        Me.cbodiagnosis.Location = New System.Drawing.Point(102, 62)
        Me.cbodiagnosis.Name = "cbodiagnosis"
        Me.cbodiagnosis.Size = New System.Drawing.Size(192, 28)
        Me.cbodiagnosis.TabIndex = 13
        '
        'cboconsulttype
        '
        Me.cboconsulttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboconsulttype.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboconsulttype.FormattingEnabled = True
        Me.cboconsulttype.Location = New System.Drawing.Point(402, 22)
        Me.cboconsulttype.Name = "cboconsulttype"
        Me.cboconsulttype.Size = New System.Drawing.Size(242, 28)
        Me.cboconsulttype.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(301, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Consultation Type:"
        '
        'lblpatientId
        '
        Me.lblpatientId.AutoSize = True
        Me.lblpatientId.Location = New System.Drawing.Point(263, 9)
        Me.lblpatientId.Name = "lblpatientId"
        Me.lblpatientId.Size = New System.Drawing.Size(47, 13)
        Me.lblpatientId.TabIndex = 12
        Me.lblpatientId.Text = "patientid"
        Me.lblpatientId.Visible = False
        '
        'txtaddress
        '
        Me.txtaddress.BackColor = System.Drawing.Color.White
        Me.txtaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(316, 84)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.ReadOnly = True
        Me.txtaddress.Size = New System.Drawing.Size(146, 26)
        Me.txtaddress.TabIndex = 11
        '
        'txtphone
        '
        Me.txtphone.BackColor = System.Drawing.Color.White
        Me.txtphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphone.Location = New System.Drawing.Point(72, 84)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.ReadOnly = True
        Me.txtphone.Size = New System.Drawing.Size(146, 26)
        Me.txtphone.TabIndex = 10
        '
        'txtsex
        '
        Me.txtsex.BackColor = System.Drawing.Color.White
        Me.txtsex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsex.Location = New System.Drawing.Point(316, 52)
        Me.txtsex.Name = "txtsex"
        Me.txtsex.ReadOnly = True
        Me.txtsex.Size = New System.Drawing.Size(146, 26)
        Me.txtsex.TabIndex = 9
        '
        'txtage
        '
        Me.txtage.BackColor = System.Drawing.Color.White
        Me.txtage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.Location = New System.Drawing.Point(72, 52)
        Me.txtage.Name = "txtage"
        Me.txtage.ReadOnly = True
        Me.txtage.Size = New System.Drawing.Size(146, 26)
        Me.txtage.TabIndex = 8
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.White
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(316, 20)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(146, 26)
        Me.txtname.TabIndex = 7
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.Color.White
        Me.txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(72, 20)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(146, 26)
        Me.txtid.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(224, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Address:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Telephone:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(224, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Sex:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Age:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(224, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Patient Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Patient No:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1188, 576)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Prescription Info"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.UiTab1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(3, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1182, 557)
        Me.Panel1.TabIndex = 4
        '
        'UiTab1
        '
        Me.UiTab1.Cursor = System.Windows.Forms.Cursors.Default
        Me.UiTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiTab1.Font = New System.Drawing.Font("Khmer OS System", 9.25!)
        Me.UiTab1.Location = New System.Drawing.Point(0, 0)
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.Size = New System.Drawing.Size(1178, 553)
        Me.UiTab1.TabIndex = 30
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage5, Me.UiTabPage6, Me.UiTabPage7, Me.UiTabPage8, Me.UiTabPage9, Me.UiTabPage1})
        Me.UiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        '
        'UiTabPage5
        '
        Me.UiTabPage5.Controls.Add(Me.ComplaintList)
        Me.UiTabPage5.Controls.Add(Me.GroupBox3)
        Me.UiTabPage5.Key = "Patient Complaint"
        Me.UiTabPage5.Location = New System.Drawing.Point(1, 32)
        Me.UiTabPage5.Name = "UiTabPage5"
        Me.UiTabPage5.Size = New System.Drawing.Size(1176, 520)
        Me.UiTabPage5.TabStop = True
        Me.UiTabPage5.Text = "Patient Complaint"
        '
        'ComplaintList
        '
        Me.ComplaintList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.ComplaintContextMenu.SetContextMenu(Me.ComplaintList, True)
        ComplaintList_DesignTimeLayout.LayoutString = resources.GetString("ComplaintList_DesignTimeLayout.LayoutString")
        Me.ComplaintList.DesignTimeLayout = ComplaintList_DesignTimeLayout
        Me.ComplaintList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComplaintList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComplaintList.GroupByBoxVisible = False
        Me.ComplaintList.Location = New System.Drawing.Point(0, 56)
        Me.ComplaintList.Name = "ComplaintList"
        Me.ComplaintList.RecordNavigator = True
        Me.ComplaintList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.ComplaintList.Size = New System.Drawing.Size(1176, 464)
        Me.ComplaintList.TabIndex = 0
        Me.ComplaintList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnAddComplaint)
        Me.GroupBox3.Controls.Add(Me.cbocomplaint)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtcomplaintdesc)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1176, 56)
        Me.GroupBox3.TabIndex = 58
        Me.GroupBox3.TabStop = False
        '
        'BtnAddComplaint
        '
        Me.BtnAddComplaint.Location = New System.Drawing.Point(774, 20)
        Me.BtnAddComplaint.Name = "BtnAddComplaint"
        Me.BtnAddComplaint.Size = New System.Drawing.Size(75, 26)
        Me.BtnAddComplaint.TabIndex = 54
        Me.BtnAddComplaint.Text = "Add"
        Me.BtnAddComplaint.UseVisualStyleBackColor = True
        '
        'cbocomplaint
        '
        Me.cbocomplaint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbocomplaint.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.cbocomplaint.FormattingEnabled = True
        Me.cbocomplaint.Location = New System.Drawing.Point(94, 16)
        Me.cbocomplaint.Name = "cbocomplaint"
        Me.cbocomplaint.Size = New System.Drawing.Size(238, 30)
        Me.cbocomplaint.TabIndex = 53
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(350, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 22)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Description"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(6, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 22)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Complaint"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcomplaintdesc
        '
        Me.txtcomplaintdesc.BackColor = System.Drawing.Color.White
        Me.txtcomplaintdesc.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.txtcomplaintdesc.Location = New System.Drawing.Point(447, 21)
        Me.txtcomplaintdesc.Name = "txtcomplaintdesc"
        Me.txtcomplaintdesc.Size = New System.Drawing.Size(312, 26)
        Me.txtcomplaintdesc.TabIndex = 50
        '
        'UiTabPage6
        '
        Me.UiTabPage6.Controls.Add(Me.HistoryList)
        Me.UiTabPage6.Controls.Add(Me.GroupBox4)
        Me.UiTabPage6.Key = "Medical History"
        Me.UiTabPage6.Location = New System.Drawing.Point(1, 32)
        Me.UiTabPage6.Name = "UiTabPage6"
        Me.UiTabPage6.Size = New System.Drawing.Size(1176, 520)
        Me.UiTabPage6.TabStop = True
        Me.UiTabPage6.Text = "Medical History"
        '
        'HistoryList
        '
        Me.HistoryList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.HistoryContextMenu.SetContextMenu(Me.HistoryList, True)
        HistoryList_DesignTimeLayout.LayoutString = resources.GetString("HistoryList_DesignTimeLayout.LayoutString")
        Me.HistoryList.DesignTimeLayout = HistoryList_DesignTimeLayout
        Me.HistoryList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HistoryList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistoryList.GroupByBoxVisible = False
        Me.HistoryList.HeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistoryList.Location = New System.Drawing.Point(0, 56)
        Me.HistoryList.Name = "HistoryList"
        Me.HistoryList.RecordNavigator = True
        Me.HistoryList.RowFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistoryList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.HistoryList.Size = New System.Drawing.Size(1176, 464)
        Me.HistoryList.TabIndex = 1
        Me.HistoryList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnAddMedical)
        Me.GroupBox4.Controls.Add(Me.cbohistory)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txtmedicaldesc)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1176, 56)
        Me.GroupBox4.TabIndex = 63
        Me.GroupBox4.TabStop = False
        '
        'BtnAddMedical
        '
        Me.BtnAddMedical.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddMedical.Location = New System.Drawing.Point(736, 20)
        Me.BtnAddMedical.Name = "BtnAddMedical"
        Me.BtnAddMedical.Size = New System.Drawing.Size(75, 26)
        Me.BtnAddMedical.TabIndex = 55
        Me.BtnAddMedical.Text = "Add"
        Me.BtnAddMedical.UseVisualStyleBackColor = True
        '
        'cbohistory
        '
        Me.cbohistory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbohistory.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.cbohistory.FormattingEnabled = True
        Me.cbohistory.Location = New System.Drawing.Point(74, 16)
        Me.cbohistory.Name = "cbohistory"
        Me.cbohistory.Size = New System.Drawing.Size(238, 30)
        Me.cbohistory.TabIndex = 53
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(321, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 22)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Description"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(5, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 22)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "History*"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtmedicaldesc
        '
        Me.txtmedicaldesc.BackColor = System.Drawing.Color.White
        Me.txtmedicaldesc.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.txtmedicaldesc.Location = New System.Drawing.Point(428, 20)
        Me.txtmedicaldesc.Name = "txtmedicaldesc"
        Me.txtmedicaldesc.Size = New System.Drawing.Size(293, 26)
        Me.txtmedicaldesc.TabIndex = 50
        '
        'UiTabPage7
        '
        Me.UiTabPage7.Controls.Add(Me.PhysicalList)
        Me.UiTabPage7.Controls.Add(Me.GroupBox5)
        Me.UiTabPage7.Key = "Physical Examination"
        Me.UiTabPage7.Location = New System.Drawing.Point(1, 32)
        Me.UiTabPage7.Name = "UiTabPage7"
        Me.UiTabPage7.Size = New System.Drawing.Size(1176, 520)
        Me.UiTabPage7.TabStop = True
        Me.UiTabPage7.Text = "Physical Examination"
        '
        'PhysicalList
        '
        Me.PhysicalList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.PhysicalContextMenu.SetContextMenu(Me.PhysicalList, True)
        PhysicalList_DesignTimeLayout.LayoutString = resources.GetString("PhysicalList_DesignTimeLayout.LayoutString")
        Me.PhysicalList.DesignTimeLayout = PhysicalList_DesignTimeLayout
        Me.PhysicalList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PhysicalList.GroupByBoxVisible = False
        Me.PhysicalList.Location = New System.Drawing.Point(0, 56)
        Me.PhysicalList.Name = "PhysicalList"
        Me.PhysicalList.RecordNavigator = True
        Me.PhysicalList.RowFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhysicalList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.PhysicalList.Size = New System.Drawing.Size(1176, 464)
        Me.PhysicalList.TabIndex = 1
        Me.PhysicalList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnAddPhysical)
        Me.GroupBox5.Controls.Add(Me.cboexamination)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.txtphysicaldesc)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1176, 56)
        Me.GroupBox5.TabIndex = 68
        Me.GroupBox5.TabStop = False
        '
        'BtnAddPhysical
        '
        Me.BtnAddPhysical.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddPhysical.Location = New System.Drawing.Point(766, 18)
        Me.BtnAddPhysical.Name = "BtnAddPhysical"
        Me.BtnAddPhysical.Size = New System.Drawing.Size(75, 26)
        Me.BtnAddPhysical.TabIndex = 55
        Me.BtnAddPhysical.Text = "Add"
        Me.BtnAddPhysical.UseVisualStyleBackColor = True
        '
        'cboexamination
        '
        Me.cboexamination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboexamination.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.cboexamination.FormattingEnabled = True
        Me.cboexamination.Location = New System.Drawing.Point(122, 14)
        Me.cboexamination.Name = "cboexamination"
        Me.cboexamination.Size = New System.Drawing.Size(238, 30)
        Me.cboexamination.TabIndex = 53
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(372, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 22)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "Result"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(15, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 22)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "Examination"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtphysicaldesc
        '
        Me.txtphysicaldesc.BackColor = System.Drawing.Color.White
        Me.txtphysicaldesc.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.txtphysicaldesc.Location = New System.Drawing.Point(430, 19)
        Me.txtphysicaldesc.Name = "txtphysicaldesc"
        Me.txtphysicaldesc.Size = New System.Drawing.Size(316, 26)
        Me.txtphysicaldesc.TabIndex = 50
        '
        'UiTabPage8
        '
        Me.UiTabPage8.Controls.Add(Me.ParaList)
        Me.UiTabPage8.Controls.Add(Me.GroupBox6)
        Me.UiTabPage8.Key = "Para Clinic Examination"
        Me.UiTabPage8.Location = New System.Drawing.Point(1, 32)
        Me.UiTabPage8.Name = "UiTabPage8"
        Me.UiTabPage8.Size = New System.Drawing.Size(1176, 520)
        Me.UiTabPage8.TabStop = True
        Me.UiTabPage8.Text = "Para Clinic Examination"
        '
        'ParaList
        '
        Me.ParaList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.ParaContextMenu.SetContextMenu(Me.ParaList, True)
        ParaList_DesignTimeLayout.LayoutString = resources.GetString("ParaList_DesignTimeLayout.LayoutString")
        Me.ParaList.DesignTimeLayout = ParaList_DesignTimeLayout
        Me.ParaList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ParaList.GroupByBoxVisible = False
        Me.ParaList.Location = New System.Drawing.Point(0, 56)
        Me.ParaList.Name = "ParaList"
        Me.ParaList.RecordNavigator = True
        Me.ParaList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.ParaList.Size = New System.Drawing.Size(1176, 464)
        Me.ParaList.TabIndex = 1
        Me.ParaList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.BtnAddPara)
        Me.GroupBox6.Controls.Add(Me.CboParaClinic)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.txtparadesc)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1176, 56)
        Me.GroupBox6.TabIndex = 73
        Me.GroupBox6.TabStop = False
        '
        'BtnAddPara
        '
        Me.BtnAddPara.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddPara.Location = New System.Drawing.Point(819, 20)
        Me.BtnAddPara.Name = "BtnAddPara"
        Me.BtnAddPara.Size = New System.Drawing.Size(75, 26)
        Me.BtnAddPara.TabIndex = 55
        Me.BtnAddPara.Text = "Add"
        Me.BtnAddPara.UseVisualStyleBackColor = True
        '
        'CboParaClinic
        '
        Me.CboParaClinic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboParaClinic.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.CboParaClinic.FormattingEnabled = True
        Me.CboParaClinic.Location = New System.Drawing.Point(121, 15)
        Me.CboParaClinic.Name = "CboParaClinic"
        Me.CboParaClinic.Size = New System.Drawing.Size(238, 30)
        Me.CboParaClinic.TabIndex = 53
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(384, 23)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 22)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "Description"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(14, 23)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(97, 22)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "Examination"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtparadesc
        '
        Me.txtparadesc.BackColor = System.Drawing.Color.White
        Me.txtparadesc.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.txtparadesc.Location = New System.Drawing.Point(481, 19)
        Me.txtparadesc.Name = "txtparadesc"
        Me.txtparadesc.Size = New System.Drawing.Size(316, 26)
        Me.txtparadesc.TabIndex = 50
        '
        'UiTabPage9
        '
        Me.UiTabPage9.Controls.Add(Me.GroupBox7)
        Me.UiTabPage9.Key = "Prescription"
        Me.UiTabPage9.Location = New System.Drawing.Point(1, 32)
        Me.UiTabPage9.Name = "UiTabPage9"
        Me.UiTabPage9.Size = New System.Drawing.Size(1176, 520)
        Me.UiTabPage9.TabStop = True
        Me.UiTabPage9.Text = "Prescription"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.PrescriptionList)
        Me.GroupBox7.Controls.Add(Me.BtnAddPrescription)
        Me.GroupBox7.Controls.Add(Me.Label19)
        Me.GroupBox7.Controls.Add(Me.txtdosage)
        Me.GroupBox7.Controls.Add(Me.txtduration)
        Me.GroupBox7.Controls.Add(Me.cbomedicine)
        Me.GroupBox7.Controls.Add(Me.Label20)
        Me.GroupBox7.Controls.Add(Me.Label21)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox7.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(1176, 520)
        Me.GroupBox7.TabIndex = 68
        Me.GroupBox7.TabStop = False
        '
        'PrescriptionList
        '
        Me.PrescriptionList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.PrescriptionContextMenu.SetContextMenu(Me.PrescriptionList, True)
        PrescriptionList_DesignTimeLayout.LayoutString = resources.GetString("PrescriptionList_DesignTimeLayout.LayoutString")
        Me.PrescriptionList.DesignTimeLayout = PrescriptionList_DesignTimeLayout
        Me.PrescriptionList.GroupByBoxVisible = False
        Me.PrescriptionList.Location = New System.Drawing.Point(12, 58)
        Me.PrescriptionList.Name = "PrescriptionList"
        Me.PrescriptionList.RecordNavigator = True
        Me.PrescriptionList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.PrescriptionList.Size = New System.Drawing.Size(1128, 349)
        Me.PrescriptionList.TabIndex = 1
        Me.PrescriptionList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'BtnAddPrescription
        '
        Me.BtnAddPrescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddPrescription.Location = New System.Drawing.Point(954, 18)
        Me.BtnAddPrescription.Name = "BtnAddPrescription"
        Me.BtnAddPrescription.Size = New System.Drawing.Size(75, 26)
        Me.BtnAddPrescription.TabIndex = 57
        Me.BtnAddPrescription.Text = "Add"
        Me.BtnAddPrescription.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(335, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 22)
        Me.Label19.TabIndex = 56
        Me.Label19.Text = "Dosage"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdosage
        '
        Me.txtdosage.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.txtdosage.Location = New System.Drawing.Point(401, 18)
        Me.txtdosage.Name = "txtdosage"
        Me.txtdosage.Size = New System.Drawing.Size(242, 26)
        Me.txtdosage.TabIndex = 55
        '
        'txtduration
        '
        Me.txtduration.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.txtduration.Location = New System.Drawing.Point(738, 18)
        Me.txtduration.Name = "txtduration"
        Me.txtduration.Size = New System.Drawing.Size(211, 26)
        Me.txtduration.TabIndex = 54
        '
        'cbomedicine
        '
        Me.cbomedicine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomedicine.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.cbomedicine.FormattingEnabled = True
        Me.cbomedicine.Location = New System.Drawing.Point(88, 14)
        Me.cbomedicine.Name = "cbomedicine"
        Me.cbomedicine.Size = New System.Drawing.Size(238, 30)
        Me.cbomedicine.TabIndex = 53
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(658, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 22)
        Me.Label20.TabIndex = 52
        Me.Label20.Text = "Duration"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label21.Location = New System.Drawing.Point(8, 22)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(74, 22)
        Me.Label21.TabIndex = 46
        Me.Label21.Text = "Medicine"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.txtremark)
        Me.UiTabPage1.Key = "Remark"
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 32)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(1176, 520)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "Remark"
        '
        'txtremark
        '
        Me.txtremark.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtremark.Location = New System.Drawing.Point(14, 22)
        Me.txtremark.Multiline = True
        Me.txtremark.Name = "txtremark"
        Me.txtremark.Size = New System.Drawing.Size(1140, 484)
        Me.txtremark.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(1075, 708)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(99, 34)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ErrPrescription
        '
        Me.ErrPrescription.ContainerControl = Me
        '
        'BtnDeleteComplaint
        '
        Me.BtnDeleteComplaint.Key = "DeleteCommand"
        Me.BtnDeleteComplaint.Name = "BtnDeleteComplaint"
        Me.BtnDeleteComplaint.Text = "Delete Patient Complaint"
        '
        'BtnEditComplaint
        '
        Me.BtnEditComplaint.Key = "EditCommand"
        Me.BtnEditComplaint.Name = "BtnEditComplaint"
        Me.BtnEditComplaint.Text = "Edit Patient Complaint"
        '
        'ComplaintContextMenu
        '
        Me.ComplaintContextMenu.Commands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.BtnAddNewComplaint, Me.BtnEditComplaint, Me.BtnDeleteComplaint})
        Me.ComplaintContextMenu.Name = "ComplaintContextMenu"
        '
        'BtnAddNewComplaint
        '
        Me.BtnAddNewComplaint.Key = "DropDownCommand1"
        Me.BtnAddNewComplaint.Name = "BtnAddNewComplaint"
        Me.BtnAddNewComplaint.Text = "New Patient Compaint"
        '
        'HistoryContextMenu
        '
        Me.HistoryContextMenu.Commands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.BtnAddNewHistory, Me.BtnEditHistory, Me.BtnDeleteHistory})
        Me.HistoryContextMenu.Name = "HistoryContextMenu"
        '
        'BtnAddNewHistory
        '
        Me.BtnAddNewHistory.Key = "DropDownCommand1"
        Me.BtnAddNewHistory.Name = "BtnAddNewHistory"
        Me.BtnAddNewHistory.Text = "New Medical History"
        '
        'BtnEditHistory
        '
        Me.BtnEditHistory.Key = "DropDownCommand2"
        Me.BtnEditHistory.Name = "BtnEditHistory"
        Me.BtnEditHistory.Text = "Edit Medical History"
        '
        'BtnDeleteHistory
        '
        Me.BtnDeleteHistory.Key = "DropDownCommand3"
        Me.BtnDeleteHistory.Name = "BtnDeleteHistory"
        Me.BtnDeleteHistory.Text = "Delete Medical History"
        '
        'PhysicalContextMenu
        '
        Me.PhysicalContextMenu.Commands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.BtnAddNewPhysical, Me.BtnEditPhysical, Me.BtnDeletePhysical})
        Me.PhysicalContextMenu.Name = "PhysicalContextMenu"
        '
        'BtnAddNewPhysical
        '
        Me.BtnAddNewPhysical.Key = "DropDownCommand1"
        Me.BtnAddNewPhysical.Name = "BtnAddNewPhysical"
        Me.BtnAddNewPhysical.Text = "New Physical Examination"
        '
        'BtnEditPhysical
        '
        Me.BtnEditPhysical.Key = "DropDownCommand2"
        Me.BtnEditPhysical.Name = "BtnEditPhysical"
        Me.BtnEditPhysical.Text = "Edit Physical Examination"
        '
        'BtnDeletePhysical
        '
        Me.BtnDeletePhysical.Key = "DropDownCommand3"
        Me.BtnDeletePhysical.Name = "BtnDeletePhysical"
        Me.BtnDeletePhysical.Text = "Delete Physical Examination"
        '
        'ParaContextMenu
        '
        Me.ParaContextMenu.Commands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.BtnAddNewPara, Me.BtnEditPara, Me.BtnDeletePara})
        Me.ParaContextMenu.Name = "ParaContextMenu"
        '
        'BtnAddNewPara
        '
        Me.BtnAddNewPara.Key = "DropDownCommand1"
        Me.BtnAddNewPara.Name = "BtnAddNewPara"
        Me.BtnAddNewPara.Text = "New Para Clinic Examination"
        '
        'BtnEditPara
        '
        Me.BtnEditPara.Key = "DropDownCommand2"
        Me.BtnEditPara.Name = "BtnEditPara"
        Me.BtnEditPara.Text = "Edit Para Clinic Examination"
        '
        'BtnDeletePara
        '
        Me.BtnDeletePara.Key = "DropDownCommand3"
        Me.BtnDeletePara.Name = "BtnDeletePara"
        Me.BtnDeletePara.Text = "Delete Para Clinic Examination"
        '
        'PrescriptionContextMenu
        '
        Me.PrescriptionContextMenu.Commands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.BtnAddNewPrescription, Me.BtnEditPrescription, Me.BtnDeletePrescription})
        Me.PrescriptionContextMenu.Name = "PrescriptionContextMenu"
        '
        'BtnAddNewPrescription
        '
        Me.BtnAddNewPrescription.Key = "DropDownCommand1"
        Me.BtnAddNewPrescription.Name = "BtnAddNewPrescription"
        Me.BtnAddNewPrescription.Text = "New Prescription"
        '
        'BtnEditPrescription
        '
        Me.BtnEditPrescription.Key = "DropDownCommand2"
        Me.BtnEditPrescription.Name = "BtnEditPrescription"
        Me.BtnEditPrescription.Text = "Edit Prescription"
        '
        'BtnDeletePrescription
        '
        Me.BtnDeletePrescription.Key = "DropDownCommand3"
        Me.BtnDeletePrescription.Name = "BtnDeletePrescription"
        Me.BtnDeletePrescription.Text = "Delete Prescription"
        '
        'OfficeFormAdorner1
        '
        Me.OfficeFormAdorner1.Form = Me
        Me.OfficeFormAdorner1.Office2007CustomColor = System.Drawing.Color.Empty
        '
        'NewPrescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(988, 633)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewPrescription"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prescription Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        Me.UiTabPage5.ResumeLayout(False)
        CType(Me.ComplaintList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.UiTabPage6.ResumeLayout(False)
        CType(Me.HistoryList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.UiTabPage7.ResumeLayout(False)
        CType(Me.PhysicalList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.UiTabPage8.ResumeLayout(False)
        CType(Me.ParaList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.UiTabPage9.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.PrescriptionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabPage1.ResumeLayout(False)
        Me.UiTabPage1.PerformLayout()
        CType(Me.ErrPrescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfficeFormAdorner1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage5 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage6 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage7 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage8 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage9 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents ComplaintList As Janus.Windows.GridEX.GridEX
    Friend WithEvents HistoryList As Janus.Windows.GridEX.GridEX
    Friend WithEvents PhysicalList As Janus.Windows.GridEX.GridEX
    Friend WithEvents ParaList As Janus.Windows.GridEX.GridEX
    Friend WithEvents PrescriptionList As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents txtremark As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtphone As System.Windows.Forms.TextBox
    Friend WithEvents txtsex As System.Windows.Forms.TextBox
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents dtprescription As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents cbodiagnosis As System.Windows.Forms.ComboBox
    Friend WithEvents cboconsulttype As System.Windows.Forms.ComboBox
    Friend WithEvents cbodoctor As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ErrPrescription As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblpatientId As System.Windows.Forms.Label
    Friend WithEvents BtnDeleteComplaint As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents BtnEditComplaint As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents ComplaintContextMenu As Janus.Windows.Ribbon.RibbonContextMenu
    Friend WithEvents BtnAddNewComplaint As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents HistoryContextMenu As Janus.Windows.Ribbon.RibbonContextMenu
    Friend WithEvents BtnAddNewHistory As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents BtnEditHistory As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents BtnDeleteHistory As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents PhysicalContextMenu As Janus.Windows.Ribbon.RibbonContextMenu
    Friend WithEvents BtnAddNewPhysical As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents BtnEditPhysical As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents BtnDeletePhysical As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents ParaContextMenu As Janus.Windows.Ribbon.RibbonContextMenu
    Friend WithEvents BtnAddNewPara As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents BtnEditPara As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents BtnDeletePara As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents PrescriptionContextMenu As Janus.Windows.Ribbon.RibbonContextMenu
    Friend WithEvents BtnAddNewPrescription As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents BtnEditPrescription As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents BtnDeletePrescription As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbocomplaint As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents txtcomplaintdesc As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cbohistory As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents txtmedicaldesc As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cboexamination As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents txtphysicaldesc As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents CboParaClinic As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents txtparadesc As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtdosage As System.Windows.Forms.TextBox
    Friend WithEvents txtduration As System.Windows.Forms.TextBox
    Friend WithEvents cbomedicine As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents BtnAddComplaint As System.Windows.Forms.Button
    Friend WithEvents BtnAddMedical As System.Windows.Forms.Button
    Friend WithEvents BtnAddPhysical As System.Windows.Forms.Button
    Friend WithEvents BtnAddPara As System.Windows.Forms.Button
    Friend WithEvents BtnAddPrescription As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents OfficeFormAdorner1 As Janus.Windows.Ribbon.OfficeFormAdorner
End Class
