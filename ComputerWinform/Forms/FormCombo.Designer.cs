﻿
namespace ComputerWinform.Forms
{
    partial class FormCombo
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
            this.dataGridViewCombo = new System.Windows.Forms.DataGridView();
            this.panelFill = new System.Windows.Forms.Panel();
            this.labelAddProduct = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbProductName = new System.Windows.Forms.ComboBox();
            this.textComboId = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textDiscount = new System.Windows.Forms.TextBox();
            this.textComboName = new System.Windows.Forms.TextBox();
            this.labelDis = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCombo = new System.Windows.Forms.Label();
            this.dataGridViewDetails = new System.Windows.Forms.DataGridView();
            this.labelDetails = new System.Windows.Forms.Label();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.labelButton = new System.Windows.Forms.Label();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCombo)).BeginInit();
            this.panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).BeginInit();
            this.panelBtn.SuspendLayout();
            this.panelDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridViewCombo.Location = new System.Drawing.Point(0, 39);
            this.dataGridViewCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewCombo.Name = "dataGridViewCombo";
            this.dataGridViewCombo.RowHeadersWidth = 51;
            this.dataGridViewCombo.RowTemplate.Height = 24;
            this.dataGridViewCombo.Size = new System.Drawing.Size(392, 399);
            this.dataGridViewCombo.TabIndex = 0;
            this.dataGridViewCombo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCombo_CellContentClick);
            // 
            // panelFill
            // 
            this.panelFill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.panelFill.Controls.Add(this.labelAddProduct);
            this.panelFill.Controls.Add(this.button1);
            this.panelFill.Controls.Add(this.cbProductName);
            this.panelFill.Controls.Add(this.textComboId);
            this.panelFill.Controls.Add(this.labelProductName);
            this.panelFill.Controls.Add(this.Id);
            this.panelFill.Controls.Add(this.dataGridViewProduct);
            this.panelFill.Controls.Add(this.textDiscount);
            this.panelFill.Controls.Add(this.textComboName);
            this.panelFill.Controls.Add(this.labelDis);
            this.panelFill.Controls.Add(this.labelName);
            this.panelFill.Controls.Add(this.labelCombo);
            this.panelFill.Location = new System.Drawing.Point(415, 9);
            this.panelFill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(405, 441);
            this.panelFill.TabIndex = 2;
            // 
            // labelAddProduct
            // 
            this.labelAddProduct.AutoSize = true;
            this.labelAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddProduct.Location = new System.Drawing.Point(14, 145);
            this.labelAddProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddProduct.Name = "labelAddProduct";
            this.labelAddProduct.Size = new System.Drawing.Size(228, 24);
            this.labelAddProduct.TabIndex = 17;
            this.labelAddProduct.Text = "Add products to combo";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::ComputerWinform.Properties.Resources.add_30px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(244, 145);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add Product ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addProductToList);
            // 
            // cbProductName
            // 
            this.cbProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProductName.FormattingEnabled = true;
            this.cbProductName.Location = new System.Drawing.Point(94, 213);
            this.cbProductName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbProductName.Name = "cbProductName";
            this.cbProductName.Size = new System.Drawing.Size(298, 21);
            this.cbProductName.TabIndex = 17;
            // 
            // textComboId
            // 
            this.textComboId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textComboId.Enabled = false;
            this.textComboId.Location = new System.Drawing.Point(154, 40);
            this.textComboId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textComboId.Name = "textComboId";
            this.textComboId.Size = new System.Drawing.Size(239, 20);
            this.textComboId.TabIndex = 14;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(15, 216);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(64, 17);
            this.labelProductName.TabIndex = 18;
            this.labelProductName.Text = "Product";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(15, 41);
            this.Id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(21, 17);
            this.Id.TabIndex = 13;
            this.Id.Text = "Id";
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
            this.ProductId,
            this.Product,
            this.Delete});
            this.dataGridViewProduct.Location = new System.Drawing.Point(0, 240);
            this.dataGridViewProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowHeadersWidth = 51;
            this.dataGridViewProduct.RowTemplate.Height = 24;
            this.dataGridViewProduct.Size = new System.Drawing.Size(405, 201);
            this.dataGridViewProduct.TabIndex = 19;
            this.dataGridViewProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellContentClick);
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Product Id";
            this.ProductId.MinimumWidth = 6;
            this.ProductId.Name = "ProductId";
            // 
            // Product
            // 
            this.Product.HeaderText = "Product Name";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delete.HeaderText = "Delete Product";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            // 
            // textDiscount
            // 
            this.textDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textDiscount.Location = new System.Drawing.Point(154, 101);
            this.textDiscount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textDiscount.Name = "textDiscount";
            this.textDiscount.Size = new System.Drawing.Size(239, 20);
            this.textDiscount.TabIndex = 6;
            // 
            // textComboName
            // 
            this.textComboName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textComboName.Location = new System.Drawing.Point(154, 69);
            this.textComboName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textComboName.Name = "textComboName";
            this.textComboName.Size = new System.Drawing.Size(239, 20);
            this.textComboName.TabIndex = 5;
            // 
            // labelDis
            // 
            this.labelDis.AutoSize = true;
            this.labelDis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDis.Location = new System.Drawing.Point(15, 102);
            this.labelDis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDis.Name = "labelDis";
            this.labelDis.Size = new System.Drawing.Size(71, 17);
            this.labelDis.TabIndex = 2;
            this.labelDis.Text = "Discount";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(15, 71);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 17);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelCombo
            // 
            this.labelCombo.AutoSize = true;
            this.labelCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCombo.Location = new System.Drawing.Point(14, 8);
            this.labelCombo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCombo.Name = "labelCombo";
            this.labelCombo.Size = new System.Drawing.Size(77, 24);
            this.labelCombo.TabIndex = 0;
            this.labelCombo.Text = "Combo";
            // 
            // dataGridViewDetails
            // 
            this.dataGridViewDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.dataGridViewDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewDetails.Location = new System.Drawing.Point(0, 35);
            this.dataGridViewDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewDetails.Name = "dataGridViewDetails";
            this.dataGridViewDetails.RowHeadersWidth = 51;
            this.dataGridViewDetails.RowTemplate.Height = 24;
            this.dataGridViewDetails.Size = new System.Drawing.Size(392, 179);
            this.dataGridViewDetails.TabIndex = 16;
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetails.Location = new System.Drawing.Point(9, 8);
            this.labelDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(72, 24);
            this.labelDetails.TabIndex = 15;
            this.labelDetails.Text = "Details";
            // 
            // panelBtn
            // 
            this.panelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.panelBtn.Controls.Add(this.buttonRefresh);
            this.panelBtn.Controls.Add(this.textSearch);
            this.panelBtn.Controls.Add(this.btnSearch);
            this.panelBtn.Controls.Add(this.btnAdd);
            this.panelBtn.Controls.Add(this.btnUpdate);
            this.panelBtn.Controls.Add(this.btnDel);
            this.panelBtn.Controls.Add(this.labelButton);
            this.panelBtn.Location = new System.Drawing.Point(417, 464);
            this.panelBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(403, 214);
            this.panelBtn.TabIndex = 3;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Image = global::ComputerWinform.Properties.Resources.refresh_30px;
            this.buttonRefresh.Location = new System.Drawing.Point(32, 104);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(340, 39);
            this.buttonRefresh.TabIndex = 11;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // textSearch
            // 
            this.textSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.Location = new System.Drawing.Point(148, 59);
            this.textSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(225, 32);
            this.textSearch.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::ComputerWinform.Properties.Resources.search_30px;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(32, 51);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 39);
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
            this.btnAdd.Location = new System.Drawing.Point(32, 158);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 39);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = global::ComputerWinform.Properties.Resources.edit_30px;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(137, 158);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 39);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Image = global::ComputerWinform.Properties.Resources.delete_bin_30px;
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(262, 158);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(110, 39);
            this.btnDel.TabIndex = 2;
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
            this.labelButton.Location = new System.Drawing.Point(14, 8);
            this.labelButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelButton.Name = "labelButton";
            this.labelButton.Size = new System.Drawing.Size(69, 24);
            this.labelButton.TabIndex = 1;
            this.labelButton.Text = "Button";
            // 
            // panelDetail
            // 
            this.panelDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.panelDetail.Controls.Add(this.dataGridViewDetails);
            this.panelDetail.Controls.Add(this.labelDetails);
            this.panelDetail.Location = new System.Drawing.Point(9, 464);
            this.panelDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(392, 214);
            this.panelDetail.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.labelList);
            this.panel1.Controls.Add(this.dataGridViewCombo);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 438);
            this.panel1.TabIndex = 13;
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelList.Location = new System.Drawing.Point(9, 7);
            this.labelList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(114, 24);
            this.labelList.TabIndex = 20;
            this.labelList.Text = "Combo List";
            // 
            // FormCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(829, 687);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.panelBtn);
            this.Controls.Add(this.panelFill);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCombo";
            this.Text = "Combo";
            this.Load += new System.EventHandler(this.FormCombo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCombo)).EndInit();
            this.panelFill.ResumeLayout(false);
            this.panelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).EndInit();
            this.panelBtn.ResumeLayout(false);
            this.panelBtn.PerformLayout();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCombo;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.TextBox textComboId;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox textDiscount;
        private System.Windows.Forms.TextBox textComboName;
        private System.Windows.Forms.Label labelDis;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCombo;
        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label labelButton;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.DataGridView dataGridViewDetails;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.ComboBox cbProductName;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Label labelAddProduct;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}