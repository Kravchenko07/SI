Public Class FrmUsuario

    Private Sub Cargar_Rol()
        Dim Lista_Rol = Base_De_Datos.Base_De_Datos.Listado_Rol()
        Dim ObjRol As New Base_De_Datos.Rol
        ObjRol.Id = 0
        ObjRol.Description = "Seleccionar"
        Lista_Rol.Add(ObjRol)
        RolCombBox.DataSource = Lista_Rol
        RolCombBox.ValueMember = "Id"
        RolCombBox.DisplayMember = "Description"
        RolCombBox.SelectedValue = 0
    End Sub

    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Rol()
        Cargar_Grid()
    End Sub

    Dim _Objeto_Actual As New Base_De_Datos.Usuario
    Property Objeto_Actual As Base_De_Datos.Usuario
        Get
            If (_Objeto_Actual Is Nothing) Then
                _Objeto_Actual = New Base_De_Datos.Usuario()
            End If
            _Objeto_Actual.Nombre = NombreTxt.Text
            _Objeto_Actual.Username = UsuarioTxt.Text
            _Objeto_Actual.Id_Rol = Integer.Parse(RolCombBox.SelectedValue.ToString())
            _Objeto_Actual.Activo = EstadoCheckBox.Checked

            Return _Objeto_Actual
        End Get
        Set(value As Base_De_Datos.Usuario)
            _Objeto_Actual = value
            If (_Objeto_Actual IsNot Nothing) Then
                NombreTxt.Text = value.Nombre
                UsuarioTxt.Text = value.Username
                RolCombBox.SelectedValue = value.Id_Rol
                EstadoCheckBox.Checked = value.Activo
            End If
        End Set
    End Property
    Dim _Lista_Usuario As List(Of Base_De_Datos.Vw_Maestro_Usuario)
    Property Lista_Usuario As List(Of Base_De_Datos.Vw_Maestro_Usuario)
        Get
            If (_Lista_Usuario Is Nothing) Then
                _Lista_Usuario = Base_De_Datos.Base_De_Datos.Listado_Usuarios()
            End If

            Return _Lista_Usuario

        End Get
        Set(value As List(Of Base_De_Datos.Vw_Maestro_Usuario))
            _Lista_Usuario = value

        End Set
    End Property

    Private Sub Cargar_Grid()
        GridViewUsuario.AutoGenerateColumns = False
        GridViewUsuario.DataSource = Base_De_Datos.Base_De_Datos.Listado_Usuarios()
    End Sub
    Private Sub GuardarToolButton_Click(sender As Object, e As EventArgs) Handles GuardarToolButton.Click
        If (Validar_Usuario() = False) Then
            If (Objeto_Actual.Id = 0) Then
                Base_De_Datos.Base_De_Datos.Insertar_Usuario(Objeto_Actual)
                MsgBox("Usuario Guardado")
            Else
                Base_De_Datos.Base_De_Datos.Actualizar_Usuario(Objeto_Actual)
                MsgBox("Usuario Actualizado")
            End If
            Limpiar()
            Cargar_Grid()
        End If
    End Sub
    Private Function Validar_Usuario() As Boolean
        If (NombreTxt.Text.Trim = "") Then
            MsgBox("Debe Ingresar el nombre de Usuario")
            Return True
        ElseIf (UsuarioTxt.Text.Trim = "") Then
            MsgBox("Debe Ingresar el Usuario")
            Return True
        ElseIf (RolCombBox.SelectedValue.ToString() = "0") Then
            MsgBox("No ha seleccionado el Rol del Usuario")
            Return True
        End If
    End Function
    Private Sub Limpiar()
        NombreTxt.Text = String.Empty
        UsuarioTxt.Text = String.Empty
        RolCombBox.SelectedValue = 0
        EstadoCheckBox.Checked = False
        Objeto_Actual = Nothing
        Lista_Usuario = Nothing
    End Sub

    Private Sub CancelarToolButton_Click(sender As Object, e As EventArgs) Handles CancelarToolButton.Click
        Limpiar()
    End Sub

    Private Sub GridViewUsuario_DoubleClick(sender As Object, e As EventArgs) Handles GridViewUsuario.DoubleClick
        Dim seleccion As Base_De_Datos.Vw_Maestro_Usuario
        Dim objusuario As New Base_De_Datos.Usuario()
        seleccion = GridViewUsuario.SelectedRows(0).DataBoundItem
        objusuario.Id = seleccion.Id
        objusuario.Nombre = seleccion.Nombre
        objusuario.Username = seleccion.Username
        objusuario.Respuesta = seleccion.Respuesta
        objusuario.Id_Pregunta = seleccion.Id_Pregunta
        objusuario.Id_Rol = seleccion.Id_Rol
        objusuario.Activo = seleccion.Activo
        objusuario.Verify = seleccion.Verify
        objusuario.Borrado = seleccion.Borrado
        Objeto_Actual = objusuario

    End Sub

    Private Sub EliminarToolButton_Click(sender As Object, e As EventArgs) Handles EliminarToolButton.Click
        If (Objeto_Actual.Id <> 0) Then
            Objeto_Actual.Borrado = True
            Base_De_Datos.Base_De_Datos.Actualizar_Usuario(Objeto_Actual)
            MsgBox("Usuario Eliminado")
            Limpiar()
            Cargar_Grid()
        End If


    End Sub
End Class

