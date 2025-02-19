Imports System.Data.Odbc
Module Module1

    Public cmd As OdbcCommand
    Public cnn As OdbcConnection
    Public rs As OdbcDataReader
    Public sql As String
    Public clasepasaje As String
    Public horapasaje As String
    Public desdepasaje As String
    Public hastapasaje As String
    Public fpasaje As String
    Public clientepasaje As String
    Public vuelopasaje As Integer
    Public nombrec As String
    Public apellidoc As String
    Public dnic As String
    Public maxc As Integer
    Public codc As Integer
    Public countdni As Integer
    Public pasajemax As Integer


    Public Sub ejecutar(ByVal consulta As String)

        cmd = New OdbcCommand(consulta, cnn)
        cmd.CommandType = CommandType.Text

            rs = cmd.ExecuteReader

            cmd.Dispose()

    End Sub

End Module
