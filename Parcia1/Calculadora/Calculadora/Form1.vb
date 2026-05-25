Imports System.Data

Public Class Form1

    '=================================================
    ' Configuración inicial
    '=================================================
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Permite detectar teclas del teclado
        Me.KeyPreview = True

        'Evita escritura manual
        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True

        'Alinea texto a la derecha
        TextBox1.TextAlign = HorizontalAlignment.Right
        TextBox2.TextAlign = HorizontalAlignment.Right

    End Sub


    '=================================================
    ' Agregar números y operadores
    ' Evita operadores duplicados
    '=================================================
    Private Sub Agregar(valor As String)

        Dim operadores As String = "+-*/"

        If TextBox2.Text.Length > 0 Then

            Dim ultimo As String =
            TextBox2.Text.Substring(TextBox2.Text.Length - 1)

            'Evita ++ -- **/
            If operadores.Contains(ultimo) And operadores.Contains(valor) Then
                Exit Sub
            End If

        End If

        TextBox2.Text &= valor

    End Sub


    '=================================================
    ' BOTONES NUMÉRICOS
    '=================================================

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Agregar("0")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Agregar("1")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Agregar("2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Agregar("3")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Agregar("4")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Agregar("5")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Agregar("6")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Agregar("7")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Agregar("8")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Agregar("9")
    End Sub


    '=================================================
    ' Punto decimal
    ' Evita varios puntos en un número
    '=================================================

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim partes() As String =
        TextBox2.Text.Split("+"c, "-"c, "*"c, "/"c)

        Dim ultimoNumero As String =
        partes(partes.Length - 1)

        If Not ultimoNumero.Contains(".") Then
            Agregar(".")
        End If

    End Sub


    '=================================================
    ' OPERADORES
    '=================================================

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Agregar("+")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Agregar("-")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Agregar("*")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Agregar("/")
    End Sub


    '=================================================
    ' Porcentaje
    '=================================================

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click

        Try

            Dim valor As Double

            valor = Convert.ToDouble(TextBox2.Text)

            valor = valor / 100

            Dim resultadoFinal As String =
            valor.ToString("0.######")

            TextBox1.Text = resultadoFinal
            TextBox2.Text = resultadoFinal

        Catch ex As Exception

            MessageBox.Show("Error")

        End Try

    End Sub


    '=================================================
    ' Igual
    ' Calcula y limita decimales mostrados
    '=================================================

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Try

            Dim resultado As Object

            resultado = New DataTable().Compute(TextBox2.Text, Nothing)

            'Convierte a número decimal
            Dim valor As Double = Convert.ToDouble(resultado)

            'Muestra máximo 6 decimales y elimina ceros sobrantes
            Dim resultadoFinal As String =
            valor.ToString("0.######")

            'Actualiza resultados
            TextBox1.Text = resultadoFinal
            TextBox2.Text = resultadoFinal

        Catch ex As Exception

            MessageBox.Show("Operación inválida")

        End Try

    End Sub


    '=================================================
    ' CE
    ' Borra solo operación actual
    '=================================================

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click

        TextBox2.Clear()

    End Sub


    '=================================================
    ' C
    ' Borra toda la calculadora
    '=================================================

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click

        TextBox1.Clear()
        TextBox2.Clear()

    End Sub


    '=================================================
    ' <x
    ' Borra un carácter
    '=================================================

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click

        If TextBox2.Text.Length > 0 Then

            TextBox2.Text =
            TextBox2.Text.Substring(0,
            TextBox2.Text.Length - 1)

        End If

    End Sub


    '=================================================
    ' Soporte para teclado
    '=================================================

    Private Sub Form1_KeyPress(sender As Object,
    e As KeyPressEventArgs) Handles Me.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            Agregar(e.KeyChar)
        End If

        Select Case e.KeyChar

            Case "+"
                Agregar("+")

            Case "-"
                Agregar("-")

            Case "*"
                Agregar("*")

            Case "/"
                Agregar("/")

            Case "."
                Agregar(".")

            Case Chr(13)
                Button6.PerformClick()

        End Select

    End Sub

End Class