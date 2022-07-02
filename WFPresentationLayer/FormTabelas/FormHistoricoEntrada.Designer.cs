namespace WFPresentationLayer
{
    partial class FormHistoricoEntrada
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
            this.btnTabelaEntrada = new System.Windows.Forms.Button();
            this.btnInformacoesEntrada = new System.Windows.Forms.Button();
            this.panelDesktopEntradas = new System.Windows.Forms.Panel();
            this.dgvEntradas = new System.Windows.Forms.DataGridView();
            this.EntradaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntradaFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntradaFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntradaData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntradaValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMenuFuncionarios.SuspendLayout();
            this.panelDesktopEntradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuFuncionarios
            // 
            this.panelMenuFuncionarios.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelMenuFuncionarios.Controls.Add(this.btnTabelaEntrada);
            this.panelMenuFuncionarios.Controls.Add(this.btnInformacoesEntrada);
            this.panelMenuFuncionarios.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenuFuncionarios.Location = new System.Drawing.Point(681, 0);
            this.panelMenuFuncionarios.Name = "panelMenuFuncionarios";
            this.panelMenuFuncionarios.Size = new System.Drawing.Size(98, 456);
            this.panelMenuFuncionarios.TabIndex = 4;
            // 
            // btnTabelaEntrada
            // 
            this.btnTabelaEntrada.BackColor = System.Drawing.Color.Transparent;
            this.btnTabelaEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTabelaEntrada.FlatAppearance.BorderSize = 0;
            this.btnTabelaEntrada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTabelaEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTabelaEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabelaEntrada.ForeColor = System.Drawing.Color.White;
            this.btnTabelaEntrada.Location = new System.Drawing.Point(6, 12);
            this.btnTabelaEntrada.Name = "btnTabelaEntrada";
            this.btnTabelaEntrada.Size = new System.Drawing.Size(92, 59);
            this.btnTabelaEntrada.TabIndex = 19;
            this.btnTabelaEntrada.Text = "Tabela Entrada";
            this.btnTabelaEntrada.UseMnemonic = false;
            this.btnTabelaEntrada.UseVisualStyleBackColor = false;
            this.btnTabelaEntrada.Click += new System.EventHandler(this.btnTabelaFuncionarios_Click);
            // 
            // btnInformacoesEntrada
            // 
            this.btnInformacoesEntrada.BackColor = System.Drawing.Color.Transparent;
            this.btnInformacoesEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInformacoesEntrada.FlatAppearance.BorderSize = 0;
            this.btnInformacoesEntrada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInformacoesEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInformacoesEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacoesEntrada.ForeColor = System.Drawing.Color.White;
            this.btnInformacoesEntrada.Location = new System.Drawing.Point(6, 77);
            this.btnInformacoesEntrada.Name = "btnInformacoesEntrada";
            this.btnInformacoesEntrada.Size = new System.Drawing.Size(92, 59);
            this.btnInformacoesEntrada.TabIndex = 16;
            this.btnInformacoesEntrada.Text = "Informações da Entrada";
            this.btnInformacoesEntrada.UseMnemonic = false;
            this.btnInformacoesEntrada.UseVisualStyleBackColor = false;
            this.btnInformacoesEntrada.Click += new System.EventHandler(this.btnInformacoesEntrada_Click);
            // 
            // panelDesktopEntradas
            // 
            this.panelDesktopEntradas.Controls.Add(this.dgvEntradas);
            this.panelDesktopEntradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopEntradas.Location = new System.Drawing.Point(0, 0);
            this.panelDesktopEntradas.Name = "panelDesktopEntradas";
            this.panelDesktopEntradas.Size = new System.Drawing.Size(681, 456);
            this.panelDesktopEntradas.TabIndex = 5;
            // 
            // dgvEntradas
            // 
            this.dgvEntradas.AllowUserToAddRows = false;
            this.dgvEntradas.AllowUserToDeleteRows = false;
            this.dgvEntradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEntradas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvEntradas.BackgroundColor = System.Drawing.Color.White;
            this.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EntradaID,
            this.EntradaFornecedor,
            this.EntradaFuncionario,
            this.EntradaData,
            this.EntradaValor});
            this.dgvEntradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEntradas.Location = new System.Drawing.Point(0, 0);
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.ReadOnly = true;
            this.dgvEntradas.RowHeadersVisible = false;
            this.dgvEntradas.RowTemplate.Height = 25;
            this.dgvEntradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntradas.Size = new System.Drawing.Size(681, 456);
            this.dgvEntradas.TabIndex = 7;
            // 
            // EntradaID
            // 
            this.EntradaID.HeaderText = "ID";
            this.EntradaID.Name = "EntradaID";
            this.EntradaID.ReadOnly = true;
            // 
            // EntradaFornecedor
            // 
            this.EntradaFornecedor.HeaderText = "Fornecedor";
            this.EntradaFornecedor.Name = "EntradaFornecedor";
            this.EntradaFornecedor.ReadOnly = true;
            // 
            // EntradaFuncionario
            // 
            this.EntradaFuncionario.HeaderText = "Funcionario";
            this.EntradaFuncionario.Name = "EntradaFuncionario";
            this.EntradaFuncionario.ReadOnly = true;
            // 
            // EntradaData
            // 
            this.EntradaData.HeaderText = "Data";
            this.EntradaData.Name = "EntradaData";
            this.EntradaData.ReadOnly = true;
            // 
            // EntradaValor
            // 
            this.EntradaValor.HeaderText = "Valor";
            this.EntradaValor.Name = "EntradaValor";
            this.EntradaValor.ReadOnly = true;
            // 
            // FormHistoricoEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 456);
            this.Controls.Add(this.panelDesktopEntradas);
            this.Controls.Add(this.panelMenuFuncionarios);
            this.Name = "FormHistoricoEntrada";
            this.Text = "FormHistoricoEntrada";
            this.Load += new System.EventHandler(this.FormHistoricoEntrada_Load);
            this.panelMenuFuncionarios.ResumeLayout(false);
            this.panelDesktopEntradas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenuFuncionarios;
        private Button btnTabelaEntrada;
        private Button btnInformacoesEntrada;
        private Panel panelDesktopEntradas;
        private DataGridView dgvEntradas;
        private DataGridViewTextBoxColumn EntradaID;
        private DataGridViewTextBoxColumn EntradaFornecedor;
        private DataGridViewTextBoxColumn EntradaFuncionario;
        private DataGridViewTextBoxColumn EntradaData;
        private DataGridViewTextBoxColumn EntradaValor;
    }
}