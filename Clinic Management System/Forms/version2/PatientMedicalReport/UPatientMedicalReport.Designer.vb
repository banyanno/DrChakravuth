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
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GridPatientConsult = New Janus.Windows.GridEX.GridEX
        Me.VisualStyleManager1 = New Janus.Windows.Common.VisualStyleManager(Me.components)
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
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 50)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1277, 557)
        Me.SplitContainer1.SplitterDistance = 547
        Me.SplitContainer1.TabIndex = 0
        '
        'GridPatientConsult
        '
        Me.GridPatientConsult.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridPatientConsult_DesignTimeLayout.LayoutString = resources.GetString("GridPatientConsult_DesignTimeLayout.LayoutString")
        Me.GridPatientConsult.DesignTimeLayout = GridPatientConsult_DesignTimeLayout
        Me.GridPatientConsult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPatientConsult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridPatientConsult.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridPatientConsult.GroupByBoxVisible = False
        Me.GridPatientConsult.HeaderFormatStyle.FontSize = 12.0!
        Me.GridPatientConsult.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridPatientConsult.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridPatientConsult.Location = New System.Drawing.Point(0, 0)
        Me.GridPatientConsult.Name = "GridPatientConsult"
        Me.GridPatientConsult.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.GridPatientConsult.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridPatientConsult.RecordNavigator = True
        Me.GridPatientConsult.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridPatientConsult.SelectedFormatStyle.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GridPatientConsult.Size = New System.Drawing.Size(547, 557)
        Me.GridPatientConsult.TabIndex = 21
        Me.GridPatientConsult.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridPatientConsult.VisualStyleManager = Me.VisualStyleManager1
        '
        'VisualStyleManager1
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HotTrack
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme1.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        JanusColorScheme1.UseThemes = False
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Standard
        Me.VisualStyleManager1.ColorSchemes.Add(JanusColorScheme1)
        Me.VisualStyleManager1.DefaultColorScheme = "Scheme0"
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
        Me.CRPatientDocViewer.Size = New System.Drawing.Size(726, 557)
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
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(26, 26)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1, Me.ToolStripSeparator4, Me.ToolStripButton2, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripSeparator2, Me.BtnEditConsultation})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1277, 50)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DropDownButtonWidth = 30
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewPatientConsultTodayToolStripMenuItem, Me.BtnViewToday, Me.BtnFindMoreInformation})
        Me.ToolStripSplitButton1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.ToolStripSplitButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripSplitButton1.Image = Global.Clinic_Management_System.My.Resources.Resources.find
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(121, 47)
        Me.ToolStripSplitButton1.Text = "Find Patieent"
        Me.ToolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 50)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton2.Image = Global.Clinic_Management_System.My.Resources.Resources.printer
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(200, 47)
        Me.ToolStripButton2.Text = "Print Preview Medical Report"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 50)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = Global.Clinic_Management_System.My.Resources.Resources.preview
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(125, 47)
        Me.ToolStripButton1.Text = "View Prescription"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 50)
        '
        'BtnEditConsultation
        '
        Me.BtnEditConsultation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditConsultation.ForeColor = System.Drawing.Color.White
        Me.BtnEditConsultation.Image = Global.Clinic_Management_System.My.Resources.Resources.edit
        Me.BtnEditConsultation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditConsultation.Name = "BtnEditConsultation"
        Me.BtnEditConsultation.Size = New System.Drawing.Size(129, 47)
        Me.BtnEditConsultation.Text = " Edit Consultation"
        Me.BtnEditConsultation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
    Friend WithEvents VisualStyleManager1 As Janus.Windows.Common.VisualStyleManager

End Class
