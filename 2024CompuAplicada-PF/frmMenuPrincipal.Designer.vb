<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<<<<<<< HEAD:2024CompuAplicada-PF/Form1.Designer.vb
Partial Class frmmenuprincipal
=======
Partial Class frmMenuPrincipal
>>>>>>> 0a739eeee4209a0a94e104771d665aa3da5e2af6:2024CompuAplicada-PF/frmMenuPrincipal.Designer.vb
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
<<<<<<< HEAD:2024CompuAplicada-PF/Form1.Designer.vb
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.msusuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministradorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncargadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msusuario = New System.Windows.Forms.ToolStripContainer()
        Me.MenuStrip1.SuspendLayout()
        Me.msusuario.ContentPanel.SuspendLayout()
        Me.msusuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.ForeColor = System.Drawing.Color.Red
        Me.txtnombre.Location = New System.Drawing.Point(141, 32)
        Me.txtnombre.Multiline = True
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(127, 36)
        Me.txtnombre.TabIndex = 0
        Me.txtnombre.Tag = " "
        Me.txtnombre.Text = "Usuarios"
        Me.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LawnGreen
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msusuarios})
        Me.MenuStrip1.Location = New System.Drawing.Point(27, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(72, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'msusuarios
        '
        Me.msusuarios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministradorToolStripMenuItem1, Me.EncargadoToolStripMenuItem, Me.OperadorToolStripMenuItem})
        Me.msusuarios.Name = "msusuarios"
        Me.msusuarios.Size = New System.Drawing.Size(64, 20)
        Me.msusuarios.Text = "Usuarios"
        '
        'AdministradorToolStripMenuItem1
        '
        Me.AdministradorToolStripMenuItem1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.AdministradorToolStripMenuItem1.Name = "AdministradorToolStripMenuItem1"
        Me.AdministradorToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.AdministradorToolStripMenuItem1.Text = "Administrador"
        '
        'EncargadoToolStripMenuItem
        '
        Me.EncargadoToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue
        Me.EncargadoToolStripMenuItem.Name = "EncargadoToolStripMenuItem"
        Me.EncargadoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EncargadoToolStripMenuItem.Text = "Encargado"
        '
        'OperadorToolStripMenuItem
        '
        Me.OperadorToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise
        Me.OperadorToolStripMenuItem.Name = "OperadorToolStripMenuItem"
        Me.OperadorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OperadorToolStripMenuItem.Text = "Operador"
        '
        'msusuario
        '
        '
        'msusuario.ContentPanel
        '
        Me.msusuario.ContentPanel.BackColor = System.Drawing.Color.LightBlue
        Me.msusuario.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.msusuario.ContentPanel.Controls.Add(Me.MenuStrip1)
        Me.msusuario.ContentPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msusuario.ContentPanel.ForeColor = System.Drawing.Color.White
        Me.msusuario.ContentPanel.Padding = New System.Windows.Forms.Padding(3)
        Me.msusuario.ContentPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.msusuario.ContentPanel.Size = New System.Drawing.Size(235, 175)
        Me.msusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msusuario.Location = New System.Drawing.Point(81, 95)
        Me.msusuario.Name = "msusuario"
        Me.msusuario.Size = New System.Drawing.Size(235, 200)
        Me.msusuario.TabIndex = 2
        Me.msusuario.Text = "MENU USUARIO"
        '
        'msusuario.TopToolStripPanel
        '
        Me.msusuario.TopToolStripPanel.BackColor = System.Drawing.Color.Cyan
        '
        'frmmenuprincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 369)
        Me.Controls.Add(Me.msusuario)
        Me.Controls.Add(Me.txtnombre)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmmenuprincipal"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.Text = "Menú Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.msusuario.ContentPanel.ResumeLayout(False)
        Me.msusuario.ContentPanel.PerformLayout()
        Me.msusuario.ResumeLayout(False)
        Me.msusuario.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
=======
        Me.SuspendLayout()
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Name = "frmMenuPrincipal"
        Me.Text = "Menú"
        Me.ResumeLayout(False)
>>>>>>> 0a739eeee4209a0a94e104771d665aa3da5e2af6:2024CompuAplicada-PF/frmMenuPrincipal.Designer.vb

    End Sub

    Friend WithEvents txtnombre As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents msusuarios As ToolStripMenuItem
    Friend WithEvents msusuario As ToolStripContainer
    Friend WithEvents EncargadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OperadorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministradorToolStripMenuItem1 As ToolStripMenuItem
End Class
