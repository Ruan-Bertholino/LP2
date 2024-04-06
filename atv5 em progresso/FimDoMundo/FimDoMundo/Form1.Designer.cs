namespace FimDoMundo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnQualquercoisa = new System.Windows.Forms.Button();
            this.lblSalbruto = new System.Windows.Forms.Label();
            this.mskbxSalBruto = new System.Windows.Forms.MaskedTextBox();
            this.lblNumfilhos = new System.Windows.Forms.Label();
            this.nudFilhos = new System.Windows.Forms.NumericUpDown();
            this.txtbAliquota = new System.Windows.Forms.TextBox();
            this.lblINSS = new System.Windows.Forms.Label();
            this.lblIRPF = new System.Windows.Forms.Label();
            this.txtbIRPF = new System.Windows.Forms.TextBox();
            this.lblSalfamilia = new System.Windows.Forms.Label();
            this.txtbSalfamilia = new System.Windows.Forms.TextBox();
            this.lblSalliquido = new System.Windows.Forms.Label();
            this.txtbSalliquiod = new System.Windows.Forms.TextBox();
            this.lblDescINSS = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDescIRPF = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilhos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbNome
            // 
            this.txtbNome.Location = new System.Drawing.Point(157, 12);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(415, 26);
            this.txtbNome.TabIndex = 0;
            this.txtbNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.txtbNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtbNome_Validating);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(138, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome Funcionario";
            // 
            // btnQualquercoisa
            // 
            this.btnQualquercoisa.Location = new System.Drawing.Point(430, 47);
            this.btnQualquercoisa.Name = "btnQualquercoisa";
            this.btnQualquercoisa.Size = new System.Drawing.Size(142, 59);
            this.btnQualquercoisa.TabIndex = 2;
            this.btnQualquercoisa.Text = "Calcula Liquido";
            this.btnQualquercoisa.UseVisualStyleBackColor = true;
            this.btnQualquercoisa.Click += new System.EventHandler(this.btnQualquercoisa_Click);
            // 
            // lblSalbruto
            // 
            this.lblSalbruto.AutoSize = true;
            this.lblSalbruto.Location = new System.Drawing.Point(12, 47);
            this.lblSalbruto.Name = "lblSalbruto";
            this.lblSalbruto.Size = new System.Drawing.Size(101, 20);
            this.lblSalbruto.TabIndex = 4;
            this.lblSalbruto.Text = "Salario Bruto";
            // 
            // mskbxSalBruto
            // 
            this.mskbxSalBruto.Location = new System.Drawing.Point(158, 45);
            this.mskbxSalBruto.Mask = "99000.00";
            this.mskbxSalBruto.Name = "mskbxSalBruto";
            this.mskbxSalBruto.Size = new System.Drawing.Size(142, 26);
            this.mskbxSalBruto.TabIndex = 5;
            this.mskbxSalBruto.Validating += new System.ComponentModel.CancelEventHandler(this.mskbxSalBruto_Validating);
            // 
            // lblNumfilhos
            // 
            this.lblNumfilhos.AutoSize = true;
            this.lblNumfilhos.Location = new System.Drawing.Point(12, 79);
            this.lblNumfilhos.Name = "lblNumfilhos";
            this.lblNumfilhos.Size = new System.Drawing.Size(128, 20);
            this.lblNumfilhos.TabIndex = 6;
            this.lblNumfilhos.Text = "Número de filhos";
            // 
            // nudFilhos
            // 
            this.nudFilhos.Location = new System.Drawing.Point(158, 77);
            this.nudFilhos.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudFilhos.Name = "nudFilhos";
            this.nudFilhos.Size = new System.Drawing.Size(142, 26);
            this.nudFilhos.TabIndex = 7;
            // 
            // txtbAliquota
            // 
            this.txtbAliquota.Enabled = false;
            this.txtbAliquota.Location = new System.Drawing.Point(158, 147);
            this.txtbAliquota.Name = "txtbAliquota";
            this.txtbAliquota.Size = new System.Drawing.Size(142, 26);
            this.txtbAliquota.TabIndex = 8;
            // 
            // lblINSS
            // 
            this.lblINSS.AutoSize = true;
            this.lblINSS.Location = new System.Drawing.Point(12, 150);
            this.lblINSS.Name = "lblINSS";
            this.lblINSS.Size = new System.Drawing.Size(109, 20);
            this.lblINSS.TabIndex = 9;
            this.lblINSS.Text = "Aliquota INSS";
            // 
            // lblIRPF
            // 
            this.lblIRPF.AutoSize = true;
            this.lblIRPF.Location = new System.Drawing.Point(12, 191);
            this.lblIRPF.Name = "lblIRPF";
            this.lblIRPF.Size = new System.Drawing.Size(108, 20);
            this.lblIRPF.TabIndex = 11;
            this.lblIRPF.Text = "Aliquota IRPF";
            // 
            // txtbIRPF
            // 
            this.txtbIRPF.Enabled = false;
            this.txtbIRPF.Location = new System.Drawing.Point(158, 188);
            this.txtbIRPF.Name = "txtbIRPF";
            this.txtbIRPF.Size = new System.Drawing.Size(142, 26);
            this.txtbIRPF.TabIndex = 10;
            // 
            // lblSalfamilia
            // 
            this.lblSalfamilia.AutoSize = true;
            this.lblSalfamilia.Location = new System.Drawing.Point(12, 236);
            this.lblSalfamilia.Name = "lblSalfamilia";
            this.lblSalfamilia.Size = new System.Drawing.Size(112, 20);
            this.lblSalfamilia.TabIndex = 13;
            this.lblSalfamilia.Text = "Salario Familia";
            // 
            // txtbSalfamilia
            // 
            this.txtbSalfamilia.Enabled = false;
            this.txtbSalfamilia.Location = new System.Drawing.Point(158, 230);
            this.txtbSalfamilia.Name = "txtbSalfamilia";
            this.txtbSalfamilia.Size = new System.Drawing.Size(142, 26);
            this.txtbSalfamilia.TabIndex = 12;
            // 
            // lblSalliquido
            // 
            this.lblSalliquido.AutoSize = true;
            this.lblSalliquido.Location = new System.Drawing.Point(11, 277);
            this.lblSalliquido.Name = "lblSalliquido";
            this.lblSalliquido.Size = new System.Drawing.Size(113, 20);
            this.lblSalliquido.TabIndex = 15;
            this.lblSalliquido.Text = "Salario Liquido";
            // 
            // txtbSalliquiod
            // 
            this.txtbSalliquiod.Enabled = false;
            this.txtbSalliquiod.Location = new System.Drawing.Point(157, 271);
            this.txtbSalliquiod.Name = "txtbSalliquiod";
            this.txtbSalliquiod.Size = new System.Drawing.Size(142, 26);
            this.txtbSalliquiod.TabIndex = 14;
            // 
            // lblDescINSS
            // 
            this.lblDescINSS.AutoSize = true;
            this.lblDescINSS.Location = new System.Drawing.Point(308, 150);
            this.lblDescINSS.Name = "lblDescINSS";
            this.lblDescINSS.Size = new System.Drawing.Size(120, 20);
            this.lblDescINSS.TabIndex = 17;
            this.lblDescINSS.Text = "Desconto INSS";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(430, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 26);
            this.textBox1.TabIndex = 16;
            // 
            // lblDescIRPF
            // 
            this.lblDescIRPF.AutoSize = true;
            this.lblDescIRPF.Location = new System.Drawing.Point(308, 191);
            this.lblDescIRPF.Name = "lblDescIRPF";
            this.lblDescIRPF.Size = new System.Drawing.Size(119, 20);
            this.lblDescIRPF.TabIndex = 19;
            this.lblDescIRPF.Text = "Desconto IRPF";
            this.lblDescIRPF.Click += new System.EventHandler(this.lblDescIRPF_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(430, 188);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 26);
            this.textBox2.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 324);
            this.Controls.Add(this.lblDescIRPF);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblDescINSS);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSalliquido);
            this.Controls.Add(this.txtbSalliquiod);
            this.Controls.Add(this.lblSalfamilia);
            this.Controls.Add(this.txtbSalfamilia);
            this.Controls.Add(this.lblIRPF);
            this.Controls.Add(this.txtbIRPF);
            this.Controls.Add(this.lblINSS);
            this.Controls.Add(this.txtbAliquota);
            this.Controls.Add(this.nudFilhos);
            this.Controls.Add(this.lblNumfilhos);
            this.Controls.Add(this.mskbxSalBruto);
            this.Controls.Add(this.lblSalbruto);
            this.Controls.Add(this.btnQualquercoisa);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtbNome);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudFilhos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnQualquercoisa;
        private System.Windows.Forms.Label lblSalbruto;
        private System.Windows.Forms.MaskedTextBox mskbxSalBruto;
        private System.Windows.Forms.Label lblNumfilhos;
        private System.Windows.Forms.NumericUpDown nudFilhos;
        private System.Windows.Forms.TextBox txtbAliquota;
        private System.Windows.Forms.Label lblINSS;
        private System.Windows.Forms.Label lblIRPF;
        private System.Windows.Forms.TextBox txtbIRPF;
        private System.Windows.Forms.Label lblSalfamilia;
        private System.Windows.Forms.TextBox txtbSalfamilia;
        private System.Windows.Forms.Label lblSalliquido;
        private System.Windows.Forms.TextBox txtbSalliquiod;
        private System.Windows.Forms.Label lblDescINSS;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDescIRPF;
        private System.Windows.Forms.TextBox textBox2;
    }
}

