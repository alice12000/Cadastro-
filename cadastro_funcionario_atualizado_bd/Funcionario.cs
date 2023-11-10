using System;

using System.Threading.Tasks;

namespace cadastro_funcionario_atualizado_bd
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public DateTime DataNas { get; set; }
        public string Cpf { get; set; }
        public int Rg { get; set; }
        public string Ec { get; set; }
        public string Email { get; set; }
        public string Funcao { get; set; }
        public double Salario { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(string nome, DateTime datanas, string cpf, int rg, string ec, string email, string funcao, double salario, string telefone)
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
        }
    }
}
