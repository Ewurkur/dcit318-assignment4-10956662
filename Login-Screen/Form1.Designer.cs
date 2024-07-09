namespace Login_Screen
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
            textUsername = new TextBox();
            textPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Login = new Button();
            SuspendLayout();
            // 
            // textUsername
            // 
            textUsername.Location = new Point(394, 138);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(125, 27);
            textUsername.TabIndex = 0;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(394, 186);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(125, 27);
            textPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 138);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 2;
            label1.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 186);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 3;
            label2.Text = "password";
            // 
            // Login
            // 
            Login.Location = new Point(394, 234);
            Login.Name = "Login";
            Login.Size = new Size(94, 29);
            Login.TabIndex = 4;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textUsername;
        private TextBox textPassword;
        private Label label1;
        private Label label2;
        private Button Login;
    }
}
