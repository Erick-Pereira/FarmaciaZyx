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
            this.panelDesktopFornecedores = new System.Windows.Forms.Panel();
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            this.FornecedoresID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FornecedoresRazaoSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FornecedoresCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FornecedoresNomeContato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FornecedoresTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FornecedoresEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMenuProdutos.SuspendLayout();
            this.panelDesktopFornecedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
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
            this.btnCadastroFornecedor.Click += new System.EventHandler(this.btnCadastroFornecedor_Click);
            // 
            // panelDesktopFornecedores
            // 
            this.panelDesktopFornecedores.Controls.Add(this.dgvFornecedores);
            this.panelDesktopFornecedores.Location = new System.Drawing.Point(0, -22);
            this.panelDesktopFornecedores.Name = "panelDesktopFornecedores";
            this.panelDesktopFornecedores.Size = new System.Drawing.Size(795, 495);
            this.panelDesktopFornecedores.TabIndex = 7;
            // 
            // dgvFornecedores
            // 
            this.dgvFornecedores.AllowUserToAddRows = false;
            this.dgvFornecedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFornecedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvFornecedores.BackgroundColor = System.Drawing.Color.White;
            this.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FornecedoresID,
            this.FornecedoresRazaoSocial,
            this.FornecedoresCNPJ,
            this.FornecedoresNomeContato,
            this.FornecedoresTelefone,
            this.FornecedoresEmail});
            this.dgvFornecedores.Location = new System.Drawing.Point(0, 22);
            this.dgvFornecedores.Name = "dgvFornecedores";
            this.dgvFornecedores.ReadOnly = true;
            this.dgvFornecedores.RowHeadersVisible = false;
            this.dgvFornecedores.RowTemplate.Height = 25;
            this.dgvFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedores.Size = new System.Drawing.Size(710, 523);
            this.dgvFornecedores.TabIndex = 3;
            // 
            // FornecedoresID
            // 
            this.FornecedoresID.HeaderText = "ID";
            this.FornecedoresID.Name = "FornecedoresID";
            this.FornecedoresID.ReadOnly = true;
            // 
            // FornecedoresRazaoSocial
            // 
            this.FornecedoresRazaoSocial.HeaderText = "Razão Social";
            this.FornecedoresRazaoSocial.Name = "FornecedoresRazaoSocial";
            this.FornecedoresRazaoSocial.ReadOnly = true;
            // 
            // FornecedoresCNPJ
            // 
            this.FornecedoresCNPJ.HeaderText = "CNPJ";
            this.FornecedoresCNPJ.Name = "FornecedoresCNPJ";
            this.FornecedoresCNPJ.ReadOnly = true;
            // 
            // FornecedoresNomeContato
            // 
            this.FornecedoresNomeContato.HeaderText = "Nome Contato";
            this.FornecedoresNomeContato.Name = "FornecedoresNomeContato";
            this.FornecedoresNomeContato.ReadOnly = true;
            // 
            // FornecedoresTelefone
            // 
            this.FornecedoresTelefone.HeaderText = "Telefone";
            this.FornecedoresTelefone.Name = "FornecedoresTelefone";
            this.FornecedoresTelefone.ReadOnly = true;
            // 
            // FornecedoresEmail
            // 
            this.FornecedoresEmail.HeaderText = "Email";
            this.FornecedoresEmail.Name = "FornecedoresEmail";
            this.FornecedoresEmail.ReadOnly = true;
            // 
            // FormFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMenuProdutos);
            this.Controls.Add(this.panelDesktopFornecedores);
            this.Name = "FormFornecedores";
            this.Text = "FormFornecedores";
            this.Load += new System.EventHandler(this.FormFornecedores_Load);
            this.panelMenuProdutos.ResumeLayout(false);
            this.panelDesktopFornecedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenuProdutos;
        private Button btnUpdateFornecedor;
        private Button btnDeleteFornecedor;
        private Button btnCadastroFornecedor;
        private Panel panelDesktopFornecedores;
        private DataGridView dgvFornecedores;
        private DataGridViewTextBoxColumn FornecedoresID;
        private DataGridViewTextBoxColumn FornecedoresRazaoSocial;
        private DataGridViewTextBoxColumn FornecedoresCNPJ;
        private DataGridViewTextBoxColumn FornecedoresNomeContato;
        private DataGridViewTextBoxColumn FornecedoresTelefone;
        private DataGridViewTextBoxColumn FornecedoresEmail;
    }
}