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
        Me.lblOriginalText = New System.Windows.Forms.Label()
        Me.txtOriginalText = New System.Windows.Forms.TextBox()
        Me.lblCap = New System.Windows.Forms.Label()
        Me.lblMorseCode = New System.Windows.Forms.Label()
        Me.txtMorseCode = New System.Windows.Forms.TextBox()
        Me.btnCode = New System.Windows.Forms.Button()
        Me.btnDecode = New System.Windows.Forms.Button()
        Me.lblSignal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblOriginalText
        '
        Me.lblOriginalText.AutoSize = True
        Me.lblOriginalText.Font = New System.Drawing.Font("Cascadia Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblOriginalText.Location = New System.Drawing.Point(25, 155)
        Me.lblOriginalText.Name = "lblOriginalText"
        Me.lblOriginalText.Size = New System.Drawing.Size(160, 22)
        Me.lblOriginalText.TabIndex = 0
        Me.lblOriginalText.Text = "Original  Text:"
        '
        'txtOriginalText
        '
        Me.txtOriginalText.Location = New System.Drawing.Point(201, 110)
        Me.txtOriginalText.Multiline = True
        Me.txtOriginalText.Name = "txtOriginalText"
        Me.txtOriginalText.Size = New System.Drawing.Size(727, 111)
        Me.txtOriginalText.TabIndex = 1
        '
        'lblCap
        '
        Me.lblCap.AutoSize = True
        Me.lblCap.Font = New System.Drawing.Font("Cascadia Code", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblCap.Location = New System.Drawing.Point(301, 45)
        Me.lblCap.Name = "lblCap"
        Me.lblCap.Size = New System.Drawing.Size(401, 37)
        Me.lblCap.TabIndex = 2
        Me.lblCap.Text = "Morse code - Code/Decode"
        '
        'lblMorseCode
        '
        Me.lblMorseCode.AutoSize = True
        Me.lblMorseCode.Font = New System.Drawing.Font("Cascadia Code", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblMorseCode.Location = New System.Drawing.Point(25, 318)
        Me.lblMorseCode.Name = "lblMorseCode"
        Me.lblMorseCode.Size = New System.Drawing.Size(131, 24)
        Me.lblMorseCode.TabIndex = 3
        Me.lblMorseCode.Text = "Morse code:"
        '
        'txtMorseCode
        '
        Me.txtMorseCode.Location = New System.Drawing.Point(201, 294)
        Me.txtMorseCode.Multiline = True
        Me.txtMorseCode.Name = "txtMorseCode"
        Me.txtMorseCode.Size = New System.Drawing.Size(727, 111)
        Me.txtMorseCode.TabIndex = 4
        '
        'btnCode
        '
        Me.btnCode.BackColor = System.Drawing.Color.Goldenrod
        Me.btnCode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCode.Font = New System.Drawing.Font("Cascadia Code", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnCode.Location = New System.Drawing.Point(201, 451)
        Me.btnCode.Name = "btnCode"
        Me.btnCode.Size = New System.Drawing.Size(233, 44)
        Me.btnCode.TabIndex = 5
        Me.btnCode.Text = "Code"
        Me.btnCode.UseVisualStyleBackColor = False
        '
        'btnDecode
        '
        Me.btnDecode.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnDecode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDecode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDecode.Font = New System.Drawing.Font("Cascadia Code", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnDecode.ForeColor = System.Drawing.Color.Black
        Me.btnDecode.Location = New System.Drawing.Point(696, 451)
        Me.btnDecode.Name = "btnDecode"
        Me.btnDecode.Size = New System.Drawing.Size(233, 44)
        Me.btnDecode.TabIndex = 6
        Me.btnDecode.Text = "Decode"
        Me.btnDecode.UseVisualStyleBackColor = False
        '
        'lblSignal
        '
        Me.lblSignal.AutoSize = True
        Me.lblSignal.BackColor = System.Drawing.Color.DarkGray
        Me.lblSignal.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblSignal.ForeColor = System.Drawing.Color.Black
        Me.lblSignal.Location = New System.Drawing.Point(533, 441)
        Me.lblSignal.Name = "lblSignal"
        Me.lblSignal.Size = New System.Drawing.Size(0, 54)
        Me.lblSignal.TabIndex = 7
        Me.lblSignal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(1030, 549)
        Me.Controls.Add(Me.lblSignal)
        Me.Controls.Add(Me.btnDecode)
        Me.Controls.Add(Me.btnCode)
        Me.Controls.Add(Me.txtMorseCode)
        Me.Controls.Add(Me.lblMorseCode)
        Me.Controls.Add(Me.lblCap)
        Me.Controls.Add(Me.txtOriginalText)
        Me.Controls.Add(Me.lblOriginalText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOriginalText As Label
    Friend WithEvents txtOriginalText As TextBox
    Friend WithEvents lblCap As Label
    Friend WithEvents lblMorseCode As Label
    Friend WithEvents txtMorseCode As TextBox
    Friend WithEvents btnCode As Button
    Friend WithEvents btnDecode As Button
    Friend WithEvents lblSignal As Label
End Class
