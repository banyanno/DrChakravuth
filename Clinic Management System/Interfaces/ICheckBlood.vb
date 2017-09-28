Public Interface ICheckBlood
    Function InsertCheck(ByVal ObjCheck As Object) As Boolean
    Function UpdateAllObject() As Boolean
    Function InsertCheckResult(ByVal ObjCheckResult As Object) As Boolean
    Function GetObjCheckResult(ByVal ResultID As Integer) As Check_Result
End Interface
