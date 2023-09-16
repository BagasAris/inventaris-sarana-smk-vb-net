Imports MySql.Data.MySqlClient
Public Class FPeminjaman
    Private Sub FPeminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Call tampilUser()
        Call aturDGV()
        Call isiComboPegawai()
        Call tampilData()
    End Sub

    Sub isiComboPegawai()
        Call koneksi()
        Dim query As String = "select nama_pegawai from tb_pegawai"
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()
        While RD.Read()
            Dim namaPegawai As String = RD("nama_pegawai").ToString()
            ComboBox1.Items.Add(namaPegawai)
        End While
    End Sub

    Sub tampilData()
        Call koneksi()
        'DA = New MySqlDataAdapter("Select tb_transaksi.id, tb_outlet.nama, tb_transaksi.kode_invoice, tb_transaksi.id_member, tb_transaksi.tgl, tb_transaksi.batas_waktu, tb_transaksi.tgl_bayar, tb_transaksi.biaya_tambahan, tb_transaksi.diskon, tb_transaksi.pajak, tb_transaksi.status, tb_transaksi.dibayar, tb_transaksi.id_user" & "FROM tb_transaksi " & "INNER JOIN tb_transaksi ON tb_transaksi.id_outlet = tb_outlet.id", CONN)
        DA = New MySqlDataAdapter("SELECT tb_peminjaman.id_peminjaman, tb_peminjaman.tgl_pinjam, tb_peminjaman.tgl_kembali, tb_peminjaman.status_peminjaman, tb_pegawai.nama_pegawai " & "FROM tb_peminjaman " & "INNER JOIN tb_pegawai ON tb_peminjaman.id_pegawai = tb_pegawai.id_pegawai ", CONN)
        'DA = New MySqlDataAdapter("SELECT tb_transaksi.id, tb_outlet.nama, tb_transaksi.kode_invoice, tb_transaksi.id_member, tb_member.nama AS nama_member, tb_transaksi.tgl, tb_transaksi.batas_waktu, tb_transaksi.tgl_bayar, tb_transaksi.biaya_tambahan, tb_transaksi.diskon, tb_transaksi.pajak, tb_transaksi.status, tb_transaksi.dibayar, tb_transaksi.id_user " & "FROM tb_transaksi " & "INNER JOIN tb_outlet ON tb_transaksi.id_outlet = tb_outlet.id " & "INNER JOIN tb_member ON tb_transaksi.id_member = tb_member.id", CONN)
        DS = New DataSet
        DA.Fill(DS, "tb_peminjaman")
        DGpeminjaman.DataSource = DS.Tables("tb_peminjaman")
    End Sub

    'Sub tampilUser()

    '    Call koneksi()
    '    DA = New MySql.Data.MySqlClient.MySqlDataAdapter("select * from tb_peminjaman", CONN)
    '    DS = New DataSet
    '    DA.Fill(DS, "tb_peminjaman")
    '    DGpeminjaman.DataSource = DS.Tables("tb_peminjaman")

    'End Sub

    Sub aturDGV()
        Try
            DGpeminjaman.Columns(0).Width = 70
            DGpeminjaman.Columns(1).Width = 130
            DGpeminjaman.Columns(2).Width = 100
            DGpeminjaman.Columns(3).Width = 150
            DGpeminjaman.Columns(4).Width = 70
            DGpeminjaman.Columns(0).HeaderText = "ID PEMINJAMAN"
            DGpeminjaman.Columns(1).HeaderText = "TANGGAL PINJAM"
            DGpeminjaman.Columns(2).HeaderText = "TANGAL KEMBALI"
            DGpeminjaman.Columns(3).HeaderText = "STATUS PEMINJAMAN"
            DGpeminjaman.Columns(4).HeaderText = "ID PEGAWAI"
        Catch ex As Exception
        End Try
    End Sub

    Sub Simpan()
        Call koneksi()
        Try
            Dim str As String
            'str = "INSERT INTO tb_petugas (id_petugas, username, password, nama_petugas, id_level) VALUES ('" & idPetugasTxt.Text & "','" & usernameTxt.Text & "', '" & passwordTxt.Text & "', '" & namaTxt.Text & "',' SELECT id_level FROM tb_level WHERE id_level = '" & idTxt.Text & "')"
            str = "INSERT INTO tb_peminjaman (id_peminjaman, tgl_pinjam, tgl_kembali, status_peminjaman, id_pegawai) VALUES ('" & idpPeminjamanTxt.Text & "','" & tglPinjam.Value.ToString("yyyy-MM-dd") & "', '" & tglKembali.Value.ToString("yyyy-MM-dd") & "', '" & CBstatus.Text & "', (Select id_pegawai from tb_pegawai where nama_pegawai='" & ComboBox1.Text & "'))"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Insert Data Peminjaman Berhasil Dilakukan")
        Catch ex As Exception
            MessageBox.Show("Insert Data Peminjaman gagal dilakukan.")
        End Try
        'Call tampilUser()
        Call tampilData()
        Call aturDGV()
        cariTxt.Text = ""
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call Simpan()
    End Sub

    Sub updateUser()
        Try
            Call koneksi()
            Dim str As String
            str = "UPDATE tb_peminjaman SET id_peminjaman = '" & idpPeminjamanTxt.Text & "', tgl_pinjam = '" & tglPinjam.Value.ToString("yyyy-MM-dd") & "', tgl_kembali = '" & tglKembali.Value.ToString("yyyy-MM-dd") & "', status_peminjaman ='" & CBstatus.Text & "', id_pegawai = (Select id_pegawai from tb_pegawai where nama_pegawai='" & ComboBox1.Text & "') WHERE id_peminjaman = '" & idpPeminjamanTxt.Text & "'"
            CMD = New MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Update Data Peminjaman Berhasil Dilakukan.")

        Catch ex As Exception
            MessageBox.Show("Update Data Peminjaman gagal dilakukan")
        End Try
        'Call tampilUser()
        Call tampilData()
        Call aturDGV()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Call updateUser()
    End Sub

    Sub hapusUser()
        Try
            Call koneksi()
            Dim str As String
            str = "delete from tb_peminjaman where id_peminjaman = '" & idpPeminjamanTxt.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Peminjaman Berhasil Dihapus.")

        Catch ex As Exception
            MessageBox.Show("Data Peminjaman Gagal Dihapus.")
        End Try
        'Call tampilUser()
        Call tampilData()
        Call aturDGV()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        MessageBox.Show("Apakah Anda Yakin Akan Menghapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Call hapusUser()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        MessageBox.Show("Apakah Anda Yakin Akan Keluar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Me.Close()
    End Sub

    Private Sub cariBtn_Click(sender As Object, e As EventArgs) Handles cariBtn.Click
        Dim tables As DataTableCollection = DS.Tables
        Dim source1 As New BindingSource
        DA = New MySqlDataAdapter("select * from tb_peminjaman", CONN)
        DS = New DataSet
        DA.Fill(DS, "tb_peminjaman")
        'memunculkan data-data di dalam tabel
        Dim tampil As New DataView(tables(0))
        source1.DataSource = tampil
        DGpeminjaman.DataSource = tampil
        DGpeminjaman.Refresh()
        'memunculkan data tabel berdasarkan pencarian Txt_Cari(memasukkan ID Anggota)
        tampil.RowFilter = "id_peminjaman= '" & cariTxt.Text & "'"
        DGpeminjaman.Refresh()
    End Sub

    Private Sub DGpeminjaman_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGpeminjaman.CellContentClick
        idpPeminjamanTxt.Text = DGpeminjaman.Rows(e.RowIndex).Cells(0).Value
        tglPinjam.Text = DGpeminjaman.Rows(e.RowIndex).Cells(1).Value
        tglPinjam.Text = DGpeminjaman.Rows(e.RowIndex).Cells(2).Value
        CBstatus.Text = DGpeminjaman.Rows(e.RowIndex).Cells(3).Value
        ComboBox1.Text = DGpeminjaman.Rows(e.RowIndex).Cells(4).Value
    End Sub
End Class