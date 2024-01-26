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
datumrodenje datetime,
placa decimal,
invalid bit
);

create table slike(
sifra int not null primary key identity(1,1),
zaposlenik int,
rednibroj int,
putanja bit
);

alter table slike add foreign key (zaposlenik) references zaposlenici;

select *from zaposlenici;

insert into zaposlenici (ime,prezime,placa,invalid) values
--1
('Karla','Kraljik',1500.55,0),
--2
('Goran','Bakic',2000.65,0),
--3
('Petra','Kraljik',1230.58,0);

select * from slike;

insert into slike (zaposlenik,rednibroj,putanja)values
(1,1,0),
(1,2,0),
(2,3,0),
(2,4,0),
(2,5,0),
(2,6,0),
(3,7,0),
(3,8,0);

