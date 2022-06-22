namespace WFPresentationLayer
{
    partial class FormCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroProduto));
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            this.cmbLaboratorio = new System.Windows.Forms.ComboBox();
            this.cmbUnidade = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCadastrarLaboratorio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(211, 306);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(124, 34);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(277, 78);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(277, 124);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(100, 23);
            this.txtDescricao.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Laboratorio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor";
            // 
            // nudValor
            // 
            this.nudValor.DecimalPlaces = 2;
            this.nudValor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudValor.Location = new System.Drawing.Point(277, 263);
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(100, 23);
            this.nudValor.TabIndex = 8;
            // 
            // cmbLaboratorio
            // 
            this.cmbLaboratorio.FormattingEnabled = true;
            this.cmbLaboratorio.Location = new System.Drawing.Point(277, 168);
            this.cmbLaboratorio.Name = "cmbLaboratorio";
            this.cmbLaboratorio.Size = new System.Drawing.Size(100, 23);
            this.cmbLaboratorio.TabIndex = 9;
            // 
            // cmbUnidade
            // 
            this.cmbUnidade.FormattingEnabled = true;
            this.cmbUnidade.Location = new System.Drawing.Point(277, 219);
            this.cmbUnidade.Name = "cmbUnidade";
            this.cmbUnidade.Size = new System.Drawing.Size(100, 23);
            this.cmbUnidade.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Un";
            // 
            // btnCadastrarLaboratorio
            // 
            this.btnCadastrarLaboratorio.Location = new System.Drawing.Point(344, 306);
            this.btnCadastrarLaboratorio.Name = "btnCadastrarLaboratorio";
            this.btnCadastrarLaboratorio.Size = new System.Drawing.Size(130, 34);
            this.btnCadastrarLaboratorio.TabIndex = 12;
            this.btnCadastrarLaboratorio.Text = "Cadastrar Laboratorio";
            this.btnCadastrarLaboratorio.UseVisualStyleBackColor = true;
            this.btnCadastrarLaboratorio.Click += new System.EventHandler(this.btnCadastrarLaboratorio_Click);
            // 
            // FormCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 456);
            this.Controls.Add(this.btnCadastrarLaboratorio);
            this.Controls.Add(this.cmbUnidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbLaboratorio);
            this.Controls.Add(this.nudValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCadastrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastroProduto";
            this.Text = "Cadastro de produto";
            this.Load += new System.EventHandler(this.FormCadastroProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCadastrar;
        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private TextBox txtDescricao;
        private Label label3;
        private Label label4;
        private NumericUpDown nudValor;
        private ComboBox cmbLaboratorio;
        private ComboBox cmbUnidade;
        private Label label5;
        private Button btnCadastrarLaboratorio;
    }
}