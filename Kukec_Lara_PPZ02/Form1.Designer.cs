namespace Kukec_Lara_PPZ02
{
    partial class Form1
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
            this.rdbGazirano = new System.Windows.Forms.RadioButton();
            this.rdbNegazirano = new System.Windows.Forms.RadioButton();
            this.rdbAlkoholno = new System.Windows.Forms.RadioButton();
            this.grbPica = new System.Windows.Forms.GroupBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.cmbKolicina = new System.Windows.Forms.ComboBox();
            this.lblPakiranje = new System.Windows.Forms.Label();
            this.cmbPakiranje = new System.Windows.Forms.ComboBox();
            this.trckPostotak = new System.Windows.Forms.TrackBar();
            this.lblAlkPost = new System.Windows.Forms.Label();
            this.lblPostotak = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.rtbIspis = new System.Windows.Forms.RichTextBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbPica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckPostotak)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbGazirano
            // 
            this.rdbGazirano.AutoSize = true;
            this.rdbGazirano.Location = new System.Drawing.Point(6, 19);
            this.rdbGazirano.Name = "rdbGazirano";
            this.rdbGazirano.Size = new System.Drawing.Size(87, 20);
            this.rdbGazirano.TabIndex = 1;
            this.rdbGazirano.TabStop = true;
            this.rdbGazirano.Text = "Gazirano";
            this.rdbGazirano.UseVisualStyleBackColor = true;
            this.rdbGazirano.CheckedChanged += new System.EventHandler(this.rdbGazirano_CheckedChanged);
            // 
            // rdbNegazirano
            // 
            this.rdbNegazirano.AutoSize = true;
            this.rdbNegazirano.Location = new System.Drawing.Point(6, 42);
            this.rdbNegazirano.Name = "rdbNegazirano";
            this.rdbNegazirano.Size = new System.Drawing.Size(105, 20);
            this.rdbNegazirano.TabIndex = 2;
            this.rdbNegazirano.TabStop = true;
            this.rdbNegazirano.Text = "Negazirano";
            this.rdbNegazirano.UseVisualStyleBackColor = true;
            this.rdbNegazirano.CheckedChanged += new System.EventHandler(this.rdbNegazirano_CheckedChanged);
            // 
            // rdbAlkoholno
            // 
            this.rdbAlkoholno.AutoSize = true;
            this.rdbAlkoholno.Location = new System.Drawing.Point(6, 65);
            this.rdbAlkoholno.Name = "rdbAlkoholno";
            this.rdbAlkoholno.Size = new System.Drawing.Size(94, 20);
            this.rdbAlkoholno.TabIndex = 3;
            this.rdbAlkoholno.TabStop = true;
            this.rdbAlkoholno.Text = "Alkoholno";
            this.rdbAlkoholno.UseVisualStyleBackColor = true;
            this.rdbAlkoholno.CheckedChanged += new System.EventHandler(this.rdbAlkoholno_CheckedChanged);
            // 
            // grbPica
            // 
            this.grbPica.Controls.Add(this.rdbGazirano);
            this.grbPica.Controls.Add(this.rdbAlkoholno);
            this.grbPica.Controls.Add(this.rdbNegazirano);
            this.grbPica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grbPica.Location = new System.Drawing.Point(21, 24);
            this.grbPica.Name = "grbPica";
            this.grbPica.Size = new System.Drawing.Size(138, 96);
            this.grbPica.TabIndex = 4;
            this.grbPica.TabStop = false;
            this.grbPica.Text = "Vrsta pića";
            this.grbPica.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.Location = new System.Drawing.Point(18, 136);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(84, 16);
            this.lblNaziv.TabIndex = 5;
            this.lblNaziv.Text = "Naziv pića:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(109, 136);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(112, 20);
            this.txtNaziv.TabIndex = 6;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKolicina.Location = new System.Drawing.Point(18, 179);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(100, 16);
            this.lblKolicina.TabIndex = 7;
            this.lblKolicina.Text = "Količina pića:";
            // 
            // cmbKolicina
            // 
            this.cmbKolicina.FormattingEnabled = true;
            this.cmbKolicina.Items.AddRange(new object[] {
            "0.5 L",
            "1 L",
            "1.5 L",
            "2 L"});
            this.cmbKolicina.Location = new System.Drawing.Point(124, 179);
            this.cmbKolicina.Name = "cmbKolicina";
            this.cmbKolicina.Size = new System.Drawing.Size(121, 21);
            this.cmbKolicina.TabIndex = 8;
            // 
            // lblPakiranje
            // 
            this.lblPakiranje.AutoSize = true;
            this.lblPakiranje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPakiranje.Location = new System.Drawing.Point(18, 226);
            this.lblPakiranje.Name = "lblPakiranje";
            this.lblPakiranje.Size = new System.Drawing.Size(111, 16);
            this.lblPakiranje.TabIndex = 9;
            this.lblPakiranje.Text = "Pakiranje pića:";
            this.lblPakiranje.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbPakiranje
            // 
            this.cmbPakiranje.FormattingEnabled = true;
            this.cmbPakiranje.Items.AddRange(new object[] {
            "Staklo",
            "PET",
            "Tetrapak"});
            this.cmbPakiranje.Location = new System.Drawing.Point(135, 225);
            this.cmbPakiranje.Name = "cmbPakiranje";
            this.cmbPakiranje.Size = new System.Drawing.Size(121, 21);
            this.cmbPakiranje.TabIndex = 10;
            // 
            // trckPostotak
            // 
            this.trckPostotak.Location = new System.Drawing.Point(21, 304);
            this.trckPostotak.Maximum = 40;
            this.trckPostotak.Name = "trckPostotak";
            this.trckPostotak.Size = new System.Drawing.Size(235, 45);
            this.trckPostotak.TabIndex = 11;
            this.trckPostotak.Scroll += new System.EventHandler(this.trckPostotak_Scroll);
            // 
            // lblAlkPost
            // 
            this.lblAlkPost.AutoSize = true;
            this.lblAlkPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAlkPost.Location = new System.Drawing.Point(18, 269);
            this.lblAlkPost.Name = "lblAlkPost";
            this.lblAlkPost.Size = new System.Drawing.Size(136, 16);
            this.lblAlkPost.TabIndex = 12;
            this.lblAlkPost.Text = "Postotak alkohola:";
            // 
            // lblPostotak
            // 
            this.lblPostotak.AutoSize = true;
            this.lblPostotak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPostotak.Location = new System.Drawing.Point(156, 270);
            this.lblPostotak.Name = "lblPostotak";
            this.lblPostotak.Size = new System.Drawing.Size(14, 16);
            this.lblPostotak.TabIndex = 14;
            this.lblPostotak.Text = "0";
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCijena.Location = new System.Drawing.Point(18, 352);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(89, 16);
            this.lblCijena.TabIndex = 15;
            this.lblCijena.Text = "Cijena pića:";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(109, 352);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(112, 20);
            this.txtCijena.TabIndex = 16;
            this.txtCijena.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rtbIspis
            // 
            this.rtbIspis.Location = new System.Drawing.Point(262, 24);
            this.rtbIspis.Name = "rtbIspis";
            this.rtbIspis.Size = new System.Drawing.Size(526, 286);
            this.rtbIspis.TabIndex = 17;
            this.rtbIspis.Text = "";
            this.rtbIspis.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnUnesi
            // 
            this.btnUnesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnesi.Location = new System.Drawing.Point(315, 336);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(208, 77);
            this.btnUnesi.TabIndex = 18;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnIspisi
            // 
            this.btnIspisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIspisi.Location = new System.Drawing.Point(556, 336);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(208, 77);
            this.btnIspisi.TabIndex = 19;
            this.btnIspisi.Text = "Ispiši";
            this.btnIspisi.UseVisualStyleBackColor = true;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(175, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(227, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Kn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.rtbIspis);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.lblPostotak);
            this.Controls.Add(this.lblAlkPost);
            this.Controls.Add(this.trckPostotak);
            this.Controls.Add(this.cmbPakiranje);
            this.Controls.Add(this.lblPakiranje);
            this.Controls.Add(this.cmbKolicina);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.grbPica);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbPica.ResumeLayout(false);
            this.grbPica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckPostotak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbGazirano;
        private System.Windows.Forms.RadioButton rdbNegazirano;
        private System.Windows.Forms.RadioButton rdbAlkoholno;
        private System.Windows.Forms.GroupBox grbPica;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.ComboBox cmbKolicina;
        private System.Windows.Forms.Label lblPakiranje;
        private System.Windows.Forms.ComboBox cmbPakiranje;
        private System.Windows.Forms.TrackBar trckPostotak;
        private System.Windows.Forms.Label lblAlkPost;
        private System.Windows.Forms.Label lblPostotak;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.RichTextBox rtbIspis;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

