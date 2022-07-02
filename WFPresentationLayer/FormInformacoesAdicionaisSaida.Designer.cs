namespace WFPresentationLayer
{
    partial class FormInformacoesAdicionaisSaida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformacoesAdicionaisSaida));
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFormaPagamento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.panelSaidaInfo = new System.Windows.Forms.Panel();
            this.panelPagamentoInfo = new System.Windows.Forms.Panel();
            this.dgvProdutosSaida = new System.Windows.Forms.DataGridView();
            this.SaidaProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaidaQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaidaValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSaidaInfo.SuspendLayout();
            this.panelPagamentoInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosSaida)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(96, 43);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(128, 23);
            this.txtCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
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
            // txtFuncionario
            // 
            this.txtFuncionario.Enabled = false;
            this.txtFuncionario.Location = new System.Drawing.Point(230, 43);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(100, 23);
            this.txtFuncionario.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(9, 87);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 23);
            this.txtValor.TabIndex = 4;
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
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(338, 43);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(123, 23);
            this.txtData.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Desconto";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Enabled = false;
            this.txtDesconto.Location = new System.Drawing.Point(9, 131);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(100, 23);
            this.txtDesconto.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Forma Pagamento";
            // 
            // txtFormaPagamento
            // 
            this.txtFormaPagamento.Enabled = false;
            this.txtFormaPagamento.Location = new System.Drawing.Point(9, 43);
            this.txtFormaPagamento.Name = "txtFormaPagamento";
            this.txtFormaPagamento.Size = new System.Drawing.Size(100, 23);
            this.txtFormaPagamento.TabIndex = 10;
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
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(12, 22);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(44, 23);
            this.txtID.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 157);
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
            this.txtValorTotal.Location = new System.Drawing.Point(9, 175);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(100, 23);
            this.txtValorTotal.TabIndex = 14;
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
            this.panelSaidaInfo.Controls.Add(this.txtCliente);
            this.panelSaidaInfo.Controls.Add(this.label1);
            this.panelSaidaInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSaidaInfo.Location = new System.Drawing.Point(0, 0);
            this.panelSaidaInfo.Name = "panelSaidaInfo";
            this.panelSaidaInfo.Size = new System.Drawing.Size(688, 77);
            this.panelSaidaInfo.TabIndex = 17;
            // 
            // panelPagamentoInfo
            // 
            this.panelPagamentoInfo.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelPagamentoInfo.Controls.Add(this.txtFormaPagamento);
            this.panelPagamentoInfo.Controls.Add(this.label8);
            this.panelPagamentoInfo.Controls.Add(this.label6);
            this.panelPagamentoInfo.Controls.Add(this.txtValorTotal);
            this.panelPagamentoInfo.Controls.Add(this.txtValor);
            this.panelPagamentoInfo.Controls.Add(this.label3);
            this.panelPagamentoInfo.Controls.Add(this.txtDesconto);
            this.panelPagamentoInfo.Controls.Add(this.label5);
            this.panelPagamentoInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPagamentoInfo.Location = new System.Drawing.Point(688, 0);
            this.panelPagamentoInfo.Name = "panelPagamentoInfo";
            this.panelPagamentoInfo.Size = new System.Drawing.Size(112, 450);
            this.panelPagamentoInfo.TabIndex = 18;
            // 
            // dgvProdutosSaida
            // 
            this.dgvProdutosSaida.AllowUserToAddRows = false;
            this.dgvProdutosSaida.AllowUserToDeleteRows = false;
            this.dgvProdutosSaida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutosSaida.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutosSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosSaida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaidaProduto,
            this.SaidaQuantidade,
            this.SaidaValorUnitario});
            this.dgvProdutosSaida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutosSaida.Location = new System.Drawing.Point(0, 77);
            this.dgvProdutosSaida.Name = "dgvProdutosSaida";
            this.dgvProdutosSaida.ReadOnly = true;
            this.dgvProdutosSaida.RowTemplate.Height = 25;
            this.dgvProdutosSaida.Size = new System.Drawing.Size(688, 373);
            this.dgvProdutosSaida.TabIndex = 19;
            // 
            // SaidaProduto
            // 
            this.SaidaProduto.HeaderText = "Produto";
            this.SaidaProduto.Name = "SaidaProduto";
            this.SaidaProduto.ReadOnly = true;
            // 
            // SaidaQuantidade
            // 
            this.SaidaQuantidade.HeaderText = "Quantidade";
            this.SaidaQuantidade.Name = "SaidaQuantidade";
            this.SaidaQuantidade.ReadOnly = true;
            // 
            // SaidaValorUnitario
            // 
            this.SaidaValorUnitario.HeaderText = "ValorUnitario";
            this.SaidaValorUnitario.Name = "SaidaValorUnitario";
            this.SaidaValorUnitario.ReadOnly = true;
            // 
            // FormInformacoesAdicionaisSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProdutosSaida);
            this.Controls.Add(this.panelSaidaInfo);
            this.Controls.Add(this.panelPagamentoInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInformacoesAdicionaisSaida";
            this.Text = "Informações Adicionais";
            this.Load += new System.EventHandler(this.FormInformacoesAdicionaisSaida_Load);
            this.panelSaidaInfo.ResumeLayout(false);
            this.panelSaidaInfo.PerformLayout();
            this.panelPagamentoInfo.ResumeLayout(false);
            this.panelPagamentoInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosSaida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtCliente;
        private Label label1;
        private Label label2;
        private TextBox txtFuncionario;
        private Label label3;
        private TextBox txtValor;
        private Label label4;
        private TextBox txtData;
        private Label label5;
        private TextBox txtDesconto;
        private Label label6;
        private TextBox txtFormaPagamento;
        private Label label7;
        private TextBox txtID;
        private Label label8;
        private TextBox txtValorTotal;
        private Panel panelSaidaInfo;
        private Panel panelPagamentoInfo;
        private DataGridView dgvProdutosSaida;
        private DataGridViewTextBoxColumn SaidaProduto;
        private DataGridViewTextBoxColumn SaidaQuantidade;
        private DataGridViewTextBoxColumn SaidaValorUnitario;
    }
}