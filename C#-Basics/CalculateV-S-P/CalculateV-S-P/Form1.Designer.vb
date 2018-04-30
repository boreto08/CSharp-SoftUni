<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.РъбестиТелаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПравилнаЧетПирToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПравилнаПризмаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВалчестиТелаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.КонусToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЦилиндърToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(123, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(664, 92)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Проект на  написването на оценки" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                               " & _
    "     Б.Б"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.РъбестиТелаToolStripMenuItem, Me.ВалчестиТелаToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(963, 28)
        Me.MenuStrip1.TabIndex = 2
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
        Me.КонусToolStripMenuItem.Size = New System.Drawing.Size(150, 24)
        Me.КонусToolStripMenuItem.Text = "Конус"
        '
        'ЦилиндърToolStripMenuItem
        '
        Me.ЦилиндърToolStripMenuItem.Name = "ЦилиндърToolStripMenuItem"
        Me.ЦилиндърToolStripMenuItem.Size = New System.Drawing.Size(150, 24)
        Me.ЦилиндърToolStripMenuItem.Text = "Цилиндър"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 510)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents РъбестиТелаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПравилнаЧетПирToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПравилнаПризмаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ВалчестиТелаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents КонусToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЦилиндърToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
