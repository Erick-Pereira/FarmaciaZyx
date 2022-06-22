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
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.FuncionariosID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionariosNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionariosCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionariosRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionariosTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionariosEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionariosTipoFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDesktopProdutos = new System.Windows.Forms.Panel();
            this.panelMenuProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
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
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.AllowUserToDeleteRows = false;
            this.dgvFuncionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFuncionarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvFuncionarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FuncionariosID,
            this.FuncionariosNome,
            this.FuncionariosCPF,
            this.FuncionariosRG,
            this.FuncionariosTelefone,
            this.FuncionariosEmail,
            this.FuncionariosTipoFuncionario});
            this.dgvFuncionarios.Location = new System.Drawing.Point(0, 22);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.RowHeadersVisible = false;
            this.dgvFuncionarios.RowTemplate.Height = 25;
            this.dgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionarios.Size = new System.Drawing.Size(711, 495);
            this.dgvFuncionarios.TabIndex = 3;
            // 
            // FuncionariosID
            // 
            this.FuncionariosID.HeaderText = "ID";
            this.FuncionariosID.Name = "FuncionariosID";
            this.FuncionariosID.ReadOnly = true;
            // 
            // FuncionariosNome
            // 
            this.FuncionariosNome.HeaderText = "Nome";
            this.FuncionariosNome.Name = "FuncionariosNome";
            this.FuncionariosNome.ReadOnly = true;
            // 
            // FuncionariosCPF
            // 
            this.FuncionariosCPF.HeaderText = "CPF";
            this.FuncionariosCPF.Name = "FuncionariosCPF";
            this.FuncionariosCPF.ReadOnly = true;
            // 
            // FuncionariosRG
            // 
            this.FuncionariosRG.HeaderText = "RG";
            this.FuncionariosRG.Name = "FuncionariosRG";
            this.FuncionariosRG.ReadOnly = true;
            // 
            // FuncionariosTelefone
            // 
            this.FuncionariosTelefone.HeaderText = "Telefone";
            this.FuncionariosTelefone.Name = "FuncionariosTelefone";
            this.FuncionariosTelefone.ReadOnly = true;
            // 
            // FuncionariosEmail
            // 
            this.FuncionariosEmail.HeaderText = "Email";
            this.FuncionariosEmail.Name = "FuncionariosEmail";
            this.FuncionariosEmail.ReadOnly = true;
            // 
            // FuncionariosTipoFuncionario
            // 
            this.FuncionariosTipoFuncionario.HeaderText = "Tipo Funcionario";
            this.FuncionariosTipoFuncionario.Name = "FuncionariosTipoFuncionario";
            this.FuncionariosTipoFuncionario.ReadOnly = true;
            // 
            // panelDesktopProdutos
            // 
            this.panelDesktopProdutos.Controls.Add(this.dgvFuncionarios);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.panelDesktopProdutos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenuProdutos;
        private Button btnUpdateProduto;
        private Button btnDeleteProduto;
        private Button btnCadastroProduto;
        private DataGridView dgvFuncionarios;
        private DataGridViewTextBoxColumn FuncionariosID;
        private DataGridViewTextBoxColumn FuncionariosNome;
        private DataGridViewTextBoxColumn FuncionariosCPF;
        private DataGridViewTextBoxColumn FuncionariosRG;
        private DataGridViewTextBoxColumn FuncionariosTelefone;
        private DataGridViewTextBoxColumn FuncionariosEmail;
        private DataGridViewTextBoxColumn FuncionariosTipoFuncionario;
        private Panel panelDesktopProdutos;
    }
}