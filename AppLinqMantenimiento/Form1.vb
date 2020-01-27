Imports System.Data.Linq.SqlClient
Imports AppLinqMantenimiento.AppLinqMantenimiento

Public Class Form1
    Dim db As New ContextoDb

    Private Sub BtnEquipos1_Click(sender As Object, e As EventArgs) Handles btnEquipos1.Click
        Dim res = From equip In db.Equipos
                  Where equip.Memoria <= 60
                  Select New With {equip.CodInstalacion, equip.Procesador, equip.Memoria}

        gridRes.DataSource = res.ToList()
    End Sub
End Class
