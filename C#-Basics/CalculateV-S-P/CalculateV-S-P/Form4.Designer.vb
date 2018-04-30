<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.РъбестиТелаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПравилнаЧетПирToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПравилнаПризмаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВалчестиТелаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.КонусToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЦилиндърToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(42, 159)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(252, 274)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 69)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Конус"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(451, 194)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(451, 234)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(451, 274)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(98, 22)
        Me.TextBox3.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(352, 318)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "V=Pi*(r*r)*h"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(329, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "S1= 2*Pi*r(r+h)"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(451, 313)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(98, 22)
        Me.TextBox4.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(416, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "h"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(419, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "r"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(556, 274)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Сметни"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(555, 313)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 22)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Сметни"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.РъбестиТелаToolStripMenuItem, Me.ВалчестиТелаToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(734, 28)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'РъбестиТелаToolStripMenuItem
        '
        Me.РъбестиТелаToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ПравилнаЧетПирToolStripMenuItem, Me.ПравилнаПризмаToolStripMenuItem})
        Me.РъбестиТелаToolStripMenuItem.Name = "РъбестиТелаToolStripMenuItem"
        Me.РъбестиТелаToolStripMenuItem.Size = New System.Drawing.Size(111, 24)
        Me.РъбестиТелаToolStripMenuItem.Text = "Ръбести тела"
        '
        'ПравилнаЧетПирToolStripMenuItem
        '
        Me.ПравилнаЧетПирToolStripMenuItem.Name = "ПравилнаЧетПирToolStripMenuItem"
        Me.ПравилнаЧетПирToolStripMenuItem.Size = New System.Drawing.Size(211, 24)
        Me.ПравилнаЧетПирToolStripMenuItem.Text = "Правилна чет. пир."
        '
        'ПравилнаПризмаToolStripMenuItem
        '
        Me.ПравилнаПризмаToolStripMenuItem.Name = "ПравилнаПризмаToolStripMenuItem"
        Me.ПравилнаПризмаToolStripMenuItem.Size = New System.Drawing.Size(211, 24)
        Me.ПравилнаПризмаToolStripMenuItem.Text = "Правилна призма"
        '
        'ВалчестиТелаToolStripMenuItem
        '
        Me.ВалчестиТелаToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.КонусToolStripMenuItem, Me.ЦилиндърToolStripMenuItem})
        Me.ВалчестиТелаToolStripMenuItem.Name = "ВалчестиТелаToolStripMenuItem"
        Me.ВалчестиТелаToolStripMenuItem.Size = New System.Drawing.Size(118, 24)
        Me.ВалчестиТелаToolStripMenuItem.Text = "Валчести тела"
        '
        'КонусToolStripMenuItem
        '
        Me.КонусToolStripMenuItem.Name = "КонусToolStripMenuItem"
        Me.КонусToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.КонусToolStripMenuItem.Text = "Конус"
        '
        'ЦилиндърToolStripMenuItem
        '
        Me.ЦилиндърToolStripMenuItem.Name = "ЦилиндърToolStripMenuItem"
        Me.ЦилиндърToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.ЦилиндърToolStripMenuItem.Text = "Цилиндър"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 489)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents РъбестиТелаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПравилнаЧетПирToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПравилнаПризмаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ВалчестиТелаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents КонусToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЦилиндърToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
