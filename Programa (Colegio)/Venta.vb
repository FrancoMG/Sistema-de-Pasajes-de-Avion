Public Class frmVenta

    Dim maxventa As Integer
    Dim codc As Integer
    Dim countr As Integer
    Dim codr As Integer
    Dim codigorecuperado As Integer
    Dim contventa As Integer
    Dim contmostrar As Integer = 0
    Dim countc As Integer
    Dim countp As Integer = 0
    Dim nombreacompañantep As String
    Dim apellidoacompañantep As String
    Dim dniacompañantep As String
    Dim precioviajeT As Integer = 0
    Dim descuentoT As Integer = 0
    Dim precioreservaT As Integer
    Dim precioviajeP As Integer
    Dim descuentoP As Integer
    Dim precioreservaP As Integer
    Dim codigod As Integer
    Dim cantpersonas As Integer
    Dim pasajeventa As Integer
    Dim pais As String
    Dim ciudad As String
    Dim mostrar As Integer
    Dim contadorReserva As Integer


    Private Sub btnIngresarCodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresarCodigo.Click

        If txtVentaReserva.Text = "" Then

            MsgBox("Complete los campos vacios para poder continuar", MsgBoxStyle.Critical, "Campos incompletos")

        Else

            If Not IsNumeric(txtVentaReserva.Text) Then

                MsgBox("No puede ingresar letras en un campo que solo pide numeros", MsgBoxStyle.Critical, "Tipo de dato no valido")
                txtVentaReserva.Clear()
            Else

                sql = "select count(codreserva) from reserva where codreserva = '" & txtVentaReserva.Text & "'"
                Call ejecutar(sql)
                rs.Read()

                If rs(0) = 0 Then

                    MsgBox("El codigo ingresado no corresponde a ninguna reserva", MsgBoxStyle.Critical, "Codigo de reserva onexistente")
                    txtVentaReserva.Clear()

                Else

                    sql = "select count(codreserva) from ventapasaje where codreserva = '" & txtVentaReserva.Text & "'"
                    Call ejecutar(sql)
                    rs.Read()

                    If rs(0) > 0 Then

                        MsgBox("La reserva ingresada ya fue utilizada para una venta", MsgBoxStyle.Critical, "Reserva ya utilizada")
                        txtVentaReserva.Clear()

                    Else

                        MsgBox("La reserva existe. Procederemos a ingresar la informacion", MsgBoxStyle.Information, "Reserva existente")

                        sql = "select clase from reserva where codreserva = '" & txtVentaReserva.Text & "'"
                        Call ejecutar(sql)
                        rs.Read()

                        If rs(0) = "Turista" Then

                            sql = "select cantpersonas from reserva where codreserva = " & txtVentaReserva.Text & ""
                            Call ejecutar(sql)
                            rs.Read()
                            cantpersonas = rs(0)

                            sql = "select coddestino from vuelo v, reserva r where v.nrovuelo = r.nrovuelo and r.codreserva = " & txtVentaReserva.Text & ""
                            Call ejecutar(sql)
                            rs.Read()
                            codigod = rs(0)

                            sql = "select precioclaseturista from preciodestino where coddestino = " & codigod & ""
                            Call ejecutar(sql)
                            rs.Read()
                            precioviajeT = rs(0)

                            precioviajeT = precioviajeT * cantpersonas

                            descuentoT = (precioviajeT * 10) / 100

                            precioreservaT = precioviajeT - descuentoT

                            If MsgBox("El precio que debe pagar para poder realizar la venta es de $" & precioreservaT & ". ¿Acepta pagar este monto?", MsgBoxStyle.YesNo, "Monto restante para la venta") = MsgBoxResult.Yes Then

                                MsgBox("El cliente acpeta pagar el resto de la venta, se procedera a realizar la venta del pasaje", MsgBoxStyle.Information, "Monto aceptado")

                                Do Until contventa = (cantpersonas + 1)

                                    sql = "select max(codventa)+1 from ventapasaje"
                                    Call ejecutar(sql)
                                    rs.Read()
                                    maxventa = rs(0)

                                    sql = "select codpasaje from pasaje where codreserva = " & txtVentaReserva.Text & ""
                                    Call ejecutar(sql)
                                    rs.Read()
                                    pasajeventa = rs(0)

                                    sql = "insert into ventapasaje values(" & maxventa & ", '" & txtVentaReserva.Text & "', " & pasajeventa & ", " & precioreservaT & ")"
                                    Call ejecutar(sql)
                                    contventa = contventa + 1

                                Loop

                                MsgBox("Se ha realizado la venta del pasaje con exito, a continuacion se procedera a mostrar su pasaje", MsgBoxStyle.Information, "Venta realizada")

                                sql = "select count(codpasajero) from pasajero where codpasaje in(select codpasaje from pasaje where codreserva = '" & txtVentaReserva.Text & "')"
                                Call ejecutar(sql)
                                rs.Read()
                                countp = rs(0)

                                If countp = 0 Then

                                    frmPasaje.lblClaseP.Text = clasepasaje
                                    frmPasaje.lblHoraP.Text = horapasaje
                                    frmPasaje.lblVueloP.Text = vuelopasaje
                                    frmPasaje.lblFechaP.Text = fpasaje
                                    frmPasaje.lblDesdeP.Text = desdepasaje
                                    frmPasaje.lblHastaP.Text = hastapasaje
                                    frmPasaje.lblNombreCP.Text = nombrec
                                    frmPasaje.lblApellidoP.Text = apellidoc
                                    frmPasaje.lblDNIP.Text = dnic
                                    frmPasaje.lblNombreC2P.Text = nombrec
                                    frmPasaje.lblApellido2P.Text = apellidoc
                                    frmPasaje.lblDNI2P.Text = dnic
                                    frmPasaje.lblDesde2P.Text = desdepasaje
                                    frmPasaje.lblHasta2P.Text = hastapasaje
                                    frmPasaje.lblVuelo2P.Text = vuelopasaje
                                    frmPasaje.lblFecha2P.Text = fpasaje

                                    Me.Hide()
                                    frmPasaje.Show()


                                Else
                                    frmPasaje.lblClaseP.Text = clasepasaje
                                    frmPasaje.lblHoraP.Text = horapasaje
                                    frmPasaje.lblVueloP.Text = vuelopasaje
                                    frmPasaje.lblFechaP.Text = fpasaje
                                    frmPasaje.lblDesdeP.Text = desdepasaje
                                    frmPasaje.lblHastaP.Text = hastapasaje
                                    frmPasaje.lblNombreCP.Text = nombrec
                                    frmPasaje.lblApellidoP.Text = apellidoc
                                    frmPasaje.lblDNIP.Text = dnic
                                    frmPasaje.lblNombreC2P.Text = nombrec
                                    frmPasaje.lblApellido2P.Text = apellidoc
                                    frmPasaje.lblDNI2P.Text = dnic
                                    frmPasaje.lblDesde2P.Text = desdepasaje
                                    frmPasaje.lblHasta2P.Text = hastapasaje
                                    frmPasaje.lblVuelo2P.Text = vuelopasaje
                                    frmPasaje.lblFecha2P.Text = fpasaje


                                    Me.Hide()
                                    frmPasaje.Show()

                                    MsgBox("Presione Aceptar para pasar al siguiente boleto", MsgBoxStyle.Information, "Muestra de los boletos")

                                    frmPasaje.lblNombreA.Visible = True
                                    frmPasaje.lblNombreA2.Visible = True
                                    frmPasaje.lblDNIA.Visible = True
                                    frmPasaje.lblApellidoA.Visible = True
                                    frmPasaje.lblApellidoA2.Visible = True
                                    frmPasaje.lblDNIA2.Visible = True
                                    frmPasaje.lblNombreCP.Visible = False
                                    frmPasaje.lblNombreC2P.Visible = False
                                    frmPasaje.lblDNIP.Visible = False
                                    frmPasaje.lblApellidoP.Visible = False
                                    frmPasaje.lblApellido2P.Visible = False
                                    frmPasaje.lblDNI2P.Visible = False

                                    Do Until contmostrar = countp

                                        sql = "select nombre from pasajero p, pasaje pa where p.codpasaje = pa.codpasaje and  pa.codreserva = " & txtVentaReserva.Text & ""
                                        Call ejecutar(sql)
                                        rs.Read()
                                        nombreacompañantep = rs(0) 'segun visual la consulta de arriba tiene un solo valor aunque en realidad tenga mas de uno

                                        sql = "select apellido from pasajero p, pasaje pa where p.codpasaje = pa.codpasaje and  pa.codreserva = " & txtVentaReserva.Text & ""
                                        Call ejecutar(sql)
                                        rs.Read()
                                        apellidoacompañantep = rs(0)

                                        sql = "select dni from pasajero p, pasaje pa where p.codpasaje = pa.codpasaje and  pa.codreserva = " & txtVentaReserva.Text & ""
                                        Call ejecutar(sql)
                                        rs.Read()
                                        dniacompañantep = rs(0)

                                        frmPasaje.lblNombreA.Text = nombreacompañantep
                                        frmPasaje.lblNombreA2.Text = nombreacompañantep
                                        frmPasaje.lblApellidoA.Text = apellidoacompañantep
                                        frmPasaje.lblApellidoA2.Text = apellidoacompañantep
                                        frmPasaje.lblDNIA.Text = dniacompañantep
                                        frmPasaje.lblDNIA2.Text = dniacompañantep

                                        contmostrar = contmostrar + 1

                                        Me.Hide()
                                        frmPasaje.Show()
                                        MsgBox("Presione Aceptar para pasar al siguiente boleto", MsgBoxStyle.Information, "Muestra de los boletos")

                                    Loop

                                End If

                            Else

                                MsgBox("El cliente no acepto el monto restante para realizar la venta, por lo que no se pudo efectuar el pago", MsgBoxStyle.Critical, "Monto rechazado")
                                Me.Close()
                                frmInicio.Show()
                            End If

                        Else

                            sql = "select cantpersonas from reserva where codreserva = " & txtVentaReserva.Text & ""
                            Call ejecutar(sql)
                            rs.Read()
                            cantpersonas = rs(0)

                            sql = "select coddestino from vuelo v, reserva r where v.nrovuelo = r.nrovuelo and r.codreserva = " & txtVentaReserva.Text & ""
                            Call ejecutar(sql)
                            rs.Read()
                            codigod = rs(0)

                            sql = "select precioprimeraclase from preciodestino where coddestino = " & codigod & ""
                            Call ejecutar(sql)
                            rs.Read()
                            precioviajeP = rs(0)

                            precioviajeP = precioviajeP * cantpersonas

                            descuentoP = (precioviajeP * 10) / 100

                            precioreservaP = precioviajeP - descuentoP

                            If MsgBox("El precio que debe pagar para poder realizar la venta es de $" & precioreservaP & ". ¿Acepta pagar este monto?", MsgBoxStyle.YesNo, "Monto restante para la venta") = MsgBoxResult.Yes Then

                                MsgBox("El cliente acpeta pagar el resto de la venta, se procedera a realizar la venta del pasaje", MsgBoxStyle.Information, "Monto aceptado")

                                Do Until contventa = (cantpersonas + 1)

                                    sql = "select max(codventa)+1 from ventapasaje"
                                    Call ejecutar(sql)
                                    rs.Read()
                                    maxventa = rs(0)

                                    sql = "select codpasaje from pasaje where codreserva = " & txtVentaReserva.Text & ""
                                    Call ejecutar(sql)
                                    rs.Read()
                                    pasajeventa = rs(0)

                                    sql = "insert into ventapasaje values(" & maxventa & ", '" & txtVentaReserva.Text & "', " & pasajeventa & ", " & precioreservaP & ")"
                                    Call ejecutar(sql)
                                    contventa = contventa + 1

                                Loop

                                MsgBox("Se ha realizado la venta del pasaje con exito, a continuacion se procedera a mostrar su pasaje", MsgBoxStyle.Information, "Venta realizada")

                                sql = "select count(codpasajero) from pasajero where codpasaje in(select codpasaje from pasaje where codreserva = '" & txtVentaReserva.Text & "')"
                                Call ejecutar(sql)
                                rs.Read()
                                countp = rs(0)

                                If countp = 0 Then

                                    frmPasaje.lblClaseP.Text = clasepasaje
                                    frmPasaje.lblHoraP.Text = horapasaje
                                    frmPasaje.lblVueloP.Text = vuelopasaje
                                    frmPasaje.lblFechaP.Text = fpasaje
                                    frmPasaje.lblDesdeP.Text = desdepasaje
                                    frmPasaje.lblHastaP.Text = hastapasaje
                                    frmPasaje.lblNombreCP.Text = nombrec
                                    frmPasaje.lblApellidoP.Text = apellidoc
                                    frmPasaje.lblDNIP.Text = dnic
                                    frmPasaje.lblNombreC2P.Text = nombrec
                                    frmPasaje.lblApellido2P.Text = apellidoc
                                    frmPasaje.lblDNI2P.Text = dnic
                                    frmPasaje.lblDesde2P.Text = desdepasaje
                                    frmPasaje.lblHasta2P.Text = hastapasaje
                                    frmPasaje.lblVuelo2P.Text = vuelopasaje
                                    frmPasaje.lblFecha2P.Text = fpasaje

                                    Me.Hide()
                                    frmPasaje.Show()


                                Else
                                    frmPasaje.lblClaseP.Text = clasepasaje
                                    frmPasaje.lblHoraP.Text = horapasaje
                                    frmPasaje.lblVueloP.Text = vuelopasaje
                                    frmPasaje.lblFechaP.Text = fpasaje
                                    frmPasaje.lblDesdeP.Text = desdepasaje
                                    frmPasaje.lblHastaP.Text = hastapasaje
                                    frmPasaje.lblNombreCP.Text = nombrec
                                    frmPasaje.lblApellidoP.Text = apellidoc
                                    frmPasaje.lblDNIP.Text = dnic
                                    frmPasaje.lblNombreC2P.Text = nombrec
                                    frmPasaje.lblApellido2P.Text = apellidoc
                                    frmPasaje.lblDNI2P.Text = dnic
                                    frmPasaje.lblDesde2P.Text = desdepasaje
                                    frmPasaje.lblHasta2P.Text = hastapasaje
                                    frmPasaje.lblVuelo2P.Text = vuelopasaje
                                    frmPasaje.lblFecha2P.Text = fpasaje


                                    Me.Hide()
                                    frmPasaje.Show()

                                    MsgBox("Presione Aceptar para pasar al siguiente boleto", MsgBoxStyle.Information, "Muestra de los boletos")

                                    frmPasaje.lblNombreA.Visible = True
                                    frmPasaje.lblNombreA2.Visible = True
                                    frmPasaje.lblDNIA.Visible = True
                                    frmPasaje.lblApellidoA.Visible = True
                                    frmPasaje.lblApellidoA2.Visible = True
                                    frmPasaje.lblDNIA2.Visible = True
                                    frmPasaje.lblNombreCP.Visible = False
                                    frmPasaje.lblNombreC2P.Visible = False
                                    frmPasaje.lblDNIP.Visible = False
                                    frmPasaje.lblApellidoP.Visible = False
                                    frmPasaje.lblApellido2P.Visible = False
                                    frmPasaje.lblDNI2P.Visible = False

                                    Do Until contmostrar = countp

                                        sql = "select nombre from pasajero p, pasaje pa where p.codpasaje = pa.codpasaje and  pa.codreserva = " & txtVentaReserva.Text & ""
                                        Call ejecutar(sql)
                                        rs.Read()
                                        nombreacompañantep = rs(0) 'segun visual la consulta de arriba tiene un solo valor aunque en realidad tenga mas de uno

                                        sql = "select apellido from pasajero p, pasaje pa where p.codpasaje = pa.codpasaje and  pa.codreserva = " & txtVentaReserva.Text & ""
                                        Call ejecutar(sql)
                                        rs.Read()
                                        apellidoacompañantep = rs(0)

                                        sql = "select dni from pasajero p, pasaje pa where p.codpasaje = pa.codpasaje and  pa.codreserva = " & txtVentaReserva.Text & ""
                                        Call ejecutar(sql)
                                        rs.Read()
                                        dniacompañantep = rs(0)

                                        frmPasaje.lblNombreA.Text = nombreacompañantep
                                        frmPasaje.lblNombreA2.Text = nombreacompañantep
                                        frmPasaje.lblApellidoA.Text = apellidoacompañantep
                                        frmPasaje.lblApellidoA2.Text = apellidoacompañantep
                                        frmPasaje.lblDNIA.Text = dniacompañantep
                                        frmPasaje.lblDNIA2.Text = dniacompañantep

                                        contmostrar = contmostrar + 1

                                        Me.Hide()
                                        frmPasaje.Show()
                                        MsgBox("Presione Aceptar para pasar al siguiente boleto", MsgBoxStyle.Information, "Muestra de los boletos")

                                    Loop

                                End If

                            Else

                                MsgBox("El cliente no acepto el monto restante para realizar la venta, por lo que no se pudo efectuar el pago", MsgBoxStyle.Critical, "Monto rechazado")
                                Me.Close()
                                frmInicio.Show()
                            End If

                        End If
                    End If

                End If
            End If
        End If

    End Sub

    Private Sub chkCodigoOlvidado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCodigoOlvidado.CheckedChanged

        If chkCodigoOlvidado.Checked = True Then

            gbxCodigoOlvidado.Visible = True
            btnIngresarCodigo.Enabled = False
            txtVentaReserva.Enabled = False

        Else

            gbxCodigoOlvidado.Visible = False
            btnIngresarCodigo.Enabled = True
            txtVentaReserva.Enabled = True
            txtDNIVenta.Clear()

        End If

    End Sub

    Private Sub btnIngresarDNI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresarDNI.Click

        If txtDNIVenta.Text = "" Then

            MsgBox("Complete los campos vacios para poder continuar", MsgBoxStyle.Critical, "Campos incompletos")

        Else

            If Not IsNumeric(txtDNIVenta.Text) Then

                MsgBox("No puede ingresar letras en un campo que solo pide numeros", MsgBoxStyle.Critical, "Tipo de dato no valido")
                txtDNIVenta.Clear()
            Else

                sql = "select count(codcliente) from cliente where dni = '" & txtDNIVenta.Text & "'"
                Call ejecutar(sql)
                rs.Read()
                countc = rs(0)

                If countc = 0 Then

                    MsgBox("No existe un cliente con ese DNI", MsgBoxStyle.Exclamation, "Cliente inexistente")
                Else

                    sql = "select count(distinct(p.codreserva)) from cliente c, reserva r, pasaje p,ventapasaje vp where c.codcliente = r.codcliente and r.codreserva = p.codreserva and r.codreserva!=vp.codreserva and c.dni = '" & txtDNIVenta.Text & "' and p.codreserva not in(select codreserva from ventapasaje)"
                    Call ejecutar(sql)
                    rs.Read()
                    contadorReserva = rs(0)

                    sql = "select distinct(p.codreserva) from cliente c, reserva r, pasaje p, ventapasaje vp where c.codcliente = r.codcliente and r.codreserva = p.codreserva and r.codreserva!=vp.codreserva and c.dni = '" & txtDNIVenta.Text & "' and p.codreserva not in(select codreserva from ventapasaje)"
                    Call ejecutar(sql)
                    rs.Read()
                    codigorecuperado = rs(0)

                    If contadorReserva = 0 Then

                        MsgBox("No existe una reserva para ese DNI", MsgBoxStyle.Critical, "Reserva inexistente")
                    Else

                        Do Until mostrar = contadorReserva

                            sql = "select pais, ciudad from destino d, vuelo v, reserva r where d.coddestino = v.coddestino and v.nrovuelo = r.nrovuelo and r.codreserva = " & codigorecuperado & ""
                            Call ejecutar(sql)
                            rs.Read()
                            pais = rs(0)
                            ciudad = rs(1)
                            MsgBox("La reserva existe, el numero de reserva es " & codigorecuperado & " (este numero de reserva pertenece al destino hacia " & pais & ", " & ciudad & ")", MsgBoxStyle.Information, "Reserva existente")
                            mostrar = mostrar + 1
                        Loop

                        chkCodigoOlvidado.Checked = False
                        txtVentaReserva.Enabled = True
                        btnIngresarCodigo.Enabled = True
                        txtDNIVenta.Clear()
                        gbxCodigoOlvidado.Visible = False

                    End If

                    End If

                End If

            End If

    End Sub

    Private Sub frmVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAtrasV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtrasV.Click

        If MsgBox("¿Esta seguro que desea volver? Todos los datos ingresados no podran recuperarse", MsgBoxStyle.YesNo, "Volver atras") = MsgBoxResult.Yes Then

            Me.Close()
            frmInicio.Show()
        End If

    End Sub

End Class