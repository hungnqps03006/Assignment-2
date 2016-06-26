Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmkhachhang
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=HUNGNGUYENPC\SQLEXPRESS;Initial Catalog=ps03006;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select * from khachhang", conn)
        db.Clear()
        refesh.Fill(db)
        DataGridView1.DataSource = db.DefaultView
        conn.Close()
    End Sub

    Private Sub reset()
        txtmakh.Text = ""
        txttenkh.Text = ""
        txtdiachi.Text = ""
        txtsdt.Text = ""
        txtemail.Text = ""
        txtmakh.Focus()

    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        If txtmakh.Text = "" Then
            MessageBox.Show("Chưa nhập mã khách hàng")
            txtmakh.Focus()
        ElseIf txttenkh.Text = "" Then
            MessageBox.Show("Chưa nhập tên khách hàng")
            txttenkh.Focus()
        ElseIf txtdiachi.Text = "" Then
            MessageBox.Show("Chưa nhập địa chỉ")
            txtdiachi.Focus()
        ElseIf txtsdt.Text = "" Then
            MessageBox.Show("Chưa nhập số điện thoại")
            txtsdt.Focus()
        ElseIf txtemail.Text = "" Then
            MessageBox.Show("Chưa nhập email")
            txtemail.Focus()
        Else
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into khachhang values (@makh,@tenkh,@diachi,@sodienthoai,@email)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@makh", txtmakh.Text)
            save.Parameters.AddWithValue("@TEnkh", txttenkh.Text)
            save.Parameters.AddWithValue("@diachi", txtdiachi.Text)
            save.Parameters.AddWithValue("@sodienthoai", txtsdt.Text)
            save.Parameters.AddWithValue("@email", txtemail.Text)

            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Lưu thành công")
            LoadData()


        End If



    End Sub


    Private Sub btnnhaplai_Click(sender As Object, e As EventArgs) Handles btnnhaplai.Click
        reset()

    End Sub

    Private Sub frmkhachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()

    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        If btnsua.Text = "Sửa" Then
            txtmakh.ReadOnly = True
            btnsua.Text = "Update"
            txttenkh.Focus()
        ElseIf btnsua.Text = "Update" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update SANPHAM set Tenkh=@TENkh, diachi=@diachi, sodienthoai=@sodienthoai ,email =@email where Makh=@MAkh"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MAkh", txtmakh.Text)
            save.Parameters.AddWithValue("@TENkh", txttenkh.Text)
            save.Parameters.AddWithValue("@diachi", txtdiachi.Text)
            save.Parameters.AddWithValue("@sodienthoai", txtsdt.Text)
            save.Parameters.AddWithValue("@email", txtemail.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update thành công")
            txtmakh.ReadOnly = False
            btnsua.Text = "Sửa"
            LoadData()
        End If
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        If txtmakh.Text = "" Then
            MessageBox.Show("Nhập mã khách hàng cần xóa")
            txtmakh.Focus()
        Else
            Dim delquery As String = "delete from khachhang where makh=@makh"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim result As DialogResult = MessageBox.Show("Bạn có muốn xóa không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = Windows.Forms.DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@makh", txtmakh.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                LoadData()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim click As Integer = DataGridView1.CurrentCell.RowIndex
        txtmakh.Text = DataGridView1.Item(0, click).Value
        txttenkh.Text = DataGridView1.Item(1, click).Value
        txtdiachi.Text = DataGridView1.Item(2, click).Value
        txtsdt.Text = DataGridView1.Item(3, click).Value
        txtemail.Text = DataGridView1.Item(4, click).Value

    End Sub
End Class