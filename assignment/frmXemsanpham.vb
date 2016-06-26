Imports System.Data.SqlClient
Imports System.Data.DataSet
Public Class frmXemsanpham
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=HUNGNGUYENPC\SQLEXPRESS;Initial Catalog=ps03006;Integrated Security=True"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnXemall_Click(sender As Object, e As EventArgs) Handles btnXemall.Click
        Dim hienthi As New Class1
        dgvXemsp.DataSource = hienthi.Loadsanpham.Tables(0)
    End Sub

    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("select * from sanpham where sanpham.masp like '%" & txtMASP.Text & "%' ", connect)
        'Try
        If txtMASP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvXemsp.DataSource = Nothing
                timkiem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvXemsp.DataSource = db.DefaultView
                    txtMASP.Text = Nothing
                Else
                    MessageBox.Show("Không tìm được")
                    txtMASP.Text = Nothing
                End If
            End If
            connect.Close()

    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub dgvXemsp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvXemsp.CellContentClick

    End Sub
End Class