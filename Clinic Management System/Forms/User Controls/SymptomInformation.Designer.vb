<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SymptomInformation
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
        Dim SymptomList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SymptomInformation))
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.BtnAdd = New System.Windows.Forms.ToolStripButton
        Me.BtnEdit = New System.Windows.Forms.ToolStripButton
        Me.BtnDelete = New System.Windows.Forms.ToolStripButton
        Me.SymptomList = New Janus.Windows.GridEX.GridEX
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStrip2.SuspendLayout()
        CType(Me.SymptomList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnAdd, Me.ToolStripSeparator1, Me.BtnEdit, Me.ToolStripSeparator2, Me.BtnDelete})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip2.Size = New System.Drawing.Size(1461, 34)
        Me.ToolStrip2.TabIndex = 27
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Khmer OS", 9.75!)
        Me.BtnAdd.ForeColor = System.Drawing.Color.SlateBlue
        Me.BtnAdd.Image = Global.Clinic_Management_System.My.Resources.Resources.add
        Me.BtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(111, 31)
        Me.BtnAdd.Text = "រោគសញ្ញាថ្មី"
        '
        'BtnEdit
        '
        Me.BtnEdit.Font = New System.Drawing.Font("Khmer OS", 9.75!)
        Me.BtnEdit.ForeColor = System.Drawing.Color.SlateBlue
        Me.BtnEdit.Image = Global.Clinic_Management_System.My.Resources.Resources.edit
        Me.BtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(76, 31)
        Me.BtnEdit.Text = "កែប្រែ"
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Khmer OS", 9.75!)
        Me.BtnDelete.ForeColor = System.Drawing.Color.SlateBlue
        Me.BtnDelete.Image = Global.Clinic_Management_System.My.Resources.Resources.delete_appointment
        Me.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(101, 31)
        Me.BtnDelete.Text = "លុបចោល"
        '
        'SymptomList
        '
        Me.SymptomList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        SymptomList_DesignTimeLayout.LayoutString = resources.GetString("SymptomList_DesignTimeLayout.LayoutString")
        Me.SymptomList.DesignTimeLayout = SymptomList_DesignTimeLayout
        Me.SymptomList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SymptomList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SymptomList.GroupByBoxVisible = False
        Me.SymptomList.HeaderFormatStyle.Font = New System.Drawing.Font("Khmer OS System", 11.25!)
        Me.SymptomList.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.SymptomList.Location = New System.Drawing.Point(0, 34)
        Me.SymptomList.Name = "SymptomList"
        Me.SymptomList.RowFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SymptomList.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.SymptomList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.SymptomList.SelectedFormatStyle.BackColorAlphaMode = Janus.Windows.GridEX.AlphaMode.Transparent
        Me.SymptomList.SelectedFormatStyle.BackColorGradient = System.Drawing.SystemColors.Highlight
        Me.SymptomList.Size = New System.Drawing.Size(1461, 1709)
        Me.SymptomList.TabIndex = 41
        Me.SymptomList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 34)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 34)
        '
        'SymptomInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Controls.Add(Me.SymptomList)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Font = New System.Drawing.Font("Khmer OS System", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "SymptomInformation"
        Me.Size = New System.Drawing.Size(1461, 1743)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.SymptomList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents SymptomList As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator

End Class
