using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastro_funcionario_atualizado_bd.TELAS
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cadastrar funcionario

            CadastrarFuncionario tela2 = new CadastrarFuncionario();
            this.Visible = false;
            tela2.ShowDialog();
            this.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {//cadastrar empresa
          
            CadastroEmpresa tela = new CadastroEmpresa();
            this.Visible = false;
            tela.ShowDialog();
            this.Visible = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
