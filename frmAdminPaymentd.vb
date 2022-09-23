Imports System.Data.OleDb
Public Class frmAdminPaymentd

    Private Sub frmAdminPaymentd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'To make Button and label Transparent

        Label1.BackColor = System.Drawing.Color.Transparent

        btndetails.FlatStyle = FlatStyle.Flat
        btndetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        btndetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        btndetails.BackColor = System.Drawing.Color.Transparent

        btncancel.FlatStyle = FlatStyle.Flat
        btncancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        btncancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        btncancel.BackColor = System.Drawing.Color.Transparent

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btndetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndetails.Click
        Dim connectionstring As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\BHAVESH\Desktop\Tours and Travels Management System\Tours and Travels Management System.mdb"
        Dim sql As String = "Select * from Payment"
        Dim connection As New OleDbConnection(connectionstring)
        Dim dataadapter As New OleDbDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "Payment")
        connection.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Payment"
    End Sub
End Class