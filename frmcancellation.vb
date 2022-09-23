Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Public Class frmcancellation
    Dim connection As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Private Sub txtmobno_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmobno.Leave
        If Not Regex.Match(txtmobno.Text, "\d{10}", RegexOptions.IgnoreCase).Success Then
            MsgBox("Please enter 10 Digits and only Numeric value in Contact Number field", MsgBoxStyle.Critical)
            txtmobno.Focus()
        End If
    End Sub


   
    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Dim search As Boolean
        Try
            cmd = New OleDbCommand
            cmd.Connection = connection
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * from Payment where(Contact_No='" & txtmobno.Text & "')"
            dr = cmd.ExecuteReader
            While dr.Read()
                lblcid.Text = dr("C_id").ToString
                txtname.Text = dr("Name").ToString
                txtmobno.Text = dr("Contact_No").ToString
                txtaddress.Text = dr("Address").ToString
                txtadharcardno.Text = dr("AdharNo").ToString
                txtemailid.Text = dr("Email-id").ToString
                lblbid.Text = dr("Booking_id").ToString
                txtplacename.Text = dr("PlaceName").ToString
                txtdays.Text = dr("Days").ToString
                txthoteltype.Text = dr("HotelType").ToString
                txtfood.Text = dr("Food").ToString
                txttravellingmode.Text = dr("TravellingMode").ToString
                txtfromdate.Text = dr("FromDate").ToString
                txttodate.Text = dr("ToDate").ToString
                txtnoofchild.Text = dr("NoofChild").ToString
                txtnoofadult.Text = dr("NoofAdult").ToString
                txtnoofold.Text = dr("NoofOld").ToString
                txttotal.Text = dr("Total").ToString
                txttotalamount.Text = dr("Total").ToString
                search = True
            End While
            If search = False Then
                MsgBox("Mobile Number Not Found", MsgBoxStyle.Critical)
                dr.Close()
            End If
            Exit Sub
        Catch ex As Exception

        End Try
    End Sub


    Private Sub frmcancellation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cancellation Date
        lblcancellationdate.Text = System.DateTime.Now

        connection = New OleDbConnection()
        connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\BHAVESH\Desktop\Tours and Travels Management System\Tours and Travels Management System.mdb"
        connection.Open()
        cmd = New OleDb.OleDbCommand("select * from Cancellation", connection)

        'make label transparent
        Label1.BackColor = System.Drawing.Color.Transparent
        Label2.BackColor = System.Drawing.Color.Transparent
        Label27.BackColor = System.Drawing.Color.Transparent
        lblcancellationdate.BackColor = System.Drawing.Color.Transparent

        'make groupbox transparent
        GroupBox1.BackColor = Color.Transparent
        GroupBox2.BackColor = Color.Transparent
        GroupBox3.BackColor = Color.Transparent
        GroupBox4.BackColor = Color.Transparent

        'make button transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button1.BackColor = System.Drawing.Color.Transparent

        btnsearch.FlatStyle = FlatStyle.Flat
        btnsearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        btnsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        btnsearch.BackColor = System.Drawing.Color.Transparent

        btnticketcancellation.FlatStyle = FlatStyle.Flat
        btnticketcancellation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        btnticketcancellation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        btnticketcancellation.BackColor = System.Drawing.Color.Transparent

        btnreceipt.FlatStyle = FlatStyle.Flat
        btnreceipt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        btnreceipt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        btnreceipt.BackColor = System.Drawing.Color.Transparent

        'for automatic Cancellation id
        Dim maxid As Object
        Dim strid As String
        Dim intid As Integer


        cmd.CommandText = "select Max(Cancellation_ID)as Maxid from Cancellation"
        maxid = cmd.ExecuteScalar
        If maxid Is DBNull.Value Then
            intid = 1
        Else
            strid = CType(maxid, String)
            intid = CType(strid, String)
            intid = intid + 1

        End If
        lblcancellationid.Text = intid
        lblcancellationid.Focus()
    End Sub

    Private Sub btnticketcancellation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnticketcancellation.Click
        'Calculate remaining Amount

        'cancellation amount for child = 700 per Child
        'cancellation amount for Adult = 1000 per Adult
        'cancellation amount for Old = 500 per Old
        txtcancellationcharges.Text = Val(txtnoofchild.Text * 700) + Val(txtnoofadult.Text * 1000) + Val(txtnoofold.Text * 500)
        txtremainingamount.Text = Val(txttotalamount.Text) - Val(txtcancellationcharges.Text)

        'Save cancellation details in Cancellation Table
        Dim s As String
        s = "Insert Into Cancellation values('" & lblcancellationid.Text & "','" & lblbid.Text & "','" & lblcancellationdate.Text & "','" & txtname.Text & "','" & txtaddress.Text & "','" & txtmobno.Text & "','" & txtadharcardno.Text & "','" & txtemailid.Text & "','" & txttotalamount.Text & "','" & txtcancellationcharges.Text & "','" & txtremainingamount.Text & "')"
        cmd = New OleDbCommand(s, connection)
        cmd.ExecuteNonQuery()

        'Delete record from Booking table after ticket cancellation
        'Dim d As String
        'd = "Delete from Booking where B_id= '" & lblbid.Text & "' "
        'cmd = New OleDbCommand(d, connection)
        'cmd.ExecuteNonQuery()

        'Delete record from Payment table after ticket cancellation
        'Dim p As String
        'p = "Delete from Payment where Booking_id= '" & lblbid.Text & "' "
        'cmd = New OleDbCommand(p, connection)
        'cmd.ExecuteNonQuery()
    End Sub

    Private Sub btnreceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreceipt.Click
        frmcancellationprint.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class