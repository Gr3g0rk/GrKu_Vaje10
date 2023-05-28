namespace Letala
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rex = new System.Windows.Forms.PictureBox();
            this.ovira1 = new System.Windows.Forms.PictureBox();
            this.ovira2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tocke = new System.Windows.Forms.Label();
            this.casovnik = new System.Windows.Forms.Timer(this.components);
            this.najboljsiRezultatLabel = new System.Windows.Forms.Label();
            this.najboljsiRezultatiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovira1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovira2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 324);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(598, 41);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rex
            // 
            this.rex.Image = global::Letala.Properties.Resources.running;
            this.rex.Location = new System.Drawing.Point(46, 280);
            this.rex.Margin = new System.Windows.Forms.Padding(2);
            this.rex.Name = "rex";
            this.rex.Size = new System.Drawing.Size(36, 48);
            this.rex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rex.TabIndex = 1;
            this.rex.TabStop = false;
            // 
            // ovira1
            // 
            this.ovira1.Image = global::Letala.Properties.Resources.obstacle_2;
            this.ovira1.Location = new System.Drawing.Point(334, 297);
            this.ovira1.Margin = new System.Windows.Forms.Padding(2);
            this.ovira1.Name = "ovira1";
            this.ovira1.Size = new System.Drawing.Size(30, 30);
            this.ovira1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ovira1.TabIndex = 2;
            this.ovira1.TabStop = false;
            this.ovira1.Tag = "ovira";
            // 
            // ovira2
            // 
            this.ovira2.Image = global::Letala.Properties.Resources.obstacle_1;
            this.ovira2.Location = new System.Drawing.Point(496, 280);
            this.ovira2.Margin = new System.Windows.Forms.Padding(2);
            this.ovira2.Name = "ovira2";
            this.ovira2.Size = new System.Drawing.Size(26, 48);
            this.ovira2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ovira2.TabIndex = 3;
            this.ovira2.TabStop = false;
            this.ovira2.Tag = "ovira";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Točke:";
            // 
            // tocke
            // 
            this.tocke.AutoSize = true;
            this.tocke.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tocke.Location = new System.Drawing.Point(51, 61);
            this.tocke.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tocke.Name = "tocke";
            this.tocke.Size = new System.Drawing.Size(23, 27);
            this.tocke.TabIndex = 5;
            this.tocke.Text = "0";
            // 
            // casovnik
            // 
            this.casovnik.Interval = 20;
            this.casovnik.Tick += new System.EventHandler(this.casovnik_Tick);
            // 
            // najboljsiRezultatLabel
            // 
            this.najboljsiRezultatLabel.AutoSize = true;
            this.najboljsiRezultatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.najboljsiRezultatLabel.Location = new System.Drawing.Point(484, 18);
            this.najboljsiRezultatLabel.Name = "najboljsiRezultatLabel";
            this.najboljsiRezultatLabel.Size = new System.Drawing.Size(11, 13);
            this.najboljsiRezultatLabel.TabIndex = 6;
            this.najboljsiRezultatLabel.Text = " ";
            // 
            // najboljsiRezultatiLabel
            // 
            this.najboljsiRezultatiLabel.AutoSize = true;
            this.najboljsiRezultatiLabel.Location = new System.Drawing.Point(407, 75);
            this.najboljsiRezultatiLabel.Name = "najboljsiRezultatiLabel";
            this.najboljsiRezultatiLabel.Size = new System.Drawing.Size(10, 13);
            this.najboljsiRezultatiLabel.TabIndex = 7;
            this.najboljsiRezultatiLabel.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.najboljsiRezultatiLabel);
            this.Controls.Add(this.najboljsiRezultatLabel);
            this.Controls.Add(this.rex);
            this.Controls.Add(this.tocke);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ovira1);
            this.Controls.Add(this.ovira2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "T-Rex";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovira1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovira2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox rex;
        private System.Windows.Forms.PictureBox ovira1;
        private System.Windows.Forms.PictureBox ovira2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tocke;
        private System.Windows.Forms.Timer casovnik;
        private System.Windows.Forms.Label najboljsiRezultatLabel;
        private System.Windows.Forms.Label najboljsiRezultatiLabel;
    }
}

