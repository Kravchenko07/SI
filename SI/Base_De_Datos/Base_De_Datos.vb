Imports System.Configuration
Public Class Base_De_Datos

    Shared Entorno_De_Datos As Entorno_De_DatosDataContext = New Entorno_De_DatosDataContext()

    Public Shared Sub Conectar()
        Entorno_De_Datos = New Entorno_De_DatosDataContext(ConfigurationManager.ConnectionStrings("conex").ConnectionString)
    End Sub

    Public Shared Sub DesConectar()
        Entorno_De_Datos.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)
        Entorno_De_Datos.Dispose()
    End Sub

    Public Shared Function Listado_Usuarios() As List(Of Vw_Maestro_Usuario)
        Conectar()
        Dim Listado As New List(Of Vw_Maestro_Usuario)
        Listado = Entorno_De_Datos.Vw_Maestro_Usuarios.Where(Function(x) x.Borrado = False).ToList()
        DesConectar()
        Return Listado
    End Function
    Public Shared Function Listado_Cliente() As List(Of Vw_Cliente)
        Conectar()
        Dim Listado As New List(Of Vw_Cliente)
        Listado = Entorno_De_Datos.Vw_Clientes.Where(Function(x) x.Eliminado = False).ToList()
        DesConectar()
        Return Listado
    End Function
    Public Shared Function Listado_Almacen() As List(Of Almacen)
        Conectar()
        Dim Listado = Entorno_De_Datos.Almacens.Where(Function(x) x.Eliminado = False).ToList()
        DesConectar()
        Return Listado
    End Function
    Public Shared Function Listado_Producto() As List(Of Vw_Producto_Almacen)
        Conectar()
        Dim Listado As New List(Of Vw_Producto_Almacen)
        Listado = Entorno_De_Datos.Vw_Producto_Almacens.Where(Function(x) x.Eliminado = False).ToList()
        DesConectar()
        Return Listado
    End Function

    Public Shared Function Listado_Pregunta() As List(Of Pregunta_Seguridad)
        Conectar()
        Dim Listado = Entorno_De_Datos.Pregunta_Seguridads().ToList
        DesConectar()
        Return Listado
    End Function

    Public Shared Function Listado_Rol() As List(Of Rol)
        Conectar()
        Dim Listado = Entorno_De_Datos.Rols().ToList
        DesConectar()
        Return Listado
    End Function

    Public Shared Sub Insertar_Usuario(ByVal Obj As Usuario)
        Conectar()
        Obj.Respuesta = String.Empty
        Entorno_De_Datos.Usuarios.InsertOnSubmit(Obj)
        Entorno_De_Datos.SubmitChanges()
        DesConectar()
    End Sub

    Public Shared Sub Actualizar_Usuario(ByVal Obj As Usuario)
        Conectar()
        Entorno_De_Datos.Usuarios.Attach(Obj)
        Entorno_De_Datos.Refresh(Data.Linq.RefreshMode.KeepCurrentValues, Obj)
        Entorno_De_Datos.SubmitChanges()
        DesConectar()
    End Sub
    Public Shared Sub Instertar_Cliente(ByVal Obj As Cliente)
        Conectar()
        Entorno_De_Datos.Clientes.InsertOnSubmit(Obj)
        Entorno_De_Datos.SubmitChanges()
        DesConectar()
    End Sub
    Public Shared Sub Actulizar_Cliente(ByVal Obj As Cliente)
        Conectar()
        Entorno_De_Datos.Clientes.Attach(Obj)
        Entorno_De_Datos.Refresh(Data.Linq.RefreshMode.KeepCurrentValues, Obj)
        Entorno_De_Datos.SubmitChanges()
        DesConectar()
    End Sub
    Public Shared Sub Insertar_Almacen(ByVal Obj As Almacen)
        Conectar()
        Entorno_De_Datos.Almacens.InsertOnSubmit(Obj)
        Entorno_De_Datos.SubmitChanges()
        DesConectar()
    End Sub
    Public Shared Sub Actualizar_Almacen(ByVal Obj As Almacen)
        Conectar()
        Entorno_De_Datos.Almacens.Attach(Obj)
        Entorno_De_Datos.Refresh(Data.Linq.RefreshMode.KeepCurrentValues, Obj)
        Entorno_De_Datos.SubmitChanges()
        DesConectar()
    End Sub
    Public Shared Sub Insertar_Producto(ByVal obj As Producto)
        Conectar()
        Entorno_De_Datos.Productos.InsertOnSubmit(obj)
        Entorno_De_Datos.SubmitChanges()
        DesConectar()
    End Sub
    Public Shared Sub Actualizar_Producto(ByVal obj As Producto)
        Conectar()
        Entorno_De_Datos.Productos.Attach(obj)
        Entorno_De_Datos.Refresh(Data.Linq.RefreshMode.KeepCurrentValues, obj)
        Entorno_De_Datos.SubmitChanges()
        DesConectar()
    End Sub
    Public Shared Function ListaPermiso(ByVal IdRol As Integer) As List(Of sp_permisologiaResult)
        Conectar()
        Dim Listado As New List(Of sp_permisologiaResult)
        Listado = Entorno_De_Datos.sp_permisologia(IdRol).ToList()
        DesConectar()
        Return Listado
    End Function

    Public Shared Sub Insertar_PermisoRol(ByVal Obj As Rol_Permisologia)
        Conectar()
        Entorno_De_Datos.Rol_Permisologias.InsertOnSubmit(Obj)
        Entorno_De_Datos.SubmitChanges()
        DesConectar()
    End Sub
    Public Shared Sub Eliminar_PermisoRol(ByVal IdRol As Integer, ByVal IdPermisologia As Integer)
        Conectar()
        Dim Obj As New Rol_Permisologia()
        Obj = Entorno_De_Datos.Rol_Permisologias.Where(Function(x) x.Id_Rol = IdRol And x.Id_Permisologia = IdPermisologia).SingleOrDefault()
        Entorno_De_Datos.Rol_Permisologias.DeleteOnSubmit(Obj)
        Entorno_De_Datos.SubmitChanges()
        DesConectar()
    End Sub

    Public Shared Sub Insertar_Contrasena(ByVal Obj As Contrasena_Usuario)
        Conectar()
        Dim ObjContrs As New Contrasena_Usuario()
        ObjContrs = Entorno_De_Datos.Contrasena_Usuarios.Where(Function(x) x.Activa = True And x.Id_Usuario = Obj.Id_Usuario).SingleOrDefault()
        If (ObjContrs IsNot Nothing) Then
            ObjContrs.Activa = False
            Entorno_De_Datos.Refresh(Data.Linq.RefreshMode.KeepChanges, ObjContrs)
            Entorno_De_Datos.SubmitChanges()
        End If

        Dim wrapper As New Encriptar(Obj.contrasena)
        Obj.contrasena = wrapper.EncryptData(Obj.contrasena)
        Entorno_De_Datos.Contrasena_Usuarios.InsertOnSubmit(Obj)
        Entorno_De_Datos.SubmitChanges()
        DesConectar()
    End Sub

    Public Shared Function Login(ByVal Usuario As String, ByVal Password As String) As Vw_Usuario
        Try
            Conectar()
            Dim wrapper As New Encriptar(Password)
            Password = wrapper.EncryptData(Password)
            Dim ObjLogin As New Vw_Usuario()
            ObjLogin = Entorno_De_Datos.Vw_Usuarios.Where(Function(x) x.Username = Usuario And x.contrasena = Password).Single()
            DesConectar()
            Return ObjLogin
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Function CompareUser(ByVal Usuario As String) As Usuario
        Try
            Conectar()
            Dim User As New Usuario()
            User = Entorno_De_Datos.Usuarios.Where(Function(x) x.Username = Usuario).Single()
            DesConectar()
            Return User
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
End Class
