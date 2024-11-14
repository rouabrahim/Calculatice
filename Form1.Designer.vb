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
        Label1 = New Label()
        Label2 = New Label()
        txt_A = New TextBox()
        txt_B = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Label3 = New Label()
        lbl_res = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.GreenYellow
        Label1.Location = New Point(100, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(19, 20)
        Label1.TabIndex = 0
        Label1.Text = "A"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.GreenYellow
        Label2.Location = New Point(100, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(18, 20)
        Label2.TabIndex = 1
        Label2.Text = "B"
        ' 
        ' txt_A
        ' 
        txt_A.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        txt_A.Location = New Point(181, 51)
        txt_A.Name = "txt_A"
        txt_A.Size = New Size(125, 27)
        txt_A.TabIndex = 2
        ' 
        ' txt_B
        ' 
        txt_B.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        txt_B.Location = New Point(181, 109)
        txt_B.Name = "txt_B"
        txt_B.Size = New Size(125, 27)
        txt_B.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Salmon
        Button1.Location = New Point(211, 190)
        Button1.Name = "Button1"
        Button1.Size = New Size(74, 52)
        Button1.TabIndex = 4
        Button1.Text = "+"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Salmon
        Button2.Location = New Point(327, 190)
        Button2.Name = "Button2"
        Button2.Size = New Size(74, 52)
        Button2.TabIndex = 5
        Button2.Text = "-"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Salmon
        Button3.Location = New Point(432, 190)
        Button3.Name = "Button3"
        Button3.Size = New Size(74, 52)
        Button3.TabIndex = 6
        Button3.Text = "*"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Salmon
        Button4.Location = New Point(546, 190)
        Button4.Name = "Button4"
        Button4.Size = New Size(74, 52)
        Button4.TabIndex = 7
        Button4.Text = "/"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.NavajoWhite
        Button5.Location = New Point(458, 281)
        Button5.Name = "Button5"
        Button5.Size = New Size(123, 52)
        Button5.TabIndex = 8
        Button5.Text = "Reset"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.NavajoWhite
        Button6.Location = New Point(243, 281)
        Button6.Name = "Button6"
        Button6.Size = New Size(128, 52)
        Button6.TabIndex = 9
        Button6.Text = "="
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.LightPink
        Label3.Location = New Point(135, 418)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 20)
        Label3.TabIndex = 10
        Label3.Text = "Resultat"
        ' 
        ' lbl_res
        ' 
        lbl_res.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        lbl_res.Location = New Point(338, 411)
        lbl_res.Name = "lbl_res"
        lbl_res.Size = New Size(264, 27)
        lbl_res.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(800, 495)
        Controls.Add(lbl_res)
        Controls.Add(Label3)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(txt_B)
        Controls.Add(txt_A)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_A As TextBox
    Friend WithEvents txt_B As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_res As TextBox

End Class
