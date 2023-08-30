Imports MySql.Data.MySqlClient
Public Class Form2

    Sub Terbuka()
        Form1.LoginToolStripMenuItem.Visible = False
        Form1.LogOutToolStripMenuItem.Visible = True
        Form1.PetugasToolStripMenuItem.Visible = True
        Form1.PegawaiToolStripMenuItem.Visible = True
        Form1.LaporanToolStripMenuItem.Visible = True
        Form1.StatusToolStripMenuItem.Visible = True
        Form1.DetaiPinjamToolStripMenuItem.Visible = True
        Form1.PeminjamanToolStripMenuItem.Visible = True
        Form1.InventarisToolStripMenuItem.Visible = True
        Form1.BingungToolStripMenuItem.Visible = True
        Form1.RuangToolStripMenuItem.Visible = True
        Form1.JenisToolStripMenuItem.Visible = True
        Form1.LevelToolStripMenuItem.Visible = True
    End Sub
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If usernameTxt.Text = "" Or passwordTxt.Text = "" Then
            MessageBox.Show("Harap isi username dan password!")
        Else
            Call koneksi()
            CMD = New MySqlCommand("Select * from tb_petugas where username ='" & usernameTxt.Text & "' and password = '" & passwordTxt.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                Me.Hide()
                Call Terbuka()
            Else
                RD.Close()
                MessageBox.Show("Periksa Kembali username dan password", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
                usernameTxt.Focus()
                passwordTxt.Text = ""
            End If
            RD.Close()
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class