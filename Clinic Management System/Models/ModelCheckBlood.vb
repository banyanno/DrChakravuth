Imports System.Data.Common
Public Class ModelCheckBlood
    Implements ICheckBlood
    Private ParameterContext As BaseParameterDataContext
    Sub New()
        ParameterContext = New BaseParameterDataContext
    End Sub
    Public Function GetObjCheckResult(ByVal ResultID As Integer) As Check_Result Implements ICheckBlood.GetObjCheckResult
        Dim Obj = From Check_Result In ParameterContext.GetParameterDataContext.Check_Results Where Check_Result.Result_ID = ResultID
        Return Obj.SingleOrDefault
    End Function

    Public Function InsertCheck(ByVal ObjCheck As Object) As Boolean Implements ICheckBlood.InsertCheck
        If ParameterContext.GetParameterDataContext.Connection.State = ConnectionState.Closed Then
            ParameterContext.GetParameterDataContext.Connection.Open()
        End If
        Dim Trn As DbTransaction = ParameterContext.GetParameterDataContext.Connection.BeginTransaction
        ParameterContext.GetParameterDataContext.Transaction = Trn
        Try
            ParameterContext.GetParameterDataContext.Check_Details.InsertOnSubmit(ObjCheck)
            ParameterContext.GetParameterDataContext.SubmitChanges()
            Trn.Commit()
            ParameterContext.GetParameterDataContext.Connection.Close()
            Return True
        Catch ex As Exception
            Trn.Rollback()
            ParameterContext.GetParameterDataContext.Connection.Close()
            Return False
        Finally
            Trn = Nothing
        End Try
    End Function

    Public Function InsertCheckResult(ByVal ObjCheckResult As Object) As Boolean Implements ICheckBlood.InsertCheckResult
        If ParameterContext.GetParameterDataContext.Connection.State = ConnectionState.Closed Then
            ParameterContext.GetParameterDataContext.Connection.Open()
        End If
        Dim Trn As DbTransaction = ParameterContext.GetParameterDataContext.Connection.BeginTransaction
        ParameterContext.GetParameterDataContext.Transaction = Trn
        Try
            ParameterContext.GetParameterDataContext.Check_Results.InsertOnSubmit(ObjCheckResult)
            ParameterContext.GetParameterDataContext.SubmitChanges()
            Trn.Commit()
            ParameterContext.GetParameterDataContext.Connection.Close()
            Return True
        Catch ex As Exception
            Trn.Rollback()
            ParameterContext.GetParameterDataContext.Connection.Close()
            Return False
        Finally
            Trn = Nothing
        End Try
    End Function

    Public Function UpdateAllObject() As Boolean Implements ICheckBlood.UpdateAllObject
        If (ParameterContext.GetParameterDataContext.Connection.State = ConnectionState.Closed) Then
            ParameterContext.GetParameterDataContext.Connection.Open()
        End If
        Dim Tran As DbTransaction = ParameterContext.GetParameterDataContext.Connection.BeginTransaction
        ParameterContext.GetParameterDataContext.Transaction = Tran
        Try
            ParameterContext.GetParameterDataContext.SubmitChanges()
            Tran.Commit()
            ParameterContext.GetParameterDataContext.Connection.Close()
            Return True
        Catch ex As Exception
            Tran.Rollback()
            ParameterContext.GetParameterDataContext.Connection.Close()
            Return False
        Finally
            Tran = Nothing
        End Try
    End Function
End Class
