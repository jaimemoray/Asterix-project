
namespace WindowsFormsApp1
{
    partial class LoadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadForm));
            this.CloseButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LoadButton = new System.Windows.Forms.Button();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.textBoxLoad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(1109, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(45, 45);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OpenButton.AutoSize = true;
            this.OpenButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenButton.BackgroundImage")));
            this.OpenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenButton.FlatAppearance.BorderSize = 0;
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenButton.Location = new System.Drawing.Point(360, 278);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(154, 159);
            this.OpenButton.TabIndex = 1;
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LoadButton
            // 
            this.LoadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadButton.AutoSize = true;
            this.LoadButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoadButton.BackgroundImage")));
            this.LoadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoadButton.FlatAppearance.BorderSize = 0;
            this.LoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadButton.Location = new System.Drawing.Point(558, 278);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(142, 137);
            this.LoadButton.TabIndex = 2;
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // textBoxFile
            // 
            this.textBoxFile.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFile.Location = new System.Drawing.Point(360, 479);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(340, 15);
            this.textBoxFile.TabIndex = 3;
            // 
            // textBoxLoad
            // 
            this.textBoxLoad.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxLoad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLoad.Location = new System.Drawing.Point(360, 536);
            this.textBoxLoad.Name = "textBoxLoad";
            this.textBoxLoad.Size = new System.Drawing.Size(340, 15);
            this.textBoxLoad.TabIndex = 4;
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 658);
            this.Controls.Add(this.textBoxLoad);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadForm";
            this.Text = "LoadForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.TextBox textBoxLoad;
    }
}