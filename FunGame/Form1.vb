Imports System.Drawing.Text
Imports System.Net
Imports System.Security.Cryptography
Imports System.Security.Principal

Public Class Form1
    Public totalCookies, ClickValue, ClickLevel, ClickLevel2 As Integer
    Public PassiveOneVal, PassiveOneLevel As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalCookies = 0
        ClickValue = 1
        ClickLevel = 1
        PassiveOneVal = 0
        PassiveOneLevel = 1
        set_Timer(100)

        PassiveCookieTimer.Start()
    End Sub

    Private Sub btn_cookie_click_Click(sender As Object, e As EventArgs) Handles btn_cookie_click.Click
        click_cookie()
    End Sub

    'new github test'

    'Private Sub btn_cookie_click_2_Click(sender As Object, e As EventArgs) Handles btn_cookie_click_2.Click
    'click_cookie()
    'End Sub

    Private Sub click_cookie()
        totalCookies = totalCookies + ClickValue
        Cookie_Value.Text = "Cookie: " + totalCookies.ToString
    End Sub

    Private Sub RoundButton1_Click(sender As Object, e As EventArgs) Handles RoundButton1.Click
        click_cookie()
    End Sub

    Private Sub Button_Command_1_Click(sender As Object, e As EventArgs) Handles Button_Command_1.Click
        Dim upgradeCost As Integer
        upgradeCost = ClickLevel * 2

        If totalCookies >= upgradeCost Then
            totalCookies = totalCookies - upgradeCost

            ClickLevel = ClickLevel + 1
            ClickValue = (ClickLevel - 1) * 5

            upgradeCost = ClickLevel * 2
            Level_Text_1.Text = "Lvl: " + ClickLevel.ToString
            Price_Text_1.Text = "Price: " + upgradeCost.ToString
            Cookie_Multiplier.Text = "Cookie Multiplier: " + ClickValue.ToString
        End If
    End Sub

    Private Sub Button_Command_2_Click(sender As Object, e As EventArgs) Handles Button_Command_2.Click
        Dim upgradeCost As Integer
        upgradeCost = PassiveOneLevel * PassiveOneLevel * 100
        If totalCookies >= upgradeCost Then
            totalCookies = totalCookies - upgradeCost

            PassiveOneLevel = PassiveOneLevel + 1
            PassiveOneVal = PassiveOneVal + 1
            upgradeCost = PassiveOneLevel * PassiveOneLevel * 100

            Level_Text_2.Text = "Lvl " + PassiveOneLevel.ToString
            Price_Text_2.Text = "Price: " + upgradeCost.ToString
            Cookie_Stores.Text = "Cookie Stores: " + PassiveOneVal.ToString
        End If
    End Sub
    Private Sub PassiveCookieTimer_Tick(sender As Object, e As EventArgs) Handles PassiveCookieTimer.Tick
        totalCookies = totalCookies + 10
        Cookie_Value.Text = "Cookie: " + totalCookies.ToString
    End Sub

    Private Sub set_Timer(interval As Integer)
        PassiveCookieTimer.Interval = interval
    End Sub


End Class
