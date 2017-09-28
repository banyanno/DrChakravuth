Public Class EditeConsultationFee
    Dim DA_ConsultType As New DSPAtientTableAdapters.tblConsultTypeTableAdapter
    Dim DA_PreConsultation As New DSConsultationTableAdapters.tbl_preinvoice_consultationTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.CboConsult.DataSource = DA_ConsultType.SelectConsultationTypes
        Me.CboConsult.DisplayMember = DA_ConsultType.SelectConsultationTypes.Columns("consulttypename").ColumnName
        Me.CboConsult.ValueMember = DA_ConsultType.SelectConsultationTypes.Columns("consulttypeid").ColumnName
        Me.CboConsult.SelectedIndex = -1
        ' Add any initialization after the InitializeComponent() call.

    End Sub
   

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        If ValidateCombobox(CboConsult, "", ErrorUpdate) = False Then Exit Sub
        If MessageBox.Show("Do you want update consultation?", "Consult", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim ConsultPrice As Double
            ConsultPrice = DA_ConsultType.SelectConsultByID(CInt(Me.CboConsult.SelectedValue)).Rows(0).Item("price")
            If DA_PreConsultation.UpdatePreConsult(CboConsult.Text, ConsultPrice, LblConsultID.Text) = 1 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub
End Class