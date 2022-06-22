namespace WFPresentationLayer
{
    partial class FormProdutos
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
            this.btnUpdateProduto = new System.Windows.Forms.Button();
            this.btnDeleteProduto = new System.Windows.Forms.Button();
            this.btnCadastroProduto = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.ProdutosID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutosNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutosDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutosQtdEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutosLaboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutosTipoUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutosValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDesktopProdutos = new System.Windows.Forms.Panel();
            this.panelMenuProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.panelDesktopProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuProdutos
            // 
            this.panelMenuProdutos.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelMenuProdutos.Controls.Add(this.btnUpdateProduto);
            this.panelMenuProdutos.Controls.Add(this.btnDeleteProduto);
            this.panelMenuProdutos.Controls.Add(this.btnCadastroProduto);
            this.panelMenuProdutos.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenuProdutos.Location = new System.Drawing.Point(681, 0);
            this.panelMenuProdutos.Name = "panelMenuProdutos";
            this.panelMenuProdutos.Size = new System.Drawing.Size(98, 456);
            this.panelMenuProdutos.TabIndex = 4;
            // 
            // btnUpdateProduto
            // 
            this.btnUpdateProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateProduto.FlatAppearance.BorderSize = 0;
            this.btnUpdateProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProduto.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProduto.Location = new System.Drawing.Point(3, 87);
            this.btnUpdateProduto.Name = "btnUpdateProduto";
            this.btnUpdateProduto.Size = new System.Drawing.Size(92, 59);
            this.btnUpdateProduto.TabIndex = 17;
            this.btnUpdateProduto.Text = "Update Produto";
            this.btnUpdateProduto.UseMnemonic = false;
            this.btnUpdateProduto.UseVisualStyleBackColor = false;
            // 
            // btnDeleteProduto
            // 
            this.btnDeleteProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteProduto.FlatAppearance.BorderSize = 0;
            this.btnDeleteProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduto.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduto.Location = new System.Drawing.Point(6, 152);
            this.btnDeleteProduto.Name = "btnDeleteProduto";
            this.btnDeleteProduto.Size = new System.Drawing.Size(92, 59);
            this.btnDeleteProduto.TabIndex = 16;
            this.btnDeleteProduto.Text = "Delete Produto";
            this.btnDeleteProduto.UseMnemonic = false;
            this.btnDeleteProduto.UseVisualStyleBackColor = false;
            this.btnDeleteProduto.Click += new System.EventHandler(this.btnDeleteProduto_Click);
            // 
            // btnCadastroProduto
            // 
            this.btnCadastroProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastroProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastroProduto.FlatAppearance.BorderSize = 0;
            this.btnCadastroProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCadastroProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCadastroProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroProduto.ForeColor = System.Drawing.Color.White;
            this.btnCadastroProduto.Location = new System.Drawing.Point(3, 22);
            this.btnCadastroProduto.Name = "btnCadastroProduto";
            this.btnCadastroProduto.Size = new System.Drawing.Size(92, 59);
            this.btnCadastroProduto.TabIndex = 15;
            this.btnCadastroProduto.Text = "Cadastro Produto";
            this.btnCadastroProduto.UseMnemonic = false;
            this.btnCadastroProduto.UseVisualStyleBackColor = false;
            this.btnCadastroProduto.Click += new System.EventHandler(this.btnCadastroProduto_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdutosID,
            this.ProdutosNome,
            this.ProdutosDescricao,
            this.ProdutosQtdEstoque,
            this.ProdutosLaboratorio,
            this.ProdutosTipoUnidade,
            this.ProdutosValor});
            this.dgvProdutos.Location = new System.Drawing.Point(0, 22);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.RowTemplate.Height = 25;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(710, 523);
            this.dgvProdutos.TabIndex = 3;
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
            // panelDesktopProdutos
            // 
            this.panelDesktopProdutos.Controls.Add(this.dgvProdutos);
            this.panelDesktopProdutos.Location = new System.Drawing.Point(0, -22);
            this.panelDesktopProdutos.Name = "panelDesktopProdutos";
            this.panelDesktopProdutos.Size = new System.Drawing.Size(795, 495);
            this.panelDesktopProdutos.TabIndex = 5;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 456);
            this.Controls.Add(this.panelMenuProdutos);
            this.Controls.Add(this.panelDesktopProdutos);
            this.Name = "FormProdutos";
            this.Text = "FormProdutos";
            this.Load += new System.EventHandler(this.FormProdutos_Load);
            this.panelMenuProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.panelDesktopProdutos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenuProdutos;
        private Button btnUpdateProduto;
        private Button btnDeleteProduto;
        private Button btnCadastroProduto;
        private DataGridView dgvProdutos;
        private Panel panelDesktopProdutos;
        private DataGridViewTextBoxColumn ProdutosID;
        private DataGridViewTextBoxColumn ProdutosNome;
        private DataGridViewTextBoxColumn ProdutosDescricao;
        private DataGridViewTextBoxColumn ProdutosQtdEstoque;
        private DataGridViewTextBoxColumn ProdutosLaboratorio;
        private DataGridViewTextBoxColumn ProdutosTipoUnidade;
        private DataGridViewTextBoxColumn ProdutosValor;
    }
}