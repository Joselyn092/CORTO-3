Module Module1
    Public index = 0


    Public Nombre(7) As String
    Public Nit(7) As Double
    Public Dias(7) As Double
    Public Impuesto(7) As Double
    Public Habitación(7) As Double
    Public Tipopago(7) As Double
    Public Pago(7) As Double
    Public Descuento(7) As Double
    Public Recargo(7) As Double
    Public Pagototal(7) As Double



    Public Const sencialla = 250
    Public Const doble = 400
    Public Const cabaña = 650
    Public Const efectivo = 0.15
    Public Const tarjeta = 0.03

    Sub Eliminar_Datos()
        Form1.Txtnombre.Text = 0
        Form1.Txtnit.Text = 0
        Form1.Txtimpuesto.Text = 0
        Form1.Txtdias.Text = 0
        Form1.Cbxtipo.SelectedIndex = False
        Form1.Cbxpago.SelectedIndex = False


    End Sub


    Sub limpiar_vectores()
        Form1.DataGridView1.Rows.Clear()

        index = 0

    End Sub
End Module
