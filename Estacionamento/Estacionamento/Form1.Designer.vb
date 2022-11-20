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
        Me.bttEntrada = New System.Windows.Forms.Button()
        Me.bttSaida = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbDataEntrada = New System.Windows.Forms.Label()
        Me.lbHoraEntrada = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lbHoraSaida = New System.Windows.Forms.Label()
        Me.lbDataSaida = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbPagar = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bttEntrada
        '
        Me.bttEntrada.Location = New System.Drawing.Point(23, 34)
        Me.bttEntrada.Name = "bttEntrada"
        Me.bttEntrada.Size = New System.Drawing.Size(75, 23)
        Me.bttEntrada.TabIndex = 0
        Me.bttEntrada.Text = "Entrada"
        Me.bttEntrada.UseVisualStyleBackColor = True
        '
        'bttSaida
        '
        Me.bttSaida.Enabled = False
        Me.bttSaida.Location = New System.Drawing.Point(23, 63)
        Me.bttSaida.Name = "bttSaida"
        Me.bttSaida.Size = New System.Drawing.Size(75, 23)
        Me.bttSaida.TabIndex = 1
        Me.bttSaida.Text = "Saida"
        Me.bttSaida.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Data"
        '
        'lbDataEntrada
        '
        Me.lbDataEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbDataEntrada.Location = New System.Drawing.Point(104, 34)
        Me.lbDataEntrada.Name = "lbDataEntrada"
        Me.lbDataEntrada.Size = New System.Drawing.Size(100, 23)
        Me.lbDataEntrada.TabIndex = 3
        Me.lbDataEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbHoraEntrada
        '
        Me.lbHoraEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbHoraEntrada.Location = New System.Drawing.Point(210, 34)
        Me.lbHoraEntrada.Name = "lbHoraEntrada"
        Me.lbHoraEntrada.Size = New System.Drawing.Size(100, 23)
        Me.lbHoraEntrada.TabIndex = 5
        Me.lbHoraEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Location = New System.Drawing.Point(240, 19)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(30, 13)
        Me.lblHora.TabIndex = 4
        Me.lblHora.Text = "Hora"
        '
        'lbHoraSaida
        '
        Me.lbHoraSaida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbHoraSaida.Location = New System.Drawing.Point(210, 63)
        Me.lbHoraSaida.Name = "lbHoraSaida"
        Me.lbHoraSaida.Size = New System.Drawing.Size(100, 23)
        Me.lbHoraSaida.TabIndex = 7
        Me.lbHoraSaida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbDataSaida
        '
        Me.lbDataSaida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbDataSaida.Location = New System.Drawing.Point(104, 63)
        Me.lbDataSaida.Name = "lbDataSaida"
        Me.lbDataSaida.Size = New System.Drawing.Size(100, 23)
        Me.lbDataSaida.TabIndex = 6
        Me.lbDataSaida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(29, 141)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(69, 13)
        Me.Label.TabIndex = 8
        Me.Label.Text = "Valor 15 Min."
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(104, 134)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 20)
        Me.txtValor.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(221, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Valor a Pagar"
        '
        'lbPagar
        '
        Me.lbPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbPagar.Location = New System.Drawing.Point(210, 131)
        Me.lbPagar.Name = "lbPagar"
        Me.lbPagar.Size = New System.Drawing.Size(100, 23)
        Me.lbPagar.TabIndex = 11
        Me.lbPagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 186)
        Me.Controls.Add(Me.lbPagar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.lbHoraSaida)
        Me.Controls.Add(Me.lbDataSaida)
        Me.Controls.Add(Me.lbHoraEntrada)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lbDataEntrada)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bttSaida)
        Me.Controls.Add(Me.bttEntrada)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttEntrada As System.Windows.Forms.Button
    Friend WithEvents bttSaida As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbDataEntrada As System.Windows.Forms.Label
    Friend WithEvents lbHoraEntrada As System.Windows.Forms.Label
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents lbHoraSaida As System.Windows.Forms.Label
    Friend WithEvents lbDataSaida As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbPagar As System.Windows.Forms.Label

End Class
