using cadastrodefuncionario;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace cadastro_funcionario_atualizado_bd
{
    public partial class CadastrarFuncionario : Form
    {
        public CadastrarFuncionario()
        {
            InitializeComponent();
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelar_button_Click_1(object sender, EventArgs e)
        {
            //botão cancelar
            nome_txt.Text = "";
            data_nas_txt.Text = "";
            estado_civ_txt.Text = " ";
            rg_txt.Text = "";
            cpf_txt.Text = "";
            funcao_txt.Text = "";
            salario_txt.Text = "";
            email_txt.Text = "";
            telefone_txt.Text = "";
            estado_cbx.Text = "";
            cidade_txt.Text = "";
            rua_txt.Text = "";
            cep_txt.Text = "";
  
        }

        private void salvar_btn_Click(object sender, EventArgs e)
        {
            try
            {
                bool validacao = Validacao.ValidarCPF(cpf_txt.Text);
                bool validacaoEmail = Validacao.ValidarEmail(email_txt.Text);

                if (validacao == true && validacaoEmail == true)
                {
                    string cpf = cpf_txt.Text;
                    Funcionario f = new Funcionario();
                    f.Nome = nome_txt.Text;
                    f.Cpf = cpf;
                    f.Telefone = telefone_txt.Text;
                    f.Email = email_txt.Text;
                    f.Salario = Convert.ToDouble(salario_txt.Text);
                    f.Funcao = funcao_txt.Text;
                    f.Ec = estado_cbx.Text;

                    MessageBox.Show("Salvo com sucesso");
                }

                else
                {
                    MessageBox.Show("Cpf inválido ou Email Inválido");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + " ocorreu um erro");

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

 
    }
}
    
