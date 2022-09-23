Imports System.Net.Mail
Imports System.Text
Public Class frmemail

    Private Sub btnsend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsend.Click
        'sending mail
        Dim sb As New StringBuilder

        sb.AppendLine("Congratulations Your Ticket is Booked .....!!!!")
        sb.AppendLine("-------------------------------------------------------- ")
        sb.AppendLine("Name : " + frmprintticket.lblname.Text)
        sb.AppendLine("Contact No : " + frmprintticket.lblcontactno.Text)
        sb.AppendLine("Place Name : " + frmprintticket.lblplacename.Text)
        sb.AppendLine("From Date : " + frmprintticket.lblfromdate.Text)
        sb.AppendLine("To Date : " + frmprintticket.lbltodate.Text)
        sb.AppendLine("Days : " + frmprintticket.lbldays.Text)
        sb.AppendLine("Hotel Type : " + frmprintticket.lblhoteltype.Text)
        sb.AppendLine("Food : " + frmprintticket.lblfood.Text)
        sb.AppendLine("Travelling Mode : " + frmprintticket.lbltravellingmode.Text)
        sb.AppendLine("No of Child : " + frmprintticket.lblnoofchild.Text)
        sb.AppendLine("No of Adult : " + frmprintticket.lblnoofadult.Text)
        sb.AppendLine("No of Old : " + frmprintticket.lblnoofold.Text)
        sb.AppendLine("-------------------------------------------------------- ")
        sb.AppendLine("Total : " + frmprintticket.lbltotal.Text)
        sb.AppendLine("-------------------------------------------------------- ")
        sb.AppendLine("TRIP TIMETABLE")
        sb.AppendLine("-------------------------------------- ")
        sb.AppendLine("Day1  : " + frmprintticket.Button1.Text)
        sb.AppendLine("-------------------------------------- ")
        sb.AppendLine("Day2  : " + frmprintticket.Button2.Text)
        sb.AppendLine("-------------------------------------- ")
        sb.AppendLine("Day3  : " + frmprintticket.Button3.Text)
        sb.AppendLine("-------------------------------------- ")
        sb.AppendLine("Day4  : " + frmprintticket.Button4.Text)
        sb.AppendLine("-------------------------------------- ")
        sb.AppendLine("Day5  : " + frmprintticket.Button5.Text)
        sb.AppendLine("-------------------------------------- ")
        sb.AppendLine("Day6  : " + frmprintticket.Button6.Text)
        sb.AppendLine("-------------------------------------- ")
        sb.AppendLine("Day7  : " + frmprintticket.Button7.Text)
        sb.AppendLine("-------------------------------------- ")
        sb.AppendLine("Enjoy Your Trip .....!!!!")
        sb.AppendLine("Happy Journey .....!!!!")

        Dim Smtp_Server As New SmtpClient
        Dim e_mail As New MailMessage()
        Smtp_Server.UseDefaultCredentials = False
        Smtp_Server.Credentials = New Net.NetworkCredential("DreamTourTravelManagement@gmail.com", "Tour1234")
        Smtp_Server.Port = 587
        Smtp_Server.EnableSsl = True
        Smtp_Server.Host = "smtp.gmail.com"

        e_mail = New MailMessage()
        e_mail.From = New MailAddress("DreamTourTravelManagement@gmail.com")
        e_mail.To.Add(txtto.Text)
        e_mail.Subject = "Dream Tour and Travel Management System"
        e_mail.IsBodyHtml = False
        e_mail.Body = sb.ToString()
        Smtp_Server.Send(e_mail)
        MsgBox("Mail Sent To '" & txtto.Text & "'", MsgBoxStyle.Information)

       

    End Sub

    Private Sub frmemail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtto.Text = frmPayment.txtemailid.Text

        'to make label and button transparent
        Label1.BackColor = System.Drawing.Color.Transparent
        Label2.BackColor = System.Drawing.Color.Transparent
        Label4.BackColor = System.Drawing.Color.Transparent

        btnsend.FlatStyle = FlatStyle.Flat
        btnsend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        btnsend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        btnsend.BackColor = System.Drawing.Color.Transparent

        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button1.BackColor = System.Drawing.Color.Transparent
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
