﻿
namespace ComputerWinform.Forms
{
    partial class FormStorage
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
<<<<<<< HEAD
            this.dataGridViewStorage = new System.Windows.Forms.DataGridView();
            this.labelCategory = new System.Windows.Forms.Label();
            this.textExport = new System.Windows.Forms.TextBox();
=======
            this.dataGridViewTicket = new System.Windows.Forms.DataGridView();
            this.labelDate = new System.Windows.Forms.Label();
            this.textIsImport = new System.Windows.Forms.TextBox();
>>>>>>> 45fae6e955f0a3025e223f4bc2a65c353aa1de26
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.labelStorage = new System.Windows.Forms.Label();
            this.panelFill = new System.Windows.Forms.Panel();
<<<<<<< HEAD
            this.cbProductName = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textImport = new System.Windows.Forms.TextBox();
            this.labelDes = new System.Windows.Forms.Label();
=======
            this.labelAddProduct = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbProductName = new System.Windows.Forms.ComboBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.textTotalAmount = new System.Windows.Forms.TextBox();
            this.dateDate = new System.Windows.Forms.DateTimePicker();
            this.textTotalCost = new System.Windows.Forms.TextBox();
            this.labelTotalcost = new System.Windows.Forms.Label();
>>>>>>> 45fae6e955f0a3025e223f4bc2a65c353aa1de26
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.labelButton = new System.Windows.Forms.Label();
            this.panelBtn = new System.Windows.Forms.Panel();
<<<<<<< HEAD
            this.label1 = new System.Windows.Forms.Label();
            this.textStorageId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStorage)).BeginInit();
=======
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewDetail = new System.Windows.Forms.DataGridView();
            this.labelDetail = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelList = new System.Windows.Forms.Label();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicket)).BeginInit();
>>>>>>> 45fae6e955f0a3025e223f4bc2a65c353aa1de26
            this.panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.panelBtn.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
<<<<<<< HEAD
            // dataGridViewStorage
            // 
            this.dataGridViewStorage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStorage.Location = new System.Drawing.Point(-1, 0);
            this.dataGridViewStorage.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewStorage.Name = "dataGridViewStorage";
            this.dataGridViewStorage.RowHeadersWidth = 51;
            this.dataGridViewStorage.RowTemplate.Height = 24;
            this.dataGridViewStorage.Size = new System.Drawing.Size(421, 717);
            this.dataGridViewStorage.TabIndex = 0;
            this.dataGridViewStorage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStorage_CellContentClick);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(11, 173);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(42, 17);
            this.labelCategory.TabIndex = 9;
            this.labelCategory.Text = "Date";
            // 
            // textExport
            // 
            this.textExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textExport.Location = new System.Drawing.Point(136, 128);
            this.textExport.Margin = new System.Windows.Forms.Padding(2);
            this.textExport.Name = "textExport";
            this.textExport.Size = new System.Drawing.Size(239, 20);
            this.textExport.TabIndex = 7;
=======
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
            this.dataGridViewTicket.Name = "dataGridViewTicket";
            this.dataGridViewTicket.RowHeadersWidth = 51;
            this.dataGridViewTicket.RowTemplate.Height = 24;
            this.dataGridViewTicket.Size = new System.Drawing.Size(585, 475);
            this.dataGridViewTicket.TabIndex = 0;
            this.dataGridViewTicket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTicket_CellContentClick);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(21, 164);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(49, 20);
            this.labelDate.TabIndex = 9;
            this.labelDate.Text = "Date";
            // 
            // textIsImport
            // 
            this.textIsImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textIsImport.Location = new System.Drawing.Point(202, 125);
            this.textIsImport.Name = "textIsImport";
            this.textIsImport.Size = new System.Drawing.Size(317, 22);
            this.textIsImport.TabIndex = 7;
>>>>>>> 45fae6e955f0a3025e223f4bc2a65c353aa1de26
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.labelPrice.Location = new System.Drawing.Point(11, 129);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(54, 17);
=======
            this.labelPrice.Location = new System.Drawing.Point(21, 125);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(122, 20);
>>>>>>> 45fae6e955f0a3025e223f4bc2a65c353aa1de26
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "Import/Export";
            // 
            // labelTotalAmount
            // 
<<<<<<< HEAD
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(11, 63);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(82, 17);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Product Id";
=======
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAmount.Location = new System.Drawing.Point(21, 50);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(120, 20);
            this.labelTotalAmount.TabIndex = 1;
            this.labelTotalAmount.Text = "Total Amount";
