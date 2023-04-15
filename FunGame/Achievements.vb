Public Class Achievements
    Private Sub Back_To_Cookie_Click(sender As Object, e As EventArgs) Handles Back_To_Cookie.Click
        CookieClicker.Show()
        Me.Close()
    End Sub
    Private Sub Achievements_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CookieClicker.GrandmaCookies > 0 Then
            Falling_Grandma.Show()
            Grandma_Cookie_1.Show()
        End If

        If CookieClicker.CookieStores > 4 Then
            Cookie_Stores_5.Show()
            CookieStores_5.Show()
        End If
    End Sub
End Class