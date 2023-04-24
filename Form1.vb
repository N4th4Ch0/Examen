Public Class Form1
    Private Sub cmdFuncion_Click(sender As Object, e As EventArgs) Handles cmdFuncion.Click


        'Dim numero As Integer

        'numero = txtNumero.Text


        If txtNumero.Text >= 0 AndAlso txtNumero.Text <= 10 Then
            'andalso sirve para tomar otra comparacion dentro del mismo if seria un if y 

            lblResultado.Text = " Has introducido el numero " & txtNumero.Text
            lblResultado.ForeColor = Color.Green

        Else

            lblResultado.Text = "El numero es incorrecto"
            lblResultado.ForeColor = Color.Red

        End If





    End Sub
End Class
