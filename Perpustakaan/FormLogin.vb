Imports MySql.Data.MySqlClient

Public Class FormLogin

    ' Ketika tombol Enter ditekan pada TextBox User
    Private Sub TextUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextUser.KeyPress
        If e.KeyChar = Chr(13) Then
            TextPass.Focus()  ' Alihkan fokus ke TextBox Password
            e.Handled = True
        End If
    End Sub

    Private Sub TextPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextPass.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            PerformLogin()
        End If
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        PerformLogin()
    End Sub

    Private Sub PerformLogin()
        Dim username As String = TextUser.Text

        Dim password As String = TextPass.Text

        ' Validasi apakah TextBox username dan password kosong
        If String.IsNullOrWhiteSpace(username) Or String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Username dan password tidak boleh kosong", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Lakukan validasi login di sini, Anda perlu memeriksa apakah pengguna dengan username dan password tertentu ada di database,
        ' dan juga periksa peran pengguna (admin atau petugas) dari ENUM "level".

        ' Misalnya, Anda dapat menggunakan perintah SQL untuk memeriksa pengguna:
        Dim query As String = "SELECT * FROM user WHERE username = @username AND password = @password"
        Using cmd As New MySqlCommand(query, Koneksi)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)
            Konek()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                ' Pengguna ditemukan dalam database, periksa peran pengguna
                Dim level As String = reader("level").ToString()

                ' Buka Form MenuUtama sesuai peran pengguna
                Dim menuUtama As New MenuUtama(level)
                menuUtama.Show()
                Me.Hide()

                ketemu = True ' Set variabel ketemu menjadi True karena login berhasil
            Else
                ketemu = False ' Set variabel ketemu menjadi False jika login gagal
                MessageBox.Show("Username atau password salah", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Diskonek()
        End Using
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Close()
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextPass.PasswordChar = "*"
    End Sub
End Class

