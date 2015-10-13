Public Class Configuracion

    Private Shared Usuario As Base_De_Datos.Vw_Usuario

    Public Shared Property Usuario_Activo As Base_De_Datos.Vw_Usuario
        Get
            Return Usuario
        End Get
        Set(value As Base_De_Datos.Vw_Usuario)
            Usuario = value
        End Set
    End Property

End Class
