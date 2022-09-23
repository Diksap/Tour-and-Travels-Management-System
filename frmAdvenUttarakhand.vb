Imports System.Data.OleDb
Public Class frmAdvenUttarakhand
    Dim connection As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Private Sub btnpayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpayment.Click
        frmPayment.Show()
    End Sub
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub




    Private Sub btntotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntotal.Click
        'check one radio button for a/c and non a/c
        If Not rbtnac.Checked AndAlso Not rbtnnonac.Checked Then
            MessageBox.Show("Please select Hotel type A/C or NON-A/C")
        End If
        'check one radio button for veg and non-veg
        If Not rbtnVeg.Checked AndAlso Not rbtnnonveg.Checked Then
            MessageBox.Show("Please select Food type VEG or NON-VEG")
        End If
        'check one radio button for Train, Filght
        If Not rbtntrain.Checked AndAlso Not rbtnflight.Checked Then
            MessageBox.Show("Please select Travelling Mode Train or Filght")
        End If

        'check atleast one checkbox is selected
        If Not cbtnchild.Checked AndAlso Not cbtnadults.Checked AndAlso Not cbtnold.Checked Then
            MessageBox.Show("Please select Person Type Child, Adult, Old")
        End If

        'selected date cannot be < today
        If DateTimePicker1.Value < Date.Today Then
            MessageBox.Show("Date cannot be before today ")
        End If

        'Increase date by 7 days
        DateTimePicker2.Value = DateTimePicker1.Value.AddDays(+7)

       

        'Person wise Calculation
        Dim tc As Integer
        Dim ta As Integer
        Dim told As Integer
        Dim fc As Integer
        Dim fa As Integer
        Dim fold As Integer

        If cbtnchild.Checked = True And rbtntrain.Checked = True Then
            tc = (txtnoofchild.Text * 13200) '12000=package amt + 1200 = train amt
        End If
        If cbtnadults.Checked = True And rbtntrain.Checked = True Then
            ta = (txtnoofadults.Text * 15000) '12000=package amt + 3000 = train amt
        End If
        If cbtnold.Checked = True And rbtntrain.Checked = True Then
            told = (txtnoofold.Text * 13800) '12000=package amt + 1800 = train amt
        End If

        If cbtnchild.Checked = True And rbtnflight.Checked = True Then
            tc = (txtnoofchild.Text * 15000) '12000=package amt + 3000 = flight amt
        End If
        If cbtnadults.Checked = True And rbtnflight.Checked = True Then
            ta = (txtnoofadults.Text * 18000)  '12000=package amt + 6000 = flight amt
        End If
        If cbtnold.Checked = True And rbtnflight.Checked = True Then
            told = (txtnoofold.Text * 16100) '12000=package amt + 4100 = flight amt
        End If
        txttot.Text = tc + ta + told + fc + fa + fold

        'delete old records from Temp
        Dim d As String
        d = "delete * from Temp"
        cmd = New OleDbCommand(d, connection)
        cmd.ExecuteNonQuery()
        'MsgBox("Record delete")

        'save deatils in access in Temp Table
        Dim h As String = String.Empty
        Dim f As String = String.Empty
        Dim t As String = String.Empty

        If rbtnac.Checked = True Then
            h = "A/C"
        ElseIf rbtnnonac.Checked = True Then
            h = "Non-A/C"
        End If

        If rbtnVeg.Checked = True Then
            f = "Veg"
        ElseIf rbtnnonveg.Checked = True Then
            f = "Non-Veg"
        End If

        If rbtntrain.Checked = True Then
            t = "Train"
        ElseIf rbtnflight.Checked = True Then
            t = "Flight"
        End If

        cmd = New OleDbCommand("Insert into Temp (B_id,PlaceName,Days,HotelName,HotelType,Food,TravellingMode,FromDate,ToDate,NoofChild,NoofAdult,NoofOld,Total)values('" & lblbookingid.Text & "','" & lblplacename.Text & "','" & lbludays.Text & "','" & lblhotelname.Text & "','" & h & "','" & f & "','" & t & "','" & DateTimePicker1.Value.Date & "','" & DateTimePicker2.Value.Date & "','" & txtnoofchild.Text & "','" & txtnoofadults.Text & "','" & txtnoofold.Text & "','" & txttot.Text & "')", connection)
        cmd.ExecuteNonQuery()


    End Sub



    Private Sub frmAdvenUttarakhand_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection = New OleDbConnection()
        connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\BHAVESH\Desktop\Tours and Travels Management System\Tours and Travels Management System.mdb"
        connection.Open()
        cmd = New OleDb.OleDbCommand("select * from Payment", connection)

        'for automatic booking id
        Dim maxid As Object
        Dim strid As String
        Dim intid As Integer

        cmd.CommandText = "select Max(B_id)as Maxid from Booking"
        maxid = cmd.ExecuteScalar
        If maxid Is DBNull.Value Then
            intid = 1
        Else
            strid = CType(maxid, String)
            intid = CType(strid, String)
            intid = intid + 1

        End If
        lblbookingid.Text = intid
        lblbookingid.Focus()

        'make timetable buttons transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button1.BackColor = System.Drawing.Color.Transparent

        Button8.FlatStyle = FlatStyle.Flat
        Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button8.BackColor = System.Drawing.Color.Transparent

        Button8.FlatStyle = FlatStyle.Flat
        Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button8.BackColor = System.Drawing.Color.Transparent

        Button9.FlatStyle = FlatStyle.Flat
        Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button9.BackColor = System.Drawing.Color.Transparent

        Button10.FlatStyle = FlatStyle.Flat
        Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button10.BackColor = System.Drawing.Color.Transparent

        Button11.FlatStyle = FlatStyle.Flat
        Button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button11.BackColor = System.Drawing.Color.Transparent

        Button12.FlatStyle = FlatStyle.Flat
        Button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button12.BackColor = System.Drawing.Color.Transparent

        Button13.FlatStyle = FlatStyle.Flat
        Button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button13.BackColor = System.Drawing.Color.Transparent

        Button14.FlatStyle = FlatStyle.Flat
        Button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button14.BackColor = System.Drawing.Color.Transparent

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

        Button5.FlatStyle = FlatStyle.Flat
        Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button5.BackColor = System.Drawing.Color.Transparent

        Button6.FlatStyle = FlatStyle.Flat
        Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button6.BackColor = System.Drawing.Color.Transparent

        Button7.FlatStyle = FlatStyle.Flat
        Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button7.BackColor = System.Drawing.Color.Transparent


        'make groupbox transparent
        GroupBox1.BackColor = Color.Transparent
        GroupBox2.BackColor = Color.Transparent
        GroupBox3.BackColor = Color.Transparent
        GroupBox4.BackColor = Color.Transparent
        grmanaliTT.BackColor = Color.Transparent

        'make button transparent
        btntotal.FlatStyle = FlatStyle.Flat
        btntotal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        btntotal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        btntotal.BackColor = System.Drawing.Color.Transparent

        btnpayment.FlatStyle = FlatStyle.Flat
        btnpayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        btnpayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        btnpayment.BackColor = System.Drawing.Color.Transparent

        btncancel.FlatStyle = FlatStyle.Flat
        btncancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        btncancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        btncancel.BackColor = System.Drawing.Color.Transparent

        
    End Sub

    
    Private Sub txtnoofadults_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnoofadults.Click
        txtnoofadults.Text = ""
    End Sub

    Private Sub txtnoofchild_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnoofchild.Click
        txtnoofchild.Text = ""
    End Sub

    Private Sub txtnoofold_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnoofold.Click
        txtnoofold.Text = ""
    End Sub

    Private Sub txtnoofadults_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnoofadults.LostFocus
        If IsNumeric(txtnoofadults.Text) = False Then
            MsgBox("please enter only numeric value....")
        End If
    End Sub

    Private Sub txtnoofchild_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnoofchild.LostFocus
        If IsNumeric(txtnoofchild.Text) = False Then
            MsgBox("please enter only numeric value....")
        End If
    End Sub

    Private Sub txtnoofold_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnoofold.LostFocus
        If IsNumeric(txtnoofold.Text) = False Then
            MsgBox("please enter only numeric value....")
        End If
    End Sub
End Class