>>>>>>> 45fae6e955f0a3025e223f4bc2a65c353aa1de26
            // 
            // labelStorage
            // 
            this.labelStorage.AutoSize = true;
            this.labelStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.labelStorage.Location = new System.Drawing.Point(14, 8);
            this.labelStorage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
=======
            this.labelStorage.Location = new System.Drawing.Point(19, 10);
>>>>>>> 45fae6e955f0a3025e223f4bc2a65c353aa1de26
            this.labelStorage.Name = "labelStorage";
            this.labelStorage.Size = new System.Drawing.Size(82, 24);
            this.labelStorage.TabIndex = 0;
            this.labelStorage.Text = "Storage";
            // 
            // panelFill
            // 
            this.panelFill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
<<<<<<< HEAD
            this.panelFill.Controls.Add(this.textStorageId);
            this.panelFill.Controls.Add(this.label1);
            this.panelFill.Controls.Add(this.cbProductName);
            this.panelFill.Controls.Add(this.dateTimePicker1);
            this.panelFill.Controls.Add(this.labelCategory);
            this.panelFill.Controls.Add(this.textExport);
            this.panelFill.Controls.Add(this.textImport);
=======
            this.panelFill.Controls.Add(this.labelAddProduct);
            this.panelFill.Controls.Add(this.button1);
            this.panelFill.Controls.Add(this.cbProductName);
            this.panelFill.Controls.Add(this.labelProductName);
            this.panelFill.Controls.Add(this.dataGridViewProduct);
            this.panelFill.Controls.Add(this.textTotalAmount);
            this.panelFill.Controls.Add(this.dateDate);
            this.panelFill.Controls.Add(this.labelDate);
            this.panelFill.Controls.Add(this.textIsImport);
            this.panelFill.Controls.Add(this.textTotalCost);
>>>>>>> 45fae6e955f0a3025e223f4bc2a65c353aa1de26
            this.panelFill.Controls.Add(this.labelPrice);
            this.panelFill.Controls.Add(this.labelTotalcost);
            this.panelFill.Controls.Add(this.labelTotalAmount);
            this.panelFill.Controls.Add(this.labelStorage);
<<<<<<< HEAD
            this.panelFill.Location = new System.Drawing.Point(424, 9);
            this.panelFill.Margin = new System.Windows.Forms.Padding(2);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(392, 232);
            this.panelFill.TabIndex = 2;
            // 
            // cbProductName
            // 
            this.cbProductName.FormattingEnabled = true;
            this.cbProductName.Location = new System.Drawing.Point(136, 59);
            this.cbProductName.Margin = new System.Windows.Forms.Padding(2);
            this.cbProductName.Name = "cbProductName";
            this.cbProductName.Size = new System.Drawing.Size(239, 21);
            this.cbProductName.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 171);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(239, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textImport
            // 
            this.textImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textImport.Location = new System.Drawing.Point(136, 93);
            this.textImport.Margin = new System.Windows.Forms.Padding(2);
            this.textImport.Name = "textImport";
            this.textImport.Size = new System.Drawing.Size(239, 20);
            this.textImport.TabIndex = 6;
=======
            this.panelFill.Location = new System.Drawing.Point(618, 11);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(552, 523);
            this.panelFill.TabIndex = 2;
            // 
            // labelAddProduct
            // 
            this.labelAddProduct.AutoSize = true;
            this.labelAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddProduct.Location = new System.Drawing.Point(19, 201);
            this.labelAddProduct.Name = "labelAddProduct";
            this.labelAddProduct.Size = new System.Drawing.Size(87, 29);
            this.labelAddProduct.TabIndex = 22;
            this.labelAddProduct.Text = "Import";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::ComputerWinform.Properties.Resources.add_30px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(323, 201);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 51);
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
            this.cbProductName.Location = new System.Drawing.Point(160, 272);
            this.cbProductName.Name = "cbProductName";
            this.cbProductName.Size = new System.Drawing.Size(359, 24);
            this.cbProductName.TabIndex = 23;
            // 
            // labelProductName
>>>>>>> 45fae6e955f0a3025e223f4bc2a65c353aa1de26
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(21, 276);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(74, 20);
            this.labelProductName.TabIndex = 24;
            this.labelProductName.Text = "Product";
            // 
<<<<<<< HEAD
            this.labelDes.AutoSize = true;
            this.labelDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDes.Location = new System.Drawing.Point(11, 94);
            this.labelDes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDes.Name = "labelDes";
            this.labelDes.Size = new System.Drawing.Size(53, 17);
            this.labelDes.TabIndex = 2;
            this.labelDes.Text = "Import";
