<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainDocRequestExam
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
        Dim itemlist_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainDocRequestExam))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CboDiagnosis = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtmoreinfo = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupRequestExam = New System.Windows.Forms.GroupBox
        Me.GBloodCheck = New System.Windows.Forms.GroupBox
        Me.TxtBloodResult = New System.Windows.Forms.TextBox
        Me.btnDeleteItem = New System.Windows.Forms.Button
        Me.btnAddItem = New System.Windows.Forms.Button
        Me.itemlist = New Janus.Windows.GridEX.GridEX
        Me.cboitem = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.chkfibroscan = New System.Windows.Forms.CheckBox
        Me.chkmri = New System.Windows.Forms.CheckBox
        Me.chkscan = New System.Windows.Forms.CheckBox
        Me.chkecho = New System.Windows.Forms.CheckBox
        Me.chkcolo = New System.Windows.Forms.CheckBox
        Me.chknaso = New System.Windows.Forms.CheckBox
        Me.chkfibro = New System.Windows.Forms.CheckBox
        Me.chkbilogy = New System.Windows.Forms.CheckBox
        Me.dtrequest = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbodoctor = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.BtnFindPatient = New System.Windows.Forms.Button
        Me.lblpatientid = New System.Windows.Forms.Label
        Me.txtno = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.txtdatebirth = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtsex = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lbloption = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupRequestExam.SuspendLayout()
        Me.GBloodCheck.SuspendLayout()
        CType(Me.itemlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.CboDiagnosis)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtmoreinfo)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.GroupRequestExam)
        Me.GroupBox2.Controls.Add(Me.dtrequest)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cbodoctor)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(869, 345)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Request Examination:"
        '
        'CboDiagnosis
        '
        Me.CboDiagnosis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDiagnosis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDiagnosis.DropDownWidth = 500
        Me.CboDiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDiagnosis.FormattingEnabled = True
        Me.CboDiagnosis.Location = New System.Drawing.Point(605, 18)
        Me.CboDiagnosis.Name = "CboDiagnosis"
        Me.CboDiagnosis.Size = New System.Drawing.Size(247, 28)
        Me.CboDiagnosis.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(543, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Diagnosis:"
        '
        'txtmoreinfo
        '
        Me.txtmoreinfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmoreinfo.Location = New System.Drawing.Point(9, 292)
        Me.txtmoreinfo.Multiline = True
        Me.txtmoreinfo.Name = "txtmoreinfo"
        Me.txtmoreinfo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtmoreinfo.Size = New System.Drawing.Size(850, 47)
        Me.txtmoreinfo.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 276)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Add more Information"
        '
        'GroupRequestExam
        '
        Me.GroupRequestExam.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupRequestExam.Controls.Add(Me.GBloodCheck)
        Me.GroupRequestExam.Controls.Add(Me.chkfibroscan)
        Me.GroupRequestExam.Controls.Add(Me.chkmri)
        Me.GroupRequestExam.Controls.Add(Me.chkscan)
        Me.GroupRequestExam.Controls.Add(Me.chkecho)
        Me.GroupRequestExam.Controls.Add(Me.chkcolo)
        Me.GroupRequestExam.Controls.Add(Me.chknaso)
        Me.GroupRequestExam.Controls.Add(Me.chkfibro)
        Me.GroupRequestExam.Controls.Add(Me.chkbilogy)
        Me.GroupRequestExam.Location = New System.Drawing.Point(9, 56)
        Me.GroupRequestExam.Name = "GroupRequestExam"
        Me.GroupRequestExam.Size = New System.Drawing.Size(850, 217)
        Me.GroupRequestExam.TabIndex = 5
        Me.GroupRequestExam.TabStop = False
        Me.GroupRequestExam.Text = "Examination On"
        '
        'GBloodCheck
        '
        Me.GBloodCheck.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBloodCheck.Controls.Add(Me.TxtBloodResult)
        Me.GBloodCheck.Controls.Add(Me.btnDeleteItem)
        Me.GBloodCheck.Controls.Add(Me.btnAddItem)
        Me.GBloodCheck.Controls.Add(Me.itemlist)
        Me.GBloodCheck.Controls.Add(Me.cboitem)
        Me.GBloodCheck.Controls.Add(Me.Label8)
        Me.GBloodCheck.Enabled = False
        Me.GBloodCheck.Location = New System.Drawing.Point(138, 9)
        Me.GBloodCheck.Name = "GBloodCheck"
        Me.GBloodCheck.Size = New System.Drawing.Size(705, 203)
        Me.GBloodCheck.TabIndex = 8
        Me.GBloodCheck.TabStop = False
        Me.GBloodCheck.Text = "List blood check"
        '
        'TxtBloodResult
        '
        Me.TxtBloodResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBloodResult.Location = New System.Drawing.Point(295, 21)
        Me.TxtBloodResult.Name = "TxtBloodResult"
        Me.TxtBloodResult.Size = New System.Drawing.Size(206, 26)
        Me.TxtBloodResult.TabIndex = 4
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteItem.Location = New System.Drawing.Point(565, 21)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(44, 23)
        Me.btnDeleteItem.TabIndex = 2
        Me.btnDeleteItem.Text = "-"
        Me.btnDeleteItem.UseVisualStyleBackColor = True
        '
        'btnAddItem
        '
        Me.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddItem.Location = New System.Drawing.Point(515, 21)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(44, 23)
        Me.btnAddItem.TabIndex = 1
        Me.btnAddItem.Text = "+"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'itemlist
        '
        Me.itemlist.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        itemlist_DesignTimeLayout.LayoutString = resources.GetString("itemlist_DesignTimeLayout.LayoutString")
        Me.itemlist.DesignTimeLayout = itemlist_DesignTimeLayout
        Me.itemlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemlist.GroupByBoxVisible = False
        Me.itemlist.HeaderFormatStyle.FontSize = 10.0!
        Me.itemlist.Location = New System.Drawing.Point(8, 52)
        Me.itemlist.Name = "itemlist"
        Me.itemlist.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.itemlist.Size = New System.Drawing.Size(675, 145)
        Me.itemlist.TabIndex = 3
        '
        'cboitem
        '
        Me.cboitem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboitem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboitem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboitem.FormattingEnabled = True
        Me.cboitem.Location = New System.Drawing.Point(70, 20)
        Me.cboitem.Name = "cboitem"
        Me.cboitem.Size = New System.Drawing.Size(220, 28)
        Me.cboitem.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Check On:"
        '
        'chkfibroscan
        '
        Me.chkfibroscan.AutoSize = True
        Me.chkfibroscan.Location = New System.Drawing.Point(10, 187)
        Me.chkfibroscan.Name = "chkfibroscan"
        Me.chkfibroscan.Size = New System.Drawing.Size(77, 17)
        Me.chkfibroscan.TabIndex = 7
        Me.chkfibroscan.Text = "Fibro Scan"
        Me.chkfibroscan.UseVisualStyleBackColor = True
        '
        'chkmri
        '
        Me.chkmri.AutoSize = True
        Me.chkmri.Location = New System.Drawing.Point(11, 165)
        Me.chkmri.Name = "chkmri"
        Me.chkmri.Size = New System.Drawing.Size(52, 17)
        Me.chkmri.TabIndex = 6
        Me.chkmri.Text = "M-R-I"
        Me.chkmri.UseVisualStyleBackColor = True
        '
        'chkscan
        '
        Me.chkscan.AutoSize = True
        Me.chkscan.Location = New System.Drawing.Point(11, 142)
        Me.chkscan.Name = "chkscan"
        Me.chkscan.Size = New System.Drawing.Size(51, 17)
        Me.chkscan.TabIndex = 5
        Me.chkscan.Text = "Scan"
        Me.chkscan.UseVisualStyleBackColor = True
        '
        'chkecho
        '
        Me.chkecho.AutoSize = True
        Me.chkecho.Location = New System.Drawing.Point(11, 119)
        Me.chkecho.Name = "chkecho"
        Me.chkecho.Size = New System.Drawing.Size(51, 17)
        Me.chkecho.TabIndex = 4
        Me.chkecho.Text = "Echo"
        Me.chkecho.UseVisualStyleBackColor = True
        '
        'chkcolo
        '
        Me.chkcolo.AutoSize = True
        Me.chkcolo.Location = New System.Drawing.Point(11, 96)
        Me.chkcolo.Name = "chkcolo"
        Me.chkcolo.Size = New System.Drawing.Size(75, 17)
        Me.chkcolo.TabIndex = 3
        Me.chkcolo.Text = "Coloscopy"
        Me.chkcolo.UseVisualStyleBackColor = True
        '
        'chknaso
        '
        Me.chknaso.AutoSize = True
        Me.chknaso.Location = New System.Drawing.Point(11, 73)
        Me.chknaso.Name = "chknaso"
        Me.chknaso.Size = New System.Drawing.Size(80, 17)
        Me.chknaso.TabIndex = 2
        Me.chknaso.Text = "Nasogastro"
        Me.chknaso.UseVisualStyleBackColor = True
        '
        'chkfibro
        '
        Me.chkfibro.AutoSize = True
        Me.chkfibro.Location = New System.Drawing.Point(11, 50)
        Me.chkfibro.Name = "chkfibro"
        Me.chkfibro.Size = New System.Drawing.Size(77, 17)
        Me.chkfibro.TabIndex = 1
        Me.chkfibro.Text = "Fibroscopy"
        Me.chkfibro.UseVisualStyleBackColor = True
        '
        'chkbilogy
        '
        Me.chkbilogy.AutoSize = True
        Me.chkbilogy.Location = New System.Drawing.Point(11, 27)
        Me.chkbilogy.Name = "chkbilogy"
        Me.chkbilogy.Size = New System.Drawing.Size(127, 17)
        Me.chkbilogy.TabIndex = 0
        Me.chkbilogy.Text = "Biology(Blood Check)"
        Me.chkbilogy.UseVisualStyleBackColor = True
        '
        'dtrequest
        '
        Me.dtrequest.Checked = False
        Me.dtrequest.CustomFormat = "dd/MM/yyyy"
        Me.dtrequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtrequest.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtrequest.Location = New System.Drawing.Point(406, 20)
        Me.dtrequest.Name = "dtrequest"
        Me.dtrequest.ShowCheckBox = True
        Me.dtrequest.Size = New System.Drawing.Size(131, 26)
        Me.dtrequest.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(319, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date Request:"
        '
        'cbodoctor
        '
        Me.cbodoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbodoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbodoctor.DropDownWidth = 500
        Me.cbodoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodoctor.FormattingEnabled = True
        Me.cbodoctor.Location = New System.Drawing.Point(116, 18)
        Me.cbodoctor.Name = "cbodoctor"
        Me.cbodoctor.Size = New System.Drawing.Size(196, 28)
        Me.cbodoctor.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Request By Dr:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LblSaveOption)
        Me.GroupBox1.Controls.Add(Me.BtnFindPatient)
        Me.GroupBox1.Controls.Add(Me.lblpatientid)
        Me.GroupBox1.Controls.Add(Me.txtno)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.txtaddress)
        Me.GroupBox1.Controls.Add(Me.txtdatebirth)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtsex)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(869, 129)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Information"
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(705, 41)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(13, 13)
        Me.LblSaveOption.TabIndex = 42
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
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
        Me.lblpatientid.Location = New System.Drawing.Point(623, 60)
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
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Location = New System.Drawing.Point(718, 486)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 30)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Location = New System.Drawing.Point(799, 486)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(77, 30)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Err
        '
        Me.Err.ContainerControl = Me
        '
        'lbloption
        '
        Me.lbloption.AutoSize = True
        Me.lbloption.Location = New System.Drawing.Point(13, 495)
        Me.lbloption.Name = "lbloption"
        Me.lbloption.Size = New System.Drawing.Size(13, 13)
        Me.lbloption.TabIndex = 4
        Me.lbloption.Text = "0"
        Me.lbloption.Visible = False
        '
        'MainDocRequestExam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 518)
        Me.Controls.Add(Me.lbloption)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainDocRequestExam"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Doctor Request Examination"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupRequestExam.ResumeLayout(False)
        Me.GroupRequestExam.PerformLayout()
        Me.GBloodCheck.ResumeLayout(False)
        Me.GBloodCheck.PerformLayout()
        CType(Me.itemlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbodoctor As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents dtrequest As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupRequestExam As System.Windows.Forms.GroupBox
    Friend WithEvents chkmri As System.Windows.Forms.CheckBox
    Friend WithEvents chkscan As System.Windows.Forms.CheckBox
    Friend WithEvents chkecho As System.Windows.Forms.CheckBox
    Friend WithEvents chkcolo As System.Windows.Forms.CheckBox
    Friend WithEvents chknaso As System.Windows.Forms.CheckBox
    Friend WithEvents chkfibro As System.Windows.Forms.CheckBox
    Friend WithEvents chkbilogy As System.Windows.Forms.CheckBox
    Friend WithEvents chkfibroscan As System.Windows.Forms.CheckBox
    Friend WithEvents GBloodCheck As System.Windows.Forms.GroupBox
    Friend WithEvents cboitem As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents itemlist As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnDeleteItem As System.Windows.Forms.Button
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents lblpatientid As System.Windows.Forms.Label
    Friend WithEvents Err As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtmoreinfo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BtnFindPatient As System.Windows.Forms.Button
    Friend WithEvents TxtBloodResult As System.Windows.Forms.TextBox
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents lbloption As System.Windows.Forms.Label
    Friend WithEvents CboDiagnosis As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
