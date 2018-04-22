create database contaBancaria;

use contaBancaria;


 
CREATE TABLE cliente (
  id_cliente int(11) NOT NULL AUTO_INCREMENT,
  nome varchar(45) NOT NULL,
  senha int NOT NULL,
  PRIMARY KEY (id_cliente),
  UNIQUE KEY id_cliente_UNIQUE (id_cliente)
  );
  
  CREATE TABLE movimentacao (
  id_mov int(11) NOT NULL, 
  valor double NOT NULL,
  tipo char(1) NOT NULL,
  data datetime NOT NULL,
  constraint id_mov foreign key(id_mov) references cliente(id_cliente)
);
select *  from cliente;

select * from movimentacao;
 /*drop table movimentacao;
 drop table cliente;*/
select nome,valor,tipo,data from cliente inner join movimentacao on id_cliente=id_mov where senha =1010 order by(data);

update cliente set senha= 1111 where id_cliente = 7;

insert into movimentacao(id_mov,valor,tipo,data)values(1,100,"D",now());
insert into movimentacao(id_mov,valor,tipo,data)values(2,100,"D",now());
insert into movimentacao(id_mov,valor,tipo,data)values(3,100,"D",now());
insert into movimentacao(id_mov,valor,tipo,data)values(4,100,"D",now());
insert into movimentacao(id_mov,valor,tipo,data)values(5,100,"D",now());
insert into movimentacao(id_mov,valor,tipo,data)values(6,100,"D",now());
insert into movimentacao(id_mov,valor,tipo,data)values(7,100,"D",now());


insert into cliente (nome,senha)values("Lee",1212);
insert into cliente (nome,senha)values("Jose",1515);
insert into cliente (nome,senha)values("Pedro",1616);
insert into cliente (nome,senha)values("Martha",1010);
insert into cliente (nome,senha)values("Fernanda",1313);
insert into cliente (nome,senha)values("Margareth",1414);
insert into cliente (nome,senha)values("Bernardia",1515);

/*
 insert into movimentacao(id_mov,valor,tipo,data)values(1,-25,"S",now());
 select senha from cliente inner join movimentacao on id_cliente=id_mov where senha =2050;
 select * from movimentacao;
 select * from cliente;
 insert into cliente (nome,senha)values("pdr",2630);
 select senha,id_cliente from cliente  where senha = 2050;
 select senha,id_cliente from cliente inner join movimentacao on id_cliente=id_mov where senha = 2050;
 /*select sum(valor) from movimentacao join cliente on id_mov = id_cliente where id_mov =1;*/
 /*
 select senha,sum(valor) as valor from cliente inner join movimentacao on id_cliente=id_mov where senha =2050;
  drop table movimentacao;
 drop table cliente;
drop table conta;*/

