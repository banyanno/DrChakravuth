<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMNewUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMNewUser))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CboDepartment = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtVerifyPwd = New System.Windows.Forms.TextBox
        Me.TxtPwd = New System.Windows.Forms.TextBox
        Me.TxtLoginName = New System.Windows.Forms.TextBox
        Me.TxtUserName = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.ErrUser = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.GroupDoctorInfor = New System.Windows.Forms.GroupBox
        Me.lblImgURL = New System.Windows.Forms.Label
        Me.PictDoctorSigne = New System.Windows.Forms.PictureBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtDoctorname = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtphone = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtdesc = New System.Windows.Forms.TextBox
        Me.chIsDoctor = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupDoctorInfor.SuspendLayout()
        CType(Me.PictDoctorSigne, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CboDepartment)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtVerifyPwd)
        Me.GroupBox1.Controls.Add(Me.TxtPwd)
        Me.GroupBox1.Controls.Add(Me.TxtLoginName)
        Me.GroupBox1.Controls.Add(Me.TxtUserName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 279)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Login"
        '
        'CboDepartment
        '
        Me.CboDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDepartment.FormattingEnabled = True
        Me.CboDepartment.Location = New System.Drawing.Point(149, 198)
        Me.CboDepartment.Margin = New System.Windows.Forms.Padding(2)
        Me.CboDepartment.Name = "CboDepartment"
        Me.CboDepartment.Size = New System.Drawing.Size(203, 28)
        Me.CboDepartment.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 208)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Select Department:*"
        '
        'TxtVerifyPwd
        '
        Me.TxtVerifyPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVerifyPwd.Location = New System.Drawing.Point(149, 155)
        Me.TxtVerifyPwd.Name = "TxtVerifyPwd"
        Me.TxtVerifyPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtVerifyPwd.Size = New System.Drawing.Size(203, 26)
        Me.TxtVerifyPwd.TabIndex = 3
        '
        'TxtPwd
        '
        Me.TxtPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPwd.Location = New System.Drawing.Point(149, 110)
        Me.TxtPwd.Name = "TxtPwd"
        Me.TxtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPwd.Size = New System.Drawing.Size(203, 26)
        Me.TxtPwd.TabIndex = 2
        '
        'TxtLoginName
        '
        Me.TxtLoginName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLoginName.Location = New System.Drawing.Point(149, 19)
        Me.TxtLoginName.Name = "TxtLoginName"
        Me.TxtLoginName.Size = New System.Drawing.Size(203, 26)
        Me.TxtLoginName.TabIndex = 0
        '
        'TxtUserName
        '
        Me.TxtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUserName.Location = New System.Drawing.Point(149, 64)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(203, 26)
        Me.TxtUserName.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Verify Password*:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password*:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Login name*:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name of user*:"
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(671, 303)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(82, 27)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(760, 303)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(82, 27)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'ErrUser
        '
        Me.ErrUser.ContainerControl = Me
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(489, 303)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(13, 13)
        Me.LblSaveOption.TabIndex = 3
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'GroupDoctorInfor
        '
        Me.GroupDoctorInfor.Controls.Add(Me.lblImgURL)
        Me.GroupDoctorInfor.Controls.Add(Me.PictDoctorSigne)
        Me.GroupDoctorInfor.Controls.Add(Me.Label9)
        Me.GroupDoctorInfor.Controls.Add(Me.txtDoctorname)
        Me.GroupDoctorInfor.Controls.Add(Me.Label6)
        Me.GroupDoctorInfor.Controls.Add(Me.Label7)
        Me.GroupDoctorInfor.Controls.Add(Me.txtphone)
        Me.GroupDoctorInfor.Controls.Add(Me.Label8)
        Me.GroupDoctorInfor.Controls.Add(Me.txtdesc)
        Me.GroupDoctorInfor.Enabled = False
        Me.GroupDoctorInfor.Location = New System.Drawing.Point(370, 12)
        Me.GroupDoctorInfor.Name = "GroupDoctorInfor"
        Me.GroupDoctorInfor.Size = New System.Drawing.Size(472, 280)
        Me.GroupDoctorInfor.TabIndex = 4
        Me.GroupDoctorInfor.TabStop = False
        '
        'lblImgURL
        '
        Me.lblImgURL.AutoSize = True
        Me.lblImgURL.Location = New System.Drawing.Point(47, 241)
        Me.lblImgURL.Name = "lblImgURL"
        Me.lblImgURL.Size = New System.Drawing.Size(0, 13)
        Me.lblImgURL.TabIndex = 55
        Me.lblImgURL.Visible = False
        '
        'PictDoctorSigne
        '
        Me.PictDoctorSigne.BackColor = System.Drawing.Color.Transparent
        Me.PictDoctorSigne.BackgroundImage = Global.Clinic_Management_System.My.Resources.Resources.Image1
        Me.PictDoctorSigne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictDoctorSigne.Location = New System.Drawing.Point(138, 190)
        Me.PictDoctorSigne.Name = "PictDoctorSigne"
        Me.PictDoctorSigne.Size = New System.Drawing.Size(316, 79)
        Me.PictDoctorSigne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictDoctorSigne.TabIndex = 54
        Me.PictDoctorSigne.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 193)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 20)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Doctor's Signe:"
        '
        'txtDoctorname
        '
        Me.txtDoctorname.BackColor = System.Drawing.Color.White
        Me.txtDoctorname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctorname.Location = New System.Drawing.Point(138, 27)
        Me.txtDoctorname.Name = "txtDoctorname"
        Me.txtDoctorname.Size = New System.Drawing.Size(316, 26)
        Me.txtDoctorname.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Khmer OS System", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(10, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 27)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "ព័ត៏មានបន្ថែម"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Khmer OS System", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(10, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 27)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "ឈ្មោះវេជ្ជបណ្ឌិត"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtphone
        '
        Me.txtphone.BackColor = System.Drawing.Color.White
        Me.txtphone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphone.Location = New System.Drawing.Point(138, 73)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(316, 26)
        Me.txtphone.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Khmer OS System", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(10, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 27)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "លេខទូរស័ព្ទ"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdesc
        '
        Me.txtdesc.BackColor = System.Drawing.Color.White
        Me.txtdesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesc.Location = New System.Drawing.Point(138, 118)
        Me.txtdesc.Multiline = True
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(316, 66)
        Me.txtdesc.TabIndex = 2
        '
        'chIsDoctor
        '
        Me.chIsDoctor.AutoSize = True
        Me.chIsDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chIsDoctor.Location = New System.Drawing.Point(379, 6)
        Me.chIsDoctor.Name = "chIsDoctor"
        Me.chIsDoctor.Size = New System.Drawing.Size(93, 24)
        Me.chIsDoctor.TabIndex = 5
        Me.chIsDoctor.Text = "Is Doctor"
        Me.chIsDoctor.UseVisualStyleBackColor = True
        '
        'FRMNewUser
        '
        Me.AcceptButton = Me.BtnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(857, 338)
        Me.Controls.Add(Me.chIsDoctor)
        Me.Controls.Add(Me.GroupDoctorInfor)
        Me.Controls.Add(Me.LblSaveOption)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMNewUser"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New User"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupDoctorInfor.ResumeLayout(False)
        Me.GroupDoctorInfor.PerformLayout()
        CType(Me.PictDoctorSigne, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtVerifyPwd As System.Windows.Forms.TextBox
    Friend WithEvents TxtPwd As System.Windows.Forms.TextBox
    Friend WithEvents TxtLoginName As System.Windows.Forms.TextBox
    Friend WithEvents TxtUserName As System.Windows.Forms.TextBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents ErrUser As System.Windows.Forms.ErrorProvider
    Friend WithEvents CboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents GroupDoctorInfor As System.Windows.Forms.GroupBox
    Public WithEvents txtDoctorname As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents txtphone As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents PictDoctorSigne As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblImgURL As System.Windows.Forms.Label
    Friend WithEvents chIsDoctor As System.Windows.Forms.CheckBox
End Class
