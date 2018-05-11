Public Class Frm_Main
    Private Sub Frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ThêmĐộcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmĐộcGiảToolStripMenuItem.Click
        Dim frmhs As Frm_ThemDocGia = New Frm_ThemDocGia()
        frmhs.MdiParent = Me
        frmhs.Show()
    End Sub

    Private Sub ThêmLoạiĐộcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmLoạiĐộcGiảToolStripMenuItem.Click
        Dim frmhs As Frm_ThemLoaiDocGia = New Frm_ThemLoaiDocGia()
        frmhs.MdiParent = Me
        frmhs.Show()
    End Sub
End Class