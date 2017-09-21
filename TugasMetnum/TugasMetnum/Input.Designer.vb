<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Input
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
        Me.Angka1 = New System.Windows.Forms.Label()
        Me.Angka2 = New System.Windows.Forms.Label()
        Me.T_1 = New System.Windows.Forms.TextBox()
        Me.T_2 = New System.Windows.Forms.TextBox()
        Me.T_Hasil = New System.Windows.Forms.TextBox()
        Me.Hasil = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Angka1
        '
        Me.Angka1.AutoSize = True
        Me.Angka1.Location = New System.Drawing.Point(95, 95)
        Me.Angka1.Name = "Angka1"
        Me.Angka1.Size = New System.Drawing.Size(133, 13)
        Me.Angka1.TabIndex = 0
        Me.Angka1.Text = "Masukan Angka Pertama :"
        '
        'Angka2
        '
        Me.Angka2.AutoSize = True
        Me.Angka2.Location = New System.Drawing.Point(103, 129)
        Me.Angka2.Name = "Angka2"
        Me.Angka2.Size = New System.Drawing.Size(125, 13)
        Me.Angka2.TabIndex = 1
        Me.Angka2.Text = "Masukan Angka Kedua :"
        '
        'T_1
        '
        Me.T_1.Location = New System.Drawing.Point(234, 91)
        Me.T_1.Name = "T_1"
        Me.T_1.Size = New System.Drawing.Size(100, 20)
        Me.T_1.TabIndex = 2
        '
        'T_2
        '
        Me.T_2.Location = New System.Drawing.Point(234, 125)
        Me.T_2.Name = "T_2"
        Me.T_2.Size = New System.Drawing.Size(100, 20)
        Me.T_2.TabIndex = 3
        '
        'T_Hasil
        '
        Me.T_Hasil.Location = New System.Drawing.Point(234, 151)
        Me.T_Hasil.Name = "T_Hasil"
        Me.T_Hasil.Size = New System.Drawing.Size(100, 20)
        Me.T_Hasil.TabIndex = 4
        '
        'Hasil
        '
        Me.Hasil.AutoSize = True
        Me.Hasil.Location = New System.Drawing.Point(189, 154)
        Me.Hasil.Name = "Hasil"
        Me.Hasil.Size = New System.Drawing.Size(30, 13)
        Me.Hasil.TabIndex = 5
        Me.Hasil.Text = "Hasil"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(340, 125)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Enter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(54, 202)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Input
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 234)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Hasil)
        Me.Controls.Add(Me.T_Hasil)
        Me.Controls.Add(Me.T_2)
        Me.Controls.Add(Me.T_1)
        Me.Controls.Add(Me.Angka2)
        Me.Controls.Add(Me.Angka1)
        Me.Name = "Input"
        Me.Text = "Input"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Angka1 As System.Windows.Forms.Label
    Friend WithEvents Angka2 As System.Windows.Forms.Label
    Friend WithEvents T_1 As System.Windows.Forms.TextBox
    Friend WithEvents T_2 As System.Windows.Forms.TextBox
    Friend WithEvents T_Hasil As System.Windows.Forms.TextBox
    Friend WithEvents Hasil As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
