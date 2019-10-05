namespace RestaurantApp
{
    partial class AppMenuDesign
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
            this.categoryGridView = new System.Windows.Forms.DataGridView();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.categoryGroupBox = new System.Windows.Forms.GroupBox();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnAddNewCategory = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.productGroupBox = new System.Windows.Forms.GroupBox();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductItem = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCategoryGridViewName = new System.Windows.Forms.Label();
            this.lblProductGridViewName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.categoryGroupBox.SuspendLayout();
            this.productGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryGridView
            // 
            this.categoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryGridView.Location = new System.Drawing.Point(12, 50);
            this.categoryGridView.Name = "categoryGridView";
            this.categoryGridView.RowTemplate.Height = 24;
            this.categoryGridView.Size = new System.Drawing.Size(347, 352);
            this.categoryGridView.TabIndex = 0;
            this.categoryGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryGridView_CellClick);
            // 
            // productGridView
            // 
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(1357, 50);
            this.productGridView.Name = "productGridView";
            this.productGridView.RowTemplate.Height = 24;
            this.productGridView.Size = new System.Drawing.Size(462, 352);
            this.productGridView.TabIndex = 1;
            this.productGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productGridView_CellClick);
            // 
            // categoryGroupBox
            // 
            this.categoryGroupBox.Controls.Add(this.btnRemoveCategory);
            this.categoryGroupBox.Controls.Add(this.btnEditCategory);
            this.categoryGroupBox.Controls.Add(this.btnAddNewCategory);
            this.categoryGroupBox.Controls.Add(this.txtCategoryName);
            this.categoryGroupBox.Controls.Add(this.lblItemName);
            this.categoryGroupBox.Location = new System.Drawing.Point(12, 408);
            this.categoryGroupBox.Name = "categoryGroupBox";
            this.categoryGroupBox.Size = new System.Drawing.Size(641, 371);
            this.categoryGroupBox.TabIndex = 2;
            this.categoryGroupBox.TabStop = false;
            this.categoryGroupBox.Visible = false;
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.Location = new System.Drawing.Point(441, 131);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(169, 103);
            this.btnRemoveCategory.TabIndex = 5;
            this.btnRemoveCategory.Text = "Kategori Sil";
            this.btnRemoveCategory.UseVisualStyleBackColor = true;
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Location = new System.Drawing.Point(237, 131);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(169, 103);
            this.btnEditCategory.TabIndex = 4;
            this.btnEditCategory.Text = "Kategori Güncelle";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnAddNewCategory
            // 
            this.btnAddNewCategory.Location = new System.Drawing.Point(27, 131);
            this.btnAddNewCategory.Name = "btnAddNewCategory";
            this.btnAddNewCategory.Size = new System.Drawing.Size(169, 103);
            this.btnAddNewCategory.TabIndex = 3;
            this.btnAddNewCategory.Text = "Kategori Ekle";
            this.btnAddNewCategory.UseVisualStyleBackColor = true;
            this.btnAddNewCategory.Click += new System.EventHandler(this.btnAddNewCategory_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(134, 60);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(259, 22);
            this.txtCategoryName.TabIndex = 1;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblItemName.Location = new System.Drawing.Point(205, 18);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(119, 23);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "Kategori Adı";
            // 
            // productGroupBox
            // 
            this.productGroupBox.Controls.Add(this.btnRemoveProduct);
            this.productGroupBox.Controls.Add(this.btnEditProduct);
            this.productGroupBox.Controls.Add(this.btnAddNewProduct);
            this.productGroupBox.Controls.Add(this.txtProductPrice);
            this.productGroupBox.Controls.Add(this.label1);
            this.productGroupBox.Controls.Add(this.lblProductCategory);
            this.productGroupBox.Controls.Add(this.cmbCategory);
            this.productGroupBox.Controls.Add(this.txtProductName);
            this.productGroupBox.Controls.Add(this.lblProductItem);
            this.productGroupBox.Location = new System.Drawing.Point(1178, 408);
            this.productGroupBox.Name = "productGroupBox";
            this.productGroupBox.Size = new System.Drawing.Size(641, 406);
            this.productGroupBox.TabIndex = 3;
            this.productGroupBox.TabStop = false;
            this.productGroupBox.Visible = false;
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(443, 232);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(169, 103);
            this.btnRemoveProduct.TabIndex = 8;
            this.btnRemoveProduct.Text = "Ürün Sil";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(239, 232);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(169, 103);
            this.btnEditProduct.TabIndex = 7;
            this.btnEditProduct.Text = "Ürün Güncelle";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Location = new System.Drawing.Point(29, 232);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(169, 103);
            this.btnAddNewProduct.TabIndex = 6;
            this.btnAddNewProduct.Text = "Ürün Ekle";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(26, 173);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(259, 22);
            this.txtProductPrice.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(97, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Fiyat";
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductCategory.Location = new System.Drawing.Point(437, 18);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(146, 23);
            this.lblProductCategory.TabIndex = 3;
            this.lblProductCategory.Text = "Ürün Kategorisi";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(390, 60);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(251, 24);
            this.cmbCategory.TabIndex = 2;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(26, 60);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(259, 22);
            this.txtProductName.TabIndex = 1;
            // 
            // lblProductItem
            // 
            this.lblProductItem.AutoSize = true;
            this.lblProductItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductItem.Location = new System.Drawing.Point(97, 18);
            this.lblProductItem.Name = "lblProductItem";
            this.lblProductItem.Size = new System.Drawing.Size(87, 23);
            this.lblProductItem.TabIndex = 0;
            this.lblProductItem.Text = "Ürün Adı";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.BackgroundImage = global::RestaurantApp.Properties.Resources.back_arrow_icon_63664;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Location = new System.Drawing.Point(801, 61);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(268, 250);
            this.btnBack.TabIndex = 11;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCategoryGridViewName
            // 
            this.lblCategoryGridViewName.AutoSize = true;
            this.lblCategoryGridViewName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategoryGridViewName.Location = new System.Drawing.Point(89, 12);
            this.lblCategoryGridViewName.Name = "lblCategoryGridViewName";
            this.lblCategoryGridViewName.Size = new System.Drawing.Size(106, 23);
            this.lblCategoryGridViewName.TabIndex = 6;
            this.lblCategoryGridViewName.Text = "Kategoriler";
            // 
            // lblProductGridViewName
            // 
            this.lblProductGridViewName.AutoSize = true;
            this.lblProductGridViewName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductGridViewName.Location = new System.Drawing.Point(1576, 9);
            this.lblProductGridViewName.Name = "lblProductGridViewName";
            this.lblProductGridViewName.Size = new System.Drawing.Size(74, 23);
            this.lblProductGridViewName.TabIndex = 12;
            this.lblProductGridViewName.Text = "Ürünler";
            // 
            // AppMenuDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1831, 826);
            this.Controls.Add(this.lblProductGridViewName);
            this.Controls.Add(this.lblCategoryGridViewName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.productGroupBox);
            this.Controls.Add(this.categoryGroupBox);
            this.Controls.Add(this.productGridView);
            this.Controls.Add(this.categoryGridView);
            this.Name = "AppMenuDesign";
            this.Text = "Menü Düzenle";
            this.Load += new System.EventHandler(this.AppMenuDesign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.categoryGroupBox.ResumeLayout(false);
            this.categoryGroupBox.PerformLayout();
            this.productGroupBox.ResumeLayout(false);
            this.productGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView categoryGridView;
        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.GroupBox categoryGroupBox;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnAddNewCategory;
        private System.Windows.Forms.GroupBox productGroupBox;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductItem;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCategoryGridViewName;
        private System.Windows.Forms.Label lblProductGridViewName;
    }
}