create database contaBancaria;

use contaBancaria;

CREATE table conta(
id INT NOT NULL primary key auto_increment unique,
saldo double,
numConta int null unique);


CREATE TABLE cliente(
idCliente int Not null primary key auto_increment unique,
nomeCliente varchar(50),
senha int unique,
idConta int,
FOREIGN key(idConta) references conta(id)
);
ALTER TABLE CONTA ADD COLUMN DATA DATETIME;

/*inserindo dados na conta*/
insert into conta (saldo,numConta)values("250.00","1300");
insert into conta (saldo,numConta)values("1250","14100");
insert into conta (saldo,numConta)values("2530","11200");
insert into conta (saldo,numConta)values("2520","11010");
insert into conta (saldo,numConta)values("2510","110310");
insert into conta (saldo,numConta)values("2510","110311");
/*atualizando o saldo*/
UPDATE conta set saldo= 250.000 where id =1;

/*inserindo os clientes*/
insert into cliente(nomeCliente,senha,idConta)values("carlos",106,6);
insert into cliente(nomeCliente,senha,idConta)values("pedro",10,2);
insert into cliente(nomeCliente,senha,idConta)values("camila",4040,3);
insert into cliente(nomeCliente,senha,idConta)values("viviane",5050,4);
insert into cliente(nomeCliente,senha,idConta)values("carla",5030,5);

/*alterando a senha do cliente*/
update cliente set senha= 110 where idCliente = 10;

update cliente set nomeCliente = "Ana Maria" where idCliente = 10;


select * from conta;

DELETE FROM CONTA WHERE numConta = "13";

select * from cliente;

insert into conta (saldo, numConta) values (5000, 110311);
insert into cliente (nomeCliente, senha, idConta) values ("teo2", 108, 6);
select senha from cliente  where senha=2050;

select senha from cliente join conta on idConta=id where senha=110;

drop table cliente;

drop table conta;



select * from cliente;

select senha,nome,saldo from cliente inner join conta on idConta=id where senha =104;

update cliente inner join conta on idConta=id set saldo = 1500 where senha = 2050; 
/*update TABELA_A a 
inner join TABELA_B b on a.ID_A = b.ID_B
set
a.CAMPO1 = [VALOR],
a.CAMPO2 = [VALOR],
a.CAMPO3 = [VALOR]
WHERE b.CAMPO_TABELA_B = [VALOR]*/