=======
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
            this.Product,
            this.Delete});
            this.dataGridViewProduct.Location = new System.Drawing.Point(0, 302);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowHeadersWidth = 51;
            this.dataGridViewProduct.RowTemplate.Height = 24;
            this.dataGridViewProduct.Size = new System.Drawing.Size(552, 221);
            this.dataGridViewProduct.TabIndex = 20;
            // 
            // textTotalAmount
            // 
            this.textTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textTotalAmount.Location = new System.Drawing.Point(202, 48);
            this.textTotalAmount.Name = "textTotalAmount";
            this.textTotalAmount.Size = new System.Drawing.Size(317, 22);
            this.textTotalAmount.TabIndex = 14;
            // 
            // dateDate
            // 
            this.dateDate.Location = new System.Drawing.Point(202, 162);
            this.dateDate.Name = "dateDate";
            this.dateDate.Size = new System.Drawing.Size(317, 22);
            this.dateDate.TabIndex = 13;
            // 
            // textTotalCost
            // 
            this.textTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textTotalCost.Location = new System.Drawing.Point(202, 91);
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
>>>>>>> 45fae6e955f0a3025e223f4bc2a65c353aa1de26
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Image = global::ComputerWinform.Properties.Resources.refresh_30px;
<<<<<<< HEAD
            this.buttonRefresh.Location = new System.Drawing.Point(146, 105);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(88, 39);
=======
            this.buttonRefresh.Location = new System.Drawing.Point(35, 120);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(484, 48);
>>>>>>> 45fae6e955f0a3025e223f4bc2a65c353aa1de26
            this.buttonRefresh.TabIndex = 11;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // textSearch
            // 
            this.textSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.textSearch.Location = new System.Drawing.Point(142, 51);
            this.textSearch.Margin = new System.Windows.Forms.Padding(2);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(225, 32);
=======
            this.textSearch.Location = new System.Drawing.Point(202, 66);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(317, 38);
>>>>>>> 45fae6e955f0a3025e223f4bc2a65c353aa1de26
            this.textSearch.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::ComputerWinform.Properties.Resources.search_30px;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
<<<<<<< HEAD
            this.btnSearch.Location = new System.Drawing.Point(26, 51);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
=======
            this.btnSearch.Location = new System.Drawing.Point(35, 56);
>>>>>>> 45fae6e955f0a3025e223f4bc2a65c353aa1de26
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 39);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
<<<<<<< HEAD
            // btnFilter
            // 
            this.btnFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Image = global::ComputerWinform.Properties.Resources.filter_30px;
            this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilter.Location = new System.Drawing.Point(26, 104);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(101, 39);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Filter";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
=======
>>>>>>> 45fae6e955f0a3025e223f4bc2a65c353aa1de26
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::ComputerWinform.Properties.Resources.add_30px;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
<<<<<<< HEAD
            this.btnAdd.Location = new System.Drawing.Point(26, 158);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
=======
            this.btnAdd.Location = new System.Drawing.Point(35, 189);
>>>>>>> 45fae6e955f0a3025e223f4bc2a65c353aa1de26
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 39);
            this.btnAdd.TabIndex = 4;
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
<<<<<<< HEAD
            this.btnEdit.Location = new System.Drawing.Point(142, 158);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 39);
=======
            this.btnEdit.Location = new System.Drawing.Point(202, 189);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(155, 48);
>>>>>>> 45fae6e955f0a3025e223f4bc2a65c353aa1de26
            this.btnEdit.TabIndex = 3;
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
<<<<<<< HEAD
            this.btnDel.Location = new System.Drawing.Point(256, 158);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(110, 39);
=======
            this.btnDel.Location = new System.Drawing.Point(384, 189);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(135, 48);
>>>>>>> 45fae6e955f0a3025e223f4bc2a65c353aa1de26
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
<<<<<<< HEAD
            this.labelButton.Location = new System.Drawing.Point(14, 8);
            this.labelButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
=======
            this.labelButton.Location = new System.Drawing.Point(19, 11);
