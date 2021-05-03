<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LatihanUTS
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbnama = New System.Windows.Forms.ComboBox()
        Me.txtjurusan = New System.Windows.Forms.TextBox()
        Me.txtjenjang = New System.Windows.Forms.TextBox()
        Me.txtnim = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.txtuts = New System.Windows.Forms.TextBox()
        Me.txtuas = New System.Windows.Forms.TextBox()
        Me.txttugas = New System.Windows.Forms.TextBox()
        Me.txtkehadiran = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnproses = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbnama)
        Me.GroupBox1.Controls.Add(Me.txtjurusan)
        Me.GroupBox1.Controls.Add(Me.txtjenjang)
        Me.GroupBox1.Controls.Add(Me.txtnim)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Hack", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(69, 30)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(610, 197)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATA MAHASISWA"
        '
        'cbnama
        '
        Me.cbnama.Font = New System.Drawing.Font("Hack", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbnama.FormattingEnabled = True
        Me.cbnama.Items.AddRange(New Object() {"Pahrurozi", "Muhammad Zakaria", "Titin Yustika", "Hafif Nur Muhammad"})
        Me.cbnama.Location = New System.Drawing.Point(151, 39)
        Me.cbnama.Name = "cbnama"
        Me.cbnama.Size = New System.Drawing.Size(121, 22)
        Me.cbnama.TabIndex = 8
        '
        'txtjurusan
        '
        Me.txtjurusan.Font = New System.Drawing.Font("Hack", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjurusan.Location = New System.Drawing.Point(151, 158)
        Me.txtjurusan.Name = "txtjurusan"
        Me.txtjurusan.Size = New System.Drawing.Size(121, 21)
        Me.txtjurusan.TabIndex = 7
        '
        'txtjenjang
        '
        Me.txtjenjang.Font = New System.Drawing.Font("Hack", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjenjang.Location = New System.Drawing.Point(151, 118)
        Me.txtjenjang.Name = "txtjenjang"
        Me.txtjenjang.Size = New System.Drawing.Size(121, 21)
        Me.txtjenjang.TabIndex = 6
        '
        'txtnim
        '
        Me.txtnim.Font = New System.Drawing.Font("Hack", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnim.Location = New System.Drawing.Point(151, 79)
        Me.txtnim.Name = "txtnim"
        Me.txtnim.Size = New System.Drawing.Size(121, 21)
        Me.txtnim.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Hack", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "JURUSAN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Hack", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "JENJANG"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Hack", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Hack", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NAMA"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListView1)
        Me.GroupBox2.Controls.Add(Me.txtuts)
        Me.GroupBox2.Controls.Add(Me.txtuas)
        Me.GroupBox2.Controls.Add(Me.txttugas)
        Me.GroupBox2.Controls.Add(Me.txtkehadiran)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.btnproses)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(69, 267)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(610, 404)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATA NILAI"
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(48, 210)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(509, 146)
        Me.ListView1.TabIndex = 21
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'txtuts
        '
        Me.txtuts.Font = New System.Drawing.Font("Hack", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuts.Location = New System.Drawing.Point(151, 111)
        Me.txtuts.Name = "txtuts"
        Me.txtuts.Size = New System.Drawing.Size(121, 21)
        Me.txtuts.TabIndex = 20
        '
        'txtuas
        '
        Me.txtuas.Font = New System.Drawing.Font("Hack", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuas.Location = New System.Drawing.Point(151, 150)
        Me.txtuas.Name = "txtuas"
        Me.txtuas.Size = New System.Drawing.Size(121, 21)
        Me.txtuas.TabIndex = 19
        '
        'txttugas
        '
        Me.txttugas.Font = New System.Drawing.Font("Hack", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttugas.Location = New System.Drawing.Point(151, 70)
        Me.txttugas.Name = "txttugas"
        Me.txttugas.Size = New System.Drawing.Size(121, 21)
        Me.txttugas.TabIndex = 18
        '
        'txtkehadiran
        '
        Me.txtkehadiran.Font = New System.Drawing.Font("Hack", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkehadiran.Location = New System.Drawing.Point(151, 31)
        Me.txtkehadiran.Name = "txtkehadiran"
        Me.txtkehadiran.Size = New System.Drawing.Size(121, 21)
        Me.txtkehadiran.TabIndex = 17
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Hack", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(328, 130)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "EXIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Hack", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(328, 92)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "CLEAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnproses
        '
        Me.btnproses.Font = New System.Drawing.Font("Hack", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproses.Location = New System.Drawing.Point(328, 54)
        Me.btnproses.Name = "btnproses"
        Me.btnproses.Size = New System.Drawing.Size(75, 23)
        Me.btnproses.TabIndex = 4
        Me.btnproses.Text = "PROSES"
        Me.btnproses.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Hack", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(52, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 14)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "UAS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Hack", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(52, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 14)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "UTS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Hack", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(52, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 14)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "TUGAS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Hack", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 14)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "KEHADIRAN"
        '
        'Latihan1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 677)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Hack", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Latihan1"
        Me.Text = "PENILAIAN MAHASISWA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbnama As ComboBox
    Friend WithEvents txtjurusan As TextBox
    Friend WithEvents txtjenjang As TextBox
    Friend WithEvents txtnim As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnproses As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtuts As TextBox
    Friend WithEvents txtuas As TextBox
    Friend WithEvents txttugas As TextBox
    Friend WithEvents txtkehadiran As TextBox
    Friend WithEvents ListView1 As ListView
End Class
