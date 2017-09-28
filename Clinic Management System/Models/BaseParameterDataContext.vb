Public Class BaseParameterDataContext
    Private ParameterDataContext As DataClassesDataContext
    Sub New()
        ParameterDataContext = New DataClassesDataContext
    End Sub
    ReadOnly Property GetParameterDataContext() As DataClassesDataContext
        Get
            Return ParameterDataContext
        End Get
    End Property
End Class
