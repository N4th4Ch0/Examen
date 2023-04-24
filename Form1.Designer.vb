<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblIn = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.cmdFuncion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.Location = New System.Drawing.Point(71, 38)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(193, 25)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Solicitud de numero"
        '
        'lblIn
        '
        Me.lblIn.AutoSize = True
        Me.lblIn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblIn.Location = New System.Drawing.Point(71, 92)
        Me.lblIn.Name = "lblIn"
        Me.lblIn.Size = New System.Drawing.Size(237, 21)
        Me.lblIn.TabIndex = 1
        Me.lblIn.Text = "Introduce un numero del 1 al 10"
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblResultado.Location = New System.Drawing.Point(155, 227)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(0, 21)
        Me.lblResultado.TabIndex = 2
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(71, 116)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(74, 23)
        Me.txtNumero.TabIndex = 3
        '
        'cmdFuncion
        '
        Me.cmdFuncion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cmdFuncion.Location = New System.Drawing.Point(70, 145)
        Me.cmdFuncion.Name = "cmdFuncion"
        Me.cmdFuncion.Size = New System.Drawing.Size(75, 23)
        Me.cmdFuncion.TabIndex = 4
        Me.cmdFuncion.Text = "Verificar"
        Me.cmdFuncion.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 279)
        Me.Controls.Add(Me.cmdFuncion)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.lblIn)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblIn As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents cmdFuncion As Button
End Class
