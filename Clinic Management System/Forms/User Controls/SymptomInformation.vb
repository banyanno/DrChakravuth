Public Class SymptomInformation
    Dim DA_Symptom As New DSPAtientTableAdapters.SymptomsTableAdapter
    Private Sub SymptomInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SymptomList.DataSource = DA_Symptom.GetData
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        'Dim Sym As New NewSymptom(Me)
        'Sym.ShowDialog()
    End Sub
    Sub LoadDataToGridView()
        Me.SymptomList.DataSource = DA_Symptom.GetData

    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MsgBox("Are you sure you want to delete this symptom?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DA_Symptom.DeleteSymptom(SymptomList.CurrentRow.Cells(0).Value)
            LoadDataToGridView()
        End If
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        'Dim Sym As New EditSymptom(Me)
        'Sym.txtname.Text = SymptomList.CurrentRow.Cells(1).Value
        'Sym.txtid.Text = SymptomList.CurrentRow.Cells(0).Value
        'Sym.ShowDialog()
    End Sub
End Class
