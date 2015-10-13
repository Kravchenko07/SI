<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPermisologia
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SinPermisoListBox = New System.Windows.Forms.ListBox()
        Me.ConPermisoListBox = New System.Windows.Forms.ListBox()
        Me.RolComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rol:"
        '
        'SinPermisoListBox
        '
        Me.SinPermisoListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SinPermisoListBox.FormattingEnabled = True
        Me.SinPermisoListBox.Location = New System.Drawing.Point(12, 41)
        Me.SinPermisoListBox.Name = "SinPermisoListBox"
        Me.SinPermisoListBox.Size = New System.Drawing.Size(209, 223)
        Me.SinPermisoListBox.TabIndex = 2
        '
        'ConPermisoListBox
        '
        Me.ConPermisoListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ConPermisoListBox.FormattingEnabled = True
        Me.ConPermisoListBox.Location = New System.Drawing.Point(281, 41)
        Me.ConPermisoListBox.Name = "ConPermisoListBox"
        Me.ConPermisoListBox.Size = New System.Drawing.Size(201, 223)
        Me.ConPermisoListBox.TabIndex = 3
        '
        'RolComboBox
        '
        Me.RolComboBox.CausesValidation = False
        Me.RolComboBox.FormattingEnabled = True
        Me.RolComboBox.Location = New System.Drawing.Point(56, 12)
        Me.RolComboBox.Name = "RolComboBox"
        Me.RolComboBox.Size = New System.Drawing.Size(426, 21)
        Me.RolComboBox.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(227, 100)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 28)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = ">>"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(227, 164)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 28)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "<<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmPermisologia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 277)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RolComboBox)
        Me.Controls.Add(Me.ConPermisoListBox)
        Me.Controls.Add(Me.SinPermisoListBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmPermisologia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configurar Permisos Por Rol"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SinPermisoListBox As System.Windows.Forms.ListBox
    Friend WithEvents ConPermisoListBox As System.Windows.Forms.ListBox
    Friend WithEvents RolComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
