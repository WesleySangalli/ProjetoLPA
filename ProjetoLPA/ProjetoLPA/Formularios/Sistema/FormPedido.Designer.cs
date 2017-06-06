namespace ProjetoLPA.Formularios.Sistema
{
    partial class FormPedido
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
            this.groupPedido = new System.Windows.Forms.GroupBox();
            this.btnAdcionarCliente = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.groupItem = new System.Windows.Forms.GroupBox();
            this.gridItem = new System.Windows.Forms.DataGridView();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.btnBuscarProduto = new System.Windows.Forms.Button();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.groupCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errError)).BeginInit();
            this.groupPedido.SuspendLayout();
            this.groupItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupCampos
            // 
            this.groupCampos.Controls.Add(this.groupItem);
            this.groupCampos.Controls.Add(this.groupPedido);
            this.groupCampos.Location = new System.Drawing.Point(6, 22);
            this.groupCampos.Size = new System.Drawing.Size(591, 433);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(528, 461);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(453, 461);
            // 
            // groupPedido
            // 
            this.groupPedido.Controls.Add(this.btnAdcionarCliente);
            this.groupPedido.Controls.Add(this.dtpData);
            this.groupPedido.Controls.Add(this.lblData);
            this.groupPedido.Controls.Add(this.btnBuscarCliente);
            this.groupPedido.Controls.Add(this.txtCliente);
            this.groupPedido.Controls.Add(this.lblCliente);
            this.groupPedido.Location = new System.Drawing.Point(7, 17);
            this.groupPedido.Name = "groupPedido";
            this.groupPedido.Size = new System.Drawing.Size(579, 126);
            this.groupPedido.TabIndex = 0;
            this.groupPedido.TabStop = false;
            this.groupPedido.Text = "Pedido";
            // 
            // btnAdcionarCliente
            // 
            this.btnAdcionarCliente.Location = new System.Drawing.Point(6, 93);
            this.btnAdcionarCliente.Name = "btnAdcionarCliente";
            this.btnAdcionarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnAdcionarCliente.TabIndex = 5;
            this.btnAdcionarCliente.Text = "Adicionar";
            this.btnAdcionarCliente.UseVisualStyleBackColor = true;
            this.btnAdcionarCliente.Click += new System.EventHandler(this.btnAdcionar_Click);
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "dd/MM/yyyy";
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(54, 60);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(111, 20);
            this.dtpData.TabIndex = 4;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(15, 61);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data:";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(486, 25);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(54, 27);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(425, 20);
            this.txtCliente.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(6, 30);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // groupItem
            // 
            this.groupItem.Controls.Add(this.gridItem);
            this.groupItem.Controls.Add(this.btnRemover);
            this.groupItem.Controls.Add(this.btnAdicionarItem);
            this.groupItem.Controls.Add(this.txtValor);
            this.groupItem.Controls.Add(this.lblValor);
            this.groupItem.Controls.Add(this.txtQuantidade);
            this.groupItem.Controls.Add(this.lblQuantidade);
            this.groupItem.Controls.Add(this.btnBuscarProduto);
            this.groupItem.Controls.Add(this.txtProduto);
            this.groupItem.Controls.Add(this.lblProduto);
            this.groupItem.Location = new System.Drawing.Point(7, 150);
            this.groupItem.Name = "groupItem";
            this.groupItem.Size = new System.Drawing.Size(579, 268);
            this.groupItem.TabIndex = 1;
            this.groupItem.TabStop = false;
            this.groupItem.Text = "Item";
            // 
            // gridItem
            // 
            this.gridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItem.Location = new System.Drawing.Point(6, 84);
            this.gridItem.Name = "gridItem";
            this.gridItem.Size = new System.Drawing.Size(567, 178);
            this.gridItem.TabIndex = 9;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(426, 55);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 8;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Location = new System.Drawing.Point(345, 55);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarItem.TabIndex = 7;
            this.btnAdicionarItem.Text = "Adicionar";
            this.btnAdicionarItem.UseVisualStyleBackColor = true;
            this.btnAdicionarItem.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(221, 55);
            this.txtValor.MaxLength = 10;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 6;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(183, 58);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 5;
            this.lblValor.Text = "Valor:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(76, 55);
            this.txtQuantidade.MaxLength = 5;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 4;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(7, 58);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 3;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.Location = new System.Drawing.Point(477, 21);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProduto.TabIndex = 2;
            this.btnBuscarProduto.Text = "Buscar";
            this.btnBuscarProduto.UseVisualStyleBackColor = true;
            this.btnBuscarProduto.Click += new System.EventHandler(this.btnBuscarProduto_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(59, 22);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.ReadOnly = true;
            this.txtProduto.Size = new System.Drawing.Size(411, 20);
            this.txtProduto.TabIndex = 1;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(6, 25);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(47, 13);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto:";
            // 
            // FormPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(607, 485);
            this.Name = "FormPedido";
            this.groupCampos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errError)).EndInit();
            this.groupPedido.ResumeLayout(false);
            this.groupPedido.PerformLayout();
            this.groupItem.ResumeLayout(false);
            this.groupItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupPedido;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.GroupBox groupItem;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Button btnBuscarProduto;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Button btnAdcionarCliente;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DataGridView gridItem;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionarItem;
    }
}
