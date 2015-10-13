Public Class Login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If (UsernameTextBox.Text.Trim = "" And PasswordTextBox.Text.Trim = "") Then
            MsgBox("Debe igresar los datos de Usuario")
            Return
        ElseIf (UsernameTextBox.Text.Trim = "") Then
            MsgBox("Debe igresar un Usuario")
            Return
        ElseIf (PasswordTextBox.Text.Trim = "") Then
            MsgBox("Debe igresar una contraseña")
            Return
        End If

        Validar_Usuario()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Validar_Usuario()
        Dim User = Base_De_Datos.Base_De_Datos.Login(UsernameTextBox.Text.ToString(), PasswordTextBox.Text.ToString())
        If (User IsNot Nothing) Then
            If (User.Activo) Then
                Configuracion.Usuario_Activo = User
                Dim Contenedor As New FrmInventario()
                Contenedor.Show()
                Me.Visible = False
            Else
                MsgBox("Usuario Inactivo")
            End If
        Else
            MsgBox("Usuario Incorrecto")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FrmNuevoUsuario.Show()
    End Sub
End Class
