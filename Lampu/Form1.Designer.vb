<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLampu
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
        Me.gbrLampuMati = New System.Windows.Forms.PictureBox()
        Me.gbrLampuHidup = New System.Windows.Forms.PictureBox()
        Me.tombolTukarLampu = New System.Windows.Forms.Button()
        Me.tombolKeluar = New System.Windows.Forms.Button()
        Me.labelStatusLampu = New System.Windows.Forms.Label()
        CType(Me.gbrLampuMati, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbrLampuHidup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbrLampuMati
        '
        Me.gbrLampuMati.Image = Global.Lampu.My.Resources.Resources.LAMPU_OFF
        Me.gbrLampuMati.Location = New System.Drawing.Point(219, 13)
        Me.gbrLampuMati.Name = "gbrLampuMati"
        Me.gbrLampuMati.Size = New System.Drawing.Size(200, 197)
        Me.gbrLampuMati.TabIndex = 1
        Me.gbrLampuMati.TabStop = False
        Me.gbrLampuMati.Visible = False
        '
        'gbrLampuHidup
        '
        Me.gbrLampuHidup.Image = Global.Lampu.My.Resources.Resources.LAMPU_ON
        Me.gbrLampuHidup.Location = New System.Drawing.Point(13, 13)
        Me.gbrLampuHidup.Name = "gbrLampuHidup"
        Me.gbrLampuHidup.Size = New System.Drawing.Size(200, 197)
        Me.gbrLampuHidup.TabIndex = 0
        Me.gbrLampuHidup.TabStop = False
        '
        'tombolTukarLampu
        '
        Me.tombolTukarLampu.Location = New System.Drawing.Point(13, 261)
        Me.tombolTukarLampu.Name = "tombolTukarLampu"
        Me.tombolTukarLampu.Size = New System.Drawing.Size(200, 39)
        Me.tombolTukarLampu.TabIndex = 2
        Me.tombolTukarLampu.Text = "Tukar Lampu"
        Me.tombolTukarLampu.UseVisualStyleBackColor = True
        '
        'tombolKeluar
        '
        Me.tombolKeluar.Location = New System.Drawing.Point(219, 261)
        Me.tombolKeluar.Name = "tombolKeluar"
        Me.tombolKeluar.Size = New System.Drawing.Size(200, 39)
        Me.tombolKeluar.TabIndex = 3
        Me.tombolKeluar.Text = "Keluar"
        Me.tombolKeluar.UseVisualStyleBackColor = True
        '
        'labelStatusLampu
        '
        Me.labelStatusLampu.AutoSize = True
        Me.labelStatusLampu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelStatusLampu.Location = New System.Drawing.Point(190, 224)
        Me.labelStatusLampu.Name = "labelStatusLampu"
        Me.labelStatusLampu.Size = New System.Drawing.Size(56, 20)
        Me.labelStatusLampu.TabIndex = 4
        Me.labelStatusLampu.Text = "Hidup"
        '
        'FormLampu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 312)
        Me.Controls.Add(Me.labelStatusLampu)
        Me.Controls.Add(Me.tombolKeluar)
        Me.Controls.Add(Me.tombolTukarLampu)
        Me.Controls.Add(Me.gbrLampuMati)
        Me.Controls.Add(Me.gbrLampuHidup)
        Me.Name = "FormLampu"
        Me.Text = "Lampu"
        CType(Me.gbrLampuMati, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbrLampuHidup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbrLampuHidup As System.Windows.Forms.PictureBox
    Friend WithEvents gbrLampuMati As System.Windows.Forms.PictureBox
    Friend WithEvents tombolTukarLampu As System.Windows.Forms.Button
    Friend WithEvents tombolKeluar As System.Windows.Forms.Button
    Friend WithEvents labelStatusLampu As System.Windows.Forms.Label

End Class
