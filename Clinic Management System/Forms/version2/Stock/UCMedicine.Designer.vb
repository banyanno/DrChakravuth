﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCMedicine
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
        Dim MedicineList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCMedicine))
        Me.MedicineList = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnNewStore = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnUpdate = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDelete = New System.Windows.Forms.ToolStripButton
        Me.FilterEditor1 = New Janus.Windows.FilterEditor.FilterEditor
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.btnUndo = New System.Windows.Forms.ToolStripButton
        CType(Me.MedicineList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MedicineList
        '
        Me.MedicineList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        MedicineList_DesignTimeLayout.LayoutString = resources.GetString("MedicineList_DesignTimeLayout.LayoutString")
        Me.MedicineList.DesignTimeLayout = MedicineList_DesignTimeLayout
        Me.MedicineList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MedicineList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.MedicineList.GroupByBoxVisible = False
        Me.MedicineList.HeaderFormatStyle.FontSize = 10.0!
        Me.MedicineList.Location = New System.Drawing.Point(0, 95)
        Me.MedicineList.Name = "MedicineList"
        Me.MedicineList.RecordNavigator = True
        Me.MedicineList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.MedicineList.Size = New System.Drawing.Size(793, 325)
        Me.MedicineList.TabIndex = 10
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator3, Me.BtnNewStore, Me.ToolStripSeparator1, Me.BtnUpdate, Me.ToolStripSeparator2, Me.BtnDelete, Me.ToolStripSeparator4, Me.btnUndo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(793, 35)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton1.Image = Global.Clinic_Management_System.My.Resources.Resources.refresh
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(84, 32)
        Me.ToolStripButton1.Text = "Refresh"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 35)
        '
        'BtnNewStore
        '
        Me.BtnNewStore.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewStore.ForeColor = System.Drawing.Color.Blue
        Me.BtnNewStore.Image = Global.Clinic_Management_System.My.Resources.Resources.add
        Me.BtnNewStore.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewStore.Name = "BtnNewStore"
        Me.BtnNewStore.Size = New System.Drawing.Size(127, 32)
        Me.BtnNewStore.Text = "New Medicine"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 35)
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.ForeColor = System.Drawing.Color.Blue
        Me.BtnUpdate.Image = Global.Clinic_Management_System.My.Resources.Resources.edit
        Me.BtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(146, 32)
        Me.BtnUpdate.Text = "Update Medicine"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 35)
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.Blue
        Me.BtnDelete.Image = Global.Clinic_Management_System.My.Resources.Resources.delete_appointment
        Me.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(141, 32)
        Me.BtnDelete.Text = "Delete Medicine"
        '
        'FilterEditor1
        '
        Me.FilterEditor1.AllowFilterByFieldValue = True
        Me.FilterEditor1.AutoApply = True
        Me.FilterEditor1.BackColor = System.Drawing.Color.Transparent
        Me.FilterEditor1.DefaultConditionOperator = Janus.Data.ConditionOperator.Equal
        Me.FilterEditor1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FilterEditor1.EditControlWidth = 200
        Me.FilterEditor1.InnerAreaStyle = Janus.Windows.UI.Dock.PanelInnerAreaStyle.UseFormatStyle
        Me.FilterEditor1.Location = New System.Drawing.Point(0, 35)
        Me.FilterEditor1.MinSize = New System.Drawing.Size(16, 45)
        Me.FilterEditor1.Name = "FilterEditor1"
        Me.FilterEditor1.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.[Default]
        Me.FilterEditor1.ScrollMode = Janus.Windows.UI.Dock.ScrollMode.Both
        Me.FilterEditor1.ScrollStep = 15
        Me.FilterEditor1.Size = New System.Drawing.Size(793, 60)
        Me.FilterEditor1.SourceControl = Me.MedicineList
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 35)
        '
        'btnUndo
        '
        Me.btnUndo.ForeColor = System.Drawing.Color.Blue
        Me.btnUndo.Image = Global.Clinic_Management_System.My.Resources.Resources.check
        Me.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(128, 32)
        Me.btnUndo.Text = "Undo Medicine"
        '
        'UCMedicine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MedicineList)
        Me.Controls.Add(Me.FilterEditor1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "UCMedicine"
        Me.Size = New System.Drawing.Size(793, 420)
        CType(Me.MedicineList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MedicineList As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnNewStore As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FilterEditor1 As Janus.Windows.FilterEditor.FilterEditor
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnUndo As System.Windows.Forms.ToolStripButton

End Class
