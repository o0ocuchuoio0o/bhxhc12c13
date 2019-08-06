Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        diachiphuongxa.AutoCompleteMode = AutoCompleteMode.Suggest
        diachiphuongxa.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim DataCollection As New AutoCompleteStringCollection()
        laydanhmucphuongxa(DataCollection)
        diachiphuongxa.AutoCompleteCustomSource = DataCollection
        Loaddl()
    End Sub
    Sub loaddl()
        Dim dt As DataTable = dl("select top 1 ma_dv,diachi from chuandiachi where quan is null")
        Label1.Text = dt.Rows(0).Item("diachi").ToString
        Label2.Text = dt.Rows(0).Item("ma_dv").ToString
        diachiphuongxa.Text = ""
        MaBC.Text = ""
    End Sub
    Private Sub laydanhmucphuongxa(ByVal dataCollection As AutoCompleteStringCollection)
        Dim dt As DataTable = dl("select phuong from dm_phuongxa")
        For Each row As DataRow In dt.Rows
            dataCollection.Add(row(0).ToString())
        Next
    End Sub

    Private Sub TextBox1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles diachiphuongxa.Validated
        Dim l As String = diachiphuongxa.Text.Trim
        MaBC.Text = Mid(l, InStr(l, "-") + 1, Len(l) - InStr(l, "-"))

      
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim dt As DataTable
        If diachiphuongxa.Text = "" Then
            dt = dl("update chuandiachi set quan=N'Khác' where ma_dv='" & Label2.Text.Trim.Trim & "'")
        Else
            dt = dl("update chuandiachi set quan=N'" & MaBC.Text & "' where ma_dv='" & Label2.Text.Trim.Trim & "'")
        End If
        loaddl()
        diachiphuongxa.Focus()
        diachiphuongxa.SelectAll()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim dt As DataTable
        dt = dl("update chuandiachi set quan=N'???' where ma_dv='" & Label2.Text.Trim.Trim & "'")
        loaddl()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        'khai báo các biến cần dùng
        Dim src As String
        Dim sobj As String
        Dim sotu As Integer
        Dim pos As Integer
        'thiết lập thử giá trị của các chuỗi
        src = "Truong ta Ta hoc, nha ta Ta o"
        sobj = "ta"
        'khởi động trị ban đầu các biến
        sotu = 0
        pos = 1
        Do 'Lặp
            'bắt đầu từ vị trí pos của src, thử tìm vị trí kế của sobj 
            pos = InStr(pos, src, sobj, vbTextCompare)
            'nếu không có, dừng vòng lặp 
            If pos = 0 Then Exit Do
            'nếu có, tăng counter đếm 
            sotu = sotu + 1
            'tăng vị trí tìm về sau từ vừa tìm được 
            pos = pos + Len(sobj)
        Loop Until pos = 0
        'hiển thị kết quả tìm kiếm
        MsgBox("Số  cần tìm là : " & sotu)
    End Sub

End Class