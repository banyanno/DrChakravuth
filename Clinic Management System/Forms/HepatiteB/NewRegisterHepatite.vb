Public Class NewRegisterHepatite
    Dim DAHepatite As New DSHepatiteBTableAdapters.HEPATITE_BTableAdapter
    Dim DAPatient As New DSHepatiteBTableAdapters.tblpatientTableAdapter
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtPatientNo, "", ErrRegisHepatite) = False Then Exit Sub
        If ValidateTextField(TxtName, "", ErrRegisHepatite) = False Then Exit Sub
        If ValidateTextField(TxtSex, "", ErrRegisHepatite) = False Then Exit Sub
        If ValidateTextField(TxtAge, "", ErrRegisHepatite) = False Then Exit Sub
        If ValidateTextField(TxtTel, "", ErrRegisHepatite) = False Then Exit Sub
        If ValidateTextField(TxtAddress, "", ErrRegisHepatite) = False Then Exit Sub
        If DAHepatite.CheckExistingPATIENT_NO(EmptyString(TxtPatientNo.Text)) > 0 Then
            MessageBox.Show("Patient already register into Hepatite!", "Hepatite", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to register new hepatite B?", "Hepatite B", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DAHepatite.InsertNewHepatiteB(EmptyString(TxtPatientNo.Text), TxtName.Text, TxtSex.Text, TxtAge.Text, TxtAddress.Text, Now.Date, TxtTel.Text, False, TxtNoted.Text) = 1 Then
                    MessageBox.Show("Save new register successful!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("Do you want to update hepatite B?", "Hepatite B", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DAHepatite.UpdateHepatite(EmptyString(TxtPatientNo.Text), TxtName.Text, TxtSex.Text, TxtAge.Text, TxtAddress.Text, Now.Date, TxtTel.Text, False, TxtNoted.Text, LblSaveOption.Text) = 1 Then
                    MessageBox.Show("Update register hepatite successful!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        If ValidateTextField(TxtPatientNo, "", ErrRegisHepatite) = False Then Exit Sub
       
        Dim TblPatient As DataTable = DAPatient.FindByPatientNo(EmptyString(TxtPatientNo.Text))
        If TblPatient.Rows.Count <= 0 Then
            TxtName.Text = ""
            TxtSex.Text = ""
            TxtAge.Text = ""
            TxtAddress.Text = ""
            TxtTel.Text = ""
            Exit Sub
        Else
            For Each rows In TblPatient.Rows
                TxtName.Text = rows("pname")
                TxtSex.Text = rows("pgender")
                TxtAge.Text = rows("Age")
                TxtAddress.Text = rows("pcontactaddress")
                TxtTel.Text = rows("pphoneno")

            Next
        End If

    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub NewRegisterHepatite_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class