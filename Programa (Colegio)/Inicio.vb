'Imports System.Data.Odbc
Imports System.Data.SQLite

Public Class frmInicio
    Private Sub frmInicio_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        Try

            cnn = New SQLiteConnection("Data Source=Base pasajes.db;Version=3;")
            cnn.Open()
        Catch ex As Exception

            MsgBox("Conexion interrumpida", MsgBoxStyle.Critical, "Error de conexion")

        End Try

    End Sub

    Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSalir.Click

        If (MsgBox("¿Esta seguro que desea salir del Sistema?", MsgBoxStyle.YesNo, "Salir del Sistema") = MsgBoxResult.Yes) Then

            End

        Else

        End If

    End Sub

    Private Sub btnReserva_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReserva.Click

        Me.Hide()
        frmReserva.Show()

    End Sub

    Private Sub btnVenta_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnVenta.Click

        Me.Hide()
        frmVenta.Show()

    End Sub

End Class
