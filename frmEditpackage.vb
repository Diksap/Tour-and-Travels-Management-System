Imports System.Data.OleDb
Public Class frmEditpackage
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim ra As Integer
    Dim dba As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim dr As OleDbDataReader

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
       
        ' con.Open()
        'Dim strSQL As String
        'Dim ppid As Integer
        'Dim Days As String = ""
        'Dim packagenm As String = ""
        'Dim packagetype As String = ""
        'Dim placenm As String = ""
        'Dim basiccharge As Integer
        'Dim hotelnm As String = ""
        'strSQL = String.Concat("UPDATE Packages SET  Days = '", txtedays.Text, "', package_nm = '", txtepnm.Text, "', package_type = '", txteptype.Text, "',place_nm = '", txteplacenm.Text, "',basic_charge = '", txtebaschar.Text, "',hotel_nm = '", txtehotelnm.Text, "'where P_id = @pid ";")
        'strSQL = String.Concat("Update Packages set P_id='" & pid & "',Days='" & Days.ToString & "',package_nm='" & packagenm.ToString & "',package_type='" & packagetype.ToString & "', place_nm='" & placenm.ToString & "',basic_charge='" & basiccharge & "',hotel_nm='" & hotelnm.ToString & "' where P_id= '" & pid & "' ")
        'cmd.Parameters.Add("pid", OleDbType.Integer).Value = ppid
        'Try
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\BHAVESH\Desktop\Tours and Travels Management System\Tours and Travels Management System.mdb")
        con.Open()
        'cmd = New OleDbCommand("UPDATE Packages SET  Days = '" & txtedays.Text.ToString & "', package_nm = '" & txtepnm.Text.ToString & "', package_type = '" & txteptype.Text.ToString & "',place_nm = '" & txteplacenm.Text.ToString & "',basic_charge = ' & txtebaschar.Text & ',hotel_nm = '" & txtehotelnm.Text.ToString & "'where P_id = ' & txtpid.Text & ' ", con)
        'ra = cmd.ExecuteNonQuery
        'MessageBox.Show("Record Update Successfully" & ra)
        'con.Close()
        'Dim id As Integer
        'Using cmd As New OleDbCommand("UPDATE Packages SET  Days = '" & txtedays.Text.ToString & "', package_nm = '" & txtepnm.Text & "', package_type = '" & txteptype.Text & "',place_nm = '" & txteplacenm.Text & "',basic_charge = '" & txtebaschar.Text & "',hotel_nm = '" & txtehotelnm.Text & "' where P_id = @pid ", con)
        'cmd.Parameters.Add("pid", OleDbType.Integer).Value = id
        'cmd.Parameters.AddWithValue("pid", OleDbType.Integer).Value = id
        'cmd.ExecuteNonQuery()
        'con.Close()
        'MessageBox.Show("Record Update Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End Using

        'cmd = New OleDbCommand(strSQL, con)

        'cmd.Connection.Open()
        'cmd.ExecuteNonQuery()
        'MsgBox("Data is updated....")
        'cmd.Dispose()
        'con.Close()

        'Catch ex As Exception
        'MsgBox(ex.Message)
        'End Try

        Try
            Dim MessageText As String
            'Dim myCommand As OleDbCommand
            'Dim pid As Integer
            MessageText = "UPDATE Packages SET Days = '" + txtedays.Text + "', package_nm = '" + txtepnm.Text + "', package_type = '" + txteptype.Text + "', place_nm = '" + txteplacenm.Text + "', basic_charge = " + txtebaschar.Text + ", hotel_nm = '" + txtehotelnm.Text + "' where P_id=" & txtpid.Text & " "
            cmd = New OleDbCommand(MessageText, con)
            cmd.ExecuteNonQuery()
            MessageText = "Information Updated Successfully !! "
            MsgBox(MessageText)
            con.Close()
            'MessageText = "Information Updated Successfully !! "
            ' MsgBox(MessageText)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmEditpackage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'to make label and button transparent
        Label8.BackColor = System.Drawing.Color.Transparent

        'To make button transparent
        btnupdate.FlatStyle = FlatStyle.Flat
        btnupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        btnupdate.BackColor = System.Drawing.Color.Transparent

        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button1.BackColor = System.Drawing.Color.Transparent

        btnbooksear.FlatStyle = FlatStyle.Flat
        btnbooksear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        btnbooksear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        btnbooksear.BackColor = System.Drawing.Color.Transparent
    End Sub

    Private Sub btnbooksear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbooksear.Click
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\BHAVESH\Desktop\Tours and Travels Management System\Tours and Travels Management System.mdb")
        'con.ConnectionString = con
        Dim found As Boolean
        Dim Pid As Integer
        Dim days As String = ""
        Dim Packagename As String = ""
        Dim packagetype As String = ""
        Dim placename As String = ""
        Dim basiccharge As Integer
        Dim hotelname As String = ""

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Packages WHERE package_nm = '" & txtsearch.Text & "'", con)
        con.Open()
        Dim dr As OleDbDataReader = cmd.ExecuteReader


        While dr.Read
            Found = True
            Pid = dr("P_id")
            days = dr("Days")
            Packagename = dr("package_nm")
            packagetype = dr("package_type")
            placename = dr("place_nm")
            basiccharge = dr("basic_charge")
            hotelname = dr("hotel_nm")
        End While

        txtpid.Text = Pid
        txtedays.Text = days
        txtepnm.Text = Packagename
        txteptype.Text = packagetype
        txteplacenm.Text = placename
        txtebaschar.Text = basiccharge
        txtehotelnm.Text = hotelname

        con.Close()
    End Sub
End Class