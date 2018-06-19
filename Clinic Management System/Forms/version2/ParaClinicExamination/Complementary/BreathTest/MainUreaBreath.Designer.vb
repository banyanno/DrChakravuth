<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainUreaBreath
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
        Dim GridBreathTest_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainUreaBreath))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnPrintPreviw = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnNewBreathTest = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnUpdateBreath = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnDelete = New System.Windows.Forms.ToolStripButton
        Me.GridBreathTest = New Janus.Windows.GridEX.GridEX
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnFindPatient = New System.Windows.Forms.Button
        Me.TxtPatientNo = New System.Windows.Forms.TextBox
        Me.ChByPatientNo = New System.Windows.Forms.CheckBox
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TxtMoreInfo = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.DateRequest = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbodoctor = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtResult = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtIndication = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.CboConclusion = New System.Windows.Forms.ComboBox
        Me.ErrBreathTest = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BgLoadData = New System.ComponentModel.BackgroundWorker
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridBreathTest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrBreathTest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnPrintPreviw, Me.ToolStripSeparator5, Me.BtnNewBreathTest, Me.ToolStripSeparator1, Me.BtnUpdateBreath, Me.ToolStripSeparator2, Me.btnDelete})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(915, 28)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "New Breath Test"
        '
        'BtnPrintPreviw
        '
        Me.BtnPrintPreviw.ForeColor = System.Drawing.Color.Blue
        Me.BtnPrintPreviw.Image = Global.Clinic_Management_System.My.Resources.Resources.printer
        Me.BtnPrintPreviw.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintPreviw.Name = "BtnPrintPreviw"
        Me.BtnPrintPreviw.Size = New System.Drawing.Size(126, 25)
        Me.BtnPrintPreviw.Text = "Print Preview"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 28)
        '
        'BtnNewBreathTest
        '
        Me.BtnNewBreathTest.ForeColor = System.Drawing.Color.Blue
        Me.BtnNewBreathTest.Image = Global.Clinic_Management_System.My.Resources.Resources.send_to_doctor
        Me.BtnNewBreathTest.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewBreathTest.Name = "BtnNewBreathTest"
        Me.BtnNewBreathTest.Size = New System.Drawing.Size(145, 25)
        Me.BtnNewBreathTest.Text = "New Breath Test"
        Me.BtnNewBreathTest.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
        Me.ToolStripSeparator1.Visible = False
        '
        'BtnUpdateBreath
        '
        Me.BtnUpdateBreath.ForeColor = System.Drawing.Color.Blue
        Me.BtnUpdateBreath.Image = Global.Clinic_Management_System.My.Resources.Resources.edit
        Me.BtnUpdateBreath.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUpdateBreath.Name = "BtnUpdateBreath"
        Me.BtnUpdateBreath.Size = New System.Drawing.Size(201, 25)
        Me.BtnUpdateBreath.Text = "Upate Breath Test Result"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 28)
        '
        'btnDelete
        '
        Me.btnDelete.ForeColor = System.Drawing.Color.Blue
        Me.btnDelete.Image = Global.Clinic_Management_System.My.Resources.Resources.delete_appointment
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(157, 25)
        Me.btnDelete.Text = "Delete Breath Test"
        '
        'GridBreathTest
        '
        GridBreathTest_DesignTimeLayout.LayoutString = resources.GetString("GridBreathTest_DesignTimeLayout.LayoutString")
        Me.GridBreathTest.DesignTimeLayout = GridBreathTest_DesignTimeLayout
        Me.GridBreathTest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridBreathTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GridBreathTest.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridBreathTest.GroupByBoxVisible = False
        Me.GridBreathTest.Location = New System.Drawing.Point(0, 0)
        Me.GridBreathTest.Name = "GridBreathTest"
        Me.GridBreathTest.RecordNavigator = True
        Me.GridBreathTest.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridBreathTest.Size = New System.Drawing.Size(915, 210)
        Me.GridBreathTest.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 28)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridBreathTest)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(915, 558)
        Me.SplitContainer1.SplitterDistance = 210
        Me.SplitContainer1.TabIndex = 2
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer2.Size = New System.Drawing.Size(915, 344)
        Me.SplitContainer2.SplitterDistance = 275
        Me.SplitContainer2.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnFindPatient)
        Me.GroupBox2.Controls.Add(Me.TxtPatientNo)
        Me.GroupBox2.Controls.Add(Me.ChByPatientNo)
        Me.GroupBox2.Controls.Add(Me.DateTo)
        Me.GroupBox2.Controls.Add(Me.DateFrom)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(275, 344)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Find Patient Breath Test"
        '
        'BtnFindPatient
        '
        Me.BtnFindPatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFindPatient.Location = New System.Drawing.Point(18, 154)
        Me.BtnFindPatient.Name = "BtnFindPatient"
        Me.BtnFindPatient.Size = New System.Drawing.Size(117, 31)
        Me.BtnFindPatient.TabIndex = 6
        Me.BtnFindPatient.Text = "Find Patient"
        Me.BtnFindPatient.UseVisualStyleBackColor = True
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.Enabled = False
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.Location = New System.Drawing.Point(18, 121)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(232, 26)
        Me.TxtPatientNo.TabIndex = 5
        '
        'ChByPatientNo
        '
        Me.ChByPatientNo.AutoSize = True
        Me.ChByPatientNo.Location = New System.Drawing.Point(18, 98)
        Me.ChByPatientNo.Name = "ChByPatientNo"
        Me.ChByPatientNo.Size = New System.Drawing.Size(101, 17)
        Me.ChByPatientNo.TabIndex = 4
        Me.ChByPatientNo.Text = "With Patient No"
        Me.ChByPatientNo.UseVisualStyleBackColor = True
        '
        'DateTo
        '
        Me.DateTo.Checked = False
        Me.DateTo.CustomFormat = "dd/MM/yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(56, 63)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(196, 26)
        Me.DateTo.TabIndex = 3
        '
        'DateFrom
        '
        Me.DateFrom.Checked = False
        Me.DateFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(56, 27)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(196, 26)
        Me.DateFrom.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "To:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "From:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TxtMoreInfo)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.DateRequest)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbodoctor)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtResult)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TxtIndication)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.CboConclusion)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(636, 344)
        Me.Panel1.TabIndex = 2
        '
        'TxtMoreInfo
        '
        Me.TxtMoreInfo.Enabled = False
        Me.TxtMoreInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMoreInfo.Location = New System.Drawing.Point(118, 250)
        Me.TxtMoreInfo.Multiline = True
        Me.TxtMoreInfo.Name = "TxtMoreInfo"
        Me.TxtMoreInfo.ReadOnly = True
        Me.TxtMoreInfo.Size = New System.Drawing.Size(426, 84)
        Me.TxtMoreInfo.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(5, 253)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 20)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "More Info:"
        '
        'DateRequest
        '
        Me.DateRequest.Checked = False
        Me.DateRequest.CustomFormat = "dd/MM/yyyy"
        Me.DateRequest.Enabled = False
        Me.DateRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateRequest.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateRequest.Location = New System.Drawing.Point(118, 22)
        Me.DateRequest.Name = "DateRequest"
        Me.DateRequest.Size = New System.Drawing.Size(196, 26)
        Me.DateRequest.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 20)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Date Request:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Request By:"
        '
        'cbodoctor
        '
        Me.cbodoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbodoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbodoctor.DropDownWidth = 500
        Me.cbodoctor.Enabled = False
        Me.cbodoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodoctor.FormattingEnabled = True
        Me.cbodoctor.Location = New System.Drawing.Point(118, 61)
        Me.cbodoctor.Name = "cbodoctor"
        Me.cbodoctor.Size = New System.Drawing.Size(339, 28)
        Me.cbodoctor.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Indication:"
        '
        'TxtResult
        '
        Me.TxtResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtResult.Location = New System.Drawing.Point(118, 132)
        Me.TxtResult.Multiline = True
        Me.TxtResult.Name = "TxtResult"
        Me.TxtResult.ReadOnly = True
        Me.TxtResult.Size = New System.Drawing.Size(339, 74)
        Me.TxtResult.TabIndex = 3
        Me.TxtResult.Text = "S.1 :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "S.2 :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "/\(%..) :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 20)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Result:"
        '
        'TxtIndication
        '
        Me.TxtIndication.Enabled = False
        Me.TxtIndication.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIndication.Location = New System.Drawing.Point(118, 96)
        Me.TxtIndication.Name = "TxtIndication"
        Me.TxtIndication.Size = New System.Drawing.Size(339, 26)
        Me.TxtIndication.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 220)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 20)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Conclusion:"
        '
        'CboConclusion
        '
        Me.CboConclusion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboConclusion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboConclusion.DropDownWidth = 500
        Me.CboConclusion.Enabled = False
        Me.CboConclusion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboConclusion.FormattingEnabled = True
        Me.CboConclusion.Items.AddRange(New Object() {"", "Positive", "Negative"})
        Me.CboConclusion.Location = New System.Drawing.Point(118, 212)
        Me.CboConclusion.Name = "CboConclusion"
        Me.CboConclusion.Size = New System.Drawing.Size(197, 28)
        Me.CboConclusion.TabIndex = 4
        '
        'ErrBreathTest
        '
        Me.ErrBreathTest.ContainerControl = Me
        '
        'BgLoadData
        '
        '
        'MainUreaBreath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "MainUreaBreath"
        Me.Size = New System.Drawing.Size(915, 586)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridBreathTest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrBreathTest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewBreathTest As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnUpdateBreath As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridBreathTest As Janus.Windows.GridEX.GridEX
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtMoreInfo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DateRequest As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbodoctor As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtResult As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtIndication As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CboConclusion As System.Windows.Forms.ComboBox
    Friend WithEvents BtnPrintPreviw As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents ChByPatientNo As System.Windows.Forms.CheckBox
    Friend WithEvents BtnFindPatient As System.Windows.Forms.Button
    Friend WithEvents ErrBreathTest As System.Windows.Forms.ErrorProvider
    Friend WithEvents BgLoadData As System.ComponentModel.BackgroundWorker

End Class
