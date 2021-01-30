namespace Kółko_i_krzyżyk2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TL = new System.Windows.Forms.Button();
            this.TM = new System.Windows.Forms.Button();
            this.TR = new System.Windows.Forms.Button();
            this.ML = new System.Windows.Forms.Button();
            this.MM = new System.Windows.Forms.Button();
            this.MR = new System.Windows.Forms.Button();
            this.BL = new System.Windows.Forms.Button();
            this.BM = new System.Windows.Forms.Button();
            this.BR = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.NGra = new System.Windows.Forms.Button();
            this.Wyjscie = new System.Windows.Forms.Button();
            this.Gracz1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OWygrane = new System.Windows.Forms.Label();
            this.XWygrane = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(559, 658);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TL
            // 
            this.TL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(108)))), ((int)(((byte)(180)))));
            this.TL.DialogResult = System.Windows.Forms.DialogResult.No;
            this.TL.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.TL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.TL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.TL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TL.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TL.ForeColor = System.Drawing.Color.White;
            this.TL.Location = new System.Drawing.Point(152, 60);
            this.TL.Name = "TL";
            this.TL.Size = new System.Drawing.Size(80, 80);
            this.TL.TabIndex = 1;
            this.TL.TabStop = false;
            this.TL.UseVisualStyleBackColor = false;
            this.TL.Click += new System.EventHandler(this.klik);
            this.TL.MouseEnter += new System.EventHandler(this.Enter);
            this.TL.MouseLeave += new System.EventHandler(this.Leave);
            // 
            // TM
            // 
            this.TM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(108)))), ((int)(((byte)(180)))));
            this.TM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.TM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TM.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TM.ForeColor = System.Drawing.Color.White;
            this.TM.Location = new System.Drawing.Point(238, 60);
            this.TM.Name = "TM";
            this.TM.Size = new System.Drawing.Size(80, 80);
            this.TM.TabIndex = 2;
            this.TM.TabStop = false;
            this.TM.UseVisualStyleBackColor = false;
            this.TM.Click += new System.EventHandler(this.klik);
            this.TM.MouseEnter += new System.EventHandler(this.Enter);
            this.TM.MouseLeave += new System.EventHandler(this.Leave);
            // 
            // TR
            // 
            this.TR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(108)))), ((int)(((byte)(180)))));
            this.TR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.TR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TR.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TR.ForeColor = System.Drawing.Color.White;
            this.TR.Location = new System.Drawing.Point(323, 60);
            this.TR.Name = "TR";
            this.TR.Size = new System.Drawing.Size(80, 80);
            this.TR.TabIndex = 3;
            this.TR.TabStop = false;
            this.TR.UseVisualStyleBackColor = false;
            this.TR.Click += new System.EventHandler(this.klik);
            this.TR.MouseEnter += new System.EventHandler(this.Enter);
            this.TR.MouseLeave += new System.EventHandler(this.Leave);
            // 
            // ML
            // 
            this.ML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(108)))), ((int)(((byte)(180)))));
            this.ML.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ML.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ML.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ML.ForeColor = System.Drawing.Color.White;
            this.ML.Location = new System.Drawing.Point(152, 145);
            this.ML.Name = "ML";
            this.ML.Size = new System.Drawing.Size(80, 80);
            this.ML.TabIndex = 4;
            this.ML.TabStop = false;
            this.ML.UseVisualStyleBackColor = false;
            this.ML.Click += new System.EventHandler(this.klik);
            this.ML.MouseEnter += new System.EventHandler(this.Enter);
            this.ML.MouseLeave += new System.EventHandler(this.Leave);
            // 
            // MM
            // 
            this.MM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(108)))), ((int)(((byte)(180)))));
            this.MM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MM.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MM.ForeColor = System.Drawing.Color.White;
            this.MM.Location = new System.Drawing.Point(238, 145);
            this.MM.Name = "MM";
            this.MM.Size = new System.Drawing.Size(80, 80);
            this.MM.TabIndex = 5;
            this.MM.TabStop = false;
            this.MM.UseVisualStyleBackColor = false;
            this.MM.Click += new System.EventHandler(this.klik);
            this.MM.MouseEnter += new System.EventHandler(this.Enter);
            this.MM.MouseLeave += new System.EventHandler(this.Leave);
            // 
            // MR
            // 
            this.MR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(108)))), ((int)(((byte)(180)))));
            this.MR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MR.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MR.ForeColor = System.Drawing.Color.White;
            this.MR.Location = new System.Drawing.Point(323, 145);
            this.MR.Name = "MR";
            this.MR.Size = new System.Drawing.Size(80, 80);
            this.MR.TabIndex = 6;
            this.MR.TabStop = false;
            this.MR.UseVisualStyleBackColor = false;
            this.MR.Click += new System.EventHandler(this.klik);
            this.MR.MouseEnter += new System.EventHandler(this.Enter);
            this.MR.MouseLeave += new System.EventHandler(this.Leave);
            // 
            // BL
            // 
            this.BL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(108)))), ((int)(((byte)(180)))));
            this.BL.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BL.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BL.ForeColor = System.Drawing.Color.White;
            this.BL.Location = new System.Drawing.Point(152, 229);
            this.BL.Name = "BL";
            this.BL.Size = new System.Drawing.Size(80, 80);
            this.BL.TabIndex = 7;
            this.BL.TabStop = false;
            this.BL.UseVisualStyleBackColor = false;
            this.BL.Click += new System.EventHandler(this.klik);
            this.BL.MouseEnter += new System.EventHandler(this.Enter);
            this.BL.MouseLeave += new System.EventHandler(this.Leave);
            // 
            // BM
            // 
            this.BM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(108)))), ((int)(((byte)(180)))));
            this.BM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BM.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BM.ForeColor = System.Drawing.Color.White;
            this.BM.Location = new System.Drawing.Point(238, 229);
            this.BM.Name = "BM";
            this.BM.Size = new System.Drawing.Size(80, 80);
            this.BM.TabIndex = 8;
            this.BM.TabStop = false;
            this.BM.UseVisualStyleBackColor = false;
            this.BM.Click += new System.EventHandler(this.klik);
            this.BM.MouseEnter += new System.EventHandler(this.Enter);
            this.BM.MouseLeave += new System.EventHandler(this.Leave);
            // 
            // BR
            // 
            this.BR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(108)))), ((int)(((byte)(180)))));
            this.BR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BR.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BR.ForeColor = System.Drawing.Color.White;
            this.BR.Location = new System.Drawing.Point(323, 229);
            this.BR.Name = "BR";
            this.BR.Size = new System.Drawing.Size(80, 80);
            this.BR.TabIndex = 9;
            this.BR.TabStop = false;
            this.BR.UseVisualStyleBackColor = false;
            this.BR.Click += new System.EventHandler(this.klik);
            this.BR.MouseEnter += new System.EventHandler(this.Enter);
            this.BR.MouseLeave += new System.EventHandler(this.Leave);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.Reset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Reset.ForeColor = System.Drawing.Color.White;
            this.Reset.Location = new System.Drawing.Point(141, 568);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(81, 29);
            this.Reset.TabIndex = 10;
            this.Reset.TabStop = false;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // NGra
            // 
            this.NGra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.NGra.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.NGra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NGra.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NGra.ForeColor = System.Drawing.Color.White;
            this.NGra.Location = new System.Drawing.Point(240, 568);
            this.NGra.Name = "NGra";
            this.NGra.Size = new System.Drawing.Size(82, 29);
            this.NGra.TabIndex = 11;
            this.NGra.TabStop = false;
            this.NGra.Text = "Nowa Gra";
            this.NGra.UseVisualStyleBackColor = false;
            this.NGra.Click += new System.EventHandler(this.NGra_Click);
            // 
            // Wyjscie
            // 
            this.Wyjscie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.Wyjscie.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Wyjscie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Wyjscie.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wyjscie.ForeColor = System.Drawing.Color.White;
            this.Wyjscie.Location = new System.Drawing.Point(339, 568);
            this.Wyjscie.Name = "Wyjscie";
            this.Wyjscie.Size = new System.Drawing.Size(82, 29);
            this.Wyjscie.TabIndex = 12;
            this.Wyjscie.TabStop = false;
            this.Wyjscie.Text = "Wyjście";
            this.Wyjscie.UseVisualStyleBackColor = false;
            this.Wyjscie.Click += new System.EventHandler(this.Wyjscie_Click);
            // 
            // Gracz1
            // 
            this.Gracz1.AutoSize = true;
            this.Gracz1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(131)))), ((int)(((byte)(196)))));
            this.Gracz1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Gracz1.ForeColor = System.Drawing.SystemColors.Window;
            this.Gracz1.Location = new System.Drawing.Point(143, 488);
            this.Gracz1.MaximumSize = new System.Drawing.Size(100, 19);
            this.Gracz1.MinimumSize = new System.Drawing.Size(100, 19);
            this.Gracz1.Name = "Gracz1";
            this.Gracz1.Size = new System.Drawing.Size(100, 19);
            this.Gracz1.TabIndex = 13;
            this.Gracz1.Text = "Gracz 1";
            this.Gracz1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(131)))), ((int)(((byte)(196)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(314, 488);
            this.label1.MaximumSize = new System.Drawing.Size(100, 19);
            this.label1.MinimumSize = new System.Drawing.Size(100, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Gracz 2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OWygrane
            // 
            this.OWygrane.AutoSize = true;
            this.OWygrane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.OWygrane.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OWygrane.ForeColor = System.Drawing.SystemColors.Window;
            this.OWygrane.Location = new System.Drawing.Point(165, 507);
            this.OWygrane.MaximumSize = new System.Drawing.Size(58, 19);
            this.OWygrane.MinimumSize = new System.Drawing.Size(58, 19);
            this.OWygrane.Name = "OWygrane";
            this.OWygrane.Size = new System.Drawing.Size(58, 19);
            this.OWygrane.TabIndex = 15;
            this.OWygrane.Text = "0";
            this.OWygrane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // XWygrane
            // 
            this.XWygrane.AutoSize = true;
            this.XWygrane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.XWygrane.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.XWygrane.ForeColor = System.Drawing.SystemColors.Window;
            this.XWygrane.Location = new System.Drawing.Point(336, 507);
            this.XWygrane.MaximumSize = new System.Drawing.Size(58, 19);
            this.XWygrane.MinimumSize = new System.Drawing.Size(58, 19);
            this.XWygrane.Name = "XWygrane";
            this.XWygrane.Size = new System.Drawing.Size(58, 19);
            this.XWygrane.TabIndex = 16;
            this.XWygrane.Text = "0";
            this.XWygrane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 654);
            this.Controls.Add(this.XWygrane);
            this.Controls.Add(this.OWygrane);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gracz1);
            this.Controls.Add(this.Wyjscie);
            this.Controls.Add(this.NGra);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.BR);
            this.Controls.Add(this.BM);
            this.Controls.Add(this.BL);
            this.Controls.Add(this.MR);
            this.Controls.Add(this.MM);
            this.Controls.Add(this.ML);
            this.Controls.Add(this.TR);
            this.Controls.Add(this.TM);
            this.Controls.Add(this.TL);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(574, 693);
            this.MinimumSize = new System.Drawing.Size(574, 693);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kółko i krzyżyk";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button TM;
        private System.Windows.Forms.Button TR;
        private System.Windows.Forms.Button ML;
        private System.Windows.Forms.Button MM;
        private System.Windows.Forms.Button MR;
        private System.Windows.Forms.Button BL;
        private System.Windows.Forms.Button BM;
        private System.Windows.Forms.Button BR;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button NGra;
        private System.Windows.Forms.Button Wyjscie;
        private System.Windows.Forms.Button TL;
        private System.Windows.Forms.Label Gracz1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OWygrane;
        private System.Windows.Forms.Label XWygrane;
    }
}

