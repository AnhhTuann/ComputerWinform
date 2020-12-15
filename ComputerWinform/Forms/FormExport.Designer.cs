
namespace ComputerWinform.Forms
{
    partial class FormExport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelList = new System.Windows.Forms.Label();
            this.dataGridViewTicket = new System.Windows.Forms.DataGridView();
            this.panelFill = new System.Windows.Forms.Panel();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelAddProduct = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbProductName = new System.Windows.Forms.ComboBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.productid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dateDate = new System.Windows.Forms.DateTimePicker();
            this.labelStorage = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.textTotalCost = new System.Windows.Forms.TextBox();
            this.labelTotalcost = new System.Windows.Forms.Label();
            this.textTotalAmount = new System.Windows.Forms.TextBox();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelButton = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewDetail = new System.Windows.Forms.DataGridView();
            this.labelDetail = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicket)).BeginInit();
            this.panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.panelBtn.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.labelList);
            this.panel1.Controls.Add(this.dataGridViewTicket);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 482);
            this.panel1.TabIndex = 15;
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelList.Location = new System.Drawing.Point(19, 10);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(136, 29);
            this.labelList.TabIndex = 25;
            this.labelList.Text = "Export List";
            // 
            // dataGridViewTicket
            // 
            this.dataGridViewTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTicket.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.dataGridViewTicket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTicket.Location = new System.Drawing.Point(0, 48);
            this.dataGridViewTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTicket.Name = "dataGridViewTicket";
            this.dataGridViewTicket.RowHeadersWidth = 51;
            this.dataGridViewTicket.RowTemplate.Height = 24;
            this.dataGridViewTicket.Size = new System.Drawing.Size(603, 434);
            this.dataGridViewTicket.TabIndex = 0;
            // 
            // panelFill
            // 
            this.panelFill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.panelFill.Controls.Add(this.textAmount);
            this.panelFill.Controls.Add(this.labelAmount);
            this.panelFill.Controls.Add(this.labelAddProduct);
            this.panelFill.Controls.Add(this.button1);
            this.panelFill.Controls.Add(this.cbProductName);
            this.panelFill.Controls.Add(this.labelProductName);
            this.panelFill.Controls.Add(this.dataGridViewProduct);
            this.panelFill.Controls.Add(this.textTotalAmount);
            this.panelFill.Controls.Add(this.dateDate);
            this.panelFill.Controls.Add(this.labelDate);
            this.panelFill.Controls.Add(this.textTotalCost);
            this.panelFill.Controls.Add(this.labelTotalcost);
            this.panelFill.Controls.Add(this.labelTotalAmount);
            this.panelFill.Controls.Add(this.labelStorage);
            this.panelFill.Location = new System.Drawing.Point(634, 11);
            this.panelFill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(552, 482);
            this.panelFill.TabIndex = 26;
            // 
            // textAmount
            // 
            this.textAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textAmount.Location = new System.Drawing.Point(160, 276);
            this.textAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(359, 22);
            this.textAmount.TabIndex = 27;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(19, 276);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(72, 20);
            this.labelAmount.TabIndex = 26;
            this.labelAmount.Text = "Amount";
            // 
            // labelAddProduct
            // 
            this.labelAddProduct.AutoSize = true;
            this.labelAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddProduct.Location = new System.Drawing.Point(19, 193);
            this.labelAddProduct.Name = "labelAddProduct";
            this.labelAddProduct.Size = new System.Drawing.Size(252, 25);
            this.labelAddProduct.TabIndex = 25;
            this.labelAddProduct.Text = "Import product to storage";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::ComputerWinform.Properties.Resources.add_30px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(323, 193);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 50);
            this.button1.TabIndex = 21;
            this.button1.Text = "Add Product ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbProductName
            // 
            this.cbProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProductName.FormattingEnabled = true;
            this.cbProductName.Location = new System.Drawing.Point(160, 247);
            this.cbProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProductName.Name = "cbProductName";
            this.cbProductName.Size = new System.Drawing.Size(359, 24);
            this.cbProductName.TabIndex = 23;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(20, 247);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(74, 20);
            this.labelProductName.TabIndex = 24;
            this.labelProductName.Text = "Product";
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.dataGridViewProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productid,
            this.Product,
            this.amount,
            this.Delete});
            this.dataGridViewProduct.Location = new System.Drawing.Point(0, 302);
            this.dataGridViewProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowHeadersWidth = 51;
            this.dataGridViewProduct.RowTemplate.Height = 24;
            this.dataGridViewProduct.Size = new System.Drawing.Size(552, 180);
            this.dataGridViewProduct.TabIndex = 20;
            // 
            // productid
            // 
            this.productid.HeaderText = "Product Id";
            this.productid.MinimumWidth = 6;
            this.productid.Name = "productid";
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete Product";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            // 
            // dateDate
            // 
            this.dateDate.Location = new System.Drawing.Point(203, 128);
            this.dateDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDate.Name = "dateDate";
            this.dateDate.Size = new System.Drawing.Size(317, 22);
            this.dateDate.TabIndex = 13;
            // 
            // labelStorage
            // 
            this.labelStorage.AutoSize = true;
            this.labelStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStorage.Location = new System.Drawing.Point(19, 10);
            this.labelStorage.Name = "labelStorage";
            this.labelStorage.Size = new System.Drawing.Size(87, 29);
            this.labelStorage.TabIndex = 0;
            this.labelStorage.Text = "Import";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(21, 128);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(49, 20);
            this.labelDate.TabIndex = 9;
            this.labelDate.Text = "Date";
            // 
            // textTotalCost
            // 
            this.textTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textTotalCost.Location = new System.Drawing.Point(203, 91);
            this.textTotalCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textTotalCost.Name = "textTotalCost";
            this.textTotalCost.Size = new System.Drawing.Size(317, 22);
            this.textTotalCost.TabIndex = 6;
            // 
            // labelTotalcost
            // 
            this.labelTotalcost.AutoSize = true;
            this.labelTotalcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalcost.Location = new System.Drawing.Point(20, 91);
            this.labelTotalcost.Name = "labelTotalcost";
            this.labelTotalcost.Size = new System.Drawing.Size(96, 20);
            this.labelTotalcost.TabIndex = 2;
            this.labelTotalcost.Text = "Total Cost";
            // 
            // textTotalAmount
            // 
            this.textTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textTotalAmount.Location = new System.Drawing.Point(203, 48);
            this.textTotalAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textTotalAmount.Name = "textTotalAmount";
            this.textTotalAmount.Size = new System.Drawing.Size(317, 22);
            this.textTotalAmount.TabIndex = 14;
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAmount.Location = new System.Drawing.Point(21, 50);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(120, 20);
            this.labelTotalAmount.TabIndex = 1;
            this.labelTotalAmount.Text = "Total Amount";
            // 
            // panelBtn
            // 
            this.panelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.panelBtn.Controls.Add(this.buttonRefresh);
            this.panelBtn.Controls.Add(this.textSearch);
            this.panelBtn.Controls.Add(this.btnSearch);
            this.panelBtn.Controls.Add(this.btnAdd);
            this.panelBtn.Controls.Add(this.labelButton);
            this.panelBtn.Location = new System.Drawing.Point(634, 510);
            this.panelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(552, 254);
            this.panelBtn.TabIndex = 27;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Image = global::ComputerWinform.Properties.Resources.refresh_30px;
            this.buttonRefresh.Location = new System.Drawing.Point(35, 121);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(484, 48);
            this.buttonRefresh.TabIndex = 11;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // textSearch
            // 
            this.textSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.Location = new System.Drawing.Point(203, 66);
            this.textSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(317, 38);
            this.textSearch.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::ComputerWinform.Properties.Resources.search_30px;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(35, 57);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 48);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::ComputerWinform.Properties.Resources.add_30px;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(35, 190);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(485, 48);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // labelButton
            // 
            this.labelButton.AutoSize = true;
            this.labelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelButton.Location = new System.Drawing.Point(19, 11);
            this.labelButton.Name = "labelButton";
            this.labelButton.Size = new System.Drawing.Size(87, 29);
            this.labelButton.TabIndex = 1;
            this.labelButton.Text = "Button";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.panel2.Controls.Add(this.dataGridViewDetail);
            this.panel2.Controls.Add(this.labelDetail);
            this.panel2.Location = new System.Drawing.Point(12, 510);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 254);
            this.panel2.TabIndex = 28;
            // 
            // dataGridViewDetail
            // 
            this.dataGridViewDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.dataGridViewDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewDetail.Location = new System.Drawing.Point(0, 44);
            this.dataGridViewDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDetail.Name = "dataGridViewDetail";
            this.dataGridViewDetail.RowHeadersWidth = 51;
            this.dataGridViewDetail.RowTemplate.Height = 24;
            this.dataGridViewDetail.Size = new System.Drawing.Size(603, 210);
            this.dataGridViewDetail.TabIndex = 2;
            // 
            // labelDetail
            // 
            this.labelDetail.AutoSize = true;
            this.labelDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetail.Location = new System.Drawing.Point(29, 11);
            this.labelDetail.Name = "labelDetail";
            this.labelDetail.Size = new System.Drawing.Size(94, 29);
            this.labelDetail.TabIndex = 1;
            this.labelDetail.Text = "Details";
            // 
            // FormExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1198, 775);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelBtn);
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.panel1);
            this.Name = "FormExport";
            this.Text = "FormExport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicket)).EndInit();
            this.panelFill.ResumeLayout(false);
            this.panelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.panelBtn.ResumeLayout(false);
            this.panelBtn.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.DataGridView dataGridViewTicket;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.TextBox textAmount;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelAddProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbProductName;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn productid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.TextBox textTotalAmount;
        private System.Windows.Forms.DateTimePicker dateDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textTotalCost;
        private System.Windows.Forms.Label labelTotalcost;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Label labelStorage;
        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewDetail;
        private System.Windows.Forms.Label labelDetail;
    }
}