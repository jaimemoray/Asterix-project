
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
            this.comboBoxFilters = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.messagedataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataItemsGridView)).BeginInit();
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
            // comboBoxFilters
            // 
            this.comboBoxFilters.FormattingEnabled = true;
            this.comboBoxFilters.Items.AddRange(new object[] {
            "CALLSIGN",
            "TRACK NUMBER",
            "TARGET ADDRESS"});
            this.comboBoxFilters.Location = new System.Drawing.Point(482, 122);
            this.comboBoxFilters.Name = "comboBoxFilters";
            this.comboBoxFilters.Size = new System.Drawing.Size(179, 24);
            this.comboBoxFilters.TabIndex = 8;
            this.comboBoxFilters.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilters_SelectedIndexChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(482, 166);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(179, 22);
            this.textBoxSearch.TabIndex = 9;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(533, 194);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "button1";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1166, 658);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.comboBoxFilters);
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
        private System.Windows.Forms.ComboBox comboBoxFilters;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
    }
}