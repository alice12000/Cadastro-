using Org.BouncyCastle.Pqc.Crypto.Cmce;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastro_funcionario_atualizado_bd.TELAS
{
    internal class Empresa
    {

        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string SituacaoCadastral { get; set; }
        public string NomeP { get; set; }

        public string CpfProprietario { get; set; }

        public string NaturezaJuridica { get; set; }

        public string RegimeTributario { get; set; }
        public string Tipo { get; set; }

        public string Cnpj { get; set; }

        public double CapitalSocial { get; set; }
        public DateTime? DataFundacao { get; set; }

        public string PorteEmpresa { get; set; }

        public string Uf { get; set; }

        public string Cidade { get; set; }

        public int Cep { get; set; }

        public string Telefone { get; set; }

        public Empresa()
        {

        }

       // @razao, @situacao, @nomeFantasia, @natureza, @porte,  @capital, @regime,telefone, @cnpj, @data, @tipo, @nomeP, @cpfP,
       // @cidade, @cep, @uf"
        public Empresa(string razaoS, string situacaoC, string nomeF, string naturezaJ, string porte, double capitalS, string regimeT,
        string telefone, string cnpj, DateTime? dataF, string tipo, string nomePro, string cpf, string cidade, int cep, string uf )
        {
            this.RazaoSocial = razaoS;
            this.NomeFantasia = nomeF;
            this.SituacaoCadastral = situacaoC;
            this.NomeP = nomePro;
            this.CpfProprietario = cpf;
            this.NaturezaJuridica = naturezaJ;
            this.RegimeTributario = regimeT;
            this.Tipo = tipo;
            this.Cnpj = cnpj;
            this.CapitalSocial = capitalS;
            this.DataFundacao = dataF;
            this.PorteEmpresa = porte;
            this.Uf = uf;
            this.Cidade = cidade;
            this.Cep = cep;
            this.Telefone = telefone;


        }



    }

    
}
