Public Class PatientInformation
    Dim MainForm As main
    Dim IsAdding As Boolean = False
    Dim IsUpdating As Boolean = False
    Dim DA_Patient As New DSPAtientTableAdapters.tblpatientTableAdapter
    ' Complaint Data.........................
    Dim DA_Complaint As New DSComplaintTableAdapters.tblcomplaintTableAdapter
    Dim DA_V_ComplaintDetail As New DSComplaintTableAdapters.V_PATIENT_COMPLAINTTableAdapter
    ' -------------------------- Medical History -------------------------------------
    Dim DA_Medical As New DSMedicalHistoryTableAdapters.tblhistoryTableAdapter
    Dim DA_V_MedicalHisDetail As New DSMedicalHistoryTableAdapters.V_MEDICAL_HISTORYTableAdapter
    Dim ListOfPatientTem As DataTable
    Dim DA_Province As New DSPAtientTableAdapters.tblProvincesTableAdapter


    Sub New(ByVal MainForm As main)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MainForm = MainForm
        With txtaddress
            .DataSource = DA_Province.GetData
            .ValueMember = "IDProvCode"
            .DisplayMember = "Province"
            .SelectedIndex = -1
        End With
        With CboAddress
            .DataSource = DA_Province.GetData
            .ValueMember = "IDProvCode"
            .DisplayMember = "Province"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.
        'With CboComplaint
        '    .DataSource = DA_Complaint.GetData
        '    .ValueMember = DA_Complaint.GetData.Columns("complaintid").ColumnName
        '    .DisplayMember = DA_Complaint.GetData.Columns("complaint").ColumnName
        '    .SelectedIndex = -1
        'End With
        'With CboMedical
        '    .DataSource = DA_Medical.GetData
        '    .ValueMember = DA_Medical.GetData.Columns("Historyid").ColumnName
        '    .DisplayMember = DA_Medical.GetData.Columns("history").ColumnName
        '    .SelectedIndex = -1
        'End With
    End Sub

    Private Sub PatientInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetButtonStatus(True, False, False, False, False, True)
        Me.btnAdd.Visible = True
        ''Set Box Status
        DisableBox(True)
    End Sub
    Private Sub LoadDataToDatagrid()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadDataToDatagrid))
        Else
            GridPatientInfo.DataSource = DA_Patient.GetData
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ''Disable Patient List
        GridPatientInfo.Enabled = False
        ''Set Button Status
        SetButtonStatus(False, False, False, True, True, False)
        ClearBox()
        ''Set Box Status
        DisableBox(False)
        ''Set Action Status
        IsAdding = True
        IsUpdating = False
        Me.txtid.Text = (DA_Patient.SelectMaxNo + 1)
        Me.txtname.Focus()
    End Sub
    Private Sub SetButtonStatus(ByVal AddButton As Boolean, ByVal DeleteButton As Boolean, ByVal UpdateButton As Boolean, ByVal SaveButton As Boolean, ByVal CancelButton As Boolean, ByVal SearchButton As Boolean)
        Me.btnAdd.Enabled = AddButton
        Me.btnDelete.Enabled = DeleteButton
        Me.btnUpdate.Enabled = UpdateButton
        Me.btnSave.Enabled = SaveButton
        Me.btnCancel.Enabled = CancelButton
    End Sub

    Private Sub ValidateForm()

    End Sub
    Private Sub ClearBox()
        Me.txtname.Text = ""
        Me.txtsex.Text = ""
        Me.txtphone.Text = ""
        Me.txtaddress.Text = ""
        Me.txtid.Text = ""
        TxtAge.Text = ""
        dtbirth.Value = Now
    End Sub
    Private Sub DisableBox(ByVal IsDisabled As Boolean)
        If IsDisabled = True Then
            Me.txtname.ReadOnly = True
            Me.txtphone.ReadOnly = True
            TxtAge.ReadOnly = True
            Me.txtaddress.Enabled = False
            txtsex.Enabled = False
            dtbirth.Enabled = False

            Me.txtname.BackColor = Color.White
            Me.txtid.BackColor = Color.White
            Me.txtphone.BackColor = Color.White
            Me.txtaddress.BackColor = Color.White
            TxtAge.BackColor = Color.White
        Else
            Me.txtname.ReadOnly = False
            Me.txtphone.ReadOnly = False
            Me.txtaddress.Enabled = True
            TxtAge.ReadOnly = False
            dtbirth.Enabled = True
            txtsex.Enabled = True

        End If

    End Sub
    Private Sub linkNewStomach_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        NewStomachConsultation.txtPatientID.Text = GridPatientInfo.GetRow.Cells("Patient_ID").Value
        NewStomachConsultation.ShowDialog()
    End Sub

    Private Sub LinkNewLiver_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        NewLiverConsultation.txtPatientID.Text = GridPatientInfo.GetRow.Cells("Patient_ID").Value
        NewLiverConsultation.ShowDialog()
    End Sub



    Sub FindPatient(ByVal Value As Object, ByVal FindType As Integer)
        If FindType = 1 Then
            'Find By Patient Number
            GridPatientInfo.DataSource = DA_Patient.SelectPatientByID(EmptyString(Value))
        ElseIf FindType = 2 Then
            'Find By Name
            GridPatientInfo.DataSource = DA_Patient.SelectPatientByName("%" & Value & "%")
        ElseIf FindType = 3 Then
            'Find By Phone
            GridPatientInfo.DataSource = DA_Patient.SelectPatientByPhone("%" & Value & "%")
        ElseIf FindType = 4 Then
            GridPatientInfo.DataSource = DA_Patient.SelectPatientByAddress("%" & Value & "%")
        End If
    End Sub


    Private Sub GridPatientInfo_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridPatientInfo.SelectionChanged
        Try
            ''Set Button Status
            SetButtonStatus(True, True, True, False, False, False)
            ''Set Box Status
            DisableBox(True)
            Me.txtaddress.Text = GridPatientInfo.GetRow.Cells("pcontactaddress").Value.ToString
            Me.txtphone.Text = GridPatientInfo.GetRow.Cells("pphoneno").Value.ToString.Trim
            Me.dtbirth.Value = GridPatientInfo.GetRow.Cells("pAge").Value
            Me.txtid.Text = GridPatientInfo.GetRow.Cells("patientid").Value.ToString
            Me.txtname.Text = GridPatientInfo.GetRow.Cells("pname").Value.ToString
            Me.txtsex.Text = GridPatientInfo.GetRow.Cells("pgender").Value
            If TypeOf GridPatientInfo.CurrentRow.Cells("Age").Value Is DBNull Then
                Me.TxtAge.Text = ""
            Else
                Me.TxtAge.Text = GridPatientInfo.CurrentRow.Cells("Age").Value
            End If

        Catch ex As Exception

        End Try

    End Sub
    Sub RefreshHistory()
        '  Me.HistoryList.DataSource = DA_Medical.get .SelectHistoryByPatientID(CInt(GridPatientInfo.CurrentRow.Cells("ppatientid").Value))
    End Sub


    Private Sub BgLoadingPatient_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadingPatient.DoWork
        LoadDataToDatagrid()
    End Sub

    Private Sub BgLoadingPatient_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadingPatient.RunWorkerCompleted
        Application.DoEvents()
        MainApplicationForm.StatusLoading(False)
    End Sub







    Private Sub btnPrescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrescription.Click
        If Me.GridPatientInfo.SelectedItems.Count = 0 Then Exit Sub
        Try
            Dim FrmHistory As New PrescriptionHistory(Me)
            FrmHistory.lblpatientId.Text = Me.GridPatientInfo.CurrentRow.Cells("ppatientid").Value
            FrmHistory.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHistory.Click
        If Me.GridPatientInfo.SelectedItems.Count = 0 Then Exit Sub
        Try
            Dim AppForm As New NewAppointment
            AppForm.txtno.Text = GridPatientInfo.CurrentRow.Cells("patientid").Value
            AppForm.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub


    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        ''Set Button Status
        SetButtonStatus(False, False, False, True, True, False)
        ''Enable Box
        DisableBox(False)
        Me.txtname.SelectAll()

        ''Set Action Status
        IsAdding = False
        IsUpdating = True
        ''Disable Patient List
        GridPatientInfo.Enabled = False
        Me.txtname.Focus()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure you want to delete this patient record?", MsgBoxStyle.YesNo, "Confirm Delete") = MsgBoxResult.Yes Then
            'DA_Patient.DeletePatient(GridPatientInfo.CurrentRow.Cells("ppatientid").Value)
            DA_Patient.DeleteV1(False, GridPatientInfo.GetRow.Cells("ppatientid").Value)
            ''Clear Box
            ClearBox()
            ''Reload Data to Datagrid and Enable It
            LoadDataToDatagrid()
            ''Set Button Status
            SetButtonStatus(True, False, False, False, False, True)
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ''Validate Form
        If ValidateTextField(txtid, "", ErrValidate) = False Then Exit Sub
        If ValidateTextField(txtname, "", ErrValidate) = False Then Exit Sub
        If ValidateDateTimePicker(dtbirth, "", ErrValidate) = False Then Exit Sub
        If ValidateCombobox(txtsex, "", ErrValidate) = False Then Exit Sub
        If ValidateTextField(TxtAge, "", ErrValidate) = False Then Exit Sub
        If ValidateCombobox(txtaddress, "", ErrValidate) = False Then Exit Sub
        If ValidateTextField(txtphone, "", ErrValidate) = False Then Exit Sub
        Dim tbl As DataTable = DA_Patient.SelectPatientByID(txtid.Text)
       
        If IsNumeric(txtid.Text) = False Then
            MsgBox("Patient ID must be number only")
            Me.txtid.SelectAll()
            Me.txtid.Focus()
            Exit Sub
        End If
        ''Commit Action
        If IsAdding = True Then
            If tbl.Rows.Count > 0 Then
                Me.txtid.Text = (DA_Patient.SelectMaxNo + 1)
            End If
            DA_Patient.InsertPatient(Me.txtname.Text.Trim.Replace("'", "''").ToString, Me.txtsex.SelectedItem, Me.dtbirth.Value, Me.txtaddress.Text, Trim(Me.txtphone.Text), True, Me.txtid.Text, EmptyString(TxtAge.Text))
            MsgBox("One patient record was added", MsgBoxStyle.Information, "Successfully Added")
            GridPatientInfo.DataSource = DA_Patient.SelectPatientByID(txtid.Text)
            BtnSendPatientWaiting_Click(sender, e)
            ClearBox()
            IsAdding = False
            GridPatientInfo.Enabled = True


        ElseIf IsUpdating = True Then
            If MsgBox("Are you sure you want to update this patient record", MsgBoxStyle.YesNo, "Confirm Update") = MsgBoxResult.Yes Then
                DA_Patient.UpdatePatient(Me.txtname.Text.Trim.Replace("'", "''").ToString, Me.txtsex.SelectedItem, Me.dtbirth.Value, Me.txtaddress.Text, Trim(Me.txtphone.Text.ToString.Trim), True, Me.txtid.Text, EmptyString(TxtAge.Text), GridPatientInfo.CurrentRow.Cells("ppatientid").Value)
                MsgBox("One patient record was updated", MsgBoxStyle.Information, "Successfully Updated")
                IsAdding = False
                GridPatientInfo.Enabled = True
                FindPatient(EmptyString(txtid.Text), 1)


                IsAdding = False
                GridPatientInfo.Enabled = True
                'LoadDataToDatagrid()
                'ClearBox()
            End If
        End If
        SetButtonStatus(True, False, False, False, False, True)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ''Set Button Status 
        SetButtonStatus(True, False, False, False, False, True)
        ''Clear Box Data
        ClearBox()
        ''Set Box Status
        DisableBox(True)
        ''Enable Patient List
        GridPatientInfo.Enabled = True
        Me.txtname.Focus()
    End Sub

    Private Sub BtnSendPatientWaiting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSendPatientWaiting.Click
        If ValidateTextField(TxtAge, "", ErrValidate) = False Then Exit Sub
        If GridPatientInfo.SelectedItems.Count = 0 Then Exit Sub
        Dim PatientWatienting As New FNewPatientWaitingConsuling(Me)
        If PatientWatienting.ShowDialog() = DialogResult.OK Then
            GridPatientInfo.DataSource = Nothing
        End If
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FFindPatient As New FindPatient(Me)
        FFindPatient.ShowDialog()
    End Sub

    Private Sub ShowAllPatientInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MainApplicationForm.StatusLoading(True)
        Application.DoEvents()
        BgLoadingPatient.RunWorkerAsync()
    End Sub

    Private Sub BtnPatientReferal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPatientReferal.Click
        If GridPatientInfo.SelectedItems.Count = 0 Then
            Exit Sub
        Else
            Dim FNewRefer As New NewReferTo
            FNewRefer.LblPatientNo.Text = GridPatientInfo.GetRow.Cells("ppatientid").Value
            FNewRefer.txtno.Text = GridPatientInfo.GetRow.Cells("patientid").Value
            FNewRefer.txtname.Text = GridPatientInfo.GetRow.Cells("pname").Value
            FNewRefer.txtsex.Text = GridPatientInfo.GetRow.Cells("pgender").Value
            FNewRefer.txtdatebirth.Text = GridPatientInfo.GetRow.Cells("pAge").Value
            FNewRefer.txtaddress.Text = GridPatientInfo.GetRow.Cells("pcontactaddress").Value
            If FNewRefer.ShowDialog = DialogResult.OK Then

            End If
        End If

    End Sub



    Private Sub BtnNewMedicalHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If GridPatientInfo.RowCount >= 1 Then
            Dim FrmHistory As New FormMedicineHistory(Me)
            FrmHistory.lblaction.Text = 0
            FrmHistory.ShowDialog()
        End If

    End Sub

    Private Sub CmdNewHistory_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs)
        If GridPatientInfo.RowCount >= 1 Then
            Dim FrmHistory As New FormMedicineHistory(Me)
            FrmHistory.lblaction.Text = 0
            FrmHistory.ShowDialog()
        End If
    End Sub

    Private Sub CmdEditHistory_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs)
        If GridPatientInfo.RowCount >= 1 Then
            Dim TblHistory As New DataTable
            'TblHistory = DA_MedicineHistory.SelectHistoryByID(CLng(Me.HistoryList.CurrentRow.Cells("history_id").Value))
            Dim FrmHistory As New FormMedicineHistory(Me)
            FrmHistory.lblaction.Text = 1
            FrmHistory.cbomedicine.SelectedValue = TblHistory.Rows(0).Item("medicineid")
            FrmHistory.txtdesc.Text = TblHistory.Rows(0).Item("more_detail")
            FrmHistory.ShowDialog()
        End If
    End Sub

   

    Private Sub BtnComplain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        If GridPatientInfo.SelectedItems.Count = 0 Then Exit Sub
        Dim FormSymptom As New Patient_Symptom(Me)
        FormSymptom.txtPatientID.Text = GridPatientInfo.GetRow.Cells("ppatientid").Value
        FormSymptom.ShowDialog()
        'Catch ex As Exception
        '    MessageBox.Show("Please select patient first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    

   

    Private Sub btnPatientSendIssueReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPatientSendIssueReceipt.Click
        If Me.GridPatientInfo.SelectedItems.Count > 0 Then
            If MessageBox.Show("Do want to send patient to Issue Receipt?", "Issure Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim DA_PreInvoice As New DSInvoiceTableAdapters.tbl_preinvoiceTableAdapter
                DA_PreInvoice.InsertInvoice(CLng(GridPatientInfo.GetRow.Cells("patientid").Value), USER_ID, USER_NAME)
                MsgBox("One patient was sent to the list of current receipts already", MsgBoxStyle.Information, "Send to Receipt List")
            End If
        Else
            MsgBox("No patient was selected", MsgBoxStyle.Exclamation, "No Patient")
        End If
    End Sub

    Private Sub TxtAge_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAge.KeyPress
        SetDisableKeyString(e)
       

    End Sub
    Private Sub SubDate(ByVal valSub As Integer)
        dtbirth.Value = Now
        dtbirth.Value = dtbirth.Value.AddYears(-valSub)
    End Sub

    Private Sub TxtAge_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAge.KeyUp
        Try
            If e.KeyCode = Keys.Enter Then
            Else
                SubDate(TxtAge.Text)
            End If

        Catch ex As Exception
            dtbirth.Value = Now
        End Try
    End Sub

    Private Sub dtbirth_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtbirth.KeyUp
        Try
            TxtAge.Text = (Now.Year - dtbirth.Value.Year)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtbirth_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtbirth.ValueChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If RadByPatientNo.Checked = True Then
            'If IsNumeric(Me.TxtByPatientNo.Text.ToString) = False Then
            '    MsgBox("Patient ID must be number only", MsgBoxStyle.Exclamation, "Invalid Data")
            '    Me.TxtByPatientNo.SelectAll()
            '    Me.TxtByPatientNo.Focus()
            '    Exit Sub
            'Else
            FindPatient(TxtByPatientNo.Text, 1)
            'End If

        ElseIf RadByPateintName.Checked = True Then
            FindPatient(TxtByPatientName.Text.ToUpper, 2)
        ElseIf RadByPhone.Checked = True Then
            FindPatient(TxtByPhone.Text, 3)
        ElseIf RadAddress.Checked = True Then
            FindPatient(CboAddress.Text.ToUpper, 4)
        End If
    End Sub

    Private Sub RadByPatientNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadByPatientNo.CheckedChanged
        CheckSercher()
    End Sub
    Private Sub CheckSercher()
        If RadByPatientNo.Checked = True Then
            TxtByPatientNo.Enabled = True

            TxtByPatientName.Enabled = False
            TxtByPhone.Enabled = False
            CboAddress.Enabled = False
            TxtByPatientNo.Text = ""
            TxtByPatientName.Text = ""
            TxtByPhone.Text = ""
            CboAddress.Text = ""
            TxtByPatientNo.Focus()
        ElseIf RadByPateintName.Checked = True Then
            TxtByPatientNo.Enabled = False
            TxtByPatientName.Enabled = True
            TxtByPhone.Enabled = False
            CboAddress.Enabled = False

            TxtByPatientNo.Text = ""
            TxtByPatientName.Text = ""
            TxtByPhone.Text = ""
            CboAddress.Text = ""
            TxtByPatientName.Focus()
        ElseIf RadByPhone.Checked = True Then
            TxtByPatientNo.Enabled = False
            TxtByPatientName.Enabled = False
            TxtByPhone.Enabled = True
            CboAddress.Enabled = False
            TxtByPatientNo.Text = ""
            TxtByPatientName.Text = ""
            TxtByPhone.Text = ""
            CboAddress.Text = ""
            TxtByPhone.Focus()
        ElseIf RadAddress.Checked = True Then
            TxtByPatientNo.Enabled = False
            TxtByPatientName.Enabled = False
            TxtByPhone.Enabled = False
            CboAddress.Enabled = True

            TxtByPatientNo.Text = ""
            TxtByPatientName.Text = ""
            TxtByPhone.Text = ""
            CboAddress.Text = ""
            CboAddress.Focus()
        End If
       
    End Sub

    Private Sub RadByPateintName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadByPateintName.CheckedChanged
        CheckSercher()
    End Sub

    Private Sub RadByPhone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadByPhone.CheckedChanged
        CheckSercher()
    End Sub

    Private Sub RadAddress_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadAddress.CheckedChanged
        CheckSercher()
    End Sub

    Private Sub TxtByPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtByPatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

  
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        MainApplicationForm.StatusLoading(True)
        Application.DoEvents()
        BgLoadingPatient.RunWorkerAsync()
    End Sub

   
   
    Private Sub txtphone_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtphone.KeyDown

        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True ' e.Handled = False
            Exit Sub
            '    MsgBox("")
            'Else
            '    e.Handled = True
        End If
    End Sub

    Private Sub txtphone_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtphone.KeyPress
       
    End Sub

    Private Sub TxtByPatientNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtByPatientNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button2_Click(sender, e)
        End If
    End Sub

    Private Sub TxtByPatientName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtByPatientName.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button2_Click(sender, e)
        End If
    End Sub

    Private Sub TxtByPhone_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtByPhone.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button2_Click(sender, e)
        End If
    End Sub

    Private Sub CboAddress_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboAddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button2_Click(sender, e)
        End If
    End Sub
End Class
