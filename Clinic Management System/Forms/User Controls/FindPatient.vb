Public Class FindPatient
    Dim UPatientInfo As PatientInformation
    Dim UMedical As UPatientMedicalReport
    Dim DA_Province As New DSPAtientTableAdapters.tblProvincesTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal PatientInforPanel As PatientInformation)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.UPatientInfo = PatientInforPanel
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal UMedical As UPatientMedicalReport)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.UMedical = UMedical
        ' Add any initialization after the InitializeComponent() call.
        With CboAddress
            .DataSource = DA_Province.GetData
            .ValueMember = "IDProvCode"
            .DisplayMember = "Province"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        ''Me.UPatientInfo.PatientList.DataSource = Nothing
        If RadByPatientNo.Checked = True Then
            Me.UMedical.FindPatient(TxtByPatientNo.Text, 1)
        ElseIf RadByPateintName.Checked = True Then
            Me.UMedical.FindPatient(TxtByPatientName.Text, 2)
        ElseIf RadByPhone.Checked = True Then
            Me.UMedical.FindPatient(TxtByPhone.Text, 3)
        ElseIf RadAddress.Checked = True Then
            Me.UMedical.FindPatient(CboAddress.Text, 4)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Me.Close()
    End Sub

  

    Private Sub RadByPatientNo_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.TxtByPatientName.Text = ""
        Me.TxtByPhone.Text = ""
        Me.TxtByPatientNo.Focus()
    End Sub

    Private Sub RadByPateintName_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.TxtByPatientNo.Text = ""
        Me.TxtByPhone.Text = ""
        Me.TxtByPatientName.Focus()
    End Sub

    Private Sub RadByPhone_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.TxtByPatientNo.Text = ""
        Me.TxtByPatientName.Text = ""
        Me.TxtByPhone.Focus()
    End Sub

    Private Sub TxtByPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtByPatientNo_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtByPatientNo.KeyPress
        SetDisableKeyString(e)
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

    Private Sub RadByPatientNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadByPatientNo.CheckedChanged
        CheckSercher()
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
End Class