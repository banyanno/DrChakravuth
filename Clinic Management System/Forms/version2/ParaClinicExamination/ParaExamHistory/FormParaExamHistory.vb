Public Class FormParaExamHistory
    'Patient Infromation
    Dim DA_Patient As New DSPAtientTableAdapters.tblpatientTableAdapter
    '' Blood Check Item
    Dim DA_BloodItem As New DSPAtientTableAdapters.tblblooditemTableAdapter
    Dim DA_RequestBloodItem As New DSExaminationTableAdapters.tblrequestblooditemTableAdapter
    ' Request Exam
    Dim DA_Request As New DSExaminationTableAdapters.tblrequestTableAdapter

    Dim DA_Conclusion As New DSExaminationTableAdapters.tblconclusionTableAdapter
    ' FibroConclusion 
    Dim DA_FibroConclusion As New DSExaminationTableAdapters.tblfibroconclusionTableAdapter

    ' Nasocop Conclusion
    Dim DA_NasoConclusion As New DSExaminationTableAdapters.tblnasoconclusionTableAdapter

    ' Coloscopy Conclusion
    Dim DA_ConclustionColo As New DS_ParameterTableAdapters.tblConclusionOfColoscopyTableAdapter
    Dim DA_ColoConclusion As New DSExaminationTableAdapters.tblcoloconclusionTableAdapter

    ' Echo Conclusion   
    Dim DA_EchoConclusion As New DSExaminationTableAdapters.tblechoconclusionTableAdapter

    ' Scan
    Dim DA_Scan As New DSExaminationTableAdapters.tblscanTableAdapter

    ' M-R-I
    Dim DA_MRI As New DSExaminationTableAdapters.tblmriTableAdapter

    ' FirboScan
    Dim DA_FibroScan As New DSExaminationTableAdapters.tblfibroscanTableAdapter

    ' CF-Anapath
    Dim DA_CFAnapath As New DSExaminationTableAdapters.tblCFAnaPathTableAdapter

    ' Echo Conclustion
    Dim DA_Echo As New DSExaminationTableAdapters.tblechoTableAdapter

    Dim MaxRequestID As Long
    Private Sub FormParaExamHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboitem.DataSource = DA_BloodItem.SelectAllItems
        Me.cboitem.ValueMember = DA_BloodItem.SelectAllItems.Columns("item_id").ColumnName
        Me.cboitem.DisplayMember = DA_BloodItem.SelectAllItems.Columns("item_name").ColumnName
        cboitem.SelectedIndex = -1


        Me.cboFibroConclusion.DataSource = DA_Conclusion.SelectConclusion
        Me.cboFibroConclusion.ValueMember = DA_Conclusion.SelectConclusion.Columns("conclusion_id").ColumnName
        Me.cboFibroConclusion.DisplayMember = DA_Conclusion.SelectConclusion.Columns("conclusion_name").ColumnName
        cboFibroConclusion.SelectedIndex = -1

        Me.cboNasoConclusion.DataSource = DA_Conclusion.SelectConclusion
        Me.cboNasoConclusion.ValueMember = DA_Conclusion.SelectConclusion.Columns("conclusion_id").ColumnName
        Me.cboNasoConclusion.DisplayMember = DA_Conclusion.SelectConclusion.Columns("conclusion_name").ColumnName
        cboNasoConclusion.SelectedIndex = -1

        Me.cboColoConclusion.DataSource = DA_ConclustionColo.GetData
        Me.cboColoConclusion.ValueMember = DA_ConclustionColo.GetData.Columns("ConclusionID").ColumnName
        Me.cboColoConclusion.DisplayMember = DA_ConclustionColo.GetData.Columns("Conclusion").ColumnName
        cboColoConclusion.SelectedIndex = -1

        Me.cboEchoConclusion.DataSource = DA_Conclusion.SelectConclusion
        Me.cboEchoConclusion.ValueMember = DA_Conclusion.SelectConclusion.Columns("conclusion_id").ColumnName
        Me.cboEchoConclusion.DisplayMember = DA_Conclusion.SelectConclusion.Columns("conclusion_name").ColumnName
        cboEchoConclusion.SelectedIndex = -1
      
        MaxRequestID = DA_Request.SelectMaxID
        LblRequestID.Text = MaxRequestID + 1
    End Sub
    Sub GetRefreshBloodCheckItem(ByVal RequestID As Double)
        Me.BloodResultList.DataSource = DA_RequestBloodItem.SelectCheckItemByRequestID(RequestID)
    End Sub
    Public Sub LoadPatientInfo(ByVal patientID As Integer)
        Dim TblPatient As New DataTable
        TblPatient = DA_Patient.SelectPatientByID(patientID)
        If TblPatient.Rows.Count < 1 Then
            MsgBox("Patient record was not found", MsgBoxStyle.Information, "No Record Found")
            Exit Sub
        Else
            'txtno

            'Me.lblpatientid.Text = patientID
            Me.txtname.Text = TblPatient.Rows(0).Item("pname")
            Me.txtsex.Text = TblPatient.Rows(0).Item("pgender")
            Me.txtaddress.Text = TblPatient.Rows(0).Item("pcontactaddress")
            Me.txtno.Text = TblPatient.Rows(0).Item("patientid")
            Me.txtdatebirth.Text = TblPatient.Rows(0).Item("pAge")
        End If

    End Sub

    Private Sub btnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click
        Try
            If DA_RequestBloodItem.SelectItem(LblRequestID.Text, CInt(Me.cboitem.SelectedValue)).Rows.Count >= 1 Then
                MsgBox("This check item has been added already", MsgBoxStyle.Exclamation, "Existing Check Item")
            Else
                If LblRequestID.Text = "0" Then
                    DA_RequestBloodItem.InsertRequestItem(MaxRequestID + 1, CInt(Me.cboitem.SelectedValue), TxtBloodResult.Text)
                    GetRefreshBloodCheckItem(MaxRequestID + 1)
                    TxtBloodResult.Text = ""
                    cboitem.SelectedIndex = -1
                Else
                    DA_RequestBloodItem.InsertRequestItem(LblRequestID.Text, CInt(Me.cboitem.SelectedValue), TxtBloodResult.Text)
                    GetRefreshBloodCheckItem(LblRequestID.Text)
                    TxtBloodResult.Text = ""
                    cboitem.SelectedIndex = -1
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Please select patient No.", "Blood", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        'Delete Blood Check
        DA_RequestBloodItem.DeleteItemByRequestID(LblRequestID.Text)
        ' Delete FibroCon
        DA_FibroConclusion.DeleteConclusionByRequestID(LblRequestID.Text)
        ' Delete Naso
        DA_NasoConclusion.DeleteConclusionByRequestID(LblRequestID.Text)
        ' Delete Colo
        DA_ColoConclusion.DeleteConclusionByRequestID(LblRequestID.Text)
        ' Delete Echo
        DA_EchoConclusion.DeleteConclusionByRequestID(LblRequestID.Text)
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If MessageBox.Show("Do you want to save Para-exam history?", "Para-History", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ' Insert Request
            'If LblRequestID.Text = "0" Then
            DA_Request.InsertRequest(CLng(Me.txtno.Text), FormatDateTime(Me.dtrequest.Value.Date, DateFormat.ShortDate), 16, True, True, True, True, True, True, True, True, "Result Para exam from other place.", 0, CboDiagnosis.Text, True)
            'End If

            ' Insert Scan
            If Me.txtScan.Text.Trim <> "" Then
                SaveScan()
            End If
            ' Insert MRI
            If Me.txtmri.Text.Trim <> "" Then
                SaveMRI()
            End If
            ' Insert Fibro Scan
            If Me.txtfibroscan.Text.Trim <> "" Then
                SaveFibroScan()
            End If
            ' Insert CF-Anapath
            If Me.TxtCFAnapath.Text.Trim <> "" Then
                SaveCFAnapath()
            End If
            If Me.txtechomoreinfo.Text.Trim <> "" Then
                SaveConclustionEcho()
            End If
            MsgBox("The examination has been saved successfully", MsgBoxStyle.Information, "Examination Saved")
            Close()
        End If
        
    End Sub

    Sub SaveFibroConclusion()
        If DA_FibroConclusion.SelectConclusion(LblRequestID.Text, CInt(Me.cboFibroConclusion.SelectedValue)).Rows.Count > 0 Then
            MsgBox("The conclusion was added already", MsgBoxStyle.OkOnly, "Existing Conclusion")
        Else
            If LblRequestID.Text = "0" Then
                DA_FibroConclusion.Insert(LblRequestID.Text, CInt(Me.cboFibroConclusion.SelectedValue))
                GetFibroConclusion(LblRequestID.Text)
                cboFibroConclusion.SelectedIndex = -1
            Else
                DA_FibroConclusion.Insert(LblRequestID.Text, CInt(Me.cboFibroConclusion.SelectedValue))
                GetFibroConclusion(LblRequestID.Text)
                cboFibroConclusion.SelectedIndex = -1
            End If

        End If
    End Sub
    Sub GetFibroConclusion(ByVal RequestID As Double)
        Me.FibroConclusionList.DataSource = DA_FibroConclusion.SelectConclusionByRequestID(RequestID)
    End Sub
    Sub RemoveFibroConclusion()
        If Me.FibroConclusionList.SelectedItems.Count >= 1 Then
            If LblRequestID.Text = "0" Then
                DA_FibroConclusion.DeleteConclusion(CInt(Me.FibroConclusionList.CurrentRow.Cells("request_id").Value), CInt(Me.FibroConclusionList.CurrentRow.Cells("conclusion_id").Value))
                Me.FibroConclusionList.DataSource = DA_FibroConclusion.SelectConclusionByRequestID(LblRequestID.Text)
            Else
                DA_FibroConclusion.DeleteConclusion(LblRequestID.Text, CInt(Me.FibroConclusionList.CurrentRow.Cells("conclusion_id").Value))
                Me.FibroConclusionList.DataSource = DA_FibroConclusion.SelectConclusionByRequestID(LblRequestID.Text)
            End If
            
        End If
    End Sub


    Sub SaveNasoConclusion()
        If DA_NasoConclusion.SelectConclusion(LblRequestID.Text, CInt(Me.cboNasoConclusion.SelectedValue)).Rows.Count > 0 Then
            MsgBox("The conclusion was added already", MsgBoxStyle.OkOnly, "Existing Conclusion")
        Else
            If LblRequestID.Text = "0" Then
                DA_NasoConclusion.Insert(LblRequestID.Text, CInt(Me.cboNasoConclusion.SelectedValue))
                GetNasoConclustion(LblRequestID.Text)
                cboNasoConclusion.SelectedIndex = -1
            Else
                DA_NasoConclusion.Insert(LblRequestID.Text, CInt(Me.cboNasoConclusion.SelectedValue))
                GetNasoConclustion(LblRequestID.Text)
                cboNasoConclusion.SelectedIndex = -1
            End If
        End If
    End Sub
    Sub GetNasoConclustion(ByVal RequestID As Double)
        Me.NasoConclusionList.DataSource = DA_NasoConclusion.SelectConclusionByRequestID(RequestID)
    End Sub
    Sub RemoveNasoConclusion()
        If Me.NasoConclusionList.SelectedItems.Count >= 1 Then
            If LblRequestID.Text = "0" Then
                DA_NasoConclusion.DeleteConclusion(CInt(Me.NasoConclusionList.CurrentRow.Cells("request_id").Value), CInt(Me.NasoConclusionList.CurrentRow.Cells("conclusion_id").Value))
                Me.NasoConclusionList.DataSource = DA_NasoConclusion.SelectConclusionByRequestID(LblRequestID.Text)
            Else
                DA_NasoConclusion.DeleteConclusion(LblRequestID.Text, CInt(Me.NasoConclusionList.CurrentRow.Cells("conclusion_id").Value))
                Me.NasoConclusionList.DataSource = DA_NasoConclusion.SelectConclusionByRequestID(LblRequestID.Text)
            End If
            
        End If
    End Sub


    Sub SaveColoConclusion()
        If DA_ColoConclusion.SelectConclusion(LblRequestID.Text, CInt(Me.cboColoConclusion.SelectedValue)).Rows.Count > 0 Then
            MsgBox("The conclusion was added already", MsgBoxStyle.OkOnly, "Existing Conclusion")
        Else
            If LblRequestID.Text = "0" Then
                DA_ColoConclusion.Insert(LblRequestID.Text, CInt(Me.cboColoConclusion.SelectedValue))
                GetColoConclusion(LblRequestID.Text)
                cboColoConclusion.SelectedIndex = -1
            Else
                DA_ColoConclusion.Insert(LblRequestID.Text, CInt(Me.cboColoConclusion.SelectedValue))
                GetColoConclusion(LblRequestID.Text)
                cboColoConclusion.SelectedIndex = -1
            End If
        End If
    End Sub
    Sub GetColoConclusion(ByVal RequestID As Double)
        Me.ColoConclusionList.DataSource = DA_ColoConclusion.SelectConclusionByRequestID(RequestID)
    End Sub
    Sub RemoveColoConclusion()
        If Me.ColoConclusionList.SelectedItems.Count >= 1 Then
            If LblRequestID.Text = "0" Then
                DA_ColoConclusion.DeleteConclusion(CInt(Me.ColoConclusionList.CurrentRow.Cells("request_id").Value), CInt(Me.ColoConclusionList.CurrentRow.Cells("conclusion_id").Value))
                Me.ColoConclusionList.DataSource = DA_ColoConclusion.SelectConclusionByRequestID(LblRequestID.Text)
            Else
                DA_ColoConclusion.DeleteConclusion(LblRequestID.Text, CInt(Me.ColoConclusionList.CurrentRow.Cells("conclusion_id").Value))
                Me.ColoConclusionList.DataSource = DA_ColoConclusion.SelectConclusionByRequestID(LblRequestID.Text)
            End If
        End If
    End Sub


    Sub SaveEchoConclusion()
        If DA_EchoConclusion.SelectConclusion(LblRequestID.Text, CInt(Me.cboEchoConclusion.SelectedValue)).Rows.Count > 0 Then
            MsgBox("The conclusion was added already", MsgBoxStyle.OkOnly, "Existing Conclusion")
        Else
            DA_EchoConclusion.Insert(LblRequestID.Text, CInt(Me.cboEchoConclusion.SelectedValue))
            Me.EchoConclusionList.DataSource = DA_EchoConclusion.SelectConclusionByRequestID(LblRequestID.Text)
            cboEchoConclusion.SelectedIndex = -1
        End If
    End Sub
    Sub RemoveEchoConclusion()
        If Me.EchoConclusionList.SelectedItems.Count >= 1 Then
            DA_EchoConclusion.DeleteConclusion(CInt(Me.EchoConclusionList.CurrentRow.Cells("request_id").Value), CInt(Me.EchoConclusionList.CurrentRow.Cells("conclusion_id").Value))
            Me.EchoConclusionList.DataSource = DA_EchoConclusion.SelectConclusionByRequestID(MaxRequestID + 1)
        End If
    End Sub


    Sub SaveScan()
        'If LblRequestID.Text = "0" Then
        DA_Scan.InsertScan(LblRequestID.Text, Me.txtScan.Text)
        ''Else
        'DA_Scan.UpdateScan(txtScan.Text, LblRequestID.Text)
        ''End If

    End Sub
    Sub GetScan(ByVal RequestID As Double)
        Dim TblScan As DataTable = DA_Scan.SelectScanByRequestID(RequestID)
        For Each row As DataRow In TblScan.Rows
            txtScan.Text = row("scan")
        Next
    End Sub
    Sub SaveMRI()
        'If LblRequestID.Text = "0" Then
        DA_MRI.InsertMRI(LblRequestID.Text, Me.txtmri.Text)
        'Else
        '    DA_MRI.UpdateMRI(txtmri.Text, LblRequestID.Text)
        'End If

    End Sub
    Sub GetMRI(ByVal RequestID As Double)
        Dim tblMRI As DataTable = DA_MRI.SelectMRIByRequestID(RequestID)
        For Each row As DataRow In tblMRI.Rows
            txtmri.Text = row("mri")
        Next
    End Sub
    Sub SaveFibroScan()
        'If LblRequestID.Text = "0" Then
        DA_FibroScan.InsertFibroScan(LblRequestID.Text, Me.txtfibroscan.Text)
        'Else
        '    DA_FibroScan.UpdateFibroScan(Me.txtfibroscan.Text, LblRequestID.Text)
        'End If

    End Sub
    Sub GetFibroScan(ByVal RequestID As Double)
        Dim tblFibroScan As DataTable = DA_FibroScan.SelectFibroScanByRequestID(RequestID)
        For Each row In tblFibroScan.Rows
            txtfibroscan.Text = row("fibroscan")
        Next
    End Sub
    Sub SaveCFAnapath()
        'If LblRequestID.Text = "0" Then
        DA_CFAnapath.InsertCFAnapath(LblRequestID.Text, Me.TxtCFAnapath.Text)
        'Else
        '    DA_CFAnapath.UpdateCFAnapath(TxtCFAnapath.Text, LblRequestID.Text)
        'End If

    End Sub
    Sub GetCFAnapath(ByVal RequestID As Double)
        Dim tblCFAnapath As DataTable = DA_CFAnapath.GetDataByRequest_id(RequestID)
        For Each row In tblCFAnapath.Rows
            TxtCFAnapath.Text = row("CFAnaPath")
        Next
    End Sub
    Sub SaveConclustionEcho()
        'If LblRequestID.Text = "0" Then
        DA_EchoConclusion.InsertNewEchoConclustion(LblRequestID.Text, txtechomoreinfo.Text)
        'Else
        '    DA_EchoConclusion.UpdateEchoConclusion(txtechomoreinfo.Text, LblRequestID.Text)
        'End If
        DA_Echo.InsertEcho(LblRequestID.Text, CLng(Me.txtno.Text), dtrequest.Value.Date, "", "", "", "", "", "", "", "", "", "", txtechomoreinfo.Text, "", dtrequest.Value.Date, 1, "", "")
    End Sub
    Sub GetConclustionEcho(ByVal RequesId As Double)
        Dim Tbl As DataTable = DA_EchoConclusion.SelectConclusionByRequestID(RequesId)
        For Each row As DataRow In Tbl.Rows
            txtechomoreinfo.Text = row("conclusion_id")
        Next
    End Sub
    Private Sub BtnAddEchoConclusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddEchoConclusion.Click
        SaveEchoConclusion()
    End Sub

    Private Sub BtnRemoveEchoConclusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveEchoConclusion.Click
        RemoveEchoConclusion()
    End Sub

    Private Sub BtnAddColoConclusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddColoConclusion.Click
        SaveColoConclusion()
    End Sub

    Private Sub BtnRemoveColoConclusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveColoConclusion.Click
        RemoveColoConclusion()
    End Sub

    Private Sub BtnAddNasoConclusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNasoConclusion.Click
        SaveNasoConclusion()
    End Sub

    Private Sub BtnRemoveNasoConclusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveNasoConclusion.Click
        RemoveNasoConclusion()
    End Sub

    Private Sub BtnAddFibroConclusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddFibroConclusion.Click
        SaveFibroConclusion()
    End Sub

    Private Sub BtnRemoveFibroConclusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveFibroConclusion.Click
        RemoveFibroConclusion()
    End Sub

    Private Sub btnDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteItem.Click
        If BloodResultList.SelectedItems.Count = 0 Then Exit Sub
        If LblRequestID.Text = "0" Then
            DA_RequestBloodItem.DeleteCheckItem(LblRequestID.Text, CInt(Me.BloodResultList.CurrentRow.Cells("item_id").Value))
            GetRefreshBloodCheckItem(LblRequestID.Text)
        Else
            DA_RequestBloodItem.DeleteCheckItem(LblRequestID.Text, CInt(Me.BloodResultList.CurrentRow.Cells("item_id").Value))
            GetRefreshBloodCheckItem(LblRequestID.Text)
        End If

    End Sub
End Class