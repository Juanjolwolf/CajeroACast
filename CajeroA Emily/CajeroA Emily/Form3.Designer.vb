<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(211, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Retiros"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 139)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(211, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cantidad a retirar"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(247, 139)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(251, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(248, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Saldo restante"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(12, 197)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 60)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Retirar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Yellow
        Me.Button2.Location = New System.Drawing.Point(414, 329)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 60)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(173, 205)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(68, 52)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "10 mil"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(247, 263)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(68, 52)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "100 mil"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(321, 205)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(68, 52)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "50 mil"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(173, 263)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(68, 52)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "5 mil"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(321, 263)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(68, 52)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "200 mil"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button8.Location = New System.Drawing.Point(251, 205)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(68, 52)
        Me.Button8.TabIndex = 6
        Me.Button8.Text = "20 mil"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(510, 401)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
End Class
