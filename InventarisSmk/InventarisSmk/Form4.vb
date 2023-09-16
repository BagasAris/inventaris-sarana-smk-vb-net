Imports MySql.Data.MySqlClient

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilUser()
        Call aturDGV()
    End Sub

    Sub tampilUser()

        Call koneksi()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("select * from tb_pegawai", CONN)
        DS = New DataSet
        DA.Fill(DS, "tb_pegawai")
        DGpegawai.DataSource = DS.Tables("tb_pegawai")

    End Sub

    Sub aturDGV()
        Try
            DGpegawai.Columns(0).Width = 70
            DGpegawai.Columns(1).Width = 130
            DGpegawai.Columns(2).Width = 100
            DGpegawai.Columns(3).Width = 150
            DGpegawai.Columns(0).HeaderText = "ID PEGAWAI"
            DGpegawai.Columns(1).HeaderText = "NAMA PEGAWAI"
            DGpegawai.Columns(2).HeaderText = "NIP"
            DGpegawai.Columns(3).HeaderText = "ALAMAT"
        Catch ex As Exception
        End Try
    End Sub

    Sub Simpan()
        Call koneksi()
        Try
            Dim str As String
            'str = "INSERT INTO tb_petugas (id_petugas, username, password, nama_petugas, id_level) VALUES ('" & idPetugasTxt.Text & "','" & usernameTxt.Text & "', '" & passwordTxt.Text & "', '" & namaTxt.Text & "',' SELECT id_level FROM tb_level WHERE id_level = '" & idTxt.Text & "')"
            str = "INSERT INTO tb_pegawai (id_pegawai, nama_pegawai, nip, alamat) VALUES ('" & idPegawaiTxt.Text & "','" & namaTxt.Text & "', '" & nipTxt.Text & "', '" & alamatTxt.Text & "')"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Insert Data Pegawai Berhasil Dilakukan")
        Catch ex As Exception
            MessageBox.Show("Insert Data Pegawai gagal dilakukan.")
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
            str = "UPDATE tb_pegawai SET id_pegawai = '" & idPegawaiTxt.Text & "', nama_pegawai = '" & namaTxt.Text & "', nip = '" & nipTxt.Text & "', alamat ='" & alamatTxt.Text & "' WHERE id_pegawai = '" & idPegawaiTxt.Text & "'"
            CMD = New MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Update Data Pegawai Berhasil Dilakukan.")

        Catch ex As Exception
            MessageBox.Show("Update Data Pegawai gagal dilakukan")
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
            str = "delete from tb_pegawai where id_pegawai = '" & idPegawaiTxt.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Pegawai Berhasil Dihapus.")

        Catch ex As Exception
            MessageBox.Show("Data Pegawai Gagal Dihapus.")
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
        DA = New MySqlDataAdapter("select * from tb_pegawai", CONN)
        DS = New DataSet
        DA.Fill(DS, "tb_pegawai")
        'memunculkan data-data di dalam tabel
        Dim tampil As New DataView(tables(0))
        source1.DataSource = tampil
        DGpegawai.DataSource = tampil
        DGpegawai.Refresh()
        'memunculkan data tabel berdasarkan pencarian Txt_Cari(memasukkan ID Anggota)
        tampil.RowFilter = "nama_pegawai= '" & cariTxt.Text & "'"
        DGpegawai.Refresh()
    End Sub

    Private Sub DGpegawai_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGpegawai.CellContentClick
        idPegawaiTxt.Text = DGpegawai.Rows(e.RowIndex).Cells(0).Value
        namaTxt.Text = DGpegawai.Rows(e.RowIndex).Cells(1).Value
        nipTxt.Text = DGpegawai.Rows(e.RowIndex).Cells(2).Value
        alamatTxt.Text = DGpegawai.Rows(e.RowIndex).Cells(3).Value
    End Sub
End Class