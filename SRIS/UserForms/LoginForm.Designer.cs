
namespace SRIS.UserForms
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
            this.label12 = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Login = new System.Windows.Forms.Button();
            this.lb_Register = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(35, 26);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(84, 21);
            this.label12.TabIndex = 82;
            this.label12.Text = "Username:";
            // 
            // tb_Username
            // 
            this.tb_Username.Location = new System.Drawing.Point(122, 20);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(238, 27);
            this.tb_Username.TabIndex = 84;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(122, 53);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(238, 27);
            this.tb_Password.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 59);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 85;
            this.label1.Text = "Password:";
            // 
            // bt_Login
            // 
            this.bt_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Login.ForeColor = System.Drawing.Color.Black;
            this.bt_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Login.Location = new System.Drawing.Point(39, 107);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(321, 29);
            this.bt_Login.TabIndex = 106;
            this.bt_Login.Text = "LOGIN";
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // lb_Register
            // 
            this.lb_Register.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lb_Register.AutoSize = true;
            this.lb_Register.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Register.LinkColor = System.Drawing.Color.DimGray;
            this.lb_Register.Location = new System.Drawing.Point(179, 139);
            this.lb_Register.Name = "lb_Register";
            this.lb_Register.Size = new System.Drawing.Size(49, 13);
            this.lb_Register.TabIndex = 107;
            this.lb_Register.TabStop = true;
            this.lb_Register.Text = "Register";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 207);
            this.Controls.Add(this.lb_Register);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.label12);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.LinkLabel lb_Register;
    }
}