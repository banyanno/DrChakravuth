Public Class NewUreaBreath
    Dim DA_Patient As New DSPAtientTableAdapters.tblpatientTableAdapter
    Dim DA_Doctor As New DSPAtientTableAdapters.DoctorsTableAdapter
    Dim DA_BreathTest As New DSExaminationTableAdapters.TblBreathTestTableAdapter

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.cbodoctor.DataSource = DA_Doctor.SelectDoctor
        Me.cbodoctor.ValueMember = DA_Doctor.SelectDoctor.Columns("Doctor_ID").ColumnName
        Me.cbodoctor.DisplayMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        Me.cbodoctor.SelectedIndex = -1
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnFindPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFindPatient.Click
        LoadPatientInfo(CInt(EmptyString(txtno.Text)))
    End Sub
    Sub LoadPatientInfo(ByVal patientID As Integer)
        Dim TblPatient As New DataTable
        TblPatient = DA_Patient.SelectPatientByID(patientID)
        If TblPatient.Rows.Count < 1 Then
            MsgBox("Patient record was not found", MsgBoxStyle.Information, "No Record Found")
            Exit Sub
        Else
            Me.lblpatientid.Text = TblPatient.Rows(0).Item("ppatientid")
            Me.txtname.Text = TblPatient.Rows(0).Item("pname")
            Me.txtsex.Text = TblPatient.Rows(0).Item("pgender")
            Me.txtaddress.Text = TblPatient.Rows(0).Item("pcontactaddress")
            Me.txtno.Text = TblPatient.Rows(0).Item("patientid")
            Me.txtdatebirth.Text = TblPatient.Rows(0).Item("pAge")
        End If

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(txtno, "", ErrBreathTest) = False Then Exit Sub
        If ValidateTextField(txtname, "", ErrBreathTest) = False Then Exit Sub
        If ValidateDateField(DateRequest, "", ErrBreathTest) = False Then Exit Sub

        If ValidateCombobox(cbodoctor, "", ErrBreathTest) = False Then Exit Sub
        If ValidateCombobox(CboConclusion, "", ErrBreathTest) = False Then Exit Sub
        If LblSaveOption.Text <> 0 Then
            If MessageBox.Show("Do you want to save result breath test?", "Breath Test", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_BreathTest.UpdateBreath(LblRequestNo.Text, txtno.Text, txtname.Text, txtsex.Text, txtdatebirth.Text, txtaddress.Text, TxtIndication.Text, TxtResult.Text, CboConclusion.Text, TxtMoreInfo.Text, DateRequest.Value.Date, cbodoctor.Text) Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class