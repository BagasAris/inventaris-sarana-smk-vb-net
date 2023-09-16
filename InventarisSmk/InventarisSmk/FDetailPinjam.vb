Imports MySql.Data.MySqlClient
Public Class FDetailPinjam
    Private Sub FDetailPinjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilUser()
        Call aturDGV()
        Call isiComboInventaris()
    End Sub

    Sub isiComboInventaris()
        Call koneksi()
        Dim query As String = "select nama from tb_inventaris"
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()
        While RD.Read()
            Dim namaInventaris As String = RD("nama").ToString()
            ComboBox1.Items.Add(namaInventaris)
        End While
    End Sub

    Sub tampilUser()

        Call koneksi()
        DA = New MySqlDataAdapter("SELECT tb_detail_pinjam.id_detail_pinjam, tb_inventaris.nama, tb_detail_pinjam.jumlah " &
        "FROM tb_detail_pinjam " &
        "INNER JOIN tb_inventaris ON tb_detail_pinjam.id_inventaris = tb_inventaris.id_inventaris", CONN)
        DS = New DataSet
        DA.Fill(DS, "tb_detail_pinjam")
        DGdetail.DataSource = DS.Tables("tb_detail_pinjam")

    End Sub

    Sub aturDGV()
        Try
            DGdetail.Columns(0).Width = 70
            DGdetail.Columns(1).Width = 130
            DGdetail.Columns(2).Width = 100
            DGdetail.Columns(0).HeaderText = "ID DETAIL PINJAM"
            DGdetail.Columns(1).HeaderText = "ID IVENTARIS"
            DGdetail.Columns(2).HeaderText = "JUMLAH"
        Catch ex As Exception
        End Try
    End Sub

    Sub Simpan()
        Call koneksi()
        Try
            Dim str As String
            'str = "INSERT INTO tb_petugas (id_petugas, username, password, nama_petugas, id_level) VALUES ('" & idPetugasTxt.Text & "','" & usernameTxt.Text & "', '" & passwordTxt.Text & "', '" & namaTxt.Text & "',' SELECT id_level FROM tb_level WHERE id_level = '" & idTxt.Text & "')"
            str = "INSERT INTO tb_detail_pinjam (id_detail_pinjam, id_inventaris, jumlah) VALUES ('" & idDetailTxt.Text & "',(Select id_inventaris from tb_inventaris where nama='" & ComboBox1.Text & "'),'" & jumlahTxt.Text & "')"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Insert Data Detail Pinjam Berhasil Dilakukan")
        Catch ex As Exception
            MessageBox.Show("Insert Data Detail Pinjam gagal dilakukan.")
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
            str = "UPDATE tb_detail_pinjam SET id_detail_pinjam = '" & idDetailTxt.Text & "', id_inventaris = (Select id_inventaris from tb_inventaris where nama='" & ComboBox1.Text & "'), jumlah = '" & jumlahTxt.Text & "' WHERE id_detail_pinjam = '" & idDetailTxt.Text & "'"
            CMD = New MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Update Data Detail Pinjam Berhasil Dilakukan.")

        Catch ex As Exception
            MessageBox.Show("Update Data Detail Pinjam gagal dilakukan")
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
            str = "delete from tb_detail_pinjam where id_detail_pinjam = '" & idDetailTxt.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Detail Pinjam Berhasil Dihapus.")

        Catch ex As Exception
            MessageBox.Show("Data Detail Pinjam Gagal Dihapus.")
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

    Private Sub DGdetail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGdetail.CellContentClick
        idDetailTxt.Text = DGdetail.Rows(e.RowIndex).Cells(0).Value
        ComboBox1.Text = DGdetail.Rows(e.RowIndex).Cells(1).Value
        jumlahTxt.Text = DGdetail.Rows(e.RowIndex).Cells(2).Value
    End Sub

    Private Sub cariBtn_Click(sender As Object, e As EventArgs) Handles cariBtn.Click
        Dim tables As DataTableCollection = DS.Tables
        Dim source1 As New BindingSource
        DA = New MySqlDataAdapter("select * from tb_detail_pinjam", CONN)
        DS = New DataSet
        DA.Fill(DS, "tb_detail_pinjam")
        'memunculkan data-data di dalam tabel
        Dim tampil As New DataView(tables(0))
        source1.DataSource = tampil
        DGdetail.DataSource = tampil
        DGdetail.Refresh()
        'memunculkan data tabel berdasarkan pencarian Txt_Cari(memasukkan ID Anggota)
        tampil.RowFilter = "id_detail_pinjam= '" & cariTxt.Text & "'"
        DGdetail.Refresh()
    End Sub
End Class