Public Class Form1

    '=========================================
    ' EJERCICIO 2 - VARIABLES GLOBALES
    '=========================================
    Dim productos As New List(Of String)
    Dim precios As New List(Of Decimal)

    '=========================================
    ' EJERCICIO 3 - INVENTARIO
    '=========================================
    Dim nombres() As String =
    {
        "Laptop Dell",
        "Mouse Logitech",
        "Teclado Redragon",
        "Monitor Samsung",
        "Headset HyperX",
        "SSD Kingston",
        "Memoria RAM Corsair",
        "Webcam Logitech",
        "Impresora HP",
        "Tablet Lenovo"
    }

    Dim preciosInventario() As Decimal =
    {
        15000D,
        450D,
        900D,
        4200D,
        1200D,
        850D,
        1500D,
        700D,
        3500D,
        4800D
    }

    '=========================================
    ' EJERCICIO 1
    ' CLASIFICADOR DE PRODUCTOS
    '=========================================

    Private Sub btnClasificar_Click(sender As Object, e As EventArgs) Handles btnClasificar.Click

        Dim precio As Decimal

        If Not Decimal.TryParse(txtPrecio.Text, precio) OrElse precio <= 0 Then
            MessageBox.Show("Ingrese un precio válido.")
            txtPrecio.Focus()
            Exit Sub
        End If

        Dim categoria As String

        If precio < 500 Then
            categoria = "Económico"
        ElseIf precio <= 2000 Then
            categoria = "Estándar"
        Else
            categoria = "Premium"
        End If

        Dim iva As Decimal = precio * 0.16D
        Dim precioFinal As Decimal = precio + iva

        lblCategoria.Text = categoria
        lblIva.Text = iva.ToString("C")
        lblPrecioFinal.Text = precioFinal.ToString("C")

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        txtNombre.Clear()
        txtPrecio.Clear()

        lblCategoria.Text = ""
        lblIva.Text = ""
        lblPrecioFinal.Text = ""

        txtNombre.Focus()

    End Sub

    '=========================================
    ' EJERCICIO 2
    ' GENERADOR DE TICKET
    '=========================================

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim precio As Decimal

        If txtNombreProducto.Text.Trim = "" Then
            MessageBox.Show("Ingrese un producto.")
            txtNombreProducto.Focus()
            Exit Sub
        End If

        If Not Decimal.TryParse(txtPrecioProducto.Text, precio) OrElse precio <= 0 Then
            MessageBox.Show("Precio inválido.")
            txtPrecioProducto.Focus()
            Exit Sub
        End If

        productos.Add(txtNombreProducto.Text)
        precios.Add(precio)

        lstProductos.Items.Add($"{txtNombreProducto.Text} - {precio:C}")

        CalcularTotales()

        txtNombreProducto.Clear()
        txtPrecioProducto.Clear()

    End Sub

    Private Sub CalcularTotales()

        Dim subtotal As Decimal = 0

        For Each precio As Decimal In precios
            subtotal += precio
        Next

        Dim descuento As Decimal = 0

        If productos.Count >= 3 Then
            descuento = subtotal * 0.05D
        End If

        subtotal -= descuento

        Dim iva As Decimal = subtotal * 0.16D
        Dim total As Decimal = subtotal + iva

        lblSubtotal.Text = subtotal.ToString("C")
        lblIva.Text = iva.ToString("C")
        lblTotal.Text = total.ToString("C")

    End Sub

    Private Sub btnGenerarTicket_Click(sender As Object, e As EventArgs) Handles btnGenerarTicket.Click

        Dim ticket As String = "===== TICKET =====" & vbCrLf

        Dim subtotal As Decimal = 0
        Dim contador As Integer = 1

        For Each precio As Decimal In precios
            subtotal += precio
        Next

        For Each producto As String In productos

            ticket &= contador & ". " &
                  producto & " - " &
                  precios(contador - 1).ToString("C") &
                  vbCrLf

            contador += 1

        Next

        Dim descuento As Decimal = 0

        If productos.Count >= 3 Then
            descuento = subtotal * 0.05D
        End If

        subtotal -= descuento

        Dim iva As Decimal = subtotal * 0.16D
        Dim total As Decimal = subtotal + iva

        ticket &= vbCrLf
        ticket &= "Subtotal: " & subtotal.ToString("C") & vbCrLf
        ticket &= "Descuento: " & descuento.ToString("C") & vbCrLf
        ticket &= "IVA: " & iva.ToString("C") & vbCrLf
        ticket &= "Total: " & total.ToString("C")

        MessageBox.Show(ticket)

    End Sub

    '=========================================
    ' EJERCICIO 3
    ' BUSCADOR DE PRODUCTOS
    '=========================================

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim busqueda As String = txtBusqueda.Text.Trim.ToLower()

        For i As Integer = 0 To nombres.Length - 1

            If nombres(i).ToLower() = busqueda Then

                lblResultado.Text =
                $"Encontrado en posición {i}" &
                vbCrLf &
                $"Precio: {precios(i):C}"

                Exit Sub

            End If

        Next

        lblResultado.Text = "Producto no encontrado."

    End Sub

End Class