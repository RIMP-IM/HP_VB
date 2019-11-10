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
        Me.pbPieza1 = New System.Windows.Forms.PictureBox()
        Me.pbPieza2 = New System.Windows.Forms.PictureBox()
        Me.pbPieza3 = New System.Windows.Forms.PictureBox()
        Me.pbPiezaA = New System.Windows.Forms.PictureBox()
        Me.pbPiezaB = New System.Windows.Forms.PictureBox()
        Me.pbPiezaC = New System.Windows.Forms.PictureBox()
        CType(Me.pbPieza1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPieza2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPieza3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPiezaA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPiezaB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPiezaC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbPieza1
        '
        Me.pbPieza1.Location = New System.Drawing.Point(209, 40)
        Me.pbPieza1.Name = "pbPieza1"
        Me.pbPieza1.Size = New System.Drawing.Size(120, 110)
        Me.pbPieza1.TabIndex = 0
        Me.pbPieza1.TabStop = False
        '
        'pbPieza2
        '
        Me.pbPieza2.Location = New System.Drawing.Point(341, 40)
        Me.pbPieza2.Name = "pbPieza2"
        Me.pbPieza2.Size = New System.Drawing.Size(120, 110)
        Me.pbPieza2.TabIndex = 1
        Me.pbPieza2.TabStop = False
        '
        'pbPieza3
        '
        Me.pbPieza3.Location = New System.Drawing.Point(477, 40)
        Me.pbPieza3.Name = "pbPieza3"
        Me.pbPieza3.Size = New System.Drawing.Size(120, 110)
        Me.pbPieza3.TabIndex = 2
        Me.pbPieza3.TabStop = False
        '
        'pbPiezaA
        '
        Me.pbPiezaA.Location = New System.Drawing.Point(209, 298)
        Me.pbPiezaA.Name = "pbPiezaA"
        Me.pbPiezaA.Size = New System.Drawing.Size(120, 110)
        Me.pbPiezaA.TabIndex = 3
        Me.pbPiezaA.TabStop = False
        '
        'pbPiezaB
        '
        Me.pbPiezaB.Location = New System.Drawing.Point(343, 298)
        Me.pbPiezaB.Name = "pbPiezaB"
        Me.pbPiezaB.Size = New System.Drawing.Size(120, 110)
        Me.pbPiezaB.TabIndex = 4
        Me.pbPiezaB.TabStop = False
        '
        'pbPiezaC
        '
        Me.pbPiezaC.Location = New System.Drawing.Point(476, 298)
        Me.pbPiezaC.Name = "pbPiezaC"
        Me.pbPiezaC.Size = New System.Drawing.Size(120, 110)
        Me.pbPiezaC.TabIndex = 5
        Me.pbPiezaC.TabStop = False
        '
        'Juego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pbPiezaC)
        Me.Controls.Add(Me.pbPiezaB)
        Me.Controls.Add(Me.pbPiezaA)
        Me.Controls.Add(Me.pbPieza3)
        Me.Controls.Add(Me.pbPieza2)
        Me.Controls.Add(Me.pbPieza1)
        Me.DoubleBuffered = True
        Me.Name = "Juego"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Juego"
        CType(Me.pbPieza1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPieza2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPieza3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPiezaA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPiezaB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPiezaC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbPieza1 As PictureBox
    Friend WithEvents pbPieza2 As PictureBox
    Friend WithEvents pbPieza3 As PictureBox
    Friend WithEvents pbPiezaA As PictureBox
    Friend WithEvents pbPiezaB As PictureBox
    Friend WithEvents pbPiezaC As PictureBox
End Class
