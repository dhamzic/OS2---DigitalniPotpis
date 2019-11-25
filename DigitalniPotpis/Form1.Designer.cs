namespace DigitalniPotpis
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
            this.UiGenerirajKljuceveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UiAsimetricnoKriptiranjeButton = new System.Windows.Forms.Button();
            this.UiTekstZaKriptiranjeTxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.UiSimetricnoDekriptiranjeButton = new System.Windows.Forms.Button();
            this.UiAsimetricnoDekriptiranjeButton = new System.Windows.Forms.Button();
            this.UiSimetricnoKriptiranjeButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.UiTajniKljucButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UiKreirajSazetakButton = new System.Windows.Forms.Button();
            this.UiProvjeriPotpisButton = new System.Windows.Forms.Button();
            this.UiDigitalanPotpisButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // UiGenerirajKljuceveButton
            // 
            this.UiGenerirajKljuceveButton.Location = new System.Drawing.Point(6, 33);
            this.UiGenerirajKljuceveButton.Name = "UiGenerirajKljuceveButton";
            this.UiGenerirajKljuceveButton.Size = new System.Drawing.Size(155, 52);
            this.UiGenerirajKljuceveButton.TabIndex = 0;
            this.UiGenerirajKljuceveButton.TabStop = false;
            this.UiGenerirajKljuceveButton.Text = "Generiraj ključeve";
            this.UiGenerirajKljuceveButton.UseVisualStyleBackColor = true;
            this.UiGenerirajKljuceveButton.Click += new System.EventHandler(this.UiJavniKljucButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UiGenerirajKljuceveButton);
            this.groupBox1.Location = new System.Drawing.Point(54, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 101);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asimetrično";
            // 
            // UiAsimetricnoKriptiranjeButton
            // 
            this.UiAsimetricnoKriptiranjeButton.Location = new System.Drawing.Point(6, 58);
            this.UiAsimetricnoKriptiranjeButton.Name = "UiAsimetricnoKriptiranjeButton";
            this.UiAsimetricnoKriptiranjeButton.Size = new System.Drawing.Size(155, 55);
            this.UiAsimetricnoKriptiranjeButton.TabIndex = 5;
            this.UiAsimetricnoKriptiranjeButton.TabStop = false;
            this.UiAsimetricnoKriptiranjeButton.Text = "Asimetrično kriptiranje";
            this.UiAsimetricnoKriptiranjeButton.UseVisualStyleBackColor = true;
            this.UiAsimetricnoKriptiranjeButton.Click += new System.EventHandler(this.UiAsimetricnoKriptiranjeButton_Click);
            // 
            // UiTekstZaKriptiranjeTxt
            // 
            this.UiTekstZaKriptiranjeTxt.Location = new System.Drawing.Point(6, 33);
            this.UiTekstZaKriptiranjeTxt.Name = "UiTekstZaKriptiranjeTxt";
            this.UiTekstZaKriptiranjeTxt.Size = new System.Drawing.Size(328, 22);
            this.UiTekstZaKriptiranjeTxt.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.UiSimetricnoDekriptiranjeButton);
            this.groupBox3.Controls.Add(this.UiAsimetricnoDekriptiranjeButton);
            this.groupBox3.Controls.Add(this.UiSimetricnoKriptiranjeButton);
            this.groupBox3.Controls.Add(this.UiTekstZaKriptiranjeTxt);
            this.groupBox3.Controls.Add(this.UiAsimetricnoKriptiranjeButton);
            this.groupBox3.Location = new System.Drawing.Point(54, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 182);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kriptiranje i Dekriptiranje";
            // 
            // UiSimetricnoDekriptiranjeButton
            // 
            this.UiSimetricnoDekriptiranjeButton.Location = new System.Drawing.Point(179, 119);
            this.UiSimetricnoDekriptiranjeButton.Name = "UiSimetricnoDekriptiranjeButton";
            this.UiSimetricnoDekriptiranjeButton.Size = new System.Drawing.Size(155, 55);
            this.UiSimetricnoDekriptiranjeButton.TabIndex = 9;
            this.UiSimetricnoDekriptiranjeButton.TabStop = false;
            this.UiSimetricnoDekriptiranjeButton.Text = "Simetrično dekriptiranje";
            this.UiSimetricnoDekriptiranjeButton.UseVisualStyleBackColor = true;
            this.UiSimetricnoDekriptiranjeButton.Click += new System.EventHandler(this.UiSimetricnoDekriptiranjeButton_Click);
            // 
            // UiAsimetricnoDekriptiranjeButton
            // 
            this.UiAsimetricnoDekriptiranjeButton.Location = new System.Drawing.Point(6, 119);
            this.UiAsimetricnoDekriptiranjeButton.Name = "UiAsimetricnoDekriptiranjeButton";
            this.UiAsimetricnoDekriptiranjeButton.Size = new System.Drawing.Size(155, 55);
            this.UiAsimetricnoDekriptiranjeButton.TabIndex = 8;
            this.UiAsimetricnoDekriptiranjeButton.TabStop = false;
            this.UiAsimetricnoDekriptiranjeButton.Text = "Asimetrično dekriptiranje";
            this.UiAsimetricnoDekriptiranjeButton.UseVisualStyleBackColor = true;
            this.UiAsimetricnoDekriptiranjeButton.Click += new System.EventHandler(this.UiAsimetricnoDekriptiranjeButton_Click);
            // 
            // UiSimetricnoKriptiranjeButton
            // 
            this.UiSimetricnoKriptiranjeButton.Location = new System.Drawing.Point(179, 58);
            this.UiSimetricnoKriptiranjeButton.Name = "UiSimetricnoKriptiranjeButton";
            this.UiSimetricnoKriptiranjeButton.Size = new System.Drawing.Size(155, 55);
            this.UiSimetricnoKriptiranjeButton.TabIndex = 7;
            this.UiSimetricnoKriptiranjeButton.TabStop = false;
            this.UiSimetricnoKriptiranjeButton.Text = "Simetrično kriptiranje";
            this.UiSimetricnoKriptiranjeButton.UseVisualStyleBackColor = true;
            this.UiSimetricnoKriptiranjeButton.Click += new System.EventHandler(this.UiSimetricnoKriptiranjeButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.UiTajniKljucButton);
            this.groupBox4.Location = new System.Drawing.Point(227, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(167, 101);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Simetrično";
            // 
            // UiTajniKljucButton
            // 
            this.UiTajniKljucButton.Location = new System.Drawing.Point(6, 33);
            this.UiTajniKljucButton.Name = "UiTajniKljucButton";
            this.UiTajniKljucButton.Size = new System.Drawing.Size(155, 52);
            this.UiTajniKljucButton.TabIndex = 0;
            this.UiTajniKljucButton.TabStop = false;
            this.UiTajniKljucButton.Text = "Tajni ključ";
            this.UiTajniKljucButton.UseVisualStyleBackColor = true;
            this.UiTajniKljucButton.Click += new System.EventHandler(this.UiTajniKljucButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UiDigitalanPotpisButton);
            this.groupBox2.Controls.Add(this.UiProvjeriPotpisButton);
            this.groupBox2.Controls.Add(this.UiKreirajSazetakButton);
            this.groupBox2.Location = new System.Drawing.Point(54, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 161);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asimetrično";
            // 
            // UiKreirajSazetakButton
            // 
            this.UiKreirajSazetakButton.Location = new System.Drawing.Point(6, 33);
            this.UiKreirajSazetakButton.Name = "UiKreirajSazetakButton";
            this.UiKreirajSazetakButton.Size = new System.Drawing.Size(155, 52);
            this.UiKreirajSazetakButton.TabIndex = 0;
            this.UiKreirajSazetakButton.TabStop = false;
            this.UiKreirajSazetakButton.Text = "Kreiraj sažetak";
            this.UiKreirajSazetakButton.UseVisualStyleBackColor = true;
            this.UiKreirajSazetakButton.Click += new System.EventHandler(this.UiKreirajSazetakButton_Click);
            // 
            // UiProvjeriPotpisButton
            // 
            this.UiProvjeriPotpisButton.Location = new System.Drawing.Point(179, 91);
            this.UiProvjeriPotpisButton.Name = "UiProvjeriPotpisButton";
            this.UiProvjeriPotpisButton.Size = new System.Drawing.Size(155, 52);
            this.UiProvjeriPotpisButton.TabIndex = 1;
            this.UiProvjeriPotpisButton.TabStop = false;
            this.UiProvjeriPotpisButton.Text = "Provjeri potpis";
            this.UiProvjeriPotpisButton.UseVisualStyleBackColor = true;
            this.UiProvjeriPotpisButton.Click += new System.EventHandler(this.UiProvjeriPotpisButton_Click);
            // 
            // UiDigitalanPotpisButton
            // 
            this.UiDigitalanPotpisButton.Location = new System.Drawing.Point(179, 33);
            this.UiDigitalanPotpisButton.Name = "UiDigitalanPotpisButton";
            this.UiDigitalanPotpisButton.Size = new System.Drawing.Size(155, 52);
            this.UiDigitalanPotpisButton.TabIndex = 2;
            this.UiDigitalanPotpisButton.TabStop = false;
            this.UiDigitalanPotpisButton.Text = "Digitalno potpiši";
            this.UiDigitalanPotpisButton.UseVisualStyleBackColor = true;
            this.UiDigitalanPotpisButton.Click += new System.EventHandler(this.UiDigitalanPotpisButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 480);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operacijski sustavi 2 - Digitalni potpis - Domagoj Hamzić";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UiGenerirajKljuceveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button UiAsimetricnoKriptiranjeButton;
        private System.Windows.Forms.TextBox UiTekstZaKriptiranjeTxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button UiTajniKljucButton;
        private System.Windows.Forms.Button UiSimetricnoKriptiranjeButton;
        private System.Windows.Forms.Button UiSimetricnoDekriptiranjeButton;
        private System.Windows.Forms.Button UiAsimetricnoDekriptiranjeButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button UiProvjeriPotpisButton;
        private System.Windows.Forms.Button UiKreirajSazetakButton;
        private System.Windows.Forms.Button UiDigitalanPotpisButton;
    }
}

