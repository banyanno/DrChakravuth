<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWaitingConsuling
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
        Dim WaitingList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWaitingConsuling))
        Dim PrescriptionList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridComplaintList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridMedical_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim PhysicalList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim ItemResultList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim FibroConclusionList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim NasoConclusionList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim ColoConclusionList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim EchoConclusionList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridScan_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridMRI_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridFibroScan_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridCFAnapat_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnNewConsult = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDoctorRequestExamination = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnConsultainHistory = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCancelWaiting = New System.Windows.Forms.ToolStripButton
        Me.WaitingList = New Janus.Windows.GridEX.GridEX
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage
        Me.CRVMedicalHistoryReport = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.UiTabPage2 = New Janus.Windows.UI.Tab.UITabPage
        Me.GroupBox19 = New System.Windows.Forms.GroupBox
        Me.PrescriptionList = New Janus.Windows.GridEX.GridEX
        Me.ConPrescription = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnDeletePrescription = New System.Windows.Forms.ToolStripMenuItem
        Me.UiTabPage6 = New Janus.Windows.UI.Tab.UITabPage
        Me.GridComplaintList = New Janus.Windows.GridEX.GridEX
        Me.ConComplaint = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnDeleteComplaint = New System.Windows.Forms.ToolStripMenuItem
        Me.UiTabPage7 = New Janus.Windows.UI.Tab.UITabPage
        Me.GridMedical = New Janus.Windows.GridEX.GridEX
        Me.ConMedicalHistory = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnDeleteMedical = New System.Windows.Forms.ToolStripMenuItem
        Me.UiTabPage8 = New Janus.Windows.UI.Tab.UITabPage
        Me.PhysicalList = New Janus.Windows.GridEX.GridEX
        Me.ConPhysical = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnDeletePhysical = New System.Windows.Forms.ToolStripMenuItem
        Me.UiTabPage3 = New Janus.Windows.UI.Tab.UITabPage
        Me.UiTab2 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage4 = New Janus.Windows.UI.Tab.UITabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ItemResultList = New Janus.Windows.GridEX.GridEX
        Me.ConBlood = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnEditBlood = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnAddBlood = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDeleteBlood = New System.Windows.Forms.ToolStripMenuItem
        Me.UiTabPage5 = New Janus.Windows.UI.Tab.UITabPage
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.FibroConclusionList = New Janus.Windows.GridEX.GridEX
        Me.ConFibro = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnFibroscopy = New System.Windows.Forms.ToolStripMenuItem
        Me.UiTabPage9 = New Janus.Windows.UI.Tab.UITabPage
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.NasoConclusionList = New Janus.Windows.GridEX.GridEX
        Me.ConNasogastro = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnNasogastro = New System.Windows.Forms.ToolStripMenuItem
        Me.UiTabPage10 = New Janus.Windows.UI.Tab.UITabPage
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.ColoConclusionList = New Janus.Windows.GridEX.GridEX
        Me.ConColoscopy = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnColoscopy = New System.Windows.Forms.ToolStripMenuItem
        Me.UiTabPage11 = New Janus.Windows.UI.Tab.UITabPage
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.EchoConclusionList = New Janus.Windows.GridEX.GridEX
        Me.ConEcho = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnDeleteEcho = New System.Windows.Forms.ToolStripMenuItem
        Me.UiTabPage12 = New Janus.Windows.UI.Tab.UITabPage
        Me.GroupBox11 = New System.Windows.Forms.GroupBox
        Me.GroupBox20 = New System.Windows.Forms.GroupBox
        Me.GridScan = New Janus.Windows.GridEX.GridEX
        Me.ConScan = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnDeleteScan = New System.Windows.Forms.ToolStripMenuItem
        Me.UiTabPage13 = New Janus.Windows.UI.Tab.UITabPage
        Me.GroupBox21 = New System.Windows.Forms.GroupBox
        Me.GridMRI = New Janus.Windows.GridEX.GridEX
        Me.ConMRI = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnMRI = New System.Windows.Forms.ToolStripMenuItem
        Me.UiTabPage14 = New Janus.Windows.UI.Tab.UITabPage
        Me.GroupBox22 = New System.Windows.Forms.GroupBox
        Me.GridFibroScan = New Janus.Windows.GridEX.GridEX
        Me.ConFibroScan = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnFibroscan = New System.Windows.Forms.ToolStripMenuItem
        Me.UiTabPage15 = New Janus.Windows.UI.Tab.UITabPage
        Me.GroupBox23 = New System.Windows.Forms.GroupBox
        Me.GridCFAnapat = New Janus.Windows.GridEX.GridEX
        Me.ConCFAnaPath = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnDeleteAnapath = New System.Windows.Forms.ToolStripMenuItem
        Me.ResultContextMenu = New Janus.Windows.Ribbon.RibbonContextMenu(Me.components)
        Me.cmdDelete = New Janus.Windows.Ribbon.DropDownCommand
        Me.DropDownCommand1 = New Janus.Windows.Ribbon.DropDownCommand
        Me.ErrPrescription = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.bgLoadingData = New System.ComponentModel.BackgroundWorker
        Me.BgLoadingReport = New System.ComponentModel.BackgroundWorker
        Me.ContextFibroConclusion = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnDeletFibro = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip1.SuspendLayout()
        CType(Me.WaitingList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.UiTabPage1.SuspendLayout()
        Me.UiTabPage2.SuspendLayout()
        Me.GroupBox19.SuspendLayout()
        CType(Me.PrescriptionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConPrescription.SuspendLayout()
        Me.UiTabPage6.SuspendLayout()
        CType(Me.GridComplaintList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConComplaint.SuspendLayout()
        Me.UiTabPage7.SuspendLayout()
        CType(Me.GridMedical, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConMedicalHistory.SuspendLayout()
        Me.UiTabPage8.SuspendLayout()
        CType(Me.PhysicalList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConPhysical.SuspendLayout()
        Me.UiTabPage3.SuspendLayout()
        CType(Me.UiTab2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab2.SuspendLayout()
        Me.UiTabPage4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ItemResultList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConBlood.SuspendLayout()
        Me.UiTabPage5.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.FibroConclusionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConFibro.SuspendLayout()
        Me.UiTabPage9.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NasoConclusionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConNasogastro.SuspendLayout()
        Me.UiTabPage10.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.ColoConclusionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConColoscopy.SuspendLayout()
        Me.UiTabPage11.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.EchoConclusionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConEcho.SuspendLayout()
        Me.UiTabPage12.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox20.SuspendLayout()
        CType(Me.GridScan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConScan.SuspendLayout()
        Me.UiTabPage13.SuspendLayout()
        Me.GroupBox21.SuspendLayout()
        CType(Me.GridMRI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConMRI.SuspendLayout()
        Me.UiTabPage14.SuspendLayout()
        Me.GroupBox22.SuspendLayout()
        CType(Me.GridFibroScan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConFibroScan.SuspendLayout()
        Me.UiTabPage15.SuspendLayout()
        Me.GroupBox23.SuspendLayout()
        CType(Me.GridCFAnapat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConCFAnaPath.SuspendLayout()
        CType(Me.ErrPrescription, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextFibroConclusion.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRefresh, Me.ToolStripSeparator1, Me.BtnNewConsult, Me.ToolStripSeparator2, Me.BtnDoctorRequestExamination, Me.ToolStripSeparator5, Me.BtnConsultainHistory, Me.ToolStripSeparator6, Me.btnCancelWaiting})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1465, 32)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.Blue
        Me.btnRefresh.Image = Global.Clinic_Management_System.My.Resources.Resources.refresh
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(99, 29)
        Me.btnRefresh.Text = "Refresh"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'BtnNewConsult
        '
        Me.BtnNewConsult.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewConsult.ForeColor = System.Drawing.Color.Blue
        Me.BtnNewConsult.Image = Global.Clinic_Management_System.My.Resources.Resources.Chat
        Me.BtnNewConsult.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewConsult.Name = "BtnNewConsult"
        Me.BtnNewConsult.Size = New System.Drawing.Size(228, 29)
        Me.BtnNewConsult.Text = "Start New Consultation"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 32)
        '
        'BtnDoctorRequestExamination
        '
        Me.BtnDoctorRequestExamination.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDoctorRequestExamination.ForeColor = System.Drawing.Color.Blue
        Me.BtnDoctorRequestExamination.Image = Global.Clinic_Management_System.My.Resources.Resources._1349422790_microscope
        Me.BtnDoctorRequestExamination.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDoctorRequestExamination.Name = "BtnDoctorRequestExamination"
        Me.BtnDoctorRequestExamination.Size = New System.Drawing.Size(239, 29)
        Me.BtnDoctorRequestExamination.Text = "Request for Examination"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 32)
        '
        'BtnConsultainHistory
        '
        Me.BtnConsultainHistory.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultainHistory.ForeColor = System.Drawing.Color.Blue
        Me.BtnConsultainHistory.Image = Global.Clinic_Management_System.My.Resources.Resources._1349422899_clipboard
        Me.BtnConsultainHistory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnConsultainHistory.Name = "BtnConsultainHistory"
        Me.BtnConsultainHistory.Size = New System.Drawing.Size(162, 29)
        Me.BtnConsultainHistory.Text = "Medical History"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 32)
        '
        'btnCancelWaiting
        '
        Me.btnCancelWaiting.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelWaiting.ForeColor = System.Drawing.Color.Blue
        Me.btnCancelWaiting.Image = Global.Clinic_Management_System.My.Resources.Resources.delete_appointment
        Me.btnCancelWaiting.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelWaiting.Name = "btnCancelWaiting"
        Me.btnCancelWaiting.Size = New System.Drawing.Size(161, 29)
        Me.btnCancelWaiting.Text = "Delete Waiting"
        '
        'WaitingList
        '
        Me.WaitingList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.WaitingList.BlendColor = System.Drawing.SystemColors.Control
        WaitingList_DesignTimeLayout.LayoutString = resources.GetString("WaitingList_DesignTimeLayout.LayoutString")
        Me.WaitingList.DesignTimeLayout = WaitingList_DesignTimeLayout
        Me.WaitingList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WaitingList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.WaitingList.GroupByBoxVisible = False
        Me.WaitingList.HeaderFormatStyle.FontSize = 10.0!
        Me.WaitingList.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.WaitingList.Location = New System.Drawing.Point(0, 0)
        Me.WaitingList.Name = "WaitingList"
        Me.WaitingList.RecordNavigator = True
        Me.WaitingList.SelectedInactiveFormatStyle.BackColor = System.Drawing.SystemColors.Highlight
        Me.WaitingList.SelectedInactiveFormatStyle.ForeColor = System.Drawing.SystemColors.Window
        Me.WaitingList.Size = New System.Drawing.Size(456, 748)
        Me.WaitingList.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 32)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer1.Size = New System.Drawing.Size(1465, 748)
        Me.SplitContainer1.SplitterDistance = 456
        Me.SplitContainer1.TabIndex = 2
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.WaitingList)
        Me.SplitContainer3.Panel2Collapsed = True
        Me.SplitContainer3.Size = New System.Drawing.Size(456, 748)
        Me.SplitContainer3.SplitterDistance = 1092
        Me.SplitContainer3.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.UiTab1)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1005, 748)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Medical History"
        '
        'UiTab1
        '
        Me.UiTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiTab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiTab1.ForeColor = System.Drawing.Color.Blue
        Me.UiTab1.Location = New System.Drawing.Point(3, 19)
        Me.UiTab1.Margin = New System.Windows.Forms.Padding(2)
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.Size = New System.Drawing.Size(999, 726)
        Me.UiTab1.TabIndex = 19
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage1, Me.UiTabPage2, Me.UiTabPage6, Me.UiTabPage7, Me.UiTabPage8, Me.UiTabPage3})
        Me.UiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Normal
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.CRVMedicalHistoryReport)
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 25)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(995, 698)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "     Medical History Report     "
        '
        'CRVMedicalHistoryReport
        '
        Me.CRVMedicalHistoryReport.ActiveViewIndex = -1
        Me.CRVMedicalHistoryReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVMedicalHistoryReport.DisplayGroupTree = False
        Me.CRVMedicalHistoryReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVMedicalHistoryReport.Location = New System.Drawing.Point(0, 0)
        Me.CRVMedicalHistoryReport.Name = "CRVMedicalHistoryReport"
        Me.CRVMedicalHistoryReport.SelectionFormula = ""
        Me.CRVMedicalHistoryReport.Size = New System.Drawing.Size(995, 698)
        Me.CRVMedicalHistoryReport.TabIndex = 0
        Me.CRVMedicalHistoryReport.ViewTimeSelectionFormula = ""
        '
        'UiTabPage2
        '
        Me.UiTabPage2.Controls.Add(Me.GroupBox19)
        Me.UiTabPage2.Location = New System.Drawing.Point(1, 25)
        Me.UiTabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.UiTabPage2.Name = "UiTabPage2"
        Me.UiTabPage2.Size = New System.Drawing.Size(1455, 481)
        Me.UiTabPage2.TabStop = True
        Me.UiTabPage2.Text = "     Prescription     "
        '
        'GroupBox19
        '
        Me.GroupBox19.Controls.Add(Me.PrescriptionList)
        Me.GroupBox19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox19.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(1455, 481)
        Me.GroupBox19.TabIndex = 69
        Me.GroupBox19.TabStop = False
        '
        'PrescriptionList
        '
        Me.PrescriptionList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.PrescriptionList.ContextMenuStrip = Me.ConPrescription
        PrescriptionList_DesignTimeLayout.LayoutString = resources.GetString("PrescriptionList_DesignTimeLayout.LayoutString")
        Me.PrescriptionList.DesignTimeLayout = PrescriptionList_DesignTimeLayout
        Me.PrescriptionList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrescriptionList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PrescriptionList.GroupByBoxVisible = False
        Me.PrescriptionList.HeaderFormatStyle.FontSize = 10.0!
        Me.PrescriptionList.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.PrescriptionList.Location = New System.Drawing.Point(3, 19)
        Me.PrescriptionList.Name = "PrescriptionList"
        Me.PrescriptionList.RecordNavigator = True
        Me.PrescriptionList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.PrescriptionList.Size = New System.Drawing.Size(1449, 459)
        Me.PrescriptionList.TabIndex = 1
        '
        'ConPrescription
        '
        Me.ConPrescription.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnDeletePrescription})
        Me.ConPrescription.Name = "ConComplaint"
        Me.ConPrescription.Size = New System.Drawing.Size(209, 30)
        '
        'BtnDeletePrescription
        '
        Me.BtnDeletePrescription.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnDeletePrescription.ForeColor = System.Drawing.Color.Red
        Me.BtnDeletePrescription.Name = "BtnDeletePrescription"
        Me.BtnDeletePrescription.Size = New System.Drawing.Size(208, 26)
        Me.BtnDeletePrescription.Text = "Delete Prescription"
        '
        'UiTabPage6
        '
        Me.UiTabPage6.Controls.Add(Me.GridComplaintList)
        Me.UiTabPage6.Location = New System.Drawing.Point(1, 25)
        Me.UiTabPage6.Name = "UiTabPage6"
        Me.UiTabPage6.Size = New System.Drawing.Size(1455, 481)
        Me.UiTabPage6.TabStop = True
        Me.UiTabPage6.Text = "     Patient Complaint     "
        '
        'GridComplaintList
        '
        Me.GridComplaintList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridComplaintList.ContextMenuStrip = Me.ConComplaint
        GridComplaintList_DesignTimeLayout.LayoutString = resources.GetString("GridComplaintList_DesignTimeLayout.LayoutString")
        Me.GridComplaintList.DesignTimeLayout = GridComplaintList_DesignTimeLayout
        Me.GridComplaintList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridComplaintList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GridComplaintList.GroupByBoxFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridComplaintList.GroupByBoxVisible = False
        Me.GridComplaintList.GroupRowFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridComplaintList.HeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GridComplaintList.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridComplaintList.Location = New System.Drawing.Point(0, 0)
        Me.GridComplaintList.Name = "GridComplaintList"
        Me.GridComplaintList.RecordNavigator = True
        Me.GridComplaintList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridComplaintList.Size = New System.Drawing.Size(1455, 481)
        Me.GridComplaintList.TabIndex = 38
        '
        'ConComplaint
        '
        Me.ConComplaint.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnDeleteComplaint})
        Me.ConComplaint.Name = "ConComplaint"
        Me.ConComplaint.Size = New System.Drawing.Size(198, 30)
        '
        'BtnDeleteComplaint
        '
        Me.BtnDeleteComplaint.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnDeleteComplaint.ForeColor = System.Drawing.Color.Red
        Me.BtnDeleteComplaint.Name = "BtnDeleteComplaint"
        Me.BtnDeleteComplaint.Size = New System.Drawing.Size(197, 26)
        Me.BtnDeleteComplaint.Text = "Delete Complaint"
        '
        'UiTabPage7
        '
        Me.UiTabPage7.Controls.Add(Me.GridMedical)
        Me.UiTabPage7.Location = New System.Drawing.Point(1, 25)
        Me.UiTabPage7.Name = "UiTabPage7"
        Me.UiTabPage7.Size = New System.Drawing.Size(1455, 481)
        Me.UiTabPage7.TabStop = True
        Me.UiTabPage7.Text = "     Medical History     "
        '
        'GridMedical
        '
        Me.GridMedical.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridMedical.ContextMenuStrip = Me.ConMedicalHistory
        GridMedical_DesignTimeLayout.LayoutString = resources.GetString("GridMedical_DesignTimeLayout.LayoutString")
        Me.GridMedical.DesignTimeLayout = GridMedical_DesignTimeLayout
        Me.GridMedical.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMedical.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridMedical.GroupByBoxVisible = False
        Me.GridMedical.HeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GridMedical.Location = New System.Drawing.Point(0, 0)
        Me.GridMedical.Name = "GridMedical"
        Me.GridMedical.RecordNavigator = True
        Me.GridMedical.RowFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GridMedical.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridMedical.Size = New System.Drawing.Size(1455, 481)
        Me.GridMedical.TabIndex = 14
        '
        'ConMedicalHistory
        '
        Me.ConMedicalHistory.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnDeleteMedical})
        Me.ConMedicalHistory.Name = "ConComplaint"
        Me.ConMedicalHistory.Size = New System.Drawing.Size(234, 30)
        '
        'BtnDeleteMedical
        '
        Me.BtnDeleteMedical.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnDeleteMedical.ForeColor = System.Drawing.Color.Red
        Me.BtnDeleteMedical.Name = "BtnDeleteMedical"
        Me.BtnDeleteMedical.Size = New System.Drawing.Size(233, 26)
        Me.BtnDeleteMedical.Text = "Delete Medical History"
        '
        'UiTabPage8
        '
        Me.UiTabPage8.Controls.Add(Me.PhysicalList)
        Me.UiTabPage8.Location = New System.Drawing.Point(1, 25)
        Me.UiTabPage8.Name = "UiTabPage8"
        Me.UiTabPage8.Size = New System.Drawing.Size(1455, 481)
        Me.UiTabPage8.TabStop = True
        Me.UiTabPage8.Text = "     Physical     "
        '
        'PhysicalList
        '
        Me.PhysicalList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.PhysicalList.ContextMenuStrip = Me.ConPhysical
        PhysicalList_DesignTimeLayout.LayoutString = resources.GetString("PhysicalList_DesignTimeLayout.LayoutString")
        Me.PhysicalList.DesignTimeLayout = PhysicalList_DesignTimeLayout
        Me.PhysicalList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PhysicalList.GroupByBoxVisible = False
        Me.PhysicalList.HeaderFormatStyle.FontSize = 10.0!
        Me.PhysicalList.Location = New System.Drawing.Point(0, 0)
        Me.PhysicalList.Name = "PhysicalList"
        Me.PhysicalList.RecordNavigator = True
        Me.PhysicalList.RowFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhysicalList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.PhysicalList.Size = New System.Drawing.Size(1455, 481)
        Me.PhysicalList.TabIndex = 17
        '
        'ConPhysical
        '
        Me.ConPhysical.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnDeletePhysical})
        Me.ConPhysical.Name = "ConComplaint"
        Me.ConPhysical.Size = New System.Drawing.Size(182, 30)
        '
        'BtnDeletePhysical
        '
        Me.BtnDeletePhysical.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnDeletePhysical.ForeColor = System.Drawing.Color.Red
        Me.BtnDeletePhysical.Name = "BtnDeletePhysical"
        Me.BtnDeletePhysical.Size = New System.Drawing.Size(181, 26)
        Me.BtnDeletePhysical.Text = "Delete Physical"
        '
        'UiTabPage3
        '
        Me.UiTabPage3.Controls.Add(Me.UiTab2)
        Me.UiTabPage3.Location = New System.Drawing.Point(1, 25)
        Me.UiTabPage3.Name = "UiTabPage3"
        Me.UiTabPage3.Size = New System.Drawing.Size(1455, 481)
        Me.UiTabPage3.TabStop = True
        Me.UiTabPage3.Text = "     Para Clinic Examination     "
        '
        'UiTab2
        '
        Me.UiTab2.Cursor = System.Windows.Forms.Cursors.Default
        Me.UiTab2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiTab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiTab2.Location = New System.Drawing.Point(0, 0)
        Me.UiTab2.Name = "UiTab2"
        Me.UiTab2.Size = New System.Drawing.Size(1455, 481)
        Me.UiTab2.TabIndex = 3
        Me.UiTab2.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage4, Me.UiTabPage5, Me.UiTabPage9, Me.UiTabPage10, Me.UiTabPage11, Me.UiTabPage12, Me.UiTabPage13, Me.UiTabPage14, Me.UiTabPage15})
        Me.UiTab2.TabsStateStyles.FormatStyle.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiTab2.TabsStateStyles.FormatStyle.FontSize = 10.0!
        Me.UiTab2.TabsStateStyles.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiTab2.TabStripAlignment = Janus.Windows.UI.Tab.TabStripAlignment.Bottom
        Me.UiTab2.TextOrientation = Janus.Windows.UI.Tab.TextOrientation.Horizontal
        Me.UiTab2.UseCompatibleTextRendering = False
        '
        'UiTabPage4
        '
        Me.UiTabPage4.AutoScroll = True
        Me.UiTabPage4.Controls.Add(Me.GroupBox1)
        Me.UiTabPage4.ImageIndex = 0
        Me.UiTabPage4.Key = "Biology(Blood Check)"
        Me.UiTabPage4.Location = New System.Drawing.Point(1, 3)
        Me.UiTabPage4.Name = "UiTabPage4"
        Me.UiTabPage4.Size = New System.Drawing.Size(1451, 452)
        Me.UiTabPage4.TabStop = True
        Me.UiTabPage4.Text = "     Biology(Blood Check)     "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1451, 452)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ItemResultList)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 17)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1445, 432)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Blood Check"
        '
        'ItemResultList
        '
        Me.ItemResultList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.ItemResultList.ContextMenuStrip = Me.ConBlood
        ItemResultList_DesignTimeLayout.LayoutString = resources.GetString("ItemResultList_DesignTimeLayout.LayoutString")
        Me.ItemResultList.DesignTimeLayout = ItemResultList_DesignTimeLayout
        Me.ItemResultList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemResultList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ItemResultList.GroupByBoxVisible = False
        Me.ItemResultList.HeaderFormatStyle.FontSize = 10.0!
        Me.ItemResultList.Location = New System.Drawing.Point(3, 17)
        Me.ItemResultList.Name = "ItemResultList"
        Me.ItemResultList.RecordNavigator = True
        Me.ItemResultList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.ItemResultList.Size = New System.Drawing.Size(1439, 412)
        Me.ItemResultList.TabIndex = 6
        '
        'ConBlood
        '
        Me.ConBlood.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnEditBlood, Me.ToolStripSeparator7, Me.BtnAddBlood, Me.ToolStripSeparator4, Me.BtnDeleteBlood})
        Me.ConBlood.Name = "ConComplaint"
        Me.ConBlood.Size = New System.Drawing.Size(166, 94)
        '
        'BtnEditBlood
        '
        Me.BtnEditBlood.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnEditBlood.ForeColor = System.Drawing.Color.Blue
        Me.BtnEditBlood.Name = "BtnEditBlood"
        Me.BtnEditBlood.Size = New System.Drawing.Size(165, 26)
        Me.BtnEditBlood.Text = "Edite Blood"
        Me.BtnEditBlood.Visible = False
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(162, 6)
        Me.ToolStripSeparator7.Visible = False
        '
        'BtnAddBlood
        '
        Me.BtnAddBlood.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnAddBlood.ForeColor = System.Drawing.Color.Blue
        Me.BtnAddBlood.Name = "BtnAddBlood"
        Me.BtnAddBlood.Size = New System.Drawing.Size(165, 26)
        Me.BtnAddBlood.Text = "Add Blood"
        Me.BtnAddBlood.Visible = False
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(162, 6)
        Me.ToolStripSeparator4.Visible = False
        '
        'BtnDeleteBlood
        '
        Me.BtnDeleteBlood.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnDeleteBlood.ForeColor = System.Drawing.Color.Red
        Me.BtnDeleteBlood.Name = "BtnDeleteBlood"
        Me.BtnDeleteBlood.Size = New System.Drawing.Size(165, 26)
        Me.BtnDeleteBlood.Text = "Delete Blood"
        '
        'UiTabPage5
        '
        Me.UiTabPage5.AutoScroll = True
        Me.UiTabPage5.Controls.Add(Me.GroupBox12)
        Me.UiTabPage5.Key = "Fibro"
        Me.UiTabPage5.Location = New System.Drawing.Point(1, 3)
        Me.UiTabPage5.Name = "UiTabPage5"
        Me.UiTabPage5.Size = New System.Drawing.Size(1451, 452)
        Me.UiTabPage5.TabStop = True
        Me.UiTabPage5.Text = "    Fibroscopy     "
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.GroupBox5)
        Me.GroupBox12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox12.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(1451, 452)
        Me.GroupBox12.TabIndex = 12
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Result of Fibro"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.FibroConclusionList)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(3, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1445, 430)
        Me.GroupBox5.TabIndex = 37
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "List of conclusion"
        '
        'FibroConclusionList
        '
        Me.FibroConclusionList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.FibroConclusionList.ContextMenuStrip = Me.ConFibro
        FibroConclusionList_DesignTimeLayout.LayoutString = resources.GetString("FibroConclusionList_DesignTimeLayout.LayoutString")
        Me.FibroConclusionList.DesignTimeLayout = FibroConclusionList_DesignTimeLayout
        Me.FibroConclusionList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FibroConclusionList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FibroConclusionList.GroupByBoxVisible = False
        Me.FibroConclusionList.HeaderFormatStyle.FontSize = 10.0!
        Me.FibroConclusionList.Location = New System.Drawing.Point(3, 19)
        Me.FibroConclusionList.Name = "FibroConclusionList"
        Me.FibroConclusionList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.FibroConclusionList.Size = New System.Drawing.Size(1439, 408)
        Me.FibroConclusionList.TabIndex = 3
        '
        'ConFibro
        '
        Me.ConFibro.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnFibroscopy})
        Me.ConFibro.Name = "ConComplaint"
        Me.ConFibro.Size = New System.Drawing.Size(202, 30)
        '
        'BtnFibroscopy
        '
        Me.BtnFibroscopy.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnFibroscopy.ForeColor = System.Drawing.Color.Red
        Me.BtnFibroscopy.Name = "BtnFibroscopy"
        Me.BtnFibroscopy.Size = New System.Drawing.Size(201, 26)
        Me.BtnFibroscopy.Text = "Delete Fibroscopy"
        '
        'UiTabPage9
        '
        Me.UiTabPage9.AutoScroll = True
        Me.UiTabPage9.Controls.Add(Me.GroupBox6)
        Me.UiTabPage9.Key = "Nasogastro"
        Me.UiTabPage9.Location = New System.Drawing.Point(1, 3)
        Me.UiTabPage9.Name = "UiTabPage9"
        Me.UiTabPage9.Size = New System.Drawing.Size(1451, 452)
        Me.UiTabPage9.TabStop = True
        Me.UiTabPage9.Text = "     Nasogastro     "
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.GroupBox2)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1451, 452)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NasoConclusionList)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1445, 432)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List of conclusion"
        '
        'NasoConclusionList
        '
        Me.NasoConclusionList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.NasoConclusionList.ContextMenuStrip = Me.ConNasogastro
        NasoConclusionList_DesignTimeLayout.LayoutString = resources.GetString("NasoConclusionList_DesignTimeLayout.LayoutString")
        Me.NasoConclusionList.DesignTimeLayout = NasoConclusionList_DesignTimeLayout
        Me.NasoConclusionList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NasoConclusionList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NasoConclusionList.GroupByBoxVisible = False
        Me.NasoConclusionList.HeaderFormatStyle.FontSize = 10.0!
        Me.NasoConclusionList.Location = New System.Drawing.Point(3, 17)
        Me.NasoConclusionList.Name = "NasoConclusionList"
        Me.NasoConclusionList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.NasoConclusionList.Size = New System.Drawing.Size(1439, 412)
        Me.NasoConclusionList.TabIndex = 4
        '
        'ConNasogastro
        '
        Me.ConNasogastro.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNasogastro})
        Me.ConNasogastro.Name = "ConComplaint"
        Me.ConNasogastro.Size = New System.Drawing.Size(206, 30)
        '
        'BtnNasogastro
        '
        Me.BtnNasogastro.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnNasogastro.ForeColor = System.Drawing.Color.Red
        Me.BtnNasogastro.Name = "BtnNasogastro"
        Me.BtnNasogastro.Size = New System.Drawing.Size(205, 26)
        Me.BtnNasogastro.Text = "Delete Nasogastro"
        '
        'UiTabPage10
        '
        Me.UiTabPage10.AutoScroll = True
        Me.UiTabPage10.Controls.Add(Me.GroupBox7)
        Me.UiTabPage10.Key = "Coloscopy"
        Me.UiTabPage10.Location = New System.Drawing.Point(1, 3)
        Me.UiTabPage10.Name = "UiTabPage10"
        Me.UiTabPage10.Size = New System.Drawing.Size(1451, 452)
        Me.UiTabPage10.TabStop = True
        Me.UiTabPage10.Text = "     Coloscopy     "
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.GroupBox8)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox7.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(1451, 452)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.ColoConclusionList)
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox8.Location = New System.Drawing.Point(3, 17)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(1445, 432)
        Me.GroupBox8.TabIndex = 59
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "List of conclusion"
        '
        'ColoConclusionList
        '
        Me.ColoConclusionList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.ColoConclusionList.ContextMenuStrip = Me.ConColoscopy
        ColoConclusionList_DesignTimeLayout.LayoutString = resources.GetString("ColoConclusionList_DesignTimeLayout.LayoutString")
        Me.ColoConclusionList.DesignTimeLayout = ColoConclusionList_DesignTimeLayout
        Me.ColoConclusionList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ColoConclusionList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColoConclusionList.GroupByBoxVisible = False
        Me.ColoConclusionList.HeaderFormatStyle.FontSize = 10.0!
        Me.ColoConclusionList.Location = New System.Drawing.Point(3, 17)
        Me.ColoConclusionList.Name = "ColoConclusionList"
        Me.ColoConclusionList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.ColoConclusionList.Size = New System.Drawing.Size(1439, 412)
        Me.ColoConclusionList.TabIndex = 5
        '
        'ConColoscopy
        '
        Me.ConColoscopy.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnColoscopy})
        Me.ConColoscopy.Name = "ConComplaint"
        Me.ConColoscopy.Size = New System.Drawing.Size(198, 30)
        '
        'btnColoscopy
        '
        Me.btnColoscopy.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnColoscopy.ForeColor = System.Drawing.Color.Red
        Me.btnColoscopy.Name = "btnColoscopy"
        Me.btnColoscopy.Size = New System.Drawing.Size(197, 26)
        Me.btnColoscopy.Text = "Delete Coloscopy"
        '
        'UiTabPage11
        '
        Me.UiTabPage11.AutoScroll = True
        Me.UiTabPage11.Controls.Add(Me.GroupBox9)
        Me.UiTabPage11.Key = "Echo"
        Me.UiTabPage11.Location = New System.Drawing.Point(1, 3)
        Me.UiTabPage11.Name = "UiTabPage11"
        Me.UiTabPage11.Size = New System.Drawing.Size(1451, 452)
        Me.UiTabPage11.TabStop = True
        Me.UiTabPage11.Text = "     Echo     "
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.GroupBox10)
        Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox9.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(1451, 452)
        Me.GroupBox9.TabIndex = 2
        Me.GroupBox9.TabStop = False
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.EchoConclusionList)
        Me.GroupBox10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox10.Location = New System.Drawing.Point(3, 17)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(1445, 432)
        Me.GroupBox10.TabIndex = 38
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "List of conclusion"
        '
        'EchoConclusionList
        '
        Me.EchoConclusionList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.EchoConclusionList.ContextMenuStrip = Me.ConEcho
        EchoConclusionList_DesignTimeLayout.LayoutString = resources.GetString("EchoConclusionList_DesignTimeLayout.LayoutString")
        Me.EchoConclusionList.DesignTimeLayout = EchoConclusionList_DesignTimeLayout
        Me.EchoConclusionList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EchoConclusionList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.EchoConclusionList.GroupByBoxVisible = False
        Me.EchoConclusionList.Location = New System.Drawing.Point(3, 17)
        Me.EchoConclusionList.Name = "EchoConclusionList"
        Me.EchoConclusionList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.EchoConclusionList.Size = New System.Drawing.Size(1439, 412)
        Me.EchoConclusionList.TabIndex = 6
        '
        'ConEcho
        '
        Me.ConEcho.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnDeleteEcho})
        Me.ConEcho.Name = "ConComplaint"
        Me.ConEcho.Size = New System.Drawing.Size(159, 30)
        '
        'BtnDeleteEcho
        '
        Me.BtnDeleteEcho.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnDeleteEcho.ForeColor = System.Drawing.Color.Red
        Me.BtnDeleteEcho.Name = "BtnDeleteEcho"
        Me.BtnDeleteEcho.Size = New System.Drawing.Size(158, 26)
        Me.BtnDeleteEcho.Text = "Delete Echo"
        '
        'UiTabPage12
        '
        Me.UiTabPage12.Controls.Add(Me.GroupBox11)
        Me.UiTabPage12.Key = "Scan"
        Me.UiTabPage12.Location = New System.Drawing.Point(1, 3)
        Me.UiTabPage12.Name = "UiTabPage12"
        Me.UiTabPage12.Size = New System.Drawing.Size(1451, 452)
        Me.UiTabPage12.TabStop = True
        Me.UiTabPage12.Text = "     Scan     "
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.GroupBox20)
        Me.GroupBox11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox11.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(1451, 452)
        Me.GroupBox11.TabIndex = 0
        Me.GroupBox11.TabStop = False
        '
        'GroupBox20
        '
        Me.GroupBox20.Controls.Add(Me.GridScan)
        Me.GroupBox20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox20.Location = New System.Drawing.Point(3, 17)
        Me.GroupBox20.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox20.Size = New System.Drawing.Size(1445, 432)
        Me.GroupBox20.TabIndex = 4
        Me.GroupBox20.TabStop = False
        Me.GroupBox20.Text = "Result of Scan"
        '
        'GridScan
        '
        Me.GridScan.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridScan.ContextMenuStrip = Me.ConScan
        GridScan_DesignTimeLayout.LayoutString = resources.GetString("GridScan_DesignTimeLayout.LayoutString")
        Me.GridScan.DesignTimeLayout = GridScan_DesignTimeLayout
        Me.GridScan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridScan.GroupByBoxVisible = False
        Me.GridScan.Location = New System.Drawing.Point(2, 16)
        Me.GridScan.Name = "GridScan"
        Me.GridScan.RecordNavigator = True
        Me.GridScan.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridScan.Size = New System.Drawing.Size(1441, 414)
        Me.GridScan.TabIndex = 1
        '
        'ConScan
        '
        Me.ConScan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnDeleteScan})
        Me.ConScan.Name = "ConComplaint"
        Me.ConScan.Size = New System.Drawing.Size(159, 30)
        '
        'BtnDeleteScan
        '
        Me.BtnDeleteScan.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnDeleteScan.ForeColor = System.Drawing.Color.Red
        Me.BtnDeleteScan.Name = "BtnDeleteScan"
        Me.BtnDeleteScan.Size = New System.Drawing.Size(158, 26)
        Me.BtnDeleteScan.Text = "Delete Scan"
        '
        'UiTabPage13
        '
        Me.UiTabPage13.Controls.Add(Me.GroupBox21)
        Me.UiTabPage13.Key = "M-R-I"
        Me.UiTabPage13.Location = New System.Drawing.Point(1, 3)
        Me.UiTabPage13.Name = "UiTabPage13"
        Me.UiTabPage13.Size = New System.Drawing.Size(1451, 452)
        Me.UiTabPage13.TabStop = True
        Me.UiTabPage13.Text = "     M-R-I     "
        '
        'GroupBox21
        '
        Me.GroupBox21.Controls.Add(Me.GridMRI)
        Me.GroupBox21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox21.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox21.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox21.Name = "GroupBox21"
        Me.GroupBox21.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox21.Size = New System.Drawing.Size(1451, 452)
        Me.GroupBox21.TabIndex = 1
        Me.GroupBox21.TabStop = False
        Me.GroupBox21.Text = "Result of M-R-I"
        '
        'GridMRI
        '
        Me.GridMRI.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridMRI.ContextMenuStrip = Me.ConMRI
        GridMRI_DesignTimeLayout.LayoutString = resources.GetString("GridMRI_DesignTimeLayout.LayoutString")
        Me.GridMRI.DesignTimeLayout = GridMRI_DesignTimeLayout
        Me.GridMRI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMRI.GroupByBoxVisible = False
        Me.GridMRI.Location = New System.Drawing.Point(2, 16)
        Me.GridMRI.Name = "GridMRI"
        Me.GridMRI.RecordNavigator = True
        Me.GridMRI.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridMRI.Size = New System.Drawing.Size(1447, 434)
        Me.GridMRI.TabIndex = 1
        '
        'ConMRI
        '
        Me.ConMRI.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnMRI})
        Me.ConMRI.Name = "ConComplaint"
        Me.ConMRI.Size = New System.Drawing.Size(166, 30)
        '
        'BtnMRI
        '
        Me.BtnMRI.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnMRI.ForeColor = System.Drawing.Color.Red
        Me.BtnMRI.Name = "BtnMRI"
        Me.BtnMRI.Size = New System.Drawing.Size(165, 26)
        Me.BtnMRI.Text = "Delete M-R-I"
        '
        'UiTabPage14
        '
        Me.UiTabPage14.Controls.Add(Me.GroupBox22)
        Me.UiTabPage14.Key = "FibroScan"
        Me.UiTabPage14.Location = New System.Drawing.Point(1, 3)
        Me.UiTabPage14.Name = "UiTabPage14"
        Me.UiTabPage14.Size = New System.Drawing.Size(1451, 452)
        Me.UiTabPage14.TabStop = True
        Me.UiTabPage14.Text = "     Fibro Scan     "
        '
        'GroupBox22
        '
        Me.GroupBox22.Controls.Add(Me.GridFibroScan)
        Me.GroupBox22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox22.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox22.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox22.Name = "GroupBox22"
        Me.GroupBox22.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox22.Size = New System.Drawing.Size(1451, 452)
        Me.GroupBox22.TabIndex = 4
        Me.GroupBox22.TabStop = False
        Me.GroupBox22.Text = "Fibro Scan"
        '
        'GridFibroScan
        '
        Me.GridFibroScan.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridFibroScan.ContextMenuStrip = Me.ConFibroScan
        GridFibroScan_DesignTimeLayout.LayoutString = resources.GetString("GridFibroScan_DesignTimeLayout.LayoutString")
        Me.GridFibroScan.DesignTimeLayout = GridFibroScan_DesignTimeLayout
        Me.GridFibroScan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridFibroScan.GroupByBoxVisible = False
        Me.GridFibroScan.Location = New System.Drawing.Point(2, 16)
        Me.GridFibroScan.Name = "GridFibroScan"
        Me.GridFibroScan.RecordNavigator = True
        Me.GridFibroScan.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridFibroScan.Size = New System.Drawing.Size(1447, 434)
        Me.GridFibroScan.TabIndex = 0
        '
        'ConFibroScan
        '
        Me.ConFibroScan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnFibroscan})
        Me.ConFibroScan.Name = "ConComplaint"
        Me.ConFibroScan.Size = New System.Drawing.Size(199, 30)
        '
        'BtnFibroscan
        '
        Me.BtnFibroscan.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnFibroscan.ForeColor = System.Drawing.Color.Red
        Me.BtnFibroscan.Name = "BtnFibroscan"
        Me.BtnFibroscan.Size = New System.Drawing.Size(198, 26)
        Me.BtnFibroscan.Text = "Delete Fibro Scan"
        '
        'UiTabPage15
        '
        Me.UiTabPage15.Controls.Add(Me.GroupBox23)
        Me.UiTabPage15.Key = "C.F Ana-Path"
        Me.UiTabPage15.Location = New System.Drawing.Point(1, 3)
        Me.UiTabPage15.Name = "UiTabPage15"
        Me.UiTabPage15.Size = New System.Drawing.Size(1451, 452)
        Me.UiTabPage15.TabStop = True
        Me.UiTabPage15.Text = "     C.F Ana-Path     "
        '
        'GroupBox23
        '
        Me.GroupBox23.Controls.Add(Me.GridCFAnapat)
        Me.GroupBox23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox23.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox23.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox23.Name = "GroupBox23"
        Me.GroupBox23.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox23.Size = New System.Drawing.Size(1451, 452)
        Me.GroupBox23.TabIndex = 5
        Me.GroupBox23.TabStop = False
        Me.GroupBox23.Text = "C.F Ana-Path"
        '
        'GridCFAnapat
        '
        Me.GridCFAnapat.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridCFAnapat.ContextMenuStrip = Me.ConCFAnaPath
        GridCFAnapat_DesignTimeLayout.LayoutString = resources.GetString("GridCFAnapat_DesignTimeLayout.LayoutString")
        Me.GridCFAnapat.DesignTimeLayout = GridCFAnapat_DesignTimeLayout
        Me.GridCFAnapat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCFAnapat.GroupByBoxVisible = False
        Me.GridCFAnapat.Location = New System.Drawing.Point(2, 16)
        Me.GridCFAnapat.Name = "GridCFAnapat"
        Me.GridCFAnapat.RecordNavigator = True
        Me.GridCFAnapat.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridCFAnapat.Size = New System.Drawing.Size(1447, 434)
        Me.GridCFAnapat.TabIndex = 0
        '
        'ConCFAnaPath
        '
        Me.ConCFAnaPath.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnDeleteAnapath})
        Me.ConCFAnaPath.Name = "ConComplaint"
        Me.ConCFAnaPath.Size = New System.Drawing.Size(215, 30)
        '
        'BtnDeleteAnapath
        '
        Me.BtnDeleteAnapath.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnDeleteAnapath.ForeColor = System.Drawing.Color.Red
        Me.BtnDeleteAnapath.Name = "BtnDeleteAnapath"
        Me.BtnDeleteAnapath.Size = New System.Drawing.Size(214, 26)
        Me.BtnDeleteAnapath.Text = "Delete C.F Ana-Path"
        '
        'ResultContextMenu
        '
        Me.ResultContextMenu.Commands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.cmdDelete, Me.DropDownCommand1})
        Me.ResultContextMenu.Name = "ResultContextMenu"
        '
        'cmdDelete
        '
        Me.cmdDelete.Key = "DropDownCommand2"
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Text = "Delete Result"
        '
        'DropDownCommand1
        '
        Me.DropDownCommand1.Key = "DropDownCommand1"
        Me.DropDownCommand1.Name = "DropDownCommand1"
        Me.DropDownCommand1.Text = ""
        '
        'ErrPrescription
        '
        Me.ErrPrescription.ContainerControl = Me
        '
        'bgLoadingData
        '
        '
        'BgLoadingReport
        '
        '
        'ContextFibroConclusion
        '
        Me.ContextFibroConclusion.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ContextFibroConclusion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnDeletFibro})
        Me.ContextFibroConclusion.Name = "ContextFibroConclusion"
        Me.ContextFibroConclusion.Size = New System.Drawing.Size(143, 28)
        '
        'BtnDeletFibro
        '
        Me.BtnDeletFibro.Name = "BtnDeletFibro"
        Me.BtnDeletFibro.Size = New System.Drawing.Size(142, 24)
        Me.BtnDeletFibro.Text = "Delete ..."
        '
        'MainWaitingConsuling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "MainWaitingConsuling"
        Me.Size = New System.Drawing.Size(1465, 780)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.WaitingList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        Me.UiTabPage1.ResumeLayout(False)
        Me.UiTabPage2.ResumeLayout(False)
        Me.GroupBox19.ResumeLayout(False)
        CType(Me.PrescriptionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConPrescription.ResumeLayout(False)
        Me.UiTabPage6.ResumeLayout(False)
        CType(Me.GridComplaintList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConComplaint.ResumeLayout(False)
        Me.UiTabPage7.ResumeLayout(False)
        CType(Me.GridMedical, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConMedicalHistory.ResumeLayout(False)
        Me.UiTabPage8.ResumeLayout(False)
        CType(Me.PhysicalList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConPhysical.ResumeLayout(False)
        Me.UiTabPage3.ResumeLayout(False)
        CType(Me.UiTab2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab2.ResumeLayout(False)
        Me.UiTabPage4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.ItemResultList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConBlood.ResumeLayout(False)
        Me.UiTabPage5.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.FibroConclusionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConFibro.ResumeLayout(False)
        Me.UiTabPage9.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.NasoConclusionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConNasogastro.ResumeLayout(False)
        Me.UiTabPage10.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.ColoConclusionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConColoscopy.ResumeLayout(False)
        Me.UiTabPage11.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        CType(Me.EchoConclusionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConEcho.ResumeLayout(False)
        Me.UiTabPage12.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox20.ResumeLayout(False)
        CType(Me.GridScan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConScan.ResumeLayout(False)
        Me.UiTabPage13.ResumeLayout(False)
        Me.GroupBox21.ResumeLayout(False)
        CType(Me.GridMRI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConMRI.ResumeLayout(False)
        Me.UiTabPage14.ResumeLayout(False)
        Me.GroupBox22.ResumeLayout(False)
        CType(Me.GridFibroScan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConFibroScan.ResumeLayout(False)
        Me.UiTabPage15.ResumeLayout(False)
        Me.GroupBox23.ResumeLayout(False)
        CType(Me.GridCFAnapat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConCFAnaPath.ResumeLayout(False)
        CType(Me.ErrPrescription, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextFibroConclusion.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents WaitingList As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnCancelWaiting As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnNewConsult As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ResultContextMenu As Janus.Windows.Ribbon.RibbonContextMenu
    Friend WithEvents cmdDelete As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDoctorRequestExamination As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ErrPrescription As System.Windows.Forms.ErrorProvider
    Friend WithEvents BtnConsultainHistory As System.Windows.Forms.ToolStripButton
    Friend WithEvents bgLoadingData As System.ComponentModel.BackgroundWorker
    Friend WithEvents DropDownCommand1 As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage2 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GroupBox19 As System.Windows.Forms.GroupBox
    Friend WithEvents PrescriptionList As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiTabPage6 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridComplaintList As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiTabPage7 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridMedical As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiTabPage8 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents PhysicalList As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents CRVMedicalHistoryReport As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents UiTabPage3 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTab2 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage4 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ItemResultList As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiTabPage5 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents FibroConclusionList As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiTabPage9 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents NasoConclusionList As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiTabPage10 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents ColoConclusionList As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiTabPage11 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage12 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox20 As System.Windows.Forms.GroupBox
    Friend WithEvents UiTabPage13 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GroupBox21 As System.Windows.Forms.GroupBox
    Friend WithEvents UiTabPage14 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GroupBox22 As System.Windows.Forms.GroupBox
    Friend WithEvents UiTabPage15 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GroupBox23 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents EchoConclusionList As Janus.Windows.GridEX.GridEX
    Friend WithEvents BgLoadingReport As System.ComponentModel.BackgroundWorker
    Friend WithEvents GridScan As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridMRI As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridFibroScan As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridCFAnapat As Janus.Windows.GridEX.GridEX
    Friend WithEvents ContextFibroConclusion As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnDeletFibro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConComplaint As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnDeleteComplaint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConMedicalHistory As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnDeleteMedical As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConPhysical As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnDeletePhysical As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConPrescription As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnDeletePrescription As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConBlood As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnDeleteBlood As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConFibro As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnFibroscopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConNasogastro As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnNasogastro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConColoscopy As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btnColoscopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConEcho As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnDeleteEcho As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConScan As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnDeleteScan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConMRI As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnMRI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConFibroScan As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnFibroscan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConCFAnaPath As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnDeleteAnapath As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnEditBlood As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnAddBlood As System.Windows.Forms.ToolStripMenuItem

End Class
