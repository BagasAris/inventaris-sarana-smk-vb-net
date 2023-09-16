Imports MySql.Data.MySqlClient

Public Class FJenis
    Private Sub FJenis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilUser()
        Call aturDGV()
    End Sub

    Sub tampilUser()

            Call koneksi()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("select * from tb_jenis", CONN)
        DS = New DataSet
        DA.Fill(DS, "tb_jenis")
        DGjenis.DataSource = DS.Tables("tb_jenis")

    End Sub

        Sub aturDGV()
            Try
            DGjenis.Columns(0).Width = 70
            DGjenis.Columns(1).Width = 130
            DGjenis.Columns(2).Width = 100
            DGjenis.Columns(3).Width = 150
            DGjenis.Columns(0).HeaderText = "ID JENIS"
            DGjenis.Columns(1).HeaderText = "NAMA JENIS"
            DGjenis.Columns(2).HeaderText = "KODE JENIS"
            DGjenis.Columns(3).HeaderText = "KETERANGAN"
        Catch ex As Exception
            End Try
        End Sub

        Sub Simpan()
            Call koneksi()
            Try
                Dim str As String
            'str = "INSERT INTO tb_petugas (id_petugas, username, password, nama_petugas, id_level) VALUES ('" & idPetugasTxt.Text & "','" & usernameTxt.Text & "', '" & passwordTxt.Text & "', '" & namaTxt.Text & "',' SELECT id_level FROM tb_level WHERE id_level = '" & idTxt.Text & "')"
            str = "INSERT INTO tb_jenis (id_jenis, nama_jenis, kode_jenis, keterangan) VALUES ('" & idTxt.Text & "','" & namaTxt.Text & "', '" & kodeTxt.Text & "', '" & keteranganTxt.Text & "')"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
                CMD.ExecuteNonQuery()
            MessageBox.Show("Insert Data Jenis Berhasil Dilakukan")
        Catch ex As Exception
            MessageBox.Show("Insert Data Jenis gagal dilakukan.")
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
            str = "UPDATE tb_jenis SET id_jenis = '" & idTxt.Text & "', nama_jenis = '" & namaTxt.Text & "', kode_jenis = '" & kodeTxt.Text & "', keterangan ='" & keteranganTxt.Text & "' WHERE id_jenis = '" & idTxt.Text & "'"
            CMD = New MySqlCommand(str, CONN)
                CMD.ExecuteNonQuery()
            MessageBox.Show("Update Data Jenis Berhasil Dilakukan.")

        Catch ex As Exception
            MessageBox.Show("Update Data Jenis gagal dilakukan")
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
            str = "delete from tb_jenis where id_jenis = '" & idTxt.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
                CMD.ExecuteNonQuery()
            MessageBox.Show("Data Jenis Berhasil Dihapus.")

        Catch ex As Exception
            MessageBox.Show("Data Jenis Gagal Dihapus.")
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
        DA = New MySqlDataAdapter("select * from tb_jenis", CONN)
        DS = New DataSet
        DA.Fill(DS, "tb_jenis")
        'memunculkan data-data di dalam tabel
        Dim tampil As New DataView(tables(0))
            source1.DataSource = tampil
        DGjenis.DataSource = tampil
        DGjenis.Refresh()
        'memunculkan data tabel berdasarkan pencarian Txt_Cari(memasukkan ID Anggota)
        tampil.RowFilter = "id_jenis= '" & cariTxt.Text & "'"
        DGjenis.Refresh()
    End Sub

    Private Sub DGpegawai_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGjenis.CellContentClick
        idTxt.Text = DGjenis.Rows(e.RowIndex).Cells(0).Value
        namaTxt.Text = DGjenis.Rows(e.RowIndex).Cells(1).Value
        kodeTxt.Text = DGjenis.Rows(e.RowIndex).Cells(2).Value
        keteranganTxt.Text = DGjenis.Rows(e.RowIndex).Cells(3).Value
    End Sub
End Class
