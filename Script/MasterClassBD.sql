create database masterclass_f5
go

use masterclass_f5
go

create table BandasMusicales (
	id int primary key identity(1,1),
	Banda varchar(200) not null,
	Coder varchar(100) not null
)

insert into BandasMusicales (Banda, Coder)
values ('Patricio Rey y sus Redonditos de Ricota', 'Gonzalo')

select * 
from BandasMusicales

delete from BandasMusicales