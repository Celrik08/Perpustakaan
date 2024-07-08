Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class DataPeminjaman

    ' Matikan kembali kontrol-kontrol
    Sub kondisiAwal()
        IDAnggota.Enabled = True
        textStok.Text = ""
        IDBuku.Text = ""
        JumlahPinjam.Text = ""
        JudulBuku.Text = ""
        tahunTerbit.Text = ""
        penulis.Text = ""
        textStok.ReadOnly = True
        NamaAnggota.ReadOnly = True
        JudulBuku.ReadOnly = True
        tahunTerbit.ReadOnly = True
        penulis.ReadOnly = True
        username.ReadOnly = True
        totPinjam.Text = ""
    End Sub

    Sub kondisiAwal2()
        IDBuku.Enabled = False
        JumlahPinjam.Enabled = False
        BtnInput.Visible = False
        NamaAnggota.BackColor = Color.LightSteelBlue
        username.BackColor = Color.LightSteelBlue
        penulis.BackColor = Color.Gainsboro
        JudulBuku.BackColor = Color.Gainsboro
        textStok.BackColor = Color.Gainsboro
        tahunTerbit.BackColor = Color.Gainsboro
    End Sub

    Sub BackKondisiAwal2()
        IDBuku.Enabled = True
        JumlahPinjam.Enabled = True
        BtnInput.Visible = True
        NamaAnggota.BackColor = Color.Gainsboro
        username.BackColor = Color.Gainsboro
        penulis.BackColor = Color.LightSteelBlue
        JudulBuku.BackColor = Color.LightSteelBlue
        textStok.BackColor = Color.LightSteelBlue
        tahunTerbit.BackColor = Color.LightSteelBlue
        penulis.ForeColor = Color.Black
        JudulBuku.ForeColor = Color.Black
        textStok.ForeColor = Color.Black
        tahunTerbit.ForeColor = Color.Black
    End Sub

    'koneksi ke dataset anggota
    Sub dataAnggota()
        Call Konek()
        IDAnggota.Items.Clear()
        cmd = New MySqlCommand("SELECT * FROM anggota", Koneksi)
        dr = cmd.ExecuteReader
        Do While dr.Read
            IDAnggota.Items.Add(dr.Item(0))
        Loop
    End Sub

    Private Sub IDAnggota_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IDAnggota.SelectedIndexChanged
        'menampilkan data anggota
        Konek()
        cmd = New MySqlCommand("SELECT * FROM anggota where id_anggota ='" & IDAnggota.Text & "'", Koneksi)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            NamaAnggota.Text = dr!nama_anggota
        End If
    End Sub

    'koneksi ke dataset buku
    Sub dataBuku()
        Call Konek()
        IDBuku.Items.Clear()
        cmd = New MySqlCommand("SELECT * FROM buku", Koneksi)
        dr = cmd.ExecuteReader
        Do While dr.Read
            IDBuku.Items.Add(dr.Item(0))
        Loop
    End Sub

    Private Sub IDBuku_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IDBuku.SelectedIndexChanged
        'menampilkan data buku
        Konek()
        cmd = New MySqlCommand("SELECT * FROM buku where id_buku ='" & IDBuku.Text & "'", Koneksi)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            penulis.Text = dr!penerbit
            textStok.Text = dr!stok
            tahunTerbit.Text = dr!tahun_terbit
            JudulBuku.Text = dr!judul_buku
        End If
        
    End Sub

    'Nomor ID Peminjaman otomatis
    Sub noOtomatis()
        Call Konek()
        cmd = New MySqlCommand("SELECT * FROM peminjaman where id_peminjaman in(SELECT max(id_peminjaman) FROM peminjaman)", Koneksi)
        Dim urutanKode As String
        Dim hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urutanKode = "PJM" + Format(Now, "ddMMyy") + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 9) + 1
            urutanKode = "PJM" + Format(Now, "ddMMyy") + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        IDPeminjaman.Text = urutanKode
        'JumlahPinjam.Focus()
    End Sub

    Sub RumusTotalBuku()
        Dim hitungItem As Integer = 0
        For i As Integer = 0 To Data_Peminjaman.Rows.Count - 1
            hitungItem = hitungItem + Data_Peminjaman.Rows(i).Cells(3).Value
            totPinjam.Text = hitungItem
        Next
    End Sub

    Sub Batal()
        ' Buka koneksi ke database
        Call Konek()

        ' Iterate through the rows in Data_Peminjaman DataGridView
        For Each row As DataGridViewRow In Data_Peminjaman.Rows
            ' Check if the row is not a new row (avoid null reference error)
            If Not row.IsNewRow Then
                ' Check if the cells are not null
                If row.Cells("GridIDBuku").Value IsNot Nothing AndAlso row.Cells("GridJumlah").Value IsNot Nothing Then
                    ' Retrieve data from DataGridView
                    Dim idBukuToCancel As String = row.Cells("GridIDBuku").Value.ToString()
                    Dim jumlahPeminjamanToCancel As Integer = Convert.ToInt32(row.Cells("GridJumlah").Value)

                    ' Buat perintah SQL UPDATE untuk mengembalikan stok
                    Dim cancelQuery As String = "UPDATE buku SET stok = stok + @jumlahPeminjamanToCancel WHERE id_buku = @idBukuToCancel"

                    Using cmd As New MySqlCommand(cancelQuery, Koneksi)
                        cmd.Parameters.AddWithValue("@jumlahPeminjamanToCancel", jumlahPeminjamanToCancel)
                        cmd.Parameters.AddWithValue("@idBukuToCancel", idBukuToCancel)
                        cmd.ExecuteNonQuery()
                    End Using
                End If
            End If
        Next

        ' Tutup koneksi setelah selesai
        Koneksi.Close()

        ' Clear the DataGridView
        Data_Peminjaman.Rows.Clear()

        ' Kosongkan input
        kondisiAwal2()

        ' Hitung total buku
        RumusTotalBuku()
        IDAnggota.Enabled = True
    End Sub

    Private Sub BtnInput_Click(sender As Object, e As EventArgs) Handles BtnInput.Click
        ' Buka koneksi ke database
        Call Konek()

        ' ID buku yang ingin diperbarui
        Dim idBukuToUpdate As String = IDBuku.Text

        ' Batasan maksimal peminjaman buku
        Dim batasanMaksimal As Integer = 5

        ' Mengubah input menjadi angka (pastikan variabel-variabel numerik)
        Dim jumlahPeminjaman As Integer

        ' Pastikan JumlahPinjam.Text dapat diubah menjadi Integer
        If Integer.TryParse(JumlahPinjam.Text, jumlahPeminjaman) Then
            If totPinjam.Text + jumlahPeminjaman > batasanMaksimal Then
                MsgBox("Total peminjaman buku melebihi batas maksimal (" & batasanMaksimal & ").")
            ElseIf jumlahPeminjaman > CInt(textStok.Text) Then
                MsgBox("Jumlah peminjaman melebihi stok buku yang tersedia.")
            ElseIf IDAnggota.Text = "" Or IDBuku.Text = "" Or JumlahPinjam.Text = "" Then
                MsgBox("Isi ID Anggota, ID Buku, atau Jumlah Peminjaman Buku terlebih dahulu.")
            ElseIf jumlahPeminjaman <= 0 Then
                MsgBox("Jumlah peminjaman harus lebih besar dari 0.")
            Else
                ' Check if there is enough stock for the requested amount
                If jumlahPeminjaman > CInt(textStok.Text) Then
                    MsgBox("Tidak dapat melakukan peminjaman buku karena stok telah habis.")
                Else
                    ' Buat perintah SQL UPDATE
                    Dim updateQuery As String = "UPDATE buku SET stok = stok - @jumlahPeminjaman WHERE id_buku = @idBukuToUpdate"

                    Using cmd As New MySqlCommand(updateQuery, Koneksi)
                        cmd.Parameters.AddWithValue("@jumlahPeminjaman", jumlahPeminjaman)
                        cmd.Parameters.AddWithValue("@idBukuToUpdate", idBukuToUpdate)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' Tutup koneksi setelah selesai
                    Koneksi.Close()

                    ' Mengurangi stok buku
                    textStok.Text = (CInt(textStok.Text) - jumlahPeminjaman).ToString()

                    ' Tambahkan data ke DataGridView
                    Data_Peminjaman.Rows.Add(New String() {IDBuku.Text, JudulBuku.Text, penulis.Text, jumlahPeminjaman})

                    ' Kosongkan input
                    kondisiAwal()

                    ' Hitung total buku
                    RumusTotalBuku()
                    IDAnggota.Enabled = False
                End If
                
            End If
        Else
            MsgBox("Jumlah Peminjaman harus berupa angka.")


        End If
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Try
            ' Buka koneksi ke database
            Call Konek()

            ' Insert into peminjaman table
            Dim PinjamBuku As String = "INSERT INTO peminjaman VALUES (@IDPeminjaman, @tglsql, @IDAnggota, @totPinjam, @username)"
            Using cmd As New MySqlCommand(PinjamBuku, Koneksi)
                cmd.Parameters.AddWithValue("@IDPeminjaman", IDPeminjaman.Text)
                cmd.Parameters.AddWithValue("@tglsql", Format(Today, "yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@IDAnggota", IDAnggota.Text)
                cmd.Parameters.AddWithValue("@totPinjam", totPinjam.Text)
                cmd.Parameters.AddWithValue("@username", username.Text)
                cmd.ExecuteNonQuery()
            End Using

            ' Insert into detailpeminjaman table
            For baris As Integer = 0 To Data_Peminjaman.Rows.Count - 2
                'Dim nomorOtomatis As Integer = GetNextDetailPinjamNumber() ' Replace with your method to get the next automatic number
                Dim SimpanDetail As String = "INSERT INTO detailpeminjaman VALUES (@IDPeminjaman, @Cell0Value, @Cell1Value, @Cell3Value)"
                Using cmd As New MySqlCommand(SimpanDetail, Koneksi)
                    'cmd.Parameters.AddWithValue("@detailPinjam", nomorOtomatis)
                    cmd.Parameters.AddWithValue("@IDPeminjaman", IDPeminjaman.Text)
                    cmd.Parameters.AddWithValue("@Cell0Value", Data_Peminjaman.Rows(baris).Cells(0).Value)
                    cmd.Parameters.AddWithValue("@Cell1Value", Data_Peminjaman.Rows(baris).Cells(1).Value)
                    cmd.Parameters.AddWithValue("@Cell3Value", Data_Peminjaman.Rows(baris).Cells(3).Value)
                    cmd.ExecuteNonQuery()
                End Using
            Next
            Pilih()
            kondisiAwal2()
            noOtomatis()

            ' Clear the DataGridView
            Data_Peminjaman.Rows.Clear()

            MsgBox("Transaksi telah berhasil disimpan.")
        Catch ex As Exception
            ' Handle specific exceptions and provide meaningful error messages.
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
            Batal()
        Finally
            ' Pastikan untuk menutup koneksi setelah selesai.
            Koneksi.Close()
        End Try
    End Sub

    Private Sub DataPeminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kondisiAwal()
        kondisiAwal2()
        noOtomatis()
        dataAnggota()
        dataBuku()
        LoadDataToDataGridView()
        DatePinjam.Text = Today()
        RumusTotalBuku()
        Data_Peminjaman.ReadOnly = True
        'Data_Peminjaman.Enabled = False
    End Sub

    ' Buat sebuah method untuk menampilkan data dari database ke DataGridView
    Private Sub LoadDataToDataGridView()
        ' Kosongkan DataGridView terlebih dahulu
        Data_Peminjaman.Rows.Clear()

        ' Tulis kueri SQL Anda untuk mengambil data dari peminjaman
        Dim query As String = "SELECT peminjaman.id_peminjaman, anggota.nama_anggota, buku.judul_buku, peminjaman.tanggal_peminjaman, peminjaman.tanggal_pengembalian " &
                              "FROM peminjaman " &
                              "INNER JOIN anggota ON peminjaman.id_anggota = anggota.id_anggota " &
                              "INNER JOIN buku ON peminjaman.id_buku = buku.id_buku"

        ' Buat MySqlCommand untuk menjalankan kueri
        Using cmd As New MySqlCommand(query, Koneksi)

        End Using
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        jam.Text = TimeOfDay
    End Sub

    Sub Pilih()
        IDAnggota.Enabled = True
        IDAnggota.Text = ""
        NamaAnggota.Text = ""
        kondisiAwal()
        Button1.Text = "Pilih"
    End Sub

    Sub Ubah()
        IDAnggota.Enabled = False
        Button1.Text = "Ubah"
        BackKondisiAwal2()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kondisiAwal2()
        'Membersihkan GridView
        Data_Peminjaman.Rows.Clear()

        If Button1.Text = "Pilih" Then
            ' Mengubah kondisi dari "Pilih" ke "Ubah"
            If IDAnggota.Text = "" Then
                MsgBox("Pilih ID Anggota terlebih dahulu.")
            Else
                Ubah()
            End If
        ElseIf Button1.Text = "Ubah" Then
            ' Mengubah kondisi dari "Ubah" ke "Pilih"
            Pilih()
        End If
    End Sub

    Private Sub totPinjam_TextChanged(sender As Object, e As EventArgs) Handles totPinjam.TextChanged
        totPinjam.ReadOnly = True
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        If Data_Peminjaman.Rows.Count > 0 Then
            Batal()
        Else
            MsgBox("Tidak ada transaksi peminjaman.")
        End If
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub
End Class

