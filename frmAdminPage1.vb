Public Class frmAdminPage1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmEditpackage.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmAddpackage.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        AdminBooking.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        frmAdminCancellation.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        frmAdminPaymentd.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        frmAllReports.Show()
    End Sub

    Private Sub frmAdminPage1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'To make button transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button1.BackColor = System.Drawing.Color.Transparent

        Button2.FlatStyle = FlatStyle.Flat
        Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button2.BackColor = System.Drawing.Color.Transparent

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
    End Sub
End Class