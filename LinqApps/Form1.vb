Imports System.Data.Linq.SqlClient
Imports LinqApps.LinqApps

Public Class Form1
    Dim m As New DataEntities

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        resizeApp()
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

        '5
        Dim notasReparacion = From rep In m.NOTAS_REPARACIONES
                              Where Month(rep.FechadeReparacion) = 3
                              Select rep.CodigodeNota, rep.DNI, rep.FechadeReparacion

        grid5.DataSource = notasReparacion.ToList()

        '6
        Dim notRep = From rep In m.NOTAS_REPARACIONES
                     Where Month(rep.FechadeReparacion) > 0 And Month(rep.FechadeReparacion) < 4 And Year(rep.FechadeReparacion) = 2003
                     Select rep.CodigodeNota, rep.DNI, rep.FechadeReparacion

        grid6.DataSource = notRep.ToList()

        '8
        Dim totalNotasGrouped = From notas In m.DETALLES_NOTAS
                                Group By notas.CodigodeNota Into Sum(notas.Importe)

        grid8.DataSource = totalNotasGrouped.ToList()

        '9
        Dim vehiculosCliente = From vehiculos In m.VEHICULOS
                               Group By vehiculos.DNI Into num = Count()


        grid9.DataSource = vehiculosCliente.ToList()

        '11
        Dim result = From cli In m.CLIENTES
                     Join notas In m.NOTAS_REPARACIONES On cli.DNI Equals notas.DNI
                     Join detalles In m.DETALLES_NOTAS On notas.CodigodeNota Equals detalles.CodigodeNota
                     Group By notas.CodigodeNota Into total = Sum(detalles.Importe)
                     Select 

        grid11.DataSource = result.ToList()

    End Sub

    Public Sub resizeApp()
        Dim w As Integer = Size().Width
        Dim h As Integer = Size().Height
        Dim panelMargin As Integer = 10
        lblSize.Text = w.ToString + " x " + h.ToString
        w = w - (panelMargin * 2) - 15
        h = h - (panelMargin * 2) - 35
        mainPanel.Size = New Size(w, h)
        mainPanel.Location = New Point(panelMargin, panelMargin)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles mainPanel.Paint

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

    Public Sub ejercicio6()
        '7
        Dim notasRango = From rep In m.NOTAS_REPARACIONES
                         Where rep.FechadeReparacion > dateInicio.Value And rep.FechadeReparacion < dateFin.Value
                         Select rep.CodigodeNota, rep.DNI, rep.FechadeReparacion


        grid7.DataSource = notasRango.ToList()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        resizeApp()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub DateInicio_ValueChanged(sender As Object, e As EventArgs) Handles dateInicio.ValueChanged
        ejercicio6()
    End Sub

    Private Sub DateFin_ValueChanged(sender As Object, e As EventArgs) Handles dateFin.ValueChanged
        ejercicio6()
    End Sub

    Private Sub TxtNom10_TextChanged(sender As Object, e As EventArgs) Handles txtNom10.TextChanged
        getClientRep()
    End Sub

    Public Sub getClientRep()
        '10
        Dim nombre As String = txtNom10.Text.ToString()
        Dim repCli = From rep In m.CLIENTES
                     Where rep.Nombre = nombre
                     Group rep By Key = rep.Nombre Into Group
                     Select nombr = Key, veces = Group.Count()

        grid10.DataSource = repCli.ToList()
    End Sub
End Class
