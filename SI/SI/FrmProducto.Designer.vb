<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProducto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProducto))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.GuardarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CancelarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SalirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CodigoTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NombreTxt = New System.Windows.Forms.TextBox()
        Me.DescripcionTxt = New System.Windows.Forms.TextBox()
        Me.StockTxt = New System.Windows.Forms.TextBox()
        Me.StockMinTxt = New System.Windows.Forms.TextBox()
        Me.ComboBoxAlmacen = New System.Windows.Forms.ComboBox()
        Me.GridViewProducto = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockMin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Almacen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridViewProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripButton, Me.CancelarToolStripButton, Me.SalirToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(475, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'GuardarToolStripButton
        '
        Me.GuardarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.GuardarToolStripButton.Image = CType(resources.GetObject("GuardarToolStripButton.Image"), System.Drawing.Image)
        Me.GuardarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GuardarToolStripButton.Name = "GuardarToolStripButton"
        Me.GuardarToolStripButton.Size = New System.Drawing.Size(53, 22)
        Me.GuardarToolStripButton.Text = "Guardar"
        '
        'CancelarToolStripButton
        '
        Me.CancelarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CancelarToolStripButton.Image = CType(resources.GetObject("CancelarToolStripButton.Image"), System.Drawing.Image)
        Me.CancelarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelarToolStripButton.Name = "CancelarToolStripButton"
        Me.CancelarToolStripButton.Size = New System.Drawing.Size(57, 22)
        Me.CancelarToolStripButton.Text = "Cancelar"
        '
        'SalirToolStripButton
        '
        Me.SalirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SalirToolStripButton.Image = CType(resources.GetObject("SalirToolStripButton.Image"), System.Drawing.Image)
        Me.SalirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SalirToolStripButton.Name = "SalirToolStripButton"
        Me.SalirToolStripButton.Size = New System.Drawing.Size(33, 22)
        Me.SalirToolStripButton.Text = "Salir"
        '
        'CodigoTxt
        '
        Me.CodigoTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CodigoTxt.Location = New System.Drawing.Point(106, 45)
        Me.CodigoTxt.Name = "CodigoTxt"
        Me.CodigoTxt.Size = New System.Drawing.Size(100, 20)
        Me.CodigoTxt.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Codigo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(244, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripción:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Stock:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(244, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Stock Minimo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Almacen:"
        '
        'NombreTxt
        '
        Me.NombreTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NombreTxt.Location = New System.Drawing.Point(316, 45)
        Me.NombreTxt.Name = "NombreTxt"
        Me.NombreTxt.Size = New System.Drawing.Size(123, 20)
        Me.NombreTxt.TabIndex = 8
        '
        'DescripcionTxt
        '
        Me.DescripcionTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescripcionTxt.Location = New System.Drawing.Point(106, 91)
        Me.DescripcionTxt.Multiline = True
        Me.DescripcionTxt.Name = "DescripcionTxt"
        Me.DescripcionTxt.Size = New System.Drawing.Size(333, 40)
        Me.DescripcionTxt.TabIndex = 9
        '
        'StockTxt
        '
        Me.StockTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StockTxt.Location = New System.Drawing.Point(106, 156)
        Me.StockTxt.Name = "StockTxt"
        Me.StockTxt.Size = New System.Drawing.Size(108, 20)
        Me.StockTxt.TabIndex = 10
        '
        'StockMinTxt
        '
        Me.StockMinTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StockMinTxt.Location = New System.Drawing.Point(316, 157)
        Me.StockMinTxt.Name = "StockMinTxt"
        Me.StockMinTxt.Size = New System.Drawing.Size(123, 20)
        Me.StockMinTxt.TabIndex = 11
        '
        'ComboBoxAlmacen
        '
        Me.ComboBoxAlmacen.FormattingEnabled = True
        Me.ComboBoxAlmacen.Location = New System.Drawing.Point(106, 205)
        Me.ComboBoxAlmacen.Name = "ComboBoxAlmacen"
        Me.ComboBoxAlmacen.Size = New System.Drawing.Size(333, 21)
        Me.ComboBoxAlmacen.TabIndex = 12
        '
        'GridViewProducto
        '
        Me.GridViewProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridViewProducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Nombre, Me.Stock, Me.StockMin, Me.Almacen})
        Me.GridViewProducto.Location = New System.Drawing.Point(0, 244)
        Me.GridViewProducto.Name = "GridViewProducto"
        Me.GridViewProducto.ReadOnly = True
        Me.GridViewProducto.RowHeadersVisible = False
        Me.GridViewProducto.Size = New System.Drawing.Size(475, 163)
        Me.GridViewProducto.TabIndex = 13
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 80
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Expr3"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Stock
        '
        Me.Stock.DataPropertyName = "Stock"
        Me.Stock.HeaderText = "Stock"
        Me.Stock.Name = "Stock"
        Me.Stock.ReadOnly = True
        Me.Stock.Width = 70
        '
        'StockMin
        '
        Me.StockMin.DataPropertyName = "StockMin"
        Me.StockMin.HeaderText = "StockMin"
        Me.StockMin.Name = "StockMin"
        Me.StockMin.ReadOnly = True
        Me.StockMin.Width = 70
        '
        'Almacen
        '
        Me.Almacen.DataPropertyName = "Nombre"
        Me.Almacen.HeaderText = "Almacen"
        Me.Almacen.Name = "Almacen"
        Me.Almacen.ReadOnly = True
        Me.Almacen.Width = 152
        '
        'FrmProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 408)
        Me.Controls.Add(Me.GridViewProducto)
        Me.Controls.Add(Me.ComboBoxAlmacen)
        Me.Controls.Add(Me.StockMinTxt)
        Me.Controls.Add(Me.StockTxt)
        Me.Controls.Add(Me.DescripcionTxt)
        Me.Controls.Add(Me.NombreTxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CodigoTxt)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Producto"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridViewProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents GuardarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CancelarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SalirToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CodigoTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NombreTxt As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTxt As System.Windows.Forms.TextBox
    Friend WithEvents StockTxt As System.Windows.Forms.TextBox
    Friend WithEvents StockMinTxt As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents GridViewProducto As System.Windows.Forms.DataGridView
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockMin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Almacen As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
