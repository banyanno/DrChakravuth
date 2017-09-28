<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCConsultationType
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim ConsultTypeList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCConsultationType))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnNewConsultation = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnUpdate = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDelete = New System.Windows.Forms.ToolStripButton
        Me.ConsultTypeList = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ConsultTypeList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(35, 35)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewConsultation, Me.ToolStripSeparator1, Me.BtnUpdate, Me.ToolStripSeparator2, Me.BtnDelete})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(551, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNewConsultation
        '
        Me.BtnNewConsultation.Image = Global.Clinic_Management_System.My.Resources.Resources.add
        Me.BtnNewConsultation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewConsultation.Name = "BtnNewConsultation"
        Me.BtnNewConsultation.Size = New System.Drawing.Size(124, 22)
        Me.BtnNewConsultation.Text = "New Consult Type"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Image = Global.Clinic_Management_System.My.Resources.Resources.edit
        Me.BtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(109, 22)
        Me.BtnUpdate.Text = "Update Consult"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BtnDelete
        '
        Me.BtnDelete.Image = Global.Clinic_Management_System.My.Resources.Resources.delete_appointment
        Me.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(104, 22)
        Me.BtnDelete.Text = "Delete Consult"
        '
        'ConsultTypeList
        '
        Me.ConsultTypeList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        ConsultTypeList_DesignTimeLayout.LayoutString = resources.GetString("ConsultTypeList_DesignTimeLayout.LayoutString")
        Me.ConsultTypeList.DesignTimeLayout = ConsultTypeList_DesignTimeLayout
        Me.ConsultTypeList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConsultTypeList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ConsultTypeList.GroupByBoxVisible = False
        Me.ConsultTypeList.Location = New System.Drawing.Point(0, 25)
        Me.ConsultTypeList.Name = "ConsultTypeList"
        Me.ConsultTypeList.RecordNavigator = True
        Me.ConsultTypeList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.ConsultTypeList.Size = New System.Drawing.Size(551, 377)
        Me.ConsultTypeList.TabIndex = 1
        '
        'UCConsultationType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ConsultTypeList)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "UCConsultationType"
        Me.Size = New System.Drawing.Size(551, 402)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ConsultTypeList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewConsultation As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ConsultTypeList As Janus.Windows.GridEX.GridEX

End Class
