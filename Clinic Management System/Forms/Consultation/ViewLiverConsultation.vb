﻿Public Class ViewLiverConsultation
    Dim DA_Result As New DSPAtientTableAdapters.Consultation_ResultsTableAdapter
    Dim DA_Patient As New DSPAtientTableAdapters.tblpatientTableAdapter
    Dim DA_Doctor As New DSPAtientTableAdapters.DoctorsTableAdapter
    Dim DA_ConsultDetail As New DSPAtientTableAdapters.Consultation_DetailsTableAdapter
    Dim DConsultation As DoctorConsultation
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
    Private Sub ViewLiverConsultation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim PatientData As New DataTable
        PatientData = DA_Patient.SelectPatientByID(Me.txtPatientID.Text)
        Me.lblname.Text = PatientData.Rows(0).Item("pname").ToString
        Me.lblage.Text = Year(Now) - Year(PatientData.Rows(0).Item("pAge"))
        Me.lblsex.Text = PatientData.Rows(0).Item("pgender").ToString
        Me.lblid.Text = PatientData.Rows(0).Item("patientid").ToString
        Me.lbladdress.Text = PatientData.Rows(0).Item("pcontactaddress").ToString
        Me.cbodoctor.DataSource = DA_Doctor.GetData
        Me.cbodoctor.DisplayMember = DA_Doctor.GetData.Columns("Doctor_Name").ColumnName

        Dim DetailTable As New DataTable
        DetailTable = DA_ConsultDetail.GetDataByPConsultNo(Me.txtPConsultNo.Text)
        cbodoctor.SelectedValue = DetailTable.Rows(0).Item("User_Create")
        dtdate.Value = DetailTable.Rows(0).Item("Consult_Date")

        ''Get Category
        Dim DA_Category As New DSPAtientTableAdapters.Consult_CategoriesTableAdapter
        Dim Categories As New DataTable
        Categories = DA_Category.GetDataByDisease(2)
        Me.lblCategory1.Text = Categories.Rows(0).Item("Category_Description").ToString
        Me.lblCategory2.Text = Categories.Rows(1).Item("Category_Description").ToString
        Me.lblCategory3.Text = Categories.Rows(2).Item("Category_Description").ToString
        Me.lblCategory4.Text = Categories.Rows(3).Item("Category_Description").ToString
        Me.lblCategory5.Text = Categories.Rows(4).Item("Category_Description").ToString

        Dim DA_Item As New DSPAtientTableAdapters.Category_ItemsTableAdapter
        'Get Items in Category1
        Dim Cat1Items As New DataTable
        Cat1Items = DA_Item.GetDataByCategory(Me.lblCategory1.Text, 2)
        lblCat1Item1.Text = Cat1Items.Rows(0).Item("Item_Description").ToString
        lblCat1Item2.Text = Cat1Items.Rows(1).Item("Item_Description").ToString
        lblCat1Item3.Text = Cat1Items.Rows(2).Item("Item_Description").ToString
        lblCat1Item4.Text = Cat1Items.Rows(3).Item("Item_Description").ToString
        lblCat1Item5.Text = Cat1Items.Rows(4).Item("Item_Description").ToString
        lblCat1Item6.Text = Cat1Items.Rows(5).Item("Item_Description").ToString
        lblCat1Item7.Text = Cat1Items.Rows(6).Item("Item_Description").ToString
        lblCat1Item8.Text = Cat1Items.Rows(7).Item("Item_Description").ToString

        'Get Items in Category2
        Dim Cat2Items As New DataTable
        Cat2Items = DA_Item.GetDataByCategory(Me.lblCategory2.Text, 2)
        lblCat2Item9.Text = Cat2Items.Rows(0).Item("Item_Description").ToString
        lblCat2Item10.Text = Cat2Items.Rows(1).Item("Item_Description").ToString
        lblCat2Item11.Text = Cat2Items.Rows(2).Item("Item_Description").ToString
        lblCat2Item16.Text = Cat2Items.Rows(7).Item("Item_Description").ToString


        'Get Items in Category3
        Dim Cat3Items As New DataTable
        Cat3Items = DA_Item.GetDataByCategory(Me.lblCategory3.Text, 2)
        lblCat3Item17.Text = Cat3Items.Rows(0).Item("Item_Description").ToString
        lblCat3Item18.Text = Cat3Items.Rows(1).Item("Item_Description").ToString
        lblCat3Item19.Text = Cat3Items.Rows(2).Item("Item_Description").ToString
        lblCat3Item20.Text = Cat3Items.Rows(3).Item("Item_Description").ToString

        ''Get Items in Category4
        Dim Cat4Items As New DataTable
        Cat4Items = DA_Item.GetDataByCategory(Me.lblCategory4.Text, 2)
        'Me.item47.Name = Cat4Items.Rows(0).Item("Item_ID").ToString

        'Get Items in Category5
        Dim Cat5Items As New DataTable
        Cat5Items = DA_Item.GetDataByCategory(Me.lblCategory5.Text, 2)
        'Me.item48.Name = Cat5Items.Rows(0).Item("Item_ID").ToString


        ''Get Consult Item Value
        Dim Items As New DataTable
        Items = DA_Result.GetDataByPConsult_No(CInt(Me.txtPConsultNo.Text))
        Dim chkitem As New CheckBox
        Dim txtbox As New TextBox
        Dim itemname As String
        Dim itemID As Integer = 0
        ''Save these items values displayed on the form
        For i As Integer = 0 To Items.Rows.Count - 1
            itemID = itemID + 1
            itemname = "item" & itemID
            If TypeOf Me.Controls(itemname) Is CheckBox Then
                chkitem = Me.Controls(itemname)
                chkitem.Checked = Items.Rows(i).Item("Is_Yes")
            Else
                txtbox = Me.Controls(itemname)
                txtbox.Text = Items.Rows(i).Item("Result_Text")
            End If
        Next

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If MsgBox("Are you sure you want to update this consultation", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ''Get Consult Item Value And Update with the new values
            Dim ConsultModel As New ModelConsultation
            Dim ObjResult As New Consultation_Result
            ''Get Consult Item Value
            Dim Items As New DataTable
            Items = DA_Result.GetDataByPConsult_No(CInt(Me.txtPConsultNo.Text))
            Dim chkitem As New CheckBox
            Dim txtbox As New TextBox
            Dim itemname As String
            Dim itemID As Integer = 0
            ''Save these items values displayed on the form
            For i As Integer = 0 To Items.Rows.Count - 1
                itemID = itemID + 1
                itemname = "item" & itemID
                ObjResult = New Consultation_Result
                ObjResult = ConsultModel.GetObjConsultationResult(Items.Rows(i).Item("Result_ID"))
                If TypeOf Me.Controls(itemname) Is CheckBox Then
                    chkitem = Me.Controls(itemname)
                    ObjResult.Is_Yes = chkitem.Checked
                    ObjResult.Result_Text = ""
                    'StomachModel.UpdateConsultationItemValue(Items.Rows(i).Item("PConsult_ID"), Items.Rows(i).Item("Item_ID"), chkitem.Checked, "")
                Else
                    ObjResult.Is_Yes = False
                    ObjResult.Result_Text = Me.Controls(itemname).Text.Replace("'", "''")
                    'StomachModel.UpdateConsultationItemValue(Items.Rows(i).Item("PConsult_ID"), Items.Rows(i).Item("Item_ID"), False, txtbox.Text.Replace("'", "''"))
                End If
                If ConsultModel.UpdateAllObject = False Then
                    MsgBox("Failed to update consultation record", MsgBoxStyle.Exclamation)
                End If
            Next
            ''Update Consultation Detail
            DA_ConsultDetail.UpdateConsultDetail(dtdate.Value, cbodoctor.SelectedValue, Me.txtPConsultNo.Text)
            History.RowChanged()
            MsgBox("One consultation record was updated", MsgBoxStyle.Information)
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles item10.CheckedChanged

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCat2Item10.Click

    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCat2Item12.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles item12.CheckedChanged

    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click

    End Sub

    Private Sub lblCat2Item11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCat2Item11.Click

    End Sub

    Private Sub lblCat3Item18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCat3Item18.Click

    End Sub
End Class