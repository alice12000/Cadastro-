using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cadastro_funcionario_atualizado_bd;
using cadastro_funcionario_atualizado_bd.Geral;

namespace cadastro_funcionario_atualizado_bd.TELAS
{
    public partial class ExibirFuncionario : Form
    {
        private List<Funcionario> listaF = new List<Funcionario>();
        public ExibirFuncionario()
        {
            InitializeComponent();
            Consultar();
        }

        private void dataGridViewFuncionario_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        void Consultar()
        {
            try
            {
                var con = new Conexao();
                var comaand = con.Comando("SELECT * FROM Funcionario");
                var leitor = comaand.ExecuteReader();


                while (leitor.Read())
                {
                    var f = new Funcionario();
                    f.Id = DAOHelper.GetInt(leitor, "id_fun");
                    f.Nome = DAOHelper.GetString(leitor, "nome_fun");
                    f.Cpf = DAOHelper.GetString(leitor, "cpf_fun");
                    f.Rg = DAOHelper.GetInt(leitor, "rg_fun");
                    f.DataNas = DAOHelper.GetDateTime(leitor, "data_fun");
                    f.Ec = DAOHelper.GetString(leitor, "ec_fun");
                    f.Email = DAOHelper.GetString(leitor, "email_fun");
                    f.Salario = DAOHelper.GetDouble(leitor, "salario_fun");
                    f.Telefone = DAOHelper.GetString(leitor, "telefone_fun");
                    f.Funcao = DAOHelper.GetString(leitor, "funcao_fun");
                    f.Estado = DAOHelper.GetString(leitor, "estado_fun");
                    f.Cidade = DAOHelper.GetString(leitor, "cidade_fun");
                    f.Rua = DAOHelper.GetString(leitor, "rua_fun");
                    listaF.Add(f);
                }
                dataGridViewFuncionario.DataSource = listaF;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}



