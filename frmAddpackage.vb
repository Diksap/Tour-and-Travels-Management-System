Imports System.Data.OleDb
Public Class frmAddpackage
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet

    
    Private Sub frmAddpackage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeeDetailsDataSet.Employee' table. You can move, or remove it, as needed.
        'Me.PackagesAdapter.Fill(Me.PackagesDataSet.Employee)
        con = New OleDbConnection()
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\BHAVESH\Desktop\Tours and Travels Management System\Tours and Travels Management System.mdb"
        con.Open()
        cmd = New OleDb.OleDbCommand("select * from Package", con)
        'MsgBox("Data Connection is created")

        'for automatic package id
        Dim maxid As Object
        Dim strid As String
        Dim intid As Integer

        cmd.CommandText = "select Max(P_id)as Maxid from Packages"
        maxid = cmd.ExecuteScalar
        If maxid Is DBNull.Value Then
            intid = 1
        Else
            strid = CType(maxid, String)
            intid = CType(strid, String)
            intid = intid + 1
        End If
        txtbid.Text = intid
        txtbid.Focus()

        'To make button transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button1.BackColor = System.Drawing.Color.Transparent

        btnaddnew.FlatStyle = FlatStyle.Flat
        btnaddnew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        btnaddnew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        btnaddnew.BackColor = System.Drawing.Color.Transparent
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub



    'Provider=Microsoft.Jet.OLEDB.4.0;Data Source="D:\VB.NET Project Sem 6\Tours and Travels Management System.mdb"

    Private Sub btnaddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddnew.Click
        Dim s As String
        s = "INSERT INTO Packages values('" & txtbid.Text & "','" & txtpacknm.Text & "','" & txtpacktype.Text & "','" & txtplacenm.Text & "','" & txtdays.Text & "','" & txtbaschar.Text & "','" & txthotelnm.Text & "')"
        cmd = New OleDbCommand(s, con)
        cmd.ExecuteNonQuery()
        MsgBox("Your Record is Added")
        cmd.Dispose()
        con.Close()

    End Sub
End Class