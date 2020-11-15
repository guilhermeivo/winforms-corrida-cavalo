create database Cavalo

use Cavalo 

create table Apostador(
idApostador int identity (1,1) primary key not null,
nome char (100),
telefone char(11),
email char(100),
valor money,
)

create table tblLogin(
idLogin int identity (1,1) primary key not null,
usuario char (100),
senha char (20),
email char(100),
telefone char (10)
)

insert into tblLogin values ('admin','123','cudepia@gmail','4002-8922')
