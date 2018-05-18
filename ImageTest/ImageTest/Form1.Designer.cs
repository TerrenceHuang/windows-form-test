namespace ImageTest
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
            this.TestPictureBox = new System.Windows.Forms.PictureBox();
            this.ModifyColorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TestPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TestPictureBox
            // 
            this.TestPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("TestPictureBox.Image")));
            this.TestPictureBox.Location = new System.Drawing.Point(200, 87);
            this.TestPictureBox.Name = "TestPictureBox";
            this.TestPictureBox.Size = new System.Drawing.Size(311, 265);
            this.TestPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TestPictureBox.TabIndex = 0;
            this.TestPictureBox.TabStop = false;
            // 
            // ModifyColorButton
            // 
            this.ModifyColorButton.Location = new System.Drawing.Point(605, 243);
            this.ModifyColorButton.Name = "ModifyColorButton";
            this.ModifyColorButton.Size = new System.Drawing.Size(75, 23);
            this.ModifyColorButton.TabIndex = 2;
            this.ModifyColorButton.Text = "Modify Color";
            this.ModifyColorButton.UseVisualStyleBackColor = true;
            this.ModifyColorButton.Click += new System.EventHandler(this.ModifyColorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ModifyColorButton);
            this.Controls.Add(this.TestPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TestPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox TestPictureBox;
        private System.Windows.Forms.Button ModifyColorButton;
    }
}

