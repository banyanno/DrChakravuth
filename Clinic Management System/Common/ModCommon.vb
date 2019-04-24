
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Module ModCommon
    Public Sub AddUserControl(ByVal PanelHeader As Panel, ByVal PanelMain As Panel, ByVal UI As UserControl, ByVal Info As String, ByVal VisHeader As Boolean)
        PanelMain.Cursor = Cursors.WaitCursor
        PanelHeader.Visible = VisHeader
        PanelMain.Controls.Clear()
        PanelMain.AutoScroll = True
        'PMainContainer.AutoScrollMinSize = New Size(UI.Width, UI.Height)
        UI.Dock = DockStyle.Fill
        PanelMain.Controls.Add(UI)
        PanelMain.Cursor = Cursors.Default
    End Sub
    Function GetRowIndexDataGrid(ByVal Grid As DataGridView) As Integer
        Return Grid.SelectedCells(0).RowIndex
    End Function
    Sub NumberAllRowHeaderDataGrid(ByVal Gr As DataGridView)

        'Add row header
        Dim j As Integer = 0
        For i As Integer = 0 To Gr.Rows.Count - 1
            j = i
            j = j + 1
            Gr.Rows(i).HeaderCell.Value = j.ToString
        Next
    End Sub
    Sub SetDisableKeyString(ByVal e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
    End Sub
    Sub SetDisableKey(ByVal e As KeyPressEventArgs)
        e.Handled = True
    End Sub
    Sub SetDisableKeyDelete(ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Delete Then
            e.Handled = True
        End If
    End Sub
    Function EmptyString(ByVal StringEmty As String) As String
        Return IIf(StringEmty = "", "0", StringEmty)
    End Function


    Sub SelectTabIndex(ByVal index As Integer, ByVal Tabselect As TabControl)
        Tabselect.SelectTab(index)
    End Sub


    'Check application running
    Public Function isRunning() As Boolean
        Dim Name As String = Process.GetCurrentProcess.ProcessName
        Dim allPro As Process() = Process.GetProcesses
        Dim i As Integer, j As Integer = 0
        For i = 0 To allPro.GetUpperBound(0)
            If allPro(i).ProcessName = Name Then
                j = j + 1
                If j = 2 Then
                    Return True
                End If
            End If
        Next
        Return False
    End Function

    Public Sub Merlin(Optional ByVal Msg As String = "", Optional ByVal Animation As String = "Explain")
        'Animation:
        ' Wave
        ' Read
        ' Pleased
        ' Write
        ' GetAttention
        ' Think
        ' Acknowledge
        ' DoMagic1
        'If myCharacter.Visible Then
        '    'myCharacter.StopAll()
        '    For i As Integer = 1 To 3
        '        myCharacter.Play(Animation)
        '    Next i
        '    myCharacter.IdleOn = True
        '    If Not Msg = "" Then myCharacter.Speak(Msg)
        'End If
    End Sub
    Public Sub showMerlin(ByVal x As Short, ByVal y As Short)
        'If frmMain.mnuAgent.Checked Then
        'myCharacter.Show()

        ''to botton right corner
        ''myCharacter.LanguageID = 9

        'myCharacter.MoveTo(x, y)

        'myCharacter.AutoPopupMenu = False
        'myCharacter.IdleOn = True

        ''Else
        '    myCharacter.Play("Wave")
        '    myCharacter.Hide()
        'End If
    End Sub
    ' User past paramenterfield to Crystal Report
    'Sub SetCurrentValuesForParameterField(ByVal myParameterFields As ParameterFields, ByVal myArrayList As ArrayList, ByVal parameterFields As String)
    '    Dim currentParameterValues As ParameterValues = New ParameterValues()
    '    For Each submittedValue As Object In myArrayList
    '        Dim myParameterDiscreteValue As ParameterDiscreteValue = New ParameterDiscreteValue()
    '        myParameterDiscreteValue.Value = submittedValue.ToString()
    '        currentParameterValues.Add(myParameterDiscreteValue)
    '    Next
    '    Dim myParameterField As ParameterField = myParameterFields(parameterFields)
    '    myParameterField.CurrentValues = currentParameterValues
    'End Sub

    ' Use for visible sub panel in SplitContainner
    Sub ShowSplitPanel(ByVal spContainer As SplitContainer, Optional ByVal con As Integer = 0)
        If con = 0 Then
            spContainer.Panel2Collapsed = False
            spContainer.Panel1Collapsed = True
        End If
        If con = 1 Then
            spContainer.Panel1Collapsed = False
            spContainer.Panel2Collapsed = True
        End If
    End Sub

    ' Use for chang connection string error when connection1 can't find 
    Sub ChangeConnectionStringProvider(ByVal newProvider As String)
        My.Settings.Item("TakeoDBConnectionString") = newProvider
    End Sub


    ' User past paramenterfield to Crystal Report
    Sub SetCurrentValuesForParameterField(ByVal myParameterFields As ParameterFields, ByVal myArrayList As ArrayList, ByVal parameterFields As String)
        Dim currentParameterValues As ParameterValues = New ParameterValues()
        For Each submittedValue As Object In myArrayList
            Dim myParameterDiscreteValue As ParameterDiscreteValue = New ParameterDiscreteValue()
            myParameterDiscreteValue.Value = submittedValue.ToString()
            currentParameterValues.Add(myParameterDiscreteValue)
        Next
        Dim myParameterField As ParameterField = myParameterFields(parameterFields)
        myParameterField.CurrentValues = currentParameterValues
    End Sub
    'Function GetDateServer() As Date
    '    Dim DServer As DataTable = da.GetDateServer
    '    For Each row As DataRow In DServer.Rows
    '        Return row("DateServer")
    '    Next
    'End Function


End Module
