<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCStoreReport
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
        Me.BtnMedicineStore = New System.Windows.Forms.ToolStripSplitButton
        Me.BtnCurrentStore = New System.Windows.Forms.ToolStripMenuItem
        Me.BtnStoreTransaction = New System.Windows.Forms.ToolStripMenuItem
        Me.BtnReceiveStore = New System.Windows.Forms.ToolStripButton
        Me.BtnIssueStore = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.BgLoadingReport = New System.ComponentModel.BackgroundWorker
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(35, 35)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnMedicineStore, Me.ToolStripSeparator3, Me.BtnReceiveStore, Me.ToolStripSeparator4, Me.BtnIssueStore, Me.ToolStripSeparator5, Me.ToolStripButton1, Me.ToolStripButton4, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1147, 40)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnMedicineStore
        '
        Me.BtnMedicineStore.DropDownButtonWidth = 30
        Me.BtnMedicineStore.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnCurrentStore, Me.ToolStripSeparator2, Me.BtnStoreTransaction})
        Me.BtnMedicineStore.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMedicineStore.ForeColor = System.Drawing.Color.Blue
        Me.BtnMedicineStore.Image = Global.Clinic_Management_System.My.Resources.Resources.MedicineStore
        Me.BtnMedicineStore.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnMedicineStore.Name = "BtnMedicineStore"
        Me.BtnMedicineStore.Size = New System.Drawing.Size(176, 37)
        Me.BtnMedicineStore.Text = "Medicine Store"
        '
        'BtnCurrentStore
        '
        Me.BtnCurrentStore.ForeColor = System.Drawing.Color.Blue
        Me.BtnCurrentStore.Name = "BtnCurrentStore"
        Me.BtnCurrentStore.Size = New System.Drawing.Size(195, 22)
        Me.BtnCurrentStore.Text = "Current Store"
        '
        'BtnStoreTransaction
        '
        Me.BtnStoreTransaction.ForeColor = System.Drawing.Color.Blue
        Me.BtnStoreTransaction.Name = "BtnStoreTransaction"
        Me.BtnStoreTransaction.Size = New System.Drawing.Size(195, 22)
        Me.BtnStoreTransaction.Text = "Store Transaction"
        '
        'BtnReceiveStore
        '
        Me.BtnReceiveStore.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReceiveStore.ForeColor = System.Drawing.Color.Blue
        Me.BtnReceiveStore.Image = Global.Clinic_Management_System.My.Resources.Resources.Receive
        Me.BtnReceiveStore.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnReceiveStore.Name = "BtnReceiveStore"
        Me.BtnReceiveStore.Size = New System.Drawing.Size(139, 37)
        Me.BtnReceiveStore.Text = "Store Receive"
        '
        'BtnIssueStore
        '
        Me.BtnIssueStore.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIssueStore.ForeColor = System.Drawing.Color.Blue
        Me.BtnIssueStore.Image = Global.Clinic_Management_System.My.Resources.Resources.Issue
        Me.BtnIssueStore.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnIssueStore.Name = "BtnIssueStore"
        Me.BtnIssueStore.Size = New System.Drawing.Size(123, 37)
        Me.BtnIssueStore.Text = "Store Issue"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton1.Image = Global.Clinic_Management_System.My.Resources.Resources.Adjust
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(163, 37)
        Me.ToolStripButton1.Text = "Store Adjustment"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton4.Image = Global.Clinic_Management_System.My.Resources.Resources.transfer
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(143, 37)
        Me.ToolStripButton4.Text = "Store Transfer"
        Me.ToolStripButton4.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 40)
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 40)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1147, 374)
        Me.CrystalReportViewer1.TabIndex = 8
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'BgLoadingReport
        '
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(192, 6)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 40)
        '
        'UCStoreReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "UCStoreReport"
        Me.Size = New System.Drawing.Size(1147, 414)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BtnReceiveStore As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnIssueStore As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnMedicineStore As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents BtnCurrentStore As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnStoreTransaction As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BgLoadingReport As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator

End Class
