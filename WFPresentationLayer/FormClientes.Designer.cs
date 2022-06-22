namespace WFPresentationLayer
{
    partial class FormClientes
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
            this.panelMenuClientes = new System.Windows.Forms.Panel();
            this.btnUpdateCliente = new System.Windows.Forms.Button();
            this.btnDeleteCliente = new System.Windows.Forms.Button();
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.ClientesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientesNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientesCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientesRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientesTelefone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientesTelefone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientesPontos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientesEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientesTipoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDesktopClientes = new System.Windows.Forms.Panel();
            this.panelMenuClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuClientes
            // 
            this.panelMenuClientes.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelMenuClientes.Controls.Add(this.btnUpdateCliente);
            this.panelMenuClientes.Controls.Add(this.btnDeleteCliente);
            this.panelMenuClientes.Controls.Add(this.btnCadastroCliente);
            this.panelMenuClientes.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenuClientes.Location = new System.Drawing.Point(681, 0);
            this.panelMenuClientes.Name = "panelMenuClientes";
            this.panelMenuClientes.Size = new System.Drawing.Size(98, 456);
            this.panelMenuClientes.TabIndex = 3;
            // 
            // btnUpdateCliente
            // 
            this.btnUpdateCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateCliente.FlatAppearance.BorderSize = 0;
            this.btnUpdateCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCliente.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCliente.Location = new System.Drawing.Point(3, 87);
            this.btnUpdateCliente.Name = "btnUpdateCliente";
            this.btnUpdateCliente.Size = new System.Drawing.Size(92, 59);
            this.btnUpdateCliente.TabIndex = 17;
            this.btnUpdateCliente.Text = "Update Cliente";
            this.btnUpdateCliente.UseMnemonic = false;
            this.btnUpdateCliente.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCliente
            // 
            this.btnDeleteCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteCliente.FlatAppearance.BorderSize = 0;
            this.btnDeleteCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCliente.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCliente.Location = new System.Drawing.Point(6, 152);
            this.btnDeleteCliente.Name = "btnDeleteCliente";
            this.btnDeleteCliente.Size = new System.Drawing.Size(92, 59);
            this.btnDeleteCliente.TabIndex = 16;
            this.btnDeleteCliente.Text = "Delete Cliente";
            this.btnDeleteCliente.UseMnemonic = false;
            this.btnDeleteCliente.UseVisualStyleBackColor = false;
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastroCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastroCliente.FlatAppearance.BorderSize = 0;
            this.btnCadastroCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCadastroCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroCliente.ForeColor = System.Drawing.Color.White;
            this.btnCadastroCliente.Location = new System.Drawing.Point(3, 22);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Size = new System.Drawing.Size(92, 59);
            this.btnCadastroCliente.TabIndex = 15;
            this.btnCadastroCliente.Text = "Cadastro Cliente";
            this.btnCadastroCliente.UseMnemonic = false;
            this.btnCadastroCliente.UseVisualStyleBackColor = false;
            this.btnCadastroCliente.Click += new System.EventHandler(this.btnCadastroCliente_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientesID,
            this.ClientesNome,
            this.ClientesCPF,
            this.ClientesRG,
            this.ClientesTelefone1,
            this.ClientesTelefone2,
            this.ClientesPontos,
            this.ClientesEmail,
            this.ClientesTipoCliente});
            this.dgvClientes.Location = new System.Drawing.Point(0, 0);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowTemplate.Height = 25;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(705, 495);
            this.dgvClientes.TabIndex = 2;
            // 
            // ClientesID
            // 
            this.ClientesID.HeaderText = "ID";
            this.ClientesID.Name = "ClientesID";
            this.ClientesID.ReadOnly = true;
            // 
            // ClientesNome
            // 
            this.ClientesNome.HeaderText = "Nome";
            this.ClientesNome.Name = "ClientesNome";
            this.ClientesNome.ReadOnly = true;
            // 
            // ClientesCPF
            // 
            this.ClientesCPF.HeaderText = "CPF";
            this.ClientesCPF.Name = "ClientesCPF";
            this.ClientesCPF.ReadOnly = true;
            // 
            // ClientesRG
            // 
            this.ClientesRG.HeaderText = "RG";
            this.ClientesRG.Name = "ClientesRG";
            this.ClientesRG.ReadOnly = true;
            // 
            // ClientesTelefone1
            // 
            this.ClientesTelefone1.HeaderText = "Telefone1";
            this.ClientesTelefone1.Name = "ClientesTelefone1";
            this.ClientesTelefone1.ReadOnly = true;
            // 
            // ClientesTelefone2
            // 
            this.ClientesTelefone2.HeaderText = "Telefone2";
            this.ClientesTelefone2.Name = "ClientesTelefone2";
            this.ClientesTelefone2.ReadOnly = true;
            // 
            // ClientesPontos
            // 
            this.ClientesPontos.HeaderText = "Pontos";
            this.ClientesPontos.Name = "ClientesPontos";
            this.ClientesPontos.ReadOnly = true;
            // 
            // ClientesEmail
            // 
            this.ClientesEmail.HeaderText = "Email";
            this.ClientesEmail.Name = "ClientesEmail";
            this.ClientesEmail.ReadOnly = true;
            // 
            // ClientesTipoCliente
            // 
            this.ClientesTipoCliente.HeaderText = "Tipo Cliente";
            this.ClientesTipoCliente.Name = "ClientesTipoCliente";
            this.ClientesTipoCliente.ReadOnly = true;
            // 
            // panelDesktopClientes
            // 
            this.panelDesktopClientes.Location = new System.Drawing.Point(0, 0);
            this.panelDesktopClientes.Name = "panelDesktopClientes";
            this.panelDesktopClientes.Size = new System.Drawing.Size(795, 495);
            this.panelDesktopClientes.TabIndex = 4;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 456);
            this.Controls.Add(this.panelMenuClientes);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.panelDesktopClientes);
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.panelMenuClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenuClientes;
        private Button btnUpdateCliente;
        private Button btnDeleteCliente;
        private Button btnCadastroCliente;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn ClientesID;
        private DataGridViewTextBoxColumn ClientesNome;
        private DataGridViewTextBoxColumn ClientesCPF;
        private DataGridViewTextBoxColumn ClientesRG;
        private DataGridViewTextBoxColumn ClientesTelefone1;
        private DataGridViewTextBoxColumn ClientesTelefone2;
        private DataGridViewTextBoxColumn ClientesPontos;
        private DataGridViewTextBoxColumn ClientesEmail;
        private DataGridViewTextBoxColumn ClientesTipoCliente;
        private Panel panelDesktopClientes;
    }
}