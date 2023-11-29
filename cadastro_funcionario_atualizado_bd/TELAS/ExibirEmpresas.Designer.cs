namespace cadastro_funcionario_atualizado_bd
{
    partial class ExibirEmpresas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExibirEmpresas));
            this.dataGridViewEmpresa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmpresa
            // 
            this.dataGridViewEmpresa.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpresa.Location = new System.Drawing.Point(68, 83);
            this.dataGridViewEmpresa.Name = "dataGridViewEmpresa";
            this.dataGridViewEmpresa.RowHeadersWidth = 51;
            this.dataGridViewEmpresa.RowTemplate.Height = 24;
            this.dataGridViewEmpresa.Size = new System.Drawing.Size(926, 516);
            this.dataGridViewEmpresa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista de Empresas";
            // 
            // ExibirEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1051, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ExibirEmpresas";
            this.Text = "ExibirEmpresas";
            this.Load += new System.EventHandler(this.ExibirEmpresas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmpresa;
        private System.Windows.Forms.Label label1;
    }
}