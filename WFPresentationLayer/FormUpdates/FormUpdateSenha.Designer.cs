namespace WFPresentationLayer
{
    partial class FormUpdateSenha
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
            this.txtSenhaAntiga = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmarNovaSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateSenha = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSenhaAntiga
            // 
            this.txtSenhaAntiga.Location = new System.Drawing.Point(306, 104);
            this.txtSenhaAntiga.Name = "txtSenhaAntiga";
            this.txtSenhaAntiga.PasswordChar = '●';
            this.txtSenhaAntiga.Size = new System.Drawing.Size(100, 23);
            this.txtSenhaAntiga.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(306, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 15);
            this.label12.TabIndex = 39;
            this.label12.Text = "Senha antiga";
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Location = new System.Drawing.Point(306, 153);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.PasswordChar = '●';
            this.txtNovaSenha.Size = new System.Drawing.Size(100, 23);
            this.txtNovaSenha.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nova Senha";
            // 
            // txtConfirmarNovaSenha
            // 
            this.txtConfirmarNovaSenha.Location = new System.Drawing.Point(306, 202);
            this.txtConfirmarNovaSenha.Name = "txtConfirmarNovaSenha";
            this.txtConfirmarNovaSenha.PasswordChar = '●';
            this.txtConfirmarNovaSenha.Size = new System.Drawing.Size(100, 23);
            this.txtConfirmarNovaSenha.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "Confirmar nova Senha";
            // 
            // btnUpdateSenha
            // 
            this.btnUpdateSenha.Location = new System.Drawing.Point(306, 247);
            this.btnUpdateSenha.Name = "btnUpdateSenha";
            this.btnUpdateSenha.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateSenha.TabIndex = 45;
            this.btnUpdateSenha.Text = "Update";
            this.btnUpdateSenha.UseVisualStyleBackColor = true;
            this.btnUpdateSenha.Click += new System.EventHandler(this.btnUpdateSenha_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(637, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 20);
            this.btnClose.TabIndex = 46;
            this.btnClose.Text = "X";
            this.btnClose.UseMnemonic = false;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormUpdateSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 383);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdateSenha);
            this.Controls.Add(this.txtConfirmarNovaSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenhaAntiga);
            this.Controls.Add(this.label12);
            this.Name = "FormUpdateSenha";
            this.Text = "FormUpdateSenha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtSenhaAntiga;
        private Label label12;
        private TextBox txtNovaSenha;
        private Label label1;
        private TextBox txtConfirmarNovaSenha;
        private Label label2;
        private Button btnUpdateSenha;
        private Button btnClose;
    }
}