Public Class FrmProducto

    Private Sub FrmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarListadoAlmacen()
        CargarGrid()
    End Sub

    Private Sub CargarListadoAlmacen()
        Dim Lista_Almacen = Base_De_Datos.Base_De_Datos.Listado_Almacen()
        Dim ObjAlm As New Base_De_Datos.Almacen
        ObjAlm.Id = 0
        ObjAlm.Nombre = "Seleccionar"
        Lista_Almacen.Add(ObjAlm)
        ComboBoxAlmacen.DataSource = Lista_Almacen
        ComboBoxAlmacen.ValueMember = "Id"
        ComboBoxAlmacen.DisplayMember = "Nombre"
        ComboBoxAlmacen.SelectedValue = 0
    End Sub

    Private Sub CargarGrid()
        GridViewProducto.AutoGenerateColumns = False
        GridViewProducto.DataSource = Base_De_Datos.Base_De_Datos.Listado_Producto

    End Sub

    Dim _ObjetoActual As New Base_De_Datos.Producto
    Property objetoActual As Base_De_Datos.Producto
        Get
            _ObjetoActual.Codigo = CodigoTxt.Text
            _ObjetoActual.Nombre = NombreTxt.Text
            _ObjetoActual.Descripcion = DescripcionTxt.Text
            _ObjetoActual.Stock = StockTxt.Text
            _ObjetoActual.StockMin = StockMinTxt.Text
            _ObjetoActual.IdAlmacen = Integer.Parse(ComboBoxAlmacen.SelectedValue.ToString())
            Return _ObjetoActual

        End Get
        Set(value As Base_De_Datos.Producto)
            _ObjetoActual = value
            If (_ObjetoActual IsNot Nothing) Then
                CodigoTxt.Text = value.Codigo
                NombreTxt.Text = value.Nombre
                DescripcionTxt.Text = value.Descripcion
                StockTxt.Text = value.Stock
                StockMinTxt.Text = value.StockMin
                ComboBoxAlmacen.SelectedValue = value.IdAlmacen
            End If
        End Set
    End Property

    Private Sub GuardarToolStripButton_Click(sender As Object, e As EventArgs) Handles GuardarToolStripButton.Click
        If (ValidarProducto() = False) Then
            If (objetoActual.Id = 0) Then
                Base_De_Datos.Base_De_Datos.Insertar_Producto(objetoActual)
                MsgBox("Producto Guardado")
            Else
                Base_De_Datos.Base_De_Datos.Actualizar_Producto(objetoActual)
                MsgBox("Producto Actualizado")
            End If
            Limpiar()
            CargarGrid()
        End If
    End Sub
    Private Function ValidarProducto() As Boolean
        If (CodigoTxt.Text.Trim = "") Then
            MsgBox("Debe ingresar un codigo al producto")
            Return True
        ElseIf (NombreTxt.Text.Trim = "") Then
            MsgBox("Debe ingresar el nombre del producto")
            Return True
        ElseIf (DescripcionTxt.Text.Trim = "") Then
            MsgBox("Debe ingresar la descripción del producto")
            Return True
        ElseIf (StockTxt.Text.Trim = "") Then
            MsgBox("Debe ingresar el stock actual del producto")
            Return True
        ElseIf (StockMinTxt.Text.Trim = "") Then
            MsgBox("Debe ingresar el stock minimo del producto")
            Return True
        ElseIf (ComboBoxAlmacen.SelectedValue.ToString() = "0") Then
            MsgBox("Debe seleccionarle un almacen al producto")
            Return True
        End If
    End Function

    Private Sub Limpiar()
        CodigoTxt.Text = String.Empty
        NombreTxt.Text = String.Empty
        DescripcionTxt.Text = String.Empty
        StockTxt.Text = String.Empty
        StockMinTxt.Text = String.Empty
        ComboBoxAlmacen.SelectedValue = 0
        objetoActual = Nothing

    End Sub

    Private Sub GridViewProducto_DoubleClick(sender As Object, e As EventArgs) Handles GridViewProducto.DoubleClick

        Dim seleccion As Base_De_Datos.Vw_Producto_Almacen
        Dim objProducto As New Base_De_Datos.Producto()
        seleccion = GridViewProducto.CurrentRow.DataBoundItem
        objProducto.Id = seleccion.Id
        objProducto.Codigo = seleccion.Codigo
        objProducto.Nombre = seleccion.Nombre
        objProducto.Descripcion = seleccion.Descripcion
        objProducto.Stock = seleccion.Stock
        objProducto.StockMin = seleccion.StockMin
        objProducto.IdAlmacen = seleccion.IdAlmacen
        objProducto.Eliminado = seleccion.Eliminado
        objetoActual = objProducto

    End Sub
End Class