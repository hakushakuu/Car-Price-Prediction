namespace Car_Price_Prediction
{
    partial class Intro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intro));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Franklin Gothic Demi", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTitle.Location = new System.Drawing.Point(145, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(344, 43);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Car Price Prediction";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightGray;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Location = new System.Drawing.Point(454, 222);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(139, 58);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Developed by:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(12, 306);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(274, 15);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Bagasona, Kim Dianne G., Rosales, Earl Benjamin T.";
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(639, 330);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Intro";
            this.Text = "Car Price Prediction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Button btnStart;
        private Label label1;
        private Label lblName;
    }
}