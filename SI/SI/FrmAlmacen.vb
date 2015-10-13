Public Class FrmAlmacen

    Dim _ObjetoActual As New Base_De_Datos.Almacen
    Property objetoActual As Base_De_Datos.Almacen
        Get
            _ObjetoActual.Nombre = NombreTxt.Text
            _ObjetoActual.Descripcion = DescripcionTxt.Text
            _ObjetoActual.Direccion = DireccionTxt.Text
            Return _ObjetoActual
        End Get
        Set(value As Base_De_Datos.Almacen)
            _ObjetoActual = value
            If (_ObjetoActual IsNot Nothing) Then
                NombreTxt.Text = value.Nombre
                DescripcionTxt.Text = value.Descripcion
                DireccionTxt.Text = value.Direccion
            End If
        End Set
    End Property
    Private Sub GuardarToolButton_Click(sender As Object, e As EventArgs) Handles GuardarToolButton.Click
        If (Validar_Almacen() = False) Then
            If (objetoActual.Id = 0) Then
                Base_De_Datos.Base_De_Datos.Insertar_Almacen(objetoActual)
                MsgBox("Almacen Guardado")
            Else
                Base_De_Datos.Base_De_Datos.Actualizar_Almacen(objetoActual)
                MsgBox("Almacen Actualizado")
            End If
            Limpiar()
            Cargar_Grid()
        End If
    End Sub
    Private Sub Cargar_Grid()
        DataGridViewAlmacen.AutoGenerateColumns = False
        DataGridViewAlmacen.DataSource = Base_De_Datos.Base_De_Datos.Listado_Almacen().ToList
    End Sub

    Private Sub GridViewAlmacen_DoubleClick(sender As Object, e As EventArgs) Handles DataGridViewAlmacen.DoubleClick
        Dim seleccion As Base_De_Datos.Almacen
        Dim objAlmacen As New Base_De_Datos.Almacen()
        seleccion = DataGridViewAlmacen.CurrentRow.DataBoundItem
        objAlmacen.Id = seleccion.Id
        objAlmacen.Nombre = seleccion.Nombre
        objAlmacen.Descripcion = seleccion.Descripcion
        objAlmacen.Direccion = seleccion.Direccion
        objAlmacen.Eliminado = seleccion.Eliminado
        objetoActual = objAlmacen
    End Sub
    Private Sub EliminarToolButton_Click(sender As Object, e As EventArgs) Handles EliminarToolButton.Click
        If (objetoActual.Id <> 0) Then
            objetoActual.Eliminado = True
            Base_De_Datos.Base_De_Datos.Actualizar_Almacen(objetoActual)
            MsgBox("Almacen Eliminado")
            Limpiar()
            Cargar_Grid()
        End If


    End Sub

    Private Function Validar_Almacen() As Boolean
        If (NombreTxt.Text.Trim = "") Then
            MsgBox("Debe Ingresar el nombre del Almacen")
            Return True
        ElseIf (DescripcionTxt.Text.Trim = "") Then
            MsgBox("Debe Ingresar una Descripción")
            Return True
        ElseIf (DireccionTxt.Text.Trim = "") Then
            MsgBox("Debe Ingresar una Dirección")
            Return True
        End If
    End Function
    Private Sub Limpiar()
        NombreTxt.Text = String.Empty
        DireccionTxt.Text = String.Empty
        DescripcionTxt.Text = String.Empty
        objetoActual = Nothing

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Limpiar()
    End Sub

    Private Sub FrmAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Grid()
    End Sub
End Class