Public Class FormDataAnalysis
    Dim mainAnalysis As UAnalysis
    Dim DA_ProvinceAnalysis As New DSAnalysisTableAdapters.PROVINCE_DIAGNOSISTableAdapter

    Dim DA_Province As New DSPAtientTableAdapters.tblProvincesTableAdapter
    Dim DA_Diagnosis As New DSPAtientTableAdapters.tbldiagnosisTableAdapter

    'Motif Fibro and Nasoscopy ...........................................
    Dim DA_MotifFibroNaso As New DS_ParameterTableAdapters.tblMotiveOfFibroAnaNasoTableAdapter

    'Motif Colonaso
    Dim DA_Motif_Colo As New DS_ParameterTableAdapters.tblMotiveOfColoscopyTableAdapter

    ' Data Adapter for Report 
    Dim DA_DiagnosisComplaintAnalys As New DSAnalysisTableAdapters.VIEW_DIAGNOSI_COMPLAINTTableAdapter
    Dim DA_DiagnosisMedicalHistoryAnalys As New DSAnalysisTableAdapters.VIEW_DIAGNOSI_MEDICALHISTORYTableAdapter
    Dim DA_DiagnosisPhysicalAnalys As New DSAnalysisTableAdapters.VIEW_DIAGNOSI_PHYSICALCHECKTableAdapter
    Dim DA_DiagnosisParaBloodAnalys As New DSAnalysisTableAdapters.VIEW_PARAEXAM_BLOODTableAdapter
    Dim DA_DiagnosisParaFibroAnalys As New DSAnalysisTableAdapters.VIEW_PARAEXAM_FIBROSCOPYTableAdapter
    Dim DA_DiagnosisParaNasogasroAnalys As New DSAnalysisTableAdapters.VIEW_PARAEXAM_NASOGASTROTableAdapter
    Dim DA_DiagnosisParaColoscopyAnalys As New DSAnalysisTableAdapters.VIEW_PARAEXAM_COLOSCOPYTableAdapter
    Dim VAL_OPTION_REPORT As Integer

    Sub New(ByVal mainAnalysis As UAnalysis)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.mainAnalysis = mainAnalysis
        With CboProvince
            .DataSource = DA_Province.GetData
            .ValueMember = "IDProvCode"
            .DisplayMember = "Province"
            .SelectedIndex = -1
        End With
        Me.cbodiagnosis.DataSource = DA_Diagnosis.SelectDiagnosis
        Me.cbodiagnosis.DisplayMember = DA_Diagnosis.SelectDiagnosis.Columns("diagnosis").ColumnName
        Me.cbodiagnosis.ValueMember = DA_Diagnosis.SelectDiagnosis.Columns("diagnosisid").ColumnName
        Me.cbodiagnosis.SelectedIndex = -1
        ' Add any initialization after the InitializeComponent() call.
        Me.CboPDiagnosis.DataSource = DA_Diagnosis.SelectDiagnosis
        Me.CboPDiagnosis.DisplayMember = DA_Diagnosis.SelectDiagnosis.Columns("diagnosis").ColumnName
        Me.CboPDiagnosis.ValueMember = DA_Diagnosis.SelectDiagnosis.Columns("diagnosisid").ColumnName
        Me.CboPDiagnosis.SelectedIndex = -1


        Me.cboParaDiagnosis.DataSource = DA_Diagnosis.SelectDiagnosis
        Me.cboParaDiagnosis.DisplayMember = DA_Diagnosis.SelectDiagnosis.Columns("diagnosis").ColumnName
        Me.cboParaDiagnosis.ValueMember = DA_Diagnosis.SelectDiagnosis.Columns("diagnosisid").ColumnName
        Me.cboParaDiagnosis.SelectedIndex = -1

        Me.CboFibroMotif.DataSource = DA_MotifFibroNaso.GetData
        Me.CboFibroMotif.DisplayMember = DA_MotifFibroNaso.GetData.Columns("Motive").ColumnName
        Me.CboFibroMotif.ValueMember = DA_MotifFibroNaso.GetData.Columns("Motive").ColumnName
        Me.CboFibroMotif.SelectedIndex = -1

        Me.CboNasoMotif.DataSource = DA_MotifFibroNaso.GetData
        Me.CboNasoMotif.DisplayMember = DA_MotifFibroNaso.GetData.Columns("Motive").ColumnName
        Me.CboNasoMotif.ValueMember = DA_MotifFibroNaso.GetData.Columns("Motive").ColumnName
        Me.CboNasoMotif.SelectedIndex = -1

        Me.cboColoMotify.DataSource = DA_Motif_Colo.GetData
        Me.cboColoMotify.ValueMember = DA_Motif_Colo.GetData.Columns("Motive").ColumnName
        Me.cboColoMotify.DisplayMember = DA_Motif_Colo.GetData.Columns("Motive").ColumnName
        cboColoMotify.SelectedIndex = -1
    End Sub

    Private Sub BtnProvincePreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProvincePreview.Click
        MainApplicationForm.StatusLoading(True)
        VAL_OPTION_REPORT = 1
        Application.DoEvents()
        BgLoadAnalysis.RunWorkerAsync()

    End Sub
    Private Sub LoadingProvince()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadingProvince))
        Else

            If RadPAllDiagnosis.Checked = True Then
                Dim tblAllDiagnosis As DataTable = DA_ProvinceAnalysis.SelectDateToDateAllProvince(DateFrom.Value.Date, DateTo.Value.Date)
                Dim REachProvince As New ReportDiagnosis
                Dim REachProvinceV1 As New ReportDiagnosisV1

                REachProvince.SetDataSource(tblAllDiagnosis)
                REachProvinceV1.SetDataSource(tblAllDiagnosis)
                If ChViewDetialData.Checked = True Then
                    mainAnalysis.CrvViewer.ReportSource = REachProvinceV1
                    REachProvinceV1.SetParameterValue("Title", "Data Analys Diagnosis From: " & Format(Me.DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(Me.DateTo.Value, "dd-MM-yyyy"))
                Else
                    mainAnalysis.CrvViewer.ReportSource = REachProvince
                    REachProvince.SetParameterValue("Title", "Data Analys Diagnosis From: " & Format(Me.DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(Me.DateTo.Value, "dd-MM-yyyy"))
                End If
            End If
            If RadOnePDiagnosis.Checked = True Then
                Dim tblAllDiagnosis As DataTable = DA_ProvinceAnalysis.SelectDateToDateByDiagnosis(DateFrom.Value.Date, DateTo.Value.Date, CboPDiagnosis.Text)
                Dim REachProvince As New ReportDiagnosis
                Dim REachProvinceV1 As New ReportDiagnosisV1
                REachProvince.SetDataSource(tblAllDiagnosis)
                REachProvinceV1.SetDataSource(tblAllDiagnosis)
                If ChViewDetialData.Checked = True Then
                    mainAnalysis.CrvViewer.ReportSource = REachProvinceV1
                    REachProvinceV1.SetParameterValue("Title", "Data Analys Diagnosis From: " & Format(Me.DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(Me.DateTo.Value, "dd-MM-yyyy"))
                Else
                    mainAnalysis.CrvViewer.ReportSource = REachProvince
                    REachProvince.SetParameterValue("Title", "Data Analys Diagnosis From: " & Format(Me.DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(Me.DateTo.Value, "dd-MM-yyyy"))
                End If
               
            End If

            If RadEachProvince.Checked = True Then
                If ValidateCombobox(CboProvince, "", ErrAnalysis) = False Then Exit Sub
                Dim tblProvince As DataTable = DA_ProvinceAnalysis.SelectDateToDateByProvince(DateFrom.Value.Date, DateTo.Value.Date, CboProvince.Text)
                Dim REachProvince As New ReportEachProvince
                Dim REachProvinceV1 As New ReportEachProvincev1

                REachProvince.SetDataSource(tblProvince)
                REachProvinceV1.SetDataSource(tblProvince)
                If ChViewDetialData.Checked = True Then
                    mainAnalysis.CrvViewer.ReportSource = REachProvinceV1
                    REachProvinceV1.SetParameterValue("Title", "From: " & Format(Me.DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(Me.DateTo.Value, "dd-MM-yyyy"))
                Else
                    mainAnalysis.CrvViewer.ReportSource = REachProvince
                    REachProvince.SetParameterValue("Title", "From: " & Format(Me.DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(Me.DateTo.Value, "dd-MM-yyyy"))
                End If
               
            End If
            If RadAllProvince.Checked = True Then
                Dim tblProvince As DataTable = DA_ProvinceAnalysis.SelectDateToDateAllProvince(DateFrom.Value.Date, DateTo.Value.Date)
                Dim REachProvince As New ReportEachProvince
                Dim REachProvinceV1 As New ReportEachProvincev1

                REachProvince.SetDataSource(tblProvince)
                REachProvinceV1.SetDataSource(tblProvince)
                If ChViewDetialData.Checked = True Then
                    mainAnalysis.CrvViewer.ReportSource = REachProvinceV1
                    REachProvinceV1.SetParameterValue("Title", "From: " & Format(Me.DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(Me.DateTo.Value, "dd-MM-yyyy"))
                Else
                    mainAnalysis.CrvViewer.ReportSource = REachProvince
                    REachProvince.SetParameterValue("Title", "From: " & Format(Me.DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(Me.DateTo.Value, "dd-MM-yyyy"))
                End If

                
            End If
        End If
    End Sub
    Private Sub BtnPreviewDiagnosis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreviewDiagnosis.Click
        MainApplicationForm.StatusLoading(True)
        VAL_OPTION_REPORT = 2
        BgLoadAnalysis.RunWorkerAsync()
    End Sub
    Private Sub LoadingAnalysisOther()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadingAnalysisOther))
        Else
            ' ============================= Report on Tab 2 ===================================
            If RadAllDiagnosis.Checked = True Then
                If RadByComplaint.Checked = True Then
                    Dim tblAllDiagnosisCompliant As DataTable = DA_DiagnosisComplaintAnalys.SelectComplaintDateToDate(DateFrom.Value, DateTo.Value)
                    Dim ReportComplaint As New ReportDiagnosisComplaint
                    Dim ReportComplaintv1 As New ReportDiagnosisComplaintV1
                    ReportComplaint.SetDataSource(tblAllDiagnosisCompliant)
                    ReportComplaintv1.SetDataSource(tblAllDiagnosisCompliant)
                    If ChViewDetialData.Checked = True Then
                        mainAnalysis.CrvViewer.ReportSource = ReportComplaintv1
                        ReportComplaintv1.SetParameterValue("Title", "Data Analys (Diagnosis with Patient Complaint) From:" & Format(Me.DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(Me.DateTo.Value, "dd-MM-yyyy"))
                    Else
                        mainAnalysis.CrvViewer.ReportSource = ReportComplaint
                        ReportComplaint.SetParameterValue("Title", "Data Analys (Diagnosis with Patient Complaint) From:" & Format(Me.DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(Me.DateTo.Value, "dd-MM-yyyy"))
                    End If
                   
                End If
                ' ============================= Report on Tab History with diagnosis 2 ===================================
                If RadByMedicalHistory.Checked = True Then
                    Dim MedicalHistory As DataTable = DA_DiagnosisMedicalHistoryAnalys.SelectMedicalHistoryDateToDate(DateFrom.Value, DateTo.Value)
                    Dim RMedicalHistory As New ReportDiagnosisMedicalHistory
                    Dim RMedicalHistoryv1 As New ReportDiagnosisMedicalHistoryV1
                    RMedicalHistory.SetDataSource(MedicalHistory)
                    RMedicalHistoryv1.SetDataSource(MedicalHistory)
                    If ChViewDetialData.Checked = True Then
                        mainAnalysis.CrvViewer.ReportSource = RMedicalHistoryv1
                        RMedicalHistoryv1.SetParameterValue("Title", "Data Analys (Diagnosis with Patient Medical History) From: " & Format(DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(DateTo.Value, "dd-MM-yyyy"))
                    Else
                        mainAnalysis.CrvViewer.ReportSource = RMedicalHistory
                        RMedicalHistory.SetParameterValue("Title", "Data Analys (Diagnosis with Patient Medical History) From: " & Format(DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(DateTo.Value, "dd-MM-yyyy"))
                    End If

                   
                End If
                If RadByPhysical.Checked = True Then
                    Dim TblPysicalCheck As DataTable = DA_DiagnosisPhysicalAnalys.SelectPhysicalDateToDate(DateFrom.Value, DateTo.Value)
                    Dim RPhysicalChecka As New ReportDiagnosisPhysicalCheck
                    Dim RphysicalCheckv1 As New ReportDiagnosisPhysicalCheckV1

                    RPhysicalChecka.SetDataSource(TblPysicalCheck)
                    RphysicalCheckv1.SetDataSource(TblPysicalCheck)
                    If ChViewDetialData.Checked = True Then
                        mainAnalysis.CrvViewer.ReportSource = RphysicalCheckv1
                        RphysicalCheckv1.SetParameterValue("Title", "Data Analys (Diagnosis with Physical Check) From: " & Format(DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(DateTo.Value, "dd-MM-yyyy"))
                    Else
                        mainAnalysis.CrvViewer.ReportSource = RPhysicalChecka
                        RPhysicalChecka.SetParameterValue("Title", "Data Analys (Diagnosis with Physical Check) From: " & Format(DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(DateTo.Value, "dd-MM-yyyy"))
                    End If
                    
                End If

            End If
            If RadEachDiagnosis.Checked = True Then
                If RadByComplaint.Checked = True Then
                    Dim tblDiagnosisCompliant As DataTable = DA_DiagnosisComplaintAnalys.SelectComplaintWithDiagnosis(DateFrom.Value, DateTo.Value, cbodiagnosis.Text)
                    Dim ReportComplaint As New ReportDiagnosisComplaint
                    Dim ReportComplaintv1 As New ReportDiagnosisComplaintV1
                    ReportComplaint.SetDataSource(tblDiagnosisCompliant)
                    ReportComplaintv1.SetDataSource(tblDiagnosisCompliant)
                    If ChViewDetialData.Checked = True Then
                        mainAnalysis.CrvViewer.ReportSource = ReportComplaintv1
                        ReportComplaintv1.SetParameterValue("Title", "Data Analysis (Diagnosis with Patient Complaint) From:" & Format(Me.DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(Me.DateTo.Value, "dd-MM-yyyy"))
                    Else
                        mainAnalysis.CrvViewer.ReportSource = ReportComplaint
                        ReportComplaint.SetParameterValue("Title", "Data Analysis (Diagnosis with Patient Complaint) From:" & Format(Me.DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(Me.DateTo.Value, "dd-MM-yyyy"))
                    End If
                   
                End If
                If RadByMedicalHistory.Checked = True Then
                    Dim MedicalHistory As DataTable = DA_DiagnosisMedicalHistoryAnalys.SelectMedicalHistoryWithDiagnosis(DateFrom.Value, DateTo.Value, cbodiagnosis.Text)
                    Dim RMedicalHistory As New ReportDiagnosisMedicalHistory
                    Dim RMedicalHistoryv1 As New ReportDiagnosisMedicalHistoryV1
                    RMedicalHistory.SetDataSource(MedicalHistory)
                    RMedicalHistoryv1.SetDataSource(MedicalHistory)
                    If ChViewDetialData.Checked = True Then
                        mainAnalysis.CrvViewer.ReportSource = RMedicalHistoryv1
                        RMedicalHistoryv1.SetParameterValue("Title", "Data Analys (Diagnosis with Patient Medical History) From: " & Format(DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(DateTo.Value, "dd-MM-yyyy"))
                    Else
                        mainAnalysis.CrvViewer.ReportSource = RMedicalHistory
                        RMedicalHistory.SetParameterValue("Title", "Data Analys (Diagnosis with Patient Medical History) From: " & Format(DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(DateTo.Value, "dd-MM-yyyy"))
                    End If
                End If
                If RadByPhysical.Checked = True Then
                    Dim TblPysicalCheck As DataTable = DA_DiagnosisPhysicalAnalys.SelectPhysicalWithDiagnosis(DateFrom.Value, DateTo.Value, cbodiagnosis.Text)
                    Dim RPhysicalChecka As New ReportDiagnosisPhysicalCheck
                    Dim RphysicalCheckv1 As New ReportDiagnosisPhysicalCheckV1

                    RPhysicalChecka.SetDataSource(TblPysicalCheck)
                    RphysicalCheckv1.SetDataSource(TblPysicalCheck)
                    If ChViewDetialData.Checked = True Then
                        mainAnalysis.CrvViewer.ReportSource = RphysicalCheckv1
                        RphysicalCheckv1.SetParameterValue("Title", "Data Analys (Diagnosis with Physical Check) From: " & Format(DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(DateTo.Value, "dd-MM-yyyy"))
                    Else
                        mainAnalysis.CrvViewer.ReportSource = RPhysicalChecka
                        RPhysicalChecka.SetParameterValue("Title", "Data Analys (Diagnosis with Physical Check) From: " & Format(DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(DateTo.Value, "dd-MM-yyyy"))
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub RadEachProvince_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadEachProvince.CheckedChanged
        CboProvince.Enabled = RadEachProvince.Checked
    End Sub

    Private Sub RadEachComplaint_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadEachDiagnosis.CheckedChanged
        cbodiagnosis.Enabled = RadEachDiagnosis.Checked
    End Sub





    Private Sub RadOnePDiagnosis_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadOnePDiagnosis.CheckedChanged
        CboPDiagnosis.Enabled = RadOnePDiagnosis.Checked
    End Sub

    Private Sub btnParaExamViewer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParaExamViewer.Click
        MainApplicationForm.StatusLoading(True)
        VAL_OPTION_REPORT = 3
        Application.DoEvents()
        BgLoadAnalysis.RunWorkerAsync()

    End Sub
    Private Sub LoadingParaExamBlood()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadingParaExamBlood))
        Else

            ' Case data analysis with blood
            If RadParaAllDiagnosis.Checked = True Then
                Dim tblParaExam As DataTable = DA_DiagnosisParaBloodAnalys.SelectParaExamBloodByDateToDate(DateFrom.Value, DateTo.Value)
                Dim RParaBlood As New ReportParaWithBlood
                Dim RParaBloodV1 As New ReportParaWithBloodV1

                RParaBlood.SetDataSource(tblParaExam)
                RParaBloodV1.SetDataSource(tblParaExam)
                If ChViewDetialData.Checked = True Then
                    mainAnalysis.CrvViewer.ReportSource = RParaBloodV1
                    RParaBloodV1.SetParameterValue("Title", "Data Analysis (Para Exam with Diagnosis and Blood) From: " & Format(DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(DateTo.Value, "dd-MM-yyyy"))
                Else
                    mainAnalysis.CrvViewer.ReportSource = RParaBlood
                    RParaBlood.SetParameterValue("Title", "Data Analysis (Para Exam with Diagnosis and Blood) From: " & Format(DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(DateTo.Value, "dd-MM-yyyy"))
                End If
              
            End If
            If RadParaOneDiagnosis.Checked = True Then
                Dim tblParaExam As DataTable = DA_DiagnosisParaBloodAnalys.SelectParaExamBloodByDiagnosis(DateFrom.Value, DateTo.Value, cboParaDiagnosis.Text)
                Dim RParaBlood As New ReportParaWithBlood
                Dim RParaBloodV1 As New ReportParaWithBloodV1

                RParaBlood.SetDataSource(tblParaExam)
                RParaBloodV1.SetDataSource(tblParaExam)
                If ChViewDetialData.Checked = True Then
                    mainAnalysis.CrvViewer.ReportSource = RParaBloodV1
                    RParaBloodV1.SetParameterValue("Title", "Data Analysis (Para Exam with Diagnosis and Blood) From: " & Format(DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(DateTo.Value, "dd-MM-yyyy"))
                Else
                    mainAnalysis.CrvViewer.ReportSource = RParaBlood
                    RParaBlood.SetParameterValue("Title", "Data Analysis (Para Exam with Diagnosis and Blood) From: " & Format(DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(DateTo.Value, "dd-MM-yyyy"))
                End If
            End If

        End If
    End Sub
    Private Sub LoadingParaExamFibro()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadingParaExamFibro))
        Else
            If RadFibMotif.Checked = True Then
                Dim TblFibro As DataTable = DA_DiagnosisParaFibroAnalys.SelectFibroscopyDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
                Dim RParaFibro As New ReportDiagnosisFibroscopy
                Dim RParaFibroV1 As New ReportDiagnosisFibroscopyV1

                RParaFibro.SetDataSource(TblFibro)
                RParaFibroV1.SetDataSource(TblFibro)

                If ChViewDetialData.Checked = True Then
                    mainAnalysis.CrvViewer.ReportSource = RParaFibroV1
                    RParaFibroV1.SetParameterValue("Title", " Data Analysis (Para Exam with Motif's Fibroscopy) From: " & Format(DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(DateTo.Value, "dd-MM-yyyy"))
                Else
                    mainAnalysis.CrvViewer.ReportSource = RParaFibro
                    RParaFibro.SetParameterValue("Title", " Data Analysis (Para Exam with Motif's Fibroscopy) From: " & Format(DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(DateTo.Value, "dd-MM-yyyy"))
                End If
                
            End If
            If RadFibOneMotif.Checked = True Then
                Dim TblFibro As DataTable = DA_DiagnosisParaFibroAnalys.SelectFibroScopyWithMotif(DateFrom.Value.Date, DateTo.Value.Date, CboFibroMotif.Text)
                Dim RParaFibro As New ReportDiagnosisFibroscopy
                Dim RParaFibroV1 As New ReportDiagnosisFibroscopyV1

                RParaFibro.SetDataSource(TblFibro)
                RParaFibroV1.SetDataSource(TblFibro)

                If ChViewDetialData.Checked = True Then
                    mainAnalysis.CrvViewer.ReportSource = RParaFibroV1
                    RParaFibroV1.SetParameterValue("Title", " Data Analysis (Para Exam with Motif's Fibroscopy) From: " & Format(DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(DateTo.Value, "dd-MM-yyyy"))
                Else
                    mainAnalysis.CrvViewer.ReportSource = RParaFibro
                    RParaFibro.SetParameterValue("Title", " Data Analysis (Para Exam with Motif's Fibroscopy) From: " & Format(DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(DateTo.Value, "dd-MM-yyyy"))
                End If
            End If
        End If
    End Sub
    Private Sub LoadingParaExamNasogastro()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadingParaExamNasogastro))
        Else
            If RadNasoAllMotif.Checked = True Then
                Dim tblNaso As DataTable = DA_DiagnosisParaNasogasroAnalys.SelectNasogastroDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
                Dim RNasograstro As New ReportDiagnosisNasogastro
                RNasograstro.SetDataSource(tblNaso)
                mainAnalysis.CrvViewer.ReportSource = RNasograstro
                RNasograstro.SetParameterValue("Title", "Data Analysis (Para Exam with Motif's Nasogastro) From: " & Format(DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(DateTo.Value, "dd-MM-yyyy"))
            End If
            If RadNasoByMotif.Checked = True Then
                Dim tblNaso As DataTable = DA_DiagnosisParaNasogasroAnalys.SelectNasogastroWithMotif(DateFrom.Value.Date, DateTo.Value.Date, CboNasoMotif.Text)
                Dim RNasograstro As New ReportDiagnosisNasogastro
                RNasograstro.SetDataSource(tblNaso)
                mainAnalysis.CrvViewer.ReportSource = RNasograstro
                RNasograstro.SetParameterValue("Title", "Data Analysis (Para Exam with Motif's Nasogastro) From: " & Format(DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(DateTo.Value, "dd-MM-yyyy"))
            End If
        End If
    End Sub
    Private Sub LoadingParaExamColoscopy()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadingParaExamColoscopy))
        Else
            If RadColoAllDiagnosis.Checked = True Then
                Dim tblColo As DataTable = DA_DiagnosisParaColoscopyAnalys.SelelectColoDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
                Dim RColoscopy As New ReportDiagnosisColoscopy
                RColoscopy.SetDataSource(tblColo)
                mainAnalysis.CrvViewer.ReportSource = RColoscopy
                RColoscopy.SetParameterValue("Title", "Data Analysis (Para Exam with motif's Coloscopy) From: " & Format(DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(DateTo.Value, "dd-MM-yyyy"))
            End If
            If RadColoOneDiagnosis.Checked = True Then
                Dim tblColo As DataTable = DA_DiagnosisParaColoscopyAnalys.SelectColoscopyWithMotif(DateFrom.Value.Date, DateTo.Value.Date, cboColoMotify.Text)
                Dim RColoscopy As New ReportDiagnosisColoscopy
                RColoscopy.SetDataSource(tblColo)
                mainAnalysis.CrvViewer.ReportSource = RColoscopy
                RColoscopy.SetParameterValue("Title", "Data Analysis (Para Exam with motif's Coloscopy) From: " & Format(DateFrom.Value, "dd-MM-yyyy") & " To: " & Format(DateTo.Value, "dd-MM-yyyy"))
            End If
        End If
    End Sub

    Private Sub RadParaOneDiagnosis_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadParaOneDiagnosis.CheckedChanged
        cboParaDiagnosis.Enabled = RadParaOneDiagnosis.Checked
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnFibPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFibPrintPreview.Click
        MainApplicationForm.StatusLoading(True)
        VAL_OPTION_REPORT = 4
        Application.DoEvents()
        BgLoadAnalysis.RunWorkerAsync()
    End Sub

    Private Sub RadFibOneDiagnosis_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadFibOneMotif.CheckedChanged
        CboFibroMotif.Enabled = RadFibOneMotif.Checked
    End Sub

    Private Sub BtnNasoPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNasoPrintPreview.Click
        MainApplicationForm.StatusLoading(True)
        VAL_OPTION_REPORT = 5
        Application.DoEvents()
        BgLoadAnalysis.RunWorkerAsync()
    End Sub

    Private Sub RadNasoOneDiagnosis_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadNasoByMotif.CheckedChanged
        CboNasoMotif.Enabled = RadNasoByMotif.Checked
    End Sub

    Private Sub BtnColoPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnColoPrintPreview.Click
        MainApplicationForm.StatusLoading(True)
        VAL_OPTION_REPORT = 6
        Application.DoEvents()
        BgLoadAnalysis.RunWorkerAsync()

    End Sub

    Private Sub RadColoOneDiagnosis_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadColoOneDiagnosis.CheckedChanged
        cboColoMotify.Enabled = RadColoOneDiagnosis.Checked
    End Sub

    Private Sub BgLoadAnalysis_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadAnalysis.RunWorkerCompleted

        MainApplicationForm.StatusLoading(False)
        Application.DoEvents()

    End Sub

    Private Sub BgLoadAnalysis_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadAnalysis.DoWork
        If VAL_OPTION_REPORT = 1 Then
            LoadingProvince()
        ElseIf VAL_OPTION_REPORT = 2 Then
            LoadingAnalysisOther()
        ElseIf VAL_OPTION_REPORT = 3 Then
            LoadingParaExamBlood()
        ElseIf VAL_OPTION_REPORT = 4 Then
            LoadingParaExamFibro()
        ElseIf VAL_OPTION_REPORT = 5 Then
            LoadingParaExamNasogastro()
        ElseIf VAL_OPTION_REPORT = 6 Then
            LoadingParaExamColoscopy()
        End If
    End Sub

  
End Class