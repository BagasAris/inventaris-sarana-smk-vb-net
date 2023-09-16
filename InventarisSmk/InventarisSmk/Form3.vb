Imports MySql.Data.MySqlClient
Public Class Form3
    Private Sub fUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilUser()
        Call aturDGV()
        Call isiComboLevel()
    End Sub

    Sub isiComboLevel()
        Call koneksi()
        Dim query As String = "select nama_level from tb_level"
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()
        While RD.Read()
            Dim namaLevel As String = RD("nama_level").ToString()
            ComboBox1.Items.Add(namaLevel)
        End While
    End Sub
    Sub tampilUser()

        Call koneksi()
        DA = New MySqlDataAdapter("SELECT tb_petugas.id_petugas, tb_petugas.username, tb_petugas.password, tb_petugas.nama_petugas, tb_level.nama_level " & "FROM tb_petugas " & "INNER JOIN tb_level ON tb_petugas.id_level = tb_level.id_level ", CONN)
        DS = New DataSet
        DA.Fill(DS, "tb_level")
        DGpetugas.DataSource = DS.Tables("tb_level")

    End Sub

    Sub aturDGV()
        Try
            DGpetugas.Columns(0).Width = 70
            DGpetugas.Columns(1).Width = 130
            DGpetugas.Columns(2).Width = 100
            DGpetugas.Columns(3).Width = 150
            DGpetugas.Columns(4).Width = 70
            DGpetugas.Columns(0).HeaderText = "ID PETUGAS"
            DGpetugas.Columns(1).HeaderText = "USERNAME"
            DGpetugas.Columns(2).HeaderText = "PASSWORD"
            DGpetugas.Columns(3).HeaderText = "NAMA PETUGAS"
            DGpetugas.Columns(4).HeaderText = "ID LEVEL"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call Simpan()
    End Sub

    Private Sub DGpetugas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGpetugas.CellContentClick
        idPetugasTxt.Text = DGpetugas.Rows(e.RowIndex).Cells(0).Value
        usernameTxt.Text = DGpetugas.Rows(e.RowIndex).Cells(1).Value
        passwordTxt.Text = DGpetugas.Rows(e.RowIndex).Cells(2).Value
        namaTxt.Text = DGpetugas.Rows(e.RowIndex).Cells(3).Value
        ComboBox1.Text = DGpetugas.Rows(e.RowIndex).Cells(4).Value
    End Sub
    Sub Simpan()
        Call koneksi()
        Try
            Dim str As String
            'str = "INSERT INTO tb_petugas (id_petugas, username, password, nama_petugas, id_level) VALUES ('" & idPetugasTxt.Text & "','" & usernameTxt.Text & "', '" & passwordTxt.Text & "', '" & namaTxt.Text & "',' SELECT id_level FROM tb_level WHERE id_level = '" & idTxt.Text & "')"
            str = "INSERT INTO tb_petugas (id_petugas, username, password, nama_petugas, id_level) VALUES ('" & idPetugasTxt.Text & "','" & usernameTxt.Text & "', '" & passwordTxt.Text & "', '" & namaTxt.Text & "', (Select id_level from tb_level where nama_level='" & ComboBox1.Text & "'))"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Insert Data Petugas Berhasil Dilakukan")
        Catch ex As Exception
            MessageBox.Show("Insert Data Petugas gagal dilakukan.")
        End Try
        Call tampilUser()
        Call aturDGV()
        cariTxt.Text = ""
    End Sub
    Sub updateUser()
        Try
            Call koneksi()
            Dim str As String
            str = "UPDATE tb_petugas SET id_petugas = '" & idPetugasTxt.Text & "', username = '" & usernameTxt.Text & "', password = '" & passwordTxt.Text & "', nama_petugas ='" & namaTxt.Text & "', id_level = (Select id_level from tb_level where nama_level='" & ComboBox1.Text & "') WHERE id_petugas = '" & idPetugasTxt.Text & "'"
            CMD = New MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Update Data Petugas Berhasil Dilakukan.")

        Catch ex As Exception
            MessageBox.Show("Update Data Petugas gagal dilakukan")
        End Try
        Call tampilUser()
        Call aturDGV()
    End Sub
    Sub hapusUser()
        Try
            Call koneksi()
            Dim str As String
            str = "delete from tb_petugas where id_petugas = '" & idPetugasTxt.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Petugas Berhasil Dihapus.")

        Catch ex As Exception
            MessageBox.Show("Data Petugas Gagal Dihapus.")
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
        DA = New MySqlDataAdapter("select * from tb_petugas", CONN)
        DS = New DataSet
        DA.Fill(DS, "tb_petugas")
        'memunculkan data-data di dalam tabel
        Dim tampil As New DataView(tables(0))
        source1.DataSource = tampil
        DGpetugas.DataSource = tampil
        DGpetugas.Refresh()
        'memunculkan data tabel berdasarkan pencarian Txt_Cari(memasukkan ID Anggota)
        tampil.RowFilter = "id_petugas= '" & cariTxt.Text & "'"
        DGpetugas.Refresh()

    End Sub
End Class