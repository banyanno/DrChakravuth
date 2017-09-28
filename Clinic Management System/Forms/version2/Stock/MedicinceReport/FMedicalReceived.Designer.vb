<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMedicalReceived
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
        Me.components = New System.ComponentModel.Container
        Dim GridMedicalReceive_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FMedicalReceived))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.MaxRecord = New System.Windows.Forms.Label
        Me.BtnRemove = New System.Windows.Forms.Button
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.GridMedicalReceive = New Janus.Windows.GridEX.GridEX
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtNote = New System.Windows.Forms.TextBox
        Me.TxtTotalCost = New System.Windows.Forms.TextBox
        Me.TxtCost = New System.Windows.Forms.TextBox
        Me.TxtBonusQTY = New System.Windows.Forms.TextBox
        Me.TxtQty = New System.Windows.Forms.TextBox
        Me.CboProduct = New System.Windows.Forms.ComboBox
        Me.DateReceived = New System.Windows.Forms.DateTimePicker
        Me.TxtReferNo = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.ErrReceived = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtSubTotal = New System.Windows.Forms.TextBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.GridMedicalReceive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrReceived, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(7, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(931, 661)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.MaxRecord)
        Me.TabPage2.Controls.Add(Me.BtnRemove)
        Me.TabPage2.Controls.Add(Me.BtnAdd)
        Me.TabPage2.Controls.Add(Me.GridMedicalReceive)
        Me.TabPage2.Controls.Add(Me.LblSaveOption)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.TxtNote)
        Me.TabPage2.Controls.Add(Me.TxtTotalCost)
        Me.TabPage2.Controls.Add(Me.TxtCost)
        Me.TabPage2.Controls.Add(Me.TxtBonusQTY)
        Me.TabPage2.Controls.Add(Me.TxtQty)
        Me.TabPage2.Controls.Add(Me.CboProduct)
        Me.TabPage2.Controls.Add(Me.DateReceived)
        Me.TabPage2.Controls.Add(Me.TxtReferNo)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.ForeColor = System.Drawing.Color.Blue
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(923, 628)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Medical Receive Info"
        '
        'MaxRecord
        '
        Me.MaxRecord.AutoSize = True
        Me.MaxRecord.Location = New System.Drawing.Point(774, 58)
        Me.MaxRecord.Name = "MaxRecord"
        Me.MaxRecord.Size = New System.Drawing.Size(18, 20)
        Me.MaxRecord.TabIndex = 18
        Me.MaxRecord.Text = "0"
        Me.MaxRecord.Visible = False
        '
        'BtnRemove
        '
        Me.BtnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemove.ForeColor = System.Drawing.Color.Red
        Me.BtnRemove.Location = New System.Drawing.Point(604, 215)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(110, 32)
        Me.BtnRemove.TabIndex = 9
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Location = New System.Drawing.Point(488, 215)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(110, 32)
        Me.BtnAdd.TabIndex = 8
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'GridMedicalReceive
        '
        Me.GridMedicalReceive.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridMedicalReceive_DesignTimeLayout.LayoutString = resources.GetString("GridMedicalReceive_DesignTimeLayout.LayoutString")
        Me.GridMedicalReceive.DesignTimeLayout = GridMedicalReceive_DesignTimeLayout
        Me.GridMedicalReceive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridMedicalReceive.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridMedicalReceive.GroupByBoxVisible = False
        Me.GridMedicalReceive.Location = New System.Drawing.Point(6, 258)
        Me.GridMedicalReceive.Name = "GridMedicalReceive"
        Me.GridMedicalReceive.RecordNavigator = True
        Me.GridMedicalReceive.Size = New System.Drawing.Size(909, 362)
        Me.GridMedicalReceive.TabIndex = 17
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(707, 58)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(18, 20)
        Me.LblSaveOption.TabIndex = 3
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Expend Note:"
        '
        'TxtNote
        '
        Me.TxtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNote.Location = New System.Drawing.Point(132, 49)
        Me.TxtNote.Name = "TxtNote"
        Me.TxtNote.Size = New System.Drawing.Size(524, 29)
        Me.TxtNote.TabIndex = 2
        '
        'TxtTotalCost
        '
        Me.TxtTotalCost.BackColor = System.Drawing.SystemColors.Info
        Me.TxtTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalCost.ForeColor = System.Drawing.Color.Red
        Me.TxtTotalCost.Location = New System.Drawing.Point(131, 217)
        Me.TxtTotalCost.Name = "TxtTotalCost"
        Me.TxtTotalCost.ReadOnly = True
        Me.TxtTotalCost.Size = New System.Drawing.Size(340, 32)
        Me.TxtTotalCost.TabIndex = 7
        Me.TxtTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtCost
        '
        Me.TxtCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCost.ForeColor = System.Drawing.Color.Blue
        Me.TxtCost.Location = New System.Drawing.Point(132, 173)
        Me.TxtCost.Name = "TxtCost"
        Me.TxtCost.Size = New System.Drawing.Size(340, 32)
        Me.TxtCost.TabIndex = 6
        Me.TxtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBonusQTY
        '
        Me.TxtBonusQTY.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBonusQTY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBonusQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBonusQTY.ForeColor = System.Drawing.Color.Blue
        Me.TxtBonusQTY.Location = New System.Drawing.Point(576, 127)
        Me.TxtBonusQTY.Name = "TxtBonusQTY"
        Me.TxtBonusQTY.Size = New System.Drawing.Size(80, 32)
        Me.TxtBonusQTY.TabIndex = 5
        Me.TxtBonusQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtQty
        '
        Me.TxtQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQty.ForeColor = System.Drawing.Color.Blue
        Me.TxtQty.Location = New System.Drawing.Point(132, 127)
        Me.TxtQty.Name = "TxtQty"
        Me.TxtQty.Size = New System.Drawing.Size(340, 32)
        Me.TxtQty.TabIndex = 4
        Me.TxtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CboProduct
        '
        Me.CboProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboProduct.FormattingEnabled = True
        Me.CboProduct.Location = New System.Drawing.Point(132, 86)
        Me.CboProduct.Name = "CboProduct"
        Me.CboProduct.Size = New System.Drawing.Size(340, 32)
        Me.CboProduct.TabIndex = 3
        '
        'DateReceived
        '
        Me.DateReceived.CustomFormat = "dd - MM - yyyy"
        Me.DateReceived.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateReceived.Location = New System.Drawing.Point(475, 14)
        Me.DateReceived.Name = "DateReceived"
        Me.DateReceived.ShowCheckBox = True
        Me.DateReceived.Size = New System.Drawing.Size(181, 26)
        Me.DateReceived.TabIndex = 1
        '
        'TxtReferNo
        '
        Me.TxtReferNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtReferNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReferNo.Location = New System.Drawing.Point(131, 11)
        Me.TxtReferNo.Name = "TxtReferNo"
        Me.TxtReferNo.Size = New System.Drawing.Size(202, 29)
        Me.TxtReferNo.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total Cost *:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Cost $ x1 Qty *:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(478, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Bonus QTY:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Quality *:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Product Name*:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(349, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date Receive:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reference No:"
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(710, 672)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(110, 38)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(826, 672)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(110, 38)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'ErrReceived
        '
        Me.ErrReceived.ContainerControl = Me
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(11, 685)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 25)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Sub Total $:"
        '
        'TxtSubTotal
        '
        Me.TxtSubTotal.BackColor = System.Drawing.SystemColors.Info
        Me.TxtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSubTotal.ForeColor = System.Drawing.Color.Red
        Me.TxtSubTotal.Location = New System.Drawing.Point(143, 675)
        Me.TxtSubTotal.Name = "TxtSubTotal"
        Me.TxtSubTotal.ReadOnly = True
        Me.TxtSubTotal.Size = New System.Drawing.Size(341, 35)
        Me.TxtSubTotal.TabIndex = 0
        Me.TxtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FMedicalReceived
        '
        Me.AcceptButton = Me.BtnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 715)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtSubTotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FMedicalReceived"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medical Received"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.GridMedicalReceive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrReceived, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateReceived As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtReferNo As System.Windows.Forms.TextBox
    Friend WithEvents CboProduct As System.Windows.Forms.ComboBox
    Friend WithEvents TxtTotalCost As System.Windows.Forms.TextBox
    Friend WithEvents TxtCost As System.Windows.Forms.TextBox
    Friend WithEvents TxtBonusQTY As System.Windows.Forms.TextBox
    Friend WithEvents TxtQty As System.Windows.Forms.TextBox
    Friend WithEvents ErrReceived As System.Windows.Forms.ErrorProvider
    Friend WithEvents TxtNote As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents GridMedicalReceive As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnRemove As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents TxtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents MaxRecord As System.Windows.Forms.Label
End Class
