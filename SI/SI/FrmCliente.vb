Public Class FrmCliente

    Dim _OjetoActual As New Base_De_Datos.Cliente
    Property ObjetoActual As Base_De_Datos.Cliente
        Get
            _OjetoActual.Nombre = NombreTxt.Text
            _OjetoActual.Apellido = ApellidoTxt.Text
            _OjetoActual.Cedula = CedulaTxt.Text
            _OjetoActual.Email = EmailTxt.Text
            _OjetoActual.Tlf_Local = TlfLocTxt.Text
            _OjetoActual.Tlf_Movil = TlfMovTxt.Text
            _OjetoActual.Direccion = DireccionTxt.Text
            Return _OjetoActual
        End Get
        Set(value As Base_De_Datos.Cliente)
            NombreTxt.Text = value.Nombre
            ApellidoTxt.Text = value.Apellido
            CedulaTxt.Text = value.Cedula
            EmailTxt.Text = value.Email
            TlfLocTxt.Text = value.Tlf_Local
            TlfMovTxt.Text = value.Tlf_Movil
            DireccionTxt.Text = value.Direccion
        End Set
    End Property

    Private Sub CargarGrid()
        GridViewCliente.AutoGenerateColumns = False
        GridViewCliente.DataSource = Base_De_Datos.Base_De_Datos.Listado_Cliente.Where(Function(x) x.Eliminado = False).ToList()
    End Sub

    Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If (ValidarCliente() = False) Then
            If (ObjetoActual.Id = 0) Then
                Base_De_Datos.Base_De_Datos.Instertar_Cliente(ObjetoActual)
                MsgBox("Cliente Guardado")
            Else
                Base_De_Datos.Base_De_Datos.Actulizar_Cliente(ObjetoActual)
                MsgBox("Cliente Actualizado")
            End If
        End If
    End Sub
    Private Function ValidarCliente()
        If (NombreTxt.Text.Trim = "") Then
            MsgBox("Debe ingresar el nombre del cliente")
            Return True
        ElseIf (ApellidoTxt.Text.Trim = "") Then
            MsgBox("Debe ingresar el apellido del cliente")
            Return True
        ElseIf (DireccionTxt.Text.Trim = "") Then
            MsgBox("Debe ingresar la dirección del cliente")
            Return True
        End If
    End Function

    Private Sub GridViewCliente_DoubleClick(sender As Object, e As EventArgs) Handles GridViewCliente.DoubleClick
        Dim seleccion As Base_De_Datos.Vw_Cliente
        Dim objCliente As New Base_De_Datos.Cliente
        seleccion = GridViewCliente.CurrentRow.DataBoundItem
        objCliente.Id = seleccion.IdCliente
        objCliente.Nombre = seleccion.Nombre
        objCliente.Apellido = seleccion.Apellido
        objCliente.Cedula = seleccion.Cedula
        objCliente.Email = seleccion.Email
        objCliente.Tlf_Local = seleccion.Tlf_Local
        objCliente.Tlf_Movil = seleccion.Tlf_Movil
        objCliente.Direccion = seleccion.Direccion
        objCliente.Eliminado = seleccion.Eliminado
        objCliente.Fecha_Agregado = seleccion.Fecha_Agregado
        ObjetoActual = objCliente

    End Sub
End Class