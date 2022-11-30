﻿
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
            this.ClockLabel = new System.Windows.Forms.Label();
            this.Hlabel = new System.Windows.Forms.Label();
            this.LNGlabel = new System.Windows.Forms.Label();
            this.LATlabel = new System.Windows.Forms.Label();
            this.FLlabel = new System.Windows.Forms.Label();
            this.TIMElabel = new System.Windows.Forms.Label();
            this.TAlabel = new System.Windows.Forms.Label();
            this.TIlabel = new System.Windows.Forms.Label();
            this.SIClabel = new System.Windows.Forms.Label();
            this.AircraftDataLabel = new System.Windows.Forms.Label();
            this.panelTime = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Layerlabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.layerListBox = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.startPause = new System.Windows.Forms.Button();
            this.previus = new System.Windows.Forms.Button();
            this.Nextbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.startlabel = new System.Windows.Forms.Label();
            this.endlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMap.SuspendLayout();
            this.mapPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.panelTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMap
            // 
            this.panelMap.Controls.Add(this.mapPanel);
            this.panelMap.Controls.Add(this.controlPanel);
            this.panelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMap.Location = new System.Drawing.Point(0, 0);
            this.panelMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(1148, 610);
            this.panelMap.TabIndex = 5;
            // 
            // mapPanel
            // 
            this.mapPanel.Controls.Add(this.gMapControl1);
            this.mapPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapPanel.Location = new System.Drawing.Point(0, 0);
            this.mapPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mapPanel.Name = "mapPanel";
            this.mapPanel.Size = new System.Drawing.Size(1148, 412);
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
            this.gMapControl1.Margin = new System.Windows.Forms.Padding(4);
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
            this.gMapControl1.Size = new System.Drawing.Size(1148, 412);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.OnMarkerDoubleClick += new GMap.NET.WindowsForms.MarkerDoubleClick(this.gMapControl1_OnMarkerDoubleClick);
            // 
            // controlPanel
            // 
            this.controlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlPanel.Controls.Add(this.dataPanel);
            this.controlPanel.Controls.Add(this.panelTime);
            this.controlPanel.Controls.Add(this.panelInfo);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.Location = new System.Drawing.Point(0, 412);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(4);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1148, 198);
            this.controlPanel.TabIndex = 9;
            // 
            // dataPanel
            // 
            this.dataPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataPanel.Controls.Add(this.ClockLabel);
            this.dataPanel.Controls.Add(this.Hlabel);
            this.dataPanel.Controls.Add(this.LNGlabel);
            this.dataPanel.Controls.Add(this.LATlabel);
            this.dataPanel.Controls.Add(this.FLlabel);
            this.dataPanel.Controls.Add(this.TIMElabel);
            this.dataPanel.Controls.Add(this.TAlabel);
            this.dataPanel.Controls.Add(this.TIlabel);
            this.dataPanel.Controls.Add(this.SIClabel);
            this.dataPanel.Controls.Add(this.AircraftDataLabel);
            this.dataPanel.Location = new System.Drawing.Point(362, 0);
            this.dataPanel.Margin = new System.Windows.Forms.Padding(4);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(501, 196);
            this.dataPanel.TabIndex = 9;
            // 
            // ClockLabel
            // 
            this.ClockLabel.AutoSize = true;
            this.ClockLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockLabel.Location = new System.Drawing.Point(246, 16);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(129, 34);
            this.ClockLabel.TabIndex = 9;
            this.ClockLabel.Text = "00:00:00";
            // 
            // Hlabel
            // 
            this.Hlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Hlabel.AutoSize = true;
            this.Hlabel.Location = new System.Drawing.Point(322, 157);
            this.Hlabel.Name = "Hlabel";
            this.Hlabel.Size = new System.Drawing.Size(53, 17);
            this.Hlabel.TabIndex = 8;
            this.Hlabel.Text = "Height:";
            // 
            // LNGlabel
            // 
            this.LNGlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LNGlabel.AutoSize = true;
            this.LNGlabel.Location = new System.Drawing.Point(170, 157);
            this.LNGlabel.Name = "LNGlabel";
            this.LNGlabel.Size = new System.Drawing.Size(75, 17);
            this.LNGlabel.TabIndex = 7;
            this.LNGlabel.Text = "Longitude:";
            // 
            // LATlabel
            // 
            this.LATlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LATlabel.AutoSize = true;
            this.LATlabel.Location = new System.Drawing.Point(55, 157);
            this.LATlabel.Name = "LATlabel";
            this.LATlabel.Size = new System.Drawing.Size(63, 17);
            this.LATlabel.TabIndex = 6;
            this.LATlabel.Text = "Latitude:";
            // 
            // FLlabel
            // 
            this.FLlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FLlabel.AutoSize = true;
            this.FLlabel.Location = new System.Drawing.Point(322, 113);
            this.FLlabel.Name = "FLlabel";
            this.FLlabel.Size = new System.Drawing.Size(88, 17);
            this.FLlabel.TabIndex = 5;
            this.FLlabel.Text = "Flight Level: ";
            // 
            // TIMElabel
            // 
            this.TIMElabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TIMElabel.AutoSize = true;
            this.TIMElabel.Location = new System.Drawing.Point(55, 113);
            this.TIMElabel.Name = "TIMElabel";
            this.TIMElabel.Size = new System.Drawing.Size(47, 17);
            this.TIMElabel.TabIndex = 4;
            this.TIMElabel.Text = "Time: ";
            // 
            // TAlabel
            // 
            this.TAlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TAlabel.AutoSize = true;
            this.TAlabel.Location = new System.Drawing.Point(289, 71);
            this.TAlabel.Name = "TAlabel";
            this.TAlabel.Size = new System.Drawing.Size(110, 17);
            this.TAlabel.TabIndex = 3;
            this.TAlabel.Text = "Target Address:";
            // 
            // TIlabel
            // 
            this.TIlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TIlabel.AutoSize = true;
            this.TIlabel.Location = new System.Drawing.Point(55, 71);
            this.TIlabel.Name = "TIlabel";
            this.TIlabel.Size = new System.Drawing.Size(137, 17);
            this.TIlabel.TabIndex = 2;
            this.TIlabel.Text = "Target Identification:";
            // 
            // SIClabel
            // 
            this.SIClabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SIClabel.AutoSize = true;
            this.SIClabel.Location = new System.Drawing.Point(170, 113);
            this.SIClabel.Name = "SIClabel";
            this.SIClabel.Size = new System.Drawing.Size(37, 17);
            this.SIClabel.TabIndex = 1;
            this.SIClabel.Text = "SIC: ";
            // 
            // AircraftDataLabel
            // 
            this.AircraftDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AircraftDataLabel.AutoSize = true;
            this.AircraftDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AircraftDataLabel.Location = new System.Drawing.Point(55, 16);
            this.AircraftDataLabel.Name = "AircraftDataLabel";
            this.AircraftDataLabel.Size = new System.Drawing.Size(100, 17);
            this.AircraftDataLabel.TabIndex = 0;
            this.AircraftDataLabel.Text = "Aircraft Data";
            // 
            // panelTime
            // 
            this.panelTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTime.Controls.Add(this.pictureBox2);
            this.panelTime.Controls.Add(this.Layerlabel);
            this.panelTime.Controls.Add(this.pictureBox3);
            this.panelTime.Controls.Add(this.layerListBox);
            this.panelTime.Controls.Add(this.pictureBox1);
            this.panelTime.Controls.Add(this.CloseButton);
            this.panelTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTime.Location = new System.Drawing.Point(863, 0);
            this.panelTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(283, 196);
            this.panelTime.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Blue;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(39, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // Layerlabel
            // 
            this.Layerlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Layerlabel.AutoSize = true;
            this.Layerlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Layerlabel.Location = new System.Drawing.Point(13, 4);
            this.Layerlabel.Name = "Layerlabel";
            this.Layerlabel.Size = new System.Drawing.Size(97, 17);
            this.Layerlabel.TabIndex = 15;
            this.Layerlabel.Text = "Instruments:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Red;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(39, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // layerListBox
            // 
            this.layerListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layerListBox.BackColor = System.Drawing.SystemColors.Control;
            this.layerListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.layerListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layerListBox.FormattingEnabled = true;
            this.layerListBox.Location = new System.Drawing.Point(61, 28);
            this.layerListBox.Name = "layerListBox";
            this.layerListBox.Size = new System.Drawing.Size(141, 76);
            this.layerListBox.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(39, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(226, 4);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(45, 46);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.panel2);
            this.panelInfo.Controls.Add(this.panel1);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(364, 196);
            this.panelInfo.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Controls.Add(this.startPause);
            this.panel2.Controls.Add(this.previus);
            this.panel2.Controls.Add(this.Nextbutton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 107);
            this.panel2.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(238, 4);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 99);
            this.trackBar1.TabIndex = 4;
            // 
            // startPause
            // 
            this.startPause.Location = new System.Drawing.Point(105, 45);
            this.startPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startPause.Name = "startPause";
            this.startPause.Size = new System.Drawing.Size(40, 40);
            this.startPause.TabIndex = 0;
            this.startPause.Text = "start/pause";
            this.startPause.UseVisualStyleBackColor = true;
            this.startPause.Click += new System.EventHandler(this.startPause_Click);
            // 
            // previus
            // 
            this.previus.Location = new System.Drawing.Point(46, 45);
            this.previus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.previus.Name = "previus";
            this.previus.Size = new System.Drawing.Size(40, 40);
            this.previus.TabIndex = 3;
            this.previus.Text = "Previus";
            this.previus.UseVisualStyleBackColor = true;
            this.previus.Click += new System.EventHandler(this.previus_Click);
            // 
            // Nextbutton
            // 
            this.Nextbutton.Location = new System.Drawing.Point(164, 45);
            this.Nextbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Nextbutton.Name = "Nextbutton";
            this.Nextbutton.Size = new System.Drawing.Size(40, 40);
            this.Nextbutton.TabIndex = 2;
            this.Nextbutton.Text = "Next";
            this.Nextbutton.UseVisualStyleBackColor = true;
            this.Nextbutton.Click += new System.EventHandler(this.Nextbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.endlabel);
            this.panel1.Controls.Add(this.startlabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 89);
            this.panel1.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // startlabel
            // 
            this.startlabel.AutoSize = true;
            this.startlabel.Location = new System.Drawing.Point(10, 16);
            this.startlabel.Name = "startlabel";
            this.startlabel.Size = new System.Drawing.Size(171, 17);
            this.startlabel.TabIndex = 0;
            this.startlabel.Text = "Start Simulation: 00:00:00";
            // 
            // endlabel
            // 
            this.endlabel.AutoSize = true;
            this.endlabel.Location = new System.Drawing.Point(188, 16);
            this.endlabel.Name = "endlabel";
            this.endlabel.Size = new System.Drawing.Size(166, 17);
            this.endlabel.TabIndex = 1;
            this.endlabel.Text = "End Simulation: 00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Skip at:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(75, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(70, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(171, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(70, 24);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(269, 50);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(70, 24);
            this.comboBox3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = ":";
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 610);
            this.Controls.Add(this.panelMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Simulation";
            this.Text = "Simulation";
            this.Load += new System.EventHandler(this.Simulation_Load);
            this.panelMap.ResumeLayout(false);
            this.mapPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            this.dataPanel.PerformLayout();
            this.panelTime.ResumeLayout(false);
            this.panelTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label AircraftDataLabel;
        private System.Windows.Forms.Label Hlabel;
        private System.Windows.Forms.Label LNGlabel;
        private System.Windows.Forms.Label LATlabel;
        private System.Windows.Forms.Label FLlabel;
        private System.Windows.Forms.Label TIMElabel;
        private System.Windows.Forms.Label TAlabel;
        private System.Windows.Forms.Label TIlabel;
        private System.Windows.Forms.Label SIClabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ClockLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Layerlabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckedListBox layerListBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label endlabel;
        private System.Windows.Forms.Label startlabel;
    }
}