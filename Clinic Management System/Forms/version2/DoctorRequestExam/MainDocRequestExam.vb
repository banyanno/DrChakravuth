Public Class MainDocRequestExam
    Dim DA_Patient As New DSPAtientTableAdapters.tblpatientTableAdapter
    Dim DA_Doctor As New DSPAtientTableAdapters.DoctorsTableAdapter
    Dim DA_BloodItem As New DSPAtientTableAdapters.tblblooditemTableAdapter
    Dim DA_PreRequestBloodItem As New DSExaminationTableAdapters.tblprerequestblooditemTableAdapter
    Dim DA_RequestBloodItem As New DSExaminationTableAdapters.tblrequestblooditemTableAdapter
    Dim DA_Request As New DSExaminationTableAdapters.tblrequestTableAdapter
    Dim DA_Waiting As New DSPAtientTableAdapters.tblwaitingTableAdapter
    Dim DA_BreathTest As New DSExaminationTableAdapters.TblBreathTestTableAdapter
    Dim WaitingPanel As MainWaitingConsuling
    Dim RequestPanel As DashbordDotorRequestExamination

    Dim consultForm As NewConsultingForm
    Dim WaitingConsul As FNewPatientWaitingConsuling


    Dim DA_Diagnosis As New DSPAtientTableAdapters.tbldiagnosisTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.cbodoctor.DataSource = DA_Doctor.SelectDoctor
        Me.cbodoctor.ValueMember = DA_Doctor.SelectDoctor.Columns("Doctor_ID").ColumnName
        Me.cbodoctor.DisplayMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        Me.cbodoctor.SelectedIndex = -1

        Me.cboitem.DataSource = DA_BloodItem.SelectAllItems
        Me.cboitem.ValueMember = DA_BloodItem.SelectAllItems.Columns("item_id").ColumnName
        Me.cboitem.DisplayMember = DA_BloodItem.SelectAllItems.Columns("item_name").ColumnName
        cboitem.SelectedIndex = -1
        Me.CboDiagnosis.DataSource = DA_Diagnosis.SelectDiagnosis
        Me.CboDiagnosis.DisplayMember = DA_Diagnosis.SelectDiagnosis.Columns("diagnosis").ColumnName
        Me.CboDiagnosis.ValueMember = DA_Diagnosis.SelectDiagnosis.Columns("diagnosisid").ColumnName
        Me.CboDiagnosis.SelectedIndex = -1
    End Sub
    Sub New(ByVal PanelWaiting As MainWaitingConsuling)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.WaitingPanel = PanelWaiting
        ' Add any initialization after the InitializeComponent() call.
        LoadPatientInfo(CInt(Me.WaitingPanel.WaitingList.CurrentRow.Cells("patientid").Value))

        Me.cbodoctor.DataSource = DA_Doctor.SelectDoctor
        Me.cbodoctor.ValueMember = DA_Doctor.SelectDoctor.Columns("Doctor_ID").ColumnName
        Me.cbodoctor.DisplayMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        Me.cbodoctor.SelectedIndex = -1

        Me.cboitem.DataSource = DA_BloodItem.SelectAllItems
        Me.cboitem.ValueMember = DA_BloodItem.SelectAllItems.Columns("item_id").ColumnName
        Me.cboitem.DisplayMember = DA_BloodItem.SelectAllItems.Columns("item_name").ColumnName
        cboitem.SelectedIndex = -1

        Me.CboDiagnosis.DataSource = DA_Diagnosis.SelectDiagnosis
        Me.CboDiagnosis.DisplayMember = DA_Diagnosis.SelectDiagnosis.Columns("diagnosis").ColumnName
        Me.CboDiagnosis.ValueMember = DA_Diagnosis.SelectDiagnosis.Columns("diagnosisid").ColumnName
        Me.CboDiagnosis.SelectedIndex = -1
    End Sub
    Dim EditeConsult As EditConsultation
    Sub New(ByVal EditeConsult As EditConsultation)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.EditeConsult = EditeConsult
        ' Add any initialization after the InitializeComponent() call.
        LoadPatientInfo(CInt(EmptyString(EditeConsult.TxtPatientNo.Text)))

        Me.cbodoctor.DataSource = DA_Doctor.SelectDoctor
        Me.cbodoctor.ValueMember = DA_Doctor.SelectDoctor.Columns("Doctor_ID").ColumnName
        Me.cbodoctor.DisplayMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        Me.cbodoctor.SelectedIndex = -1

        Me.cboitem.DataSource = DA_BloodItem.SelectAllItems
        Me.cboitem.ValueMember = DA_BloodItem.SelectAllItems.Columns("item_id").ColumnName
        Me.cboitem.DisplayMember = DA_BloodItem.SelectAllItems.Columns("item_name").ColumnName
        cboitem.SelectedIndex = -1
        Me.CboDiagnosis.DataSource = DA_Diagnosis.SelectDiagnosis
        Me.CboDiagnosis.DisplayMember = DA_Diagnosis.SelectDiagnosis.Columns("diagnosis").ColumnName
        Me.CboDiagnosis.ValueMember = DA_Diagnosis.SelectDiagnosis.Columns("diagnosisid").ColumnName
        Me.CboDiagnosis.SelectedIndex = -1
    End Sub
    Sub New(ByVal consultForm As NewConsultingForm)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        LoadPatientInfo(CInt(EmptyString(consultForm.TxtPatientNo.Text)))
        ' Add any initialization after the InitializeComponent() call.
        Me.cbodoctor.DataSource = DA_Doctor.SelectDoctor
        Me.cbodoctor.ValueMember = DA_Doctor.SelectDoctor.Columns("Doctor_ID").ColumnName
        Me.cbodoctor.DisplayMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        Me.cbodoctor.SelectedIndex = -1

        Me.cboitem.DataSource = DA_BloodItem.SelectAllItems
        Me.cboitem.ValueMember = DA_BloodItem.SelectAllItems.Columns("item_id").ColumnName
        Me.cboitem.DisplayMember = DA_BloodItem.SelectAllItems.Columns("item_name").ColumnName
        cboitem.SelectedIndex = -1

        Me.CboDiagnosis.DataSource = DA_Diagnosis.SelectDiagnosis
        Me.CboDiagnosis.DisplayMember = DA_Diagnosis.SelectDiagnosis.Columns("diagnosis").ColumnName
        Me.CboDiagnosis.ValueMember = DA_Diagnosis.SelectDiagnosis.Columns("diagnosisid").ColumnName
        Me.CboDiagnosis.SelectedIndex = -1
    End Sub
    Sub New(ByVal WaitingConsul As FNewPatientWaitingConsuling)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.WaitingConsul = WaitingConsul
        ' Add any initialization after the InitializeComponent() call.
        LoadPatientInfo(CInt(EmptyString(WaitingConsul.TxtPatientNo.Text)))

        Me.cbodoctor.DataSource = DA_Doctor.SelectDoctor
        Me.cbodoctor.ValueMember = DA_Doctor.SelectDoctor.Columns("Doctor_ID").ColumnName
        Me.cbodoctor.DisplayMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        Me.cbodoctor.SelectedIndex = -1

        Me.cboitem.DataSource = DA_BloodItem.SelectAllItems
        Me.cboitem.ValueMember = DA_BloodItem.SelectAllItems.Columns("item_id").ColumnName
        Me.cboitem.DisplayMember = DA_BloodItem.SelectAllItems.Columns("item_name").ColumnName
        cboitem.SelectedIndex = -1

        Me.CboDiagnosis.DataSource = DA_Diagnosis.SelectDiagnosis
        Me.CboDiagnosis.DisplayMember = DA_Diagnosis.SelectDiagnosis.Columns("diagnosis").ColumnName
        Me.CboDiagnosis.ValueMember = DA_Diagnosis.SelectDiagnosis.Columns("diagnosisid").ColumnName
        Me.CboDiagnosis.SelectedIndex = -1
    End Sub
    Sub New(ByVal PanelRequest As DashbordDotorRequestExamination)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.RequestPanel = PanelRequest
        ' Add any initialization after the InitializeComponent() call.

        Me.cbodoctor.DataSource = DA_Doctor.SelectDoctor
        Me.cbodoctor.ValueMember = DA_Doctor.SelectDoctor.Columns("Doctor_ID").ColumnName
        Me.cbodoctor.DisplayMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        Me.cbodoctor.SelectedIndex = -1

        Me.cboitem.DataSource = DA_BloodItem.SelectAllItems
        Me.cboitem.ValueMember = DA_BloodItem.SelectAllItems.Columns("item_id").ColumnName
        Me.cboitem.DisplayMember = DA_BloodItem.SelectAllItems.Columns("item_name").ColumnName
        cboitem.SelectedIndex = -1
        Me.CboDiagnosis.DataSource = DA_Diagnosis.SelectDiagnosis
        Me.CboDiagnosis.DisplayMember = DA_Diagnosis.SelectDiagnosis.Columns("diagnosis").ColumnName
        Me.CboDiagnosis.ValueMember = DA_Diagnosis.SelectDiagnosis.Columns("diagnosisid").ColumnName
        Me.CboDiagnosis.SelectedIndex = -1

    End Sub
    Sub LoadPatientInfo(ByVal patientID As Integer)
        Dim TblPatient As New DataTable
        TblPatient = DA_Patient.SelectPatientByID(patientID)
        If TblPatient.Rows.Count < 1 Then
            MsgBox("Patient record was not found", MsgBoxStyle.Information, "No Record Found")
            Exit Sub
        Else
            Me.txtname.Text = TblPatient.Rows(0).Item("pname")
            Me.txtsex.Text = TblPatient.Rows(0).Item("pgender")
            Me.txtaddress.Text = TblPatient.Rows(0).Item("pcontactaddress")
            Me.TxtPatientNo.Text = TblPatient.Rows(0).Item("patientid")
            Me.LblPPatientIDAuto.Text = TblPatient.Rows(0).Item("ppatientid")
            Me.txtdatebirth.Text = TblPatient.Rows(0).Item("pAge")
        End If

    End Sub

    Sub RefreshPreCheckItem()
        Me.itemlist.DataSource = DA_PreRequestBloodItem.SelectItemByPatientID(CLng(Me.LblPPatientIDAuto.Text))
    End Sub
    Private Sub btnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click
        Try
            If Me.LblSaveOption.Text = 0 Then
                If DA_PreRequestBloodItem.SelectExisting(CLng(EmptyString(Me.TxtPatientNo.Text)), CInt(Me.cboitem.SelectedValue)).Rows.Count >= 1 Then
                    MsgBox("This check item has been added already", MsgBoxStyle.Exclamation, "Existing Check Item")
                Else
                    DA_PreRequestBloodItem.InsertItem(CLng(Me.LblPPatientIDAuto.Text), CInt(Me.cboitem.SelectedValue), TxtBloodResult.Text)
                    Me.RefreshPreCheckItem()
                    cboitem.SelectedIndex = -1
                    Me.TxtBloodResult.Text = ""
                End If
            Else
                If DA_RequestBloodItem.SelectItem(CLng(RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value), CInt(Me.cboitem.SelectedValue)).Rows.Count >= 1 Then
                    MsgBox("This check item has been added already", MsgBoxStyle.Exclamation, "Existing Check Item")
                Else
                    DA_RequestBloodItem.InsertRequestItem(CLng(RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value), CInt(Me.cboitem.SelectedValue), TxtBloodResult.Text)
                    Me.itemlist.DataSource = DA_RequestBloodItem.SelectCheckItemByRequestID(CLng(RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value))
                    cboitem.SelectedIndex = -1
                    Me.TxtBloodResult.Text = ""
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Please select patient No.", "Blood", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteItem.Click
        Try
            If Me.LblSaveOption.Text = 0 Then
                DA_PreRequestBloodItem.DeleteItem(CLng(Me.LblPPatientIDAuto.Text), CInt(Me.itemlist.CurrentRow.Cells("item_id").Value))
                Me.RefreshPreCheckItem()
            Else
                DA_RequestBloodItem.DeleteCheckItem(CLng(RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value), CInt(Me.itemlist.CurrentRow.Cells("item_id").Value))
                Me.itemlist.DataSource = DA_RequestBloodItem.SelectCheckItemByRequestID(CLng(RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value))
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub chkbilogy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbilogy.CheckedChanged
        If Me.chkbilogy.Checked = True Then
            Me.GBloodCheck.Enabled = True
        Else
            Me.GBloodCheck.Enabled = False
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If ValidateDateField(dtrequest, "", Err) = False Then Exit Sub
        If ValidateCombobox(cbodoctor, "", Err) = False Then Exit Sub
        If ValidateCombobox(CboDiagnosis, "", Err) = False Then Exit Sub
        If CheckRequestExam(GroupRequestExam) = False Then
            MessageBox.Show("Please select at least one exam. ", "Request", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GroupRequestExam.BackColor = Color.Khaki
            Exit Sub
        Else
            GroupRequestExam.BackColor = Color.Transparent
        End If
        If LblSaveOption.Text = "0" Then

            If chkfibro.Checked = True Then
                If DA_Request.CheckExistFibro(LblPPatientIDAuto.Text, dtrequest.Value.Date) > 0 Then
                    MessageBox.Show("You can not request Fibroscopy exam at the same day.", "Fibroscopy", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            If chknaso.Checked = True Then
                If DA_Request.CheckExistNaso(LblPPatientIDAuto.Text, dtrequest.Value.Date) > 0 Then

                    MessageBox.Show("You can not request Nasogastro exam at the same day.", "Nasogastro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            If chkcolo.Checked = True Then
                If DA_Request.CheckExistColo(LblPPatientIDAuto.Text, dtrequest.Value.Date) > 0 Then

                    MessageBox.Show("You can not request Coloscopy exam at the same day.", "Coloscopy", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            If chkecho.Checked = True Then
                If DA_Request.CheckExistEcho(LblPPatientIDAuto.Text, dtrequest.Value.Date) > 0 Then
                    MessageBox.Show("You can not request Echo exam at the same day.", "Echo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            If chkscan.Checked = True Then
                If DA_Request.CheckExistScan(LblPPatientIDAuto.Text, dtrequest.Value.Date) > 0 Then
                    MessageBox.Show("You can not request Scan  at the same day.", "Scan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If

            If chkmri.Checked = True Then
                If DA_Request.CheckExistMRI(LblPPatientIDAuto.Text, dtrequest.Value.Date) > 0 Then
                    MessageBox.Show("You can not request  M-R-I exam at the same day.", "M-R-I ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If

            If chkfibroscan.Checked = True Then
                If DA_Request.CheckExistFibroScan(LblPPatientIDAuto.Text, dtrequest.Value.Date) > 0 Then
                    MessageBox.Show("You can not request Fibro Scan exam at the same day.", "Fibro Scan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            If ChUreaBreathTest.Checked = True Then
                If DA_Request.CheckExistBreathTest(LblPPatientIDAuto.Text, dtrequest.Value.Date) > 0 Then
                    MessageBox.Show("You can not request Urea Breath test exam at the same day.", "Fibro Scan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub

                End If
            End If
            If MessageBox.Show("Do you want to save request Para exam?", "Para exam", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If Me.chkbilogy.Checked = False Then
                    ''Delete All PreCheckItem
                    DA_PreRequestBloodItem.DeleteItemByPatientID(CLng(Me.TxtPatientNo.Text))
                    'DA_Request.InsertRequest(CLng(Me.lblpatientid.Text), FormatDateTime(Me.dtrequest.Value, DateFormat.ShortDate), CInt(Me.cbodoctor.SelectedValue), Me.chkbilogy.Checked, Me.chkfibro.Checked, Me.chknaso.Checked, Me.chkcolo.Checked, Me.chkecho.Checked, Me.chkscan.Checked, Me.chkmri.Checked, Me.chkfibroscan.Checked, Me.txtmoreinfo.Text, 1, CboDiagnosis.Text)
                    DA_Request.InsertRequest(CLng(Me.LblPPatientIDAuto.Text), Me.dtrequest.Value, CInt(Me.cbodoctor.SelectedValue), Me.chkbilogy.Checked, Me.chkfibro.Checked, Me.chknaso.Checked, Me.chkcolo.Checked, Me.chkecho.Checked, Me.chkscan.Checked, Me.chkmri.Checked, Me.chkfibroscan.Checked, Me.txtmoreinfo.Text, 1, CboDiagnosis.Text, ChUreaBreathTest.Checked)
                    Dim MaxRequestID As Long = DA_Request.SelectMaxID
                    If ChUreaBreathTest.Checked = True Then
                        Dim strResult As String = "- S.1 :" & vbCrLf & "- S.2 :" & vbCrLf & "- /\(%..) :"
                        DA_BreathTest.InsertNewBreathTest(MaxRequestID, CLng(Me.TxtPatientNo.Text), txtname.Text, txtsex.Text, txtdatebirth.Text, txtaddress.Text, "", strResult, "", "", dtrequest.Value.Date, cbodoctor.Text)
                    End If
                Else
                    ''INSERT Request
                    If itemlist.SelectedItems.Count = 0 Then
                        MessageBox.Show("Please add blood check!", "Blood", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    ''DA_Request.InsertRequest(CLng(Me.lblpatientid.Text), FormatDateTime(Me.dtrequest.Value, DateFormat.ShortDate), CInt(Me.cbodoctor.SelectedValue), Me.chkbilogy.Checked, Me.chkfibro.Checked, Me.chknaso.Checked, Me.chkcolo.Checked, Me.chkecho.Checked, Me.chkscan.Checked, Me.chkmri.Checked, Me.chkfibroscan.Checked, Me.txtmoreinfo.Text, 1, CboDiagnosis.Text)
                    DA_Request.InsertRequest(CLng(Me.LblPPatientIDAuto.Text), Me.dtrequest.Value.Date, CInt(Me.cbodoctor.SelectedValue), Me.chkbilogy.Checked, Me.chkfibro.Checked, Me.chknaso.Checked, Me.chkcolo.Checked, Me.chkecho.Checked, Me.chkscan.Checked, Me.chkmri.Checked, Me.chkfibroscan.Checked, Me.txtmoreinfo.Text, 1, CboDiagnosis.Text, ChUreaBreathTest.Checked)

                    ''INSERT CheckItem INTO TABLE RequestCheckItem
                    Dim MaxRequestID As Long = DA_Request.SelectMaxID
                    Dim CheckTable As New DataTable
                    CheckTable = DA_PreRequestBloodItem.SelectItemByPatientID(CLng(Me.LblPPatientIDAuto.Text))
                    For i = 0 To CheckTable.Rows.Count - 1
                        DA_RequestBloodItem.InsertRequestItem(MaxRequestID, CheckTable.Rows(i).Item("item_id"), CheckTable.Rows(i).Item("Result"))
                    Next
                    DA_PreRequestBloodItem.DeleteItemByPatientID(CLng(Me.LblPPatientIDAuto.Text))
                    If ChUreaBreathTest.Checked = True Then
                        Dim strResult As String = "- S.1 :" & vbCrLf & "- S.2 :" & vbCrLf & "- /\(%..) :"
                        DA_BreathTest.InsertNewBreathTest(MaxRequestID, CLng(Me.TxtPatientNo.Text), txtname.Text, txtsex.Text, txtdatebirth.Text, txtaddress.Text, "", strResult, "", "", dtrequest.Value.Date, cbodoctor.Text)
                    End If
                End If
                MsgBox("The request has been saved", MsgBoxStyle.Information, "Saved Request")
                If BtnFindPatient.Visible = True Then
                    Try
                        RequestPanel.gridRequestList.DataSource = DA_Request.SelectStatus(1)
                    Catch ex As Exception

                    End Try

                End If
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        Else
            If MessageBox.Show("Do you want to update request Para exam?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Request.UpdateMainRequest(dtrequest.Value.Date, CInt(cbodoctor.SelectedValue), Me.chkbilogy.Checked, Me.chkfibro.Checked, Me.chknaso.Checked, Me.chkcolo.Checked, Me.chkecho.Checked, Me.chkscan.Checked, Me.chkmri.Checked, Me.chkfibroscan.Checked, CboDiagnosis.Text, ChUreaBreathTest.Checked, LblSaveOption.Text) = 1 Then
                    If ChUreaBreathTest.Checked = True Then
                        If DA_BreathTest.CheckExistBreathTest(LblSaveOption.Text, TxtPatientNo.Text) = 0 Then
                            Dim strResult As String = "- S.1 :" & vbCrLf & "- S.2 :" & vbCrLf & "- /\(%..) :"
                            DA_BreathTest.InsertNewBreathTest(LblSaveOption.Text, CLng(Me.TxtPatientNo.Text), txtname.Text, txtsex.Text, txtdatebirth.Text, txtaddress.Text, "", strResult, "", "", dtrequest.Value.Date, cbodoctor.Text)
                        End If
                    End If

                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            End If
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            DA_PreRequestBloodItem.DeleteItemByPatientID(CLng(Me.LblPPatientIDAuto.Text))

        Catch ex As Exception

        End Try
        Me.Close()
    End Sub

    Public Sub BtnFindPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFindPatient.Click
        LoadPatientInfo(CInt(EmptyString(TxtPatientNo.Text)))
    End Sub

    Private Sub txtno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Function CheckRequestExam(ByVal GB As GroupBox) As Boolean
        For Each obj As Object In GB.Controls
            If TypeOf obj Is CheckBox Then
                Dim rd As CheckBox = CType(obj, CheckBox)
                If rd.Checked = True Then
                    Return True
                    Exit For
                End If
            End If
        Next
    End Function

  
    Private Sub MainDocRequestExam_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'Try
        '    DA_PreRequestBloodItem.DeleteItemByPatientID(CLng(Me.LblPPatientIDAuto.Text))

        'Catch ex As Exception

        'End Try
        'Me.Close()
    End Sub

    Private Sub MainDocRequestExam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class