<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscar
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
        Me.BuscarGridView = New System.Windows.Forms.DataGridView()
        Me.BuscarLblGrid = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BuscarBtnGrid = New System.Windows.Forms.Button()
        CType(Me.BuscarGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BuscarGridView
        '
        Me.BuscarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BuscarGridView.Location = New System.Drawing.Point(0, 36)
        Me.BuscarGridView.Name = "BuscarGridView"
        Me.BuscarGridView.Size = New System.Drawing.Size(503, 227)
        Me.BuscarGridView.TabIndex = 0
        '
        'BuscarLblGrid
        '
        Me.BuscarLblGrid.AutoSize = True
        Me.BuscarLblGrid.Location = New System.Drawing.Point(13, 13)
        Me.BuscarLblGrid.Name = "BuscarLblGrid"
        Me.BuscarLblGrid.Size = New System.Drawing.Size(62, 13)
        Me.BuscarLblGrid.TabIndex = 1
        Me.BuscarLblGrid.Text = "Buscar Por:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(87, 7)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(232, 7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(154, 20)
        Me.TextBox1.TabIndex = 3
        '
        'BuscarBtnGrid
        '
        Me.BuscarBtnGrid.Location = New System.Drawing.Point(405, 7)
        Me.BuscarBtnGrid.Name = "BuscarBtnGrid"
        Me.BuscarBtnGrid.Size = New System.Drawing.Size(75, 23)
        Me.BuscarBtnGrid.TabIndex = 4
        Me.BuscarBtnGrid.Text = "Buscar"
        Me.BuscarBtnGrid.UseVisualStyleBackColor = True
        '
        'FrmBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 262)
        Me.Controls.Add(Me.BuscarBtnGrid)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.BuscarLblGrid)
        Me.Controls.Add(Me.BuscarGridView)
        Me.Name = "FrmBuscar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBuscar"
        CType(Me.BuscarGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BuscarGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BuscarLblGrid As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BuscarBtnGrid As System.Windows.Forms.Button
End Class
