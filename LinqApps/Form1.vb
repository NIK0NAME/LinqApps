Imports LinqApps.LinqApps

Public Class Form1
    Dim m As New DataEntities
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        '1
        Dim clientesOpel = From cli In m.CLIENTES
                           Join vhi In m.VEHICULOS On
                               cli.DNI Equals vhi.DNI
                           Where vhi.Marca = "OPEL" And vhi.Color = "blanco"
                           Select cli.Nombre, cli.DNI, vhi.Marca, vhi.Color

        gridClientes.DataSource = clientesOpel.ToList()

        '2
        Dim clientesOpeloNo = From cli In m.CLIENTES
                              Join vhi In m.VEHICULOS On
                               cli.DNI Equals vhi.DNI
                              Where vhi.Marca = "OPEL" Or (vhi.Color = "blanco" Or vhi.Color = "negro")
                              Select cli.Nombre, cli.DNI, vhi.Marca, vhi.Color

        gridOpelOno.DataSource = clientesOpeloNo.ToList()

        '3
        Dim clientesDonos = From cli In m.CLIENTES
                            Where cli.Poblacion = "Donostia"
                            Select cli.Nombre, cli.Poblacion

        gridCliDonos.DataSource = clientesDonos.ToList()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GridClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridClientes.CellContentClick

    End Sub

    Private Sub BtnSearchPoblacion_Click(sender As Object, e As EventArgs) Handles btnSearchPoblacion.Click
        Dim pob As String = txtPoblacion.Text.ToString
        '4
        Dim clientesPorPob = From cli In m.CLIENTES
                             Where cli.Poblacion = pob


        gridCliPoblacion.DataSource = clientesPorPob.ToList()
    End Sub
End Class
