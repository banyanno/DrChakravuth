<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientInformation))
        Dim GridPatientInfo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GridPatientInfo = New Janus.Windows.GridEX.GridEX
        Me.VisualStyleManager1 = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CboAddress = New System.Windows.Forms.ComboBox
        Me.RadAddress = New System.Windows.Forms.RadioButton
        Me.Button2 = New System.Windows.Forms.Button
        Me.TxtByPhone = New System.Windows.Forms.TextBox
        Me.RadByPhone = New System.Windows.Forms.RadioButton
        Me.TxtByPatientName = New System.Windows.Forms.TextBox
        Me.TxtByPatientNo = New System.Windows.Forms.TextBox
        Me.RadByPateintName = New System.Windows.Forms.RadioButton
        Me.RadByPatientNo = New System.Windows.Forms.RadioButton
        Me.txtsex = New System.Windows.Forms.ComboBox
        Me.txtaddress = New System.Windows.Forms.ComboBox
        Me.TxtAge = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.dtbirth = New System.Windows.Forms.DateTimePicker
        Me.txtname = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtid = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtphone = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ErrValidate = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnSendPatientWaiting = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.btnPatientSendIssueReceipt = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
        Me.btnPrescription = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnHistory = New System.Windows.Forms.ToolStripButton
        Me.BtnPatientReferal = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator
        Me.BgLoadingPatient = New System.ComponentModel.BackgroundWorker
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GridPatientInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.UiTabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrValidate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.SplitContainer1, "SplitContainer1")
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridPatientInfo)
        resources.ApplyResources(Me.SplitContainer1.Panel1, "SplitContainer1.Panel1")
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UiTab1)
        '
        'GridPatientInfo
        '
        Me.GridPatientInfo.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridPatientInfo.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        resources.ApplyResources(GridPatientInfo_DesignTimeLayout, "GridPatientInfo_DesignTimeLayout")
        Me.GridPatientInfo.DesignTimeLayout = GridPatientInfo_DesignTimeLayout
        resources.ApplyResources(Me.GridPatientInfo, "GridPatientInfo")
        Me.GridPatientInfo.GroupByBoxVisible = False
        Me.GridPatientInfo.HeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.GridPatientInfo.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridPatientInfo.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridPatientInfo.Name = "GridPatientInfo"
        Me.GridPatientInfo.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.GridPatientInfo.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridPatientInfo.RecordNavigator = True
        Me.GridPatientInfo.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridPatientInfo.RowHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.GridPatientInfo.RowHeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.GridPatientInfo.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridPatientInfo.SelectedInactiveFormatStyle.BackColor = System.Drawing.SystemColors.Highlight
        Me.GridPatientInfo.SelectedInactiveFormatStyle.ForeColor = System.Drawing.SystemColors.Window
        Me.GridPatientInfo.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GridPatientInfo.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridPatientInfo.VisualStyleManager = Me.VisualStyleManager1
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
        'UiTab1
        '
        Me.UiTab1.BackColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.UiTab1, "UiTab1")
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage1})
        Me.UiTab1.VisualStyleManager = Me.VisualStyleManager1
        '
        'UiTabPage1
        '
        resources.ApplyResources(Me.UiTabPage1, "UiTabPage1")
        Me.UiTabPage1.Controls.Add(Me.GroupBox1)
        Me.UiTabPage1.Controls.Add(Me.txtsex)
        Me.UiTabPage1.Controls.Add(Me.txtaddress)
        Me.UiTabPage1.Controls.Add(Me.TxtAge)
        Me.UiTabPage1.Controls.Add(Me.Label14)
        Me.UiTabPage1.Controls.Add(Me.btnCancel)
        Me.UiTabPage1.Controls.Add(Me.btnSave)
        Me.UiTabPage1.Controls.Add(Me.btnDelete)
        Me.UiTabPage1.Controls.Add(Me.btnUpdate)
        Me.UiTabPage1.Controls.Add(Me.btnAdd)
        Me.UiTabPage1.Controls.Add(Me.dtbirth)
        Me.UiTabPage1.Controls.Add(Me.txtname)
        Me.UiTabPage1.Controls.Add(Me.Label1)
        Me.UiTabPage1.Controls.Add(Me.txtid)
        Me.UiTabPage1.Controls.Add(Me.Label4)
        Me.UiTabPage1.Controls.Add(Me.Label3)
        Me.UiTabPage1.Controls.Add(Me.txtphone)
        Me.UiTabPage1.Controls.Add(Me.Label2)
        Me.UiTabPage1.Controls.Add(Me.Label7)
        Me.UiTabPage1.Controls.Add(Me.Label5)
        Me.UiTabPage1.Key = "Patient Registration Info."
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.TabStop = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CboAddress)
        Me.GroupBox1.Controls.Add(Me.RadAddress)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.TxtByPhone)
        Me.GroupBox1.Controls.Add(Me.RadByPhone)
        Me.GroupBox1.Controls.Add(Me.TxtByPatientName)
        Me.GroupBox1.Controls.Add(Me.TxtByPatientNo)
        Me.GroupBox1.Controls.Add(Me.RadByPateintName)
        Me.GroupBox1.Controls.Add(Me.RadByPatientNo)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'CboAddress
        '
        Me.CboAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        resources.ApplyResources(Me.CboAddress, "CboAddress")
        Me.CboAddress.FormattingEnabled = True
        Me.CboAddress.Name = "CboAddress"
        '
        'RadAddress
        '
        resources.ApplyResources(Me.RadAddress, "RadAddress")
        Me.RadAddress.ForeColor = System.Drawing.Color.Blue
        Me.RadAddress.Name = "RadAddress"
        Me.RadAddress.TabStop = True
        Me.RadAddress.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.ForeColor = System.Drawing.Color.Blue
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TxtByPhone
        '
        resources.ApplyResources(Me.TxtByPhone, "TxtByPhone")
        Me.TxtByPhone.Name = "TxtByPhone"
        '
        'RadByPhone
        '
        resources.ApplyResources(Me.RadByPhone, "RadByPhone")
        Me.RadByPhone.ForeColor = System.Drawing.Color.Blue
        Me.RadByPhone.Name = "RadByPhone"
        Me.RadByPhone.TabStop = True
        Me.RadByPhone.UseVisualStyleBackColor = True
        '
        'TxtByPatientName
        '
        Me.TxtByPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtByPatientName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.TxtByPatientName, "TxtByPatientName")
        Me.TxtByPatientName.Name = "TxtByPatientName"
        '
        'TxtByPatientNo
        '
        Me.TxtByPatientNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.TxtByPatientNo, "TxtByPatientNo")
        Me.TxtByPatientNo.Name = "TxtByPatientNo"
        '
        'RadByPateintName
        '
        resources.ApplyResources(Me.RadByPateintName, "RadByPateintName")
        Me.RadByPateintName.ForeColor = System.Drawing.Color.Blue
        Me.RadByPateintName.Name = "RadByPateintName"
        Me.RadByPateintName.TabStop = True
        Me.RadByPateintName.UseVisualStyleBackColor = True
        '
        'RadByPatientNo
        '
        resources.ApplyResources(Me.RadByPatientNo, "RadByPatientNo")
        Me.RadByPatientNo.Checked = True
        Me.RadByPatientNo.ForeColor = System.Drawing.Color.Blue
        Me.RadByPatientNo.Name = "RadByPatientNo"
        Me.RadByPatientNo.TabStop = True
        Me.RadByPatientNo.UseVisualStyleBackColor = True
        '
        'txtsex
        '
        Me.txtsex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtsex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        resources.ApplyResources(Me.txtsex, "txtsex")
        Me.txtsex.FormattingEnabled = True
        Me.txtsex.Items.AddRange(New Object() {resources.GetString("txtsex.Items"), resources.GetString("txtsex.Items1")})
        Me.txtsex.Name = "txtsex"
        '
        'txtaddress
        '
        Me.txtaddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtaddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        resources.ApplyResources(Me.txtaddress, "txtaddress")
        Me.txtaddress.FormattingEnabled = True
        Me.txtaddress.Name = "txtaddress"
        '
        'TxtAge
        '
        resources.ApplyResources(Me.TxtAge, "TxtAge")
        Me.TxtAge.Name = "TxtAge"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Name = "Label14"
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnCancel, "btnCancel")
        Me.btnCancel.ForeColor = System.Drawing.Color.Blue
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnSave, "btnSave")
        Me.btnSave.ForeColor = System.Drawing.Color.Blue
        Me.btnSave.Name = "btnSave"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnDelete, "btnDelete")
        Me.btnDelete.ForeColor = System.Drawing.Color.Blue
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnUpdate, "btnUpdate")
        Me.btnUpdate.ForeColor = System.Drawing.Color.Blue
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnAdd, "btnAdd")
        Me.btnAdd.ForeColor = System.Drawing.Color.Blue
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dtbirth
        '
        resources.ApplyResources(Me.dtbirth, "dtbirth")
        Me.dtbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtbirth.Name = "dtbirth"
        Me.dtbirth.Value = New Date(2013, 1, 1, 23, 7, 0, 0)
        '
        'txtname
        '
        Me.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtname, "txtname")
        Me.txtname.Name = "txtname"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Name = "Label1"
        '
        'txtid
        '
        resources.ApplyResources(Me.txtid, "txtid")
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Name = "Label3"
        '
        'txtphone
        '
        Me.txtphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.txtphone, "txtphone")
        Me.txtphone.Name = "txtphone"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Name = "Label2"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Name = "Label7"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Name = "Label5"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'ErrValidate
        '
        Me.ErrValidate.ContainerControl = Me
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        resources.ApplyResources(Me.ToolStrip1, "ToolStrip1")
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator5, Me.BtnSendPatientWaiting, Me.ToolStripSeparator7, Me.btnPatientSendIssueReceipt, Me.ToolStripSeparator10, Me.btnPrescription, Me.ToolStripSeparator6, Me.BtnHistory, Me.BtnPatientReferal, Me.ToolStripSeparator11})
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        '
        'ToolStripButton1
        '
        resources.ApplyResources(Me.ToolStripButton1, "ToolStripButton1")
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Name = "ToolStripButton1"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        resources.ApplyResources(Me.ToolStripSeparator5, "ToolStripSeparator5")
        '
        'BtnSendPatientWaiting
        '
        resources.ApplyResources(Me.BtnSendPatientWaiting, "BtnSendPatientWaiting")
        Me.BtnSendPatientWaiting.ForeColor = System.Drawing.Color.White
        Me.BtnSendPatientWaiting.Name = "BtnSendPatientWaiting"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        resources.ApplyResources(Me.ToolStripSeparator7, "ToolStripSeparator7")
        '
        'btnPatientSendIssueReceipt
        '
        resources.ApplyResources(Me.btnPatientSendIssueReceipt, "btnPatientSendIssueReceipt")
        Me.btnPatientSendIssueReceipt.ForeColor = System.Drawing.Color.White
        Me.btnPatientSendIssueReceipt.Name = "btnPatientSendIssueReceipt"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        resources.ApplyResources(Me.ToolStripSeparator10, "ToolStripSeparator10")
        '
        'btnPrescription
        '
        resources.ApplyResources(Me.btnPrescription, "btnPrescription")
        Me.btnPrescription.ForeColor = System.Drawing.Color.White
        Me.btnPrescription.Image = Global.Clinic_Management_System.My.Resources.Resources.edit
        Me.btnPrescription.Name = "btnPrescription"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        resources.ApplyResources(Me.ToolStripSeparator6, "ToolStripSeparator6")
        '
        'BtnHistory
        '
        resources.ApplyResources(Me.BtnHistory, "BtnHistory")
        Me.BtnHistory.ForeColor = System.Drawing.Color.White
        Me.BtnHistory.Image = Global.Clinic_Management_System.My.Resources.Resources.new_appointment
        Me.BtnHistory.Name = "BtnHistory"
        '
        'BtnPatientReferal
        '
        resources.ApplyResources(Me.BtnPatientReferal, "BtnPatientReferal")
        Me.BtnPatientReferal.ForeColor = System.Drawing.Color.Blue
        Me.BtnPatientReferal.Image = Global.Clinic_Management_System.My.Resources.Resources.wheelchair
        Me.BtnPatientReferal.Name = "BtnPatientReferal"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        resources.ApplyResources(Me.ToolStripSeparator11, "ToolStripSeparator11")
        '
        'BgLoadingPatient
        '
        '
        'PatientInformation
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "PatientInformation"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GridPatientInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        Me.UiTabPage1.ResumeLayout(False)
        Me.UiTabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrValidate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridPatientInfo As Janus.Windows.GridEX.GridEX
    Friend WithEvents ErrValidate As System.Windows.Forms.ErrorProvider
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnHistory As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnPrescription As System.Windows.Forms.ToolStripButton
    Friend WithEvents BgLoadingPatient As System.ComponentModel.BackgroundWorker
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents dtbirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents txtphone As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnSendPatientWaiting As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPatientReferal As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnPatientSendIssueReceipt As System.Windows.Forms.ToolStripButton
    Friend WithEvents TxtAge As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtaddress As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtByPhone As System.Windows.Forms.TextBox
    Friend WithEvents RadByPhone As System.Windows.Forms.RadioButton
    Friend WithEvents TxtByPatientName As System.Windows.Forms.TextBox
    Friend WithEvents TxtByPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents RadByPateintName As System.Windows.Forms.RadioButton
    Friend WithEvents RadByPatientNo As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CboAddress As System.Windows.Forms.ComboBox
    Friend WithEvents RadAddress As System.Windows.Forms.RadioButton
    Friend WithEvents txtsex As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents VisualStyleManager1 As Janus.Windows.Common.VisualStyleManager

End Class
