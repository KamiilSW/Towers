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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.Location = New Point(233, 267)
        Button1.Name = "Button1"
        Button1.Size = New Size(24, 340)
        Button1.TabIndex = 0
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.Location = New Point(654, 267)
        Button2.Name = "Button2"
        Button2.Size = New Size(24, 340)
        Button2.TabIndex = 1
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Red
        Button3.Location = New Point(1061, 267)
        Button3.Name = "Button3"
        Button3.Size = New Size(24, 340)
        Button3.TabIndex = 2
        Button3.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ActiveCaptionText
        PictureBox1.Location = New Point(89, 596)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(323, 27)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.ActiveCaptionText
        PictureBox2.Location = New Point(506, 596)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(323, 27)
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.ActiveCaptionText
        PictureBox3.Location = New Point(915, 596)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(323, 27)
        PictureBox3.TabIndex = 5
        PictureBox3.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(102, 568)
        Button4.Name = "Button4"
        Button4.Size = New Size(297, 29)
        Button4.TabIndex = 6
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(117, 542)
        Button5.Name = "Button5"
        Button5.Size = New Size(270, 29)
        Button5.TabIndex = 7
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(102, 517)
        Button6.Name = "Button6"
        Button6.Size = New Size(297, 29)
        Button6.TabIndex = 8
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1392, 711)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button

End Class
