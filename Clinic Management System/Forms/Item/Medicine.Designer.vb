<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Medicine
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
        Dim MedicineList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Medicine))
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.BtnAdd = New System.Windows.Forms.ToolStripButton
        Me.BtnEdit = New System.Windows.Forms.ToolStripButton
        Me.BtnDelete = New System.Windows.Forms.ToolStripButton
        Me.MedicineList = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip2.SuspendLayout()
        CType(Me.MedicineList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnAdd, Me.BtnEdit, Me.BtnDelete})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.ToolStrip2.Size = New System.Drawing.Size(2192, 34)
        Me.ToolStrip2.TabIndex = 31
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Khmer OS", 9.75!)
        Me.BtnAdd.ForeColor = System.Drawing.Color.SlateBlue
        Me.BtnAdd.Image = Global.Clinic_Management_System.My.Resources.Resources.add
        Me.BtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(96, 31)
        Me.BtnAdd.Text = "ថ្នាំពេទ្យថ្មី"
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
        'MedicineList
        '
        Me.MedicineList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        MedicineList_DesignTimeLayout.LayoutString = resources.GetString("MedicineList_DesignTimeLayout.LayoutString")
        Me.MedicineList.DesignTimeLayout = MedicineList_DesignTimeLayout
        Me.MedicineList.Dock = System.Windows.Forms.DockStyle.Left
        Me.MedicineList.GroupByBoxVisible = False
        Me.MedicineList.Location = New System.Drawing.Point(0, 34)
        Me.MedicineList.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MedicineList.Name = "MedicineList"
        Me.MedicineList.RecordNavigator = True
        Me.MedicineList.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.MedicineList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.MedicineList.Size = New System.Drawing.Size(1200, 3586)
        Me.MedicineList.TabIndex = 32
        '
        'Medicine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Controls.Add(Me.MedicineList)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Font = New System.Drawing.Font("Khmer OS System", 11.25!)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Medicine"
        Me.Size = New System.Drawing.Size(2192, 3620)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.MedicineList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents MedicineList As Janus.Windows.GridEX.GridEX

End Class
