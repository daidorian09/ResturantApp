namespace RestaurantApp
{
    partial class TableOrder
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
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnOrderCanceled = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.orderGridView = new System.Windows.Forms.DataGridView();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.tableGroupBox = new System.Windows.Forms.GroupBox();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.txtSelectedProductQuantity = new System.Windows.Forms.TextBox();
            this.txtSelectedProductPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSelectedProduct = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSelectedCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            this.tableGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(359, 49);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(282, 119);
            this.btnAddOrder.TabIndex = 0;
            this.btnAddOrder.Text = "Sipariş Ekle";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.SystemColors.Control;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategory.Location = new System.Drawing.Point(57, 40);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(101, 27);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Kategori";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.BackColor = System.Drawing.SystemColors.Control;
            this.lblProduct.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProduct.Location = new System.Drawing.Point(57, 161);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(65, 27);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "Ürün";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(12, 97);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(233, 24);
            this.cmbCategory.TabIndex = 3;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(12, 218);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(233, 24);
            this.cmbProduct.TabIndex = 4;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.lblQuantity.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantity.Location = new System.Drawing.Point(57, 455);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(145, 27);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Sipariş Adeti";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(12, 512);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(233, 22);
            this.txtQuantity.TabIndex = 7;
            this.txtQuantity.Validated += new System.EventHandler(this.txtQuantity_Validated);
            // 
            // btnOrderCanceled
            // 
            this.btnOrderCanceled.Location = new System.Drawing.Point(719, 49);
            this.btnOrderCanceled.Name = "btnOrderCanceled";
            this.btnOrderCanceled.Size = new System.Drawing.Size(282, 119);
            this.btnOrderCanceled.TabIndex = 8;
            this.btnOrderCanceled.Text = "Sipariş İptal";
            this.btnOrderCanceled.UseVisualStyleBackColor = true;
            this.btnOrderCanceled.Click += new System.EventHandler(this.btnOrderCanceled_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.BackgroundImage = global::RestaurantApp.Properties.Resources.back_arrow_icon_63664;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Location = new System.Drawing.Point(12, 561);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(282, 174);
            this.btnBack.TabIndex = 11;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // orderGridView
            // 
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGridView.Location = new System.Drawing.Point(1055, 12);
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.RowTemplate.Height = 24;
            this.orderGridView.Size = new System.Drawing.Size(716, 613);
            this.orderGridView.TabIndex = 12;
            this.orderGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderGridView_CellClick);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(1055, 650);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(716, 85);
            this.btnCheckOut.TabIndex = 13;
            this.btnCheckOut.Text = "Hesap Al";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(12, 366);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.ReadOnly = true;
            this.txtProductPrice.Size = new System.Drawing.Size(233, 22);
            this.txtProductPrice.TabIndex = 15;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblProductPrice.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductPrice.Location = new System.Drawing.Point(57, 309);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(130, 27);
            this.lblProductPrice.TabIndex = 14;
            this.lblProductPrice.Text = "Ürün Fiyatı";
            // 
            // tableGroupBox
            // 
            this.tableGroupBox.Controls.Add(this.btnDeleteOrder);
            this.tableGroupBox.Controls.Add(this.btnEditOrder);
            this.tableGroupBox.Controls.Add(this.txtSelectedProductQuantity);
            this.tableGroupBox.Controls.Add(this.txtSelectedProductPrice);
            this.tableGroupBox.Controls.Add(this.label4);
            this.tableGroupBox.Controls.Add(this.cmbSelectedProduct);
            this.tableGroupBox.Controls.Add(this.label3);
            this.tableGroupBox.Controls.Add(this.label2);
            this.tableGroupBox.Controls.Add(this.cmbSelectedCategory);
            this.tableGroupBox.Controls.Add(this.label1);
            this.tableGroupBox.Location = new System.Drawing.Point(359, 289);
            this.tableGroupBox.Name = "tableGroupBox";
            this.tableGroupBox.Size = new System.Drawing.Size(669, 446);
            this.tableGroupBox.TabIndex = 16;
            this.tableGroupBox.TabStop = false;
            this.tableGroupBox.Visible = false;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(364, 288);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(282, 119);
            this.btnDeleteOrder.TabIndex = 21;
            this.btnDeleteOrder.Text = "Sipariş İptal";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.Location = new System.Drawing.Point(27, 294);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(282, 119);
            this.btnEditOrder.TabIndex = 17;
            this.btnEditOrder.Text = "Sipariş Düzenle";
            this.btnEditOrder.UseVisualStyleBackColor = true;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // txtSelectedProductQuantity
            // 
            this.txtSelectedProductQuantity.Location = new System.Drawing.Point(413, 225);
            this.txtSelectedProductQuantity.Name = "txtSelectedProductQuantity";
            this.txtSelectedProductQuantity.Size = new System.Drawing.Size(233, 22);
            this.txtSelectedProductQuantity.TabIndex = 18;
            // 
            // txtSelectedProductPrice
            // 
            this.txtSelectedProductPrice.Location = new System.Drawing.Point(27, 225);
            this.txtSelectedProductPrice.Name = "txtSelectedProductPrice";
            this.txtSelectedProductPrice.ReadOnly = true;
            this.txtSelectedProductPrice.Size = new System.Drawing.Size(233, 22);
            this.txtSelectedProductPrice.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(458, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 27);
            this.label4.TabIndex = 17;
            this.label4.Text = "Sipariş Adeti";
            // 
            // cmbSelectedProduct
            // 
            this.cmbSelectedProduct.FormattingEnabled = true;
            this.cmbSelectedProduct.Location = new System.Drawing.Point(413, 97);
            this.cmbSelectedProduct.Name = "cmbSelectedProduct";
            this.cmbSelectedProduct.Size = new System.Drawing.Size(233, 24);
            this.cmbSelectedProduct.TabIndex = 20;
            this.cmbSelectedProduct.SelectedIndexChanged += new System.EventHandler(this.cmbSelectedProduct_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(72, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 27);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ürün Fiyatı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(458, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 27);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ürün";
            // 
            // cmbSelectedCategory
            // 
            this.cmbSelectedCategory.FormattingEnabled = true;
            this.cmbSelectedCategory.Location = new System.Drawing.Point(18, 97);
            this.cmbSelectedCategory.Name = "cmbSelectedCategory";
            this.cmbSelectedCategory.Size = new System.Drawing.Size(233, 24);
            this.cmbSelectedCategory.TabIndex = 18;
            this.cmbSelectedCategory.SelectedIndexChanged += new System.EventHandler(this.cmbSelectedCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(63, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kategori";
            // 
            // TableOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1820, 888);
            this.Controls.Add(this.tableGroupBox);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.orderGridView);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOrderCanceled);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnAddOrder);
            this.Name = "TableOrder";
            this.Text = "Masa";
            this.Load += new System.EventHandler(this.TableOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            this.tableGroupBox.ResumeLayout(false);
            this.tableGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnOrderCanceled;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView orderGridView;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.GroupBox tableGroupBox;
        private System.Windows.Forms.ComboBox cmbSelectedProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSelectedCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSelectedProductQuantity;
        private System.Windows.Forms.TextBox txtSelectedProductPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnEditOrder;
    }
}