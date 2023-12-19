use master;
go
drop database if exists bolnica;
go
create database bolnica collate Croatian_CI_AS;
go
use bolnica;
create table doktori(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
email varchar (100) not null,
pacjent int
);
create table pacjenti(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
medicinskasestra int
);
create table medicinskesestre(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
doktor int
);

alter table doktori add foreign key(pacjent) references pacjenti(sifra);
alter table pacjenti add foreign key (medicinskasestra) references medicinskesestre(sifra);
alter table medicinskesestre add foreign key(doktor) references doktori (sifra);
