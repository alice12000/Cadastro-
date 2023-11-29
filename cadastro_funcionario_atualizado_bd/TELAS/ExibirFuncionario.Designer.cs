namespace cadastro_funcionario_atualizado_bd.TELAS
{
    partial class ExibirFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExibirFuncionario));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewFuncionario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Funcionários";
            // 
            // dataGridViewFuncionario
            // 
            this.dataGridViewFuncionario.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFuncionario.Location = new System.Drawing.Point(78, 107);
            this.dataGridViewFuncionario.Name = "dataGridViewFuncionario";
            this.dataGridViewFuncionario.RowHeadersWidth = 51;
            this.dataGridViewFuncionario.RowTemplate.Height = 24;
            this.dataGridViewFuncionario.Size = new System.Drawing.Size(859, 365);
            this.dataGridViewFuncionario.TabIndex = 2;
            this.dataGridViewFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFuncionario_CellContentClick_1);
            // 
            // ExibirFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1233, 617);
            this.Controls.Add(this.dataGridViewFuncionario);
            this.Controls.Add(this.label1);
            this.Name = "ExibirFuncionario";
            this.Text = "ExibirFuncionario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewFuncionario;
    }
}