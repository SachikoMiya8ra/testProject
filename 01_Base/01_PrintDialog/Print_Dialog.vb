Public Class Print_Dialog

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'プリントダイアログ
        Dim pd As PrintDialog = New PrintDialog

        pd.AllowCurrentPage = Me.ChkCurrentPage.Checked
        pd.AllowPrintToFile = Me.ChkPrintToFile.Checked
        pd.AllowSelection = Me.ChkSelection.Checked
        pd.AllowSomePages = Me.ChkSomePages.Checked

        'ShowDialog
        '
        'pd.ShowNetwork = False
        pd.ShowDialog()

    End Sub
End Class
