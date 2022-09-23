Public Class frmemployeemenu


    Private Sub frmusermenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'to make label & buttons transparents
        Label1.BackColor = System.Drawing.Color.Transparent
        Label2.BackColor = System.Drawing.Color.Transparent

        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        btnSearch.BackColor = System.Drawing.Color.Transparent

        btncustomizepackage.FlatStyle = FlatStyle.Flat
        btncustomizepackage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        btncustomizepackage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        btncustomizepackage.BackColor = System.Drawing.Color.Transparent

        btngrouppackage.FlatStyle = FlatStyle.Flat
        btngrouppackage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        btngrouppackage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        btngrouppackage.BackColor = System.Drawing.Color.Transparent

        btnadventurepackage.FlatStyle = FlatStyle.Flat
        btnadventurepackage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        btnadventurepackage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        btnadventurepackage.BackColor = System.Drawing.Color.Transparent

        btnhoneymoonpackage.FlatStyle = FlatStyle.Flat
        btnhoneymoonpackage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        btnhoneymoonpackage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        btnhoneymoonpackage.BackColor = System.Drawing.Color.Transparent

        btnpayment.FlatStyle = FlatStyle.Flat
        btnpayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        btnpayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        btnpayment.BackColor = System.Drawing.Color.Transparent

        btncancellation.FlatStyle = FlatStyle.Flat
        btncancellation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        btncancellation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        btncancellation.BackColor = System.Drawing.Color.Transparent

        btnprintticket.FlatStyle = FlatStyle.Flat
        btnprintticket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        btnprintticket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        btnprintticket.BackColor = System.Drawing.Color.Transparent
    End Sub

    Private Sub btncustomizepackage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncustomizepackage.Click
        frmViewDetailscustomize.Show()
    End Sub

    Private Sub btnpayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpayment.Click
        frmPayment.Show()
    End Sub

    Private Sub btncancellation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancellation.Click
        frmcancellation.Show()
    End Sub

    Private Sub btnprintticket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprintticket.Click
        frmprintticket.Show()
    End Sub

    Private Sub btngrouppackage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrouppackage.Click
        frmViewdetailsgroup.Show()
    End Sub

    Private Sub btnhoneymoonpackage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhoneymoonpackage.Click
        frmViewdetailsHM.Show()
    End Sub

    Private Sub btnadventurepackage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadventurepackage.Click
        frmViewdetailsadven.Show()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If txtsearch.Text = "Manali" Then
            frmAdvenManali.Show()
        End If
        If txtsearch.Text = "manali" Then
            frmAdvenManali.Show()
        End If
        If txtsearch.Text = "Nainital" Then
            frmAdvenNainital.Show()
        End If
        If txtsearch.Text = "nainital" Then
            frmAdvenNainital.Show()
        End If
        If txtsearch.Text = "Rushikesh" Then
            frmAdvenRushikesh.Show()
        End If
        If txtsearch.Text = "rushikesh" Then
            frmAdvenRushikesh.Show()
        End If
        If txtsearch.Text = "Uttarakhand" Then
            frmAdvenUttarakhand.Show()
        End If
        If txtsearch.Text = "uttarakhand" Then
            frmAdvenUttarakhand.Show()
        End If
        If txtsearch.Text = "Darjeeling" Then
            frmcustomizedarjeeling.Show()
        End If
        If txtsearch.Text = "darjeeling" Then
            frmcustomizedarjeeling.Show()
        End If
        If txtsearch.Text = "Goldentraingle" Then
            frmcustomizegoldentraingle.Show()
        End If
        If txtsearch.Text = "goldentraingle" Then
            frmcustomizegoldentraingle.Show()
        End If
        If txtsearch.Text = "Humpibadami" Then
            frmcustomizehumpibadami.Show()
        End If
        If txtsearch.Text = "humpibadami" Then
            frmcustomizehumpibadami.Show()
        End If
        If txtsearch.Text = "Ooty" Then
            frmcustomizeooty.Show()
        End If
        If txtsearch.Text = "ooty" Then
            frmcustomizeooty.Show()
        End If
        If txtsearch.Text = "Indore" Then
            frmgroupIndore.Show()
        End If
        If txtsearch.Text = "indore" Then
            frmgroupIndore.Show()
        End If
        If txtsearch.Text = "Jaipur" Then
            frmgroupJaipur.Show()
        End If
        If txtsearch.Text = "jaipur" Then
            frmgroupJaipur.Show()
        End If
        If txtsearch.Text = "Rajasthan" Then
            frmgroupRajasthan.Show()
        End If
        If txtsearch.Text = "rajasthan" Then
            frmgroupRajasthan.Show()
        End If
        If txtsearch.Text = "Tamilnadu" Then
            frmgroupTamilnadu.Show()
        End If
        If txtsearch.Text = "tamilnadu" Then
            frmgroupTamilnadu.Show()
        End If
        If txtsearch.Text = "Goa" Then
            frmHmGOA.Show()
        End If
        If txtsearch.Text = "goa" Then
            frmHmGOA.Show()
        End If
        If txtsearch.Text = "Kashmir" Then
            frmHmKashmir.Show()
        End If
        If txtsearch.Text = "kashmir" Then
            frmHmKashmir.Show()
        End If
        If txtsearch.Text = "Kerala" Then
            frmHmKerala.Show()
        End If
        If txtsearch.Text = "kerala" Then
            frmHmKerala.Show()
        End If
        If txtsearch.Text = "Mysoor" Then
            frmHMmysoor.Show()
        End If
        If txtsearch.Text = "mysoor" Then
            frmHMmysoor.Show()
        End If
    End Sub
End Class