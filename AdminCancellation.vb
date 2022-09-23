Imports System.Data.OleDb
Public Class frmAdminCancellation
    Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\BHAVESH\Desktop\Tours and Travels Management System\Tours and Travels Management System\Tours and Travels Management System\Tours and Travels Management System.mdb"
    'Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Clive\Documents\Visual Studio 2008\clive projects\Displaydata\Displaydata\bin\Debug\Items.accdb"
    Dim Myconnection As OleDbConnection
    Dim dbda As OleDbDataAdapter
    Dim dbds As DataSet
    Dim tables As DataTableCollection
    Dim source As New BindingSource
    Private Sub frmAdminCancellation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'To make label and button transparent
        Label1.BackColor = System.Drawing.Color.Transparent

        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button1.BackColor = System.Drawing.Color.Transparent

        'To display cancellation deatils
        Myconnection = New OleDbConnection
        Myconnection.ConnectionString = connString
        dbds = New DataSet
        tables = dbds.Tables
        dbda = New OleDbDataAdapter("Select * from [Cancellation]", Myconnection)
        dbda.Fill(dbds, "Cancellation")
        Dim view As New DataView(tables(0))
        source.DataSource = view
        DataGridView1.DataSource = view
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class