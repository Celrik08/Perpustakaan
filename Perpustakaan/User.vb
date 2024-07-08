Imports MySql.Data.MySqlClient

Public Class DataUser

    ' Deklarasikan variabel selectedRowIndex di tingkat kelas.
    Private selectedRowIndex As Integer = -1

    Dim level1 As String

    Public Sub New(ByVal level As String)
        InitializeComponent()
        Me.level1 = level
    End Sub

    ' Ketika tombol Enter ditekan pada TextBox User
    Private Sub TextUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextUser.KeyPress
        If e.KeyChar = Chr(13) Then
            TextPass.Focus()  ' Alihkan fokus ke TextBox Password
            e.Handled = True
        End If
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        ' Ambil nilai dari TextBox dan ComboBox
        Dim username As String = TextUser.Text
        Dim password As String = TextPass.Text
        Dim level As String = ComboLevel.SelectedItem.ToString()

        ' Tambahkan data ke database
        Dim query As String = "INSERT INTO user (username, password, level) VALUES (@username, @password, @level)"
        Using cmd As New MySqlCommand(query, Koneksi)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)
            cmd.Parameters.AddWithValue("@level", level)

            Konek()
            cmd.ExecuteNonQuery()
            Diskonek()
        End Using

        ' Tambahkan data ke DataGridView
        Data_User.Rows.Add(username, password, level)

        ' Reset nilai TextBox dan ComboBox
        TextUser.Clear()
        TextPass.Clear()
        ComboLevel.SelectedIndex = -1 ' Atau sesuaikan dengan pilihan default jika ada

        ' Memuat ulang data dari database ke DataGridView
        LoadDataToDataGridView()

        ' Matikan kembali kontrol-kontrol
        DisableInputControls()
    End Sub

    Private Sub DataUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Panggil method untuk memuat data saat Form dimuat
        LoadDataToDataGridView()

        ' Matikan kontrol-kontrol yang akan dimatikan
        DisableInputControls()
    End Sub

    Private Sub LoadDataToDataGridView()
        ' Bersihkan DataGridView
        Data_User.Rows.Clear()

        ' Kueri untuk mengambil data dari tabel user
        Dim query As String = "SELECT username, password, level FROM user"

        Using cmd As New MySqlCommand(query, Koneksi)
            Konek()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Loop melalui hasil pembacaan dan tambahkan ke DataGridView
            While reader.Read()
                Dim username As String = reader("username").ToString()
                Dim password As String = reader("password").ToString()
                Dim level As String = reader("level").ToString()

                Data_User.Rows.Add(username, password, level)
            End While

            Diskonek()
        End Using
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        ' Validasi apakah baris terpilih
        If selectedRowIndex < 0 Then
            MessageBox.Show("Pilih baris yang ingin diubah", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Ambil nilai dari TextBox dan ComboBox
        Dim username As String = TextUser.Text
        Dim password As String = TextPass.Text
        Dim level As String = ComboLevel.SelectedItem.ToString()

        ' Validasi apakah ada isian di TextBox dan ComboBox
        If String.IsNullOrWhiteSpace(username) Or String.IsNullOrWhiteSpace(password) Or String.IsNullOrWhiteSpace(level) Then
            MessageBox.Show("Semua kolom harus diisi", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Update data dalam DataGridView
        Data_User.Rows(selectedRowIndex).Cells(0).Value = username
        Data_User.Rows(selectedRowIndex).Cells(1).Value = password
        Data_User.Rows(selectedRowIndex).Cells(2).Value = level

        ' Update data dalam database
        Dim query As String = "UPDATE user SET username = @username, password = @password, level = @level WHERE username = @username"
        Using cmd As New MySqlCommand(query, Koneksi)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)
            cmd.Parameters.AddWithValue("@level", level)
            Konek()
            cmd.ExecuteNonQuery()
            Diskonek()
        End Using

        ' Reset nilai TextBox dan ComboBox
        TextUser.Clear()
        TextPass.Clear()
        ComboLevel.SelectedIndex = -1

        ' Set selectedRowIndex kembali ke -1
        selectedRowIndex = -1

        ' Matikan kembali kontrol-kontrol
        DisableInputControls()
    End Sub

    Private Sub Data_User_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Data_User.CellDoubleClick
        Dim Rows As DataGridViewRow = Data_User.Rows(e.RowIndex)
        If Not IsNothing(Rows) Then
            selectedRowIndex = e.RowIndex
            TextUser.Text = Rows.Cells(0).Value
            TextPass.Text = Rows.Cells(1).Value
            ComboLevel.Text = Rows.Cells(2).Value
        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        ' Pastikan ada baris terpilih di Data_User
        If selectedRowIndex < 0 Then
            MessageBox.Show("Pilih baris yang ingin dihapus", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Ambil nilai dari TextBox
        Dim username As String = TextUser.Text

        ' Tampilkan konfirmasi kepada pengguna sebelum menghapus
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Hapus data dari Data_User (DataGridView)
            Data_User.Rows.RemoveAt(selectedRowIndex)

            ' Hapus data dari database user
            Dim queryUser As String = "DELETE FROM user WHERE username = @username"
            Using cmd As New MySqlCommand(queryUser, Koneksi)
                cmd.Parameters.AddWithValue("@username", username)

                Konek()
                cmd.ExecuteNonQuery()
                Diskonek()
            End Using

            ' Reset nilai TextBox
            TextUser.Clear()
            TextPass.Clear()
            ComboLevel.Text = "" ' Atau sesuaikan dengan nilai default yang sesuai

            ' Set selectedRowIndex kembali ke -1
            selectedRowIndex = -1

            ' Matikan kembali kontrol-kontrol
            DisableInputControls()
        End If
    End Sub

    Private Sub BtnTambah_Click_1(sender As Object, e As EventArgs) Handles BtnTambah.Click
        ' Mengizinkan pengguna untuk mengedit TextBox saat tombol "Tambah" ditekan
        EnableInputControls()
    End Sub

    Private Sub EnableInputControls()
        ' Mengaktifkan input controls
        TextUser.Enabled = True
        TextPass.Enabled = True
        ComboLevel.Enabled = True

        ' Mengaktifkan tombol Simpan, Ubah, dan Hapus
        BtnSimpan.Enabled = True
        BtnUbah.Enabled = True
        BtnHapus.Enabled = True
    End Sub

    Private Sub DisableInputControls()
        ' Mengaktifkan input controls
        TextUser.Enabled = False
        TextPass.Enabled = False
        ComboLevel.Enabled = False

        ' Menonaktifkan tombol Simpan, Ubah, dan Hapus
        BtnSimpan.Enabled = False
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim formMenuUtama As New MenuUtama(level1)
        formMenuUtama.Show()
        Me.Close()
    End Sub
End Class