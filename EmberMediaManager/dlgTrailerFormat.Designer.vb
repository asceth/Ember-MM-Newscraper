﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTrailerFormat
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
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.lbFormats = New System.Windows.Forms.ListBox()
        Me.gbFormats = New System.Windows.Forms.GroupBox()
        Me.pnlStatus = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.prbStatus = New System.Windows.Forms.ProgressBar()
        Me.pnlTrailerFormat = New System.Windows.Forms.Panel()
        Me.gbFormats.SuspendLayout()
        Me.pnlStatus.SuspendLayout()
        Me.pnlTrailerFormat.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Enabled = False
        Me.OK_Button.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.OK_Button.Location = New System.Drawing.Point(72, 187)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cancel_Button.Location = New System.Drawing.Point(145, 187)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'lbFormats
        '
        Me.lbFormats.Enabled = False
        Me.lbFormats.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbFormats.FormattingEnabled = True
        Me.lbFormats.Location = New System.Drawing.Point(4, 19)
        Me.lbFormats.Name = "lbFormats"
        Me.lbFormats.Size = New System.Drawing.Size(170, 121)
        Me.lbFormats.TabIndex = 0
        '
        'gbFormats
        '
        Me.gbFormats.Controls.Add(Me.lbFormats)
        Me.gbFormats.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbFormats.Location = New System.Drawing.Point(10, 8)
        Me.gbFormats.Name = "gbFormats"
        Me.gbFormats.Size = New System.Drawing.Size(180, 151)
        Me.gbFormats.TabIndex = 0
        Me.gbFormats.TabStop = False
        Me.gbFormats.Text = "Available Formats"
        '
        'pnlStatus
        '
        Me.pnlStatus.BackColor = System.Drawing.Color.White
        Me.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStatus.Controls.Add(Me.lblStatus)
        Me.pnlStatus.Controls.Add(Me.prbStatus)
        Me.pnlStatus.Location = New System.Drawing.Point(12, 75)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(200, 54)
        Me.pnlStatus.TabIndex = 1
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(3, 10)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(147, 13)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Getting available formats..."
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'prbStatus
        '
        Me.prbStatus.Location = New System.Drawing.Point(3, 29)
        Me.prbStatus.MarqueeAnimationSpeed = 25
        Me.prbStatus.Name = "prbStatus"
        Me.prbStatus.Size = New System.Drawing.Size(192, 17)
        Me.prbStatus.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.prbStatus.TabIndex = 1
        '
        'pnlTrailerFormat
        '
        Me.pnlTrailerFormat.BackColor = System.Drawing.Color.White
        Me.pnlTrailerFormat.Controls.Add(Me.gbFormats)
        Me.pnlTrailerFormat.Location = New System.Drawing.Point(12, 12)
        Me.pnlTrailerFormat.Name = "pnlTrailerFormat"
        Me.pnlTrailerFormat.Size = New System.Drawing.Size(200, 169)
        Me.pnlTrailerFormat.TabIndex = 2
        '
        'dlgTrailerFormat
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(224, 217)
        Me.Controls.Add(Me.pnlStatus)
        Me.Controls.Add(Me.pnlTrailerFormat)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTrailerFormat"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select Format"
        Me.gbFormats.ResumeLayout(False)
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStatus.PerformLayout()
        Me.pnlTrailerFormat.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents lbFormats As System.Windows.Forms.ListBox
    Friend WithEvents gbFormats As System.Windows.Forms.GroupBox
    Friend WithEvents pnlStatus As System.Windows.Forms.Panel
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents prbStatus As System.Windows.Forms.ProgressBar
    Friend WithEvents pnlTrailerFormat As System.Windows.Forms.Panel

End Class
