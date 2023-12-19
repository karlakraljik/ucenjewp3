use master;
go
drop database if exists tvrtka;
go 
create database tvrtka collate Croatian_CI_AS;
go
use tvrtka;
create table zaposlenici(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
datumrodenja datetime,
placa decimal(18,2),
invalid bit
);

create table slike(
sifra int not null primary key identity(1,1),
zaposlenik int,
rednibroj int,
putanja varchar(50)
);

alter table slike add foreign key (zaposlenik) references zaposlenici(sifra);

select * from zaposlenici;

insert into zaposlenici (ime, prezime,placa,invalid)
values
--1 
('Karla','Kraljik', 1500.33,0),
-- 2
('Goran','Bakic', 1500.34,0),
--3
('Petra','Kraljik', 1400.22,0);


insert into slike (zaposlenik,rednibroj) values

(1,1),
(1,2),
(2,3),
(2,4),
(3,5),
(3,6);



select* from slike;

use master;
go
drop database if exists webshop;
go 
create database webshop collate Croatian_CI_AS;
go
use webshop;

create table proizvodi(
sifra int not null primary key identity(1,1),
naziv varchar(20) not null,
datumnabave datetime,
cijena decimal,
aktivan bit
);

create table stavke(
racun int ,
proizvod int,
kolicina decimal (18,2)
);

create table racuni (
sifra int not null primary key identity(1,1),
datum datetime,
kupac int,
status bit
);

create table kupci(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
ulica varchar(25),
mjesto varchar(40)
);

alter table stavke add foreign key (proizvod) references proizvodi(sifra);
alter table stavke add foreign key (racun) references racuni(sifra);
alter table racuni add foreign key (kupac) references kupci(sifra);

