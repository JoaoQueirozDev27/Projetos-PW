DROP SCHEMA IF EXISTS projeto_produtos;
CREATE SCHEMA projeto_produtos;
USE projeto_produtos;

CREATE TABLE produto
(
  cd_produto int,
  nm_produto varchar(200),
  vl_produto decimal(10,2),
  Constraint pk_produto PRIMARY KEY (cd_produto)
);

Insert into produto values (1, 'Coca-Cola 2L', 18.00);