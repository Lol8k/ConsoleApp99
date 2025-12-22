namespace ConsoleApp99
{
    partial class AuthForm
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
            label1 = new Label();
            loginBox = new TextBox();
            passwordBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            roleBox = new ComboBox();
            authButton = new Button();
            errorBox = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 48);
            label1.Margin = new Padding(3, 0, 3, 10);
            label1.Name = "label1";
            label1.Size = new Size(50, 18);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // loginBox
            // 
            loginBox.Location = new Point(127, 79);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(200, 26);
            loginBox.TabIndex = 1;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(127, 159);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(200, 26);
            passwordBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 128);
            label2.Margin = new Padding(3, 20, 3, 10);
            label2.Name = "label2";
            label2.Size = new Size(63, 18);
            label2.TabIndex = 2;
            label2.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 208);
            label3.Margin = new Padding(3, 20, 3, 10);
            label3.Name = "label3";
            label3.Size = new Size(44, 18);
            label3.TabIndex = 4;
            label3.Text = "Роль";
            // 
            // roleBox
            // 
            roleBox.FormattingEnabled = true;
            roleBox.Location = new Point(127, 239);
            roleBox.Name = "roleBox";
            roleBox.Size = new Size(200, 26);
            roleBox.TabIndex = 5;
            // 
            // authButton
            // 
            authButton.Location = new Point(127, 398);
            authButton.Name = "authButton";
            authButton.Size = new Size(200, 51);
            authButton.TabIndex = 6;
            authButton.Text = "Войти";
            authButton.UseVisualStyleBackColor = true;
            authButton.Click += authButton_Click;
            // 
            // errorBox
            // 
            errorBox.Location = new Point(98, 371);
            errorBox.Name = "errorBox";
            errorBox.Size = new Size(374, 24);
            errorBox.TabIndex = 7;
            errorBox.Text = "label4";
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(errorBox);
            Controls.Add(authButton);
            Controls.Add(roleBox);
            Controls.Add(label3);
            Controls.Add(passwordBox);
            Controls.Add(label2);
            Controls.Add(loginBox);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(500, 500);
            Name = "AuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox loginBox;
        private TextBox passwordBox;
        private Label label2;
        private Label label3;
        private ComboBox roleBox;
        private Button authButton;
        private Label errorBox;
    }
}
