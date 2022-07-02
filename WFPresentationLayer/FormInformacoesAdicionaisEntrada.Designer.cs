namespace WFPresentationLayer
{
    partial class FormInformacoesAdicionaisEntrada
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
            this.dgvProdutosSaida = new System.Windows.Forms.DataGridView();
            this.EntradaProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntradaQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntradaValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSaidaInfo = new System.Windows.Forms.Panel();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPagamentoInfo = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosSaida)).BeginInit();
            this.panelSaidaInfo.SuspendLayout();
            this.panelPagamentoInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutosSaida
            // 
            this.dgvProdutosSaida.AllowUserToAddRows = false;
            this.dgvProdutosSaida.AllowUserToDeleteRows = false;
            this.dgvProdutosSaida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutosSaida.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutosSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosSaida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EntradaProduto,
            this.EntradaQuantidade,
            this.EntradaValorUnitario});
            this.dgvProdutosSaida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutosSaida.Location = new System.Drawing.Point(0, 77);
            this.dgvProdutosSaida.Name = "dgvProdutosSaida";
            this.dgvProdutosSaida.ReadOnly = true;
            this.dgvProdutosSaida.RowTemplate.Height = 25;
            this.dgvProdutosSaida.Size = new System.Drawing.Size(688, 373);
            this.dgvProdutosSaida.TabIndex = 22;
            // 
            // EntradaProduto
            // 
            this.EntradaProduto.HeaderText = "Produto";
            this.EntradaProduto.Name = "EntradaProduto";
            this.EntradaProduto.ReadOnly = true;
            // 
            // EntradaQuantidade
            // 
            this.EntradaQuantidade.HeaderText = "Quantidade";
            this.EntradaQuantidade.Name = "EntradaQuantidade";
            this.EntradaQuantidade.ReadOnly = true;
            // 
            // EntradaValorUnitario
            // 
            this.EntradaValorUnitario.HeaderText = "ValorUnitario";
            this.EntradaValorUnitario.Name = "EntradaValorUnitario";
            this.EntradaValorUnitario.ReadOnly = true;
            // 
            // panelSaidaInfo
            // 
            this.panelSaidaInfo.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelSaidaInfo.Controls.Add(this.txtData);
            this.panelSaidaInfo.Controls.Add(this.label7);
            this.panelSaidaInfo.Controls.Add(this.txtFuncionario);
            this.panelSaidaInfo.Controls.Add(this.txtID);
            this.panelSaidaInfo.Controls.Add(this.label2);
            this.panelSaidaInfo.Controls.Add(this.label4);
            this.panelSaidaInfo.Controls.Add(this.txtFornecedor);
            this.panelSaidaInfo.Controls.Add(this.label1);
            this.panelSaidaInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSaidaInfo.Location = new System.Drawing.Point(0, 0);
            this.panelSaidaInfo.Name = "panelSaidaInfo";
            this.panelSaidaInfo.Size = new System.Drawing.Size(688, 77);
            this.panelSaidaInfo.TabIndex = 20;
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(338, 43);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(123, 23);
            this.txtData.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "ID";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Enabled = false;
            this.txtFuncionario.Location = new System.Drawing.Point(230, 43);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(100, 23);
            this.txtFuncionario.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(12, 22);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(44, 23);
            this.txtID.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Funcionario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(338, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Enabled = false;
            this.txtFornecedor.Location = new System.Drawing.Point(96, 43);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(128, 23);
            this.txtFornecedor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fornecedor";
            // 
            // panelPagamentoInfo
            // 
            this.panelPagamentoInfo.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelPagamentoInfo.Controls.Add(this.label8);
            this.panelPagamentoInfo.Controls.Add(this.txtValorTotal);
            this.panelPagamentoInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPagamentoInfo.Location = new System.Drawing.Point(688, 0);
            this.panelPagamentoInfo.Name = "panelPagamentoInfo";
            this.panelPagamentoInfo.Size = new System.Drawing.Size(112, 450);
            this.panelPagamentoInfo.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Valor Total";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValorTotal.Location = new System.Drawing.Point(9, 43);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(100, 23);
            this.txtValorTotal.TabIndex = 14;
            // 
            // FormInformacoesAdicionaisEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProdutosSaida);
            this.Controls.Add(this.panelSaidaInfo);
            this.Controls.Add(this.panelPagamentoInfo);
            this.Name = "FormInformacoesAdicionaisEntrada";
            this.Text = "FormInformacoesAdicionaisEntrada";
            this.Load += new System.EventHandler(this.FormInformacoesAdicionaisEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosSaida)).EndInit();
            this.panelSaidaInfo.ResumeLayout(false);
            this.panelSaidaInfo.PerformLayout();
            this.panelPagamentoInfo.ResumeLayout(false);
            this.panelPagamentoInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvProdutosSaida;
        private Panel panelSaidaInfo;
        private TextBox txtData;
        private Label label7;
        private TextBox txtFuncionario;
        private TextBox txtID;
        private Label label2;
        private Label label4;
        private TextBox txtFornecedor;
        private Label label1;
        private Panel panelPagamentoInfo;
        private Label label8;
        private TextBox txtValorTotal;
        private DataGridViewTextBoxColumn EntradaProduto;
        private DataGridViewTextBoxColumn EntradaQuantidade;
        private DataGridViewTextBoxColumn EntradaValorUnitario;
    }
}