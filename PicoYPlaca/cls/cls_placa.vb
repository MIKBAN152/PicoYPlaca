Public Class cls_placa
    Dim str_placa As String = ""
    Dim int_last_digit As Integer = 0
    Dim error_message As String = "No Error"

    Public Function set_placa(ByVal placa As String) As Boolean
        Dim success As Boolean = False
        If placa.Length = 7 Then
            str_placa = placa
            If set_last_digit() Then
                success = True
            End If
        Else
            error_message = "Placa no valida"
        End If
        Return success
    End Function

    Private Function set_last_digit() As Boolean
        Dim conversion_succes As Boolean = False
        Try
            int_last_digit = CInt(str_placa.Substring(6, 1))
            conversion_succes = True
        Catch ex As Exception
            error_message = "Ultimo digito debe ser numero"
        End Try
        Return conversion_succes
    End Function

    Public Function get_pyp_day() As String
        Dim str_day As String = ""

        Select Case int_last_digit
            Case 1 To 2
                str_day = "1"'"LUNES"
            Case 3 To 4
                str_day = "2"'"MARTES"
            Case 5 To 6
                str_day = "3"'"MIERCOLES"
            Case 7 To 8
                str_day = "4"'"JUEVES"
            Case 0, 9
                str_day = "5" '"VIERNES"
            Case Else
                str_day = "error en ultimo digito"
        End Select
        Return str_day
    End Function

    Public Function get_msg() As String
        Return error_message
    End Function
End Class
