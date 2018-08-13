<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UPatientMedicalReport
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
        Dim GridPatientConsult_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UPatientMedicalReport))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GridPatientConsult = New Janus.Windows.GridEX.GridEX
        Me.CRPatientDocViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ErrValidate = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BgLoadingReport = New System.ComponentModel.BackgroundWorker
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton
        Me.ViewPatientConsultTodayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BtnViewToday = New System.Windows.Forms.ToolStripSeparator
        Me.BtnFindMoreInformation = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnEditConsultation = New System.Windows.Forms.ToolStripButton
        Me.BgLoadingPatient = New System.ComponentModel.BackgroundWorker
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GridPatientConsult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrValidate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 33)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridPatientConsult)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.CRPatientDocViewer)
        Me.SplitContainer1.Size = New System.Drawing.Size(1277, 574)
        Me.SplitContainer1.SplitterDistance = 547
        Me.SplitContainer1.TabIndex = 0
        '
        'GridPatientConsult
        '
        Me.GridPatientConsult.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridPatientConsult_DesignTimeLayout.LayoutString = resources.GetString("GridPatientConsult_DesignTimeLayout.LayoutString")
        Me.GridPatientConsult.DesignTimeLayout = GridPatientConsult_DesignTimeLayout
        Me.GridPatientConsult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPatientConsult.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridPatientConsult.GroupByBoxVisible = False
        Me.GridPatientConsult.HeaderFormatStyle.FontSize = 12.0!
        Me.GridPatientConsult.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridPatientConsult.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridPatientConsult.Location = New System.Drawing.Point(0, 0)
        Me.GridPatientConsult.Name = "GridPatientConsult"
        Me.GridPatientConsult.RecordNavigator = True
        Me.GridPatientConsult.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridPatientConsult.Size = New System.Drawing.Size(547, 574)
        Me.GridPatientConsult.TabIndex = 21
        '
        'CRPatientDocViewer
        '
        Me.CRPatientDocViewer.ActiveViewIndex = -1
        Me.CRPatientDocViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRPatientDocViewer.DisplayGroupTree = False
        Me.CRPatientDocViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRPatientDocViewer.Location = New System.Drawing.Point(0, 0)
        Me.CRPatientDocViewer.Name = "CRPatientDocViewer"
        Me.CRPatientDocViewer.SelectionFormula = ""
        Me.CRPatientDocViewer.ShowCloseButton = False
        Me.CRPatientDocViewer.ShowGroupTreeButton = False
        Me.CRPatientDocViewer.Size = New System.Drawing.Size(726, 574)
        Me.CRPatientDocViewer.TabIndex = 0
        Me.CRPatientDocViewer.ViewTimeSelectionFormula = ""
        '
        'ErrValidate
        '
        Me.ErrValidate.ContainerControl = Me
        '
        'BgLoadingReport
        '
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(26, 26)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1, Me.ToolStripSeparator4, Me.ToolStripButton2, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripSeparator2, Me.BtnEditConsultation})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1277, 33)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DropDownButtonWidth = 30
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewPatientConsultTodayToolStripMenuItem, Me.BtnViewToday, Me.BtnFindMoreInformation})
        Me.ToolStripSplitButton1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.ToolStripSplitButton1.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripSplitButton1.Image = Global.Clinic_Management_System.My.Resources.Resources.find
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(147, 30)
        Me.ToolStripSplitButton1.Text = "Find Patieent"
        '
        'ViewPatientConsultTodayToolStripMenuItem
        '
        Me.ViewPatientConsultTodayToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.ViewPatientConsultTodayToolStripMenuItem.Name = "ViewPatientConsultTodayToolStripMenuItem"
        Me.ViewPatientConsultTodayToolStripMenuItem.Size = New System.Drawing.Size(256, 22)
        Me.ViewPatientConsultTodayToolStripMenuItem.Text = "View Patient Consult Today"
        '
        'BtnViewToday
        '
        Me.BtnViewToday.Name = "BtnViewToday"
        Me.BtnViewToday.Size = New System.Drawing.Size(253, 6)
        '
        'BtnFindMoreInformation
        '
        Me.BtnFindMoreInformation.ForeColor = System.Drawing.Color.Blue
        Me.BtnFindMoreInformation.Name = "BtnFindMoreInformation"
        Me.BtnFindMoreInformation.Size = New System.Drawing.Size(256, 22)
        Me.BtnFindMoreInformation.Text = "Find Patient More Information"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 33)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton2.Image = Global.Clinic_Management_System.My.Resources.Resources.printer
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(226, 30)
        Me.ToolStripButton2.Text = "Print Preview Medical Report"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 33)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton1.Image = Global.Clinic_Management_System.My.Resources.Resources.preview
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(151, 30)
        Me.ToolStripButton1.Text = "View Prescription"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 33)
        '
        'BtnEditConsultation
        '
        Me.BtnEditConsultation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditConsultation.ForeColor = System.Drawing.Color.Blue
        Me.BtnEditConsultation.Image = Global.Clinic_Management_System.My.Resources.Resources.edit
        Me.BtnEditConsultation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditConsultation.Name = "BtnEditConsultation"
        Me.BtnEditConsultation.Size = New System.Drawing.Size(155, 30)
        Me.BtnEditConsultation.Text = " Edit Consultation"
        '
        'BgLoadingPatient
        '
        '
        'UPatientMedicalReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "UPatientMedicalReport"
        Me.Size = New System.Drawing.Size(1277, 607)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GridPatientConsult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrValidate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents CRPatientDocViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ErrValidate As System.Windows.Forms.ErrorProvider
    Friend WithEvents BgLoadingReport As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BgLoadingPatient As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnEditConsultation As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ViewPatientConsultTodayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnViewToday As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnFindMoreInformation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridPatientConsult As Janus.Windows.GridEX.GridEX

End Class
