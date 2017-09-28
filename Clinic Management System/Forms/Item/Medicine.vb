Public Class Medicine
    Dim DA_Medicine As New DSPAtientTableAdapters.MedicinesTableAdapter
    Private Sub Medicine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshData()
    End Sub
    Sub RefreshData()
        Me.MedicineList.DataSource = DA_Medicine.SelectMedicine
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Dim FrmMedicine As New Item(Me)
        FrmMedicine.lblaction.Text = 0
        FrmMedicine.ShowDialog()
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        If MedicineList.CurrentRow.Cells("Category_ID").Value Is Nothing Then
            MessageBox.Show("No record was selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim FrmMedicine As New Item(Me)
            FrmMedicine.lblaction.Text = 1
            FrmMedicine.ShowDialog()

        End If
      
     
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MsgBox("Are you sure you want to delete this medicine?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DA_Medicine.DeleteMedicine(Me.MedicineList.CurrentRow.Cells("Medicine_ID").Value)
            RefreshData()
        End If
    End Sub
End Class
