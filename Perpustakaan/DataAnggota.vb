Imports MySql.Data.MySqlClient

Public Class DataAnggota

    Dim level As String

    Public Sub New(ByVal level As String)
        InitializeComponent()
        Me.level = level
    End Sub

    ' Ketika tombol Enter ditekan pada TextBox User
    Private Sub TextAnggota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextAnggota.KeyPress
        If e.KeyChar = Chr(13) Then
            TextNama.Focus()  ' Alihkan fokus ke TextBox Password
            e.Handled = True
        End If
    End Sub

    ' Ketika tombol Enter ditekan pada TextBox User
    Private Sub TextNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextNama.KeyPress
        If e.KeyChar = Chr(13) Then
            TextAlamat.Focus()  ' Alihkan fokus ke TextBox Password
            e.Handled = True
        End If
    End Sub

    ' Ketika tombol Enter ditekan pada TextBox User
    Private Sub TextAlamat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextAlamat.KeyPress
        If e.KeyChar = Chr(13) Then
            TextHp.Focus()  ' Alihkan fokus ke TextBox Password
            e.Handled = True
        End If
    End Sub

    ' Ketika tombol Enter ditekan pada TextBox User
    Private Sub TextHp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextHp.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            PerFormAnggota()
        End If
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        PerFormAnggota()
    End Sub
    Private Sub PerFormAnggota()
        ' Ambil nilai dari TextBox ke variabel
        Dim anggota As String = TextAnggota.Text
        Dim nama As String = TextNama.Text
        Dim alamat As String = TextAlamat.Text
        Dim hp As String = TextHp.Text

        ' Validasi apakah ada isian di TextBox
        If String.IsNullOrWhiteSpace(anggota) Or String.IsNullOrWhiteSpace(nama) Or String.IsNullOrWhiteSpace(alamat) Or String.IsNullOrWhiteSpace(hp) Then
            MessageBox.Show("Semua kolom harus diisi", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Tambahkan data ke database
        Dim query As String = "INSERT INTO anggota (id_anggota, nama_anggota, alamat, phone) VALUES (@id_anggota, @nama_anggota, @alamat, @phone)"
        Using cmd As New MySqlCommand(query, Koneksi)
            cmd.Parameters.AddWithValue("@id_anggota", anggota)
            cmd.Parameters.AddWithValue("@nama_anggota", nama)
            cmd.Parameters.AddWithValue("@alamat", alamat)
            cmd.Parameters.AddWithValue("@phone", hp)
            Konek()
            cmd.ExecuteNonQuery()
            Diskonek()
        End Using

        ' Kosongkan TextBox setelah data ditambahkan
        TextAnggota.Clear()
        TextNama.Clear()
        TextAlamat.Clear()
        TextHp.Clear()

        ' Panggil method untuk memuat ulang data
        LoadDataToDataGridView()

        ' Matikan kembali kontrol-kontrol
        DisableInputControls()
    End Sub

    Private Sub Data_Anggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Panggil method untuk memuat data saat Form dimuat
        LoadDataToDataGridView()
    End Sub

    ' ... (Kode yang sudah ada sebelumnya)

    ' Buat sebuah method untuk menampilkan data dari database ke DataGridView
    Private Sub LoadDataToDataGridView()
        ' Kosongkan DataGridView terlebih dahulu
        Data_Anggota.Rows.Clear()

        ' Tulis kueri SQL Anda untuk mengambil data dari database
        Dim query As String = "SELECT id_anggota, nama_anggota, alamat, phone FROM anggota"

        ' Buat MySqlCommand untuk menjalankan kueri
        Using cmd As New MySqlCommand(query, Koneksi)
            Konek()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Loop melalui hasil pembacaan dan tambahkan ke DataGridView
            While reader.Read()
                Dim anggota As String = reader("id_anggota").ToString()
                Dim nama As String = reader("nama_anggota").ToString()
                Dim alamat As String = reader("alamat").ToString()
                Dim hp As String = reader("phone").ToString()

                Data_Anggota.Rows.Add(anggota, nama, alamat, hp)
            End While

            Diskonek()
        End Using
    End Sub
    ' Tambahkan variabel global untuk menyimpan indeks baris terpilih.
    Dim selectedRowIndex As Integer = -1

    ' Method untuk memuat data saat Form dimuat
    Private Sub DataAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Panggil method untuk memuat data saat Form dimuat
        LoadDataToDataGridView()

        ' Matikan kontrol-kontrol yang akan dimatikan
        DisableInputControls()
    End Sub

    Private Sub Data_Anggota_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Data_Anggota.CellClick
        ' Ketika pengguna mengklik sel dalam DataGridView, ambil indeks baris terpilih.
        If e.RowIndex >= 0 Then
            selectedRowIndex = e.RowIndex

            ' Tampilkan data dari baris terpilih di TextBox
            TextAnggota.Text = Data_Anggota.Rows(selectedRowIndex).Cells(0).Value.ToString()
            TextNama.Text = Data_Anggota.Rows(selectedRowIndex).Cells(1).Value.ToString()
            TextAlamat.Text = Data_Anggota.Rows(selectedRowIndex).Cells(2).Value.ToString()
            TextHp.Text = Data_Anggota.Rows(selectedRowIndex).Cells(3).Value.ToString()
        End If
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        ' Validasi apakah baris terpilih
        If selectedRowIndex < 0 Then
            MessageBox.Show("Pilih baris yang ingin diubah", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Ambil data dari TextBox
        Dim anggota As String = TextAnggota.Text
        Dim nama As String = TextNama.Text
        Dim alamat As String = TextAlamat.Text
        Dim hp As String = TextHp.Text

        ' Validasi apakah ada isian di TextBox
        If String.IsNullOrWhiteSpace(nama) Or String.IsNullOrWhiteSpace(alamat) Or String.IsNullOrWhiteSpace(hp) Then
            MessageBox.Show("Semua kolom harus diisi", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Update data dalam DataGridView
        Data_Anggota.Rows(selectedRowIndex).Cells(0).Value = anggota
        Data_Anggota.Rows(selectedRowIndex).Cells(1).Value = nama
        Data_Anggota.Rows(selectedRowIndex).Cells(2).Value = alamat
        Data_Anggota.Rows(selectedRowIndex).Cells(3).Value = hp

        ' Update data dalam database
        Dim query As String = "UPDATE anggota SET id_anggota = @id_anggota, nama_anggota = @nama_anggota, alamat = @alamat, phone = @phone WHERE id_anggota = @id_anggota"
        Using cmd As New MySqlCommand(query, Koneksi)
            cmd.Parameters.AddWithValue("@id_anggota", anggota)
            cmd.Parameters.AddWithValue("@nama_anggota", nama)
            cmd.Parameters.AddWithValue("@alamat", alamat)
            cmd.Parameters.AddWithValue("@phone", hp)
            Konek()
            cmd.ExecuteNonQuery()
            Diskonek()
        End Using

        ' Kosongkan TextBox setelah data diubah
        TextAnggota.Clear()
        TextNama.Clear()
        TextAlamat.Clear()
        TextHp.Clear()

        ' Set selectedRowIndex kembali ke -1
        selectedRowIndex = -1

        ' Matikan kembali kontrol-kontrol
        DisableInputControls()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        ' Validasi apakah baris terpilih
        If selectedRowIndex < 0 Then
            MessageBox.Show("Pilih baris yang ingin dihapus", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Ambil ID anggota dari baris terpilih
        Dim anggota As String = TextAnggota.Text

        ' Hapus data dalam DataGridView
        Data_Anggota.Rows.RemoveAt(selectedRowIndex)

        ' Hapus data dalam database
        Dim query As String = "DELETE FROM anggota WHERE id_anggota = @id_anggota"
        Using cmd As New MySqlCommand(query, Koneksi)
            cmd.Parameters.AddWithValue("@id_anggota", anggota)
            Konek()
            cmd.ExecuteNonQuery()
            Diskonek()
        End Using

        ' Kosongkan TextBox setelah data dihapus
        TextAnggota.Clear()
        TextNama.Clear()
        TextAlamat.Clear()
        TextHp.Clear()

        ' Set selectedRowIndex kembali ke -1
        selectedRowIndex = -1

        ' Matikan kembali kontrol-kontrol
        DisableInputControls()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim formMenuUtama As New MenuUtama(level)
        formMenuUtama.Show()
        Me.Close()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        ' Mengizinkan pengguna untuk mengedit TextBox saat tombol "Tambah" ditekan
        EnableInputControls()
    End Sub

    Private Sub EnableInputControls()
        ' Mengaktifkan input controls
        TextAnggota.Enabled = True
        TextNama.Enabled = True
        TextAlamat.Enabled = True
        TextHp.Enabled = True

        ' Mengaktifkan tombol Simpan, Ubah, dan Hapus
        BtnSimpan.Enabled = True
        BtnUbah.Enabled = True
        BtnHapus.Enabled = True
    End Sub

    Private Sub DisableInputControls()
        ' Menonaktifkan input controls
        TextAnggota.Enabled = False
        TextNama.Enabled = False
        TextAlamat.Enabled = False
        TextHp.Enabled = False

        ' Menonaktifkan tombol Simpan, Ubah, dan Hapus
        BtnSimpan.Enabled = False
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
    End Sub
End Class