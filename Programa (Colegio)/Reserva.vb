Public Class frmReserva

    Dim descuentoT As Integer
    Dim precioviajeT As Integer
    Dim codigod As Integer
    Dim coda As Integer
    Dim maxv As Integer
    Dim maxreserva As Integer
    Dim codag As Integer
    Dim descuentoP As Integer
    Dim precioviajeP As Integer
    Dim precioreservaT As Integer
    Dim precioreservaP As Integer
    Dim fIda As String
    Dim fVuelta As String
    Dim diacorrecto As Boolean = False
    Dim mescorrecto As Boolean = False
    Dim diamesañocorrecto As Boolean = False
    Dim fechascorrectas As Boolean = False
    Dim añocorrecto As Boolean = False
    Dim dnicorrecto As Boolean = False
    Dim contpasaje As Integer
    Dim clase As String
    Dim hora As String
    Dim desde As String
    Dim hasta As String
    Dim fechahoy As Date
    Dim contpasajero As Integer
    Dim i As Integer
    Dim telefonocliente As String
    Dim emailcliente As String
    Dim telnumeros As Boolean = False
    Dim nombreclien As Boolean = False
    Dim apellidoclien As Boolean = False
    Dim emailc As Boolean = False
    Dim nombrea As Boolean = False
    Dim apellidoa As Boolean = False
    Dim dnia As Boolean = False
    Dim nombreacompañante As String
    Dim apellidoacompañante As String
    Dim dniacompañante As String


    Private Sub btnAtras_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAtras.Click

        If (MsgBox("¿Esta seguro que desea volver atrás? Se perderan todos los datos ingresados", MsgBoxStyle.YesNo, "Volver atras") = MsgBoxResult.Yes) Then

            Me.Close()
            frmInicio.Show()

        Else

        End If

    End Sub

    Private Sub rbtnIdaVuelta_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbtnIdaVuelta.CheckedChanged

        If rbtnIdaVuelta.Checked = True Then

            txtDesde.Enabled = True
            cmbPais.Enabled = True
            cmbCiudad.Enabled = True
            txtDiaIda.Enabled = True
            txtMesIda.Enabled = True
            txtAñoIda.Enabled = True
            txtDiaVuelta.Enabled = True
            txtMesVuelta.Enabled = True
            txtAñoVuelta.Enabled = True
            cmbClase.Enabled = True
            txtDNI.Enabled = True
            txtDiaVuelta.Enabled = True
            txtMesVuelta.Enabled = True
            txtAñoVuelta.Enabled = True
            txtDiaVuelta.Visible = True
            txtMesVuelta.Visible = True
            txtAñoVuelta.Visible = True
            lblFechaVuelta.Visible = True
            lblDiaVuelta.Visible = True
            lblMesVuelta.Visible = True
            lblAñoVuelta.Visible = True
            lblVuelta.Visible = True
            lblVuelta2.Visible = True
            cmbHorario.Enabled = True
            txtCantPersonas.Enabled = True

        End If

    End Sub

    Private Sub rbtnIda_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbtnIda.CheckedChanged

        If rbtnIda.Checked = True Then
            txtDesde.Enabled = True
            cmbPais.Enabled = True
            cmbCiudad.Enabled = True
            txtDiaIda.Enabled = True
            txtMesIda.Enabled = True
            txtAñoIda.Enabled = True
            txtDiaVuelta.Enabled = True
            txtMesVuelta.Enabled = True
            txtAñoVuelta.Enabled = True
            cmbClase.Enabled = True
            txtDNI.Enabled = True
            txtDiaVuelta.Enabled = False
            txtMesVuelta.Enabled = False
            txtAñoVuelta.Enabled = False
            txtDiaVuelta.Visible = False
            txtMesVuelta.Visible = False
            txtAñoVuelta.Visible = False
            lblFechaVuelta.Visible = False
            lblVuelta.Visible = False
            lblVuelta2.Visible = False
            lblDiaVuelta.Visible = False
            lblMesVuelta.Visible = False
            lblAñoVuelta.Visible = False
            cmbHorario.Enabled = True
            txtCantPersonas.Enabled = True

        Else


        End If

    End Sub

    Private Sub btnReserva_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReserva.Click

        If rbtnIda.Checked = True Then

            If txtDesde.Text = "" Or cmbPais.SelectedText = "" Or cmbCiudad.SelectedText = "" Or txtDiaIda.Text = "" Or txtMesIda.Text = "" Or txtAñoIda.Text = "" Or cmbClase.SelectedText = "" Or cmbHorario.SelectedText = "" Or txtCantPersonas.Text = "" Or txtDNI.Text = "" Then

            Else

                btnReserva.Enabled = True
            End If
        Else

            If txtDesde.Text = "" Or cmbPais.SelectedText = "" Or cmbCiudad.SelectedText = "" Or txtDiaIda.Text = "" Or txtMesIda.Text = "" Or txtAñoIda.Text = "" Or txtDiaVuelta.Text = "" Or txtMesVuelta.Text = "" Or txtAñoVuelta.Text = "" Or cmbClase.SelectedText = "" Or cmbHorario.SelectedText = "" Or txtCantPersonas.Text = "" Or txtDNI.Text = "" Then

            Else

                btnReserva.Enabled = True
            End If
        End If 'fin de verificacion si todos los campos estan vacios o no

        If IsNumeric(txtDesde.Text) Then

            MsgBox("No puede ingresar numeros en un campo que solo pide texto", MsgBoxStyle.Critical, "Tipo de dato no valido")
        Else

            If txtDiaIda.Text > "31" Or txtDiaVuelta.Text > "31" Then

                MsgBox("El dia ingresado no es valido. Por favor ingrese el dia nuevamente", MsgBoxStyle.Critical, "Dia fuera de rango")

            Else
                diacorrecto = True

            End If 'fin del if de si el dia ingresado es correcto

            If rbtnIda.Checked = True Then

                fIda = txtAñoIda.Text & "/" & txtMesIda.Text & "/" & txtDiaIda.Text

                fVuelta = txtAñoVuelta.Text & "/" & txtMesVuelta.Text & "/" & txtDiaVuelta.Text

                sql = "select curdate()"
                Call ejecutar(sql)
                rs.Read()
                fechahoy = rs(0)

                If Not IsNumeric(txtDiaIda.Text) Or Not IsNumeric(txtMesIda.Text) Or Not IsNumeric(txtAñoIda.Text) Then

                    diamesañocorrecto = False
                    MsgBox("No puede ingresar letras en un campo que pide solo numeros", MsgBoxStyle.Critical, "Tipo de dato no valido")
                Else

                    diamesañocorrecto = True
                    If txtMesIda.Text > "12" Then

                        MsgBox("El mes ingresado no es valido. Por favor ingrese el mes nuevamente", MsgBoxStyle.Critical, "Mes fuera de rango")
                    Else

                        mescorrecto = True
                        If fIda < Format(fechahoy, "yyyy/MM/dd") Then

                            fechascorrectas = False
                            MsgBox("La fecha ingresada no puede ser menor a la fecha de hoy. Por favor ingrese la fecha nuevamente", MsgBoxStyle.Critical, "Fecha incorrecta")
                        Else

                            fechascorrectas = True
                        End If
                    End If
                End If
            ElseIf rbtnIdaVuelta.Checked = True Then

                fIda = txtAñoIda.Text & "/" & txtMesIda.Text & "/" & txtDiaIda.Text

                fVuelta = txtAñoVuelta.Text & "/" & txtMesVuelta.Text & "/" & txtDiaVuelta.Text

                sql = "select curdate()"
                Call ejecutar(sql)
                rs.Read()
                fechahoy = rs(0)

                If Not IsNumeric(txtDiaIda.Text) Or Not IsNumeric(txtDiaVuelta.Text) Or Not IsNumeric(txtMesIda.Text) Or Not IsNumeric(txtMesVuelta.Text) Or Not IsNumeric(txtAñoIda.Text) Or Not IsNumeric(txtAñoVuelta.Text) Then

                    diamesañocorrecto = False
                    MsgBox("No puede ingresar letras en un campo que pide solo numeros", MsgBoxStyle.Critical, "Tipo de dato no valido")
                Else

                    diamesañocorrecto = True
                    If txtMesIda.Text > "12" Or txtMesVuelta.Text > "12" Then

                        MsgBox("El mes ingresado no es valido. Por favor ingrese el mes nuevamente", MsgBoxStyle.Critical, "Mes fuera de rango")
                    Else

                        mescorrecto = True
                        If fIda < Format(fechahoy, "yyyy/MM/dd") Or fVuelta < Format(fechahoy, "yyyy/MM/dd") Then

                            fechascorrectas = False
                            MsgBox("La fecha ingresada no puede ser menor a la fecha de hoy. Por favor ingrese la fecha nuevamente", MsgBoxStyle.Critical, "Fecha incorrecta")
                        Else

                            fechascorrectas = True
                            If fVuelta < fIda Or fVuelta = fIda Then

                                fechascorrectas = False
                                MsgBox("La fecha de vuelta no puede ser menor a la fecha de ida. Por favor ingrese la fecha nuevamente", MsgBoxStyle.Critical, "Fecha incorrecta")
                            Else

                                fechascorrectas = True
                            End If
                        End If
                    End If
                End If
            End If 'fin del if de si hay letras en vez de numeros en los txt de las fechas de vuelta

            If diacorrecto = True And mescorrecto = True And diamesañocorrecto = True And fechascorrectas = True Then

                clase = cmbClase.Text
                clasepasaje = clase
                hora = cmbHorario.Text
                horapasaje = hora
                desde = txtDesde.Text
                desdepasaje = desde
                hasta = cmbCiudad.Text
                hastapasaje = hasta

                If Not IsNumeric(txtDNI.Text) Then

                    dnicorrecto = False
                    MsgBox("No puede ingresar letras en un campo que solo pide numeros", MsgBoxStyle.Critical, "Tipo de dato no valido")
                Else

                    dnicorrecto = True

                    If txtDNI.TextLength < 8 Then

                        dnicorrecto = False
                        MsgBox("El DNI  ingresado no es valido", MsgBoxStyle.Exclamation, "DNI no valido")
                    Else

                        dnicorrecto = True
                    End If
                End If

                If dnicorrecto = True Then

                    '-------------------------------------------------------------------------------------------------------------------------------------- FIN DE LAS VERIFICACIONES

                    If cmbClase.Text = "Turista" Then

                        sql = "select coddestino from destino where pais = '" & cmbPais.Text & "' and ciudad = '" & cmbCiudad.Text & "'"
                        Call ejecutar(sql)
                        rs.Read()
                        codigod = rs(0)

                        sql = "select precioclaseturista from preciodestino where coddestino = " & codigod & ""
                        Call ejecutar(sql)
                        rs.Read()
                        precioviajeT = rs(0)

                        precioviajeT = precioviajeT * (txtCantPersonas.Text + 1)

                        descuentoT = (precioviajeT * 10) / 100

                        precioreservaT = precioviajeT - descuentoT

                        If MsgBox("El valor de la reserva del pasaje que debe pagar el cliente es de: $" & descuentoT & ". El valor total del pasaje es de $" & precioviajeT & ".¿Acepta el monto a pagar?", MsgBoxStyle.YesNo, "Monto reserva") = MsgBoxResult.Yes Then

                            MsgBox("EL cliente acepta pagar el monto de la reserva", MsgBoxStyle.Information, "Monto aceptado")

                            sql = "select count(dni) from cliente where dni = " & txtDNI.Text & ""
                            Call ejecutar(sql)
                            rs.Read()
                            countdni = rs(0)

                            If countdni = 0 Then

                                MsgBox("El cliente ingresado no existe en la base, se pasara a ingresarlo", MsgBoxStyle.Exclamation, "Cliente inexistente")

                                Do Until nombreclien = True
                                    nombrec = InputBox("Ingrese el nombre del cliente")

                                    If nombrec = "" Then

                                        MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                        nombreclien = False
                                    Else

                                        If IsNumeric(nombrec) Then

                                            MsgBox("No puede ingresar numeros en un campo que solo pide letras", MsgBoxStyle.Critical, "Tipo de dato no valido")
                                        Else

                                            nombreclien = True
                                        End If
                                    End If
                                Loop

                                Do Until apellidoclien = True

                                    apellidoc = InputBox("Ingrese el apellido del cliente")

                                    If apellidoc = "" Then

                                        MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                        apellidoclien = False
                                    Else

                                        If IsNumeric(apellidoc) Then

                                            MsgBox("No puede ingresar numeros en un campo que solo pide letras", MsgBoxStyle.Critical, "Tipo de dato no valido")
                                        Else

                                            apellidoclien = True
                                        End If
                                    End If
                                Loop

                                Do Until telnumeros = True

                                    telefonocliente = InputBox("Ingrese el telefono del cliente")

                                    If telefonocliente = "" Then

                                        MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                        telnumeros = False
                                    Else
                                        If Not IsNumeric(telefonocliente) Then

                                            MsgBox("No puede ingresar letras en un campo que pide solo numeros", MsgBoxStyle.Critical, "Tipo de dato no valido")
                                            telnumeros = False
                                        Else

                                            If telefonocliente.Length < 8 Or telefonocliente.Length > 10 Then

                                                MsgBox("El telefono ingresado no es valido", MsgBoxStyle.Exclamation, "Telefono no valido")
                                                telnumeros = False
                                            Else

                                                telnumeros = True
                                            End If
                                        End If
                                    End If

                                Loop

                                Do Until emailc = True

                                    emailcliente = InputBox("Ingrese el e-mail del cliente")

                                    If emailcliente = "" Then

                                        MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                        emailc = False
                                    Else

                                        emailc = True
                                    End If
                                Loop

                                sql = "select max(codcliente) + 1 from cliente"
                                Call ejecutar(sql)
                                rs.Read()
                                maxc = rs(0)

                                sql = "insert into cliente values(" & maxc & ", '" & nombrec & "', '" & apellidoc & "', '" & txtDNI.Text & "', '" & telefonocliente & "', '" & emailcliente & "')"
                                Call ejecutar(sql)
                                dnic = txtDNI.Text

                                MsgBox("Se ha ingresado al cliente " & nombrec & " " & apellidoc & " con exito.", MsgBoxStyle.Information, "Cliente ingresado")

                                sql = "select tipoavion from preciodestino where coddestino = " & codigod & ""
                                Call ejecutar(sql)
                                rs.Read()

                                sql = "select codavion from avion where tipoavion = '" & rs(0) & "'"
                                Call ejecutar(sql)
                                rs.Read()
                                coda = rs(0)

                                sql = "select max(nrovuelo) + 1 from vuelo"
                                Call ejecutar(sql)
                                rs.Read()
                                maxv = rs(0)
                                vuelopasaje = maxv

                                sql = "insert into vuelo values(" & maxv & ", " & codigod & ", " & coda & ", curdate(), '" & cmbHorario.Text & "')"
                                Call ejecutar(sql)

                                MsgBox("El vuelo se ha ingresado con exito", MsgBoxStyle.Information, "Vuelo ingresado")

                                sql = "select max(codreserva) + 1 from reserva"
                                Call ejecutar(sql)
                                rs.Read()
                                maxreserva = rs(0)

                                sql = "select codagencia from agencia where nombre = '" & cmbAgencia.Text & "'"
                                Call ejecutar(sql)
                                rs.Read()
                                codag = rs(0)

                                If rbtnIda.Checked = True Then

                                    sql = "insert into reserva values(" & maxreserva & ", " & maxv & ", " & maxc & ", " & codag & ", curdate(), '" & fIda & "', null, " & (txtCantPersonas.Text + 1) & ", '" & cmbClase.Text & "', " & descuentoT & ")"
                                    Call ejecutar(sql)

                                    Do Until contpasaje = (txtCantPersonas.Text + 1)

                                        sql = "select max(codpasaje)+1 from pasaje"
                                        Call ejecutar(sql)
                                        rs.Read()
                                        pasajemax = rs(0)

                                        sql = "insert into pasaje values(" & pasajemax & ", " & maxreserva & ")"
                                        Call ejecutar(sql)
                                        contpasaje = contpasaje + 1

                                    Loop

                                    If txtCantPersonas.Text > 0 Then

                                        MsgBox("Se ha realizado la reserva del pasaje con exito. A continuacion se procedera a tomar los datos de los otros pasajeros", MsgBoxStyle.Information, "Datos pasajeros")
                                        Do Until contpasajero = txtCantPersonas.Text

                                            Do Until nombrea = True

                                                nombrea = False
                                                nombreacompañante = InputBox("Ingrese el nombre del acompañante")

                                                If nombreacompañante = "" Then

                                                    MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                                    nombrea = False
                                                Else

                                                    If IsNumeric(nombreacompañante) Then

                                                        MsgBox("No puede ingresar numeros en un campo que solo pide letras", MsgBoxStyle.Critical, "Tipo de dato no valido")
                                                        nombrea = False

                                                    Else
                                                        nombrea = True

                                                    End If
                                                End If
                                            Loop

                                            Do Until apellidoa = True

                                                apellidoa = False
                                                apellidoacompañante = InputBox("Ingrese el apellido del acompañante")

                                                If apellidoacompañante = "" Then

                                                    MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                                    apellidoa = False
                                                Else

                                                    If IsNumeric(apellidoacompañante) Then

                                                        MsgBox("No puede ingresar numeros en un campo que solo pide letras", MsgBoxStyle.Critical, "Tipo de dato no valido")
                                                        apellidoa = False
                                                    Else

                                                        apellidoa = True
                                                    End If
                                                End If
                                            Loop

                                            Do Until dnia = True

                                                dnia = False
                                                dniacompañante = InputBox("Ingrese el DNI del acompañante")

                                                If dniacompañante = "" Then

                                                    MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                                    dnia = False
                                                Else
                                                    If Not IsNumeric(dniacompañante) Then

                                                        MsgBox("No puede ingresar letras en un campo que pide solo numeros", MsgBoxStyle.Critical, "Tipo de dato no valido")
                                                        dnia = False

                                                    Else

                                                        If dniacompañante.Length < 8 Or dniacompañante.Length > 8 Then

                                                            MsgBox("El DNI ingresado no es valido", MsgBoxStyle.Exclamation, "DNI no valido")
                                                        Else
                                                            dnia = True
                                                        End If
                                                    End If
                                                End If

                                            Loop

                                            sql = "insert into pasajero values('', " & maxc & ", " & pasajemax & ", '" & nombreacompañante & "', '" & apellidoacompañante & "', '" & dniacompañante & "')"
                                            Call ejecutar(sql)
                                            contpasajero = contpasajero + 1
                                            nombrea = False
                                            apellidoa = False
                                            dnia = False
                                        Loop

                                        MsgBox("Se han ingresado los datos de/los pasajero/s con exito. El codigo de la reserva para poder efecturar la venta del mismo es: " & maxreserva & ".", MsgBoxStyle.Information, "Reserva realizada")
                                        Me.Close()
                                        frmInicio.Show()

                                    ElseIf txtCantPersonas.Text = 0 Then

                                        MsgBox("Se ha realizado la reserva del pasaje con exito. El codigo de la reserva para poder efecturar la venta del mismo es: " & maxreserva & ".", MsgBoxStyle.Information, "Reserva realizada")
                                        fpasaje = fIda

                                        Me.Close()
                                        frmInicio.Show()
                                    End If

                                ElseIf rbtnIdaVuelta.Checked = True Then

                                    sql = "insert into reserva values(" & maxreserva & ", " & maxv & ", " & maxc & ", " & codag & ", curdate(), '" & fIda & "', '" & fVuelta & "', " & (txtCantPersonas.Text + 1) & ", '" & cmbClase.Text & "', " & descuentoT & ")"
                                    Call ejecutar(sql)

                                    Do Until contpasaje = (txtCantPersonas.Text + 1)

                                        sql = "select max(codpasaje)+1 from pasaje"
                                        Call ejecutar(sql)
                                        rs.Read()
                                        pasajemax = rs(0)

                                        sql = "insert into pasaje values(" & pasajemax & ", " & maxreserva & ")"
                                        Call ejecutar(sql)
                                        contpasaje = contpasaje + 1

                                    Loop

                                    If txtCantPersonas.Text > 0 Then

                                        MsgBox("Se ha realizado la reserva del pasaje con exito. A continuacion se procedera a tomar los datos de los otros pasajeros", MsgBoxStyle.Information, "Datos pasajeros")
                                        Do Until contpasajero = txtCantPersonas.Text

                                            Do Until nombrea = True

                                                nombrea = False
                                                nombreacompañante = InputBox("Ingrese el nombre del acompañante")

                                                If nombreacompañante = "" Then

                                                    MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                                    nombrea = False
                                                Else

                                                    If IsNumeric(nombreacompañante) Then

                                                        MsgBox("No puede ingresar numeros en un campo que solo pide letras", MsgBoxStyle.Critical, "Tipo de dato no valido")
                                                        nombrea = False

                                                    Else
                                                        nombrea = True

                                                    End If
                                                End If
                                            Loop

                                            Do Until apellidoa = True

                                                apellidoa = False
                                                apellidoacompañante = InputBox("Ingrese el apellido del acompañante")

                                                If apellidoacompañante = "" Then

                                                    MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                                    apellidoa = False
                                                Else

                                                    If IsNumeric(apellidoacompañante) Then

                                                        MsgBox("No puede ingresar numeros en un campo que solo pide letras", MsgBoxStyle.Critical, "Tipo de dato no valido")
                                                        apellidoa = False
                                                    Else

                                                        apellidoa = True
                                                    End If
                                                End If
                                            Loop

                                            Do Until dnia = True

                                                dnia = False
                                                dniacompañante = InputBox("Ingrese el DNI del acompañante")

                                                If dniacompañante = "" Then

                                                    MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                                    dnia = False
                                                Else
                                                    If Not IsNumeric(dniacompañante) Then

                                                        MsgBox("No puede ingresar letras en un campo que pide solo numeros", MsgBoxStyle.Critical, "Tipo de dato no valido")
                                                        dnia = False

                                                    Else

                                                        If dniacompañante.Length < 8 Or dniacompañante.Length > 8 Then

                                                            MsgBox("El DNI ingresado no es valido", MsgBoxStyle.Exclamation, "DNI no valido")
                                                        Else
                                                            dnia = True
                                                        End If
                                                    End If
                                                End If

                                            Loop

                                            sql = "insert into pasajero values('', " & maxc & ", " & pasajemax & ", '" & nombreacompañante & "', '" & apellidoacompañante & "', '" & dniacompañante & "')"
                                            Call ejecutar(sql)
                                            contpasajero = contpasajero + 1
                                            nombrea = False
                                            apellidoa = False
                                            dnia = False
                                        Loop

                                        MsgBox("Se han ingresado los datos de/los pasajero/s con exito. El codigo de la reserva para poder efecturar la venta del mismo es: " & maxreserva & ".", MsgBoxStyle.Information, "Reserva realizada")
                                        Me.Close()
                                        frmInicio.Show()

                                    ElseIf txtCantPersonas.Text = 0 Then

                                        MsgBox("Se ha realizado la reserva del pasaje con exito. El codigo de la reserva para poder efecturar la venta del mismo es: " & maxreserva & ".", MsgBoxStyle.Information, "Reserva realizada")
                                        fpasaje = fIda

                                        Me.Close()
                                        frmInicio.Show()
                                    End If

                                End If 'termina el if de si el radiobutton es Ida

                            Else 'si el cliente existe

                                sql = "select nombre from cliente where dni = " & txtDNI.Text & ""
                                Call ejecutar(sql)
                                rs.Read()
                                nombrec = rs(0)

                                sql = "select apellido from cliente where dni = " & txtDNI.Text & ""
                                Call ejecutar(sql)
                                rs.Read()
                                apellidoc = rs(0)

                                dnic = txtDNI.Text

                                MsgBox("El cliente " & nombrec & " " & apellidoc & " existe en la base", MsgBoxStyle.Information, "Cliente existente")

                                sql = "select codcliente from cliente where dni = " & txtDNI.Text & ""
                                Call ejecutar(sql)
                                rs.Read()
                                codc = rs(0)

                                sql = "select tipoavion from preciodestino where coddestino = " & codigod & ""
                                Call ejecutar(sql)
                                rs.Read()

                                sql = "select codavion from avion where tipoavion = '" & rs(0) & "'"
                                Call ejecutar(sql)
                                rs.Read()
                                coda = rs(0)

                                sql = "select max(nrovuelo) + 1 from vuelo"
                                Call ejecutar(sql)
                                rs.Read()
                                maxv = rs(0)
                                vuelopasaje = maxv

                                sql = "insert into vuelo values(" & maxv & ", " & codigod & ", " & coda & ", curdate(), '" & cmbHorario.Text & "')"
                                Call ejecutar(sql)

                                MsgBox("El vuelo se ha ingresado con exito", MsgBoxStyle.Information, "Vuelo ingresado")

                                sql = "select max(codreserva) + 1 from reserva"
                                Call ejecutar(sql)
                                rs.Read()
                                maxreserva = rs(0)

                                sql = "select codagencia from agencia where nombre = '" & cmbAgencia.Text & "'"
                                Call ejecutar(sql)
                                rs.Read()
                                codag = rs(0)

                                If rbtnIda.Checked = True Then

                                    sql = "insert into reserva values(" & maxreserva & ", " & maxv & ", " & codc & ", " & codag & ", curdate(), '" & fIda & "', null, " & (txtCantPersonas.Text + 1) & ", '" & cmbClase.Text & "', " & descuentoT & ")"
                                    Call ejecutar(sql)

                                    Do Until contpasaje = (txtCantPersonas.Text + 1)

                                        sql = "select max(codpasaje)+1 from pasaje"
                                        Call ejecutar(sql)
                                        rs.Read()
                                        pasajemax = rs(0)

                                        sql = "insert into pasaje values(" & pasajemax & ", " & maxreserva & ")"
                                        Call ejecutar(sql)
                                        contpasaje = contpasaje + 1

                                    Loop

                                    If txtCantPersonas.Text > 0 Then

                                        MsgBox("Se ha realizado la reserva del pasaje con exito. A continuacion se procedera a tomar los datos de los otros pasajeros", MsgBoxStyle.Information, "Datos pasajeros")

                                        Do Until contpasajero = txtCantPersonas.Text

                                            Do Until nombrea = True

                                                nombrea = False
                                                nombreacompañante = InputBox("Ingrese el nombre del acompañante")

                                                If nombreacompañante = "" Then

                                                    MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                                    nombrea = False
                                                Else

                                                    If IsNumeric(nombreacompañante) Then

                                                        MsgBox("No puede ingresar numeros en un campo que solo pide letras", MsgBoxStyle.Critical, "Tipo de dato no valido")
                                                        nombrea = False

                                                    Else
                                                        nombrea = True

                                                    End If
                                                End If
                                            Loop

                                            Do Until apellidoa = True

                                                apellidoa = False
                                                apellidoacompañante = InputBox("Ingrese el apellido del acompañante")

                                                If apellidoacompañante = "" Then

                                                    MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                                    apellidoa = False
                                                Else

                                                    If IsNumeric(apellidoacompañante) Then

                                                        MsgBox("No puede ingresar numeros en un campo que solo pide letras", MsgBoxStyle.Critical, "Tipo de dato no valido")
                                                        apellidoa = False
                                                    Else

                                                        apellidoa = True
                                                    End If
                                                End If
                                            Loop

                                            Do Until dnia = True

                                                dnia = False
                                                dniacompañante = InputBox("Ingrese el DNI del acompañante")

                                                If dniacompañante = "" Then

                                                    MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                                    dnia = False
                                                Else
                                                    If Not IsNumeric(dniacompañante) Then

                                                        MsgBox("No puede ingresar letras en un campo que pide solo numeros", MsgBoxStyle.Critical, "Tipo de dato no valido")
                                                        dnia = False

                                                    Else

                                                        If dniacompañante.Length < 8 Or dniacompañante.Length > 8 Then

                                                            MsgBox("El DNI ingresado no es valido", MsgBoxStyle.Exclamation, "DNI no valido")
                                                        Else
                                                            dnia = True
                                                        End If
                                                    End If
                                                End If

                                            Loop

                                            sql = "insert into pasajero values('', " & codc & ", " & pasajemax & ", '" & nombreacompañante & "', '" & apellidoacompañante & "', '" & dniacompañante & "')"
                                            Call ejecutar(sql)
                                            contpasajero = contpasajero + 1
                                            nombrea = False
                                            apellidoa = False
                                            dnia = False
                                        Loop

                                        MsgBox("Se han ingresado los datos de/los pasajero/s con exito. El codigo de la reserva para poder efecturar la venta del mismo es: " & maxreserva & ".", MsgBoxStyle.Information, "Reserva realizada")
                                        Me.Close()
                                        frmInicio.Show()

                                    ElseIf txtCantPersonas.Text = 0 Then

                                        MsgBox("Se ha realizado la reserva del pasaje con exito. El codigo de la reserva para poder efecturar la venta del mismo es: " & maxreserva & ".", MsgBoxStyle.Information, "Reserva realizada")
                                        fpasaje = fIda

                                        Me.Close()
                                        frmInicio.Show()
                                    End If

                                ElseIf rbtnIdaVuelta.Checked = True Then

                                    sql = "insert into reserva values(" & maxreserva & ", " & maxv & ", " & codc & ", " & codag & ", curdate(), '" & fIda & "', '" & fVuelta & "', " & (txtCantPersonas.Text + 1) & ", '" & cmbClase.Text & "', " & descuentoT & ")"
                                    Call ejecutar(sql)

                                    Do Until contpasaje = (txtCantPersonas.Text + 1)

                                        sql = "select max(codpasaje)+1 from pasaje"
                                        Call ejecutar(sql)
                                        rs.Read()
                                        pasajemax = rs(0)

                                        sql = "insert into pasaje values(" & pasajemax & ", " & maxreserva & ")"
                                        Call ejecutar(sql)
                                        contpasaje = contpasaje + 1

                                    Loop

                                    If txtCantPersonas.Text >= 1 Then

                                        MsgBox("Se ha realizado la reserva del pasaje con exito. A continuacion se procedera a tomar los datos de los otros pasajeros", MsgBoxStyle.Information, "Datos pasajeros")
                                        Do Until contpasajero = txtCantPersonas.Text

                                            Do Until nombrea = True

                                                nombrea = False
                                                nombreacompañante = InputBox("Ingrese el nombre del acompañante")

                                                If nombreacompañante = "" Then

                                                    MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                                    nombrea = False
                                                Else

                                                    If IsNumeric(nombreacompañante) Then

                                                        MsgBox("No puede ingresar numeros en un campo que solo pide letras", MsgBoxStyle.Critical, "Tipo de dato no valido")
                                                        nombrea = False

                                                    Else
                                                        nombrea = True

                                                    End If
                                                End If
                                            Loop

                                            Do Until apellidoa = True

                                                apellidoa = False
                                                apellidoacompañante = InputBox("Ingrese el apellido del acompañante")

                                                If apellidoacompañante = "" Then

                                                    MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                                    apellidoa = False
                                                Else

                                                    If IsNumeric(apellidoacompañante) Then

                                                        MsgBox("No puede ingresar numeros en un campo que solo pide letras", MsgBoxStyle.Critical, "Tipo de dato no valido")
                                                        apellidoa = False
                                                    Else

                                                        apellidoa = True
                                                    End If
                                                End If
                                            Loop

                                            Do Until dnia = True

                                                dnia = False
                                                dniacompañante = InputBox("Ingrese el DNI del acompañante")

                                                If dniacompañante = "" Then

                                                    MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                                    dnia = False
                                                Else
                                                    If Not IsNumeric(dniacompañante) Then

                                                        MsgBox("No puede ingresar letras en un campo que pide solo numeros", MsgBoxStyle.Critical, "Tipo de dato no valido")
                                                        dnia = False

                                                    Else

                                                        If dniacompañante.Length < 8 Or dniacompañante.Length > 8 Then

                                                            MsgBox("El DNI ingresado no es valido", MsgBoxStyle.Exclamation, "DNI no valido")
                                                        Else
                                                            dnia = True
                                                        End If
                                                    End If
                                                End If

                                            Loop

                                            sql = "insert into pasajero values('', " & codc & ", " & pasajemax & ", '" & nombreacompañante & "', '" & apellidoacompañante & "', '" & dniacompañante & "')"
                                            Call ejecutar(sql)
                                            contpasajero = contpasajero + 1
                                            nombrea = False
                                            apellidoa = False
                                            dnia = False
                                        Loop

                                        MsgBox("Se han ingresado los datos de/los pasajero/s con exito. El codigo de la reserva para poder efecturar la venta del mismo es: " & maxreserva & ".", MsgBoxStyle.Information, "Reserva realizada")
                                        Me.Close()
                                        frmInicio.Show()

                                    ElseIf txtCantPersonas.Text = 0 Then

                                        MsgBox("Se ha realizado la reserva del pasaje con exito. El codigo de la reserva para poder efecturar la venta del mismo es: " & maxreserva & ".", MsgBoxStyle.Information, "Reserva realizada")
                                        fpasaje = fIda

                                        Me.Close()
                                        frmInicio.Show()
                                    End If

                                End If 'termina el if de si el radiobutton es Ida

                            End If 'termina el if de si el cliente no existe

                        Else

                            MsgBox("El cliente no acepta el monto de la reserva, por lo que no se puede seguir con la reserva", MsgBoxStyle.Exclamation, "Monto no aceptado")


                        End If 'termina el if de si el cliente acepta el monto de la reserva

                    End If 'termina if de si la clase es Turista

                    If cmbClase.Text = "Primera clase" Then

                        sql = "select coddestino from destino where pais = '" & cmbPais.Text & "' and ciudad = '" & cmbCiudad.Text & "'"
                        Call ejecutar(sql)
                        rs.Read()
                        codigod = rs(0)

                        sql = "select precioprimeraclase from preciodestino where coddestino = " & codigod & ""
                        Call ejecutar(sql)
                        rs.Read()
                        precioviajeP = rs(0)

                        precioviajeP = precioviajeP * (txtCantPersonas.Text + 1)

                        descuentoP = (precioviajeP * 10) / 100

                        precioreservaP = precioviajeP - descuentoP

                        If MsgBox("El valor de la reserva del pasaje que debe pagar el cliente es de: $" & descuentoP & ". El valor total del pasaje es de $" & precioviajeP & ".¿Acepta el monto a pagar?", MsgBoxStyle.YesNo, "Monto reserva") = MsgBoxResult.Yes Then
                            MsgBox("EL cliente acepta pagar el monto de la reserva, se procedera a ingresar los datos en la base", MsgBoxStyle.Information, "Monto reserva")

                            sql = "select count(dni) from cliente where dni = " & txtDNI.Text & ""
                            Call ejecutar(sql)
                            rs.Read()
                            countdni = rs(0)

                            If countdni = 0 Then

                                MsgBox("El cliente ingresado no existe en la base, se pasara a ingresarlo", MsgBoxStyle.Exclamation, "Cliente inexistente")

                                Do Until nombreclien = True
                                    nombrec = InputBox("Ingrese el nombre del cliente")

                                    If nombrec = "" Then

                                        MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                        nombreclien = False
                                    Else

                                        If IsNumeric(nombrec) Then

                                            MsgBox("No puede ingresar numeros en un campo que solo pide letras", MsgBoxStyle.Critical, "Tipo de dato no valido")
                                        Else

                                            nombreclien = True
                                        End If
                                    End If
                                Loop

                                Do Until apellidoclien = True

                                    apellidoc = InputBox("Ingrese el apellido del cliente")

                                    If apellidoc = "" Then

                                        MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                        apellidoclien = False
                                    Else

                                        If IsNumeric(apellidoc) Then

                                            MsgBox("No puede ingresar numeros en un campo que solo pide letras", MsgBoxStyle.Critical, "Tipo de dato no valido")
                                        Else

                                            apellidoclien = True
                                        End If
                                    End If
                                Loop

                                Do Until telnumeros = True

                                    telefonocliente = InputBox("Ingrese el telefono del cliente")

                                    If telefonocliente = "" Then

                                        MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                        telnumeros = False
                                    Else
                                        If Not IsNumeric(telefonocliente) Then

                                            MsgBox("No puede ingresar letras en un campo que pide solo numeros", MsgBoxStyle.Critical, "Tipo de dato no valido")
                                            telnumeros = False

                                        Else
                                            If telefonocliente.Length < 8 Or telefonocliente.Length > 10 Then

                                                MsgBox("El telefono ingresado no es valido", MsgBoxStyle.Exclamation, "Telefono no valido")
                                            Else
                                                telnumeros = True
                                            End If
                                        End If
                                    End If

                                Loop

                                Do Until emailc = True

                                    emailcliente = InputBox("Ingrese el e-mail del cliente")

                                    If emailcliente = "" Then

                                        MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                        emailc = False
                                    Else

                                        emailc = True
                                    End If
                                Loop

                                sql = "select max(codcliente) + 1 from cliente"
                                Call ejecutar(sql)
                                rs.Read()
                                maxc = rs(0)

                                sql = "insert into cliente values(" & maxc & ", '" & nombrec & "', '" & apellidoc & "', '" & txtDNI.Text & "', '" & telefonocliente & "', '" & emailcliente & "')"
                                Call ejecutar(sql)
                                dnic = txtDNI.Text

                                MsgBox("Se ha ingresado al cliente " & nombrec & " " & apellidoc & " con exito.", MsgBoxStyle.Information, "Cliente ingresado")
                                dnic = txtDNI.Text

                                sql = "select tipoavion from preciodestino where coddestino = " & codigod & ""
                                Call ejecutar(sql)
                                rs.Read()

                                sql = "select codavion from avion where tipoavion = '" & rs(0) & "'"
                                Call ejecutar(sql)
                                rs.Read()
                                coda = rs(0)

                                sql = "select max(nrovuelo) + 1 from vuelo"
                                Call ejecutar(sql)
                                rs.Read()
                                maxv = rs(0)
                                vuelopasaje = maxv

                                sql = "insert into vuelo values(" & maxv & ", " & codigod & ", " & coda & ", curdate(), '" & cmbHorario.Text & "')"
                                Call ejecutar(sql)

                                MsgBox("El vuelo se ha ingresado con exito", MsgBoxStyle.Information, "Vuelo ingresado")

                                sql = "select max(codreserva) + 1 from reserva"
                                Call ejecutar(sql)
                                rs.Read()
                                maxreserva = rs(0)

                                sql = "select codagencia from agencia where nombre = '" & cmbAgencia.Text & "'"
                                Call ejecutar(sql)
                                rs.Read()
                                codag = rs(0)

                                If rbtnIda.Checked = True Then

                                    sql = "insert into reserva values(" & maxreserva & ", " & maxv & ", " & maxc & ", " & codag & ", curdate(), '" & fIda & "', null, " & (txtCantPersonas.Text + 1) & ", '" & cmbClase.Text & "', " & descuentoP & ")"
                                    Call ejecutar(sql)

                                    Do Until contpasaje = (txtCantPersonas.Text + 1)

                                        sql = "select max(codpasaje)+1 from pasaje"
                                        Call ejecutar(sql)
                                        rs.Read()
                                        pasajemax = rs(0)

                                        sql = "insert into pasaje values(" & pasajemax & ", " & maxreserva & ")"
                                        Call ejecutar(sql)
                                        contpasaje = contpasaje + 1

                                    Loop

                                    If txtCantPersonas.Text > 0 Then

                                        MsgBox("Se ha realizado la reserva del pasaje con exito. A continuacion se procedera a tomar los datos de los otros pasajeros", MsgBoxStyle.Information, "Datos pasajeros")
                                        Do Until contpasajero = txtCantPersonas.Text

                                            Do Until nombrea = True

                                                nombrea = False
                                                nombreacompañante = InputBox("Ingrese el nombre del acompañante")

                                                If nombreacompañante = "" Then

                                                    MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                                    nombrea = False
                                                Else

                                                    If IsNumeric(nombreacompañante) Then

                                                        MsgBox("No puede ingresar numeros en un campo que solo pide letras", MsgBoxStyle.Critical, "Tipo de dato no valido")
                                                        nombrea = False

                                                    Else
                                                        nombrea = True

                                                    End If
                                                End If
                                            Loop

                                            Do Until apellidoa = True

                                                apellidoa = False
                                                apellidoacompañante = InputBox("Ingrese el apellido del acompañante")

                                                If apellidoacompañante = "" Then

                                                    MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                                    apellidoa = False
                                                Else

                                                    If IsNumeric(apellidoacompañante) Then

                                                        MsgBox("No puede ingresar numeros en un campo que solo pide letras", MsgBoxStyle.Critical, "Tipo de dato no valido")
                                                        apellidoa = False
                                                    Else

                                                        apellidoa = True
                                                    End If
                                                End If
                                            Loop

                                            Do Until dnia = True

                                                dnia = False
                                                dniacompañante = InputBox("Ingrese el DNI del acompañante")

                                                If dniacompañante = "" Then

                                                    MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                                    dnia = False
                                                Else
                                                    If Not IsNumeric(dniacompañante) Then

                                                        MsgBox("No puede ingresar letras en un campo que pide solo numeros", MsgBoxStyle.Critical, "Tipo de dato no valido")
                                                        dnia = False

                                                    Else

                                                        If dniacompañante.Length < 8 Or dniacompañante.Length > 8 Then

                                                            MsgBox("El DNI ingresado no es valido", MsgBoxStyle.Exclamation, "DNI no valido")
                                                        Else
                                                            dnia = True
                                                        End If
                                                    End If
                                                End If

                                            Loop

                                            sql = "insert into pasajero values('', " & maxc & ", " & pasajemax & ", '" & nombreacompañante & "', '" & apellidoacompañante & "', '" & dniacompañante & "')"
                                            Call ejecutar(sql)
                                            contpasajero = contpasajero + 1
                                            nombrea = False
                                            apellidoa = False
                                            dnia = False

                                        Loop

                                        MsgBox("Se han ingresado los datos de/los pasajero/s con exito. El codigo de la reserva para poder efecturar la venta del mismo es: " & maxreserva & ".", MsgBoxStyle.Information, "Reserva realizada")
                                        Me.Close()
                                        frmInicio.Show()

                                    ElseIf txtCantPersonas.Text = 0 Then

                                        MsgBox("Se ha realizado la reserva del pasaje con exito. El codigo de la reserva para poder efecturar la venta del mismo es: " & maxreserva & ".", MsgBoxStyle.Information, "Reserva realizada")
                                        fpasaje = fIda

                                        Me.Close()
                                        frmInicio.Show()
                                    End If

                                ElseIf rbtnIdaVuelta.Checked = True Then

                                    sql = "insert into reserva values(" & maxreserva & ", " & maxv & ", " & maxc & ", " & codag & ", curdate(), '" & fIda & "', '" & fVuelta & "', " & (txtCantPersonas.Text + 1) & ", '" & cmbClase.Text & "', " & descuentoP & ")"
                                    Call ejecutar(sql)

                                    Do Until contpasaje = (txtCantPersonas.Text + 1)

                                        sql = "select max(codpasaje)+1 from pasaje"
                                        Call ejecutar(sql)
                                        rs.Read()
                                        pasajemax = rs(0)

                                        sql = "insert into pasaje values(" & pasajemax & ", " & maxreserva & ")"
                                        Call ejecutar(sql)
                                        contpasaje = contpasaje + 1

                                    Loop

                                    If txtCantPersonas.Text > 0 Then

                                        MsgBox("Se ha realizado la reserva del pasaje con exito. A continuacion se procedera a tomar los datos de los otros pasajeros", MsgBoxStyle.Information, "Datos pasajeros")
                                        Do Until contpasajero = txtCantPersonas.Text

                                            Do Until nombrea = True

                                                nombrea = False
                                                nombreacompañante = InputBox("Ingrese el nombre del acompañante")

                                                If nombreacompañante = "" Then

                                                    MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                                    nombrea = False
                                                Else

                                                    If IsNumeric(nombreacompañante) Then

                                                        MsgBox("No puede ingresar numeros en un campo que solo pide letras", MsgBoxStyle.Critical, "Tipo de dato no valido")
                                                        nombrea = False

                                                    Else
                                                        nombrea = True

                                                    End If
                                                End If
                                            Loop

                                            Do Until apellidoa = True

                                                apellidoa = False
                                                apellidoacompañante = InputBox("Ingrese el apellido del acompañante")

                                                If apellidoacompañante = "" Then

                                                    MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                                    apellidoa = False
                                                Else

                                                    If IsNumeric(apellidoacompañante) Then

                                                        MsgBox("No puede ingresar numeros en un campo que solo pide letras", MsgBoxStyle.Critical, "Tipo de dato no valido")
                                                        apellidoa = False
                                                    Else

                                                        apellidoa = True
                                                    End If
                                                End If
                                            Loop

                                            Do Until dnia = True

                                                dnia = False
                                                dniacompañante = InputBox("Ingrese el DNI del acompañante")

                                                If dniacompañante = "" Then

                                                    MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                                    dnia = False
                                                Else
                                                    If Not IsNumeric(dniacompañante) Then

                                                        MsgBox("No puede ingresar letras en un campo que pide solo numeros", MsgBoxStyle.Critical, "Tipo de dato no valido")
                                                        dnia = False

                                                    Else

                                                        If dniacompañante.Length < 8 Or dniacompañante.Length > 8 Then

                                                            MsgBox("El DNI ingresado no es valido", MsgBoxStyle.Exclamation, "DNI no valido")
                                                        Else

                                                            dnia = True
                                                        End If
                                                    End If
                                                End If

                                            Loop

                                            sql = "insert into pasajero values('', " & maxc & ", " & pasajemax & ", '" & nombreacompañante & "', '" & apellidoacompañante & "', '" & dniacompañante & "')"
                                            Call ejecutar(sql)
                                            contpasajero = contpasajero + 1
                                            nombrea = False
                                            apellidoa = False
                                            dnia = False
                                        Loop

                                        MsgBox("Se han ingresado los datos de/los pasajero/s con exito. El codigo de la reserva para poder efecturar la venta del mismo es: " & maxreserva & ".", MsgBoxStyle.Information, "Reserva realizada")
                                        Me.Close()
                                        frmInicio.Show()

                                    ElseIf txtCantPersonas.Text = 0 Then

                                        MsgBox("Se ha realizado la reserva del pasaje con exito. El codigo de la reserva para poder efecturar la venta del mismo es: " & maxreserva & ".", MsgBoxStyle.Information, "Reserva realizada")
                                        fpasaje = fIda

                                        Me.Close()
                                        frmInicio.Show()
                                    End If

                                End If 'termina el if de si el radiobutton es Ida

                            Else 'si el cliente existe

                                sql = "select nombre from cliente where dni = " & txtDNI.Text & ""
                                Call ejecutar(sql)
                                rs.Read()
                                nombrec = rs(0)

                                sql = "select apellido from cliente where dni = " & txtDNI.Text & ""
                                Call ejecutar(sql)
                                rs.Read()
                                apellidoc = rs(0)

                                dnic = txtDNI.Text

                                MsgBox("El cliente " & nombrec & " " & apellidoc & " existe en la base", MsgBoxStyle.Information, "Cliente existente")

                                sql = "select codcliente from cliente where dni = " & txtDNI.Text & ""
                                Call ejecutar(sql)
                                rs.Read()
                                codc = rs(0)


                                sql = "select tipoavion from preciodestino where coddestino = " & codigod & ""
                                Call ejecutar(sql)
                                rs.Read()

                                sql = "select codavion from avion where tipoavion = '" & rs(0) & "'"
                                Call ejecutar(sql)
                                rs.Read()
                                coda = rs(0)

                                sql = "select max(nrovuelo) + 1 from vuelo"
                                Call ejecutar(sql)
                                rs.Read()
                                maxv = rs(0)
                                vuelopasaje = maxv

                                sql = "insert into vuelo values(" & maxv & ", " & codigod & ", " & coda & ", curdate(), '" & cmbHorario.Text & "')"
                                Call ejecutar(sql)

                                MsgBox("El vuelo se ha ingresado con exito", MsgBoxStyle.Information, "Vuelo ingresado")

                                sql = "select max(codreserva) + 1 from reserva"
                                Call ejecutar(sql)
                                rs.Read()
                                maxreserva = rs(0)

                                sql = "select codagencia from agencia where nombre = '" & cmbAgencia.Text & "'"
                                Call ejecutar(sql)
                                rs.Read()
                                codag = rs(0)

                                If rbtnIda.Checked = True Then

                                    sql = "insert into reserva values(" & maxreserva & ", " & maxv & ", " & codc & ", " & codag & ", curdate(), '" & fIda & "', null, " & (txtCantPersonas.Text + 1) & ", '" & cmbClase.Text & "', " & descuentoP & ")"
                                    Call ejecutar(sql)

                                    Do Until contpasaje = (txtCantPersonas.Text + 1)

                                        sql = "select max(codpasaje)+1 from pasaje"
                                        Call ejecutar(sql)
                                        rs.Read()
                                        pasajemax = rs(0)

                                        sql = "insert into pasaje values(" & pasajemax & ", " & maxreserva & ")"
                                        Call ejecutar(sql)
                                        contpasaje = contpasaje + 1

                                    Loop

                                    If txtCantPersonas.Text > 0 Then

                                        MsgBox("Se ha realizado la reserva del pasaje con exito. A continuacion se procedera a tomar los datos de los otros pasajeros", MsgBoxStyle.Information, "Datos pasajeros")
                                        Do Until contpasajero = txtCantPersonas.Text

                                            Do Until nombrea = True

                                                nombrea = False
                                                nombreacompañante = InputBox("Ingrese el nombre del acompañante")

                                                If nombreacompañante = "" Then

                                                    MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                                    nombrea = False
                                                Else

                                                    If IsNumeric(nombreacompañante) Then

                                                        MsgBox("No puede ingresar numeros en un campo que solo pide letras", MsgBoxStyle.Critical, "Tipo de dato no valido")
                                                        nombrea = False

                                                    Else
                                                        nombrea = True

                                                    End If
                                                End If
                                            Loop

                                            Do Until apellidoa = True

                                                apellidoa = False
                                                apellidoacompañante = InputBox("Ingrese el apellido del acompañante")

                                                If apellidoacompañante = "" Then

                                                    MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                                    apellidoa = False
                                                Else

                                                    If IsNumeric(apellidoacompañante) Then

                                                        MsgBox("No puede ingresar numeros en un campo que solo pide letras", MsgBoxStyle.Critical, "Tipo de dato no valido")
                                                        apellidoa = False
                                                    Else

                                                        apellidoa = True
                                                    End If
                                                End If
                                            Loop

                                            Do Until dnia = True

                                                dnia = False
                                                dniacompañante = InputBox("Ingrese el DNI del acompañante")

                                                If dniacompañante = "" Then

                                                    MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                                    dnia = False
                                                Else
                                                    If Not IsNumeric(dniacompañante) Then

                                                        MsgBox("No puede ingresar letras en un campo que pide solo numeros", MsgBoxStyle.Critical, "Tipo de dato no valido")
                                                        dnia = False

                                                    Else

                                                        If dniacompañante.Length < 8 Or dniacompañante.Length > 8 Then

                                                            MsgBox("El DNI ingresado no es valido", MsgBoxStyle.Exclamation, "DNI no valido")
                                                        Else
                                                            dnia = True
                                                        End If
                                                    End If
                                                End If

                                            Loop

                                            sql = "insert into pasajero values('', " & codc & ", " & pasajemax & ", '" & nombreacompañante & "', '" & apellidoacompañante & "', '" & dniacompañante & "')"
                                            Call ejecutar(sql)
                                            contpasajero = contpasajero + 1
                                            nombrea = False
                                            apellidoa = False
                                            dnia = False

                                        Loop

                                        MsgBox("Se han ingresado los datos de/los pasajero/s con exito. El codigo de la reserva para poder efecturar la venta del mismo es: " & maxreserva & ".", MsgBoxStyle.Information, "Reserva realizada")
                                        Me.Close()
                                        frmInicio.Show()

                                    ElseIf txtCantPersonas.Text = 0 Then

                                        MsgBox("Se ha realizado la reserva del pasaje con exito. El codigo de la reserva para poder efecturar la venta del mismo es: " & maxreserva & ".", MsgBoxStyle.Information, "Reserva realizada")
                                        fpasaje = fIda

                                        Me.Close()
                                        frmInicio.Show()
                                    End If

                                ElseIf rbtnIdaVuelta.Checked = True Then

                                    sql = "insert into reserva values(" & maxreserva & ", " & maxv & ", " & codc & ", " & codag & ", curdate(), '" & fIda & "', '" & fVuelta & "', " & (txtCantPersonas.Text + 1) & ", '" & cmbClase.Text & "', " & descuentoP & ")"
                                    Call ejecutar(sql)

                                    Do Until contpasaje = (txtCantPersonas.Text + 1)

                                        sql = "select max(codpasaje)+1 from pasaje"
                                        Call ejecutar(sql)
                                        rs.Read()
                                        pasajemax = rs(0)

                                        sql = "insert into pasaje values(" & pasajemax & ", " & maxreserva & ")"
                                        Call ejecutar(sql)
                                        contpasaje = contpasaje + 1

                                    Loop

                                    If txtCantPersonas.Text > 0 Then

                                        MsgBox("Se ha realizado la reserva del pasaje con exito. A continuacion se procedera a tomar los datos de los otros pasajeros", MsgBoxStyle.Information, "Datos pasajeros")
                                        Do Until contpasajero = txtCantPersonas.Text

                                            Do Until nombrea = True

                                                nombrea = False
                                                nombreacompañante = InputBox("Ingrese el nombre del acompañante")

                                                If nombreacompañante = "" Then

                                                    MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                                    nombrea = False
                                                Else

                                                    If IsNumeric(nombreacompañante) Then

                                                        MsgBox("No puede ingresar numeros en un campo que solo pide letras", MsgBoxStyle.Critical, "Tipo de dato no valido")
                                                        nombrea = False

                                                    Else
                                                        nombrea = True

                                                    End If
                                                End If
                                            Loop

                                            Do Until apellidoa = True

                                                apellidoa = False
                                                apellidoacompañante = InputBox("Ingrese el apellido del acompañante")

                                                If apellidoacompañante = "" Then

                                                    MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                                    apellidoa = False
                                                Else

                                                    If IsNumeric(apellidoacompañante) Then

                                                        MsgBox("No puede ingresar numeros en un campo que solo pide letras", MsgBoxStyle.Critical, "Tipo de dato no valido")
                                                        apellidoa = False
                                                    Else

                                                        apellidoa = True
                                                    End If
                                                End If
                                            Loop

                                            Do Until dnia = True

                                                dnia = False
                                                dniacompañante = InputBox("Ingrese el DNI del acompañante")

                                                If dniacompañante = "" Then

                                                    MsgBox("Complete los campos", MsgBoxStyle.Exclamation, "Campos incompletos")
                                                    dnia = False
                                                Else
                                                    If Not IsNumeric(dniacompañante) Then

                                                        MsgBox("No puede ingresar letras en un campo que pide solo numeros", MsgBoxStyle.Critical, "Tipo de dato no valido")
                                                        dnia = False

                                                    Else

                                                        If dniacompañante.Length < 8 Or dniacompañante.Length > 8 Then

                                                            MsgBox("El DNI ingresado no es valido", MsgBoxStyle.Exclamation, "DNI no valido")
                                                        Else
                                                            dnia = True
                                                        End If
                                                    End If
                                                End If

                                            Loop

                                            sql = "insert into pasajero values('', " & codc & ", " & pasajemax & ", '" & nombreacompañante & "', '" & apellidoacompañante & "', '" & dniacompañante & "')"
                                            Call ejecutar(sql)
                                            contpasajero = contpasajero + 1
                                            nombrea = False
                                            apellidoa = False
                                            dnia = False

                                        Loop

                                        MsgBox("Se han ingresado los datos de/los pasajero/s con exito. El codigo de la reserva para poder efecturar la venta del mismo es: " & maxreserva & ".", MsgBoxStyle.Information, "Reserva realizada")
                                        Me.Close()
                                        frmInicio.Show()

                                    ElseIf txtCantPersonas.Text = 0 Then

                                        MsgBox("Se ha realizado la reserva del pasaje con exito. El codigo de la reserva para poder efecturar la venta del mismo es: " & maxreserva & ".", MsgBoxStyle.Information, "Reserva realizada")
                                        fpasaje = fIda

                                        Me.Close()
                                        frmInicio.Show()
                                    End If

                                End If 'termina el if de si el radiobutton es Ida

                            End If 'termina el if de si el cliente no existe

                        Else

                            MsgBox("El cliente no acepta el monto de la reserva, por lo que no se puede seguir con la reserva", MsgBoxStyle.Exclamation, "Monto no aceptado")
                            Me.Close()
                            frmInicio.Show()
                        End If 'terima el if de si el cliente acepta el monto de la reserva

                    End If ' termina el if de si la clase es Clase Principal

                    fpasaje = fIda

                End If
            End If

        End If 'termina el if de si el lugar de salida es correcto

    End Sub


    Private Sub cmbPais_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbPais.SelectedIndexChanged

        sql = "Select ciudad from destino where pais = '" & cmbPais.Text & "'"
        Call ejecutar(sql)
        cmbCiudad.Items.Clear()
        While rs.Read()

            cmbCiudad.Items.Add(rs(0))
        End While

    End Sub

    Private Sub frmReserva_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        sql = "select nombre from agencia"
        Call ejecutar(sql)

        While rs.Read

            cmbAgencia.Items.Add(rs(0))

        End While

        sql = "select distinct(pais) from destino"
        Call ejecutar(sql)

        While rs.Read

            cmbPais.Items.Add(rs(0))

        End While



    End Sub

    Private Sub cmbAgencia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAgencia.SelectedIndexChanged

        If cmbAgencia.Text = "" Then
        Else

            rbtnIda.Enabled = True
            rbtnIdaVuelta.Enabled = True

        End If

    End Sub

    Private Sub txtDiaIda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiaIda.TextChanged

        If txtDiaIda.TextLength = 2 Then

            txtMesIda.Focus()
        End If

    End Sub

    Private Sub txtMesIda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMesIda.TextChanged

        If txtMesIda.TextLength = 2 Then

            txtAñoIda.Focus()
        End If


    End Sub

    Private Sub txtAñoIda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAñoIda.TextChanged

        If txtAñoIda.TextLength = 4 Then

            txtDiaVuelta.Focus()
        End If

    End Sub

    Private Sub txtDiaVuelta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiaVuelta.TextChanged

        If txtDiaVuelta.TextLength = 2 Then

            txtMesVuelta.Focus()
        End If

    End Sub

    Private Sub txtMesVuelta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMesVuelta.TextChanged

        If txtMesVuelta.TextLength = 2 Then

            txtAñoVuelta.Focus()
        End If

    End Sub

    Private Sub txtDesde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDesde.TextChanged

    End Sub
End Class