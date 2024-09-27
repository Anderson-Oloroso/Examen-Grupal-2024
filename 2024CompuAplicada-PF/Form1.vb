Public Class frmmenuprincipal
    Private Sub EncargadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncargadoToolStripMenuItem.Click
        mdiEncargado.Show()
    End Sub

    Private Sub OperadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperadorToolStripMenuItem.Click
        mdiOperador.Show()
    End Sub

    Private Sub AdministradorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AdministradorToolStripMenuItem1.Click
        mdiAdministrador.Show()
    End Sub
End Class
