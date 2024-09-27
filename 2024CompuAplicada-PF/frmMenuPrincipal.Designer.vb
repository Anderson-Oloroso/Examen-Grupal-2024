<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuPrincipal
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
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AAdministradorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncargadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msusario = New System.Windows.Forms.ToolStripContainer()
        Me.MenuStrip1.SuspendLayout()
        Me.msusario.TopToolStripPanel.SuspendLayout()
        Me.msusario.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(114, 61)
        Me.txtnombre.Multiline = True
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(119, 37)
        Me.txtnombre.TabIndex = 0
        Me.txtnombre.Text = "USUARIOS"
        Me.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SpringGreen
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(184, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AAdministradorToolStripMenuItem, Me.EncargadoToolStripMenuItem, Me.OperadorToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'AAdministradorToolStripMenuItem
        '
        Me.AAdministradorToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.AAdministradorToolStripMenuItem.Name = "AAdministradorToolStripMenuItem"
        Me.AAdministradorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AAdministradorToolStripMenuItem.Text = "Administrador"
        '
        'EncargadoToolStripMenuItem
        '
        Me.EncargadoToolStripMenuItem.BackColor = System.Drawing.Color.DodgerBlue
        Me.EncargadoToolStripMenuItem.Name = "EncargadoToolStripMenuItem"
        Me.EncargadoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EncargadoToolStripMenuItem.Text = "Encargado"
        '
        'OperadorToolStripMenuItem
        '
        Me.OperadorToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.OperadorToolStripMenuItem.Name = "OperadorToolStripMenuItem"
        Me.OperadorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OperadorToolStripMenuItem.Text = "Operador"
        '
        'msusario
        '
        '
        'msusario.BottomToolStripPanel
        '
        Me.msusario.BottomToolStripPanel.BackColor = System.Drawing.Color.SteelBlue
        '
        'msusario.ContentPanel
        '
        Me.msusario.ContentPanel.BackColor = System.Drawing.Color.LightBlue
        Me.msusario.ContentPanel.Size = New System.Drawing.Size(184, 134)
        Me.msusario.Location = New System.Drawing.Point(81, 141)
        Me.msusario.Margin = New System.Windows.Forms.Padding(5)
        Me.msusario.Name = "msusario"
        Me.msusario.Size = New System.Drawing.Size(184, 158)
        Me.msusario.TabIndex = 2
        Me.msusario.Text = "ToolStripContainer1"
        '
        'msusario.TopToolStripPanel
        '
        Me.msusario.TopToolStripPanel.Controls.Add(Me.MenuStrip1)
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 375)
        Me.Controls.Add(Me.msusario)
        Me.Controls.Add(Me.txtnombre)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenuPrincipal"
        Me.Text = "Menú"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.msusario.TopToolStripPanel.ResumeLayout(False)
        Me.msusario.TopToolStripPanel.PerformLayout()
        Me.msusario.ResumeLayout(False)
        Me.msusario.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnombre As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents msusario As ToolStripContainer
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AAdministradorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncargadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OperadorToolStripMenuItem As ToolStripMenuItem
End Class
