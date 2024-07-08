<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataPengembalian
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
        Me.DatePengembali = New System.Windows.Forms.DateTimePicker()
        Me.DatePinjam = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Data_Peminjaman = New System.Windows.Forms.DataGridView()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.TextJudul = New System.Windows.Forms.TextBox()
        Me.TextNama = New System.Windows.Forms.TextBox()
        Me.TextPeminjaman = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextDenda = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Pengembalian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Judul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pinjam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pengembali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Denda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Data_Peminjaman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DatePengembali
        '
        Me.DatePengembali.CalendarFont = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePengembali.Location = New System.Drawing.Point(221, 208)
        Me.DatePengembali.Name = "DatePengembali"
        Me.DatePengembali.Size = New System.Drawing.Size(232, 22)
        Me.DatePengembali.TabIndex = 64
        '
        'DatePinjam
        '
        Me.DatePinjam.CalendarFont = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePinjam.Location = New System.Drawing.Point(221, 180)
        Me.DatePinjam.Name = "DatePinjam"
        Me.DatePinjam.Size = New System.Drawing.Size(232, 22)
        Me.DatePinjam.TabIndex = 63
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 21)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Tanggal Pengembalian"
        '
        'Data_Peminjaman
        '
        Me.Data_Peminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Data_Peminjaman.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Pengembalian, Me.Nama, Me.Judul, Me.Pinjam, Me.Pengembali, Me.Denda})
        Me.Data_Peminjaman.Location = New System.Drawing.Point(45, 304)
        Me.Data_Peminjaman.Name = "Data_Peminjaman"
        Me.Data_Peminjaman.RowTemplate.Height = 24
        Me.Data_Peminjaman.Size = New System.Drawing.Size(906, 506)
        Me.Data_Peminjaman.TabIndex = 61
        '
        'BtnBack
        '
        Me.BtnBack.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.Location = New System.Drawing.Point(698, 144)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(80, 31)
        Me.BtnBack.TabIndex = 60
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.Location = New System.Drawing.Point(605, 144)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(80, 31)
        Me.BtnHapus.TabIndex = 59
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnUbah
        '
        Me.BtnUbah.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUbah.Location = New System.Drawing.Point(698, 99)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(80, 31)
        Me.BtnUbah.TabIndex = 58
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.Location = New System.Drawing.Point(605, 99)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(80, 31)
        Me.BtnTambah.TabIndex = 57
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'TextJudul
        '
        Me.TextJudul.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextJudul.Location = New System.Drawing.Point(221, 146)
        Me.TextJudul.Name = "TextJudul"
        Me.TextJudul.Size = New System.Drawing.Size(232, 28)
        Me.TextJudul.TabIndex = 56
        '
        'TextNama
        '
        Me.TextNama.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNama.Location = New System.Drawing.Point(221, 112)
        Me.TextNama.Name = "TextNama"
        Me.TextNama.Size = New System.Drawing.Size(232, 28)
        Me.TextNama.TabIndex = 55
        '
        'TextPeminjaman
        '
        Me.TextPeminjaman.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextPeminjaman.Location = New System.Drawing.Point(221, 74)
        Me.TextPeminjaman.Name = "TextPeminjaman"
        Me.TextPeminjaman.Size = New System.Drawing.Size(232, 28)
        Me.TextPeminjaman.TabIndex = 54
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 21)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Tanggal Pinjam"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 21)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Judul Buku"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 21)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Nama Pengembali"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 21)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Id Pengembalian"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(330, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 23)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Data Pengembalian"
        '
        'TextDenda
        '
        Me.TextDenda.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDenda.Location = New System.Drawing.Point(221, 236)
        Me.TextDenda.Name = "TextDenda"
        Me.TextDenda.Size = New System.Drawing.Size(232, 28)
        Me.TextDenda.TabIndex = 66
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 21)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Denda"
        '
        'Pengembalian
        '
        Me.Pengembalian.HeaderText = "Id Pengembalian"
        Me.Pengembalian.Name = "Pengembalian"
        '
        'Nama
        '
        Me.Nama.HeaderText = "Nama Pengembali"
        Me.Nama.Name = "Nama"
        '
        'Judul
        '
        Me.Judul.HeaderText = "Judul Buku"
        Me.Judul.Name = "Judul"
        '
        'Pinjam
        '
        Me.Pinjam.HeaderText = "Tanggal Pinjam"
        Me.Pinjam.Name = "Pinjam"
        '
        'Pengembali
        '
        Me.Pengembali.HeaderText = "Tanggal Pengembalian"
        Me.Pengembali.Name = "Pengembali"
        '
        'Denda
        '
        Me.Denda.HeaderText = "Denda"
        Me.Denda.Name = "Denda"
        '
        'DataPengembalian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 853)
        Me.Controls.Add(Me.TextDenda)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DatePengembali)
        Me.Controls.Add(Me.DatePinjam)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Data_Peminjaman)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.TextJudul)
        Me.Controls.Add(Me.TextNama)
        Me.Controls.Add(Me.TextPeminjaman)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DataPengembalian"
        Me.Text = "DataPengembalian"
        CType(Me.Data_Peminjaman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatePengembali As System.Windows.Forms.DateTimePicker
    Friend WithEvents DatePinjam As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Data_Peminjaman As System.Windows.Forms.DataGridView
    Friend WithEvents Pengembalian As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Judul As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pinjam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pengembali As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Denda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnBack As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnUbah As System.Windows.Forms.Button
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents TextJudul As System.Windows.Forms.TextBox
    Friend WithEvents TextNama As System.Windows.Forms.TextBox
    Friend WithEvents TextPeminjaman As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextDenda As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
