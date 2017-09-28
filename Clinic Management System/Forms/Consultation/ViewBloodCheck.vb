'Public Class ViewBloodCheck
'    ''Dim DA_Result As New DSPAtientTableAdapters.Check_ResultsTableAdapter
'    Dim Consult As DoctorConsultation
'    Dim History As PrescriptionHistory
'    Sub New(ByVal FrmPreHistory As PrescriptionHistory)

'        ' This call is required by the Windows Form Designer.
'        InitializeComponent()
'        Me.History = FrmPreHistory
'        ' Add any initialization after the InitializeComponent() call.
'    End Sub
'    Sub New()

'        ' This call is required by the Windows Form Designer.
'        InitializeComponent()
'        ' Add any initialization after the InitializeComponent() call.

'    End Sub
'    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
'        ''Get Consult Item Value And Update with the new values
'        Dim CheckModel As New ModelCheckBlood
'        Dim ObjResult As New Check_Result
'        ''Get Consult Item Value
'        Dim Items As New DataTable
'        Items = DA_Result.GetDataByCheckNo(CInt(Me.txtCheckNo.Text))
'        Dim chkitem As New CheckBox
'        Dim txtbox As New TextBox
'        Dim itemname As String
'        Dim itemID As Integer = 0
'        ''Save these items values displayed on the form
'        For i As Integer = 0 To Items.Rows.Count - 1
'            itemID = itemID + 1
'            itemname = "item" & itemID
'            ObjResult = New Check_Result
'            ObjResult = CheckModel.GetObjCheckResult(Items.Rows(i).Item("Result_ID"))
'            ''chkitem = Me.Controls(itemname)
'            ''ObjResult.Checked = chkitem.Checked

'            If TypeOf Me.Controls(itemname) Is CheckBox Then
'                chkitem = Me.Controls(itemname)
'                ObjResult.Checked = chkitem.Checked
'            Else
'                txtbox = Me.Controls(itemname)
'                ObjResult.Note = txtbox.Text.ToString.Replace("'", "''")
'            End If


'            If CheckModel.UpdateAllObject = False Then
'                MsgBox("Failed to update the record of blood test", MsgBoxStyle.Exclamation)
'            End If
'        Next
'        MsgBox("One record of blood test was updated", MsgBoxStyle.Information)
'        History.RowChanged()
'        Me.Close()
'    End Sub

'    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
'        Me.Close()
'    End Sub

'    Private Sub ViewBloodCheck_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'        ''Get Consult Item Value
'        Dim Items As New DataTable
'        Items = DA_Result.GetDataByCheckNo(CInt(Me.txtCheckNo.Text))
'        Dim chkitem As New CheckBox
'        Dim txtbox As New TextBox
'        Dim itemname As String
'        Dim itemID As Integer = 0
'        ''Save these items values displayed on the form
'        For i As Integer = 0 To Items.Rows.Count - 1
'            itemID = itemID + 1
'            itemname = "item" & itemID
'            If i < 114 Then
'                chkitem = Me.Controls(itemname)
'                chkitem.Checked = Items.Rows(i).Item("Checked")
'            Else
'                item115.Text = Items.Rows(i).Item("Note")
'            End If

'        Next
'    End Sub

'    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
'        Dim DABlood As New DSPAtientTableAdapters.Check_ResultsTableAdapter
'        Dim RMBloodForm As New BloodForm
'        Dim TblBlood As DataTable = DABlood.GetDataByCheckNo(Me.txtCheckNo.Text)
'        ''RMBloodForm.SetDataSource(TblBlood)
'        RMBloodForm.SetParameterValue("phone", History.txtphone.Text.ToString)
'        RMBloodForm.SetParameterValue("Full_Name", History.txtname.Text.ToString)
'        RMBloodForm.SetParameterValue("Sex", History.txtsex.Text.ToString)
'        RMBloodForm.SetParameterValue("Age", History.txtage.Text)
'        RMBloodForm.SetParameterValue("DateCheck", Format(History.BloodCheckList.CurrentRow.Cells("Check_Date").Value, "dd/MM/yyyy"))
'        ''RMBloodForm.SetParameterValue("CheckDate", Now)


