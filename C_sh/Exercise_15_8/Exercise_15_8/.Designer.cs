namespace Exercise_15_8
{
    partial class LoginPasswordUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.passwordLabelB = new System.Windows.Forms.Label();
            this.passwordLabelA = new System.Windows.Forms.Label();
            this.loginLabelB = new System.Windows.Forms.Label();
            this.loginLabelA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(57, 56);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(63, 20);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login: ";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(175, 56);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(143, 20);
            this.loginTextBox.TabIndex = 1;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(57, 108);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(96, 20);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password: ";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(175, 108);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(143, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(62, 164);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(80, 32);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // passwordLabelB
            // 
            this.passwordLabelB.AutoSize = true;
            this.passwordLabelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabelB.Location = new System.Drawing.Point(170, 309);
            this.passwordLabelB.Name = "passwordLabelB";
            this.passwordLabelB.Size = new System.Drawing.Size(54, 20);
            this.passwordLabelB.TabIndex = 8;
            this.passwordLabelB.Text = "-          ";
            // 
            // passwordLabelA
            // 
            this.passwordLabelA.AutoSize = true;
            this.passwordLabelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabelA.Location = new System.Drawing.Point(58, 309);
            this.passwordLabelA.Name = "passwordLabelA";
            this.passwordLabelA.Size = new System.Drawing.Size(91, 20);
            this.passwordLabelA.TabIndex = 7;
            this.passwordLabelA.Text = "Password:";
            // 
            // loginLabelB
            // 
            this.loginLabelB.AutoSize = true;
            this.loginLabelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabelB.Location = new System.Drawing.Point(170, 251);
            this.loginLabelB.Name = "loginLabelB";
            this.loginLabelB.Size = new System.Drawing.Size(50, 20);
            this.loginLabelB.TabIndex = 6;
            this.loginLabelB.Text = "-         ";
            // 
            // loginLabelA
            // 
            this.loginLabelA.AutoSize = true;
            this.loginLabelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabelA.Location = new System.Drawing.Point(58, 251);
            this.loginLabelA.Name = "loginLabelA";
            this.loginLabelA.Size = new System.Drawing.Size(63, 20);
            this.loginLabelA.TabIndex = 5;
            this.loginLabelA.Text = "Login: ";
            // 
            // LoginPasswordUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.passwordLabelB);
            this.Controls.Add(this.passwordLabelA);
            this.Controls.Add(this.loginLabelB);
            this.Controls.Add(this.loginLabelA);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.loginLabel);
            this.Name = "LoginPasswordUserControl";
            this.Size = new System.Drawing.Size(517, 364);
            this.Load += new System.EventHandler(this.LoginPasswordUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label passwordLabelB;
        private System.Windows.Forms.Label passwordLabelA;
        private System.Windows.Forms.Label loginLabelB;
        private System.Windows.Forms.Label loginLabelA;
    }
}
