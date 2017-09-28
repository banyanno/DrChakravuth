Public Class ChooseConsultation

    Private Sub ChooseConsultation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DA_Disease As New DSPAtientTableAdapters.Consult_DiseasesTableAdapter
        Dim DiseaseList As New DataTable
        DiseaseList = DA_Disease.GetData
        Me.CboConsultType.DataSource = DiseaseList
        Me.CboConsultType.ValueMember = DiseaseList.Columns(0).ColumnName
        Me.CboConsultType.DisplayMember = DiseaseList.Columns(1).ColumnName
        Me.CboConsultType.SelectedIndex = -1
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Me.Close()
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        If ValidateCombobox(CboConsultType, "", ErroConsult) = False Then Exit Sub
        Select Case CInt(Me.CboConsultType.SelectedValue)
            Case 1
                NewStomachConsultation.txtPatientID.Text = Me.txtpatientid.Text
                NewStomachConsultation.ShowDialog()
            Case 2
                NewLiverConsultation.txtPatientID.Text = Me.txtpatientid.Text
                NewLiverConsultation.ShowDialog()
            Case Else
                NewFinalConsultation.txtPatientID.Text = Me.txtpatientid.Text
                NewFinalConsultation.ShowDialog()
        End Select
    End Sub
End Class