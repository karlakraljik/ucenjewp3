﻿
select * from smjerovi 
where sifra=1;

-- mijenjanje samo jedne kolone na samo jednom redu
update smjerovi set naziv='C# programiranje'
where sifra=1;

-- mjenjanje vrijednosti više kolona odjednom
update smjerovi set trajanje=300, cijena=2000
where sifra=2;

-- Smjer čšćđž ČŠĆĐŽ promjeniti na Serviser koji traje 120 sati
-- i cijena mu je 1500 EURA.

update smjerovi set naziv='Serviser', trajanje=120, cijena=1500
where sifra=3;


select * from smjerovi;

update smjerovi set cijena=cijena*1.2;

update smjerovi set cijena=cijena*0.8;

update smjerovi set cijena=cijena-100;

 select *from polaznici;

 update polaznici set oib='00000000001',brojugovora='12/2023'
 where sifra=18;

update polaznici set oib= '         ' , brojugovora= '    '
where sifra=19

update polaznici set oib= null, brojugovora=null
where sifra=19;
