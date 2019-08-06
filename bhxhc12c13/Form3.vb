Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        kiemtra()

    End Sub
    Sub kiemtra()
        Dim s As String
        s = "select lan,noidung,ten_huyen,ma_dv,ten,diachi,sokiemsoat,sohieubuugui from bhxh_c12c13 where  (ma_dv='" & tx.Text.ToString & "' or sohieubuugui='" & tx.Text.ToString & "') and ((thang=" & th.SelectedItem.ToString & " or thang = '0' ) " & " and nam=" & nm.SelectedItem.ToString & ")"
        gr.DataSource = dl(s)
        tx.SelectAll()
        tx.Focus()
    End Sub
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bind_th_nam()
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
       
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub


    Private Sub tx_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tx.KeyDown
        If e.KeyCode = Keys.Enter Then
            kiemtra()

        End If


    End Sub

   
    Private Sub tx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tx.TextChanged

    End Sub

End Class