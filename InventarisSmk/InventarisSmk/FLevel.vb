Imports MySql.Data.MySqlClient

Public Class FLevel
    Private Sub FLevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilUser()
        Call aturDGV()
    End Sub

    Sub tampilUser()

            Call koneksi()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("select * from tb_level", CONN)
        DS = New DataSet
        DA.Fill(DS, "tb_level")
        DGlevel.DataSource = DS.Tables("tb_level")

    End Sub

        Sub aturDGV()
            Try
            DGlevel.Columns(0).Width = 70
            DGlevel.Columns(1).Width = 130
            DGlevel.Columns(1).HeaderText = "ID LEVEL"
            DGlevel.Columns(2).HeaderText = "NAMA LEVEL"
        Catch ex As Exception
            End Try
        End Sub

        Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
            Call Simpan()
        End Sub

    Private Sub DGpetugas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGlevel.CellContentClick
        idTxt.Text = DGlevel.Rows(e.RowIndex).Cells(0).Value
        namaTxt.Text = DGlevel.Rows(e.RowIndex).Cells(1).Value
    End Sub
    Sub Simpan()
            Call koneksi()
            Try
                Dim str As String
            'str = "INSERT INTO tb_petugas (id_petugas, username, password, nama_petugas, id_level) VALUES ('" & idPetugasTxt.Text & "','" & usernameTxt.Text & "', '" & passwordTxt.Text & "', '" & namaTxt.Text & "',' SELECT id_level FROM tb_level WHERE id_level = '" & idTxt.Text & "')"
            str = "INSERT INTO tb_level (id_level, nama_level) VALUES ('" & idTxt.Text & "','" & namaTxt.Text & "')"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
                CMD.ExecuteNonQuery()
            MessageBox.Show("Insert Data Level Berhasil Dilakukan")
        Catch ex As Exception
            MessageBox.Show("Insert Data Level gagal dilakukan.")
        End Try
            Call tampilUser()
            Call aturDGV()
            cariTxt.Text = ""
        End Sub
        Sub updateUser()
            Try
                Call koneksi()
                Dim str As String
            str = "UPDATE tb_level SET id_level = '" & idTxt.Text & "', nama_level = '" & namaTxt.Text & "' WHERE id_level = '" & idTxt.Text & "'"
            CMD = New MySqlCommand(str, CONN)
                CMD.ExecuteNonQuery()
            MessageBox.Show("Update Data Level Berhasil Dilakukan.")

        Catch ex As Exception
            MessageBox.Show("Update Data Level gagal dilakukan")
        End Try
            Call tampilUser()
            Call aturDGV()
        End Sub
        Sub hapusUser()
            Try
                Call koneksi()
                Dim str As String
            str = "delete from tb_level where id_level = '" & idTxt.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
                CMD.ExecuteNonQuery()
            MessageBox.Show("Data Level Berhasil Dihapus.")

        Catch ex As Exception
            MessageBox.Show("Data Level Gagal Dihapus.")
        End Try
            Call tampilUser()
            Call aturDGV()
        End Sub



        Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
            Call updateUser()
        End Sub

        Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        MessageBox.Show("Apakah Anda Yakin Akan Menghapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Call hapusUser()
    End Sub

        Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        MessageBox.Show("Apakah Anda Yakin Akan Keluar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Me.Close()
    End Sub

        Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles cariBtn.Click
            Dim tables As DataTableCollection = DS.Tables
            Dim source1 As New BindingSource
        DA = New MySqlDataAdapter("select * from tb_level", CONN)
        DS = New DataSet
        DA.Fill(DS, "tb_level")
        'memunculkan data-data di dalam tabel
        Dim tampil As New DataView(tables(0))
            source1.DataSource = tampil
        DGlevel.DataSource = tampil
        DGlevel.Refresh()
        'memunculkan data tabel berdasarkan pencarian Txt_Cari(memasukkan ID Anggota)
        tampil.RowFilter = "nama_level = '" & cariTxt.Text & "'"
        DGlevel.Refresh()

    End Sub
End Class