<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        txtNombre = New TextBox()
        txtPrecio = New TextBox()
        lblCategoria = New Label()
        lblIva = New Label()
        lblPrecioFinal = New Label()
        btnClasificar = New Button()
        btnLimpiar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        txtPrecioProducto = New TextBox()
        txtNombreProducto = New TextBox()
        Label10 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        btnGenerarTicket = New Button()
        btnAgregar = New Button()
        lstProductos = New ListBox()
        lblTotal = New Label()
        lblIvaTicket = New Label()
        lblSubtotal = New Label()
        Label11 = New Label()
        txtBusqueda = New TextBox()
        btnBuscar = New Button()
        lblResultado = New Label()
        SuspendLayout()
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(124, 37)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(100, 23)
        txtNombre.TabIndex = 0
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(124, 66)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(100, 23)
        txtPrecio.TabIndex = 1
        ' 
        ' lblCategoria
        ' 
        lblCategoria.AutoSize = True
        lblCategoria.Font = New Font("Segoe UI", 12F)
        lblCategoria.Location = New Point(124, 111)
        lblCategoria.Name = "lblCategoria"
        lblCategoria.Size = New Size(213, 21)
        lblCategoria.TabIndex = 2
        lblCategoria.Text = "Economico/Estadar/Premium"
        ' 
        ' lblIva
        ' 
        lblIva.AutoSize = True
        lblIva.Font = New Font("Segoe UI", 12F)
        lblIva.Location = New Point(124, 132)
        lblIva.Name = "lblIva"
        lblIva.Size = New Size(19, 21)
        lblIva.TabIndex = 3
        lblIva.Text = "$"
        ' 
        ' lblPrecioFinal
        ' 
        lblPrecioFinal.AutoSize = True
        lblPrecioFinal.Font = New Font("Segoe UI", 12F)
        lblPrecioFinal.Location = New Point(124, 154)
        lblPrecioFinal.Name = "lblPrecioFinal"
        lblPrecioFinal.Size = New Size(19, 21)
        lblPrecioFinal.TabIndex = 4
        lblPrecioFinal.Text = "$"
        ' 
        ' btnClasificar
        ' 
        btnClasificar.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnClasificar.Font = New Font("Segoe UI", 12F)
        btnClasificar.Location = New Point(248, 30)
        btnClasificar.Name = "btnClasificar"
        btnClasificar.Size = New Size(135, 33)
        btnClasificar.TabIndex = 5
        btnClasificar.Text = "Clasificar"
        btnClasificar.UseVisualStyleBackColor = False
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnLimpiar.Font = New Font("Segoe UI", 12F)
        btnLimpiar.Location = New Point(248, 69)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(135, 37)
        btnLimpiar.TabIndex = 6
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(19, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 21)
        Label1.TabIndex = 7
        Label1.Text = "Producto:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.Location = New Point(20, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 21)
        Label2.TabIndex = 8
        Label2.Text = "Precio:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.Location = New Point(20, 111)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 21)
        Label3.TabIndex = 9
        Label3.Text = "Categoria:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label4.Location = New Point(20, 132)
        Label4.Name = "Label4"
        Label4.Size = New Size(40, 21)
        Label4.TabIndex = 10
        Label4.Text = "IVA:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label5.Location = New Point(19, 153)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 21)
        Label5.TabIndex = 11
        Label5.Text = "Precio final:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label6.Location = New Point(20, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(279, 21)
        Label6.TabIndex = 12
        Label6.Text = "EJERCICIO 1  Clasificador de productos"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F)
        Label7.ForeColor = Color.Blue
        Label7.Location = New Point(20, 188)
        Label7.Name = "Label7"
        Label7.Size = New Size(317, 21)
        Label7.TabIndex = 13
        Label7.Text = "EJERCICIO 2  Generador de ticket de compra"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label8.Location = New Point(20, 230)
        Label8.Name = "Label8"
        Label8.Size = New Size(84, 21)
        Label8.TabIndex = 14
        Label8.Text = "Producto:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label9.Location = New Point(20, 262)
        Label9.Name = "Label9"
        Label9.Size = New Size(62, 21)
        Label9.TabIndex = 15
        Label9.Text = "Precio:"
        ' 
        ' txtPrecioProducto
        ' 
        txtPrecioProducto.Location = New Point(124, 260)
        txtPrecioProducto.Name = "txtPrecioProducto"
        txtPrecioProducto.Size = New Size(100, 23)
        txtPrecioProducto.TabIndex = 17
        ' 
        ' txtNombreProducto
        ' 
        txtNombreProducto.Location = New Point(124, 231)
        txtNombreProducto.Name = "txtNombreProducto"
        txtNombreProducto.Size = New Size(100, 23)
        txtNombreProducto.TabIndex = 16
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label10.Location = New Point(20, 296)
        Label10.Name = "Label10"
        Label10.Size = New Size(153, 21)
        Label10.TabIndex = 18
        Label10.Text = "Lista de productos:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label13.Location = New Point(18, 429)
        Label13.Name = "Label13"
        Label13.Size = New Size(52, 21)
        Label13.TabIndex = 23
        Label13.Text = "Total:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label14.Location = New Point(19, 408)
        Label14.Name = "Label14"
        Label14.Size = New Size(40, 21)
        Label14.TabIndex = 22
        Label14.Text = "IVA:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label15.Location = New Point(19, 387)
        Label15.Name = "Label15"
        Label15.Size = New Size(79, 21)
        Label15.TabIndex = 21
        Label15.Text = "Subtotal:"
        ' 
        ' btnGenerarTicket
        ' 
        btnGenerarTicket.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        btnGenerarTicket.Font = New Font("Segoe UI", 12F)
        btnGenerarTicket.Location = New Point(248, 262)
        btnGenerarTicket.Name = "btnGenerarTicket"
        btnGenerarTicket.Size = New Size(135, 37)
        btnGenerarTicket.TabIndex = 25
        btnGenerarTicket.Text = "Generar ticket"
        btnGenerarTicket.UseVisualStyleBackColor = False
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnAgregar.Font = New Font("Segoe UI", 12F)
        btnAgregar.Location = New Point(248, 223)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(135, 33)
        btnAgregar.TabIndex = 24
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' lstProductos
        ' 
        lstProductos.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lstProductos.FormattingEnabled = True
        lstProductos.ItemHeight = 15
        lstProductos.Location = New Point(21, 320)
        lstProductos.Name = "lstProductos"
        lstProductos.Size = New Size(362, 64)
        lstProductos.TabIndex = 26
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 12F)
        lblTotal.Location = New Point(124, 430)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(19, 21)
        lblTotal.TabIndex = 29
        lblTotal.Text = "$"
        ' 
        ' lblIvaTicket
        ' 
        lblIvaTicket.AutoSize = True
        lblIvaTicket.Font = New Font("Segoe UI", 12F)
        lblIvaTicket.Location = New Point(124, 408)
        lblIvaTicket.Name = "lblIvaTicket"
        lblIvaTicket.Size = New Size(19, 21)
        lblIvaTicket.TabIndex = 28
        lblIvaTicket.Text = "$"
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.AutoSize = True
        lblSubtotal.Font = New Font("Segoe UI", 12F)
        lblSubtotal.Location = New Point(124, 387)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(19, 21)
        lblSubtotal.TabIndex = 27
        lblSubtotal.Text = "$"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F)
        Label11.ForeColor = Color.Red
        Label11.Location = New Point(420, 9)
        Label11.Name = "Label11"
        Label11.Size = New Size(320, 21)
        Label11.TabIndex = 30
        Label11.Text = "EJERCICIO 3  Buscador con ciclo y depurador"
        ' 
        ' txtBusqueda
        ' 
        txtBusqueda.Location = New Point(514, 63)
        txtBusqueda.Name = "txtBusqueda"
        txtBusqueda.Size = New Size(100, 23)
        txtBusqueda.TabIndex = 31
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnBuscar.Font = New Font("Segoe UI", 12F)
        btnBuscar.Location = New Point(649, 59)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(91, 33)
        btnBuscar.TabIndex = 32
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Font = New Font("Segoe UI", 12F)
        lblResultado.Location = New Point(514, 100)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(79, 21)
        lblResultado.TabIndex = 33
        lblResultado.Text = "Resultado"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(760, 533)
        Controls.Add(lblResultado)
        Controls.Add(btnBuscar)
        Controls.Add(txtBusqueda)
        Controls.Add(Label11)
        Controls.Add(lblTotal)
        Controls.Add(lblIvaTicket)
        Controls.Add(lblSubtotal)
        Controls.Add(lstProductos)
        Controls.Add(btnGenerarTicket)
        Controls.Add(btnAgregar)
        Controls.Add(Label13)
        Controls.Add(Label14)
        Controls.Add(Label15)
        Controls.Add(Label10)
        Controls.Add(txtPrecioProducto)
        Controls.Add(txtNombreProducto)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnLimpiar)
        Controls.Add(btnClasificar)
        Controls.Add(lblPrecioFinal)
        Controls.Add(lblIva)
        Controls.Add(lblCategoria)
        Controls.Add(txtPrecio)
        Controls.Add(txtNombre)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblCategoria As Label
    Friend WithEvents lblIva As Label
    Friend WithEvents lblPrecioFinal As Label
    Friend WithEvents btnClasificar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnGenerarTicket As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lstProductos As ListBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblIvaTicket As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents txtPrecioProducto As TextBox
    Friend WithEvents btnBuscar As Button

End Class
