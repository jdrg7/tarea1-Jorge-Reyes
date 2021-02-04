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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbNota4 = New System.Windows.Forms.Label()
        Me.lbAcum4 = New System.Windows.Forms.Label()
        Me.txtNota4 = New System.Windows.Forms.TextBox()
        Me.txtAcum4 = New System.Windows.Forms.TextBox()
        Me.txtNotaexamen4 = New System.Windows.Forms.TextBox()
        Me.lbNotaexamen4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbNota3 = New System.Windows.Forms.Label()
        Me.lbAcum3 = New System.Windows.Forms.Label()
        Me.txtNota3 = New System.Windows.Forms.TextBox()
        Me.txtAcum3 = New System.Windows.Forms.TextBox()
        Me.txtNotaexamen3 = New System.Windows.Forms.TextBox()
        Me.lbNotaexamen3 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lbNota2 = New System.Windows.Forms.Label()
        Me.lbAcum2 = New System.Windows.Forms.Label()
        Me.txtNota2 = New System.Windows.Forms.TextBox()
        Me.txtAcum2 = New System.Windows.Forms.TextBox()
        Me.txtNotaexamen2 = New System.Windows.Forms.TextBox()
        Me.lbNotaexamen2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbNota1 = New System.Windows.Forms.Label()
        Me.lbAcum1 = New System.Windows.Forms.Label()
        Me.txtNota1 = New System.Windows.Forms.TextBox()
        Me.txtAcum1 = New System.Windows.Forms.TextBox()
        Me.txtNotaexamen1 = New System.Windows.Forms.TextBox()
        Me.lbNotaexamen1 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lbParcialbajo = New System.Windows.Forms.Label()
        Me.lbParcialalto = New System.Windows.Forms.Label()
        Me.lbCalifiacionPromedio = New System.Windows.Forms.Label()
        Me.lbPromedio = New System.Windows.Forms.Label()
        Me.txtParcialbajo = New System.Windows.Forms.TextBox()
        Me.txtParcialalto = New System.Windows.Forms.TextBox()
        Me.txtCalificacionPromedio = New System.Windows.Forms.TextBox()
        Me.txtPromedio = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 467)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Notas Parciales"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Gray
        Me.GroupBox4.Controls.Add(Me.lbNota4)
        Me.GroupBox4.Controls.Add(Me.lbAcum4)
        Me.GroupBox4.Controls.Add(Me.txtNota4)
        Me.GroupBox4.Controls.Add(Me.txtAcum4)
        Me.GroupBox4.Controls.Add(Me.txtNotaexamen4)
        Me.GroupBox4.Controls.Add(Me.lbNotaexamen4)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(6, 354)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(459, 103)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cuarto Parcial"
        '
        'lbNota4
        '
        Me.lbNota4.AutoSize = True
        Me.lbNota4.Location = New System.Drawing.Point(358, 27)
        Me.lbNota4.Name = "lbNota4"
        Me.lbNota4.Size = New System.Drawing.Size(77, 20)
        Me.lbNota4.TabIndex = 5
        Me.lbNota4.Text = "Nota Final"
        '
        'lbAcum4
        '
        Me.lbAcum4.AutoSize = True
        Me.lbAcum4.Location = New System.Drawing.Point(190, 27)
        Me.lbAcum4.Name = "lbAcum4"
        Me.lbAcum4.Size = New System.Drawing.Size(92, 20)
        Me.lbAcum4.TabIndex = 4
        Me.lbAcum4.Text = "Acumulativo"
        '
        'txtNota4
        '
        Me.txtNota4.Location = New System.Drawing.Point(328, 60)
        Me.txtNota4.Name = "txtNota4"
        Me.txtNota4.ReadOnly = True
        Me.txtNota4.Size = New System.Drawing.Size(125, 27)
        Me.txtNota4.TabIndex = 3
        '
        'txtAcum4
        '
        Me.txtAcum4.Location = New System.Drawing.Point(172, 60)
        Me.txtAcum4.Name = "txtAcum4"
        Me.txtAcum4.Size = New System.Drawing.Size(125, 27)
        Me.txtAcum4.TabIndex = 2
        '
        'txtNotaexamen4
        '
        Me.txtNotaexamen4.Location = New System.Drawing.Point(7, 60)
        Me.txtNotaexamen4.Name = "txtNotaexamen4"
        Me.txtNotaexamen4.Size = New System.Drawing.Size(125, 27)
        Me.txtNotaexamen4.TabIndex = 1
        '
        'lbNotaexamen4
        '
        Me.lbNotaexamen4.AutoSize = True
        Me.lbNotaexamen4.BackColor = System.Drawing.Color.Transparent
        Me.lbNotaexamen4.Location = New System.Drawing.Point(7, 27)
        Me.lbNotaexamen4.Name = "lbNotaexamen4"
        Me.lbNotaexamen4.Size = New System.Drawing.Size(98, 20)
        Me.lbNotaexamen4.TabIndex = 0
        Me.lbNotaexamen4.Text = "Nota examen"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Gray
        Me.GroupBox3.Controls.Add(Me.lbNota3)
        Me.GroupBox3.Controls.Add(Me.lbAcum3)
        Me.GroupBox3.Controls.Add(Me.txtNota3)
        Me.GroupBox3.Controls.Add(Me.txtAcum3)
        Me.GroupBox3.Controls.Add(Me.txtNotaexamen3)
        Me.GroupBox3.Controls.Add(Me.lbNotaexamen3)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(7, 245)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(459, 103)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tercer Parcial"
        '
        'lbNota3
        '
        Me.lbNota3.AutoSize = True
        Me.lbNota3.Location = New System.Drawing.Point(358, 27)
        Me.lbNota3.Name = "lbNota3"
        Me.lbNota3.Size = New System.Drawing.Size(77, 20)
        Me.lbNota3.TabIndex = 5
        Me.lbNota3.Text = "Nota Final"
        '
        'lbAcum3
        '
        Me.lbAcum3.AutoSize = True
        Me.lbAcum3.Location = New System.Drawing.Point(190, 27)
        Me.lbAcum3.Name = "lbAcum3"
        Me.lbAcum3.Size = New System.Drawing.Size(92, 20)
        Me.lbAcum3.TabIndex = 4
        Me.lbAcum3.Text = "Acumulativo"
        '
        'txtNota3
        '
        Me.txtNota3.Location = New System.Drawing.Point(328, 60)
        Me.txtNota3.Name = "txtNota3"
        Me.txtNota3.ReadOnly = True
        Me.txtNota3.Size = New System.Drawing.Size(125, 27)
        Me.txtNota3.TabIndex = 3
        '
        'txtAcum3
        '
        Me.txtAcum3.Location = New System.Drawing.Point(172, 60)
        Me.txtAcum3.Name = "txtAcum3"
        Me.txtAcum3.Size = New System.Drawing.Size(125, 27)
        Me.txtAcum3.TabIndex = 2
        '
        'txtNotaexamen3
        '
        Me.txtNotaexamen3.Location = New System.Drawing.Point(7, 60)
        Me.txtNotaexamen3.Name = "txtNotaexamen3"
        Me.txtNotaexamen3.Size = New System.Drawing.Size(125, 27)
        Me.txtNotaexamen3.TabIndex = 1
        '
        'lbNotaexamen3
        '
        Me.lbNotaexamen3.AutoSize = True
        Me.lbNotaexamen3.BackColor = System.Drawing.Color.Transparent
        Me.lbNotaexamen3.Location = New System.Drawing.Point(7, 27)
        Me.lbNotaexamen3.Name = "lbNotaexamen3"
        Me.lbNotaexamen3.Size = New System.Drawing.Size(98, 20)
        Me.lbNotaexamen3.TabIndex = 0
        Me.lbNotaexamen3.Text = "Nota examen"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.DimGray
        Me.GroupBox5.Controls.Add(Me.lbNota2)
        Me.GroupBox5.Controls.Add(Me.lbAcum2)
        Me.GroupBox5.Controls.Add(Me.txtNota2)
        Me.GroupBox5.Controls.Add(Me.txtAcum2)
        Me.GroupBox5.Controls.Add(Me.txtNotaexamen2)
        Me.GroupBox5.Controls.Add(Me.lbNotaexamen2)
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(7, 136)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(459, 103)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Segundo Parcial"
        '
        'lbNota2
        '
        Me.lbNota2.AutoSize = True
        Me.lbNota2.Location = New System.Drawing.Point(358, 27)
        Me.lbNota2.Name = "lbNota2"
        Me.lbNota2.Size = New System.Drawing.Size(77, 20)
        Me.lbNota2.TabIndex = 5
        Me.lbNota2.Text = "Nota Final"
        '
        'lbAcum2
        '
        Me.lbAcum2.AutoSize = True
        Me.lbAcum2.Location = New System.Drawing.Point(190, 27)
        Me.lbAcum2.Name = "lbAcum2"
        Me.lbAcum2.Size = New System.Drawing.Size(92, 20)
        Me.lbAcum2.TabIndex = 4
        Me.lbAcum2.Text = "Acumulativo"
        '
        'txtNota2
        '
        Me.txtNota2.Location = New System.Drawing.Point(328, 60)
        Me.txtNota2.Name = "txtNota2"
        Me.txtNota2.ReadOnly = True
        Me.txtNota2.Size = New System.Drawing.Size(125, 27)
        Me.txtNota2.TabIndex = 3
        '
        'txtAcum2
        '
        Me.txtAcum2.Location = New System.Drawing.Point(172, 60)
        Me.txtAcum2.Name = "txtAcum2"
        Me.txtAcum2.Size = New System.Drawing.Size(125, 27)
        Me.txtAcum2.TabIndex = 2
        '
        'txtNotaexamen2
        '
        Me.txtNotaexamen2.Location = New System.Drawing.Point(7, 60)
        Me.txtNotaexamen2.Name = "txtNotaexamen2"
        Me.txtNotaexamen2.Size = New System.Drawing.Size(125, 27)
        Me.txtNotaexamen2.TabIndex = 1
        '
        'lbNotaexamen2
        '
        Me.lbNotaexamen2.AutoSize = True
        Me.lbNotaexamen2.BackColor = System.Drawing.Color.Transparent
        Me.lbNotaexamen2.Location = New System.Drawing.Point(7, 27)
        Me.lbNotaexamen2.Name = "lbNotaexamen2"
        Me.lbNotaexamen2.Size = New System.Drawing.Size(98, 20)
        Me.lbNotaexamen2.TabIndex = 0
        Me.lbNotaexamen2.Text = "Nota examen"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DimGray
        Me.GroupBox2.Controls.Add(Me.lbNota1)
        Me.GroupBox2.Controls.Add(Me.lbAcum1)
        Me.GroupBox2.Controls.Add(Me.txtNota1)
        Me.GroupBox2.Controls.Add(Me.txtAcum1)
        Me.GroupBox2.Controls.Add(Me.txtNotaexamen1)
        Me.GroupBox2.Controls.Add(Me.lbNotaexamen1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(7, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(459, 103)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Primer Parcial"
        '
        'lbNota1
        '
        Me.lbNota1.AutoSize = True
        Me.lbNota1.Location = New System.Drawing.Point(358, 27)
        Me.lbNota1.Name = "lbNota1"
        Me.lbNota1.Size = New System.Drawing.Size(77, 20)
        Me.lbNota1.TabIndex = 5
        Me.lbNota1.Text = "Nota Final"
        '
        'lbAcum1
        '
        Me.lbAcum1.AutoSize = True
        Me.lbAcum1.Location = New System.Drawing.Point(190, 27)
        Me.lbAcum1.Name = "lbAcum1"
        Me.lbAcum1.Size = New System.Drawing.Size(92, 20)
        Me.lbAcum1.TabIndex = 4
        Me.lbAcum1.Text = "Acumulativo"
        '
        'txtNota1
        '
        Me.txtNota1.Location = New System.Drawing.Point(328, 60)
        Me.txtNota1.Name = "txtNota1"
        Me.txtNota1.ReadOnly = True
        Me.txtNota1.Size = New System.Drawing.Size(125, 27)
        Me.txtNota1.TabIndex = 3
        '
        'txtAcum1
        '
        Me.txtAcum1.Location = New System.Drawing.Point(172, 60)
        Me.txtAcum1.Name = "txtAcum1"
        Me.txtAcum1.Size = New System.Drawing.Size(125, 27)
        Me.txtAcum1.TabIndex = 2
        '
        'txtNotaexamen1
        '
        Me.txtNotaexamen1.Location = New System.Drawing.Point(7, 60)
        Me.txtNotaexamen1.Name = "txtNotaexamen1"
        Me.txtNotaexamen1.Size = New System.Drawing.Size(125, 27)
        Me.txtNotaexamen1.TabIndex = 1
        '
        'lbNotaexamen1
        '
        Me.lbNotaexamen1.AutoSize = True
        Me.lbNotaexamen1.BackColor = System.Drawing.Color.Transparent
        Me.lbNotaexamen1.Location = New System.Drawing.Point(7, 27)
        Me.lbNotaexamen1.Name = "lbNotaexamen1"
        Me.lbNotaexamen1.Size = New System.Drawing.Size(98, 20)
        Me.lbNotaexamen1.TabIndex = 0
        Me.lbNotaexamen1.Text = "Nota examen"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.DimGray
        Me.GroupBox6.Controls.Add(Me.lbParcialbajo)
        Me.GroupBox6.Controls.Add(Me.lbParcialalto)
        Me.GroupBox6.Controls.Add(Me.lbCalifiacionPromedio)
        Me.GroupBox6.Controls.Add(Me.lbPromedio)
        Me.GroupBox6.Controls.Add(Me.txtParcialbajo)
        Me.GroupBox6.Controls.Add(Me.txtParcialalto)
        Me.GroupBox6.Controls.Add(Me.txtCalificacionPromedio)
        Me.GroupBox6.Controls.Add(Me.txtPromedio)
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(517, 13)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(471, 223)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Resultados"
        '
        'lbParcialbajo
        '
        Me.lbParcialbajo.AutoSize = True
        Me.lbParcialbajo.Location = New System.Drawing.Point(102, 175)
        Me.lbParcialbajo.Name = "lbParcialbajo"
        Me.lbParcialbajo.Size = New System.Drawing.Size(117, 20)
        Me.lbParcialbajo.TabIndex = 7
        Me.lbParcialbajo.Text = "Parcial mas bajo"
        '
        'lbParcialalto
        '
        Me.lbParcialalto.AutoSize = True
        Me.lbParcialalto.Location = New System.Drawing.Point(106, 122)
        Me.lbParcialalto.Name = "lbParcialalto"
        Me.lbParcialalto.Size = New System.Drawing.Size(113, 20)
        Me.lbParcialalto.TabIndex = 6
        Me.lbParcialalto.Text = "Parcial mas alto"
        '
        'lbCalifiacionPromedio
        '
        Me.lbCalifiacionPromedio.AutoSize = True
        Me.lbCalifiacionPromedio.Location = New System.Drawing.Point(64, 76)
        Me.lbCalifiacionPromedio.Name = "lbCalifiacionPromedio"
        Me.lbCalifiacionPromedio.Size = New System.Drawing.Size(155, 20)
        Me.lbCalifiacionPromedio.TabIndex = 5
        Me.lbCalifiacionPromedio.Text = "Calificacion Promedio"
        '
        'lbPromedio
        '
        Me.lbPromedio.AutoSize = True
        Me.lbPromedio.Location = New System.Drawing.Point(145, 29)
        Me.lbPromedio.Name = "lbPromedio"
        Me.lbPromedio.Size = New System.Drawing.Size(74, 20)
        Me.lbPromedio.TabIndex = 4
        Me.lbPromedio.Text = "Promedio"
        '
        'txtParcialbajo
        '
        Me.txtParcialbajo.Location = New System.Drawing.Point(249, 172)
        Me.txtParcialbajo.Name = "txtParcialbajo"
        Me.txtParcialbajo.ReadOnly = True
        Me.txtParcialbajo.Size = New System.Drawing.Size(216, 27)
        Me.txtParcialbajo.TabIndex = 3
        '
        'txtParcialalto
        '
        Me.txtParcialalto.Location = New System.Drawing.Point(249, 120)
        Me.txtParcialalto.Name = "txtParcialalto"
        Me.txtParcialalto.ReadOnly = True
        Me.txtParcialalto.Size = New System.Drawing.Size(216, 27)
        Me.txtParcialalto.TabIndex = 2
        '
        'txtCalificacionPromedio
        '
        Me.txtCalificacionPromedio.Location = New System.Drawing.Point(249, 74)
        Me.txtCalificacionPromedio.Name = "txtCalificacionPromedio"
        Me.txtCalificacionPromedio.ReadOnly = True
        Me.txtCalificacionPromedio.Size = New System.Drawing.Size(216, 27)
        Me.txtCalificacionPromedio.TabIndex = 1
        '
        'txtPromedio
        '
        Me.txtPromedio.Location = New System.Drawing.Point(249, 26)
        Me.txtPromedio.Name = "txtPromedio"
        Me.txtPromedio.ReadOnly = True
        Me.txtPromedio.Size = New System.Drawing.Size(216, 27)
        Me.txtPromedio.TabIndex = 0
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(766, 268)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(94, 29)
        Me.btnCalcular.TabIndex = 2
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(766, 318)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(94, 29)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(994, 492)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lbNota4 As Label
    Friend WithEvents lbAcum4 As Label
    Friend WithEvents txtNota4 As TextBox
    Friend WithEvents txtAcum4 As TextBox
    Friend WithEvents txtNotaexamen4 As TextBox
    Friend WithEvents lbNotaexamen4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbNota3 As Label
    Friend WithEvents lbAcum3 As Label
    Friend WithEvents txtNota3 As TextBox
    Friend WithEvents txtAcum3 As TextBox
    Friend WithEvents txtNotaexamen3 As TextBox
    Friend WithEvents lbNotaexamen3 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lbNota2 As Label
    Friend WithEvents lbAcum2 As Label
    Friend WithEvents txtNota2 As TextBox
    Friend WithEvents txtAcum2 As TextBox
    Friend WithEvents txtNotaexamen2 As TextBox
    Friend WithEvents lbNotaexamen2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbNota1 As Label
    Friend WithEvents lbAcum1 As Label
    Friend WithEvents txtNota1 As TextBox
    Friend WithEvents txtAcum1 As TextBox
    Friend WithEvents txtNotaexamen1 As TextBox
    Friend WithEvents lbNotaexamen1 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents lbParcialbajo As Label
    Friend WithEvents lbParcialalto As Label
    Friend WithEvents lbCalifiacionPromedio As Label
    Friend WithEvents lbPromedio As Label
    Friend WithEvents txtParcialbajo As TextBox
    Friend WithEvents txtParcialalto As TextBox
    Friend WithEvents txtCalificacionPromedio As TextBox
    Friend WithEvents txtPromedio As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
End Class
