<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForReceiveOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForReceiveOrder))
        Dim GridListItemReceive_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnSave = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnCancel = New System.Windows.Forms.ToolStripButton
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.BtnAddMoreSupplyer = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.CboSupplier = New System.Windows.Forms.ComboBox
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.DateInvoiceDueDate = New System.Windows.Forms.DateTimePicker
        Me.Label14 = New System.Windows.Forms.Label
        Me.DateInvoiceReference = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.TxtInvoiceReferenceNo = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtTeam = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
        Me.txtUnitName = New System.Windows.Forms.TextBox
        Me.TxtUnitQTYReceive = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.TxtUnitQTY = New System.Windows.Forms.TextBox
        Me.BtnAddMoreItem = New System.Windows.Forms.Button
        Me.DateExpiry = New System.Windows.Forms.DateTimePicker
        Me.Label16 = New System.Windows.Forms.Label
        Me.BtnRemoveItem = New System.Windows.Forms.Button
        Me.BtnAddItem = New System.Windows.Forms.Button
        Me.TxtItemCost = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblUnitName = New System.Windows.Forms.Label
        Me.TxtQTYReceive = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CboItem = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.UiGroupBox4 = New Janus.Windows.EditControls.UIGroupBox
        Me.GridListItemReceive = New Janus.Windows.GridEX.GridEX
        Me.VisualStyleManager1 = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.UiGroupBox5 = New Janus.Windows.EditControls.UIGroupBox
        Me.TxtReceiveNote = New System.Windows.Forms.TextBox
        Me.UiGroupBox6 = New Janus.Windows.EditControls.UIGroupBox
        Me.TxtVATPercent = New System.Windows.Forms.TextBox
        Me.TxtTotalAmounDue = New System.Windows.Forms.TextBox
        Me.TxtDeposit = New System.Windows.Forms.TextBox
        Me.TxtTotalAmountIncludVAT = New System.Windows.Forms.TextBox
        Me.TxtVAT = New System.Windows.Forms.TextBox
        Me.TxtTotalAmoutExcludVAT = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.ErrReceive = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox3.SuspendLayout()
        CType(Me.UiGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox4.SuspendLayout()
        CType(Me.GridListItemReceive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox5.SuspendLayout()
        CType(Me.UiGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox6.SuspendLayout()
        CType(Me.ErrReceive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnSave, Me.ToolStripSeparator1, Me.BtnCancel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1142, 52)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Image = Global.Clinic_Management_System.My.Resources.Resources._1316761851_ark2
        Me.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(133, 49)
        Me.BtnSave.Text = "Save Recieve Item"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 52)
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Image = Global.Clinic_Management_System.My.Resources.Resources.delete_appointment
        Me.BtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(146, 49)
        Me.BtnCancel.Text = "Cancel Receive Item"
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Controls.Add(Me.BtnAddMoreSupplyer)
        Me.UiGroupBox1.Controls.Add(Me.Label15)
        Me.UiGroupBox1.Controls.Add(Me.CboSupplier)
        Me.UiGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiGroupBox1.Location = New System.Drawing.Point(5, 53)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(479, 110)
        Me.UiGroupBox1.TabIndex = 1
        Me.UiGroupBox1.Text = "Supplier Info"
        Me.UiGroupBox1.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'BtnAddMoreSupplyer
        '
        Me.BtnAddMoreSupplyer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddMoreSupplyer.FlatAppearance.BorderSize = 0
        Me.BtnAddMoreSupplyer.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnAddMoreSupplyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddMoreSupplyer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddMoreSupplyer.ForeColor = System.Drawing.Color.Blue
        Me.BtnAddMoreSupplyer.Image = CType(resources.GetObject("BtnAddMoreSupplyer.Image"), System.Drawing.Image)
        Me.BtnAddMoreSupplyer.Location = New System.Drawing.Point(430, 54)
        Me.BtnAddMoreSupplyer.Name = "BtnAddMoreSupplyer"
        Me.BtnAddMoreSupplyer.Size = New System.Drawing.Size(33, 26)
        Me.BtnAddMoreSupplyer.TabIndex = 17
        Me.BtnAddMoreSupplyer.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAddMoreSupplyer.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(10, 33)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(107, 17)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Select Supplyer"
        '
        'CboSupplier
        '
        Me.CboSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSupplier.FormattingEnabled = True
        Me.CboSupplier.Location = New System.Drawing.Point(11, 53)
        Me.CboSupplier.Name = "CboSupplier"
        Me.CboSupplier.Size = New System.Drawing.Size(403, 28)
        Me.CboSupplier.TabIndex = 0
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox2.Controls.Add(Me.LblSaveOption)
        Me.UiGroupBox2.Controls.Add(Me.DateInvoiceDueDate)
        Me.UiGroupBox2.Controls.Add(Me.Label14)
        Me.UiGroupBox2.Controls.Add(Me.DateInvoiceReference)
        Me.UiGroupBox2.Controls.Add(Me.Label13)
        Me.UiGroupBox2.Controls.Add(Me.TxtInvoiceReferenceNo)
        Me.UiGroupBox2.Controls.Add(Me.Label11)
        Me.UiGroupBox2.Controls.Add(Me.TxtTeam)
        Me.UiGroupBox2.Controls.Add(Me.Label12)
        Me.UiGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiGroupBox2.Location = New System.Drawing.Point(491, 53)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Size = New System.Drawing.Size(644, 110)
        Me.UiGroupBox2.TabIndex = 2
        Me.UiGroupBox2.Text = "Invoice Info"
        Me.UiGroupBox2.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(355, 33)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(16, 17)
        Me.LblSaveOption.TabIndex = 14
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'DateInvoiceDueDate
        '
        Me.DateInvoiceDueDate.Checked = False
        Me.DateInvoiceDueDate.CustomFormat = "dd-MM-yyyy"
        Me.DateInvoiceDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateInvoiceDueDate.Location = New System.Drawing.Point(166, 81)
        Me.DateInvoiceDueDate.Name = "DateInvoiceDueDate"
        Me.DateInvoiceDueDate.ShowCheckBox = True
        Me.DateInvoiceDueDate.Size = New System.Drawing.Size(147, 23)
        Me.DateInvoiceDueDate.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(166, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 17)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Invoice Due Date:"
        '
        'DateInvoiceReference
        '
        Me.DateInvoiceReference.Checked = False
        Me.DateInvoiceReference.CustomFormat = "dd-MM-yyyy"
        Me.DateInvoiceReference.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateInvoiceReference.Location = New System.Drawing.Point(6, 81)
        Me.DateInvoiceReference.Name = "DateInvoiceReference"
        Me.DateInvoiceReference.ShowCheckBox = True
        Me.DateInvoiceReference.Size = New System.Drawing.Size(144, 23)
        Me.DateInvoiceReference.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(6, 60)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(160, 17)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Invoice Reference Date:"
        '
        'TxtInvoiceReferenceNo
        '
        Me.TxtInvoiceReferenceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtInvoiceReferenceNo.Location = New System.Drawing.Point(6, 33)
        Me.TxtInvoiceReferenceNo.Name = "TxtInvoiceReferenceNo"
        Me.TxtInvoiceReferenceNo.Size = New System.Drawing.Size(306, 23)
        Me.TxtInvoiceReferenceNo.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(6, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(148, 17)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Invoice Reference No:"
        '
        'TxtTeam
        '
        Me.TxtTeam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTeam.Location = New System.Drawing.Point(328, 80)
        Me.TxtTeam.Name = "TxtTeam"
        Me.TxtTeam.Size = New System.Drawing.Size(100, 23)
        Me.TxtTeam.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(327, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 17)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Team"
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox3.Controls.Add(Me.txtUnitName)
        Me.UiGroupBox3.Controls.Add(Me.TxtUnitQTYReceive)
        Me.UiGroupBox3.Controls.Add(Me.Label17)
        Me.UiGroupBox3.Controls.Add(Me.TxtUnitQTY)
        Me.UiGroupBox3.Controls.Add(Me.BtnAddMoreItem)
        Me.UiGroupBox3.Controls.Add(Me.DateExpiry)
        Me.UiGroupBox3.Controls.Add(Me.Label16)
        Me.UiGroupBox3.Controls.Add(Me.BtnRemoveItem)
        Me.UiGroupBox3.Controls.Add(Me.BtnAddItem)
        Me.UiGroupBox3.Controls.Add(Me.TxtItemCost)
        Me.UiGroupBox3.Controls.Add(Me.Label4)
        Me.UiGroupBox3.Controls.Add(Me.lblUnitName)
        Me.UiGroupBox3.Controls.Add(Me.TxtQTYReceive)
        Me.UiGroupBox3.Controls.Add(Me.Label3)
        Me.UiGroupBox3.Controls.Add(Me.CboItem)
        Me.UiGroupBox3.Controls.Add(Me.Label1)
        Me.UiGroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiGroupBox3.Location = New System.Drawing.Point(5, 163)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.Size = New System.Drawing.Size(1130, 73)
        Me.UiGroupBox3.TabIndex = 3
        Me.UiGroupBox3.Text = "Select Item"
        Me.UiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'txtUnitName
        '
        Me.txtUnitName.Location = New System.Drawing.Point(457, 41)
        Me.txtUnitName.Name = "txtUnitName"
        Me.txtUnitName.ReadOnly = True
        Me.txtUnitName.Size = New System.Drawing.Size(148, 26)
        Me.txtUnitName.TabIndex = 21
        '
        'TxtUnitQTYReceive
        '
        Me.TxtUnitQTYReceive.Location = New System.Drawing.Point(367, 41)
        Me.TxtUnitQTYReceive.Name = "TxtUnitQTYReceive"
        Me.TxtUnitQTYReceive.Size = New System.Drawing.Size(84, 26)
        Me.TxtUnitQTYReceive.TabIndex = 20
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Blue
        Me.Label17.Location = New System.Drawing.Point(374, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(69, 24)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "ចំនួនទទួល"
        '
        'TxtUnitQTY
        '
        Me.TxtUnitQTY.Location = New System.Drawing.Point(938, 8)
        Me.TxtUnitQTY.Name = "TxtUnitQTY"
        Me.TxtUnitQTY.ReadOnly = True
        Me.TxtUnitQTY.Size = New System.Drawing.Size(57, 26)
        Me.TxtUnitQTY.TabIndex = 18
        Me.TxtUnitQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtUnitQTY.Visible = False
        '
        'BtnAddMoreItem
        '
        Me.BtnAddMoreItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddMoreItem.FlatAppearance.BorderSize = 0
        Me.BtnAddMoreItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddMoreItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddMoreItem.ForeColor = System.Drawing.Color.Red
        Me.BtnAddMoreItem.Image = CType(resources.GetObject("BtnAddMoreItem.Image"), System.Drawing.Image)
        Me.BtnAddMoreItem.Location = New System.Drawing.Point(326, 37)
        Me.BtnAddMoreItem.Name = "BtnAddMoreItem"
        Me.BtnAddMoreItem.Size = New System.Drawing.Size(32, 31)
        Me.BtnAddMoreItem.TabIndex = 17
        Me.BtnAddMoreItem.UseVisualStyleBackColor = True
        '
        'DateExpiry
        '
        Me.DateExpiry.Checked = False
        Me.DateExpiry.CustomFormat = "dd-MM-yyyy"
        Me.DateExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateExpiry.Location = New System.Drawing.Point(803, 40)
        Me.DateExpiry.Name = "DateExpiry"
        Me.DateExpiry.ShowCheckBox = True
        Me.DateExpiry.Size = New System.Drawing.Size(144, 26)
        Me.DateExpiry.TabIndex = 14
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(801, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 17)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Expiry Date:"
        '
        'BtnRemoveItem
        '
        Me.BtnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemoveItem.FlatAppearance.BorderSize = 0
        Me.BtnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemoveItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemoveItem.ForeColor = System.Drawing.Color.Red
        Me.BtnRemoveItem.Image = CType(resources.GetObject("BtnRemoveItem.Image"), System.Drawing.Image)
        Me.BtnRemoveItem.Location = New System.Drawing.Point(1004, 38)
        Me.BtnRemoveItem.Name = "BtnRemoveItem"
        Me.BtnRemoveItem.Size = New System.Drawing.Size(36, 31)
        Me.BtnRemoveItem.TabIndex = 9
        Me.BtnRemoveItem.UseVisualStyleBackColor = True
        '
        'BtnAddItem
        '
        Me.BtnAddItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddItem.FlatAppearance.BorderSize = 0
        Me.BtnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddItem.ForeColor = System.Drawing.Color.Red
        Me.BtnAddItem.Image = CType(resources.GetObject("BtnAddItem.Image"), System.Drawing.Image)
        Me.BtnAddItem.Location = New System.Drawing.Point(959, 37)
        Me.BtnAddItem.Name = "BtnAddItem"
        Me.BtnAddItem.Size = New System.Drawing.Size(36, 31)
        Me.BtnAddItem.TabIndex = 8
        Me.BtnAddItem.UseVisualStyleBackColor = True
        '
        'TxtItemCost
        '
        Me.TxtItemCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtItemCost.Location = New System.Drawing.Point(707, 40)
        Me.TxtItemCost.Name = "TxtItemCost"
        Me.TxtItemCost.Size = New System.Drawing.Size(91, 26)
        Me.TxtItemCost.TabIndex = 7
        Me.TxtItemCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(722, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Last Cost:"
        '
        'lblUnitName
        '
        Me.lblUnitName.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitName.ForeColor = System.Drawing.Color.Blue
        Me.lblUnitName.Location = New System.Drawing.Point(478, 17)
        Me.lblUnitName.Name = "lblUnitName"
        Me.lblUnitName.Size = New System.Drawing.Size(77, 17)
        Me.lblUnitName.TabIndex = 2
        Me.lblUnitName.Text = "Unit"
        Me.lblUnitName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TxtQTYReceive
        '
        Me.TxtQTYReceive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtQTYReceive.Location = New System.Drawing.Point(613, 40)
        Me.TxtQTYReceive.Name = "TxtQTYReceive"
        Me.TxtQTYReceive.ReadOnly = True
        Me.TxtQTYReceive.Size = New System.Drawing.Size(89, 26)
        Me.TxtQTYReceive.TabIndex = 5
        Me.TxtQTYReceive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(629, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ចំនួនរាយ"
        '
        'CboItem
        '
        Me.CboItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboItem.FormattingEnabled = True
        Me.CboItem.Location = New System.Drawing.Point(10, 41)
        Me.CboItem.Name = "CboItem"
        Me.CboItem.Size = New System.Drawing.Size(314, 26)
        Me.CboItem.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(10, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item Name:"
        '
        'UiGroupBox4
        '
        Me.UiGroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox4.Controls.Add(Me.GridListItemReceive)
        Me.UiGroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiGroupBox4.Location = New System.Drawing.Point(5, 236)
        Me.UiGroupBox4.Name = "UiGroupBox4"
        Me.UiGroupBox4.Size = New System.Drawing.Size(1130, 428)
        Me.UiGroupBox4.TabIndex = 4
        Me.UiGroupBox4.Text = "Item List"
        Me.UiGroupBox4.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center
        Me.UiGroupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'GridListItemReceive
        '
        Me.GridListItemReceive.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridListItemReceive.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        GridListItemReceive_DesignTimeLayout.LayoutString = resources.GetString("GridListItemReceive_DesignTimeLayout.LayoutString")
        Me.GridListItemReceive.DesignTimeLayout = GridListItemReceive_DesignTimeLayout
        Me.GridListItemReceive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridListItemReceive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GridListItemReceive.GroupByBoxVisible = False
        Me.GridListItemReceive.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridListItemReceive.Location = New System.Drawing.Point(3, 22)
        Me.GridListItemReceive.Name = "GridListItemReceive"
        Me.GridListItemReceive.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.GridListItemReceive.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridListItemReceive.RecordNavigator = True
        Me.GridListItemReceive.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridListItemReceive.Size = New System.Drawing.Size(1124, 403)
        Me.GridListItemReceive.TabIndex = 0
        Me.GridListItemReceive.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridListItemReceive.VisualStyleManager = Me.VisualStyleManager1
        '
        'VisualStyleManager1
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme1.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        JanusColorScheme1.UseThemes = False
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Standard
        Me.VisualStyleManager1.ColorSchemes.Add(JanusColorScheme1)
        Me.VisualStyleManager1.DefaultColorScheme = "Scheme0"
        '
        'UiGroupBox5
        '
        Me.UiGroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox5.Controls.Add(Me.TxtReceiveNote)
        Me.UiGroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiGroupBox5.Location = New System.Drawing.Point(5, 668)
        Me.UiGroupBox5.Name = "UiGroupBox5"
        Me.UiGroupBox5.Size = New System.Drawing.Size(414, 209)
        Me.UiGroupBox5.TabIndex = 5
        Me.UiGroupBox5.Text = "Received Item Note:"
        Me.UiGroupBox5.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'TxtReceiveNote
        '
        Me.TxtReceiveNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtReceiveNote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtReceiveNote.Font = New System.Drawing.Font("Kh Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReceiveNote.Location = New System.Drawing.Point(3, 22)
        Me.TxtReceiveNote.Multiline = True
        Me.TxtReceiveNote.Name = "TxtReceiveNote"
        Me.TxtReceiveNote.Size = New System.Drawing.Size(408, 184)
        Me.TxtReceiveNote.TabIndex = 0
        '
        'UiGroupBox6
        '
        Me.UiGroupBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox6.Controls.Add(Me.TxtVATPercent)
        Me.UiGroupBox6.Controls.Add(Me.TxtTotalAmounDue)
        Me.UiGroupBox6.Controls.Add(Me.TxtDeposit)
        Me.UiGroupBox6.Controls.Add(Me.TxtTotalAmountIncludVAT)
        Me.UiGroupBox6.Controls.Add(Me.TxtVAT)
        Me.UiGroupBox6.Controls.Add(Me.TxtTotalAmoutExcludVAT)
        Me.UiGroupBox6.Controls.Add(Me.Label10)
        Me.UiGroupBox6.Controls.Add(Me.Label9)
        Me.UiGroupBox6.Controls.Add(Me.Label8)
        Me.UiGroupBox6.Controls.Add(Me.Label6)
        Me.UiGroupBox6.Controls.Add(Me.Label5)
        Me.UiGroupBox6.Controls.Add(Me.Label7)
        Me.UiGroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiGroupBox6.Location = New System.Drawing.Point(676, 670)
        Me.UiGroupBox6.Name = "UiGroupBox6"
        Me.UiGroupBox6.Size = New System.Drawing.Size(459, 207)
        Me.UiGroupBox6.TabIndex = 6
        Me.UiGroupBox6.Text = "Total:"
        Me.UiGroupBox6.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'TxtVATPercent
        '
        Me.TxtVATPercent.BackColor = System.Drawing.Color.White
        Me.TxtVATPercent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtVATPercent.Location = New System.Drawing.Point(254, 54)
        Me.TxtVATPercent.Name = "TxtVATPercent"
        Me.TxtVATPercent.Size = New System.Drawing.Size(62, 26)
        Me.TxtVATPercent.TabIndex = 1
        Me.TxtVATPercent.Text = "0"
        Me.TxtVATPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTotalAmounDue
        '
        Me.TxtTotalAmounDue.BackColor = System.Drawing.Color.Silver
        Me.TxtTotalAmounDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalAmounDue.Location = New System.Drawing.Point(254, 152)
        Me.TxtTotalAmounDue.Name = "TxtTotalAmounDue"
        Me.TxtTotalAmounDue.ReadOnly = True
        Me.TxtTotalAmounDue.Size = New System.Drawing.Size(195, 26)
        Me.TxtTotalAmounDue.TabIndex = 5
        Me.TxtTotalAmounDue.Text = "0"
        Me.TxtTotalAmounDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDeposit
        '
        Me.TxtDeposit.BackColor = System.Drawing.Color.White
        Me.TxtDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDeposit.Location = New System.Drawing.Point(254, 120)
        Me.TxtDeposit.Name = "TxtDeposit"
        Me.TxtDeposit.Size = New System.Drawing.Size(195, 26)
        Me.TxtDeposit.TabIndex = 4
        Me.TxtDeposit.Text = "0"
        Me.TxtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTotalAmountIncludVAT
        '
        Me.TxtTotalAmountIncludVAT.BackColor = System.Drawing.Color.Silver
        Me.TxtTotalAmountIncludVAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalAmountIncludVAT.Location = New System.Drawing.Point(254, 88)
        Me.TxtTotalAmountIncludVAT.Name = "TxtTotalAmountIncludVAT"
        Me.TxtTotalAmountIncludVAT.ReadOnly = True
        Me.TxtTotalAmountIncludVAT.Size = New System.Drawing.Size(195, 26)
        Me.TxtTotalAmountIncludVAT.TabIndex = 3
        Me.TxtTotalAmountIncludVAT.Text = "0"
        Me.TxtTotalAmountIncludVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtVAT
        '
        Me.TxtVAT.BackColor = System.Drawing.Color.Silver
        Me.TxtVAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtVAT.Location = New System.Drawing.Point(335, 54)
        Me.TxtVAT.Name = "TxtVAT"
        Me.TxtVAT.ReadOnly = True
        Me.TxtVAT.Size = New System.Drawing.Size(114, 26)
        Me.TxtVAT.TabIndex = 2
        Me.TxtVAT.Text = "0"
        Me.TxtVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTotalAmoutExcludVAT
        '
        Me.TxtTotalAmoutExcludVAT.BackColor = System.Drawing.Color.Silver
        Me.TxtTotalAmoutExcludVAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalAmoutExcludVAT.Location = New System.Drawing.Point(254, 21)
        Me.TxtTotalAmoutExcludVAT.Name = "TxtTotalAmoutExcludVAT"
        Me.TxtTotalAmoutExcludVAT.ReadOnly = True
        Me.TxtTotalAmoutExcludVAT.Size = New System.Drawing.Size(195, 26)
        Me.TxtTotalAmoutExcludVAT.TabIndex = 0
        Me.TxtTotalAmoutExcludVAT.Text = "0"
        Me.TxtTotalAmoutExcludVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(7, 157)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(229, 21)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Amount Due $:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(7, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(229, 21)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Less Deposit $:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(7, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(229, 21)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Total Amount Including VAT $:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(7, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(229, 21)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "VAT(%):"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(7, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(229, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total Amount Excluding VAT $:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(318, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 21)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "%"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ErrReceive
        '
        Me.ErrReceive.ContainerControl = Me
        '
        'ForReceiveOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1142, 881)
        Me.Controls.Add(Me.UiGroupBox6)
        Me.Controls.Add(Me.UiGroupBox5)
        Me.Controls.Add(Me.UiGroupBox4)
        Me.Controls.Add(Me.UiGroupBox3)
        Me.Controls.Add(Me.UiGroupBox2)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ForReceiveOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receive Medicine"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox3.ResumeLayout(False)
        Me.UiGroupBox3.PerformLayout()
        CType(Me.UiGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox4.ResumeLayout(False)
        CType(Me.GridListItemReceive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox5.ResumeLayout(False)
        Me.UiGroupBox5.PerformLayout()
        CType(Me.UiGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox6.ResumeLayout(False)
        Me.UiGroupBox6.PerformLayout()
        CType(Me.ErrReceive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents UiGroupBox4 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents UiGroupBox5 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents UiGroupBox6 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents CboSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents GridListItemReceive As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblUnitName As System.Windows.Forms.Label
    Friend WithEvents CboItem As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtQTYReceive As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnRemoveItem As System.Windows.Forms.Button
    Friend WithEvents BtnAddItem As System.Windows.Forms.Button
    Friend WithEvents TxtItemCost As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtTotalAmounDue As System.Windows.Forms.TextBox
    Friend WithEvents TxtDeposit As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalAmountIncludVAT As System.Windows.Forms.TextBox
    Friend WithEvents TxtVAT As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalAmoutExcludVAT As System.Windows.Forms.TextBox
    Friend WithEvents TxtReceiveNote As System.Windows.Forms.TextBox
    Friend WithEvents DateInvoiceReference As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtInvoiceReferenceNo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtTeam As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DateInvoiceDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DateExpiry As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ErrReceive As System.Windows.Forms.ErrorProvider
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents TxtVATPercent As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnAddMoreSupplyer As System.Windows.Forms.Button
    Friend WithEvents BtnAddMoreItem As System.Windows.Forms.Button
    Friend WithEvents VisualStyleManager1 As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents TxtUnitQTY As System.Windows.Forms.TextBox
    Friend WithEvents TxtUnitQTYReceive As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtUnitName As System.Windows.Forms.TextBox
End Class
