<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gudang_bahan_baku
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
        Me.nextto = New System.Windows.Forms.Button()
        Me.backto = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tmplknkeluar = New System.Windows.Forms.Button()
        Me.tmplknmasuk = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.formutama = New System.Windows.Forms.Button()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'nextto
        '
        Me.nextto.Location = New System.Drawing.Point(706, 509)
        Me.nextto.Name = "nextto"
        Me.nextto.Size = New System.Drawing.Size(107, 36)
        Me.nextto.TabIndex = 34
        Me.nextto.Text = "Next Produksi >>"
        Me.nextto.UseVisualStyleBackColor = True
        '
        'backto
        '
        Me.backto.Location = New System.Drawing.Point(15, 509)
        Me.backto.Name = "backto"
        Me.backto.Size = New System.Drawing.Size(140, 36)
        Me.backto.TabIndex = 33
        Me.backto.Text = "<< Kembali ke Purchasing"
        Me.backto.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(141, -100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(485, 27)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "DEPARTEMEN GUDANG BAHAN BAKU"
        '
        'ListView3
        '
        Me.ListView3.HideSelection = False
        Me.ListView3.Location = New System.Drawing.Point(15, 327)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(798, 150)
        Me.ListView3.TabIndex = 31
        Me.ListView3.UseCompatibleStateImageBehavior = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 297)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 18)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Stock Tersedia"
        '
        'tmplknkeluar
        '
        Me.tmplknkeluar.Location = New System.Drawing.Point(726, 253)
        Me.tmplknkeluar.Name = "tmplknkeluar"
        Me.tmplknkeluar.Size = New System.Drawing.Size(97, 37)
        Me.tmplknkeluar.TabIndex = 29
        Me.tmplknkeluar.Text = "Show Info"
        Me.tmplknkeluar.UseVisualStyleBackColor = True
        '
        'tmplknmasuk
        '
        Me.tmplknmasuk.Location = New System.Drawing.Point(311, 253)
        Me.tmplknmasuk.Name = "tmplknmasuk"
        Me.tmplknmasuk.Size = New System.Drawing.Size(98, 37)
        Me.tmplknmasuk.TabIndex = 28
        Me.tmplknmasuk.Text = "Show Info"
        Me.tmplknmasuk.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-20, -48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Barang Masuk"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader12})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(44, 96)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(365, 140)
        Me.ListView1.TabIndex = 26
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Tanggal"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Badan"
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Mesin"
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Kursi"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Roda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(424, -48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Barang Keluar"
        '
        'formutama
        '
        Me.formutama.Location = New System.Drawing.Point(566, 509)
        Me.formutama.Name = "formutama"
        Me.formutama.Size = New System.Drawing.Size(94, 36)
        Me.formutama.TabIndex = 35
        Me.formutama.Text = "Form Utama"
        Me.formutama.UseVisualStyleBackColor = True
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(433, 96)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(363, 140)
        Me.ListView2.TabIndex = 27
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Tanggal"
        Me.ColumnHeader6.Width = 80
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Badan"
        Me.ColumnHeader7.Width = 80
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Mesin"
        Me.ColumnHeader8.Width = 80
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Kursi"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Roda"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(156, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(485, 27)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "DEPARTEMEN GUDANG BAHAN BAKU"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Barang Masuk"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(456, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Barang Keluar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(311, 509)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 36)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "LIHAT STOK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Pintu"
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Pintu"
        '
        'Gudang_bahan_baku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 557)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.nextto)
        Me.Controls.Add(Me.backto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListView3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tmplknkeluar)
        Me.Controls.Add(Me.tmplknmasuk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.formutama)
        Me.Controls.Add(Me.ListView2)
        Me.Name = "Gudang_bahan_baku"
        Me.Text = "Gudang_bahan_baku"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nextto As Button
    Friend WithEvents backto As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ListView3 As ListView
    Friend WithEvents Label3 As Label
    Friend WithEvents tmplknkeluar As Button
    Friend WithEvents tmplknmasuk As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents formutama As Button
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
End Class
