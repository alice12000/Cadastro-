namespace cadastro_funcionario_atualizado_bd
{
    partial class CadastroEmpresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroEmpresa));
            this.cnpj_txt = new System.Windows.Forms.MaskedTextBox();
            this.ufE_cbx = new Guna.UI2.WinForms.Guna2ComboBox();
            this.telefoneE_txt = new System.Windows.Forms.MaskedTextBox();
            this.nomeP_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.nomeF_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.razaoS_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataFundacao_txt = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.capitalS_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cancelar_button = new Guna.UI2.WinForms.Guna2Button();
            this.salvar_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label13 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.situacao_cbx = new Guna.UI2.WinForms.Guna2ComboBox();
            this.naturezaJ_txt = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cpfE_txt = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grande_rb = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.medio_rb = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.pequeno_rb = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.cidade_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.cepE_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.porte_gp_rb = new System.Windows.Forms.GroupBox();
            this.tipo_gb_rb = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.matriz_rb = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.filial_rb = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.regime_gb_rb = new System.Windows.Forms.GroupBox();
            this.simples_rb = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.lucro_rb = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label27 = new System.Windows.Forms.Label();
            this.real_rb = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.porte_gp_rb.SuspendLayout();
            this.tipo_gb_rb.SuspendLayout();
            this.regime_gb_rb.SuspendLayout();
            this.SuspendLayout();
            // 
            // cnpj_txt
            // 
            this.cnpj_txt.ForeColor = System.Drawing.Color.Black;
            this.cnpj_txt.Location = new System.Drawing.Point(258, 390);
            this.cnpj_txt.Mask = "00,000,000/0000-00";
            this.cnpj_txt.Name = "cnpj_txt";
            this.cnpj_txt.Size = new System.Drawing.Size(125, 22);
            this.cnpj_txt.TabIndex = 92;
            // 
            // ufE_cbx
            // 
            this.ufE_cbx.BackColor = System.Drawing.Color.Transparent;
            this.ufE_cbx.BorderRadius = 10;
            this.ufE_cbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ufE_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ufE_cbx.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ufE_cbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ufE_cbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ufE_cbx.ForeColor = System.Drawing.Color.Black;
            this.ufE_cbx.ItemHeight = 20;
            this.ufE_cbx.Items.AddRange(new object[] {
            "(AC)",
            "(AL)",
            "(AP)",
            "(AM)",
            "(BA)",
            "(CE)",
            "(DF)",
            "(ES)",
            "(GO)",
            "(MA)",
            "(MT)",
            "(MS)",
            "(MG)",
            "(PA)",
            "(PB)",
            "(PR)",
            "(PE)",
            "(PI)",
            "(RJ)",
            "(RN)",
            "(RS)",
            "(RO)",
            "(RR)",
            "(SC)",
            "(SP)",
            "(SE)",
            "(TO)",
            "",
            "",
            "",
            ""});
            this.ufE_cbx.Location = new System.Drawing.Point(490, 524);
            this.ufE_cbx.Name = "ufE_cbx";
            this.ufE_cbx.Size = new System.Drawing.Size(160, 26);
            this.ufE_cbx.TabIndex = 89;
            // 
            // telefoneE_txt
            // 
            this.telefoneE_txt.ForeColor = System.Drawing.Color.Black;
            this.telefoneE_txt.Location = new System.Drawing.Point(128, 390);
            this.telefoneE_txt.Mask = "(99) 00000-0000";
            this.telefoneE_txt.Name = "telefoneE_txt";
            this.telefoneE_txt.Size = new System.Drawing.Size(108, 22);
            this.telefoneE_txt.TabIndex = 85;
            // 
            // nomeP_txt
            // 
            this.nomeP_txt.BackColor = System.Drawing.Color.Transparent;
            this.nomeP_txt.BorderRadius = 10;
            this.nomeP_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nomeP_txt.DefaultText = "";
            this.nomeP_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nomeP_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nomeP_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nomeP_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nomeP_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nomeP_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nomeP_txt.ForeColor = System.Drawing.Color.Black;
            this.nomeP_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nomeP_txt.Location = new System.Drawing.Point(127, 469);
            this.nomeP_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nomeP_txt.Name = "nomeP_txt";
            this.nomeP_txt.PasswordChar = '\0';
            this.nomeP_txt.PlaceholderText = "";
            this.nomeP_txt.SelectedText = "";
            this.nomeP_txt.Size = new System.Drawing.Size(523, 26);
            this.nomeP_txt.TabIndex = 84;
            // 
            // nomeF_txt
            // 
            this.nomeF_txt.BackColor = System.Drawing.Color.Transparent;
            this.nomeF_txt.BorderRadius = 10;
            this.nomeF_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nomeF_txt.DefaultText = "";
            this.nomeF_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nomeF_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nomeF_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nomeF_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nomeF_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nomeF_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nomeF_txt.ForeColor = System.Drawing.Color.Black;
            this.nomeF_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nomeF_txt.Location = new System.Drawing.Point(127, 226);
            this.nomeF_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nomeF_txt.Name = "nomeF_txt";
            this.nomeF_txt.PasswordChar = '\0';
            this.nomeF_txt.PlaceholderText = "";
            this.nomeF_txt.SelectedText = "";
            this.nomeF_txt.Size = new System.Drawing.Size(347, 25);
            this.nomeF_txt.TabIndex = 82;
            // 
            // razaoS_txt
            // 
            this.razaoS_txt.BackColor = System.Drawing.Color.Transparent;
            this.razaoS_txt.BorderRadius = 10;
            this.razaoS_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.razaoS_txt.DefaultText = "";
            this.razaoS_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.razaoS_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.razaoS_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.razaoS_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.razaoS_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.razaoS_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.razaoS_txt.ForeColor = System.Drawing.Color.Black;
            this.razaoS_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.razaoS_txt.Location = new System.Drawing.Point(127, 160);
            this.razaoS_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.razaoS_txt.Name = "razaoS_txt";
            this.razaoS_txt.PasswordChar = '\0';
            this.razaoS_txt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.razaoS_txt.PlaceholderText = "";
            this.razaoS_txt.SelectedText = "";
            this.razaoS_txt.Size = new System.Drawing.Size(553, 25);
            this.razaoS_txt.TabIndex = 81;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(496, 505);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 16);
            this.label16.TabIndex = 77;
            this.label16.Text = "UF:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(255, 367);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 16);
            this.label12.TabIndex = 74;
            this.label12.Text = "Cnpj:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(124, 206);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 72;
            this.label8.Text = "Nome fantasia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(125, 367);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 70;
            this.label6.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(402, 367);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 69;
            this.label5.Text = "Data de Fundação:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(124, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 68;
            this.label3.Text = "Razão social:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Broadway", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(120, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(483, 46);
            this.label2.TabIndex = 67;
            this.label2.Text = "Cadastro de Empresa";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // dataFundacao_txt
            // 
            this.dataFundacao_txt.Location = new System.Drawing.Point(405, 390);
            this.dataFundacao_txt.Mask = "00/00/0000";
            this.dataFundacao_txt.Name = "dataFundacao_txt";
            this.dataFundacao_txt.Size = new System.Drawing.Size(78, 22);
            this.dataFundacao_txt.TabIndex = 96;
            this.dataFundacao_txt.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(124, 439);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 16);
            this.label4.TabIndex = 98;
            this.label4.Text = "Nome do responsável pela empresa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(457, 266);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 107;
            this.label7.Text = "Capital Social:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(569, 279);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 106;
            // 
            // capitalS_txt
            // 
            this.capitalS_txt.Animated = true;
            this.capitalS_txt.BackColor = System.Drawing.Color.Transparent;
            this.capitalS_txt.BorderRadius = 10;
            this.capitalS_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.capitalS_txt.DefaultText = "";
            this.capitalS_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.capitalS_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.capitalS_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.capitalS_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.capitalS_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.capitalS_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.capitalS_txt.ForeColor = System.Drawing.Color.Black;
            this.capitalS_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.capitalS_txt.Location = new System.Drawing.Point(460, 290);
            this.capitalS_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.capitalS_txt.Name = "capitalS_txt";
            this.capitalS_txt.PasswordChar = '\0';
            this.capitalS_txt.PlaceholderText = "";
            this.capitalS_txt.SelectedText = "";
            this.capitalS_txt.Size = new System.Drawing.Size(194, 28);
            this.capitalS_txt.TabIndex = 105;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(687, 140);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 16);
            this.label10.TabIndex = 101;
            this.label10.Text = "Situação cadastral:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(260, 266);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 16);
            this.label11.TabIndex = 100;
            // 
            // cancelar_button
            // 
            this.cancelar_button.BackColor = System.Drawing.Color.Transparent;
            this.cancelar_button.BorderColor = System.Drawing.Color.Transparent;
            this.cancelar_button.BorderRadius = 10;
            this.cancelar_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelar_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelar_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelar_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelar_button.FillColor = System.Drawing.Color.White;
            this.cancelar_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancelar_button.ForeColor = System.Drawing.Color.Black;
            this.cancelar_button.Location = new System.Drawing.Point(873, 606);
            this.cancelar_button.Name = "cancelar_button";
            this.cancelar_button.Size = new System.Drawing.Size(134, 35);
            this.cancelar_button.TabIndex = 109;
            this.cancelar_button.Text = "Cancelar";
            this.cancelar_button.Click += new System.EventHandler(this.cancelar_button_Click);
            // 
            // salvar_btn
            // 
            this.salvar_btn.BackColor = System.Drawing.Color.Transparent;
            this.salvar_btn.BorderColor = System.Drawing.Color.Transparent;
            this.salvar_btn.BorderRadius = 10;
            this.salvar_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.salvar_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.salvar_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.salvar_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.salvar_btn.FillColor = System.Drawing.Color.White;
            this.salvar_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.salvar_btn.ForeColor = System.Drawing.Color.Black;
            this.salvar_btn.Location = new System.Drawing.Point(733, 606);
            this.salvar_btn.Name = "salvar_btn";
            this.salvar_btn.Size = new System.Drawing.Size(134, 35);
            this.salvar_btn.TabIndex = 108;
            this.salvar_btn.Text = "Salvar";
            this.salvar_btn.Click += new System.EventHandler(this.salvar_btn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(477, 206);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 16);
            this.label13.TabIndex = 111;
            this.label13.Text = "Natureza Jurídica:";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(-57, -49);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(141, 743);
            this.guna2Panel1.TabIndex = 113;
            // 
            // situacao_cbx
            // 
            this.situacao_cbx.BackColor = System.Drawing.Color.Transparent;
            this.situacao_cbx.BorderRadius = 10;
            this.situacao_cbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.situacao_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.situacao_cbx.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.situacao_cbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.situacao_cbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.situacao_cbx.ForeColor = System.Drawing.Color.Black;
            this.situacao_cbx.ItemHeight = 20;
            this.situacao_cbx.Items.AddRange(new object[] {
            "Ativa",
            "Nula",
            "Suspensa",
            "Inapta",
            "Baixada"});
            this.situacao_cbx.Location = new System.Drawing.Point(690, 161);
            this.situacao_cbx.Name = "situacao_cbx";
            this.situacao_cbx.Size = new System.Drawing.Size(169, 26);
            this.situacao_cbx.TabIndex = 115;
            // 
            // naturezaJ_txt
            // 
            this.naturezaJ_txt.BackColor = System.Drawing.Color.Transparent;
            this.naturezaJ_txt.BorderRadius = 10;
            this.naturezaJ_txt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.naturezaJ_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.naturezaJ_txt.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.naturezaJ_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.naturezaJ_txt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.naturezaJ_txt.ForeColor = System.Drawing.Color.Black;
            this.naturezaJ_txt.ItemHeight = 20;
            this.naturezaJ_txt.Items.AddRange(new object[] {
            "EI – Empresário Individual",
            "MEI – Microempreendedor Individual",
            "Sociedade Anônima",
            "Sociedade Simples Limitada",
            "Sociedade Limitada Unipessoal"});
            this.naturezaJ_txt.Location = new System.Drawing.Point(480, 225);
            this.naturezaJ_txt.Name = "naturezaJ_txt";
            this.naturezaJ_txt.Size = new System.Drawing.Size(379, 26);
            this.naturezaJ_txt.TabIndex = 117;
            // 
            // cpfE_txt
            // 
            this.cpfE_txt.ForeColor = System.Drawing.Color.Black;
            this.cpfE_txt.Location = new System.Drawing.Point(670, 472);
            this.cpfE_txt.Mask = "000,000,000-00";
            this.cpfE_txt.Name = "cpfE_txt";
            this.cpfE_txt.Size = new System.Drawing.Size(108, 22);
            this.cpfE_txt.TabIndex = 119;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(675, 455);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 118;
            this.label1.Text = "Cpf:";
            // 
            // grande_rb
            // 
            this.grande_rb.BackColor = System.Drawing.Color.Transparent;
            this.grande_rb.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.grande_rb.CheckedState.BorderThickness = 0;
            this.grande_rb.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.grande_rb.CheckedState.InnerColor = System.Drawing.Color.White;
            this.grande_rb.ForeColor = System.Drawing.Color.White;
            this.grande_rb.Location = new System.Drawing.Point(242, 33);
            this.grande_rb.Name = "grande_rb";
            this.grande_rb.Size = new System.Drawing.Size(20, 20);
            this.grande_rb.TabIndex = 128;
            this.grande_rb.Text = "Grande";
            this.grande_rb.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grande_rb.UncheckedState.BorderThickness = 2;
            this.grande_rb.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.grande_rb.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // medio_rb
            // 
            this.medio_rb.BackColor = System.Drawing.Color.Transparent;
            this.medio_rb.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.medio_rb.CheckedState.BorderThickness = 0;
            this.medio_rb.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.medio_rb.CheckedState.InnerColor = System.Drawing.Color.White;
            this.medio_rb.ForeColor = System.Drawing.Color.White;
            this.medio_rb.Location = new System.Drawing.Point(130, 33);
            this.medio_rb.Name = "medio_rb";
            this.medio_rb.Size = new System.Drawing.Size(20, 20);
            this.medio_rb.TabIndex = 127;
            this.medio_rb.Tag = "";
            this.medio_rb.Text = "Médio";
            this.medio_rb.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.medio_rb.UncheckedState.BorderThickness = 2;
            this.medio_rb.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.medio_rb.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // pequeno_rb
            // 
            this.pequeno_rb.BackColor = System.Drawing.Color.Transparent;
            this.pequeno_rb.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pequeno_rb.CheckedState.BorderThickness = 0;
            this.pequeno_rb.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pequeno_rb.CheckedState.InnerColor = System.Drawing.Color.White;
            this.pequeno_rb.ForeColor = System.Drawing.Color.White;
            this.pequeno_rb.Location = new System.Drawing.Point(21, 34);
            this.pequeno_rb.Name = "pequeno_rb";
            this.pequeno_rb.Size = new System.Drawing.Size(20, 20);
            this.pequeno_rb.TabIndex = 126;
            this.pequeno_rb.Text = "Pequeno";
            this.pequeno_rb.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.pequeno_rb.UncheckedState.BorderThickness = 2;
            this.pequeno_rb.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.pequeno_rb.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(559, 606);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(168, 35);
            this.guna2Button1.TabIndex = 129;
            this.guna2Button1.Text = "Consultar";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // cidade_txt
            // 
            this.cidade_txt.Animated = true;
            this.cidade_txt.BackColor = System.Drawing.Color.Transparent;
            this.cidade_txt.BorderRadius = 10;
            this.cidade_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cidade_txt.DefaultText = "";
            this.cidade_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cidade_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cidade_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cidade_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cidade_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cidade_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cidade_txt.ForeColor = System.Drawing.Color.Black;
            this.cidade_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cidade_txt.Location = new System.Drawing.Point(128, 525);
            this.cidade_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cidade_txt.Name = "cidade_txt";
            this.cidade_txt.PasswordChar = '\0';
            this.cidade_txt.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.cidade_txt.PlaceholderText = "";
            this.cidade_txt.SelectedText = "";
            this.cidade_txt.Size = new System.Drawing.Size(219, 26);
            this.cidade_txt.TabIndex = 134;
            // 
            // cepE_txt
            // 
            this.cepE_txt.Animated = true;
            this.cepE_txt.BackColor = System.Drawing.Color.Transparent;
            this.cepE_txt.BorderRadius = 10;
            this.cepE_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cepE_txt.DefaultText = "";
            this.cepE_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cepE_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cepE_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cepE_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cepE_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cepE_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cepE_txt.ForeColor = System.Drawing.Color.Black;
            this.cepE_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cepE_txt.Location = new System.Drawing.Point(366, 525);
            this.cepE_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cepE_txt.Name = "cepE_txt";
            this.cepE_txt.PasswordChar = '\0';
            this.cepE_txt.PlaceholderText = "";
            this.cepE_txt.SelectedText = "";
            this.cepE_txt.Size = new System.Drawing.Size(108, 28);
            this.cepE_txt.TabIndex = 133;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.ForeColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(365, 505);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 16);
            this.label20.TabIndex = 131;
            this.label20.Text = "CEP:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.ForeColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(128, 505);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 16);
            this.label17.TabIndex = 130;
            this.label17.Text = "Cidade:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.ForeColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(157, 36);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 16);
            this.label21.TabIndex = 135;
            this.label21.Text = "Médio";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.ForeColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(267, 36);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 16);
            this.label22.TabIndex = 136;
            this.label22.Text = "Grande";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.ForeColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(41, 36);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(62, 16);
            this.label23.TabIndex = 137;
            this.label23.Text = "Pequeno";
            // 
            // porte_gp_rb
            // 
            this.porte_gp_rb.BackColor = System.Drawing.Color.Transparent;
            this.porte_gp_rb.Controls.Add(this.pequeno_rb);
            this.porte_gp_rb.Controls.Add(this.medio_rb);
            this.porte_gp_rb.Controls.Add(this.grande_rb);
            this.porte_gp_rb.Controls.Add(this.label21);
            this.porte_gp_rb.Controls.Add(this.label22);
            this.porte_gp_rb.Controls.Add(this.label23);
            this.porte_gp_rb.ForeColor = System.Drawing.Color.GhostWhite;
            this.porte_gp_rb.Location = new System.Drawing.Point(128, 266);
            this.porte_gp_rb.Name = "porte_gp_rb";
            this.porte_gp_rb.Size = new System.Drawing.Size(326, 71);
            this.porte_gp_rb.TabIndex = 142;
            this.porte_gp_rb.TabStop = false;
            this.porte_gp_rb.Text = "Porte da Empresa:";
            // 
            // tipo_gb_rb
            // 
            this.tipo_gb_rb.BackColor = System.Drawing.Color.Transparent;
            this.tipo_gb_rb.Controls.Add(this.label15);
            this.tipo_gb_rb.Controls.Add(this.matriz_rb);
            this.tipo_gb_rb.Controls.Add(this.filial_rb);
            this.tipo_gb_rb.Controls.Add(this.label28);
            this.tipo_gb_rb.Controls.Add(this.label29);
            this.tipo_gb_rb.ForeColor = System.Drawing.Color.GhostWhite;
            this.tipo_gb_rb.Location = new System.Drawing.Point(541, 367);
            this.tipo_gb_rb.Name = "tipo_gb_rb";
            this.tipo_gb_rb.Size = new System.Drawing.Size(210, 70);
            this.tipo_gb_rb.TabIndex = 143;
            this.tipo_gb_rb.TabStop = false;
            this.tipo_gb_rb.Text = "Tipo:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(145, 32);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 16);
            this.label15.TabIndex = 138;
            this.label15.Text = "Filial";
            // 
            // matriz_rb
            // 
            this.matriz_rb.BackColor = System.Drawing.Color.Transparent;
            this.matriz_rb.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.matriz_rb.CheckedState.BorderThickness = 0;
            this.matriz_rb.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.matriz_rb.CheckedState.InnerColor = System.Drawing.Color.White;
            this.matriz_rb.ForeColor = System.Drawing.Color.White;
            this.matriz_rb.Location = new System.Drawing.Point(9, 28);
            this.matriz_rb.Name = "matriz_rb";
            this.matriz_rb.Size = new System.Drawing.Size(20, 20);
            this.matriz_rb.TabIndex = 126;
            this.matriz_rb.Text = "Matriz";
            this.matriz_rb.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.matriz_rb.UncheckedState.BorderThickness = 2;
            this.matriz_rb.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.matriz_rb.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.matriz_rb.CheckedChanged += new System.EventHandler(this.matriz_rb_CheckedChanged);
            // 
            // filial_rb
            // 
            this.filial_rb.BackColor = System.Drawing.Color.Transparent;
            this.filial_rb.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filial_rb.CheckedState.BorderThickness = 0;
            this.filial_rb.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filial_rb.CheckedState.InnerColor = System.Drawing.Color.White;
            this.filial_rb.ForeColor = System.Drawing.Color.White;
            this.filial_rb.Location = new System.Drawing.Point(118, 28);
            this.filial_rb.Name = "filial_rb";
            this.filial_rb.Size = new System.Drawing.Size(20, 20);
            this.filial_rb.TabIndex = 128;
            this.filial_rb.Text = "Filial";
            this.filial_rb.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.filial_rb.UncheckedState.BorderThickness = 2;
            this.filial_rb.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.filial_rb.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.ForeColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(257, 39);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(0, 16);
            this.label28.TabIndex = 136;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.ForeColor = System.Drawing.Color.Transparent;
            this.label29.Location = new System.Drawing.Point(36, 32);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(42, 16);
            this.label29.TabIndex = 137;
            this.label29.Text = "Matriz";
            // 
            // regime_gb_rb
            // 
            this.regime_gb_rb.BackColor = System.Drawing.Color.Transparent;
            this.regime_gb_rb.Controls.Add(this.simples_rb);
            this.regime_gb_rb.Controls.Add(this.lucro_rb);
            this.regime_gb_rb.Controls.Add(this.label27);
            this.regime_gb_rb.Controls.Add(this.real_rb);
            this.regime_gb_rb.Controls.Add(this.label19);
            this.regime_gb_rb.Controls.Add(this.label14);
            this.regime_gb_rb.Controls.Add(this.label18);
            this.regime_gb_rb.ForeColor = System.Drawing.Color.GhostWhite;
            this.regime_gb_rb.Location = new System.Drawing.Point(670, 266);
            this.regime_gb_rb.Name = "regime_gb_rb";
            this.regime_gb_rb.Size = new System.Drawing.Size(353, 71);
            this.regime_gb_rb.TabIndex = 144;
            this.regime_gb_rb.TabStop = false;
            this.regime_gb_rb.Text = "Regime Tributário:";
            // 
            // simples_rb
            // 
            this.simples_rb.BackColor = System.Drawing.Color.Transparent;
            this.simples_rb.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.simples_rb.CheckedState.BorderThickness = 0;
            this.simples_rb.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.simples_rb.CheckedState.InnerColor = System.Drawing.Color.White;
            this.simples_rb.ForeColor = System.Drawing.Color.White;
            this.simples_rb.Location = new System.Drawing.Point(6, 35);
            this.simples_rb.Name = "simples_rb";
            this.simples_rb.Size = new System.Drawing.Size(20, 20);
            this.simples_rb.TabIndex = 138;
            this.simples_rb.Text = "Simples Nacional";
            this.simples_rb.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.simples_rb.UncheckedState.BorderThickness = 2;
            this.simples_rb.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.simples_rb.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // lucro_rb
            // 
            this.lucro_rb.BackColor = System.Drawing.Color.Transparent;
            this.lucro_rb.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lucro_rb.CheckedState.BorderThickness = 0;
            this.lucro_rb.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lucro_rb.CheckedState.InnerColor = System.Drawing.Color.White;
            this.lucro_rb.ForeColor = System.Drawing.Color.White;
            this.lucro_rb.Location = new System.Drawing.Point(146, 32);
            this.lucro_rb.Name = "lucro_rb";
            this.lucro_rb.Size = new System.Drawing.Size(20, 20);
            this.lucro_rb.TabIndex = 139;
            this.lucro_rb.Tag = "";
            this.lucro_rb.Text = "Lucro Presumido";
            this.lucro_rb.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lucro_rb.UncheckedState.BorderThickness = 2;
            this.lucro_rb.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.lucro_rb.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.ForeColor = System.Drawing.Color.Transparent;
            this.label27.Location = new System.Drawing.Point(257, 39);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(0, 16);
            this.label27.TabIndex = 136;
            // 
            // real_rb
            // 
            this.real_rb.BackColor = System.Drawing.Color.Transparent;
            this.real_rb.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.real_rb.CheckedState.BorderThickness = 0;
            this.real_rb.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.real_rb.CheckedState.InnerColor = System.Drawing.Color.White;
            this.real_rb.ForeColor = System.Drawing.Color.White;
            this.real_rb.Location = new System.Drawing.Point(281, 35);
            this.real_rb.Name = "real_rb";
            this.real_rb.Size = new System.Drawing.Size(20, 20);
            this.real_rb.TabIndex = 140;
            this.real_rb.Text = "Real";
            this.real_rb.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.real_rb.UncheckedState.BorderThickness = 2;
            this.real_rb.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.real_rb.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.real_rb.CheckedChanged += new System.EventHandler(this.guna2CustomRadioButton3_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.ForeColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(26, 37);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(113, 16);
            this.label19.TabIndex = 143;
            this.label19.Text = "Simples Nacional";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(173, 36);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 16);
            this.label14.TabIndex = 141;
            this.label14.Text = "Lucro Presumido";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.ForeColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(308, 36);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 16);
            this.label18.TabIndex = 142;
            this.label18.Text = "Real";
            // 
            // CadastroEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1051, 681);
            this.Controls.Add(this.regime_gb_rb);
            this.Controls.Add(this.tipo_gb_rb);
            this.Controls.Add(this.porte_gp_rb);
            this.Controls.Add(this.cidade_txt);
            this.Controls.Add(this.cepE_txt);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.cpfE_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.naturezaJ_txt);
            this.Controls.Add(this.situacao_cbx);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cancelar_button);
            this.Controls.Add(this.salvar_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.capitalS_txt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataFundacao_txt);
            this.Controls.Add(this.cnpj_txt);
            this.Controls.Add(this.ufE_cbx);
            this.Controls.Add(this.telefoneE_txt);
            this.Controls.Add(this.nomeP_txt);
            this.Controls.Add(this.nomeF_txt);
            this.Controls.Add(this.razaoS_txt);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadastroEmpresa";
            this.Text = "Filial";
            this.porte_gp_rb.ResumeLayout(false);
            this.porte_gp_rb.PerformLayout();
            this.tipo_gb_rb.ResumeLayout(false);
            this.tipo_gb_rb.PerformLayout();
            this.regime_gb_rb.ResumeLayout(false);
            this.regime_gb_rb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox cnpj_txt;
        private Guna.UI2.WinForms.Guna2ComboBox ufE_cbx;
        private System.Windows.Forms.MaskedTextBox telefoneE_txt;
        private Guna.UI2.WinForms.Guna2TextBox nomeP_txt;
        private Guna.UI2.WinForms.Guna2TextBox nomeF_txt;
        private Guna.UI2.WinForms.Guna2TextBox razaoS_txt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox dataFundacao_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox capitalS_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2Button cancelar_button;
        private Guna.UI2.WinForms.Guna2Button salvar_btn;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox situacao_cbx;
        private Guna.UI2.WinForms.Guna2ComboBox naturezaJ_txt;
        private System.Windows.Forms.MaskedTextBox cpfE_txt;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton grande_rb;
        private Guna.UI2.WinForms.Guna2CustomRadioButton medio_rb;
        private Guna.UI2.WinForms.Guna2CustomRadioButton pequeno_rb;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox cidade_txt;
        private Guna.UI2.WinForms.Guna2TextBox cepE_txt;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox porte_gp_rb;
        private System.Windows.Forms.GroupBox tipo_gb_rb;
        private Guna.UI2.WinForms.Guna2CustomRadioButton matriz_rb;
        private Guna.UI2.WinForms.Guna2CustomRadioButton filial_rb;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox regime_gb_rb;
        private System.Windows.Forms.Label label27;
        private Guna.UI2.WinForms.Guna2CustomRadioButton simples_rb;
        private Guna.UI2.WinForms.Guna2CustomRadioButton lucro_rb;
        private Guna.UI2.WinForms.Guna2CustomRadioButton real_rb;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
    }
}