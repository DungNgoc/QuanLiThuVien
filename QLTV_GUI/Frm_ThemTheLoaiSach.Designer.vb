<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ThemTheLoaiSach
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_MaTheLoaiSach = New System.Windows.Forms.TextBox()
        Me.Txt_TenTheLoaiSach = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Nhap = New System.Windows.Forms.Button()
        Me.Btn_NhapVaDong = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Thể Loại Sách"
        '
        'Txt_MaTheLoaiSach
        '
        Me.Txt_MaTheLoaiSach.Location = New System.Drawing.Point(215, 111)
        Me.Txt_MaTheLoaiSach.Name = "Txt_MaTheLoaiSach"
        Me.Txt_MaTheLoaiSach.ReadOnly = True
        Me.Txt_MaTheLoaiSach.Size = New System.Drawing.Size(219, 22)
        Me.Txt_MaTheLoaiSach.TabIndex = 1
        '
        'Txt_TenTheLoaiSach
        '
        Me.Txt_TenTheLoaiSach.Location = New System.Drawing.Point(215, 163)
        Me.Txt_TenTheLoaiSach.Name = "Txt_TenTheLoaiSach"
        Me.Txt_TenTheLoaiSach.Size = New System.Drawing.Size(219, 22)
        Me.Txt_TenTheLoaiSach.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên Thể Loại Sách"
        '
        'Btn_Nhap
        '
        Me.Btn_Nhap.Location = New System.Drawing.Point(77, 215)
        Me.Btn_Nhap.Name = "Btn_Nhap"
        Me.Btn_Nhap.Size = New System.Drawing.Size(88, 53)
        Me.Btn_Nhap.TabIndex = 4
        Me.Btn_Nhap.Text = "Nhập"
        Me.Btn_Nhap.UseVisualStyleBackColor = True
        '
        'Btn_NhapVaDong
        '
        Me.Btn_NhapVaDong.Location = New System.Drawing.Point(295, 215)
        Me.Btn_NhapVaDong.Name = "Btn_NhapVaDong"
        Me.Btn_NhapVaDong.Size = New System.Drawing.Size(139, 53)
        Me.Btn_NhapVaDong.TabIndex = 5
        Me.Btn_NhapVaDong.Text = "Nhập và đóng"
        Me.Btn_NhapVaDong.UseVisualStyleBackColor = True
        '
        'Frm_ThemTheLoaiSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 311)
        Me.Controls.Add(Me.Btn_NhapVaDong)
        Me.Controls.Add(Me.Btn_Nhap)
        Me.Controls.Add(Me.Txt_TenTheLoaiSach)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_MaTheLoaiSach)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_ThemTheLoaiSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm Thể Loại Sách"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_MaTheLoaiSach As TextBox
    Friend WithEvents Txt_TenTheLoaiSach As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Nhap As Button
    Friend WithEvents Btn_NhapVaDong As Button
End Class
