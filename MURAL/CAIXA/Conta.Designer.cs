namespace CAIXA
{
    partial class Conta
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.btnConfirme = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(548, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 42);
            this.label6.TabIndex = 14;
            this.label6.Text = "Insira seu cartão";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(662, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 42);
            this.label1.TabIndex = 15;
            this.label1.Text = "ou";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(574, 42);
            this.label2.TabIndex = 16;
            this.label2.Text = "Informe o número da sua conta:";
            // 
            // txtConta
            // 
            this.txtConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConta.Location = new System.Drawing.Point(426, 330);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(140, 24);
            this.txtConta.TabIndex = 0;
            // 
            // btnConfirme
            // 
            this.btnConfirme.BackColor = System.Drawing.Color.Brown;
            this.btnConfirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirme.ForeColor = System.Drawing.Color.Yellow;
            this.btnConfirme.Location = new System.Drawing.Point(636, 583);
            this.btnConfirme.Name = "btnConfirme";
            this.btnConfirme.Size = new System.Drawing.Size(148, 62);
            this.btnConfirme.TabIndex = 2;
            this.btnConfirme.Text = "Confirme";
            this.btnConfirme.UseVisualStyleBackColor = false;
            this.btnConfirme.Click += new System.EventHandler(this.btnConfirme_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(426, 402);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = 'o';
            this.txtSenha.Size = new System.Drawing.Size(140, 24);
            this.txtSenha.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 42);
            this.label3.TabIndex = 20;
            this.label3.Text = "Informe sua senha:";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(420, 491);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 31);
            this.lblMensagem.TabIndex = 21;
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Conta
            // 
            this.AcceptButton = this.btnConfirme;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1284, 749);
            this.ControlBox = false;
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnConfirme);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Conta";
            this.Text = "Conta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.Button btnConfirme;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMensagem;
    }
}