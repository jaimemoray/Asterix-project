
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
            this.messagedataGrid.Size = new System.Drawing.Size(473, 369);
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
            this.dataItemsGridView.Location = new System.Drawing.Point(567, 68);
            this.dataItemsGridView.Name = "dataItemsGridView";
            this.dataItemsGridView.ReadOnly = true;
            this.dataItemsGridView.RowHeadersWidth = 51;
            this.dataItemsGridView.RowTemplate.Height = 24;
            this.dataItemsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataItemsGridView.Size = new System.Drawing.Size(549, 369);
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
            this.dataItemLabel.Location = new System.Drawing.Point(26, 480);
            this.dataItemLabel.Name = "dataItemLabel";
            this.dataItemLabel.Size = new System.Drawing.Size(67, 16);
            this.dataItemLabel.TabIndex = 6;
            this.dataItemLabel.Text = "Data Item:";
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 658);
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
    }
}