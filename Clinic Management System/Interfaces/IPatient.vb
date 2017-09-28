Public Interface IPatient
    Function InsertPatient(ByVal ObjPatient As Object) As Boolean
    Function InsertConsultation(ByVal ObjConsultation As Object) As Boolean
    Function UpdateAllObject() As Boolean
    Function GetObjPatient(ByVal PatientID As Integer) As Patient
End Interface
