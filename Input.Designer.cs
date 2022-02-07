namespace Car_Price_Prediction
{
    partial class Input
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Input));
            this.tbCN = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbPP = new System.Windows.Forms.TextBox();
            this.tbFT = new System.Windows.Forms.TextBox();
            this.tbST = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPredict = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ave_txt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.effect_txt = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCN
            // 
            this.tbCN.Location = new System.Drawing.Point(37, 144);
            this.tbCN.Name = "tbCN";
            this.tbCN.Size = new System.Drawing.Size(127, 23);
            this.tbCN.TabIndex = 0;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(293, 144);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(153, 23);
            this.tbYear.TabIndex = 1;
            // 
            // tbPP
            // 
            this.tbPP.Location = new System.Drawing.Point(553, 144);
            this.tbPP.Name = "tbPP";
            this.tbPP.Size = new System.Drawing.Size(161, 23);
            this.tbPP.TabIndex = 2;
            this.tbPP.TextChanged += new System.EventHandler(this.tbPP_TextChanged);
            // 
            // tbFT
            // 
            this.tbFT.Location = new System.Drawing.Point(37, 315);
            this.tbFT.Name = "tbFT";
            this.tbFT.Size = new System.Drawing.Size(127, 23);
            this.tbFT.TabIndex = 3;
            // 
            // tbST
            // 
            this.tbST.Location = new System.Drawing.Point(289, 315);
            this.tbST.Name = "tbST";
            this.tbST.Size = new System.Drawing.Size(153, 23);
            this.tbST.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Car Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(343, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(569, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Present Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(54, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fuel Type";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(312, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Seller Type";
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(458, 288);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(127, 56);
            this.btnPredict.TabIndex = 10;
            this.btnPredict.Text = "PREDICT";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(606, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "Average";
            // 
            // ave_txt
            // 
            this.ave_txt.AutoSize = true;
            this.ave_txt.BackColor = System.Drawing.Color.Transparent;
            this.ave_txt.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ave_txt.Location = new System.Drawing.Point(620, 233);
            this.ave_txt.Name = "ave_txt";
            this.ave_txt.Size = new System.Drawing.Size(17, 26);
            this.ave_txt.TabIndex = 12;
            this.ave_txt.Text = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(606, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 30);
            this.label8.TabIndex = 13;
            this.label8.Text = "Effect";
            // 
            // effect_txt
            // 
            this.effect_txt.AutoSize = true;
            this.effect_txt.BackColor = System.Drawing.Color.Transparent;
            this.effect_txt.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.effect_txt.Location = new System.Drawing.Point(620, 320);
            this.effect_txt.Name = "effect_txt";
            this.effect_txt.Size = new System.Drawing.Size(15, 24);
            this.effect_txt.TabIndex = 14;
            this.effect_txt.Text = " ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Franklin Gothic Demi", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(175, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(448, 61);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Car Price Prediction";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(765, 382);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.effect_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ave_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPredict);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbST);
            this.Controls.Add(this.tbFT);
            this.Controls.Add(this.tbPP);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbCN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Input";
            this.Text = "Car Price Prediction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbCN;
        private TextBox tbYear;
        private TextBox tbPP;
        private TextBox tbFT;
        private TextBox tbST;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnPredict;
        private Label label6;
        private Label ave_txt;
        private Label label8;
        private Label effect_txt;
        private Label lblTitle;
    }
}