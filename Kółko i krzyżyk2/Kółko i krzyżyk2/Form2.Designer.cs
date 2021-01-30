namespace Kółko_i_krzyżyk2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Gracz1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.g1 = new System.Windows.Forms.TextBox();
            this.g2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Gracz1
            // 
            this.Gracz1.AutoSize = true;
            this.Gracz1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(116)))), ((int)(((byte)(186)))));
            this.Gracz1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.Gracz1.ForeColor = System.Drawing.SystemColors.Window;
            this.Gracz1.Location = new System.Drawing.Point(12, 85);
            this.Gracz1.MaximumSize = new System.Drawing.Size(80, 25);
            this.Gracz1.MinimumSize = new System.Drawing.Size(58, 19);
            this.Gracz1.Name = "Gracz1";
            this.Gracz1.Size = new System.Drawing.Size(62, 19);
            this.Gracz1.TabIndex = 14;
            this.Gracz1.Text = "Gracz 1:";
            this.Gracz1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Gracz1.Click += new System.EventHandler(this.Gracz1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(125)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.MaximumSize = new System.Drawing.Size(80, 25);
            this.label1.MinimumSize = new System.Drawing.Size(58, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Gracz 2:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // g1
            // 
            this.g1.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.g1.Location = new System.Drawing.Point(80, 82);
            this.g1.Name = "g1";
            this.g1.Size = new System.Drawing.Size(296, 27);
            this.g1.TabIndex = 16;
            // 
            // g2
            // 
            this.g2.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.g2.Location = new System.Drawing.Point(80, 119);
            this.g2.Name = "g2";
            this.g2.Size = new System.Drawing.Size(296, 27);
            this.g2.TabIndex = 17;
            this.g2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.g2_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(138)))), ((int)(((byte)(201)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(125)))), ((int)(((byte)(181)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(125)))), ((int)(((byte)(181)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(287, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 27);
            this.button1.TabIndex = 18;
            this.button1.Text = "Start!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 198);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.g2);
            this.Controls.Add(this.g1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gracz1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(404, 237);
            this.MinimumSize = new System.Drawing.Size(404, 237);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kółko i krzyżyk";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Gracz1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox g1;
        private System.Windows.Forms.TextBox g2;
        private System.Windows.Forms.Button button1;
    }
}