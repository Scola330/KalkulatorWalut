namespace waluty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            Kwota = new NumericUpDown();
            groupBox2 = new GroupBox();
            STHB = new RadioButton();
            SRUB = new RadioButton();
            SEUR = new RadioButton();
            SUSD = new RadioButton();
            SPLN = new RadioButton();
            groupBox3 = new GroupBox();
            TTHB = new RadioButton();
            TRUB = new RadioButton();
            TEUR = new RadioButton();
            TUSD = new RadioButton();
            TPLN = new RadioButton();
            groupBox4 = new GroupBox();
            label1 = new Label();
            btn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Kwota).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Kwota);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(240, 112);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kwota :";
            // 
            // Kwota
            // 
            Kwota.DecimalPlaces = 2;
            Kwota.Location = new Point(6, 22);
            Kwota.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            Kwota.Name = "Kwota";
            Kwota.Size = new Size(120, 23);
            Kwota.TabIndex = 0;
            Kwota.ValueChanged += Kwota_ValueChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(STHB);
            groupBox2.Controls.Add(SRUB);
            groupBox2.Controls.Add(SEUR);
            groupBox2.Controls.Add(SUSD);
            groupBox2.Controls.Add(SPLN);
            groupBox2.Location = new Point(12, 130);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(117, 175);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "przelicz z :";
            // 
            // STHB
            // 
            STHB.AutoSize = true;
            STHB.Location = new Point(0, 122);
            STHB.Name = "STHB";
            STHB.Size = new Size(47, 19);
            STHB.TabIndex = 4;
            STHB.TabStop = true;
            STHB.Text = "THB";
            STHB.UseVisualStyleBackColor = true;
            // 
            // SRUB
            // 
            SRUB.AutoSize = true;
            SRUB.Location = new Point(0, 97);
            SRUB.Name = "SRUB";
            SRUB.Size = new Size(47, 19);
            SRUB.TabIndex = 3;
            SRUB.TabStop = true;
            SRUB.Text = "RUB";
            SRUB.UseVisualStyleBackColor = true;
            // 
            // SEUR
            // 
            SEUR.AutoSize = true;
            SEUR.Location = new Point(0, 72);
            SEUR.Name = "SEUR";
            SEUR.Size = new Size(46, 19);
            SEUR.TabIndex = 2;
            SEUR.TabStop = true;
            SEUR.Text = "EUR";
            SEUR.UseVisualStyleBackColor = true;
            // 
            // SUSD
            // 
            SUSD.AutoSize = true;
            SUSD.Location = new Point(0, 47);
            SUSD.Name = "SUSD";
            SUSD.Size = new Size(47, 19);
            SUSD.TabIndex = 1;
            SUSD.TabStop = true;
            SUSD.Text = "USD";
            SUSD.UseVisualStyleBackColor = true;
            // 
            // SPLN
            // 
            SPLN.AutoSize = true;
            SPLN.Location = new Point(0, 22);
            SPLN.Name = "SPLN";
            SPLN.Size = new Size(47, 19);
            SPLN.TabIndex = 0;
            SPLN.TabStop = true;
            SPLN.Text = "PLN";
            SPLN.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(TTHB);
            groupBox3.Controls.Add(TRUB);
            groupBox3.Controls.Add(TEUR);
            groupBox3.Controls.Add(TUSD);
            groupBox3.Controls.Add(TPLN);
            groupBox3.Location = new Point(135, 130);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(117, 175);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "przelicz na :";
            // 
            // TTHB
            // 
            TTHB.AutoSize = true;
            TTHB.Location = new Point(6, 122);
            TTHB.Name = "TTHB";
            TTHB.Size = new Size(47, 19);
            TTHB.TabIndex = 9;
            TTHB.TabStop = true;
            TTHB.Text = "THB";
            TTHB.UseVisualStyleBackColor = true;
            // 
            // TRUB
            // 
            TRUB.AutoSize = true;
            TRUB.Location = new Point(6, 97);
            TRUB.Name = "TRUB";
            TRUB.Size = new Size(47, 19);
            TRUB.TabIndex = 8;
            TRUB.TabStop = true;
            TRUB.Text = "RUB";
            TRUB.UseVisualStyleBackColor = true;
            TRUB.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // TEUR
            // 
            TEUR.AutoSize = true;
            TEUR.Location = new Point(6, 72);
            TEUR.Name = "TEUR";
            TEUR.Size = new Size(46, 19);
            TEUR.TabIndex = 7;
            TEUR.TabStop = true;
            TEUR.Text = "EUR";
            TEUR.UseVisualStyleBackColor = true;
            // 
            // TUSD
            // 
            TUSD.AutoSize = true;
            TUSD.Location = new Point(6, 47);
            TUSD.Name = "TUSD";
            TUSD.Size = new Size(47, 19);
            TUSD.TabIndex = 6;
            TUSD.TabStop = true;
            TUSD.Text = "USD";
            TUSD.UseVisualStyleBackColor = true;
            // 
            // TPLN
            // 
            TPLN.AutoSize = true;
            TPLN.Location = new Point(6, 22);
            TPLN.Name = "TPLN";
            TPLN.Size = new Size(47, 19);
            TPLN.TabIndex = 5;
            TPLN.TabStop = true;
            TPLN.Text = "PLN";
            TPLN.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label1);
            groupBox4.Location = new Point(603, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(297, 293);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Wynik :";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 142);
            label1.Name = "label1";
            label1.Size = new Size(16, 15);
            label1.TabIndex = 0;
            label1.Text = "...";
            // 
            // btn
            // 
            btn.Location = new Point(258, 12);
            btn.Name = "btn";
            btn.Size = new Size(339, 293);
            btn.TabIndex = 4;
            btn.Text = "Przelicz";
            btn.UseVisualStyleBackColor = true;
            btn.Click += oblicz;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 311);
            Controls.Add(btn);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "EKANTOR 2024";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Kwota).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private RadioButton STHB;
        private RadioButton SRUB;
        private RadioButton SEUR;
        private RadioButton SUSD;
        private RadioButton SPLN;
        private Button btn;
        private NumericUpDown Kwota;
        private Label label1;
        private RadioButton TRUB;
        private RadioButton TEUR;
        private RadioButton TUSD;
        private RadioButton TPLN;
        private RadioButton TTHB;
    }
}
