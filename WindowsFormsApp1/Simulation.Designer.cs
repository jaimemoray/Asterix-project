
namespace WindowsFormsApp1
{
    partial class Simulation
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
            this.components = new System.ComponentModel.Container();
            this.panelMap = new System.Windows.Forms.Panel();
            this.mapPanel = new System.Windows.Forms.Panel();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.panelTime = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.Nextbutton = new System.Windows.Forms.Button();
            this.previus = new System.Windows.Forms.Button();
            this.startPause = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelMap.SuspendLayout();
            this.mapPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.panelTime.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMap
            // 
            this.panelMap.Controls.Add(this.mapPanel);
            this.panelMap.Controls.Add(this.controlPanel);
            this.panelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMap.Location = new System.Drawing.Point(0, 0);
            this.panelMap.Margin = new System.Windows.Forms.Padding(2);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(861, 496);
            this.panelMap.TabIndex = 5;
            // 
            // mapPanel
            // 
            this.mapPanel.Controls.Add(this.gMapControl1);
            this.mapPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapPanel.Location = new System.Drawing.Point(0, 0);
            this.mapPanel.Name = "mapPanel";
            this.mapPanel.Size = new System.Drawing.Size(861, 396);
            this.mapPanel.TabIndex = 10;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 0);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(861, 396);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            // 
            // controlPanel
            // 
            this.controlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlPanel.Controls.Add(this.dataPanel);
            this.controlPanel.Controls.Add(this.panelTime);
            this.controlPanel.Controls.Add(this.panelInfo);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.Location = new System.Drawing.Point(0, 396);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(861, 100);
            this.controlPanel.TabIndex = 9;
            // 
            // dataPanel
            // 
            this.dataPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(254, 0);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(350, 98);
            this.dataPanel.TabIndex = 9;
            // 
            // panelTime
            // 
            this.panelTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTime.Controls.Add(this.CloseButton);
            this.panelTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTime.Location = new System.Drawing.Point(604, 0);
            this.panelTime.Margin = new System.Windows.Forms.Padding(2);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(255, 98);
            this.panelTime.TabIndex = 8;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(207, 2);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(34, 37);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.Nextbutton);
            this.panelInfo.Controls.Add(this.previus);
            this.panelInfo.Controls.Add(this.startPause);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(2);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(254, 98);
            this.panelInfo.TabIndex = 6;
            // 
            // Nextbutton
            // 
            this.Nextbutton.Location = new System.Drawing.Point(177, 11);
            this.Nextbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Nextbutton.Name = "Nextbutton";
            this.Nextbutton.Size = new System.Drawing.Size(56, 19);
            this.Nextbutton.TabIndex = 2;
            this.Nextbutton.Text = "Next";
            this.Nextbutton.UseVisualStyleBackColor = true;
            this.Nextbutton.Click += new System.EventHandler(this.Nextbutton_Click);
            // 
            // previus
            // 
            this.previus.Location = new System.Drawing.Point(9, 11);
            this.previus.Margin = new System.Windows.Forms.Padding(2);
            this.previus.Name = "previus";
            this.previus.Size = new System.Drawing.Size(56, 19);
            this.previus.TabIndex = 3;
            this.previus.Text = "Previus";
            this.previus.UseVisualStyleBackColor = true;
            this.previus.Click += new System.EventHandler(this.previus_Click);
            // 
            // startPause
            // 
            this.startPause.Location = new System.Drawing.Point(86, 11);
            this.startPause.Margin = new System.Windows.Forms.Padding(2);
            this.startPause.Name = "startPause";
            this.startPause.Size = new System.Drawing.Size(76, 19);
            this.startPause.TabIndex = 0;
            this.startPause.Text = "start/pause";
            this.startPause.UseVisualStyleBackColor = true;
            this.startPause.Click += new System.EventHandler(this.startPause_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 496);
            this.Controls.Add(this.panelMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Simulation";
            this.Text = "Simulation";
            this.Load += new System.EventHandler(this.Simulation_Load);
            this.panelMap.ResumeLayout(false);
            this.mapPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.panelTime.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button Nextbutton;
        private System.Windows.Forms.Button startPause;
        private System.Windows.Forms.Panel panelTime;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button previus;
        private System.Windows.Forms.Panel mapPanel;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel dataPanel;
    }
}