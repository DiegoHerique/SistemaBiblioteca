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
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        DateTimePicker1 = New DateTimePicker()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        Button1 = New Button()
        MaskedTextBox1 = New MaskedTextBox()
        Panel1 = New Panel()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(98, 186)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 15)
        Label1.TabIndex = 0
        Label1.Text = "Gênero"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(102, 238)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 15)
        Label2.TabIndex = 1
        Label2.Text = "Título"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(98, 117)
        Label3.Name = "Label3"
        Label3.Size = New Size(37, 15)
        Label3.TabIndex = 2
        Label3.Text = "Autor"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(223, 36)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 15)
        Label4.TabIndex = 3
        Label4.Text = "Biblioteca"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(330, 117)
        Label5.Name = "Label5"
        Label5.Size = New Size(109, 15)
        Label5.TabIndex = 4
        Label5.Text = "Ano de Publicação "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(330, 186)
        Label6.Name = "Label6"
        Label6.Size = New Size(32, 15)
        Label6.TabIndex = 5
        Label6.Text = "ISBN"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(330, 238)
        Label7.Name = "Label7"
        Label7.Size = New Size(41, 15)
        Label7.TabIndex = 6
        Label7.Text = "Label7"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(330, 139)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 7
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(96, 142)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 8
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(96, 212)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(121, 23)
        ComboBox2.TabIndex = 9
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(96, 268)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(121, 23)
        ComboBox3.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(632, 238)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 11
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Location = New Point(330, 212)
        MaskedTextBox1.Mask = "00-0-000000-00-0"
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(100, 23)
        MaskedTextBox1.TabIndex = 12
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(0, 311)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(798, 258)
        Panel1.TabIndex = 13
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 621)
        Controls.Add(Panel1)
        Controls.Add(MaskedTextBox1)
        Controls.Add(Button1)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Panel1 As Panel
End Class
