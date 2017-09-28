Public Class NewMedicalHistory
    Dim DA_History As New DSPAtientTableAdapters.tblhistoryTableAdapter
    Dim History As UCMedical
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
   


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateTextField(Me.TxtHistoryName, "", Err) = False Then Exit Sub
        If Me.LblSaveOption.Text = 0 Then
            If MessageBox.Show("Do you want to save new medical history ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_History.InsertHistory(Me.TxtHistoryName.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            End If
           
        Else
            If MsgBox("Are you sure you want to update this patient complaint?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If DA_History.UpdateHistory(Me.TxtHistoryName.Text, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class