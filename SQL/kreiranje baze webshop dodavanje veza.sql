use master;
go 
drop database if exists webshop;
go 
create database webshop collate Croatian_CI_AS;
go 
use webshop;

create table proizvodi(
sifra int not null primary key identity(1,1),
naziv varchar(25),
datumnabave datetime,
cijena decimal,
aktivan bit
);

create table stavke(
racun int,
proizvod int,
kolicina decimal,
cijena decimal
);

create table racuni(
sifra int primary key identity(1,1),
datum datetime,
kupac int,
satus bit
);

create table kupci(
sifra int primary key identity (1,1),
ime varchar(50),
prezime varchar(50),
ulica varchar(30),
mjesto varchar(30) 
);

alter table stavke add foreign key (proizvod) references proizvodi(sifra);
alter table stavke add foreign key (racun) references racuni(sifra);
alter table racuni add foreign key (kupac) references kupci(sifra);