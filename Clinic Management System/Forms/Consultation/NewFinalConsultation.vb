Public Class NewFinalConsultation
    Dim DA_Patient As New DSPAtientTableAdapters.tblpatientTableAdapter
    Dim DA_Doctor As New DSPAtientTableAdapters.DoctorsTableAdapter
    Dim History As PrescriptionHistory
    Sub New(ByVal FrmPreHistory As PrescriptionHistory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.History = FrmPreHistory
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub NewFinalConsultation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim PatientData As New DataTable
        PatientData = DA_Patient.SelectPatientByID(Me.txtPatientID.Text)
        Me.lblname.Text = PatientData.Rows(0).Item("pname").ToString
        Me.lblage.Text = Year(Now) - Year(PatientData.Rows(0).Item("pAge"))
        Me.lblsex.Text = PatientData.Rows(0).Item("pgender").ToString
        Me.lblid.Text = PatientData.Rows(0).Item("patientid").ToString
        Me.lbladdress.Text = PatientData.Rows(0).Item("pcontactaddress").ToString
        Me.cbodoctor.DataSource = DA_Doctor.GetData
        Me.cbodoctor.DisplayMember = DA_Doctor.GetData.Columns("Doctor_Name").ColumnName

        ''Get Category
        Dim DA_Category As New DSPAtientTableAdapters.Consult_CategoriesTableAdapter
        Dim Categories As New DataTable
        Categories = DA_Category.GetDataByDisease(3)
        Me.lblCategory1.Text = Categories.Rows(0).Item("Category_Description").ToString
        Me.lblCategory2.Text = Categories.Rows(1).Item("Category_Description").ToString
        Me.lblCategory3.Text = Categories.Rows(2).Item("Category_Description").ToString
        Me.lblCategory4.Text = Categories.Rows(3).Item("Category_Description").ToString
        Me.lblCategory5.Text = Categories.Rows(4).Item("Category_Description").ToString
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim ObjConsult As New Consultation_Detail
        Dim ObjConsultResult As New Consultation_Result
        Dim ModelConsult As New ModelConsultation
        ObjConsult.prescriptionid = History.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value
        ObjConsult.Patient_ID = Me.txtPatientID.Text
        ObjConsult.Disease_ID = 3
        ObjConsult.User_Create = Me.cbodoctor.SelectedValue
        ObjConsult.Consult_Date = Me.dtdate.Value
        If ModelConsult.InsertConsultation(ObjConsult) = True Then
            Dim DA_Consult As New DSPAtientTableAdapters.Consultation_DetailsTableAdapter
            Dim ConsultTable As New DataTable
            Dim ConsultID As New Integer
            ConsultID = DA_Consult.GetMaxID
            'ConsultID = ConsultTable.Rows(0).Item(0)

            Dim chkitem As New CheckBox
            Dim txtbox As New TextBox
            Dim itemname As String
            Dim itemID As Integer = 0


            ''Get Items in Category1
            Dim DA_Item As New DSPAtientTableAdapters.Category_ItemsTableAdapter
            'Get Items in Category1
            Dim Cat1Items As New DataTable
            Cat1Items = DA_Item.GetDataByCategory(Me.lblCategory1.Text, 3)
            ''Save these items values displayed on the form
            For i As Integer = 0 To Cat1Items.Rows.Count - 1
                itemID = itemID + 1
                itemname = "item" & itemID
                ObjConsultResult = New Consultation_Result
                ObjConsultResult.PConsult_No = ConsultID
                ObjConsultResult.Item_ID = Cat1Items.Rows(i).Item("Item_ID")
                If TypeOf Me.Controls(itemname) Is CheckBox Then
                    chkitem = Me.Controls(itemname)
                    ObjConsultResult.Is_Yes = chkitem.Checked
                    ObjConsultResult.Result_Text = ""
                Else
                    ObjConsultResult.Is_Yes = False
                    ObjConsultResult.Result_Text = Me.Controls(itemname).Text.Replace("'", "''")
                End If
                If ModelConsult.InsertConsultationResult(ObjConsultResult) = False Then
                    MsgBox("Failed to save item in category 1")
                End If

            Next


            ''Get Items in Category2
            Dim Cat2Items As New DataTable
            Cat2Items = DA_Item.GetDataByCategory(Me.lblCategory2.Text, 3)
            ''Save these items values displayed on the form
            For i As Integer = 0 To Cat2Items.Rows.Count - 1
                itemID = itemID + 1
                itemname = "item" & itemID
                ObjConsultResult = New Consultation_Result
                ObjConsultResult.PConsult_No = ConsultID
                ObjConsultResult.Item_ID = Cat2Items.Rows(i).Item("Item_ID")
                If TypeOf Me.Controls(itemname) Is CheckBox Then
                    chkitem = Me.Controls(itemname)
                    ObjConsultResult.Is_Yes = chkitem.Checked
                    ObjConsultResult.Result_Text = ""
                Else
                    ObjConsultResult.Is_Yes = False
                    ObjConsultResult.Result_Text = Me.Controls(itemname).Text.Replace("'", "''")
                End If
                If ModelConsult.InsertConsultationResult(ObjConsultResult) = False Then
                    MsgBox("Failed to save item in category 2")
                End If
            Next


            ''Get Items in Category3
            Dim Cat3Items As New DataTable
            Cat3Items = DA_Item.GetDataByCategory(Me.lblCategory3.Text, 3)
            ''Save these items values displayed on the form
            For i As Integer = 0 To Cat3Items.Rows.Count - 1
                itemID = itemID + 1
                itemname = "item" & itemID
                ObjConsultResult = New Consultation_Result
                ObjConsultResult.PConsult_No = ConsultID
                ObjConsultResult.Item_ID = Cat3Items.Rows(i).Item("Item_ID")
                If TypeOf Me.Controls(itemname) Is CheckBox Then
                    chkitem = Me.Controls(itemname)
                    ObjConsultResult.Is_Yes = chkitem.Checked
                    ObjConsultResult.Result_Text = ""
                Else
                    ObjConsultResult.Is_Yes = False
                    ObjConsultResult.Result_Text = Me.Controls(itemname).Text.Replace("'", "''")
                End If
                If ModelConsult.InsertConsultationResult(ObjConsultResult) = False Then
                    MsgBox("Failed to save item in category 3")
                End If
            Next


            ''Get Items in Category4
            Dim Cat4Items As New DataTable
            Cat4Items = DA_Item.GetDataByCategory(Me.lblCategory4.Text, 3)
            ''Save these items values displayed on the form
            For i As Integer = 0 To Cat4Items.Rows.Count - 1
                itemID = itemID + 1
                itemname = "item" & itemID
                ObjConsultResult = New Consultation_Result
                ObjConsultResult.PConsult_No = ConsultID
                ObjConsultResult.Item_ID = Cat4Items.Rows(i).Item("Item_ID")
                If TypeOf Me.Controls(itemname) Is CheckBox Then
                    chkitem = Me.Controls(itemname)
                    ObjConsultResult.Is_Yes = chkitem.Checked
                    ObjConsultResult.Result_Text = ""
                Else
                    ObjConsultResult.Is_Yes = False
                    ObjConsultResult.Result_Text = Me.Controls(itemname).Text.Replace("'", "''")
                End If
                If ModelConsult.InsertConsultationResult(ObjConsultResult) = False Then
                    MsgBox("Failed to save item in category 4")
                End If
            Next

            ''Get Items in Category5
            Dim Cat5Items As New DataTable
            Cat5Items = DA_Item.GetDataByCategory(Me.lblCategory5.Text, 3)
            ''Save these items values displayed on the form
            For i As Integer = 0 To Cat5Items.Rows.Count - 1
                itemID = itemID + 1
                itemname = "item" & itemID
                ObjConsultResult = New Consultation_Result
                ObjConsultResult.PConsult_No = ConsultID
                ObjConsultResult.Item_ID = Cat5Items.Rows(i).Item("Item_ID")
                If TypeOf Me.Controls(itemname) Is CheckBox Then
                    chkitem = Me.Controls(itemname)
                    ObjConsultResult.Is_Yes = chkitem.Checked
                    ObjConsultResult.Result_Text = ""
                Else
                    ObjConsultResult.Is_Yes = False
                    ObjConsultResult.Result_Text = Me.Controls(itemname).Text.Replace("'", "''")
                End If
                If ModelConsult.InsertConsultationResult(ObjConsultResult) = False Then
                    MsgBox("Failed to save item in category 5")
                End If
            Next
            MsgBox("One consultation record was added", vbInformation)
        Else
            MsgBox("Fail to save consultation record")
        End If
        History.RowChanged()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblCat2Item11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblCat3Item18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class