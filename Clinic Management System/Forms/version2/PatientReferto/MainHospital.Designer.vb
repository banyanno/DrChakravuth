<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainHospital
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
        Dim GridHospital_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainHospital))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnNewHospital = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDelete = New System.Windows.Forms.ToolStripButton
        Me.GridHospital = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridHospital, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewHospital, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.BtnDelete})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(685, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNewHospital
        '
        Me.BtnNewHospital.Image = Global.Clinic_Management_System.My.Resources.Resources.db_add
        Me.BtnNewHospital.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewHospital.Name = "BtnNewHospital"
        Me.BtnNewHospital.Size = New System.Drawing.Size(89, 22)
        Me.BtnNewHospital.Text = "New Hospital"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.Clinic_Management_System.My.Resources.Resources.edit
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(103, 22)
        Me.ToolStripButton2.Text = "Update Hospital"
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
        Me.BtnDelete.Size = New System.Drawing.Size(58, 22)
        Me.BtnDelete.Text = "Delete"
        '
        'GridHospital
        '
        Me.GridHospital.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridHospital_DesignTimeLayout.LayoutString = resources.GetString("GridHospital_DesignTimeLayout.LayoutString")
        Me.GridHospital.DesignTimeLayout = GridHospital_DesignTimeLayout
        Me.GridHospital.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridHospital.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridHospital.GroupByBoxVisible = False
        Me.GridHospital.Location = New System.Drawing.Point(0, 25)
        Me.GridHospital.Name = "GridHospital"
        Me.GridHospital.RecordNavigator = True
        Me.GridHospital.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridHospital.Size = New System.Drawing.Size(685, 281)
        Me.GridHospital.TabIndex = 1
        '
        'MainHospital
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 306)
        Me.Controls.Add(Me.GridHospital)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainHospital"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hospital"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridHospital, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewHospital As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridHospital As Janus.Windows.GridEX.GridEX
End Class
