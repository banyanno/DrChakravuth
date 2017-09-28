Imports System.Data.Common
Public Class ModelConsultation
    Implements IConsultation
    Private ParameterContext As BaseParameterDataContext
    Sub New()
        ParameterContext = New BaseParameterDataContext
    End Sub
    Public Function InsertConsultation(ByVal ObjConsult As Object) As Boolean Implements IConsultation.InsertConsultation
        If ParameterContext.GetParameterDataContext.Connection.State = ConnectionState.Closed Then
            ParameterContext.GetParameterDataContext.Connection.Open()
        End If
        Dim Trn As DbTransaction = ParameterContext.GetParameterDataContext.Connection.BeginTransaction
        ParameterContext.GetParameterDataContext.Transaction = Trn
        Try
            ParameterContext.GetParameterDataContext.Consultation_Details.InsertOnSubmit(ObjConsult)
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
    Public Function UpdateAllObject() As Boolean Implements IConsultation.UpdateAllObject
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
    Public Function GetObjConsultation(ByVal ConsultNo As Integer) As Consultation_Detail Implements IConsultation.GetObjConsultation
        Dim Obj = From Consultation_Detail In ParameterContext.GetParameterDataContext.Consultation_Details Where Consultation_Detail.PConsult_No = ConsultNo
        Return Obj.SingleOrDefault
    End Function

    Public Function InsertConsultationResult(ByVal ObjResult As Object) As Boolean Implements IConsultation.InsertConsultationResult
        If ParameterContext.GetParameterDataContext.Connection.State = ConnectionState.Closed Then
            ParameterContext.GetParameterDataContext.Connection.Open()
        End If
        Dim Trn As DbTransaction = ParameterContext.GetParameterDataContext.Connection.BeginTransaction
        ParameterContext.GetParameterDataContext.Transaction = Trn
        Try
            ParameterContext.GetParameterDataContext.Consultation_Results.InsertOnSubmit(ObjResult)
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

    Public Function GetObjConsultationResult(ByVal ResultID As Integer) As Consultation_Result Implements IConsultation.GetObjConsultationResult
        Dim Obj = From Consultation_Result In ParameterContext.GetParameterDataContext.Consultation_Results Where Consultation_Result.Result_ID = ResultID
        Return Obj.SingleOrDefault
    End Function
End Class
