Public Class FormHistoryConsultation
    Private waitingConsult As MainWaitingConsuling
    Dim consultation As New DSConsultationTableAdapters.V_PRESCRIPTIONTableAdapter
    Sub New(ByVal waitingConsult As MainWaitingConsuling)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.waitingConsult = waitingConsult
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        If RadPatientNo.Checked = True Then
            If ValidateTextField(TxtPatientNo, "", ErrFindHistoryConsult) = False Then Exit Sub
            GridPrescriptionDetail.DataSource = consultation.GetDataPrescriptionByPID(TxtPatientNo.Text)
        End If
        If RadPatientName.Checked = True Then
            If ValidateTextField(TxtPatientName, "", ErrFindHistoryConsult) = False Then Exit Sub
            GridPrescriptionDetail.DataSource = consultation.GetDataByPatientName("%" & TxtPatientName.Text & "%")
        End If
        'If RadPatientNo.Checked = True Then
        '    If ValidateTextField(TxtPatientNo, "", ErrFindHistoryConsult) = False Then Exit Sub
        '    Me.waitingConsult.LoadHistoryConsult(0, TxtPatientNo.Text, )
        'End If
        'If RadPatientName.Checked = True Then
        '    If ValidateTextField(TxtPatientName, "", ErrFindHistoryConsult) = False Then Exit Sub
        '    Me.waitingConsult.LoadHistoryConsult(0, , TxtPatientName.Text)
        'End If
    End Sub

    

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub RadPatientNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadPatientNo.CheckedChanged
        TxtPatientName.Enabled = False
        TxtPatientName.Text = ""
        TxtPatientNo.Enabled = True
        TxtPatientNo.Text = "0"
    End Sub

    Private Sub RadPatientName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadPatientName.CheckedChanged
        TxtPatientNo.Enabled = False
        TxtPatientNo.Text = "0"
        TxtPatientName.Enabled = True
        TxtPatientNo.Text = ""
    End Sub

    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class