'        RMBloodForm.SetParameterValue("Check1", TblBlood.Rows(0).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check2", TblBlood.Rows(1).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check3", TblBlood.Rows(2).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check4", TblBlood.Rows(3).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check5", TblBlood.Rows(4).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check6", TblBlood.Rows(5).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check7", TblBlood.Rows(6).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check8", TblBlood.Rows(7).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check9", TblBlood.Rows(8).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check10", TblBlood.Rows(9).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check11", TblBlood.Rows(10).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check12", TblBlood.Rows(11).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check13", TblBlood.Rows(12).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check14", TblBlood.Rows(13).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check15", TblBlood.Rows(14).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check16", TblBlood.Rows(15).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check17", TblBlood.Rows(16).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check18", TblBlood.Rows(17).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check19", TblBlood.Rows(18).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check20", TblBlood.Rows(19).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check21", TblBlood.Rows(20).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check22", TblBlood.Rows(21).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check23", TblBlood.Rows(22).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check24", TblBlood.Rows(23).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check25", TblBlood.Rows(24).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check26", TblBlood.Rows(25).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check27", TblBlood.Rows(26).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check28", TblBlood.Rows(27).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check29", TblBlood.Rows(28).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check30", TblBlood.Rows(29).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check31", TblBlood.Rows(30).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check32", TblBlood.Rows(31).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check33", TblBlood.Rows(32).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check34", TblBlood.Rows(33).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check35", TblBlood.Rows(34).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check36", TblBlood.Rows(35).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check37", TblBlood.Rows(36).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check38", TblBlood.Rows(37).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check39", TblBlood.Rows(38).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check40", TblBlood.Rows(39).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check41", TblBlood.Rows(40).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check42", TblBlood.Rows(41).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check43", TblBlood.Rows(42).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check44", TblBlood.Rows(43).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check45", TblBlood.Rows(44).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check46", TblBlood.Rows(45).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check47", TblBlood.Rows(46).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check48", TblBlood.Rows(47).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check49", TblBlood.Rows(48).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check50", TblBlood.Rows(49).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check51", TblBlood.Rows(50).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check52", TblBlood.Rows(51).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check53", TblBlood.Rows(52).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check54", TblBlood.Rows(53).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check55", TblBlood.Rows(54).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check56", TblBlood.Rows(55).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check57", TblBlood.Rows(56).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check58", TblBlood.Rows(57).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check59", TblBlood.Rows(58).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check60", TblBlood.Rows(59).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check61", TblBlood.Rows(60).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check62", TblBlood.Rows(61).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check63", TblBlood.Rows(62).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check64", TblBlood.Rows(63).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check65", TblBlood.Rows(64).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check66", TblBlood.Rows(65).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check67", TblBlood.Rows(66).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check68", TblBlood.Rows(67).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check69", TblBlood.Rows(68).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check70", TblBlood.Rows(69).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check71", TblBlood.Rows(70).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check72", TblBlood.Rows(71).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check73", TblBlood.Rows(72).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check74", TblBlood.Rows(73).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check75", TblBlood.Rows(74).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check76", TblBlood.Rows(75).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check77", TblBlood.Rows(76).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check78", TblBlood.Rows(77).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check79", TblBlood.Rows(78).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check80", TblBlood.Rows(79).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check81", TblBlood.Rows(80).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check82", TblBlood.Rows(81).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check83", TblBlood.Rows(82).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check84", TblBlood.Rows(83).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check85", TblBlood.Rows(84).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check86", TblBlood.Rows(85).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check87", TblBlood.Rows(86).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check88", TblBlood.Rows(87).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check89", TblBlood.Rows(88).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check90", TblBlood.Rows(89).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check91", TblBlood.Rows(90).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check92", TblBlood.Rows(91).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check93", TblBlood.Rows(92).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check94", TblBlood.Rows(93).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check95", TblBlood.Rows(94).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check96", TblBlood.Rows(95).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check97", TblBlood.Rows(96).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check98", TblBlood.Rows(97).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check99", TblBlood.Rows(98).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check100", TblBlood.Rows(99).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check101", TblBlood.Rows(100).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check102", TblBlood.Rows(101).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check103", TblBlood.Rows(102).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check104", TblBlood.Rows(103).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check105", TblBlood.Rows(104).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check106", TblBlood.Rows(105).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check107", TblBlood.Rows(106).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check108", TblBlood.Rows(107).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check109", TblBlood.Rows(108).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check110", TblBlood.Rows(109).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check111", TblBlood.Rows(110).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check112", TblBlood.Rows(111).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check113", TblBlood.Rows(112).Item("Checked"))
'        RMBloodForm.SetParameterValue("Check114", TblBlood.Rows(113).Item("Checked"))
'        RMBloodForm.SetParameterValue("Note", TblBlood.Rows(114).Item("Note"))
'        Dim FViewer As New FormReportViewer
'        FViewer.CVForm.ReportSource = RMBloodForm
'        FViewer.ShowDialog()
'        FViewer.Close()
'        FViewer.Dispose()
'    End Sub

'    Private Sub item12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles item12.CheckedChanged

'    End Sub
'End Class