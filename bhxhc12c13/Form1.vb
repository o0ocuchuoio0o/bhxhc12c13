Imports System.ComponentModel
Imports System.Text
Imports System.Data.SqlClient
Imports vb = Microsoft.VisualBasic

Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form3.Show()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "Xem ConnectString"
        Dim conn As New SqlClient.SqlConnection(My.Settings.conns)
        Try
            conn.Open()
            conn.Close()

        Catch ex As Exception
            MsgBox("Chưa có kết nối với máy chủ!" & conn.ConnectionString.ToString)
            Me.Close()
        End Try
        bind_th_nam()
        pr1.Visible = False
        grid.Visible = False
        If Month(Now) = 1 Then
            th.SelectedItem = 12
            nm.SelectedItem = Year(Now) - 1
        Else
            th.SelectedItem = Month(Now) - 1
            nm.SelectedItem = Year(Now)
        End If

    End Sub
    Sub bind_th_nam()
        Dim i As Integer

        For i = 0 To 12
            th.Items.Add(i)
        Next
        th.SelectedItem = Month(Now)
        'th.SelectedItem = th.SelectedText

        For i = Year(Now) - 1 To Year(Now) + 1
            nm.Items.Add(i)
        Next
        nm.SelectedItem = Year(Now)
        'nm.SelectedItem = nm.SelectedText
        For i = 1 To 3
            cblan.Items.Add(i)
        Next
        cblan.SelectedItem = 1

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        grid.Visible = False
        If MsgBox("Có chạy cập nhật ko ?", MsgBoxStyle.OkCancel) = vbOK Then
            pr1.Visible = True
            Dim t1, t2 As Date
            t1 = Now
            Dim loai As String
            If rd1.Checked Then
                loai = "C12"
            Else
                loai = "C13"
            End If
            Dim lan As String = cblan.SelectedItem.ToString.Trim
            Dim ff(31) As String
            ReDim ff(31)
            ff(1) = "00100_VPTPHANOI"
            ff(2) = "00101_QUANBADINH"
            ff(3) = "00102_QUANHOANKIEM"
            ff(4) = "00103_QUANTAYHO"
            ff(5) = "00104_QUANLONGBIEN"
            ff(6) = "00105_QUANCAUGIAY"
            ff(7) = "00106_QUANDONGDA"
            ff(8) = "00107_QUANHAIBATRUNG"
            ff(9) = "00108_QUANHOANGMAI"
            ff(10) = "00109_QUANTHANHXUAN"
            ff(11) = "00110_HUYENSOCSON"
            ff(12) = "00111_HUYENDONGANH"
            ff(13) = "00112_HUYENGIALAM"
            ff(14) = "00113_QUANNAMTULIEM"
            ff(15) = "00114_HUYENTHANHTRI"
            ff(16) = "00115_QUANHADONG"
            ff(17) = "00116_TXSONTAY"
            ff(18) = "00117_HUYENBAVI"
            ff(19) = "00118_HUYENPHUCTHO"
            ff(20) = "00119_HUYENDANPHUONG"
            ff(21) = "00120_HUYENHOAIDUC"
            ff(22) = "00121_HUYENQUOCOAI"
            ff(23) = "00122_HUYENTHACHTHAT"
            ff(24) = "00123_HUYENCHUONGMY"
            ff(25) = "00124_HUYENTHANHOAI"
            ff(26) = "00125_HUYENTHUONGTIN"
            ff(27) = "00126_HUYENPHUXUYEN"
            ff(28) = "00127_HUYENUNGHOA"
            ff(29) = "00128_HUYENMYDUC"
            ff(30) = "00129_HUYENMELINH"
            ff(31) = "00131_QUANBACTULIEM"
            ' YYYYMM\MãTỉnh_TênTỉnh\MãCơQuanBHXH_Tên Cơ Quan BHXH\Lần gửi\*.*
            Dim tm As String
            tm = LTrim(RTrim(Str(nm.SelectedItem))) + vb.Right("0" + LTrim(RTrim(Str(th.SelectedItem))), 2)
            '----
            Dim path As String
            '  path = "d:\bhxh_c12c13\" + loai + "\" + tm + "\001_TPHANOI"

            path = "d:\bhxh_c12c13\" + loai + "\" + tm

            Dim i As Integer
            Dim j, f As String
            pr1.Maximum = 31
            pr1.Minimum = 0
            Dim ss As String
            Dim ds As DataTable
            ss = "select * from  bhxh_c12c13 where trangthai=1 and left(noidung,3)='" & loai & "' and thang = " & th.SelectedItem.ToString & " and nam = " & nm.SelectedItem.ToString & " and lan = " & cblan.SelectedItem.ToString
            ds = dl(ss)
            If ds.Rows.Count > 1 Then
                MsgBox("Đã truyền dữ liệu sang điều tin, kiểm tra lại!!!!!")
                pr1.Visible = False
                Return
            End If
            ss = "delete bhxh_c12c13 where left(noidung,3)='" & loai & "' and thang = " & th.SelectedItem.ToString & " and nam = " & nm.SelectedItem.ToString & " and lan = " & cblan.SelectedItem.ToString
            ds = dl(ss)
            For i = 1 To 31
                pr1.Value = i
                lnhap.Text = "Đang chạy ..." & i.ToString & " / 31"
                Me.Refresh()
                j = RTrim(LTrim(Str(i)))
                'If loai = "C12" Then
                '    f = path + "\" + ff(i) + "\" + "lan" + lan + "\" + loai + "_" + tm + "_" + vb.Left(ff(i), 5) + "_" + lan + ".xls"
                'Else
                '    f = path + "\" + ff(i) + "\" + "lan" + lan + "\" + loai + "_" + vb.Left(tm, 4) + "_" + vb.Left(ff(i), 5) + "_" + lan + ".xls"
                'End If
                If loai = "C12" Then
                    f = path + "\" + ff(i) + "\" + "lan" + lan + "\" + loai + "_" + tm + "_" + vb.Left(ff(i), 5) + "_" + lan + ".xls"
                    f = path + "\C12_" + tm + "_" + vb.Left(ff(i), 5) + "_" + lan + ".xls"

                Else
                    f = path + "\" + ff(i) + "\" + ff(i) + "_" + lan + ".xls"
                End If
                'f = "D:\bhxh_c12c13\01_2019\c12 (" + Str(i).Trim + ").xls"
                xuly(f)
            Next
            t2 = Now
            Dim n, g, p, s, n1, n2, g1, g2, p1, p2, s1, s2 As Integer
            n1 = t1.Day
            n2 = t2.Day

            g1 = t1.Hour
            g2 = t2.Hour

            p1 = t1.Minute
            p2 = t2.Minute

            s1 = t1.Second
            s2 = t2.Second

            If s2 - s1 >= 0 Then
                s = s2 - s1
                p = p2 - p1
            Else
                s = 60 + s2 - s1
                p = p2 - p1 - 1
            End If

            If p >= 0 Then
                g = g2 - g1
            Else
                p = 60 + p2 - p1
                g = g2 - g1 - 1
            End If

            If g >= 0 Then
                n = n2 - n1
            Else
                n = n2 - n1 - 1
                g = 24 + g
            End If
            lnhap.Text = "Đã xong ! " & n.ToString & " ngày, " & g.ToString & " giờ, " & p.ToString & " phút, " & s.ToString & " giây"
            pr1.Visible = False
        Else
            lnhap.Text = ""
            pr1.Visible = False
        End If

    End Sub
    Sub xuly(ByVal sfile As String)
        Dim loai As String
        If rd1.Checked Then
            loai = "C12"
        Else
            loai = "C13"
        End If
        Dim tm1 As String
        tm1 = vb.Right("0" + LTrim(RTrim(Str(th.SelectedItem))), 2) + "-" + LTrim(RTrim(Str(nm.SelectedItem)))

        Dim lan As Integer = cblan.SelectedItem
        Dim fn As String = sfile
        If Dir(fn, vbNormal Or vbReadOnly Or vbHidden Or vbSystem Or vbArchive) = "" Then
            MsgBox("File " & fn & "  khong ton tai")
            Return
        End If
        '----
        Dim MyConnection As System.Data.OleDb.OleDbConnection
        Dim DtSet As System.Data.DataSet
        Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
        ' MyConnection = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + Server.MapPath("~/upload/") & sfile + ".xls" + "';Extended Properties=Excel 8.0;")
        MyConnection = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + fn + "';Extended Properties=Excel 8.0;")

        MyCommand = New System.Data.OleDb.OleDbDataAdapter("select [Mã tỉnh] as ma_tinh, " & _
                                                           "[Tên tỉnh] as ten_tinh, " & _
                                                           "[Mã huyện] as ma_huyen, " & _
                                                           "[Tên huyện]  as ten_huyen, " & _
                                                           "[Mã đơn vị] as ma_dv, " & _
                                                           "[Tên đơn vị] as ten, " & _
                                                           "[Địa chỉ đơn vị] as diachi, " & _
                                                           "[Điện thoại] as dienthoai, " & _
                                                           "[Số lượng] as soluong, " & _
                                                           "[Số tờ] as soto, '" & loai.ToString & "'  as noidung, " & _
                                                           "0 as thang, 0 as nam ," & _
                                                           lan.ToString & " as lan, " & _
                                                          "[Số kiểm soát] as sokiemsoat, " & _
                                                          "[BARCODE] as sohieubuugui " & _
                                                           "from [Sheet0$]", MyConnection)
     
        MyCommand.TableMappings.Add("Table", "Net-informations.com")
        DtSet = New System.Data.DataSet

        MyCommand.Fill(DtSet)
        Dim i As Integer = 0
        lnhap.Text = lnhap.Text & " - " & DtSet.Tables(0).Rows(0).Item("ten_huyen").ToString
        Me.Refresh()

        Dim sfile1 As String
        sfile1 = sfile
        sfile1 = Replace(sfile1, " ", "")
        sfile1 = Replace(sfile1, "(", "")
        sfile1 = Replace(sfile1, ")", "")
        Dim CMD As New System.Data.SqlClient.SqlCommand("sp_them")
        Dim con As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.conns)

        con.Open()
        CMD.Connection = con
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.AddWithValue("@bang", DtSet.Tables(0))
        CMD.Parameters.AddWithValue("@goc", sfile1)
        CMD.Parameters.AddWithValue("@tm", tm1)
        CMD.ExecuteNonQuery()
        con.Close()
        MyConnection.Close()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        grid.Visible = True

        Dim loai As String
        If rd1.Checked Then
            loai = "C12"
        Else
            loai = "C13"
        End If
        Dim s As String
        s = "sp_kiemtra " + th.SelectedItem.ToString & ", " & nm.SelectedItem.ToString & ", " & cblan.SelectedItem.ToString & ", " & loai.Trim
        grid.DataSource = dl(s)

    End Sub
    Private Sub grid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid.DoubleClick
        If MsgBox("Có xuất file excel ko ?", vbOKCancel) = MsgBoxResult.Ok Then
            Dim loai As String
            If rd1.Checked Then
                loai = "C12"
            Else
                loai = "C13"
            End If

            Dim s As String = "\bhxh_c12c13\Kiemtra_TongHop_" & loai.Trim & "_" & nm.SelectedItem.ToString & th.SelectedItem.ToString & ".xls"
            grid.ExportToXls(s)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Shell("C:\Program Files (x86)\WinSCP\WinSCP.exe", AppWinStyle.MaximizedFocus)


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub rd2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd2.CheckedChanged
        If rd2.Checked Then
            th.SelectedItem = 0
            nm.SelectedItem = Year(Now) - 1
        Else
            If Month(Now) = 1 Then
                th.SelectedItem = 12
                nm.SelectedItem = Year(Now) - 1
            Else
                th.SelectedItem = Month(Now) - 1
                nm.SelectedItem = Year(Now)
            End If
        End If
    End Sub


    Private Sub Label1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.MouseLeave
        Label1.Text = "Xem ConnectString"
    End Sub

    Private Sub Label1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove
        Label1.Text = vb.Left(My.Settings.conns.ToString, InStr(My.Settings.conns.ToString, "Persist", CompareMethod.Text) - 2)
    End Sub


    Private Sub rd1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd1.CheckedChanged

    End Sub
End Class
