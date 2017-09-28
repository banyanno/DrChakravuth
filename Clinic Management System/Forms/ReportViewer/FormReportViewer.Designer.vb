<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReportViewer))
        Me.CVForm = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.RibbonStatusBar1 = New Janus.Windows.Ribbon.RibbonStatusBar
        Me.ContainerControlCommand1 = New Janus.Windows.Ribbon.ContainerControlCommand
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BgLoadingReport = New System.ComponentModel.BackgroundWorker
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.CrvImage = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CVForm
        '
        Me.CVForm.ActiveViewIndex = -1
        Me.CVForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CVForm.DisplayGroupTree = False
        Me.CVForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CVForm.Location = New System.Drawing.Point(0, 0)
        Me.CVForm.Name = "CVForm"
        Me.CVForm.SelectionFormula = ""
        Me.CVForm.ShowGroupTreeButton = False
        Me.CVForm.ShowRefreshButton = False
        Me.CVForm.Size = New System.Drawing.Size(498, 500)
        Me.CVForm.TabIndex = 0
        Me.CVForm.ViewTimeSelectionFormula = ""
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ImageSize = New System.Drawing.Size(16, 16)
        Me.RibbonStatusBar1.LeftPanelCommands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.ContainerControlCommand1})
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 500)
        Me.RibbonStatusBar1.Margin = New System.Windows.Forms.Padding(2)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Custom
        Me.RibbonStatusBar1.Office2007CustomColor = System.Drawing.Color.Silver
        Me.RibbonStatusBar1.ShowToolTips = False
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1049, 20)
        '
        '
        '
        Me.RibbonStatusBar1.SuperTipComponent.AutoPopDelay = 2000
        Me.RibbonStatusBar1.SuperTipComponent.ImageList = Nothing
        Me.RibbonStatusBar1.TabIndex = 4
        Me.RibbonStatusBar1.Text = "RibbonStatusBar1"
        Me.RibbonStatusBar1.UseCompatibleTextRendering = False
        '
        'ContainerControlCommand1
        '
        Me.ContainerControlCommand1.Control = Me.PictureBox1
        Me.ContainerControlCommand1.Key = "ContainerControlCommand1"
        Me.ContainerControlCommand1.Name = "ContainerControlCommand1"
        Me.ContainerControlCommand1.Text = "Loading"
        Me.ContainerControlCommand1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Clinic_Management_System.My.Resources.Resources.loading_bar11
        Me.PictureBox1.Location = New System.Drawing.Point(50, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 18)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(0, 0)
        Me.AxAcroPDF1.Margin = New System.Windows.Forms.Padding(2)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(547, 500)
        Me.AxAcroPDF1.TabIndex = 5
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.CrvImage)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AxAcroPDF1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.CVForm)
        Me.SplitContainer1.Size = New System.Drawing.Size(1049, 500)
        Me.SplitContainer1.SplitterDistance = 547
        Me.SplitContainer1.TabIndex = 6
        '
        'CrvImage
        '
        Me.CrvImage.ActiveViewIndex = -1
        Me.CrvImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrvImage.DisplayGroupTree = False
        Me.CrvImage.Location = New System.Drawing.Point(28, 0)
        Me.CrvImage.Name = "CrvImage"
        Me.CrvImage.SelectionFormula = ""
        Me.CrvImage.ShowGroupTreeButton = False
        Me.CrvImage.ShowRefreshButton = False
        Me.CrvImage.Size = New System.Drawing.Size(495, 500)
        Me.CrvImage.TabIndex = 6
        Me.CrvImage.ViewTimeSelectionFormula = ""
        Me.CrvImage.Visible = False
        '
        'FormReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 520)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormReportViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Viewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CVForm As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents RibbonStatusBar1 As Janus.Windows.Ribbon.RibbonStatusBar
    Friend WithEvents ContainerControlCommand1 As Janus.Windows.Ribbon.ContainerControlCommand
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BgLoadingReport As System.ComponentModel.BackgroundWorker
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents CrvImage As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
