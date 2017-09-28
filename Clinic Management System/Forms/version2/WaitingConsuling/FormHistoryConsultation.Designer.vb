<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHistoryConsultation
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
        Dim GridPrescriptionDetail_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHistoryConsultation))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.TxtPatientName = New System.Windows.Forms.TextBox
        Me.btnFind = New System.Windows.Forms.Button
        Me.TxtPatientNo = New System.Windows.Forms.TextBox
        Me.RadPatientName = New System.Windows.Forms.RadioButton
        Me.RadPatientNo = New System.Windows.Forms.RadioButton
        Me.ErrFindHistoryConsult = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GridPrescriptionDetail = New Janus.Windows.GridEX.GridEX
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrFindHistoryConsult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPrescriptionDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BtnCancel)
        Me.GroupBox1.Controls.Add(Me.TxtPatientName)
        Me.GroupBox1.Controls.Add(Me.btnFind)
        Me.GroupBox1.Controls.Add(Me.TxtPatientNo)
        Me.GroupBox1.Controls.Add(Me.RadPatientName)
        Me.GroupBox1.Controls.Add(Me.RadPatientNo)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(869, 105)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Find History Consult:"
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(379, 55)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 26)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Close"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'TxtPatientName
        '
        Me.TxtPatientName.Enabled = False
        Me.TxtPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientName.Location = New System.Drawing.Point(99, 58)
        Me.TxtPatientName.Name = "TxtPatientName"
        Me.TxtPatientName.Size = New System.Drawing.Size(274, 26)
        Me.TxtPatientName.TabIndex = 3
        '
        'btnFind
        '
        Me.btnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFind.Location = New System.Drawing.Point(379, 23)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 26)
        Me.btnFind.TabIndex = 1
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.Location = New System.Drawing.Point(99, 22)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(274, 26)
        Me.TxtPatientNo.TabIndex = 2
        '
        'RadPatientName
        '
        Me.RadPatientName.AutoSize = True
        Me.RadPatientName.Location = New System.Drawing.Point(6, 67)
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
        Me.RadPatientNo.Location = New System.Drawing.Point(6, 31)
        Me.RadPatientNo.Name = "RadPatientNo"
        Me.RadPatientNo.Size = New System.Drawing.Size(78, 17)
        Me.RadPatientNo.TabIndex = 0
        Me.RadPatientNo.TabStop = True
        Me.RadPatientNo.Text = "Patient No:"
        Me.RadPatientNo.UseVisualStyleBackColor = True
        '
        'ErrFindHistoryConsult
        '
        Me.ErrFindHistoryConsult.ContainerControl = Me
        '
        'GridPrescriptionDetail
        '
        Me.GridPrescriptionDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridPrescriptionDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridPrescriptionDetail.BlendColor = System.Drawing.SystemColors.Control
        GridPrescriptionDetail_DesignTimeLayout.LayoutString = resources.GetString("GridPrescriptionDetail_DesignTimeLayout.LayoutString")
        Me.GridPrescriptionDetail.DesignTimeLayout = GridPrescriptionDetail_DesignTimeLayout
        Me.GridPrescriptionDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridPrescriptionDetail.GroupByBoxVisible = False
        Me.GridPrescriptionDetail.HeaderFormatStyle.FontSize = 10.0!
        Me.GridPrescriptionDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridPrescriptionDetail.Location = New System.Drawing.Point(2, 117)
        Me.GridPrescriptionDetail.Name = "GridPrescriptionDetail"
        Me.GridPrescriptionDetail.RecordNavigator = True
        Me.GridPrescriptionDetail.SelectedInactiveFormatStyle.BackColor = System.Drawing.SystemColors.Highlight
        Me.GridPrescriptionDetail.SelectedInactiveFormatStyle.ForeColor = System.Drawing.SystemColors.Window
        Me.GridPrescriptionDetail.Size = New System.Drawing.Size(870, 197)
        Me.GridPrescriptionDetail.TabIndex = 2
        '
        'FormHistoryConsultation
        '
        Me.AcceptButton = Me.btnFind
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 314)
        Me.Controls.Add(Me.GridPrescriptionDetail)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormHistoryConsultation"
        Me.ShowInTaskbar = False
        Me.Text = "Find History"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrFindHistoryConsult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPrescriptionDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadPatientNo As System.Windows.Forms.RadioButton
    Friend WithEvents RadPatientName As System.Windows.Forms.RadioButton
    Friend WithEvents TxtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents ErrFindHistoryConsult As System.Windows.Forms.ErrorProvider
    Friend WithEvents GridPrescriptionDetail As Janus.Windows.GridEX.GridEX
End Class
