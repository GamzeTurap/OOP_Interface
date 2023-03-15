namespace InterfaceOrnek2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            radioBtnKare = new RadioButton();
            radioBtnDikdortgen = new RadioButton();
            grpBoxİslemler = new GroupBox();
            lblSekilAdi = new Label();
            lblKenar1 = new Label();
            lblKenar2 = new Label();
            txtSekilAdi = new TextBox();
            txtKenar1 = new TextBox();
            txtKenar2 = new TextBox();
            btnAlanHesapla = new Button();
            btnCevreHesapla = new Button();
            grpBoxİslemler.SuspendLayout();
            SuspendLayout();
            // 
            // radioBtnKare
            // 
            radioBtnKare.AutoSize = true;
            radioBtnKare.Location = new Point(42, 33);
            radioBtnKare.Name = "radioBtnKare";
            radioBtnKare.Size = new Size(53, 19);
            radioBtnKare.TabIndex = 0;
            radioBtnKare.TabStop = true;
            radioBtnKare.Text = "KARE";
            radioBtnKare.UseVisualStyleBackColor = true;
            // 
            // radioBtnDikdortgen
            // 
            radioBtnDikdortgen.AutoSize = true;
            radioBtnDikdortgen.Location = new Point(163, 33);
            radioBtnDikdortgen.Name = "radioBtnDikdortgen";
            radioBtnDikdortgen.Size = new Size(90, 19);
            radioBtnDikdortgen.TabIndex = 0;
            radioBtnDikdortgen.TabStop = true;
            radioBtnDikdortgen.Text = "DİKDÖRGEN";
            radioBtnDikdortgen.UseVisualStyleBackColor = true;
            // 
            // grpBoxİslemler
            // 
            grpBoxİslemler.Controls.Add(btnCevreHesapla);
            grpBoxİslemler.Controls.Add(btnAlanHesapla);
            grpBoxİslemler.Controls.Add(txtKenar2);
            grpBoxİslemler.Controls.Add(txtKenar1);
            grpBoxİslemler.Controls.Add(txtSekilAdi);
            grpBoxİslemler.Controls.Add(lblKenar2);
            grpBoxİslemler.Controls.Add(lblKenar1);
            grpBoxİslemler.Controls.Add(lblSekilAdi);
            grpBoxİslemler.Location = new Point(42, 85);
            grpBoxİslemler.Name = "grpBoxİslemler";
            grpBoxİslemler.Size = new Size(221, 215);
            grpBoxİslemler.TabIndex = 1;
            grpBoxİslemler.TabStop = false;
            grpBoxİslemler.Text = "İŞLEM BİLGİLERİ";
            // 
            // lblSekilAdi
            // 
            lblSekilAdi.AutoSize = true;
            lblSekilAdi.Location = new Point(26, 39);
            lblSekilAdi.Name = "lblSekilAdi";
            lblSekilAdi.Size = new Size(66, 15);
            lblSekilAdi.TabIndex = 0;
            lblSekilAdi.Text = "ŞEKLİN ADI";
            // 
            // lblKenar1
            // 
            lblKenar1.AutoSize = true;
            lblKenar1.Location = new Point(26, 76);
            lblKenar1.Name = "lblKenar1";
            lblKenar1.Size = new Size(44, 15);
            lblKenar1.TabIndex = 0;
            lblKenar1.Text = "KENAR";
            // 
            // lblKenar2
            // 
            lblKenar2.AutoSize = true;
            lblKenar2.Location = new Point(26, 118);
            lblKenar2.Name = "lblKenar2";
            lblKenar2.Size = new Size(44, 15);
            lblKenar2.TabIndex = 0;
            lblKenar2.Text = "KENAR";
            // 
            // txtSekilAdi
            // 
            txtSekilAdi.Location = new Point(95, 39);
            txtSekilAdi.Name = "txtSekilAdi";
            txtSekilAdi.Size = new Size(100, 23);
            txtSekilAdi.TabIndex = 1;
            // 
            // txtKenar1
            // 
            txtKenar1.Location = new Point(95, 73);
            txtKenar1.Name = "txtKenar1";
            txtKenar1.Size = new Size(100, 23);
            txtKenar1.TabIndex = 1;
            // 
            // txtKenar2
            // 
            txtKenar2.Location = new Point(95, 115);
            txtKenar2.Name = "txtKenar2";
            txtKenar2.Size = new Size(100, 23);
            txtKenar2.TabIndex = 1;
            // 
            // btnAlanHesapla
            // 
            btnAlanHesapla.Location = new Point(39, 154);
            btnAlanHesapla.Name = "btnAlanHesapla";
            btnAlanHesapla.Size = new Size(124, 23);
            btnAlanHesapla.TabIndex = 2;
            btnAlanHesapla.Text = "ALAN HESAPLA";
            btnAlanHesapla.UseVisualStyleBackColor = true;
            // 
            // btnCevreHesapla
            // 
            btnCevreHesapla.Location = new Point(39, 183);
            btnCevreHesapla.Name = "btnCevreHesapla";
            btnCevreHesapla.Size = new Size(124, 23);
            btnCevreHesapla.TabIndex = 2;
            btnCevreHesapla.Text = "ÇEVRE HESAPLA";
            btnCevreHesapla.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 311);
            Controls.Add(grpBoxİslemler);
            Controls.Add(radioBtnDikdortgen);
            Controls.Add(radioBtnKare);
            Name = "Form1";
            Text = "Form1";
            grpBoxİslemler.ResumeLayout(false);
            grpBoxİslemler.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioBtnKare;
        private RadioButton radioBtnDikdortgen;
        private GroupBox grpBoxİslemler;
        private Button btnCevreHesapla;
        private Button btnAlanHesapla;
        private TextBox txtKenar2;
        private TextBox txtKenar1;
        private TextBox txtSekilAdi;
        private Label lblKenar2;
        private Label lblKenar1;
        private Label lblSekilAdi;
    }
}