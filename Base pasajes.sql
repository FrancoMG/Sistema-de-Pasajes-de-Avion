drop database if exists Viajes;
create database Viajes;
use Viajes;

Create table Destino(
CodDestino int,
Pais varchar(30), 
Ciudad varchar(30),    
CONSTRAINT PK_Destino PRIMARY KEY (CodDestino)
)Engine=InnoDB;

insert into Destino values
(100, "Japon", "Osaka"),
(101, "Japon", "Tokio"),
(102, "Estados Unidos", "Miami"),
(103, "Estados Unidos", "Los Ángeles"),
(104, "Estados Unidos", "Nueva York"),
(105, "Estados Unidos", "Washington D.C."),
(106, "Italia", "Turín"),
(107, "Italia", "Roma"),
(108, "Italia", "Venecia"),
(109, "Italia", "Milán"),
(110, "España", "Madrid"),
(111, "España", "Barcelona"),
(112, "Inglaterra", "Londres"),
(113, "Inglaterra", "Manchester"),
(114, "Inglaterra", "Liverpool"),
(115, "Inglaterra", "Oxford"),
(116, "Alemania", "Berlín"),
(117, "Alemania", "Múnich"),
(118, "Alemania", "Hamburgo"),
(119, "Mexico", "Ciudad de Mexico"),
(120, "Mexico", "Monterrey"),
(121, "Mexico", "Guadalajara");

create table PrecioDestino(
CodPD int,
CodDestino int,
PrecioClaseTurista int,
PrecioPrimeraClase int,
TipoAvion varchar(20),
CONSTRAINT PK_CodPD PRIMARY KEY(CodPD),
CONSTRAINT FK_PrecioDestino_Destino FOREIGN KEY (CodDestino) REFERENCES Destino(CodDestino)
)Engine=InnoDB; 

insert into PrecioDestino values
(200, 112, 15000, 25000, "Boeing 737-700NG"),
(201, 109, 15000, 30000, "Airbus A340-300"),
(202, 103, 12000, 23000, "Boeing 737-700NG"),
(203, 101, 14000, 27000, "Airbus A340-300"),
(204, 119, 16000, 25000, "Airbus A340-300"),
(205, 106, 17000, 24000, "Boeing 737-700NG"),
(206, 121, 15000, 22000, "Airbus A340-300"),
(207, 118, 12000, 21000, "Airbus A340-300"),
(208, 113, 22000, 40000, "Airbus A340-300"),
(209, 110, 22000, 30000, "Boeing 737-700NG"),
(210, 102, 21000, 45000, "Boeing 737-700NG"),
(211, 105, 23000, 31000, "Airbus A340-300"),
(212, 116, 24000, 43000, "Airbus A340-300"),
(213, 114, 23000, 33000, "Boeing 737-700NG"),
(214, 107, 26000, 37000, "Boeing 737-700NG"),
(215, 104, 22000, 31000, "Boeing 737-700NG"),
(216, 108, 24000, 40000, "Boeing 737-700NG"),
(217, 115, 27000, 43000, "Airbus A340-300"),
(218, 120, 21000, 33000, "Airbus A340-300"),
(219, 111, 22000, 30000, "Boeing 737-700NG"),
(220, 117, 24000, 43000, "Airbus A340-300"),
(221, 100, 26000, 46000, "Airbus A340-300");

create table Cliente(
CodCliente int,
Nombre varchar(30),
Apellido varchar(40),
DNI varchar(8),
Telefono varchar(20),
Email varchar(100),
CONSTRAINT PK_CodCliente PRIMARY KEY(CodCliente)
)Engine=InnoDB;

insert into Cliente values
(300, "Juan Fernando", "Quintero", "23563879", "1523784350", "juanfer_10@gmail.com"),
(301, "Exequiel", "Palacios", "25608333", "47121465", "exepela15@gmail.com"),
(302, "Lucas", "Pratto", "36100205", "42153309", "ositocariñoso27@gmail.com"),
(303, "Rafael Santos", "Borré", "28753951", "47114568", "rafa19@gmail.com"),
(304, "Marcelo Daniel", "Gallardo", "29888486", "20713406", "muñedelmillo@gmail.com");

create table Avion(
CodAvion int,
TipoAvion varchar(20),
CantPlazasTurista int,  
CantPlazasPrimeraClase int,
CONSTRAINT PK_Avion PRIMARY KEY(CodAvion)
)Engine=InnoDB;

