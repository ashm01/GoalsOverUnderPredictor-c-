namespace GoalsOverUnderPredictor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.getResultButton = new System.Windows.Forms.Button();
            this.label_Title = new System.Windows.Forms.Label();
            this.comboBox_League = new System.Windows.Forms.ComboBox();
            this.comboBox_Home = new System.Windows.Forms.ComboBox();
            this.comboBox_Away = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Home Team:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Away Team:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(225, 360);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 4;
            // 
            // getResultButton
            // 
            this.getResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getResultButton.Location = new System.Drawing.Point(189, 265);
            this.getResultButton.Name = "getResultButton";
            this.getResultButton.Size = new System.Drawing.Size(97, 34);
            this.getResultButton.TabIndex = 5;
            this.getResultButton.Text = "Predict";
            this.getResultButton.UseVisualStyleBackColor = true;
            this.getResultButton.Click += new System.EventHandler(this.getResultButton_Click);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Impact", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(23, 54);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(418, 37);
            this.label_Title.TabIndex = 6;
            this.label_Title.Text = "Football League Goal Predictor";
            // 
            // comboBox_League
            // 
            this.comboBox_League.FormattingEnabled = true;
            this.comboBox_League.Items.AddRange(new object[] {
            "Premiership",
            "Championship",
            "League One",
            "League Two"});
            this.comboBox_League.Location = new System.Drawing.Point(207, 124);
            this.comboBox_League.Name = "comboBox_League";
            this.comboBox_League.Size = new System.Drawing.Size(121, 21);
            this.comboBox_League.TabIndex = 7;
            this.comboBox_League.SelectedIndexChanged += new System.EventHandler(this.comboBox_League_SelectedIndexChanged);
            // 
            // comboBox_Home
            // 
            this.comboBox_Home.FormattingEnabled = true;
            this.comboBox_Home.Items.AddRange(new object[] {
            "Arsenal",
            "Aston Villa",
            "Bournemouth",
            "Chelsea",
            "Crystal Palace",
            "Everton",
            "Leicester",
            "Liverpool",
            "Man City",
            "Man United",
            "Newcastle",
            "Norwich",
            "Southampton",
            "Sunderland",
            "Stoke",
            "Swansea",
            "Tottenham",
            "Watford",
            "West Brom",
            "West Ham"});
            this.comboBox_Home.Location = new System.Drawing.Point(206, 166);
            this.comboBox_Home.Name = "comboBox_Home";
            this.comboBox_Home.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Home.TabIndex = 8;
            // 
            // comboBox_Away
            // 
            this.comboBox_Away.FormattingEnabled = true;
            this.comboBox_Away.Items.AddRange(new object[] {
            "Arsenal",
            "Aston Villa",
            "Bournemouth",
            "Chelsea",
            "Crystal Palace",
            "Everton",
            "Leicester",
            "Liverpool",
            "Man City",
            "Man United",
            "Newcastle",
            "Norwich",
            "Southampton",
            "Sunderland",
            "Stoke",
            "Swansea",
            "Tottenham",
            "Watford",
            "West Brom",
            "West Ham"});
            this.comboBox_Away.Location = new System.Drawing.Point(207, 208);
            this.comboBox_Away.Name = "comboBox_Away";
            this.comboBox_Away.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Away.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select League:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Over or Under 2.5 Goals:";
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Result.ForeColor = System.Drawing.Color.Red;
            this.label_Result.Location = new System.Drawing.Point(182, 395);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(159, 39);
            this.label_Result.TabIndex = 12;
            this.label_Result.Text = "RESULT";
            this.label_Result.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(475, 467);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Away);
            this.Controls.Add(this.comboBox_Home);
            this.Controls.Add(this.comboBox_League);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.getResultButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button getResultButton;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.ComboBox comboBox_League;
        private System.Windows.Forms.ComboBox comboBox_Home;
        private System.Windows.Forms.ComboBox comboBox_Away;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Result;
    }
}

