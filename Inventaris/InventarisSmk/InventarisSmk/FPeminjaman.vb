Imports MySql.Data.MySqlClient
Public Class FPeminjaman
    Private Sub FPeminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilUser()
        Call aturDGV()
    End Sub

    Sub tampilUser()

        Call koneksi()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("select * from tb_peminjaman", CONN)
        DS = New DataSet
        DA.Fill(DS, "tb_peminjaman")
        DGpeminjaman.DataSource = DS.Tables("tb_peminjaman")

    End Sub

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
            str = "INSERT INTO tb_peminjaman (id_peminjaman, tgl_pinjam, tgl_kembali, status_peminjaman, id_pegawai) VALUES ('" & idpPeminjamanTxt.Text & "','" & tglPinjam.Text & "', '" & tglKembali.Text & "', '" & statusTxt.Text & "', '" & idPegawaiTxt.Text & "')"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Insert Data User Berhasil Dilakukan")
        Catch ex As Exception
            MessageBox.Show("Insert data User gagal dilakukan.")
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
            str = "UPDATE tb_peminjaman SET id_peminjaman = '" & idpPeminjamanTxt.Text & "', tgl_pinjam = '" & tglPinjam.Text & "', tgl_kembali = '" & tglKembali.Text & "', status_peminjaman ='" & statusTxt.Text & "', id_pegawai ='" & idPegawaiTxt.Text & "' WHERE id_peminjaman = '" & idpPeminjamanTxt.Text & "'"
            CMD = New MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Update Data User Berhasil Dilakukan.")

        Catch ex As Exception
            MessageBox.Show("Update data User gagal dilakukan")
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
            str = "delete from tb_peminjaman where id_peminjaman = '" & idpPeminjamanTxt.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data User Berhasil Dihapus.")

        Catch ex As Exception
            MessageBox.Show("Data User Gagal Dihapus.")
        End Try
        Call tampilUser()
        Call aturDGV()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Call hapusUser()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
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
        statusTxt.Text = DGpeminjaman.Rows(e.RowIndex).Cells(3).Value
        idPegawaiTxt.Text = DGpeminjaman.Rows(e.RowIndex).Cells(4).Value
    End Sub
End Class