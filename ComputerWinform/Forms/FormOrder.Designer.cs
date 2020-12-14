
namespace ComputerWinform.Forms
{
    partial class FormOrder
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
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.dataGridViewCombo = new System.Windows.Forms.DataGridView();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.panelReceipt = new System.Windows.Forms.Panel();
            this.labelReceipt = new System.Windows.Forms.Label();
            this.panelProduct = new Guna.UI2.WinForms.Guna2Panel();
            this.labelProduct = new System.Windows.Forms.Label();
            this.panelCombo = new System.Windows.Forms.Panel();
            this.labelCombo = new System.Windows.Forms.Label();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.buttonPay = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.labelButton = new System.Windows.Forms.Label();
            this.panelFill = new System.Windows.Forms.Panel();
            this.buttonLoadCombo = new System.Windows.Forms.Button();
            this.buttonLoadProduct = new System.Windows.Forms.Button();
            this.buttonAddCombo = new System.Windows.Forms.Button();
            this.cbComboname = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.comboid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteCombo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dateDate = new System.Windows.Forms.DateTimePicker();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.cbProductName = new System.Windows.Forms.ComboBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelDis = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelOrder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.panelReceipt.SuspendLayout();
            this.panelProduct.SuspendLayout();
            this.panelCombo.SuspendLayout();
            this.panelBtn.SuspendLayout();
            this.panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.dataGridViewCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(0, 33);
            this.dataGridViewCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.RowHeadersWidth = 51;
            this.dataGridViewCustomer.RowTemplate.Height = 24;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(416, 189);
            this.dataGridViewCustomer.TabIndex = 0;
            this.dataGridViewCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomer_CellContentClick);
            // 
            // dataGridViewCombo
            // 
            this.dataGridViewCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCombo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCombo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.dataGridViewCombo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCombo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCombo.Location = new System.Drawing.Point(0, 36);
            this.dataGridViewCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewCombo.Name = "dataGridViewCombo";
            this.dataGridViewCombo.RowHeadersWidth = 51;
            this.dataGridViewCombo.RowTemplate.Height = 24;
            this.dataGridViewCombo.Size = new System.Drawing.Size(416, 169);
            this.dataGridViewCombo.TabIndex = 1;
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
            this.dataGridViewProduct.Location = new System.Drawing.Point(-2, 33);
            this.dataGridViewProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowHeadersWidth = 51;
            this.dataGridViewProduct.RowTemplate.Height = 24;
            this.dataGridViewProduct.Size = new System.Drawing.Size(418, 158);
            this.dataGridViewProduct.TabIndex = 3;
            // 
            // panelReceipt
            // 
            this.panelReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.panelReceipt.Controls.Add(this.labelReceipt);
            this.panelReceipt.Controls.Add(this.dataGridViewCustomer);
            this.panelReceipt.Location = new System.Drawing.Point(9, 10);
            this.panelReceipt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelReceipt.Name = "panelReceipt";
            this.panelReceipt.Size = new System.Drawing.Size(416, 223);
            this.panelReceipt.TabIndex = 4;
            // 
            // labelReceipt
            // 
            this.labelReceipt.AutoSize = true;
            this.labelReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReceipt.Location = new System.Drawing.Point(10, 7);
            this.labelReceipt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReceipt.Name = "labelReceipt";
            this.labelReceipt.Size = new System.Drawing.Size(118, 24);
            this.labelReceipt.TabIndex = 26;
            this.labelReceipt.Text = "Receipt List";
            // 
            // panelProduct
            // 
            this.panelProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.panelProduct.Controls.Add(this.labelProduct);
            this.panelProduct.Controls.Add(this.dataGridViewProduct);
            this.panelProduct.Location = new System.Drawing.Point(9, 243);
            this.panelProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.ShadowDecoration.Parent = this.panelProduct;
            this.panelProduct.Size = new System.Drawing.Size(416, 192);
            this.panelProduct.TabIndex = 5;
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct.Location = new System.Drawing.Point(10, 7);
            this.labelProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(119, 24);
            this.labelProduct.TabIndex = 27;
            this.labelProduct.Text = "Product List";
            // 
            // panelCombo
            // 
            this.panelCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.panelCombo.Controls.Add(this.labelCombo);
            this.panelCombo.Controls.Add(this.dataGridViewCombo);
            this.panelCombo.Location = new System.Drawing.Point(11, 448);
            this.panelCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCombo.Name = "panelCombo";
            this.panelCombo.Size = new System.Drawing.Size(416, 205);
            this.panelCombo.TabIndex = 6;
            // 
            // labelCombo
            // 
            this.labelCombo.AutoSize = true;
            this.labelCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCombo.Location = new System.Drawing.Point(8, 10);
            this.labelCombo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCombo.Name = "labelCombo";
            this.labelCombo.Size = new System.Drawing.Size(114, 24);
            this.labelCombo.TabIndex = 28;
            this.labelCombo.Text = "Combo List";
            // 
            // panelBtn
            // 
            this.panelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.panelBtn.Controls.Add(this.buttonPay);
            this.panelBtn.Controls.Add(this.textSearch);
            this.panelBtn.Controls.Add(this.buttonRefresh);
            this.panelBtn.Controls.Add(this.btnSearch);
            this.panelBtn.Controls.Add(this.btnAdd);
            this.panelBtn.Controls.Add(this.btnEdit);
            this.panelBtn.Controls.Add(this.btnDel);
            this.panelBtn.Controls.Add(this.labelButton);
            this.panelBtn.Location = new System.Drawing.Point(442, 448);
            this.panelBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(458, 205);
            this.panelBtn.TabIndex = 29;
            // 
            // buttonPay
            // 
            this.buttonPay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPay.Image = global::ComputerWinform.Properties.Resources.áda;
            this.buttonPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPay.Location = new System.Drawing.Point(310, 96);
            this.buttonPay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(125, 39);
            this.buttonPay.TabIndex = 35;
            this.buttonPay.Text = "Pay";
            this.buttonPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPay.UseVisualStyleBackColor = true;
            // 
            // textSearch
            // 
            this.textSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.Location = new System.Drawing.Point(155, 54);
            this.textSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(281, 32);
            this.textSearch.TabIndex = 31;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Image = global::ComputerWinform.Properties.Resources.refresh_30px;
            this.buttonRefresh.Location = new System.Drawing.Point(18, 97);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(254, 39);
            this.buttonRefresh.TabIndex = 34;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::ComputerWinform.Properties.Resources.search_30px;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(18, 46);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 39);
            this.btnSearch.TabIndex = 32;
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
            this.btnAdd.Location = new System.Drawing.Point(18, 149);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 39);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::ComputerWinform.Properties.Resources.edit_30px;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(155, 149);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(116, 39);
            this.btnEdit.TabIndex = 30;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Image = global::ComputerWinform.Properties.Resources.delete_bin_30px;
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(310, 149);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(125, 39);
            this.btnDel.TabIndex = 29;
            this.btnDel.Text = "Delete";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // labelButton
            // 
            this.labelButton.AutoSize = true;
            this.labelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelButton.Location = new System.Drawing.Point(14, 10);
            this.labelButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelButton.Name = "labelButton";
            this.labelButton.Size = new System.Drawing.Size(69, 24);
            this.labelButton.TabIndex = 28;
            this.labelButton.Text = "Button";
            // 
            // panelFill
            // 
            this.panelFill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.panelFill.Controls.Add(this.buttonLoadCombo);
            this.panelFill.Controls.Add(this.buttonLoadProduct);
            this.panelFill.Controls.Add(this.buttonAddCombo);
            this.panelFill.Controls.Add(this.cbComboname);
            this.panelFill.Controls.Add(this.dataGridView2);
            this.panelFill.Controls.Add(this.dataGridView1);
            this.panelFill.Controls.Add(this.dateDate);
            this.panelFill.Controls.Add(this.textStatus);
            this.panelFill.Controls.Add(this.textPhone);
            this.panelFill.Controls.Add(this.label7);
            this.panelFill.Controls.Add(this.label6);
            this.panelFill.Controls.Add(this.label5);
            this.panelFill.Controls.Add(this.cbCustomer);
            this.panelFill.Controls.Add(this.label4);
            this.panelFill.Controls.Add(this.buttonAddProduct);
            this.panelFill.Controls.Add(this.cbProductName);
            this.panelFill.Controls.Add(this.textId);
            this.panelFill.Controls.Add(this.Id);
            this.panelFill.Controls.Add(this.textAddress);
            this.panelFill.Controls.Add(this.textName);
            this.panelFill.Controls.Add(this.labelDis);
            this.panelFill.Controls.Add(this.labelName);
            this.panelFill.Controls.Add(this.labelOrder);
            this.panelFill.Location = new System.Drawing.Point(442, 10);
            this.panelFill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(458, 425);
            this.panelFill.TabIndex = 30;
            // 
            // buttonLoadCombo
            // 
            this.buttonLoadCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadCombo.Image = global::ComputerWinform.Properties.Resources.wait_30px1;
            this.buttonLoadCombo.Location = new System.Drawing.Point(383, 265);
            this.buttonLoadCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLoadCombo.Name = "buttonLoadCombo";
            this.buttonLoadCombo.Size = new System.Drawing.Size(74, 41);
            this.buttonLoadCombo.TabIndex = 34;
            this.buttonLoadCombo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoadCombo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLoadCombo.UseVisualStyleBackColor = true;
            this.buttonLoadCombo.Click += new System.EventHandler(this.buttonLoadCombo_Click);
            // 
            // buttonLoadProduct
            // 
            this.buttonLoadProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadProduct.Image = global::ComputerWinform.Properties.Resources.wait_30px;
            this.buttonLoadProduct.Location = new System.Drawing.Point(155, 265);
            this.buttonLoadProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLoadProduct.Name = "buttonLoadProduct";
            this.buttonLoadProduct.Size = new System.Drawing.Size(74, 41);
            this.buttonLoadProduct.TabIndex = 33;
            this.buttonLoadProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLoadProduct.UseVisualStyleBackColor = true;
            this.buttonLoadProduct.Click += new System.EventHandler(this.buttonLoadProduct_Click);
            // 
            // buttonAddCombo
            // 
            this.buttonAddCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCombo.Image = global::ComputerWinform.Properties.Resources.add_30px;
            this.buttonAddCombo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddCombo.Location = new System.Drawing.Point(241, 265);
            this.buttonAddCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddCombo.Name = "buttonAddCombo";
            this.buttonAddCombo.Size = new System.Drawing.Size(136, 41);
            this.buttonAddCombo.TabIndex = 32;
            this.buttonAddCombo.Text = "Add Combo";
            this.buttonAddCombo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddCombo.UseVisualStyleBackColor = true;
            this.buttonAddCombo.Click += new System.EventHandler(this.buttonAddCombo_Click);
            // 
            // cbComboname
            // 
            this.cbComboname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbComboname.FormattingEnabled = true;
            this.cbComboname.Location = new System.Drawing.Point(241, 309);
            this.cbComboname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbComboname.Name = "cbComboname";
            this.cbComboname.Size = new System.Drawing.Size(218, 21);
            this.cbComboname.TabIndex = 31;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comboid,
            this.comboName,
            this.DeleteCombo});
            this.dataGridView2.Location = new System.Drawing.Point(241, 332);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(217, 93);
            this.dataGridView2.TabIndex = 30;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // comboid
            // 
            this.comboid.HeaderText = "Combo Id";
            this.comboid.MinimumWidth = 6;
            this.comboid.Name = "comboid";
            // 
            // comboName
            // 
            this.comboName.HeaderText = "Combo Name";
            this.comboName.MinimumWidth = 6;
            this.comboName.Name = "comboName";
            // 
            // DeleteCombo
            // 
            this.DeleteCombo.HeaderText = "Delete";
            this.DeleteCombo.MinimumWidth = 6;
            this.DeleteCombo.Name = "DeleteCombo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productid,
            this.productname,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(0, 332);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(228, 93);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // productid
            // 
            this.productid.HeaderText = "Product Id";
            this.productid.MinimumWidth = 6;
            this.productid.Name = "productid";
            // 
            // productname
            // 
            this.productname.HeaderText = "Product Name";
            this.productname.MinimumWidth = 6;
            this.productname.Name = "productname";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            // 
            // dateDate
            // 
            this.dateDate.Location = new System.Drawing.Point(198, 233);
            this.dateDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateDate.Name = "dateDate";
            this.dateDate.Size = new System.Drawing.Size(239, 20);
            this.dateDate.TabIndex = 26;
            // 
            // textStatus
            // 
            this.textStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textStatus.Location = new System.Drawing.Point(198, 206);
            this.textStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(239, 20);
            this.textStatus.TabIndex = 25;
            // 
            // textPhone
            // 
            this.textPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textPhone.Location = new System.Drawing.Point(200, 174);
            this.textPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(239, 20);
            this.textPhone.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 235);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Phone";
            // 
            // cbCustomer
            // 
            this.cbCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(200, 44);
            this.cbCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(239, 21);
            this.cbCustomer.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Customer";
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProduct.Image = global::ComputerWinform.Properties.Resources.add_30px;
            this.buttonAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddProduct.Location = new System.Drawing.Point(0, 265);
            this.buttonAddProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(146, 41);
            this.buttonAddProduct.TabIndex = 12;
            this.buttonAddProduct.Text = "Add Product ";
            this.buttonAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // cbProductName
            // 
            this.cbProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProductName.FormattingEnabled = true;
            this.cbProductName.Location = new System.Drawing.Point(0, 309);
            this.cbProductName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbProductName.Name = "cbProductName";
            this.cbProductName.Size = new System.Drawing.Size(229, 21);
            this.cbProductName.TabIndex = 17;
            // 
            // textId
            // 
            this.textId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textId.Enabled = false;
            this.textId.Location = new System.Drawing.Point(200, 76);
            this.textId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(239, 20);
            this.textId.TabIndex = 14;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(17, 76);
            this.Id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(21, 17);
            this.Id.TabIndex = 13;
            this.Id.Text = "Id";
            // 
            // textAddress
            // 
            this.textAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textAddress.Location = new System.Drawing.Point(200, 140);
            this.textAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(239, 20);
            this.textAddress.TabIndex = 6;
            // 
            // textName
            // 
            this.textName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textName.Location = new System.Drawing.Point(200, 106);
            this.textName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(239, 20);
            this.textName.TabIndex = 5;
            // 
            // labelDis
            // 
            this.labelDis.AutoSize = true;
            this.labelDis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDis.Location = new System.Drawing.Point(17, 141);
            this.labelDis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDis.Name = "labelDis";
            this.labelDis.Size = new System.Drawing.Size(67, 17);
            this.labelDis.TabIndex = 2;
            this.labelDis.Text = "Address";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(17, 106);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(122, 17);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Recipient Name";
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrder.Location = new System.Drawing.Point(14, 8);
            this.labelOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(64, 24);
            this.labelOrder.TabIndex = 0;
            this.labelOrder.Text = "Order";
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(908, 663);
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.panelBtn);
            this.Controls.Add(this.panelCombo);
            this.Controls.Add(this.panelProduct);
            this.Controls.Add(this.panelReceipt);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormOrder";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.panelReceipt.ResumeLayout(false);
            this.panelReceipt.PerformLayout();
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            this.panelCombo.ResumeLayout(false);
            this.panelCombo.PerformLayout();
            this.panelBtn.ResumeLayout(false);
            this.panelBtn.PerformLayout();
            this.panelFill.ResumeLayout(false);
            this.panelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.DataGridView dataGridViewCombo;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Panel panelReceipt;
        private System.Windows.Forms.Label labelReceipt;
        private Guna.UI2.WinForms.Guna2Panel panelProduct;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Panel panelCombo;
        private System.Windows.Forms.Label labelCombo;
        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.Label labelButton;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.ComboBox cbProductName;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelDis;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateDate;
        private System.Windows.Forms.TextBox textStatus;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbComboname;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn comboid;
        private System.Windows.Forms.DataGridViewTextBoxColumn comboName;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn productid;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Button buttonLoadCombo;
        private System.Windows.Forms.Button buttonLoadProduct;
    }
}