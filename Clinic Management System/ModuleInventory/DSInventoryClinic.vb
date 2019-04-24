

Partial Public Class DSInventoryClinic
    Partial Class ReceiveItemTemDedtailDataTable

        Private Sub ReceiveItemTemDedtailDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.UNIT_QTY_UNIT_RECIEVEColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
