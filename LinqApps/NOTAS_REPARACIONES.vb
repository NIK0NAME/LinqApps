'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Namespace LinqApps

    Partial Public Class NOTAS_REPARACIONES
        Public Property CodigodeNota As Integer
        Public Property DNI As String
        Public Property FechadeReparacion As Nullable(Of Date)
        Public Property Descuento As Nullable(Of Integer)
        Public Property Observaciones As String
    
        Public Overridable Property CLIENTES As CLIENTES
        Public Overridable Property DETALLES_NOTAS As ICollection(Of DETALLES_NOTAS) = New HashSet(Of DETALLES_NOTAS)
    
    End Class

End Namespace