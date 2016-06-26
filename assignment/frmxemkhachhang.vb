Imports System.Data.SqlClient
Imports System.Data.DataSet

Public Class frmxemkhachhang

    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=HUNGNGUYENPC\SQLEXPRESS;Initial Catalog=ps03006;Integrated Security=True"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub btnXemall_Click(sender As Object, e As EventArgs) Handles btnXemall.Click
        Dim hienthi As New Class1
        dgvXemkh.DataSource = hienthi.Loadkhachhang.Tables(0)
    End Sub
    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("select * from khachhang where khachhang.makh like '%" & txtMAKH.Text & "%' ", connect)
        'Try
        If txtMAKH.Text = "" Then
            MessageBox.Show("Bạn cần nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            db.Clear()
            dgvXemkh.DataSource = Nothing
            timkiem.Fill(db)
            If db.Rows.Count > 0 Then
                dgvXemkh.DataSource = db.DefaultView
                txtMAKH.Text = Nothing
            Else
                MessageBox.Show("Không tìm được")
                txtMAKH.Text = Nothing
            End If
        End If
        connect.Close()
    End Sub

    Private Sub dgvXemkh_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvXemkh.CellContentClick

    End Sub
End Class