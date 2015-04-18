create table tbUsuarios (
	Id int unique identity(1,1) not null,
	Nombre nvarchar(30) not null,
	Email nvarchar(30) not null,
	Passwrd nvarchar(10) not null,
	Rango int not null default 1,
	constraint PK_tbUsuarios_Id primary key (Id)
);

create table tbSalas (
	Id int unique identity(1,1) not null,
	Creador int not null,
	Nombre nvarchar(30) not null,
	Passwrd nvarchar(30),
	FechaCreacion datetime not null
	constraint FK_tbSalas_Creador foreign key(Creador)
		references tbUsuarios(Id)
);

create table tbMensajes (
	Id int unique identity(1,1) not null,
	IdUsuario int not null,
	IdSala int not null,
	FechaHora datetime not null,
	Mensaje nvarchar(255) not null
	constraint PK_tbMensajes_Id primary key(Id),
	constraint FK_tbMensajes_IdUsuario foreign key(IdUsuario)
		references tbUsuarios(Id),
	constraint FK_tbMensajes_IdSala foreign key(IdSala)
		references tbSalas(Id) on delete cascade
);

create table tbFavoritos (
	IdUsuario int not null,
	IdSala int not null,
	constraint FK_tbFavoritos_IdUsuario foreign key(IdUsuario)
		references tbUsuarios(Id) on delete cascade,
	constraint FK_tbFavoritos_IdSala foreign key(IdSala)
		references tbSalas(Id) on delete cascade
);