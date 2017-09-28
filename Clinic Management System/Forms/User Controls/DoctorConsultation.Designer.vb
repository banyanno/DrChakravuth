<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoctorConsultation
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
        Me.components = New System.ComponentModel.Container
        Dim GridWaitingConsultation_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DoctorConsultation))
        Dim GridEXSymptom_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnHistory = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnrefresh = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.btnPrescription = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnConsultationService = New System.Windows.Forms.ToolStripButton
        Me.SplitConsultationService = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GridWaitingConsultation = New Janus.Windows.GridEX.GridEX
        Me.btnfind = New System.Windows.Forms.PictureBox
        Me.txtPatientNo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GridEXSymptom = New Janus.Windows.GridEX.GridEX
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbodate = New System.Windows.Forms.ComboBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SeparatorCommand6 = New Janus.Windows.Ribbon.SeparatorCommand
        Me.ToolStrip1.SuspendLayout()
        Me.SplitConsultationService.Panel1.SuspendLayout()
        Me.SplitConsultationService.Panel2.SuspendLayout()
        Me.SplitConsultationService.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridWaitingConsultation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnfind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridEXSymptom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.AliceBlue
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.BtnHistory, Me.ToolStripSeparator2, Me.btnrefresh, Me.ToolStripSeparator9, Me.btnPrescription, Me.ToolStripSeparator3, Me.BtnConsultationService})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(974, 32)
        Me.ToolStrip1.TabIndex = 30
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'BtnHistory
        '
        Me.BtnHistory.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHistory.ForeColor = System.Drawing.Color.Magenta
        Me.BtnHistory.Image = Global.Clinic_Management_System.My.Resources.Resources.add
        Me.BtnHistory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnHistory.Name = "BtnHistory"
        Me.BtnHistory.Size = New System.Drawing.Size(166, 29)
        Me.BtnHistory.Text = "New Appointment"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 32)
        '
        'btnrefresh
        '
        Me.btnrefresh.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.ForeColor = System.Drawing.Color.Magenta
        Me.btnrefresh.Image = Global.Clinic_Management_System.My.Resources.Resources.refresh
        Me.btnrefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(181, 29)
        Me.btnrefresh.Text = "Refresh Waiting List"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 32)
        '
        'btnPrescription
        '
        Me.btnPrescription.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrescription.ForeColor = System.Drawing.Color.Magenta
        Me.btnPrescription.Image = Global.Clinic_Management_System.My.Resources.Resources.edit
        Me.btnPrescription.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrescription.Name = "btnPrescription"
        Me.btnPrescription.Size = New System.Drawing.Size(159, 29)
        Me.btnPrescription.Text = "New Prescription"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 32)
        '
        'BtnConsultationService
        '
        Me.BtnConsultationService.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultationService.ForeColor = System.Drawing.Color.Magenta
        Me.BtnConsultationService.Image = Global.Clinic_Management_System.My.Resources.Resources._1342235074_navigation_down_button_blue
        Me.BtnConsultationService.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnConsultationService.Name = "BtnConsultationService"
        Me.BtnConsultationService.Size = New System.Drawing.Size(187, 29)
        Me.BtnConsultationService.Text = "Consultation Service"
        '
        'SplitConsultationService
        '
        Me.SplitConsultationService.BackColor = System.Drawing.Color.AliceBlue
        Me.SplitConsultationService.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitConsultationService.Font = New System.Drawing.Font("Khmer OS System", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SplitConsultationService.Location = New System.Drawing.Point(0, 32)
        Me.SplitConsultationService.Name = "SplitConsultationService"
        Me.SplitConsultationService.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitConsultationService.Panel1
        '
        Me.SplitConsultationService.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitConsultationService.Panel2
        '
        Me.SplitConsultationService.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitConsultationService.Panel2.Font = New System.Drawing.Font("Khmer OS System", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SplitConsultationService.Size = New System.Drawing.Size(974, 571)
        Me.SplitConsultationService.SplitterDistance = 395
        Me.SplitConsultationService.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox1.Controls.Add(Me.GridWaitingConsultation)
        Me.GroupBox1.Controls.Add(Me.btnfind)
        Me.GroupBox1.Controls.Add(Me.txtPatientNo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(974, 395)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'GridWaitingConsultation
        '
        Me.GridWaitingConsultation.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridWaitingConsultation_DesignTimeLayout.LayoutString = resources.GetString("GridWaitingConsultation_DesignTimeLayout.LayoutString")
        Me.GridWaitingConsultation.DesignTimeLayout = GridWaitingConsultation_DesignTimeLayout
        Me.GridWaitingConsultation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridWaitingConsultation.Font = New System.Drawing.Font("Khmer OS System", 11.25!)
        Me.GridWaitingConsultation.GroupByBoxVisible = False
        Me.GridWaitingConsultation.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridWaitingConsultation.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridWaitingConsultation.Location = New System.Drawing.Point(3, 58)
        Me.GridWaitingConsultation.Name = "GridWaitingConsultation"
        Me.GridWaitingConsultation.RecordNavigator = True
        Me.GridWaitingConsultation.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridWaitingConsultation.Size = New System.Drawing.Size(968, 334)
        Me.GridWaitingConsultation.TabIndex = 39
        Me.GridWaitingConsultation.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'btnfind
        '
        Me.btnfind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnfind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfind.Image = Global.Clinic_Management_System.My.Resources.Resources.find
        Me.btnfind.Location = New System.Drawing.Point(340, 28)
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(26, 24)
        Me.btnfind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnfind.TabIndex = 38
        Me.btnfind.TabStop = False
        '
        'txtPatientNo
        '
        Me.txtPatientNo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientNo.Location = New System.Drawing.Point(147, 27)
        Me.txtPatientNo.Name = "txtPatientNo"
        Me.txtPatientNo.Size = New System.Drawing.Size(187, 25)
        Me.txtPatientNo.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label2.Location = New System.Drawing.Point(3, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 27)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Find By Patient ID :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox2.Controls.Add(Me.GridEXSymptom)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cbodate)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(974, 172)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'GridEXSymptom
        '
        Me.GridEXSymptom.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXSymptom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridEXSymptom_DesignTimeLayout.LayoutString = resources.GetString("GridEXSymptom_DesignTimeLayout.LayoutString")
        Me.GridEXSymptom.DesignTimeLayout = GridEXSymptom_DesignTimeLayout
        Me.GridEXSymptom.GroupByBoxVisible = False
        Me.GridEXSymptom.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridEXSymptom.Location = New System.Drawing.Point(3, 58)
        Me.GridEXSymptom.Name = "GridEXSymptom"
        Me.GridEXSymptom.RecordNavigator = True
        Me.GridEXSymptom.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEXSymptom.Size = New System.Drawing.Size(965, 108)
        Me.GridEXSymptom.TabIndex = 22
        Me.GridEXSymptom.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label1.Location = New System.Drawing.Point(3, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 24)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "ជ្រើសរើសកាលបរិច្ឆទ :"
        '
        'cbodate
        '
        Me.cbodate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbodate.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodate.FormattingEnabled = True
        Me.cbodate.Location = New System.Drawing.Point(152, 16)
        Me.cbodate.Name = "cbodate"
        Me.cbodate.Size = New System.Drawing.Size(182, 28)
        Me.cbodate.TabIndex = 20
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "1342235165_navigation-right-button_basic_blue.png")
        Me.ImageList1.Images.SetKeyName(1, "1342235272_navigation-left-button_basic_blue.png")
        '
        'SeparatorCommand6
        '
        Me.SeparatorCommand6.Key = "SeparatorCommand6"
        Me.SeparatorCommand6.Name = "SeparatorCommand6"
        '
        'DoctorConsultation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.Controls.Add(Me.SplitConsultationService)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "DoctorConsultation"
        Me.Size = New System.Drawing.Size(974, 603)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitConsultationService.Panel1.ResumeLayout(False)
        Me.SplitConsultationService.Panel2.ResumeLayout(False)
        Me.SplitConsultationService.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridWaitingConsultation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnfind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridEXSymptom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents SplitConsultationService As System.Windows.Forms.SplitContainer
    Friend WithEvents BtnHistory As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnrefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents cbodate As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents btnfind As System.Windows.Forms.PictureBox
    Friend WithEvents btnPrescription As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnConsultationService As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GridWaitingConsultation As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridEXSymptom As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SeparatorCommand6 As Janus.Windows.Ribbon.SeparatorCommand

End Class
