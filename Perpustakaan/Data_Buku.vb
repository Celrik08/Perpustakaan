Imports MySql.Data.MySqlClient

Public Class DataBuku

    Dim level As String

    Public Sub New(ByVal level As String)
        InitializeComponent()
        Me.level = level
    End Sub

    ' Ketika tombol Enter ditekan pada TextBox User
    Private Sub TextBuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBuku.KeyPress
        If e.KeyChar = Chr(13) Then
            TextJudul.Focus()  ' Alihkan fokus ke TextBox Password
            e.Handled = True
        End If
    End Sub

    ' Ketika tombol Enter ditekan pada TextBox User
    Private Sub TextJudul_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextJudul.KeyPress
        If e.KeyChar = Chr(13) Then
            TextTahun.Focus()  ' Alihkan fokus ke TextBox Password
            e.Handled = True
        End If
    End Sub

    ' Ketika tombol Enter ditekan pada TextBox User
    Private Sub TextTahun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextTahun.KeyPress
        If e.KeyChar = Chr(13) Then
            TextPenerbit.Focus()  ' Alihkan fokus ke TextBox Password
            e.Handled = True
        End If
    End Sub

    ' Ketika tombol Enter ditekan pada TextBox User
    Private Sub TextPenerbit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextPenerbit.KeyPress
        If e.KeyChar = Chr(13) Then
            TextPenulis.Focus()  ' Alihkan fokus ke TextBox Password
            e.Handled = True
        End If
    End Sub

    ' Ketika tombol Enter ditekan pada TextBox User
    Private Sub TextPenulis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextPenulis.KeyPress
        If e.KeyChar = Chr(13) Then
            TextStock.Focus()  ' Alihkan fokus ke TextBox Password
            e.Handled = True
        End If
    End Sub

    ' Ketika tombol Enter ditekan pada TextBox User
    Private Sub TextStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextStock.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            PerformBuku()
        End If
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        PerformBuku()
    End Sub

    Private Sub PerformBuku()
        ' Ambil nilai dari TextBox ke variabel
        Dim buku As String = TextBuku.Text
        Dim judul As String = TextJudul.Text
        Dim tahun As String = TextTahun.Text
        Dim penerbit As String = TextPenerbit.Text
        Dim penulis As String = TextPenulis.Text
        Dim stock As String = TextStock.Text

        ' Validasi apakah ada isian di TextBox
        If String.IsNullOrWhiteSpace(buku) Or String.IsNullOrWhiteSpace(judul) Or String.IsNullOrWhiteSpace(tahun) Or String.IsNullOrWhiteSpace(penerbit) Or String.IsNullOrWhiteSpace(penulis) Or String.IsNullOrWhiteSpace(stock) Then
            MessageBox.Show("Semua kolom harus diisi", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        ' Tambahkan data ke database
        Dim query As String = "INSERT INTO buku (id_buku, judul_buku, tahun_terbit, penerbit, penulis, stok) VALUES (@id_buku, @judul_buku, @tahun_terbit, @penerbit, @penulis, @stok)"
        Using cmd As New MySqlCommand(query, Koneksi)
            cmd.Parameters.AddWithValue("@id_buku", buku)
            cmd.Parameters.AddWithValue("@judul_buku", judul)
            cmd.Parameters.AddWithValue("@tahun_terbit", tahun)
            cmd.Parameters.AddWithValue("@penerbit", penerbit)
            cmd.Parameters.AddWithValue("@penulis", penulis)
            cmd.Parameters.AddWithValue("@stok", stock)

            Konek()
            cmd.ExecuteNonQuery()
            Diskonek()
        End Using

        ' Kosongkan TextBox setelah data ditambahkan
        TextBuku.Clear()
        TextJudul.Clear()
        TextTahun.Clear()
        TextPenerbit.Clear()
        TextPenulis.Clear()
        TextStock.Clear()

        ' Panggil method untuk memuat ulang data
        LoadDataToDataGridView()

        ' Matikan kembali kontrol-kontrol
        DisableInputControls()
    End Sub

    Private Sub Data_Buku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Panggil method untuk memuat data saat Form dimuat
        LoadDataToDataGridView()
    End Sub

    ' Buat sebuah method untuk menampilkan data dari database ke DataGridView
    Private Sub LoadDataToDataGridView()
        ' Kosongkan DataGridView terlebih dahulu
        Data_Buku.Rows.Clear()

        ' Tulis kueri SQL Anda untuk mengambil data dari database
        Dim query As String = "SELECT id_buku, judul_buku, tahun_terbit, penerbit, penulis, stok FROM buku"

        ' Buat MySqlCommand untuk menjalankan kueri
        Using cmd As New MySqlCommand(query, Koneksi)
            Konek()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Loop melalui hasil pembacaan dan tambahkan ke DataGridView
            While reader.Read()
                Dim buku As String = reader("id_buku").ToString()
                Dim judul As String = reader("judul_buku").ToString()
                Dim tahun As String = reader("tahun_terbit").ToString()
                Dim penerbit As String = reader("penerbit").ToString()
                Dim penulis As String = reader("penulis").ToString()
                Dim stok As String = reader("stok").ToString()

                Data_Buku.Rows.Add(buku, judul, tahun, penerbit, penulis, stok)
            End While

            Diskonek()
        End Using
    End Sub
    ' Tambahkan variabel global untuk menyimpan indeks baris terpilih.
    Dim selectedRowIndex As Integer = -1

    ' Method untuk memuat data saat Form dimuat
    Private Sub DataBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Panggil method untuk memuat data saat Form dimuat
        LoadDataToDataGridView()

        ' Matikan kontrol-kontrol yang akan dimatikan
        DisableInputControls()
    End Sub

    Private Sub Data_Buku_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Data_Buku.CellClick
        ' Ketika pengguna mengklik sel dalam DataGridView, ambil indeks baris terpilih.
        If e.RowIndex >= 0 Then
            selectedRowIndex = e.RowIndex

            ' Tampilkan data dari baris terpilih di TextBox
            TextBuku.Text = Data_Buku.Rows(selectedRowIndex).Cells(0).Value.ToString()
            TextJudul.Text = Data_Buku.Rows(selectedRowIndex).Cells(1).Value.ToString()
            TextTahun.Text = Data_Buku.Rows(selectedRowIndex).Cells(2).Value.ToString()
            TextPenerbit.Text = Data_Buku.Rows(selectedRowIndex).Cells(3).Value.ToString()
            TextPenulis.Text = Data_Buku.Rows(selectedRowIndex).Cells(4).Value.ToString()
            TextStock.Text = Data_Buku.Rows(selectedRowIndex).Cells(5).Value.ToString()
        End If
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        ' Validasi apakah baris terpilih
        If selectedRowIndex < 0 Then
            MessageBox.Show("Pilih baris yang ingin diubah", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Ambil data dari TextBox
        Dim buku As String = TextBuku.Text
        Dim judul As String = TextJudul.Text
        Dim tahun As String = TextTahun.Text
        Dim penerbit As String = TextPenerbit.Text
        Dim penulis As String = TextPenulis.Text
        Dim stock As String = TextStock.Text

        ' Validasi apakah ada isian di TextBox
        If String.IsNullOrWhiteSpace(buku) Or String.IsNullOrWhiteSpace(judul) Or String.IsNullOrWhiteSpace(tahun) Or String.IsNullOrWhiteSpace(penerbit) Or String.IsNullOrWhiteSpace(penulis) Or String.IsNullOrWhiteSpace(stock) Then
            MessageBox.Show("Semua kolom harus diisi", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Update data dalam DataGridView
        Data_Buku.Rows(selectedRowIndex).Cells(0).Value = buku
        Data_Buku.Rows(selectedRowIndex).Cells(1).Value = judul
        Data_Buku.Rows(selectedRowIndex).Cells(2).Value = tahun
        Data_Buku.Rows(selectedRowIndex).Cells(3).Value = penerbit
        Data_Buku.Rows(selectedRowIndex).Cells(4).Value = penulis
        Data_Buku.Rows(selectedRowIndex).Cells(5).Value = stock

        ' Update data dalam database
        Dim query As String = "UPDATE buku SET id_buku = @id_buku, judul_buku = @judul_buku, tahun_terbit = @tahun_terbit, penerbit = @penerbit, penulis = @penulis, stok = @stok WHERE id_buku = @id_buku"
        Using cmd As New MySqlCommand(query, Koneksi)
            cmd.Parameters.AddWithValue("@id_buku", buku)
            cmd.Parameters.AddWithValue("@judul_buku", judul)
            cmd.Parameters.AddWithValue("@tahun_terbit", tahun)
            cmd.Parameters.AddWithValue("@penerbit", penerbit)
            cmd.Parameters.AddWithValue("@penulis", penulis)
            cmd.Parameters.AddWithValue("@stok", stock)
            Konek()
            cmd.ExecuteNonQuery()
            Diskonek()
        End Using

        ' Kosongkan TextBox setelah data diubah
        TextBuku.Clear()
        TextJudul.Clear()
        TextTahun.Clear()
        TextPenerbit.Clear()
        TextPenulis.Clear()
        TextStock.Clear()

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
        Dim buku As String = TextBuku.Text

        ' Hapus data dalam DataGridView
        Data_Buku.Rows.RemoveAt(selectedRowIndex)

        ' Hapus data dalam database
        Dim query As String = "DELETE FROM buku WHERE id_buku = @id_buku"
        Using cmd As New MySqlCommand(query, Koneksi)
            cmd.Parameters.AddWithValue("@id_buku", buku)
            Konek()
            cmd.ExecuteNonQuery()
            Diskonek()
        End Using

        ' Kosongkan TextBox setelah data dihapus
        TextBuku.Clear()
        TextJudul.Clear()
        TextTahun.Clear()
        TextPenerbit.Clear()
        TextPenulis.Clear()
        TextStock.Clear()

        ' Set selectedRowIndex kembali ke -1
        selectedRowIndex = -1
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim formMenuUtama As New MenuUtama(level)
        formMenuUtama.Show()
        Me.Close()
    End Sub

    Private Sub BtnTambah_Click_1(sender As Object, e As EventArgs) Handles BtnTambah.Click
        ' Mengizinkan pengguna untuk mengedit TextBox saat tombol "Tambah" ditekan
        EnableInputControls()
    End Sub

    Private Sub EnableInputControls()
        ' Mengaktifkan input controls
        TextBuku.Enabled = True
        TextJudul.Enabled = True
        TextTahun.Enabled = True
        TextPenerbit.Enabled = True
        TextPenulis.Enabled = True
        TextStock.Enabled = True

        ' Mengaktifkan tombol Simpan, Ubah, dan Hapus
        BtnSimpan.Enabled = True
        BtnUbah.Enabled = True
        BtnHapus.Enabled = True
    End Sub

    Private Sub DisableInputControls()
        ' Mengaktifkan input controls
        TextBuku.Enabled = False
        TextJudul.Enabled = False
        TextTahun.Enabled = False
        TextPenerbit.Enabled = False
        TextPenulis.Enabled = False
        TextStock.Enabled = False

        ' Menonaktifkan tombol Simpan, Ubah, dan Hapus
        BtnSimpan.Enabled = False
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
    End Sub
End Class