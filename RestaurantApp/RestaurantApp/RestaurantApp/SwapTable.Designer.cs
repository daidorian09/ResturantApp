namespace RestaurantApp
{
    partial class SwapTable
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
            this.listFullTables = new System.Windows.Forms.ListBox();
            this.listEmptyTables = new System.Windows.Forms.ListBox();
            this.btnSwapNow = new System.Windows.Forms.Button();
            this.btnReturnToDisplayMenu = new System.Windows.Forms.Button();
            this.lblFullTables = new System.Windows.Forms.Label();
            this.lblEmptyTables = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listFullTables
            // 
            this.listFullTables.FormattingEnabled = true;
            this.listFullTables.ItemHeight = 16;
            this.listFullTables.Location = new System.Drawing.Point(139, 101);
            this.listFullTables.Name = "listFullTables";
            this.listFullTables.Size = new System.Drawing.Size(408, 564);
            this.listFullTables.TabIndex = 0;
            // 
            // listEmptyTables
            // 
            this.listEmptyTables.FormattingEnabled = true;
            this.listEmptyTables.ItemHeight = 16;
            this.listEmptyTables.Location = new System.Drawing.Point(1084, 101);
            this.listEmptyTables.Name = "listEmptyTables";
            this.listEmptyTables.Size = new System.Drawing.Size(408, 564);
            this.listEmptyTables.TabIndex = 1;
            // 
            // btnSwapNow
            // 
            this.btnSwapNow.Location = new System.Drawing.Point(685, 163);
            this.btnSwapNow.Name = "btnSwapNow";
            this.btnSwapNow.Size = new System.Drawing.Size(299, 96);
            this.btnSwapNow.TabIndex = 2;
            this.btnSwapNow.Text = "Değiştir";
            this.btnSwapNow.UseVisualStyleBackColor = true;
            this.btnSwapNow.Click += new System.EventHandler(this.btnSwapNow_Click);
            // 
            // btnReturnToDisplayMenu
            // 
            this.btnReturnToDisplayMenu.Location = new System.Drawing.Point(685, 404);
            this.btnReturnToDisplayMenu.Name = "btnReturnToDisplayMenu";
            this.btnReturnToDisplayMenu.Size = new System.Drawing.Size(299, 96);
            this.btnReturnToDisplayMenu.TabIndex = 3;
            this.btnReturnToDisplayMenu.Text = "Geri Dön";
            this.btnReturnToDisplayMenu.UseVisualStyleBackColor = true;
            this.btnReturnToDisplayMenu.Click += new System.EventHandler(this.btnReturnToDisplayMenu_Click);
            // 
            // lblFullTables
            // 
            this.lblFullTables.AutoSize = true;
            this.lblFullTables.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFullTables.Location = new System.Drawing.Point(274, 41);
            this.lblFullTables.Name = "lblFullTables";
            this.lblFullTables.Size = new System.Drawing.Size(126, 23);
            this.lblFullTables.TabIndex = 4;
            this.lblFullTables.Text = "Dolu Masalar";
            // 
            // lblEmptyTables
            // 
            this.lblEmptyTables.AutoSize = true;
            this.lblEmptyTables.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmptyTables.Location = new System.Drawing.Point(1244, 41);
            this.lblEmptyTables.Name = "lblEmptyTables";
            this.lblEmptyTables.Size = new System.Drawing.Size(121, 23);
            this.lblEmptyTables.TabIndex = 6;
            this.lblEmptyTables.Text = "Boş Masalar";
            // 
            // SwapTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1828, 749);
            this.Controls.Add(this.lblEmptyTables);
            this.Controls.Add(this.lblFullTables);
            this.Controls.Add(this.btnReturnToDisplayMenu);
            this.Controls.Add(this.btnSwapNow);
            this.Controls.Add(this.listEmptyTables);
            this.Controls.Add(this.listFullTables);
            this.Name = "SwapTable";
            this.Text = "Masa Düzenle";
            this.Load += new System.EventHandler(this.SwapTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listFullTables;
        private System.Windows.Forms.ListBox listEmptyTables;
        private System.Windows.Forms.Button btnSwapNow;
        private System.Windows.Forms.Button btnReturnToDisplayMenu;
        private System.Windows.Forms.Label lblFullTables;
        private System.Windows.Forms.Label lblEmptyTables;
    }
}