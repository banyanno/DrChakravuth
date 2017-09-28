Public Class FindPatientExam
    Dim DocRequest As DashbordDotorRequestExamination
    Sub New(ByVal DocRequest As DashbordDotorRequestExamination)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.DocRequest = DocRequest
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

   
    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        If RadPatientNo.Checked = True Then
            If ValidateTextField(TxtPatientNo, "", ErrExamHistory) = False Then Exit Sub
            If ChFindHistory.Checked = True Then
                Me.DocRequest.FindHistoryExam(0, TxtPatientNo.Text, )
            Else
                Me.DocRequest.FindHistoryExam(1, TxtPatientNo.Text, )
            End If

        End If
        If RadPatientName.Checked = True Then
            If ValidateTextField(TxtPatientName, "", ErrExamHistory) = False Then Exit Sub
            If ChFindHistory.Checked = True Then
                Me.DocRequest.FindHistoryExam(0, , "%" & TxtPatientName.Text & "%")
            Else
                Me.DocRequest.FindHistoryExam(1, , "%" & TxtPatientName.Text & "%")
            End If

        End If
    End Sub

    Private Sub RadPatientNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadPatientNo.CheckedChanged
        TxtPatientNo.Enabled = True
        TxtPatientNo.Text = "0"
        TxtPatientName.Enabled = False
        TxtPatientName.Text = ""
    End Sub

    Private Sub RadPatientName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadPatientName.CheckedChanged
        TxtPatientNo.Enabled = False
        TxtPatientNo.Text = "0"
        TxtPatientName.Enabled = True
        TxtPatientName.Text = ""
    End Sub
End Class
