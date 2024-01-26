use knjiznica;
--- dz
select a.naslov
from katalog a inner join mjesto b
on a.izdavac= b.sifra
where b.naziv= 'osijek';