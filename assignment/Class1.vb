Imports System.Data.SqlClient
Imports System.Data
Public Class Class1
    Public Function Loadkhachhang() As DataSet
        Dim chuoiketnoi As String = "Data Source=HUNGNGUYENPC\SQLEXPRESS;Initial Catalog=ps03006;Integrated Security=True"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select * from KHAChHANG", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function

    Public Function Loadsanpham() As DataSet
        Dim chuoiketnoi As String = "Data Source=HUNGNGUYENPC\SQLEXPRESS;Initial Catalog=ps03006;Integrated Security=True"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadSP As New SqlDataAdapter("select * from sanpham ", conn)
        Dim db As New DataSet
        conn.Open()
        LoadSP.Fill(db)
        conn.Close()
        Return db
    End Function
End Class
