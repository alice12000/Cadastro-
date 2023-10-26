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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void salvar_button_Click(object sender, EventArgs e)
        {
            //pessoais: 
            string nome = nome_txt.Text;
            DateTime datanas = Convert.ToDateTime(datanas_txt);
            string estadocivil = estado_civ_txt.Text;
            int rg = Convert.ToInt32(rg_txt.Text);
            string cpf = cpf_txt.Text; 

            //gerais:
            string funcao = funcao_txt.Text;
            string salario = salario_txt.Text;
      
            //contato
            string email = email_txt.Text;
            string telefone = telefone_txt.Text;

            //endereco: 
            string estado = estado_txt.Text;
            string cidade = cidade_txt.Text;
            string rua = rua_txt.Text;
            string cpe = Convert.ToInt32(cpe_txt);
            //string numero = Convert.ToDouble

        }
    }
}
