<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCiudadanos
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
<<<<<<< HEAD
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
=======
        Me.dgvTotal = New System.Windows.Forms.DataGridView()
>>>>>>> d86ba23953df3a7ea8481e12010ac02d102cc59b
        Me.dgvNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvRegion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvMunicipio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
<<<<<<< HEAD
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvNombre, Me.dgvApellido, Me.dgvRegion, Me.dgvDepto, Me.dgvMunicipio})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 210)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1145, 261)
        Me.DataGridView1.TabIndex = 0
=======
        Me.btnCerrar = New System.Windows.Forms.Button()
        CType(Me.dgvTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTotal
        '
        Me.dgvTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTotal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvNombre, Me.dgvApellido, Me.dgvRegion, Me.dgvDepto, Me.dgvMunicipio})
        Me.dgvTotal.Location = New System.Drawing.Point(12, 210)
        Me.dgvTotal.Name = "dgvTotal"
        Me.dgvTotal.Size = New System.Drawing.Size(1145, 261)
        Me.dgvTotal.TabIndex = 0
>>>>>>> d86ba23953df3a7ea8481e12010ac02d102cc59b
        '
        'dgvNombre
        '
        Me.dgvNombre.HeaderText = "NOMBRE"
        Me.dgvNombre.Name = "dgvNombre"
        Me.dgvNombre.Width = 200
        '
        'dgvApellido
        '
        Me.dgvApellido.HeaderText = "APELLIDO"
        Me.dgvApellido.Name = "dgvApellido"
        Me.dgvApellido.Width = 200
        '
        'dgvRegion
        '
        Me.dgvRegion.HeaderText = "REGION"
        Me.dgvRegion.Name = "dgvRegion"
        Me.dgvRegion.Width = 200
        '
        'dgvDepto
        '
        Me.dgvDepto.HeaderText = "DEPARTAMENTO"
        Me.dgvDepto.Name = "dgvDepto"
        Me.dgvDepto.Width = 200
        '
        'dgvMunicipio
        '
        Me.dgvMunicipio.HeaderText = "MUNICIPIO"
        Me.dgvMunicipio.Name = "dgvMunicipio"
        Me.dgvMunicipio.Width = 300
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "INBRESE EL ID:"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(185, 72)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(499, 72)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(183, 20)
        Me.txtNombre.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(350, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "INGRESE EL NOMBRE:"
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(890, 72)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(183, 20)
        Me.txtMunicipio.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(726, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "INGRESE EL MUNICIPIO"
        '
        'btnAgregar
        '
<<<<<<< HEAD
        Me.btnAgregar.Location = New System.Drawing.Point(68, 155)
=======
        Me.btnAgregar.Location = New System.Drawing.Point(12, 155)
>>>>>>> d86ba23953df3a7ea8481e12010ac02d102cc59b
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(196, 23)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
<<<<<<< HEAD
        Me.btnEliminar.Location = New System.Drawing.Point(311, 155)
=======
        Me.btnEliminar.Location = New System.Drawing.Point(227, 155)
>>>>>>> d86ba23953df3a7ea8481e12010ac02d102cc59b
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(176, 23)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
<<<<<<< HEAD
        Me.btnModificar.Location = New System.Drawing.Point(528, 155)
=======
        Me.btnModificar.Location = New System.Drawing.Point(428, 155)
>>>>>>> d86ba23953df3a7ea8481e12010ac02d102cc59b
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(176, 23)
        Me.btnModificar.TabIndex = 9
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
<<<<<<< HEAD
        Me.btnMostrar.Location = New System.Drawing.Point(746, 155)
=======
        Me.btnMostrar.Location = New System.Drawing.Point(634, 155)
>>>>>>> d86ba23953df3a7ea8481e12010ac02d102cc59b
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(176, 23)
        Me.btnMostrar.TabIndex = 10
        Me.btnMostrar.Text = "MOSTRAR"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
<<<<<<< HEAD
        Me.btnImprimir.Location = New System.Drawing.Point(939, 155)
=======
        Me.btnImprimir.Location = New System.Drawing.Point(816, 155)
>>>>>>> d86ba23953df3a7ea8481e12010ac02d102cc59b
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(176, 23)
        Me.btnImprimir.TabIndex = 11
        Me.btnImprimir.Text = "IMPRIMIR"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
<<<<<<< HEAD
=======
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(1027, 155)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(130, 23)
        Me.btnCerrar.TabIndex = 12
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
>>>>>>> d86ba23953df3a7ea8481e12010ac02d102cc59b
        'frmCiudadanos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1169, 512)
<<<<<<< HEAD
=======
        Me.Controls.Add(Me.btnCerrar)
>>>>>>> d86ba23953df3a7ea8481e12010ac02d102cc59b
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtMunicipio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label1)
<<<<<<< HEAD
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmCiudadanos"
        Me.Text = "frmCiudadanos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
=======
        Me.Controls.Add(Me.dgvTotal)
        Me.Name = "frmCiudadanos"
        Me.Text = "FORMULARIO DE LOS CIUDADANOS"
        CType(Me.dgvTotal, System.ComponentModel.ISupportInitialize).EndInit()
>>>>>>> d86ba23953df3a7ea8481e12010ac02d102cc59b
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

<<<<<<< HEAD
    Friend WithEvents DataGridView1 As DataGridView
=======
    Friend WithEvents dgvTotal As DataGridView
>>>>>>> d86ba23953df3a7ea8481e12010ac02d102cc59b
    Friend WithEvents Label1 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvNombre As DataGridViewTextBoxColumn
    Friend WithEvents dgvApellido As DataGridViewTextBoxColumn
    Friend WithEvents dgvRegion As DataGridViewTextBoxColumn
    Friend WithEvents dgvDepto As DataGridViewTextBoxColumn
    Friend WithEvents dgvMunicipio As DataGridViewTextBoxColumn
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents btnImprimir As Button
<<<<<<< HEAD
=======
    Friend WithEvents btnCerrar As Button
>>>>>>> d86ba23953df3a7ea8481e12010ac02d102cc59b
End Class
