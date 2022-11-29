
namespace WindowsFormsApp1
{
    partial class DataForm
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
            this.messagedataGrid = new System.Windows.Forms.DataGridView();
            this.CloseButton = new System.Windows.Forms.Button();
            this.dataItemsGridView = new System.Windows.Forms.DataGridView();
            this.ItemInformationTextBox = new System.Windows.Forms.TextBox();
            this.dataItemLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonFilterbyCallSign = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.searchCallsignBox = new System.Windows.Forms.TextBox();
            this.SearchCallSignButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.messagedataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataItemsGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // messagedataGrid
            // 
            this.messagedataGrid.AllowUserToAddRows = false;
            this.messagedataGrid.AllowUserToDeleteRows = false;
            this.messagedataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.messagedataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.messagedataGrid.Location = new System.Drawing.Point(29, 68);
            this.messagedataGrid.Name = "messagedataGrid";
            this.messagedataGrid.ReadOnly = true;
            this.messagedataGrid.RowHeadersWidth = 51;
            this.messagedataGrid.RowTemplate.Height = 24;
            this.messagedataGrid.Size = new System.Drawing.Size(433, 400);
            this.messagedataGrid.TabIndex = 0;
            this.messagedataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.messagedataGrid_CellDoubleClick);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(1121, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(45, 45);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // dataItemsGridView
            // 
            this.dataItemsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataItemsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataItemsGridView.Location = new System.Drawing.Point(682, 68);
            this.dataItemsGridView.Name = "dataItemsGridView";
            this.dataItemsGridView.ReadOnly = true;
            this.dataItemsGridView.RowHeadersWidth = 51;
            this.dataItemsGridView.RowTemplate.Height = 24;
            this.dataItemsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataItemsGridView.Size = new System.Drawing.Size(434, 400);
            this.dataItemsGridView.TabIndex = 4;
            this.dataItemsGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataItemsGridView_CellContentDoubleClick);
            // 
            // ItemInformationTextBox
            // 
            this.ItemInformationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemInformationTextBox.Location = new System.Drawing.Point(26, 511);
            this.ItemInformationTextBox.Multiline = true;
            this.ItemInformationTextBox.Name = "ItemInformationTextBox";
            this.ItemInformationTextBox.ReadOnly = true;
            this.ItemInformationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ItemInformationTextBox.Size = new System.Drawing.Size(1090, 116);
            this.ItemInformationTextBox.TabIndex = 5;
            // 
            // dataItemLabel
            // 
            this.dataItemLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataItemLabel.AutoSize = true;
            this.dataItemLabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataItemLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataItemLabel.Location = new System.Drawing.Point(26, 480);
            this.dataItemLabel.Name = "dataItemLabel";
            this.dataItemLabel.Size = new System.Drawing.Size(100, 19);
            this.dataItemLabel.TabIndex = 6;
            this.dataItemLabel.Text = "Data Item:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(480, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 19);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Filter by:";
            // 
            // buttonFilterbyCallSign
            // 
            this.buttonFilterbyCallSign.Font = new System.Drawing.Font("Copperplate Gothic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilterbyCallSign.Location = new System.Drawing.Point(480, 106);
            this.buttonFilterbyCallSign.Name = "buttonFilterbyCallSign";
            this.buttonFilterbyCallSign.Size = new System.Drawing.Size(180, 50);
            this.buttonFilterbyCallSign.TabIndex = 8;
            this.buttonFilterbyCallSign.Text = "Callsign";
            this.buttonFilterbyCallSign.UseVisualStyleBackColor = true;
            this.buttonFilterbyCallSign.Click += new System.EventHandler(this.buttonFilterbyCallSign_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchCallSignButton);
            this.panel1.Controls.Add(this.searchCallsignBox);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(480, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 305);
            this.panel1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Copperplate Gothic Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.Location = new System.Drawing.Point(17, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 15);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Add a Callsign:";
            // 
            // searchCallsignBox
            // 
            this.searchCallsignBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.searchCallsignBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchCallsignBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCallsignBox.Location = new System.Drawing.Point(17, 34);
            this.searchCallsignBox.Name = "searchCallsignBox";
            this.searchCallsignBox.Size = new System.Drawing.Size(149, 20);
            this.searchCallsignBox.TabIndex = 1;
            // 
            // SearchCallSignButton
            // 
            this.SearchCallSignButton.BackColor = System.Drawing.Color.Black;
            this.SearchCallSignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchCallSignButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCallSignButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchCallSignButton.Location = new System.Drawing.Point(53, 72);
            this.SearchCallSignButton.Name = "SearchCallSignButton";
            this.SearchCallSignButton.Size = new System.Drawing.Size(75, 23);
            this.SearchCallSignButton.TabIndex = 2;
            this.SearchCallSignButton.Text = "Search";
            this.SearchCallSignButton.UseVisualStyleBackColor = false;
            this.SearchCallSignButton.Click += new System.EventHandler(this.SearchCallSignButton_Click);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1166, 658);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonFilterbyCallSign);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataItemLabel);
            this.Controls.Add(this.ItemInformationTextBox);
            this.Controls.Add(this.dataItemsGridView);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.messagedataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataForm";
            this.Text = "DataForm";
            this.Load += new System.EventHandler(this.DataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.messagedataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataItemsGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView messagedataGrid;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.DataGridView dataItemsGridView;
        private System.Windows.Forms.TextBox ItemInformationTextBox;
        private System.Windows.Forms.Label dataItemLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonFilterbyCallSign;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SearchCallSignButton;
        private System.Windows.Forms.TextBox searchCallsignBox;
        private System.Windows.Forms.TextBox textBox2;
    }
}