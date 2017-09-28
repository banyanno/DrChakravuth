<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPatientReferto
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
        Dim GridPatientHospitalReferal_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPatientReferto))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnUpdate = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnCreatePlace = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDelete = New System.Windows.Forms.ToolStripButton
        Me.GridPatientHospitalReferal = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridPatientHospitalReferal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripSeparator1, Me.BtnUpdate, Me.ToolStripSeparator2, Me.BtnCreatePlace, Me.ToolStripSeparator3, Me.BtnDelete})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(736, 32)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Image = Global.Clinic_Management_System.My.Resources.Resources.refresh
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(86, 29)
        Me.ToolStripButton2.Text = "Refresh"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.ForeColor = System.Drawing.Color.Magenta
        Me.BtnUpdate.Image = Global.Clinic_Management_System.My.Resources.Resources.wheelchair
        Me.BtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(175, 29)
        Me.BtnUpdate.Text = "Update Patient Refer"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 32)
        '
        'BtnCreatePlace
        '
        Me.BtnCreatePlace.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreatePlace.ForeColor = System.Drawing.Color.Magenta
        Me.BtnCreatePlace.Image = Global.Clinic_Management_System.My.Resources.Resources.country
        Me.BtnCreatePlace.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCreatePlace.Name = "BtnCreatePlace"
        Me.BtnCreatePlace.Size = New System.Drawing.Size(122, 29)
        Me.BtnCreatePlace.Text = "Referal Place"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 32)
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.Magenta
        Me.BtnDelete.Image = Global.Clinic_Management_System.My.Resources.Resources.delete_appointment
        Me.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(129, 29)
        Me.BtnDelete.Text = "Delete Referal"
        '
        'GridPatientHospitalReferal
        '
        Me.GridPatientHospitalReferal.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridPatientHospitalReferal_DesignTimeLayout.LayoutString = resources.GetString("GridPatientHospitalReferal_DesignTimeLayout.LayoutString")
        Me.GridPatientHospitalReferal.DesignTimeLayout = GridPatientHospitalReferal_DesignTimeLayout
        Me.GridPatientHospitalReferal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPatientHospitalReferal.GroupByBoxVisible = False
        Me.GridPatientHospitalReferal.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridPatientHospitalReferal.Location = New System.Drawing.Point(0, 32)
        Me.GridPatientHospitalReferal.Name = "GridPatientHospitalReferal"
        Me.GridPatientHospitalReferal.RecordNavigator = True
        Me.GridPatientHospitalReferal.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridPatientHospitalReferal.Size = New System.Drawing.Size(736, 441)
        Me.GridPatientHospitalReferal.TabIndex = 1
        '
        'MainPatientReferto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridPatientHospitalReferal)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "MainPatientReferto"
        Me.Size = New System.Drawing.Size(736, 473)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridPatientHospitalReferal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnCreatePlace As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridPatientHospitalReferal As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDelete As System.Windows.Forms.ToolStripButton

End Class
