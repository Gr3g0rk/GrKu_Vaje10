namespace Nobel
{
    partial class Okno
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.letoLabel = new System.Windows.Forms.Label();
            this.letoTextBox = new System.Windows.Forms.TextBox();
            this.najdiButton = new System.Windows.Forms.Button();
            this.podrocjeLabel = new System.Windows.Forms.Label();
            this.podrocjeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(388, 76);
            this.textBox.Margin = new System.Windows.Forms.Padding(2);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(297, 228);
            this.textBox.TabIndex = 0;
            // 
            // letoLabel
            // 
            this.letoLabel.AutoSize = true;
            this.letoLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letoLabel.ForeColor = System.Drawing.Color.Wheat;
            this.letoLabel.Location = new System.Drawing.Point(11, 118);
            this.letoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.letoLabel.Name = "letoLabel";
            this.letoLabel.Size = new System.Drawing.Size(51, 18);
            this.letoLabel.TabIndex = 1;
            this.letoLabel.Text = "Leto:";
            // 
            // letoTextBox
            // 
            this.letoTextBox.Location = new System.Drawing.Point(87, 118);
            this.letoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.letoTextBox.Name = "letoTextBox";
            this.letoTextBox.Size = new System.Drawing.Size(68, 20);
            this.letoTextBox.TabIndex = 2;
            // 
            // najdiButton
            // 
            this.najdiButton.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.najdiButton.Location = new System.Drawing.Point(101, 175);
            this.najdiButton.Margin = new System.Windows.Forms.Padding(2);
            this.najdiButton.Name = "najdiButton";
            this.najdiButton.Size = new System.Drawing.Size(106, 36);
            this.najdiButton.TabIndex = 3;
            this.najdiButton.Text = "Najdi";
            this.najdiButton.UseVisualStyleBackColor = true;
            this.najdiButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Poisci);
            // 
            // podrocjeLabel
            // 
            this.podrocjeLabel.AutoSize = true;
            this.podrocjeLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.podrocjeLabel.ForeColor = System.Drawing.Color.Wheat;
            this.podrocjeLabel.Location = new System.Drawing.Point(11, 79);
            this.podrocjeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.podrocjeLabel.Name = "podrocjeLabel";
            this.podrocjeLabel.Size = new System.Drawing.Size(86, 18);
            this.podrocjeLabel.TabIndex = 5;
            this.podrocjeLabel.Text = "Področje:";
            // 
            // podrocjeComboBox
            // 
            this.podrocjeComboBox.FormattingEnabled = true;
            this.podrocjeComboBox.Location = new System.Drawing.Point(101, 76);
            this.podrocjeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.podrocjeComboBox.Name = "podrocjeComboBox";
            this.podrocjeComboBox.Size = new System.Drawing.Size(229, 21);
            this.podrocjeComboBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(214, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nobelovi nagrajenci";
            // 
            // Okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(696, 323);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.podrocjeComboBox);
            this.Controls.Add(this.podrocjeLabel);
            this.Controls.Add(this.najdiButton);
            this.Controls.Add(this.letoTextBox);
            this.Controls.Add(this.letoLabel);
            this.Controls.Add(this.textBox);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Okno";
            this.Text = "Nobel";
            this.Load += new System.EventHandler(this.OknoNalozi);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label letoLabel;
        private System.Windows.Forms.TextBox letoTextBox;
        private System.Windows.Forms.Button najdiButton;
        private System.Windows.Forms.Label podrocjeLabel;
        private System.Windows.Forms.ComboBox podrocjeComboBox;
        private System.Windows.Forms.Label label1;
    }
}

