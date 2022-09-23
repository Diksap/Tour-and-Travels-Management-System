Imports System.Data.OleDb

Public Class frmAllReports
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand

    Private Sub frmAllReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\BHAVESH\Desktop\Tours and Travels Management System\Tours and Travels Management System\Tours and Travels Management System\Tours and Travels Management System.mdb"
        con.Open()

        'make timetable buttons transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button1.BackColor = System.Drawing.Color.Transparent

        Button2.FlatStyle = FlatStyle.Flat
        Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button2.BackColor = System.Drawing.Color.Transparent

        Button3.FlatStyle = FlatStyle.Flat
        Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button3.BackColor = System.Drawing.Color.Transparent

        Button4.FlatStyle = FlatStyle.Flat
        Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button4.BackColor = System.Drawing.Color.Transparent

        btncustomerreport.FlatStyle = FlatStyle.Flat
        btncustomerreport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        btncustomerreport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        btncustomerreport.BackColor = System.Drawing.Color.Transparent

    End Sub

    Private Sub btncustomerreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncustomerreport.Click
        ReportCustomer.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ReportBooking.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ReportPayment.show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ReportCancellation.show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ReportPackage.show()
    End Sub
End Class