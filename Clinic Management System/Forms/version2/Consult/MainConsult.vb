Public Class MainConsult
    Dim DA_Patient As New DSPAtientTableAdapters.tblpatientTableAdapter
    Dim DA_Item As New DSExaminationTableAdapters.tblblooditemTableAdapter
    Dim DA_Doctor As New DSPAtientTableAdapters.DoctorsTableAdapter
    Dim DA_Waiting As New DSPAtientTableAdapters.tblwaitingTableAdapter
    Dim UMainWaiting As MainWaitingConsuling
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal MWaiting As MainWaitingConsuling)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.UMainWaiting = MWaiting
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub SetPatientData()

        Dim Patient As New DataTable
        Patient = DA_Patient.SelectPatientByID(UMainWaiting.WaitingList.CurrentRow.Cells("ppatientid").Value)
        Me.txtno.Text = Patient.Rows(0).Item("patientid")
        Me.txtname.Text = Patient.Rows(0).Item("pname")
        Me.txtsex.Text = Patient.Rows(0).Item("pgender")
        Me.txtdatebirth.Text = Format(Patient.Rows(0).Item("pAge"), "dd/MM/yyyy")
        Me.txtaddress.Text = Patient.Rows(0).Item("pcontactaddress")
    End Sub
    Private Sub MainConsult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetPatientData()
        Dim DoctorTable As New DataTable
        Dim ItemTable As New DataTable
        DoctorTable = DA_Doctor.SelectDoctor
        ItemTable = DA_Item.SelectAllItems
        Me.cbodoctor.DataSource = DoctorTable
        Me.cboitem.DataSource = ItemTable
        Me.cbodoctor.DisplayMember = DoctorTable.Columns("Doctor_Name").ColumnName
        Me.cbodoctor.ValueMember = DoctorTable.Columns("Doctor_ID").ColumnName
        Me.cboitem.DisplayMember = ItemTable.Columns("item_id").ColumnName
        Me.cboitem.ValueMember = ItemTable.Columns("item_name").ColumnName
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbodoctor.SelectedIndexChanged

    End Sub
End Class