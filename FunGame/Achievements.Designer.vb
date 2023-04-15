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
        CType(Me.Falling_Grandma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Back_To_Cookie
        '
        Me.Back_To_Cookie.Location = New System.Drawing.Point(329, 316)
        Me.Back_To_Cookie.Name = "Back_To_Cookie"
        Me.Back_To_Cookie.Size = New System.Drawing.Size(145, 61)
        Me.Back_To_Cookie.TabIndex = 0
        Me.Back_To_Cookie.Text = "Button1"
        Me.Back_To_Cookie.UseVisualStyleBackColor = True
        '
        'Falling_Grandma
        '
        Me.Falling_Grandma.BackgroundImage = CType(resources.GetObject("Falling_Grandma.BackgroundImage"), System.Drawing.Image)
        Me.Falling_Grandma.Location = New System.Drawing.Point(12, 12)
        Me.Falling_Grandma.Name = "Falling_Grandma"
        Me.Falling_Grandma.Size = New System.Drawing.Size(262, 231)
        Me.Falling_Grandma.TabIndex = 1
        Me.Falling_Grandma.TabStop = False
        Me.Falling_Grandma.Visible = False
        Me.Falling_Grandma.WaitOnLoad = True
        '
        'Achievements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 450)
        Me.Controls.Add(Me.Falling_Grandma)
        Me.Controls.Add(Me.Back_To_Cookie)
        Me.Name = "Achievements"
        Me.Text = "Form3"
        CType(Me.Falling_Grandma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Back_To_Cookie As Button
    Friend WithEvents Falling_Grandma As PictureBox
End Class
