
namespace számológép
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
            this.button1 = new System.Windows.Forms.Button();
            this.kijelzo_lb = new System.Windows.Forms.Label();
            this.adat2 = new System.Windows.Forms.Label();
            this.adat1 = new System.Windows.Forms.Label();
            this.adat1_nup = new System.Windows.Forms.NumericUpDown();
            this.adat2_nup = new System.Windows.Forms.NumericUpDown();
            this.kivon_bt = new System.Windows.Forms.Button();
            this.szoroz_bt = new System.Windows.Forms.Button();
            this.oszt_bt = new System.Windows.Forms.Button();
            this.oszzead_bt = new System.Windows.Forms.Button();
            this.szamol_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.adat1_nup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adat2_nup)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 10);
            this.button1.TabIndex = 0;
            this.button1.Text = "anyad gomb";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kijelzo_lb
            // 
            this.kijelzo_lb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.kijelzo_lb.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kijelzo_lb.Location = new System.Drawing.Point(35, 28);
            this.kijelzo_lb.Name = "kijelzo_lb";
            this.kijelzo_lb.Size = new System.Drawing.Size(400, 67);
            this.kijelzo_lb.TabIndex = 1;
            this.kijelzo_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.kijelzo_lb.Click += new System.EventHandler(this.label1_Click);
            // 
            // adat2
            // 
            this.adat2.AutoSize = true;
            this.adat2.Location = new System.Drawing.Point(35, 171);
            this.adat2.Name = "adat2";
            this.adat2.Size = new System.Drawing.Size(36, 15);
            this.adat2.TabIndex = 2;
            this.adat2.Text = "adat2";
            this.adat2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // adat1
            // 
            this.adat1.AutoSize = true;
            this.adat1.Location = new System.Drawing.Point(35, 139);
            this.adat1.Name = "adat1";
            this.adat1.Size = new System.Drawing.Size(36, 15);
            this.adat1.TabIndex = 3;
            this.adat1.Text = "adat1";
            this.adat1.Click += new System.EventHandler(this.label2_Click);
            // 
            // adat1_nup
            // 
            this.adat1_nup.Location = new System.Drawing.Point(132, 139);
            this.adat1_nup.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.adat1_nup.Name = "adat1_nup";
            this.adat1_nup.Size = new System.Drawing.Size(120, 23);
            this.adat1_nup.TabIndex = 4;
            this.adat1_nup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adat2_nup
            // 
            this.adat2_nup.Location = new System.Drawing.Point(132, 162);
            this.adat2_nup.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.adat2_nup.Name = "adat2_nup";
            this.adat2_nup.Size = new System.Drawing.Size(120, 23);
            this.adat2_nup.TabIndex = 5;
            this.adat2_nup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kivon_bt
            // 
            this.kivon_bt.Location = new System.Drawing.Point(25, 208);
            this.kivon_bt.Name = "kivon_bt";
            this.kivon_bt.Size = new System.Drawing.Size(120, 53);
            this.kivon_bt.TabIndex = 6;
            this.kivon_bt.Text = "Kivonás";
            this.kivon_bt.UseVisualStyleBackColor = true;
            this.kivon_bt.Click += new System.EventHandler(this.button2_Click);
            // 
            // szoroz_bt
            // 
            this.szoroz_bt.Location = new System.Drawing.Point(165, 208);
            this.szoroz_bt.Name = "szoroz_bt";
            this.szoroz_bt.Size = new System.Drawing.Size(120, 53);
            this.szoroz_bt.TabIndex = 7;
            this.szoroz_bt.Text = "Szorzás";
            this.szoroz_bt.UseVisualStyleBackColor = true;
            this.szoroz_bt.Click += new System.EventHandler(this.button3_Click);
            // 
            // oszt_bt
            // 
            this.oszt_bt.Location = new System.Drawing.Point(165, 287);
            this.oszt_bt.Name = "oszt_bt";
            this.oszt_bt.Size = new System.Drawing.Size(120, 53);
            this.oszt_bt.TabIndex = 8;
            this.oszt_bt.Text = "Osztás";
            this.oszt_bt.UseVisualStyleBackColor = true;
            this.oszt_bt.Click += new System.EventHandler(this.button4_Click);
            // 
            // oszzead_bt
            // 
            this.oszzead_bt.Location = new System.Drawing.Point(25, 287);
            this.oszzead_bt.Name = "oszzead_bt";
            this.oszzead_bt.Size = new System.Drawing.Size(120, 53);
            this.oszzead_bt.TabIndex = 9;
            this.oszzead_bt.Text = "Öszzeadás";
            this.oszzead_bt.UseVisualStyleBackColor = true;
            this.oszzead_bt.Click += new System.EventHandler(this.button5_Click);
            // 
            // szamol_bt
            // 
            this.szamol_bt.BackColor = System.Drawing.SystemColors.Desktop;
            this.szamol_bt.BackgroundImage = global::számológép.Properties.Resources.letöltés;
            this.szamol_bt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.szamol_bt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.szamol_bt.Location = new System.Drawing.Point(341, 118);
            this.szamol_bt.Name = "szamol_bt";
            this.szamol_bt.Size = new System.Drawing.Size(110, 263);
            this.szamol_bt.TabIndex = 10;
            this.szamol_bt.Text = "Számolj";
            this.szamol_bt.UseVisualStyleBackColor = false;
            this.szamol_bt.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(499, 415);
            this.Controls.Add(this.szamol_bt);
            this.Controls.Add(this.oszzead_bt);
            this.Controls.Add(this.oszt_bt);
            this.Controls.Add(this.szoroz_bt);
            this.Controls.Add(this.kivon_bt);
            this.Controls.Add(this.adat2_nup);
            this.Controls.Add(this.adat1_nup);
            this.Controls.Add(this.adat1);
            this.Controls.Add(this.adat2);
            this.Controls.Add(this.kijelzo_lb);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adat1_nup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adat2_nup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label kijelzo_lb;
        private System.Windows.Forms.Label adat2;
        private System.Windows.Forms.Label adat1;
        private System.Windows.Forms.NumericUpDown adat1_nup;
        private System.Windows.Forms.NumericUpDown adat2_nup;
        private System.Windows.Forms.Button kivon_bt;
        private System.Windows.Forms.Button szoroz_bt;
        private System.Windows.Forms.Button oszt_bt;
        private System.Windows.Forms.Button oszzead_bt;
        private System.Windows.Forms.Button szamol_bt;
    }
}

