<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.picPhil0 = New System.Windows.Forms.PictureBox()
        Me.picPhil4 = New System.Windows.Forms.PictureBox()
        Me.picPhil3 = New System.Windows.Forms.PictureBox()
        Me.picPhil2 = New System.Windows.Forms.PictureBox()
        Me.picPhil1 = New System.Windows.Forms.PictureBox()
        CType(Me.picPhil0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPhil4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPhil3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPhil2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPhil1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(406, 624)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'picPhil0
        '
        Me.picPhil0.Location = New System.Drawing.Point(367, 21)
        Me.picPhil0.Name = "picPhil0"
        Me.picPhil0.Size = New System.Drawing.Size(150, 150)
        Me.picPhil0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhil0.TabIndex = 1
        Me.picPhil0.TabStop = False
        '
        'picPhil4
        '
        Me.picPhil4.Location = New System.Drawing.Point(44, 194)
        Me.picPhil4.Name = "picPhil4"
        Me.picPhil4.Size = New System.Drawing.Size(150, 150)
        Me.picPhil4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhil4.TabIndex = 2
        Me.picPhil4.TabStop = False
        '
        'picPhil3
        '
        Me.picPhil3.Location = New System.Drawing.Point(211, 450)
        Me.picPhil3.Name = "picPhil3"
        Me.picPhil3.Size = New System.Drawing.Size(150, 150)
        Me.picPhil3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhil3.TabIndex = 3
        Me.picPhil3.TabStop = False
        '
        'picPhil2
        '
        Me.picPhil2.Location = New System.Drawing.Point(525, 450)
        Me.picPhil2.Name = "picPhil2"
        Me.picPhil2.Size = New System.Drawing.Size(150, 150)
        Me.picPhil2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhil2.TabIndex = 4
        Me.picPhil2.TabStop = False
        '
        'picPhil1
        '
        Me.picPhil1.Location = New System.Drawing.Point(665, 194)
        Me.picPhil1.Name = "picPhil1"
        Me.picPhil1.Size = New System.Drawing.Size(150, 150)
        Me.picPhil1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhil1.TabIndex = 5
        Me.picPhil1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 659)
        Me.Controls.Add(Me.picPhil1)
        Me.Controls.Add(Me.picPhil2)
        Me.Controls.Add(Me.picPhil3)
        Me.Controls.Add(Me.picPhil4)
        Me.Controls.Add(Me.picPhil0)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "Form1"
        Me.Text = "Dining Philosophers Problem"
        CType(Me.picPhil0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPhil4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPhil3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPhil2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPhil1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents picPhil0 As PictureBox
    Friend WithEvents picPhil4 As PictureBox
    Friend WithEvents picPhil3 As PictureBox
    Friend WithEvents picPhil2 As PictureBox
    Friend WithEvents picPhil1 As PictureBox
End Class
