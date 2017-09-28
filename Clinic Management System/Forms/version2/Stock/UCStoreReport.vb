Public Class UCStoreReport

    
    Dim DA_Store As New DSStoreReportTableAdapters.StoreTableAdapter
    Dim ReportOption As Integer
    Dim StoreTable As New DataTable
    Private Sub StoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCurrentStore.Click
        Dim FrmShow As New FormShowCurrentStore(Me)
        If FrmShow.ShowDialog() = DialogResult.OK Then
            If FrmShow.RadByAll.Checked = True Then
                MainApplicationForm.StatusLoading(True)
                StoreTable = DA_Store.SelectAllStore
                ReportOption = 1
                BgLoadingReport.RunWorkerAsync()
            Else
                MainApplicationForm.StatusLoading(True)
                StoreTable = DA_Store.SelectStoreByMedicineID(CInt(FrmShow.cbomedicine.SelectedValue))
                ReportOption = 1
                BgLoadingReport.RunWorkerAsync()
            End If
           

        End If
    End Sub

    Private Sub LoadingReport()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadingReport))
        Else
            Select Case ReportOption
                Case 1
                    Dim StoreReport As New RptStore
                    StoreReport.SetDataSource(StoreTable)
                    Me.CrystalReportViewer1.ReportSource = StoreReport
                Case 2
                Case 3

            End Select
        End If
        
    End Sub
    Private Sub BtnReceiveStore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReceiveStore.Click
        Dim FormReport As New FormShowBy(Me, 1)
        FormReport.ShowDialog()
    End Sub

    Private Sub BtnIssueStore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIssueStore.Click
        Dim FormReport As New FormShowBy(Me, 2)
        FormReport.ShowDialog()
    End Sub

    Private Sub BtnStoreTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStoreTransaction.Click
        Dim FormReport As New FormShowBy(Me, 3)
        If FormReport.ShowDialog() = DialogResult.OK Then

        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim FormReport As New FormShowBy(Me, 4)
        FormReport.ShowDialog()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Dim FormReport As New FormShowBy(Me, 5)
        FormReport.ShowDialog()
    End Sub

    Private Sub BgLoadingReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadingReport.DoWork

        LoadingReport()
    End Sub

    Private Sub BgLoadingReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadingReport.RunWorkerCompleted
        MainApplicationForm.StatusLoading(False)
    End Sub
End Class
