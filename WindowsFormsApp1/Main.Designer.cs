
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
            this.panelButtoms = new System.Windows.Forms.Panel();
            this.LoadButton = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.Databutton = new System.Windows.Forms.Button();
            this.subDataPanel = new System.Windows.Forms.Panel();
            this.CAT10button = new System.Windows.Forms.Button();
            this.CAT21button = new System.Windows.Forms.Button();
            this.panelButtoms.SuspendLayout();
            this.subDataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtoms
            // 
            this.panelButtoms.AutoScroll = true;
            this.panelButtoms.BackColor = System.Drawing.SystemColors.ActiveBorder;
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
            // LoadButton
            // 
            this.LoadButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoadButton.Location = new System.Drawing.Point(0, 100);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.LoadButton.Size = new System.Drawing.Size(200, 45);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Load File";
            this.LoadButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(200, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1166, 658);
            this.panelChildForm.TabIndex = 1;
            // 
            // Databutton
            // 
            this.Databutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.Databutton.Location = new System.Drawing.Point(0, 145);
            this.Databutton.Name = "Databutton";
            this.Databutton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Databutton.Size = new System.Drawing.Size(200, 45);
            this.Databutton.TabIndex = 2;
            this.Databutton.Text = "Data View";
            this.Databutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Databutton.UseVisualStyleBackColor = true;
            this.Databutton.Click += new System.EventHandler(this.Databutton_Click);
            // 
            // subDataPanel
            // 
            this.subDataPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.subDataPanel.Controls.Add(this.CAT21button);
            this.subDataPanel.Controls.Add(this.CAT10button);
            this.subDataPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.subDataPanel.Location = new System.Drawing.Point(0, 190);
            this.subDataPanel.Name = "subDataPanel";
            this.subDataPanel.Size = new System.Drawing.Size(200, 90);
            this.subDataPanel.TabIndex = 3;
            // 
            // CAT10button
            // 
            this.CAT10button.Dock = System.Windows.Forms.DockStyle.Top;
            this.CAT10button.Location = new System.Drawing.Point(0, 0);
            this.CAT10button.Name = "CAT10button";
            this.CAT10button.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.CAT10button.Size = new System.Drawing.Size(200, 45);
            this.CAT10button.TabIndex = 0;
            this.CAT10button.Text = "CAT 10";
            this.CAT10button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CAT10button.UseVisualStyleBackColor = true;
            this.CAT10button.Click += new System.EventHandler(this.CAT10button_Click);
            // 
            // CAT21button
            // 
            this.CAT21button.Dock = System.Windows.Forms.DockStyle.Top;
            this.CAT21button.Location = new System.Drawing.Point(0, 45);
            this.CAT21button.Name = "CAT21button";
            this.CAT21button.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.CAT21button.Size = new System.Drawing.Size(200, 45);
            this.CAT21button.TabIndex = 1;
            this.CAT21button.Text = "CAT 21";
            this.CAT21button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CAT21button.UseVisualStyleBackColor = true;
            this.CAT21button.Click += new System.EventHandler(this.CAT21button_Click);
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
            this.subDataPanel.ResumeLayout(false);
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
    }
}

