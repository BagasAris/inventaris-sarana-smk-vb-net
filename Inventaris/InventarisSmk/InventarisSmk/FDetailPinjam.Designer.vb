<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FDetailPinjam
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.idDetailTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.cariBtn = New System.Windows.Forms.Button()
        Me.cariTxt = New System.Windows.Forms.TextBox()
        Me.jumlahTxt = New System.Windows.Forms.TextBox()
        Me.idIventarisTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DGdetail = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGdetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 181)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 15)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "ID IVENTARIS"
        '
        'idDetailTxt
        '
        Me.idDetailTxt.Location = New System.Drawing.Point(156, 94)
        Me.idDetailTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.idDetailTxt.Name = "idDetailTxt"
        Me.idDetailTxt.Size = New System.Drawing.Size(288, 20)
        Me.idDetailTxt.TabIndex = 78
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(8, 98)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 15)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "ID DETAIL PINJAM"
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnKeluar.ForeColor = System.Drawing.Color.White
        Me.btnKeluar.Location = New System.Drawing.Point(370, 350)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(74, 27)
        Me.btnKeluar.TabIndex = 76
        Me.btnKeluar.Text = "KELUAR"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Location = New System.Drawing.Point(246, 350)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(74, 27)
        Me.btnHapus.TabIndex = 75
        Me.btnHapus.Text = "HAPUS"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(11, 350)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(74, 27)
        Me.btnEdit.TabIndex = 74
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(125, 350)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(74, 27)
        Me.btnSimpan.TabIndex = 73
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'cariBtn
        '
        Me.cariBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cariBtn.ForeColor = System.Drawing.Color.White
        Me.cariBtn.Location = New System.Drawing.Point(825, 88)
        Me.cariBtn.Name = "cariBtn"
        Me.cariBtn.Size = New System.Drawing.Size(74, 27)
        Me.cariBtn.TabIndex = 72
        Me.cariBtn.Text = "CARI"
        Me.cariBtn.UseVisualStyleBackColor = False
        '
        'cariTxt
        '
        Me.cariTxt.Location = New System.Drawing.Point(585, 90)
        Me.cariTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cariTxt.Name = "cariTxt"
        Me.cariTxt.Size = New System.Drawing.Size(220, 20)
        Me.cariTxt.TabIndex = 71
        '
        'jumlahTxt
        '
        Me.jumlahTxt.Location = New System.Drawing.Point(156, 267)
        Me.jumlahTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.jumlahTxt.Name = "jumlahTxt"
        Me.jumlahTxt.Size = New System.Drawing.Size(288, 20)
        Me.jumlahTxt.TabIndex = 70
        '
        'idIventarisTxt
        '
        Me.idIventarisTxt.Location = New System.Drawing.Point(156, 179)
        Me.idIventarisTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.idIventarisTxt.Name = "idIventarisTxt"
        Me.idIventarisTxt.Size = New System.Drawing.Size(288, 20)
        Me.idIventarisTxt.TabIndex = 69
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(489, 94)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 15)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "CARI DATA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(8, 270)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 15)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "JUMLAH"
        '
        'DGdetail
        '
        Me.DGdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGdetail.Location = New System.Drawing.Point(482, 152)
        Me.DGdetail.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DGdetail.Name = "DGdetail"
        Me.DGdetail.Size = New System.Drawing.Size(417, 225)
        Me.DGdetail.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(278, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(384, 41)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "FROM DETAIL PINJAM"
        '
        'FDetailPinjam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(917, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.idDetailTxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.cariBtn)
        Me.Controls.Add(Me.cariTxt)
        Me.Controls.Add(Me.jumlahTxt)
        Me.Controls.Add(Me.idIventarisTxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DGdetail)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FDetailPinjam"
        Me.Text = "FDetailPinjam"
        CType(Me.DGdetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents idDetailTxt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents cariBtn As Button
    Friend WithEvents cariTxt As TextBox
    Friend WithEvents jumlahTxt As TextBox
    Friend WithEvents idIventarisTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DGdetail As DataGridView
    Friend WithEvents Label1 As Label
End Class
