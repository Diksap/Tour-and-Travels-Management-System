Imports System.Data.OleDb
Public Class AdminBooking
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Try
            con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\BHAVESH\Desktop\Tours and Travels Management System\Tours and Travels Management System.mdb")
            Dim dataset1 As New DataSet()
            Dim ddate1 As Date = DateTimePicker1.Text
            Dim ddate2 As Date = DateTimePicker2.Text
            Dim sqlstring As String = "select * from Booking where FromDate between '" & ddate1 & "' AND '" & ddate2 & "'"
            'Dim sqlstring As String = "select * from enq1 where ddate >= '" & ddate1 & "' AND ddate <= '" & ddate2 & "'"
            cmd = New OleDbCommand(sqlstring, con)
            Dim oledbdataadapter1 As System.Data.OleDb.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter(sqlstring, con)
            con.Open()
            oledbdataadapter1.Fill(dataset1, "Booking")
            DataGridView1.DataSource = dataset1.Tables("Booking")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        con.Close()
    End Sub

    Private Sub AdminBooking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'To make label and button transparent
        Label1.BackColor = System.Drawing.Color.Transparent
        Label2.BackColor = System.Drawing.Color.Transparent
        Label3.BackColor = System.Drawing.Color.Transparent

        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        btnCancel.BackColor = System.Drawing.Color.Transparent

        btnsearch.FlatStyle = FlatStyle.Flat
        btnsearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        btnsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        btnsearch.BackColor = System.Drawing.Color.Transparent
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class