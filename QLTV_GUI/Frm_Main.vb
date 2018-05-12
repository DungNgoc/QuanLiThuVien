Public Class Frm_Main


    Private Sub ThêmĐộcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmĐộcGiảToolStripMenuItem.Click
        Dim frmdg As Frm_ThemDocGia = New Frm_ThemDocGia()
        frmdg.MdiParent = Me
        frmdg.Show()
    End Sub

    Private Sub ThêmLoạiĐộcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmLoạiĐộcGiảToolStripMenuItem.Click
        Dim frmdg As Frm_ThemLoaiDocGia = New Frm_ThemLoaiDocGia()
        frmdg.MdiParent = Me
        frmdg.Show()
    End Sub

    Private Sub QuảnLíĐộcGiảToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles QuảnLíĐộcGiảToolStripMenuItem1.Click
        Dim frmdg As Frm_QLDocGia = New Frm_QLDocGia()
        frmdg.MdiParent = Me
        frmdg.Show()
    End Sub

    Private Sub QuảnLíLoạiĐộcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíLoạiĐộcGiảToolStripMenuItem.Click
        Dim frmldg As Frm_QLLoaiDocGia = New Frm_QLLoaiDocGia()
        frmldg.MdiParent = Me
        frmldg.Show()
    End Sub
End Class