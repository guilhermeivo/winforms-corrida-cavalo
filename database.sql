create database cavalo

use cavalo 

create table apostador(
    idapostador int identity primary key not null,
    nome char(100),
    telefone char(11),
    email char(100)
)

create table statu(
    idstatus int primary key not null,
    descr char(200)
)

create table cavalo (
    idcavalo int identity primary key not null,
    dono char (100),
    nome char (100),
    idade int,
    idstatus int foreign key references statu(idstatus)
)

create table corrida(
    idcorrida int identity primary key not null,
    dt_corrida date,
    local_ char(30),
    distancia char(9)
)

create table aposta(
    idapostador int not null,
    idcavalo int not null,
    idcorrida int not null,
    valor money default 0.0,
    foreign key (idapostador) references apostador(idapostador),
    foreign key (idcavalo) references cavalo(idcavalo),
    foreign key (idcorrida) references corrida(idcorrida)
)





