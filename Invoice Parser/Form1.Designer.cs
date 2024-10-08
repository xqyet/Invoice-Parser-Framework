namespace Invoice_Parser
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonBrowse = new Button();
            pictureBoxLogo = new PictureBox();
            panelButtonContainer = new Panel();
            pictureBoxDropImage2 = new PictureBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelButtonContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDropImage2).BeginInit();
            SuspendLayout();
            // 
            // buttonBrowse
            // 
            buttonBrowse.BackColor = Color.RoyalBlue;
            buttonBrowse.FlatStyle = FlatStyle.Popup;
            buttonBrowse.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonBrowse.ForeColor = Color.White;
            buttonBrowse.Location = new Point(224, 40);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(101, 42);
            buttonBrowse.TabIndex = 0;
            buttonBrowse.Text = "Browse files";
            buttonBrowse.UseVisualStyleBackColor = false;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(-85, -55);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(672, 378);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 2;
            pictureBoxLogo.TabStop = false;
            // 
            // panelButtonContainer
            // 
            panelButtonContainer.BackColor = Color.White;
            panelButtonContainer.BorderStyle = BorderStyle.Fixed3D;
            panelButtonContainer.Controls.Add(buttonBrowse);
            panelButtonContainer.Controls.Add(pictureBoxDropImage2);
            panelButtonContainer.Location = new Point(12, 257);
            panelButtonContainer.Name = "panelButtonContainer";
            panelButtonContainer.Size = new Size(460, 121);
            panelButtonContainer.TabIndex = 3;
            // 
            // pictureBoxDropImage2
            // 
            pictureBoxDropImage2.Image = (Image)resources.GetObject("pictureBoxDropImage2.Image");
            pictureBoxDropImage2.Location = new Point(69, 18);
            pictureBoxDropImage2.Name = "pictureBoxDropImage2";
            pictureBoxDropImage2.Size = new Size(76, 83);
            pictureBoxDropImage2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDropImage2.TabIndex = 5;
            pictureBoxDropImage2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(175, 451);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 16);
            textBox1.TabIndex = 4;
            textBox1.Text = "licensed 2024 @Gio\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(493, 479);
            Controls.Add(textBox1);
            Controls.Add(panelButtonContainer);
            Controls.Add(pictureBoxLogo);
            Name = "Form1";
            Text = "Invoice Parser";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelButtonContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxDropImage2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelButtonContainer;
        private System.Windows.Forms.PictureBox pictureBoxDropImage2; // Second drop image above container
        private TextBox textBox1;
    }
}
