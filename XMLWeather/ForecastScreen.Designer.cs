namespace XMLWeather
{
    partial class ForecastScreen
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
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.min1 = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.max1 = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.min2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.max2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.date3 = new System.Windows.Forms.Label();
            this.max3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.min3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.Black;
            this.forecastLabel.Location = new System.Drawing.Point(213, 21);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(124, 43);
            this.forecastLabel.TabIndex = 62;
            this.forecastLabel.Text = "7 Day";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 43);
            this.label3.TabIndex = 61;
            this.label3.Text = "Today";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // min1
            // 
            this.min1.BackColor = System.Drawing.Color.White;
            this.min1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min1.Location = new System.Drawing.Point(216, 199);
            this.min1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min1.Name = "min1";
            this.min1.Size = new System.Drawing.Size(33, 20);
            this.min1.TabIndex = 48;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.BackColor = System.Drawing.Color.Transparent;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.Color.Black;
            this.minLabel.Location = new System.Drawing.Point(55, 199);
            this.minLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(64, 26);
            this.minLabel.TabIndex = 46;
            this.minLabel.Text = " Min:";
            this.minLabel.Click += new System.EventHandler(this.minLabel_Click);
            // 
            // max1
            // 
            this.max1.BackColor = System.Drawing.Color.White;
            this.max1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max1.Location = new System.Drawing.Point(216, 154);
            this.max1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max1.Name = "max1";
            this.max1.Size = new System.Drawing.Size(33, 20);
            this.max1.TabIndex = 45;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.ForeColor = System.Drawing.Color.Black;
            this.maxLabel.Location = new System.Drawing.Point(57, 154);
            this.maxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(63, 26);
            this.maxLabel.TabIndex = 44;
            this.maxLabel.Text = "Max:";
            this.maxLabel.Click += new System.EventHandler(this.maxLabel_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(194, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 41);
            this.label5.TabIndex = 63;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // date1
            // 
            this.date1.AutoSize = true;
            this.date1.BackColor = System.Drawing.Color.Transparent;
            this.date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.ForeColor = System.Drawing.Color.Black;
            this.date1.Location = new System.Drawing.Point(57, 113);
            this.date1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(62, 26);
            this.date1.TabIndex = 64;
            this.date1.Text = "Date";
            this.date1.Click += new System.EventHandler(this.date1_Click);
            // 
            // date2
            // 
            this.date2.AutoSize = true;
            this.date2.BackColor = System.Drawing.Color.Transparent;
            this.date2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.ForeColor = System.Drawing.Color.Black;
            this.date2.Location = new System.Drawing.Point(57, 265);
            this.date2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(62, 26);
            this.date2.TabIndex = 69;
            this.date2.Text = "Date";
            this.date2.Click += new System.EventHandler(this.date2_Click);
            // 
            // min2
            // 
            this.min2.BackColor = System.Drawing.Color.White;
            this.min2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min2.Location = new System.Drawing.Point(216, 351);
            this.min2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min2.Name = "min2";
            this.min2.Size = new System.Drawing.Size(33, 20);
            this.min2.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(55, 351);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 26);
            this.label4.TabIndex = 67;
            this.label4.Text = " Min:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // max2
            // 
            this.max2.BackColor = System.Drawing.Color.White;
            this.max2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max2.Location = new System.Drawing.Point(216, 306);
            this.max2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max2.Name = "max2";
            this.max2.Size = new System.Drawing.Size(33, 20);
            this.max2.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(57, 306);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 26);
            this.label7.TabIndex = 65;
            this.label7.Text = "Max:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // date3
            // 
            this.date3.AutoSize = true;
            this.date3.BackColor = System.Drawing.Color.Transparent;
            this.date3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date3.ForeColor = System.Drawing.Color.Black;
            this.date3.Location = new System.Drawing.Point(57, 415);
            this.date3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date3.Name = "date3";
            this.date3.Size = new System.Drawing.Size(62, 26);
            this.date3.TabIndex = 75;
            this.date3.Text = "Date";
            this.date3.Click += new System.EventHandler(this.date3_Click);
            // 
            // max3
            // 
            this.max3.BackColor = System.Drawing.Color.White;
            this.max3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max3.Location = new System.Drawing.Point(216, 501);
            this.max3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max3.Name = "max3";
            this.max3.Size = new System.Drawing.Size(33, 20);
            this.max3.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(55, 501);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 26);
            this.label8.TabIndex = 73;
            this.label8.Text = " Min ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // min3
            // 
            this.min3.BackColor = System.Drawing.Color.White;
            this.min3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min3.Location = new System.Drawing.Point(216, 456);
            this.min3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min3.Name = "min3";
            this.min3.Size = new System.Drawing.Size(33, 20);
            this.min3.TabIndex = 72;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(57, 456);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 26);
            this.label10.TabIndex = 71;
            this.label10.Text = "Max:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.date3);
            this.Controls.Add(this.max3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.min3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.min2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.max2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.min1);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.max1);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(375, 615);
            this.Load += new System.EventHandler(this.ForecastScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label min1;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label max1;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label min2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label max2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label date3;
        private System.Windows.Forms.Label max3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label min3;
        private System.Windows.Forms.Label label10;
    }
}
