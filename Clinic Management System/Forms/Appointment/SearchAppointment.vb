Public Class SearchAppointment
    Dim DA_Appointment As New DSPAtientTableAdapters.AppointmentsTableAdapter
    Dim App As Appointment
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal AppPanel As Appointment)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.App = AppPanel
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub SearchAppointment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        If RadByPatientNo.Checked = True Then
            App.FindingApp(EmptyString(TxtPatientNo.Text), dtfrom.Value.Date, dtto.Value.Date, 1)
        ElseIf RadByPateintName.Checked = True Then
            App.FindingApp(TxtPatientName.Text, dtfrom.Value.Date, dtto.Value.Date, 2)
        ElseIf RadByPhone.Checked = True Then
            App.FindingApp(TxtPhoneNo.Text, dtfrom.Value.Date, dtto.Value.Date, 3)
        ElseIf RadAll.Checked = True Then
            App.FindingApp("", dtfrom.Value.Date, dtto.Value.Date, 4)
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub RadByPatientNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadByPatientNo.CheckedChanged
        setFinding()
    End Sub
    Private Sub setFinding()
        If RadByPatientNo.Checked = True Then
            TxtPatientNo.Text = ""
            TxtPatientName.Text = ""
            TxtPhoneNo.Text = ""
            TxtPatientNo.Enabled = True
            TxtPatientName.Enabled = False
            TxtPhoneNo.Enabled = False
        ElseIf RadByPateintName.Checked = True Then
            TxtPatientNo.Text = ""
            TxtPatientName.Text = ""
            TxtPhoneNo.Text = ""
            TxtPatientNo.Enabled = False
            TxtPatientName.Enabled = True
            TxtPhoneNo.Enabled = False
        ElseIf RadByPhone.Checked = True Then
            TxtPatientNo.Text = ""
            TxtPatientName.Text = ""
            TxtPhoneNo.Text = ""
            TxtPatientNo.Enabled = False
            TxtPatientName.Enabled = False
            TxtPhoneNo.Enabled = True
        ElseIf RadAll.Checked = True Then
            TxtPatientNo.Text = ""
            TxtPatientName.Text = ""
            TxtPhoneNo.Text = ""
            TxtPatientNo.Enabled = False
            TxtPatientName.Enabled = False
            TxtPhoneNo.Enabled = False
        End If
    End Sub

    Private Sub RadByPateintName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadByPateintName.CheckedChanged
        setFinding()
    End Sub

    Private Sub RadByPhone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadByPhone.CheckedChanged
        setFinding()
    End Sub
End Class