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
        Me.ServiceController1 = New System.ServiceProcess.ServiceController()
        Me.ImageGallery1 = New Agoge_GaleriaImagens.ImageGallery()
        Me.SuspendLayout()
        '
        'ImageGallery1
        '
        Me.ImageGallery1.AutoScroll = True
        Me.ImageGallery1.BackColor = System.Drawing.Color.White
        Me.ImageGallery1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ImageGallery1.Directorypath = Nothing
        Me.ImageGallery1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImageGallery1.Location = New System.Drawing.Point(0, 0)
        Me.ImageGallery1.Name = "ImageGallery1"
        Me.ImageGallery1.Resizing = False
        Me.ImageGallery1.Size = New System.Drawing.Size(710, 471)
        Me.ImageGallery1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 471)
        Me.Controls.Add(Me.ImageGallery1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageGallery1 As Agoge_GaleriaImagens.ImageGallery
    Friend WithEvents ServiceController1 As System.ServiceProcess.ServiceController

End Class
