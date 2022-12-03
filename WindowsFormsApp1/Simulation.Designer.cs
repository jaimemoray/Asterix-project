
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulation));
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
            this.label4 = new System.Windows.Forms.Label();
            this.Speedlabel = new System.Windows.Forms.Label();
            this.SpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.startPause = new System.Windows.Forms.Button();
            this.previus = new System.Windows.Forms.Button();
            this.Nextbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Setbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ScomboBox = new System.Windows.Forms.ComboBox();
            this.McomboBox = new System.Windows.Forms.ComboBox();
            this.HcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.endlabel = new System.Windows.Forms.Label();
            this.startlabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).BeginInit();
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
            this.mapPanel.Size = new System.Drawing.Size(1148, 390);
            this.mapPanel.TabIndex = 10;
            // 
            // gMapControl1
            // 
            this.gMapControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.gMapControl1.Size = new System.Drawing.Size(1148, 390);
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
            this.controlPanel.Location = new System.Drawing.Point(0, 390);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(4);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1148, 220);
            this.controlPanel.TabIndex = 9;
            // 
            // dataPanel
            // 
            this.dataPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(364, 0);
            this.dataPanel.Margin = new System.Windows.Forms.Padding(4);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(499, 218);
            this.dataPanel.TabIndex = 9;
            // 
            // ClockLabel
            // 
            this.ClockLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClockLabel.AutoSize = true;
            this.ClockLabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClockLabel.Location = new System.Drawing.Point(281, 32);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(149, 30);
            this.ClockLabel.TabIndex = 9;
            this.ClockLabel.Text = "00:00:00";
            // 
            // Hlabel
            // 
            this.Hlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Hlabel.AutoSize = true;
            this.Hlabel.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Hlabel.Location = new System.Drawing.Point(320, 178);
            this.Hlabel.Name = "Hlabel";
            this.Hlabel.Size = new System.Drawing.Size(50, 16);
            this.Hlabel.TabIndex = 8;
            this.Hlabel.Text = "Height:";
            // 
            // LNGlabel
            // 
            this.LNGlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LNGlabel.AutoSize = true;
            this.LNGlabel.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNGlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LNGlabel.Location = new System.Drawing.Point(169, 178);
            this.LNGlabel.Name = "LNGlabel";
            this.LNGlabel.Size = new System.Drawing.Size(69, 16);
            this.LNGlabel.TabIndex = 7;
            this.LNGlabel.Text = "Longitude:";
            // 
            // LATlabel
            // 
            this.LATlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LATlabel.AutoSize = true;
            this.LATlabel.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LATlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LATlabel.Location = new System.Drawing.Point(18, 178);
            this.LATlabel.Name = "LATlabel";
            this.LATlabel.Size = new System.Drawing.Size(60, 16);
            this.LATlabel.TabIndex = 6;
            this.LATlabel.Text = "Latitude:";
            // 
            // FLlabel
            // 
            this.FLlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FLlabel.AutoSize = true;
            this.FLlabel.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FLlabel.Location = new System.Drawing.Point(320, 123);
            this.FLlabel.Name = "FLlabel";
            this.FLlabel.Size = new System.Drawing.Size(79, 16);
            this.FLlabel.TabIndex = 5;
            this.FLlabel.Text = "Flight Level: ";
            // 
            // TIMElabel
            // 
            this.TIMElabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TIMElabel.AutoSize = true;
            this.TIMElabel.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIMElabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TIMElabel.Location = new System.Drawing.Point(18, 123);
            this.TIMElabel.Name = "TIMElabel";
            this.TIMElabel.Size = new System.Drawing.Size(41, 16);
            this.TIMElabel.TabIndex = 4;
            this.TIMElabel.Text = "Time: ";
            // 
            // TAlabel
            // 
            this.TAlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TAlabel.AutoSize = true;
            this.TAlabel.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TAlabel.Location = new System.Drawing.Point(18, 80);
            this.TAlabel.Name = "TAlabel";
            this.TAlabel.Size = new System.Drawing.Size(100, 16);
            this.TAlabel.TabIndex = 3;
            this.TAlabel.Text = "Target Address:";
            // 
            // TIlabel
            // 
            this.TIlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TIlabel.AutoSize = true;
            this.TIlabel.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TIlabel.Location = new System.Drawing.Point(18, 33);
            this.TIlabel.Name = "TIlabel";
            this.TIlabel.Size = new System.Drawing.Size(128, 16);
            this.TIlabel.TabIndex = 2;
            this.TIlabel.Text = "Target Identification:";
            // 
            // SIClabel
            // 
            this.SIClabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SIClabel.AutoSize = true;
            this.SIClabel.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SIClabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SIClabel.Location = new System.Drawing.Point(169, 123);
            this.SIClabel.Name = "SIClabel";
            this.SIClabel.Size = new System.Drawing.Size(33, 16);
            this.SIClabel.TabIndex = 1;
            this.SIClabel.Text = "SIC: ";
            // 
            // AircraftDataLabel
            // 
            this.AircraftDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AircraftDataLabel.AutoSize = true;
            this.AircraftDataLabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AircraftDataLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AircraftDataLabel.Location = new System.Drawing.Point(18, 4);
            this.AircraftDataLabel.Name = "AircraftDataLabel";
            this.AircraftDataLabel.Size = new System.Drawing.Size(139, 19);
            this.AircraftDataLabel.TabIndex = 0;
            this.AircraftDataLabel.Text = "Aircraft Data";
            // 
            // panelTime
            // 
            this.panelTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.panelTime.Size = new System.Drawing.Size(283, 218);
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
            this.Layerlabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Layerlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Layerlabel.Location = new System.Drawing.Point(13, 4);
            this.Layerlabel.Name = "Layerlabel";
            this.Layerlabel.Size = new System.Drawing.Size(128, 19);
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
            this.layerListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.layerListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.layerListBox.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layerListBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.layerListBox.FormattingEnabled = true;
            this.layerListBox.Location = new System.Drawing.Point(61, 28);
            this.layerListBox.Name = "layerListBox";
            this.layerListBox.Size = new System.Drawing.Size(141, 95);
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
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButton.Location = new System.Drawing.Point(251, 4);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(27, 28);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
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
            this.panelInfo.Size = new System.Drawing.Size(364, 218);
            this.panelInfo.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Speedlabel);
            this.panel2.Controls.Add(this.SpeedTrackBar);
            this.panel2.Controls.Add(this.startPause);
            this.panel2.Controls.Add(this.previus);
            this.panel2.Controls.Add(this.Nextbutton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 107);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(16, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Controls";
            // 
            // Speedlabel
            // 
            this.Speedlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Speedlabel.AutoSize = true;
            this.Speedlabel.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speedlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Speedlabel.Location = new System.Drawing.Point(28, 78);
            this.Speedlabel.Name = "Speedlabel";
            this.Speedlabel.Size = new System.Drawing.Size(62, 16);
            this.Speedlabel.TabIndex = 5;
            this.Speedlabel.Text = "Speed: x1";
            // 
            // SpeedTrackBar
            // 
            this.SpeedTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpeedTrackBar.Location = new System.Drawing.Point(17, 39);
            this.SpeedTrackBar.Maximum = 5;
            this.SpeedTrackBar.Minimum = 1;
            this.SpeedTrackBar.Name = "SpeedTrackBar";
            this.SpeedTrackBar.Size = new System.Drawing.Size(182, 56);
            this.SpeedTrackBar.TabIndex = 4;
            this.SpeedTrackBar.Value = 1;
            this.SpeedTrackBar.Scroll += new System.EventHandler(this.SpeedTrackBar_Scroll);
            // 
            // startPause
            // 
            this.startPause.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startPause.BackgroundImage")));
            this.startPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.startPause.FlatAppearance.BorderSize = 0;
            this.startPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startPause.Location = new System.Drawing.Point(270, 39);
            this.startPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startPause.Name = "startPause";
            this.startPause.Size = new System.Drawing.Size(40, 40);
            this.startPause.TabIndex = 0;
            this.startPause.UseVisualStyleBackColor = false;
            this.startPause.Click += new System.EventHandler(this.startPause_Click);
            // 
            // previus
            // 
            this.previus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.previus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previus.BackgroundImage")));
            this.previus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previus.FlatAppearance.BorderSize = 0;
            this.previus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previus.Location = new System.Drawing.Point(224, 39);
            this.previus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.previus.Name = "previus";
            this.previus.Size = new System.Drawing.Size(40, 40);
            this.previus.TabIndex = 3;
            this.previus.UseVisualStyleBackColor = false;
            this.previus.Click += new System.EventHandler(this.previus_Click);
            // 
            // Nextbutton
            // 
            this.Nextbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Nextbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Nextbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Nextbutton.BackgroundImage")));
            this.Nextbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Nextbutton.FlatAppearance.BorderSize = 0;
            this.Nextbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nextbutton.Location = new System.Drawing.Point(316, 39);
            this.Nextbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Nextbutton.Name = "Nextbutton";
            this.Nextbutton.Size = new System.Drawing.Size(40, 40);
            this.Nextbutton.TabIndex = 2;
            this.Nextbutton.UseVisualStyleBackColor = false;
            this.Nextbutton.Click += new System.EventHandler(this.Nextbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Setbutton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ScomboBox);
            this.panel1.Controls.Add(this.McomboBox);
            this.panel1.Controls.Add(this.HcomboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.endlabel);
            this.panel1.Controls.Add(this.startlabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 111);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(14, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Time ";
            // 
            // Setbutton
            // 
            this.Setbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Setbutton.BackColor = System.Drawing.Color.DimGray;
            this.Setbutton.FlatAppearance.BorderSize = 0;
            this.Setbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Setbutton.Font = new System.Drawing.Font("Copperplate Gothic Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Setbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Setbutton.Location = new System.Drawing.Point(292, 64);
            this.Setbutton.Name = "Setbutton";
            this.Setbutton.Size = new System.Drawing.Size(64, 29);
            this.Setbutton.TabIndex = 8;
            this.Setbutton.Text = "Set";
            this.Setbutton.UseVisualStyleBackColor = false;
            this.Setbutton.Click += new System.EventHandler(this.Setbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(205, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(129, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = ":";
            // 
            // ScomboBox
            // 
            this.ScomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScomboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ScomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScomboBox.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScomboBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScomboBox.FormattingEnabled = true;
            this.ScomboBox.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.ScomboBox.Location = new System.Drawing.Point(225, 68);
            this.ScomboBox.Name = "ScomboBox";
            this.ScomboBox.Size = new System.Drawing.Size(46, 23);
            this.ScomboBox.TabIndex = 5;
            // 
            // McomboBox
            // 
            this.McomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.McomboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.McomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.McomboBox.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.McomboBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.McomboBox.FormattingEnabled = true;
            this.McomboBox.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.McomboBox.Location = new System.Drawing.Point(149, 68);
            this.McomboBox.Name = "McomboBox";
            this.McomboBox.Size = new System.Drawing.Size(55, 23);
            this.McomboBox.TabIndex = 4;
            // 
            // HcomboBox
            // 
            this.HcomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HcomboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HcomboBox.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HcomboBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HcomboBox.FormattingEnabled = true;
            this.HcomboBox.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.HcomboBox.Location = new System.Drawing.Point(71, 68);
            this.HcomboBox.Name = "HcomboBox";
            this.HcomboBox.Size = new System.Drawing.Size(52, 23);
            this.HcomboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(10, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Skip at:";
            // 
            // endlabel
            // 
            this.endlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endlabel.AutoSize = true;
            this.endlabel.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.endlabel.Location = new System.Drawing.Point(194, 27);
            this.endlabel.Name = "endlabel";
            this.endlabel.Size = new System.Drawing.Size(153, 16);
            this.endlabel.TabIndex = 1;
            this.endlabel.Text = "End Simulation: 00:00:00";
            // 
            // startlabel
            // 
            this.startlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startlabel.AutoSize = true;
            this.startlabel.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startlabel.Location = new System.Drawing.Point(10, 27);
            this.startlabel.Name = "startlabel";
            this.startlabel.Size = new System.Drawing.Size(160, 16);
            this.startlabel.TabIndex = 0;
            this.startlabel.Text = "Start Simulation: 00:00:00";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
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
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).EndInit();
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
        private System.Windows.Forms.TrackBar SpeedTrackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ScomboBox;
        private System.Windows.Forms.ComboBox McomboBox;
        private System.Windows.Forms.ComboBox HcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label endlabel;
        private System.Windows.Forms.Label startlabel;
        private System.Windows.Forms.Button Setbutton;
        private System.Windows.Forms.Label Speedlabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}