Delimiter $$
 
Drop procedure if exists ListarProdutos$$
Create procedure ListarProdutos() 
begin
	Select cd_produto,nm_produto,concat('R$',vl_produto)
	from produto;
end$$
 
Drop procedure if exists MaiorCodigo$$
Create procedure MaiorCodigo() 
begin
	Select (max(cd_produto)+1) as ProximoCodigo
	from produto;
end$$
 
Drop procedure if exists AdicionarProduto$$
Create procedure AdicionarProduto(pCodigo int,pNome varchar(200), pValor decimal(10,2))
begin
	Insert into produto values (pCodigo, pNome, pValor);
end$$

Drop procedure if exists ConsultarProduto$$
Create procedure ConsultarProduto(pCodigo int)
begin
	Select cd_produto, nm_produto,vl_produto
	from produto where cd_produto =  pCodigo;
end$$

Drop procedure if exists EditarProduto$$
Create procedure EditarProduto(pCodigo int,pNome varchar(200), pValor decimal(10,2))
begin
	Update produto set nm_produto = pNome , vl_produto = pValor where cd_produto = pCodigo;
end$$

Drop procedure if exists ExcluirProduto$$
Create procedure ExcluirProduto(pCodigo int)
begin
	Delete from produto where cd_produto = pCodigo;
end$$
 
Delimiter ;
call ListarProdutos;
call MaiorCodigo;