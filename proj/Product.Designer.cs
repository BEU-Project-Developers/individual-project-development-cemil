namespace proj
{
    partial class Product
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
            this.grid_products = new System.Windows.Forms.DataGridView();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.cart = new System.Windows.Forms.Button();
            this.label_user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.decrease = new System.Windows.Forms.Button();
            this.lcount = new System.Windows.Forms.Label();
            this.increase = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_products)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_products
            // 
            this.grid_products.BackgroundColor = System.Drawing.Color.White;
            this.grid_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image,
            this.Name,
            this.Price});
            this.grid_products.Location = new System.Drawing.Point(279, 53);
            this.grid_products.Name = "grid_products";
            this.grid_products.RowHeadersWidth = 51;
            this.grid_products.RowTemplate.Height = 200;
            this.grid_products.Size = new System.Drawing.Size(979, 264);
            this.grid_products.TabIndex = 0;
            this.grid_products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_products_CellClick);
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Image";
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.Width = 200;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 200;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Snap ITC", 14.2F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(63, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "CMStore";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.cart);
            this.panel1.Controls.Add(this.label_user);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 731);
            this.panel1.TabIndex = 1;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Red;
            this.logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(0, 676);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(277, 51);
            this.logout.TabIndex = 7;
            this.logout.Text = "Log out";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // cart
            // 
            this.cart.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.cart.Location = new System.Drawing.Point(-2, 278);
            this.cart.Name = "cart";
            this.cart.Size = new System.Drawing.Size(281, 51);
            this.cart.TabIndex = 6;
            this.cart.Text = "Cart";
            this.cart.UseVisualStyleBackColor = true;
            this.cart.Click += new System.EventHandler(this.cart_Click);
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.ForeColor = System.Drawing.Color.White;
            this.label_user.Location = new System.Drawing.Point(85, 139);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(75, 37);
            this.label_user.TabIndex = 5;
            this.label_user.Text = "user";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(64, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(309, 425);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 201);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label_name
            // 
            this.label_name.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.White;
            this.label_name.Location = new System.Drawing.Point(650, 455);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(0, 29);
            this.label_name.TabIndex = 4;
            // 
            // label_price
            // 
            this.label_price.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price.ForeColor = System.Drawing.Color.White;
            this.label_price.Location = new System.Drawing.Point(652, 499);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(0, 25);
            this.label_price.TabIndex = 4;
            // 
            // decrease
            // 
            this.decrease.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.decrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decrease.Location = new System.Drawing.Point(652, 558);
            this.decrease.Name = "decrease";
            this.decrease.Size = new System.Drawing.Size(33, 23);
            this.decrease.TabIndex = 5;
            this.decrease.Text = "-";
            this.decrease.UseVisualStyleBackColor = true;
            this.decrease.Click += new System.EventHandler(this.decrease_Click);
            // 
            // lcount
            // 
            this.lcount.AutoSize = true;
            this.lcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcount.ForeColor = System.Drawing.Color.White;
            this.lcount.Location = new System.Drawing.Point(725, 558);
            this.lcount.Name = "lcount";
            this.lcount.Size = new System.Drawing.Size(20, 22);
            this.lcount.TabIndex = 6;
            this.lcount.Text = "0";
            // 
            // increase
            // 
            this.increase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increase.Location = new System.Drawing.Point(782, 558);
            this.increase.Name = "increase";
            this.increase.Size = new System.Drawing.Size(34, 23);
            this.increase.TabIndex = 7;
            this.increase.Text = "+";
            this.increase.UseVisualStyleBackColor = true;
            this.increase.Click += new System.EventHandler(this.increase_Click_1);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.Color.White;
            this.total.Location = new System.Drawing.Point(725, 604);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(20, 22);
            this.total.TabIndex = 8;
            this.total.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(651, 604);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total: ";
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(1093, 589);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(147, 37);
            this.button_add.TabIndex = 9;
            this.button_add.Text = "Add to Cart";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1270, 731);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.total);
            this.Controls.Add(this.increase);
            this.Controls.Add(this.lcount);
            this.Controls.Add(this.decrease);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grid_products);
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_products)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_products;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Button cart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Button decrease;
        private System.Windows.Forms.Label lcount;
        private System.Windows.Forms.Button increase;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button logout;
    }
}