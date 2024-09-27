<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmencar
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
        Me.cbodepto = New System.Windows.Forms.ComboBox()
        Me.lbldepto = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dgvcodmuni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gdvnombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbodepto
        '
        Me.cbodepto.FormattingEnabled = True
        Me.cbodepto.Location = New System.Drawing.Point(57, -31)
        Me.cbodepto.Name = "cbodepto"
        Me.cbodepto.Size = New System.Drawing.Size(121, 21)
        Me.cbodepto.TabIndex = 5
        '
        'lbldepto
        '
        Me.lbldepto.AutoSize = True
        Me.lbldepto.Location = New System.Drawing.Point(-124, -28)
        Me.lbldepto.Name = "lbldepto"
        Me.lbldepto.Size = New System.Drawing.Size(123, 13)
        Me.lbldepto.TabIndex = 4
        Me.lbldepto.Text = "Ingrese el Departamento"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcodmuni, Me.gdvnombre})
        Me.DataGridView1.Location = New System.Drawing.Point(25, 137)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(657, 268)
        Me.DataGridView1.TabIndex = 3
        '
        'dgvcodmuni
        '
        Me.dgvcodmuni.HeaderText = "Cod_Municipio"
        Me.dgvcodmuni.Name = "dgvcodmuni"
        '
        'gdvnombre
        '
        Me.gdvnombre.HeaderText = "Nombre"
        Me.gdvnombre.Name = "gdvnombre"
        Me.gdvnombre.Width = 300
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(312, 66)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(131, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Ingrese el Departamento"
        '
        'frmencar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 438)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbodepto)
        Me.Controls.Add(Me.lbldepto)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmencar"
        Me.Text = "Encargado"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbodepto As ComboBox
    Friend WithEvents lbldepto As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dgvcodmuni As DataGridViewTextBoxColumn
    Friend WithEvents gdvnombre As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
End Class
