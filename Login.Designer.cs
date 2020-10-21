namespace E_Pacient
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailboxlog = new System.Windows.Forms.TextBox();
            this.hesloboxlog = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.forgotBtn = new System.Windows.Forms.Button();
            this.passChechBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(236, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(236, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Heslo";
            // 
            // emailboxlog
            // 
            this.emailboxlog.Location = new System.Drawing.Point(165, 123);
            this.emailboxlog.Name = "emailboxlog";
            this.emailboxlog.Size = new System.Drawing.Size(211, 20);
            this.emailboxlog.TabIndex = 2;
            // 
            // hesloboxlog
            // 
            this.hesloboxlog.Location = new System.Drawing.Point(165, 179);
            this.hesloboxlog.Name = "hesloboxlog";
            this.hesloboxlog.Size = new System.Drawing.Size(211, 20);
            this.hesloboxlog.TabIndex = 3;
            this.hesloboxlog.TextChanged += new System.EventHandler(this.hesloboxlog_TextChanged);
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.Location = new System.Drawing.Point(12, 385);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(118, 53);
            this.backBtn.TabIndex = 4;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginBtn.BackgroundImage")));
            this.loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginBtn.Location = new System.Drawing.Point(134, 385);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(244, 53);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // forgotBtn
            // 
            this.forgotBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("forgotBtn.BackgroundImage")));
            this.forgotBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forgotBtn.Location = new System.Drawing.Point(384, 385);
            this.forgotBtn.Name = "forgotBtn";
            this.forgotBtn.Size = new System.Drawing.Size(122, 53);
            this.forgotBtn.TabIndex = 6;
            this.forgotBtn.UseVisualStyleBackColor = true;
            this.forgotBtn.Click += new System.EventHandler(this.forgotBtn_Click);
            // 
            // passChechBox
            // 
            this.passChechBox.AutoSize = true;
            this.passChechBox.Location = new System.Drawing.Point(165, 206);
            this.passChechBox.Name = "passChechBox";
            this.passChechBox.Size = new System.Drawing.Size(93, 17);
            this.passChechBox.TabIndex = 7;
            this.passChechBox.Text = "Zobraziť heslo";
            this.passChechBox.UseVisualStyleBackColor = true;
            this.passChechBox.CheckedChanged += new System.EventHandler(this.passChechBox_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(149, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(17, 23);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(372, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(17, 23);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(372, 178);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(17, 23);
            this.panel4.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(149, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(17, 23);
            this.panel2.TabIndex = 9;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(518, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.passChechBox);
            this.Controls.Add(this.forgotBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.hesloboxlog);
            this.Controls.Add(this.emailboxlog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailboxlog;
        private System.Windows.Forms.TextBox hesloboxlog;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button forgotBtn;
        private System.Windows.Forms.CheckBox passChechBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
    }
}