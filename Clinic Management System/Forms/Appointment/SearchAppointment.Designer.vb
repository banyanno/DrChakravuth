<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchAppointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchAppointment))
        Me.dtfrom = New System.Windows.Forms.DateTimePicker
        Me.dtto = New System.Windows.Forms.DateTimePicker
        Me.From = New System.Windows.Forms.Label
        Me.btnFind = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadByPhone = New System.Windows.Forms.RadioButton
        Me.RadByPateintName = New System.Windows.Forms.RadioButton
        Me.RadByPatientNo = New System.Windows.Forms.RadioButton
        Me.TxtPatientNo = New System.Windows.Forms.TextBox
        Me.TxtPatientName = New System.Windows.Forms.TextBox
        Me.TxtPhoneNo = New System.Windows.Forms.TextBox
        Me.RadAll = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtfrom
        '
        Me.dtfrom.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtfrom.CustomFormat = "dd-MM-yyyy"
        Me.dtfrom.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfrom.Location = New System.Drawing.Point(72, 197)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(147, 29)
        Me.dtfrom.TabIndex = 0
        '
        'dtto
        '
        Me.dtto.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtto.CustomFormat = "dd-MM-yyyy"
        Me.dtto.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtto.Location = New System.Drawing.Point(298, 197)
        Me.dtto.Name = "dtto"
        Me.dtto.Size = New System.Drawing.Size(147, 29)
        Me.dtto.TabIndex = 1
        '
        'From
        '
        Me.From.AutoSize = True
        Me.From.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.From.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.From.Location = New System.Drawing.Point(13, 208)
        Me.From.Name = "From"
        Me.From.Size = New System.Drawing.Size(48, 18)
        Me.From.TabIndex = 2
        Me.From.Text = "From:"
        '
        'btnFind
        '
        Me.btnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFind.Font = New System.Drawing.Font("Khmer OS System", 11.25!)
        Me.btnFind.ForeColor = System.Drawing.Color.SlateBlue
        Me.btnFind.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnFind.Location = New System.Drawing.Point(266, 264)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(100, 35)
        Me.btnFind.TabIndex = 2
        Me.btnFind.Text = "ស្វែងរក"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Khmer OS System", 11.25!)
        Me.btnCancel.ForeColor = System.Drawing.Color.SlateBlue
        Me.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCancel.Location = New System.Drawing.Point(372, 264)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 35)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "ចាកចេញ"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(238, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "To:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadAll)
        Me.GroupBox1.Controls.Add(Me.TxtPhoneNo)
        Me.GroupBox1.Controls.Add(Me.TxtPatientName)
        Me.GroupBox1.Controls.Add(Me.TxtPatientNo)
        Me.GroupBox1.Controls.Add(Me.RadByPhone)
        Me.GroupBox1.Controls.Add(Me.RadByPateintName)
        Me.GroupBox1.Controls.Add(Me.RadByPatientNo)
        Me.GroupBox1.Controls.Add(Me.dtfrom)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtto)
        Me.GroupBox1.Controls.Add(Me.From)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 244)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Finding"
        '
        'RadByPhone
        '
        Me.RadByPhone.AutoSize = True
        Me.RadByPhone.Font = New System.Drawing.Font("Khmer OS System", 9.75!)
        Me.RadByPhone.ForeColor = System.Drawing.Color.Black
        Me.RadByPhone.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadByPhone.Location = New System.Drawing.Point(15, 112)
        Me.RadByPhone.Name = "RadByPhone"
        Me.RadByPhone.Size = New System.Drawing.Size(98, 28)
        Me.RadByPhone.TabIndex = 11
        Me.RadByPhone.Text = "លេខទូរស័ព្ទ"
        Me.RadByPhone.UseVisualStyleBackColor = True
        '
        'RadByPateintName
        '
        Me.RadByPateintName.AutoSize = True
        Me.RadByPateintName.Font = New System.Drawing.Font("Khmer OS System", 9.75!)
        Me.RadByPateintName.ForeColor = System.Drawing.Color.Black
        Me.RadByPateintName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadByPateintName.Location = New System.Drawing.Point(15, 71)
        Me.RadByPateintName.Name = "RadByPateintName"
        Me.RadByPateintName.Size = New System.Drawing.Size(105, 28)
        Me.RadByPateintName.TabIndex = 10
        Me.RadByPateintName.Text = "ឈ្មោះអ្នកជម្ងឺ"
        Me.RadByPateintName.UseVisualStyleBackColor = True
        '
        'RadByPatientNo
        '
        Me.RadByPatientNo.AutoSize = True
        Me.RadByPatientNo.Font = New System.Drawing.Font("Khmer OS System", 9.75!)
        Me.RadByPatientNo.ForeColor = System.Drawing.Color.Black
        Me.RadByPatientNo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadByPatientNo.Location = New System.Drawing.Point(15, 34)
        Me.RadByPatientNo.Name = "RadByPatientNo"
        Me.RadByPatientNo.Size = New System.Drawing.Size(107, 28)
        Me.RadByPatientNo.TabIndex = 9
        Me.RadByPatientNo.Text = "លេខសំគាល់ "
        Me.RadByPatientNo.UseVisualStyleBackColor = True
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.Location = New System.Drawing.Point(128, 31)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(316, 29)
        Me.TxtPatientNo.TabIndex = 12
        '
        'TxtPatientName
        '
        Me.TxtPatientName.Enabled = False
        Me.TxtPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientName.Location = New System.Drawing.Point(128, 71)
        Me.TxtPatientName.Name = "TxtPatientName"
        Me.TxtPatientName.Size = New System.Drawing.Size(316, 29)
        Me.TxtPatientName.TabIndex = 13
        '
        'TxtPhoneNo
        '
        Me.TxtPhoneNo.Enabled = False
        Me.TxtPhoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPhoneNo.Location = New System.Drawing.Point(128, 112)
        Me.TxtPhoneNo.Name = "TxtPhoneNo"
        Me.TxtPhoneNo.Size = New System.Drawing.Size(316, 29)
        Me.TxtPhoneNo.TabIndex = 14
        '
        'RadAll
        '
        Me.RadAll.AutoSize = True
        Me.RadAll.Checked = True
        Me.RadAll.Font = New System.Drawing.Font("Khmer OS System", 9.75!)
        Me.RadAll.ForeColor = System.Drawing.Color.Black
        Me.RadAll.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadAll.Location = New System.Drawing.Point(15, 155)
        Me.RadAll.Name = "RadAll"
        Me.RadAll.Size = New System.Drawing.Size(41, 28)
        Me.RadAll.TabIndex = 15
        Me.RadAll.TabStop = True
        Me.RadAll.Text = "All"
        Me.RadAll.UseVisualStyleBackColor = True
        '
        'SearchAppointment
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(485, 309)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnFind)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SearchAppointment"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finding"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtto As System.Windows.Forms.DateTimePicker
    Friend WithEvents From As System.Windows.Forms.Label
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadByPhone As System.Windows.Forms.RadioButton
    Friend WithEvents RadByPateintName As System.Windows.Forms.RadioButton
    Friend WithEvents RadByPatientNo As System.Windows.Forms.RadioButton
    Friend WithEvents RadAll As System.Windows.Forms.RadioButton
    Friend WithEvents TxtPhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientNo As System.Windows.Forms.TextBox
End Class
