<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCStock
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
        Dim StoreList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCStock))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnReceive = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnIssue = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnAdjustment = New System.Windows.Forms.ToolStripButton
        Me.BtnTransfer = New System.Windows.Forms.ToolStripButton
        Me.StoreList = New Janus.Windows.GridEX.GridEX
        Me.FilterEditor1 = New Janus.Windows.FilterEditor.FilterEditor
        Me.ToolStrip1.SuspendLayout()
        CType(Me.StoreList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(35, 35)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnRefresh, Me.ToolStripSeparator1, Me.BtnReceive, Me.ToolStripSeparator2, Me.BtnIssue, Me.ToolStripSeparator3, Me.BtnAdjustment, Me.BtnTransfer})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(893, 40)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.ForeColor = System.Drawing.Color.Blue
        Me.BtnRefresh.Image = Global.Clinic_Management_System.My.Resources.Resources.refresh
        Me.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(94, 37)
        Me.BtnRefresh.Text = "Refresh"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 40)
        '
        'BtnReceive
        '
        Me.BtnReceive.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReceive.ForeColor = System.Drawing.Color.Blue
        Me.BtnReceive.Image = Global.Clinic_Management_System.My.Resources.Resources.Receive
        Me.BtnReceive.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnReceive.Name = "BtnReceive"
        Me.BtnReceive.Size = New System.Drawing.Size(160, 37)
        Me.BtnReceive.Text = "Receive Medicine"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 40)
        '
        'BtnIssue
        '
        Me.BtnIssue.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIssue.ForeColor = System.Drawing.Color.Blue
        Me.BtnIssue.Image = Global.Clinic_Management_System.My.Resources.Resources.Issue
        Me.BtnIssue.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnIssue.Name = "BtnIssue"
        Me.BtnIssue.Size = New System.Drawing.Size(144, 37)
        Me.BtnIssue.Text = "Issue Medicine"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 40)
        '
        'BtnAdjustment
        '
        Me.BtnAdjustment.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdjustment.ForeColor = System.Drawing.Color.Blue
        Me.BtnAdjustment.Image = Global.Clinic_Management_System.My.Resources.Resources.Adjust
        Me.BtnAdjustment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAdjustment.Name = "BtnAdjustment"
        Me.BtnAdjustment.Size = New System.Drawing.Size(151, 37)
        Me.BtnAdjustment.Text = "Adjust Medicine"
        '
        'BtnTransfer
        '
        Me.BtnTransfer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransfer.ForeColor = System.Drawing.Color.Blue
        Me.BtnTransfer.Image = Global.Clinic_Management_System.My.Resources.Resources.transfer
        Me.BtnTransfer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnTransfer.Name = "BtnTransfer"
        Me.BtnTransfer.Size = New System.Drawing.Size(164, 37)
        Me.BtnTransfer.Text = "Transfer Medicine"
        Me.BtnTransfer.Visible = False
        '
        'StoreList
        '
        Me.StoreList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        StoreList_DesignTimeLayout.LayoutString = resources.GetString("StoreList_DesignTimeLayout.LayoutString")
        Me.StoreList.DesignTimeLayout = StoreList_DesignTimeLayout
        Me.StoreList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StoreList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.StoreList.GroupByBoxVisible = False
        Me.StoreList.GroupRowFormatStyle.FontSize = 12.0!
        Me.StoreList.GroupRowFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.StoreList.HeaderFormatStyle.FontSize = 10.0!
        Me.StoreList.Location = New System.Drawing.Point(0, 101)
        Me.StoreList.Name = "StoreList"
        Me.StoreList.RecordNavigator = True
        Me.StoreList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.StoreList.Size = New System.Drawing.Size(893, 336)
        Me.StoreList.TabIndex = 6
        '
        'FilterEditor1
        '
        Me.FilterEditor1.AutoApply = True
        Me.FilterEditor1.BackColor = System.Drawing.Color.Transparent
        Me.FilterEditor1.DefaultConditionOperator = Janus.Data.ConditionOperator.Equal
        Me.FilterEditor1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FilterEditor1.InnerAreaStyle = Janus.Windows.UI.Dock.PanelInnerAreaStyle.UseFormatStyle
        Me.FilterEditor1.Location = New System.Drawing.Point(0, 40)
        Me.FilterEditor1.MinSize = New System.Drawing.Size(16, 45)
        Me.FilterEditor1.Name = "FilterEditor1"
        Me.FilterEditor1.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.[Default]
        Me.FilterEditor1.ScrollMode = Janus.Windows.UI.Dock.ScrollMode.Both
        Me.FilterEditor1.ScrollStep = 15
        Me.FilterEditor1.Size = New System.Drawing.Size(893, 61)
        Me.FilterEditor1.SourceControl = Me.StoreList
        '
        'UCStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.StoreList)
        Me.Controls.Add(Me.FilterEditor1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "UCStock"
        Me.Size = New System.Drawing.Size(893, 437)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.StoreList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents StoreList As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnIssue As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnReceive As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnAdjustment As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnTransfer As System.Windows.Forms.ToolStripButton
    Friend WithEvents FilterEditor1 As Janus.Windows.FilterEditor.FilterEditor
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator

End Class
