create table Cuentas(
ID serial Primary key not null,
IDCliente Int ,
Fechalata varchar(50),
Nrocuenta varchar(50),
Tipocuenta varchar(50),
Saldo varchar(50),
Estado varchar(25),
NroContrato varchar(50),
Costomantenimiento varchar(50),
PromedioAcreditacion varchar(50),
Moneda varchar(50),
Estado1 varchar(50)
	
	
);
create table Movimientos(
IDmovimiento serial Primary key not null,
IDCuenta Int ,
Fechamovimiento varchar(50),
Tipomovimiento varchar(50),
Saldoanterior varchar(50),
SaldoActual varchar(50),
Montomovimiento varchar(50),
Cuentaorigen varchar(50),
Cuentadestino varchar(50),
Canal varchar(50)
	
	
);

create table Persona(
ID serial Primary key not null,
IDCiudad Int ,
Nombre varchar(50),
Apellido varchar(50),
TipoDocumento varchar(25),
NroDocumento varchar(25),
Direccion varchar(100),
Celular varchar(50),
Email varchar(50),
Estado int
);

create table Cuentas(
ID serial Primary key not null,
IDCliente Int ,
Fechalata timestamp,
Nrocuenta varchar(50),
Tipocuenta varchar(50),
Saldo decimal(18,2),
Estado varchar(25),
NroContrato varchar(50),
Costomantenimiento decimal(25,2),
PromedioAcreditacion varchar(50),
Moneda varchar(50),
Estado1 varchar(50)
	
	
);

create table Ciudad(
ID serial Primary key not null,
Ciudad varchar(50),
Departamento varchar(50),
Codigo_POSTAL int
);