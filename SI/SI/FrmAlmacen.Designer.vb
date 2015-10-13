<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAlmacen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAlmacen))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.GuardarToolButton = New System.Windows.Forms.ToolStripButton()
        Me.EliminarToolButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.NombreTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DescripcionTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DireccionTxt = New System.Windows.Forms.TextBox()
        Me.DataGridViewAlmacen = New System.Windows.Forms.DataGridView()
        Me.Almacen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridViewAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolButton, Me.EliminarToolButton, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(516, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'GuardarToolButton
        '
        Me.GuardarToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.GuardarToolButton.Image = CType(resources.GetObject("GuardarToolButton.Image"), System.Drawing.Image)
        Me.GuardarToolButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GuardarToolButton.Name = "GuardarToolButton"
        Me.GuardarToolButton.Size = New System.Drawing.Size(53, 22)
        Me.GuardarToolButton.Text = "Guardar"
        '
        'EliminarToolButton
        '
        Me.EliminarToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EliminarToolButton.Image = CType(resources.GetObject("EliminarToolButton.Image"), System.Drawing.Image)
        Me.EliminarToolButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EliminarToolButton.Name = "EliminarToolButton"
        Me.EliminarToolButton.Size = New System.Drawing.Size(54, 22)
        Me.EliminarToolButton.Text = "Eliminar"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(57, 22)
        Me.ToolStripButton3.Text = "Cancelar"
        '
        'NombreTxt
        '
        Me.NombreTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NombreTxt.Location = New System.Drawing.Point(144, 42)
        Me.NombreTxt.Name = "NombreTxt"
        Me.NombreTxt.Size = New System.Drawing.Size(360, 20)
        Me.NombreTxt.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Descripción:"
        '
        'DescripcionTxt
        '
        Me.DescripcionTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescripcionTxt.Location = New System.Drawing.Point(144, 85)
        Me.DescripcionTxt.Multiline = True
        Me.DescripcionTxt.Name = "DescripcionTxt"
        Me.DescripcionTxt.Size = New System.Drawing.Size(360, 40)
        Me.DescripcionTxt.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Dirección:"
        '
        'DireccionTxt
        '
        Me.DireccionTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DireccionTxt.Location = New System.Drawing.Point(144, 148)
        Me.DireccionTxt.Multiline = True
        Me.DireccionTxt.Name = "DireccionTxt"
        Me.DireccionTxt.Size = New System.Drawing.Size(360, 40)
        Me.DireccionTxt.TabIndex = 6
        '
        'DataGridViewAlmacen
        '
        Me.DataGridViewAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAlmacen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Almacen, Me.Descripcion, Me.Direccion})
        Me.DataGridViewAlmacen.Location = New System.Drawing.Point(0, 205)
        Me.DataGridViewAlmacen.Name = "DataGridViewAlmacen"
        Me.DataGridViewAlmacen.ReadOnly = True
        Me.DataGridViewAlmacen.RowHeadersVisible = False
        Me.DataGridViewAlmacen.Size = New System.Drawing.Size(515, 102)
        Me.DataGridViewAlmacen.TabIndex = 7
        '
        'Almacen
        '
        Me.Almacen.DataPropertyName = "Nombre"
        Me.Almacen.HeaderText = "Almacen"
        Me.Almacen.Name = "Almacen"
        Me.Almacen.ReadOnly = True
        Me.Almacen.Width = 110
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 201
        '
        'Direccion
        '
        Me.Direccion.DataPropertyName = "Direccion"
        Me.Direccion.HeaderText = "Dirección"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        Me.Direccion.Width = 201
        '
        'FrmAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 319)
        Me.Controls.Add(Me.DataGridViewAlmacen)
        Me.Controls.Add(Me.DireccionTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DescripcionTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NombreTxt)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmAlmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Almacen"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridViewAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents GuardarToolButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents EliminarToolButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents NombreTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DescripcionTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DireccionTxt As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewAlmacen As System.Windows.Forms.DataGridView
    Friend WithEvents Almacen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
