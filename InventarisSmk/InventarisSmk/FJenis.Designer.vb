<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FJenis
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
        Me.idTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.cariBtn = New System.Windows.Forms.Button()
        Me.cariTxt = New System.Windows.Forms.TextBox()
        Me.keteranganTxt = New System.Windows.Forms.TextBox()
        Me.kodeTxt = New System.Windows.Forms.TextBox()
        Me.namaTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGjenis = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGjenis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'idTxt
        '
        Me.idTxt.Location = New System.Drawing.Point(152, 123)
        Me.idTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.idTxt.Name = "idTxt"
        Me.idTxt.Size = New System.Drawing.Size(298, 20)
        Me.idTxt.TabIndex = 58
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(14, 127)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 15)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "ID JENIS"
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnKeluar.ForeColor = System.Drawing.Color.White
        Me.btnKeluar.Location = New System.Drawing.Point(376, 379)
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
        Me.btnHapus.Location = New System.Drawing.Point(252, 379)
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
        Me.btnEdit.Location = New System.Drawing.Point(17, 379)
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
        Me.btnSimpan.Location = New System.Drawing.Point(131, 379)
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
        Me.cariBtn.Location = New System.Drawing.Point(831, 117)
        Me.cariBtn.Name = "cariBtn"
        Me.cariBtn.Size = New System.Drawing.Size(74, 27)
        Me.cariBtn.TabIndex = 52
        Me.cariBtn.Text = "CARI"
        Me.cariBtn.UseVisualStyleBackColor = False
        '
        'cariTxt
        '
        Me.cariTxt.Location = New System.Drawing.Point(591, 119)
        Me.cariTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cariTxt.Name = "cariTxt"
        Me.cariTxt.Size = New System.Drawing.Size(220, 20)
        Me.cariTxt.TabIndex = 51
        '
        'keteranganTxt
        '
        Me.keteranganTxt.Location = New System.Drawing.Point(152, 296)
        Me.keteranganTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.keteranganTxt.Name = "keteranganTxt"
        Me.keteranganTxt.Size = New System.Drawing.Size(298, 20)
        Me.keteranganTxt.TabIndex = 50
        '
        'kodeTxt
        '
        Me.kodeTxt.Location = New System.Drawing.Point(152, 239)
        Me.kodeTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.kodeTxt.Name = "kodeTxt"
        Me.kodeTxt.Size = New System.Drawing.Size(298, 20)
        Me.kodeTxt.TabIndex = 49
        '
        'namaTxt
        '
        Me.namaTxt.Location = New System.Drawing.Point(152, 181)
        Me.namaTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.namaTxt.Name = "namaTxt"
        Me.namaTxt.Size = New System.Drawing.Size(298, 20)
        Me.namaTxt.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(495, 123)
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
        Me.Label5.Location = New System.Drawing.Point(14, 299)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 15)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "KETERANGAN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(14, 242)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 15)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "KODE JENIS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(14, 185)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "NAMA JENIS"
        '
        'DGjenis
        '
        Me.DGjenis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGjenis.Location = New System.Drawing.Point(488, 181)
        Me.DGjenis.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DGjenis.Name = "DGjenis"
        Me.DGjenis.Size = New System.Drawing.Size(417, 225)
        Me.DGjenis.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(338, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 41)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "FORM JENIS"
        '
        'FJenis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(918, 450)
        Me.Controls.Add(Me.idTxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.cariBtn)
        Me.Controls.Add(Me.cariTxt)
        Me.Controls.Add(Me.keteranganTxt)
        Me.Controls.Add(Me.kodeTxt)
        Me.Controls.Add(Me.namaTxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DGjenis)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FJenis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FJenis"
        CType(Me.DGjenis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents idTxt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents cariBtn As Button
    Friend WithEvents cariTxt As TextBox
    Friend WithEvents keteranganTxt As TextBox
    Friend WithEvents kodeTxt As TextBox
    Friend WithEvents namaTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DGjenis As DataGridView
    Friend WithEvents Label1 As Label
End Class
