namespace Project1
{
    partial class product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(product));
            this.pictureclose = new System.Windows.Forms.PictureBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.productAddForm = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dtpMDate = new System.Windows.Forms.DateTimePicker();
            this.labelMdate = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.labelPPrice = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.labelPName = new System.Windows.Forms.Label();
            this.txtPId = new System.Windows.Forms.TextBox();
            this.labelPId = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.productAddForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureclose
            // 
            this.pictureclose.Image = ((System.Drawing.Image)(resources.GetObject("pictureclose.Image")));
            this.pictureclose.Location = new System.Drawing.Point(778, 11);
            this.pictureclose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureclose.Name = "pictureclose";
            this.pictureclose.Size = new System.Drawing.Size(40, 36);
            this.pictureclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureclose.TabIndex = 11;
            this.pictureclose.TabStop = false;
            this.pictureclose.Click += new System.EventHandler(this.pictureclose_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(43, 68);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(757, 234);
            this.dgvProduct.TabIndex = 12;
            this.dgvProduct.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProduct_RowHeaderMouseClick);
            // 
            // productAddForm
            // 
            this.productAddForm.AutoSize = true;
            this.productAddForm.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.productAddForm.Controls.Add(this.btnDelete);
            this.productAddForm.Controls.Add(this.btnUpdate);
            this.productAddForm.Controls.Add(this.btnInsert);
            this.productAddForm.Controls.Add(this.dtpMDate);
            this.productAddForm.Controls.Add(this.labelMdate);
            this.productAddForm.Controls.Add(this.txtPrice);
            this.productAddForm.Controls.Add(this.labelPPrice);
            this.productAddForm.Controls.Add(this.txtProductName);
            this.productAddForm.Controls.Add(this.labelPName);
            this.productAddForm.Controls.Add(this.txtPId);
            this.productAddForm.Controls.Add(this.labelPId);
            this.productAddForm.Location = new System.Drawing.Point(72, 322);
            this.productAddForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productAddForm.Name = "productAddForm";
            this.productAddForm.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productAddForm.Size = new System.Drawing.Size(740, 188);
            this.productAddForm.TabIndex = 13;
            this.productAddForm.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(455, 134);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 32);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(317, 134);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 32);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(165, 134);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(103, 32);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dtpMDate
            // 
            this.dtpMDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMDate.Location = new System.Drawing.Point(467, 80);
            this.dtpMDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpMDate.Name = "dtpMDate";
            this.dtpMDate.Size = new System.Drawing.Size(245, 22);
            this.dtpMDate.TabIndex = 7;
            // 
            // labelMdate
            // 
            this.labelMdate.AutoSize = true;
            this.labelMdate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelMdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMdate.Location = new System.Drawing.Point(297, 84);
            this.labelMdate.Name = "labelMdate";
            this.labelMdate.Size = new System.Drawing.Size(171, 20);
            this.labelMdate.TabIndex = 6;
            this.labelMdate.Text = "Menufacturing Date : ";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(135, 79);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(132, 26);
            this.txtPrice.TabIndex = 5;
            // 
            // labelPPrice
            // 
            this.labelPPrice.AutoSize = true;
            this.labelPPrice.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelPPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPPrice.Location = new System.Drawing.Point(17, 79);
            this.labelPPrice.Name = "labelPPrice";
            this.labelPPrice.Size = new System.Drawing.Size(48, 20);
            this.labelPPrice.TabIndex = 4;
            this.labelPPrice.Text = "Price";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(467, 31);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(245, 26);
            this.txtProductName.TabIndex = 3;
            // 
            // labelPName
            // 
            this.labelPName.AutoSize = true;
            this.labelPName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPName.Location = new System.Drawing.Point(297, 34);
            this.labelPName.Name = "labelPName";
            this.labelPName.Size = new System.Drawing.Size(131, 20);
            this.labelPName.TabIndex = 2;
            this.labelPName.Text = "Product Name : ";
            // 
            // txtPId
            // 
            this.txtPId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPId.Location = new System.Drawing.Point(135, 30);
            this.txtPId.Margin = new System.Windows.Forms.Padding(4);
            this.txtPId.Name = "txtPId";
            this.txtPId.ReadOnly = true;
            this.txtPId.Size = new System.Drawing.Size(132, 26);
            this.txtPId.TabIndex = 1;
            // 
            // labelPId
            // 
            this.labelPId.AutoSize = true;
            this.labelPId.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelPId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPId.Location = new System.Drawing.Point(17, 30);
            this.labelPId.Name = "labelPId";
            this.labelPId.Size = new System.Drawing.Size(85, 20);
            this.labelPId.TabIndex = 0;
            this.labelPId.Text = "Product Id";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(596, 32);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(52, 18);
            this.UserName.TabIndex = 14;
            this.UserName.Text = "label1";
            // 
            // product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(830, 546);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.productAddForm);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.pictureclose);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "product";
            this.Text = "product";
            this.Load += new System.EventHandler(this.product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.productAddForm.ResumeLayout(false);
            this.productAddForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureclose;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.GroupBox productAddForm;
        private System.Windows.Forms.Label labelPId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label labelPName;
        private System.Windows.Forms.TextBox txtPId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DateTimePicker dtpMDate;
        private System.Windows.Forms.Label labelMdate;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label labelPPrice;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label UserName;
    }
}