<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFinidsfs = New System.Windows.Forms.Label()
        Me.txtCodViajero = New System.Windows.Forms.TextBox()
        Me.txtIFini = New System.Windows.Forms.TextBox()
        Me.txtFfin = New System.Windows.Forms.TextBox()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.listViajes = New System.Windows.Forms.ListView()
        Me.CodViaje = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Destino = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.disponible = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FechaSalida = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FechaRegreso = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(95, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code. Viajero"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(388, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha fin"
        '
        'txtFinidsfs
        '
        Me.txtFinidsfs.AutoSize = True
        Me.txtFinidsfs.Location = New System.Drawing.Point(241, 85)
        Me.txtFinidsfs.Name = "txtFinidsfs"
        Me.txtFinidsfs.Size = New System.Drawing.Size(64, 13)
        Me.txtFinidsfs.TabIndex = 2
        Me.txtFinidsfs.Text = "Fecha inicio"
        '
        'txtCodViajero
        '
        Me.txtCodViajero.Location = New System.Drawing.Point(98, 102)
        Me.txtCodViajero.Name = "txtCodViajero"
        Me.txtCodViajero.Size = New System.Drawing.Size(100, 20)
        Me.txtCodViajero.TabIndex = 3
        '
        'txtIFini
        '
        Me.txtIFini.Location = New System.Drawing.Point(244, 102)
        Me.txtIFini.Name = "txtIFini"
        Me.txtIFini.Size = New System.Drawing.Size(100, 20)
        Me.txtIFini.TabIndex = 4
        '
        'txtFfin
        '
        Me.txtFfin.Location = New System.Drawing.Point(391, 102)
        Me.txtFfin.Name = "txtFfin"
        Me.txtFfin.Size = New System.Drawing.Size(100, 20)
        Me.txtFfin.TabIndex = 5
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(630, 100)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.btnMostrar.TabIndex = 7
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'listViajes
        '
        Me.listViajes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CodViaje, Me.Destino, Me.disponible, Me.FechaSalida, Me.FechaRegreso})
        Me.listViajes.HideSelection = False
        Me.listViajes.Location = New System.Drawing.Point(98, 129)
        Me.listViajes.Name = "listViajes"
        Me.listViajes.Size = New System.Drawing.Size(607, 172)
        Me.listViajes.TabIndex = 8
        Me.listViajes.UseCompatibleStateImageBehavior = False
        Me.listViajes.View = System.Windows.Forms.View.Details
        '
        'CodViaje
        '
        Me.CodViaje.Text = "Codigo"
        '
        'Destino
        '
        Me.Destino.Text = "Destino"
        Me.Destino.Width = 181
        '
        'disponible
        '
        Me.disponible.Text = "Disponible"
        Me.disponible.Width = 77
        '
        'FechaSalida
        '
        Me.FechaSalida.Text = "Fecha salida"
        Me.FechaSalida.Width = 135
        '
        'FechaRegreso
        '
        Me.FechaRegreso.Text = "Fecha regreso"
        Me.FechaRegreso.Width = 147
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.listViajes)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.txtFfin)
        Me.Controls.Add(Me.txtIFini)
        Me.Controls.Add(Me.txtCodViajero)
        Me.Controls.Add(Me.txtFinidsfs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFinidsfs As Label
    Friend WithEvents txtCodViajero As TextBox
    Friend WithEvents txtIFini As TextBox
    Friend WithEvents txtFfin As TextBox
    Friend WithEvents btnMostrar As Button
    Friend WithEvents listViajes As ListView
    Friend WithEvents CodViaje As ColumnHeader
    Friend WithEvents Destino As ColumnHeader
    Friend WithEvents disponible As ColumnHeader
    Friend WithEvents FechaSalida As ColumnHeader
    Friend WithEvents FechaRegreso As ColumnHeader
End Class
