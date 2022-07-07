namespace WFPresentationLayer
{
    partial class FormLaboratorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLaboratorios));
            this.panelMenuFuncionarios = new System.Windows.Forms.Panel();
            this.btnTabelaLaboratorios = new System.Windows.Forms.Button();
            this.btnUpdateLaboratorio = new System.Windows.Forms.Button();
            this.btnDeleteLaboratorio = new System.Windows.Forms.Button();
            this.btnCadastroLaboratorio = new System.Windows.Forms.Button();
            this.dgvLaboratorios = new System.Windows.Forms.DataGridView();
            this.LaboratoriosID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaboratoriosNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDesktopLaboratorios = new System.Windows.Forms.Panel();
            this.panelMenuFuncionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaboratorios)).BeginInit();
            this.panelDesktopLaboratorios.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuFuncionarios
            // 
            this.panelMenuFuncionarios.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelMenuFuncionarios.Controls.Add(this.btnTabelaLaboratorios);
            this.panelMenuFuncionarios.Controls.Add(this.btnUpdateLaboratorio);
            this.panelMenuFuncionarios.Controls.Add(this.btnDeleteLaboratorio);
            this.panelMenuFuncionarios.Controls.Add(this.btnCadastroLaboratorio);
            this.panelMenuFuncionarios.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenuFuncionarios.Location = new System.Drawing.Point(681, 0);
            this.panelMenuFuncionarios.Name = "panelMenuFuncionarios";
            this.panelMenuFuncionarios.Size = new System.Drawing.Size(98, 456);
            this.panelMenuFuncionarios.TabIndex = 4;
            // 
            // btnTabelaLaboratorios
            // 
            this.btnTabelaLaboratorios.BackColor = System.Drawing.Color.Transparent;
            this.btnTabelaLaboratorios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTabelaLaboratorios.FlatAppearance.BorderSize = 0;
            this.btnTabelaLaboratorios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTabelaLaboratorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTabelaLaboratorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabelaLaboratorios.ForeColor = System.Drawing.Color.White;
            this.btnTabelaLaboratorios.Location = new System.Drawing.Point(6, 12);
            this.btnTabelaLaboratorios.Name = "btnTabelaLaboratorios";
            this.btnTabelaLaboratorios.Size = new System.Drawing.Size(92, 59);
            this.btnTabelaLaboratorios.TabIndex = 19;
            this.btnTabelaLaboratorios.Text = "Tabela Laboratorios";
            this.btnTabelaLaboratorios.UseMnemonic = false;
            this.btnTabelaLaboratorios.UseVisualStyleBackColor = false;
            this.btnTabelaLaboratorios.Click += new System.EventHandler(this.btnTabelaLaboratorios_Click);
            // 
            // btnUpdateLaboratorio
            // 
            this.btnUpdateLaboratorio.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateLaboratorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateLaboratorio.FlatAppearance.BorderSize = 0;
            this.btnUpdateLaboratorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateLaboratorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateLaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateLaboratorio.ForeColor = System.Drawing.Color.White;
            this.btnUpdateLaboratorio.Location = new System.Drawing.Point(3, 111);
            this.btnUpdateLaboratorio.Name = "btnUpdateLaboratorio";
            this.btnUpdateLaboratorio.Size = new System.Drawing.Size(92, 59);
            this.btnUpdateLaboratorio.TabIndex = 17;
            this.btnUpdateLaboratorio.Text = "Update Laboratorio";
            this.btnUpdateLaboratorio.UseMnemonic = false;
            this.btnUpdateLaboratorio.UseVisualStyleBackColor = false;
            this.btnUpdateLaboratorio.Click += new System.EventHandler(this.btnUpdateLaboratorio_Click);
            // 
            // btnDeleteLaboratorio
            // 
            this.btnDeleteLaboratorio.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteLaboratorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteLaboratorio.FlatAppearance.BorderSize = 0;
            this.btnDeleteLaboratorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteLaboratorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteLaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteLaboratorio.ForeColor = System.Drawing.Color.White;
            this.btnDeleteLaboratorio.Location = new System.Drawing.Point(3, 164);
            this.btnDeleteLaboratorio.Name = "btnDeleteLaboratorio";
            this.btnDeleteLaboratorio.Size = new System.Drawing.Size(92, 59);
            this.btnDeleteLaboratorio.TabIndex = 16;
            this.btnDeleteLaboratorio.Text = "Delete Laboratorio";
            this.btnDeleteLaboratorio.UseMnemonic = false;
            this.btnDeleteLaboratorio.UseVisualStyleBackColor = false;
            this.btnDeleteLaboratorio.Click += new System.EventHandler(this.btnDeleteLaboratorio_Click);
            // 
            // btnCadastroLaboratorio
            // 
            this.btnCadastroLaboratorio.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastroLaboratorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastroLaboratorio.FlatAppearance.BorderSize = 0;
            this.btnCadastroLaboratorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCadastroLaboratorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCadastroLaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroLaboratorio.ForeColor = System.Drawing.Color.White;
            this.btnCadastroLaboratorio.Location = new System.Drawing.Point(3, 64);
            this.btnCadastroLaboratorio.Name = "btnCadastroLaboratorio";
            this.btnCadastroLaboratorio.Size = new System.Drawing.Size(92, 59);
            this.btnCadastroLaboratorio.TabIndex = 15;
            this.btnCadastroLaboratorio.Text = "Cadastro Laboratorio";
            this.btnCadastroLaboratorio.UseMnemonic = false;
            this.btnCadastroLaboratorio.UseVisualStyleBackColor = false;
            this.btnCadastroLaboratorio.Click += new System.EventHandler(this.btnCadastroLaboratorio_Click);
            // 
            // dgvLaboratorios
            // 
            this.dgvLaboratorios.AllowUserToAddRows = false;
            this.dgvLaboratorios.AllowUserToDeleteRows = false;
            this.dgvLaboratorios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLaboratorios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvLaboratorios.BackgroundColor = System.Drawing.Color.White;
            this.dgvLaboratorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaboratorios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LaboratoriosID,
            this.LaboratoriosNome});
            this.dgvLaboratorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLaboratorios.Location = new System.Drawing.Point(0, 0);
            this.dgvLaboratorios.Name = "dgvLaboratorios";
            this.dgvLaboratorios.ReadOnly = true;
            this.dgvLaboratorios.RowHeadersVisible = false;
            this.dgvLaboratorios.RowTemplate.Height = 25;
            this.dgvLaboratorios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLaboratorios.Size = new System.Drawing.Size(681, 456);
            this.dgvLaboratorios.TabIndex = 3;
            // 
            // LaboratoriosID
            // 
            this.LaboratoriosID.HeaderText = "ID";
            this.LaboratoriosID.Name = "LaboratoriosID";
            this.LaboratoriosID.ReadOnly = true;
            // 
            // LaboratoriosNome
            // 
            this.LaboratoriosNome.HeaderText = "Nome";
            this.LaboratoriosNome.Name = "LaboratoriosNome";
            this.LaboratoriosNome.ReadOnly = true;
            // 
            // panelDesktopLaboratorios
            // 
            this.panelDesktopLaboratorios.Controls.Add(this.dgvLaboratorios);
            this.panelDesktopLaboratorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopLaboratorios.Location = new System.Drawing.Point(0, 0);
            this.panelDesktopLaboratorios.Name = "panelDesktopLaboratorios";
            this.panelDesktopLaboratorios.Size = new System.Drawing.Size(681, 456);
            this.panelDesktopLaboratorios.TabIndex = 5;
            // 
            // FormLaboratorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 456);
            this.Controls.Add(this.panelDesktopLaboratorios);
            this.Controls.Add(this.panelMenuFuncionarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLaboratorios";
            this.Text = "FormLaboratorios";
            this.Load += new System.EventHandler(this.FormLaboratorios_Load);
            this.panelMenuFuncionarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaboratorios)).EndInit();
            this.panelDesktopLaboratorios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenuFuncionarios;
        private Button btnTabelaLaboratorios;
        private Button btnUpdateLaboratorio;
        private Button btnDeleteLaboratorio;
        private Button btnCadastroLaboratorio;
        private DataGridView dgvLaboratorios;
        private Panel panelDesktopLaboratorios;
        private DataGridViewTextBoxColumn LaboratoriosID;
        private DataGridViewTextBoxColumn LaboratoriosNome;
    }
}