

Partial Public Class DSInvoice
    Partial Class ScanDataTable

        Private Sub ScanDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.scanColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class PhysicalExamDataTable

        Private Sub PhysicalExamDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.physicalcheckdetailidColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class PrescriptionDetailDataTable

        Private Sub PrescriptionDetailDataTable_PrescriptionDetailRowChanging(ByVal sender As System.Object, ByVal e As PrescriptionDetailRowChangeEvent) Handles Me.PrescriptionDetailRowChanging

        End Sub

    End Class

End Class

Namespace DSInvoiceTableAdapters
    
    Partial Class tblprescriptionTableAdapter

    End Class

    Partial Class PrescriptionDetailTableAdapter

    End Class

    Partial Public Class Invoice3TableAdapter
    End Class
End Namespace
