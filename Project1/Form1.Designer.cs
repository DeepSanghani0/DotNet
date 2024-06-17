namespace Project1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtCPassword = new System.Windows.Forms.TextBox();
            this.labelcpassword = new System.Windows.Forms.Label();
            this.btnregister = new System.Windows.Forms.Button();
            this.btnforloginpage = new System.Windows.Forms.Button();
            this.pictureclose = new System.Windows.Forms.PictureBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelpermission = new System.Windows.Forms.Label();
            this.cmbpermission = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureclose)).BeginInit();
            this.SuspendLayout();
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(263, 107);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(75, 20);
            this.labelname.TabIndex = 0;
            this.labelname.Text = "Name : ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(393, 100);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(244, 27);
            this.txtName.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(393, 160);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(244, 27);
            this.txtEmail.TabIndex = 3;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(263, 167);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(74, 20);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email : ";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(393, 225);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(244, 27);
            this.txtPassword.TabIndex = 5;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(264, 229);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(109, 20);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Password : ";
            // 
            // txtCPassword
            // 
            this.txtCPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPassword.Location = new System.Drawing.Point(393, 278);
            this.txtCPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCPassword.Name = "txtCPassword";
            this.txtCPassword.Size = new System.Drawing.Size(244, 27);
            this.txtCPassword.TabIndex = 7;
            // 
            // labelcpassword
            // 
            this.labelcpassword.AutoSize = true;
            this.labelcpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcpassword.Location = new System.Drawing.Point(264, 282);
            this.labelcpassword.Name = "labelcpassword";
            this.labelcpassword.Size = new System.Drawing.Size(128, 20);
            this.labelcpassword.TabIndex = 6;
            this.labelcpassword.Text = "C Password : ";
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.ForeColor = System.Drawing.Color.MintCream;
            this.btnregister.Location = new System.Drawing.Point(393, 389);
            this.btnregister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(80, 37);
            this.btnregister.TabIndex = 8;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // btnforloginpage
            // 
            this.btnforloginpage.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnforloginpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnforloginpage.ForeColor = System.Drawing.Color.MintCream;
            this.btnforloginpage.Location = new System.Drawing.Point(537, 389);
            this.btnforloginpage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnforloginpage.Name = "btnforloginpage";
            this.btnforloginpage.Size = new System.Drawing.Size(80, 37);
            this.btnforloginpage.TabIndex = 9;
            this.btnforloginpage.Text = "Login";
            this.btnforloginpage.UseVisualStyleBackColor = false;
            this.btnforloginpage.Click += new System.EventHandler(this.btnforloginpage_Click);
            // 
            // pictureclose
            // 
            this.pictureclose.Image = ((System.Drawing.Image)(resources.GetObject("pictureclose.Image")));
            this.pictureclose.Location = new System.Drawing.Point(859, 12);
            this.pictureclose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureclose.Name = "pictureclose";
            this.pictureclose.Size = new System.Drawing.Size(47, 38);
            this.pictureclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureclose.TabIndex = 10;
            this.pictureclose.TabStop = false;
            this.pictureclose.Click += new System.EventHandler(this.pictureclose_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(393, 46);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(244, 27);
            this.txtId.TabIndex = 12;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(263, 52);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(42, 20);
            this.labelId.TabIndex = 11;
            this.labelId.Text = "Id : ";
            // 
            // labelpermission
            // 
            this.labelpermission.AutoSize = true;
            this.labelpermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpermission.Location = new System.Drawing.Point(263, 331);
            this.labelpermission.Name = "labelpermission";
            this.labelpermission.Size = new System.Drawing.Size(103, 20);
            this.labelpermission.TabIndex = 13;
            this.labelpermission.Text = "Permission";
            // 
            // cmbpermission
            // 
            this.cmbpermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpermission.FormattingEnabled = true;
            this.cmbpermission.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbpermission.Location = new System.Drawing.Point(393, 331);
            this.cmbpermission.Name = "cmbpermission";
            this.cmbpermission.Size = new System.Drawing.Size(244, 28);
            this.cmbpermission.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(925, 546);
            this.Controls.Add(this.cmbpermission);
            this.Controls.Add(this.labelpermission);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.pictureclose);
            this.Controls.Add(this.btnforloginpage);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.txtCPassword);
            this.Controls.Add(this.labelcpassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtCPassword;
        private System.Windows.Forms.Label labelcpassword;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button btnforloginpage;
        private System.Windows.Forms.PictureBox pictureclose;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelpermission;
        private System.Windows.Forms.ComboBox cmbpermission;
    }
}

