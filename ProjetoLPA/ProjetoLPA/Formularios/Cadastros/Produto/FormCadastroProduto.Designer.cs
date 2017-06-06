namespace ProjetoLPA.Formularios.Cadastros.Produto
{
    partial class FormCadastroProduto
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblAtivo = new System.Windows.Forms.Label();
            this.optSim = new System.Windows.Forms.RadioButton();
            this.optNao = new System.Windows.Forms.RadioButton();
            this.groupCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // groupCampos
            // 
            this.groupCampos.Controls.Add(this.optNao);
            this.groupCampos.Controls.Add(this.optSim);
            this.groupCampos.Controls.Add(this.lblAtivo);
            this.groupCampos.Controls.Add(this.txtValor);
            this.groupCampos.Controls.Add(this.lblValor);
            this.groupCampos.Controls.Add(this.nudQuantidade);
            this.groupCampos.Controls.Add(this.txtDescricao);
            this.groupCampos.Controls.Add(this.comboCategoria);
            this.groupCampos.Controls.Add(this.label1);
            this.groupCampos.Controls.Add(this.lblDescricao);
            this.groupCampos.Controls.Add(this.lblCategoria);
            this.groupCampos.Location = new System.Drawing.Point(9, 11);
            this.groupCampos.Enter += new System.EventHandler(this.groupCampos_Enter);
            // 
            // btnNovo
            // 
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSair
            // 
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(21, 19);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoria:";
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(24, 52);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição:";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantidade:";
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(100, 16);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(308, 21);
            this.comboCategoria.TabIndex = 3;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(100, 47);
            this.txtDescricao.MaxLength = 80;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(308, 20);
            this.txtDescricao.TabIndex = 4;
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(100, 76);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(84, 20);
            this.nudQuantidade.TabIndex = 5;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(42, 105);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 6;
            this.lblValor.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(100, 104);
            this.txtValor.MaxLength = 80;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(84, 20);
            this.txtValor.TabIndex = 7;
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.Location = new System.Drawing.Point(42, 128);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(34, 13);
            this.lblAtivo.TabIndex = 8;
            this.lblAtivo.Text = "Ativo:";
            // 
            // optSim
            // 
            this.optSim.AutoSize = true;
            this.optSim.Checked = true;
            this.optSim.Location = new System.Drawing.Point(100, 131);
            this.optSim.Name = "optSim";
            this.optSim.Size = new System.Drawing.Size(42, 17);
            this.optSim.TabIndex = 9;
            this.optSim.TabStop = true;
            this.optSim.Text = "Sim";
            this.optSim.UseVisualStyleBackColor = true;
            // 
            // optNao
            // 
            this.optNao.AutoSize = true;
            this.optNao.Location = new System.Drawing.Point(149, 131);
            this.optNao.Name = "optNao";
            this.optNao.Size = new System.Drawing.Size(45, 17);
            this.optNao.TabIndex = 10;
            this.optNao.TabStop = true;
            this.optNao.Text = "Não";
            this.optNao.UseVisualStyleBackColor = true;
            // 
            // FormCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(475, 347);
            this.Name = "FormCadastroProduto";
            this.groupCampos.ResumeLayout(false);
            this.groupCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.RadioButton optSim;
        private System.Windows.Forms.Label lblAtivo;
        private System.Windows.Forms.RadioButton optNao;
    }
}
