create database contabd;

use contabd;

CREATE table conta(
id INT NOT NULL primary key auto_increment unique,
saldo double,
dataS datetime,
numConta int not null unique);


alter table conta add column dataS datetime;
alter table conta add column dataD datetime;
CREATE TABLE cliente(
idCliente int Not null primary key auto_increment unique,
nomeCliente varchar(50),
senha int unique,
idConta int,
FOREIGN key(idConta) references conta(id)
);

insert into conta (saldo,numConta)values(2150.00,11010);
insert into conta (saldo,numConta)values(1250.00,11300);
insert into conta (saldo,numConta)values(2250.00,11200);
select * from conta;
select * from cliente;

insert into cliente(nomeCliente,senha,idConta)values("carlos d2",22050,2);
insert into cliente(nomeCliente,senha,idConta)values("carlos we",23050,3);
insert into cliente(nomeCliente,senha,idConta)values("carlos ew",24050,1);
select senha from cliente where senha=22050;

drop table cliente;
drop table conta;
/*alterando a senha do cliente*/
update cliente set senha= 110 where idCliente = 10;

update cliente set nomeCliente = "Ana Maria" where idCliente = 10;


select * from conta;

DELETE FROM CONTA WHERE numConta = "13";

select * from cliente;


select senha from cliente  where senha=22050;

select senha from cliente join conta on idConta=id where senha=110;

drop table cliente;

drop table conta;



select * from cliente;
select senha,saldo from cliente inner join conta on idConta=id where senha =22050;
select senha,saldo from cliente inner join conta on idConta=id where senha =23050;

update cliente inner join conta on idConta=id set saldo = 1500, dataS = now() where senha = 22050; 