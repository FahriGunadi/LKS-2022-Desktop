<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdminNav
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.cbxFilter = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.btnKelUser = New System.Windows.Forms.Button()
        Me.btnKelObat = New System.Windows.Forms.Button()
        Me.btnKelLaporan = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.btnLoad)
        Me.Panel1.Controls.Add(Me.cbxFilter)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DGV1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(212, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(580, 434)
        Me.Panel1.TabIndex = 1
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(407, 377)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(85, 34)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'cbxFilter
        '
        Me.cbxFilter.FormattingEnabled = True
        Me.cbxFilter.Location = New System.Drawing.Point(194, 385)
        Me.cbxFilter.Name = "cbxFilter"
        Me.cbxFilter.Size = New System.Drawing.Size(195, 21)
        Me.cbxFilter.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(88, 388)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tampilkan Per"
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(33, 93)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(515, 268)
        Me.DGV1.TabIndex = 2
        '
        'btnKelUser
        '
        Me.btnKelUser.Location = New System.Drawing.Point(11, 243)
        Me.btnKelUser.Name = "btnKelUser"
        Me.btnKelUser.Size = New System.Drawing.Size(195, 45)
        Me.btnKelUser.TabIndex = 0
        Me.btnKelUser.Text = "Kelola User"
        Me.btnKelUser.UseVisualStyleBackColor = True
        '
        'btnKelObat
        '
        Me.btnKelObat.Location = New System.Drawing.Point(11, 294)
        Me.btnKelObat.Name = "btnKelObat"
        Me.btnKelObat.Size = New System.Drawing.Size(195, 45)
        Me.btnKelObat.TabIndex = 0
        Me.btnKelObat.Text = "Kelola Obat"
        Me.btnKelObat.UseVisualStyleBackColor = True
        '
        'btnKelLaporan
        '
        Me.btnKelLaporan.Location = New System.Drawing.Point(11, 345)
        Me.btnKelLaporan.Name = "btnKelLaporan"
        Me.btnKelLaporan.Size = New System.Drawing.Size(195, 45)
        Me.btnKelLaporan.TabIndex = 0
        Me.btnKelLaporan.Text = "Kelola Laporan"
        Me.btnKelLaporan.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(11, 396)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(195, 45)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'FormAdminNav
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnKelLaporan)
        Me.Controls.Add(Me.btnKelObat)
        Me.Controls.Add(Me.btnKelUser)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormAdminNav"
        Me.Padding = New System.Windows.Forms.Padding(8)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAdminNav"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnKelUser As Button
    Friend WithEvents btnKelObat As Button
    Friend WithEvents btnKelLaporan As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents btnLoad As Button
    Friend WithEvents cbxFilter As ComboBox
    Friend WithEvents Label1 As Label
End Class
