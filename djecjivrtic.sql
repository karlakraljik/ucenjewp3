use master;
go
drop database if exists djecjivrtic;
go
create database djecjivrtic collate Croatian_CI_AS;
go
use djecjivrtic;
create table djeca(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
oib char(11),
skupina int
);
create table skupine(
sifra int not null primary key identity (1,1),
naziv varchar(50),
maxdjece int not null,
odgajateljica int
);

create table odgajateljice(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
oib char(11),
email varchar(100) not null,
iban varchar(20),
strucnasprema int
);
create table strucnespreme(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
titula varchar(100)
);

alter table djeca add foreign key(skupina) references skupine(sifra);
alter table skupine add foreign key(odgajateljica) references odgajateljice(sifra);
alter table odgajateljice add foreign key (strucnasprema) references strucnespreme(sifra);
