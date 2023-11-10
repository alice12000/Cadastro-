    using System;
    using System.Windows.Forms;

    namespace cadastro_funcionario_atualizado_bd
    {
        public partial class Form1 : Form
        {
            public Form1()
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
                numero_txt.Text = "";
            }

            private void salvar_btn_Click(object sender, EventArgs e)
            {
                try
                {
                Funcionario f = new Funcionario();
                f.Nome = nome_txt.Text;
                f.Rg = Convert.ToInt32(rg_txt.Text);
                f.Ec = estado_cbx.Text;
                f.Cpf = cpf_txt.Text;
                f.Email = email_txt.Text;
                f.Salario = Convert.ToDouble(salario_txt.Text);
                f.Funcao = funcao_txt.Text; 
                f.Telefone = telefone_txt.Text;

                  
            }


            catch
            {
                MessageBox.Show("OCORREU UM ERRO");
            }
           

            }
    }




}
    
