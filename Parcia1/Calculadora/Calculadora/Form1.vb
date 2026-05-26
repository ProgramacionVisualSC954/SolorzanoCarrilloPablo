Option Strict On
Imports System.Data

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.KeyPreview = True

        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True

        TextBox1.TextAlign = HorizontalAlignment.Right
        TextBox2.TextAlign = HorizontalAlignment.Right

        TextBox2.Focus()

    End Sub


    Private Sub Agregar(valor As String)

        If TextBox2.Text.Length > 0 Then

            Dim ultimo As String =
                TextBox2.Text.Substring(TextBox2.Text.Length - 1)

            If "+-*/".Contains(ultimo) And
               "+-*/".Contains(valor) Then
                Exit Sub
            End If

        End If

        TextBox2.Text &= valor

    End Sub


    Private Function ValidarCampoVacio(
        campo As TextBox,
        mensaje As String) As Boolean

        If campo.Text.Trim() = "" Then

            MessageBox.Show(mensaje)

            campo.Focus()

            Return False

        End If

        Return True

    End Function


    Private Function ParentesisValidos() As Boolean

        Dim abrir As Integer =
            TextBox2.Text.Count(Function(c) c = "("c)

        Dim cerrar As Integer =
            TextBox2.Text.Count(Function(c) c = ")"c)

        Return abrir = cerrar

    End Function


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


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim operadores As Char() =
            {"+"c, "-"c, "*"c, "/"c, "("c, ")"c}

        Dim partes() As String =
            TextBox2.Text.Split(operadores)

        Dim ultimoNumero As String =
            partes(partes.Length - 1)

        If Not ultimoNumero.Contains(".") Then
            Agregar(".")
        End If

    End Sub


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


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Try

            If Not ValidarCampoVacio(
                TextBox2,
                "El campo Número 1 no puede estar vacío") Then

                Exit Sub

            End If

            Dim expresion As String =
                TextBox2.Text.Trim()

            'Si inicia con operador (+,*,/)
            If expresion.Length > 0 Then

                If "+*/".Contains(expresion(0)) Then

                    MessageBox.Show(
                    "El campo Número 1 no puede estar vacío")

                    TextBox2.Focus()

                    Exit Sub

                End If

            End If

            'Si termina con operador
            If expresion.Length > 0 Then

                Dim ultimo As Char =
                expresion(expresion.Length - 1)

                If "+-*/".Contains(ultimo) Then

                    MessageBox.Show(
                    "El campo Número 2 no puede estar vacío")

                    TextBox2.Focus()

                    Exit Sub

                End If

            End If


            If Not ParentesisValidos() Then

                MessageBox.Show(
                "La expresión contiene paréntesis no balanceados")

                Exit Sub

            End If


            If TextBox2.Text.Contains("/0") Then

                Dim partes() As String =
                    TextBox2.Text.Split("/"c)

                If partes.Length > 1 Then

                    Dim divisor As Decimal

                    If Decimal.TryParse(
            partes(1),
            divisor) Then

                        If divisor = 0D Then

                            MessageBox.Show(
                "No se puede dividir entre cero")

                            TextBox1.Clear()

                            Exit Sub

                        End If

                    End If

                End If

            End If


            Dim resultado As Object =
            New DataTable().Compute(
            TextBox2.Text,
            Nothing)

            Dim valor As Decimal

            If Not Decimal.TryParse(
                resultado.ToString(),
                valor) Then

                MessageBox.Show(
                "El valor ingresado no es un número válido")

                TextBox2.Focus()

                Exit Sub

            End If


            If valor Mod 1 = 0 Then

                TextBox1.Text = valor.ToString("N0")
                TextBox2.Text = valor.ToString("N0")

            Else

                TextBox1.Text = valor.ToString("N2")
                TextBox2.Text = valor.ToString("N2")

            End If


        Catch ex As OverflowException

            MessageBox.Show(
            "El resultado está fuera del rango permitido")

        Catch ex As Exception

            MessageBox.Show(
            "Operación inválida")

        End Try

    End Sub


    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click

        Try

            Dim valor As Decimal

            If Not Decimal.TryParse(
                TextBox2.Text,
                valor) Then

                MessageBox.Show(
                "El valor ingresado no es un número válido")

                Exit Sub

            End If


            valor /= 100D

            If valor Mod 1 = 0 Then

                TextBox1.Text = valor.ToString("N0")
                TextBox2.Text = valor.ToString("N0")

            Else

                TextBox1.Text = valor.ToString("N2")
                TextBox2.Text = valor.ToString("N2")

            End If

        Catch ex As Exception

            MessageBox.Show("Error")

        End Try

    End Sub


    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click

        If TextBox2.Text.Length > 0 Then

            TextBox2.Text =
            TextBox2.Text.Substring(
            0,
            TextBox2.Text.Length - 1)

        End If

    End Sub


    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click

        TextBox1.Clear()
        TextBox2.Clear()

        TextBox2.Focus()

    End Sub


    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click

        TextBox2.Clear()

    End Sub


    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click

        Try

            Dim numero As Decimal

            If Not Decimal.TryParse(
                TextBox2.Text,
                numero) Then

                MessageBox.Show(
                "El valor ingresado no es un número válido")

                TextBox2.Focus()

                Exit Sub

            End If


            Dim resultado As Decimal =
                numero * numero

            If resultado Mod 1 = 0 Then

                TextBox1.Text = resultado.ToString("N0")
                TextBox2.Text = resultado.ToString("N0")

            Else

                TextBox1.Text = resultado.ToString("N2")
                TextBox2.Text = resultado.ToString("N2")

            End If

        Catch ex As OverflowException

            MessageBox.Show(
            "El resultado está fuera del rango permitido")

        End Try

    End Sub


    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click

        Try

            Dim numero As Decimal

            If Not Decimal.TryParse(
                TextBox2.Text,
                numero) Then

                MessageBox.Show(
                "El valor ingresado no es un número válido")

                TextBox2.Focus()

                Exit Sub

            End If


            Dim resultado As Double =
                Math.Sqrt(CDbl(numero))

            If Double.IsNaN(resultado) Then

                MessageBox.Show(
                "La raíz cuadrada de un número negativo no es real")

                Exit Sub

            End If


            Dim valor As Decimal =
                CDec(resultado)

            If valor Mod 1 = 0 Then

                TextBox1.Text = valor.ToString("N0")
                TextBox2.Text = valor.ToString("N0")

            Else

                TextBox1.Text = valor.ToString("N2")
                TextBox2.Text = valor.ToString("N2")

            End If
        Catch ex As Exception

            MessageBox.Show("Error")

        End Try

    End Sub


    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click

        Agregar("(")

    End Sub


    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click

        Dim abrir As Integer =
            TextBox2.Text.Count(
            Function(c) c = "("c)

        Dim cerrar As Integer =
            TextBox2.Text.Count(
            Function(c) c = ")"c)

        If abrir > cerrar Then

            Agregar(")")

        End If

    End Sub


    Private Sub Form1_KeyPress(
    sender As Object,
    e As KeyPressEventArgs) Handles Me.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            Agregar(e.KeyChar.ToString())
        End If

        Select Case e.KeyChar

            Case "+"c
                Agregar("+")

            Case "-"c
                Agregar("-")

            Case "*"c
                Agregar("*")

            Case "/"c
                Agregar("/")

            Case "."c
                Agregar(".")

            Case "("c
                Agregar("(")

            Case ")"c
                Agregar(")")

            Case ChrW(13)
                Button6.PerformClick()

        End Select

    End Sub
End Class