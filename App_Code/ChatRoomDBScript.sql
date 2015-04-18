create database ChatRoomDB;
go;

use ChatRoomDB;
go;

create table Usuarios (
	IDUsuario int unique identity(1,1) not null,
	Nombre nvarchar(30) not null,
	Email nvarchar(30) not null,
	Passwrd nvarchar(10) not null,
	Rango char(1) not null default '0',
	constraint PK_Usuarios primary key (IDUsuario),
	constraint CK_Usuarios_Rango check (Rango like '[0,1]')
);
go;

create table Salas (
	IDSala int unique identity(1,1) not null,
	IdCreador int not null,
	Nombre nvarchar(30) not null,
	Passwrd nvarchar(30),
	FechaCreacion datetime not null
	constraint FK_Salas_Creador foreign key(IdCreador)
		references Usuarios(IDUsuario) on update cascade
);
go;

create table Mensajes (
	IDMensaje int unique identity(1,1) not null,
	NumeroMensaje int not null default 0,
	IdUsuario int not null,
	IdSala int not null,
	FechaHora datetime not null default getdate(),
	Mensaje nvarchar(255) not null
	constraint PK_Mensajes primary key(IDMensaje),
	constraint FK_Mensajes_IdUsuario foreign key(IdUsuario)
		references Usuarios(IDUsuario) on update cascade,
	constraint FK_Mensajes_IdSala foreign key(IdSala)
		references Salas(IDSala) on delete cascade on update cascade
);

create table Favoritos (
	IdUsuario int not null,
	IdSala int not null,
	constraint PK_Favoritos primary key (IdUsuario, IdSala),
	constraint FK_Favoritos_IdUsuario foreign key(IdUsuario)
		references Usuarios(IDUsuario) on delete cascade on update cascade,
	constraint FK_Favoritos_IdSala foreign key(IdSala)
		references Salas(IDUsuario) on delete cascade on update cascade
);
go;