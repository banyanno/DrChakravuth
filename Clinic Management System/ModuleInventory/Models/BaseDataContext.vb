Public Class BaseDataContext
    Private THIDataContext As InventoryDataContext
    Private THIDataContextUser As DataClassesUserManagmentDataContext


    Public Sub New()
        THIDataContext = New InventoryDataContext
        THIDataContextUser = New DataClassesUserManagmentDataContext
        THIDataContextOpticalShop = New DataClassesDataContext
    End Sub

    ReadOnly Property getTHIDataContext() As InventoryDataContext
        Get
            Return THIDataContext
        End Get
    End Property

    ReadOnly Property getTHIDataContextUserManagement() As DataClassesUserManagmentDataContext
        Get
            Return THIDataContextUser
        End Get
    End Property
   
End Class
