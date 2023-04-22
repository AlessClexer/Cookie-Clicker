<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Achievements
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Achievements))
        Me.Back_To_Cookie = New System.Windows.Forms.Button()
        Me.Falling_Grandma = New System.Windows.Forms.PictureBox()
        Me.Cookie_Stores_5 = New System.Windows.Forms.PictureBox()
        Me.Grandma_Cookie_1 = New System.Windows.Forms.Label()
        Me.CookieStores_5 = New System.Windows.Forms.Label()
        CType(Me.Falling_Grandma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cookie_Stores_5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Back_To_Cookie
        '
        Me.Back_To_Cookie.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Back_To_Cookie.Location = New System.Drawing.Point(95, 384)
        Me.Back_To_Cookie.Name = "Back_To_Cookie"
        Me.Back_To_Cookie.Size = New System.Drawing.Size(599, 54)
        Me.Back_To_Cookie.TabIndex = 0
        Me.Back_To_Cookie.Text = "Click to get back to Cookie Clicker game"
        Me.Back_To_Cookie.UseVisualStyleBackColor = True
        '
        'Falling_Grandma
        '
        Me.Falling_Grandma.BackgroundImage = CType(resources.GetObject("Falling_Grandma.BackgroundImage"), System.Drawing.Image)
        Me.Falling_Grandma.Location = New System.Drawing.Point(35, 12)
        Me.Falling_Grandma.Name = "Falling_Grandma"
        Me.Falling_Grandma.Size = New System.Drawing.Size(262, 231)
        Me.Falling_Grandma.TabIndex = 1
        Me.Falling_Grandma.TabStop = False
        Me.Falling_Grandma.Visible = False
        Me.Falling_Grandma.WaitOnLoad = True
        '
        'Cookie_Stores_5
        '
        Me.Cookie_Stores_5.BackgroundImage = CType(resources.GetObject("Cookie_Stores_5.BackgroundImage"), System.Drawing.Image)
        Me.Cookie_Stores_5.Location = New System.Drawing.Point(443, 34)
        Me.Cookie_Stores_5.Name = "Cookie_Stores_5"
        Me.Cookie_Stores_5.Size = New System.Drawing.Size(297, 209)
        Me.Cookie_Stores_5.TabIndex = 3
        Me.Cookie_Stores_5.TabStop = False
        Me.Cookie_Stores_5.Visible = False
        '
        'Grandma_Cookie_1
        '
        Me.Grandma_Cookie_1.AutoSize = True
        Me.Grandma_Cookie_1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Grandma_Cookie_1.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.Grandma_Cookie_1.Location = New System.Drawing.Point(12, 246)
        Me.Grandma_Cookie_1.Name = "Grandma_Cookie_1"
        Me.Grandma_Cookie_1.Size = New System.Drawing.Size(311, 35)
        Me.Grandma_Cookie_1.TabIndex = 4
        Me.Grandma_Cookie_1.Text = "Gotten 1 Grandma Cookie"
        Me.Grandma_Cookie_1.Visible = False
        '
        'CookieStores_5
        '
        Me.CookieStores_5.AutoSize = True
        Me.CookieStores_5.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CookieStores_5.ForeColor = System.Drawing.Color.SaddleBrown
        Me.CookieStores_5.Location = New System.Drawing.Point(443, 246)
        Me.CookieStores_5.Name = "CookieStores_5"
        Me.CookieStores_5.Size = New System.Drawing.Size(289, 35)
        Me.CookieStores_5.TabIndex = 6
        Me.CookieStores_5.Text = "Gotten 5 Cookie Stores"
        Me.CookieStores_5.Visible = False
        '
        'Achievements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(814, 450)
        Me.Controls.Add(Me.CookieStores_5)
        Me.Controls.Add(Me.Grandma_Cookie_1)
        Me.Controls.Add(Me.Cookie_Stores_5)
        Me.Controls.Add(Me.Falling_Grandma)
        Me.Controls.Add(Me.Back_To_Cookie)
        Me.Name = "Achievements"
        Me.Text = "Form3"
        CType(Me.Falling_Grandma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cookie_Stores_5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Back_To_Cookie As Button
    Friend WithEvents Falling_Grandma As PictureBox
    Friend WithEvents Cookie_1000 As PictureBox
    Friend WithEvents Cookie_Stores_5 As PictureBox
    Friend WithEvents Grandma_Cookie_1 As Label
    Friend WithEvents Cookies_1000_Total As Label
    Friend WithEvents CookieStores_5 As Label
End Class
