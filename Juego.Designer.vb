<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Juego
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Juego))
        Me.PerroNo1 = New System.Windows.Forms.PictureBox()
        Me.GatoNo1 = New System.Windows.Forms.PictureBox()
        Me.GatoNo2 = New System.Windows.Forms.PictureBox()
        Me.GatoNo3 = New System.Windows.Forms.PictureBox()
        Me.PerroNo2 = New System.Windows.Forms.PictureBox()
        Me.PerroNo3 = New System.Windows.Forms.PictureBox()
        CType(Me.PerroNo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GatoNo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GatoNo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GatoNo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerroNo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerroNo3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PerroNo1
        '
        Me.PerroNo1.BackColor = System.Drawing.Color.Transparent
        Me.PerroNo1.BackgroundImage = CType(resources.GetObject("PerroNo1.BackgroundImage"), System.Drawing.Image)
        Me.PerroNo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PerroNo1.Location = New System.Drawing.Point(176, 252)
        Me.PerroNo1.Name = "PerroNo1"
        Me.PerroNo1.Size = New System.Drawing.Size(177, 186)
        Me.PerroNo1.TabIndex = 6
        Me.PerroNo1.TabStop = False
        '
        'GatoNo1
        '
        Me.GatoNo1.BackColor = System.Drawing.Color.Transparent
        Me.GatoNo1.BackgroundImage = CType(resources.GetObject("GatoNo1.BackgroundImage"), System.Drawing.Image)
        Me.GatoNo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GatoNo1.Location = New System.Drawing.Point(185, 12)
        Me.GatoNo1.Name = "GatoNo1"
        Me.GatoNo1.Size = New System.Drawing.Size(143, 158)
        Me.GatoNo1.TabIndex = 7
        Me.GatoNo1.TabStop = False
        '
        'GatoNo2
        '
        Me.GatoNo2.BackColor = System.Drawing.Color.Transparent
        Me.GatoNo2.BackgroundImage = CType(resources.GetObject("GatoNo2.BackgroundImage"), System.Drawing.Image)
        Me.GatoNo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GatoNo2.Location = New System.Drawing.Point(322, 12)
        Me.GatoNo2.Name = "GatoNo2"
        Me.GatoNo2.Size = New System.Drawing.Size(143, 158)
        Me.GatoNo2.TabIndex = 8
        Me.GatoNo2.TabStop = False
        '
        'GatoNo3
        '
        Me.GatoNo3.BackColor = System.Drawing.Color.Transparent
        Me.GatoNo3.BackgroundImage = CType(resources.GetObject("GatoNo3.BackgroundImage"), System.Drawing.Image)
        Me.GatoNo3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GatoNo3.Location = New System.Drawing.Point(458, 12)
        Me.GatoNo3.Name = "GatoNo3"
        Me.GatoNo3.Size = New System.Drawing.Size(143, 158)
        Me.GatoNo3.TabIndex = 9
        Me.GatoNo3.TabStop = False
        '
        'PerroNo2
        '
        Me.PerroNo2.BackColor = System.Drawing.Color.Transparent
        Me.PerroNo2.BackgroundImage = CType(resources.GetObject("PerroNo2.BackgroundImage"), System.Drawing.Image)
        Me.PerroNo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PerroNo2.Location = New System.Drawing.Point(310, 252)
        Me.PerroNo2.Name = "PerroNo2"
        Me.PerroNo2.Size = New System.Drawing.Size(177, 186)
        Me.PerroNo2.TabIndex = 10
        Me.PerroNo2.TabStop = False
        '
        'PerroNo3
        '
        Me.PerroNo3.BackColor = System.Drawing.Color.Transparent
        Me.PerroNo3.BackgroundImage = CType(resources.GetObject("PerroNo3.BackgroundImage"), System.Drawing.Image)
        Me.PerroNo3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PerroNo3.Location = New System.Drawing.Point(444, 252)
        Me.PerroNo3.Name = "PerroNo3"
        Me.PerroNo3.Size = New System.Drawing.Size(177, 186)
        Me.PerroNo3.TabIndex = 11
        Me.PerroNo3.TabStop = False
        '
        'Juego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PerroNo3)
        Me.Controls.Add(Me.PerroNo2)
        Me.Controls.Add(Me.GatoNo3)
        Me.Controls.Add(Me.GatoNo2)
        Me.Controls.Add(Me.GatoNo1)
        Me.Controls.Add(Me.PerroNo1)
        Me.DoubleBuffered = True
        Me.Name = "Juego"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Juego"
        CType(Me.PerroNo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GatoNo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GatoNo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GatoNo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerroNo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerroNo3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PerroNo1 As PictureBox
    Friend WithEvents GatoNo1 As PictureBox
    Friend WithEvents GatoNo2 As PictureBox
    Friend WithEvents GatoNo3 As PictureBox
    Friend WithEvents PerroNo2 As PictureBox
    Friend WithEvents PerroNo3 As PictureBox
End Class