>>>>>>> 45fae6e955f0a3025e223f4bc2a65c353aa1de26
            this.labelButton.Name = "labelButton";
            this.labelButton.Size = new System.Drawing.Size(69, 24);
            this.labelButton.TabIndex = 1;
            this.labelButton.Text = "Button";
            // 
            // panelBtn
            // 
            this.panelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.panelBtn.Controls.Add(this.buttonRefresh);
            this.panelBtn.Controls.Add(this.textSearch);
            this.panelBtn.Controls.Add(this.btnSearch);
            this.panelBtn.Controls.Add(this.btnAdd);
            this.panelBtn.Controls.Add(this.btnEdit);
            this.panelBtn.Controls.Add(this.btnDel);
            this.panelBtn.Controls.Add(this.labelButton);
<<<<<<< HEAD
            this.panelBtn.Location = new System.Drawing.Point(424, 245);
            this.panelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(392, 214);
            this.panelBtn.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Id";
            // 
            // textStorageId
            // 
            this.textStorageId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textStorageId.Location = new System.Drawing.Point(136, 29);
            this.textStorageId.Margin = new System.Windows.Forms.Padding(2);
            this.textStorageId.Name = "textStorageId";
            this.textStorageId.Size = new System.Drawing.Size(239, 20);
            this.textStorageId.TabIndex = 16;
=======
            this.panelBtn.Location = new System.Drawing.Point(618, 557);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(552, 253);
            this.panelBtn.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.panel2.Controls.Add(this.dataGridViewDetail);
            this.panel2.Controls.Add(this.labelDetail);
            this.panel2.Location = new System.Drawing.Point(12, 557);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 253);
            this.panel2.TabIndex = 13;
            // 
            // dataGridViewDetail
            // 
            this.dataGridViewDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.dataGridViewDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewDetail.Location = new System.Drawing.Point(0, 43);
            this.dataGridViewDetail.Name = "dataGridViewDetail";
            this.dataGridViewDetail.RowHeadersWidth = 51;
            this.dataGridViewDetail.RowTemplate.Height = 24;
            this.dataGridViewDetail.Size = new System.Drawing.Size(585, 210);
            this.dataGridViewDetail.TabIndex = 2;
            // 
            // labelDetail
            // 
            this.labelDetail.AutoSize = true;
            this.labelDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetail.Location = new System.Drawing.Point(30, 11);
            this.labelDetail.Name = "labelDetail";
            this.labelDetail.Size = new System.Drawing.Size(94, 29);
            this.labelDetail.TabIndex = 1;
            this.labelDetail.Text = "Details";
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 523);
            this.panel1.TabIndex = 14;
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelList.Location = new System.Drawing.Point(19, 10);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(153, 29);
            this.labelList.TabIndex = 25;
            this.labelList.Text = "Storage List";
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete Product";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
>>>>>>> 45fae6e955f0a3025e223f4bc2a65c353aa1de26
            // 
            // FormStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(826, 461);
            this.Controls.Add(this.dataGridViewStorage);
            this.Controls.Add(this.panelBtn);
            this.Controls.Add(this.panelFill);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormStorage";
            this.Text = "Storage";
            this.Load += new System.EventHandler(this.FormStorage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStorage)).EndInit();
=======
            this.ClientSize = new System.Drawing.Size(1182, 822);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelBtn);
            this.Controls.Add(this.panelFill);
            this.Name = "FormStorage";
            this.Text = "Storage";
            this.Load += new System.EventHandler(this.FormStorage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicket)).EndInit();
>>>>>>> 45fae6e955f0a3025e223f4bc2a65c353aa1de26
            this.panelFill.ResumeLayout(false);
            this.panelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.panelBtn.ResumeLayout(false);
            this.panelBtn.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.DataGridView dataGridViewStorage;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox textExport;
=======
        private System.Windows.Forms.DataGridView dataGridViewTicket;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textIsImport;
>>>>>>> 45fae6e955f0a3025e223f4bc2a65c353aa1de26
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Label labelStorage;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label labelButton;
        private System.Windows.Forms.Panel panelBtn;
<<<<<<< HEAD
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textImport;
        private System.Windows.Forms.Label labelDes;
        private System.Windows.Forms.ComboBox cbProductName;
        private System.Windows.Forms.TextBox textStorageId;
        private System.Windows.Forms.Label label1;
=======
        private System.Windows.Forms.DateTimePicker dateDate;
        private System.Windows.Forms.TextBox textTotalCost;
        private System.Windows.Forms.Label labelTotalcost;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewDetail;
        private System.Windows.Forms.Label labelDetail;
        private System.Windows.Forms.TextBox textTotalAmount;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Label labelAddProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbProductName;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
>>>>>>> 45fae6e955f0a3025e223f4bc2a65c353aa1de26
    }
}