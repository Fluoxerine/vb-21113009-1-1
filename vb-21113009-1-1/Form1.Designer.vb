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
        Label3 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("隶书", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(278, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(208, 98)
        Label1.TabIndex = 0
        Label1.Text = "欢迎学习VB.NET"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("宋体", 9F, FontStyle.Underline, GraphicsUnit.Point)
        Label2.Location = New Point(127, 172)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 15)
        Label2.TabIndex = 1
        Label2.Text = "请输入你的姓名"
        ' 
        ' Label3
        ' 
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.Location = New Point(483, 282)
        Label3.Name = "Label3"
        Label3.Size = New Size(133, 43)
        Label3.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(483, 166)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(161, 27)
        TextBox1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(127, 264)
        Button1.Name = "Button1"
        Button1.Size = New Size(148, 61)
        Button1.TabIndex = 4
        Button1.Text = "你输入的姓名是"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
End Class
