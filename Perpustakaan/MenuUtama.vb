
Public Class MenuUtama

    Private level As String  ' Deklarasikan variabel level


    Public Sub New(ByVal level As String)
        InitializeComponent()
        Me.level = level  ' Inisialisasi variabel level

        ' Berdasarkan ENUM "level", atur visibilitas menu strip
        If level = "admin" Then
            DataMaster.Visible = True
            Transaksi.Visible = True ' Sembunyikan menu strip petugas
        ElseIf level = "petugas" Then
            DataMaster.Visible = False ' Sembunyikan menu strip admin
            Transaksi.Visible = True
        End If

        ' Tampilkan nama pengguna di Label "User"
        User.Text = level
    End Sub

    Private Sub DataAnggota_Click(sender As Object, e As EventArgs) Handles DataAnggota.Click
        Dim dataAnggotaForm As New DataAnggota(level)
        dataAnggotaForm.Show()
        Me.Hide()
    End Sub

    Private Sub DataBuku_Click(sender As Object, e As EventArgs) Handles DataBuku.Click
        Dim DataBuku As New DataBuku(level)
        DataBuku.Show()
        Me.Hide()
    End Sub

    Private Sub DataUser_Click(sender As Object, e As EventArgs) Handles DataUser.Click
        Dim DataUser As New DataUser(level)
        DataUser.Show()
        Me.Hide()
    End Sub

    Private Sub Peminjaman_Click(sender As Object, e As EventArgs) Handles Peminjaman.Click
        Dim DataPeminjaman As New DataPeminjaman()
        DataPeminjaman.Show()
        Me.Hide()
    End Sub

    Private Sub Pengembalian_Click(sender As Object, e As EventArgs) Handles Pengembalian.Click
        Dim DataPengembalian As New DataPengembalian()
        DataPengembalian.Show()
        Me.Hide()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Dim FormLogin As New FormLogin()
        FormLogin.Show()
        Me.Hide()
    End Sub
End Class