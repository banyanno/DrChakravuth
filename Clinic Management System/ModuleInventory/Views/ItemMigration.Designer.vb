<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemMigration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ItemMigration))
        Dim GridItemUsed_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.BtnExpend = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.GridItemUsed = New Janus.Windows.GridEX.GridEX
        Me.VisualStyleManager1 = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridItemUsed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.BtnExpend, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.ShowItemToolTips = False
        Me.ToolStrip1.Size = New System.Drawing.Size(909, 58)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(83, 55)
        Me.ToolStripButton1.Text = "     Save    "
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 58)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(102, 55)
        Me.ToolStripButton2.Text = "Refresh Item"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 58)
        Me.ToolStripSeparator2.Visible = False
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(74, 55)
        Me.ToolStripButton3.Text = "     Delete     "
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton3.Visible = False
        '
        'BtnExpend
        '
        Me.BtnExpend.ForeColor = System.Drawing.Color.White
        Me.BtnExpend.Image = CType(resources.GetObject("BtnExpend.Image"), System.Drawing.Image)
        Me.BtnExpend.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnExpend.Name = "BtnExpend"
        Me.BtnExpend.Size = New System.Drawing.Size(82, 55)
        Me.BtnExpend.Text = "     Expend      "
        Me.BtnExpend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnExpend.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 58)
        Me.ToolStripSeparator3.Visible = False
        '
        'GridItemUsed
        '
        Me.GridItemUsed.BackColor = System.Drawing.Color.White
        GridItemUsed_DesignTimeLayout.LayoutString = resources.GetString("GridItemUsed_DesignTimeLayout.LayoutString")
        Me.GridItemUsed.DesignTimeLayout = GridItemUsed_DesignTimeLayout
        Me.GridItemUsed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridItemUsed.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridItemUsed.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridItemUsed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridItemUsed.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridItemUsed.GroupByBoxVisible = False
        Me.GridItemUsed.HeaderFormatStyle.FontSize = 12.0!
        Me.GridItemUsed.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridItemUsed.Location = New System.Drawing.Point(0, 58)
        Me.GridItemUsed.Name = "GridItemUsed"
        Me.GridItemUsed.Office2007CustomColor = System.Drawing.Color.White
        Me.GridItemUsed.RecordNavigator = True
        Me.GridItemUsed.RowFormatStyle.FontSize = 12.0!
        Me.GridItemUsed.Size = New System.Drawing.Size(909, 385)
        Me.GridItemUsed.TabIndex = 6
        Me.GridItemUsed.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridItemUsed.VisualStyleManager = Me.VisualStyleManager1
        '
        'VisualStyleManager1
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.Color.Black
        JanusColorScheme1.MenuColor = System.Drawing.SystemColors.Control
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.Office2007CustomColor = System.Drawing.Color.White
        JanusColorScheme1.UseThemes = False
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Standard
        JanusColorScheme1.WindowColor = System.Drawing.Color.White
        Me.VisualStyleManager1.ColorSchemes.Add(JanusColorScheme1)
        Me.VisualStyleManager1.DefaultColorScheme = "Scheme0"
        '
        'ItemMigration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridItemUsed)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "ItemMigration"
        Me.Size = New System.Drawing.Size(909, 443)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridItemUsed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnExpend As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GridItemUsed As Janus.Windows.GridEX.GridEX
    Friend WithEvents VisualStyleManager1 As Janus.Windows.Common.VisualStyleManager

End Class
