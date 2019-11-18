<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Juego
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Juego))
        Me.perrono1 = New System.Windows.Forms.PictureBox()
        Me.perrono3 = New System.Windows.Forms.PictureBox()
        Me.perrono2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        CType(Me.perrono1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.perrono3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.perrono2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'perrono1
        '
        Me.perrono1.BackColor = System.Drawing.Color.Transparent
        Me.perrono1.BackgroundImage = CType(resources.GetObject("perrono1.BackgroundImage"), System.Drawing.Image)
        Me.perrono1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.perrono1.Location = New System.Drawing.Point(181, -17)
        Me.perrono1.Name = "perrono1"
        Me.perrono1.Size = New System.Drawing.Size(169, 197)
        Me.perrono1.TabIndex = 1
        Me.perrono1.TabStop = False
        '
        'perrono3
        '
        Me.perrono3.BackColor = System.Drawing.Color.Transparent
        Me.perrono3.BackgroundImage = CType(resources.GetObject("perrono3.BackgroundImage"), System.Drawing.Image)
        Me.perrono3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.perrono3.Location = New System.Drawing.Point(454, -17)
        Me.perrono3.Name = "perrono3"
        Me.perrono3.Size = New System.Drawing.Size(169, 197)
        Me.perrono3.TabIndex = 2
        Me.perrono3.TabStop = False
        '
        'perrono2
        '
        Me.perrono2.BackColor = System.Drawing.Color.Transparent
        Me.perrono2.BackgroundImage = CType(resources.GetObject("perrono2.BackgroundImage"), System.Drawing.Image)
        Me.perrono2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.perrono2.Location = New System.Drawing.Point(311, -17)
        Me.perrono2.Name = "perrono2"
        Me.perrono2.Size = New System.Drawing.Size(169, 197)
        Me.perrono2.TabIndex = 3
        Me.perrono2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(181, 247)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(169, 191)
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Location = New System.Drawing.Point(311, 247)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(169, 191)
        Me.PictureBox5.TabIndex = 5
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox6.Location = New System.Drawing.Point(454, 247)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(169, 191)
        Me.PictureBox6.TabIndex = 6
        Me.PictureBox6.TabStop = False
        '
        'Juego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.perrono2)
        Me.Controls.Add(Me.perrono3)
        Me.Controls.Add(Me.perrono1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Name = "Juego"
        Me.Text = "HEXAPAWN"
        CType(Me.perrono1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.perrono3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.perrono2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents perrono1 As PictureBox
    Friend WithEvents perrono3 As PictureBox
    Friend WithEvents perrono2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
End Class
