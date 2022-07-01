namespace WFPresentationLayer
{
    partial class FormRegistroSaida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistroSaida));
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataSaida = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRetirarProduto = new System.Windows.Forms.Button();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudQtde = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.dgvProdutosSaida = new System.Windows.Forms.DataGridView();
            this.ProdutosSaidaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutosSaidaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutosSaidaUn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutosSaidaQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutosSaidaValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutosSaidaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCadastroNovoCliente = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbFormaPamento = new System.Windows.Forms.ComboBox();
            this.btnRegistrarVenda = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDescontoPorc = new System.Windows.Forms.TextBox();
            this.txtDescontoRs = new System.Windows.Forms.TextBox();
            this.txtNumItens = new System.Windows.Forms.TextBox();
            this.txtTotalPago = new System.Windows.Forms.TextBox();
            this.btnAdicionarCliente = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.mtxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosSaida)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(664, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 15);
            this.label10.TabIndex = 35;
            this.label10.Text = "Total Pago";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(664, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 34;
            this.label9.Text = "n itens";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(664, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "Desconto(R$)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(664, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "Desconto(%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(664, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Data Saida";
            // 
            // dtpDataSaida
            // 
            this.dtpDataSaida.Location = new System.Drawing.Point(200, 47);
            this.dtpDataSaida.Name = "dtpDataSaida";
            this.dtpDataSaida.Size = new System.Drawing.Size(200, 23);
            this.dtpDataSaida.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cliente";
            // 
            // btnRetirarProduto
            // 
            this.btnRetirarProduto.Location = new System.Drawing.Point(406, 120);
            this.btnRetirarProduto.Name = "btnRetirarProduto";
            this.btnRetirarProduto.Size = new System.Drawing.Size(122, 24);
            this.btnRetirarProduto.TabIndex = 49;
            this.btnRetirarProduto.Text = "Retirar Produto";
            this.btnRetirarProduto.UseVisualStyleBackColor = true;
            this.btnRetirarProduto.Click += new System.EventHandler(this.btnRetirarProduto_Click);
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Location = new System.Drawing.Point(406, 146);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(122, 24);
            this.btnAdicionarProduto.TabIndex = 48;
            this.btnAdicionarProduto.Text = "Adicionar Produto";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // txtUnidade
            // 
            this.txtUnidade.Location = new System.Drawing.Point(232, 148);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.ReadOnly = true;
            this.txtUnidade.Size = new System.Drawing.Size(44, 23);
            this.txtUnidade.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 46;
            this.label5.Text = "Un";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 45;
            this.label4.Text = "Qtde.";
            // 
            // nudQtde
            // 
            this.nudQtde.Location = new System.Drawing.Point(155, 148);
            this.nudQtde.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudQtde.Name = "nudQtde";
            this.nudQtde.Size = new System.Drawing.Size(74, 23);
            this.nudQtde.TabIndex = 44;
            this.nudQtde.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 43;
            this.label3.Text = "Produto";
            // 
            // cmbProduto
            // 
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(279, 148);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(121, 23);
            this.cmbProduto.TabIndex = 42;
            this.cmbProduto.SelectedIndexChanged += new System.EventHandler(this.cmbProduto_SelectedIndexChanged_1);
            // 
            // dgvProdutosSaida
            // 
            this.dgvProdutosSaida.AllowUserToAddRows = false;
            this.dgvProdutosSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosSaida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdutosSaidaID,
            this.ProdutosSaidaNome,
            this.ProdutosSaidaUn,
            this.ProdutosSaidaQtde,
            this.ProdutosSaidaValor,
            this.ProdutosSaidaTotal});
            this.dgvProdutosSaida.Location = new System.Drawing.Point(27, 177);
            this.dgvProdutosSaida.Name = "dgvProdutosSaida";
            this.dgvProdutosSaida.ReadOnly = true;
            this.dgvProdutosSaida.RowTemplate.Height = 25;
            this.dgvProdutosSaida.Size = new System.Drawing.Size(501, 147);
            this.dgvProdutosSaida.TabIndex = 50;
            // 
            // ProdutosSaidaID
            // 
            this.ProdutosSaidaID.HeaderText = "ID";
            this.ProdutosSaidaID.Name = "ProdutosSaidaID";
            this.ProdutosSaidaID.ReadOnly = true;
            // 
            // ProdutosSaidaNome
            // 
            this.ProdutosSaidaNome.HeaderText = "Nome";
            this.ProdutosSaidaNome.Name = "ProdutosSaidaNome";
            this.ProdutosSaidaNome.ReadOnly = true;
            // 
            // ProdutosSaidaUn
            // 
            this.ProdutosSaidaUn.HeaderText = "Un";
            this.ProdutosSaidaUn.Name = "ProdutosSaidaUn";
            this.ProdutosSaidaUn.ReadOnly = true;
            // 
            // ProdutosSaidaQtde
            // 
            this.ProdutosSaidaQtde.HeaderText = "Qtde";
            this.ProdutosSaidaQtde.Name = "ProdutosSaidaQtde";
            this.ProdutosSaidaQtde.ReadOnly = true;
            // 
            // ProdutosSaidaValor
            // 
            this.ProdutosSaidaValor.HeaderText = "Valor";
            this.ProdutosSaidaValor.Name = "ProdutosSaidaValor";
            this.ProdutosSaidaValor.ReadOnly = true;
            // 
            // ProdutosSaidaTotal
            // 
            this.ProdutosSaidaTotal.HeaderText = "Total";
            this.ProdutosSaidaTotal.Name = "ProdutosSaidaTotal";
            this.ProdutosSaidaTotal.ReadOnly = true;
            // 
            // btnCadastroNovoCliente
            // 
            this.btnCadastroNovoCliente.Location = new System.Drawing.Point(537, 415);
            this.btnCadastroNovoCliente.Name = "btnCadastroNovoCliente";
            this.btnCadastroNovoCliente.Size = new System.Drawing.Size(142, 23);
            this.btnCadastroNovoCliente.TabIndex = 51;
            this.btnCadastroNovoCliente.Text = "Cadastrar novo Cliente";
            this.btnCadastroNovoCliente.UseVisualStyleBackColor = true;
            this.btnCadastroNovoCliente.Click += new System.EventHandler(this.btnCadastroNovoCliente_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 339);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 15);
            this.label11.TabIndex = 53;
            this.label11.Text = "Forma de Pagamento";
            // 
            // cmbFormaPamento
            // 
            this.cmbFormaPamento.FormattingEnabled = true;
            this.cmbFormaPamento.Location = new System.Drawing.Point(27, 357);
            this.cmbFormaPamento.Name = "cmbFormaPamento";
            this.cmbFormaPamento.Size = new System.Drawing.Size(121, 23);
            this.cmbFormaPamento.TabIndex = 52;
            // 
            // btnRegistrarVenda
            // 
            this.btnRegistrarVenda.Location = new System.Drawing.Point(534, 301);
            this.btnRegistrarVenda.Name = "btnRegistrarVenda";
            this.btnRegistrarVenda.Size = new System.Drawing.Size(105, 23);
            this.btnRegistrarVenda.TabIndex = 54;
            this.btnRegistrarVenda.Text = "Registrar Venda";
            this.btnRegistrarVenda.UseVisualStyleBackColor = true;
            this.btnRegistrarVenda.Click += new System.EventHandler(this.btnRegistrarVenda_Click);
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(664, 36);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 23);
            this.txtValor.TabIndex = 55;
            // 
            // txtDescontoPorc
            // 
            this.txtDescontoPorc.Enabled = false;
            this.txtDescontoPorc.Location = new System.Drawing.Point(664, 80);
            this.txtDescontoPorc.Name = "txtDescontoPorc";
            this.txtDescontoPorc.Size = new System.Drawing.Size(100, 23);
            this.txtDescontoPorc.TabIndex = 56;
            // 
            // txtDescontoRs
            // 
            this.txtDescontoRs.Enabled = false;
            this.txtDescontoRs.Location = new System.Drawing.Point(664, 124);
            this.txtDescontoRs.Name = "txtDescontoRs";
            this.txtDescontoRs.Size = new System.Drawing.Size(100, 23);
            this.txtDescontoRs.TabIndex = 57;
            // 
            // txtNumItens
            // 
            this.txtNumItens.Enabled = false;
            this.txtNumItens.Location = new System.Drawing.Point(664, 168);
            this.txtNumItens.Name = "txtNumItens";
            this.txtNumItens.Size = new System.Drawing.Size(100, 23);
            this.txtNumItens.TabIndex = 58;
            // 
            // txtTotalPago
            // 
            this.txtTotalPago.Enabled = false;
            this.txtTotalPago.Location = new System.Drawing.Point(664, 212);
            this.txtTotalPago.Name = "txtTotalPago";
            this.txtTotalPago.Size = new System.Drawing.Size(100, 23);
            this.txtTotalPago.TabIndex = 59;
            // 
            // btnAdicionarCliente
            // 
            this.btnAdicionarCliente.Location = new System.Drawing.Point(502, 36);
            this.btnAdicionarCliente.Name = "btnAdicionarCliente";
            this.btnAdicionarCliente.Size = new System.Drawing.Size(75, 40);
            this.btnAdicionarCliente.TabIndex = 60;
            this.btnAdicionarCliente.Text = "Adicionar Cliente";
            this.btnAdicionarCliente.UseVisualStyleBackColor = true;
            this.btnAdicionarCliente.Click += new System.EventHandler(this.btnAdicionarCliente_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(406, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 15);
            this.label12.TabIndex = 61;
            this.label12.Text = "CPF Cliente";
            // 
            // mtxtCpf
            // 
            this.mtxtCpf.BackColor = System.Drawing.Color.White;
            this.mtxtCpf.Location = new System.Drawing.Point(406, 47);
            this.mtxtCpf.Mask = "000.000.000-00";
            this.mtxtCpf.Name = "mtxtCpf";
            this.mtxtCpf.Size = new System.Drawing.Size(90, 23);
            this.mtxtCpf.TabIndex = 62;
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(72, 46);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(119, 23);
            this.txtCliente.TabIndex = 63;
            // 
            // FormRegistroSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.mtxtCpf);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnAdicionarCliente);
            this.Controls.Add(this.txtTotalPago);
            this.Controls.Add(this.txtNumItens);
            this.Controls.Add(this.txtDescontoRs);
            this.Controls.Add(this.txtDescontoPorc);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnRegistrarVenda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbFormaPamento);
            this.Controls.Add(this.btnCadastroNovoCliente);
            this.Controls.Add(this.dgvProdutosSaida);
            this.Controls.Add(this.btnRetirarProduto);
            this.Controls.Add(this.btnAdicionarProduto);
            this.Controls.Add(this.txtUnidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudQtde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProduto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDataSaida);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegistroSaida";
            this.Text = "Registro Saida";
            this.Load += new System.EventHandler(this.FormRegistroSaida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQtde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosSaida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label2;
        private DateTimePicker dtpDataSaida;
        private Label label1;
        private Button btnRetirarProduto;
        private Button btnAdicionarProduto;
        private TextBox txtUnidade;
        private Label label5;
        private Label label4;
        private NumericUpDown nudQtde;
        private Label label3;
        private ComboBox cmbProduto;
        private DataGridView dgvProdutosSaida;
        private Button btnCadastroNovoCliente;
        private Label label11;
        private ComboBox cmbFormaPamento;
        private Button btnRegistrarVenda;
        private DataGridViewTextBoxColumn ProdutosSaidaID;
        private DataGridViewTextBoxColumn ProdutosSaidaNome;
        private DataGridViewTextBoxColumn ProdutosSaidaUn;
        private DataGridViewTextBoxColumn ProdutosSaidaQtde;
        private DataGridViewTextBoxColumn ProdutosSaidaValor;
        private DataGridViewTextBoxColumn ProdutosSaidaTotal;
        private TextBox txtValor;
        private TextBox txtDescontoPorc;
        private TextBox txtDescontoRs;
        private TextBox txtNumItens;
        private TextBox txtTotalPago;
        private Button btnAdicionarCliente;
        private Label label12;
        private MaskedTextBox mtxtCpf;
        private TextBox txtCliente;
    }
}