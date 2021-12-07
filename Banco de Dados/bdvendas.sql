create database bdvendas;
 
use bdvendas;
 
create table TB_CLIENTES(
TB_CLIENTE_ID int primary key auto_increment not null,
TB_CLIENTE_NOME varchar(100),
TB_CLIENTE_RG varchar(30),
TB_CLIENTE_CPF varchar(20),
TB_CLIENTE_EMAIL varchar(200),
TB_CLIENTE_TELEFONE varchar(30),
TB_CLIENTE_CELULAR varchar(30),
TB_CLIENTE_CEP varchar(100),
TB_CLIENTE_ENDERECO varchar(255),
TB_CLIENTE_NUMERO int,
TB_CLIENTE_COMPLEMENTO varchar(200),
TB_CLIENTE_BAIRRO varchar(100),
TB_CLIENTE_CIDADE varchar(100),
TB_CLIENTE_ESTADO varchar(2)
);
 
create table TB_FORNECEDORES(
TB_FORNECEDORES_ID int primary key auto_increment not null,
TB_FORNECEDORES_NOME varchar(100),
TB_FORNECEDORES_CNPJ varchar(100),
TB_FORNECEDORES_EMAIL varchar(200),
TB_FORNECEDORES_TELEFONE varchar(30),
TB_FORNECEDORES_CELULAR varchar(30),
TB_FORNECEDORES_CEP varchar(100),
TB_FORNECEDORES_ENDERECO varchar(255),
TB_FORNECEDORES_NUMERO int,
TB_FORNECEDORES_COMPLEMENTO varchar(200),
TB_FORNECEDORES_BAIRRO varchar(100),
TB_FORNECEDORES_CIDADE varchar(100),
TB_FORNECEDORES_ESTADO varchar(2)
);
 
create table TB_FUNCIONARIOS(
TB_FUNCIONARIOS_ID int primary key auto_increment not null,
TB_FUNCIONARIOS_NOME varchar(100),
TB_FUNCIONARIOS_RG varchar(30),
TB_FUNCIONARIOS_CPF varchar(20),
TB_FUNCIONARIOS_EMAIL varchar(200),
TB_FUNCIONARIOS_SENHA varchar(10),
TB_FUNCIONARIOS_CARGO varchar(100),
TB_FUNCIONARIOS_NIVEL_ACESSO varchar(50),
TB_FUNCIONARIOS_TELEFONE varchar(30),
TB_FUNCIONARIOS_CELULAR varchar(30),
TB_FUNCIONARIOS_CEP varchar(100),
TB_FUNCIONARIOS_ENDERECO varchar(255),
TB_FUNCIONARIOS_NUMERO int,
TB_FUNCIONARIOS_COMPLEMENTO varchar(200),
TB_FUNCIONARIOS_BAIRRO varchar(100),
TB_FUNCIONARIOS_CIDADE varchar(100),
TB_FUNCIONARIOS_ESTADO varchar(2)
);
 
create table TB_PRODUTOS (
TB_PRODUTOS_ID int auto_increment primary key not null,
TB_PRODUTOS_DESCRICAO varchar(100),
TB_PRODUTOS_PRECO decimal (10,2),
TB_PRODUTOS_QTD_ESTOQUE int,
TB_PRODUTOS_FOR_ID int
);
 
create table TB_VENDAS (
 
TB_VENDAS_ID int auto_increment not null primary key,
TB_CLIENTE_ID int,
TB_VENDAS_DATA_VENDA datetime,
TB_VENDAS_TOTAL_VENDA decimal (10,2),
TB_VENDAS_OBSERVACOES text,
 
FOREIGN KEY (TB_CLIENTE_ID) REFERENCES TB_CLIENTES(TB_CLIENTE_ID)
);
 
create table TB_ITENSVENDAS (
TB_ITENSVENDAS_ID int primary key auto_increment not null,
TB_VENDAS_ID int,
TB_PRODUTOS_ID int,
TB_ITENSVENDAS_QTD int,
TB_ITENSVENDAS_SUBTOTAL decimal(10,2),
 
FOREIGN KEY (TB_VENDAS_ID) REFERENCES TB_VENDAS(TB_VENDAS_ID),
FOREIGN KEY (TB_PRODUTOS_ID) REFERENCES TB_PRODUTOS(TB_PRODUTOS_ID)
);

insert into tb_funcionarios 
(tb_funcionarios_nome, tb_funcionarios_email, tb_funcionarios_senha, 
TB_FUNCIONARIOS_NIVEL_ACESSO, TB_FUNCIONARIOS_NUMERO) 
values 
('AdmB', 'adm@admB', 'admB', 'AdministradorB', 9),
('AdmA','adm@admA', 'admA', 'AdministradorA', 19),
('AdmC','adm@admC', 'admC', 'AdministradorC', 29),
('AdmD','adm@admD', 'admD', 'AdministradorD', 39),
('User','user@user', 'user', 'Usuário', 49);