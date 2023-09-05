Imports MySql.Data.MySqlClient
Public Class Form1
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
            If RD("id_level").ToString = "1" Then
                Me.Hide()
                FMenu.Show()
                usernameTxt.Focus()
                passwordTxt.Text = ""
                FMenu.FileToolStripMenuItem.Enabled = True
                FMenu.LoginToolStripMenuItem.Enabled = False
                FMenu.LaporanToolStripMenuItem.Enabled = True
                FMenu.JenisToolStripMenuItem.Enabled = True
                FMenu.BingungToolStripMenuItem.Enabled = True
            ElseIf RD("id_level").ToString = "2" Then
                Me.Hide()
                FMenu.Show()
                usernameTxt.Focus()
                passwordTxt.Text = ""
                FMenu.FileToolStripMenuItem.Enabled = True
                FMenu.LoginToolStripMenuItem.Enabled = False
                FMenu.LaporanToolStripMenuItem.Enabled = True
                FMenu.JenisToolStripMenuItem.Enabled = True
                FMenu.BingungToolStripMenuItem.Enabled = True
            ElseIf RD("id_level").ToString = "3" Then
                Me.Hide()
                FMenu.Show()
                usernameTxt.Focus()
                passwordTxt.Text = ""
                FMenu.FileToolStripMenuItem.Enabled = True
                FMenu.LoginToolStripMenuItem.Enabled = False
                FMenu.LaporanToolStripMenuItem.Enabled = True
                FMenu.JenisToolStripMenuItem.Enabled = True
                FMenu.BingungToolStripMenuItem.Enabled = True
                FMenu.PetugasToolStripMenuItem.Enabled = False
            End If
            RD.Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passwordTxt.UseSystemPasswordChar = True
    End Sub

    Private Sub show_Click(sender As Object, e As EventArgs) Handles show.Click
        If passwordTxt.UseSystemPasswordChar = True Then
            passwordTxt.UseSystemPasswordChar = False
        Else
            passwordTxt.UseSystemPasswordChar = True
        End If
    End Sub
End Class