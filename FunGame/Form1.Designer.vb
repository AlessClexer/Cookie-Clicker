<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Cookie_Value = New System.Windows.Forms.Label()
        Me.btn_cookie_click = New System.Windows.Forms.Button()
        Me.PassiveCookieTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Price_Text_1 = New System.Windows.Forms.Label()
        Me.Level_Text_1 = New System.Windows.Forms.Label()
        Me.Button_Command_1 = New System.Windows.Forms.Button()
        Me.Price_Text_2 = New System.Windows.Forms.Label()
        Me.Button_Command_2 = New System.Windows.Forms.Button()
        Me.Level_Text_2 = New System.Windows.Forms.Label()
        Me.btn_cookie_click_2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RoundButton1 = New FunGame.RoundButton()
        Me.Cookie_Multiplier = New System.Windows.Forms.Label()
        Me.Cookie_Stores = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cookie_Value
        '
        Me.Cookie_Value.AutoSize = True
        Me.Cookie_Value.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Cookie_Value.Location = New System.Drawing.Point(302, 3)
        Me.Cookie_Value.Name = "Cookie_Value"
        Me.Cookie_Value.Size = New System.Drawing.Size(279, 81)
        Me.Cookie_Value.TabIndex = 0
        Me.Cookie_Value.Text = "Cookie: 0"
        '
        'btn_cookie_click
        '
        Me.btn_cookie_click.Location = New System.Drawing.Point(651, 377)
        Me.btn_cookie_click.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_cookie_click.Name = "btn_cookie_click"
        Me.btn_cookie_click.Size = New System.Drawing.Size(231, 64)
        Me.btn_cookie_click.TabIndex = 1
        Me.btn_cookie_click.Text = "Click To Increase Cookie By 1"
        Me.btn_cookie_click.UseVisualStyleBackColor = True
        '
        'PassiveCookieTimer
        '
        '
        'Price_Text_1
        '
        Me.Price_Text_1.AutoSize = True
        Me.Price_Text_1.BackColor = System.Drawing.Color.Goldenrod
        Me.Price_Text_1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Price_Text_1.Location = New System.Drawing.Point(47, 38)
        Me.Price_Text_1.Name = "Price_Text_1"
        Me.Price_Text_1.Size = New System.Drawing.Size(115, 45)
        Me.Price_Text_1.TabIndex = 2
        Me.Price_Text_1.Text = "Price 2"
        '
        'Level_Text_1
        '
        Me.Level_Text_1.AutoSize = True
        Me.Level_Text_1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Level_Text_1.Location = New System.Drawing.Point(64, 150)
        Me.Level_Text_1.Name = "Level_Text_1"
        Me.Level_Text_1.Size = New System.Drawing.Size(82, 45)
        Me.Level_Text_1.TabIndex = 3
        Me.Level_Text_1.Text = "Lvl 0"
        '
        'Button_Command_1
        '
        Me.Button_Command_1.Location = New System.Drawing.Point(13, 87)
        Me.Button_Command_1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button_Command_1.Name = "Button_Command_1"
        Me.Button_Command_1.Size = New System.Drawing.Size(173, 61)
        Me.Button_Command_1.TabIndex = 4
        Me.Button_Command_1.Text = "Increase Value of Click"
        Me.Button_Command_1.UseVisualStyleBackColor = True
        '
        'Price_Text_2
        '
        Me.Price_Text_2.AutoSize = True
        Me.Price_Text_2.BackColor = System.Drawing.Color.Goldenrod
        Me.Price_Text_2.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Price_Text_2.Location = New System.Drawing.Point(696, 39)
        Me.Price_Text_2.Name = "Price_Text_2"
        Me.Price_Text_2.Size = New System.Drawing.Size(149, 45)
        Me.Price_Text_2.TabIndex = 8
        Me.Price_Text_2.Text = "Price 100"
        '
        'Button_Command_2
        '
        Me.Button_Command_2.Location = New System.Drawing.Point(682, 87)
        Me.Button_Command_2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button_Command_2.Name = "Button_Command_2"
        Me.Button_Command_2.Size = New System.Drawing.Size(185, 60)
        Me.Button_Command_2.TabIndex = 9
        Me.Button_Command_2.Text = "Click to Buy Cookie Stores"
        Me.Button_Command_2.UseVisualStyleBackColor = True
        '
        'Level_Text_2
        '
        Me.Level_Text_2.AutoSize = True
        Me.Level_Text_2.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Level_Text_2.Location = New System.Drawing.Point(738, 151)
        Me.Level_Text_2.Name = "Level_Text_2"
        Me.Level_Text_2.Size = New System.Drawing.Size(82, 45)
        Me.Level_Text_2.TabIndex = 10
        Me.Level_Text_2.Text = "Lvl 0"
        '
        'btn_cookie_click_2
        '
        Me.btn_cookie_click_2.Location = New System.Drawing.Point(651, 305)
        Me.btn_cookie_click_2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_cookie_click_2.Name = "btn_cookie_click_2"
        Me.btn_cookie_click_2.Size = New System.Drawing.Size(234, 64)
        Me.btn_cookie_click_2.TabIndex = 11
        Me.btn_cookie_click_2.Text = "Click To Increase Cookie By 1"
        Me.btn_cookie_click_2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 282)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(243, 230)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'RoundButton1
        '
        Me.RoundButton1.Font = New System.Drawing.Font("Comic Sans MS", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RoundButton1.ForeColor = System.Drawing.Color.Red
        Me.RoundButton1.Image = CType(resources.GetObject("RoundButton1.Image"), System.Drawing.Image)
        Me.RoundButton1.Location = New System.Drawing.Point(302, 78)
        Me.RoundButton1.Name = "RoundButton1"
        Me.RoundButton1.Size = New System.Drawing.Size(265, 267)
        Me.RoundButton1.TabIndex = 13
        Me.RoundButton1.Text = "COOKIE!!"
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
        Me.Cookie_Stores.Location = New System.Drawing.Point(273, 396)
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
        Me.Label1.Size = New System.Drawing.Size(206, 55)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "IGNORE:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(911, 506)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cookie_Stores)
        Me.Controls.Add(Me.Cookie_Multiplier)
        Me.Controls.Add(Me.RoundButton1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_cookie_click_2)
        Me.Controls.Add(Me.Level_Text_2)
        Me.Controls.Add(Me.Button_Command_2)
        Me.Controls.Add(Me.Price_Text_2)
        Me.Controls.Add(Me.Button_Command_1)
        Me.Controls.Add(Me.Level_Text_1)
        Me.Controls.Add(Me.Price_Text_1)
        Me.Controls.Add(Me.btn_cookie_click)
        Me.Controls.Add(Me.Cookie_Value)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Cookie Clicker"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cookie_Click As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Cookie_Value As Label
    Friend WithEvents btn_cookie_click As Button
    Friend WithEvents PassiveCookieTimer As Timer
    Friend WithEvents Price_Text_1 As Label
    Friend WithEvents Level_Text_1 As Label
    Friend WithEvents Button_Command_1 As Button
    Friend WithEvents Price_Text_2 As Label
    Friend WithEvents Button_Command_2 As Button
    Friend WithEvents Level_Text_2 As Label
    Friend WithEvents btn_cookie_click_2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RoundButton1 As RoundButton
    Friend WithEvents Cookie_Multiplier As Label
    Friend WithEvents Cookie_Stores As Label
    Friend WithEvents Label1 As Label
End Class
