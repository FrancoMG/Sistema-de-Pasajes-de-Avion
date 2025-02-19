<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenta))
        Me.lblVenta = New System.Windows.Forms.Label()
        Me.txtDNIVenta = New System.Windows.Forms.TextBox()
        Me.lblDNIVenta = New System.Windows.Forms.Label()
        Me.btnIngresarDNI = New System.Windows.Forms.Button()
        Me.gbxCodigo = New System.Windows.Forms.GroupBox()
        Me.txtVentaReserva = New System.Windows.Forms.TextBox()
        Me.lblVentaReserva = New System.Windows.Forms.Label()
        Me.btnIngresarCodigo = New System.Windows.Forms.Button()
        Me.chkCodigoOlvidado = New System.Windows.Forms.CheckBox()
        Me.gbxCodigoOlvidado = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAtrasV = New System.Windows.Forms.Button()
        Me.gbxCodigo.SuspendLayout()
        Me.gbxCodigoOlvidado.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblVenta
        '
        Me.lblVenta.AutoSize = True
        Me.lblVenta.Font = New System.Drawing.Font("Century", 21.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenta.Location = New System.Drawing.Point(320, 21)
        Me.lblVenta.Name = "lblVenta"
        Me.lblVenta.Size = New System.Drawing.Size(257, 34)
        Me.lblVenta.TabIndex = 1
        Me.lblVenta.Text = "Venta del Pasaje"
        '
        'txtDNIVenta
        '
        Me.txtDNIVenta.Location = New System.Drawing.Point(87, 30)
        Me.txtDNIVenta.MaxLength = 8
        Me.txtDNIVenta.Name = "txtDNIVenta"
        Me.txtDNIVenta.Size = New System.Drawing.Size(100, 20)
        Me.txtDNIVenta.TabIndex = 5
        '
        'lblDNIVenta
        '
        Me.lblDNIVenta.AutoSize = True
        Me.lblDNIVenta.BackColor = System.Drawing.Color.Transparent
        Me.lblDNIVenta.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNIVenta.Location = New System.Drawing.Point(197, 31)
        Me.lblDNIVenta.Name = "lblDNIVenta"
        Me.lblDNIVenta.Size = New System.Drawing.Size(101, 19)
        Me.lblDNIVenta.TabIndex = 6
        Me.lblDNIVenta.Text = "Ingrese el DNI"
        '
        'btnIngresarDNI
        '
        Me.btnIngresarDNI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIngresarDNI.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresarDNI.Location = New System.Drawing.Point(159, 79)
        Me.btnIngresarDNI.Name = "btnIngresarDNI"
        Me.btnIngresarDNI.Size = New System.Drawing.Size(113, 31)
        Me.btnIngresarDNI.TabIndex = 8
        Me.btnIngresarDNI.Text = "Ingresar"
        Me.btnIngresarDNI.UseVisualStyleBackColor = True
        '
        'gbxCodigo
        '
        Me.gbxCodigo.Controls.Add(Me.txtVentaReserva)
        Me.gbxCodigo.Controls.Add(Me.lblVentaReserva)
        Me.gbxCodigo.Controls.Add(Me.btnIngresarCodigo)
        Me.gbxCodigo.Controls.Add(Me.chkCodigoOlvidado)
        Me.gbxCodigo.Location = New System.Drawing.Point(12, 103)
        Me.gbxCodigo.Name = "gbxCodigo"
        Me.gbxCodigo.Size = New System.Drawing.Size(448, 152)
        Me.gbxCodigo.TabIndex = 9
        Me.gbxCodigo.TabStop = False
        Me.gbxCodigo.Text = "Codigo de reserva"
        '
        'txtVentaReserva
        '
        Me.txtVentaReserva.Location = New System.Drawing.Point(14, 33)
        Me.txtVentaReserva.Name = "txtVentaReserva"
        Me.txtVentaReserva.Size = New System.Drawing.Size(100, 20)
        Me.txtVentaReserva.TabIndex = 2
        '
        'lblVentaReserva
        '
        Me.lblVentaReserva.AutoSize = True
        Me.lblVentaReserva.BackColor = System.Drawing.Color.Transparent
        Me.lblVentaReserva.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVentaReserva.ForeColor = System.Drawing.Color.Black
        Me.lblVentaReserva.Location = New System.Drawing.Point(123, 34)
        Me.lblVentaReserva.Name = "lblVentaReserva"
        Me.lblVentaReserva.Size = New System.Drawing.Size(313, 19)
        Me.lblVentaReserva.TabIndex = 3
        Me.lblVentaReserva.Text = "Ingrese el codigo de la reserva que se le asigno"
        '
        'btnIngresarCodigo
        '
        Me.btnIngresarCodigo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIngresarCodigo.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresarCodigo.Location = New System.Drawing.Point(156, 106)
        Me.btnIngresarCodigo.Name = "btnIngresarCodigo"
        Me.btnIngresarCodigo.Size = New System.Drawing.Size(113, 31)
        Me.btnIngresarCodigo.TabIndex = 7
        Me.btnIngresarCodigo.Text = "Ingresar"
        Me.btnIngresarCodigo.UseVisualStyleBackColor = True
        '
        'chkCodigoOlvidado
        '
        Me.chkCodigoOlvidado.AutoSize = True
        Me.chkCodigoOlvidado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCodigoOlvidado.Location = New System.Drawing.Point(12, 63)
        Me.chkCodigoOlvidado.Name = "chkCodigoOlvidado"
        Me.chkCodigoOlvidado.Size = New System.Drawing.Size(131, 17)
        Me.chkCodigoOlvidado.TabIndex = 4
        Me.chkCodigoOlvidado.Text = "He olvidado mi codigo"
        Me.chkCodigoOlvidado.UseVisualStyleBackColor = True
        '
        'gbxCodigoOlvidado
        '
        Me.gbxCodigoOlvidado.Controls.Add(Me.lblDNIVenta)
        Me.gbxCodigoOlvidado.Controls.Add(Me.txtDNIVenta)
        Me.gbxCodigoOlvidado.Controls.Add(Me.btnIngresarDNI)
        Me.gbxCodigoOlvidado.Location = New System.Drawing.Point(14, 273)
        Me.gbxCodigoOlvidado.Name = "gbxCodigoOlvidado"
        Me.gbxCodigoOlvidado.Size = New System.Drawing.Size(446, 130)
        Me.gbxCodigoOlvidado.TabIndex = 10
        Me.gbxCodigoOlvidado.TabStop = False
        Me.gbxCodigoOlvidado.Text = "Codigo olvidado"
        Me.gbxCodigoOlvidado.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Programa__Colegio_.My.Resources.Resources.Logo1
        Me.PictureBox1.Location = New System.Drawing.Point(499, 103)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(286, 300)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'btnAtrasV
        '
        Me.btnAtrasV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAtrasV.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtrasV.Location = New System.Drawing.Point(12, 465)
        Me.btnAtrasV.Name = "btnAtrasV"
        Me.btnAtrasV.Size = New System.Drawing.Size(108, 29)
        Me.btnAtrasV.TabIndex = 19
        Me.btnAtrasV.Text = "Atras"
        Me.btnAtrasV.UseVisualStyleBackColor = True
        '
        'frmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(844, 506)
        Me.Controls.Add(Me.btnAtrasV)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gbxCodigoOlvidado)
        Me.Controls.Add(Me.gbxCodigo)
        Me.Controls.Add(Me.lblVenta)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venta"
        Me.gbxCodigo.ResumeLayout(False)
        Me.gbxCodigo.PerformLayout()
        Me.gbxCodigoOlvidado.ResumeLayout(False)
        Me.gbxCodigoOlvidado.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblVenta As System.Windows.Forms.Label
    Friend WithEvents txtDNIVenta As System.Windows.Forms.TextBox
    Friend WithEvents lblDNIVenta As System.Windows.Forms.Label
    Friend WithEvents btnIngresarDNI As System.Windows.Forms.Button
    Friend WithEvents gbxCodigo As System.Windows.Forms.GroupBox
    Friend WithEvents txtVentaReserva As System.Windows.Forms.TextBox
    Friend WithEvents lblVentaReserva As System.Windows.Forms.Label
    Friend WithEvents btnIngresarCodigo As System.Windows.Forms.Button
    Friend WithEvents chkCodigoOlvidado As System.Windows.Forms.CheckBox
    Friend WithEvents gbxCodigoOlvidado As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAtrasV As System.Windows.Forms.Button
End Class
