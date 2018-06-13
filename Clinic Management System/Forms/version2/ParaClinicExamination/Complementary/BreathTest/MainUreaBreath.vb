Public Class MainUreaBreath
    Dim DA_BreathTest As New DSExaminationTableAdapters.TblBreathTestTableAdapter

    Private Sub RefreshBreathTest()
        GridBreathTest.DataSource = DA_BreathTest.GetData
    End Sub
    Private Sub EnterResultBreathTest()
        If GridBreathTest.SelectedItems.Count = 0 Then Exit Sub
        Dim ResultBreathTest As New NewUreaBreath
        ResultBreathTest.LblSaveOption.Text = GridBreathTest.GetRow.Cells("BreathID").Value
        ResultBreathTest.LblRequestNo.Text = GridBreathTest.GetRow.Cells("RequestID").Value
        ResultBreathTest.txtno.Text = GridBreathTest.GetRow.Cells("PatientNo").Value
        ResultBreathTest.txtname.Text = GridBreathTest.GetRow.Cells("PatientName").Value
        ResultBreathTest.txtsex.Text = GridBreathTest.GetRow.Cells("PatientSex").Value
        ResultBreathTest.txtdatebirth.Text = GridBreathTest.GetRow.Cells("PatientDOB").Value
        ResultBreathTest.txtaddress.Text = GridBreathTest.GetRow.Cells("PatientAdress").Value
        ResultBreathTest.DateRequest.Checked = True
        ResultBreathTest.DateRequest.Value = GridBreathTest.GetRow.Cells("DateTest").Value
        ResultBreathTest.cbodoctor.Text = GridBreathTest.GetRow.Cells("RequestBy").Value
        ResultBreathTest.TxtIndication.Text = GridBreathTest.GetRow.Cells("Indication").Value
        ResultBreathTest.TxtResult.Text = GridBreathTest.GetRow.Cells("Result").Value
        ResultBreathTest.CboConclusion.Text = GridBreathTest.GetRow.Cells("Conclusion").Value
        ResultBreathTest.TxtMoreInfo.Text = GridBreathTest.GetRow.Cells("BreathTestNote").Value
        ResultBreathTest.ShowDialog()
    End Sub
    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        RefreshBreathTest()
    End Sub

    Private Sub BtnUpdateBreath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateBreath.Click
        EnterResultBreathTest()
    End Sub

    Private Sub GridBreathTest_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridBreathTest.RowDoubleClick
        EnterResultBreathTest()
    End Sub

  
    Private Sub GridBreathTest_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridBreathTest.SelectionChanged
        If GridBreathTest.SelectedItems.Count = 0 Then Exit Sub
        DateRequest.Value = GridBreathTest.GetRow.Cells("DateTest").Value
        cbodoctor.Text = GridBreathTest.GetRow.Cells("RequestBy").Value
        TxtIndication.Text = GridBreathTest.GetRow.Cells("Indication").Value
        TxtResult.Text = GridBreathTest.GetRow.Cells("Result").Value
        CboConclusion.Text = GridBreathTest.GetRow.Cells("Conclusion").Value
        TxtMoreInfo.Text = GridBreathTest.GetRow.Cells("BreathTestNote").Value
    End Sub
End Class
