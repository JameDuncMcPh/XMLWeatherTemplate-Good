namespace XMLWeather
{
    partial class Forecast
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateLabel = new System.Windows.Forms.Label();
            this.windLAbel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.locationLabel = new System.Windows.Forms.Label();
            this.date2Label = new System.Windows.Forms.Label();
            this.wind2Label = new System.Windows.Forms.Label();
            this.temp2Label = new System.Windows.Forms.Label();
            this.weather3Box = new System.Windows.Forms.PictureBox();
            this.weatherBox = new System.Windows.Forms.PictureBox();
            this.weather2Box = new System.Windows.Forms.PictureBox();
            this.date3Label = new System.Windows.Forms.Label();
            this.wind3Label = new System.Windows.Forms.Label();
            this.temp3Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weather3Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weather2Box)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(22, 36);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(42, 18);
            this.dateLabel.TabIndex = 11;
            this.dateLabel.Text = "label2";
            // 
            // windLAbel
            // 
            this.windLAbel.AutoSize = true;
            this.windLAbel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windLAbel.Location = new System.Drawing.Point(22, 105);
            this.windLAbel.Name = "windLAbel";
            this.windLAbel.Size = new System.Drawing.Size(42, 18);
            this.windLAbel.TabIndex = 10;
            this.windLAbel.Text = "label3";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.Location = new System.Drawing.Point(22, 70);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(42, 18);
            this.tempLabel.TabIndex = 9;
            this.tempLabel.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Go to Current";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(87, 20);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(42, 18);
            this.locationLabel.TabIndex = 7;
            this.locationLabel.Text = "label1";
            // 
            // date2Label
            // 
            this.date2Label.AutoSize = true;
            this.date2Label.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2Label.Location = new System.Drawing.Point(22, 138);
            this.date2Label.Name = "date2Label";
            this.date2Label.Size = new System.Drawing.Size(42, 18);
            this.date2Label.TabIndex = 15;
            this.date2Label.Text = "label2";
            // 
            // wind2Label
            // 
            this.wind2Label.AutoSize = true;
            this.wind2Label.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wind2Label.Location = new System.Drawing.Point(22, 198);
            this.wind2Label.Name = "wind2Label";
            this.wind2Label.Size = new System.Drawing.Size(42, 18);
            this.wind2Label.TabIndex = 14;
            this.wind2Label.Text = "label3";
            // 
            // temp2Label
            // 
            this.temp2Label.AutoSize = true;
            this.temp2Label.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp2Label.Location = new System.Drawing.Point(22, 168);
            this.temp2Label.Name = "temp2Label";
            this.temp2Label.Size = new System.Drawing.Size(42, 18);
            this.temp2Label.TabIndex = 13;
            this.temp2Label.Text = "label2";
            // 
            // weather3Box
            // 
            this.weather3Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weather3Box.Location = new System.Drawing.Point(129, 222);
            this.weather3Box.Name = "weather3Box";
            this.weather3Box.Size = new System.Drawing.Size(100, 87);
            this.weather3Box.TabIndex = 16;
            this.weather3Box.TabStop = false;
            // 
            // weatherBox
            // 
            this.weatherBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weatherBox.Location = new System.Drawing.Point(129, 36);
            this.weatherBox.Name = "weatherBox";
            this.weatherBox.Size = new System.Drawing.Size(100, 87);
            this.weatherBox.TabIndex = 12;
            this.weatherBox.TabStop = false;
            // 
            // weather2Box
            // 
            this.weather2Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weather2Box.Location = new System.Drawing.Point(129, 129);
            this.weather2Box.Name = "weather2Box";
            this.weather2Box.Size = new System.Drawing.Size(100, 87);
            this.weather2Box.TabIndex = 20;
            this.weather2Box.TabStop = false;
            // 
            // date3Label
            // 
            this.date3Label.AutoSize = true;
            this.date3Label.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date3Label.Location = new System.Drawing.Point(22, 234);
            this.date3Label.Name = "date3Label";
            this.date3Label.Size = new System.Drawing.Size(42, 18);
            this.date3Label.TabIndex = 19;
            this.date3Label.Text = "label2";
            // 
            // wind3Label
            // 
            this.wind3Label.AutoSize = true;
            this.wind3Label.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wind3Label.Location = new System.Drawing.Point(22, 291);
            this.wind3Label.Name = "wind3Label";
            this.wind3Label.Size = new System.Drawing.Size(42, 18);
            this.wind3Label.TabIndex = 18;
            this.wind3Label.Text = "label3";
            // 
            // temp3Label
            // 
            this.temp3Label.AutoSize = true;
            this.temp3Label.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp3Label.Location = new System.Drawing.Point(22, 262);
            this.temp3Label.Name = "temp3Label";
            this.temp3Label.Size = new System.Drawing.Size(42, 18);
            this.temp3Label.TabIndex = 17;
            this.temp3Label.Text = "label2";
            // 
            // Forecast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.weather2Box);
            this.Controls.Add(this.date3Label);
            this.Controls.Add(this.wind3Label);
            this.Controls.Add(this.temp3Label);
            this.Controls.Add(this.weather3Box);
            this.Controls.Add(this.date2Label);
            this.Controls.Add(this.wind2Label);
            this.Controls.Add(this.temp2Label);
            this.Controls.Add(this.weatherBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.windLAbel);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.locationLabel);
            this.Name = "Forecast";
            this.Size = new System.Drawing.Size(260, 358);
            this.Load += new System.EventHandler(this.Forecast_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weather3Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weather2Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox weatherBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label windLAbel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.PictureBox weather3Box;
        private System.Windows.Forms.Label date2Label;
        private System.Windows.Forms.Label wind2Label;
        private System.Windows.Forms.Label temp2Label;
        private System.Windows.Forms.PictureBox weather2Box;
        private System.Windows.Forms.Label date3Label;
        private System.Windows.Forms.Label wind3Label;
        private System.Windows.Forms.Label temp3Label;
    }
}
