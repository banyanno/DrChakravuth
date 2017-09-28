<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParaExam
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
        Dim ParaList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ParaExam))
        Me.cboexamination = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnRemove = New System.Windows.Forms.Button
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.ParaList = New Janus.Windows.GridEX.GridEX
        Me.BtnFinish = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        CType(Me.ParaList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboexamination
        '
        Me.cboexamination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboexamination.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.cboexamination.FormattingEnabled = True
        Me.cboexamination.Location = New System.Drawing.Point(140, 53)
        Me.cboexamination.Name = "cboexamination"
        Me.cboexamination.Size = New System.Drawing.Size(279, 30)
        Me.cboexamination.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(33, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 22)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Examination"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(124, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 24)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Select Para Examination Conducted"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnRemove
        '
        Me.BtnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemove.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.BtnRemove.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRemove.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnRemove.Location = New System.Drawing.Point(515, 52)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(80, 32)
        Me.BtnRemove.TabIndex = 2
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.BtnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnAdd.Location = New System.Drawing.Point(427, 52)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(81, 32)
        Me.BtnAdd.TabIndex = 1
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'ParaList
        '
        Me.ParaList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        ParaList_DesignTimeLayout.LayoutString = resources.GetString("ParaList_DesignTimeLayout.LayoutString")
        Me.ParaList.DesignTimeLayout = ParaList_DesignTimeLayout
        Me.ParaList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParaList.GroupByBoxVisible = False
        Me.ParaList.HeaderFormatStyle.FontSize = 10.0!
        Me.ParaList.Location = New System.Drawing.Point(6, 99)
        Me.ParaList.Name = "ParaList"
        Me.ParaList.RecordNavigator = True
        Me.ParaList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.ParaList.Size = New System.Drawing.Size(606, 220)
        Me.ParaList.TabIndex = 3
        '
        'BtnFinish
        '
        Me.BtnFinish.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFinish.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.BtnFinish.ForeColor = System.Drawing.Color.Blue
        Me.BtnFinish.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFinish.Location = New System.Drawing.Point(396, 325)
        Me.BtnFinish.Name = "BtnFinish"
        Me.BtnFinish.Size = New System.Drawing.Size(105, 37)
        Me.BtnFinish.TabIndex = 4
        Me.BtnFinish.Text = "Complete"
        Me.BtnFinish.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.BtnCancel.ForeColor = System.Drawing.Color.Blue
        Me.BtnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnCancel.Location = New System.Drawing.Point(507, 325)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(105, 37)
        Me.BtnCancel.TabIndex = 5
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'ParaExam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 363)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnFinish)
        Me.Controls.Add(Me.ParaList)
        Me.Controls.Add(Me.cboexamination)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnAdd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ParaExam"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ParaExam"
        CType(Me.ParaList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboexamination As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnRemove As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents ParaList As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnFinish As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
End Class
