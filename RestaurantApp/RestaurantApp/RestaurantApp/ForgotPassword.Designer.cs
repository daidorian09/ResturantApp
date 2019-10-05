namespace RestaurantApp
{
    partial class ForgotPassword
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
            this.txtForgottenEmail = new System.Windows.Forms.TextBox();
            this.lblForgottenEmail = new System.Windows.Forms.Label();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtForgottenEmail
            // 
            this.txtForgottenEmail.Location = new System.Drawing.Point(273, 139);
            this.txtForgottenEmail.Name = "txtForgottenEmail";
            this.txtForgottenEmail.Size = new System.Drawing.Size(309, 22);
            this.txtForgottenEmail.TabIndex = 4;
            // 
            // lblForgottenEmail
            // 
            this.lblForgottenEmail.AutoSize = true;
            this.lblForgottenEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblForgottenEmail.Location = new System.Drawing.Point(394, 89);
            this.lblForgottenEmail.Name = "lblForgottenEmail";
            this.lblForgottenEmail.Size = new System.Drawing.Size(58, 23);
            this.lblForgottenEmail.TabIndex = 3;
            this.lblForgottenEmail.Text = "Email";
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSendMessage.Location = new System.Drawing.Point(207, 279);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(467, 94);
            this.btnSendMessage.TabIndex = 5;
            this.btnSendMessage.Text = "Gönder";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(867, 641);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.txtForgottenEmail);
            this.Controls.Add(this.lblForgottenEmail);
            this.Name = "ForgotPassword";
            this.Text = "Şifremi Unuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtForgottenEmail;
        private System.Windows.Forms.Label lblForgottenEmail;
        private System.Windows.Forms.Button btnSendMessage;
    }
}