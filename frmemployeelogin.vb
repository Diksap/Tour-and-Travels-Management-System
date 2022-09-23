Imports System.Data.OleDb

Public Class frmemployeelogin
    Dim connection As OleDbConnection

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If txtusername.Text = Nothing Or txtpassword.Text = Nothing Then
            MsgBox("Enter Username and Password", MsgBoxStyle.Exclamation)
        Else
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim cmd As New OleDbCommand("select count(*) from EmployeeLogin where Username=? and Password=?", connection)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtusername.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = txtpassword.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If (count > 0) Then
                MsgBox("Login Successfully", MsgBoxStyle.Information)
                frmemployeemenu.Show()
            Else
                MsgBox("Username and Password are Invalid!!", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub frmemployeelogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnclose.FlatStyle = FlatStyle.Flat
        btnclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        btnclose.BackColor = System.Drawing.Color.Transparent

        btnlogin.FlatStyle = FlatStyle.Flat
        btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        btnlogin.BackColor = System.Drawing.Color.Transparent

        btneye.FlatStyle = FlatStyle.Flat
        btneye.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        btneye.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        btneye.BackColor = System.Drawing.Color.White

        Label1.BackColor = System.Drawing.Color.Transparent
        Label2.BackColor = System.Drawing.Color.Transparent
        Label3.BackColor = System.Drawing.Color.Transparent

        GroupBox1.BackColor = Color.Transparent

        connection = New OleDbConnection()
        connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\BHAVESH\Desktop\Tours and Travels Management System\Tours and Travels Management System.mdb"
        connection.Open()
    End Sub





    Private Sub btneye_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneye.Click
        If txtpassword.UseSystemPasswordChar = True Then
            txtpassword.UseSystemPasswordChar = False
        Else
            txtpassword.UseSystemPasswordChar = True
        End If

        If txtpassword.UseSystemPasswordChar = False Then
            btneye.BackgroundImage = Image.FromFile("C:\Users\BHAVESH\Desktop\Tours and Travels Management System\Tour images\openeye.png")
        Else
            btneye.BackgroundImage = Image.FromFile("C:\Users\BHAVESH\Desktop\Tours and Travels Management System\Tour images\closeeye.png")
        End If
    End Sub

End Class