Public Class MaskedTextBox

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged


        Try
            TextChangedException()

        Catch ex As Exception
            '何もしない
            Debug.Print("エラーが発生しているけど無視.")

        End Try

    End Sub

    ''' <summary>
    ''' エラーを発生させるだけのためのメソッド.
    ''' </summary>
    ''' <remarks></remarks>
    Private Shared Sub TextChangedException()
        Debug.Print("Call Exception")
        Throw New Exception
    End Sub

End Class