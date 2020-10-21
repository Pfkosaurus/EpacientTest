namespace E_Pacient
{
    partial class DoktorScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorScreen));
            this.NewPatientForm = new System.Windows.Forms.Button();
            this.SettingsForm = new System.Windows.Forms.Button();
            this.AppointmentForm = new System.Windows.Forms.Button();
            this.SearchPatientForm = new System.Windows.Forms.Button();
            this.ToDoListForm = new System.Windows.Forms.Button();
            this.LogOutForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewPatientForm
            // 
            this.NewPatientForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NewPatientForm.BackgroundImage")));
            this.NewPatientForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NewPatientForm.Location = new System.Drawing.Point(37, 40);
            this.NewPatientForm.Name = "NewPatientForm";
            this.NewPatientForm.Size = new System.Drawing.Size(249, 270);
            this.NewPatientForm.TabIndex = 0;
            this.NewPatientForm.UseVisualStyleBackColor = true;
            this.NewPatientForm.Click += new System.EventHandler(this.NewPatientForm_Click);
            // 
            // SettingsForm
            // 
            this.SettingsForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingsForm.BackgroundImage")));
            this.SettingsForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SettingsForm.Location = new System.Drawing.Point(292, 316);
            this.SettingsForm.Name = "SettingsForm";
            this.SettingsForm.Size = new System.Drawing.Size(305, 257);
            this.SettingsForm.TabIndex = 1;
            this.SettingsForm.UseVisualStyleBackColor = true;
            this.SettingsForm.Click += new System.EventHandler(this.SettingsForm_Click);
            // 
            // AppointmentForm
            // 
            this.AppointmentForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AppointmentForm.BackgroundImage")));
            this.AppointmentForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AppointmentForm.Location = new System.Drawing.Point(292, 40);
            this.AppointmentForm.Name = "AppointmentForm";
            this.AppointmentForm.Size = new System.Drawing.Size(305, 270);
            this.AppointmentForm.TabIndex = 2;
            this.AppointmentForm.UseVisualStyleBackColor = true;
            this.AppointmentForm.Click += new System.EventHandler(this.AppointmentForm_Click);
            // 
            // SearchPatientForm
            // 
            this.SearchPatientForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchPatientForm.BackgroundImage")));
            this.SearchPatientForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SearchPatientForm.Location = new System.Drawing.Point(37, 316);
            this.SearchPatientForm.Name = "SearchPatientForm";
            this.SearchPatientForm.Size = new System.Drawing.Size(249, 257);
            this.SearchPatientForm.TabIndex = 3;
            this.SearchPatientForm.UseVisualStyleBackColor = true;
            this.SearchPatientForm.Click += new System.EventHandler(this.SearchPatientForm_Click);
            // 
            // ToDoListForm
            // 
            this.ToDoListForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ToDoListForm.BackgroundImage")));
            this.ToDoListForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ToDoListForm.Location = new System.Drawing.Point(603, 40);
            this.ToDoListForm.Name = "ToDoListForm";
            this.ToDoListForm.Size = new System.Drawing.Size(249, 322);
            this.ToDoListForm.TabIndex = 4;
            this.ToDoListForm.UseVisualStyleBackColor = true;
            this.ToDoListForm.Click += new System.EventHandler(this.ToDoListForm_Click);
            // 
            // LogOutForm
            // 
            this.LogOutForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogOutForm.BackgroundImage")));
            this.LogOutForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LogOutForm.Location = new System.Drawing.Point(603, 374);
            this.LogOutForm.Name = "LogOutForm";
            this.LogOutForm.Size = new System.Drawing.Size(249, 199);
            this.LogOutForm.TabIndex = 5;
            this.LogOutForm.UseVisualStyleBackColor = true;
            this.LogOutForm.Click += new System.EventHandler(this.LogOutForm_Click);
            // 
            // DoktorScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(895, 612);
            this.Controls.Add(this.LogOutForm);
            this.Controls.Add(this.ToDoListForm);
            this.Controls.Add(this.SearchPatientForm);
            this.Controls.Add(this.AppointmentForm);
            this.Controls.Add(this.SettingsForm);
            this.Controls.Add(this.NewPatientForm);
            this.Name = "DoktorScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoktorScreen";
            this.Load += new System.EventHandler(this.DoktorScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewPatientForm;
        private System.Windows.Forms.Button SettingsForm;
        private System.Windows.Forms.Button AppointmentForm;
        private System.Windows.Forms.Button SearchPatientForm;
        private System.Windows.Forms.Button ToDoListForm;
        private System.Windows.Forms.Button LogOutForm;
    }
}