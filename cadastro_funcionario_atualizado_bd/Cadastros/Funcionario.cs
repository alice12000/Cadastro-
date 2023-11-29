using System;
using System.Security;
using System.Threading.Tasks;

namespace cadastro_funcionario_atualizado_bd
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime? DataNas { get; set; }
        public string Cpf { get; set; }
        public int Rg { get; set; }
        public string Ec { get; set; }
        public string Email { get; set; }
        public string Funcao { get; set; }
        public double Salario { get; set; }
        public string Telefone { get; set; }
       

        //parte de endereço

        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Rua { get; set; }


        public Funcionario()
        {

        }

        //adicionar double salaario
        public Funcionario(string nome,DateTime? datanas, string cpf, int rg, string ec, string email, string funcao,double salario,
        string telefone, string estado,string cidade, string rua)
        {
            this.Nome = nome;
            this.DataNas = datanas;
            this.Cpf = cpf;
            this.Rg = rg;
            this.Ec = ec;
            this.Email = email;
            this.Funcao = funcao;
            this.Salario = salario;
            this.Telefone = telefone;
            this.Estado = estado;
            this.Cidade = cidade;
            this.Rua = rua;


        }
    }
}
