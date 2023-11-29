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
rua_fun varchar(100),
cep_fun int
);

create table Empresa(
id_emp int primary key,
razao_emp varchar(300),
nome_fan_emp varchar(100),
site_emp varchar(300),
complemento_emp varchar(200),
dataF_emp date,
nome_res_emp varchar(200),
produto_emp varchar(100),
slogan_emp varchar(100),
estado_emp varchar(300),
cidade_emp varchar(100),
bairro_emp varchar(200),
cep_emp varchar(100),
telefone_emp varchar(100),
cnpj_emp varchar(100),
email_emp varchar(200)
);
