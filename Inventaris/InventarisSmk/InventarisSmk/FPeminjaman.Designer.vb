<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPeminjaman
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.idpPeminjamanTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.cariBtn = New System.Windows.Forms.Button()
        Me.cariTxt = New System.Windows.Forms.TextBox()
        Me.idPegawaiTxt = New System.Windows.Forms.TextBox()
        Me.statusTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGpeminjaman = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tglPinjam = New System.Windows.Forms.DateTimePicker()
        Me.tglKembali = New System.Windows.Forms.DateTimePicker()
        CType(Me.DGpeminjaman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'idpPeminjamanTxt
        '
        Me.idpPeminjamanTxt.Location = New System.Drawing.Point(157, 115)
        Me.idpPeminjamanTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.idpPeminjamanTxt.Name = "idpPeminjamanTxt"
        Me.idpPeminjamanTxt.Size = New System.Drawing.Size(288, 20)
        Me.idpPeminjamanTxt.TabIndex = 58
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(9, 119)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 15)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "ID PEMINJAMAN"
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnKeluar.ForeColor = System.Drawing.Color.White
        Me.btnKeluar.Location = New System.Drawing.Point(371, 371)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(74, 27)
        Me.btnKeluar.TabIndex = 56
        Me.btnKeluar.Text = "KELUAR"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Location = New System.Drawing.Point(247, 371)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(74, 27)
        Me.btnHapus.TabIndex = 55
        Me.btnHapus.Text = "HAPUS"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(12, 371)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(74, 27)
        Me.btnEdit.TabIndex = 54
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(126, 371)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(74, 27)
        Me.btnSimpan.TabIndex = 53
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'cariBtn
        '
        Me.cariBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cariBtn.ForeColor = System.Drawing.Color.White
        Me.cariBtn.Location = New System.Drawing.Point(826, 109)
        Me.cariBtn.Name = "cariBtn"
        Me.cariBtn.Size = New System.Drawing.Size(74, 27)
        Me.cariBtn.TabIndex = 52
        Me.cariBtn.Text = "CARI"
        Me.cariBtn.UseVisualStyleBackColor = False
        '
        'cariTxt
        '
        Me.cariTxt.Location = New System.Drawing.Point(586, 111)
        Me.cariTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cariTxt.Name = "cariTxt"
        Me.cariTxt.Size = New System.Drawing.Size(220, 20)
        Me.cariTxt.TabIndex = 51
        '
        'idPegawaiTxt
        '
        Me.idPegawaiTxt.Location = New System.Drawing.Point(157, 288)
        Me.idPegawaiTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.idPegawaiTxt.Name = "idPegawaiTxt"
        Me.idPegawaiTxt.Size = New System.Drawing.Size(288, 20)
        Me.idPegawaiTxt.TabIndex = 50
        '
        'statusTxt
        '
        Me.statusTxt.Location = New System.Drawing.Point(157, 242)
        Me.statusTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.statusTxt.Name = "statusTxt"
        Me.statusTxt.Size = New System.Drawing.Size(288, 20)
        Me.statusTxt.TabIndex = 49
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(490, 115)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 15)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "CARI DATA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(9, 291)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 15)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "ID PEGAWAI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(-45, 242)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 15)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "NIP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(9, 163)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 15)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "TANGGAL PINJAM"
        '
        'DGpeminjaman
        '
        Me.DGpeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGpeminjaman.Location = New System.Drawing.Point(483, 173)
        Me.DGpeminjaman.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DGpeminjaman.Name = "DGpeminjaman"
        Me.DGpeminjaman.Size = New System.Drawing.Size(417, 225)
        Me.DGpeminjaman.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(240, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(458, 41)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "FROM DATA PEMINJAMAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(9, 244)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 15)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "STATUS PEMINJAMAN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(9, 202)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 15)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "TANGGAL KEMBALI"
        '
        'tglPinjam
        '
        Me.tglPinjam.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tglPinjam.Location = New System.Drawing.Point(157, 163)
        Me.tglPinjam.Name = "tglPinjam"
        Me.tglPinjam.Size = New System.Drawing.Size(288, 20)
        Me.tglPinjam.TabIndex = 62
        '
        'tglKembali
        '
        Me.tglKembali.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tglKembali.Location = New System.Drawing.Point(157, 202)
        Me.tglKembali.Name = "tglKembali"
        Me.tglKembali.Size = New System.Drawing.Size(288, 20)
        Me.tglKembali.TabIndex = 63
        '
        'FPeminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(909, 450)
        Me.Controls.Add(Me.tglKembali)
        Me.Controls.Add(Me.tglPinjam)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.idpPeminjamanTxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.cariBtn)
        Me.Controls.Add(Me.cariTxt)
        Me.Controls.Add(Me.idPegawaiTxt)
        Me.Controls.Add(Me.statusTxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DGpeminjaman)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FPeminjaman"
        Me.Text = "FPeminjaman"
        CType(Me.DGpeminjaman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents idpPeminjamanTxt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents cariBtn As Button
    Friend WithEvents cariTxt As TextBox
    Friend WithEvents idPegawaiTxt As TextBox
    Friend WithEvents statusTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DGpeminjaman As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tglPinjam As DateTimePicker
    Friend WithEvents tglKembali As DateTimePicker
End Class
