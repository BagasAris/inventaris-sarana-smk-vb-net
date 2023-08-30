Imports MySql.Data.MySqlClient

Public Class FRuang
    Private Sub FRuang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call tampilUser()
        Call aturDGV()
    End Sub

    Sub tampilUser()

        Call koneksi()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("select * from tb_ruang", CONN)
        DS = New DataSet
        DA.Fill(DS, "tb_ruang")
        DGruang.DataSource = DS.Tables("tb_ruang")

    End Sub
    Sub aturDGV()
        Try
            DGruang.Columns(0).Width = 70
            DGruang.Columns(1).Width = 130
            DGruang.Columns(2).Width = 100
            DGruang.Columns(3).Width = 150
            DGruang.Columns(0).HeaderText = "ID RUANG"
            DGruang.Columns(1).HeaderText = "NAMA RUANG"
            DGruang.Columns(2).HeaderText = "KODE RUANG"
            DGruang.Columns(3).HeaderText = "KETERANGAN"
        Catch ex As Exception
        End Try
    End Sub

    Sub Simpan()
        Call koneksi()
        Try
            Dim str As String
            'str = "INSERT INTO tb_petugas (id_petugas, username, password, nama_petugas, id_level) VALUES ('" & idPetugasTxt.Text & "','" & usernameTxt.Text & "', '" & passwordTxt.Text & "', '" & namaTxt.Text & "',' SELECT id_level FROM tb_level WHERE id_level = '" & idTxt.Text & "')"
            str = "INSERT INTO tb_ruang (id_ruang, nama_ruang, kode_ruang, keterangan) VALUES ('" & idRuangTxt.Text & "','" & namaTxt.Text & "', '" & kodeTxt.Text & "','" & keteranganTxt.Text & "')"
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
            str = "UPDATE tb_ruang SET id_ruang = '" & idRuangTxt.Text & "', nama_ruang = '" & namaTxt.Text & "', kode_ruang = '" & kodeTxt.Text & "', keterangan = '" & keteranganTxt.Text & "' WHERE id_ruang = '" & idRuangTxt.Text & "'"
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
            str = "delete from tb_ruang where id_ruang = '" & idRuangTxt.Text & "'"
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

    Private Sub DGDGruang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGruang.CellContentClick
        idRuangTxt.Text = DGruang.Rows(e.RowIndex).Cells(0).Value
        namaTxt.Text = DGruang.Rows(e.RowIndex).Cells(1).Value
        kodeTxt.Text = DGruang.Rows(e.RowIndex).Cells(2).Value
        keteranganTxt.Text = DGruang.Rows(e.RowIndex).Cells(3).Value
    End Sub

    Private Sub cariBtn_Click(sender As Object, e As EventArgs) Handles cariBtn.Click
        Dim tables As DataTableCollection = DS.Tables
        Dim source1 As New BindingSource
        DA = New MySqlDataAdapter("select * from tb_ruang", CONN)
        DS = New DataSet
        DA.Fill(DS, "tb_ruang")
        'memunculkan data-data di dalam tabel
        Dim tampil As New DataView(tables(0))
        source1.DataSource = tampil
        DGruang.DataSource = tampil
        DGruang.Refresh()
        'memunculkan data tabel berdasarkan pencarian Txt_Cari(memasukkan ID Anggota)
        tampil.RowFilter = "id_ruang= '" & cariTxt.Text & "'"
        DGruang.Refresh()
    End Sub
End Class
