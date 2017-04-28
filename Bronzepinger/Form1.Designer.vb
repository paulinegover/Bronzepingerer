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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.InfoText
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"),System.Drawing.Image)
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"),System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(69, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 60)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Pinger"
        Me.Button1.UseVisualStyleBackColor = false
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"),System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(69, 166)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 60)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Summs"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"),System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(69, 245)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(140, 60)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Coming soon"
        Me.Button3.UseVisualStyleBackColor = true
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"),System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(69, 321)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(140, 60)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Coming soon"
        Me.Button4.UseVisualStyleBackColor = true
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"),System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(69, 397)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(140, 60)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Coming soon"
        Me.Button5.UseVisualStyleBackColor = true
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"),System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(199, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Login"
        Me.Button6.UseVisualStyleBackColor = true
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = true
        Me.LinkLabel1.Image = CType(resources.GetObject("LinkLabel1.Image"),System.Drawing.Image)
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(98, 7)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(95, 13)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = true
        Me.LinkLabel1.Text = "Create an account"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"),System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(275, 478)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "BronzePinger"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
