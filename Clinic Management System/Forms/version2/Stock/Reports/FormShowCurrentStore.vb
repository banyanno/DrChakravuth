Public Class FormShowCurrentStore
    Dim ReportPanel As UCStoreReport
    Dim DA_Medicine As New DSPAtientTableAdapters.tblmedicineTableAdapter
    Dim DA_Store As New DSStoreReportTableAdapters.StoreTableAdapter

    Sub New(ByVal UReport As UCStoreReport)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ReportPanel = UReport
        ' Add any initialization after the InitializeComponent() call.
        Me.cbomedicine.DataSource = DA_Medicine.SelectMedicine
        Me.cbomedicine.ValueMember = DA_Medicine.SelectMedicine.Columns("medicineid").ColumnName
        Me.cbomedicine.DisplayMember = DA_Medicine.SelectMedicine.Columns("medicinename").ColumnName
        Me.cbomedicine.SelectedIndex = -1
    End Sub

    Private Sub BtnShow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnShow.Click
        If RadByAll.Checked = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK

           
        End If
        If RadByMedicine.Checked = True Then
            If ValidateCombobox(cbomedicine, "", EorrStore) = False Then Exit Sub
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
        'Dim StoreReport As New RptStore
        'Dim StoreTable As New DataTable
        'If RadByAll.Checked = True Then
        '    StoreTable = DA_Store.SelectAllStore
        'Else
        '    If ValidateCombobox(cbomedicine, "", EorrStore) = False Then Exit Sub
        '    StoreTable = DA_Store.SelectStoreByMedicineID(CInt(Me.cbomedicine.SelectedValue))
        'End If
        'StoreReport.SetDataSource(StoreTable)
        'ReportPanel.CrystalReportViewer1.ReportSource = StoreReport
        'ReportPanel.CrystalReportViewer1.Show()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

   
End Class