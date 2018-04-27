namespace NewMailForm
{
    partial class Frm
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labMail = new System.Windows.Forms.Label();
            this.labPassword = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.labTBao = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(130, 47);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(276, 20);
            this.txtUser.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(130, 131);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(276, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // labMail
            // 
            this.labMail.AutoSize = true;
            this.labMail.Location = new System.Drawing.Point(54, 50);
            this.labMail.Name = "labMail";
            this.labMail.Size = new System.Drawing.Size(26, 13);
            this.labMail.TabIndex = 2;
            this.labMail.Text = "Mail";
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Location = new System.Drawing.Point(54, 134);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(53, 13);
            this.labPassword.TabIndex = 3;
            this.labPassword.Text = "Password";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(508, 368);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // labTBao
            // 
            this.labTBao.AutoSize = true;
            this.labTBao.Location = new System.Drawing.Point(263, 169);
            this.labTBao.Name = "labTBao";
            this.labTBao.Size = new System.Drawing.Size(0, 13);
            this.labTBao.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 200);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(453, 127);
            this.textBox1.TabIndex = 6;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 439);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labTBao);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.labMail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Name = "Frm";
            this.Text = "New Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label labMail;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label labTBao;
        private System.Windows.Forms.TextBox textBox1;
    }
}

