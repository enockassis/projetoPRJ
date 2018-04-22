create database contaBancaria;

use contaBancaria;

CREATE table conta(
id INT NOT NULL primary key auto_increment unique,
saldo double,
numConta int not null unique);


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
insert into cliente(nomeCliente,senha,idConta)values("carlos ew",24050,4);
select senha from cliente where senha=2050;

drop table cliente;
drop table conta;