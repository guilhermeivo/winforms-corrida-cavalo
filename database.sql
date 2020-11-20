create database Cavalo
go

use Cavalo 
go

create table Apostador (
    idApostador int identity not null,
    nome char (100),
    telefone char(11),
    email char(100),
    valor money
)
go

create table Categoria (
    idCategoria int identity not null,
    descr char (200)
)
go

create table Cavalo (
    idCavalo int identity not null,
    idDono int,
    idCategoria int,
    nome char (100),
    idade int
)
go

create table CorridaCavalo (
    idCavalo int not null,
    idCorrida int not null
)
go

Create table Corrida (
    idCorrida int identity not null,
    dt_Corrida date,
    local_ char(30),
    distancia char (9)
)
go

create table Aposta (
    idApostador int not null,
    idCavalo int not null,
    idCorrida int not null,
    valor MONEY DEFAULT 0.0,
)
go

create table Dono (
    idDono int identity not null,
    nomedn char (100),
    telefone char (11),
    email char(80)
)
go

create index XDONO on Dono (idDono)
create index XCORRIDA on Corrida (idCorrida)
create index XCAVALO on Cavalo (idCavalo)
create index XAPOSTADOR on Apostador (idApostador)
go

alter table Apostador add constraint pk_apostador primary key (idApostador)
alter table Categoria add constraint pk_categoria primary key (idCategoria)
alter table Cavalo add constraint pk_cavalo primary key (idCavalo)
alter table Corrida add constraint pk_corrida primary key (idCorrida)
alter table Dono add constraint pk_Dono primary key (idDono)
go

alter table Cavalo add constraint fk_cavalo_dono foreign key (idDono) references Dono (idDono)
alter table Cavalo add constraint fk_cavalo_statu foreign key (idCategoria) references Categoria (idCategoria)
alter table CorridaCavalo add constraint fk_corridaCavalo_cavalo foreign key (idCavalo) references Cavalo (idCavalo)
alter table CorridaCavalo add constraint fk_corridaCavalo_corrida foreign key (idCorrida) references Corrida (idCorrida)
alter table Aposta add constraint fk_aposta_apostador foreign key (idApostador) references Apostador (idApostador)
alter table Aposta add constraint fk_aposta_cavalo foreign key (idCavalo) references Cavalo (idCavalo)
alter table Aposta add constraint fk_aposta_corrida foreign key (idCorrida) references Corrida (idCorrida)
go

insert into Categoria values ('Peso Pesado'), ('Peso Pena'), ('Peso Mosca')