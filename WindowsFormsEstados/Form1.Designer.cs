namespace WindowsFormsEstados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.bntEstado = new System.Windows.Forms.Button();
            this.cmbNorte = new System.Windows.Forms.ComboBox();
            this.btnNorte = new System.Windows.Forms.Button();
            this.cmbNordeste = new System.Windows.Forms.ComboBox();
            this.btnNordeste = new System.Windows.Forms.Button();
            this.cmbCentro = new System.Windows.Forms.ComboBox();
            this.btnCentro = new System.Windows.Forms.Button();
            this.cmbSuldeste = new System.Windows.Forms.ComboBox();
            this.btnSudeste = new System.Windows.Forms.Button();
            this.btnSul = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNorte = new System.Windows.Forms.Label();
            this.lblNordeste = new System.Windows.Forms.Label();
            this.lblCentro = new System.Windows.Forms.Label();
            this.lblSuldeste = new System.Windows.Forms.Label();
            this.lblSul = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSul = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbEstado
            // 
            this.cmbEstado.AutoCompleteCustomSource.AddRange(new string[] {
            "SP"});
            this.cmbEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "SP",
            "MA",
            "PI",
            "CE",
            "RN",
            "PE",
            "PB",
            "SE",
            "AL",
            "BA",
            "MT",
            "MS",
            "GO",
            "RJ",
            "ES",
            "MG",
            "PR",
            "RS",
            "SC",
            "AM",
            "RR",
            "AP",
            "PA",
            "TO",
            "RO",
            "AC"});
            this.cmbEstado.Location = new System.Drawing.Point(163, 73);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(147, 21);
            this.cmbEstado.TabIndex = 0;
            // 
            // bntEstado
            // 
            this.bntEstado.BackColor = System.Drawing.SystemColors.Info;
            this.bntEstado.Location = new System.Drawing.Point(355, 71);
            this.bntEstado.Name = "bntEstado";
            this.bntEstado.Size = new System.Drawing.Size(26, 23);
            this.bntEstado.TabIndex = 1;
            this.bntEstado.Text = "-";
            this.bntEstado.UseVisualStyleBackColor = false;
            this.bntEstado.Click += new System.EventHandler(this.bntEstado_Click);
            // 
            // cmbNorte
            // 
            this.cmbNorte.FormattingEnabled = true;
            this.cmbNorte.Location = new System.Drawing.Point(163, 112);
            this.cmbNorte.Name = "cmbNorte";
            this.cmbNorte.Size = new System.Drawing.Size(147, 21);
            this.cmbNorte.TabIndex = 2;
            // 
            // btnNorte
            // 
            this.btnNorte.BackColor = System.Drawing.SystemColors.Info;
            this.btnNorte.Location = new System.Drawing.Point(355, 112);
            this.btnNorte.Name = "btnNorte";
            this.btnNorte.Size = new System.Drawing.Size(26, 23);
            this.btnNorte.TabIndex = 3;
            this.btnNorte.Text = "-";
            this.btnNorte.UseVisualStyleBackColor = false;
            this.btnNorte.Click += new System.EventHandler(this.btnNorte_Click);
            // 
            // cmbNordeste
            // 
            this.cmbNordeste.FormattingEnabled = true;
            this.cmbNordeste.Location = new System.Drawing.Point(163, 151);
            this.cmbNordeste.Name = "cmbNordeste";
            this.cmbNordeste.Size = new System.Drawing.Size(147, 21);
            this.cmbNordeste.TabIndex = 4;
            // 
            // btnNordeste
            // 
            this.btnNordeste.BackColor = System.Drawing.SystemColors.Info;
            this.btnNordeste.Location = new System.Drawing.Point(355, 151);
            this.btnNordeste.Name = "btnNordeste";
            this.btnNordeste.Size = new System.Drawing.Size(26, 23);
            this.btnNordeste.TabIndex = 5;
            this.btnNordeste.Text = "-";
            this.btnNordeste.UseVisualStyleBackColor = false;
            this.btnNordeste.Click += new System.EventHandler(this.btnNordeste_Click);
            // 
            // cmbCentro
            // 
            this.cmbCentro.FormattingEnabled = true;
            this.cmbCentro.Location = new System.Drawing.Point(163, 189);
            this.cmbCentro.Name = "cmbCentro";
            this.cmbCentro.Size = new System.Drawing.Size(147, 21);
            this.cmbCentro.TabIndex = 6;
            // 
            // btnCentro
            // 
            this.btnCentro.BackColor = System.Drawing.SystemColors.Info;
            this.btnCentro.Location = new System.Drawing.Point(355, 187);
            this.btnCentro.Name = "btnCentro";
            this.btnCentro.Size = new System.Drawing.Size(26, 23);
            this.btnCentro.TabIndex = 7;
            this.btnCentro.Text = "-";
            this.btnCentro.UseVisualStyleBackColor = false;
            this.btnCentro.Click += new System.EventHandler(this.btnCentro_Click);
            // 
            // cmbSuldeste
            // 
            this.cmbSuldeste.FormattingEnabled = true;
            this.cmbSuldeste.Location = new System.Drawing.Point(163, 225);
            this.cmbSuldeste.Name = "cmbSuldeste";
            this.cmbSuldeste.Size = new System.Drawing.Size(147, 21);
            this.cmbSuldeste.TabIndex = 8;
            // 
            // btnSudeste
            // 
            this.btnSudeste.BackColor = System.Drawing.SystemColors.Info;
            this.btnSudeste.Location = new System.Drawing.Point(355, 225);
            this.btnSudeste.Name = "btnSudeste";
            this.btnSudeste.Size = new System.Drawing.Size(26, 23);
            this.btnSudeste.TabIndex = 9;
            this.btnSudeste.Text = "-";
            this.btnSudeste.UseVisualStyleBackColor = false;
            this.btnSudeste.Click += new System.EventHandler(this.btnSudeste_Click);
            // 
            // btnSul
            // 
            this.btnSul.BackColor = System.Drawing.SystemColors.Info;
            this.btnSul.Location = new System.Drawing.Point(355, 268);
            this.btnSul.Name = "btnSul";
            this.btnSul.Size = new System.Drawing.Size(26, 23);
            this.btnSul.TabIndex = 11;
            this.btnSul.Text = "-";
            this.btnSul.UseVisualStyleBackColor = false;
            this.btnSul.Click += new System.EventHandler(this.btnSul_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.SystemColors.Info;
            this.lblEstado.Location = new System.Drawing.Point(420, 76);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(13, 13);
            this.lblEstado.TabIndex = 12;
            this.lblEstado.Text = "0";
            // 
            // lblNorte
            // 
            this.lblNorte.AutoSize = true;
            this.lblNorte.BackColor = System.Drawing.SystemColors.Info;
            this.lblNorte.Location = new System.Drawing.Point(420, 115);
            this.lblNorte.Name = "lblNorte";
            this.lblNorte.Size = new System.Drawing.Size(13, 13);
            this.lblNorte.TabIndex = 13;
            this.lblNorte.Text = "0";
            // 
            // lblNordeste
            // 
            this.lblNordeste.AutoSize = true;
            this.lblNordeste.BackColor = System.Drawing.SystemColors.Info;
            this.lblNordeste.Location = new System.Drawing.Point(420, 154);
            this.lblNordeste.Name = "lblNordeste";
            this.lblNordeste.Size = new System.Drawing.Size(13, 13);
            this.lblNordeste.TabIndex = 14;
            this.lblNordeste.Text = "0";
            // 
            // lblCentro
            // 
            this.lblCentro.AutoSize = true;
            this.lblCentro.BackColor = System.Drawing.SystemColors.Info;
            this.lblCentro.Location = new System.Drawing.Point(420, 192);
            this.lblCentro.Name = "lblCentro";
            this.lblCentro.Size = new System.Drawing.Size(13, 13);
            this.lblCentro.TabIndex = 15;
            this.lblCentro.Text = "0";
            // 
            // lblSuldeste
            // 
            this.lblSuldeste.AutoSize = true;
            this.lblSuldeste.BackColor = System.Drawing.SystemColors.Info;
            this.lblSuldeste.Location = new System.Drawing.Point(420, 228);
            this.lblSuldeste.Name = "lblSuldeste";
            this.lblSuldeste.Size = new System.Drawing.Size(13, 13);
            this.lblSuldeste.TabIndex = 16;
            this.lblSuldeste.Text = "0";
            // 
            // lblSul
            // 
            this.lblSul.AutoSize = true;
            this.lblSul.BackColor = System.Drawing.SystemColors.Info;
            this.lblSul.Location = new System.Drawing.Point(420, 273);
            this.lblSul.Name = "lblSul";
            this.lblSul.Size = new System.Drawing.Size(13, 13);
            this.lblSul.TabIndex = 17;
            this.lblSul.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(57, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Estados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(57, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Norte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(57, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nordeste:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(57, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Centro-Oeste:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(57, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Suldeste:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(57, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Sul:";
            // 
            // cmbSul
            // 
            this.cmbSul.FormattingEnabled = true;
            this.cmbSul.Location = new System.Drawing.Point(163, 273);
            this.cmbSul.Name = "cmbSul";
            this.cmbSul.Size = new System.Drawing.Size(147, 21);
            this.cmbSul.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(525, 571);
            this.Controls.Add(this.cmbSul);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSul);
            this.Controls.Add(this.lblSuldeste);
            this.Controls.Add(this.lblCentro);
            this.Controls.Add(this.lblNordeste);
            this.Controls.Add(this.lblNorte);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnSul);
            this.Controls.Add(this.btnSudeste);
            this.Controls.Add(this.cmbSuldeste);
            this.Controls.Add(this.btnCentro);
            this.Controls.Add(this.cmbCentro);
            this.Controls.Add(this.btnNordeste);
            this.Controls.Add(this.cmbNordeste);
            this.Controls.Add(this.btnNorte);
            this.Controls.Add(this.cmbNorte);
            this.Controls.Add(this.bntEstado);
            this.Controls.Add(this.cmbEstado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button bntEstado;
        private System.Windows.Forms.ComboBox cmbNorte;
        private System.Windows.Forms.Button btnNorte;
        private System.Windows.Forms.ComboBox cmbNordeste;
        private System.Windows.Forms.Button btnNordeste;
        private System.Windows.Forms.ComboBox cmbCentro;
        private System.Windows.Forms.Button btnCentro;
        private System.Windows.Forms.ComboBox cmbSuldeste;
        private System.Windows.Forms.Button btnSudeste;
        private System.Windows.Forms.Button btnSul;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblNorte;
        private System.Windows.Forms.Label lblNordeste;
        private System.Windows.Forms.Label lblCentro;
        private System.Windows.Forms.Label lblSuldeste;
        private System.Windows.Forms.Label lblSul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSul;
    }
}

