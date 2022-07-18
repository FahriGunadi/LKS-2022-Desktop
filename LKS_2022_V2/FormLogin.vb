Imports System.Data.SqlClient
Public Class FormLogin
    Sub kondisiAwal()
        tbxPassword.PasswordChar = "*"
        tbxUsername.Text = "fahri"
        tbxPassword.Text = "fahri"
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        tbxUsername.Text = ""
        tbxPassword.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call koneksi()
        cmd = New SqlCommand("select * from Tbl_User where Username = '" & tbxUsername.Text & "' and Password = '" & tbxPassword.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If tbxUsername.Text = "" Or tbxPassword.Text = "" Then
            MsgBox("Isi lengkap semua kolom!!")
        Else
            If Not rd.HasRows Then
                MsgBox("Username atau Password yang anda masukkan tidak sesuai!!")
            Else
                Call koneksi()
                Dim Insert As String = "insert into Tbl_Log (waktu, aktifitas, Id_User) Values('" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "' ,'Login', '" & rd!Id_User & "')"
                cmd = New SqlCommand(Insert, conn)
                cmd.ExecuteNonQuery()
                Call kondisiAwal()

                If rd!Tipe_User = "Admin" Then
                    Me.Hide()
                    FormAdminNav.ShowDialog()
                Else
                    If rd!Tipe_User = "Apoteker" Then
                        'KelolaResepForm.ShowDialog()
                        Me.Hide()
                    Else
                        FormKelolaTransaksi.ShowDialog()
                        Me.Hide()
                    End If
                End If
            End If
        End If
    End Sub
End Class
