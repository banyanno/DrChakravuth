<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UAnalysis
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnAnalysis = New System.Windows.Forms.ToolStripButton
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.CrvViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnAnalysis})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1070, 51)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnAnalysis
        '
        Me.BtnAnalysis.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BtnAnalysis.ForeColor = System.Drawing.Color.Blue
        Me.BtnAnalysis.Image = Global.Clinic_Management_System.My.Resources.Resources._1369921179_pie_chart
        Me.BtnAnalysis.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAnalysis.Name = "BtnAnalysis"
        Me.BtnAnalysis.Size = New System.Drawing.Size(114, 48)
        Me.BtnAnalysis.Text = "Clinic Analysis"
        Me.BtnAnalysis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CrvViewer
        '
        Me.CrvViewer.ActiveViewIndex = -1
        Me.CrvViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrvViewer.DisplayGroupTree = False
        Me.CrvViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrvViewer.Location = New System.Drawing.Point(0, 51)
        Me.CrvViewer.Name = "CrvViewer"
        Me.CrvViewer.SelectionFormula = ""
        Me.CrvViewer.ShowGroupTreeButton = False
        Me.CrvViewer.ShowRefreshButton = False
        Me.CrvViewer.Size = New System.Drawing.Size(1070, 563)
        Me.CrvViewer.TabIndex = 1
        Me.CrvViewer.ViewTimeSelectionFormula = ""
        '
        'UAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CrvViewer)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "UAnalysis"
        Me.Size = New System.Drawing.Size(1070, 614)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents CrvViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BtnAnalysis As System.Windows.Forms.ToolStripButton

End Class
