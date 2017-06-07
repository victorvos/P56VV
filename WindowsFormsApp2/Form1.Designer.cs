namespace WindowsFormsApp2
{
    partial class LoginForm
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
            this.Login = new System.Windows.Forms.TabControl();
            this.L = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginTextBoxPassword = new System.Windows.Forms.TextBox();
            this.loginTextBoxUsername = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.registerUsernameLabel1 = new System.Windows.Forms.Label();
            this.registerTextBoxUsername = new System.Windows.Forms.TextBox();
            this.registerLabelMessage = new System.Windows.Forms.Label();
            this.loginLabelMessage = new System.Windows.Forms.Label();
            this.Login.SuspendLayout();
            this.L.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Controls.Add(this.L);
            this.Login.Controls.Add(this.tabPage2);
            this.Login.Location = new System.Drawing.Point(1, 3);
            this.Login.Name = "Login";
            this.Login.SelectedIndex = 0;
            this.Login.Size = new System.Drawing.Size(358, 235);
            this.Login.TabIndex = 0;
            // 
            // L
            // 
            this.L.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.L.Controls.Add(this.loginLabelMessage);
            this.L.Controls.Add(this.loginTextBoxUsername);
            this.L.Controls.Add(this.loginTextBoxPassword);
            this.L.Controls.Add(this.label2);
            this.L.Controls.Add(this.label1);
            this.L.Controls.Add(this.button1);
            this.L.Location = new System.Drawing.Point(4, 22);
            this.L.Name = "L";
            this.L.Padding = new System.Windows.Forms.Padding(3);
            this.L.Size = new System.Drawing.Size(350, 209);
            this.L.TabIndex = 0;
            this.L.Text = "Login";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tabPage2.Controls.Add(this.registerLabelMessage);
            this.tabPage2.Controls.Add(this.registerTextBoxUsername);
            this.tabPage2.Controls.Add(this.registerUsernameLabel1);
            this.tabPage2.Controls.Add(this.registerButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(350, 209);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Register";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button1.Location = new System.Drawing.Point(255, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(20, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // loginTextBoxPassword
            // 
            this.loginTextBoxPassword.Location = new System.Drawing.Point(133, 75);
            this.loginTextBoxPassword.Name = "loginTextBoxPassword";
            this.loginTextBoxPassword.Size = new System.Drawing.Size(188, 20);
            this.loginTextBoxPassword.TabIndex = 3;
            // 
            // loginTextBoxUsername
            // 
            this.loginTextBoxUsername.Location = new System.Drawing.Point(133, 29);
            this.loginTextBoxUsername.Name = "loginTextBoxUsername";
            this.loginTextBoxUsername.Size = new System.Drawing.Size(188, 20);
            this.loginTextBoxUsername.TabIndex = 4;
            this.loginTextBoxUsername.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.registerButton.Location = new System.Drawing.Point(255, 166);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 35);
            this.registerButton.TabIndex = 0;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton1_Click);
            // 
            // registerUsernameLabel1
            // 
            this.registerUsernameLabel1.AutoSize = true;
            this.registerUsernameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.registerUsernameLabel1.Location = new System.Drawing.Point(18, 20);
            this.registerUsernameLabel1.Name = "registerUsernameLabel1";
            this.registerUsernameLabel1.Size = new System.Drawing.Size(97, 24);
            this.registerUsernameLabel1.TabIndex = 1;
            this.registerUsernameLabel1.Text = "Username";
            this.registerUsernameLabel1.Click += new System.EventHandler(this.label3_Click);
            // 
            // registerTextBoxUsername
            // 
            this.registerTextBoxUsername.Location = new System.Drawing.Point(132, 25);
            this.registerTextBoxUsername.Name = "registerTextBoxUsername";
            this.registerTextBoxUsername.Size = new System.Drawing.Size(170, 20);
            this.registerTextBoxUsername.TabIndex = 2;
            this.registerTextBoxUsername.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // registerLabelMessage
            // 
            this.registerLabelMessage.AutoSize = true;
            this.registerLabelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.registerLabelMessage.Location = new System.Drawing.Point(19, 74);
            this.registerLabelMessage.Name = "registerLabelMessage";
            this.registerLabelMessage.Size = new System.Drawing.Size(0, 20);
            this.registerLabelMessage.TabIndex = 3;
            this.registerLabelMessage.Click += new System.EventHandler(this.label4_Click);
            // 
            // loginLabelMessage
            // 
            this.loginLabelMessage.AutoSize = true;
            this.loginLabelMessage.Location = new System.Drawing.Point(21, 124);
            this.loginLabelMessage.Name = "loginLabelMessage";
            this.loginLabelMessage.Size = new System.Drawing.Size(0, 13);
            this.loginLabelMessage.TabIndex = 5;
            this.loginLabelMessage.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 238);
            this.Controls.Add(this.Login);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Login.ResumeLayout(false);
            this.L.ResumeLayout(false);
            this.L.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Login;
        private System.Windows.Forms.TabPage L;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginTextBoxUsername;
        private System.Windows.Forms.TextBox loginTextBoxPassword;
        private System.Windows.Forms.Label registerUsernameLabel1;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox registerTextBoxUsername;
        private System.Windows.Forms.Label registerLabelMessage;
        private System.Windows.Forms.Label loginLabelMessage;
    }
}

