<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FInventaris
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
        Me.idInventarisTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.cariBtn = New System.Windows.Forms.Button()
        Me.cariTxt = New System.Windows.Forms.TextBox()
        Me.idRuangTxt = New System.Windows.Forms.TextBox()
        Me.idJenisTxt = New System.Windows.Forms.TextBox()
        Me.kondisiTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGinventaris = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.namaTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.jumlahTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.kodeTxt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.idPetugasTxt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.keteranganTxt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tglRegister = New System.Windows.Forms.DateTimePicker()
        CType(Me.DGinventaris, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'idInventarisTxt
        '
        Me.idInventarisTxt.Location = New System.Drawing.Point(150, 60)
        Me.idInventarisTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.idInventarisTxt.Name = "idInventarisTxt"
        Me.idInventarisTxt.Size = New System.Drawing.Size(298, 20)
        Me.idInventarisTxt.TabIndex = 58
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(12, 64)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 15)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "ID INVENTARIS"
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnKeluar.ForeColor = System.Drawing.Color.White
        Me.btnKeluar.Location = New System.Drawing.Point(379, 394)
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
        Me.btnHapus.Location = New System.Drawing.Point(255, 394)
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
        Me.btnEdit.Location = New System.Drawing.Point(20, 394)
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
        Me.btnSimpan.Location = New System.Drawing.Point(134, 394)
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
        Me.cariBtn.Location = New System.Drawing.Point(828, 394)
        Me.cariBtn.Name = "cariBtn"
        Me.cariBtn.Size = New System.Drawing.Size(74, 27)
        Me.cariBtn.TabIndex = 52
        Me.cariBtn.Text = "CARI"
        Me.cariBtn.UseVisualStyleBackColor = False
        '
        'cariTxt
        '
        Me.cariTxt.Location = New System.Drawing.Point(588, 396)
        Me.cariTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cariTxt.Name = "cariTxt"
        Me.cariTxt.Size = New System.Drawing.Size(233, 20)
        Me.cariTxt.TabIndex = 51
        '
        'idRuangTxt
        '
        Me.idRuangTxt.Location = New System.Drawing.Point(605, 84)
        Me.idRuangTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.idRuangTxt.Name = "idRuangTxt"
        Me.idRuangTxt.Size = New System.Drawing.Size(298, 20)
        Me.idRuangTxt.TabIndex = 50
        '
        'idJenisTxt
        '
        Me.idJenisTxt.Location = New System.Drawing.Point(150, 164)
        Me.idJenisTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.idJenisTxt.Name = "idJenisTxt"
        Me.idJenisTxt.Size = New System.Drawing.Size(298, 20)
        Me.idJenisTxt.TabIndex = 49
        '
        'kondisiTxt
        '
        Me.kondisiTxt.Location = New System.Drawing.Point(150, 112)
        Me.kondisiTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.kondisiTxt.Name = "kondisiTxt"
        Me.kondisiTxt.Size = New System.Drawing.Size(298, 20)
        Me.kondisiTxt.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(505, 401)
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
        Me.Label5.Location = New System.Drawing.Point(467, 87)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 15)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "ID RUANG"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 167)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "ID JENIS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 116)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "KONDISI"
        '
        'DGinventaris
        '
        Me.DGinventaris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGinventaris.Location = New System.Drawing.Point(12, 202)
        Me.DGinventaris.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DGinventaris.Name = "DGinventaris"
        Me.DGinventaris.Size = New System.Drawing.Size(891, 186)
        Me.DGinventaris.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(261, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 41)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "FORM INVENTARIS"
        '
        'namaTxt
        '
        Me.namaTxt.Location = New System.Drawing.Point(150, 86)
        Me.namaTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.namaTxt.Name = "namaTxt"
        Me.namaTxt.Size = New System.Drawing.Size(298, 20)
        Me.namaTxt.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "NAMA"
        '
        'jumlahTxt
        '
        Me.jumlahTxt.Location = New System.Drawing.Point(150, 138)
        Me.jumlahTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.jumlahTxt.Name = "jumlahTxt"
        Me.jumlahTxt.Size = New System.Drawing.Size(298, 20)
        Me.jumlahTxt.TabIndex = 62
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(12, 142)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 15)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "JUMLAH"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(467, 62)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 15)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "TANGGAL REGISTER"
        '
        'kodeTxt
        '
        Me.kodeTxt.Location = New System.Drawing.Point(605, 110)
        Me.kodeTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.kodeTxt.Name = "kodeTxt"
        Me.kodeTxt.Size = New System.Drawing.Size(298, 20)
        Me.kodeTxt.TabIndex = 66
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(467, 114)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 15)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "KODE INVENTARIS"
        '
        'idPetugasTxt
        '
        Me.idPetugasTxt.Location = New System.Drawing.Point(605, 136)
        Me.idPetugasTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.idPetugasTxt.Name = "idPetugasTxt"
        Me.idPetugasTxt.Size = New System.Drawing.Size(298, 20)
        Me.idPetugasTxt.TabIndex = 68
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(467, 140)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 15)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "ID PETUGAS"
        '
        'keteranganTxt
        '
        Me.keteranganTxt.Location = New System.Drawing.Point(605, 165)
        Me.keteranganTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.keteranganTxt.Name = "keteranganTxt"
        Me.keteranganTxt.Size = New System.Drawing.Size(298, 20)
        Me.keteranganTxt.TabIndex = 70
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(467, 169)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 15)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "KETERANGAN"
        '
        'tglRegister
        '
        Me.tglRegister.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tglRegister.Location = New System.Drawing.Point(605, 57)
        Me.tglRegister.Name = "tglRegister"
        Me.tglRegister.Size = New System.Drawing.Size(298, 20)
        Me.tglRegister.TabIndex = 71
        '
        'FInventaris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(914, 450)
        Me.Controls.Add(Me.tglRegister)
        Me.Controls.Add(Me.keteranganTxt)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.idPetugasTxt)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.kodeTxt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.jumlahTxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.namaTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.idInventarisTxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.cariBtn)
        Me.Controls.Add(Me.cariTxt)
        Me.Controls.Add(Me.idRuangTxt)
        Me.Controls.Add(Me.idJenisTxt)
        Me.Controls.Add(Me.kondisiTxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DGinventaris)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FInventaris"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FInventaris"
        CType(Me.DGinventaris, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents idInventarisTxt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents cariBtn As Button
    Friend WithEvents cariTxt As TextBox
    Friend WithEvents idRuangTxt As TextBox
    Friend WithEvents idJenisTxt As TextBox
    Friend WithEvents kondisiTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DGinventaris As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents namaTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents jumlahTxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents kodeTxt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents idPetugasTxt As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents keteranganTxt As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tglRegister As DateTimePicker
End Class
