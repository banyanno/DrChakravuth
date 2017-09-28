Public Class main

    Dim DA_USER_PERMISION As New DSUserManagermentTableAdapters.V_USER_MENU_PERMISIONTableAdapter
    Dim DoctorConsultation As DoctorConsultation
    Dim PatientInformation As PatientInformation
    Dim DoctorFeeConsult As DoctorFee
    Dim AccountManagemt As MainInvoice
    Dim MedicinceReceived As UMgrMedicince
    Dim DoctorInformation As DoctorInformation
    Dim SymptomInformation As SymptomInformation
    Dim ClinicConsultation As UCConsultationType
    Dim PatientComplaint As UCPateintComplaint
    Dim MedicalHistory As UCMedical
    Dim ParaCheck As UCParaClinicExam
    Dim PhysicalExam As UCPhysicalExamination
    Dim Login As frmLoginChackTravoth
    Dim WaitingConsulting As MainWaitingConsuling
    Dim PatientReferTo As MainPatientReferto
    Dim DrRequestExam As DashbordDotorRequestExamination
    Dim ParameterList As MainParameter
    Dim UserManager As UCDepartment
    Dim IssueReceipt As UPatientIssueReceipt
    Dim PatientMedicalReport As UPatientMedicalReport
    Dim ClinicAnalysis As UAnalysis
    Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        InitUC()
        CheckPermistionOnForm()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Sub New(ByVal login As frmLoginChackTravoth)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.Login = login
        ' Add any initialization after the InitializeComponent() call.
        InitUC()
        CheckPermistionOnForm()
    End Sub
    Sub InitUC()

        PatientInformation = New PatientInformation(Me)
        Login.UpdateLabelStatus("Configure Hospital System 1.", True)
        Application.DoEvents()
        DoctorConsultation = New DoctorConsultation
        Login.UpdateLabelStatus("Configure Hospital System 2.", True)
        Application.DoEvents()
        DoctorFeeConsult = New DoctorFee
        Login.UpdateLabelStatus("Configure Hospital System 3.", True)
        Application.DoEvents()
        DoctorInformation = New DoctorInformation
        Login.UpdateLabelStatus("Configure Hospital System 4.", True)
        Application.DoEvents()
        SymptomInformation = New SymptomInformation
        Login.UpdateLabelStatus("Configure Hospital System 5.", True)
        Application.DoEvents()
        ClinicConsultation = New UCConsultationType
        Login.UpdateLabelStatus("Configure Hospital System 6.", True)
        Application.DoEvents()
        PatientComplaint = New UCPateintComplaint
        Login.UpdateLabelStatus("Configure Hospital System 7.", True)
        Application.DoEvents()
        MedicalHistory = New UCMedical
        Login.UpdateLabelStatus("Configure Hospital System 8.", True)
        Application.DoEvents()
        ParaCheck = New UCParaClinicExam
        Login.UpdateLabelStatus("Configure Hospital System 9.", True)
        Application.DoEvents()
        PhysicalExam = New UCPhysicalExamination
        Login.UpdateLabelStatus("Configure Hospital System 10.", True)
        Application.DoEvents()
        AccountManagemt = New MainInvoice
        Login.UpdateLabelStatus("Configure Hospital System 12.", True)
        Application.DoEvents()
        WaitingConsulting = New MainWaitingConsuling
        Login.UpdateLabelStatus("Configure Hospital System 13.", True)
        Application.DoEvents()
        PatientReferTo = New MainPatientReferto
        Login.UpdateLabelStatus("Configure Hospital System 14.", True)
        Application.DoEvents()
        DrRequestExam = New DashbordDotorRequestExamination
        Login.UpdateLabelStatus("Configure Hospital System 15.", True)
        Application.DoEvents()
        ParameterList = New MainParameter
        Login.UpdateLabelStatus("Configure Hospital System 16.", True)
        Application.DoEvents()
        UserManager = New UCDepartment
        Login.UpdateLabelStatus("Configure Hospital System 17.", True)
        Application.DoEvents()
        IssueReceipt = New UPatientIssueReceipt
        Login.UpdateLabelStatus("Configure Hospital System 18.", True)
        Application.DoEvents()
        PatientMedicalReport = New UPatientMedicalReport
        Login.UpdateLabelStatus("Configure Hospital System 19.", True)
        Application.DoEvents()
        Login.UpdateLabelStatus("Configure Hospital System 20.", True)
        ClinicAnalysis = New UAnalysis
        Application.DoEvents()
        Login.UpdateLabelStatus("Configure Hospital System 21", True)
        MedicinceReceived = New UMgrMedicince
    End Sub
    Private Delegate Sub DelShowLoadingPicture(ByVal visible As Boolean)
    Public Sub StatusLoading(ByVal v As Boolean)
        If Me.Created Then
            RibboStatusBar.Invoke(New DelShowLoadingPicture(AddressOf UpdateVisibleLoading), New Object() {v})
        End If
    End Sub
    Private Sub UpdateVisibleLoading(ByVal v As Boolean)
        LoadingBar.Visible = v
    End Sub
    Sub AddUserControl(ByVal PMainContainer As Janus.Windows.UI.Dock.UIPanelInnerContainer, ByVal UI As UserControl, ByVal Info As String)
        Me.Cursor = Cursors.WaitCursor
        PMainContainer.Controls.Clear()
        PMainContainer.AutoScroll = True
        'PMainContainer.AutoScrollMinSize = New Size(UI.Width, UI.Height)
        UI.Dock = DockStyle.Fill
        PMainContainer.Controls.Add(UI)
        Me.Cursor = Cursors.Default
        uiPanel2.Text = Info
    End Sub
    Sub AddUserControlToPanel(ByVal Panel As Panel, ByVal UI As UserControl)
        Panel.Controls.Clear()
        Panel.AutoScroll = True
        UI.Dock = DockStyle.Fill
        Panel.Controls.Add(UI)
    End Sub
    Private Sub PatientInfo_ItemClick(ByVal sender As System.Object, ByVal e As Janus.Windows.ButtonBar.ItemEventArgs) Handles PatientInfo.ItemClick
        Select Case e.Item.Key
            Case "PatienInfo"
                AddUserControl(Me.MainContainer, PatientInformation, "Patient Information")
            Case "PatientWaitingConsult"
                AddUserControl(Me.MainContainer, WaitingConsulting, "List of patient waiting consult.")
            Case "IssuePatientReceipt"
                AddUserControl(Me.MainContainer, IssueReceipt, "Issue patient receipt.")
            Case "DoctorConsultation"
                Dim DA_Consultation As New DSPAtientTableAdapters.ConsultationsTableAdapter
                DoctorConsultation.GridWaitingConsultation.DataSource = DA_Consultation.GetConsultationList
                AddUserControl(Me.MainContainer, DoctorConsultation, "Consultation")
            Case "PatientReport"
                AddUserControl(Me.MainContainer, PatientMedicalReport, "Patient Medical Reports.")
            Case "Appointment"
                AddUserControl(Me.MainContainer, DoctorFeeConsult, "Doctor Fee")
            Case "AccountManagement"
                AddUserControl(Me.MainContainer, AccountManagemt, "Account Management")
            Case "MedicinceReceived"
                AddUserControl(Me.MainContainer, MedicinceReceived, "Medical Received Management")
            Case "PatientReferTo"
                AddUserControl(Me.MainContainer, PatientReferTo, "Patient send to other place.")
            Case "Dr.Request"
                AddUserControl(Me.MainContainer, DrRequestExam, "List of patient Dr.Request for examination")
            Case "DiagnosisAnalysis"
                AddUserControl(Me.MainContainer, ClinicAnalysis, "Clinic Diagnosis Analysis")
        End Select
    End Sub

    Private Sub Parameter_ItemClick(ByVal sender As System.Object, ByVal e As Janus.Windows.ButtonBar.ItemEventArgs) Handles Parameter.ItemClick
        Dim ServiceType As New ServiceTypes
        Dim Service As New Service
        Select Case e.Item.Key
            Case "ClinicParameter"
                AddUserControl(Me.MainContainer, ParameterList, "Clinic parameter list.")
                ParameterList.LoadAllPararmeter()
                'Case "ConsultType"
                '    AddUserControl(Me.MainContainer, ClinicConsultation, "Consultation Type")
                'Case "Patient Complaint"
                '    AddUserControl(Me.MainContainer, PatientComplaint, "Patient Complaint")
                'Case "Medical History"
                '    AddUserControl(Me.MainContainer, MedicalHistory, "Medical History")
                'Case "Physical Examination"
                '    AddUserControl(Me.MainContainer, PhysicalExam, "Physical Examination")
                'Case "Para Clinic Examination"
                '    AddUserControl(Me.MainContainer, ParaCheck, "Para Clinic Examination")
                'Case "Para Clinic Examination"
                '    AddUserControl(Me.MainContainer, PhysicalExam, "Physical Examination")
                'Case "Doctor"
                '    AddUserControl(Me.MainContainer, DoctorInformation, "Doctor")
                'Case "Symptom"
                '    AddUserControl(Me.MainContainer, SymptomInformation, "Symptom")
                'Case "Service Type"
                '    AddUserControl(Me.MainContainer, ServiceType, "Service Type")
                'Case "Service"
                '    AddUserControl(Me.MainContainer, Service, "Service")
        End Select
    End Sub

    Dim PMedicine As New UCMedicine
    Dim PMedicineCategory As New MedicineCategory
    Dim UCInventory As New UCStock
    Dim UCStoreManagement As New StoreManagement
    Dim UCStoreTransaction As New UCStock
    Dim UCReport As New UCStoreReport
    Dim UCBarcode As New UIBarcodeGenerator
    Private Sub Inventory_ItemClick(ByVal sender As System.Object, ByVal e As Janus.Windows.ButtonBar.ItemEventArgs) Handles Inventory.ItemClick
      
        Select Case e.Item.Key
            Case "Medicine"
                AddUserControl(Me.MainContainer, PMedicine, "Medicine")
            Case "StoreManagement"
                AddUserControl(Me.MainContainer, UCStoreManagement, "Store Management")
            Case "StoreTransaction"
                AddUserControl(Me.MainContainer, UCStoreTransaction, "Store Transactions")
            Case "StoreReport"
                AddUserControl(Me.MainContainer, UCReport, "Store Reports")
            Case "Barcode"
                AddUserControl(Me.MainContainer, UCBarcode, "Barcode")
        End Select
    End Sub

    Private Sub ButtonCommand1_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles ButtonCommand1.Click
        If MessageBox.Show("Do you want to close the application?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub


    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AddUserControl(Me.MainContainer, PatientInformation, "Patient Information")
        MainApplicationForm = Me
        LblUserLogIn.Text = SHOW_NAME
    End Sub

    Private Sub ButonUserManage_ItemClick(ByVal sender As System.Object, ByVal e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButonUserManage.ItemClick
        Select Case e.Item.Key
            Case "User Management"
                AddUserControl(Me.MainContainer, UserManager, "User Managerment.")
                UserManager.InitDepartment()
        End Select
        'Case "PatienInfo"

    End Sub

    Private Sub BtnLogout_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnLogout.Click
        CreateSwitchUser()
    End Sub
    Sub CreateSwitchUser()
        Login.txtUserName.Text = ""
        Login.txtPassword.Text = ""
        Login.txtUserName.Select()
        Login.txtUserName.Focus()
        Login.Cursor = Cursors.Default
        Login.Show()
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub CheckPermistionOnForm()
        Dim TblMenuPermistion As DataTable = DA_USER_PERMISION.GetDataByGetMenuPermissionUserName(USER_NAME)
        Dim indexBar As Integer
        Dim indexSubBar As Integer
        Dim indexMenu As Integer
        ' Check Permistion in Tab patient Information....
        For indexBar = 0 To PatientInfo.Groups.Count - 1
            For indexSubBar = 0 To PatientInfo.Groups(indexBar).Items.Count - 1
                For indexMenu = 0 To TblMenuPermistion.Rows.Count - 1
                    Application.DoEvents()
                    'MsgBox(BottonBarMain.Groups(indexBar).Items(indexSubBar).Key & "    " & tblPermistion.Rows(indexMenu).Item(0))                    
                    If PatientInfo.Groups(indexBar).Items(indexSubBar).Key = TblMenuPermistion.Rows(indexMenu).Item("MenuKey") Then
                        'Login.UpdateLabelStatus("Checking menu name " & BottonBarMain.Groups(indexBar).Items(indexSubBar).Text, True)
                        'Application.DoEvents()
                        PatientInfo.Groups(indexBar).Items(indexSubBar).Enabled = Janus.Windows.UI.InheritableBoolean.True
                    End If
                Next
            Next
        Next



        ' Check Permision in  tab patient consultation ...............
        For indexBar = 0 To Parameter.Groups.Count - 1
            For indexSubBar = 0 To Parameter.Groups(indexBar).Items.Count - 1
                For indexMenu = 0 To TblMenuPermistion.Rows.Count - 1
                    Application.DoEvents()
                    'MsgBox(BottonBarMain.Groups(indexBar).Items(indexSubBar).Key & "    " & tblPermistion.Rows(indexMenu).Item(0))                    
                    If Parameter.Groups(indexBar).Items(indexSubBar).Key = TblMenuPermistion.Rows(indexMenu).Item("MenuKey") Then
                        'Login.UpdateLabelStatus("Checking menu name " & BottonBarMain.Groups(indexBar).Items(indexSubBar).Text, True)
                        'Application.DoEvents()
                        Parameter.Groups(indexBar).Items(indexSubBar).Enabled = Janus.Windows.UI.InheritableBoolean.True
                    End If
                Next
            Next
        Next

        'Check Permision in  tab patient System ...............
        For indexBar = 0 To ButonUserManage.Groups.Count - 1
            For indexSubBar = 0 To ButonUserManage.Groups(indexBar).Items.Count - 1
                For indexMenu = 0 To TblMenuPermistion.Rows.Count - 1
                    Application.DoEvents()
                    'MsgBox(BottonBarMain.Groups(indexBar).Items(indexSubBar).Key & "    " & tblPermistion.Rows(indexMenu).Item(0))                    
                    If ButonUserManage.Groups(indexBar).Items(indexSubBar).Key = TblMenuPermistion.Rows(indexMenu).Item("MenuKey") Then
                        'Login.UpdateLabelStatus("Checking menu name " & BottonBarMain.Groups(indexBar).Items(indexSubBar).Text, True)
                        'Application.DoEvents()
                        ButonUserManage.Groups(indexBar).Items(indexSubBar).Enabled = Janus.Windows.UI.InheritableBoolean.True
                    End If
                Next
            Next
        Next

        'check Permision in tab Inventory
        For indexBar = 0 To Inventory.Groups.Count - 1
            For indexSubBar = 0 To Inventory.Groups(indexBar).Items.Count - 1
                For indexMenu = 0 To TblMenuPermistion.Rows.Count - 1
                    Application.DoEvents()
                    'MsgBox(BottonBarMain.Groups(indexBar).Items(indexSubBar).Key & "    " & tblPermistion.Rows(indexMenu).Item(0))                    
                    If Inventory.Groups(indexBar).Items(indexSubBar).Key = TblMenuPermistion.Rows(indexMenu).Item("MenuKey") Then
                        'Login.UpdateLabelStatus("Checking menu name " & BottonBarMain.Groups(indexBar).Items(indexSubBar).Text, True)
                        'Application.DoEvents()
                        Inventory.Groups(indexBar).Items(indexSubBar).Enabled = Janus.Windows.UI.InheritableBoolean.True
                    End If
                Next
            Next
        Next
    End Sub

    Private Sub BtnChangeUserPWD_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnChangeUserPWD.Click
      
        Dim FChangePwd As New FrmChangeUserPWD
        FChangePwd.LblUserID.Text = USER_ID
        FChangePwd.TxtUserName.Text = USER_NAME
        FChangePwd.ShowDialog()

    End Sub

    Private Sub main_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F4 Then
            IssueReceipt.FireButtonEventIssueReceipt()
        End If
        If e.KeyCode = Keys.F5 Then
            IssueReceipt.FireButtonEventRefresh()
        End If
        If e.KeyCode = Keys.F1 Then
            If PatientInfo.Groups(0).Items(4).Enabled = False Then
            Else
                AddUserControl(Me.MainContainer, IssueReceipt, "Issue patient receipt.")
            End If

        End If
        If e.KeyCode = Keys.F2 Then
            IssueReceipt.FireButtonEventMedicince()
        End If
        If e.KeyCode = Keys.F3 Then
            IssueReceipt.FireButtonEventExam()
        End If
    End Sub
End Class
