<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindPatientExam
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FindPatientExam))
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.btnFind = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtPatientName = New System.Windows.Forms.TextBox
        Me.TxtPatientNo = New System.Windows.Forms.TextBox
        Me.RadPatientName = New System.Windows.Forms.RadioButton
        Me.RadPatientNo = New System.Windows.Forms.RadioButton
        Me.ErrExamHistory = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ChFindHistory = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrExamHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(320, 135)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 26)
        Me.BtnCancel.TabIndex = 5
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFind.Location = New System.Drawing.Point(239, 135)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 26)
        Me.btnFind.TabIndex = 4
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChFindHistory)
        Me.GroupBox1.Controls.Add(Me.TxtPatientName)
        Me.GroupBox1.Controls.Add(Me.TxtPatientNo)
        Me.GroupBox1.Controls.Add(Me.RadPatientName)
        Me.GroupBox1.Controls.Add(Me.RadPatientNo)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 127)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Find By:"
        '
        'TxtPatientName
        '
        Me.TxtPatientName.Enabled = False
        Me.TxtPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientName.Location = New System.Drawing.Point(102, 78)
        Me.TxtPatientName.Name = "TxtPatientName"
        Me.TxtPatientName.Size = New System.Drawing.Size(274, 26)
        Me.TxtPatientName.TabIndex = 3
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.Location = New System.Drawing.Point(102, 42)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(274, 26)
        Me.TxtPatientNo.TabIndex = 2
        '
        'RadPatientName
        '
        Me.RadPatientName.AutoSize = True
        Me.RadPatientName.Location = New System.Drawing.Point(9, 87)
        Me.RadPatientName.Name = "RadPatientName"
        Me.RadPatientName.Size = New System.Drawing.Size(92, 17)
        Me.RadPatientName.TabIndex = 1
        Me.RadPatientName.Text = "Patient Name:"
        Me.RadPatientName.UseVisualStyleBackColor = True
        '
        'RadPatientNo
        '
        Me.RadPatientNo.AutoSize = True
        Me.RadPatientNo.Checked = True
        Me.RadPatientNo.Location = New System.Drawing.Point(9, 51)
        Me.RadPatientNo.Name = "RadPatientNo"
        Me.RadPatientNo.Size = New System.Drawing.Size(78, 17)
        Me.RadPatientNo.TabIndex = 0
        Me.RadPatientNo.TabStop = True
        Me.RadPatientNo.Text = "Patient No:"
        Me.RadPatientNo.UseVisualStyleBackColor = True
        '
        'ErrExamHistory
        '
        Me.ErrExamHistory.ContainerControl = Me
        '
        'ChFindHistory
        '
        Me.ChFindHistory.AutoSize = True
        Me.ChFindHistory.Location = New System.Drawing.Point(9, 19)
        Me.ChFindHistory.Name = "ChFindHistory"
        Me.ChFindHistory.Size = New System.Drawing.Size(96, 17)
        Me.ChFindHistory.TabIndex = 4
        Me.ChFindHistory.Text = "Find By History"
        Me.ChFindHistory.UseVisualStyleBackColor = True
        '
        'FindPatientExam
        '
        Me.AcceptButton = Me.btnFind
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 173)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FindPatientExam"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Find History Exam"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrExamHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents RadPatientName As System.Windows.Forms.RadioButton
    Friend WithEvents RadPatientNo As System.Windows.Forms.RadioButton
    Friend WithEvents ErrExamHistory As System.Windows.Forms.ErrorProvider
    Friend WithEvents ChFindHistory As System.Windows.Forms.CheckBox
End Class
