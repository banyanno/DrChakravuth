<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIssueReceipt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormIssueReceipt))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.LblValMedicine = New System.Windows.Forms.Label
        Me.LblValParaExam = New System.Windows.Forms.Label
        Me.LblValConsult = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.TxtDeposit = New System.Windows.Forms.TextBox
        Me.txtcash = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtdiscount = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtexchangerate = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txttotalusd = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtsubtotalusd = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtSubtotalriel = New System.Windows.Forms.TextBox
        Me.txtchange = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtno = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtdatebirth = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtsex = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.ChDisMedicine = New System.Windows.Forms.CheckBox
        Me.TxtDisMedicine = New System.Windows.Forms.TextBox
        Me.ChDisPara = New System.Windows.Forms.CheckBox
        Me.TxtDisParaExam = New System.Windows.Forms.TextBox
        Me.ChDisConsult = New System.Windows.Forms.CheckBox
        Me.TxtDisConsult = New System.Windows.Forms.TextBox
        Me.ErrIssueReceipt = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.ErrIssueReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.LblValMedicine)
        Me.GroupBox2.Controls.Add(Me.LblValParaExam)
        Me.GroupBox2.Controls.Add(Me.LblValConsult)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(434, 111)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(377, 207)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Service Charge On"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(351, 147)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(18, 20)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "$"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(351, 106)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(18, 20)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "$"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(351, 62)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 20)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "$"
        '
        'LblValMedicine
        '
        Me.LblValMedicine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblValMedicine.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValMedicine.ForeColor = System.Drawing.Color.Blue
        Me.LblValMedicine.Location = New System.Drawing.Point(140, 135)
        Me.LblValMedicine.Name = "LblValMedicine"
        Me.LblValMedicine.Size = New System.Drawing.Size(205, 32)
        Me.LblValMedicine.TabIndex = 2
        Me.LblValMedicine.Text = "0"
        Me.LblValMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblValParaExam
        '
        Me.LblValParaExam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblValParaExam.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValParaExam.ForeColor = System.Drawing.Color.Blue
        Me.LblValParaExam.Location = New System.Drawing.Point(140, 93)
        Me.LblValParaExam.Name = "LblValParaExam"
        Me.LblValParaExam.Size = New System.Drawing.Size(205, 33)
        Me.LblValParaExam.TabIndex = 1
        Me.LblValParaExam.Text = "0"
        Me.LblValParaExam.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblValConsult
        '
        Me.LblValConsult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblValConsult.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValConsult.ForeColor = System.Drawing.Color.Blue
        Me.LblValConsult.Location = New System.Drawing.Point(140, 53)
        Me.LblValConsult.Name = "LblValConsult"
        Me.LblValConsult.Size = New System.Drawing.Size(205, 29)
        Me.LblValConsult.TabIndex = 0
        Me.LblValConsult.Text = "0"
        Me.LblValConsult.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Medicine: ="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Para Exam: ="
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Consultation: ="
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.TxtDeposit)
        Me.GroupBox3.Controls.Add(Me.txtcash)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtexchangerate)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(9, 112)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(823, 333)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Receipt Info $"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(10, 82)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 20)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Deposit:"
        '
        'TxtDeposit
        '
        Me.TxtDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDeposit.Location = New System.Drawing.Point(143, 67)
        Me.TxtDeposit.Name = "TxtDeposit"
        Me.TxtDeposit.Size = New System.Drawing.Size(238, 35)
        Me.TxtDeposit.TabIndex = 1
        Me.TxtDeposit.Text = "0"
        Me.TxtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtcash
        '
        Me.txtcash.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtcash.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcash.Location = New System.Drawing.Point(143, 26)
        Me.txtcash.Name = "txtcash"
        Me.txtcash.Size = New System.Drawing.Size(238, 35)
        Me.txtcash.TabIndex = 0
        Me.txtcash.Text = "0"
        Me.txtcash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(216, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Total Dicount"
        '
        'txtdiscount
        '
        Me.txtdiscount.BackColor = System.Drawing.SystemColors.Control
        Me.txtdiscount.Enabled = False
        Me.txtdiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiscount.Location = New System.Drawing.Point(20, 162)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.Size = New System.Drawing.Size(182, 35)
        Me.txtdiscount.TabIndex = 2
        Me.txtdiscount.Text = "0"
        Me.txtdiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 20)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Cash Received:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(409, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Exchange Rate:"
        '
        'txtexchangerate
        '
        Me.txtexchangerate.Enabled = False
        Me.txtexchangerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtexchangerate.Location = New System.Drawing.Point(542, 26)
        Me.txtexchangerate.Name = "txtexchangerate"
        Me.txtexchangerate.ReadOnly = True
        Me.txtexchangerate.Size = New System.Drawing.Size(238, 35)
        Me.txtexchangerate.TabIndex = 3
        Me.txtexchangerate.Text = "4100"
        Me.txtexchangerate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txttotalusd)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtsubtotalusd)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.txtSubtotalriel)
        Me.GroupBox4.Controls.Add(Me.txtchange)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 452)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(825, 206)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'txttotalusd
        '
        Me.txttotalusd.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalusd.ForeColor = System.Drawing.Color.Blue
        Me.txttotalusd.Location = New System.Drawing.Point(545, 18)
        Me.txttotalusd.Name = "txttotalusd"
        Me.txttotalusd.ReadOnly = True
        Me.txttotalusd.Size = New System.Drawing.Size(240, 35)
        Me.txttotalusd.TabIndex = 0
        Me.txttotalusd.Text = "0"
        Me.txttotalusd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(411, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 20)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Sub Total (KHR):"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(411, 172)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Change(USD):"
        '
        'txtsubtotalusd
        '
        Me.txtsubtotalusd.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubtotalusd.ForeColor = System.Drawing.Color.Blue
        Me.txtsubtotalusd.Location = New System.Drawing.Point(545, 65)
        Me.txtsubtotalusd.Name = "txtsubtotalusd"
        Me.txtsubtotalusd.ReadOnly = True
        Me.txtsubtotalusd.Size = New System.Drawing.Size(240, 35)
        Me.txtsubtotalusd.TabIndex = 2
        Me.txtsubtotalusd.Text = "0"
        Me.txtsubtotalusd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(412, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Total (USD):"
        '
        'txtSubtotalriel
        '
        Me.txtSubtotalriel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotalriel.ForeColor = System.Drawing.Color.Blue
        Me.txtSubtotalriel.Location = New System.Drawing.Point(545, 111)
        Me.txtSubtotalriel.Name = "txtSubtotalriel"
        Me.txtSubtotalriel.ReadOnly = True
        Me.txtSubtotalriel.Size = New System.Drawing.Size(240, 35)
        Me.txtSubtotalriel.TabIndex = 3
        Me.txtSubtotalriel.Text = "0"
        Me.txtSubtotalriel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtchange
        '
        Me.txtchange.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchange.ForeColor = System.Drawing.Color.Blue
        Me.txtchange.Location = New System.Drawing.Point(545, 159)
        Me.txtchange.Name = "txtchange"
        Me.txtchange.ReadOnly = True
        Me.txtchange.Size = New System.Drawing.Size(240, 35)
        Me.txtchange.TabIndex = 1
        Me.txtchange.Text = "0"
        Me.txtchange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(411, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Sub Total (USD):"
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(623, 669)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 35)
        Me.BtnSave.TabIndex = 3
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Location = New System.Drawing.Point(729, 669)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(103, 35)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtno)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.txtdatebirth)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtsex)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(823, 106)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Information"
        '
        'txtno
        '
        Me.txtno.BackColor = System.Drawing.Color.White
        Me.txtno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtno.Location = New System.Drawing.Point(112, 28)
        Me.txtno.Name = "txtno"
        Me.txtno.ReadOnly = True
        Me.txtno.Size = New System.Drawing.Size(297, 26)
        Me.txtno.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Khmer OS System", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(7, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 27)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Name"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(7, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 30)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Patient No:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.White
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(112, 66)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(298, 26)
        Me.txtname.TabIndex = 1
        '
        'txtdatebirth
        '
        Me.txtdatebirth.BackColor = System.Drawing.Color.White
        Me.txtdatebirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdatebirth.Location = New System.Drawing.Point(529, 66)
        Me.txtdatebirth.Name = "txtdatebirth"
        Me.txtdatebirth.ReadOnly = True
        Me.txtdatebirth.Size = New System.Drawing.Size(134, 26)
        Me.txtdatebirth.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Khmer OS System", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(425, 69)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 27)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Date Of Birth"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtsex
        '
        Me.txtsex.BackColor = System.Drawing.Color.White
        Me.txtsex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsex.Location = New System.Drawing.Point(721, 65)
        Me.txtsex.Name = "txtsex"
        Me.txtsex.ReadOnly = True
        Me.txtsex.Size = New System.Drawing.Size(66, 26)
        Me.txtsex.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(676, 65)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 30)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Sex"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ChDisMedicine)
        Me.GroupBox5.Controls.Add(Me.TxtDisMedicine)
        Me.GroupBox5.Controls.Add(Me.ChDisPara)
        Me.GroupBox5.Controls.Add(Me.TxtDisParaExam)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.txtdiscount)
        Me.GroupBox5.Controls.Add(Me.ChDisConsult)
        Me.GroupBox5.Controls.Add(Me.TxtDisConsult)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(13, 110)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(415, 207)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Discount On $"
        '
        'ChDisMedicine
        '
        Me.ChDisMedicine.AutoSize = True
        Me.ChDisMedicine.Location = New System.Drawing.Point(220, 127)
        Me.ChDisMedicine.Name = "ChDisMedicine"
        Me.ChDisMedicine.Size = New System.Drawing.Size(147, 24)
        Me.ChDisMedicine.TabIndex = 6
        Me.ChDisMedicine.Text = "Dis-For Medicine"
        Me.ChDisMedicine.UseVisualStyleBackColor = True
        '
        'TxtDisMedicine
        '
        Me.TxtDisMedicine.Enabled = False
        Me.TxtDisMedicine.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDisMedicine.Location = New System.Drawing.Point(20, 116)
        Me.TxtDisMedicine.Name = "TxtDisMedicine"
        Me.TxtDisMedicine.Size = New System.Drawing.Size(182, 35)
        Me.TxtDisMedicine.TabIndex = 5
        Me.TxtDisMedicine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ChDisPara
        '
        Me.ChDisPara.AutoSize = True
        Me.ChDisPara.Location = New System.Drawing.Point(220, 83)
        Me.ChDisPara.Name = "ChDisPara"
        Me.ChDisPara.Size = New System.Drawing.Size(161, 24)
        Me.ChDisPara.TabIndex = 4
        Me.ChDisPara.Text = "Dis-For Para Exam"
        Me.ChDisPara.UseVisualStyleBackColor = True
        '
        'TxtDisParaExam
        '
        Me.TxtDisParaExam.Enabled = False
        Me.TxtDisParaExam.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDisParaExam.Location = New System.Drawing.Point(20, 72)
        Me.TxtDisParaExam.Name = "TxtDisParaExam"
        Me.TxtDisParaExam.Size = New System.Drawing.Size(182, 35)
        Me.TxtDisParaExam.TabIndex = 3
        Me.TxtDisParaExam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ChDisConsult
        '
        Me.ChDisConsult.AutoSize = True
        Me.ChDisConsult.Location = New System.Drawing.Point(220, 42)
        Me.ChDisConsult.Name = "ChDisConsult"
        Me.ChDisConsult.Size = New System.Drawing.Size(173, 24)
        Me.ChDisConsult.TabIndex = 2
        Me.ChDisConsult.Text = "Dis-For Consultation"
        Me.ChDisConsult.UseVisualStyleBackColor = True
        '
        'TxtDisConsult
        '
        Me.TxtDisConsult.Enabled = False
        Me.TxtDisConsult.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDisConsult.Location = New System.Drawing.Point(20, 31)
        Me.TxtDisConsult.Name = "TxtDisConsult"
        Me.TxtDisConsult.Size = New System.Drawing.Size(182, 35)
        Me.TxtDisConsult.TabIndex = 0
        Me.TxtDisConsult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ErrIssueReceipt
        '
        Me.ErrIssueReceipt.ContainerControl = Me
        '
        'FormIssueReceipt
        '
        Me.AcceptButton = Me.BtnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 709)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormIssueReceipt"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Issue Receipt"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.ErrIssueReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblValMedicine As System.Windows.Forms.Label
    Friend WithEvents LblValParaExam As System.Windows.Forms.Label
    Friend WithEvents LblValConsult As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtsubtotalusd As System.Windows.Forms.TextBox
    Friend WithEvents txttotalusd As System.Windows.Forms.TextBox
    Friend WithEvents txtSubtotalriel As System.Windows.Forms.TextBox
    Friend WithEvents txtcash As System.Windows.Forms.TextBox
    Friend WithEvents txtexchangerate As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtchange As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtno As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtdatebirth As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtsex As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TxtDeposit As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDisConsult As System.Windows.Forms.TextBox
    Friend WithEvents ChDisConsult As System.Windows.Forms.CheckBox
    Friend WithEvents ChDisMedicine As System.Windows.Forms.CheckBox
    Friend WithEvents TxtDisMedicine As System.Windows.Forms.TextBox
    Friend WithEvents ChDisPara As System.Windows.Forms.CheckBox
    Friend WithEvents TxtDisParaExam As System.Windows.Forms.TextBox
    Friend WithEvents ErrIssueReceipt As System.Windows.Forms.ErrorProvider
End Class
