<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedicineCategory
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
        Dim CategoryList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MedicineCategory))
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.BtnAdd = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnEdit = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDelete = New System.Windows.Forms.ToolStripButton
        Me.CategoryList = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip2.SuspendLayout()
        CType(Me.CategoryList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnAdd, Me.ToolStripSeparator1, Me.BtnEdit, Me.ToolStripSeparator2, Me.BtnDelete})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip2.Size = New System.Drawing.Size(1461, 34)
        Me.ToolStrip2.TabIndex = 30
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Khmer OS", 9.75!)
        Me.BtnAdd.ForeColor = System.Drawing.Color.SlateBlue
        Me.BtnAdd.Image = Global.Clinic_Management_System.My.Resources.Resources.add
        Me.BtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(106, 31)
        Me.BtnAdd.Text = "ប្រភេទថ្នាំថ្មី"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 34)
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 34)
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
        'CategoryList
        '
        Me.CategoryList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        CategoryList_DesignTimeLayout.LayoutString = resources.GetString("CategoryList_DesignTimeLayout.LayoutString")
        Me.CategoryList.DesignTimeLayout = CategoryList_DesignTimeLayout
        Me.CategoryList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CategoryList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CategoryList.GroupByBoxVisible = False
        Me.CategoryList.HeaderFormatStyle.Font = New System.Drawing.Font("Khmer OS System", 11.25!)
        Me.CategoryList.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.CategoryList.Location = New System.Drawing.Point(0, 34)
        Me.CategoryList.Name = "CategoryList"
        Me.CategoryList.RowFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.CategoryList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.CategoryList.SelectedFormatStyle.BackColorAlphaMode = Janus.Windows.GridEX.AlphaMode.Transparent
        Me.CategoryList.SelectedFormatStyle.BackColorGradient = System.Drawing.SystemColors.Highlight
        Me.CategoryList.Size = New System.Drawing.Size(1461, 1709)
        Me.CategoryList.TabIndex = 44
        '
        'MedicineCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Controls.Add(Me.CategoryList)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Name = "MedicineCategory"
        Me.Size = New System.Drawing.Size(1461, 1743)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.CategoryList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents CategoryList As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator

End Class
