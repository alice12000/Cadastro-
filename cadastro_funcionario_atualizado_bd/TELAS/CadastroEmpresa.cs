using cadastro_funcionario_atualizado_bd.TELAS;
using cadastrodefuncionario;
using CpfCnpjLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace cadastro_funcionario_atualizado_bd
{
    public partial class CadastroEmpresa : Form
    {
        public CadastroEmpresa()
        {
            InitializeComponent();
         
        }


        private List<Empresa> listE = new List<Empresa>();
   
        void Inserir(Empresa e)
        {
            try
            {
                Conexao c = new Conexao();

                var comando = c.Comando("INSERT INTO Empresa VALUES (null, @razao, @situacao, @nome, @natureza, @porte, @capital, @regime, @telefone, @cnpj, @data, @tipo, @nomeP, @cpf, @cidade, @cep, @uf)"   );
                comando.Parameters.AddWithValue("@id", e.Id);
                comando.Parameters.AddWithValue("@razao", e.RazaoSocial);
                comando.Parameters.AddWithValue("@situacao", e.SituacaoCadastral);
                comando.Parameters.AddWithValue("nome", e.NomeFantasia);
                comando.Parameters.AddWithValue("@natureza",e.NaturezaJuridica);
                comando.Parameters.AddWithValue("@porte", e.PorteEmpresa);
                comando.Parameters.AddWithValue("@capital",e.CapitalSocial );
                comando.Parameters.AddWithValue("@regime",e.RegimeTributario );
                comando.Parameters.AddWithValue("@telefone",e.Telefone );
                comando.Parameters.AddWithValue("@cnpj",e.Cnpj );
                comando.Parameters.AddWithValue("@data",e.DataFundacao);
                comando.Parameters.AddWithValue("@tipo",e.Tipo );
                comando.Parameters.AddWithValue("@nomeP",e.NomeP);
                comando.Parameters.AddWithValue("@cpf", e.CpfProprietario);
                comando.Parameters.AddWithValue("@cidade", e.Cidade);
                comando.Parameters.AddWithValue("@cep", e.Cep);
                comando.Parameters.AddWithValue("@uf", e.Uf);

                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("A empresa foi cadastrada no sistema");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cancelar_button_Click(object sender, EventArgs e)
        {//limpar

            razaoS_txt.Text = "";
            nomeF_txt.Text = "";
            nomeP_txt.Text = "";

            //porte
            pequeno_rb.Checked = false;
            grande_rb.Checked = false;
            medio_rb.Checked = false;


            //tipo

            matriz_rb.Checked = false;
            filial_rb.Checked = false;

            //regime tributario

            simples_rb.Checked = false;
            real_rb.Checked = false;
            lucro_rb.Checked = false;

            cpfE_txt.Text = "";
            naturezaJ_txt.Text = "";
            /// o radiobox : string regimeT = regimeT_txt.Text;
           
            capitalS_txt.Text = "";
           
            ufE_cbx.Text = "";
            cidade_txt.Text = "";
            cepE_txt.Text = "";

            dataFundacao_txt.Clear();
            cnpj_txt.Clear();
            telefoneE_txt.Clear();
        }

        private void salvar_btn_Click(object sender, EventArgs e)
        {///salvar 
            try
            {
                bool validacaoCnpj = Validacao.ValidarCnpj(cnpj_txt.Text);
                bool validacaoCpf = Validacao.ValidarCPF(cpfE_txt.Text);

                if(validacaoCnpj == true)
                {
                    MessageBox.Show("Cnpj válido");
                    if(validacaoCpf == true)
                    {
                        MessageBox.Show("Cpf válido");
                        string razaoS = razaoS_txt.Text;
                        string nomeF = nomeF_txt.Text;
                        string situacaoC = situacao_cbx.Text;
                        string nomeP = nomeP_txt.Text;

                        //regime tributario;

                        string regimeT;

                        GroupBox regime = new GroupBox();
                        regime.Controls.Add(lucro_rb);
                        regime.Controls.Add(filial_rb);
                        regime.Controls.Add(matriz_rb);
                   

                        if (simples_rb.Checked == true)
                        {
                            regimeT = simples_rb.Text;
                        }
                        else if (real_rb.Checked == true)
                        {
                            regimeT = real_rb.Text;
                        }
                        else
                        {
                            regimeT = lucro_rb.Text;
                        }
     
                        string tipO;

                        GroupBox tipo = new GroupBox();
                        tipo.Controls.Add(matriz_rb);
                        tipo.Controls.Add(filial_rb);
     

                        if (matriz_rb.Checked == true)
                        {
                            tipO = matriz_rb.Text;
                        }
                       
                        else
                        {
                            tipO = filial_rb.Text;
                        }

                        string porteE;

                        GroupBox porte = new GroupBox();
                        porte.Controls.Add(pequeno_rb);
                        porte.Controls.Add(medio_rb);
                        porte.Controls.Add(grande_rb);


                        if (pequeno_rb.Checked == true)
                        {
                            porteE = pequeno_rb.Text;
                        }

                        else if(medio_rb.Checked == true)
                        {
                            porteE = medio_rb.Text;
                        }
                    
                        else
                        {
                            porteE = grande_rb.Text;
                        }


                        string cpf = cpfE_txt.Text;
                        string naturezaJ = naturezaJ_txt.Text;
                        string cnpj = cnpj_txt.Text;
                        double capitalS = Convert.ToDouble(capitalS_txt.Text);
                        DateTime dataF = Convert.ToDateTime(dataFundacao_txt.Text);
                        string uf = ufE_cbx.Text;
                        string cidade = cidade_txt.Text;
                        int cep = Convert.ToInt32(cepE_txt.Text);
                        string telefone = telefoneE_txt.Text;

                

                        Empresa e1 = new Empresa(razaoS, situacaoC, nomeF, naturezaJ, porteE, capitalS, regimeT, telefone,
                        cnpj, dataF, tipO, nomeP, cpf, cidade,cep, uf);
                         
                        Inserir(e1);
         
                    }

                    else{
                        MessageBox.Show("Cpf inválido");
                    }
                }

                else
                {
                    MessageBox.Show("Cnpj inválido");
                }

             
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " ocorreu um erro");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //mostrar lista com empresas
            this.Visible = false;
            ExibirEmpresas tela4 = new ExibirEmpresas();
            tela4.Show();

        }



        private void guna2CustomRadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
