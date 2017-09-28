

Partial Public Class DSExamination

    Partial Class tblechoconclusionDataTable

        Private Sub tblechoconclusionDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.conclusion_idColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class ColoDataTable

        Private Sub ColoDataTable_ColoRowChanging(ByVal sender As System.Object, ByVal e As ColoRowChangeEvent) Handles Me.ColoRowChanging

        End Sub

    End Class

    Partial Class tblrequestDataTable

        Private Sub tblrequestDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.coloColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class

Namespace DSExaminationTableAdapters
    
    Partial Public Class EchoConclusionTableAdapter
    End Class
End Namespace
