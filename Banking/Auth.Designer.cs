namespace Banking
{
    partial class Auth
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
            Emailtxt = new TextBox();
            passwordtxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            loginbtn = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // Emailtxt
            // 
            Emailtxt.Location = new Point(306, 131);
            Emailtxt.Name = "Emailtxt";
            Emailtxt.Size = new Size(125, 27);
            Emailtxt.TabIndex = 0;
            Emailtxt.Text = "email1@gmail.com";
            // 
            // passwordtxt
            // 
            passwordtxt.Location = new Point(306, 206);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(125, 27);
            passwordtxt.TabIndex = 1;
            passwordtxt.Text = "123123";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 97);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(306, 183);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // loginbtn
            // 
            loginbtn.Location = new Point(322, 254);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(94, 29);
            loginbtn.TabIndex = 4;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Underline, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(341, 286);
            label3.Name = "label3";
            label3.Size = new Size(53, 17);
            label3.TabIndex = 5;
            label3.Text = "register";
            label3.Click += label3_Click;
            // 
            // Auth
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(loginbtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordtxt);
            Controls.Add(Emailtxt);
            Name = "Auth";
            Text = "Auth";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Emailtxt;
        private TextBox passwordtxt;
        private Label label1;
        private Label label2;
        private Button loginbtn;
        private Label label3;
    }
}