Imports System.Data.Common
Public Class ModelPatient
    Implements IPatient
    Private ParameterContext As BaseParameterDataContext
    Sub New()
        ParameterContext = New BaseParameterDataContext
    End Sub
    Public Function InsertConsultation(ByVal ObjConsult As Object) As Boolean Implements IPatient.InsertConsultation
        ParameterContext.GetParameterDataContext.Connection.Open()
        Dim PTransaction As DbTransaction = ParameterContext.GetParameterDataContext.Connection.BeginTransaction
        ParameterContext.GetParameterDataContext.Transaction = PTransaction
        Try
            ParameterContext.GetParameterDataContext.Consultations.InsertOnSubmit(ObjConsult)
            ParameterContext.GetParameterDataContext.SubmitChanges()
            PTransaction.Commit()
            ParameterContext.GetParameterDataContext.Connection.Close()
            Return True
        Catch ex As Exception
            PTransaction.Rollback()
            ParameterContext.GetParameterDataContext.Connection.Close()
            Return False
        Finally
            PTransaction = Nothing
        End Try
    End Function

    Public Function InsertPatient(ByVal ObjPatient As Object) As Boolean Implements IPatient.InsertPatient
        ParameterContext.GetParameterDataContext.Connection.Open()
        Dim PTransaction As DbTransaction = ParameterContext.GetParameterDataContext.Connection.BeginTransaction
        ParameterContext.GetParameterDataContext.Transaction = PTransaction
        Try
            ParameterContext.GetParameterDataContext.Patients.InsertOnSubmit(ObjPatient)
            ParameterContext.GetParameterDataContext.SubmitChanges()
            PTransaction.Commit()
            ParameterContext.GetParameterDataContext.Connection.Close()
            Return True
        Catch ex As Exception
            PTransaction.Rollback()
            ParameterContext.GetParameterDataContext.Connection.Close()
            Return False
        Finally
            PTransaction = Nothing
        End Try
    End Function
    Public Function UpdateAllObject() As Boolean Implements IPatient.UpdateAllObject
        ParameterContext.GetParameterDataContext.Connection.Open()
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
    Public Function GetObjPatient(ByVal PatientID As Integer) As Patient Implements IPatient.GetObjPatient
        Dim Obj = From Patient In ParameterContext.GetParameterDataContext.Patients Where Patient.Patient_ID = PatientID
        Return Obj.SingleOrDefault
    End Function
End Class
