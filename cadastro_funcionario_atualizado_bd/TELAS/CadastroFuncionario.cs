
using cadastro_funcionario_atualizado_bd.TELAS;
using cadastrodefuncionario;
using CpfCnpjLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace cadastro_funcionario_atualizado_bd
{
    public partial class CadastrarFuncionario : Form
    {
        
        public CadastrarFuncionario()
        {
            InitializeComponent();

        }

        private List<Funcionario> listF = new List<Funcionario>();
 
        void Inserir(Funcionario f)
        {
            try
            {

                Conexao c = new Conexao();
                var comando = c.Comando("INSERT INTO Funcionario VALUES (null, @nome, @cpf, @rg, @data, @ec, @email,@salario, @telefone,@funcao, @estado, @cidade, @rua)");
                comando.Parameters.AddWithValue("@id", f.Id);
                comando.Parameters.AddWithValue("@nome", f.Nome);
                comando.Parameters.AddWithValue("@cpf", f.Cpf);
                comando.Parameters.AddWithValue("@rg", f.Rg);
                comando.Parameters.AddWithValue("@data", f.DataNas);
                comando.Parameters.AddWithValue("@ec", f.Ec);
                comando.Parameters.AddWithValue("@email", f.Email);
                comando.Parameters.AddWithValue("@salario", f.Salario);
                comando.Parameters.AddWithValue("@telefone", f.Telefone);
                comando.Parameters.AddWithValue("@funcao", f.Funcao);
                comando.Parameters.AddWithValue("@estado", f.Estado);
                comando.Parameters.AddWithValue("@cidade", f.Cidade);
                comando.Parameters.AddWithValue("@rua", f.Rua);

                var resultado = comando.ExecuteNonQuery();

                if(resultado > 0)
                {
                    MessageBox.Show("Funcionário cadastrado com êxito");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        
        private void cancelar_button_Click_1(object sender, EventArgs e)
        {
            //botão cancelar
            nome_txt.Text = "";
            data_txt.Clear();
            estado_cbx.SelectedIndex = -1;
            rg_txt.Text = "";
            cpf_txt.Text = "";
            salario_txt.Text = "";
            email_txt.Text = "";
            telefone_txt.Text = "";
            funcao_txt.SelectedIndex = -1;
            cidade_txt.Text = "";
            rua_txt.Text = "";

        }

        private void salvar_btn_Click(object sender, EventArgs e)
        {
            try
            {
                bool validacao = Validacao.ValidarCPF(cpf_txt.Text);
                bool validacaoEmail = Validacao.ValidarEmail(email_txt.Text);

                if (validacao == true)
                {
                    //cpf vai ser valido

                    if (validacaoEmail == true)
                    {
                        //email vai ser valido
                        string nome = nome_txt.Text;
                        string datanas = data_txt.Text;
                        string cpf = cpf_txt.Text;
                        string rg = rg_txt.Text;
                        string ec = estado_civ_txt.Text;
                        string email = email_txt.Text;
                        string funcao = funcao_txt.Text;
                        string telefone = telefone_txt.Text;
                        double salario = Convert.ToDouble(salario_txt.Text);
                        string estado = estado_cbx.Text;
                        string cidade = cidade_txt.Text;
                        string rua = rua_txt.Text;

                        //string nome,string datanas, string cpf, int rg, string ec, string email, string funcao, string telefone
                        Funcionario f = new Funcionario(nome, Convert.ToDateTime(datanas), cpf, Convert.ToInt32(rg),
                         ec, email, funcao, salario, telefone, estado, cidade, rua);

                        Inserir(f);

                    }

                    else
                    {
                        MessageBox.Show("O email inserido é inválido");
                    }
                   
                }

                else
                {
                    MessageBox.Show("Cpf inválido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " ocorreu um erro");

            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //mostrar lista com os funcionarios
            this.Visible = false;
            ExibirFuncionario tela3 = new ExibirFuncionario();
            tela3.Show();

        }
    }
}