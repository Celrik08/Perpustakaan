<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataPeminjaman
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
        Me.components = New System.ComponentModel.Container()
        Me.Data_Peminjaman = New System.Windows.Forms.DataGridView()
        Me.GridIDBuku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GridJudul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GridPenulis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GridJumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnInput = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IDAnggota = New System.Windows.Forms.ComboBox()
        Me.IDBuku = New System.Windows.Forms.ComboBox()
        Me.JumlahPinjam = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.stok = New System.Windows.Forms.Label()
        Me.IDPeminjaman = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.JudulBuku = New System.Windows.Forms.TextBox()
        Me.tahunTerbit = New System.Windows.Forms.TextBox()
        Me.textStok = New System.Windows.Forms.TextBox()
        Me.penulis = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NamaAnggota = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.jam = New System.Windows.Forms.TextBox()
        Me.DatePinjam = New System.Windows.Forms.TextBox()
        Me.totPinjam = New System.Windows.Forms.TextBox()
        CType(Me.Data_Peminjaman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Data_Peminjaman
        '
        Me.Data_Peminjaman.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Data_Peminjaman.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Data_Peminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Data_Peminjaman.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GridIDBuku, Me.GridJudul, Me.GridPenulis, Me.GridJumlah})
        Me.Data_Peminjaman.Location = New System.Drawing.Point(42, 353)
        Me.Data_Peminjaman.Name = "Data_Peminjaman"
        Me.Data_Peminjaman.RowTemplate.Height = 24
        Me.Data_Peminjaman.Size = New System.Drawing.Size(728, 143)
        Me.Data_Peminjaman.TabIndex = 45
        '
        'GridIDBuku
        '
        Me.GridIDBuku.HeaderText = "Id Buku"
        Me.GridIDBuku.Name = "GridIDBuku"
        '
        'GridJudul
        '
        Me.GridJudul.HeaderText = "Judul Buku"
        Me.GridJudul.Name = "GridJudul"
        '
        'GridPenulis
        '
        Me.GridPenulis.HeaderText = "Pengarang / Penulis"
        Me.GridPenulis.Name = "GridPenulis"
        '
        'GridJumlah
        '
        Me.GridJumlah.HeaderText = "Jumlah Buku"
        Me.GridJumlah.Name = "GridJumlah"
        '
        'BtnBatal
        '
        Me.BtnBatal.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBatal.Location = New System.Drawing.Point(523, 551)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(123, 31)
        Me.BtnBatal.TabIndex = 44
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.Location = New System.Drawing.Point(394, 551)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(123, 31)
        Me.BtnSimpan.TabIndex = 41
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 21)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Pengarang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 21)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Nama Anggota"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 21)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Id Peminjaman"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(326, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 23)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Data Peminjaman"
        '
        'BtnInput
        '
        Me.BtnInput.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnInput.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInput.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnInput.Location = New System.Drawing.Point(257, 130)
        Me.BtnInput.Name = "BtnInput"
        Me.BtnInput.Size = New System.Drawing.Size(94, 30)
        Me.BtnInput.TabIndex = 49
        Me.BtnInput.Text = "Input"
        Me.BtnInput.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 21)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Id Anggota"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 21)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Id Buku"
        '
        'IDAnggota
        '
        Me.IDAnggota.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDAnggota.FormattingEnabled = True
        Me.IDAnggota.Location = New System.Drawing.Point(180, 81)
        Me.IDAnggota.Name = "IDAnggota"
        Me.IDAnggota.Size = New System.Drawing.Size(107, 28)
        Me.IDAnggota.TabIndex = 54
        '
        'IDBuku
        '
        Me.IDBuku.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDBuku.FormattingEnabled = True
        Me.IDBuku.Location = New System.Drawing.Point(142, 27)
        Me.IDBuku.Name = "IDBuku"
        Me.IDBuku.Size = New System.Drawing.Size(209, 28)
        Me.IDBuku.TabIndex = 55
        '
        'JumlahPinjam
        '
        Me.JumlahPinjam.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JumlahPinjam.Location = New System.Drawing.Point(141, 132)
        Me.JumlahPinjam.Name = "JumlahPinjam"
        Me.JumlahPinjam.Size = New System.Drawing.Size(104, 28)
        Me.JumlahPinjam.TabIndex = 59
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(19, 135)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 21)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "Jumlah Pinjam"
        '
        'stok
        '
        Me.stok.AutoSize = True
        Me.stok.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stok.Location = New System.Drawing.Point(379, 30)
        Me.stok.Name = "stok"
        Me.stok.Size = New System.Drawing.Size(113, 21)
        Me.stok.TabIndex = 60
        Me.stok.Text = "Stok Tersedia"
        '
        'IDPeminjaman
        '
        Me.IDPeminjaman.AutoSize = True
        Me.IDPeminjaman.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDPeminjaman.Location = New System.Drawing.Point(176, 49)
        Me.IDPeminjaman.Name = "IDPeminjaman"
        Me.IDPeminjaman.Size = New System.Drawing.Size(135, 23)
        Me.IDPeminjaman.TabIndex = 62
        Me.IDPeminjaman.Text = "IDPeminjaman"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(423, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 21)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Tanggal"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(423, 119)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 21)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Petugas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(423, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 21)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Jam"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.JudulBuku)
        Me.GroupBox1.Controls.Add(Me.tahunTerbit)
        Me.GroupBox1.Controls.Add(Me.textStok)
        Me.GroupBox1.Controls.Add(Me.penulis)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.IDBuku)
        Me.GroupBox1.Controls.Add(Me.JumlahPinjam)
        Me.GroupBox1.Controls.Add(Me.stok)
        Me.GroupBox1.Controls.Add(Me.BtnInput)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(42, 161)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(728, 174)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail Buku"
        '
        'JudulBuku
        '
        Me.JudulBuku.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JudulBuku.Location = New System.Drawing.Point(142, 97)
        Me.JudulBuku.Name = "JudulBuku"
        Me.JudulBuku.Size = New System.Drawing.Size(550, 28)
        Me.JudulBuku.TabIndex = 69
        '
        'tahunTerbit
        '
        Me.tahunTerbit.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tahunTerbit.Location = New System.Drawing.Point(505, 61)
        Me.tahunTerbit.Name = "tahunTerbit"
        Me.tahunTerbit.Size = New System.Drawing.Size(187, 28)
        Me.tahunTerbit.TabIndex = 68
        '
        'textStok
        '
        Me.textStok.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textStok.Location = New System.Drawing.Point(505, 27)
        Me.textStok.Name = "textStok"
        Me.textStok.Size = New System.Drawing.Size(187, 28)
        Me.textStok.TabIndex = 67
        '
        'penulis
        '
        Me.penulis.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.penulis.Location = New System.Drawing.Point(142, 61)
        Me.penulis.Name = "penulis"
        Me.penulis.Size = New System.Drawing.Size(209, 28)
        Me.penulis.TabIndex = 64
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 21)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Judul Buku"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(379, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 21)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Tahun Terbit"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(513, 511)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(186, 21)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Total Peminjaman Buku"
        '
        'BtnTutup
        '
        Me.BtnTutup.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTutup.Location = New System.Drawing.Point(652, 551)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(123, 31)
        Me.BtnTutup.TabIndex = 44
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(299, 79)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 30)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "Pilih"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'NamaAnggota
        '
        Me.NamaAnggota.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaAnggota.Location = New System.Drawing.Point(180, 116)
        Me.NamaAnggota.Name = "NamaAnggota"
        Me.NamaAnggota.Size = New System.Drawing.Size(213, 28)
        Me.NamaAnggota.TabIndex = 61
        '
        'username
        '
        Me.username.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.Location = New System.Drawing.Point(547, 116)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(187, 28)
        Me.username.TabIndex = 64
        '
        'jam
        '
        Me.jam.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jam.Location = New System.Drawing.Point(547, 82)
        Me.jam.Name = "jam"
        Me.jam.Size = New System.Drawing.Size(187, 28)
        Me.jam.TabIndex = 65
        '
        'DatePinjam
        '
        Me.DatePinjam.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePinjam.Location = New System.Drawing.Point(547, 48)
        Me.DatePinjam.Name = "DatePinjam"
        Me.DatePinjam.Size = New System.Drawing.Size(187, 28)
        Me.DatePinjam.TabIndex = 66
        '
        'totPinjam
        '
        Me.totPinjam.BackColor = System.Drawing.Color.LightSteelBlue
        Me.totPinjam.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totPinjam.Location = New System.Drawing.Point(705, 508)
        Me.totPinjam.Name = "totPinjam"
        Me.totPinjam.Size = New System.Drawing.Size(65, 28)
        Me.totPinjam.TabIndex = 70
        '
        'DataPeminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 608)
        Me.Controls.Add(Me.totPinjam)
        Me.Controls.Add(Me.DatePinjam)
        Me.Controls.Add(Me.jam)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.NamaAnggota)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.IDPeminjaman)
        Me.Controls.Add(Me.IDAnggota)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Data_Peminjaman)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DataPeminjaman"
        Me.Text = "DataPeminjaman"
        CType(Me.Data_Peminjaman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Data_Peminjaman As System.Windows.Forms.DataGridView
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnInput As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents IDAnggota As System.Windows.Forms.ComboBox
    Friend WithEvents IDBuku As System.Windows.Forms.ComboBox
    Friend WithEvents JumlahPinjam As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents stok As System.Windows.Forms.Label
    Friend WithEvents IDPeminjaman As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BtnTutup As System.Windows.Forms.Button
    Friend WithEvents GridIDBuku As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GridJudul As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GridPenulis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GridJumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents penulis As System.Windows.Forms.TextBox
    Friend WithEvents NamaAnggota As System.Windows.Forms.TextBox
    Friend WithEvents username As System.Windows.Forms.TextBox
    Friend WithEvents jam As System.Windows.Forms.TextBox
    Friend WithEvents DatePinjam As System.Windows.Forms.TextBox
    Friend WithEvents JudulBuku As System.Windows.Forms.TextBox
    Friend WithEvents tahunTerbit As System.Windows.Forms.TextBox
    Friend WithEvents textStok As System.Windows.Forms.TextBox
    Friend WithEvents totPinjam As System.Windows.Forms.TextBox
End Class
