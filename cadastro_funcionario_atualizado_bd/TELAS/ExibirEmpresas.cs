using cadastro_funcionario_atualizado_bd.Geral;
using cadastro_funcionario_atualizado_bd.TELAS;
using Google.Protobuf.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastro_funcionario_atualizado_bd
{
    public partial class ExibirEmpresas : Form
    {
        private List<Empresa> listaE = new List<Empresa>();
        public ExibirEmpresas()
        {
            InitializeComponent();
            Consultar();
        }

        void Consultar()
        {
            try
            {
                var con = new Conexao();
                var comaand = con.Comando("SELECT * FROM Empresa");
                var leitor = comaand.ExecuteReader();


                while (leitor.Read())
                {
                    var e = new Empresa();
                    e.Id = DAOHelper.GetInt(leitor, "id_emp");
                    e.RazaoSocial = DAOHelper.GetString(leitor, "razao_emp");
                    e.SituacaoCadastral = DAOHelper.GetString(leitor, "situacao_emp");
                    e.NomeFantasia = DAOHelper.GetString(leitor, "nome_emp");
                    e.NaturezaJuridica = DAOHelper.GetString(leitor, "natureza_emp");
                    e.PorteEmpresa = DAOHelper.GetString(leitor, "porte_emp");
                    e.CapitalSocial = DAOHelper.GetDouble(leitor, "capital_emp");
                    e.RegimeTributario = DAOHelper.GetString(leitor, "regime_emp");
                    e.Telefone = DAOHelper.GetString(leitor, "telefone_emp");
                    e.Cnpj = DAOHelper.GetString(leitor, "cnpj_emp");
                    e.DataFundacao = DAOHelper.GetDateTime(leitor, "data_emp");
                    e.Tipo = DAOHelper.GetString(leitor, "tipo_emp");
                    e.NomeP = DAOHelper.GetString(leitor, "nomeP_emp");
                    e.CpfProprietario = DAOHelper.GetString(leitor, "cpf_emp");
                    e.Cidade = DAOHelper.GetString(leitor, "cidade_emp");
                    e.Cep = DAOHelper.GetInt(leitor, "cep_emp");
                    e.Uf = DAOHelper.GetString(leitor, "uf_emp");

                    listaE.Add(e);
                }
                dataGridViewEmpresa.DataSource = listaE;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void ExibirEmpresas_Load(object sender, EventArgs e)
        {

        }
    }
}
