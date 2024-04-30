drop schema if exists BancoLogin;
create schema BancoLogin;
use BancoLogin;

create table usuario(
	nm_usuario varchar(110),
	nm_login varchar(110),
	nm_senha varchar(110),
	constraint pk_usuario primary key (nm_login)
);

insert into usuario values('Joao1','Joaozinho1','joao1231');
insert into usuario values('Joao2','Joaozinho2','joao1232');
insert into usuario values('Joao3','Joaozinho3','joao1233');
insert into usuario values('Joao4','Joaozinho4','joao1234');
insert into usuario values('Joao5','Joaozinho5','joao1235');
insert into usuario values('Joao6','Joaozinho6','joao1236');
