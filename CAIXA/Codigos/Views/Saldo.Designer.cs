namespace CAIXA
{
    partial class Saldo
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
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNovaOp = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtConta = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtConta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(394, 379);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(140, 20);
            this.txtSenha.TabIndex = 1;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(894, 380);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(124, 20);
            this.txtSaldo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(633, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Saldo Atual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Digite sua senha";
            // 
            // btnNovaOp
            // 
            this.btnNovaOp.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNovaOp.Location = new System.Drawing.Point(379, 573);
            this.btnNovaOp.Name = "btnNovaOp";
            this.btnNovaOp.Size = new System.Drawing.Size(75, 75);
            this.btnNovaOp.TabIndex = 6;
            this.btnNovaOp.UseVisualStyleBackColor = false;
            this.btnNovaOp.Click += new System.EventHandler(this.btnNovaOp_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSair.Location = new System.Drawing.Point(845, 548);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 100);
            this.btnSair.TabIndex = 7;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 617);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nova Operação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(720, 617);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sair";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(462, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(402, 42);
            this.label5.TabIndex = 10;
            this.label5.Text = "Você escolheu SALDO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 59);
            this.button1.TabIndex = 11;
            this.button1.Text = "Entra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtConta
            // 
            this.dtConta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtConta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tSaldo,
            this.numConta});
            this.dtConta.Location = new System.Drawing.Point(31, 413);
            this.dtConta.Name = "dtConta";
            this.dtConta.Size = new System.Drawing.Size(360, 59);
            this.dtConta.TabIndex = 12;
            this.dtConta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtConta_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Column1";
            this.id.Name = "id";
            // 
            // tSaldo
            // 
            this.tSaldo.HeaderText = "Column2";
            this.tSaldo.Name = "tSaldo";
            // 
            // numConta
            // 
            this.numConta.HeaderText = "Column3";
            this.numConta.Name = "numConta";
            // 
            // Saldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1048, 749);
            this.Controls.Add(this.dtConta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnNovaOp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtSenha);
            this.Name = "Saldo";
            this.Text = "Saldo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Saldo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtConta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNovaOp;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numConta;
    }
}