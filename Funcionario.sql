create database Empresa_X2A_bd;
use Empresa_X2A_bd;

create table Funcionario(
id_fun int primary key auto_increment,
nome_fun varchar(100),
cpf_fun varchar(40),
rg_fun varchar(40),
data_fun date,
ec_fun varchar(100),
email_fun varchar(100), 
salario_fun double, 
telefone_fun varchar(100),
funcao_fun varchar(100),
estado_fun varchar(100),
cidade_fun varchar(100),
rua_fun varchar(100)
);

create table Empresa(
id_emp int primary key auto_increment,
razao_emp varchar(200),
situacao_emp varchar(100),
nome_emp varchar(300),
natureza_emp varchar(100),
porte_emp varchar(100),
capital_emp double,
regime_emp varchar(100),
telefone_emp varchar(100),
cnpj_emp varchar(100),
data_emp date,
tipo_emp varchar(100),
nomeP_emp varchar(100),
cpf_emp varchar(100),
cidade_emp varchar(100),
cep_emp int, 
uf_emp varchar(200)
);

