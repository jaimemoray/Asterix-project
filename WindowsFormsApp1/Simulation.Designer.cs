
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
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelSimu = new System.Windows.Forms.Panel();
            this.Nextbutton = new System.Windows.Forms.Button();
            this.startPause = new System.Windows.Forms.Button();
            this.panelTime = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelMap.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.panelSimu.SuspendLayout();
            this.panelTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMap
            // 
            this.panelMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMap.Controls.Add(this.gMapControl1);
            this.panelMap.Controls.Add(this.panel2);
            this.panelMap.Location = new System.Drawing.Point(12, 12);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(1124, 474);
            this.panelMap.TabIndex = 5;
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
            this.gMapControl1.Size = new System.Drawing.Size(1124, 474);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(413, 471);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 125);
            this.panel2.TabIndex = 7;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(293, 34);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(45, 45);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.panelSimu);
            this.panelControl.Controls.Add(this.panelTime);
            this.panelControl.Controls.Add(this.panelInfo);
            this.panelControl.Controls.Add(this.panel1);
            this.panelControl.Location = new System.Drawing.Point(0, 486);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1148, 125);
            this.panelControl.TabIndex = 6;
            // 
            // panelSimu
            // 
            this.panelSimu.Controls.Add(this.Nextbutton);
            this.panelSimu.Controls.Add(this.startPause);
            this.panelSimu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSimu.Location = new System.Drawing.Point(385, 0);
            this.panelSimu.Name = "panelSimu";
            this.panelSimu.Size = new System.Drawing.Size(413, 125);
            this.panelSimu.TabIndex = 9;
            // 
            // Nextbutton
            // 
            this.Nextbutton.Location = new System.Drawing.Point(235, 56);
            this.Nextbutton.Name = "Nextbutton";
            this.Nextbutton.Size = new System.Drawing.Size(75, 23);
            this.Nextbutton.TabIndex = 2;
            this.Nextbutton.Text = "Next";
            this.Nextbutton.UseVisualStyleBackColor = true;
            this.Nextbutton.Click += new System.EventHandler(this.Nextbutton_Click);
            // 
            // startPause
            // 
            this.startPause.Location = new System.Drawing.Point(98, 56);
            this.startPause.Name = "startPause";
            this.startPause.Size = new System.Drawing.Size(102, 23);
            this.startPause.TabIndex = 0;
            this.startPause.Text = "start/pause";
            this.startPause.UseVisualStyleBackColor = true;
            this.startPause.Click += new System.EventHandler(this.startPause_Click);
            // 
            // panelTime
            // 
            this.panelTime.Controls.Add(this.CloseButton);
            this.panelTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTime.Location = new System.Drawing.Point(798, 0);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(350, 125);
            this.panelTime.TabIndex = 8;
            // 
            // panelInfo
            // 
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(385, 125);
            this.panelInfo.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(564, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 0);
            this.panel1.TabIndex = 5;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 611);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Simulation";
            this.Text = "Simulation";
            this.Load += new System.EventHandler(this.Simulation_Load);
            this.panelMap.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.panelSimu.ResumeLayout(false);
            this.panelTime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMap;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelSimu;
        private System.Windows.Forms.Button Nextbutton;
        private System.Windows.Forms.Button startPause;
        private System.Windows.Forms.Panel panelTime;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer;
    }
}