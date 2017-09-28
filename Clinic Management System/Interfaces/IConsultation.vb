Public Interface IConsultation
    Function InsertConsultation(ByVal ObjConsultation As Object) As Boolean
    Function UpdateAllObject() As Boolean
    Function GetObjConsultation(ByVal ConsultID As Integer) As Consultation_Detail
    Function InsertConsultationResult(ByVal ObjConsultation As Object) As Boolean
    Function GetObjConsultationResult(ByVal ResultID As Integer) As Consultation_Result
End Interface
