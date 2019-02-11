<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aritmatika
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aritmatika))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtHasilPangkat = New System.Windows.Forms.TextBox()
        Me.btPangkat = New System.Windows.Forms.Button()
        Me.txtPangkat = New System.Windows.Forms.TextBox()
        Me.txtAngkaPangkat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btString = New System.Windows.Forms.Button()
        Me.btKurang = New System.Windows.Forms.Button()
        Me.btModulus = New System.Windows.Forms.Button()
        Me.btKali = New System.Windows.Forms.Button()
        Me.btPembagi = New System.Windows.Forms.Button()
        Me.btTambah = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtHasValue = New System.Windows.Forms.TextBox()
        Me.txtValue2 = New System.Windows.Forms.TextBox()
        Me.txtValue1 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 503)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Aritmatika"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 286)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(339, 119)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contoh Penggunaan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A = 3^4 ; Hasil : A = 81 dari 3×3×3×3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contoh Penggabungan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "Judul = ""Visual"" & ""Basic"" ; Hasil : Judul = Visual Basic" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contoh dalam Progra" &
    "m lihat samping"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Lihat tabel dibawah ini untuk operator " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "aritmatika:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.OperatorAritmatika.My.Resources.Resources.aritmat
        Me.PictureBox1.Location = New System.Drawing.Point(11, 79)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(272, 189)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtHasilPangkat)
        Me.GroupBox2.Controls.Add(Me.btPangkat)
        Me.GroupBox2.Controls.Add(Me.txtPangkat)
        Me.GroupBox2.Controls.Add(Me.txtAngkaPangkat)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(401, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(573, 150)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pemangkatan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(175, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Kode Program"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(178, 28)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(389, 111)
        Me.TextBox4.TabIndex = 3
        Me.TextBox4.Text = resources.GetString("TextBox4.Text")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "A = "
        '
        'txtHasilPangkat
        '
        Me.txtHasilPangkat.Location = New System.Drawing.Point(90, 109)
        Me.txtHasilPangkat.Name = "txtHasilPangkat"
        Me.txtHasilPangkat.Size = New System.Drawing.Size(52, 20)
        Me.txtHasilPangkat.TabIndex = 5
        '
        'btPangkat
        '
        Me.btPangkat.Location = New System.Drawing.Point(90, 80)
        Me.btPangkat.Name = "btPangkat"
        Me.btPangkat.Size = New System.Drawing.Size(53, 23)
        Me.btPangkat.TabIndex = 4
        Me.btPangkat.Text = "Hitung"
        Me.btPangkat.UseVisualStyleBackColor = True
        '
        'txtPangkat
        '
        Me.txtPangkat.Location = New System.Drawing.Point(90, 54)
        Me.txtPangkat.Name = "txtPangkat"
        Me.txtPangkat.Size = New System.Drawing.Size(53, 20)
        Me.txtPangkat.TabIndex = 3
        '
        'txtAngkaPangkat
        '
        Me.txtAngkaPangkat.Location = New System.Drawing.Point(90, 28)
        Me.txtAngkaPangkat.Name = "txtAngkaPangkat"
        Me.txtAngkaPangkat.Size = New System.Drawing.Size(53, 20)
        Me.txtAngkaPangkat.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Pangkat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Angka"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.btString)
        Me.GroupBox3.Controls.Add(Me.btKurang)
        Me.GroupBox3.Controls.Add(Me.btModulus)
        Me.GroupBox3.Controls.Add(Me.btKali)
        Me.GroupBox3.Controls.Add(Me.btPembagi)
        Me.GroupBox3.Controls.Add(Me.btTambah)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtHasValue)
        Me.GroupBox3.Controls.Add(Me.txtValue2)
        Me.GroupBox3.Controls.Add(Me.txtValue1)
        Me.GroupBox3.Location = New System.Drawing.Point(401, 170)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(573, 346)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'btString
        '
        Me.btString.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btString.Location = New System.Drawing.Point(360, 69)
        Me.btString.Name = "btString"
        Me.btString.Size = New System.Drawing.Size(76, 23)
        Me.btString.TabIndex = 10
        Me.btString.Text = "String"
        Me.btString.UseVisualStyleBackColor = True
        '
        'btKurang
        '
        Me.btKurang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btKurang.Location = New System.Drawing.Point(300, 40)
        Me.btKurang.Name = "btKurang"
        Me.btKurang.Size = New System.Drawing.Size(54, 23)
        Me.btKurang.TabIndex = 9
        Me.btKurang.Text = "-"
        Me.btKurang.UseVisualStyleBackColor = True
        '
        'btModulus
        '
        Me.btModulus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btModulus.Location = New System.Drawing.Point(360, 40)
        Me.btModulus.Name = "btModulus"
        Me.btModulus.Size = New System.Drawing.Size(76, 23)
        Me.btModulus.TabIndex = 8
        Me.btModulus.Text = "mod"
        Me.btModulus.UseVisualStyleBackColor = True
        '
        'btKali
        '
        Me.btKali.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btKali.Location = New System.Drawing.Point(240, 40)
        Me.btKali.Name = "btKali"
        Me.btKali.Size = New System.Drawing.Size(54, 23)
        Me.btKali.TabIndex = 7
        Me.btKali.Text = "x"
        Me.btKali.UseVisualStyleBackColor = True
        '
        'btPembagi
        '
        Me.btPembagi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPembagi.Location = New System.Drawing.Point(240, 69)
        Me.btPembagi.Name = "btPembagi"
        Me.btPembagi.Size = New System.Drawing.Size(54, 23)
        Me.btPembagi.TabIndex = 6
        Me.btPembagi.Text = "/"
        Me.btPembagi.UseVisualStyleBackColor = True
        '
        'btTambah
        '
        Me.btTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTambah.Location = New System.Drawing.Point(300, 69)
        Me.btTambah.Name = "btTambah"
        Me.btTambah.Size = New System.Drawing.Size(54, 23)
        Me.btTambah.TabIndex = 5
        Me.btTambah.Text = "+"
        Me.btTambah.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(123, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Value 2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Value 1"
        '
        'txtHasValue
        '
        Me.txtHasValue.Location = New System.Drawing.Point(70, 66)
        Me.txtHasValue.Name = "txtHasValue"
        Me.txtHasValue.Size = New System.Drawing.Size(155, 20)
        Me.txtHasValue.TabIndex = 2
        '
        'txtValue2
        '
        Me.txtValue2.Location = New System.Drawing.Point(123, 40)
        Me.txtValue2.Name = "txtValue2"
        Me.txtValue2.Size = New System.Drawing.Size(102, 20)
        Me.txtValue2.TabIndex = 1
        '
        'txtValue1
        '
        Me.txtValue1.Location = New System.Drawing.Point(15, 39)
        Me.txtValue1.Name = "txtValue1"
        Me.txtValue1.Size = New System.Drawing.Size(102, 20)
        Me.txtValue1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 115)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(555, 218)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Hasilnya"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Kode Program"
        '
        'aritmatika
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 539)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "aritmatika"
        Me.Text = "Aritmatika"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtHasilPangkat As TextBox
    Friend WithEvents btPangkat As Button
    Friend WithEvents txtPangkat As TextBox
    Friend WithEvents txtAngkaPangkat As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtHasValue As TextBox
    Friend WithEvents txtValue2 As TextBox
    Friend WithEvents txtValue1 As TextBox
    Friend WithEvents btKali As Button
    Friend WithEvents btPembagi As Button
    Friend WithEvents btTambah As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btString As Button
    Friend WithEvents btKurang As Button
    Friend WithEvents btModulus As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
