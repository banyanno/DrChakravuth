Public Class DashboardHepatiteB
    Dim DAHepatiteB As New DSHepatiteBTableAdapters.HEPATITE_BTableAdapter
    Dim DAHepatiteHistory As New DSHepatiteBTableAdapters.HEPATITE_B_DETAILTableAdapter

    Private Sub RadByPatientNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadByPatientNo.CheckedChanged
        TxtFindPatientNo.Enabled = RadByPatientNo.Checked
    End Sub

    Private Sub RadByName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadByName.CheckedChanged
        TxtFindPatientName.Enabled = RadByName.Checked
    End Sub

    Private Sub RadByPhone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadByPhone.CheckedChanged
        TxtFindByTel.Enabled = RadByPhone.Checked
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        If RadByPatientNo.Checked = True Then
            GridHepatiteB.DataSource = DAHepatiteB.SelectByPatientNo(EmptyString(TxtFindPatientNo.Text), DateFindFrom.Value.Date, DateFindTo.Value.Date)
        ElseIf RadAllHepatite.Checked = True Then
            GridHepatiteB.DataSource = DAHepatiteB.SelectAllHepatite(DateFindFrom.Value.Date, DateFindTo.Value.Date)
        ElseIf RadByName.Checked = True Then
            GridHepatiteB.DataSource = DAHepatiteB.SelectPatientByName(EmptyString(TxtFindPatientName.Text), DateFindFrom.Value.Date, DateFindTo.Value.Date)
        ElseIf RadByPhone.Checked = True Then
            GridHepatiteB.DataSource = DAHepatiteB.SelectByPatientTel(EmptyString(TxtFindByTel.Text), DateFindFrom.Value.Date, DateFindTo.Value.Date)
        End If
    End Sub

    Private Sub TxtFindPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFindPatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub NewHepatiteBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewHepatiteBToolStripMenuItem.Click
        Dim FRegisHeptit As New NewRegisterHepatite
        If FRegisHeptit.ShowDialog() = DialogResult.OK Then
            GridHepatiteB.DataSource = DAHepatiteB.SelectByPatientNo(FRegisHeptit.TxtPatientNo.Text, Me.DateFindFrom.Value.Date, Me.DateFindTo.Value.Date)
        End If
    End Sub

    Private Sub UpdateHepatiteBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateHepatiteBToolStripMenuItem.Click
        If GridHepatiteB.SelectedItems.Count = 0 Then Exit Sub
        Dim FRegisHeptit As New NewRegisterHepatite
        FRegisHeptit.TxtPatientNo.Enabled = False
        FRegisHeptit.BtnFind.Enabled = False
        FRegisHeptit.LblSaveOption.Text = GridHepatiteB.GetRow.Cells("HEPATITE_ID").Value
        FRegisHeptit.TxtPatientNo.Text = GridHepatiteB.GetRow.Cells("PATIENT_NO").Value
        FRegisHeptit.TxtName.Text = GridHepatiteB.GetRow.Cells("PATIENT_NAME").Value
        FRegisHeptit.TxtAge.Text = GridHepatiteB.GetRow.Cells("PATIENT_AGE").Value
        FRegisHeptit.TxtSex.Text = GridHepatiteB.GetRow.Cells("PATIENNT_SEX").Value
        FRegisHeptit.TxtTel.Text = GridHepatiteB.GetRow.Cells("PATIENT_PHONE").Value
        FRegisHeptit.TxtAddress.Text = GridHepatiteB.GetRow.Cells("PATIENT_ADDRESS").Value
        FRegisHeptit.TxtNoted.Text = GridHepatiteB.GetRow.Cells("HEPATITE_NOTE").Value
        If FRegisHeptit.ShowDialog() = DialogResult.OK Then
            GridHepatiteB.DataSource = DAHepatiteB.SelectByPatientNo(FRegisHeptit.TxtPatientNo.Text, Me.DateFindFrom.Value.Date, Me.DateFindTo.Value.Date)
        End If
    End Sub


    Private Sub GridHepatiteB_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridHepatiteB.RowDoubleClick
        If GridHepatiteB.SelectedItems.Count = 0 Then Exit Sub
        Dim FRegisHeptit As New NewRegisterHepatite
        FRegisHeptit.TxtPatientNo.Enabled = False
        FRegisHeptit.BtnFind.Enabled = False
        FRegisHeptit.LblSaveOption.Text = GridHepatiteB.GetRow.Cells("HEPATITE_ID").Value
        FRegisHeptit.TxtPatientNo.Text = GridHepatiteB.GetRow.Cells("PATIENT_NO").Value
        FRegisHeptit.TxtName.Text = GridHepatiteB.GetRow.Cells("PATIENT_NAME").Value
        FRegisHeptit.TxtAge.Text = GridHepatiteB.GetRow.Cells("PATIENT_AGE").Value
        FRegisHeptit.TxtSex.Text = GridHepatiteB.GetRow.Cells("PATIENNT_SEX").Value
        FRegisHeptit.TxtTel.Text = GridHepatiteB.GetRow.Cells("PATIENT_PHONE").Value
        FRegisHeptit.TxtAddress.Text = GridHepatiteB.GetRow.Cells("PATIENT_ADDRESS").Value
        FRegisHeptit.TxtNoted.Text = GridHepatiteB.GetRow.Cells("HEPATITE_NOTE").Value
        If FRegisHeptit.ShowDialog() = DialogResult.OK Then
            GridHepatiteB.DataSource = DAHepatiteB.SelectByPatientNo(FRegisHeptit.TxtPatientNo.Text, Me.DateFindFrom.Value.Date, Me.DateFindTo.Value.Date)
        End If
    End Sub

    Private Sub GridHepatiteB_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridHepatiteB.SelectionChanged
        Try
            GridHistoryHepatite.DataSource = DAHepatiteHistory.SelectHepatiteDetialByID(GridHepatiteB.GetRow.Cells("HEPATITE_ID").Value)
        Catch ex As Exception
            GridHistoryHepatite.DataSource = Nothing
        End Try
    End Sub

    Private Sub GridHistoryHepatite_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridHistoryHepatite.RowDoubleClick
        If GridHepatiteB.SelectedItems.Count = 0 Then Exit Sub
        If GridHistoryHepatite.SelectedItems.Count = 0 Then Exit Sub
        Dim FHepatiteDetail As New NewRegisterHepatiteDetial


        FHepatiteDetail.TxtPatientNo.Text = GridHepatiteB.GetRow.Cells("PATIENT_NO").Value
        FHepatiteDetail.TxtName.Text = GridHepatiteB.GetRow.Cells("PATIENT_NAME").Value
        FHepatiteDetail.TxtSex.Text = GridHepatiteB.GetRow.Cells("PATIENNT_SEX").Value
        FHepatiteDetail.TxtAge.Text = GridHepatiteB.GetRow.Cells("PATIENT_AGE").Value
        FHepatiteDetail.TxtAddress.Text = GridHepatiteB.GetRow.Cells("PATIENT_ADDRESS").Value
        FHepatiteDetail.TxtTel.Text = GridHepatiteB.GetRow.Cells("PATIENT_PHONE").Value

        FHepatiteDetail.LblSaveOption.Text = GridHistoryHepatite.GetRow.Cells("HEPATITE_DETIAL_ID").Value
        FHepatiteDetail.LblHepatiteID.Text = GridHistoryHepatite.GetRow.Cells("HAPATITE_ID").Value
        FHepatiteDetail.DateHepatiteResult.Checked = True
        FHepatiteDetail.DateHepatiteResult.Value = GridHistoryHepatite.GetRow.Cells("DATE_HAPATITE").Value
        FHepatiteDetail.CboMedicince.Text = GridHistoryHepatite.GetRow.Cells("MEDICINCE_NAME").Value
        FHepatiteDetail.TxtResultHepatite.Text = GridHistoryHepatite.GetRow.Cells("HAPTITE_RESUT").Value

        If FHepatiteDetail.ShowDialog = DialogResult.OK Then
            Try
                GridHistoryHepatite.DataSource = DAHepatiteHistory.SelectHepatiteDetialByID(GridHepatiteB.GetRow.Cells("HEPATITE_ID").Value)
            Catch ex As Exception
                GridHistoryHepatite.DataSource = Nothing
            End Try
        End If
    End Sub

    Private Sub NewResultHepatiteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewResultHepatiteToolStripMenuItem.Click
        If GridHepatiteB.SelectedItems.Count = 0 Then Exit Sub
        Dim FHepatiteDetail As New NewRegisterHepatiteDetial

        FHepatiteDetail.TxtPatientNo.Text = GridHepatiteB.GetRow.Cells("PATIENT_NO").Value
        FHepatiteDetail.TxtName.Text = GridHepatiteB.GetRow.Cells("PATIENT_NAME").Value
        FHepatiteDetail.TxtSex.Text = GridHepatiteB.GetRow.Cells("PATIENNT_SEX").Value
        FHepatiteDetail.TxtAge.Text = GridHepatiteB.GetRow.Cells("PATIENT_AGE").Value
        FHepatiteDetail.TxtAddress.Text = GridHepatiteB.GetRow.Cells("PATIENT_ADDRESS").Value
        FHepatiteDetail.TxtTel.Text = GridHepatiteB.GetRow.Cells("PATIENT_PHONE").Value
        FHepatiteDetail.LblHepatiteID.Text = GridHepatiteB.GetRow.Cells("HEPATITE_ID").Value
        If FHepatiteDetail.ShowDialog = DialogResult.OK Then
            Try
                GridHistoryHepatite.DataSource = DAHepatiteHistory.SelectHepatiteDetialByID(GridHepatiteB.GetRow.Cells("HEPATITE_ID").Value)
            Catch ex As Exception
                GridHistoryHepatite.DataSource = Nothing
            End Try
        End If
    End Sub

    Private Sub UpdateResultHepatiteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateResultHepatiteToolStripMenuItem.Click
        If GridHepatiteB.SelectedItems.Count = 0 Then Exit Sub
        If GridHistoryHepatite.SelectedItems.Count = 0 Then Exit Sub
        Dim FHepatiteDetail As New NewRegisterHepatiteDetial


        FHepatiteDetail.TxtPatientNo.Text = GridHepatiteB.GetRow.Cells("PATIENT_NO").Value
        FHepatiteDetail.TxtName.Text = GridHepatiteB.GetRow.Cells("PATIENT_NAME").Value
        FHepatiteDetail.TxtSex.Text = GridHepatiteB.GetRow.Cells("PATIENNT_SEX").Value
        FHepatiteDetail.TxtAge.Text = GridHepatiteB.GetRow.Cells("PATIENT_AGE").Value
        FHepatiteDetail.TxtAddress.Text = GridHepatiteB.GetRow.Cells("PATIENT_ADDRESS").Value
        FHepatiteDetail.TxtTel.Text = GridHepatiteB.GetRow.Cells("PATIENT_PHONE").Value

        FHepatiteDetail.LblSaveOption.Text = GridHistoryHepatite.GetRow.Cells("HEPATITE_DETIAL_ID").Value
        FHepatiteDetail.LblHepatiteID.Text = GridHistoryHepatite.GetRow.Cells("HAPATITE_ID").Value
        FHepatiteDetail.DateHepatiteResult.Checked = True
        FHepatiteDetail.DateHepatiteResult.Value = GridHistoryHepatite.GetRow.Cells("DATE_HAPATITE").Value
        FHepatiteDetail.CboMedicince.Text = GridHistoryHepatite.GetRow.Cells("MEDICINCE_NAME").Value
        FHepatiteDetail.TxtResultHepatite.Text = GridHistoryHepatite.GetRow.Cells("HAPTITE_RESUT").Value

        If FHepatiteDetail.ShowDialog = DialogResult.OK Then
            Try
                GridHistoryHepatite.DataSource = DAHepatiteHistory.SelectHepatiteDetialByID(GridHepatiteB.GetRow.Cells("HEPATITE_ID").Value)
            Catch ex As Exception
                GridHistoryHepatite.DataSource = Nothing
            End Try
        End If
    End Sub
End Class
