Public Class MainUreaBreath
    Dim DA_BreathTest As New DSExaminationTableAdapters.TblBreathTestTableAdapter
    Dim VALUE_LOADING_DATA As Integer
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
        If ResultBreathTest.ShowDialog() = DialogResult.OK Then
            FindPatientBreathTest()
        End If
    End Sub
    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub ChByPatientNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChByPatientNo.CheckedChanged
        TxtPatientNo.Enabled = ChByPatientNo.Checked
    End Sub
    Private Sub FindPatientBreathTest()
        Dim TblBreathTest As DataTable
        If ChByPatientNo.Checked = True Then
            If ValidateTextField(TxtPatientNo, "", ErrBreathTest) = False Then Exit Sub
            TblBreathTest = DA_BreathTest.SelectBreathTestDateToDateWithPatientNo(DateFrom.Value.Date, DateTo.Value.Date, EmptyString(TxtPatientNo.Text))
        Else
            TblBreathTest = DA_BreathTest.SelectBreathTestDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
        End If
        GridBreathTest.DataSource = TblBreathTest
    End Sub

    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnFindPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFindPatient.Click
        FindPatientBreathTest()
    End Sub

    Private Sub MainUreaBreath_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FindPatientBreathTest()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If GridBreathTest.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete breath test?", "Breath Test", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_BreathTest.DeleteBreathTest(GridBreathTest.GetRow.Cells("BreathID").Value) = 1 Then
                FindPatientBreathTest()
            End If
        End If
    End Sub

    Private Sub BtnPrintPreviw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreviw.Click
        MainApplicationForm.StatusLoading(True)
        VALUE_LOADING_DATA = 9
        Application.DoEvents()
        BgLoadData.RunWorkerAsync()
    End Sub

    Private Sub BgLoadData_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadData.DoWork
        LoadingData()
    End Sub
    Private Sub LoadingData()

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadingData))
        Else
            Select Case VALUE_LOADING_DATA
           
                Case 9
                    ShowRptBreathTest()
            End Select
        End If
    End Sub
    Private Sub ShowRptBreathTest()
        If Me.GridBreathTest.SelectedItems.Count = 0 Then Exit Sub
        Dim FrmViewer As New FormReportViewer
        Dim Rpt As New BreathReport
        Dim TblBreathTest As DataTable = DA_BreathTest.SelectBreathTestByID(GridBreathTest.GetRow.Cells("RequestID").Value)
        Rpt.SetDataSource(TblBreathTest)
        'Rpt.Subreports("NasoConclusion").SetDataSource(TblNasoConclusion)
        FrmViewer.CVForm.ReportSource = Rpt
        FrmViewer.SplitContainer1.Panel1Collapsed = True
        FrmViewer.ShowDialog()
    End Sub

    Private Sub BgLoadData_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadData.RunWorkerCompleted
        MainApplicationForm.StatusLoading(False)
    End Sub
End Class
