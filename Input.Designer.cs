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
            this.SuspendLayout();
            // 
            // tbCN
            // 
            this.tbCN.Location = new System.Drawing.Point(50, 74);
            this.tbCN.Name = "tbCN";
            this.tbCN.Size = new System.Drawing.Size(100, 23);
            this.tbCN.TabIndex = 0;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(317, 74);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(100, 23);
            this.tbYear.TabIndex = 1;
            // 
            // tbPP
            // 
            this.tbPP.Location = new System.Drawing.Point(622, 74);
            this.tbPP.Name = "tbPP";
            this.tbPP.Size = new System.Drawing.Size(100, 23);
            this.tbPP.TabIndex = 2;
            this.tbPP.TextChanged += new System.EventHandler(this.tbPP_TextChanged);
            // 
            // tbFT
            // 
            this.tbFT.Location = new System.Drawing.Point(50, 234);
            this.tbFT.Name = "tbFT";
            this.tbFT.Size = new System.Drawing.Size(100, 23);
            this.tbFT.TabIndex = 3;
            // 
            // tbST
            // 
            this.tbST.Location = new System.Drawing.Point(317, 234);
            this.tbST.Name = "tbST";
            this.tbST.Size = new System.Drawing.Size(100, 23);
            this.tbST.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Car Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Present Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fuel Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Seller Type";
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(511, 220);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(75, 23);
            this.btnPredict.TabIndex = 10;
            this.btnPredict.Text = "PREDICT";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(648, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Average";
            // 
            // ave_txt
            // 
            this.ave_txt.AutoSize = true;
            this.ave_txt.Location = new System.Drawing.Point(648, 220);
            this.ave_txt.Name = "ave_txt";
            this.ave_txt.Size = new System.Drawing.Size(31, 15);
            this.ave_txt.TabIndex = 12;
            this.ave_txt.Text = "wew";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(648, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Effect";
            // 
            // effect_txt
            // 
            this.effect_txt.AutoSize = true;
            this.effect_txt.Location = new System.Drawing.Point(648, 278);
            this.effect_txt.Name = "effect_txt";
            this.effect_txt.Size = new System.Drawing.Size(37, 15);
            this.effect_txt.TabIndex = 14;
            this.effect_txt.Text = "effect";
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Input";
            this.Text = "Input";
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
    }
}