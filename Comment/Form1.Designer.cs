namespace Comment
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
            this.Close_button = new System.Windows.Forms.Button();
            this.Minimize_button = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Post = new System.Windows.Forms.TextBox();
            this.postlink = new System.Windows.Forms.Label();
            this.TestPost = new System.Windows.Forms.Button();
            this.PostError = new System.Windows.Forms.Label();
            this.PostGroup = new System.Windows.Forms.GroupBox();
            this.Controle = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.working = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NoShares = new System.Windows.Forms.TextBox();
            this.share = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NoComments = new System.Windows.Forms.TextBox();
            this.stop = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.RandomTime = new System.Windows.Forms.CheckBox();
            this.stickers = new System.Windows.Forms.CheckBox();
            this.emojis = new System.Windows.Forms.CheckBox();
            this.Generate = new System.Windows.Forms.Button();
            this.tip2 = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.Label();
            this.Comms = new System.Windows.Forms.Label();
            this.Comments = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.Label();
            this.Postchecker = new System.ComponentModel.BackgroundWorker();
            this.textgenerator = new System.ComponentModel.BackgroundWorker();
            this.Commenter = new System.ComponentModel.BackgroundWorker();
            this.PostGroup.SuspendLayout();
            this.Controle.SuspendLayout();
            this.SuspendLayout();
            // 
            // Close_button
            // 
            this.Close_button.FlatAppearance.BorderSize = 0;
            this.Close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_button.ForeColor = System.Drawing.Color.DimGray;
            this.Close_button.Location = new System.Drawing.Point(751, 0);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(54, 31);
            this.Close_button.TabIndex = 0;
            this.Close_button.Text = "X";
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            this.Close_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Close_button_MouseClick);
            this.Close_button.MouseLeave += new System.EventHandler(this.Close_button_MouseLeave);
            this.Close_button.MouseHover += new System.EventHandler(this.Close_button_MouseHover);
            // 
            // Minimize_button
            // 
            this.Minimize_button.FlatAppearance.BorderSize = 0;
            this.Minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_button.ForeColor = System.Drawing.Color.DimGray;
            this.Minimize_button.Location = new System.Drawing.Point(691, 0);
            this.Minimize_button.Name = "Minimize_button";
            this.Minimize_button.Size = new System.Drawing.Size(54, 31);
            this.Minimize_button.TabIndex = 1;
            this.Minimize_button.Text = "_";
            this.Minimize_button.UseVisualStyleBackColor = true;
            this.Minimize_button.Click += new System.EventHandler(this.Minimize_button_Click);
            // 
            // Status
            // 
            this.Status.Font = new System.Drawing.Font("Helvetica", 22F);
            this.Status.ForeColor = System.Drawing.Color.DimGray;
            this.Status.Location = new System.Drawing.Point(-1, 229);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(806, 36);
            this.Status.TabIndex = 2;
            this.Status.Text = "Checking (0/8)";
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Post
            // 
            this.Post.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Post.ForeColor = System.Drawing.Color.DimGray;
            this.Post.Location = new System.Drawing.Point(109, 25);
            this.Post.Name = "Post";
            this.Post.Size = new System.Drawing.Size(258, 26);
            this.Post.TabIndex = 3;
            // 
            // postlink
            // 
            this.postlink.AutoSize = true;
            this.postlink.ForeColor = System.Drawing.Color.DimGray;
            this.postlink.Location = new System.Drawing.Point(18, 27);
            this.postlink.Name = "postlink";
            this.postlink.Size = new System.Drawing.Size(85, 19);
            this.postlink.TabIndex = 4;
            this.postlink.Text = "Post URL :";
            // 
            // TestPost
            // 
            this.TestPost.FlatAppearance.BorderSize = 0;
            this.TestPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestPost.ForeColor = System.Drawing.Color.DimGray;
            this.TestPost.Location = new System.Drawing.Point(373, 25);
            this.TestPost.Name = "TestPost";
            this.TestPost.Size = new System.Drawing.Size(75, 26);
            this.TestPost.TabIndex = 5;
            this.TestPost.Text = "Check";
            this.TestPost.UseVisualStyleBackColor = true;
            this.TestPost.Click += new System.EventHandler(this.TestPost_Click);
            // 
            // PostError
            // 
            this.PostError.AutoSize = true;
            this.PostError.ForeColor = System.Drawing.Color.Red;
            this.PostError.Location = new System.Drawing.Point(454, 27);
            this.PostError.Name = "PostError";
            this.PostError.Size = new System.Drawing.Size(216, 19);
            this.PostError.TabIndex = 6;
            this.PostError.Text = "Check the url and connection";
            this.PostError.Visible = false;
            // 
            // PostGroup
            // 
            this.PostGroup.Controls.Add(this.Post);
            this.PostGroup.Controls.Add(this.PostError);
            this.PostGroup.Controls.Add(this.postlink);
            this.PostGroup.Controls.Add(this.TestPost);
            this.PostGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PostGroup.Location = new System.Drawing.Point(0, 37);
            this.PostGroup.Name = "PostGroup";
            this.PostGroup.Size = new System.Drawing.Size(805, 76);
            this.PostGroup.TabIndex = 7;
            this.PostGroup.TabStop = false;
            this.PostGroup.Visible = false;
            this.PostGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Controle
            // 
            this.Controle.Controls.Add(this.label4);
            this.Controle.Controls.Add(this.label3);
            this.Controle.Controls.Add(this.working);
            this.Controle.Controls.Add(this.label2);
            this.Controle.Controls.Add(this.NoShares);
            this.Controle.Controls.Add(this.share);
            this.Controle.Controls.Add(this.label1);
            this.Controle.Controls.Add(this.NoComments);
            this.Controle.Controls.Add(this.stop);
            this.Controle.Controls.Add(this.start);
            this.Controle.Controls.Add(this.RandomTime);
            this.Controle.Controls.Add(this.stickers);
            this.Controle.Controls.Add(this.emojis);
            this.Controle.Controls.Add(this.Generate);
            this.Controle.Controls.Add(this.tip2);
            this.Controle.Controls.Add(this.tip);
            this.Controle.Controls.Add(this.Comms);
            this.Controle.Controls.Add(this.Comments);
            this.Controle.Location = new System.Drawing.Point(0, 119);
            this.Controle.Name = "Controle";
            this.Controle.Size = new System.Drawing.Size(805, 382);
            this.Controle.TabIndex = 8;
            this.Controle.TabStop = false;
            this.Controle.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "leave empty for unlimited shares";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "leave empty for unlimited comments";
            // 
            // working
            // 
            this.working.ForeColor = System.Drawing.Color.Green;
            this.working.Location = new System.Drawing.Point(288, 342);
            this.working.Name = "working";
            this.working.Size = new System.Drawing.Size(469, 19);
            this.working.TabIndex = 20;
            this.working.Text = "Check the url and connection";
            this.working.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.working.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(37, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "How Many shares:";
            // 
            // NoShares
            // 
            this.NoShares.Enabled = false;
            this.NoShares.Location = new System.Drawing.Point(184, 257);
            this.NoShares.MaxLength = 10;
            this.NoShares.Name = "NoShares";
            this.NoShares.Size = new System.Drawing.Size(264, 26);
            this.NoShares.TabIndex = 18;
            this.NoShares.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoShares_KeyPress);
            // 
            // share
            // 
            this.share.AutoSize = true;
            this.share.Enabled = false;
            this.share.Location = new System.Drawing.Point(266, 191);
            this.share.Name = "share";
            this.share.Size = new System.Drawing.Size(122, 23);
            this.share.TabIndex = 17;
            this.share.Text = "Private share";
            this.share.UseVisualStyleBackColor = true;
            this.share.CheckedChanged += new System.EventHandler(this.share_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(12, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "How Many Comment :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NoComments
            // 
            this.NoComments.Enabled = false;
            this.NoComments.Location = new System.Drawing.Point(184, 225);
            this.NoComments.MaxLength = 10;
            this.NoComments.Name = "NoComments";
            this.NoComments.Size = new System.Drawing.Size(264, 26);
            this.NoComments.TabIndex = 15;
            this.NoComments.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.NoComments.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoComments_KeyPress);
            // 
            // stop
            // 
            this.stop.FlatAppearance.BorderSize = 0;
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.Location = new System.Drawing.Point(194, 334);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(108, 35);
            this.stop.TabIndex = 14;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Visible = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // start
            // 
            this.start.Enabled = false;
            this.start.FlatAppearance.BorderSize = 0;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Location = new System.Drawing.Point(109, 334);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(108, 35);
            this.start.TabIndex = 12;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // RandomTime
            // 
            this.RandomTime.AutoSize = true;
            this.RandomTime.Enabled = false;
            this.RandomTime.Location = new System.Drawing.Point(109, 191);
            this.RandomTime.Name = "RandomTime";
            this.RandomTime.Size = new System.Drawing.Size(151, 23);
            this.RandomTime.TabIndex = 11;
            this.RandomTime.Text = "Wait random time";
            this.RandomTime.UseVisualStyleBackColor = true;
            // 
            // stickers
            // 
            this.stickers.AutoSize = true;
            this.stickers.Enabled = false;
            this.stickers.Location = new System.Drawing.Point(223, 162);
            this.stickers.Name = "stickers";
            this.stickers.Size = new System.Drawing.Size(112, 23);
            this.stickers.TabIndex = 10;
            this.stickers.Text = "use stickers";
            this.stickers.UseVisualStyleBackColor = true;
            // 
            // emojis
            // 
            this.emojis.AutoSize = true;
            this.emojis.Enabled = false;
            this.emojis.Location = new System.Drawing.Point(109, 162);
            this.emojis.Name = "emojis";
            this.emojis.Size = new System.Drawing.Size(108, 23);
            this.emojis.TabIndex = 9;
            this.emojis.Text = "Use emojis";
            this.emojis.UseVisualStyleBackColor = true;
            // 
            // Generate
            // 
            this.Generate.Enabled = false;
            this.Generate.FlatAppearance.BorderSize = 0;
            this.Generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Generate.Location = new System.Drawing.Point(467, 119);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(278, 37);
            this.Generate.TabIndex = 8;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // tip2
            // 
            this.tip2.AutoSize = true;
            this.tip2.Location = new System.Drawing.Point(478, 47);
            this.tip2.Name = "tip2";
            this.tip2.Size = new System.Drawing.Size(223, 19);
            this.tip2.TabIndex = 7;
            this.tip2.Text = "separate every text with space";
            // 
            // tip
            // 
            this.tip.AutoSize = true;
            this.tip.Location = new System.Drawing.Point(463, 28);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(294, 19);
            this.tip.TabIndex = 6;
            this.tip.Text = "** I will choose random text from this box";
            // 
            // Comms
            // 
            this.Comms.AutoSize = true;
            this.Comms.ForeColor = System.Drawing.Color.DimGray;
            this.Comms.Location = new System.Drawing.Point(12, 28);
            this.Comms.Name = "Comms";
            this.Comms.Size = new System.Drawing.Size(94, 19);
            this.Comms.TabIndex = 5;
            this.Comms.Text = "Comments :";
            // 
            // Comments
            // 
            this.Comments.Enabled = false;
            this.Comments.Font = new System.Drawing.Font("Helvetica", 9F);
            this.Comments.ForeColor = System.Drawing.Color.DimGray;
            this.Comments.Location = new System.Drawing.Point(109, 25);
            this.Comments.Multiline = true;
            this.Comments.Name = "Comments";
            this.Comments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Comments.Size = new System.Drawing.Size(339, 131);
            this.Comments.TabIndex = 0;
            this.Comments.TextChanged += new System.EventHandler(this.Comments_TextChanged);
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.ForeColor = System.Drawing.Color.DimGray;
            this.logo.Location = new System.Drawing.Point(18, 6);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(192, 19);
            this.logo.TabIndex = 7;
            this.logo.Text = "Facebook auto comments";
            this.logo.Visible = false;
            // 
            // Postchecker
            // 
            this.Postchecker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Postchecker_DoWork);
            // 
            // textgenerator
            // 
            this.textgenerator.DoWork += new System.ComponentModel.DoWorkEventHandler(this.textgenerator_DoWork);
            // 
            // Commenter
            // 
            this.Commenter.WorkerSupportsCancellation = true;
            this.Commenter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Commenter_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.Controle);
            this.Controls.Add(this.PostGroup);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Minimize_button);
            this.Controls.Add(this.Close_button);
            this.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.PostGroup.ResumeLayout(false);
            this.PostGroup.PerformLayout();
            this.Controle.ResumeLayout(false);
            this.Controle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Button Minimize_button;
        private System.Windows.Forms.Label Status;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox Post;
        private System.Windows.Forms.Label postlink;
        private System.Windows.Forms.Button TestPost;
        private System.Windows.Forms.Label PostError;
        private System.Windows.Forms.GroupBox PostGroup;
        private System.Windows.Forms.GroupBox Controle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NoComments;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.CheckBox RandomTime;
        private System.Windows.Forms.CheckBox stickers;
        private System.Windows.Forms.CheckBox emojis;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Label tip2;
        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.Label Comms;
        private System.Windows.Forms.TextBox Comments;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Label working;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NoShares;
        private System.Windows.Forms.CheckBox share;
        private System.ComponentModel.BackgroundWorker Postchecker;
        private System.ComponentModel.BackgroundWorker textgenerator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker Commenter;
    }
}

