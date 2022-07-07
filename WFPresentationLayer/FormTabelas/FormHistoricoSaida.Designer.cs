namespace WFPresentationLayer
{
    partial class FormHistoricoSaida
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
            this.panelMenuFuncionarios = new System.Windows.Forms.Panel();
            this.btnTabelaSaida = new System.Windows.Forms.Button();
            this.btnInformacoesSaida = new System.Windows.Forms.Button();
            this.panelDesktopEntradas = new System.Windows.Forms.Panel();
            this.dgvSaidas = new System.Windows.Forms.DataGridView();
            this.SaidaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaidaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaidaFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaidaData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaidaFormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaidaValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaidaDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaidaValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFiltrarDatas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataSaída = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.panelMenuFuncionarios.SuspendLayout();
            this.panelDesktopEntradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaidas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuFuncionarios
            // 
            this.panelMenuFuncionarios.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelMenuFuncionarios.Controls.Add(this.btnFiltrarDatas);
            this.panelMenuFuncionarios.Controls.Add(this.label1);
            this.panelMenuFuncionarios.Controls.Add(this.dtpDataSaída);
            this.panelMenuFuncionarios.Controls.Add(this.label2);
            this.panelMenuFuncionarios.Controls.Add(this.dtpDataEntrada);
            this.panelMenuFuncionarios.Controls.Add(this.btnTabelaSaida);
            this.panelMenuFuncionarios.Controls.Add(this.btnInformacoesSaida);
            this.panelMenuFuncionarios.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenuFuncionarios.Location = new System.Drawing.Point(635, 0);
            this.panelMenuFuncionarios.Name = "panelMenuFuncionarios";
            this.panelMenuFuncionarios.Size = new System.Drawing.Size(144, 456);
            this.panelMenuFuncionarios.TabIndex = 7;
            // 
            // btnTabelaSaida
            // 
            this.btnTabelaSaida.BackColor = System.Drawing.Color.Transparent;
            this.btnTabelaSaida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTabelaSaida.FlatAppearance.BorderSize = 0;
            this.btnTabelaSaida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTabelaSaida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTabelaSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabelaSaida.ForeColor = System.Drawing.Color.White;
            this.btnTabelaSaida.Location = new System.Drawing.Point(6, 12);
            this.btnTabelaSaida.Name = "btnTabelaSaida";
            this.btnTabelaSaida.Size = new System.Drawing.Size(92, 59);
            this.btnTabelaSaida.TabIndex = 19;
            this.btnTabelaSaida.Text = "Tabela Saida";
            this.btnTabelaSaida.UseMnemonic = false;
            this.btnTabelaSaida.UseVisualStyleBackColor = false;
            this.btnTabelaSaida.Click += new System.EventHandler(this.btnTabelaSaida_Click);
            // 
            // btnInformacoesSaida
            // 
            this.btnInformacoesSaida.BackColor = System.Drawing.Color.Transparent;
            this.btnInformacoesSaida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInformacoesSaida.FlatAppearance.BorderSize = 0;
            this.btnInformacoesSaida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInformacoesSaida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInformacoesSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacoesSaida.ForeColor = System.Drawing.Color.White;
            this.btnInformacoesSaida.Location = new System.Drawing.Point(6, 77);
            this.btnInformacoesSaida.Name = "btnInformacoesSaida";
            this.btnInformacoesSaida.Size = new System.Drawing.Size(92, 59);
            this.btnInformacoesSaida.TabIndex = 16;
            this.btnInformacoesSaida.Text = "Informações da Saida";
            this.btnInformacoesSaida.UseMnemonic = false;
            this.btnInformacoesSaida.UseVisualStyleBackColor = false;
            this.btnInformacoesSaida.Click += new System.EventHandler(this.btnInformacoesSaida_Click);
            // 
            // panelDesktopEntradas
            // 
            this.panelDesktopEntradas.Controls.Add(this.dgvSaidas);
            this.panelDesktopEntradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopEntradas.Location = new System.Drawing.Point(0, 0);
            this.panelDesktopEntradas.Name = "panelDesktopEntradas";
            this.panelDesktopEntradas.Size = new System.Drawing.Size(635, 456);
            this.panelDesktopEntradas.TabIndex = 8;
            // 
            // dgvSaidas
            // 
            this.dgvSaidas.AllowUserToAddRows = false;
            this.dgvSaidas.AllowUserToDeleteRows = false;
            this.dgvSaidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSaidas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvSaidas.BackgroundColor = System.Drawing.Color.White;
            this.dgvSaidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaidaId,
            this.SaidaCliente,
            this.SaidaFuncionario,
            this.SaidaData,
            this.SaidaFormaPagamento,
            this.SaidaValor,
            this.SaidaDesconto,
            this.SaidaValorTotal});
            this.dgvSaidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSaidas.Location = new System.Drawing.Point(0, 0);
            this.dgvSaidas.Name = "dgvSaidas";
            this.dgvSaidas.ReadOnly = true;
            this.dgvSaidas.RowHeadersVisible = false;
            this.dgvSaidas.RowTemplate.Height = 25;
            this.dgvSaidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaidas.Size = new System.Drawing.Size(635, 456);
            this.dgvSaidas.TabIndex = 9;
            // 
            // SaidaId
            // 
            this.SaidaId.HeaderText = "ID";
            this.SaidaId.Name = "SaidaId";
            this.SaidaId.ReadOnly = true;
            // 
            // SaidaCliente
            // 
            this.SaidaCliente.HeaderText = "Cliente";
            this.SaidaCliente.Name = "SaidaCliente";
            this.SaidaCliente.ReadOnly = true;
            // 
            // SaidaFuncionario
            // 
            this.SaidaFuncionario.HeaderText = "Funcionario";
            this.SaidaFuncionario.Name = "SaidaFuncionario";
            this.SaidaFuncionario.ReadOnly = true;
            // 
            // SaidaData
            // 
            this.SaidaData.HeaderText = "Data";
            this.SaidaData.Name = "SaidaData";
            this.SaidaData.ReadOnly = true;
            // 
            // SaidaFormaPagamento
            // 
            this.SaidaFormaPagamento.HeaderText = "Forma Pagamento";
            this.SaidaFormaPagamento.Name = "SaidaFormaPagamento";
            this.SaidaFormaPagamento.ReadOnly = true;
            // 
            // SaidaValor
            // 
            this.SaidaValor.HeaderText = "Valor";
            this.SaidaValor.Name = "SaidaValor";
            this.SaidaValor.ReadOnly = true;
            // 
            // SaidaDesconto
            // 
            this.SaidaDesconto.HeaderText = "Desconto";
            this.SaidaDesconto.Name = "SaidaDesconto";
            this.SaidaDesconto.ReadOnly = true;
            // 
            // SaidaValorTotal
            // 
            this.SaidaValorTotal.HeaderText = "ValorTotal";
            this.SaidaValorTotal.Name = "SaidaValorTotal";
            this.SaidaValorTotal.ReadOnly = true;
            // 
            // btnFiltrarDatas
            // 
            this.btnFiltrarDatas.Location = new System.Drawing.Point(9, 279);
            this.btnFiltrarDatas.Name = "btnFiltrarDatas";
            this.btnFiltrarDatas.Size = new System.Drawing.Size(120, 23);
            this.btnFiltrarDatas.TabIndex = 47;
            this.btnFiltrarDatas.Text = "Filtrar Datas";
            this.btnFiltrarDatas.UseVisualStyleBackColor = true;
            this.btnFiltrarDatas.Click += new System.EventHandler(this.btnFiltrarDatas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 46;
            this.label1.Text = "Data Fim";
            // 
            // dtpDataSaída
            // 
            this.dtpDataSaída.Location = new System.Drawing.Point(9, 230);
            this.dtpDataSaída.Name = "dtpDataSaída";
            this.dtpDataSaída.Size = new System.Drawing.Size(129, 23);
            this.dtpDataSaída.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "Data inico";
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Location = new System.Drawing.Point(6, 175);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(129, 23);
            this.dtpDataEntrada.TabIndex = 43;
            // 
            // FormHistoricoSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 456);
            this.Controls.Add(this.panelDesktopEntradas);
            this.Controls.Add(this.panelMenuFuncionarios);
            this.Name = "FormHistoricoSaida";
            this.Text = "FormHistoricoSaida";
            this.Load += new System.EventHandler(this.FormHistoricoSaida_Load);
            this.panelMenuFuncionarios.ResumeLayout(false);
            this.panelMenuFuncionarios.PerformLayout();
            this.panelDesktopEntradas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenuFuncionarios;
        private Button btnTabelaSaida;
        private Button btnInformacoesSaida;
        private Panel panelDesktopEntradas;
        private DataGridView dgvSaidas;
        private DataGridViewTextBoxColumn SaidaId;
        private DataGridViewTextBoxColumn SaidaCliente;
        private DataGridViewTextBoxColumn SaidaFuncionario;
        private DataGridViewTextBoxColumn SaidaData;
        private DataGridViewTextBoxColumn SaidaFormaPagamento;
        private DataGridViewTextBoxColumn SaidaValor;
        private DataGridViewTextBoxColumn SaidaDesconto;
        private DataGridViewTextBoxColumn SaidaValorTotal;
        private Button btnFiltrarDatas;
        private Label label1;
        private DateTimePicker dtpDataSaída;
        private Label label2;
        private DateTimePicker dtpDataEntrada;
    }
}