<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gridClientes = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gridOpelOno = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gridCliDonos = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gridCliPoblacion = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPoblacion = New System.Windows.Forms.TextBox()
        Me.btnSearchPoblacion = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.gridClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridOpelOno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCliDonos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCliPoblacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.btnSearchPoblacion)
        Me.Panel1.Controls.Add(Me.txtPoblacion)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.gridCliPoblacion)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.gridCliDonos)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.gridOpelOno)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.gridClientes)
        Me.Panel1.Location = New System.Drawing.Point(30, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 20, 0, 20)
        Me.Panel1.Size = New System.Drawing.Size(578, 397)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "1. Clientes OPEL blanco"
        '
        'gridClientes
        '
        Me.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridClientes.Location = New System.Drawing.Point(12, 33)
        Me.gridClientes.Name = "gridClientes"
        Me.gridClientes.Size = New System.Drawing.Size(532, 77)
        Me.gridClientes.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "2. Clientes OPEL o No"
        '
        'gridOpelOno
        '
        Me.gridOpelOno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridOpelOno.Location = New System.Drawing.Point(12, 139)
        Me.gridOpelOno.Name = "gridOpelOno"
        Me.gridOpelOno.Size = New System.Drawing.Size(532, 136)
        Me.gridOpelOno.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 287)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "3. Clientes de Donosti"
        '
        'gridCliDonos
        '
        Me.gridCliDonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridCliDonos.Location = New System.Drawing.Point(12, 303)
        Me.gridCliDonos.Name = "gridCliDonos"
        Me.gridCliDonos.Size = New System.Drawing.Size(532, 87)
        Me.gridCliDonos.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 404)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "4. Clientes por poblacion"
        '
        'gridCliPoblacion
        '
        Me.gridCliPoblacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridCliPoblacion.Location = New System.Drawing.Point(13, 453)
        Me.gridCliPoblacion.Name = "gridCliPoblacion"
        Me.gridCliPoblacion.Size = New System.Drawing.Size(532, 132)
        Me.gridCliPoblacion.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 430)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Poblacion"
        '
        'txtPoblacion
        '
        Me.txtPoblacion.AcceptsTab = True
        Me.txtPoblacion.Location = New System.Drawing.Point(73, 427)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Size = New System.Drawing.Size(138, 20)
        Me.txtPoblacion.TabIndex = 11
        '
        'btnSearchPoblacion
        '
        Me.btnSearchPoblacion.Location = New System.Drawing.Point(217, 425)
        Me.btnSearchPoblacion.Name = "btnSearchPoblacion"
        Me.btnSearchPoblacion.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchPoblacion.TabIndex = 12
        Me.btnSearchPoblacion.Text = "Buscar"
        Me.btnSearchPoblacion.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(638, 529)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Linq Apps"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.gridClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridOpelOno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCliDonos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCliPoblacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents gridClientes As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents gridOpelOno As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents gridCliDonos As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents gridCliPoblacion As DataGridView
    Friend WithEvents btnSearchPoblacion As Button
    Friend WithEvents txtPoblacion As TextBox
    Friend WithEvents Label5 As Label
End Class
