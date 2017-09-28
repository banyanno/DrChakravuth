Public Class NewAppointment
    Dim DA_Appointment As New DSPAtientTableAdapters.AppointmentsTableAdapter
    Dim DA_Doctor As New DSPAtientTableAdapters.DoctorsTableAdapter
    Dim DA_Patient As New DSPAtientTableAdapters.tblpatientTableAdapter
    Dim App As Appointment
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.CboDoctor.DataSource = DA_Doctor.SelectDoctor
        Me.CboDoctor.ValueMember = DA_Doctor.SelectDoctor.Columns("Doctor_ID").ColumnName
        Me.CboDoctor.DisplayMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        CboDoctor.SelectedIndex = -1
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal AppPanel As Appointment)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.App = AppPanel
        Me.CboDoctor.DataSource = DA_Doctor.SelectDoctor
        Me.CboDoctor.ValueMember = DA_Doctor.SelectDoctor.Columns("Doctor_ID").ColumnName
        Me.CboDoctor.DisplayMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        CboDoctor.SelectedIndex = -1
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Dim PatientNo As String = Me.txtno.Text
        If (PatientNo = "" Or IsNumeric(PatientNo) = False) Then
            MsgBox("Please enter Patient ID as number only")
            Me.txtno.Text = ""
            Me.txtname.Text = ""
            Me.txtsex.Text = ""
            Me.txtdatebirth.Text = ""
            Me.txtaddress.Text = ""
        Else
            Dim PatientTable As DataTable = DA_Patient.SelectPatientByID(Me.txtno.Text)

            If (PatientTable.Rows.Count >= 1) Then
                'Me.txtno.Text = PatientTable.Rows(0).Item("patientid").ToString
                Me.txtname.Text = PatientTable.Rows(0).Item("pname").ToString
                Me.txtdatebirth.Text = Format(PatientTable.Rows(0).Item("pAge"), "dd/MM/yyyy")
                Me.txtsex.Text = PatientTable.Rows(0).Item("pgender").ToString
                Me.txtaddress.Text = PatientTable.Rows(0).Item("pcontactaddress").ToString
            Else
                MsgBox("Patient not found, please try again")
                Me.txtno.Text = ""
                Me.txtname.Text = ""
                Me.txtsex.Text = ""
                Me.txtdatebirth.Text = ""
                Me.txtaddress.Text = ""
            End If
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateTextField(txtno, "", Err) = False Then Exit Sub
        If ValidateDateTimePicker(DtAppointment, "", Err) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If DA_Appointment.InsertAppointment(Me.txtno.Text, Me.CboDoctor.SelectedValue, DtAppointment.Value.Date, Me.txtcomment.Text, 1) = 1 Then
                MsgBox("One appointment was added", MsgBoxStyle.Information, "Successfully Added")
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                If DA_Appointment.UpdateAppointment(txtno.Text, CboDoctor.SelectedValue, DtAppointment.Value.Date, txtcomment.Text, 1, LblSaveOption.Text) Then
                    MsgBox("One appointment was update", MsgBoxStyle.Information, "Successfully update")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub

    Private Sub NewAppointment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CboDoctor.DataSource = DA_Doctor.SelectDoctor
        Me.CboDoctor.ValueMember = DA_Doctor.SelectDoctor.Columns("Doctor_ID").ColumnName
        Me.CboDoctor.DisplayMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        CboDoctor.SelectedIndex = -1
        If Me.txtno.Text <> "" Then
            Dim PatientTable As New DataTable
            PatientTable = DA_Patient.SelectPatientByID(Me.txtno.Text)
            'Me.txtno.Text = PatientTable.Rows(0).Item("patientid").ToString
            Me.txtname.Text = PatientTable.Rows(0).Item("pname").ToString
            Me.txtdatebirth.Text = Format(PatientTable.Rows(0).Item("pAge"), "dd/MM/yyyy")
            Me.txtsex.Text = PatientTable.Rows(0).Item("pgender").ToString
            Me.txtaddress.Text = PatientTable.Rows(0).Item("pcontactaddress").ToString
            Me.txtno.ReadOnly = True
            Me.txtno.BackColor = Color.White
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class