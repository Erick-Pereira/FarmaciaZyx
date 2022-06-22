namespace WFPresentationLayer
{
    partial class FormFornecedores
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
            this.panelMenuProdutos = new System.Windows.Forms.Panel();
            this.btnUpdateFornecedor = new System.Windows.Forms.Button();
            this.btnDeleteFornecedor = new System.Windows.Forms.Button();
            this.btnCadastroFornecedor = new System.Windows.Forms.Button();
            this.panelDesktopProdutos = new System.Windows.Forms.Panel();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.ProdutosID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutosNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutosDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutosQtdEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutosLaboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutosTipoUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutosValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMenuProdutos.SuspendLayout();
            this.panelDesktopProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuProdutos
            // 
            this.panelMenuProdutos.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelMenuProdutos.Controls.Add(this.btnUpdateFornecedor);
            this.panelMenuProdutos.Controls.Add(this.btnDeleteFornecedor);
            this.panelMenuProdutos.Controls.Add(this.btnCadastroFornecedor);
            this.panelMenuProdutos.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenuProdutos.Location = new System.Drawing.Point(702, 0);
            this.panelMenuProdutos.Name = "panelMenuProdutos";
            this.panelMenuProdutos.Size = new System.Drawing.Size(98, 450);
            this.panelMenuProdutos.TabIndex = 6;
            // 
            // btnUpdateFornecedor
            // 
            this.btnUpdateFornecedor.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateFornecedor.FlatAppearance.BorderSize = 0;
            this.btnUpdateFornecedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnUpdateFornecedor.Location = new System.Drawing.Point(3, 87);
            this.btnUpdateFornecedor.Name = "btnUpdateFornecedor";
            this.btnUpdateFornecedor.Size = new System.Drawing.Size(92, 59);
            this.btnUpdateFornecedor.TabIndex = 17;
            this.btnUpdateFornecedor.Text = "Update Fornecedor";
            this.btnUpdateFornecedor.UseMnemonic = false;
            this.btnUpdateFornecedor.UseVisualStyleBackColor = false;
            // 
            // btnDeleteFornecedor
            // 
            this.btnDeleteFornecedor.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteFornecedor.FlatAppearance.BorderSize = 0;
            this.btnDeleteFornecedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFornecedor.Location = new System.Drawing.Point(6, 152);
            this.btnDeleteFornecedor.Name = "btnDeleteFornecedor";
            this.btnDeleteFornecedor.Size = new System.Drawing.Size(92, 59);
            this.btnDeleteFornecedor.TabIndex = 16;
            this.btnDeleteFornecedor.Text = "Delete Fornecedor";
            this.btnDeleteFornecedor.UseMnemonic = false;
            this.btnDeleteFornecedor.UseVisualStyleBackColor = false;
            // 
            // btnCadastroFornecedor
            // 
            this.btnCadastroFornecedor.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastroFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastroFornecedor.FlatAppearance.BorderSize = 0;
            this.btnCadastroFornecedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCadastroFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCadastroFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnCadastroFornecedor.Location = new System.Drawing.Point(3, 22);
            this.btnCadastroFornecedor.Name = "btnCadastroFornecedor";
            this.btnCadastroFornecedor.Size = new System.Drawing.Size(92, 59);
            this.btnCadastroFornecedor.TabIndex = 15;
            this.btnCadastroFornecedor.Text = "Cadastro  Fornecedor";
            this.btnCadastroFornecedor.UseMnemonic = false;
            this.btnCadastroFornecedor.UseVisualStyleBackColor = false;
            // 
            // panelDesktopProdutos
            // 
            this.panelDesktopProdutos.Controls.Add(this.dgvFuncionarios);
            this.panelDesktopProdutos.Location = new System.Drawing.Point(0, -22);
            this.panelDesktopProdutos.Name = "panelDesktopProdutos";
            this.panelDesktopProdutos.Size = new System.Drawing.Size(795, 495);
            this.panelDesktopProdutos.TabIndex = 7;
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFuncionarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvFuncionarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdutosID,
            this.ProdutosNome,
            this.ProdutosDescricao,
            this.ProdutosQtdEstoque,
            this.ProdutosLaboratorio,
            this.ProdutosTipoUnidade,
            this.ProdutosValor});
            this.dgvFuncionarios.Location = new System.Drawing.Point(0, 22);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.RowHeadersVisible = false;
            this.dgvFuncionarios.RowTemplate.Height = 25;
            this.dgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionarios.Size = new System.Drawing.Size(710, 523);
            this.dgvFuncionarios.TabIndex = 3;
            // 
            // ProdutosID
            // 
            this.ProdutosID.HeaderText = "ID";
            this.ProdutosID.Name = "ProdutosID";
            this.ProdutosID.ReadOnly = true;
            // 
            // ProdutosNome
            // 
            this.ProdutosNome.HeaderText = "Nome";
            this.ProdutosNome.Name = "ProdutosNome";
            this.ProdutosNome.ReadOnly = true;
            // 
            // ProdutosDescricao
            // 
            this.ProdutosDescricao.HeaderText = "Descrição";
            this.ProdutosDescricao.Name = "ProdutosDescricao";
            this.ProdutosDescricao.ReadOnly = true;
            // 
            // ProdutosQtdEstoque
            // 
            this.ProdutosQtdEstoque.HeaderText = "Qtde Estoque";
            this.ProdutosQtdEstoque.Name = "ProdutosQtdEstoque";
            this.ProdutosQtdEstoque.ReadOnly = true;
            // 
            // ProdutosLaboratorio
            // 
            this.ProdutosLaboratorio.HeaderText = "Laboratorio";
            this.ProdutosLaboratorio.Name = "ProdutosLaboratorio";
            this.ProdutosLaboratorio.ReadOnly = true;
            // 
            // ProdutosTipoUnidade
            // 
            this.ProdutosTipoUnidade.HeaderText = "Un";
            this.ProdutosTipoUnidade.Name = "ProdutosTipoUnidade";
            this.ProdutosTipoUnidade.ReadOnly = true;
            // 
            // ProdutosValor
            // 
            this.ProdutosValor.HeaderText = "Valor";
            this.ProdutosValor.Name = "ProdutosValor";
            this.ProdutosValor.ReadOnly = true;
            // 
            // FormFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMenuProdutos);
            this.Controls.Add(this.panelDesktopProdutos);
            this.Name = "FormFornecedores";
            this.Text = "FormFornecedores";
            this.panelMenuProdutos.ResumeLayout(false);
            this.panelDesktopProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenuProdutos;
        private Button btnUpdateFornecedor;
        private Button btnDeleteFornecedor;
        private Button btnCadastroFornecedor;
        private Panel panelDesktopProdutos;
        private DataGridView dgvFuncionarios;
        private DataGridViewTextBoxColumn ProdutosID;
        private DataGridViewTextBoxColumn ProdutosNome;
        private DataGridViewTextBoxColumn ProdutosDescricao;
        private DataGridViewTextBoxColumn ProdutosQtdEstoque;
        private DataGridViewTextBoxColumn ProdutosLaboratorio;
        private DataGridViewTextBoxColumn ProdutosTipoUnidade;
        private DataGridViewTextBoxColumn ProdutosValor;
    }
}