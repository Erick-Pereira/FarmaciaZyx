namespace WFPresentationLayer
{
    partial class FormUpdateLaboratorio
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLaboratorio = new System.Windows.Forms.TextBox();
            this.btnUpdateLaboratorio = new System.Windows.Forms.Button();
            this.mtxtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Laboratorio";
            // 
            // txtLaboratorio
            // 
            this.txtLaboratorio.Location = new System.Drawing.Point(286, 169);
            this.txtLaboratorio.Name = "txtLaboratorio";
            this.txtLaboratorio.Size = new System.Drawing.Size(100, 23);
            this.txtLaboratorio.TabIndex = 16;
            // 
            // btnUpdateLaboratorio
            // 
            this.btnUpdateLaboratorio.Location = new System.Drawing.Point(286, 250);
            this.btnUpdateLaboratorio.Name = "btnUpdateLaboratorio";
            this.btnUpdateLaboratorio.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateLaboratorio.TabIndex = 15;
            this.btnUpdateLaboratorio.Text = "Update";
            this.btnUpdateLaboratorio.UseVisualStyleBackColor = true;
            this.btnUpdateLaboratorio.Click += new System.EventHandler(this.btnUpdateLaboratorio_Click);
            // 
            // mtxtCNPJ
            // 
            this.mtxtCNPJ.Location = new System.Drawing.Point(286, 221);
            this.mtxtCNPJ.Mask = "00.000.000/0000-00";
            this.mtxtCNPJ.Name = "mtxtCNPJ";
            this.mtxtCNPJ.Size = new System.Drawing.Size(100, 23);
            this.mtxtCNPJ.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "CNPJ";
            // 
            // FormUpdateLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtxtCNPJ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLaboratorio);
            this.Controls.Add(this.btnUpdateLaboratorio);
            this.Name = "FormUpdateLaboratorio";
            this.Text = "FormUpdateLaboratorio";
            this.Load += new System.EventHandler(this.FormUpdateLaboratorio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtLaboratorio;
        private Button btnUpdateLaboratorio;
        private MaskedTextBox mtxtCNPJ;
        private Label label2;
    }
}