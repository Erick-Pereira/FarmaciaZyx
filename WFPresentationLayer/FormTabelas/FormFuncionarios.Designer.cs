namespace WFPresentationLayer
{
    partial class FormFuncionarios
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
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.FuncionariosID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionariosNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionariosCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionariosRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionariosTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionariosEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionariosTipoFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMenuFuncionarios = new System.Windows.Forms.Panel();
            this.btnTabelaFuncionarios = new System.Windows.Forms.Button();
            this.btnUpdateFuncionario = new System.Windows.Forms.Button();
            this.btnDeleteFuncionario = new System.Windows.Forms.Button();
            this.btnCadastroFuncionario = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDesktopFuncionarios = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.panelMenuFuncionarios.SuspendLayout();
            this.panelDesktopFuncionarios.SuspendLayout();
            this.SuspendLayout();
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
            this.dgvFuncionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFuncionarios.Location = new System.Drawing.Point(0, 0);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.RowHeadersVisible = false;
            this.dgvFuncionarios.RowTemplate.Height = 25;
            this.dgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionarios.Size = new System.Drawing.Size(681, 456);
            this.dgvFuncionarios.TabIndex = 0;
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
            // panelMenuFuncionarios
            // 
            this.panelMenuFuncionarios.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelMenuFuncionarios.Controls.Add(this.btnTabelaFuncionarios);
            this.panelMenuFuncionarios.Controls.Add(this.btnUpdateFuncionario);
            this.panelMenuFuncionarios.Controls.Add(this.btnDeleteFuncionario);
            this.panelMenuFuncionarios.Controls.Add(this.btnCadastroFuncionario);
            this.panelMenuFuncionarios.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenuFuncionarios.Location = new System.Drawing.Point(681, 0);
            this.panelMenuFuncionarios.Name = "panelMenuFuncionarios";
            this.panelMenuFuncionarios.Size = new System.Drawing.Size(98, 456);
            this.panelMenuFuncionarios.TabIndex = 1;
            // 
            // btnTabelaFuncionarios
            // 
            this.btnTabelaFuncionarios.BackColor = System.Drawing.Color.Transparent;
            this.btnTabelaFuncionarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTabelaFuncionarios.FlatAppearance.BorderSize = 0;
            this.btnTabelaFuncionarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTabelaFuncionarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTabelaFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabelaFuncionarios.ForeColor = System.Drawing.Color.White;
            this.btnTabelaFuncionarios.Location = new System.Drawing.Point(6, 12);
            this.btnTabelaFuncionarios.Name = "btnTabelaFuncionarios";
            this.btnTabelaFuncionarios.Size = new System.Drawing.Size(92, 59);
            this.btnTabelaFuncionarios.TabIndex = 19;
            this.btnTabelaFuncionarios.Text = "Tabela Funcionarios";
            this.btnTabelaFuncionarios.UseMnemonic = false;
            this.btnTabelaFuncionarios.UseVisualStyleBackColor = false;
            this.btnTabelaFuncionarios.Click += new System.EventHandler(this.btnTabelaFuncionarios_Click);
            // 
            // btnUpdateFuncionario
            // 
            this.btnUpdateFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateFuncionario.FlatAppearance.BorderSize = 0;
            this.btnUpdateFuncionario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnUpdateFuncionario.Location = new System.Drawing.Point(3, 111);
            this.btnUpdateFuncionario.Name = "btnUpdateFuncionario";
            this.btnUpdateFuncionario.Size = new System.Drawing.Size(92, 59);
            this.btnUpdateFuncionario.TabIndex = 17;
            this.btnUpdateFuncionario.Text = "Update Funcionario";
            this.btnUpdateFuncionario.UseMnemonic = false;
            this.btnUpdateFuncionario.UseVisualStyleBackColor = false;
            this.btnUpdateFuncionario.Click += new System.EventHandler(this.btnUpdateFuncionario_Click);
            // 
            // btnDeleteFuncionario
            // 
            this.btnDeleteFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteFuncionario.FlatAppearance.BorderSize = 0;
            this.btnDeleteFuncionario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFuncionario.Location = new System.Drawing.Point(3, 164);
            this.btnDeleteFuncionario.Name = "btnDeleteFuncionario";
            this.btnDeleteFuncionario.Size = new System.Drawing.Size(92, 59);
            this.btnDeleteFuncionario.TabIndex = 16;
            this.btnDeleteFuncionario.Text = "Delete Funcionario";
            this.btnDeleteFuncionario.UseMnemonic = false;
            this.btnDeleteFuncionario.UseVisualStyleBackColor = false;
            this.btnDeleteFuncionario.Click += new System.EventHandler(this.btnDeleteFuncionario_Click);
            // 
            // btnCadastroFuncionario
            // 
            this.btnCadastroFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastroFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastroFuncionario.FlatAppearance.BorderSize = 0;
            this.btnCadastroFuncionario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCadastroFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCadastroFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnCadastroFuncionario.Location = new System.Drawing.Point(3, 64);
            this.btnCadastroFuncionario.Name = "btnCadastroFuncionario";
            this.btnCadastroFuncionario.Size = new System.Drawing.Size(92, 59);
            this.btnCadastroFuncionario.TabIndex = 15;
            this.btnCadastroFuncionario.Text = "Cadastro Funcionario";
            this.btnCadastroFuncionario.UseMnemonic = false;
            this.btnCadastroFuncionario.UseVisualStyleBackColor = false;
            this.btnCadastroFuncionario.Click += new System.EventHandler(this.btnCadastroFuncionario_Click);
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            // 
            // RG
            // 
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "RG";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // panelDesktopFuncionarios
            // 
            this.panelDesktopFuncionarios.Controls.Add(this.dgvFuncionarios);
            this.panelDesktopFuncionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopFuncionarios.Location = new System.Drawing.Point(0, 0);
            this.panelDesktopFuncionarios.Name = "panelDesktopFuncionarios";
            this.panelDesktopFuncionarios.Size = new System.Drawing.Size(681, 456);
            this.panelDesktopFuncionarios.TabIndex = 2;
            // 
            // FormFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 456);
            this.Controls.Add(this.panelDesktopFuncionarios);
            this.Controls.Add(this.panelMenuFuncionarios);
            this.Name = "FormFuncionarios";
            this.Text = "FormFuncionarios";
            this.Load += new System.EventHandler(this.FormFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.panelMenuFuncionarios.ResumeLayout(false);
            this.panelDesktopFuncionarios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvFuncionarios;
        private Panel panelMenuFuncionarios;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn CPF;
        private DataGridViewTextBoxColumn RG;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn FuncionariosID;
        private DataGridViewTextBoxColumn FuncionariosNome;
        private DataGridViewTextBoxColumn FuncionariosCPF;
        private DataGridViewTextBoxColumn FuncionariosRG;
        private DataGridViewTextBoxColumn FuncionariosTelefone;
        private DataGridViewTextBoxColumn FuncionariosEmail;
        private DataGridViewTextBoxColumn FuncionariosTipoFuncionario;
        private Button btnUpdateFuncionario;
        private Button btnDeleteFuncionario;
        private Button btnCadastroFuncionario;
        private Panel panelDesktopFuncionarios;
        private Button btnTabelaFuncionarios;
    }
}