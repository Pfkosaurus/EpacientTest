namespace E_Pacient
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1.BackgroundImage")));
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1.Location = new System.Drawing.Point(65, 85);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(381, 90);
            this.btn1.TabIndex = 0;
            this.btn1.UseMnemonic = false;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn2.BackgroundImage")));
            this.Btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn2.Location = new System.Drawing.Point(65, 181);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(381, 88);
            this.Btn2.TabIndex = 1;
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn3.BackgroundImage")));
            this.Btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn3.Location = new System.Drawing.Point(155, 275);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(204, 93);
            this.Btn3.TabIndex = 2;
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(518, 450);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.btn1);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
    }
}

