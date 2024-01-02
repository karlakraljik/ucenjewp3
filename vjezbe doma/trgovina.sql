use master;
go
drop database if exists trgovina;
create database trgovina;
go
use trgovina;
go
create table prodavaci(
sifra int not null primary key identity (1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
kupac int
);

create table kupci(
sifra int not null primary key identity(1,1),
ime varchar(50),
prezime varchar(50),
);


create table proizvodi(
sifra int not null primary key identity(1,1),
naziv varchar(30) not null,
cijena decimal not null,
kupac int
);

create table racuni(
sifra int not null primary key identity(1,1),
datum datetime,
kupac int,
);

alter table prodavaci add foreign key (kupac) references kupci;
alter table racuni add foreign key (kupac) references kupci;
alter table proizvodi  add foreign key (kupac)references kupci;

select *from prodavaci;
insert into prodavaci (ime,prezime) values
--1
('Marko','Maric'),
--2
('Klara','Muric');

insert into kupci(ime,prezime) values
('Mirela','Klaric'),
('Laura','Ivic');

insert into proizvodi (naziv,cijena) values
--1
('salama cekin',1.85),
--2
('margo',2.10);

insert into racuni (datum) values
(29-11-2024),
(3-12-2023);
