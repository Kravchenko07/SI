Public Class FrmNuevoUsuario
    Sub Cargar_Pregunta()
        Dim Lista_pregunta = Base_De_Datos.Base_De_Datos.Listado_Pregunta()
        Dim ObjPreg As New Base_De_Datos.Pregunta_Seguridad
        ObjPreg.Id = 0
        ObjPreg.Description = "Seleccionar"
        Lista_pregunta.Add(ObjPreg)
        PreguntaComboBox.DataSource = Lista_pregunta
        PreguntaComboBox.ValueMember = "Id"
        PreguntaComboBox.DisplayMember = "Description"
        PreguntaComboBox.SelectedValue = 0
    End Sub

    Private Sub FrmNuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Pregunta()
        Limpiar()
    End Sub

    Dim _ObjActual As New Base_De_Datos.Usuario
    Property ObjActual As Base_De_Datos.Usuario
        Get
            If (_ObjActual Is Nothing) Then
                _ObjActual = New Base_De_Datos.Usuario()
            End If
            _ObjActual.Id_Pregunta = PreguntaComboBox.SelectedValue
            _ObjActual.Respuesta = RespuestaTxt.Text
            _ObjActual.Verify = True
            Return _ObjActual
        End Get
        Set(value As Base_De_Datos.Usuario)
            _ObjActual = value
        End Set
    End Property

    Dim _ObjContrsn As New Base_De_Datos.Contrasena_Usuario
    ReadOnly Property ObjContrsn As Base_De_Datos.Contrasena_Usuario
        Get
            _ObjContrsn.contrasena = ContrasenaTxt.Text
            _ObjContrsn.Id_Usuario = ObjActual.Id
            _ObjContrsn.Fecha_Agregado = Date.Today
            _ObjContrsn.Activa = True
            Return _ObjContrsn
        End Get
    End Property


    Private Sub GuardarToolStripButton_Click(sender As Object, e As EventArgs) Handles GuardarToolStripButton.Click
        If (ValidateUser() = False) Then
            Base_De_Datos.Base_De_Datos.Actualizar_Usuario(ObjActual)
            Base_De_Datos.Base_De_Datos.Insertar_Contrasena(ObjContrsn)
            Limpiar()
            MsgBox("Usuario Actualizado")
            Dim FrmInventario As New FrmInventario
            FrmInventario.Show()
            Me.Hide()
        End If

    End Sub
    Sub Limpiar()
        UsuarioTxt.Text = String.Empty
        ContrasenaTxt.Text = String.Empty
        ReptrContrasenaTxt.Text = String.Empty
        ProgressBar1.Value = 0
        ProgressBar1.Visible = True
        PreguntaComboBox.SelectedValue = 0
        RespuestaTxt.Text = String.Empty
        ObjActual = Nothing

    End Sub
    Dim Leng_Anterior As Integer
    Dim wupper As Boolean = False
    Dim wlower As Boolean = False
    Dim wnum As Boolean = False
    Dim wspecial As Boolean = False
    Dim minlen As Boolean = False

    Sub ValidatePass(ByVal pwd As String)
        Dim minLength As Integer = 8
        Dim maxLength As Integer = 20
        Dim numUpper As Integer = 1
        Dim numLower As Integer = 1
        Dim numNumbers As Integer = 1
        Dim numSpecial As Integer = 1


        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters.
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Special is "none of the above".
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        ' Check the length.
        If (pwd.Length < Leng_Anterior) Then
            ProgressBar1.Value -= 2
            Leng_Anterior = pwd.Length
        End If

        If (pwd.Length > Leng_Anterior) Then
            Leng_Anterior = pwd.Length
            If (maxLength < pwd.Length) Then
                minlen = True
            End If

            If (Not minlen) Then
                ProgressBar1.Value += 2
            End If

        End If

        'If Len(pwd) >= minLength Then
        '    If (Not minlen) Then
        '        ProgressBar1.Value += 10
        '        minlen = True
        '    End If
        'Else
        '    If (minlen) Then
        '        ProgressBar1.Value -= 10
        '    End If
        'End If

        If upper.Matches(pwd).Count >= numUpper Then
            If (Not wupper) Then
                ProgressBar1.Value += 15
                wupper = True
            End If
        Else
            If (wupper) Then
                ProgressBar1.Value -= 15
                wupper = False
            End If
        End If

        If lower.Matches(pwd).Count >= numLower Then
            If (Not wlower) Then
                ProgressBar1.Value += 15
                wlower = True
            End If
        Else
            If (wlower) Then
                ProgressBar1.Value -= 15
                wlower = False
            End If
        End If

        If number.Matches(pwd).Count >= numNumbers Then
            If (Not wnum) Then
                ProgressBar1.Value += 15
                wnum = True
            End If
        Else
            If (wnum) Then
                ProgressBar1.Value -= 15
                wnum = False
            End If
        End If

        If special.Matches(pwd).Count >= numSpecial Then
            If (Not wspecial) Then
                ProgressBar1.Value += 15
                wspecial = True
            End If
        Else
            If (wspecial) Then
                ProgressBar1.Value -= 15
                wspecial = False
            End If
        End If
    End Sub

    Private Sub UsuarioTxt_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles UsuarioTxt.Validating
        If (UsuarioTxt.Text IsNot String.Empty) Then
            ObjActual = Base_De_Datos.Base_De_Datos.CompareUser(UsuarioTxt.Text)
            If (ObjActual.Id = 0) Then
                e.Cancel = True
                MsgBox("Usuario Incorrecto")
            End If
        End If
    End Sub
    Function ValidateUser()
        If (ContrasenaTxt.Text Is ReptrContrasenaTxt.Text) Then
            MsgBox("Las contraseñas no son iguales")
            Return True
        End If
    End Function



    Private Sub CancelarToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelarToolStripButton.Click
        Limpiar()
    End Sub

    Private Sub ContrasenaTxt_KeyUp(sender As Object, e As KeyEventArgs) Handles ContrasenaTxt.KeyUp
        ProgressBar1.Visible = True
        ValidatePass(ContrasenaTxt.Text)
    End Sub
End Class