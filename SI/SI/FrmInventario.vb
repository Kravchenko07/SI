Imports System.Windows.Forms

Public Class FrmInventario

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Dim FrmUsuario As New FrmUsuario
        FrmUsuario.MdiParent = Me
        FrmUsuario.Show()
    End Sub

    Private Sub PermisologíaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermisologíaToolStripMenuItem.Click
        Dim FrmPermisologia As New FrmPermisologia
        FrmPermisologia.MdiParent = Me
        FrmPermisologia.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If (MessageBox.Show("Desea Salir del Sistema", "Alerta", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub FrmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is MdiClient Then
                ctl.BackColor = Me.BackColor
            End If
        Next
    End Sub

    Private Sub AlmacenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlmacenToolStripMenuItem.Click
        Dim FrmAlmacen As New FrmAlmacen
        FrmAlmacen.MdiParent = Me
        FrmAlmacen.Show()
    End Sub

    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click
        Dim FrmProducto As New FrmProducto
        FrmProducto.MdiParent = Me
        FrmProducto.Show()
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        Dim FrmCliente As New FrmCliente
        FrmCliente.MdiParent = Me
        FrmCliente.Show()
    End Sub
End Class
