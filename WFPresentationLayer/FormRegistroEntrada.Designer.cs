namespace WFPresentationLayer
{
    partial class FormRegistroEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistroEntrada));
            this.cbmFornecedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrarNovoFornecedor = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCadastroNovoProduto = new System.Windows.Forms.Button();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudQtde = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtde)).BeginInit();
            this.SuspendLayout();
            // 
            // cbmFornecedor
            // 
            this.cbmFornecedor.FormattingEnabled = true;
            this.cbmFornecedor.Location = new System.Drawing.Point(353, 47);
            this.cbmFornecedor.Name = "cbmFornecedor";
            this.cbmFornecedor.Size = new System.Drawing.Size(121, 23);
            this.cbmFornecedor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fornecedor";
            // 
            // btnCadastrarNovoFornecedor
            // 
            this.btnCadastrarNovoFornecedor.Location = new System.Drawing.Point(353, 76);
            this.btnCadastrarNovoFornecedor.Name = "btnCadastrarNovoFornecedor";
            this.btnCadastrarNovoFornecedor.Size = new System.Drawing.Size(121, 42);
            this.btnCadastrarNovoFornecedor.TabIndex = 2;
            this.btnCadastrarNovoFornecedor.Text = "Cadastrar novo Fornecedor";
            this.btnCadastrarNovoFornecedor.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data Entrada";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(502, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnCadastroNovoProduto
            // 
            this.btnCadastroNovoProduto.Location = new System.Drawing.Point(478, 415);
            this.btnCadastroNovoProduto.Name = "btnCadastroNovoProduto";
            this.btnCadastroNovoProduto.Size = new System.Drawing.Size(142, 23);
            this.btnCadastroNovoProduto.TabIndex = 6;
            this.btnCadastroNovoProduto.Text = "Cadastrar novo Produto";
            this.btnCadastroNovoProduto.UseVisualStyleBackColor = true;
            // 
            // cmbProduto
            // 
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(251, 149);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(121, 23);
            this.cmbProduto.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Produto";
            // 
            // nudQtde
            // 
            this.nudQtde.Location = new System.Drawing.Point(154, 149);
            this.nudQtde.Name = "nudQtde";
            this.nudQtde.Size = new System.Drawing.Size(72, 23);
            this.nudQtde.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Qtde.";
            // 
            // FormRegistroEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudQtde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProduto);
            this.Controls.Add(this.btnCadastroNovoProduto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnCadastrarNovoFornecedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbmFornecedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegistroEntrada";
            this.Text = "Registro Entrada";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbmFornecedor;
        private Label label1;
        private Button btnCadastrarNovoFornecedor;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private DataGridView dataGridView1;
        private Button btnCadastroNovoProduto;
        private ComboBox cmbProduto;
        private Label label3;
        private NumericUpDown nudQtde;
        private Label label4;
    }
}