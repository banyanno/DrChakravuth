Public Class ExaminationStatus
    Dim DA_Request As New DSExaminationTableAdapters.tblrequestTableAdapter
    Dim DA_Biology As New DSExaminationTableAdapters.tblrequestblooditemTableAdapter
    Dim DA_Fibro As New DSExaminationTableAdapters.tblfibroscopyTableAdapter
    Dim DA_Naso As New DSExaminationTableAdapters.tblnasogastroTableAdapter
    Dim DA_Colo As New DSExaminationTableAdapters.tblcoloscopyTableAdapter
    Dim DA_Echo As New DSExaminationTableAdapters.tblechoTableAdapter
    Dim DA_ItemResult As New DSExaminationTableAdapters.tblrequestblooditemTableAdapter
    Dim DA_Scan As New DSExaminationTableAdapters.tblscanTableAdapter
    Dim DA_FibroScan As New DSExaminationTableAdapters.tblfibroscanTableAdapter
    Dim DA_MRI As New DSExaminationTableAdapters.tblmriTableAdapter

    Dim RequestPanel As DashbordDotorRequestExamination
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal PanelRequest As DashbordDotorRequestExamination)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.RequestPanel = PanelRequest
    End Sub
    Private Sub ExaminationStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LoadStatusExam(CLng(Me.RequestPanel.gridRequestList.GetRow.Cells("request_id").Value))
        Catch ex As Exception

        End Try

    End Sub
    Sub LoadStatusExam(ByVal RequestNo As Double)
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
            Me.RequestPanel.Refresh()
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

            For j As Integer = 0 To ExamList.Count - 1
                If ExamList.Item(j) = "Biology" Then
                    If DA_Biology.SelectByRequestResult(requestid).Rows.Count >= 1 Then
                        ExamStatus.Add("Finished")
                    Else
                        ExamStatus.Add("Not yet")
                    End If
                End If
                If ExamList.Item(j) = "Fibroscopy" Then
                    If DA_Fibro.SelectFibroByRequestID(requestid).Rows.Count >= 1 Then
                        ExamStatus.Add("Finished")
                    Else
                        ExamStatus.Add("Not yet")
                    End If
                End If
                If ExamList.Item(j) = "Nasogastro" Then
                    If DA_Naso.SelectNasoByRequestID(requestid).Rows.Count >= 1 Then
                        ExamStatus.Add("Finished")
                    Else
                        ExamStatus.Add("Not yet")
                    End If
                End If
                If ExamList.Item(j) = "Coloscopy" Then
                    If DA_Colo.SelectColoByRequestID(requestid).Rows.Count >= 1 Then
                        ExamStatus.Add("Finished")
                    Else
                        ExamStatus.Add("Not yet")
                    End If
                End If
                If ExamList.Item(j) = "Echo" Then
                    If DA_Echo.SelectEchoByRequestID(requestid).Rows.Count >= 1 Then
                        ExamStatus.Add("Finished")
                    Else
                        ExamStatus.Add("Not yet")
                    End If
                End If
                If ExamList.Item(j) = "Scan" Then
                    If DA_Scan.SelectScanByRequestID(requestid).Rows.Count >= 1 Then
                        ExamStatus.Add("Finished")
                    Else
                        ExamStatus.Add("Not yet")
                    End If
                End If
                If ExamList.Item(j) = "M-R-I" Then
                    If DA_MRI.SelectMRIByRequestID(requestid).Rows.Count >= 1 Then
                        ExamStatus.Add("Finished")
                    Else
                        ExamStatus.Add("Not yet")
                    End If
                End If
                If ExamList.Item(j) = "Fibro Scan" Then
                    If DA_FibroScan.SelectFibroScanByRequestID(requestid).Rows.Count >= 1 Then
                        ExamStatus.Add("Finished")
                    Else
                        ExamStatus.Add("Not yet")
                    End If
                End If
            Next
            StatusList.Rows.Clear()
            For x As Integer = 0 To ExamList.Count - 1
                Me.StatusList.Rows.Add()
                Me.StatusList.Rows(x).Cells(0).Value = ExamList(x)
                Me.StatusList.Rows(x).Cells(1).Value = ExamStatus(x)
                'Me.StatusList.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True
                'Me.StatusList.AddItem(x).Cells("ExaminationName").Value = ExamList(x)
                'Me.StatusList.AddItem(x).Cells("Status").Value = ExamStatus(x)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class