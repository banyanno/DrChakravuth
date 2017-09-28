Public Class Blood
    Dim DA_BloodItem As New DSPAtientTableAdapters.tblblooditemTableAdapter
    Dim DA_RequestBloodItem As New DSExaminationTableAdapters.tblrequestblooditemTableAdapter
    ' Request Exam
    Dim DA_Request As New DSExaminationTableAdapters.tblrequestTableAdapter
    Dim MaxRequestID As Long
    Private Sub Blood_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboitem.DataSource = DA_BloodItem.SelectAllItems
        Me.cboitem.ValueMember = DA_BloodItem.SelectAllItems.Columns("item_id").ColumnName
        Me.cboitem.DisplayMember = DA_BloodItem.SelectAllItems.Columns("item_name").ColumnName
        cboitem.SelectedIndex = -1
        MaxRequestID = DA_Request.SelectMaxID
    End Sub

    Private Sub btnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click
        Try
            If DA_RequestBloodItem.SelectItem(MaxRequestID + 1, CInt(Me.cboitem.SelectedValue)).Rows.Count >= 1 Then
                MsgBox("This check item has been added already", MsgBoxStyle.Exclamation, "Existing Check Item")
            Else
                If LblRequestID.Text = "0" Then
                    DA_RequestBloodItem.InsertRequestItem(MaxRequestID + 1, CInt(Me.cboitem.SelectedValue), TxtBloodResult.Text)
                    GetRefreshBloodCheckItem(MaxRequestID + 1)
                    TxtBloodResult.Text = ""
                    cboitem.SelectedIndex = -1
                Else
                    DA_RequestBloodItem.InsertRequestItem(LblRequestID.Text, CInt(Me.cboitem.SelectedValue), TxtBloodResult.Text)
                    GetRefreshBloodCheckItem(LblRequestID.Text)
                    TxtBloodResult.Text = ""
                    cboitem.SelectedIndex = -1
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Please select patient No.", "Blood", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub GetRefreshBloodCheckItem(ByVal RequestID As Double)
        Me.BloodResultList.DataSource = DA_RequestBloodItem.SelectCheckItemByRequestID(RequestID)
    End Sub

    Private Sub btnDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteItem.Click
        If BloodResultList.SelectedItems.Count = 0 Then Exit Sub
        If LblRequestID.Text = "0" Then
            DA_RequestBloodItem.DeleteCheckItem(MaxRequestID + 1, CInt(Me.BloodResultList.CurrentRow.Cells("item_id").Value))
            GetRefreshBloodCheckItem(MaxRequestID + 1)
        Else
            DA_RequestBloodItem.DeleteCheckItem(LblRequestID.Text, CInt(Me.BloodResultList.CurrentRow.Cells("item_id").Value))
            GetRefreshBloodCheckItem(LblRequestID.Text)
        End If
    End Sub
End Class