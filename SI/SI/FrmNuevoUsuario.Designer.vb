<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevoUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNuevoUsuario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UsuarioTxt = New System.Windows.Forms.TextBox()
        Me.ContrasenaTxt = New System.Windows.Forms.TextBox()
        Me.ReptrContrasenaTxt = New System.Windows.Forms.TextBox()
        Me.RespuestaTxt = New System.Windows.Forms.TextBox()
        Me.PreguntaComboBox = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.GuardarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CancelarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Establecer Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Repita su Contraseña:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Seleccione una pregunta:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Escriba su Respuesta:"
        '
        'UsuarioTxt
        '
        Me.UsuarioTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UsuarioTxt.Location = New System.Drawing.Point(192, 38)
        Me.UsuarioTxt.Name = "UsuarioTxt"
        Me.UsuarioTxt.Size = New System.Drawing.Size(174, 20)
        Me.UsuarioTxt.TabIndex = 5
        '
        'ContrasenaTxt
        '
        Me.ContrasenaTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContrasenaTxt.Location = New System.Drawing.Point(192, 70)
        Me.ContrasenaTxt.Name = "ContrasenaTxt"
        Me.ContrasenaTxt.Size = New System.Drawing.Size(174, 20)
        Me.ContrasenaTxt.TabIndex = 6
        '
        'ReptrContrasenaTxt
        '
        Me.ReptrContrasenaTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReptrContrasenaTxt.Location = New System.Drawing.Point(192, 134)
        Me.ReptrContrasenaTxt.Name = "ReptrContrasenaTxt"
        Me.ReptrContrasenaTxt.Size = New System.Drawing.Size(174, 20)
        Me.ReptrContrasenaTxt.TabIndex = 7
        '
        'RespuestaTxt
        '
        Me.RespuestaTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RespuestaTxt.Location = New System.Drawing.Point(28, 257)
        Me.RespuestaTxt.Name = "RespuestaTxt"
        Me.RespuestaTxt.Size = New System.Drawing.Size(338, 20)
        Me.RespuestaTxt.TabIndex = 8
        '
        'PreguntaComboBox
        '
        Me.PreguntaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PreguntaComboBox.FormattingEnabled = True
        Me.PreguntaComboBox.Location = New System.Drawing.Point(28, 200)
        Me.PreguntaComboBox.Name = "PreguntaComboBox"
        Me.PreguntaComboBox.Size = New System.Drawing.Size(338, 21)
        Me.PreguntaComboBox.TabIndex = 9
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripButton, Me.CancelarToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(400, 25)
        Me.ToolStrip1.TabIndex = 10
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
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(192, 96)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(174, 19)
        Me.ProgressBar1.TabIndex = 11
        Me.ProgressBar1.Visible = False
        '
        'FrmNuevoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 286)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.PreguntaComboBox)
        Me.Controls.Add(Me.RespuestaTxt)
        Me.Controls.Add(Me.ReptrContrasenaTxt)
        Me.Controls.Add(Me.ContrasenaTxt)
        Me.Controls.Add(Me.UsuarioTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmNuevoUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Validar Nuevo Usuario"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents UsuarioTxt As System.Windows.Forms.TextBox
    Friend WithEvents ContrasenaTxt As System.Windows.Forms.TextBox
    Friend WithEvents ReptrContrasenaTxt As System.Windows.Forms.TextBox
    Friend WithEvents RespuestaTxt As System.Windows.Forms.TextBox
    Friend WithEvents PreguntaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents GuardarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CancelarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
