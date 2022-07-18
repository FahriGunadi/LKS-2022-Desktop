Imports System.Data.SqlClient
Public Class FormKelolaTransaksi

    Dim Name As String = tbxNoResep.Text
    Dim Qty As Integer = tbxQuantity.Text
    Dim Id As String = cbxTglResep.Text

    Sub ComboBoxOrder()
        cbxOrderid.DataSource = Nothing
        Call koneksi()
        da = New SqlDataAdapter("SELECT DISTINCT Id As OrderId FROM OrderHeader  WHERE PaymentType IS NULL", conn)
        dt = New DataTable
        da.Fill(dt)
        cbxOrderid.DataSource = dt
        cbxOrderid.DisplayMember = "OrderId"
        cbxOrderid.ValueMember = "OrderId"
    End Sub

    Dim DataGridRows As Integer = DGV1.Rows.Count
    Dim Price As Integer = TextBox4.Text
    Dim Carbo As Integer = TextBox5.Text
    Dim Protein As Integer = TextBox6.Text
    If DataGridRows = 0 Then
    Dim row As String() = New String() {Name, Qty, Carbo, Protein, Price, Qty * Price, Id}
                            DGV1.Rows.Add(row)
                            Call TextBoxClear()
                            PictureBox1.Image = Nothing
                            DataGridView1.Columns(0).Visible = False
                            DataGridView1.Columns(3).Visible = False
                            DataGridView1.Columns(0).Visible = False
                            DataGridView1.Columns(3).Visible = False
                            Call StartDataGridView()
                            NumericUpDown1.Enabled = False
                            DataGridView1.ClearSelection()
                            DGV1.ClearSelection()
                            Button7.Visible = False
                            TextBox7.Text = ""
                            Button9.Visible = False
                            Call OrderSummary()
    Else
    Dim IdExist As String
    Dim QtyExist As Integer
    For i As Integer = 0 To DataGridRows - 1
                                IdExist = DGV1.Rows(i).Cells(6).Value
                                If IdExist = Id Then
                                    QtyExist = DGV1.Rows(i).Cells(1).Value
                                    Dim QtyAdd As Integer = QtyExist + Qty
                                    DGV1.Rows(i).Cells(1).Value = QtyAdd
                                    DGV1.Rows(i).Cells(5).Value = QtyAdd * Price
                                    Call TextBoxClear()
    Call StartDataGridView()
                                    NumericUpDown1.Enabled = False
                                    DataGridView1.Columns(0).Visible = False
                                    DataGridView1.Columns(3).Visible = False
                                    PictureBox1.Image = Nothing
                                    DataGridView1.ClearSelection()
                                    DGV1.ClearSelection()
                                    Button7.Visible = False
                                    Button9.Visible = False
                                    TextBox7.Text = ""
                                    Call OrderSummary()
    Exit Sub
    End If
    Next
    Dim row As String() = New String() {Name, Qty, Carbo, Protein, Price, Qty * Price, Id}
                            DGV1.Rows.Add(row)
                            Call TextBoxClear()
                            PictureBox1.Image = Nothing
                            Call StartDataGridView()
                            NumericUpDown1.Enabled = False
                            DataGridView1.Columns(0).Visible = False
                            DataGridView1.Columns(3).Visible = False
                            DataGridView1.ClearSelection()
                            DGV1.ClearSelection()
                            Button7.Visible = False
                            Button9.Visible = False
                            TextBox7.Text = ""
                            Call OrderSummary()
End Class