create database contaBancaria;

use contaBancaria;

CREATE table conta(
id INT NOT NULL primary key auto_increment unique,
saldo varchar(7),
numConta varchar(10) null unique);


CREATE TABLE cliente(
idCliente int Not null primary key auto_increment unique,
nomeCliente varchar(50),
senha varchar(20) unique,
idConta int,
FOREIGN key(idConta) references conta(id)
);

insert into conta (saldo,numConta)values("250.00","1100");
select * from conta;
insert into cliente(nomeCliente,senha,idConta)values("carlos","2050",1);
select senha from cliente  where senha=2050;

drop table cliente;
drop table conta;