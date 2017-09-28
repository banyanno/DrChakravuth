Public Interface IAppointment
    Function InsertAppointment(ByVal ObjAppointment As Object) As Boolean
    Function UpdateAllObject() As Boolean
    Function GetObjAppointment(ByVal AppointID As Integer) As Appointment
End Interface
