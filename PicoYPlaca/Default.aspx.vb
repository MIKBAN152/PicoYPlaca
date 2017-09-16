Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub fnCheck(sender As Object, e As System.EventArgs)
        Dim str_placa As String = tbPlaca.Text
        Dim str_fecha As String = tbFecha.Text
        Dim str_hora As String = tbHora.Text
        Dim str_result As String = ""
        Dim in_pyp As Boolean = False
        Dim str_pyp_msg() As String = {"Auto SI puede circular", "Auto NO puede circular"}
        Dim cls_pyp As New cls_fn_pyp

        If String.IsNullOrEmpty(str_placa) Or String.IsNullOrEmpty(str_fecha) Or String.IsNullOrEmpty(str_hora) Then
            Dim msg As String = "Todos los campos deben ser ingresados."
            MsgBox(msg, MsgBoxStyle.OkOnly, "Advertencia")
            Return
        End If
        'lblPlaca.Text = 
        str_result = cls_pyp.fn_validate_placa(str_placa)
        If cls_pyp._continue Then
            'lblFecha.Text = 
            str_result = cls_pyp.fn_validate_fecha(str_fecha)
            If cls_pyp._continue Then
                'lblHora.Text = 
                str_result = cls_pyp.fn_validate_time(str_hora)
                If cls_pyp._continue Then
                    in_pyp = cls_pyp.fn_check_pyp
                    If in_pyp Then
                        lblResult.Text = str_pyp_msg(1)
                    Else
                        lblResult.Text = str_pyp_msg(0)
                    End If
                    Return
                End If
            End If
        End If
        lblResult.Text = str_result
    End Sub
End Class