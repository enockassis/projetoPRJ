namespace CAIXA
{
    partial class Deposito
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNovaOp = new System.Windows.Forms.Button();
            this.txbDeposito = new System.Windows.Forms.TextBox();
            this.txtbDeposito = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Você escolheu DEPÓSITO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite sua senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(673, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Informe o valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 539);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nova Operação";
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(847, 539);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(66, 31);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(978, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNovaOp
            // 
            this.btnNovaOp.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNovaOp.Location = new System.Drawing.Point(458, 495);
            this.btnNovaOp.Name = "btnNovaOp";
            this.btnNovaOp.Size = new System.Drawing.Size(75, 75);
            this.btnNovaOp.TabIndex = 6;
            this.btnNovaOp.UseVisualStyleBackColor = false;
            this.btnNovaOp.Click += new System.EventHandler(this.btnNovaOp_Click);
            // 
            // txbDeposito
            // 
            this.txbDeposito.Location = new System.Drawing.Point(459, 317);
            this.txbDeposito.Name = "txbDeposito";
            this.txbDeposito.Size = new System.Drawing.Size(100, 20);
            this.txbDeposito.TabIndex = 7;
            this.txbDeposito.TextChanged += new System.EventHandler(this.txbDeposito_TextChanged);
            // 
            // txtbDeposito
            // 
            this.txtbDeposito.Location = new System.Drawing.Point(954, 317);
            this.txtbDeposito.Name = "txtbDeposito";
            this.txtbDeposito.Size = new System.Drawing.Size(100, 20);
            this.txtbDeposito.TabIndex = 8;
            // 
            // Deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1284, 749);
            this.Controls.Add(this.txtbDeposito);
            this.Controls.Add(this.txbDeposito);
            this.Controls.Add(this.btnNovaOp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Deposito";
            this.Text = "Deposito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label btnSair;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNovaOp;
        private System.Windows.Forms.TextBox txbDeposito;
        private System.Windows.Forms.TextBox txtbDeposito;
    }
}