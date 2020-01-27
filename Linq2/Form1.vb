Imports Linq2.Linq2

Public Class Form1
    Dim modelo As New DAM_nikolayzabaleta_DEVEntities()
    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim codigoViajero = txtCodViajero.Text.ToString()

        listViajes.Items.Clear()

        Dim res1 = (From viajes In modelo.Viajes
                    Join reservas In modelo.Reservas On viajes.CodViaje Equals reservas.CodViaje
                    Where reservas.CodViajero = codigoViajero
                    Group By r = reservas, v = viajes Into grp = Group
                    Select v.CodViaje, v.Destino, v.PlazasMax - Int32.Parse(grp.Count().ToString()), v.FechaSalida, v.FechaRegreso)


        Dim res2 = modelo.Viajes.Select(Function(x) x)

        For Each it In res1.ToList()
            Dim elem As New ListViewItem(it.CodViaje)
            elem.SubItems.Add(it.Destino)
            elem.SubItems.Add(it.PlazasMax)
            elem.SubItems.Add(it.FechaSalida)
            elem.SubItems.Add(it.FechaRegreso)
            listViajes.Items.Add(elem)
        Next

    End Sub
End Class
