<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindPatient
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
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnFind = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CboAddress = New System.Windows.Forms.ComboBox
        Me.RadAddress = New System.Windows.Forms.RadioButton
        Me.TxtByPhone = New System.Windows.Forms.TextBox
        Me.RadByPhone = New System.Windows.Forms.RadioButton
        Me.TxtByPatientName = New System.Windows.Forms.TextBox
        Me.TxtByPatientNo = New System.Windows.Forms.TextBox
        Me.RadByPateintName = New System.Windows.Forms.RadioButton
        Me.RadByPatientNo = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Font = New System.Drawing.Font("Khmer OS System", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Blue
        Me.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDelete.Location = New System.Drawing.Point(352, 227)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 32)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "ចាកចេញ"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFind.Font = New System.Drawing.Font("Khmer OS System", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.ForeColor = System.Drawing.Color.Blue
        Me.btnFind.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnFind.Location = New System.Drawing.Point(254, 227)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(90, 32)
        Me.btnFind.TabIndex = 1
        Me.btnFind.Text = "ស្វែងរក"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CboAddress)
        Me.GroupBox1.Controls.Add(Me.RadAddress)
        Me.GroupBox1.Controls.Add(Me.TxtByPhone)
        Me.GroupBox1.Controls.Add(Me.RadByPhone)
        Me.GroupBox1.Controls.Add(Me.TxtByPatientName)
        Me.GroupBox1.Controls.Add(Me.TxtByPatientNo)
        Me.GroupBox1.Controls.Add(Me.RadByPateintName)
        Me.GroupBox1.Controls.Add(Me.RadByPatientNo)
        Me.GroupBox1.Font = New System.Drawing.Font("Khmer OS System", 11.25!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(6, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(436, 209)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ស្វែងរកតាមរយៈ"
        '
        'CboAddress
        '
        Me.CboAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboAddress.Enabled = False
        Me.CboAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboAddress.FormattingEnabled = True
        Me.CboAddress.Location = New System.Drawing.Point(130, 163)
        Me.CboAddress.Name = "CboAddress"
        Me.CboAddress.Size = New System.Drawing.Size(281, 32)
        Me.CboAddress.TabIndex = 38
        '
        'RadAddress
        '
        Me.RadAddress.AutoSize = True
        Me.RadAddress.Font = New System.Drawing.Font("Khmer OS System", 9.75!)
        Me.RadAddress.ForeColor = System.Drawing.Color.Black
        Me.RadAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadAddress.Location = New System.Drawing.Point(15, 165)
        Me.RadAddress.Name = "RadAddress"
        Me.RadAddress.Size = New System.Drawing.Size(98, 28)
        Me.RadAddress.TabIndex = 8
        Me.RadAddress.TabStop = True
        Me.RadAddress.Text = "អាស័យដ្ឋាន"
        Me.RadAddress.UseVisualStyleBackColor = True
        '
        'TxtByPhone
        '
        Me.TxtByPhone.Enabled = False
        Me.TxtByPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtByPhone.Location = New System.Drawing.Point(130, 116)
        Me.TxtByPhone.Name = "TxtByPhone"
        Me.TxtByPhone.Size = New System.Drawing.Size(281, 29)
        Me.TxtByPhone.TabIndex = 2
        '
        'RadByPhone
        '
        Me.RadByPhone.AutoSize = True
        Me.RadByPhone.Font = New System.Drawing.Font("Khmer OS System", 9.75!)
        Me.RadByPhone.ForeColor = System.Drawing.Color.Black
        Me.RadByPhone.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadByPhone.Location = New System.Drawing.Point(13, 122)
        Me.RadByPhone.Name = "RadByPhone"
        Me.RadByPhone.Size = New System.Drawing.Size(98, 28)
        Me.RadByPhone.TabIndex = 6
        Me.RadByPhone.TabStop = True
        Me.RadByPhone.Text = "លេខទូរស័ព្ទ"
        Me.RadByPhone.UseVisualStyleBackColor = True
        '
        'TxtByPatientName
        '
        Me.TxtByPatientName.Enabled = False
        Me.TxtByPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtByPatientName.Location = New System.Drawing.Point(130, 72)
        Me.TxtByPatientName.Name = "TxtByPatientName"
        Me.TxtByPatientName.Size = New System.Drawing.Size(281, 29)
        Me.TxtByPatientName.TabIndex = 1
        '
        'TxtByPatientNo
        '
        Me.TxtByPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtByPatientNo.Location = New System.Drawing.Point(130, 28)
        Me.TxtByPatientNo.Name = "TxtByPatientNo"
        Me.TxtByPatientNo.Size = New System.Drawing.Size(281, 29)
        Me.TxtByPatientNo.TabIndex = 0
        '
        'RadByPateintName
        '
        Me.RadByPateintName.AutoSize = True
        Me.RadByPateintName.Font = New System.Drawing.Font("Khmer OS System", 9.75!)
        Me.RadByPateintName.ForeColor = System.Drawing.Color.Black
        Me.RadByPateintName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadByPateintName.Location = New System.Drawing.Point(15, 78)
        Me.RadByPateintName.Name = "RadByPateintName"
        Me.RadByPateintName.Size = New System.Drawing.Size(105, 28)
        Me.RadByPateintName.TabIndex = 1
        Me.RadByPateintName.TabStop = True
        Me.RadByPateintName.Text = "ឈ្មោះអ្នកជម្ងឺ"
        Me.RadByPateintName.UseVisualStyleBackColor = True
        '
        'RadByPatientNo
        '
        Me.RadByPatientNo.AutoSize = True
        Me.RadByPatientNo.Checked = True
        Me.RadByPatientNo.Font = New System.Drawing.Font("Khmer OS System", 9.75!)
        Me.RadByPatientNo.ForeColor = System.Drawing.Color.Black
        Me.RadByPatientNo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadByPatientNo.Location = New System.Drawing.Point(13, 34)
        Me.RadByPatientNo.Name = "RadByPatientNo"
        Me.RadByPatientNo.Size = New System.Drawing.Size(107, 28)
        Me.RadByPatientNo.TabIndex = 0
        Me.RadByPatientNo.TabStop = True
        Me.RadByPatientNo.Text = "លេខសំគាល់ "
        Me.RadByPatientNo.UseVisualStyleBackColor = True
        '
        'FindPatient
        '
        Me.AcceptButton = Me.btnFind
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(463, 270)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnFind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FindPatient"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Find Patient"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CboAddress As System.Windows.Forms.ComboBox
    Friend WithEvents RadAddress As System.Windows.Forms.RadioButton
    Friend WithEvents TxtByPhone As System.Windows.Forms.TextBox
    Friend WithEvents RadByPhone As System.Windows.Forms.RadioButton
    Friend WithEvents TxtByPatientName As System.Windows.Forms.TextBox
    Friend WithEvents TxtByPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents RadByPateintName As System.Windows.Forms.RadioButton
    Friend WithEvents RadByPatientNo As System.Windows.Forms.RadioButton
End Class
