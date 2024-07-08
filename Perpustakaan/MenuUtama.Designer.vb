<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataMaster = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataAnggota = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBuku = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.Transaksi = New System.Windows.Forms.ToolStripMenuItem()
        Me.Peminjaman = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pengembalian = New System.Windows.Forms.ToolStripMenuItem()
        Me.Back = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.User = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataMaster, Me.Transaksi, Me.Back})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(399, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataMaster
        '
        Me.DataMaster.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataAnggota, Me.DataBuku, Me.DataUser})
        Me.DataMaster.Name = "DataMaster"
        Me.DataMaster.Size = New System.Drawing.Size(119, 26)
        Me.DataMaster.Text = "Data Master"
        '
        'DataAnggota
        '
        Me.DataAnggota.Name = "DataAnggota"
        Me.DataAnggota.Size = New System.Drawing.Size(186, 26)
        Me.DataAnggota.Text = "Data Anggota"
        '
        'DataBuku
        '
        Me.DataBuku.Name = "DataBuku"
        Me.DataBuku.Size = New System.Drawing.Size(186, 26)
        Me.DataBuku.Text = "Data Buku"
        '
        'DataUser
        '
        Me.DataUser.Name = "DataUser"
        Me.DataUser.Size = New System.Drawing.Size(186, 26)
        Me.DataUser.Text = "Data User"
        '
        'Transaksi
        '
        Me.Transaksi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Peminjaman, Me.Pengembalian})
        Me.Transaksi.Name = "Transaksi"
        Me.Transaksi.Size = New System.Drawing.Size(98, 26)
        Me.Transaksi.Text = "Transaksi"
        '
        'Peminjaman
        '
        Me.Peminjaman.Name = "Peminjaman"
        Me.Peminjaman.Size = New System.Drawing.Size(190, 26)
        Me.Peminjaman.Text = "Peminjaman"
        '
        'Pengembalian
        '
        Me.Pengembalian.Name = "Pengembalian"
        Me.Pengembalian.Size = New System.Drawing.Size(190, 26)
        Me.Pengembalian.Text = "Pengembalian"
        '
        'Back
        '
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(62, 26)
        Me.Back.Text = "Back"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(123, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Selamat Datang"
        '
        'User
        '
        Me.User.AutoSize = True
        Me.User.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User.Location = New System.Drawing.Point(129, 166)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(120, 21)
        Me.User.TabIndex = 2
        Me.User.Text = "___________"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(129, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Menu Utama"
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 362)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.User)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuUtama"
        Me.Text = "MenuUtama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DataMaster As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataAnggota As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataBuku As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Transaksi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Peminjaman As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Pengembalian As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Back As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents User As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