insert into Avion values
(400, "Boeing 737-700NG", 131, 31),
(401, "Airbus A340-300", 225, 50),
(402, "Airbus A340-300", 200, 75),
(403, "Boeing 737-700NG", 122, 40);

create table Vuelo(
NroVuelo int,
CodDestino int,
CodAvion int,
Fecha date,
Horario time,
CONSTRAINT PK_NroVuelo PRIMARY KEY (NroVuelo),
CONSTRAINT FK_Vuelo_Destino FOREIGN KEY (CodDestino) REFERENCES Destino(CodDestino),
CONSTRAINT FK_Vuelo_Avion FOREIGN KEY (CodAvion) REFERENCES Avion(CodAvion)
)Engine=InnoDB;

insert into Vuelo values
(500, 112, 400, "2019/04/27", "10:30"),
(501, 119, 403, "2019/04/21", "11:30"),
(502, 101, 402, "2019/04/12", "15:30");

create table Agencia(
CodAgencia int,
Nombre varchar(30),
Email varchar(100),
CONSTRAINT PK_Agencia PRIMARY KEY (CodAgencia)
)Engine=InnoDB;

insert into Agencia values
(600, "despegar.com", "despegar@gmail.com"),
(601, "Almundo", "Almundo@gmail.com");

/* ver en reserva si es ida y vuelta o solo ida y en base a eso ver las fechas de inicio y fin */

create table Reserva(
CodReserva int,
NroVuelo int,
CodCliente int,
CodAgencia int,
FechaEmision date,
FechaInicio date,
FechaFinal date,
CantPersonas int,
Clase varchar(20),
Costo int,
CONSTRAINT PK_CodReserva PRIMARY KEY (CodReserva),
CONSTRAINT FK_Reserva_Vuelo FOREIGN KEY (NroVuelo) REFERENCES Vuelo(NroVuelo),
CONSTRAINT FK_Reserva_Cliente FOREIGN KEY (CodCliente) REFERENCES Cliente(CodCliente),
CONSTRAINT FK_Reserva_Agencia FOREIGN KEY (CodAgencia) REFERENCES Agencia(CodAgencia)
)Engine=InnoDB;

insert into Reserva values
(700, 501, 303, 600, "2019/03/10", "2019/04/01", null, 1 ,"Turista", 1000),
(701, 500, 300, 600, "2019/03/07", "2019/04/15", "2019/04/29", 1, "Primera clase", 2500),
(702, 502, 302, 601, "2019/03/03", "2019/03/10", "2019/03/18", 1, "Primera clase", 2700);

create table Pasaje(
CodPasaje int,
CodReserva int,
CONSTRAINT PK_CodPasaje PRIMARY KEY (CodPasaje),
CONSTRAINT FK_Pasaje_Reserva FOREIGN KEY (CodReserva) REFERENCES Reserva(CodReserva)
)Engine=InnoDB;

insert into Pasaje values
(800, 700),
(801, 701),
(802, 702);

create table VentaPasaje(
CodVenta int,
CodReserva int,
CodPasaje int,
MontoFinal int,
CONSTRAINT PK_CodVenta PRIMARY KEY (CodVenta),
CONSTRAINT FK_VentaPasaje_Reserva FOREIGN KEY (CodReserva) REFERENCES Reserva(CodReserva),
CONSTRAINT FK_VentaPasaje_Pasaje FOREIGN KEY (CodPasaje) REFERENCES Pasaje(CodPasaje)
)Engine = InnoDB;

insert into VentaPasaje values
(900, 700, 800, 9000),
(901, 701, 801, 22500),
(902, 702, 802, 24300);

create table Pasajero(
CodPasajero int auto_increment,
CodCliente int,
CodPasaje int, 
Nombre varchar(20),
Apellido varchar(20),
DNI varchar(8),
CONSTRAINT PK_CodPasajero PRIMARY KEY (CodPasajero),
CONSTRAINT FK_Pasajero_Cliente FOREIGN KEY (CodCliente) REFERENCES Cliente(CodCliente),
CONSTRAINT FK_Pasajero_Pasaje FOREIGN KEY (CodPasaje) REFERENCES Pasaje(CodPasaje)
)Engine = InnoDB;

