<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Appointment
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
        Dim AppointmentList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Appointment))
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.BtnNewAppointment = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnfind = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnPatientConsult = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.btnUpdateStatus = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDelete = New System.Windows.Forms.ToolStripButton
        Me.AppointmentList = New Janus.Windows.GridEX.GridEX
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip2.SuspendLayout()
        CType(Me.AppointmentList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnRefresh, Me.ToolStripSeparator3, Me.BtnNewAppointment, Me.ToolStripSeparator1, Me.btnfind, Me.ToolStripSeparator4, Me.BtnPatientConsult, Me.ToolStripSeparator5, Me.btnUpdateStatus, Me.ToolStripSeparator2, Me.BtnDelete})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(974, 32)
        Me.ToolStrip2.TabIndex = 28
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'BtnNewAppointment
        '
        Me.BtnNewAppointment.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewAppointment.ForeColor = System.Drawing.Color.Blue
        Me.BtnNewAppointment.Image = Global.Clinic_Management_System.My.Resources.Resources.new_appointment
        Me.BtnNewAppointment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewAppointment.Name = "BtnNewAppointment"
        Me.BtnNewAppointment.Size = New System.Drawing.Size(95, 29)
        Me.BtnNewAppointment.Text = "Add New"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'btnfind
        '
        Me.btnfind.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfind.ForeColor = System.Drawing.Color.Blue
        Me.btnfind.Image = Global.Clinic_Management_System.My.Resources.Resources.find
        Me.btnfind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(83, 29)
        Me.btnfind.Text = "Search"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 32)
        '
        'BtnPatientConsult
        '
        Me.BtnPatientConsult.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.BtnPatientConsult.ForeColor = System.Drawing.Color.Blue
        Me.BtnPatientConsult.Image = Global.Clinic_Management_System.My.Resources.Resources.Forward
        Me.BtnPatientConsult.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPatientConsult.Name = "BtnPatientConsult"
        Me.BtnPatientConsult.Size = New System.Drawing.Size(179, 29)
        Me.BtnPatientConsult.Text = "Send To Consultation"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 32)
        '
        'btnUpdateStatus
        '
        Me.btnUpdateStatus.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnUpdateStatus.ForeColor = System.Drawing.Color.Blue
        Me.btnUpdateStatus.Image = Global.Clinic_Management_System.My.Resources.Resources.check
        Me.btnUpdateStatus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUpdateStatus.Name = "btnUpdateStatus"
        Me.btnUpdateStatus.Size = New System.Drawing.Size(144, 29)
        Me.btnUpdateStatus.Text = "Appointmen Ready "
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 32)
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.Blue
        Me.BtnDelete.Image = Global.Clinic_Management_System.My.Resources.Resources.delete_appointment
        Me.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(79, 29)
        Me.BtnDelete.Text = "Delete"
        '
        'AppointmentList
        '
        Me.AppointmentList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        AppointmentList_DesignTimeLayout.LayoutString = resources.GetString("AppointmentList_DesignTimeLayout.LayoutString")
        Me.AppointmentList.DesignTimeLayout = AppointmentList_DesignTimeLayout
        Me.AppointmentList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AppointmentList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.AppointmentList.GroupByBoxVisible = False
        Me.AppointmentList.HeaderFormatStyle.Font = New System.Drawing.Font("Khmer OS System", 11.25!)
        Me.AppointmentList.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.AppointmentList.Location = New System.Drawing.Point(0, 32)
        Me.AppointmentList.Name = "AppointmentList"
        Me.AppointmentList.RecordNavigator = True
        Me.AppointmentList.RowFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.AppointmentList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.AppointmentList.Size = New System.Drawing.Size(974, 807)
        Me.AppointmentList.TabIndex = 46
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 32)
        '
        'BtnRefresh
        '
        Me.BtnRefresh.ForeColor = System.Drawing.Color.Blue
        Me.BtnRefresh.Image = Global.Clinic_Management_System.My.Resources.Resources.refresh
        Me.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(74, 29)
        Me.BtnRefresh.Text = "Refresh"
        '
        'Appointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.AppointmentList)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Name = "Appointment"
        Me.Size = New System.Drawing.Size(974, 839)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.AppointmentList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewAppointment As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AppointmentList As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnfind As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPatientConsult As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnUpdateStatus As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator

End Class
