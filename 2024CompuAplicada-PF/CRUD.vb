Public Class CRUD
    Dim sql, descrip, nombreC, aClave, nClave, r, nombre As String
    Dim cod As Integer
    Dim o As Integer
    Private Sub limpiar()
        txtNombreC.Clear()
        txtDescripcion.Clear()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminar()
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        mostrar()
    End Sub

    Private Sub mostrar()
        Dim mostr As Integer
        conect()
        If txtAclave.Text <> "" Then
            mostr = txtAclave.Text
        Else
            MsgBox("Es obligatorio rellenar este campo con el tipo de datos corrrectos", vbOKOnly + vbExclamation, "Mostrar")
            limpiar()
        End If

        sql = "SELECT* FROM TIPOCUENTA WHERE cod_tipocuenta=" & mostr

        ejecutar.CommandType = CommandType.Text
        ejecutar.Connection = conexion
        ejecutar.CommandText = sql
        Try
            ejecutar.ExecuteNonQuery()
            buscar = ejecutar.ExecuteReader
            While buscar.Read
                txtNombreC = buscar!nombre
                txtDescripcion = buscar!descripcion
            End While

        Catch ex As Exception
            MsgBox("Error al mostar: " & ex.Message, vbOKOnly + vbCritical, "Mostrar")
        End Try

        desconect()
    End Sub
    Private Sub modificar()
        conect()
        If txtDescripcion.Text <> "" And txtNombreC.Text <> "" And txtNclave.Text <> "" And txtAclave.Text <> "" Then
            nombreC = txtNombreC.Text
            descrip = txtDescripcion.Text
            nClave = txtNclave.Text
            aClave = txtAclave.Text
        Else
            MsgBox("Es obligatorio rellenar todos los campos con el tipo correcto de datos", vbOKOnly + vbExclamation, "Modificar datos")
            limpiar()
        End If
        sql = "UPDATE TIPOCUENTA  SET cod_tipocuenta=" & nClave & ",nombre='" & nombreC & "',descripcion='" & descrip & "' WHERE cod_tipocuenta=" & aClave

        ejecutar.CommandType = CommandType.Text
        ejecutar.Connection = conexion
        ejecutar.CommandText = sql

        Try
            ejecutar.ExecuteNonQuery()

            MsgBox("Datos Actualizados correctamente", vbOKOnly + vbInformation, "Modificar datos")
        Catch ex As Exception
            MsgBox("Error al actualizar los datos: " & ex.Message, vbOKOnly + vbCritical, "Modificar datos")
        End Try
        desconect()

    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        guardar()
    End Sub

    Private Sub guardar()

        conect()
        If txtNclave.Text <> "" And txtNombreC.Text <> "" And txtDescripcion.Text <> "" Then
            cod = txtNclave.Text
            nombre = txtNombreC.Text
            descrip = txtDescripcion.Text
        Else
            MsgBox("Es obligatorio rellenar todos los campos con el tipo correcto de datos", vbOKOnly + vbExclamation, "Planes")
            limpiar()
        End If


        Try
            sql = "INSERT INTO TIPOCUENTA VALUES(" & cod & ",'" & nombre & "','" & descrip & "')"

            ejecutar.CommandType = CommandType.Text
            ejecutar.Connection = conexion
            ejecutar.CommandText = sql

            ejecutar.ExecuteNonQuery()

            MsgBox("Datos guardados correctamente", vbOKOnly + vbInformation, "Planes")
        Catch ex As Exception
            MsgBox("Error al guardar los datos: " & ex.Message, vbOKOnly + vbCritical, "Planes")
        End Try

        desconect()
    End Sub
    Private Sub eliminar()
        conect()
        r = InputBox("Ingrese el Codigo del tipo de cuenta que desea eliminar", "Tipo de cuenta")
        If r <> "" Then
            o = MsgBox("Estás seguro que quieres eliminar estos dato?", vbYesNo + vbQuestion, "Eliminar")
            If o = 6 Then
                sql = "DELETE* FROM TIPOCUENTA WHERE cod_tipocuenta= " & r

                ejecutar.CommandType = CommandType.Text
                ejecutar.Connection = conexion
                ejecutar.CommandText = sql
            End If
        Else
            MsgBox("Ingrese la clave de  la cuenta que desea elimiar", vbOKOnly + vbExclamation, "Eliminar")
        End If
        Try
            ejecutar.ExecuteNonQuery()
            MsgBox("Datos eliminados correctamente", vbCritical + vbOKOnly, "Eliminar")
        Catch ex As Exception
            MsgBox("Error en la eliminación: " & ex.Message, vbCritical + vbOKOnly, "Eliminar")
        End Try

        desconect()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        modificar()
    End Sub
End Class