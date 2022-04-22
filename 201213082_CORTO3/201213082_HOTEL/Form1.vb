Public Class Form1
    Private Sub CálcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CálcularToolStripMenuItem.Click
        If index < 6 Then

            Nombre(index) = Txtnombre.Text
            Nit(index) = Txtnit.Text
            Impuesto(index) = Txtimpuesto.Text
            Dias(index) = Txtdias.Text
            Habitación = Cbxtipo.SelectedItem
            Tipopago = Cbxpago.SelectedItem

            If Cbxtipo.SelectedItem = "Sencilla" Then
                Pago(index) = sencialla
            ElseIf Cbxtipo.SelectedItem = "Doble" Then
                Pago(index) = doble
            ElseIf Cbxtipo.SelectedItem = "Cabaña" Then
                Pago(index) = cabaña
            End If

            If Cbxpago.SelectedItem = "Efectivo" Then
                Descuento(index) = Pago(index) * efectivo
            ElseIf Cbxtipo.SelectedItem = "Tarjeta de crédito/débito" Then
                Recargo(index) = Pago(index) * tarjeta

            End If

            Pagototal(index) = Pago(index) + Recargo(index) - Descuento(index)

            DataGridView1.Rows.Add(Nombre(index), Nit(index), Dias(index), Impuesto(index), Habitación(index), Tipopago(index), Pago(index), Descuento(index), Recargo(index), Pagototal(index))

            index = 0 + 1
        End If
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click

    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar_Datos()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiar_vectores()
    End Sub
End Class
