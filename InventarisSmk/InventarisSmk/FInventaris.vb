Imports MySql.Data.MySqlClient

Public Class FInventaris
    Private Sub FInventaris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilUser()
        Call aturDGV()
    End Sub

    Sub tampilUser()

            Call koneksi()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("select * from tb_inventaris", CONN)
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
            str = "INSERT INTO tb_inventaris (id_inventaris, nama, kondisi, jumlah, id_jenis, tgl_register, id_ruang, kode_inventaris, id_petugas, keterangan) VALUES ('" & idInventarisTxt.Text & "','" & namaTxt.Text & "', '" & kondisiTxt.Text & "', '" & jumlahTxt.Text & "', '" & idJenisTxt.Text & "','" & tglRegister.Value.ToString("yyyy-MM-dd") & "','" & idRuangTxt.Text & "','" & kodeTxt.Text & "','" & idPetugasTxt.Text & "','" & keteranganTxt.Text & "')"
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
            str = "UPDATE tb_inventaris SET id_inventaris = '" & idInventarisTxt.Text & "', nama = '" & namaTxt.Text & "', kondisi = '" & kondisiTxt.Text & "', jumlah ='" & jumlahTxt.Text & "', id_jenis ='" & idJenisTxt.Text & "', tgl_register ='" & tglRegister.Value.ToString("yyyy-MM-dd") & "', id_ruang ='" & idRuangTxt.Text & "', kode_inventaris ='" & kodeTxt.Text & "', id_petugas ='" & idPetugasTxt.Text & "', keterangan ='" & keteranganTxt.Text & "' WHERE id_inventaris = '" & idInventarisTxt.Text & "'"
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
            str = "delete from tb_inventaris where id_inventaris = '" & idInventarisTxt.Text & "'"
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
        kondisiTxt.Text = DGinventaris.Rows(e.RowIndex).Cells(2).Value
        jumlahTxt.Text = DGinventaris.Rows(e.RowIndex).Cells(3).Value
        idJenisTxt.Text = DGinventaris.Rows(e.RowIndex).Cells(4).Value
        tglRegister.Text = DGinventaris.Rows(e.RowIndex).Cells(5).Value
        idRuangTxt.Text = DGinventaris.Rows(e.RowIndex).Cells(6).Value
        kodeTxt.Text = DGinventaris.Rows(e.RowIndex).Cells(7).Value
        idPetugasTxt.Text = DGinventaris.Rows(e.RowIndex).Cells(8).Value
        keteranganTxt.Text = DGinventaris.Rows(e.RowIndex).Cells(9).Value
    End Sub
End Class