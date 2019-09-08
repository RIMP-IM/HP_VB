<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim BtnSalir As System.Windows.Forms.Button
        Me.Titulo = New System.Windows.Forms.Label()
        Me.BtnIniciar = New System.Windows.Forms.Button()
        Me.BtnRestablecer = New System.Windows.Forms.Button()
        BtnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        BtnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(79, Byte), Integer))
        BtnSalir.CausesValidation = False
        BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(90, Byte), Integer))
        BtnSalir.FlatAppearance.BorderSize = 3
        BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(26, Byte), Integer))
        BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(85, Byte), Integer))
        BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        BtnSalir.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        BtnSalir.ForeColor = System.Drawing.Color.White
        BtnSalir.Location = New System.Drawing.Point(8, 317)
        BtnSalir.Name = "BtnSalir"
        BtnSalir.Size = New System.Drawing.Size(109, 36)
        BtnSalir.TabIndex = 3
        BtnSalir.Text = "&Salir"
        BtnSalir.UseVisualStyleBackColor = False
        AddHandler BtnSalir.Click, AddressOf Me.BtnSalir_Click
        '
        'Titulo
        '
        Me.Titulo.CausesValidation = False
        Me.Titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Titulo.Font = New System.Drawing.Font("Mongolian Baiti", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.ForeColor = System.Drawing.Color.White
        Me.Titulo.Location = New System.Drawing.Point(5, 5)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(374, 43)
        Me.Titulo.TabIndex = 0
        Me.Titulo.Text = "Hexa Pawn"
        Me.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Titulo.UseMnemonic = False
        '
        'BtnIniciar
        '
        Me.BtnIniciar.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.BtnIniciar.CausesValidation = False
        Me.BtnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnIniciar.FlatAppearance.BorderSize = 3
        Me.BtnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BtnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIniciar.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIniciar.ForeColor = System.Drawing.Color.White
        Me.BtnIniciar.Location = New System.Drawing.Point(100, 87)
        Me.BtnIniciar.Name = "BtnIniciar"
        Me.BtnIniciar.Size = New System.Drawing.Size(180, 63)
        Me.BtnIniciar.TabIndex = 1
        Me.BtnIniciar.Text = "&Iniciar"
        Me.BtnIniciar.UseVisualStyleBackColor = False
        '
        'BtnRestablecer
        '
        Me.BtnRestablecer.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.BtnRestablecer.CausesValidation = False
        Me.BtnRestablecer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnRestablecer.FlatAppearance.BorderSize = 3
        Me.BtnRestablecer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BtnRestablecer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BtnRestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRestablecer.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRestablecer.ForeColor = System.Drawing.Color.White
        Me.BtnRestablecer.Location = New System.Drawing.Point(100, 178)
        Me.BtnRestablecer.Name = "BtnRestablecer"
        Me.BtnRestablecer.Size = New System.Drawing.Size(180, 63)
        Me.BtnRestablecer.TabIndex = 2
        Me.BtnRestablecer.Text = "&Restablecer"
        Me.BtnRestablecer.UseVisualStyleBackColor = False
        '
        'Inicio
        '
        Me.AccessibleDescription = ""
        Me.AccessibleName = ""
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(BtnSalir)
        Me.Controls.Add(Me.BtnRestablecer)
        Me.Controls.Add(Me.BtnIniciar)
        Me.Controls.Add(Me.Titulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 400)
        Me.MinimumSize = New System.Drawing.Size(400, 400)
        Me.Name = "Inicio"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HexaPawn"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Titulo As Label
    Friend WithEvents BtnRestablecer As Button
    Friend WithEvents BtnIniciar As Button
End Class
