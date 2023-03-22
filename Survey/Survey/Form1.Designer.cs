namespace Survey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ans1a = new System.Windows.Forms.CheckBox();
            this.TitLab = new System.Windows.Forms.Label();
            this.ques1 = new System.Windows.Forms.Label();
            this.ans2a = new System.Windows.Forms.CheckBox();
            this.ans3a = new System.Windows.Forms.CheckBox();
            this.ans4a = new System.Windows.Forms.CheckBox();
            this.OthLab = new System.Windows.Forms.Label();
            this.OtherBox = new System.Windows.Forms.TextBox();
            this.SubBtn = new System.Windows.Forms.Button();
            this.ClrBtn = new System.Windows.Forms.Button();
            this.CloBtn = new System.Windows.Forms.Button();
            this.ans5a = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ans1a
            // 
            this.ans1a.AutoSize = true;
            this.ans1a.Location = new System.Drawing.Point(17, 70);
            this.ans1a.Name = "ans1a";
            this.ans1a.Size = new System.Drawing.Size(55, 17);
            this.ans1a.TabIndex = 0;
            this.ans1a.Text = "Japan";
            this.ans1a.UseVisualStyleBackColor = true;
            this.ans1a.CheckedChanged += new System.EventHandler(this.ans1a_CheckedChanged);
            // 
            // TitLab
            // 
            this.TitLab.AutoSize = true;
            this.TitLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitLab.Location = new System.Drawing.Point(12, 9);
            this.TitLab.Name = "TitLab";
            this.TitLab.Size = new System.Drawing.Size(80, 26);
            this.TitLab.TabIndex = 1;
            this.TitLab.Text = "Survey";
            // 
            // ques1
            // 
            this.ques1.AutoSize = true;
            this.ques1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ques1.Location = new System.Drawing.Point(12, 50);
            this.ques1.Name = "ques1";
            this.ques1.Size = new System.Drawing.Size(242, 17);
            this.ques1.TabIndex = 2;
            this.ques1.Text = "Which country would you like to visit?";
            // 
            // ans2a
            // 
            this.ans2a.AutoSize = true;
            this.ans2a.Location = new System.Drawing.Point(17, 93);
            this.ans2a.Name = "ans2a";
            this.ans2a.Size = new System.Drawing.Size(49, 17);
            this.ans2a.TabIndex = 3;
            this.ans2a.TabStop = false;
            this.ans2a.Text = "John";
            this.ans2a.UseVisualStyleBackColor = true;
            this.ans2a.CheckedChanged += new System.EventHandler(this.ans2a_CheckedChanged);
            // 
            // ans3a
            // 
            this.ans3a.AutoSize = true;
            this.ans3a.Location = new System.Drawing.Point(133, 70);
            this.ans3a.Name = "ans3a";
            this.ans3a.Size = new System.Drawing.Size(68, 17);
            this.ans3a.TabIndex = 4;
            this.ans3a.Text = "Germany";
            this.ans3a.UseVisualStyleBackColor = true;
            this.ans3a.CheckedChanged += new System.EventHandler(this.ans3a_CheckedChanged);
            // 
            // ans4a
            // 
            this.ans4a.AutoSize = true;
            this.ans4a.Location = new System.Drawing.Point(133, 93);
            this.ans4a.Name = "ans4a";
            this.ans4a.Size = new System.Drawing.Size(73, 17);
            this.ans4a.TabIndex = 5;
            this.ans4a.Text = "Poopistan";
            this.ans4a.UseVisualStyleBackColor = true;
            this.ans4a.CheckedChanged += new System.EventHandler(this.ans4a_CheckedChanged);
            // 
            // OthLab
            // 
            this.OthLab.AutoSize = true;
            this.OthLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OthLab.Location = new System.Drawing.Point(12, 146);
            this.OthLab.Name = "OthLab";
            this.OthLab.Size = new System.Drawing.Size(167, 17);
            this.OthLab.TabIndex = 6;
            this.OthLab.Text = "If Others, Please Specify:";
            this.OthLab.Click += new System.EventHandler(this.OthLab_Click);
            // 
            // OtherBox
            // 
            this.OtherBox.Location = new System.Drawing.Point(15, 178);
            this.OtherBox.Name = "OtherBox";
            this.OtherBox.Size = new System.Drawing.Size(164, 20);
            this.OtherBox.TabIndex = 7;
            this.OtherBox.TextChanged += new System.EventHandler(this.OtherBox_TextChanged);
            // 
            // SubBtn
            // 
            this.SubBtn.Location = new System.Drawing.Point(104, 231);
            this.SubBtn.Name = "SubBtn";
            this.SubBtn.Size = new System.Drawing.Size(75, 23);
            this.SubBtn.TabIndex = 8;
            this.SubBtn.Text = "Submit";
            this.SubBtn.UseVisualStyleBackColor = true;
            this.SubBtn.Click += new System.EventHandler(this.SubBtn_Click);
            // 
            // ClrBtn
            // 
            this.ClrBtn.Location = new System.Drawing.Point(104, 260);
            this.ClrBtn.Name = "ClrBtn";
            this.ClrBtn.Size = new System.Drawing.Size(75, 23);
            this.ClrBtn.TabIndex = 9;
            this.ClrBtn.Text = "Clear";
            this.ClrBtn.UseVisualStyleBackColor = true;
            this.ClrBtn.Click += new System.EventHandler(this.ClrBtn_Click);
            // 
            // CloBtn
            // 
            this.CloBtn.Location = new System.Drawing.Point(197, 260);
            this.CloBtn.Name = "CloBtn";
            this.CloBtn.Size = new System.Drawing.Size(75, 23);
            this.CloBtn.TabIndex = 10;
            this.CloBtn.Text = "Close";
            this.CloBtn.UseVisualStyleBackColor = true;
            this.CloBtn.Click += new System.EventHandler(this.CloBtn_Click);
            // 
            // ans5a
            // 
            this.ans5a.AutoSize = true;
            this.ans5a.Location = new System.Drawing.Point(17, 116);
            this.ans5a.Name = "ans5a";
            this.ans5a.Size = new System.Drawing.Size(57, 17);
            this.ans5a.TabIndex = 11;
            this.ans5a.Text = "Others";
            this.ans5a.UseVisualStyleBackColor = true;
            this.ans5a.CheckedChanged += new System.EventHandler(this.ans5a_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(444, 357);
            this.Controls.Add(this.ans5a);
            this.Controls.Add(this.CloBtn);
            this.Controls.Add(this.ClrBtn);
            this.Controls.Add(this.SubBtn);
            this.Controls.Add(this.OtherBox);
            this.Controls.Add(this.OthLab);
            this.Controls.Add(this.ans4a);
            this.Controls.Add(this.ans3a);
            this.Controls.Add(this.ans2a);
            this.Controls.Add(this.ques1);
            this.Controls.Add(this.TitLab);
            this.Controls.Add(this.ans1a);
            this.Name = "Form1";
            this.Text = "Survey";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ans1a;
        private System.Windows.Forms.Label TitLab;
        private System.Windows.Forms.Label ques1;
        private System.Windows.Forms.CheckBox ans2a;
        private System.Windows.Forms.CheckBox ans3a;
        private System.Windows.Forms.CheckBox ans4a;
        private System.Windows.Forms.Label OthLab;
        private System.Windows.Forms.TextBox OtherBox;
        private System.Windows.Forms.Button SubBtn;
        private System.Windows.Forms.Button ClrBtn;
        private System.Windows.Forms.Button CloBtn;
        private System.Windows.Forms.CheckBox ans5a;
    }
}

