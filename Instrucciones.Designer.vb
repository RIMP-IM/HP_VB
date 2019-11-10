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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Instrucciones))
        Me.Titulo = New System.Windows.Forms.Label()
        Me.DescripcionLbl = New System.Windows.Forms.Label()
        Me.SiguienteBtn = New System.Windows.Forms.Button()
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
        'DescripcionLbl
        '
        Me.DescripcionLbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescripcionLbl.AutoSize = True
        Me.DescripcionLbl.CausesValidation = False
        Me.DescripcionLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DescripcionLbl.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionLbl.ForeColor = System.Drawing.Color.White
        Me.DescripcionLbl.Location = New System.Drawing.Point(12, 52)
        Me.DescripcionLbl.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.DescripcionLbl.MaximumSize = New System.Drawing.Size(560, 260)
        Me.DescripcionLbl.Name = "DescripcionLbl"
        Me.DescripcionLbl.Size = New System.Drawing.Size(556, 250)
        Me.DescripcionLbl.TabIndex = 2
        Me.DescripcionLbl.Text = resources.GetString("DescripcionLbl.Text")
        Me.DescripcionLbl.UseMnemonic = False
        '
        'SiguienteBtn
        '
        Me.SiguienteBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SiguienteBtn.AutoSize = True
        Me.SiguienteBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SiguienteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.SiguienteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.SiguienteBtn.FlatAppearance.BorderSize = 2
        Me.SiguienteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.SiguienteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.SiguienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SiguienteBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiguienteBtn.ForeColor = System.Drawing.Color.White
        Me.SiguienteBtn.Location = New System.Drawing.Point(505, 322)
        Me.SiguienteBtn.Name = "SiguienteBtn"
        Me.SiguienteBtn.Size = New System.Drawing.Size(67, 27)
        Me.SiguienteBtn.TabIndex = 3
        Me.SiguienteBtn.Text = "Siguente"
        Me.SiguienteBtn.UseVisualStyleBackColor = False
        '
        'Instrucciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.SiguienteBtn)
        Me.Controls.Add(Me.DescripcionLbl)
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
        Me.PerformLayout()

    End Sub

    Friend WithEvents Titulo As Label
    Friend WithEvents DescripcionLbl As Label
    Friend WithEvents SiguienteBtn As Button
End Class
