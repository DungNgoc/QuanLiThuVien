<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ThemTacGia
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
        Me.Txt_MaTacGia = New System.Windows.Forms.TextBox()
        Me.TxtTenTacGia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Nhap = New System.Windows.Forms.Button()
        Me.Btn_NhapVaDong = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Tác Giả"
        '
        'Txt_MaTacGia
        '
        Me.Txt_MaTacGia.Location = New System.Drawing.Point(145, 61)
        Me.Txt_MaTacGia.Name = "Txt_MaTacGia"
        Me.Txt_MaTacGia.ReadOnly = True
        Me.Txt_MaTacGia.Size = New System.Drawing.Size(192, 22)
        Me.Txt_MaTacGia.TabIndex = 1
        '
        'TxtTenTacGia
        '
        Me.TxtTenTacGia.Location = New System.Drawing.Point(145, 108)
        Me.TxtTenTacGia.Name = "TxtTenTacGia"
        Me.TxtTenTacGia.Size = New System.Drawing.Size(192, 22)
        Me.TxtTenTacGia.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên Tác Giả"
        '
        'Btn_Nhap
        '
        Me.Btn_Nhap.Location = New System.Drawing.Point(41, 153)
        Me.Btn_Nhap.Name = "Btn_Nhap"
        Me.Btn_Nhap.Size = New System.Drawing.Size(78, 52)
        Me.Btn_Nhap.TabIndex = 4
        Me.Btn_Nhap.Text = "Nhập"
        Me.Btn_Nhap.UseVisualStyleBackColor = True
        '
        'Btn_NhapVaDong
        '
        Me.Btn_NhapVaDong.Location = New System.Drawing.Point(226, 153)
        Me.Btn_NhapVaDong.Name = "Btn_NhapVaDong"
        Me.Btn_NhapVaDong.Size = New System.Drawing.Size(111, 52)
        Me.Btn_NhapVaDong.TabIndex = 5
        Me.Btn_NhapVaDong.Text = "Nhập Và Đóng"
        Me.Btn_NhapVaDong.UseVisualStyleBackColor = True
        '
        'Frm_ThemTacGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 275)
        Me.Controls.Add(Me.Btn_NhapVaDong)
        Me.Controls.Add(Me.Btn_Nhap)
        Me.Controls.Add(Me.TxtTenTacGia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_MaTacGia)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_ThemTacGia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm Tác Giả"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_MaTacGia As TextBox
    Friend WithEvents TxtTenTacGia As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Nhap As Button
    Friend WithEvents Btn_NhapVaDong As Button
End Class
