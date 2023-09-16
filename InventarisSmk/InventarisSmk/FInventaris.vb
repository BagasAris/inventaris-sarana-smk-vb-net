Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class FInventaris
    Private Sub FInventaris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilUser()
        Call aturDGV()
        Call isiComboJenis()
        Call isiComboRuang()
        Call isiComboPetugas()
    End Sub

    Sub isiComboJenis()
        Call koneksi()
        Dim query As String = "select nama_jenis from tb_jenis"
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()
        While RD.Read()
            Dim namaJenis As String = RD("nama_jenis").ToString()
            CBjenis.Items.Add(namaJenis)
        End While
    End Sub

    Sub isiComboRuang()
        Call koneksi()
        Dim query As String = "select nama_ruang from tb_ruang"
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()
        While RD.Read()
            Dim namaRuang As String = RD("nama_ruang").ToString()
            CBruang.Items.Add(namaRuang)
        End While
    End Sub

    Sub isiComboPetugas()
        Call koneksi()
        Dim query As String = "select nama_petugas from tb_petugas"
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()
        While RD.Read()
            Dim namaPetugas As String = RD("nama_petugas").ToString()
            CBpetugas.Items.Add(namaPetugas)
        End While
    End Sub

    Sub tampilUser()
        Call koneksi()
        DA = New MySqlDataAdapter("SELECT tb_inventaris.id_inventaris, tb_inventaris.nama, tb_inventaris.kondisi, tb_inventaris.jumlah, tb_jenis.nama_jenis, tb_inventaris.tgl_register, tb_ruang.nama_ruang, tb_inventaris.kode_inventaris, tb_petugas.nama_petugas, tb_inventaris.keterangan " &
    "FROM tb_inventaris " &
    "INNER JOIN tb_jenis ON tb_inventaris.id_jenis = tb_jenis.id_jenis " &
    "INNER JOIN tb_ruang ON tb_inventaris.id_ruang = tb_ruang.id_ruang " &
    "INNER JOIN tb_petugas ON tb_inventaris.id_petugas = tb_petugas.id_petugas", CONN)
        DS = New DataSet
        DA.Fill(DS, "tb_inventaris")
        DGinventaris.DataSource = DS.Tables("tb_inventaris")

    End Sub

    Sub aturDGV()
        Try
            DGinventaris.Columns(0).Width = 70
            DGinventaris.Columns(1).Width = 130
            DGinventaris.Columns(2).Width = 100
            DGinventaris.Columns(3).Width = 150
            DGinventaris.Columns(4).Width = 150
            DGinventaris.Columns(5).Width = 150
            DGinventaris.Columns(6).Width = 150
            DGinventaris.Columns(7).Width = 150
            DGinventaris.Columns(8).Width = 150
            DGinventaris.Columns(9).Width = 150
            DGinventaris.Columns(0).HeaderText = "ID INVENTARIS"
            DGinventaris.Columns(1).HeaderText = "NAMA"
            DGinventaris.Columns(2).HeaderText = "KONDISI"
            DGinventaris.Columns(3).HeaderText = "JUMLAH"
            DGinventaris.Columns(4).HeaderText = "ID JENIS"
            DGinventaris.Columns(5).HeaderText = "TANGGAL REGISTER"
            DGinventaris.Columns(6).HeaderText = "ID RUANG"
            DGinventaris.Columns(7).HeaderText = "KODE INVENTARIS"
            DGinventaris.Columns(8).HeaderText = "ID PETUGAS"
            DGinventaris.Columns(9).HeaderText = "KETERANGAN"
        Catch ex As Exception
        End Try
    End Sub
    Sub Simpan()
        Call koneksi()
        Try
            Dim str As String
            'str = "INSERT INTO tb_petugas (id_petugas, username, password, nama_petugas, id_level) VALUES ('" & idPetugasTxt.Text & "','" & usernameTxt.Text & "', '" & passwordTxt.Text & "', '" & namaTxt.Text & "',' SELECT id_level FROM tb_level WHERE id_level = '" & idTxt.Text & "')"
            str = "INSERT INTO tb_inventaris (id_inventaris, nama, kondisi, jumlah, id_jenis, tgl_register, id_ruang, kode_inventaris, id_petugas, keterangan) VALUES ('" & idInventarisTxt.Text & "','" & namaTxt.Text & "', '" & CBkondisi.Text & "', '" & jumlahTxt.Text & "', (Select id_jenis from tb_jenis where nama_jenis='" & CBjenis.Text & "'),'" & tglRegister.Value.ToString("yyyy-MM-dd") & "',(Select id_ruang from tb_ruang where nama_ruang='" & CBruang.Text & "'),'" & kodeTxt.Text & "',(Select id_petugas from tb_petugas where nama_petugas='" & CBpetugas.Text & "'),'" & keteranganTxt.Text & "')"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Insert Data Inventaris Berhasil Dilakukan")
        Catch ex As Exception
            MessageBox.Show("Insert Data Inventaris gagal dilakukan.")
        End Try
        Call tampilUser()
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
            str = "UPDATE tb_inventaris SET id_inventaris = '" & idInventarisTxt.Text & "', nama = '" & namaTxt.Text & "', kondisi = '" & CBkondisi.Text & "', jumlah ='" & jumlahTxt.Text & "',id_jenis = (Select id_jenis from tb_jenis where nama_jenis='" & CBjenis.Text & "'), tgl_register ='" & tglRegister.Value.ToString("yyyy-MM-dd") & "', id_ruang = (Select id_ruang from tb_ruang where nama_ruang='" & CBruang.Text & "'), kode_inventaris ='" & kodeTxt.Text & "', id_petugas = (Select id_petugas from tb_petugas where nama_petugas='" & CBpetugas.Text & "'), keterangan ='" & keteranganTxt.Text & "' WHERE id_inventaris = '" & idInventarisTxt.Text & "'"
            CMD = New MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Update Data Inventaris Berhasil Dilakukan.")

        Catch ex As Exception
            MessageBox.Show("Update Data Inventaris gagal dilakukan")
        End Try
        Call tampilUser()
        Call aturDGV()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Call updateUser()
    End Sub
    Sub hapusUser()
        Try
            Call koneksi()
            Dim str As String
            str = "delete from tb_inventaris where id_inventaris = '" & idInventarisTxt.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Inventaris Berhasil Dihapus.")

        Catch ex As Exception
            MessageBox.Show("Data Inventaris Gagal Dihapus.")
        End Try
        Call tampilUser()
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
        DA = New MySqlDataAdapter("select * from tb_inventaris", CONN)
        DS = New DataSet
        DA.Fill(DS, "tb_inventaris")
        'memunculkan data-data di dalam tabel
        Dim tampil As New DataView(tables(0))
        source1.DataSource = tampil
        DGinventaris.DataSource = tampil
        DGinventaris.Refresh()
        'memunculkan data tabel berdasarkan pencarian Txt_Cari(memasukkan ID Anggota)
        tampil.RowFilter = "id_inventaris= '" & cariTxt.Text & "'"
        DGinventaris.Refresh()
    End Sub

    Private Sub DGinventaris_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGinventaris.CellContentClick
        idInventarisTxt.Text = DGinventaris.Rows(e.RowIndex).Cells(0).Value
        namaTxt.Text = DGinventaris.Rows(e.RowIndex).Cells(1).Value
        CBkondisi.Text = DGinventaris.Rows(e.RowIndex).Cells(2).Value
        jumlahTxt.Text = DGinventaris.Rows(e.RowIndex).Cells(3).Value
        CBjenis.Text = DGinventaris.Rows(e.RowIndex).Cells(4).Value
        tglRegister.Text = DGinventaris.Rows(e.RowIndex).Cells(5).Value
        CBruang.Text = DGinventaris.Rows(e.RowIndex).Cells(6).Value
        kodeTxt.Text = DGinventaris.Rows(e.RowIndex).Cells(7).Value
        CBpetugas.Text = DGinventaris.Rows(e.RowIndex).Cells(8).Value
        keteranganTxt.Text = DGinventaris.Rows(e.RowIndex).Cells(9).Value
    End Sub
End Class