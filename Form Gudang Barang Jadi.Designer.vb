<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Gudang_Barang_Jadi
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Btninfomasuk = New System.Windows.Forms.Button()
        Me.Btninfokeluar = New System.Windows.Forms.Button()
        Me.Btnstok = New System.Windows.Forms.Button()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader19, Me.ColumnHeader20})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 68)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(149, 126)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Mobil Sedan"
        Me.ColumnHeader19.Width = 75
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Mobil Sport"
        Me.ColumnHeader20.Width = 67
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(12, 254)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(149, 126)
        Me.ListView2.TabIndex = 1
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Mobil Sedan"
        Me.ColumnHeader1.Width = 72
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Mobil Sport"
        Me.ColumnHeader2.Width = 69
        '
        'ListView3
        '
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView3.FullRowSelect = True
        Me.ListView3.GridLines = True
        Me.ListView3.HideSelection = False
        Me.ListView3.Location = New System.Drawing.Point(199, 254)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(149, 126)
        Me.ListView3.TabIndex = 2
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Mobil Sedan"
        Me.ColumnHeader3.Width = 74
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Mobil Sport"
        Me.ColumnHeader4.Width = 70
        '
        'Btninfomasuk
        '
        Me.Btninfomasuk.Location = New System.Drawing.Point(87, 397)
        Me.Btninfomasuk.Name = "Btninfomasuk"
        Me.Btninfomasuk.Size = New System.Drawing.Size(74, 25)
        Me.Btninfomasuk.TabIndex = 3
        Me.Btninfomasuk.Text = "Update"
        Me.Btninfomasuk.UseVisualStyleBackColor = True
        '
        'Btninfokeluar
        '
        Me.Btninfokeluar.Location = New System.Drawing.Point(274, 397)
        Me.Btninfokeluar.Name = "Btninfokeluar"
        Me.Btninfokeluar.Size = New System.Drawing.Size(74, 25)
        Me.Btninfokeluar.TabIndex = 4
        Me.Btninfokeluar.Text = "Update"
        Me.Btninfokeluar.UseVisualStyleBackColor = True
        '
        'Btnstok
        '
        Me.Btnstok.Location = New System.Drawing.Point(87, 200)
        Me.Btnstok.Name = "Btnstok"
        Me.Btnstok.Size = New System.Drawing.Size(74, 25)
        Me.Btnstok.TabIndex = 5
        Me.Btnstok.Text = "Update"
        Me.Btnstok.UseVisualStyleBackColor = True
        '
        'btnmenu
        '
        Me.btnmenu.Location = New System.Drawing.Point(219, 68)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(101, 32)
        Me.btnmenu.TabIndex = 6
        Me.btnmenu.Text = "Menu Utama"
        Me.btnmenu.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(219, 106)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(101, 32)
        Me.btnback.TabIndex = 7
        Me.btnback.Text = "Back To Produksi"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Location = New System.Drawing.Point(219, 144)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(101, 32)
        Me.btnnext.TabIndex = 8
        Me.btnnext.Text = "Next To Logistik"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Minion Pro", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 33)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "GUDANG BARANG JADI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Data Stok"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Data Stok Masuk "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(196, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Data Stok Keluar"
        '
        'Form_Gudang_Barang_Jadi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btnmenu)
        Me.Controls.Add(Me.Btnstok)
        Me.Controls.Add(Me.Btninfokeluar)
        Me.Controls.Add(Me.Btninfomasuk)
        Me.Controls.Add(Me.ListView3)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Form_Gudang_Barang_Jadi"
        Me.Text = "Form_Gudang_Barang_Jadi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ListView3 As ListView
    Friend WithEvents Btninfomasuk As Button
    Friend WithEvents Btninfokeluar As Button
    Friend WithEvents Btnstok As Button
    Friend WithEvents btnmenu As Button
    Friend WithEvents btnback As Button
    Friend WithEvents btnnext As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ColumnHeader19 As ColumnHeader
    Friend WithEvents ColumnHeader20 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class
