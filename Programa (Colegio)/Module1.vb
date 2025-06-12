'Imports System.Data.Odbc
Imports System.Data.SQLite

Module Module1

    Public cmd As SQLiteCommand
    Public cnn As SQLiteConnection
    Public rs As SQLiteDataReader
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

        cmd = New SQLiteCommand(consulta, cnn)
        cmd.CommandType = CommandType.Text

            rs = cmd.ExecuteReader

            cmd.Dispose()

    End Sub

End Module
