Public Class Form1
    Sub Terkunci()
        LoginToolStripMenuItem.Visible = True
        LogOutToolStripMenuItem.Visible = False
        PetugasToolStripMenuItem.Visible = False
        PegawaiToolStripMenuItem.Visible = False
        LaporanToolStripMenuItem.Visible = False
        StatusToolStripMenuItem.Visible = False
        DetaiPinjamToolStripMenuItem.Visible = False
        PeminjamanToolStripMenuItem.Visible = False
        InventarisToolStripMenuItem.Visible = False
        BingungToolStripMenuItem.Visible = False
        RuangToolStripMenuItem.Visible = False
        JenisToolStripMenuItem.Visible = False
        LevelToolStripMenuItem.Visible = False
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Form2.ShowDialog()
    End Sub

    Private Sub PegawaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegawaiToolStripMenuItem.Click
        Form4.ShowDialog()
    End Sub

    Private Sub PetugasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PetugasToolStripMenuItem.Click
        Form3.ShowDialog()
    End Sub

    Private Sub PeminjamanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeminjamanToolStripMenuItem.Click
        FPeminjaman.ShowDialog()
    End Sub

    Private Sub DetaiPinjamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetaiPinjamToolStripMenuItem.Click
        FDetailPinjam.ShowDialog()
    End Sub

    Private Sub RuangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RuangToolStripMenuItem.Click
        FRuang.ShowDialog()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Hide()
        Form2.ShowDialog()
    End Sub

    Private Sub LevelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LevelToolStripMenuItem.Click
        FLevel.ShowDialog()
    End Sub

    Private Sub JenisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JenisToolStripMenuItem.Click
        FJenis.ShowDialog()
    End Sub

    Private Sub InventarisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarisToolStripMenuItem.Click
        FInventaris.ShowDialog()
    End Sub
End Class