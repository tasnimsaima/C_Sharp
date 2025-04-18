
namespace DispensaryManagementSystem
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.passWordText = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.txtUser = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.SeaGreen;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(114, 240);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(90, 36);
            this.username.TabIndex = 1;
            this.username.Text = "Username";
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.username.Click += new System.EventHandler(this.label1_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.SeaGreen;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(115, 297);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(89, 37);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            this.password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userNameText
            // 
            this.userNameText.Location = new System.Drawing.Point(210, 240);
            this.userNameText.Multiline = true;
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(192, 36);
            this.userNameText.TabIndex = 3;
            // 
            // passWordText
            // 
            this.passWordText.Location = new System.Drawing.Point(210, 297);
            this.passWordText.Multiline = true;
            this.passWordText.Name = "passWordText";
            this.passWordText.Size = new System.Drawing.Size(192, 34);
            this.passWordText.TabIndex = 4;
            // 
            // pictureBox4
            // 
            this.pictureBox4.ErrorImage = global::DispensaryManagementSystem.Properties.Resources.pass21;
            this.pictureBox4.Image = global::DispensaryManagementSystem.Properties.Resources.pass21;
            this.pictureBox4.InitialImage = global::DispensaryManagementSystem.Properties.Resources.pass21;
            this.pictureBox4.Location = new System.Drawing.Point(51, 288);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(57, 52);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = global::DispensaryManagementSystem.Properties.Resources.thyugy;
            this.pictureBox2.Image = global::DispensaryManagementSystem.Properties.Resources.thyugy;
            this.pictureBox2.InitialImage = global::DispensaryManagementSystem.Properties.Resources.thyugy;
            this.pictureBox2.Location = new System.Drawing.Point(51, 230);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 52);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::DispensaryManagementSystem.Properties.Resources.The_Dispensary_Nv;
            this.pictureBox1.Image = global::DispensaryManagementSystem.Properties.Resources.The_Dispensary_Nv;
            this.pictureBox1.InitialImage = global::DispensaryManagementSystem.Properties.Resources.The_Dispensary_Nv;
            this.pictureBox1.Location = new System.Drawing.Point(63, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 168);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(326, 356);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(75, 23);
            this.metroTextBox1.TabIndex = 10;
            this.metroTextBox1.Text = "metroTextBox1";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(77, 356);
            this.txtUser.Name = "txtUser";
            this.txtUser.PromptText = "Enter User Name";
            this.txtUser.Size = new System.Drawing.Size(225, 24);
            this.txtUser.Style = MetroFramework.MetroColorStyle.Green;
            this.txtUser.TabIndex = 11;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 450);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.passWordText);
            this.Controls.Add(this.userNameText);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox passWordText;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox txtUser;
    }
}

