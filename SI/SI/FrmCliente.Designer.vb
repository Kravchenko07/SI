<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCliente))
        Me.NombreTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ApellidoTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CedulaTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EmailTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TlfLocTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TlfMovTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DireccionTxt = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.GridViewCliente = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TlfLocal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TlfMovil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridViewCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreTxt
        '
        Me.NombreTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NombreTxt.Location = New System.Drawing.Point(106, 40)
        Me.NombreTxt.Name = "NombreTxt"
        Me.NombreTxt.Size = New System.Drawing.Size(148, 20)
        Me.NombreTxt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(279, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apellido:"
        '
        'ApellidoTxt
        '
        Me.ApellidoTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ApellidoTxt.Location = New System.Drawing.Point(341, 40)
        Me.ApellidoTxt.Name = "ApellidoTxt"
        Me.ApellidoTxt.Size = New System.Drawing.Size(148, 20)
        Me.ApellidoTxt.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cedula:"
        '
        'CedulaTxt
        '
        Me.CedulaTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CedulaTxt.Location = New System.Drawing.Point(106, 81)
        Me.CedulaTxt.Name = "CedulaTxt"
        Me.CedulaTxt.Size = New System.Drawing.Size(148, 20)
        Me.CedulaTxt.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(279, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Email:"
        '
        'EmailTxt
        '
        Me.EmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmailTxt.Location = New System.Drawing.Point(341, 84)
        Me.EmailTxt.Name = "EmailTxt"
        Me.EmailTxt.Size = New System.Drawing.Size(148, 20)
        Me.EmailTxt.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tlf Local:"
        '
        'TlfLocTxt
        '
        Me.TlfLocTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TlfLocTxt.Location = New System.Drawing.Point(106, 127)
        Me.TlfLocTxt.Name = "TlfLocTxt"
        Me.TlfLocTxt.Size = New System.Drawing.Size(148, 20)
        Me.TlfLocTxt.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(279, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tlf Movil:"
        '
        'TlfMovTxt
        '
        Me.TlfMovTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TlfMovTxt.Location = New System.Drawing.Point(341, 127)
        Me.TlfMovTxt.Name = "TlfMovTxt"
        Me.TlfMovTxt.Size = New System.Drawing.Size(148, 20)
        Me.TlfMovTxt.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(43, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Dirección:"
        '
        'DireccionTxt
        '
        Me.DireccionTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DireccionTxt.Location = New System.Drawing.Point(106, 165)
        Me.DireccionTxt.Multiline = True
        Me.DireccionTxt.Name = "DireccionTxt"
        Me.DireccionTxt.Size = New System.Drawing.Size(383, 53)
        Me.DireccionTxt.TabIndex = 14
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(531, 25)
        Me.ToolStrip1.TabIndex = 15
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripButton1.Text = "Guardar"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(54, 22)
        Me.ToolStripButton2.Text = "Eliminar"
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
        'GridViewCliente
        '
        Me.GridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridViewCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Cedula, Me.Email, Me.TlfLocal, Me.TlfMovil})
        Me.GridViewCliente.Location = New System.Drawing.Point(0, 235)
        Me.GridViewCliente.Name = "GridViewCliente"
        Me.GridViewCliente.ReadOnly = True
        Me.GridViewCliente.RowHeadersVisible = False
        Me.GridViewCliente.Size = New System.Drawing.Size(531, 159)
        Me.GridViewCliente.TabIndex = 16
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "NombreCompleto"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 128
        '
        'Cedula
        '
        Me.Cedula.DataPropertyName = "Cedula"
        Me.Cedula.HeaderText = "Cedula"
        Me.Cedula.Name = "Cedula"
        Me.Cedula.ReadOnly = True
        '
        'Email
        '
        Me.Email.DataPropertyName = "Email"
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        '
        'TlfLocal
        '
        Me.TlfLocal.DataPropertyName = "Tlf_Local"
        Me.TlfLocal.HeaderText = "TlfLocal"
        Me.TlfLocal.Name = "TlfLocal"
        Me.TlfLocal.ReadOnly = True
        '
        'TlfMovil
        '
        Me.TlfMovil.DataPropertyName = "Tlf_Movil"
        Me.TlfMovil.HeaderText = "TlfMovil"
        Me.TlfMovil.Name = "TlfMovil"
        Me.TlfMovil.ReadOnly = True
        '
        'FrmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 395)
        Me.Controls.Add(Me.GridViewCliente)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DireccionTxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TlfMovTxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TlfLocTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.EmailTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CedulaTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ApellidoTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NombreTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliente"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridViewCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NombreTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ApellidoTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CedulaTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents EmailTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TlfLocTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TlfMovTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DireccionTxt As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridViewCliente As System.Windows.Forms.DataGridView
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TlfLocal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TlfMovil As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
