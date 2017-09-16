Public Class cls_fn_pyp
    Public _continue As Boolean = False
    Private _date_day As String = "" '
    Private _placa_day As String = ""
    Private _time_pyp As Boolean = False


    Public Function fn_validate_placa(ByVal placa As String) As String
        Dim str_result As String = "" '
        Dim bl_result As Boolean = False
        Dim ob_placa As New cls_placa
        bl_result = ob_placa.set_placa(placa)
        If bl_result Then
            str_result = ob_placa.get_pyp_day
            _placa_day = str_result
            _continue = True
        Else
            str_result = ob_placa.get_msg
            _continue = False
        End If

        Return str_result
    End Function

    Public Function fn_validate_fecha(ByVal fecha As String) As String
        Dim str_result As String = "" '
        Dim bl_result As Boolean = False
        Dim ob_fech_hora As New cls_fecha_hora
        bl_result = ob_fech_hora.validate_date(fecha)
        If bl_result Then
            str_result = ob_fech_hora.get_week_day
            _date_day = str_result
            _continue = True
        Else
            _continue = False
            str_result = ob_fech_hora.get_msg
        End If
        Return str_result
    End Function

    Public Function fn_validate_time(ByVal time As String) As String
        Dim str_result As String = ""
        Dim bl_result As Boolean = False
        Dim ob_fech_hora As New cls_fecha_hora
        bl_result = ob_fech_hora.validate_time(time)
        If bl_result Then
            _time_pyp = ob_fech_hora.get_time_in_pyp
            str_result = _time_pyp.ToString
            _continue = True
        Else
            _continue = False
            str_result = ob_fech_hora.get_msg
        End If
        Return str_result
    End Function

    Public Function fn_check_pyp() As Boolean
        If Not _time_pyp Then
            Return False
        Else
            If _placa_day = _date_day Then
                Return True
            Else
                Return False
            End If
        End If
    End Function
End Class
