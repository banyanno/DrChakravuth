Public Class UCMedicine
    Dim DA_Medicine As New DSPAtientTableAdapters.tblmedicineTableAdapter
    Sub RefreshMedicine()
        Me.MedicineList.DataSource = DA_Medicine.GetData
    End Sub

    Sub FillBy(ByVal ID As Integer)
        Me.MedicineList.DataSource = DA_Medicine.SelectMedicineByID(ID)
    End Sub
    Sub FilByName(ByVal Name As String)
        Me.MedicineList.DataSource = DA_Medicine.SelectMedicineByName(Name)
    End Sub
    Private Sub UCMedicine_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RefreshMedicine()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If Me.MedicineList.RowCount >= 1 Then
            If MsgBox("Are you sure you want to delete this medicine?", MsgBoxStyle.YesNo, "Confirm Deletion") = MsgBoxResult.Yes Then
                DA_Medicine.DeleteMedicine(True, CInt(Me.MedicineList.CurrentRow.Cells("medicineid").Value))
                Me.RefreshMedicine()
                MsgBox("The medicine has been deleted", MsgBoxStyle.Information, "Medicine Deleted")
            End If
        End If
    End Sub

    Private Sub BtnNewStore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewStore.Click
        Dim FrmNew As New NewMedicine(Me)
        If FrmNew.ShowDialog() = DialogResult.OK Then
            FilByName(FrmNew.txtmedicine.Text)
        End If
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        If Me.MedicineList.RowCount >= 1 Then
            Dim FrmUpdate As New UpdateMedicine(Me)
            FrmUpdate.TxtItemBarcode.Text = Me.MedicineList.CurrentRow.Cells("medicine_code").Value.ToString
            FrmUpdate.txtmedicine.Text = Me.MedicineList.CurrentRow.Cells("medicinename").Value.ToString
            If FrmUpdate.ShowDialog() = DialogResult.OK Then
                FillBy(Me.MedicineList.CurrentRow.Cells("medicineid").Value)
            End If
        End If
    End Sub

    Private Sub MedicineList_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles MedicineList.RowDoubleClick
        If Me.MedicineList.RowCount >= 1 Then
            Dim FrmUpdate As New UpdateMedicine(Me)
            FrmUpdate.TxtItemBarcode.Text = Me.MedicineList.CurrentRow.Cells("medicine_code").Value.ToString
            FrmUpdate.txtmedicine.Text = Me.MedicineList.CurrentRow.Cells("medicinename").Value.ToString
            If FrmUpdate.ShowDialog() = DialogResult.OK Then
                FillBy(Me.MedicineList.CurrentRow.Cells("medicineid").Value)
            End If
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        RefreshMedicine()
    End Sub

    Private Sub btnUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUndo.Click
        If Me.MedicineList.RowCount >= 1 Then
            If MsgBox("Are you sure you want to delete this medicine?", MsgBoxStyle.YesNo, "Confirm Deletion") = MsgBoxResult.Yes Then
                DA_Medicine.DeleteMedicine(False, CInt(Me.MedicineList.CurrentRow.Cells("medicineid").Value))
                Me.RefreshMedicine()
                MsgBox("The medicine has been deleted", MsgBoxStyle.Information, "Medicine Deleted")
            End If
        End If
    End Sub
End Class
