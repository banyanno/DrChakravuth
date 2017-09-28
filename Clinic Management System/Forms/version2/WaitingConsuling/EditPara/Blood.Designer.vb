<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Blood
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
        Dim BloodResultList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Blood))
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtBloodResult = New System.Windows.Forms.TextBox
        Me.BloodResultList = New Janus.Windows.GridEX.GridEX
        Me.btnDeleteItem = New System.Windows.Forms.Button
        Me.cboitem = New System.Windows.Forms.ComboBox
        Me.btnAddItem = New System.Windows.Forms.Button
        Me.Cancel = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.LblRequestID = New System.Windows.Forms.Label
        CType(Me.BloodResultList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(349, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Result:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Blood Check:"
        '
        'TxtBloodResult
        '
        Me.TxtBloodResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBloodResult.Location = New System.Drawing.Point(395, 14)
        Me.TxtBloodResult.Name = "TxtBloodResult"
        Me.TxtBloodResult.Size = New System.Drawing.Size(216, 26)
        Me.TxtBloodResult.TabIndex = 11
        '
        'BloodResultList
        '
        Me.BloodResultList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.BloodResultList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        BloodResultList_DesignTimeLayout.LayoutString = resources.GetString("BloodResultList_DesignTimeLayout.LayoutString")
        Me.BloodResultList.DesignTimeLayout = BloodResultList_DesignTimeLayout
        Me.BloodResultList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BloodResultList.GroupByBoxVisible = False
        Me.BloodResultList.HeaderFormatStyle.FontSize = 10.0!
        Me.BloodResultList.Location = New System.Drawing.Point(13, 47)
        Me.BloodResultList.Name = "BloodResultList"
        Me.BloodResultList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.BloodResultList.Size = New System.Drawing.Size(709, 269)
        Me.BloodResultList.TabIndex = 10
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteItem.Location = New System.Drawing.Point(680, 15)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(43, 26)
        Me.btnDeleteItem.TabIndex = 9
        Me.btnDeleteItem.Text = "-"
        Me.btnDeleteItem.UseVisualStyleBackColor = True
        '
        'cboitem
        '
        Me.cboitem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboitem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboitem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboitem.FormattingEnabled = True
        Me.cboitem.Location = New System.Drawing.Point(86, 12)
        Me.cboitem.Name = "cboitem"
        Me.cboitem.Size = New System.Drawing.Size(252, 28)
        Me.cboitem.TabIndex = 7
        '
        'btnAddItem
        '
        Me.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddItem.Location = New System.Drawing.Point(630, 15)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(43, 26)
        Me.btnAddItem.TabIndex = 8
        Me.btnAddItem.Text = "+"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancel.Location = New System.Drawing.Point(631, 324)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(91, 31)
        Me.Cancel.TabIndex = 15
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(534, 324)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(91, 31)
        Me.BtnSave.TabIndex = 14
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'LblRequestID
        '
        Me.LblRequestID.AutoSize = True
        Me.LblRequestID.Location = New System.Drawing.Point(22, 334)
        Me.LblRequestID.Name = "LblRequestID"
        Me.LblRequestID.Size = New System.Drawing.Size(13, 13)
        Me.LblRequestID.TabIndex = 16
        Me.LblRequestID.Text = "0"
        '
        'Blood
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 361)
        Me.Controls.Add(Me.LblRequestID)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBloodResult)
        Me.Controls.Add(Me.BloodResultList)
        Me.Controls.Add(Me.btnDeleteItem)
        Me.Controls.Add(Me.cboitem)
        Me.Controls.Add(Me.btnAddItem)
        Me.Name = "Blood"
        Me.Text = "Blood"
        CType(Me.BloodResultList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtBloodResult As System.Windows.Forms.TextBox
    Friend WithEvents BloodResultList As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnDeleteItem As System.Windows.Forms.Button
    Friend WithEvents cboitem As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents LblRequestID As System.Windows.Forms.Label
End Class
