namespace RestaurantApp
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.btnEditPassword = new System.Windows.Forms.Button();
            this.btnBackAppMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(457, 129);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(248, 22);
            this.txtNewPassword.TabIndex = 4;
            this.txtNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewPassword_Validating);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNewPassword.Location = new System.Drawing.Point(514, 46);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(114, 27);
            this.lblNewPassword.TabIndex = 3;
            this.lblNewPassword.Text = "Yeni Şifre";
            // 
            // btnEditPassword
            // 
            this.btnEditPassword.BackColor = System.Drawing.Color.White;
            this.btnEditPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnEditPassword.Image")));
            this.btnEditPassword.Location = new System.Drawing.Point(642, 282);
            this.btnEditPassword.Name = "btnEditPassword";
            this.btnEditPassword.Size = new System.Drawing.Size(236, 224);
            this.btnEditPassword.TabIndex = 22;
            this.btnEditPassword.UseVisualStyleBackColor = false;
            this.btnEditPassword.Click += new System.EventHandler(this.btnEditPassword_Click_1);
            // 
            // btnBackAppMenu
            // 
            this.btnBackAppMenu.BackColor = System.Drawing.Color.White;
            this.btnBackAppMenu.BackgroundImage = global::RestaurantApp.Properties.Resources.back_arrow_icon_63664;
            this.btnBackAppMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBackAppMenu.Location = new System.Drawing.Point(298, 282);
            this.btnBackAppMenu.Name = "btnBackAppMenu";
            this.btnBackAppMenu.Size = new System.Drawing.Size(211, 224);
            this.btnBackAppMenu.TabIndex = 21;
            this.btnBackAppMenu.UseVisualStyleBackColor = false;
            this.btnBackAppMenu.Click += new System.EventHandler(this.btnBackAppMenu_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1145, 586);
            this.Controls.Add(this.btnEditPassword);
            this.Controls.Add(this.btnBackAppMenu);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Name = "ResetPassword";
            this.Text = "Şifre Yenileme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Button btnEditPassword;
        private System.Windows.Forms.Button btnBackAppMenu;
    }
}