<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CookieClicker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CookieClicker))
        Me.Cookie_Value = New System.Windows.Forms.Label()
        Me.PassiveCookieTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Price_Text_1 = New System.Windows.Forms.Label()
        Me.Level_Text_1 = New System.Windows.Forms.Label()
        Me.Button_Command_1 = New System.Windows.Forms.Button()
        Me.Price_Text_2 = New System.Windows.Forms.Label()
        Me.Button_Command_2 = New System.Windows.Forms.Button()
        Me.Level_Text_2 = New System.Windows.Forms.Label()
        Me.RoundButton1 = New FunGame.RoundButton()
        Me.Cookie_Multiplier = New System.Windows.Forms.Label()
        Me.Cookie_Stores = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Achievement = New System.Windows.Forms.Label()
        Me.cookie_workers = New System.Windows.Forms.Label()
        Me.Price_Text_3 = New System.Windows.Forms.Label()
        Me.Button_Command_3 = New System.Windows.Forms.Button()
        Me.Remind_1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Price_Text_4 = New System.Windows.Forms.Label()
        Me.Button_Command_4 = New System.Windows.Forms.Button()
        Me.Grandmas_Cookies = New System.Windows.Forms.Label()
        Me.Achievement_Button = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Cookie_Value
        '
        Me.Cookie_Value.AutoSize = True
        Me.Cookie_Value.Font = New System.Drawing.Font("Comic Sans MS", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Cookie_Value.Location = New System.Drawing.Point(302, 8)
        Me.Cookie_Value.Name = "Cookie_Value"
        Me.Cookie_Value.Size = New System.Drawing.Size(257, 69)
        Me.Cookie_Value.TabIndex = 0
        Me.Cookie_Value.Text = "Cookie: 0"
        '
        'PassiveCookieTimer
        '
        '
        'Price_Text_1
        '
        Me.Price_Text_1.AutoSize = True
        Me.Price_Text_1.BackColor = System.Drawing.Color.Goldenrod
        Me.Price_Text_1.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Price_Text_1.Location = New System.Drawing.Point(66, 22)
        Me.Price_Text_1.Name = "Price_Text_1"
        Me.Price_Text_1.Size = New System.Drawing.Size(159, 55)
        Me.Price_Text_1.TabIndex = 2
        Me.Price_Text_1.Text = "Price 2"
        '
        'Level_Text_1
        '
        Me.Level_Text_1.AutoSize = True
        Me.Level_Text_1.Font = New System.Drawing.Font("Comic Sans MS", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Level_Text_1.Location = New System.Drawing.Point(109, 147)
        Me.Level_Text_1.Name = "Level_Text_1"
        Me.Level_Text_1.Size = New System.Drawing.Size(87, 45)
        Me.Level_Text_1.TabIndex = 3
        Me.Level_Text_1.Text = "Lvl 1"
        '
        'Button_Command_1
        '
        Me.Button_Command_1.Location = New System.Drawing.Point(42, 78)
        Me.Button_Command_1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button_Command_1.Name = "Button_Command_1"
        Me.Button_Command_1.Size = New System.Drawing.Size(213, 65)
        Me.Button_Command_1.TabIndex = 4
        Me.Button_Command_1.Text = "Increase Value of Click"
        Me.Button_Command_1.UseVisualStyleBackColor = True
        '
        'Price_Text_2
        '
        Me.Price_Text_2.AutoSize = True
        Me.Price_Text_2.BackColor = System.Drawing.Color.Goldenrod
        Me.Price_Text_2.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Price_Text_2.Location = New System.Drawing.Point(653, 20)
        Me.Price_Text_2.Name = "Price_Text_2"
        Me.Price_Text_2.Size = New System.Drawing.Size(207, 55)
        Me.Price_Text_2.TabIndex = 8
        Me.Price_Text_2.Text = "Price 100"
        '
        'Button_Command_2
        '
        Me.Button_Command_2.Location = New System.Drawing.Point(635, 80)
        Me.Button_Command_2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button_Command_2.Name = "Button_Command_2"
        Me.Button_Command_2.Size = New System.Drawing.Size(233, 70)
        Me.Button_Command_2.TabIndex = 9
        Me.Button_Command_2.Text = "Click to buy a Cookie Stores"
        Me.Button_Command_2.UseVisualStyleBackColor = True
        '
        'Level_Text_2
        '
        Me.Level_Text_2.AutoSize = True
        Me.Level_Text_2.Font = New System.Drawing.Font("Comic Sans MS", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Level_Text_2.Location = New System.Drawing.Point(704, 154)
        Me.Level_Text_2.Name = "Level_Text_2"
        Me.Level_Text_2.Size = New System.Drawing.Size(87, 45)
        Me.Level_Text_2.TabIndex = 10
        Me.Level_Text_2.Text = "Lvl 1"
        '
        'RoundButton1
        '
        Me.RoundButton1.Font = New System.Drawing.Font("Comic Sans MS", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RoundButton1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.RoundButton1.Image = CType(resources.GetObject("RoundButton1.Image"), System.Drawing.Image)
        Me.RoundButton1.Location = New System.Drawing.Point(302, 78)
        Me.RoundButton1.Name = "RoundButton1"
        Me.RoundButton1.Size = New System.Drawing.Size(265, 267)
        Me.RoundButton1.TabIndex = 13
        Me.RoundButton1.Text = "COOKIES!!"
        Me.RoundButton1.UseVisualStyleBackColor = True
        '
        'Cookie_Multiplier
        '
        Me.Cookie_Multiplier.AutoSize = True
        Me.Cookie_Multiplier.Font = New System.Drawing.Font("Comic Sans MS", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Cookie_Multiplier.Location = New System.Drawing.Point(273, 348)
        Me.Cookie_Multiplier.Name = "Cookie_Multiplier"
        Me.Cookie_Multiplier.Size = New System.Drawing.Size(326, 45)
        Me.Cookie_Multiplier.TabIndex = 14
        Me.Cookie_Multiplier.Text = "Cookie Multiplier: 1"
        '
        'Cookie_Stores
        '
        Me.Cookie_Stores.AutoSize = True
        Me.Cookie_Stores.Font = New System.Drawing.Font("Comic Sans MS", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Cookie_Stores.Location = New System.Drawing.Point(273, 438)
        Me.Cookie_Stores.Name = "Cookie_Stores"
        Me.Cookie_Stores.Size = New System.Drawing.Size(283, 45)
        Me.Cookie_Stores.TabIndex = 15
        Me.Cookie_Stores.Text = "Cookie Stores: 0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(662, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 55)
        Me.Label1.TabIndex = 16
        '
        'Achievement
        '
        Me.Achievement.AutoSize = True
        Me.Achievement.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Achievement.Location = New System.Drawing.Point(12, 611)
        Me.Achievement.Name = "Achievement"
        Me.Achievement.Size = New System.Drawing.Size(1142, 50)
        Me.Achievement.TabIndex = 17
        Me.Achievement.Text = "                                                                      "
        '
        'cookie_workers
        '
        Me.cookie_workers.AutoSize = True
        Me.cookie_workers.Font = New System.Drawing.Font("Comic Sans MS", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cookie_workers.Location = New System.Drawing.Point(273, 393)
        Me.cookie_workers.Name = "cookie_workers"
        Me.cookie_workers.Size = New System.Drawing.Size(311, 45)
        Me.cookie_workers.TabIndex = 18
        Me.cookie_workers.Text = "Cookie Workers: 0"
        '
        'Price_Text_3
        '
        Me.Price_Text_3.AutoSize = True
        Me.Price_Text_3.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Price_Text_3.Location = New System.Drawing.Point(662, 218)
        Me.Price_Text_3.Name = "Price_Text_3"
        Me.Price_Text_3.Size = New System.Drawing.Size(183, 55)
        Me.Price_Text_3.TabIndex = 19
        Me.Price_Text_3.Text = "Price 50"
        '
        'Button_Command_3
        '
        Me.Button_Command_3.Location = New System.Drawing.Point(635, 276)
        Me.Button_Command_3.Name = "Button_Command_3"
        Me.Button_Command_3.Size = New System.Drawing.Size(246, 69)
        Me.Button_Command_3.TabIndex = 20
        Me.Button_Command_3.Text = "Click to buy a Worker"
        Me.Button_Command_3.UseVisualStyleBackColor = True
        '
        'Remind_1
        '
        Me.Remind_1.AutoSize = True
        Me.Remind_1.Font = New System.Drawing.Font("Comic Sans MS", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Remind_1.Location = New System.Drawing.Point(28, 557)
        Me.Remind_1.Name = "Remind_1"
        Me.Remind_1.Size = New System.Drawing.Size(1126, 45)
        Me.Remind_1.TabIndex = 21
        Me.Remind_1.Text = "                                                                               "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 507)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 25)
        Me.Label2.TabIndex = 22
        '
        'Price_Text_4
        '
        Me.Price_Text_4.AutoSize = True
        Me.Price_Text_4.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Price_Text_4.Location = New System.Drawing.Point(12, 203)
        Me.Price_Text_4.Name = "Price_Text_4"
        Me.Price_Text_4.Size = New System.Drawing.Size(272, 55)
        Me.Price_Text_4.TabIndex = 23
        Me.Price_Text_4.Text = "Price 10,000"
        '
        'Button_Command_4
        '
        Me.Button_Command_4.Location = New System.Drawing.Point(45, 261)
        Me.Button_Command_4.Name = "Button_Command_4"
        Me.Button_Command_4.Size = New System.Drawing.Size(210, 62)
        Me.Button_Command_4.TabIndex = 24
        Me.Button_Command_4.Text = "Click to buy a Grandma Cookie"
        Me.Button_Command_4.UseVisualStyleBackColor = True
        '
        'Grandmas_Cookies
        '
        Me.Grandmas_Cookies.AutoSize = True
        Me.Grandmas_Cookies.Font = New System.Drawing.Font("Comic Sans MS", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Grandmas_Cookies.Location = New System.Drawing.Point(273, 483)
        Me.Grandmas_Cookies.Name = "Grandmas_Cookies"
        Me.Grandmas_Cookies.Size = New System.Drawing.Size(360, 45)
        Me.Grandmas_Cookies.TabIndex = 25
        Me.Grandmas_Cookies.Text = "Grandma's Cookies: 0"
        '
        'Achievement_Button
        '
        Me.Achievement_Button.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Achievement_Button.Location = New System.Drawing.Point(653, 378)
        Me.Achievement_Button.Name = "Achievement_Button"
        Me.Achievement_Button.Size = New System.Drawing.Size(471, 78)
        Me.Achievement_Button.TabIndex = 26
        Me.Achievement_Button.Text = "Click to see your Achievements"
        Me.Achievement_Button.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 326)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(290, 25)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Grandma's Cookies are superior"
        '
        'CookieClicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(1169, 670)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Achievement_Button)
        Me.Controls.Add(Me.Grandmas_Cookies)
        Me.Controls.Add(Me.Button_Command_4)
        Me.Controls.Add(Me.Price_Text_4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Remind_1)
        Me.Controls.Add(Me.Button_Command_3)
        Me.Controls.Add(Me.Price_Text_3)
        Me.Controls.Add(Me.cookie_workers)
        Me.Controls.Add(Me.Achievement)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cookie_Stores)
        Me.Controls.Add(Me.Cookie_Multiplier)
        Me.Controls.Add(Me.RoundButton1)
        Me.Controls.Add(Me.Level_Text_2)
        Me.Controls.Add(Me.Button_Command_2)
        Me.Controls.Add(Me.Price_Text_2)
        Me.Controls.Add(Me.Button_Command_1)
        Me.Controls.Add(Me.Level_Text_1)
        Me.Controls.Add(Me.Price_Text_1)
        Me.Controls.Add(Me.Cookie_Value)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "CookieClicker"
        Me.Text = "Cookie Clicker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cookie_Click As Label
    Friend WithEvents Achievement As Label
    Friend WithEvents Cookie_Value As Label
    Friend WithEvents PassiveCookieTimer As Timer
    Friend WithEvents Price_Text_1 As Label
    Friend WithEvents Level_Text_1 As Label
    Friend WithEvents Button_Command_1 As Button
    Friend WithEvents Price_Text_2 As Label
    Friend WithEvents Button_Command_2 As Button
    Friend WithEvents Level_Text_2 As Label
    Friend WithEvents RoundButton1 As RoundButton
    Friend WithEvents Cookie_Multiplier As Label
    Friend WithEvents Cookie_Stores As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cookie_workers As Label
    Friend WithEvents Price_Text_3 As Label
    Friend WithEvents Button_Command_3 As Button
    Friend WithEvents Remind_1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Price_Text_4 As Label
    Friend WithEvents Button_Command_4 As Button
    Friend WithEvents Grandmas_Cookies As Label
    Friend WithEvents Achievement_Button As Button
    Friend WithEvents Label3 As Label
End Class
