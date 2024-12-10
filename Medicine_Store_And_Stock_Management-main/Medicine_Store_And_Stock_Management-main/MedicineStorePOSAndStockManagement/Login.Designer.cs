
namespace MedicineStorePOSAndStockManagement
{
    partial class Login
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
            pnlFull = new System.Windows.Forms.Panel();
            pnlLogin = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            btnLogin = new System.Windows.Forms.Button();
            txtPassword = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            lblUserId = new System.Windows.Forms.Label();
            txtUserId = new System.Windows.Forms.TextBox();
            lblLoginText = new System.Windows.Forms.Label();
            pnlFull.SuspendLayout();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFull
            // 
            pnlFull.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            pnlFull.BackgroundImage = Properties.Resources.loginpattern;
            pnlFull.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pnlFull.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pnlFull.Controls.Add(pnlLogin);
            pnlFull.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlFull.Location = new System.Drawing.Point(0, 0);
            pnlFull.Name = "pnlFull";
            pnlFull.Size = new System.Drawing.Size(1425, 710);
            pnlFull.TabIndex = 0;
            // 
            // pnlLogin
            // 
            pnlLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            pnlLogin.BackColor = System.Drawing.Color.LightCoral;
            pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pnlLogin.Controls.Add(panel1);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(lblPassword);
            pnlLogin.Controls.Add(lblUserId);
            pnlLogin.Controls.Add(txtUserId);
            pnlLogin.Controls.Add(lblLoginText);
            pnlLogin.Location = new System.Drawing.Point(609, 138);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new System.Drawing.Size(313, 293);
            pnlLogin.TabIndex = 0;
            pnlLogin.Paint += pnlLogin_Paint;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.applogo;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel1.Location = new System.Drawing.Point(102, 16);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(101, 90);
            panel1.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLogin.Location = new System.Drawing.Point(125, 249);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(99, 37);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(92, 206);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(189, 27);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            lblPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            lblPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPassword.Location = new System.Drawing.Point(-1, 206);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(87, 26);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserId
            // 
            lblUserId.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            lblUserId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            lblUserId.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblUserId.Location = new System.Drawing.Point(-2, 147);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new System.Drawing.Size(77, 26);
            lblUserId.TabIndex = 2;
            lblUserId.Text = "User ID";
            lblUserId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblUserId.Click += lblUserId_Click;
            // 
            // txtUserId
            // 
            txtUserId.Location = new System.Drawing.Point(92, 147);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new System.Drawing.Size(189, 27);
            txtUserId.TabIndex = 1;
            txtUserId.TextChanged += txtUserId_TextChanged;
            // 
            // lblLoginText
            // 
            lblLoginText.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            lblLoginText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            lblLoginText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblLoginText.Location = new System.Drawing.Point(36, 95);
            lblLoginText.Name = "lblLoginText";
            lblLoginText.Size = new System.Drawing.Size(233, 54);
            lblLoginText.TabIndex = 0;
            lblLoginText.Text = "Please, login to your account";
            lblLoginText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblLoginText.Click += lblLoginText_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1425, 710);
            Controls.Add(pnlFull);
            Name = "Login";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosed += Login_FormClosed;
            pnlFull.ResumeLayout(false);
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlFull;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblLoginText;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Panel panel1;
    }
}

