Imports System.Drawing.Text
Imports System.Net
Imports System.Security.Cryptography
Imports System.Security.Principal
Imports System.Threading

Public Class CookieClicker
    Public totalCookies, ClickValue, ClickLevel, CookieStores, CookieWorkers As Integer
    Public PassiveOneVal, PassiveOneLevel As Integer
    Public WorkerValue, GrandmaCookies As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalCookies = 0
        ClickValue = 0
        ClickLevel = 1
        PassiveOneVal = 0
        PassiveOneLevel = 1
        WorkerValue = 0
        GrandmaCookies = 0

        CookieStores = 0
        CookieWorkers = 0
        set_Timer(100)

        PassiveCookieTimer.Start()
    End Sub

    Private Sub btn_cookie_click_Click(sender As Object, e As EventArgs)
        click_cookie()
    End Sub

    Private Sub click_cookie()
        totalCookies = totalCookies + ClickValue
        Cookie_Value.Text = "Cookie: " + totalCookies.ToString

        If totalCookies = 1000 Then
            Achievement.Text = "Congraluations! You have reached 1000 Cookies."
        End If

        If totalCookies > 1000 Then
            Achievement.Text = " "
        End If
    End Sub

    Private Sub RoundButton1_Click(sender As Object, e As EventArgs) Handles RoundButton1.Click
        click_cookie()
    End Sub

    Private Sub Achievement_Button_Click(sender As Object, e As EventArgs) Handles Achievement_Button.Click
        Dim Achievements As New Achievements()
        Achievements.Show()
        Me.Visible = False
    End Sub

    Private Sub Button_Command_4_Click(sender As Object, e As EventArgs) Handles Button_Command_4.Click
        If totalCookies >= 10 Then
            totalCookies -= 10

            GrandmaCookies += 1

            Grandmas_Cookies.Text = "Grandma's Cookies: " + GrandmaCookies.ToString
        End If

        If GrandmaCookies = 1 Then
            Achievement.Text = "Congraluations! You have 1 Grandma Cookie."
        End If

        If totalCookies > 2 Then
            Achievement.Text = " "
        End If

    End Sub

    Public Sub Button_Command_3_Click(sender As Object, e As EventArgs) Handles Button_Command_3.Click
        If totalCookies >= 50 Then
            totalCookies -= 50

            WorkerValue += 1

            cookie_workers.Text = "Cookie Workers: " + WorkerValue.ToString

        End If
    End Sub

    Private Sub Button_Command_1_Click(sender As Object, e As EventArgs) Handles Button_Command_1.Click
        Dim upgradeCost As Integer
        upgradeCost = ClickLevel * 2

        If totalCookies >= upgradeCost Then
            totalCookies = totalCookies - upgradeCost

            ClickLevel = ClickLevel + 1
            ClickValue = (ClickLevel - 1) * 5

            upgradeCost = ClickLevel * 1
            Level_Text_1.Text = "Lvl: " + ClickLevel.ToString
            Price_Text_1.Text = "Price: " + upgradeCost.ToString
            Cookie_Multiplier.Text = "Cookie Multiplier: " + ClickValue.ToString
        End If
    End Sub

    Private Sub Button_Command_2_Click(sender As Object, e As EventArgs) Handles Button_Command_2.Click
        Dim upgradeCost As Integer
        upgradeCost = PassiveOneLevel * PassiveOneLevel * 100

        If totalCookies >= upgradeCost And WorkerValue >= 10 Then
            Remind_1.Text = " "
            totalCookies = totalCookies - upgradeCost
            WorkerValue = WorkerValue - 10

            PassiveOneLevel = PassiveOneLevel + 1
            PassiveOneVal = PassiveOneVal + 1
            CookieStores = PassiveOneVal
            upgradeCost = PassiveOneLevel * PassiveOneLevel * 100

            Level_Text_2.Text = "Lvl " + PassiveOneLevel.ToString
            Price_Text_2.Text = "Price: " + upgradeCost.ToString
            Cookie_Stores.Text = "Cookie Stores: " + PassiveOneVal.ToString
        Else
            Remind_1.Text = "You do not have enough money or workers to buy stores."
        End If

        If CookieStores = 5 Then
            Achievement.Text = "Congratulations! You have reached " + CookieStores.ToString + " Cookie Stores!"
        End If
        If CookieStores > 5 Then
            Achievement.Text = " "
        End If

    End Sub
    Private Sub PassiveCookieTimer_Tick(sender As Object, e As EventArgs) Handles PassiveCookieTimer.Tick
        totalCookies = totalCookies + 10
        Cookie_Value.Text = "Cookie: " + totalCookies.ToString
    End Sub

    Private Sub set_Timer(interval As Integer)
        'PassiveCookieTimer.Interval = interval
    End Sub

End Class
