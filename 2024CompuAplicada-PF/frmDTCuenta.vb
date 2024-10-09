﻿Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class frmDTCuenta

    Dim sql, r As String
    Dim o As Integer

    Public Function TamCol(ByVal dgv As DataGridView) As Single()
        Dim valores As Single() = New Single(dgv.ColumnCount - 1) {}
        For i As Integer = 0 To dgv.ColumnCount - 1
            valores(i) = CSng(dgv.Columns(i).Width)
        Next
        Return valores
    End Function

    Public Function ExportarPDF(ByVal Doc As Document)
        Dim DTabla As New PdfPTable(dgvCuentas.ColumnCount)
        DTabla.DefaultCell.Padding = 3
        Dim TamEncabezado As Single() = TamCol(dgvCuentas)
        DTabla.SetWidths(TamEncabezado)
        DTabla.WidthPercentage = 100
        DTabla.DefaultCell.BorderWidth = 2
        DTabla.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        Dim PrinEncab As New Paragraph("Tipos de cuenta", New Font(Font.Name = "Tahoma", 20, Font.Bold))
        PrinEncab.Alignment = Element.ALIGN_CENTER
        For i As Integer = 0 To dgvCuentas.ColumnCount - 1
            DTabla.AddCell(dgvCuentas.Columns(i).HeaderText)
        Next
        DTabla.HeaderRows = 1
        DTabla.DefaultCell.BorderWidth = 1

        For i As Integer = 0 To dgvCuentas.RowCount - 2
            For j As Integer = 0 To dgvCuentas.ColumnCount - 1
                DTabla.AddCell(dgvCuentas(j, i).Value.ToString())
            Next
            DTabla.CompleteRow()
        Next
        Doc.Add(PrinEncab)
        Doc.Add(New Chunk(" "))
        Doc.Add(New Chunk(" "))
        Doc.Add(DTabla)
    End Function

    Private Sub BusCuentas()

        sql = "SELECT * FROM TIPOCUENTA"
        conect()
        ejecutar.CommandType = CommandType.Text
        ejecutar.Connection = conexion
        ejecutar.CommandText = sql

        Try
            buscar = ejecutar.ExecuteReader
            While buscar.Read
                dgvCuentas.Rows.Add(buscar!cod_tipocuenta, buscar!nombre, buscar!descripcion)
            End While
        Catch ex As Exception
            MsgBox("Error en la búsqueda: " & ex.Message, vbCritical + vbOKOnly, "Error Busqueda")
        End Try

        desconect()
    End Sub
    Private Sub eliminar()
<<<<<<< HEAD
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
=======
        sql = "DELETE* FROM TIPOCUENTA WHERE cod_tipocuenta= "
        conect()
        ejecutar.CommandType = CommandType.Text
        ejecutar.Connection = conexion
        ejecutar.CommandText = sql

        Try
            
>>>>>>> 2616879e68097951eb53875619f41362c381979b
        Catch ex As Exception
            MsgBox("Error en la eliminación: " & ex.Message, vbCritical + vbOKOnly, "Eliminar")
        End Try

        desconect()
    End Sub

    Private Sub frmTipoCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BusCuentas()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            Dim Documento As New Document(PageSize.LETTER.Rotate(), 10, 10, 10, 10)
            Dim NArchivo As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Tipos de Cuentas.pdf"
            Dim archivo As New FileStream(NArchivo, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite)
            PdfWriter.GetInstance(Documento, archivo)
            Documento.Open()
            ExportarPDF(Documento)
            Documento.Close()
            Process.Start(NArchivo)
            MsgBox("Archivo creado", vbOKOnly + vbInformation, "Exportar a PDF")
        Catch ex As Exception
            MsgBox("Error al crear el archivo: " & ex.Message, vbOKOnly + vbCritical, "Error al exportar a PDF")
        End Try
    End Sub

<<<<<<< HEAD
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        frmActualizar.Show()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        frmAgregar.Show()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminar()
=======
<<<<<<< HEAD
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim r As Integer
        r = InputBox("Ingrese el Codigo del tipo de cuenta que desea eliminar","Tipo de cuenta")
=======
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
>>>>>>> d86ba23953df3a7ea8481e12010ac02d102cc59b

>>>>>>> 2616879e68097951eb53875619f41362c381979b
    End Sub
End Class