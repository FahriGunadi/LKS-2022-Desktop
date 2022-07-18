Imports System.Data.SqlClient
Public Class FormAdminNav
    Sub kondisiAwal()
        cbxFilter.Text = ""
        cbxFilter.Items.Clear()
        Call munculGrid()

        For i = 0 To 12
            cbxFilter.Items.Add(Date.Today.AddMonths(-i).ToString("yyyy/MM/dd"))
        Next

    End Sub
    Sub munculGrid()
        Call koneksi()
        da = New SqlDataAdapter("select Tbl_Log.Id_Log, Tbl_User.Username, Tbl_Log.waktu,  Tbl_Log.aktifitas from Tbl_Log INNER Join Tbl_User ON Tbl_User.Id_User = Tbl_Log.Id_User ORDER BY Tbl_Log.Id_Log ASC", conn)
        ds = New DataSet
        da.Fill(ds, "Tbl_Log")
        DGV1.DataSource = ds.Tables("Tbl_Log")
    End Sub

    Private Sub FormAdminNav_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
    End Sub

    Private Sub SlabelDay_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        FormLogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnKelUser_Click(sender As Object, e As EventArgs) Handles btnKelUser.Click
    End Sub

    Private Sub btnKelObat_Click(sender As Object, e As EventArgs) Handles btnKelObat.Click
    End Sub

    Private Sub btnKelLaporan_Click(sender As Object, e As EventArgs) Handles btnKelLaporan.Click
    End Sub
End Class