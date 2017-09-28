Public Class ParaClinic
    Dim DA_Para As New DSPAtientTableAdapters.tblparacheckTableAdapter
    Dim DA_PrePara As New DSPAtientTableAdapters.tblpreparacheckdetailTableAdapter
    Dim DA_ParaDetail As New DSPAtientTableAdapters.tblparacheckdetailTableAdapter
    Dim Prescription As NewPrescription
    Dim PreHistory As New PrescriptionHistory
    Sub New(ByVal FrmPreHistory As PrescriptionHistory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.PreHistory = FrmPreHistory
        LoadPara()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LoadPara()
    End Sub
    Sub New(ByVal PreFrm As NewPrescription)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.Prescription = PreFrm
        ' Add any initialization after the InitializeComponent() call.
        LoadPara()
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Sub LoadPara()
        Dim ParaList As New DataTable
        ParaList = DA_Para.SelectPara
        Me.cboexamination.DataSource = ParaList
        Me.cboexamination.DisplayMember = ParaList.Columns("paracheck").ColumnName
        Me.cboexamination.ValueMember = ParaList.Columns("paracheckid").ColumnName
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim ServiceCharge As Double
        Dim ParaTable As New DataTable
        ParaTable = DA_Para.SelectParaByID(CInt(Me.cboexamination.SelectedValue.ToString))
        ServiceCharge = CDbl(ParaTable.Rows(0).Item("servicecharge").ToString)
        If Me.lbloldprescription.Text = 0 Then
            If lblaction.Text = 0 Then
                DA_PrePara.InsertPara(Prescription.lblpatientId.Text, CInt(Me.cboexamination.SelectedValue.ToString), ServiceCharge, Me.txtdesc.Text.ToString.Replace("'", "''"))
                MsgBox("One para clinic examination was added", MsgBoxStyle.Information, "Successfully Added")
                Me.txtdesc.Text = ""
                Me.cboexamination.SelectedIndex = 0
                Prescription.RefreshPara()
            Else
                If MsgBox("Are you sure you want to update this para clinic examination?", MsgBoxStyle.YesNo, "Confirm Update") = MsgBoxResult.Yes Then
                    DA_PrePara.UpdatePara(Prescription.lblpatientId.Text, CInt(Me.cboexamination.SelectedValue.ToString), ServiceCharge, Me.txtdesc.Text.ToString.Replace("'", "''"), Prescription.ParaList.CurrentRow.Cells("preid").Value)
                    MsgBox("The para clinic examination was updated", MsgBoxStyle.Information, "Successfully Updated")
                    Prescription.RefreshPara()
                    Me.Close()
                End If
            End If
        Else
            If lblaction.Text = 0 Then
                DA_ParaDetail.InsertPara(CInt(Me.cboexamination.SelectedValue.ToString), PreHistory.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value, ServiceCharge, Me.txtdesc.Text.ToString.Replace("'", "''"))
                MsgBox("One para clinic examination was added", MsgBoxStyle.Information, "Successfully Added")
                Me.txtdesc.Text = ""
                Me.cboexamination.SelectedIndex = 0
                PreHistory.RefreshPara()
            Else
                If MsgBox("Are you sure you want to update this para clinic examination?", MsgBoxStyle.YesNo, "Confirm Update") = MsgBoxResult.Yes Then
                    DA_ParaDetail.UpdatePara(CInt(Me.cboexamination.SelectedValue.ToString), PreHistory.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value, ServiceCharge, Me.txtdesc.Text.ToString.Replace("'", "''"), PreHistory.ParaList.CurrentRow.Cells("paracheckdetailid").Value)
                    MsgBox("The para clinic examination was updated", MsgBoxStyle.Information, "Successfully Updated")
                    PreHistory.RefreshPara()
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub ParaClinic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class