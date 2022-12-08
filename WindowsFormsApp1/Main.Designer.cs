
namespace WindowsFormsApp1
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelButtoms = new System.Windows.Forms.Panel();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.simulationButton = new System.Windows.Forms.Button();
            this.subDataPanel = new System.Windows.Forms.Panel();
            this.CAT21button = new System.Windows.Forms.Button();
            this.CAT10button = new System.Windows.Forms.Button();
            this.Databutton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.MOPbutton = new System.Windows.Forms.Button();
            this.panelButtoms.SuspendLayout();
            this.subDataPanel.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtoms
            // 
            this.panelButtoms.AutoScroll = true;
            this.panelButtoms.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelButtoms.Controls.Add(this.buttonHelp);
            this.panelButtoms.Controls.Add(this.MOPbutton);
            this.panelButtoms.Controls.Add(this.simulationButton);
            this.panelButtoms.Controls.Add(this.subDataPanel);
            this.panelButtoms.Controls.Add(this.Databutton);
            this.panelButtoms.Controls.Add(this.LoadButton);
            this.panelButtoms.Controls.Add(this.panelLogo);
            this.panelButtoms.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtoms.Location = new System.Drawing.Point(0, 0);
            this.panelButtoms.Name = "panelButtoms";
            this.panelButtoms.Size = new System.Drawing.Size(200, 658);
            this.panelButtoms.TabIndex = 0;
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.Black;
            this.buttonHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHelp.Location = new System.Drawing.Point(0, 570);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonHelp.Size = new System.Drawing.Size(200, 70);
            this.buttonHelp.TabIndex = 5;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // simulationButton
            // 
            this.simulationButton.AutoSize = true;
            this.simulationButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.simulationButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.simulationButton.FlatAppearance.BorderSize = 0;
            this.simulationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.simulationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simulationButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simulationButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.simulationButton.Location = new System.Drawing.Point(0, 430);
            this.simulationButton.Name = "simulationButton";
            this.simulationButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.simulationButton.Size = new System.Drawing.Size(200, 70);
            this.simulationButton.TabIndex = 4;
            this.simulationButton.Text = "Simulation";
            this.simulationButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.simulationButton.UseVisualStyleBackColor = false;
            this.simulationButton.Click += new System.EventHandler(this.simulationButton_Click);
            // 
            // subDataPanel
            // 
            this.subDataPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.subDataPanel.Controls.Add(this.CAT21button);
            this.subDataPanel.Controls.Add(this.CAT10button);
            this.subDataPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.subDataPanel.Location = new System.Drawing.Point(0, 290);
            this.subDataPanel.Name = "subDataPanel";
            this.subDataPanel.Size = new System.Drawing.Size(200, 140);
            this.subDataPanel.TabIndex = 3;
            // 
            // CAT21button
            // 
            this.CAT21button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CAT21button.Dock = System.Windows.Forms.DockStyle.Top;
            this.CAT21button.FlatAppearance.BorderSize = 0;
            this.CAT21button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.CAT21button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CAT21button.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAT21button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CAT21button.Location = new System.Drawing.Point(0, 70);
            this.CAT21button.Name = "CAT21button";
            this.CAT21button.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.CAT21button.Size = new System.Drawing.Size(200, 70);
            this.CAT21button.TabIndex = 1;
            this.CAT21button.Text = "CAT 21";
            this.CAT21button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CAT21button.UseVisualStyleBackColor = false;
            this.CAT21button.Click += new System.EventHandler(this.CAT21button_Click);
            // 
            // CAT10button
            // 
            this.CAT10button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CAT10button.Dock = System.Windows.Forms.DockStyle.Top;
            this.CAT10button.FlatAppearance.BorderSize = 0;
            this.CAT10button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.CAT10button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CAT10button.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAT10button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CAT10button.Location = new System.Drawing.Point(0, 0);
            this.CAT10button.Name = "CAT10button";
            this.CAT10button.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.CAT10button.Size = new System.Drawing.Size(200, 70);
            this.CAT10button.TabIndex = 0;
            this.CAT10button.Text = "CAT 10";
            this.CAT10button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CAT10button.UseVisualStyleBackColor = false;
            this.CAT10button.Click += new System.EventHandler(this.CAT10button_Click);
            // 
            // Databutton
            // 
            this.Databutton.BackColor = System.Drawing.SystemColors.ControlText;
            this.Databutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.Databutton.FlatAppearance.BorderSize = 0;
            this.Databutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Databutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Databutton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Databutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Databutton.Location = new System.Drawing.Point(0, 220);
            this.Databutton.Name = "Databutton";
            this.Databutton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Databutton.Size = new System.Drawing.Size(200, 70);
            this.Databutton.TabIndex = 2;
            this.Databutton.Text = "Data View";
            this.Databutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Databutton.UseVisualStyleBackColor = false;
            this.Databutton.Click += new System.EventHandler(this.Databutton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.LoadButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoadButton.FlatAppearance.BorderSize = 0;
            this.LoadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoadButton.Location = new System.Drawing.Point(0, 150);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.LoadButton.Size = new System.Drawing.Size(200, 70);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Load File";
            this.LoadButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 150);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.ASTERIX;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(31, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelChildForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelChildForm.BackgroundImage")));
            this.panelChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(200, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1166, 658);
            this.panelChildForm.TabIndex = 1;
            // 
            // MOPbutton
            // 
            this.MOPbutton.BackColor = System.Drawing.Color.Black;
            this.MOPbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MOPbutton.FlatAppearance.BorderSize = 0;
            this.MOPbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MOPbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MOPbutton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MOPbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MOPbutton.Location = new System.Drawing.Point(0, 500);
            this.MOPbutton.Name = "MOPbutton";
            this.MOPbutton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.MOPbutton.Size = new System.Drawing.Size(200, 70);
            this.MOPbutton.TabIndex = 6;
            this.MOPbutton.Text = "MOPS MLAT";
            this.MOPbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MOPbutton.UseVisualStyleBackColor = false;
            this.MOPbutton.Click += new System.EventHandler(this.MOPbutton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 658);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelButtoms);
            this.Name = "Main";
            this.Text = "Main";
            this.panelButtoms.ResumeLayout(false);
            this.panelButtoms.PerformLayout();
            this.subDataPanel.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtoms;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel subDataPanel;
        private System.Windows.Forms.Button CAT21button;
        private System.Windows.Forms.Button CAT10button;
        private System.Windows.Forms.Button Databutton;
        private System.Windows.Forms.Button simulationButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button MOPbutton;
    }
}

