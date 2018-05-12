<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_QLLoaiDocGia
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
        Me.Lb1 = New System.Windows.Forms.Label()
        Me.Dgv_ListLoaiDocGia = New System.Windows.Forms.DataGridView()
        Me.Txt_TenLoaiDocGia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_MaloaiDocGia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_CapNhap = New System.Windows.Forms.Button()
        Me.Btn_Xoa = New System.Windows.Forms.Button()
        CType(Me.Dgv_ListLoaiDocGia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lb1
        '
        Me.Lb1.Location = New System.Drawing.Point(72, 58)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(225, 23)
        Me.Lb1.TabIndex = 0
        Me.Lb1.Text = "Danh sách Các Loại Độc Giả:"
        '
        'Dgv_ListLoaiDocGia
        '
        Me.Dgv_ListLoaiDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ListLoaiDocGia.Location = New System.Drawing.Point(76, 103)
        Me.Dgv_ListLoaiDocGia.Name = "Dgv_ListLoaiDocGia"
        Me.Dgv_ListLoaiDocGia.ReadOnly = True
        Me.Dgv_ListLoaiDocGia.RowTemplate.Height = 28
        Me.Dgv_ListLoaiDocGia.Size = New System.Drawing.Size(367, 203)
        Me.Dgv_ListLoaiDocGia.TabIndex = 1
        '
        'Txt_TenLoaiDocGia
        '
        Me.Txt_TenLoaiDocGia.Location = New System.Drawing.Point(403, 407)
        Me.Txt_TenLoaiDocGia.Name = "Txt_TenLoaiDocGia"
        Me.Txt_TenLoaiDocGia.Size = New System.Drawing.Size(220, 26)
        Me.Txt_TenLoaiDocGia.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(123, 410)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 41)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Tên Loại Độc Giả"
        '
        'Txt_MaloaiDocGia
        '
        Me.Txt_MaloaiDocGia.Location = New System.Drawing.Point(403, 366)
        Me.Txt_MaloaiDocGia.Name = "Txt_MaloaiDocGia"
        Me.Txt_MaloaiDocGia.ReadOnly = True
        Me.Txt_MaloaiDocGia.Size = New System.Drawing.Size(220, 26)
        Me.Txt_MaloaiDocGia.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(123, 369)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 41)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Mã Loại Độc Giả"
        '
        'Btn_CapNhap
        '
        Me.Btn_CapNhap.Location = New System.Drawing.Point(179, 481)
        Me.Btn_CapNhap.Name = "Btn_CapNhap"
        Me.Btn_CapNhap.Size = New System.Drawing.Size(94, 33)
        Me.Btn_CapNhap.TabIndex = 8
        Me.Btn_CapNhap.Text = "Cập nhập"
        Me.Btn_CapNhap.UseVisualStyleBackColor = True
        '
        'Btn_Xoa
        '
        Me.Btn_Xoa.Location = New System.Drawing.Point(413, 481)
        Me.Btn_Xoa.Name = "Btn_Xoa"
        Me.Btn_Xoa.Size = New System.Drawing.Size(80, 33)
        Me.Btn_Xoa.TabIndex = 9
        Me.Btn_Xoa.Text = "Xóa"
        Me.Btn_Xoa.UseVisualStyleBackColor = True
        '
        'Frm_QLLoaiDocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 554)
        Me.Controls.Add(Me.Btn_Xoa)
        Me.Controls.Add(Me.Btn_CapNhap)
        Me.Controls.Add(Me.Txt_TenLoaiDocGia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_MaloaiDocGia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Dgv_ListLoaiDocGia)
        Me.Controls.Add(Me.Lb1)
        Me.Name = "Frm_QLLoaiDocGia"
        Me.ShowIcon = False
        Me.Text = "Quản Lí Loại Độc Giả"
        CType(Me.Dgv_ListLoaiDocGia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lb1 As Label
    Friend WithEvents Dgv_ListLoaiDocGia As DataGridView
    Friend WithEvents Txt_TenLoaiDocGia As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_MaloaiDocGia As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_CapNhap As Button
    Friend WithEvents Btn_Xoa As Button
End Class
