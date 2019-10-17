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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonLoad = New System.Windows.Forms.Button()
        Me.ListBoxSaves = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelSTATUS = New System.Windows.Forms.Label()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.TextBoxSynapsis = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonFiles = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonStart
        '
        Me.ButtonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.ButtonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.ButtonStart.Location = New System.Drawing.Point(12, 130)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(104, 30)
        Me.ButtonStart.TabIndex = 0
        Me.ButtonStart.Text = "Start"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(12, 169)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(104, 30)
        Me.ButtonSave.TabIndex = 1
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonLoad
        '
        Me.ButtonLoad.Location = New System.Drawing.Point(12, 208)
        Me.ButtonLoad.Name = "ButtonLoad"
        Me.ButtonLoad.Size = New System.Drawing.Size(104, 30)
        Me.ButtonLoad.TabIndex = 2
        Me.ButtonLoad.Text = "Load"
        Me.ButtonLoad.UseVisualStyleBackColor = True
        '
        'ListBoxSaves
        '
        Me.ListBoxSaves.FormattingEnabled = True
        Me.ListBoxSaves.Location = New System.Drawing.Point(138, 141)
        Me.ListBoxSaves.Name = "ListBoxSaves"
        Me.ListBoxSaves.Size = New System.Drawing.Size(79, 82)
        Me.ListBoxSaves.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(12, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 116)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'LabelSTATUS
        '
        Me.LabelSTATUS.AutoSize = True
        Me.LabelSTATUS.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSTATUS.Location = New System.Drawing.Point(113, 386)
        Me.LabelSTATUS.Name = "LabelSTATUS"
        Me.LabelSTATUS.Size = New System.Drawing.Size(19, 19)
        Me.LabelSTATUS.TabIndex = 5
        Me.LabelSTATUS.Text = "-"
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(147, 229)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(59, 20)
        Me.ButtonDelete.TabIndex = 7
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'TextBoxSynapsis
        '
        Me.TextBoxSynapsis.Location = New System.Drawing.Point(51, 271)
        Me.TextBoxSynapsis.Multiline = True
        Me.TextBoxSynapsis.Name = "TextBoxSynapsis"
        Me.TextBoxSynapsis.ReadOnly = True
        Me.TextBoxSynapsis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxSynapsis.Size = New System.Drawing.Size(140, 104)
        Me.TextBoxSynapsis.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(88, 254)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Synapsis"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(151, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Saves"
        '
        'ButtonFiles
        '
        Me.ButtonFiles.Location = New System.Drawing.Point(12, 244)
        Me.ButtonFiles.Name = "ButtonFiles"
        Me.ButtonFiles.Size = New System.Drawing.Size(44, 20)
        Me.ButtonFiles.TabIndex = 11
        Me.ButtonFiles.Text = "Files"
        Me.ButtonFiles.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleVioletRed
        Me.ClientSize = New System.Drawing.Size(243, 414)
        Me.Controls.Add(Me.ButtonFiles)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxSynapsis)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.LabelSTATUS)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ListBoxSaves)
        Me.Controls.Add(Me.ButtonLoad)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonStart As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonLoad As System.Windows.Forms.Button
    Friend WithEvents ListBoxSaves As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelSTATUS As System.Windows.Forms.Label
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents TextBoxSynapsis As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonFiles As System.Windows.Forms.Button

End Class
