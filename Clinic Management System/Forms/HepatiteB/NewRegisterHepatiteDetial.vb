Public Class NewRegisterHepatiteDetial
    Dim DAHepatiteDetail As New DSHepatiteBTableAdapters.HEPATITE_B_DETAILTableAdapter
    Dim DAItem As New DSHepatiteBTableAdapters.tblItemTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboMedicince
            .DataSource = DAItem.GetData
            .ValueMember = "ItemID"
            .DisplayMember = "ItemName"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateDateTimePicker(DateHepatiteResult, "", ErrHepatiteDetail) = False Then Exit Sub
        If ValidateCombobox(CboMedicince, "", ErrHepatiteDetail) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save new Hepatite result?", "Hepatite", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DAHepatiteDetail.InsertNewHepatiteBDetial(LblHepatiteID.Text, DateHepatiteResult.Value.Date, TxtResultHepatite.Text, CboMedicince.Text) = 1 Then
                    MessageBox.Show("Save new result successful!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("Do you want to save new Hepatite result?", "Hepatite", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DAHepatiteDetail.UpdateHepatite(DateHepatiteResult.Value.Date, TxtResultHepatite.Text, CboMedicince.Text, LblSaveOption.Text) = 1 Then
                    MessageBox.Show("Update result successful!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub
End Class