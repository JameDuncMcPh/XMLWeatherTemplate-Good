namespace XMLWeather
{
    partial class Current
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
            this.locationLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tempLabel = new System.Windows.Forms.Label();
            this.windLAbel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.weatherBox = new System.Windows.Forms.PictureBox();
            this.windSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBox)).BeginInit();
            this.SuspendLayout();
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(25, 32);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(42, 18);
            this.locationLabel.TabIndex = 0;
            this.locationLabel.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go to Forcast";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.Location = new System.Drawing.Point(25, 143);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(42, 18);
            this.tempLabel.TabIndex = 2;
            this.tempLabel.Text = "label2";
            // 
            // windLAbel
            // 
            this.windLAbel.AutoSize = true;
            this.windLAbel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windLAbel.Location = new System.Drawing.Point(25, 182);
            this.windLAbel.Name = "windLAbel";
            this.windLAbel.Size = new System.Drawing.Size(42, 18);
            this.windLAbel.TabIndex = 3;
            this.windLAbel.Text = "label3";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(137, 32);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(42, 18);
            this.dateLabel.TabIndex = 5;
            this.dateLabel.Text = "label2";
            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLabel.Location = new System.Drawing.Point(24, 89);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(52, 22);
            this.currentLabel.TabIndex = 7;
            this.currentLabel.Text = "label2";
            // 
            // weatherBox
            // 
            this.weatherBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weatherBox.Location = new System.Drawing.Point(111, 89);
            this.weatherBox.Name = "weatherBox";
            this.weatherBox.Size = new System.Drawing.Size(100, 111);
            this.weatherBox.TabIndex = 6;
            this.weatherBox.TabStop = false;
            // 
            // windSLabel
            // 
            this.windSLabel.AutoSize = true;
            this.windSLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windSLabel.Location = new System.Drawing.Point(25, 219);
            this.windSLabel.Name = "windSLabel";
            this.windSLabel.Size = new System.Drawing.Size(42, 18);
            this.windSLabel.TabIndex = 8;
            this.windSLabel.Text = "label3";
            // 
            // Current
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.windSLabel);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.weatherBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.windLAbel);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.locationLabel);
            this.Name = "Current";
            this.Size = new System.Drawing.Size(260, 310);
            this.Load += new System.EventHandler(this.Current_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weatherBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label windLAbel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.PictureBox weatherBox;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label windSLabel;
    }
}
