<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuario))
        Me.NombreTxt = New System.Windows.Forms.TextBox()
        Me.UsuarioTxt = New System.Windows.Forms.TextBox()
        Me.NameLbl = New System.Windows.Forms.Label()
        Me.UsernameLbl = New System.Windows.Forms.Label()
        Me.RolCombBox = New System.Windows.Forms.ComboBox()
        Me.RolLbl = New System.Windows.Forms.Label()
        Me.EstadoLbl = New System.Windows.Forms.Label()
        Me.EstadoCheckBox = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.GuardarToolButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.EliminarToolButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CancelarToolButton = New System.Windows.Forms.ToolStripButton()
        Me.GridViewUsuario = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usurio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridViewUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreTxt
        '
        Me.NombreTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NombreTxt.Location = New System.Drawing.Point(73, 45)
        Me.NombreTxt.Name = "NombreTxt"
        Me.NombreTxt.Size = New System.Drawing.Size(165, 20)
        Me.NombreTxt.TabIndex = 0
        '
        'UsuarioTxt
        '
        Me.UsuarioTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UsuarioTxt.Location = New System.Drawing.Point(306, 43)
        Me.UsuarioTxt.Name = "UsuarioTxt"
        Me.UsuarioTxt.Size = New System.Drawing.Size(144, 20)
        Me.UsuarioTxt.TabIndex = 1
        '
        'NameLbl
        '
        Me.NameLbl.AutoSize = True
        Me.NameLbl.Location = New System.Drawing.Point(23, 50)
        Me.NameLbl.Name = "NameLbl"
        Me.NameLbl.Size = New System.Drawing.Size(44, 13)
        Me.NameLbl.TabIndex = 2
        Me.NameLbl.Text = "Nombre"
        '
        'UsernameLbl
        '
        Me.UsernameLbl.AutoSize = True
        Me.UsernameLbl.Location = New System.Drawing.Point(257, 48)
        Me.UsernameLbl.Name = "UsernameLbl"
        Me.UsernameLbl.Size = New System.Drawing.Size(43, 13)
        Me.UsernameLbl.TabIndex = 3
        Me.UsernameLbl.Text = "Usuario"
        '
        'RolCombBox
        '
        Me.RolCombBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RolCombBox.FormattingEnabled = True
        Me.RolCombBox.Location = New System.Drawing.Point(73, 84)
        Me.RolCombBox.Name = "RolCombBox"
        Me.RolCombBox.Size = New System.Drawing.Size(165, 21)
        Me.RolCombBox.TabIndex = 4
        '
        'RolLbl
        '
        Me.RolLbl.AutoSize = True
        Me.RolLbl.Location = New System.Drawing.Point(23, 89)
        Me.RolLbl.Name = "RolLbl"
        Me.RolLbl.Size = New System.Drawing.Size(23, 13)
        Me.RolLbl.TabIndex = 5
        Me.RolLbl.Text = "Rol"
        '
        'EstadoLbl
        '
        Me.EstadoLbl.AutoSize = True
        Me.EstadoLbl.Location = New System.Drawing.Point(257, 89)
        Me.EstadoLbl.Name = "EstadoLbl"
        Me.EstadoLbl.Size = New System.Drawing.Size(40, 13)
        Me.EstadoLbl.TabIndex = 7
        Me.EstadoLbl.Text = "Estado"
        '
        'EstadoCheckBox
        '
        Me.EstadoCheckBox.AutoSize = True
        Me.EstadoCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EstadoCheckBox.Location = New System.Drawing.Point(325, 88)
        Me.EstadoCheckBox.Name = "EstadoCheckBox"
        Me.EstadoCheckBox.Size = New System.Drawing.Size(54, 17)
        Me.EstadoCheckBox.TabIndex = 8
        Me.EstadoCheckBox.Text = "Activo"
        Me.EstadoCheckBox.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolButton, Me.ToolStripSeparator3, Me.EliminarToolButton, Me.ToolStripSeparator2, Me.CancelarToolButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(462, 25)
        Me.ToolStrip1.TabIndex = 9
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CancelarToolButton
        '
        Me.CancelarToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CancelarToolButton.Image = CType(resources.GetObject("CancelarToolButton.Image"), System.Drawing.Image)
        Me.CancelarToolButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelarToolButton.Name = "CancelarToolButton"
        Me.CancelarToolButton.Size = New System.Drawing.Size(57, 22)
        Me.CancelarToolButton.Text = "Cancelar"
        '
        'GridViewUsuario
        '
        Me.GridViewUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridViewUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Usurio, Me.Rol})
        Me.GridViewUsuario.Location = New System.Drawing.Point(0, 122)
        Me.GridViewUsuario.MultiSelect = False
        Me.GridViewUsuario.Name = "GridViewUsuario"
        Me.GridViewUsuario.ReadOnly = True
        Me.GridViewUsuario.RowHeadersVisible = False
        Me.GridViewUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridViewUsuario.Size = New System.Drawing.Size(462, 166)
        Me.GridViewUsuario.TabIndex = 10
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.FillWeight = 7.751938!
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 160
        '
        'Usurio
        '
        Me.Usurio.DataPropertyName = "Username"
        Me.Usurio.HeaderText = "Usuario"
        Me.Usurio.Name = "Usurio"
        Me.Usurio.ReadOnly = True
        Me.Usurio.Width = 160
        '
        'Rol
        '
        Me.Rol.DataPropertyName = "Description"
        Me.Rol.FillWeight = 192.2481!
        Me.Rol.HeaderText = "Rol"
        Me.Rol.Name = "Rol"
        Me.Rol.ReadOnly = True
        Me.Rol.Width = 138
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 288)
        Me.Controls.Add(Me.GridViewUsuario)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.EstadoCheckBox)
        Me.Controls.Add(Me.EstadoLbl)
        Me.Controls.Add(Me.RolLbl)
        Me.Controls.Add(Me.RolCombBox)
        Me.Controls.Add(Me.UsernameLbl)
        Me.Controls.Add(Me.NameLbl)
        Me.Controls.Add(Me.UsuarioTxt)
        Me.Controls.Add(Me.NombreTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridViewUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NombreTxt As System.Windows.Forms.TextBox
    Friend WithEvents UsuarioTxt As System.Windows.Forms.TextBox
    Friend WithEvents NameLbl As System.Windows.Forms.Label
    Friend WithEvents UsernameLbl As System.Windows.Forms.Label
    Friend WithEvents RolCombBox As System.Windows.Forms.ComboBox
    Friend WithEvents RolLbl As System.Windows.Forms.Label
    Friend WithEvents EstadoCombBox As System.Windows.Forms.ComboBox
    Friend WithEvents EstadoLbl As System.Windows.Forms.Label
    Friend WithEvents EstadoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents GuardarToolButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents EliminarToolButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CancelarToolButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GridViewUsuario As System.Windows.Forms.DataGridView
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Usurio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rol As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
