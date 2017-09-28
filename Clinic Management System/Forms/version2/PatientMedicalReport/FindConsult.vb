Public Class FindConsult
    Dim MedicalHistory As UPatientMedicalReport
    Sub New(ByVal MedicalHistory As UPatientMedicalReport)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MedicalHistory = MedicalHistory
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        If RadPatientNo.Checked = True Then
            If ValidateTextField(TxtPatientNo, "", ErrConsult) = False Then Exit Sub
            MedicalHistory.FindPatientNo(EmptyString(TxtPatientNo.Text))
        End If
        If RadPatientName.Checked = True Then
            If ValidateTextField(TxtPatientName, "", ErrConsult) = False Then Exit Sub
            MedicalHistory.FindByPatientName(TxtPatientName.Text)
        End If
    End Sub
End Class