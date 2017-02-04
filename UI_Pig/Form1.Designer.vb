<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtJugador = New System.Windows.Forms.TextBox()
        Me.txtPC = New System.Windows.Forms.TextBox()
        Me.txtDado = New System.Windows.Forms.TextBox()
        Me.txtAcumulado = New System.Windows.Forms.TextBox()
        Me.btnTirar = New System.Windows.Forms.Button()
        Me.btnFinTurno = New System.Windows.Forms.Button()
        Me.lblJugador = New System.Windows.Forms.Label()
        Me.lblPC = New System.Windows.Forms.Label()
        Me.lblAcumulado = New System.Windows.Forms.Label()
        Me.lblDado = New System.Windows.Forms.Label()
        Me.lblPigDice = New System.Windows.Forms.Label()
        Me.lblTurnos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtJugador
        '
        Me.txtJugador.Location = New System.Drawing.Point(15, 70)
        Me.txtJugador.Name = "txtJugador"
        Me.txtJugador.Size = New System.Drawing.Size(100, 20)
        Me.txtJugador.TabIndex = 0
        '
        'txtPC
        '
        Me.txtPC.Location = New System.Drawing.Point(172, 70)
        Me.txtPC.Name = "txtPC"
        Me.txtPC.Size = New System.Drawing.Size(100, 20)
        Me.txtPC.TabIndex = 1
        '
        'txtDado
        '
        Me.txtDado.Location = New System.Drawing.Point(95, 148)
        Me.txtDado.Name = "txtDado"
        Me.txtDado.Size = New System.Drawing.Size(100, 20)
        Me.txtDado.TabIndex = 2
        '
        'txtAcumulado
        '
        Me.txtAcumulado.Location = New System.Drawing.Point(95, 109)
        Me.txtAcumulado.Name = "txtAcumulado"
        Me.txtAcumulado.Size = New System.Drawing.Size(100, 20)
        Me.txtAcumulado.TabIndex = 3
        '
        'btnTirar
        '
        Me.btnTirar.Location = New System.Drawing.Point(38, 206)
        Me.btnTirar.Name = "btnTirar"
        Me.btnTirar.Size = New System.Drawing.Size(75, 23)
        Me.btnTirar.TabIndex = 4
        Me.btnTirar.Text = "Tirar"
        Me.btnTirar.UseVisualStyleBackColor = True
        '
        'btnFinTurno
        '
        Me.btnFinTurno.Location = New System.Drawing.Point(172, 206)
        Me.btnFinTurno.Name = "btnFinTurno"
        Me.btnFinTurno.Size = New System.Drawing.Size(75, 23)
        Me.btnFinTurno.TabIndex = 5
        Me.btnFinTurno.Text = "Fin Turno"
        Me.btnFinTurno.UseVisualStyleBackColor = True
        '
        'lblJugador
        '
        Me.lblJugador.AutoSize = True
        Me.lblJugador.Location = New System.Drawing.Point(12, 54)
        Me.lblJugador.Name = "lblJugador"
        Me.lblJugador.Size = New System.Drawing.Size(45, 13)
        Me.lblJugador.TabIndex = 6
        Me.lblJugador.Text = "Jugador"
        '
        'lblPC
        '
        Me.lblPC.AutoSize = True
        Me.lblPC.Location = New System.Drawing.Point(169, 54)
        Me.lblPC.Name = "lblPC"
        Me.lblPC.Size = New System.Drawing.Size(21, 13)
        Me.lblPC.TabIndex = 7
        Me.lblPC.Text = "PC"
        '
        'lblAcumulado
        '
        Me.lblAcumulado.AutoSize = True
        Me.lblAcumulado.Location = New System.Drawing.Point(92, 93)
        Me.lblAcumulado.Name = "lblAcumulado"
        Me.lblAcumulado.Size = New System.Drawing.Size(60, 13)
        Me.lblAcumulado.TabIndex = 8
        Me.lblAcumulado.Text = "Acumulado"
        '
        'lblDado
        '
        Me.lblDado.AutoSize = True
        Me.lblDado.Location = New System.Drawing.Point(92, 132)
        Me.lblDado.Name = "lblDado"
        Me.lblDado.Size = New System.Drawing.Size(33, 13)
        Me.lblDado.TabIndex = 9
        Me.lblDado.Text = "Dado"
        '
        'lblPigDice
        '
        Me.lblPigDice.AutoSize = True
        Me.lblPigDice.Font = New System.Drawing.Font("Goudy Stout", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPigDice.Location = New System.Drawing.Point(85, 13)
        Me.lblPigDice.Name = "lblPigDice"
        Me.lblPigDice.Size = New System.Drawing.Size(113, 18)
        Me.lblPigDice.TabIndex = 10
        Me.lblPigDice.Text = "Pig Dice"
        '
        'lblTurnos
        '
        Me.lblTurnos.AutoSize = True
        Me.lblTurnos.Location = New System.Drawing.Point(272, 239)
        Me.lblTurnos.Name = "lblTurnos"
        Me.lblTurnos.Size = New System.Drawing.Size(0, 13)
        Me.lblTurnos.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblTurnos)
        Me.Controls.Add(Me.lblPigDice)
        Me.Controls.Add(Me.lblDado)
        Me.Controls.Add(Me.lblAcumulado)
        Me.Controls.Add(Me.lblPC)
        Me.Controls.Add(Me.lblJugador)
        Me.Controls.Add(Me.btnFinTurno)
        Me.Controls.Add(Me.btnTirar)
        Me.Controls.Add(Me.txtAcumulado)
        Me.Controls.Add(Me.txtDado)
        Me.Controls.Add(Me.txtPC)
        Me.Controls.Add(Me.txtJugador)
        Me.Name = "Form1"
        Me.Text = "Pig Dice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtJugador As TextBox
    Friend WithEvents txtPC As TextBox
    Friend WithEvents txtDado As TextBox
    Friend WithEvents txtAcumulado As TextBox
    Friend WithEvents btnTirar As Button
    Friend WithEvents btnFinTurno As Button
    Friend WithEvents lblJugador As Label
    Friend WithEvents lblPC As Label
    Friend WithEvents lblAcumulado As Label
    Friend WithEvents lblDado As Label
    Friend WithEvents lblPigDice As Label
    Friend WithEvents lblTurnos As Label
End Class
