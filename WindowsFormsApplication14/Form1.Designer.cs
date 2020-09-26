namespace Projekt_SW
{
    partial class Form1
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TrackBarGamma = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.TrackBarSaturation = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.TrackBarBrightness = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.TrackBarContrast = new System.Windows.Forms.TrackBar();
            this.buttonDefault = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.TrackBarGamma);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.TrackBarSaturation);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.TrackBarBrightness);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.TrackBarContrast);
            this.groupBox.Location = new System.Drawing.Point(12, 462);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(904, 329);
            this.groupBox.TabIndex = 42;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Korekta";
            this.groupBox.Enter += new System.EventHandler(this.groupBox_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Gamma:";
            // 
            // TrackBarGamma
            // 
            this.TrackBarGamma.Location = new System.Drawing.Point(4, 274);
            this.TrackBarGamma.Maximum = 80;
            this.TrackBarGamma.Minimum = 4;
            this.TrackBarGamma.Name = "TrackBarGamma";
            this.TrackBarGamma.Size = new System.Drawing.Size(894, 45);
            this.TrackBarGamma.TabIndex = 29;
            this.TrackBarGamma.TickFrequency = 2;
            this.TrackBarGamma.Value = 20;
            this.TrackBarGamma.ValueChanged += new System.EventHandler(this.TrackBar3_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Saturation:";
            // 
            // TrackBarSaturation
            // 
            this.TrackBarSaturation.LargeChange = 50;
            this.TrackBarSaturation.Location = new System.Drawing.Point(4, 198);
            this.TrackBarSaturation.Maximum = 60;
            this.TrackBarSaturation.Name = "TrackBarSaturation";
            this.TrackBarSaturation.Size = new System.Drawing.Size(894, 45);
            this.TrackBarSaturation.SmallChange = 10;
            this.TrackBarSaturation.TabIndex = 24;
            this.TrackBarSaturation.TickFrequency = 2;
            this.TrackBarSaturation.Value = 20;
            this.TrackBarSaturation.ValueChanged += new System.EventHandler(this.TrackBar3_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Brightness:";
            // 
            // TrackBarBrightness
            // 
            this.TrackBarBrightness.LargeChange = 50;
            this.TrackBarBrightness.Location = new System.Drawing.Point(0, 32);
            this.TrackBarBrightness.Maximum = 20;
            this.TrackBarBrightness.Minimum = -20;
            this.TrackBarBrightness.Name = "TrackBarBrightness";
            this.TrackBarBrightness.Size = new System.Drawing.Size(898, 45);
            this.TrackBarBrightness.SmallChange = 10;
            this.TrackBarBrightness.TabIndex = 0;
            this.TrackBarBrightness.ValueChanged += new System.EventHandler(this.TrackBar3_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Contrast:";
            // 
            // TrackBarContrast
            // 
            this.TrackBarContrast.Location = new System.Drawing.Point(6, 114);
            this.TrackBarContrast.Maximum = 80;
            this.TrackBarContrast.Minimum = 4;
            this.TrackBarContrast.Name = "TrackBarContrast";
            this.TrackBarContrast.Size = new System.Drawing.Size(892, 45);
            this.TrackBarContrast.TabIndex = 22;
            this.TrackBarContrast.TickFrequency = 2;
            this.TrackBarContrast.Value = 20;
            this.TrackBarContrast.ValueChanged += new System.EventHandler(this.TrackBar3_ValueChanged);
            // 
            // buttonDefault
            // 
            this.buttonDefault.Location = new System.Drawing.Point(648, 383);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new System.Drawing.Size(262, 61);
            this.buttonDefault.TabIndex = 23;
            this.buttonDefault.Text = "Reset";
            this.buttonDefault.UseVisualStyleBackColor = true;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Projekt_SW.Properties.Resources.untitled;
            this.pictureBox.Location = new System.Drawing.Point(27, 20);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(615, 424);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 803);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonDefault);
            this.Name = "Form1";
            this.Text = "Korekta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar TrackBarGamma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar TrackBarSaturation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar TrackBarBrightness;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar TrackBarContrast;
        private System.Windows.Forms.Button buttonDefault;
    }
}

