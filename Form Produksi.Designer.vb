<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Produksi
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Pro_badan = New System.Windows.Forms.TextBox()
        Me.Pro_pintu = New System.Windows.Forms.TextBox()
        Me.Pro_roda = New System.Windows.Forms.TextBox()
        Me.Pro_kursi = New System.Windows.Forms.TextBox()
        Me.Pro_mesin = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(217, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DEPARTEMEN PRODUKSI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal Produksi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis Mobil"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jumlah Produksi Perakitan Mobil"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Komponen Produksi Yang Dibutuhkan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Kerangka Badan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Kerangka Pintu"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Roda"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 267)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Kursi"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 295)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Mesin"
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(178, 99)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(114, 20)
        Me.txtjumlah.TabIndex = 10
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(126, 32)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(136, 20)
        Me.DateTimePicker1.TabIndex = 11
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"mobil sport", "Mobil Sedan"})
        Me.ComboBox1.Location = New System.Drawing.Point(178, 65)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(114, 21)
        Me.ComboBox1.TabIndex = 12
        '
        'Pro_badan
        '
        Me.Pro_badan.Location = New System.Drawing.Point(111, 171)
        Me.Pro_badan.Name = "Pro_badan"
        Me.Pro_badan.Size = New System.Drawing.Size(114, 20)
        Me.Pro_badan.TabIndex = 13
        '
        'Pro_pintu
        '
        Me.Pro_pintu.Location = New System.Drawing.Point(111, 200)
        Me.Pro_pintu.Name = "Pro_pintu"
        Me.Pro_pintu.Size = New System.Drawing.Size(114, 20)
        Me.Pro_pintu.TabIndex = 14
        '
        'Pro_roda
        '
        Me.Pro_roda.Location = New System.Drawing.Point(111, 232)
        Me.Pro_roda.Name = "Pro_roda"
        Me.Pro_roda.Size = New System.Drawing.Size(114, 20)
        Me.Pro_roda.TabIndex = 15
        '
        'Pro_kursi
        '
        Me.Pro_kursi.Location = New System.Drawing.Point(111, 260)
        Me.Pro_kursi.Name = "Pro_kursi"
        Me.Pro_kursi.Size = New System.Drawing.Size(114, 20)
        Me.Pro_kursi.TabIndex = 16
        '
        'Pro_mesin
        '
        Me.Pro_mesin.Location = New System.Drawing.Point(111, 288)
        Me.Pro_mesin.Name = "Pro_mesin"
        Me.Pro_mesin.Size = New System.Drawing.Size(114, 20)
        Me.Pro_mesin.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(584, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 33)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(509, 232)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 34)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Kembali Ke Gudang Bahan Baku"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(330, 232)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(114, 34)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "Next Gudang Barang Jadi"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(221, 128)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(71, 30)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "Hitung"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(406, 66)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(122, 124)
        Me.ListView1.TabIndex = 24
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Form_Produksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(660, 317)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Pro_mesin)
        Me.Controls.Add(Me.Pro_kursi)
        Me.Controls.Add(Me.Pro_roda)
        Me.Controls.Add(Me.Pro_pintu)
        Me.Controls.Add(Me.Pro_badan)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtjumlah)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Produksi"
        Me.Text = "Form_Produksi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Pro_badan As TextBox
    Friend WithEvents Pro_pintu As TextBox
    Friend WithEvents Pro_roda As TextBox
    Friend WithEvents Pro_kursi As TextBox
    Friend WithEvents Pro_mesin As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ListView1 As ListView
End Class
