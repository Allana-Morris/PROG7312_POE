namespace PROG7312_POE
{
    partial class DataVisual
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
            this.gMCClusterMap = new GMap.NET.WindowsForms.GMapControl();
            this.SuspendLayout();
            // 
            // gMCClusterMap
            // 
            this.gMCClusterMap.Bearing = 0F;
            this.gMCClusterMap.CanDragMap = true;
            this.gMCClusterMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMCClusterMap.GrayScaleMode = false;
            this.gMCClusterMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMCClusterMap.LevelsKeepInMemmory = 5;
            this.gMCClusterMap.Location = new System.Drawing.Point(12, 12);
            this.gMCClusterMap.MarkersEnabled = true;
            this.gMCClusterMap.MaxZoom = 2;
            this.gMCClusterMap.MinZoom = 2;
            this.gMCClusterMap.MouseWheelZoomEnabled = true;
            this.gMCClusterMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMCClusterMap.Name = "gMCClusterMap";
            this.gMCClusterMap.NegativeMode = false;
            this.gMCClusterMap.PolygonsEnabled = true;
            this.gMCClusterMap.RetryLoadTile = 0;
            this.gMCClusterMap.RoutesEnabled = true;
            this.gMCClusterMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMCClusterMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMCClusterMap.ShowTileGridLines = false;
            this.gMCClusterMap.Size = new System.Drawing.Size(227, 228);
            this.gMCClusterMap.TabIndex = 0;
            this.gMCClusterMap.Zoom = 0D;
            // 
            // DataVisual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gMCClusterMap);
            this.Name = "DataVisual";
            this.Text = "DataVisual";
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMCClusterMap;
    }
}