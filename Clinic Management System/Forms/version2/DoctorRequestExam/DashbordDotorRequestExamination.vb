Public Class DashbordDotorRequestExamination
    Dim DA_Motify As New DSExaminationTableAdapters.tblmotifyTableAdapter
    Dim DA_Doctor As New DSPAtientTableAdapters.DoctorsTableAdapter
    Dim DA_Preparation As New DSExaminationTableAdapters.tblpreparationTableAdapter
    Dim DA_FibroConclusion As New DSExaminationTableAdapters.tblfibroconclusionTableAdapter
    Dim DA_NasoConclusion As New DSExaminationTableAdapters.tblnasoconclusionTableAdapter
    Dim DA_ColoConclusion As New DSExaminationTableAdapters.tblcoloconclusionTableAdapter
    Dim DA_EchoConclusion As New DSExaminationTableAdapters.tblechoconclusionTableAdapter

    Dim DA_Request As New DSExaminationTableAdapters.tblrequestTableAdapter
    Dim DA_Fibro As New DSExaminationTableAdapters.tblfibroscopyTableAdapter
    Dim DA_Naso As New DSExaminationTableAdapters.tblnasogastroTableAdapter
    Dim DA_Colo As New DSExaminationTableAdapters.tblcoloscopyTableAdapter
    Dim DA_Echo As New DSExaminationTableAdapters.tblechoTableAdapter
    Dim DA_ItemResult As New DSExaminationTableAdapters.tblrequestblooditemTableAdapter

    Dim DA_Scan As New DSExaminationTableAdapters.tblscanTableAdapter
    Dim DA_FibroScan As New DSExaminationTableAdapters.tblfibroscanTableAdapter
    Dim DA_MRI As New DSExaminationTableAdapters.tblmriTableAdapter
    Dim DA_Anapath As New DSExaminationTableAdapters.tblCFAnaPathTableAdapter

    Dim DA_BloodResult As New DSExaminationTableAdapters.tblrequestblooditemTableAdapter
    '==================== Physical Examination ================================
    Dim DA_Physical As New DSPhysicalExamTableAdapters.tblPhysicalCheckTableAdapter
    Dim DA_PhysicalDetail As New DSPhysicalExamTableAdapters.tblphysicalcheckdetailTableAdapter
    Dim DA_V_PhysicalDetail As New DSPhysicalExamTableAdapters.V_PHYSICAL_EXAMTableAdapter

    Dim DA_BreathTest As New DSExaminationTableAdapters.TblBreathTestTableAdapter

    Dim VALUE_LOADING_DATA As Integer



    Dim DA_PrescriptionRemark As New DSInvoiceTableAdapters.PrescriptionRemarkTableAdapter
    Dim DA_Complaint As New DSInvoiceTableAdapters.ComplaintTableAdapter
    Dim DA_History As New DSInvoiceTableAdapters.HistoryTableAdapter
    Dim DA_Prescription As New DSInvoiceTableAdapters.PrescriptionDetailTableAdapter
    Dim DA_Biology As New DSInvoiceTableAdapters.BloodTableAdapter
    Dim DA_Fibroscopy As New DSInvoiceTableAdapters.FibroTableAdapter
    Dim DA_Coloscopy As New DSInvoiceTableAdapters.ColoTableAdapter
    Dim DA_Nasogastro As New DSInvoiceTableAdapters.NasoTableAdapter
    Dim DA_Echo1 As New DSInvoiceTableAdapters.EchoTableAdapter
    Dim DA_MRI1 As New DSInvoiceTableAdapters.MRITableAdapter
    Dim DA_Physical1 As New DSInvoiceTableAdapters.PhysicalExamTableAdapter
    Dim DA_CFAnaPath As New DSExaminationTableAdapters.CFAnaPathTableAdapter

    Dim DA_Patient As New DSPAtientTableAdapters.tblpatientTableAdapter
    Dim DAPatient As New DSPAtientTableAdapters.tblpatientTableAdapter

    Dim DA_Scan1 As New DSInvoiceTableAdapters.ScanTableAdapter
    Dim DA_FibroScan1 As New DSInvoiceTableAdapters.FibroScan1TableAdapter




    ' Check statsus
    Dim DA_BiologyStutus As New DSExaminationTableAdapters.tblrequestblooditemTableAdapter
    Dim DA_FibroStutus As New DSExaminationTableAdapters.tblfibroscopyTableAdapter
    Dim DA_NasoStutus As New DSExaminationTableAdapters.tblnasogastroTableAdapter
    Dim DA_ColoStutus As New DSExaminationTableAdapters.tblcoloscopyTableAdapter
    Dim DA_EchoStutus As New DSExaminationTableAdapters.tblechoTableAdapter
    Dim DA_ItemResultStutus As New DSExaminationTableAdapters.tblrequestblooditemTableAdapter
    Dim DA_ScanStutus As New DSExaminationTableAdapters.tblscanTableAdapter
    Dim DA_FibroScanStutus As New DSExaminationTableAdapters.tblfibroscanTableAdapter
    Dim DA_MRIStutus As New DSExaminationTableAdapters.tblmriTableAdapter


    Dim DA_EchoImage As New DSEchoTableAdapters.tblpatientTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub BtnNewDoctorRequestExam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DocRequestExam As New MainDocRequestExam
        DocRequestExam.ShowDialog()
    End Sub
    Function CheckExamination(ByVal CheckFieldName As String) As Boolean
        Dim IsChecked As Boolean = False
        If Me.gridRequestList.RowCount >= 1 Then
            Dim RequestTable As New DataTable
            RequestTable = DA_Request.SelectRequestByID(CInt(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
            IsChecked = RequestTable.Rows(0).Item(CheckFieldName)
        End If
        Return IsChecked
    End Function




    Private Sub DashbordDotorRequestExamination_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '' Loading patient waiting Examination....
        MainApplicationForm.StatusLoading(True)
        VALUE_LOADING_DATA = 1
        Application.DoEvents()
        BgLoadData.RunWorkerAsync()

    End Sub
    Sub LoadFibroData()
        Try
            If DA_Fibro.SelectFibroByRequestID(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value)).Rows.Count >= 1 Then
                Dim FibroTable As New DataTable
                FibroTable = DA_Fibro.SelectFibroByRequestID(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
                Me.cboFibroDemander.Text = FibroTable.Rows(0).Item("demander")
                Me.txtFibroTolerance.Text = FibroTable.Rows(0).Item("tolerance")
                Me.chkFibroAnesthegiste.Checked = FibroTable.Rows(0).Item("is_anesthegiste")
                Me.cboFibroAnesthegiste.Text = FibroTable.Rows(0).Item("anesthegiste")
                Me.cboFibroMotify.Text = FibroTable.Rows(0).Item("motify")
                Me.txtFibroOeso.Text = FibroTable.Rows(0).Item("oesophage")
                Me.txtFibroEsto.Text = FibroTable.Rows(0).Item("estomac")
                Me.txtFibroLac.Text = FibroTable.Rows(0).Item("lac_muqueux")
                Me.txtFibroGrosse.Text = FibroTable.Rows(0).Item("grosse_tub")
                Me.txtFibroD1.Text = FibroTable.Rows(0).Item("d1_de_d2")
                Me.txtFibroPylore.Text = FibroTable.Rows(0).Item("pylore")
                Me.txtFibroFundus.Text = FibroTable.Rows(0).Item("fundus")
                Me.txtFibroAntre.Text = FibroTable.Rows(0).Item("antre")
                Me.txtFibroBulbe.Text = FibroTable.Rows(0).Item("bulbe")
                If FibroTable.Rows(0).Item("cf") = "" Then
                    ChAnaPath.Checked = False
                Else
                    ChAnaPath.Checked = True
                End If

                TxtFibroIntroduction.Text = FibroTable.Rows(0).Item("Introduction")
                TxtFibroIndication.Text = FibroTable.Rows(0).Item("Indication")
                TxtFibroMedication.Text = FibroTable.Rows(0).Item("Medication")
                TxtFibroFentanyl.Text = FibroTable.Rows(0).Item("Fentanyl")
                TxtFibroPropfol.Text = FibroTable.Rows(0).Item("Propofol")
                TxtFibroXylocainegel.Text = FibroTable.Rows(0).Item("Xylocainegel")
                txtFibroEsto.Text = FibroTable.Rows(0).Item("Esophagus")
                TxtfibroStomach.Text = FibroTable.Rows(0).Item("StomachandDuodenum")
                TxtFibroAssessment.Text = FibroTable.Rows(0).Item("Assessment")
                'Me.txtFibroCF.Text = FibroTable.Rows(0).Item("cf")
                Me.cboFibroDocteur.Text = FibroTable.Rows(0).Item("docteur")
                cboFibroDoctor.Text = FibroTable.Rows(0).Item("docteur")
                Me.txtfibromoreinfo.Text = FibroTable.Rows(0).Item("more_info")

                ''Load Conclusion Data
                Me.FibroConclusionList.DataSource = DA_FibroConclusion.SelectConclusionByRequestID(CInt(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
                conclusionlist.DataSource = DA_FibroConclusion.SelectConclusionByRequestID(CInt(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
            Else
                Me.FibroConclusionList.DataSource = DA_FibroConclusion.SelectConclusionByRequestID(CInt(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
                conclusionlist.DataSource = DA_FibroConclusion.SelectConclusionByRequestID(CInt(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
            End If
        Catch ex As Exception
            Me.FibroConclusionList.DataSource = DA_FibroConclusion.SelectConclusionByRequestID(CInt(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
            conclusionlist.DataSource = DA_FibroConclusion.SelectConclusionByRequestID(CInt(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
            ' MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub LoadNasoData()
        Try
            If gridRequestList.SelectedItems.Count = 0 Then Exit Sub
            If DA_Naso.SelectNasoByRequestID(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value)).Rows.Count >= 1 Then
                Dim NasoTable As New DataTable
                NasoTable = DA_Naso.SelectNasoByRequestID(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
                Me.cboNasoDemander.Text = NasoTable.Rows(0).Item("demander")
                Me.txtNasoTolerance.Text = NasoTable.Rows(0).Item("tolerance")
                Me.cboNasoMotify.Text = NasoTable.Rows(0).Item("motify")
                Me.txtNasoOeso.Text = NasoTable.Rows(0).Item("oesophage")
                Me.txtNasoEsto.Text = NasoTable.Rows(0).Item("estomac")
                If TypeOf NasoTable.Rows(0).Item("Lacmuqueux") Is DBNull Then
                    Me.TxtLacMuquex.Text = ""
                Else
                    Me.TxtLacMuquex.Text = NasoTable.Rows(0).Item("Lacmuqueux")
                End If
                If TypeOf NasoTable.Rows(0).Item("Grossetuberosite") Is DBNull Then
                    Me.TxtGrosseTuberose.Text = ""
                Else
                    Me.TxtGrosseTuberose.Text = NasoTable.Rows(0).Item("Grossetuberosite")
                End If
                If TypeOf NasoTable.Rows(0).Item("Fundus") Is DBNull Then
                    Me.TxtFundus.Text = ""
                Else
                    Me.TxtFundus.Text = NasoTable.Rows(0).Item("Fundus")
                End If
                If TypeOf NasoTable.Rows(0).Item("Antre") Is DBNull Then
                    Me.TxtAntre.Text = ""
                Else
                    Me.TxtAntre.Text = NasoTable.Rows(0).Item("Antre")
                End If

                Me.txtNasoPylore.Text = NasoTable.Rows(0).Item("pylore")
                Me.txtNasoBulbe.Text = NasoTable.Rows(0).Item("bulbe")
                Me.txtNasoD1.Text = NasoTable.Rows(0).Item("d1_de_d2")
                If NasoTable.Rows(0).Item("cf") = "" Then
                    chNanoAnapath.Checked = False
                Else
                    chNanoAnapath.Checked = True
                End If
                'IIf(NasoTable.Rows(0).Item("cf") = "", chNanoAnapath.Checked = False, chNanoAnapath.Checked = True)
                'Me.txtNasoCF.Text = NasoTable.Rows(0).Item("cf")
                Me.cboNasoDocteur.Text = NasoTable.Rows(0).Item("docteur")
                Me.txtnasomoreinfo.Text = NasoTable.Rows(0).Item("more_info")

                ''Load Conclusion Data
                Me.NasoConclusionList.DataSource = DA_NasoConclusion.SelectConclusionByRequestID(CInt(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
            Else
                Me.NasoConclusionList.DataSource = DA_NasoConclusion.SelectConclusionByRequestID(CInt(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
            End If
        Catch ex As Exception

        End Try

    End Sub
    Sub LoadColoData()
        Try
            If DA_Colo.SelectColoByRequestID(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value)).Rows.Count >= 1 Then
                Dim ColoTable As New DataTable
                ColoTable = DA_Colo.SelectColoByRequestID(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
                Me.txtColoDuree.Text = ColoTable.Rows(0).Item("duree")
                Me.txtColoEva.Text = ColoTable.Rows(0).Item("eva")
                Me.cboColoPreparation.Text = ColoTable.Rows(0).Item("preparation")
                Me.cboColoDemander.Text = ColoTable.Rows(0).Item("demander")
                Me.txtColoTolerance.Text = ColoTable.Rows(0).Item("tolerance")
                Me.chkColoAnesthegiste.Checked = ColoTable.Rows(0).Item("is_anethegiste")
                Me.cboColoAnesthegiste.Text = ColoTable.Rows(0).Item("anethegiste")
                Me.cboColoMotify.Text = ColoTable.Rows(0).Item("motiy")
                If TypeOf ColoTable.Rows(0).Item("new_field") Is DBNull Then
                    Me.txtColoNewField.Text = ""
                Else
                    Me.txtColoNewField.Text = ColoTable.Rows(0).Item("new_field")
                End If
                TxtIntroduction.Text = ColoTable.Rows(0).Item("Introduction")
                TxtIndication.Text = ColoTable.Rows(0).Item("Indication")
                txtFentanyL.Text = ColoTable.Rows(0).Item("Fentanyl")
                TxtPropofol.Text = ColoTable.Rows(0).Item("Propofol")
                TxtXylocainegel.Text = ColoTable.Rows(0).Item("Xylocainegel")
                TxtRecalExam.Text = ColoTable.Rows(0).Item("Rectalexam")
                TxtFinding.Text = ColoTable.Rows(0).Item("Finding")
                TxtImpression.Text = ColoTable.Rows(0).Item("Impression")
                Me.txtColoCaecum.Text = ColoTable.Rows(0).Item("caecum")
                Me.txtColoColonDroit.Text = ColoTable.Rows(0).Item("colon_droit")
                Me.txtColoColonTransverse.Text = ColoTable.Rows(0).Item("colon_transverse")
                Me.txtColonGauche.Text = ColoTable.Rows(0).Item("colon_gauche")
                Me.txtColoSigmoide.Text = ColoTable.Rows(0).Item("sigmoide")
                Me.txtColoRectum.Text = ColoTable.Rows(0).Item("rectum")
                Me.cboColoDocteur.Text = ColoTable.Rows(0).Item("docteur")
                Me.CboColoDoctorEng.Text = ColoTable.Rows(0).Item("docteur")
                Me.txtcolomoreinfo.Text = ColoTable.Rows(0).Item("more_info")
                TxtMoreEng.Text = ColoTable.Rows(0).Item("more_info")
                ''Load Conclusion Data
                Me.ColoConclusionList.DataSource = DA_ColoConclusion.SelectConclusionByRequestID(CInt(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
                ConclusionListEng.DataSource = DA_ColoConclusion.SelectConclusionByRequestID(CInt(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
            Else
                Me.ColoConclusionList.DataSource = DA_ColoConclusion.SelectConclusionByRequestID(CInt(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
                ConclusionListEng.DataSource = DA_ColoConclusion.SelectConclusionByRequestID(CInt(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
            End If
        Catch ex As Exception

        End Try

    End Sub



    Sub LoadEchoData()
        'Try
        If gridRequestList.SelectedItems.Count = 0 Then Exit Sub
        If DA_Echo.SelectEchoByRequestID(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value)).Rows.Count >= 1 Then
            Dim EchoTable As New DataTable
            EchoTable = DA_Echo.SelectEchoByRequestID(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
            Me.cboEchoDemander.Text = EchoTable.Rows(0).Item("demander")
            Me.TxtExamByDR.Text = EchoTable(0).Item("ExamBy")
            Me.txtEchoIndication.Text = EchoTable.Rows(0).Item("indication")
            Me.txtEchoLaProstate.Text = EchoTable.Rows(0).Item("la_prostate")
            Me.txtEchoLaRate.Text = EchoTable.Rows(0).Item("la_rate")
            Me.txtEchoLaVeine.Text = EchoTable.Rows(0).Item("la_veine")
            Me.txtEchoLaVesicule.Text = EchoTable.Rows(0).Item("la_vesicule")
            Me.txtEchoLaVessie.Text = EchoTable.Rows(0).Item("la_vessie")
            Me.txtEchoLeFoie.Text = EchoTable.Rows(0).Item("le_foie")
            Me.txtEchoLePancreas.Text = EchoTable.Rows(0).Item("le_pancreas")
            Me.txtEchoLesReins.Text = EchoTable.Rows(0).Item("les_reins")
            Me.txtEchoLesVoies.Text = EchoTable.Rows(0).Item("les_voies")
            Me.txtechomoreinfo.Text = EchoTable.Rows(0).Item("more_info")
            If TypeOf EchoTable.Rows(0).Item("ResultOfEcho") Is DBNull Then
            Else
                Me.TxtResult.Text = EchoTable.Rows(0).Item("ResultOfEcho")
            End If

            ''Load Conclusion Data
            Me.EchoConclusionList.DataSource = DA_EchoConclusion.SelectConclusionByRequestID(CInt(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
        Else
            Me.EchoConclusionList.DataSource = DA_EchoConclusion.SelectConclusionByRequestID(CInt(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
        End If
        'Catch ex As Exception

        'End Try

    End Sub
    Sub ClearBox()

        '' Clear Biology
        Me.cbodoctor.Text = ""
        Me.txtcheckdate.Text = ""

        '' Clear Fibro
        cboFibroDemander.Text = ""
        cboFibroDocteur.Text = ""
        cboFibroMotify.Text = ""
        cboFibroAnesthegiste.Text = ""
        Me.txtFibroTolerance.Text = ""
        Me.chkFibroAnesthegiste.Checked = False
        Me.txtFibroOeso.Text = ""
        Me.txtFibroEsto.Text = ""
        Me.txtFibroLac.Text = ""
        Me.txtFibroGrosse.Text = ""
        Me.txtFibroD1.Text = ""
        Me.txtFibroPylore.Text = ""
        Me.txtFibroFundus.Text = ""
        Me.txtFibroAntre.Text = ""
        Me.txtFibroBulbe.Text = ""
        Me.ChAnaPath.Checked = False
        Me.txtfibromoreinfo.Text = ""
        Me.FibroConclusionList.DataSource = Nothing

        '' Clear Naso
        cboNasoDemander.Text = ""
        cboNasoDocteur.Text = ""
        cboNasoMotify.Text = ""
        Me.txtNasoTolerance.Text = ""
        Me.txtNasoOeso.Text = ""
        Me.txtNasoEsto.Text = ""
        Me.txtNasoPylore.Text = ""
        Me.txtNasoBulbe.Text = ""
        Me.txtNasoD1.Text = ""
        chNanoAnapath.Checked = False
        Me.txtnasomoreinfo.Text = ""
        Me.txtnasomoreinfo.Text = ""
        Me.TxtCFAnaPath.Text = ""
        TxtGrosseTuberose.Text = ""
        TxtFundus.Text = ""
        TxtAntre.Text = ""
        Me.NasoConclusionList.DataSource = Nothing

        '' Clear Colo
        Me.cboColoAnesthegiste.Text = ""
        Me.cboColoDemander.Text = ""
        Me.cboColoDocteur.Text = ""
        Me.cboColoMotify.Text = ""
        Me.cboColoPreparation.Text = ""
        Me.txtColoDuree.Text = ""
        Me.txtColoEva.Text = ""
        Me.txtColoTolerance.Text = ""
        Me.chkColoAnesthegiste.Checked = False
        Me.txtColoCaecum.Text = ""
        Me.txtColoColonDroit.Text = ""
        Me.txtColoColonTransverse.Text = ""
        Me.txtColonGauche.Text = ""
        Me.txtColoSigmoide.Text = ""
        Me.txtColoRectum.Text = ""
        Me.txtcolomoreinfo.Text = ""
        txtColoNewField.Text = ""
        Me.ColoConclusionList.DataSource = Nothing
        Me.ConclusionListEng.DataSource = Nothing
        TxtIntroduction.Text = ""
        TxtIndication.Text = ""
        txtFentanyL.Text = ""
        TxtPropofol.Text = ""
        TxtXylocainegel.Text = ""
        TxtRecalExam.Text = ""
        TxtFinding.Text = ""
        TxtImpression.Text = ""
        '' Clear Echo
        Me.cboEchoDemander.Text = ""
        Me.txtEchoIndication.Text = ""
        Me.txtEchoLaProstate.Text = ""
        Me.txtEchoLaRate.Text = ""
        Me.txtEchoLaVeine.Text = ""
        Me.txtEchoLaVesicule.Text = ""
        Me.txtEchoLaVessie.Text = ""
        Me.txtEchoLeFoie.Text = ""
        Me.txtEchoLePancreas.Text = ""
        Me.txtEchoLesReins.Text = ""
        Me.txtEchoLesVoies.Text = ""
        Me.txtechomoreinfo.Text = ""
        Me.TxtResult.Text = ""
        Me.EchoConclusionList.DataSource = Nothing

        ''Clear Other
        Me.txtscan.Text = ""
        Me.txtmri.Text = ""
        Me.txtfibroscan.Text = ""
    End Sub
    Sub LoadScanData()
        Try
            If DA_Scan.SelectScanByRequestID(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value)).Rows.Count >= 1 Then
                Dim ScanTable As New DataTable
                ScanTable = DA_Scan.SelectScanByRequestID(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
                Me.txtscan.Text = ScanTable.Rows(0).Item("scan")
            End If
        Catch ex As Exception

        End Try

    End Sub
    Sub LoadFibroScanData()
        Try
            If DA_FibroScan.SelectFibroScanByRequestID(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value)).Rows.Count >= 1 Then
                Dim ScanTable As New DataTable
                ScanTable = DA_FibroScan.SelectFibroScanByRequestID(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
                Me.txtfibroscan.Text = ScanTable.Rows(0).Item("fibroscan")
            End If
        Catch ex As Exception

        End Try

    End Sub
    Sub LoadMRIData()
        Try
            If DA_MRI.SelectMRIByRequestID(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value)).Rows.Count >= 1 Then
                Dim MRITable As New DataTable
                MRITable = DA_MRI.SelectMRIByRequestID(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
                Me.txtmri.Text = MRITable.Rows(0).Item("mri")
            End If
        Catch ex As Exception

        End Try

    End Sub
    Sub LoadCFAnapath()
        Try
            'Dim CFAnapath As DataTable = DA_Anapath.GetDataByRequest_id(CLng(Me.RequestList.CurrentRow.Cells("request_id").Value))
            TxtCFAnaPath.Text = DA_Anapath.GetDataByRequest_id(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value)).Rows(0).Item(1)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadBreathTest()
        If gridRequestList.SelectedItems.Count = 0 Then Exit Sub
        Dim TblBreathTest As DataTable = DA_BreathTest.SelectBreathTestByID(CDbl(gridRequestList.GetRow.Cells("request_id").Value))
        If TblBreathTest.Rows.Count = 0 Then
            DateRequestBreath.Value = Now
            cboBreathRequestBy.Text = ""
            TxtBreathIndication.Text = ""
            TxtBreathResult.Text = ""
            CboBreathConclusion.Text = ""
            TxtBreathMoreInfo.Text = ""
        Else
            For Each rows As DataRow In TblBreathTest.Rows
                DateRequestBreath.Value = rows("DateTest")
                cboBreathRequestBy.Text = rows("RequestBy")
                TxtBreathIndication.Text = rows("Indication")
                TxtBreathResult.Text = rows("Result")
                CboBreathConclusion.Text = rows("Conclusion")
                TxtBreathMoreInfo.Text = rows("BreathTestNote")
            Next
        End If


    End Sub
    Sub LoadCheckBloodResult(ByVal RequestID As Integer)
        Try
            Dim TblRequest As New DataTable
            TblRequest = DA_Request.SelectRequestByID(RequestID)
            Me.cbodoctor.Text = TblRequest.Rows(0).Item("Doctor_ID")
            Me.txtcheckdate.Text = Format(TblRequest.Rows(0).Item("request_date"), "dd-MM-yyyy")
            Me.ItemResultList.DataSource = DA_ItemResult.SelectCheckItemByRequestID(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
        Catch ex As Exception

        End Try

    End Sub

    Private Sub RequestList_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridRequestList.SelectionChanged
        If gridRequestList.SelectedItems.Count = 0 Then Exit Sub
        LoadExamDetial()
    End Sub
    Private Sub LoadExamDetial()
        'Try
        ClearBox()
        LoadCheckBloodResult(gridRequestList.GetRow.Cells("request_id").Value)
        LoadFibroData()
        LoadNasoData()
        LoadColoData()
        LoadEchoData()
        LoadScanData()
        LoadFibroScanData()
        LoadMRIData()
        LoadCFAnapath()
        LoadBreathTest()
        FrmStatus.LoadStatusExam(gridRequestList.GetRow.Cells("request_id").Value)
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub ShowRptFibro()
        Dim FrmViewer As New FormReportViewer
        Dim Rpt As New Fibro
        Dim TblFibro As New DataTable
        Dim TblFibroConclusion As New DataTable
        TblFibro = DA_Fibro.SelectFibroByRequestID(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
        TblFibroConclusion = DA_FibroConclusion.SelectConclusionByRequestID(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
        Rpt.SetDataSource(TblFibro)
        'Rpt.Subreports("FibroConclusion").SetDataSource(TblFibroConclusion)
        FrmViewer.CVForm.ReportSource = Rpt
        FrmViewer.SplitContainer1.Panel1Collapsed = True
        FrmViewer.ShowDialog()
    End Sub
    Private Sub ShowRptFibroEnglish()
        Dim FrmViewer As New FormReportViewer
        Dim Rpt As New FibroEng
        Dim TblFibro As New DataTable
        Dim TblFibroConclusion As New DataTable
        TblFibro = DA_Fibro.SelectFibroByRequestID(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
        TblFibroConclusion = DA_FibroConclusion.SelectConclusionByRequestID(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
        Rpt.SetDataSource(TblFibro)
        'Rpt.Subreports("FibroConclusion").SetDataSource(TblFibroConclusion)
        FrmViewer.CVForm.ReportSource = Rpt
        FrmViewer.SplitContainer1.Panel1Collapsed = True
        FrmViewer.ShowDialog()
    End Sub
    Private Sub ShowRptEcho()
        If gridRequestList.SelectedItems.Count = 0 Then Exit Sub
        Dim FrmViewer As New FormReportViewer

        FrmViewer.CrvImage.Dock = DockStyle.Fill
        FrmViewer.CrvImage.Visible = True
        FrmViewer.AxAcroPDF1.Visible = False
        Dim RptEcoImg As New EchoImage
        Dim Rpt As New EchoV1
        Dim tblEchoImg As DataTable
        Dim TblEcho As DataTable
        Dim TblEchoConclusion As DataTable
        TblEcho = DA_Echo.SelectEchoByRequestID(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
        TblEchoConclusion = DA_EchoConclusion.SelectConclusionByRequestID(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
        tblEchoImg = DA_EchoImage.SelectImageEcho(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
        Rpt.SetDataSource(TblEcho)
        RptEcoImg.SetDataSource(tblEchoImg)
        RptEcoImg.Subreports("PatientInfo").SetDataSource(tblEchoImg)
        RptEcoImg.Subreports("Image").SetDataSource(tblEchoImg)
        'Rpt.Subreports("EchoConclusion").SetDataSource(TblEchoConclusion)
        FrmViewer.CVForm.ReportSource = Rpt
        FrmViewer.CrvImage.ReportSource = RptEcoImg

        ' FrmViewer.SplitContainer1.Panel1Collapsed = True
        FrmViewer.ShowDialog()
    End Sub
    Private Sub BtnPrintFibroscopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintFibroscopy.Click
        MainApplicationForm.StatusLoading(True)
        VALUE_LOADING_DATA = 2
        Application.DoEvents()
        BgLoadData.RunWorkerAsync()

    End Sub
    Private Sub BtnPrintEcho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintEcho.Click
        MainApplicationForm.StatusLoading(True)
        VALUE_LOADING_DATA = 5
        Application.DoEvents()
        BgLoadData.RunWorkerAsync()
    End Sub

    Sub ShowBloodResultForm()
        If Me.ItemResultList.RowCount >= 1 Then
            Dim FrmBlood As New FormResultBlood(Me)
            FrmBlood.TxtBloodCheck.Text = Me.ItemResultList.CurrentRow.Cells("item_name").Value.ToString
            FrmBlood.TxtResultBlood.Text = Me.ItemResultList.CurrentRow.Cells("result").Value.ToString
            If FrmBlood.ShowDialog() = DialogResult.OK Then
                If LoadStatusExam(CLng(gridRequestList.GetRow.Cells("request_id").Value)) = True Then
                    DA_Request.UpdateStatus(0, CLng(gridRequestList.GetRow.Cells("request_id").Value))
                    gridRequestList.DataSource = DA_Request.SelectStatus(1)
                Else
                    gridRequestList.DataSource = DA_Request.SelectRequestByID(gridRequestList.GetRow.Cells("request_id").Value)
                End If
            End If
        End If
    End Sub
    Private Sub ItemResultList_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles ItemResultList.RowDoubleClick
        ShowBloodResultForm()
    End Sub
    Private Sub CmdNewPhysical_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs)
        Dim FrmPhysical As New Physical(Me)
        FrmPhysical.lblaction.Text = 0
        FrmPhysical.ShowDialog()
    End Sub








    Private Sub cmdDeleteCheckItem_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles cmdDeleteCheckItem.Click
        Try
            If MsgBox("Are you sure you want to delete this check item?", MsgBoxStyle.YesNo, "Comfirm Delete") = MsgBoxResult.Yes Then
                DA_ItemResult.DeleteCheckItem(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value), CInt(Me.ItemResultList.CurrentRow.Cells("item_id").Value))
                LoadCheckBloodResult(gridRequestList.GetRow.Cells("request_id").Value)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmdEditCheckItem_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles cmdEditCheckItem.Click
        ShowBloodResultForm()
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
    Dim FrmStatus As New ExaminationStatus(Me)
    Private Sub btnCheckStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckStatus.Click

        FrmStatus = New ExaminationStatus(Me)
        FrmStatus.Show()
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        MainApplicationForm.StatusLoading(True)
        VALUE_LOADING_DATA = 1
        Application.DoEvents()
        BgLoadData.RunWorkerAsync()
    End Sub

    Private Sub BgLoadData_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadData.DoWork
        LoadingData()
    End Sub
    Private Sub BgLoadData_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadData.RunWorkerCompleted
        Application.DoEvents()
        MainApplicationForm.StatusLoading(False)
        If VALUE_LOADING_DATA = 2 Then
            If LoadStatusExam(CLng(gridRequestList.GetRow.Cells("request_id").Value)) = True Then

                DA_Request.UpdateStatus(0, CLng(gridRequestList.GetRow.Cells("request_id").Value))
                gridRequestList.DataSource = DA_Request.SelectStatus(1)
            Else
                gridRequestList.DataSource = DA_Request.SelectRequestByID(gridRequestList.GetRow.Cells("request_id").Value)
            End If
        End If
        If VALUE_LOADING_DATA = 3 Then
            If LoadStatusExam(CLng(gridRequestList.GetRow.Cells("request_id").Value)) = True Then
                DA_Request.UpdateStatus(0, CLng(gridRequestList.GetRow.Cells("request_id").Value))
                gridRequestList.DataSource = DA_Request.SelectStatus(1)
            Else
                gridRequestList.DataSource = DA_Request.SelectRequestByID(gridRequestList.GetRow.Cells("request_id").Value)
            End If
        End If
        If VALUE_LOADING_DATA = 4 Then
            If LoadStatusExam(CLng(gridRequestList.GetRow.Cells("request_id").Value)) = True Then

                DA_Request.UpdateStatus(0, CLng(gridRequestList.GetRow.Cells("request_id").Value))
                gridRequestList.DataSource = DA_Request.SelectStatus(1)
            Else

                gridRequestList.DataSource = DA_Request.SelectRequestByID(gridRequestList.GetRow.Cells("request_id").Value)
            End If
        End If
        If VALUE_LOADING_DATA = 5 Then
            If LoadStatusExam(CLng(gridRequestList.GetRow.Cells("request_id").Value)) = True Then
                DA_Request.UpdateStatus(0, CLng(gridRequestList.GetRow.Cells("request_id").Value))
                gridRequestList.DataSource = DA_Request.SelectStatus(1)
            Else
                gridRequestList.DataSource = DA_Request.SelectRequestByID(gridRequestList.GetRow.Cells("request_id").Value)
            End If
        End If
    End Sub
    Private Sub LoadingData()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadingData))
        Else
            Select Case VALUE_LOADING_DATA
                Case 1
                    Me.gridRequestList.DataSource = DA_Request.SelectStatus(1)
                Case 2
                    ShowRptFibro()
                Case 3
                    ShowRptNaso()
                Case 4
                    ShowRptColo()
                Case 5
                    ShowRptEcho()
                Case 6
                    ShowRptColoEnglish()
                Case 7
                    ShowRptFibroEnglish()
                Case 8
                    ShowRptNasoEng()
                Case 9
                    ShowRptBreathTest()
            End Select
        End If
    End Sub

    Public Sub FindHistoryExam(ByVal Status As Integer, Optional ByVal PatientNo As Long = 0, Optional ByVal PatientName As String = "")
        If PatientNo <> 0 Then
            Me.gridRequestList.DataSource = DA_Request.SelectRequestByStatusPNo(Status, PatientNo)
        Else
            Me.gridRequestList.DataSource = DA_Request.GetDataByPnameAndStatus(Status, PatientName)
        End If
    End Sub


    Private Sub btnHistoryExam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHistoryExam.Click
        Dim FindPExam As New FindPatientExam(Me)
        FindPExam.Show()
    End Sub

    Private Sub BtnCompleteExam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCompleteExam.Click


        Dim FFindExamHistory As New FrmFindParaHistory
        FFindExamHistory.ShowDialog()


    End Sub

    Private Sub btnNasogastro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNasogastro.Click
        MainApplicationForm.StatusLoading(True)
        VALUE_LOADING_DATA = 3
        Application.DoEvents()
        BgLoadData.RunWorkerAsync()
    End Sub
    Private Sub ShowRptNaso()
        If Me.gridRequestList.SelectedItems.Count = 0 Then Exit Sub
        Dim FrmViewer As New FormReportViewer
        Dim Rpt As New Naso
        Dim TblNaso As New DataTable
        Dim TblNasoConclusion As New DataTable
        TblNaso = DA_Naso.SelectNasoByRequestID(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
        TblNasoConclusion = DA_NasoConclusion.SelectConclusionByRequestID(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
        Rpt.SetDataSource(TblNaso)
        Rpt.Subreports("NasoConclusion").SetDataSource(TblNasoConclusion)
        FrmViewer.CVForm.ReportSource = Rpt
        FrmViewer.SplitContainer1.Panel1Collapsed = True
        FrmViewer.ShowDialog()
    End Sub
    Private Sub ShowRptNasoEng()
        If Me.gridRequestList.SelectedItems.Count = 0 Then Exit Sub
        Dim FrmViewer As New FormReportViewer
        Dim Rpt As New NasoEng
        Dim TblNaso As New DataTable
        Dim TblNasoConclusion As New DataTable
        TblNaso = DA_Naso.SelectNasoByRequestID(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
        TblNasoConclusion = DA_NasoConclusion.SelectConclusionByRequestID(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
        Rpt.SetDataSource(TblNaso)
        'Rpt.Subreports("NasoConclusion").SetDataSource(TblNasoConclusion)
        FrmViewer.CVForm.ReportSource = Rpt
        FrmViewer.SplitContainer1.Panel1Collapsed = True
        FrmViewer.ShowDialog()
    End Sub
    Private Sub ShowRptBreathTest()
        If Me.gridRequestList.SelectedItems.Count = 0 Then Exit Sub
        Dim FrmViewer As New FormReportViewer
        Dim Rpt As New BreathReport
        Dim TblBreathTest As DataTable = DA_BreathTest.SelectBreathTestByID(CDbl(gridRequestList.GetRow.Cells("request_id").Value))
        Rpt.SetDataSource(TblBreathTest)
        FrmViewer.CVForm.ReportSource = Rpt
        FrmViewer.SplitContainer1.Panel1Collapsed = True
        FrmViewer.ShowDialog()
    End Sub
    Private Sub ShowRptColo()
        If gridRequestList.SelectedItems.Count = 0 Then Exit Sub
        Dim FrmViewer As New FormReportViewer
        Dim Rpt As New Colo
        Dim TblColo As New DataTable
        Dim TblColoConclusion As New DataTable
        TblColo = DA_Colo.SelectColoByRequestID(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
        TblColoConclusion = DA_ColoConclusion.SelectConclusionByRequestID(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
        Rpt.SetDataSource(TblColo)
        Rpt.Subreports("ColoConclusion").SetDataSource(TblColoConclusion)
        FrmViewer.CVForm.ReportSource = Rpt
        FrmViewer.SplitContainer1.Panel1Collapsed = True
        FrmViewer.ShowDialog()
    End Sub
    Private Sub ShowRptColoEnglish()
        If gridRequestList.SelectedItems.Count = 0 Then Exit Sub
        Dim FrmViewer As New FormReportViewer
        Dim Rpt As New ColoEng
        Dim TblColo As New DataTable
        Dim TblColoConclusion As New DataTable
        TblColo = DA_Colo.SelectColoByRequestID(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
        TblColoConclusion = DA_ColoConclusion.SelectConclusionByRequestID(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value))
        Rpt.SetDataSource(TblColo)
        ' Rpt.Subreports("ColoConclusion").SetDataSource(TblColoConclusion)
        FrmViewer.CVForm.ReportSource = Rpt
        FrmViewer.SplitContainer1.Panel1Collapsed = True
        FrmViewer.ShowDialog()
    End Sub
    Private Sub btnPrintColo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintColo.Click
        MainApplicationForm.StatusLoading(True)
        VALUE_LOADING_DATA = 4
        Application.DoEvents()
        BgLoadData.RunWorkerAsync()

    End Sub







    Private Sub BtnAsTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAsTable.Click
        gridRequestList.View = Janus.Windows.GridEX.View.TableView

    End Sub

    Private Sub BtnAsCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAsCard.Click
        gridRequestList.View = Janus.Windows.GridEX.View.CardView
    End Sub


    Private Sub BtnNewExam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewExam.Click

        Dim DocRequestExam As New MainDocRequestExam(Me)
        DocRequestExam.BtnFindPatient.Visible = True
        DocRequestExam.ShowDialog()

    End Sub

    Private Sub BtnCFAnapath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If gridRequestList.SelectedItems.Count = 0 Then Exit Sub
        Dim CFAnapath As New FormCFAnaPath(Me)
        If CFAnapath.ShowDialog() = DialogResult.OK Then
            LoadExamDetial()
        End If
    End Sub

    Private Sub DropDownCommand1_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles DropDownCommand1.Click
        FrmStatus.Close()
        If gridRequestList.SelectedItems.Count = 0 Then Exit Sub
        If gridRequestList.GetRow.Cells("biology").Value = False Then
            MessageBox.Show("You can not add information of " & DropDownCommand1.Text & ". Because doctor not request exam.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If LoadStatusExam(CLng(gridRequestList.GetRow.Cells("request_id").Value)) = True Then
                DA_Request.UpdateStatus(0, CLng(gridRequestList.GetRow.Cells("request_id").Value))
                gridRequestList.DataSource = DA_Request.SelectStatus(1)
            Else
                gridRequestList.DataSource = DA_Request.SelectRequestByID(gridRequestList.GetRow.Cells("request_id").Value)
            End If

        End If
    End Sub







    Private Sub DropDownCommand5_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles DropDownCommand5.Click
        'FrmStatus.Close()

        If gridRequestList.SelectedItems.Count = 0 Then Exit Sub
        If gridRequestList.GetRow.Cells("echo").Value = False Then
            MessageBox.Show("You can not add information of " & DropDownCommand5.Text & ". Because doctor not request exam.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim Echo As New FormResultEcho(Me)
            Echo.LblPatientNo.Text = gridRequestList.GetRow.Cells("ppatientid").Value
            Echo.lblPatientName.Text = gridRequestList.GetRow.Cells("pname").Value
            If Echo.ShowDialog() = DialogResult.OK Then
                BtnPrintEcho_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub DropDownCommand6_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles DropDownCommand6.Click
        FrmStatus.Close()
        If gridRequestList.SelectedItems.Count = 0 Then Exit Sub
        If gridRequestList.GetRow.Cells("scan").Value = False Then
            MessageBox.Show("You can not add information of " & DropDownCommand6.Text & ". Because doctor not request exam.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim Scan As New FormScan(Me)
            If Scan.ShowDialog() = DialogResult.OK Then
                If LoadStatusExam(CLng(gridRequestList.GetRow.Cells("request_id").Value)) = True Then
                    DA_Request.UpdateStatus(0, CLng(gridRequestList.GetRow.Cells("request_id").Value))
                    gridRequestList.DataSource = DA_Request.SelectStatus(1)
                Else
                    gridRequestList.DataSource = DA_Request.SelectRequestByID(gridRequestList.GetRow.Cells("request_id").Value)
                End If
            End If
        End If
    End Sub

    Private Sub DropDownCommand7_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles DropDownCommand7.Click
        FrmStatus.Close()
        If gridRequestList.SelectedItems.Count = 0 Then Exit Sub
        If gridRequestList.GetRow.Cells("mri").Value = False Then
            MessageBox.Show("You can not add information of " & DropDownCommand7.Text & ". Because doctor not request exam.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim MRI As New FormResultMRI(Me)
            If MRI.ShowDialog() = DialogResult.OK Then
                If LoadStatusExam(CLng(gridRequestList.GetRow.Cells("request_id").Value)) = True Then
                    DA_Request.UpdateStatus(0, CLng(gridRequestList.GetRow.Cells("request_id").Value))
                    gridRequestList.DataSource = DA_Request.SelectStatus(1)
                Else
                    gridRequestList.DataSource = DA_Request.SelectRequestByID(gridRequestList.GetRow.Cells("request_id").Value)
                End If
            End If
        End If
    End Sub

    Private Sub DropDownCommand8_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles DropDownCommand8.Click
        FrmStatus.Close()
        If gridRequestList.SelectedItems.Count = 0 Then Exit Sub
        If gridRequestList.GetRow.Cells("fibroscan").Value = False Then
            MessageBox.Show("You can not add information of " & DropDownCommand8.Text & ". Because doctor not request exam.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim FScan As New FormFibrosScan(Me)
            If FScan.ShowDialog() = DialogResult.OK Then
                If LoadStatusExam(CLng(gridRequestList.GetRow.Cells("request_id").Value)) = True Then
                    DA_Request.UpdateStatus(0, CLng(gridRequestList.GetRow.Cells("request_id").Value))
                    gridRequestList.DataSource = DA_Request.SelectStatus(1)
                Else
                    gridRequestList.DataSource = DA_Request.SelectRequestByID(gridRequestList.GetRow.Cells("request_id").Value)
                End If
            End If
        End If
    End Sub

    Private Sub DropDownCommand9_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles DropDownCommand9.Click
        If gridRequestList.SelectedItems.Count = 0 Then Exit Sub
        Dim CFAnapath As New FormCFAnaPath(Me)
        If CFAnapath.ShowDialog() = DialogResult.OK Then
            If LoadStatusExam(CLng(gridRequestList.GetRow.Cells("request_id").Value)) = True Then
                DA_Request.UpdateStatus(0, CLng(gridRequestList.GetRow.Cells("request_id").Value))
                gridRequestList.DataSource = DA_Request.SelectStatus(1)
            Else
                gridRequestList.DataSource = DA_Request.SelectRequestByID(gridRequestList.GetRow.Cells("request_id").Value)
            End If
        End If
    End Sub


    Private Sub BtnMedicalReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMedicalReport.Click
        If gridRequestList.SelectedItems.Count = 0 Then Exit Sub
        ''Show Report
        MainApplicationForm.StatusLoading(True)
        BgLoadingReport.RunWorkerAsync()
    End Sub

    Private Sub BgLoadingReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadingReport.DoWork
        PreviewReport()
    End Sub
    Sub PreviewReport()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf PreviewReport))
        Else
            Me.CRPatientDocViewer.ReportSource = ViewReportMainHistory.PreviewReport(CLng(Me.gridRequestList.GetRow.Cells("patientid").Value))
            'Dim PatientTable As DataTable
            'Dim PPatientIDAuto As Long
            'Dim PatientNo As Long
            'PatientTable = DAPatient.SelectPatientByID(CLng(Me.gridRequestList.GetRow.Cells("patientid").Value))
            'PatientNo = CLng(Me.gridRequestList.GetRow.Cells("patientid").Value)
            'PPatientIDAuto = CLng(Me.gridRequestList.GetRow.Cells("ppatientid").Value) 'PatientTable.Rows(0).Item("ppatientid")

            'Dim RptRecord As New RptPatientRecord
            '' Dim RptViewer As New FormReportViewer

            'Dim PresRemark As DataTable = DA_PrescriptionRemark.SelectPrescriptionByPatientID(PPatientIDAuto)
            'Dim ComplaintTable As DataTable = DA_Complaint.SelectByPatientID(PPatientIDAuto)
            'Dim HistoryTable As DataTable = DA_History.SelectByPatientID(PPatientIDAuto)
            'Dim PrescriptionTable As DataTable = DA_Prescription.SelectByPatientID(PPatientIDAuto)
            'Dim PhysicalTable As DataTable = DA_Physical1.SelectByPatientID(PPatientIDAuto)

            'Dim BiologyTable As DataTable = DA_Biology.SelectByPatientID(PPatientIDAuto)
            'Dim FibroTable As DataTable = DA_Fibroscopy.SelectByPatientID(PPatientIDAuto)
            'Dim ColoTable As DataTable = DA_Coloscopy.SelectByPatientID(PPatientIDAuto)

            'Dim NasoTable As DataTable = DA_Nasogastro.SelectByPatientID(PPatientIDAuto)

            'Dim EchoTable As DataTable = DA_Echo1.SelectByPatientID(PPatientIDAuto)

            'Dim ScanTable As DataTable = DA_Scan1.SelectByPatientID(PPatientIDAuto)

            'Dim FibroScan As DataTable = DA_FibroScan1.GetDataByPatientID(PPatientIDAuto) 'SelectByPatientID(PatientID)

            'Dim MRITable As DataTable = DA_MRI1.SelectByPatientID(PPatientIDAuto)

            'Dim CAAnaPath As DataTable = DA_CFAnaPath.GetData(PPatientIDAuto)
            'Dim BreatTestTable As DataTable = DA_BreathTest.SelectBreathTestByPatientNo(PatientNo)


            'RptRecord.Database.Tables("Patient").SetDataSource(PatientTable)
            'RptRecord.Subreports("PrescriptionRemark").SetDataSource(PresRemark)
            'RptRecord.Subreports("Complaint").Database.Tables("Complaint").SetDataSource(ComplaintTable)
            'RptRecord.Subreports("History").Database.Tables("History").SetDataSource(HistoryTable)
            'RptRecord.Subreports("Prescription").Database.Tables("PrescriptionDetail").SetDataSource(PrescriptionTable)
            'RptRecord.Subreports("Biology").Database.Tables("Blood").SetDataSource(BiologyTable)
            'RptRecord.Subreports("Fibroscopy").Database.Tables("Fibro").SetDataSource(FibroTable)
            'RptRecord.Subreports("Coloscopy").Database.Tables("Colo").SetDataSource(ColoTable)
            'RptRecord.Subreports("Nasogastro").Database.Tables("Naso").SetDataSource(NasoTable)
            'RptRecord.Subreports("Echo").Database.Tables("Echo").SetDataSource(EchoTable)
            'RptRecord.Subreports("FibroScan").Database.Tables("FibroScan1").SetDataSource(FibroScan)
            'RptRecord.Subreports("Scan").Database.Tables("Scan").SetDataSource(ScanTable)
            'RptRecord.Subreports("MRI").Database.Tables("MRI").SetDataSource(MRITable)
            'RptRecord.Subreports("Physical").Database.Tables("PhysicalExam").SetDataSource(PhysicalTable)
            'RptRecord.Subreports("ACAnaPath").Database.Tables("CFAnaPath").SetDataSource(CAAnaPath)
            'RptRecord.Subreports("UreaBreathTest").Database.Tables("TblBreathTest").SetDataSource(BreatTestTable)
            'Me.CRPatientDocViewer.ReportSource = RptRecord

        End If



    End Sub

    Private Sub BgLoadingReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadingReport.RunWorkerCompleted
        MainApplicationForm.StatusLoading(False)
    End Sub

    Private Sub RequestList_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles gridRequestList.RowDoubleClick
        Dim DocRequestExam As New MainDocRequestExam(Me)
        DocRequestExam.BtnFindPatient.Visible = False

        ''---Load Blood Result ----
        DocRequestExam.itemlist.DataSource = DA_BloodResult.SelectCheckItemByRequestID(CLng(Me.gridRequestList.CurrentRow.Cells("request_id").Value))

        DocRequestExam.TxtPatientNo.Text = gridRequestList.GetRow.Cells("patientid").Value
        DocRequestExam.LblSaveOption.Text = gridRequestList.GetRow.Cells("request_id").Value
        DocRequestExam.dtrequest.Checked = True
        DocRequestExam.dtrequest.Value = gridRequestList.GetRow.Cells("request_date").Value
        DocRequestExam.cbodoctor.Text = gridRequestList.GetRow.Cells("Doctor_Name").Value
        DocRequestExam.chkbilogy.Checked = gridRequestList.GetRow.Cells("biology").Value
        DocRequestExam.chkfibro.Checked = gridRequestList.GetRow.Cells("fibro").Value
        DocRequestExam.chknaso.Checked = gridRequestList.GetRow.Cells("naso").Value
        DocRequestExam.chkcolo.Checked = gridRequestList.GetRow.Cells("colo").Value
        DocRequestExam.chkecho.Checked = gridRequestList.GetRow.Cells("echo").Value
        DocRequestExam.chkscan.Checked = gridRequestList.GetRow.Cells("scan").Value
        DocRequestExam.chkmri.Checked = gridRequestList.GetRow.Cells("mri").Value
        DocRequestExam.ChUreaBreathTest.Checked = gridRequestList.GetRow.Cells("breathtest").Value
        DocRequestExam.chkfibroscan.Checked = gridRequestList.GetRow.Cells("fibroscan").Value
        DocRequestExam.CboDiagnosis.Text = IIf(TypeOf gridRequestList.GetRow.Cells("Diagnosis").Value Is DBNull, "", gridRequestList.GetRow.Cells("Diagnosis").Value)
        DocRequestExam.BtnFindPatient_Click(sender, e)
        LoadCheckBloodResult(gridRequestList.GetRow.Cells("request_id").Value)
        If DocRequestExam.ShowDialog() = DialogResult.OK Then
            gridRequestList.DataSource = DA_Request.SelectRequestByID(DocRequestExam.LblSaveOption.Text)
        End If
    End Sub

    Function LoadStatusExam(ByVal RequestNo As Double) As Boolean
        Try

            'SELECT EXAMINATION NAME
            Dim ExamList As New ArrayList
            Dim FieldList As New ArrayList
            Dim ExamStatus As New ArrayList
            Dim requestid As Long = RequestNo
            FieldList.Add("biology")
            FieldList.Add("fibro")
            FieldList.Add("naso")
            FieldList.Add("colo")
            FieldList.Add("echo")
            FieldList.Add("scan")
            FieldList.Add("mri")
            FieldList.Add("fibroscan")
            FieldList.Clear()
            ExamList.Clear()
            ExamStatus.Clear()
            Dim RequestTable As New DataTable
            RequestTable.Rows.Clear()
            RequestTable = DA_Request.SelectRequestByID(requestid)
            If RequestTable.Rows(0).Item("biology") = True Then
                ExamList.Add("Biology")
            End If
            If RequestTable.Rows(0).Item("fibro") = True Then
                ExamList.Add("Fibroscopy")
            End If
            If RequestTable.Rows(0).Item("naso") = True Then
                ExamList.Add("Nasogastro")
            End If
            If RequestTable.Rows(0).Item("colo") = True Then
                ExamList.Add("Coloscopy")
            End If
            If RequestTable.Rows(0).Item("echo") = True Then
                ExamList.Add("Echo")
            End If
            If RequestTable.Rows(0).Item("scan") = True Then
                ExamList.Add("Scan")
            End If
            If RequestTable.Rows(0).Item("mri") = True Then
                ExamList.Add("M-R-I")
            End If
            If RequestTable.Rows(0).Item("fibroscan") = True Then
                ExamList.Add("Fibro Scan")
            End If
            'For i As Integer = 0 To FieldList.Count - 1
            '    ''If DA_Request.SelectByExamName(FieldList.Item(i).ToString,requestid).Rows.Count >= 1 Then
            '    If DA_Request.SelectByExamName.Rows.Count >= 1 Then
            '        ExamList.Add(FieldList.Item(i))
            '    End If
            'Next
            Dim I As Integer = 0
            For j As Integer = 0 To ExamList.Count - 1
                If ExamList.Item(j) = "Biology" Then
                    If DA_BloodResult.SelectByRequestResult(requestid).Rows.Count >= 1 Then
                        ExamStatus.Add("Finished")

                    Else
                        ExamStatus.Add("Not yet")
                        I = I + 1
                    End If
                End If
                If ExamList.Item(j) = "Fibroscopy" Then
                    If DA_Fibro.SelectFibroByRequestID(requestid).Rows.Count >= 1 Then
                        ExamStatus.Add("Finished")
                    Else
                        ExamStatus.Add("Not yet")
                        I = I + 1
                    End If
                End If
                If ExamList.Item(j) = "Nasogastro" Then
                    If DA_Naso.SelectNasoByRequestID(requestid).Rows.Count >= 1 Then
                        ExamStatus.Add("Finished")
                    Else
                        ExamStatus.Add("Not yet")
                        I = I + 1
                    End If
                End If
                If ExamList.Item(j) = "Coloscopy" Then
                    If DA_Colo.SelectColoByRequestID(requestid).Rows.Count >= 1 Then
                        ExamStatus.Add("Finished")
                    Else
                        ExamStatus.Add("Not yet")
                        I = I + 1
                    End If
                End If
                If ExamList.Item(j) = "Echo" Then
                    If DA_Echo.SelectEchoByRequestID(requestid).Rows.Count >= 1 Then
                        ExamStatus.Add("Finished")
                    Else
                        ExamStatus.Add("Not yet")
                        I = I + 1
                    End If
                End If
                If ExamList.Item(j) = "Scan" Then
                    If DA_Scan.SelectScanByRequestID(requestid).Rows.Count >= 1 Then
                        ExamStatus.Add("Finished")
                    Else
                        ExamStatus.Add("Not yet")
                        I = I + 1
                    End If
                End If
                If ExamList.Item(j) = "M-R-I" Then
                    If DA_MRI.SelectMRIByRequestID(requestid).Rows.Count >= 1 Then
                        ExamStatus.Add("Finished")
                    Else
                        ExamStatus.Add("Not yet")
                        I = I + 1
                    End If
                End If
                If ExamList.Item(j) = "Fibro Scan" Then
                    If DA_FibroScan.SelectFibroScanByRequestID(requestid).Rows.Count >= 1 Then
                        ExamStatus.Add("Finished")
                    Else
                        ExamStatus.Add("Not yet")
                        I = I + 1
                    End If
                End If
            Next
            If I > 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception

        End Try
    End Function

    Private Sub BntWaitingList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BntWaitingList.Click

        If gridRequestList.SelectedItems.Count = 0 Then Exit Sub
        Dim PatientWatienting As New FNewPatientWaitingConsuling(Me)
        If PatientWatienting.ShowDialog() = DialogResult.OK Then

        End If
    End Sub



    Private Sub BtnCompletPatientExp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCompletPatientExp.Click
        If gridRequestList.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do want set this patient to complete examination?", "Complet", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            DA_Request.UpdateStatus(0, CLng(gridRequestList.GetRow.Cells("request_id").Value))
            gridRequestList.DataSource = DA_Request.SelectStatus(1)
        End If
    End Sub

    Private Sub BtnDeleteExam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteExam.Click
        If gridRequestList.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to deelete request?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_Request.DeleteRequest(gridRequestList.GetRow.Cells("request_id").Value) = 1 Then
                MainApplicationForm.StatusLoading(True)
                VALUE_LOADING_DATA = 1
                Application.DoEvents()
                BgLoadData.RunWorkerAsync()
            End If
        End If

    End Sub

    Private Sub DropDownCommand17_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles DropDownCommand17.Click
        FrmStatus.Close()
        If gridRequestList.SelectedItems.Count = 0 Then Exit Sub
        If gridRequestList.GetRow.Cells("colo").Value = False Then
            MessageBox.Show("You can not add information of " & DropDownCommand4.Text & ". Because doctor not request exam.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim Colo As New FormResultColoscopy(Me)
            Colo.LblPatientNo.Text = gridRequestList.GetRow.Cells("ppatientid").Value
            Colo.lblPatientName.Text = gridRequestList.GetRow.Cells("pname").Value
            If Colo.ShowDialog() = DialogResult.OK Then
                btnPrintColo_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub DropDownCommand16_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles DropDownCommand16.Click
        FrmStatus.Close()
        If gridRequestList.SelectedItems.Count = 0 Then Exit Sub
        If gridRequestList.GetRow.Cells("colo").Value = False Then
            MessageBox.Show("You can not add information of " & DropDownCommand4.Text & ". Because doctor not request exam.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim Colo As New FormResultColoEnglish(Me)
            Colo.LblPatientNo.Text = gridRequestList.GetRow.Cells("ppatientid").Value
            Colo.lblPatientName.Text = gridRequestList.GetRow.Cells("pname").Value
            If Colo.ShowDialog() = DialogResult.OK Then
                BtnPrintColoEng_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub BtnPrintColoEng_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintColoEng.Click
        MainApplicationForm.StatusLoading(True)
        VALUE_LOADING_DATA = 6
        Application.DoEvents()
        BgLoadData.RunWorkerAsync()
    End Sub

    Private Sub DropDownCommand12_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles DropDownCommand12.Click
        FrmStatus.Close()
        If gridRequestList.SelectedItems.Count = 0 Then Exit Sub
        If gridRequestList.GetRow.Cells("fibro").Value = False Then
            MessageBox.Show("You can not add information of " & DropDownCommand2.Text & ". Because doctor not request exam.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim Fibroscopy As New FormFibroscopy(Me)
            Fibroscopy.LblPatientNo.Text = gridRequestList.GetRow.Cells("ppatientid").Value
            Fibroscopy.lblPatientName.Text = gridRequestList.GetRow.Cells("pname").Value
            If Fibroscopy.ShowDialog() = DialogResult.OK Then
                MainApplicationForm.StatusLoading(True)
                VALUE_LOADING_DATA = 2
                Application.DoEvents()
                BgLoadData.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub DropDownCommand10_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles DropDownCommand10.Click
        FrmStatus.Close()
        If gridRequestList.SelectedItems.Count = 0 Then Exit Sub
        If gridRequestList.GetRow.Cells("fibro").Value = False Then
            MessageBox.Show("You can not add information of " & DropDownCommand2.Text & ". Because doctor not request exam.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim Fibroscopy As New FormFibroEnglish(Me)
            Fibroscopy.LblPatientNo.Text = gridRequestList.GetRow.Cells("ppatientid").Value
            Fibroscopy.lblPatientName.Text = gridRequestList.GetRow.Cells("pname").Value
            If Fibroscopy.ShowDialog = DialogResult.OK Then
                MainApplicationForm.StatusLoading(True)
                VALUE_LOADING_DATA = 7
                Application.DoEvents()
                BgLoadData.RunWorkerAsync()
            End If

        End If
    End Sub

    Private Sub BtnPrintFibroEng_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintFibroEng.Click
        MainApplicationForm.StatusLoading(True)
        VALUE_LOADING_DATA = 7
        Application.DoEvents()
        BgLoadData.RunWorkerAsync()
    End Sub

    Private Sub DropDownCommand21_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles DropDownCommand21.Click
        FrmStatus.Close()
        If gridRequestList.SelectedItems.Count = 0 Then Exit Sub
        If gridRequestList.GetRow.Cells("naso").Value = False Then
            MessageBox.Show("You can not add information of " & DropDownCommand3.Text & ". Because doctor not request exam.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim Nasogastro As New FormNasogastro(Me)
            Nasogastro.LblPatientNo.Text = gridRequestList.GetRow.Cells("ppatientid").Value
            Nasogastro.lblPatientName.Text = gridRequestList.GetRow.Cells("pname").Value
            Nasogastro.lblRequestid.Text = gridRequestList.GetRow.Cells("request_id").Value
            If Nasogastro.ShowDialog() = DialogResult.OK Then
                btnNasogastro_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub DropDownCommand20_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles DropDownCommand20.Click
        FrmStatus.Close()
        If gridRequestList.SelectedItems.Count = 0 Then Exit Sub
        If gridRequestList.GetRow.Cells("naso").Value = False Then
            MessageBox.Show("You can not add information of " & DropDownCommand3.Text & ". Because doctor not request exam.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim Nasogastro As New FormNasograstroEng(Me)
            Nasogastro.LblPatientNo.Text = gridRequestList.GetRow.Cells("ppatientid").Value
            Nasogastro.lblPatientName.Text = gridRequestList.GetRow.Cells("pname").Value
            If Nasogastro.ShowDialog() = DialogResult.OK Then
                MainApplicationForm.StatusLoading(True)
                VALUE_LOADING_DATA = 8
                Application.DoEvents()
                BgLoadData.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub BtnPrintBreathTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintBreathTest.Click
        If gridRequestList.SelectedItems.Count = 0 Then Exit Sub
        MainApplicationForm.StatusLoading(True)
        VALUE_LOADING_DATA = 9
        Application.DoEvents()
        BgLoadData.RunWorkerAsync()
    End Sub

    Private Sub BtnBreathTest_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnBreathTest.Click
        If gridRequestList.SelectedItems.Count = 0 Then Exit Sub
        If gridRequestList.SelectedItems.Count = 0 Then Exit Sub
        If gridRequestList.GetRow.Cells("breathtest").Value = False Then
            MessageBox.Show("You can not add information of " & DropDownCommand8.Text & ". Because doctor not request exam.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim BreathTest As New NewUreaBreath
            Dim TblBreathTest As DataTable = DA_BreathTest.SelectBreathTestByID(CDbl(gridRequestList.GetRow.Cells("request_id").Value))
            If TblBreathTest.Rows.Count = 0 Then
                BreathTest.LblSaveOption.Text = ""
                BreathTest.DateRequest.Value = Now
                BreathTest.cbodoctor.Text = ""
                BreathTest.TxtIndication.Text = ""
                BreathTest.TxtResult.Text = ""
                BreathTest.CboConclusion.Text = ""
                BreathTest.TxtMoreInfo.Text = ""
            Else
                For Each rows As DataRow In TblBreathTest.Rows
                    BreathTest.LblSaveOption.Text = rows("RequestID")
                    BreathTest.LblRequestNo.Text = rows("RequestID")
                    BreathTest.txtno.Text = rows("PatientNo")
                    BreathTest.txtname.Text = rows("PatientName")
                    BreathTest.txtsex.Text = rows("PatientSex")
                    BreathTest.txtdatebirth.Text = rows("PatientDOB")
                    BreathTest.txtaddress.Text = rows("PatientAdress")
                    BreathTest.DateRequest.Checked = True
                    BreathTest.DateRequest.Value = rows("DateTest")
                    BreathTest.cbodoctor.Text = rows("RequestBy")
                    BreathTest.TxtIndication.Text = rows("Indication")
                    BreathTest.TxtResult.Text = rows("Result")
                    BreathTest.CboConclusion.Text = rows("Conclusion")
                    BreathTest.TxtMoreInfo.Text = rows("BreathTestNote")
                Next
            End If
            If BreathTest.ShowDialog = DialogResult.OK Then
                LoadBreathTest()
            End If
        End If


    End Sub
End Class
