Imports System.Data.OleDb
Public Class frmcancellationprint
    Dim connection As OleDbConnection
    Dim cmd As OleDbCommand
    Private Sub frmcancellationprint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection = New OleDbConnection()
        connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\BHAVESH\Desktop\Tours and Travels Management System\Tours and Travels Management System.mdb"
        connection.Open()

        'to make label and button transparents
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button1.BackColor = System.Drawing.Color.Transparent

        Label1.BackColor = System.Drawing.Color.Transparent
        Label6.BackColor = System.Drawing.Color.Transparent

        'make groupbox transparent
        GroupBox1.BackColor = Color.Transparent

        'show person wise cancellation charges in label
        Dim c As Integer
        Dim a As Integer
        Dim o As Integer
        c = Val(700 * frmcancellation.txtnoofchild.Text)
        a = Val(1000 * frmcancellation.txtnoofadult.Text)
        o = Val(500 * frmcancellation.txtnoofold.Text)
        lbladultamt.Text = c
        lblchildamt.Text = a
        lbloldamt.Text = o
        lbltotalcancellationcharges.Text = Val(c + a + o)

        'display details from cancellation form
        lblcid.Text = frmcancellation.lblcid.Text
        lblname.Text = frmcancellation.txtname.Text
        lblcontactno.Text = frmcancellation.txtmobno.Text
        lblplacename.Text = frmcancellation.txtplacename.Text
        lblfromdate.Text = frmcancellation.txtfromdate.Text
        lbltodate.Text = frmcancellation.txttodate.Text
        lbldays.Text = frmcancellation.txtdays.Text
        lblnoofadult.Text = frmcancellation.txtnoofadult.Text
        lblnoofchild.Text = frmcancellation.txtnoofchild.Text
        lblnoofold.Text = frmcancellation.txtnoofold.Text
        lbltotalamount.Text = frmcancellation.txttotalamount.Text
        lblcancellationcharges.Text = frmcancellation.txtcancellationcharges.Text
        lblremainingamount.Text = frmcancellation.txtremainingamount.Text
        lblcancellationdate.Text = frmcancellation.lblcancellationdate.Text
    End Sub

  

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class