namespace Five
{
    partial class Five
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Five));
            this.Question = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.scoretext = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.TextBox();
            this.Greater = new System.Windows.Forms.CheckBox();
            this.Smaller = new System.Windows.Forms.CheckBox();
            this.generate = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.BackColor = System.Drawing.SystemColors.Control;
            this.Question.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Question.Location = new System.Drawing.Point(-1, -3);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(500, 26);
            this.Question.TabIndex = 0;
            this.Question.Text = "Will the next number be greater or smaller than 5?";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(217, 206);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(61, 13);
            this.Score.TabIndex = 3;
            this.Score.Text = "Your score:";
            // 
            // scoretext
            // 
            this.scoretext.BackColor = System.Drawing.SystemColors.Control;
            this.scoretext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scoretext.Location = new System.Drawing.Point(284, 203);
            this.scoretext.Name = "scoretext";
            this.scoretext.Size = new System.Drawing.Size(20, 13);
            this.scoretext.TabIndex = 4;
            // 
            // Number
            // 
            this.Number.BackColor = System.Drawing.SystemColors.Control;
            this.Number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number.Location = new System.Drawing.Point(232, 56);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(27, 40);
            this.Number.TabIndex = 5;
            // 
            // Greater
            // 
            this.Greater.Appearance = System.Windows.Forms.Appearance.Button;
            this.Greater.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Greater.FlatAppearance.BorderSize = 7;
            this.Greater.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Greater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Greater.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Greater.Location = new System.Drawing.Point(310, 129);
            this.Greater.Name = "Greater";
            this.Greater.Size = new System.Drawing.Size(172, 74);
            this.Greater.TabIndex = 6;
            this.Greater.Text = "Greater";
            this.Greater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Greater.UseVisualStyleBackColor = false;
            this.Greater.CheckedChanged += new System.EventHandler(this.Greater_CheckedChanged);
            // 
            // Smaller
            // 
            this.Smaller.Appearance = System.Windows.Forms.Appearance.Button;
            this.Smaller.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Smaller.FlatAppearance.BorderSize = 7;
            this.Smaller.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Smaller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Smaller.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Smaller.Location = new System.Drawing.Point(28, 129);
            this.Smaller.Name = "Smaller";
            this.Smaller.Size = new System.Drawing.Size(172, 74);
            this.Smaller.TabIndex = 7;
            this.Smaller.Text = "Smaller";
            this.Smaller.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Smaller.UseVisualStyleBackColor = false;
            this.Smaller.CheckedChanged += new System.EventHandler(this.Smaller_CheckedChanged);
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(220, 147);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(75, 23);
            this.generate.TabIndex = 8;
            this.generate.Text = "generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Five
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 231);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.Smaller);
            this.Controls.Add(this.Greater);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.scoretext);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Question);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Five";
            this.Text = "Five";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.TextBox scoretext;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.CheckBox Greater;
        private System.Windows.Forms.CheckBox Smaller;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Timer timer1;
    }
}

