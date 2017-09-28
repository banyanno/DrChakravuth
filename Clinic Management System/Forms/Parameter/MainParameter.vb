Public Class MainParameter
    Dim DA_Physical As New DSPAtientTableAdapters.tblPhysicalCheckTableAdapter
    Dim DA_Doctor As New DSPAtientTableAdapters.DoctorsTableAdapter
    Dim DA_ConsultType As New DSPAtientTableAdapters.tblConsultTypeTableAdapter
    Dim DA_Para As New DSPAtientTableAdapters.tblparacheckTableAdapter
    Dim DA_Complaint As New DSPAtientTableAdapters.tblcomplaintTableAdapter
    Dim DA_Symptom As New DSPAtientTableAdapters.SymptomsTableAdapter
    Dim DA_BloodCheck As New DSExaminationTableAdapters.tblblooditemTableAdapter
    Dim DA_Conclustion As New DSExaminationTableAdapters.tblconclusionTableAdapter
    Dim DA_Presc_Usage As New DS_PrescriptionTableAdapters.PRESCRIPTION_USAGETableAdapter


    ' ''''''''''''''''''''''''''
    Dim DA_ConclustionOFColoscopy As New DS_ParameterTableAdapters.tblConclusionOfColoscopyTableAdapter
    Dim DA_MotifColoscopy As New DS_ParameterTableAdapters.tblMotiveOfColoscopyTableAdapter
    Dim DA_MotifFibroAndNaso As New DS_ParameterTableAdapters.tblMotiveOfFibroAnaNasoTableAdapter
    Dim DA_KeyWord As New DS_ParameterTableAdapters.KEY_WORDTableAdapter
    Dim DA_History As New DSPAtientTableAdapters.tblhistoryTableAdapter

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MsgBox("Are you sure you want to delete this physical examination?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DA_Physical.DeletePhysical(Me.PhysicalList.CurrentRow.Cells("physicalcheckid").Value)
            RefreshPhysicalExam()
        End If
    End Sub
#Region "ModRefresh"
    Sub RefreshPhysicalExam()
        Me.PhysicalList.DataSource = DA_Physical.SelectPhysical
    End Sub
    Sub RefreshMotif()
        Me.GridMotif.DataSource = DA_MotifFibroAndNaso.GetData
    End Sub
    Sub RefreshPresUsage()
        Me.GridPrescUsage.DataSource = DA_Presc_Usage.GetData
    End Sub
    Sub RefreshDoctorInfo()
        Me.DoctorList.DataSource = DA_Doctor.SelectDoctor
    End Sub
    Sub RefreshConsultType()
        ConsultTypeList.DataSource = DA_ConsultType.SelectConsultationTypes
    End Sub
    Sub RefreshDataParaExam()
        ParaList.DataSource = DA_Para.SelectPara
    End Sub
    Sub RefreshDataPatientComplaints()
        Me.ComplaintList.DataSource = DA_Complaint.SelectComplaints
    End Sub
   
    Sub RefreshBloodCheck()
        GridBloodCheck.DataSource = DA_BloodCheck.GetData()
    End Sub
    Sub RefreshConclustion()
        GridConclusion.DataSource = DA_Conclustion.GetData
    End Sub
    Sub RefreshDiagnosis()
        GridDiagnosis.DataSource = DA_Diagnosis.GetData
    End Sub
    Sub RefreshConclustionOfColoscopy()
        GridConclusionOfColoscopy.DataSource = DA_ConclustionOFColoscopy.GetData
    End Sub
    Sub RefreshMotifColoscopy()
        GridMotifColoscopy.DataSource = DA_MotifColoscopy.GetData
    End Sub
    Sub RefreshKeyWord()
        GridKeyword.DataSource = DA_KeyWord.GetData
    End Sub
    Sub RefreshMedicalHistory()
        GridMedicalHistory.DataSource = DA_History.GetData
    End Sub
#End Region
    Sub LoadAllPararmeter()
        RefreshPhysicalExam()
        RefreshDoctorInfo()
        RefreshConsultType()
        RefreshDataParaExam()
        RefreshDataPatientComplaints()
        RefreshBloodCheck()
        RefreshConclustion()
        RefreshDiagnosis()
        RefreshPresUsage()
        RefreshMotif()
        RefreshConclustionOfColoscopy()
        RefreshMotifColoscopy()
        RefreshKeyWord()
        RefreshMedicalHistory()
    End Sub
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Dim Doc As New NewDoctor(Me)
        Doc.lblaction.Text = 0
        Doc.lblaction.Text = 0
        Doc.ShowDialog()
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Dim Doc As New NewDoctor(Me)
        Doc.lblaction.Text = 1
        Doc.txtname.Text = DoctorList.CurrentRow.Cells("Doctor_Name").Value
        Doc.txtphone.Text = DoctorList.CurrentRow.Cells("Phone").Value
        Doc.txtdesc.Text = DoctorList.CurrentRow.Cells("Other_Info").Value
        Doc.ShowDialog()
    End Sub

    Private Sub ToolStripButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton13.Click
        If MsgBox("Are you sure you want to delete this doctor?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DA_Doctor.DeleteDoctor(DoctorList.CurrentRow.Cells("Doctor_ID").Value)
            RefreshDoctorInfo()
        End If
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Dim TypeForm As New NewConsultationType(Me)
        TypeForm.LblSaveOption.Text = 0
        TypeForm.ShowDialog()
    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        Dim TypeForm As New NewConsultationType(Me)
        TypeForm.LblSaveOption.Text = 1
        TypeForm.TxtConsultName.Text = Me.ConsultTypeList.CurrentRow.Cells("consulttypename").Value
        TypeForm.TxtConsultPrice.Text = Me.ConsultTypeList.CurrentRow.Cells("price").Value
        TypeForm.ShowDialog()
    End Sub

    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton9.Click
        If MsgBox("Are you sure you want to delete this consultation type?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DA_ConsultType.DeleteConsultType(Me.ConsultTypeList.CurrentRow.Cells("consulttypeid").Value)
            RefreshConsultType()
        End If
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Dim TypeForm As New NewParaClinicExam(Me)
        TypeForm.LblSaveOption.Text = 0
        TypeForm.ShowDialog()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Dim TypeForm As New NewParaClinicExam(Me)
        TypeForm.LblSaveOption.Text = 1
        TypeForm.TxtParaName.Text = Me.ParaList.CurrentRow.Cells("paracheck").Value
        TypeForm.TxtParaPrice.Text = Me.ParaList.CurrentRow.Cells("servicecharge").Value
        TypeForm.ShowDialog()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        If MsgBox("Are you sure you want to delete this para clinic examination?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DA_Para.DeletePara(Me.ParaList.CurrentRow.Cells("paracheckid").Value)
            RefreshDataPatientComplaints()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim ComplaintForm As New NewPatientComplaint(Me)
        ComplaintForm.LblSaveOption.Text = 0
        ComplaintForm.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim ComplaintForm As New NewPatientComplaint(Me)
        ComplaintForm.LblSaveOption.Text = 1
        ComplaintForm.TxtComplaintName.Text = Me.ComplaintList.CurrentRow.Cells("complaint").Value
        ComplaintForm.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        If MsgBox("Are you sure you want to delete this patient complaint?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DA_Complaint.DeleteComplaint(Me.ComplaintList.CurrentRow.Cells("complaintid").Value)
            RefreshDataPatientComplaints()
        End If
    End Sub

    Private Sub ToolStripButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Sym As New NewSymptom(Me)
        Sym.ShowDialog()
    End Sub

    'Private Sub ToolStripButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim Sym As New EditSymptom(Me)
    '    Sym.txtname.Text = SymptomList.CurrentRow.Cells(1).Value
    '    Sym.txtid.Text = SymptomList.CurrentRow.Cells(0).Value
    '    Sym.ShowDialog()
    'End Sub

    'Private Sub ToolStripButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If MsgBox("Are you sure you want to delete this symptom?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '        DA_Symptom.DeleteSymptom(SymptomList.CurrentRow.Cells(0).Value)
    '        RefreshSymptom()
    '    End If
    'End Sub

    Private Sub BtnNewBlood_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewBlood.Click
        Dim NewBloodCheck As New FormBlood
        If NewBloodCheck.ShowDialog = DialogResult.OK Then
            RefreshBloodCheck()
        End If
    End Sub

    Private Sub BtnUpdateBlood_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateBlood.Click
        If GridBloodCheck.SelectedItems.Count = 0 Then Exit Sub
        Dim NewBloodCheck As New FormBlood
        NewBloodCheck.LblSaveOption.Text = GridBloodCheck.GetRow.Cells("item_id").Value
        NewBloodCheck.TxtBlood.Text = GridBloodCheck.GetRow.Cells("item_name").Value
        If NewBloodCheck.ShowDialog = DialogResult.OK Then
            RefreshBloodCheck()
        End If
    End Sub

    Private Sub BtnDeleteBlood_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteBlood.Click
        If GridBloodCheck.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want delete blood check", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_BloodCheck.DeleteBloodCheck(GridBloodCheck.GetRow.Cells("item_id").Value) = 1 Then
                MessageBox.Show("Delete success fully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshBloodCheck()
            End If
        End If
    End Sub

    Private Sub BtnNewConclustion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewConclustion.Click
        Dim NConclustion As New FormConclustion
        If NConclustion.ShowDialog = DialogResult.OK Then
            RefreshConclustion()
        End If
    End Sub

   

    Private Sub BtnDeleteConclustion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteConclustion.Click
        If GridConclusion.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete conclustion.", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_Conclustion.DeleteConclusion(GridConclusion.GetRow.Cells("conclusion_id").Value) = 1 Then
                MessageBox.Show("Delete conclusion successfuly.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshConclustion()
            End If
        End If
    End Sub

    Private Sub BtnUpdateConclustion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateConclustion.Click
        If GridConclusion.SelectedItems.Count = 0 Then Exit Sub
        Dim NConclustion As New FormConclustion
        NConclustion.LblSaveOption.Text = GridConclusion.GetRow.Cells("conclusion_id").Value
        NConclustion.TxtConclusion.Text = GridConclusion.GetRow.Cells("conclusion_name").Value
        If NConclustion.ShowDialog = DialogResult.OK Then
            RefreshConclustion()
        End If
    End Sub

    'For Diagnosis Parameter
    Dim DA_Diagnosis As New DSPAtientTableAdapters.tbldiagnosisTableAdapter


    
    Private Sub ToolStripButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton10.Click
        Dim Diagnosis As New NewDiagnosis
        If Diagnosis.ShowDialog = DialogResult.OK Then
            RefreshDiagnosis()
        End If
    End Sub

    Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton11.Click
        If GridDiagnosis.SelectedItems.Count = 0 Then Exit Sub
        Dim Diagnosis As New NewDiagnosis
        Diagnosis.txtDiagnosis.Text = GridDiagnosis.GetRow.Cells("diagnosis").Value
        Diagnosis.lblSaveOption.Text = GridDiagnosis.GetRow.Cells("diagnosisid").Value
        If Diagnosis.ShowDialog = DialogResult.OK Then
            RefreshDiagnosis()
        End If
    End Sub

    Private Sub BtnRefresh_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        RefreshDiagnosis()
    End Sub

    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click
        If GridDiagnosis.SelectedItems.Count = 0 Then Exit Sub
        If DA_Diagnosis.DeleteDiagnosis(GridDiagnosis.GetRow.Cells("diagnosisid").Value) = 1 Then
            RefreshDiagnosis()
        End If
    End Sub

    Private Sub BtnRefreshUsage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefreshUsage.Click
        RefreshPresUsage()
    End Sub

    Private Sub BtnNewUsage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewUsage.Click
        Dim FUsage As New FormNewPrescriptionUsage
        If FUsage.ShowDialog = DialogResult.OK Then
            RefreshPresUsage()
        End If
    End Sub

    Private Sub BtnUpdateUsage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateUsage.Click
        If GridPrescUsage.SelectedItems.Count = 0 Then Exit Sub
        Dim FUsage As New FormNewPrescriptionUsage
        FUsage.LblSaveOption.Text = GridPrescUsage.GetRow.Cells("USAGE_ID").Value
        FUsage.TextBox1.Text = GridPrescUsage.GetRow.Cells("USAGE").Value
        If FUsage.ShowDialog = DialogResult.OK Then
            RefreshPresUsage()
        End If
    End Sub

    Private Sub BtnDeleteUsage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteUsage.Click
        If GridPrescUsage.SelectedItems.Count = 0 Then Exit Sub
        If DA_Presc_Usage.DeleteUsage(GridPrescUsage.GetRow.Cells("USAGE_ID").Value) = 1 Then
            RefreshPresUsage()
        End If
    End Sub

    Private Sub BtnNewMotif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewMotif.Click
        Dim FMotif As New FormMotif
        If FMotif.ShowDialog() = DialogResult.OK Then
            GridMotif.DataSource = DA_MotifFibroAndNaso.SelectByName(FMotif.TextBox1.Text)
        End If
    End Sub

    Private Sub BtnUpdatMotif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdatMotif.Click
        If GridMotif.SelectedItems.Count = 0 Then Exit Sub
        Dim FMotif As New FormMotif
        FMotif.LblSaveOption.Text = GridMotif.GetRow.Cells("MotiveID").Value
        FMotif.TextBox1.Text = GridMotif.GetRow.Cells("Motive").Value
        If FMotif.ShowDialog() = DialogResult.OK Then
            GridMotif.DataSource = DA_MotifFibroAndNaso.SelectByID(FMotif.LblSaveOption.Text)
        End If
    End Sub

    Private Sub BtnRefreshMotif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefreshMotif.Click
        RefreshMotif()
    End Sub

    Private Sub BtnDeleteMotif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteMotif.Click
        If GridMotif.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete this motif?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'DA_Motif.DeleteMotif(GridMotif.GetRow.Cells("motify_id").Value)
            'RefreshMotif()
            If DA_MotifFibroAndNaso.DeleteMotifFibroAndNaso(GridMotif.GetRow.Cells("MotiveID").Value) = 1 Then
                RefreshMotif()
            End If
        End If
    End Sub

   
    Private Sub BtnNewConNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewConNew.Click
        Dim FConclusiontOFColo As New FormConclusionOfColo
        If FConclusiontOFColo.ShowDialog() = DialogResult.OK Then
            GridConclusionOfColoscopy.DataSource = DA_ConclustionOFColoscopy.SelectByName(FConclusiontOFColo.TxtConclosionColoscopy.Text)
        End If
    End Sub

    Private Sub BtnUpdateCol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateCol.Click
        If GridConclusionOfColoscopy.SelectedItems.Count = 0 Then Exit Sub
        Dim FConclusiontOFColo As New FormConclusionOfColo
        FConclusiontOFColo.LblSaveOption.Text = GridConclusionOfColoscopy.GetRow.Cells("ConclusionID").Value
        FConclusiontOFColo.TxtConclosionColoscopy.Text = GridConclusionOfColoscopy.GetRow.Cells("Conclusion").Value
        If FConclusiontOFColo.ShowDialog() = DialogResult.OK Then
            GridConclusionOfColoscopy.DataSource = DA_ConclustionOFColoscopy.SelectByConclusID(FConclusiontOFColo.LblSaveOption.Text)
        End If
    End Sub

    Private Sub BtnRefreshColo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefreshColo.Click
        RefreshConclustionOfColoscopy()
    End Sub

    Private Sub BtnDeleteColo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteColo.Click
        If GridConclusionOfColoscopy.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete conclustion of coloscopy?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_ConclustionOFColoscopy.DeleteCoclusionColo(GridConclusionOfColoscopy.GetRow.Cells("ConclusionID").Value) = 1 Then
                RefreshConclustionOfColoscopy()
            End If
        End If
    End Sub

    Private Sub ToolStripButton20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton20.Click

        Dim FMotifColo As New FormMotifOfColoscopy
        If FMotifColo.ShowDialog = DialogResult.OK Then
            GridMotifColoscopy.DataSource = DA_MotifColoscopy.SelectByName(FMotifColo.TxtMotifOfColoscopy.Text)
        End If
    End Sub

    Private Sub ToolStripButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton22.Click
        RefreshMotifColoscopy()
    End Sub

    Private Sub ToolStripButton23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton23.Click
        If GridMotifColoscopy.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want delete Motif Coloscopy?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_MotifColoscopy.DeleteMotifColo(GridMotifColoscopy.GetRow.Cells("MotiveID").Value) Then
                RefreshMotifColoscopy()
            End If
        End If
    End Sub

    Private Sub ToolStripButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton21.Click
        If GridMotifColoscopy.SelectedItems.Count = 0 Then Exit Sub
        Dim FMotifColo As New FormMotifOfColoscopy
        FMotifColo.LblSaveOption.Text = GridMotifColoscopy.GetRow.Cells("MotiveID").Value
        FMotifColo.TxtMotifOfColoscopy.Text = GridMotifColoscopy.GetRow.Cells("Motive").Value
        If FMotifColo.ShowDialog = DialogResult.OK Then
            GridMotifColoscopy.DataSource = DA_MotifColoscopy.SelectByID(FMotifColo.LblSaveOption.Text)
        End If
    End Sub

    Private Sub BtnRefreshConclusionFibro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefreshConclusionFibro.Click
        RefreshConclustion()
    End Sub

    Private Sub BtnNewKeyWord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewKeyWord.Click
        Dim KeyWord As New KeyWord
        If KeyWord.ShowDialog = DialogResult.OK Then
            RefreshKeyWord()
        End If
    End Sub

    Private Sub BtnUpdateKeyWord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateKeyWord.Click
        If GridKeyword.SelectedItems.Count = 0 Then Exit Sub
        Dim KeyWord As New KeyWord
        KeyWord.lblSave.Text = GridKeyword.GetRow.Cells("KEYWORD_ID").Value
        KeyWord.TxtKeyWord.Text = GridKeyword.GetRow.Cells("KEY_VALUES").Value
        If KeyWord.ShowDialog = DialogResult.OK Then
            RefreshKeyWord()
        End If
    End Sub

    Private Sub BtnRefreshKeyWord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefreshKeyWord.Click
        RefreshKeyWord()
    End Sub

    Private Sub BtnDeleteKeyWord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteKeyWord.Click
        If GridKeyword.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete key word", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_KeyWord.DeleteKeyWord(GridKeyword.GetRow.Cells("KEYWORD_ID").Value) = 1 Then
                RefreshKeyWord()
            End If
        End If
    End Sub

    Private Sub BtnNewMedicalHistoy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewMedicalHistoy.Click
        Dim NMedicalHistory As New NewMedicalHistory
        If NMedicalHistory.ShowDialog = DialogResult.OK Then
            RefreshMedicalHistory()
        End If
    End Sub

    Private Sub BtnDeleteMedicalHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteMedicalHistory.Click
        If GridMedicalHistory.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete this medical history?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_History.DeleteHistory(GridMedicalHistory.GetRow.Cells("historyid").Value) = 1 Then
                RefreshMedicalHistory()
            End If
        End If
    End Sub

    Private Sub BtnUpdateMedicalHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateMedicalHistory.Click
        If GridMedicalHistory.SelectedItems.Count = 0 Then Exit Sub
        Dim NMedicalHistory As New NewMedicalHistory
        NMedicalHistory.LblSaveOption.Text = GridMedicalHistory.GetRow.Cells("historyid").Value
        NMedicalHistory.TxtHistoryName.Text = GridMedicalHistory.GetRow.Cells("history").Value
        If NMedicalHistory.ShowDialog = DialogResult.OK Then
            RefreshMedicalHistory()
        End If
    End Sub

    Private Sub BtnRefreshMedicalHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefreshMedicalHistory.Click
        RefreshMedicalHistory()
    End Sub
End Class
