Public Class cls_fecha_hora
    Dim str_day As String = ""
    Dim str_date As String = ""
    Dim str_time As String = ""
    Dim msg_error As String = "No error"
    Dim time_range1() As DateTime = {#07:00#, #09:30#}
    Dim time_range2() As DateTime = {#16:00#, #19:30#}
    Dim time_in_pyp As Boolean = False
    Dim dt_date As DateTime
    Dim dt_time As DateTime

    Public Function validate_date(ByVal _date As String) As Boolean
        Dim success As Boolean = False
        If _date.Contains("/") Then
            Dim trck_date() As String = Split(_date, "/")
            Dim date_org As String = trck_date(1) + "/" + trck_date(0) + "/" + trck_date(2)
            Try
                dt_date = Convert.ToDateTime(date_org)
                str_day = dt_date.DayOfWeek
                success = True
            Catch ex As Exception
                msg_error = "Ingresa una fecha valida."
            End Try

        Else
            msg_error = "La fecha no tiene el formato solicitado."
        End If
        Return success
    End Function

    Public Function validate_time(ByVal _time As String) As Boolean
        Dim success As Boolean = False
        If _time.Contains(":") Then
            Try
                dt_time = Convert.ToDateTime(_time)
                If (dt_time.TimeOfDay >= time_range1(0).TimeOfDay And dt_time.TimeOfDay <= time_range1(1).TimeOfDay) Or (dt_time.TimeOfDay >= time_range2(0).TimeOfDay And dt_time.TimeOfDay <= time_range2(1).TimeOfDay) Then
                    time_in_pyp = True
                Else
                    time_in_pyp = False
                End If
                success = True
            Catch ex As Exception
                msg_error = "Ingresa una hora valida."
            End Try
        Else
            msg_error = "La hora no tiene el formato solicitado."
        End If
        Return success
    End Function

    Public Function get_week_day() As String
        Return str_day
    End Function

    Public Function get_time_in_pyp() As Boolean
        Return time_in_pyp
    End Function
    Public Function get_msg() As String
        Return msg_error
    End Function
End Class
