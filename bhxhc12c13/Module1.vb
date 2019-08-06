Module Module1
    Function dl(ByVal s As String) As DataTable
        Dim conn As New SqlClient.SqlConnection(My.Settings.conns)
        Try
            conn.Open()
            Dim ad As SqlClient.SqlDataAdapter
            Dim ds1 As DataSet
            ds1 = New DataSet
            ad = New SqlClient.SqlDataAdapter(s, conn)

            ad.Fill(ds1, "x")
            conn.Close()
            Return ds1.Tables("x")
        Catch ex As Exception
            MsgBox("Chưa có kết nối với máy chủ!" & conn.ConnectionString.ToString)
            Form1.Close()
        End Try
    End Function

    Public Class NumBer2TextBase
        Private strDigit As String() = {"không ", "một ", "hai ", "ba ", "bốn ", "năm ", _
         "sáu ", "bảy ", "tám ", "chín "}
        Private strGroup As String() = {"nghìn ", "triệu ", "tỷ "}

        Public Function Transtalte(ByVal iNum As String) As String
            Try
                Dim iG As Short
                Dim k As Byte = 0
                Dim st As String, s As String = ""
                For i As Short = CShort((iNum.Length - 6)) To iNum.Length Mod 3 Step -3
                    iG = Short.Parse(iNum.Substring(i, 3))
                    st = Group3(iG)
                    If st <> "" Then
                        st += strGroup(k)
                    ElseIf k Mod 3 = 2 Then
                        st = strGroup(k)
                    End If
                    k = CByte(((k + 1) Mod 3))
                    s = st + s
                Next
                If iNum.Length Mod 3 <> 0 AndAlso iNum.Length > 3 Then
                    iG = Short.Parse(iNum.Substring(0, iNum.Length Mod 3))
                    st = Group3(iG)
                    st += strGroup(k)
                    s = st + s
                End If
                s = s + Group3(Short.Parse(iNum.Substring(Math.Max(iNum.Length - 3, 0))))
                If s = "" Then
                    s = "không"
                ElseIf s.Substring(0, 13) = "không trăm lẻ" Then
                    s = s.Substring(14)
                ElseIf s.Substring(0, 11) = "không trăm " Then
                    s = s.Substring(11)
                End If
                Return s
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Private Function Group3(ByVal iNum As Short) As String
            Dim iDg As Byte() = New Byte(2) {}
            Dim sResult As String() = New String(2) {}
            If iNum = 0 Then
                Return ""
            End If

            iDg(2) = CByte((iNum / 100))
            iDg(1) = CByte(((iNum / 10) Mod 10))
            iDg(0) = CByte((iNum Mod 10))

            sResult(2) = strDigit(iDg(2)) + "trăm "
            If iDg(1) >= 2 Then
                sResult(1) = strDigit(iDg(1)) + "mươi "
            ElseIf iDg(1) = 1 Then
                sResult(1) = "mười "
            ElseIf iDg(1) = 0 Then
                sResult(1) = "lẻ "
            End If

            sResult(0) = strDigit(iDg(0))

            If iDg(0) = 0 Then
                sResult(0) = ""
                If iDg(1) = 0 Then
                    sResult(1) = ""
                End If
            ElseIf iDg(0) = 1 AndAlso iDg(1) >= 2 Then
                sResult(0) = "mốt "
            ElseIf iDg(0) = 5 AndAlso iDg(1) >= 1 Then
                sResult(0) = "lăm "
            End If

            Return sResult(2) + sResult(1) + sResult(0)
        End Function
        Public Shared Function Translate(ByVal Number As String) As String
            Dim N2T As New NumBer2TextBase
            Return N2T.Transtalte(Number)
        End Function

    End Class

    Dim chữsố() As String = {"không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín"}
    Dim đơnvị() As String = {"Đồng", "nghìn", "triệu", "tỷ"}

    Function đọc(ByVal số As String) As String
        số = số.TrimStart("0")
        'bỏ những số "0" ở đầu tiên

        If số.Length = 0 Then Return ""

        số = số.Replace(" ", "").Replace(",", "").Replace(".", "")
        'nếu muốn cho phép có dấu " " hay "," hay "." trong số để dễ nhìn thì uncomment dòng đây

        Dim kq As String = ""
        Dim chiềudài As Integer = số.Length

        'dùng biến để lưu lại từng nhóm ba chữ số dể dễ xài
        Dim sốnhóm As Integer = Math.Ceiling(chiềudài / 3)
        'tính số lượng nhóm 3 chữ số
        Dim nhóm(sốnhóm - 1) As String

        'cóp nhóm đầu tiên , rồi lần lượt những nhóm còn lại , j là chiều dài nhóm đầu tiên
        Dim j As Integer = chiềudài - (sốnhóm - 1) * 3
        nhóm(0) = số.Substring(0, j)
        For i As Integer = 1 To sốnhóm - 1
            nhóm(i) = số.Substring(j + (i - 1) * 3, 3)
        Next

        For i As Integer = 0 To nhóm.Length - 1
            kq &= đọcnhóm3số(nhóm(i), tínhđơnvị(nhóm.Length - 1 - i)) & " "
        Next

        Return kq.Trim.Replace("  ", " ")
        'để chắc chắn không có 2 dấu cách đứng liền nhau và 0 có dấu cách ở 2 đầu
    End Function

    Function tínhđơnvị(ByVal n As Integer) As String
        'hàm đệ qui rất đơn giản
        If n <= 3 Then
            Return đơnvị(n)
        Else
            Return tínhđơnvị(n - 3) & " " & đơnvị(3)
        End If
    End Function

    Function đọcnhóm3số(ByVal số As String, ByVal đơnvị As String) As String
        Dim kq As String = ""
        Dim l As Integer = số.Length

        số = số.PadLeft(3, "0")

        If số = "000" Then Return ""
        'không đọc những nhóm "000" như trong "1.000.000.000"

        If số.StartsWith("00") Then Return đọcsốhàngđơnvị(Val(số(2)), 0, l = 3) & " " & đơnvị
        'chỗ này để tránh khó nghe khi đọc "1.000.000.001" , nó sẽ bỏ qua từ "không trăm" và chỉ đọc "một tỉ lẻ một đơn vị" , nếu không thích thì xóa dòng đây đi cũng được

        kq &= đọcsốhàngtrăm(Val(số(0)), l = 3)
        kq &= đọcsốhàngchục(Val(số(1)))
        kq &= đọcsốhàngđơnvị(Val(số(2)), Val(số(1)), l = 3)

        Return kq & " " & đơnvị
    End Function

    Function đọcsốhàngtrăm(ByVal i As Integer, ByVal đọcsốkhông As Boolean) As String
        'biến đọcsốkhông để tránh đọc chữ "không trăm" trong số < 100 như "75" , nếu không dùng biến này thì sẽ đọc là "không trăm bảy mươi lăm"

        If i = 0 Then
            If đọcsốkhông Then
                Return "không trăm "
            Else
                Return ""
            End If
        Else
            Return chữsố(i) & " trăm "
        End If
    End Function

    Function đọcsốhàngchục(ByVal i As Integer) As String
        Select Case i
            Case 0
                Return ""
            Case 1
                Return "mười "
            Case Else
                Return chữsố(i) & " mươi "
        End Select
    End Function

    Function đọcsốhàngđơnvị(ByVal i As Integer, ByVal hàngchục As Integer, ByVal đọcchữlẻ As Boolean) As String
        'biến đọcchữlẻ để tránh đọc chữ "lẻ" trong số < 10 như "2" , nếu không dùng biến này thì sẽ đọc là "lẻ hai"
        'các lệnh điều khiển If...then và select...case chỉ là để đọc cho giống tiếng việt

        If i = 0 Then
            Return ""
        Else
            If hàngchục = 0 Then
                If đọcchữlẻ Then
                    Return "lẻ " & chữsố(i)
                Else
                    Return chữsố(i)
                End If
            Else
                Select Case i
                    Case 1
                        If hàngchục = 1 Then
                            Return "một"
                        Else
                            Return "mốt"
                        End If
                    Case 5
                        Return "lăm"
                    Case Else
                        Return chữsố(i)
                End Select
            End If
        End If

    End Function

End Module
