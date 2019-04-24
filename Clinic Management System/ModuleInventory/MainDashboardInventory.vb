Public Class MainDashboardInventory
    Public LabourFac As UCLabourFactory
    Public Chemical As UCChemical
    Public UContainer As UCContainer
    Public UItemUnit As UCItemUnit
    Public UVendor As UCVendor
    Public UCate As UCCategories
    Public UReceiveProduct As ReceivedItem
    Public UFixAsset As UFixInventory
    Public UCabinet As UCCabinet
    Public URequestOrderDep As New UCRequestOrder_V1
    Public UReciepReques As UCReceivedRequest
    Dim UDepToDep As UCDepartReceivedRequest
    Dim UDepartmentCurrenstock As UCDepartCurrentStock
    Dim UVendor_V1 As UCVendor_V1
    Dim UDashboardAdjustStock As UCDashboardAdjustStock
    Dim UCaritasRequestOrder As UCCaritasRequestOrder
    Dim UCountry As UCCountry
    Dim UItemExpiredDate As UCItemExpiredDate
    Dim URunEOD As UCRunEndOfDay
    Dim UShowAllItemBalacne As UIShowAllItemBalanceInDeppartment
    Dim UInhouseUsedITem As UCInhouseUsedItem
    Dim UBarcode As UIBarcodeGenerator
    Dim UReportItemTransaction As UCReportItemTransaction
    Dim UItemMigration As New ItemMigration
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitUserControle()
    End Sub
    Sub InitUserControle()
     
     
        ' UShowAllItemBalacne = New UIShowAllItemBalanceInDeppartment(Me)
        'Login.UpdateLabelStatus("Creating user interface 26.", True)
        Application.DoEvents()
        UInhouseUsedITem = New UCInhouseUsedItem
        'Login.UpdateLabelStatus("Creating user interface 27.", True)
        Application.DoEvents()
        UBarcode = New UIBarcodeGenerator
        'Login.UpdateLabelStatus("Creating user interface 28.", True)
        Application.DoEvents()
        UReportItemTransaction = New UCReportItemTransaction() '(Me)
        ' Login.UpdateLabelStatus("Creating user interface 29.", True)
        Application.DoEvents()


        '=========== Checking user interface
        Department = New UCDepartment
        ' Login.UpdateLabelStatus("Creating user interface 30.", True)
        Application.DoEvents()
        LabourFac = New UCLabourFactory
        ' Login.UpdateLabelStatus("Creating user interface 31.", True)
        Application.DoEvents()
        Chemical = New UCChemical
        ' Login.UpdateLabelStatus("Creating user interface 32.", True)
        Application.DoEvents()
        UContainer = New UCContainer
        ' Login.UpdateLabelStatus("Creating user interface 33.", True)
        Application.DoEvents()
        UItemUnit = New UCItemUnit
        'Login.UpdateLabelStatus("Creating user interface 34.", True)
        Application.DoEvents()
        UVendor = New UCVendor
        ' Login.UpdateLabelStatus("Creating user interface 35.", True)
        Application.DoEvents()
        UCate = New UCCategories
        'Login.UpdateLabelStatus("Create interface Fix asset", True)
        UFixAsset = New UFixInventory
        Application.DoEvents()
        'Login.UpdateLabelStatus("Creating user interface 36.", True)
        Application.DoEvents()
        UCabinet = New UCCabinet
       

       
        UReciepReques = New UCReceivedRequest
        ' Login.UpdateLabelStatus("Creating user interface 41.", True)
        Application.DoEvents()
        UDepToDep = New UCDepartReceivedRequest
        'Login.UpdateLabelStatus("Creating user interface 42.", True)
        Application.DoEvents()
        'UDepartmentCurrenstock = New UCDepartCurrentStock(Me)
        'UDepartmentCurrenstock = New UCDepartCurrentStock(Me)
        'Login.UpdateLabelStatus("Creating user interface 43.", True)
        Application.DoEvents()
        ' Login.UpdateLabelStatus("Creating user interface 44.", True)
      
        Application.DoEvents()
        ' DashBordMedicalCertificate = New MainMedicalCertificate(Me)
        UVendor_V1 = New UCVendor_V1
        Application.DoEvents()
        UDashboardAdjustStock = New UCDashboardAdjustStock
        'Login.UpdateLabelStatus("Creating user interface 46.", True)
        Application.DoEvents()
        'UPrescriptionList = New UCPrescriptionList(Me)
        Application.DoEvents()
        ' UMedicineOutsideHospital = New UCMedicineOutsideHospital
        'Login.UpdateLabelStatus("Creating user interface 47.", True)
        'Application.DoEvents()
        ' UAppointment = New UCAppointment()
        Application.DoEvents()
        ' Login.UpdateLabelStatus("Creating user interface 47", True)
        UCaritasRequestOrder = New UCCaritasRequestOrder
        ' Login.UpdateLabelStatus("Creating user interface 48.", True)
        Application.DoEvents()
        UCountry = New UCCountry
        ' Login.UpdateLabelStatus("Creating user interface 49.", True)
        Application.DoEvents()
        UReceiveProduct = New ReceivedItem
        ' Login.UpdateLabelStatus("Creating user interface 50.", True)
        Application.DoEvents()
        ' UOPStatisticReport = New UCOpticalShopStatistic(UIMainScreening)
        ' Login.UpdateLabelStatus("It is done creatint user interface.", True)
        ' Application.DoEvents()
        'UDasboardNil = New UCDashBoardNil(Me)
        ' AccountPayAble = New UCMainAcountPayable(Me)
        'Login.UpdateLabelStatus("Creating user interface.", True)
        ' Application.DoEvents()

        'UItemExpiredDate = New UCItemExpiredDate(Me)
        ' Login.UpdateLabelStatus("Creating user interface.", True)
        Application.DoEvents()
        Application.DoEvents()
        URunEOD = New UCRunEndOfDay

        DEP_EOD = URunEOD
        '=============== Start Screening Interface ======================================
        'Login.UpdateLabelStatus("Creating user interface.", True)
        'Application.DoEvents()
        'ScreenDashboard = New DashboardScreeningRegisBook

        'Login.UpdateLabelStatus("Create user interface.", True)
        'Application.DoEvents()
        'ScreenSetting = New DashboardSetting
        'Login.UpdateLabelStatus("Create User interface.", True)
        'Application.DoEvents()
        'DashReportUtility = New DashboardReportUtility
    End Sub

    Private Sub btnProductList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProductList.Click
        AddUserControl(FormMainInventory.PanelHeader, FormMainInventory.PanelDedail, Me.UCate, "", True)
    End Sub

    Private Sub BtnReceiveProduction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReceiveProduction.Click
        AddUserControl(FormMainInventory.PanelHeader, FormMainInventory.PanelDedail, Me.UReceiveProduct, "", True)
    End Sub

    Private Sub BtnVender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVender.Click
        AddUserControl(FormMainInventory.PanelHeader, FormMainInventory.PanelDedail, Me.UVendor_V1, "", True)
    End Sub

 

    Private Sub BtnRunEOD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRunEOD.Click

        AddUserControl(FormMainInventory.PanelHeader, FormMainInventory.PanelDedail, Me.URunEOD, "", True)
    End Sub

    Private Sub BtnInHouseUsed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInHouseUsed.Click

        AddUserControl(FormMainInventory.PanelHeader, FormMainInventory.PanelDedail, Me.UInhouseUsedITem, "", True)
    End Sub

    Private Sub BtnAdjustProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdjustProduct.Click
        AddUserControl(FormMainInventory.PanelHeader, FormMainInventory.PanelDedail, Me.UDashboardAdjustStock, "", True)
        'GeneralAddControl(uiPanelMainContainer, UDashboardAdjustStock, "Department items adjust stock.")
    End Sub

    
    Private Sub BtnTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTransaction.Click
        AddUserControl(FormMainInventory.PanelHeader, FormMainInventory.PanelDedail, Me.UReportItemTransaction, "", True)
        ' GeneralAddControl(uiPanelMainContainer, UReportItemTransaction, "Reports Item Transaction Information.")
    End Sub

    Private Sub BtnInventoryMigration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInventoryMigration.Click
        'AddUserControl(FormMainInventory.PanelHeader, FormMainInventory.PanelDedail, Me.UItemMigration, "", True)
    End Sub
End Class
