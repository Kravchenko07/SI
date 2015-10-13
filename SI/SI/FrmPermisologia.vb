Public Class FrmPermisologia
    Sub CargarUsuario()

        Dim Lista_Rol = Base_De_Datos.Base_De_Datos.Listado_Rol()
        Dim ObjRol As New Base_De_Datos.Rol
        ObjRol.Id = 0
        ObjRol.Description = "Seleccionar"
        Lista_Rol.Add(ObjRol)
        RolComboBox.ValueMember = "Id"
        RolComboBox.DisplayMember = "Description"
        RolComboBox.DataSource = Lista_Rol
        RolComboBox.SelectedValue = 0
    End Sub


    Private Sub FrmPermisologia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarUsuario()
    End Sub
    Dim _ListadoPermiso As List(Of Base_De_Datos.sp_permisologiaResult)

    Property ListadoPermiso As List(Of Base_De_Datos.sp_permisologiaResult)
        Get
                _ListadoPermiso = Base_De_Datos.Base_De_Datos.ListaPermiso(RolComboBox.SelectedValue)
            Return _ListadoPermiso
        End Get
        Set(value As List(Of Base_De_Datos.sp_permisologiaResult))
            _ListadoPermiso = value
        End Set
    End Property
    Sub Cargar_ListaSinPermiso()
        SinPermisoListBox.ValueMember = "Id"
        SinPermisoListBox.DisplayMember = "Description"
        ConPermisoListBox.ValueMember = "Id"
        ConPermisoListBox.DisplayMember = "Description"
        SinPermisoListBox.DataSource = ListadoPermiso.Where(Function(x) x.allowed = False).ToList()
        ConPermisoListBox.DataSource = ListadoPermiso.Where(Function(x) x.allowed = True).ToList()

    End Sub

    Private Sub RolComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RolComboBox.SelectedIndexChanged
        If (RolComboBox.SelectedValue <> 0) Then
            Cargar_ListaSinPermiso()
        Else
            SinPermisoListBox.DataSource = Nothing
            ConPermisoListBox.DataSource = Nothing
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (SinPermisoListBox.SelectedValue > 0) Then
            Dim obj As New Base_De_Datos.Rol_Permisologia()
            obj.Id_Rol = RolComboBox.SelectedValue
            obj.Id_Permisologia = SinPermisoListBox.SelectedValue
            Base_De_Datos.Base_De_Datos.Insertar_PermisoRol(obj)
            Cargar_ListaSinPermiso()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (ConPermisoListBox.SelectedValue > 0) Then
            Dim obj As New Base_De_Datos.Rol_Permisologia()
            obj.Id_Rol = RolComboBox.SelectedValue
            obj.Id_Permisologia = ConPermisoListBox.SelectedValue
            Base_De_Datos.Base_De_Datos.Eliminar_PermisoRol(obj.Id_Rol, obj.Id_Permisologia)
            Cargar_ListaSinPermiso()
        End If
    End Sub
End Class