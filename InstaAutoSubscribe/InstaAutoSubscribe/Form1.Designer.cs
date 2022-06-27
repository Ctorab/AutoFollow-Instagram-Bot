namespace InstaAutoSubscribe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Users = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.AccLink = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.FollowersLimit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LogStatusLable = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Delay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PullFolowers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Users
            // 
            this.Users.FormattingEnabled = true;
            this.Users.ItemHeight = 20;
            this.Users.Location = new System.Drawing.Point(12, 41);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(175, 324);
            this.Users.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Followers:";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RefreshBtn.Location = new System.Drawing.Point(12, 389);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(175, 29);
            this.RefreshBtn.TabIndex = 2;
            this.RefreshBtn.Text = "Pull Followers";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // AccLink
            // 
            this.AccLink.Location = new System.Drawing.Point(244, 41);
            this.AccLink.Name = "AccLink";
            this.AccLink.Size = new System.Drawing.Size(202, 27);
            this.AccLink.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(244, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Target account name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(243, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Your account:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "User Name:";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(244, 121);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(202, 27);
            this.UserName.TabIndex = 8;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(244, 179);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(202, 27);
            this.Password.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(199, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FollowersLimit
            // 
            this.FollowersLimit.Location = new System.Drawing.Point(244, 293);
            this.FollowersLimit.Name = "FollowersLimit";
            this.FollowersLimit.Size = new System.Drawing.Size(202, 27);
            this.FollowersLimit.TabIndex = 11;
            this.FollowersLimit.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Follow limit:";
            // 
            // LogStatusLable
            // 
            this.LogStatusLable.AutoSize = true;
            this.LogStatusLable.Location = new System.Drawing.Point(367, 421);
            this.LogStatusLable.Name = "LogStatusLable";
            this.LogStatusLable.Size = new System.Drawing.Size(88, 20);
            this.LogStatusLable.TabIndex = 13;
            this.LogStatusLable.Text = "Logged Out";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(299, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 29);
            this.button2.TabIndex = 14;
            this.button2.Text = "Follow Pulled Users";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Delay
            // 
            this.Delay.Location = new System.Drawing.Point(243, 353);
            this.Delay.Name = "Delay";
            this.Delay.Size = new System.Drawing.Size(202, 27);
            this.Delay.TabIndex = 15;
            this.Delay.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Follow Delay in ms:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Pull Followers limit:";
            // 
            // PullFolowers
            // 
            this.PullFolowers.Location = new System.Drawing.Point(243, 241);
            this.PullFolowers.Name = "PullFolowers";
            this.PullFolowers.Size = new System.Drawing.Size(202, 27);
            this.PullFolowers.TabIndex = 18;
            this.PullFolowers.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.Controls.Add(this.PullFolowers);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Delay);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LogStatusLable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FollowersLimit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AccLink);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Users);
            this.Name = "Form1";
            this.Text = "AutoSubscriber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox Users;
        private Label label1;
        private Button RefreshBtn;
        private TextBox AccLink;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox UserName;
        private TextBox Password;
        private Button button1;
        private TextBox FollowersLimit;
        private Label label6;
        private Label LogStatusLable;
        private Button button2;
        private TextBox Delay;
        private Label label7;
        private Label label8;
        private TextBox PullFolowers;
    }
}