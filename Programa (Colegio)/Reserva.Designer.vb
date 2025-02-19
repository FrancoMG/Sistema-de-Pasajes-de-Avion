<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReserva
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReserva))
        Me.lblReserva = New System.Windows.Forms.Label()
        Me.rbtnIdaVuelta = New System.Windows.Forms.RadioButton()
        Me.rbtnIda = New System.Windows.Forms.RadioButton()
        Me.txtDesde = New System.Windows.Forms.TextBox()
        Me.cmbPais = New System.Windows.Forms.ComboBox()
        Me.cmbCiudad = New System.Windows.Forms.ComboBox()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.lblCiudad = New System.Windows.Forms.Label()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.cmbClase = New System.Windows.Forms.ComboBox()
        Me.lblClase = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnReserva = New System.Windows.Forms.Button()
        Me.cmbAgencia = New System.Windows.Forms.ComboBox()
        Me.lblAgencia = New System.Windows.Forms.Label()
        Me.cmbHorario = New System.Windows.Forms.ComboBox()
        Me.lblHorario = New System.Windows.Forms.Label()
        Me.txtCantPersonas = New System.Windows.Forms.TextBox()
        Me.lblCantPersonas = New System.Windows.Forms.Label()
        Me.gbxDestino = New System.Windows.Forms.GroupBox()
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.gbxOtros = New System.Windows.Forms.GroupBox()
        Me.lblVuelta2 = New System.Windows.Forms.Label()
        Me.txtAñoVuelta = New System.Windows.Forms.TextBox()
        Me.txtMesVuelta = New System.Windows.Forms.TextBox()
        Me.lblAñoIda = New System.Windows.Forms.Label()
        Me.lblVuelta = New System.Windows.Forms.Label()
        Me.lblMesIda = New System.Windows.Forms.Label()
        Me.txtDiaVuelta = New System.Windows.Forms.TextBox()
        Me.lblDiaIda = New System.Windows.Forms.Label()
        Me.txtAñoIda = New System.Windows.Forms.TextBox()
        Me.lblAñoVuelta = New System.Windows.Forms.Label()
        Me.lblIda2 = New System.Windows.Forms.Label()
        Me.lblMesVuelta = New System.Windows.Forms.Label()
        Me.txtMesIda = New System.Windows.Forms.TextBox()
        Me.lblDiaVuelta = New System.Windows.Forms.Label()
        Me.lblIda = New System.Windows.Forms.Label()
        Me.txtDiaIda = New System.Windows.Forms.TextBox()
        Me.lblFechaVuelta = New System.Windows.Forms.Label()
        Me.lblFechaIda = New System.Windows.Forms.Label()
        Me.gbxFecha = New System.Windows.Forms.GroupBox()
        Me.gbxDestino.SuspendLayout()
        Me.gbxOtros.SuspendLayout()
        Me.gbxFecha.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblReserva
        '
        Me.lblReserva.AutoSize = True
        Me.lblReserva.Font = New System.Drawing.Font("Century", 21.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReserva.Location = New System.Drawing.Point(300, 24)
        Me.lblReserva.Name = "lblReserva"
        Me.lblReserva.Size = New System.Drawing.Size(287, 34)
        Me.lblReserva.TabIndex = 0
        Me.lblReserva.Text = "Reserva del Pasaje"
        '
        'rbtnIdaVuelta
        '
        Me.rbtnIdaVuelta.AutoSize = True
        Me.rbtnIdaVuelta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtnIdaVuelta.Enabled = False
        Me.rbtnIdaVuelta.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnIdaVuelta.Location = New System.Drawing.Point(309, 132)
        Me.rbtnIdaVuelta.Name = "rbtnIdaVuelta"
        Me.rbtnIdaVuelta.Size = New System.Drawing.Size(87, 19)
        Me.rbtnIdaVuelta.TabIndex = 1
        Me.rbtnIdaVuelta.TabStop = True
        Me.rbtnIdaVuelta.Text = "Ida y Vuelta"
        Me.rbtnIdaVuelta.UseVisualStyleBackColor = True
        '
        'rbtnIda
        '
        Me.rbtnIda.AutoSize = True
        Me.rbtnIda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtnIda.Enabled = False
        Me.rbtnIda.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnIda.Location = New System.Drawing.Point(482, 132)
        Me.rbtnIda.Name = "rbtnIda"
        Me.rbtnIda.Size = New System.Drawing.Size(41, 19)
        Me.rbtnIda.TabIndex = 2
        Me.rbtnIda.TabStop = True
        Me.rbtnIda.Text = "Ida"
        Me.rbtnIda.UseVisualStyleBackColor = True
        '
        'txtDesde
        '
        Me.txtDesde.Enabled = False
        Me.txtDesde.Location = New System.Drawing.Point(76, 42)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(133, 22)
        Me.txtDesde.TabIndex = 3
        '
        'cmbPais
        '
        Me.cmbPais.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPais.Enabled = False
        Me.cmbPais.FormattingEnabled = True
        Me.cmbPais.Location = New System.Drawing.Point(76, 96)
        Me.cmbPais.Name = "cmbPais"
        Me.cmbPais.Size = New System.Drawing.Size(121, 24)
        Me.cmbPais.TabIndex = 5
        '
        'cmbCiudad
        '
        Me.cmbCiudad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCiudad.Enabled = False
        Me.cmbCiudad.FormattingEnabled = True
        Me.cmbCiudad.Location = New System.Drawing.Point(203, 96)
        Me.cmbCiudad.Name = "cmbCiudad"
        Me.cmbCiudad.Size = New System.Drawing.Size(121, 24)
        Me.cmbCiudad.TabIndex = 6
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasta.ForeColor = System.Drawing.Color.Black
        Me.lblHasta.Location = New System.Drawing.Point(6, 96)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(48, 19)
        Me.lblHasta.TabIndex = 7
        Me.lblHasta.Text = "Hasta"
        '
        'lblCiudad
        '
        Me.lblCiudad.AutoSize = True
        Me.lblCiudad.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCiudad.Location = New System.Drawing.Point(228, 118)
        Me.lblCiudad.Name = "lblCiudad"
        Me.lblCiudad.Size = New System.Drawing.Size(56, 19)
        Me.lblCiudad.TabIndex = 8
        Me.lblCiudad.Text = "Ciudad"
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPais.Location = New System.Drawing.Point(115, 118)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(36, 19)
        Me.lblPais.TabIndex = 9
        Me.lblPais.Text = "Pais"
        '
        'cmbClase
        '
        Me.cmbClase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClase.Enabled = False
        Me.cmbClase.ForeColor = System.Drawing.Color.Black
        Me.cmbClase.FormattingEnabled = True
        Me.cmbClase.Items.AddRange(New Object() {"Primera clase", "Turista"})
        Me.cmbClase.Location = New System.Drawing.Point(6, 19)
        Me.cmbClase.Name = "cmbClase"
        Me.cmbClase.Size = New System.Drawing.Size(121, 24)
        Me.cmbClase.TabIndex = 14
        '
        'lblClase
        '
        Me.lblClase.AutoSize = True
        Me.lblClase.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClase.ForeColor = System.Drawing.Color.Black
        Me.lblClase.Location = New System.Drawing.Point(153, 21)
        Me.lblClase.Name = "lblClase"
        Me.lblClase.Size = New System.Drawing.Size(89, 19)
        Me.lblClase.TabIndex = 15
        Me.lblClase.Text = "Elija la clase"
        '
        'txtDNI
        '
        Me.txtDNI.Enabled = False
        Me.txtDNI.ForeColor = System.Drawing.Color.Black
        Me.txtDNI.Location = New System.Drawing.Point(6, 165)
        Me.txtDNI.MaxLength = 8
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(133, 22)
        Me.txtDNI.TabIndex = 16
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI.ForeColor = System.Drawing.Color.Black
        Me.lblDNI.Location = New System.Drawing.Point(153, 166)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(131, 19)
        Me.lblDNI.TabIndex = 17
        Me.lblDNI.Text = "DNI del reservante"
        '
        'btnAtras
        '
        Me.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAtras.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(12, 597)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(108, 29)
        Me.btnAtras.TabIndex = 18
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnReserva
        '
        Me.btnReserva.BackColor = System.Drawing.Color.Transparent
        Me.btnReserva.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReserva.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReserva.Location = New System.Drawing.Point(374, 521)
        Me.btnReserva.Name = "btnReserva"
        Me.btnReserva.Size = New System.Drawing.Size(148, 58)
        Me.btnReserva.TabIndex = 19
        Me.btnReserva.Text = "RESERVAR "
        Me.btnReserva.UseVisualStyleBackColor = False
        '
        'cmbAgencia
        '
        Me.cmbAgencia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbAgencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAgencia.FormattingEnabled = True
        Me.cmbAgencia.Location = New System.Drawing.Point(309, 85)
        Me.cmbAgencia.Name = "cmbAgencia"
        Me.cmbAgencia.Size = New System.Drawing.Size(121, 21)
        Me.cmbAgencia.TabIndex = 20
        '
        'lblAgencia
        '
        Me.lblAgencia.AutoSize = True
        Me.lblAgencia.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgencia.Location = New System.Drawing.Point(478, 84)
        Me.lblAgencia.Name = "lblAgencia"
        Me.lblAgencia.Size = New System.Drawing.Size(111, 19)
        Me.lblAgencia.TabIndex = 21
        Me.lblAgencia.Text = "Elija la agencia "
        '
        'cmbHorario
        '
        Me.cmbHorario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHorario.Enabled = False
        Me.cmbHorario.ForeColor = System.Drawing.Color.Black
        Me.cmbHorario.FormattingEnabled = True
        Me.cmbHorario.Items.AddRange(New Object() {"4:00:00", "4:30:00", "5:00:00", "5:30:00", "6:00:00", "6:30:00", "7:00:00"})
        Me.cmbHorario.Location = New System.Drawing.Point(6, 79)
        Me.cmbHorario.Name = "cmbHorario"
        Me.cmbHorario.Size = New System.Drawing.Size(121, 24)
        Me.cmbHorario.TabIndex = 22
        '
        'lblHorario
        '
        Me.lblHorario.AutoSize = True
        Me.lblHorario.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorario.ForeColor = System.Drawing.Color.Black
        Me.lblHorario.Location = New System.Drawing.Point(153, 81)
        Me.lblHorario.Name = "lblHorario"
        Me.lblHorario.Size = New System.Drawing.Size(145, 19)
        Me.lblHorario.TabIndex = 23
        Me.lblHorario.Text = "Horarios disponibles"
        '
        'txtCantPersonas
        '
        Me.txtCantPersonas.Enabled = False
        Me.txtCantPersonas.ForeColor = System.Drawing.Color.Black
        Me.txtCantPersonas.Location = New System.Drawing.Point(6, 127)
        Me.txtCantPersonas.MaxLength = 1
        Me.txtCantPersonas.Name = "txtCantPersonas"
        Me.txtCantPersonas.Size = New System.Drawing.Size(21, 22)
        Me.txtCantPersonas.TabIndex = 41
        '
        'lblCantPersonas
        '
        Me.lblCantPersonas.AutoSize = True
        Me.lblCantPersonas.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantPersonas.ForeColor = System.Drawing.Color.Black
        Me.lblCantPersonas.Location = New System.Drawing.Point(57, 126)
        Me.lblCantPersonas.Name = "lblCantPersonas"
        Me.lblCantPersonas.Size = New System.Drawing.Size(191, 19)
        Me.lblCantPersonas.TabIndex = 42
        Me.lblCantPersonas.Text = "Cantidad de acompañantes"
        '
        'gbxDestino
        '
        Me.gbxDestino.BackColor = System.Drawing.Color.Transparent
        Me.gbxDestino.Controls.Add(Me.lblDesde)
        Me.gbxDestino.Controls.Add(Me.txtDesde)
        Me.gbxDestino.Controls.Add(Me.cmbCiudad)
        Me.gbxDestino.Controls.Add(Me.cmbPais)
        Me.gbxDestino.Controls.Add(Me.lblHasta)
        Me.gbxDestino.Controls.Add(Me.lblPais)
        Me.gbxDestino.Controls.Add(Me.lblCiudad)
        Me.gbxDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDestino.Location = New System.Drawing.Point(18, 180)
        Me.gbxDestino.Name = "gbxDestino"
        Me.gbxDestino.Size = New System.Drawing.Size(437, 153)
        Me.gbxDestino.TabIndex = 43
        Me.gbxDestino.TabStop = False
        Me.gbxDestino.Text = "Destino"
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesde.Location = New System.Drawing.Point(6, 41)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(51, 19)
        Me.lblDesde.TabIndex = 10
        Me.lblDesde.Text = "Desde"
        '
        'gbxOtros
        '
        Me.gbxOtros.BackColor = System.Drawing.Color.Transparent
        Me.gbxOtros.Controls.Add(Me.cmbClase)
        Me.gbxOtros.Controls.Add(Me.lblClase)
        Me.gbxOtros.Controls.Add(Me.txtDNI)
        Me.gbxOtros.Controls.Add(Me.lblCantPersonas)
        Me.gbxOtros.Controls.Add(Me.lblDNI)
        Me.gbxOtros.Controls.Add(Me.txtCantPersonas)
        Me.gbxOtros.Controls.Add(Me.cmbHorario)
        Me.gbxOtros.Controls.Add(Me.lblHorario)
        Me.gbxOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxOtros.ForeColor = System.Drawing.Color.Black
        Me.gbxOtros.Location = New System.Drawing.Point(510, 235)
        Me.gbxOtros.Name = "gbxOtros"
        Me.gbxOtros.Size = New System.Drawing.Size(304, 193)
        Me.gbxOtros.TabIndex = 45
        Me.gbxOtros.TabStop = False
        Me.gbxOtros.Text = "Otros datos"
        '
        'lblVuelta2
        '
        Me.lblVuelta2.AutoSize = True
        Me.lblVuelta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVuelta2.Location = New System.Drawing.Point(261, 89)
        Me.lblVuelta2.Name = "lblVuelta2"
        Me.lblVuelta2.Size = New System.Drawing.Size(18, 25)
        Me.lblVuelta2.TabIndex = 33
        Me.lblVuelta2.Text = "/"
        '
        'txtAñoVuelta
        '
        Me.txtAñoVuelta.Enabled = False
        Me.txtAñoVuelta.Location = New System.Drawing.Point(279, 90)
        Me.txtAñoVuelta.MaxLength = 4
        Me.txtAñoVuelta.Name = "txtAñoVuelta"
        Me.txtAñoVuelta.Size = New System.Drawing.Size(35, 22)
        Me.txtAñoVuelta.TabIndex = 34
        '
        'txtMesVuelta
        '
        Me.txtMesVuelta.Enabled = False
        Me.txtMesVuelta.Location = New System.Drawing.Point(232, 89)
        Me.txtMesVuelta.MaxLength = 2
        Me.txtMesVuelta.Name = "txtMesVuelta"
        Me.txtMesVuelta.Size = New System.Drawing.Size(23, 22)
        Me.txtMesVuelta.TabIndex = 32
        '
        'lblAñoIda
        '
        Me.lblAñoIda.AutoSize = True
        Me.lblAñoIda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAñoIda.Location = New System.Drawing.Point(285, 55)
        Me.lblAñoIda.Name = "lblAñoIda"
        Me.lblAñoIda.Size = New System.Drawing.Size(26, 13)
        Me.lblAñoIda.TabIndex = 35
        Me.lblAñoIda.Text = "Año"
        '
        'lblVuelta
        '
        Me.lblVuelta.AutoSize = True
        Me.lblVuelta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVuelta.Location = New System.Drawing.Point(214, 89)
        Me.lblVuelta.Name = "lblVuelta"
        Me.lblVuelta.Size = New System.Drawing.Size(18, 25)
        Me.lblVuelta.TabIndex = 31
        Me.lblVuelta.Text = "/"
        '
        'lblMesIda
        '
        Me.lblMesIda.AutoSize = True
        Me.lblMesIda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMesIda.Location = New System.Drawing.Point(229, 55)
        Me.lblMesIda.Name = "lblMesIda"
        Me.lblMesIda.Size = New System.Drawing.Size(27, 13)
        Me.lblMesIda.TabIndex = 36
        Me.lblMesIda.Text = "Mes"
        '
        'txtDiaVuelta
        '
        Me.txtDiaVuelta.Enabled = False
        Me.txtDiaVuelta.Location = New System.Drawing.Point(186, 89)
        Me.txtDiaVuelta.MaxLength = 2
        Me.txtDiaVuelta.Name = "txtDiaVuelta"
        Me.txtDiaVuelta.Size = New System.Drawing.Size(23, 22)
        Me.txtDiaVuelta.TabIndex = 30
        '
        'lblDiaIda
        '
        Me.lblDiaIda.AutoSize = True
        Me.lblDiaIda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiaIda.Location = New System.Drawing.Point(186, 55)
        Me.lblDiaIda.Name = "lblDiaIda"
        Me.lblDiaIda.Size = New System.Drawing.Size(23, 13)
        Me.lblDiaIda.TabIndex = 37
        Me.lblDiaIda.Text = "Dia"
        '
        'txtAñoIda
        '
        Me.txtAñoIda.Enabled = False
        Me.txtAñoIda.Location = New System.Drawing.Point(279, 30)
        Me.txtAñoIda.MaxLength = 4
        Me.txtAñoIda.Name = "txtAñoIda"
        Me.txtAñoIda.Size = New System.Drawing.Size(35, 22)
        Me.txtAñoIda.TabIndex = 29
        '
        'lblAñoVuelta
        '
        Me.lblAñoVuelta.AutoSize = True
        Me.lblAñoVuelta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAñoVuelta.Location = New System.Drawing.Point(285, 112)
        Me.lblAñoVuelta.Name = "lblAñoVuelta"
        Me.lblAñoVuelta.Size = New System.Drawing.Size(26, 13)
        Me.lblAñoVuelta.TabIndex = 38
        Me.lblAñoVuelta.Text = "Año"
        '
        'lblIda2
        '
        Me.lblIda2.AutoSize = True
        Me.lblIda2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIda2.Location = New System.Drawing.Point(261, 29)
        Me.lblIda2.Name = "lblIda2"
        Me.lblIda2.Size = New System.Drawing.Size(18, 25)
        Me.lblIda2.TabIndex = 28
        Me.lblIda2.Text = "/"
        '
        'lblMesVuelta
        '
        Me.lblMesVuelta.AutoSize = True
        Me.lblMesVuelta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMesVuelta.Location = New System.Drawing.Point(229, 112)
        Me.lblMesVuelta.Name = "lblMesVuelta"
        Me.lblMesVuelta.Size = New System.Drawing.Size(27, 13)
        Me.lblMesVuelta.TabIndex = 39
        Me.lblMesVuelta.Text = "Mes"
        '
        'txtMesIda
        '
        Me.txtMesIda.Enabled = False
        Me.txtMesIda.Location = New System.Drawing.Point(232, 29)
        Me.txtMesIda.MaxLength = 2
        Me.txtMesIda.Name = "txtMesIda"
        Me.txtMesIda.Size = New System.Drawing.Size(23, 22)
        Me.txtMesIda.TabIndex = 27
        '
        'lblDiaVuelta
        '
        Me.lblDiaVuelta.AutoSize = True
        Me.lblDiaVuelta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiaVuelta.Location = New System.Drawing.Point(186, 112)
        Me.lblDiaVuelta.Name = "lblDiaVuelta"
        Me.lblDiaVuelta.Size = New System.Drawing.Size(23, 13)
        Me.lblDiaVuelta.TabIndex = 40
        Me.lblDiaVuelta.Text = "Dia"
        '
        'lblIda
        '
        Me.lblIda.AutoSize = True
        Me.lblIda.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIda.Location = New System.Drawing.Point(214, 29)
        Me.lblIda.Name = "lblIda"
        Me.lblIda.Size = New System.Drawing.Size(18, 25)
        Me.lblIda.TabIndex = 26
        Me.lblIda.Text = "/"
        '
        'txtDiaIda
        '
        Me.txtDiaIda.Enabled = False
        Me.txtDiaIda.Location = New System.Drawing.Point(186, 29)
        Me.txtDiaIda.MaxLength = 2
        Me.txtDiaIda.Name = "txtDiaIda"
        Me.txtDiaIda.Size = New System.Drawing.Size(23, 22)
        Me.txtDiaIda.TabIndex = 25
        '
        'lblFechaVuelta
        '
        Me.lblFechaVuelta.AutoSize = True
        Me.lblFechaVuelta.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaVuelta.Location = New System.Drawing.Point(79, 88)
        Me.lblFechaVuelta.Name = "lblFechaVuelta"
        Me.lblFechaVuelta.Size = New System.Drawing.Size(95, 19)
        Me.lblFechaVuelta.TabIndex = 13
        Me.lblFechaVuelta.Text = "Fecha Vuelta"
        '
        'lblFechaIda
        '
        Me.lblFechaIda.AutoSize = True
        Me.lblFechaIda.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIda.Location = New System.Drawing.Point(89, 30)
        Me.lblFechaIda.Name = "lblFechaIda"
        Me.lblFechaIda.Size = New System.Drawing.Size(73, 19)
        Me.lblFechaIda.TabIndex = 12
        Me.lblFechaIda.Text = "Fecha Ida"
        '
        'gbxFecha
        '
        Me.gbxFecha.BackColor = System.Drawing.Color.Transparent
        Me.gbxFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbxFecha.Controls.Add(Me.lblFechaIda)
        Me.gbxFecha.Controls.Add(Me.lblFechaVuelta)
        Me.gbxFecha.Controls.Add(Me.txtDiaIda)
        Me.gbxFecha.Controls.Add(Me.lblIda)
        Me.gbxFecha.Controls.Add(Me.lblDiaVuelta)
        Me.gbxFecha.Controls.Add(Me.txtMesIda)
        Me.gbxFecha.Controls.Add(Me.lblMesVuelta)
        Me.gbxFecha.Controls.Add(Me.lblIda2)
        Me.gbxFecha.Controls.Add(Me.lblAñoVuelta)
        Me.gbxFecha.Controls.Add(Me.txtAñoIda)
        Me.gbxFecha.Controls.Add(Me.lblDiaIda)
        Me.gbxFecha.Controls.Add(Me.txtDiaVuelta)
        Me.gbxFecha.Controls.Add(Me.lblMesIda)
        Me.gbxFecha.Controls.Add(Me.lblVuelta)
        Me.gbxFecha.Controls.Add(Me.lblAñoIda)
        Me.gbxFecha.Controls.Add(Me.txtMesVuelta)
        Me.gbxFecha.Controls.Add(Me.txtAñoVuelta)
        Me.gbxFecha.Controls.Add(Me.lblVuelta2)
        Me.gbxFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxFecha.Location = New System.Drawing.Point(18, 339)
        Me.gbxFecha.Name = "gbxFecha"
        Me.gbxFecha.Size = New System.Drawing.Size(437, 148)
        Me.gbxFecha.TabIndex = 44
        Me.gbxFecha.TabStop = False
        Me.gbxFecha.Text = "Fecha"
        '
        'frmReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(840, 638)
        Me.Controls.Add(Me.gbxOtros)
        Me.Controls.Add(Me.gbxFecha)
        Me.Controls.Add(Me.gbxDestino)
        Me.Controls.Add(Me.lblAgencia)
        Me.Controls.Add(Me.cmbAgencia)
        Me.Controls.Add(Me.btnReserva)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.rbtnIda)
        Me.Controls.Add(Me.rbtnIdaVuelta)
        Me.Controls.Add(Me.lblReserva)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReserva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reserva"
        Me.gbxDestino.ResumeLayout(False)
        Me.gbxDestino.PerformLayout()
        Me.gbxOtros.ResumeLayout(False)
        Me.gbxOtros.PerformLayout()
        Me.gbxFecha.ResumeLayout(False)
        Me.gbxFecha.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblReserva As System.Windows.Forms.Label
    Friend WithEvents rbtnIdaVuelta As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnIda As System.Windows.Forms.RadioButton
    Friend WithEvents txtDesde As System.Windows.Forms.TextBox
    Friend WithEvents cmbPais As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCiudad As System.Windows.Forms.ComboBox
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents lblCiudad As System.Windows.Forms.Label
    Friend WithEvents lblPais As System.Windows.Forms.Label
    Friend WithEvents cmbClase As System.Windows.Forms.ComboBox
    Friend WithEvents lblClase As System.Windows.Forms.Label
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnReserva As System.Windows.Forms.Button
    Friend WithEvents cmbAgencia As System.Windows.Forms.ComboBox
    Friend WithEvents lblAgencia As System.Windows.Forms.Label
    Friend WithEvents cmbHorario As System.Windows.Forms.ComboBox
    Friend WithEvents lblHorario As System.Windows.Forms.Label
    Friend WithEvents txtCantPersonas As System.Windows.Forms.TextBox
    Friend WithEvents lblCantPersonas As System.Windows.Forms.Label
    Friend WithEvents gbxDestino As System.Windows.Forms.GroupBox
    Friend WithEvents lblDesde As System.Windows.Forms.Label
    Friend WithEvents gbxOtros As System.Windows.Forms.GroupBox
    Friend WithEvents lblVuelta2 As System.Windows.Forms.Label
    Friend WithEvents txtAñoVuelta As System.Windows.Forms.TextBox
    Friend WithEvents txtMesVuelta As System.Windows.Forms.TextBox
    Friend WithEvents lblAñoIda As System.Windows.Forms.Label
    Friend WithEvents lblVuelta As System.Windows.Forms.Label
    Friend WithEvents lblMesIda As System.Windows.Forms.Label
    Friend WithEvents txtDiaVuelta As System.Windows.Forms.TextBox
    Friend WithEvents lblDiaIda As System.Windows.Forms.Label
    Friend WithEvents txtAñoIda As System.Windows.Forms.TextBox
    Friend WithEvents lblAñoVuelta As System.Windows.Forms.Label
    Friend WithEvents lblIda2 As System.Windows.Forms.Label
    Friend WithEvents lblMesVuelta As System.Windows.Forms.Label
    Friend WithEvents txtMesIda As System.Windows.Forms.TextBox
    Friend WithEvents lblDiaVuelta As System.Windows.Forms.Label
    Friend WithEvents lblIda As System.Windows.Forms.Label
    Friend WithEvents txtDiaIda As System.Windows.Forms.TextBox
    Friend WithEvents lblFechaVuelta As System.Windows.Forms.Label
    Friend WithEvents lblFechaIda As System.Windows.Forms.Label
    Friend WithEvents gbxFecha As System.Windows.Forms.GroupBox
End Class
