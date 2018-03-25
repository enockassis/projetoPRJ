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
select nome,valor,tipo,data from cliente inner join movimentacao on id_cliente=id_mov where senha =1010 order by(data);

insert into cliente (nome,senha)values("teste1",1010);
insert into cliente (nome,senha)values("pdr1",1111);
insert into cliente (nome,senha)values("pdr2",1313);
insert into cliente (nome,senha)values("pdr5",1414);
insert into cliente (nome,senha)values("pdr3",1515);
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

