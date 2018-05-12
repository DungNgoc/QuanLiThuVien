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

    Private Sub ThêmSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmSáchToolStripMenuItem.Click
        Dim frmSach As Frm_ThemSach = New Frm_ThemSach()
        frmSach.MdiParent = Me
        frmSach.Show()
    End Sub

    Private Sub ThêmThểLoạiSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmThểLoạiSáchToolStripMenuItem.Click
        Dim frmTheLoaiSach As Frm_ThemTheLoaiSach = New Frm_ThemTheLoaiSach()
        frmTheLoaiSach.MdiParent = Me
        frmTheLoaiSach.Show()
    End Sub

    Private Sub ThêmTácGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmTácGiảToolStripMenuItem.Click
        Dim frmTacGia As Frm_ThemTacGia = New Frm_ThemTacGia()
        frmTacGia.MdiParent = Me
        frmTacGia.Show()
    End Sub
End Class