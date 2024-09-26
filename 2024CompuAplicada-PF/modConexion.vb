Module modConexion
    Public conexion As New OleDb.OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=CIUDADANOS.accdb")

    Public Sub conect()
        Try
            conexion.Open()
        Catch ex As Exception
            MsgBox("Error en la conexión" & ex.Message, vbOKOnly + vbCritical, "Error en la conexión")
        End Try
    End Sub

    Public Sub desconect()
        Try
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error en la desconexión" & ex.Message, vbOKOnly + vbCritical, "Error en la desconexión")
        End Try
    End Sub

End Module
