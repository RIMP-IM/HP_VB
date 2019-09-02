<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.Tetxop = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Titulo
        '
        Me.Titulo.AutoSize = True
        Me.Titulo.BackColor = System.Drawing.Color.Transparent
        Me.Titulo.Font = New System.Drawing.Font("Franklin Gothic Book", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.Location = New System.Drawing.Point(169, 9)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(94, 24)
        Me.Titulo.TabIndex = 0
        Me.Titulo.Text = "HexaPawn"
        '
        'Tetxop
        '
        Me.Tetxop.AutoSize = True
        Me.Tetxop.Location = New System.Drawing.Point(225, 119)
        Me.Tetxop.Name = "Tetxop"
        Me.Tetxop.Size = New System.Drawing.Size(28, 13)
        Me.Tetxop.TabIndex = 1
        Me.Tetxop.Text = "Test"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(449, 441)
        Me.Controls.Add(Me.Tetxop)
        Me.Controls.Add(Me.Titulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HexaPawn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Titulo As Label
    Friend WithEvents Tetxop As Label
End Class
