namespace project___one_liners___jokes
{
    partial class JokeHub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JokeHub));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.submitBtn = new System.Windows.Forms.Button();
            this.natpisCategory = new System.Windows.Forms.Label();
            this.natpisPunchline = new System.Windows.Forms.Label();
            this.natpisQuestion = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.random_jokePage = new System.Windows.Forms.TabPage();
            this.randLike = new System.Windows.Forms.Button();
            this.randPunchlineLbl = new System.Windows.Forms.Label();
            this.revealRand = new System.Windows.Forms.Button();
            this.random_jokeLbl = new System.Windows.Forms.Label();
            this.random_jokeBtn = new System.Windows.Forms.Button();
            this.dirtyPage = new System.Windows.Forms.TabPage();
            this.punsPage = new System.Windows.Forms.TabPage();
            this.knock_knockPage = new System.Windows.Forms.TabPage();
            this.bad_jokesPage = new System.Windows.Forms.TabPage();
            this.otherPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.random_jokePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.random_jokePage);
            this.tabControl1.Controls.Add(this.dirtyPage);
            this.tabControl1.Controls.Add(this.punsPage);
            this.tabControl1.Controls.Add(this.knock_knockPage);
            this.tabControl1.Controls.Add(this.bad_jokesPage);
            this.tabControl1.Controls.Add(this.otherPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 551);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.Form1_Load);
            this.tabControl1.Click += new System.EventHandler(this.topPage_Click);
            this.tabControl1.Enter += new System.EventHandler(this.topPage_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.submitBtn);
            this.tabPage1.Controls.Add(this.natpisCategory);
            this.tabPage1.Controls.Add(this.natpisPunchline);
            this.tabPage1.Controls.Add(this.natpisQuestion);
            this.tabPage1.Controls.Add(this.radioButton5);
            this.tabPage1.Controls.Add(this.radioButton4);
            this.tabPage1.Controls.Add(this.radioButton3);
            this.tabPage1.Controls.Add(this.radioButton2);
            this.tabPage1.Controls.Add(this.radioButton1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Joke";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(305, 295);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(272, 55);
            this.submitBtn.TabIndex = 11;
            this.submitBtn.Text = "Submit Joke";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // natpisCategory
            // 
            this.natpisCategory.AutoSize = true;
            this.natpisCategory.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.natpisCategory.Location = new System.Drawing.Point(24, 218);
            this.natpisCategory.Name = "natpisCategory";
            this.natpisCategory.Size = new System.Drawing.Size(166, 27);
            this.natpisCategory.TabIndex = 10;
            this.natpisCategory.Text = "Choose Category";
            // 
            // natpisPunchline
            // 
            this.natpisPunchline.AutoSize = true;
            this.natpisPunchline.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.natpisPunchline.Location = new System.Drawing.Point(402, 36);
            this.natpisPunchline.Name = "natpisPunchline";
            this.natpisPunchline.Size = new System.Drawing.Size(147, 27);
            this.natpisPunchline.TabIndex = 9;
            this.natpisPunchline.Text = "Type Punchline";
            // 
            // natpisQuestion
            // 
            this.natpisQuestion.AutoSize = true;
            this.natpisQuestion.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.natpisQuestion.Location = new System.Drawing.Point(88, 36);
            this.natpisQuestion.Name = "natpisQuestion";
            this.natpisQuestion.Size = new System.Drawing.Size(162, 27);
            this.natpisQuestion.TabIndex = 8;
            this.natpisQuestion.Text = "Type \'Question\'";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.Location = new System.Drawing.Point(29, 340);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(51, 17);
            this.radioButton5.TabIndex = 7;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Other";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(29, 317);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(72, 17);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.Text = "Bad jokes";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(29, 294);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(89, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.Text = "Knock knock";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(29, 271);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(49, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Puns";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(29, 248);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "Dirty";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(342, 79);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 101);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 79);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 101);
            this.textBox1.TabIndex = 0;
            // 
            // random_jokePage
            // 
            this.random_jokePage.Controls.Add(this.randLike);
            this.random_jokePage.Controls.Add(this.randPunchlineLbl);
            this.random_jokePage.Controls.Add(this.revealRand);
            this.random_jokePage.Controls.Add(this.random_jokeLbl);
            this.random_jokePage.Controls.Add(this.random_jokeBtn);
            this.random_jokePage.Location = new System.Drawing.Point(4, 22);
            this.random_jokePage.Name = "random_jokePage";
            this.random_jokePage.Size = new System.Drawing.Size(876, 525);
            this.random_jokePage.TabIndex = 6;
            this.random_jokePage.Text = "RandomJoke";
            this.random_jokePage.UseVisualStyleBackColor = true;
            // 
            // randLike
            // 
            this.randLike.Location = new System.Drawing.Point(522, 204);
            this.randLike.Name = "randLike";
            this.randLike.Size = new System.Drawing.Size(75, 23);
            this.randLike.TabIndex = 4;
            this.randLike.Text = "button1";
            this.randLike.UseVisualStyleBackColor = true;
            this.randLike.Visible = false;
            // 
            // randPunchlineLbl
            // 
            this.randPunchlineLbl.AutoSize = true;
            this.randPunchlineLbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randPunchlineLbl.Location = new System.Drawing.Point(161, 312);
            this.randPunchlineLbl.Name = "randPunchlineLbl";
            this.randPunchlineLbl.Size = new System.Drawing.Size(67, 27);
            this.randPunchlineLbl.TabIndex = 3;
            this.randPunchlineLbl.Text = "label1";
            this.randPunchlineLbl.Visible = false;
            // 
            // revealRand
            // 
            this.revealRand.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revealRand.Location = new System.Drawing.Point(166, 195);
            this.revealRand.Name = "revealRand";
            this.revealRand.Size = new System.Drawing.Size(184, 37);
            this.revealRand.TabIndex = 2;
            this.revealRand.Text = "Reveal Punchline";
            this.revealRand.UseVisualStyleBackColor = true;
            // 
            // random_jokeLbl
            // 
            this.random_jokeLbl.AutoSize = true;
            this.random_jokeLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.random_jokeLbl.Location = new System.Drawing.Point(162, 36);
            this.random_jokeLbl.Name = "random_jokeLbl";
            this.random_jokeLbl.Size = new System.Drawing.Size(56, 23);
            this.random_jokeLbl.TabIndex = 1;
            this.random_jokeLbl.Text = "label1";
            this.random_jokeLbl.Visible = false;
            // 
            // random_jokeBtn
            // 
            this.random_jokeBtn.Location = new System.Drawing.Point(19, 36);
            this.random_jokeBtn.Name = "random_jokeBtn";
            this.random_jokeBtn.Size = new System.Drawing.Size(65, 338);
            this.random_jokeBtn.TabIndex = 0;
            this.random_jokeBtn.Text = "RANDOM JOKE";
            this.random_jokeBtn.UseVisualStyleBackColor = true;
            this.random_jokeBtn.Click += new System.EventHandler(this.random_jokeBtn_Click);
            // 
            // dirtyPage
            // 
            this.dirtyPage.AutoScroll = true;
            this.dirtyPage.Location = new System.Drawing.Point(4, 22);
            this.dirtyPage.Name = "dirtyPage";
            this.dirtyPage.Padding = new System.Windows.Forms.Padding(3);
            this.dirtyPage.Size = new System.Drawing.Size(876, 525);
            this.dirtyPage.TabIndex = 1;
            this.dirtyPage.Text = "Dirty";
            this.dirtyPage.UseVisualStyleBackColor = true;
            this.dirtyPage.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // punsPage
            // 
            this.punsPage.AutoScroll = true;
            this.punsPage.Location = new System.Drawing.Point(4, 22);
            this.punsPage.Name = "punsPage";
            this.punsPage.Padding = new System.Windows.Forms.Padding(3);
            this.punsPage.Size = new System.Drawing.Size(876, 525);
            this.punsPage.TabIndex = 2;
            this.punsPage.Text = "Puns";
            this.punsPage.UseVisualStyleBackColor = true;
            // 
            // knock_knockPage
            // 
            this.knock_knockPage.AutoScroll = true;
            this.knock_knockPage.Location = new System.Drawing.Point(4, 22);
            this.knock_knockPage.Name = "knock_knockPage";
            this.knock_knockPage.Size = new System.Drawing.Size(876, 525);
            this.knock_knockPage.TabIndex = 3;
            this.knock_knockPage.Text = "knock knock";
            this.knock_knockPage.UseVisualStyleBackColor = true;
            // 
            // bad_jokesPage
            // 
            this.bad_jokesPage.AutoScroll = true;
            this.bad_jokesPage.Location = new System.Drawing.Point(4, 22);
            this.bad_jokesPage.Name = "bad_jokesPage";
            this.bad_jokesPage.Size = new System.Drawing.Size(876, 525);
            this.bad_jokesPage.TabIndex = 4;
            this.bad_jokesPage.Text = "bad jokes";
            this.bad_jokesPage.UseVisualStyleBackColor = true;
            // 
            // otherPage
            // 
            this.otherPage.AutoScroll = true;
            this.otherPage.Location = new System.Drawing.Point(4, 22);
            this.otherPage.Name = "otherPage";
            this.otherPage.Size = new System.Drawing.Size(876, 525);
            this.otherPage.TabIndex = 5;
            this.otherPage.Text = "other";
            this.otherPage.UseVisualStyleBackColor = true;
            // 
            // JokeHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(884, 551);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JokeHub";
            this.Text = "JokeHub";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.random_jokePage.ResumeLayout(false);
            this.random_jokePage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label natpisCategory;
        private System.Windows.Forms.Label natpisPunchline;
        private System.Windows.Forms.Label natpisQuestion;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage dirtyPage;
        private System.Windows.Forms.TabPage punsPage;
        private System.Windows.Forms.TabPage knock_knockPage;
        private System.Windows.Forms.TabPage bad_jokesPage;
        private System.Windows.Forms.TabPage otherPage;
        private System.Windows.Forms.TabPage random_jokePage;
        private System.Windows.Forms.Label random_jokeLbl;
        private System.Windows.Forms.Button random_jokeBtn;
        private System.Windows.Forms.Button revealRand;
        private System.Windows.Forms.Label randPunchlineLbl;
        private System.Windows.Forms.Button randLike;
    }
}

