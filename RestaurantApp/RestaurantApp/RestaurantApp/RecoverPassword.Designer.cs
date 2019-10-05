namespace RestaurantApp
{
    partial class RecoverPassword
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
            this.btnRecoverPassword = new System.Windows.Forms.Button();
            this.txtRecoveryToken = new System.Windows.Forms.TextBox();
            this.lblRecoveryToken = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRecoverPassword
            // 
            this.btnRecoverPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRecoverPassword.Location = new System.Drawing.Point(379, 385);
            this.btnRecoverPassword.Name = "btnRecoverPassword";
            this.btnRecoverPassword.Size = new System.Drawing.Size(467, 94);
            this.btnRecoverPassword.TabIndex = 8;
            this.btnRecoverPassword.Text = "Kaydet";
            this.btnRecoverPassword.UseVisualStyleBackColor = true;
            this.btnRecoverPassword.Click += new System.EventHandler(this.btnRecoverPassword_Click);
            // 
            // txtRecoveryToken
            // 
            this.txtRecoveryToken.Location = new System.Drawing.Point(446, 108);
            this.txtRecoveryToken.Name = "txtRecoveryToken";
            this.txtRecoveryToken.Size = new System.Drawing.Size(309, 22);
            this.txtRecoveryToken.TabIndex = 7;
            // 
            // lblRecoveryToken
            // 
            this.lblRecoveryToken.AutoSize = true;
            this.lblRecoveryToken.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRecoveryToken.Location = new System.Drawing.Point(567, 58);
            this.lblRecoveryToken.Name = "lblRecoveryToken";
            this.lblRecoveryToken.Size = new System.Drawing.Size(45, 23);
            this.lblRecoveryToken.TabIndex = 6;
            this.lblRecoveryToken.Text = "Kod";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(446, 251);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(309, 22);
            this.txtNewPassword.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(550, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Yeni Şifre";
            // 
            // RecoverPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1202, 638);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRecoverPassword);
            this.Controls.Add(this.txtRecoveryToken);
            this.Controls.Add(this.lblRecoveryToken);
            this.Name = "RecoverPassword";
            this.Text = "Şifreyi Yenile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecoverPassword;
        private System.Windows.Forms.TextBox txtRecoveryToken;
        private System.Windows.Forms.Label lblRecoveryToken;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label1;
    }
}