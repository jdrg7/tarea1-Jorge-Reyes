Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'NOTAS PRIMER PARCIAL
        'declaracion de variables
        Dim notaexamen1, acum1, nota1 As Integer

        'captura de datos
        notaexamen1 = Val(txtNotaexamen1.Text)
        acum1 = Val(txtAcum1.Text)
        nota1 = notaexamen1 + acum1
        txtNota1.Text = nota1

        'NOTAS SEGUNDO PARCIAL
        'declaracion de variables
        Dim notaexamen2, acum2, nota2 As Integer

        'captura de datos
        notaexamen2 = Val(txtNotaexamen2.Text)
        acum2 = Val(txtAcum2.Text)
        nota2 = notaexamen2 + acum2
        txtNota2.Text = nota2

        'NOTAS TERCER PARCIAL
        'declaracion de variables
        Dim notaexamen3, acum3, nota3 As Integer

        'captura de datos
        notaexamen3 = Val(txtNotaexamen3.Text)
        acum3 = Val(txtAcum3.Text)
        nota3 = notaexamen3 + acum3
        txtNota3.Text = nota3

        'NOTAS CUARTO PARCIAL
        'declaracion de variables
        Dim notaexamen4, acum4, nota4 As Integer

        'captura de datos
        notaexamen4 = Val(txtNotaexamen4.Text)
        acum4 = Val(txtAcum4.Text)
        nota4 = notaexamen4 + acum4
        txtNota4.Text = nota4

        'PROMEDIO
        'declaracion de variables
        Dim promedio As Double
        Dim calificacion_promedio As String

        'captura de datos
        promedio = (nota1 + nota2 + nota3 + nota4) / 4
        txtPromedio.Text = promedio

        If (promedio >= 91) Then
            calificacion_promedio = "Avanzado"
        ElseIf (promedio >= 81) Then
            calificacion_promedio = "Satisfactorio"
        ElseIf (promedio >= 70) Then
            calificacion_promedio = "Bueno"
        ElseIf (promedio >= 60) Then
            calificacion_promedio = "Aprobado"
        ElseIf (promedio >= 50) Then
            calificacion_promedio = "Puedes lograrlo, falta poco"
        Else
            calificacion_promedio = "Debes mejorar"
        End If

        txtCalificacionPromedio.Text = calificacion_promedio

        'PARCIAL MAS ALTO Y MAS BAJO

        'declaracion de variables
        If (nota1 > nota2 And nota1 > nota3 And nota1 > nota4) Then
            txtParcialalto.Text = nota1
        ElseIf (nota2 > nota1 And nota2 > nota3 And nota2 > nota4) Then
            txtParcialalto.Text = nota2
        ElseIf (nota3 > nota1 And nota3 > nota2 And nota3 > nota4) Then
            txtParcialalto.Text = nota3
        ElseIf (nota4 > nota1 And nota4 > nota2 And nota4 > nota3) Then
            txtParcialalto.Text = nota4
        Else
            txtParcialalto.Text = "Hay parciales iguales"
        End If

        If (nota1 < nota2 And nota1 < nota3 And nota1 < nota4) Then
            txtParcialbajo.Text = nota1
        ElseIf (nota2 < nota1 And nota2 < nota3 And nota2 < nota4) Then
            txtParcialbajo.Text = nota2
        ElseIf (nota3 < nota1 And nota3 < nota2 And nota3 < nota4) Then
            txtParcialbajo.Text = nota3
        ElseIf (nota4 < nota1 And nota4 < nota2 And nota4 < nota3) Then
            txtParcialbajo.Text = nota4
        Else
            txtParcialbajo.Text = "Hay parciales iguales"
        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtAcum1.Text = ""
        txtAcum2.Text = ""
        txtAcum3.Text = ""
        txtAcum4.Text = ""
        txtCalificacionPromedio.Text = ""
        txtNota1.Text = ""
        txtNota2.Text = ""
        txtNota3.Text = ""
        txtNota4.Text = ""
        txtNotaexamen1.Text = ""
        txtNotaexamen2.Text = ""
        txtNotaexamen3.Text = ""
        txtNotaexamen4.Text = ""
        txtParcialalto.Text = ""
        txtParcialbajo.Text = ""
        txtPromedio.Text = ""
    End Sub
End Class
