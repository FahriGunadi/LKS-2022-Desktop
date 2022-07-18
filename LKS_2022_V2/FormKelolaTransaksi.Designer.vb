<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKelolaTransaksi
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
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbxTglResep = New System.Windows.Forms.ComboBox()
        Me.cbxTypeResep = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbxQuantity = New System.Windows.Forms.TextBox()
        Me.tbxHarga = New System.Windows.Forms.TextBox()
        Me.tbxNamaObat = New System.Windows.Forms.TextBox()
        Me.tbxNamaDokter = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.tbxNamaPasien = New System.Windows.Forms.TextBox()
        Me.tbxNoResep = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(6, 396)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(195, 45)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.ComboBox3)
        Me.Panel1.Controls.Add(Me.cbxTglResep)
        Me.Panel1.Controls.Add(Me.cbxTypeResep)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.tbxQuantity)
        Me.Panel1.Controls.Add(Me.tbxHarga)
        Me.Panel1.Controls.Add(Me.tbxNamaObat)
        Me.Panel1.Controls.Add(Me.tbxNamaDokter)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.tbxNamaPasien)
        Me.Panel1.Controls.Add(Me.tbxNoResep)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.btnLoad)
        Me.Panel1.Controls.Add(Me.DGV1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(212, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(580, 434)
        Me.Panel1.TabIndex = 6
        '
        'cbxTglResep
        '
        Me.cbxTglResep.FormattingEnabled = True
        Me.cbxTglResep.Location = New System.Drawing.Point(104, 110)
        Me.cbxTglResep.Name = "cbxTglResep"
        Me.cbxTglResep.Size = New System.Drawing.Size(151, 21)
        Me.cbxTglResep.TabIndex = 92
        '
        'cbxTypeResep
        '
        Me.cbxTypeResep.FormattingEnabled = True
        Me.cbxTypeResep.Location = New System.Drawing.Point(104, 50)
        Me.cbxTypeResep.Name = "cbxTypeResep"
        Me.cbxTypeResep.Size = New System.Drawing.Size(151, 21)
        Me.cbxTypeResep.TabIndex = 92
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Chartreuse
        Me.Panel2.Location = New System.Drawing.Point(285, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 151)
        Me.Panel2.TabIndex = 91
        '
        'tbxQuantity
        '
        Me.tbxQuantity.BackColor = System.Drawing.SystemColors.Window
        Me.tbxQuantity.Location = New System.Drawing.Point(413, 139)
        Me.tbxQuantity.Name = "tbxQuantity"
        Me.tbxQuantity.Size = New System.Drawing.Size(150, 20)
        Me.tbxQuantity.TabIndex = 82
        '
        'tbxHarga
        '
        Me.tbxHarga.BackColor = System.Drawing.SystemColors.Window
        Me.tbxHarga.Location = New System.Drawing.Point(412, 113)
        Me.tbxHarga.Name = "tbxHarga"
        Me.tbxHarga.Size = New System.Drawing.Size(150, 20)
        Me.tbxHarga.TabIndex = 81
        '
        'tbxNamaObat
        '
        Me.tbxNamaObat.BackColor = System.Drawing.SystemColors.Window
        Me.tbxNamaObat.Location = New System.Drawing.Point(412, 82)
        Me.tbxNamaObat.Name = "tbxNamaObat"
        Me.tbxNamaObat.Size = New System.Drawing.Size(150, 20)
        Me.tbxNamaObat.TabIndex = 80
        '
        'tbxNamaDokter
        '
        Me.tbxNamaDokter.BackColor = System.Drawing.SystemColors.Window
        Me.tbxNamaDokter.Location = New System.Drawing.Point(412, 50)
        Me.tbxNamaDokter.Name = "tbxNamaDokter"
        Me.tbxNamaDokter.Size = New System.Drawing.Size(150, 20)
        Me.tbxNamaDokter.TabIndex = 79
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox4.Location = New System.Drawing.Point(124, 377)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(109, 20)
        Me.TextBox4.TabIndex = 77
        '
        'tbxNamaPasien
        '
        Me.tbxNamaPasien.BackColor = System.Drawing.SystemColors.Window
        Me.tbxNamaPasien.Location = New System.Drawing.Point(104, 139)
        Me.tbxNamaPasien.Name = "tbxNamaPasien"
        Me.tbxNamaPasien.Size = New System.Drawing.Size(151, 20)
        Me.tbxNamaPasien.TabIndex = 77
        '
        'tbxNoResep
        '
        Me.tbxNoResep.BackColor = System.Drawing.SystemColors.Window
        Me.tbxNoResep.Location = New System.Drawing.Point(104, 82)
        Me.tbxNoResep.Name = "tbxNoResep"
        Me.tbxNoResep.Size = New System.Drawing.Size(151, 20)
        Me.tbxNoResep.TabIndex = 76
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Chartreuse
        Me.Label10.Location = New System.Drawing.Point(100, 405)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 85
        Me.Label10.Text = "kembalian"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Chartreuse
        Me.Label1.Location = New System.Drawing.Point(30, 351)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "harusdibayar"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(330, 143)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 23)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "Quantity"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(30, 405)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 23)
        Me.Label11.TabIndex = 84
        Me.Label11.Text = "Kembali"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(17, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 23)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Nama Pasien"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(330, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 23)
        Me.Label8.TabIndex = 86
        Me.Label8.Text = "Harga"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(328, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 23)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "Nama Obat"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(328, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 23)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Nama Dokter"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(17, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 23)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Tgl Resep"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(17, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 23)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "No Resep"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Location = New System.Drawing.Point(409, 14)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 23)
        Me.Label14.TabIndex = 83
        Me.Label14.Text = "Kasir1"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(481, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 23)
        Me.Label13.TabIndex = 83
        Me.Label13.Text = "12/121/1212"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(17, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 23)
        Me.Label12.TabIndex = 83
        Me.Label12.Text = "Form Transaksi"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(17, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 23)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Type Resep"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(352, 187)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Kosongkan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(105, 187)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Tambahkan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(26, 377)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 25)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Bayar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(477, 393)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(85, 25)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "Print  Save"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(20, 216)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(542, 131)
        Me.DGV1.TabIndex = 2
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(484, 14)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(79, 21)
        Me.ComboBox3.TabIndex = 92
        '
        'FormKelolaTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormKelolaTransaksi"
        Me.Padding = New System.Windows.Forms.Padding(8)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormKelolaTransaksi"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLoad As Button
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tbxQuantity As TextBox
    Friend WithEvents tbxHarga As TextBox
    Friend WithEvents tbxNamaObat As TextBox
    Friend WithEvents tbxNamaDokter As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents tbxNamaPasien As TextBox
    Friend WithEvents tbxNoResep As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cbxTglResep As ComboBox
    Friend WithEvents cbxTypeResep As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBox3 As ComboBox
End Class
