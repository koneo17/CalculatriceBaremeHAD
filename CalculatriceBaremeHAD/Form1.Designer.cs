namespace CalculatriceBaremeHAD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Computebutton = new System.Windows.Forms.Button();
            this.SumTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ValeurLabel = new System.Windows.Forms.Label();
            this.SommeHADLabel = new System.Windows.Forms.Label();
            this.NewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Computebutton
            // 
            this.Computebutton.Enabled = false;
            this.Computebutton.Font = new System.Drawing.Font("Arial", 12F);
            this.Computebutton.Location = new System.Drawing.Point(293, 298);
            this.Computebutton.Name = "Computebutton";
            this.Computebutton.Size = new System.Drawing.Size(85, 32);
            this.Computebutton.TabIndex = 0;
            this.Computebutton.Text = "Calculer";
            this.Computebutton.UseVisualStyleBackColor = true;
            this.Computebutton.Click += new System.EventHandler(this.Computebutton_Click);
            // 
            // SumTextBox
            // 
            this.SumTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.SumTextBox.Location = new System.Drawing.Point(311, 194);
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.Size = new System.Drawing.Size(147, 26);
            this.SumTextBox.TabIndex = 1;
            this.SumTextBox.TextChanged += new System.EventHandler(this.SumTextBox_TextChanged);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.ResultTextBox.Location = new System.Drawing.Point(311, 234);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(147, 26);
            this.ResultTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(99, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ValeurLabel
            // 
            this.ValeurLabel.AutoSize = true;
            this.ValeurLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.ValeurLabel.Location = new System.Drawing.Point(232, 197);
            this.ValeurLabel.Name = "ValeurLabel";
            this.ValeurLabel.Size = new System.Drawing.Size(56, 18);
            this.ValeurLabel.TabIndex = 5;
            this.ValeurLabel.Text = "Valeur:";
            this.ValeurLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SommeHADLabel
            // 
            this.SommeHADLabel.AutoSize = true;
            this.SommeHADLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.SommeHADLabel.Location = new System.Drawing.Point(183, 237);
            this.SommeHADLabel.Name = "SommeHADLabel";
            this.SommeHADLabel.Size = new System.Drawing.Size(105, 18);
            this.SommeHADLabel.TabIndex = 6;
            this.SommeHADLabel.Text = "Somme HAD:";
            this.SommeHADLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NewButton
            // 
            this.NewButton.Font = new System.Drawing.Font("Arial", 12F);
            this.NewButton.Location = new System.Drawing.Point(395, 298);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(85, 32);
            this.NewButton.TabIndex = 7;
            this.NewButton.Text = "Nouveau";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.Computebutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.SommeHADLabel);
            this.Controls.Add(this.ValeurLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.Computebutton);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SITRA Bareme HAD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Computebutton;
        private System.Windows.Forms.TextBox SumTextBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ValeurLabel;
        private System.Windows.Forms.Label SommeHADLabel;
        private System.Windows.Forms.Button NewButton;
    }
}

