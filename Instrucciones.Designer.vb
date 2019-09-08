<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Instrucciones
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
        Me.Titulo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Titulo
        '
        Me.Titulo.CausesValidation = False
        Me.Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Titulo.Font = New System.Drawing.Font("Mongolian Baiti", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.ForeColor = System.Drawing.Color.Gainsboro
        Me.Titulo.Location = New System.Drawing.Point(106, 14)
        Me.Titulo.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(374, 43)
        Me.Titulo.TabIndex = 1
        Me.Titulo.Text = "Instrucciones"
        Me.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Titulo.UseMnemonic = False
        '
        'Label1
        '
        Me.Label1.CausesValidation = False
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 77)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(560, 195)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Hexa Pawn es un juego"
        Me.Label1.UseMnemonic = False
        '
        'Instrucciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Titulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 400)
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "Instrucciones"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hexa Pawn"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Titulo As Label
    Friend WithEvents Label1 As Label
End Class
