
namespace ComputerWinform.Forms
{
    partial class FormCategory
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
            this.panelCategory = new System.Windows.Forms.Panel();
            this.panelFill = new System.Windows.Forms.Panel();
            this.textCategoryName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.labelButton = new System.Windows.Forms.Label();
            this.dataGridViewCatetgory = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.textCategoryId = new System.Windows.Forms.TextBox();
            this.panelCategory.SuspendLayout();
            this.panelFill.SuspendLayout();
            this.panelBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatetgory)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCategory
            // 
            this.panelCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelCategory.Controls.Add(this.panelFill);
            this.panelCategory.Controls.Add(this.panelBtn);
            this.panelCategory.Controls.Add(this.dataGridViewCatetgory);
            this.panelCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCategory.Location = new System.Drawing.Point(0, 0);
            this.panelCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(620, 310);
            this.panelCategory.TabIndex = 0;
            // 
            // panelFill
            // 
            this.panelFill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.panelFill.Controls.Add(this.textCategoryId);
            this.panelFill.Controls.Add(this.label1);
            this.panelFill.Controls.Add(this.textCategoryName);
            this.panelFill.Controls.Add(this.labelName);
            this.panelFill.Controls.Add(this.labelProduct);
            this.panelFill.Location = new System.Drawing.Point(238, 10);
            this.panelFill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(372, 93);
            this.panelFill.TabIndex = 10;
            // 
            // textCategoryName
            // 
            this.textCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textCategoryName.Location = new System.Drawing.Point(129, 64);
            this.textCategoryName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textCategoryName.Name = "textCategoryName";
            this.textCategoryName.Size = new System.Drawing.Size(225, 20);
            this.textCategoryName.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(13, 67);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 17);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct.Location = new System.Drawing.Point(14, 8);
            this.labelProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(93, 24);
            this.labelProduct.TabIndex = 0;
            this.labelProduct.Text = "Category";
            // 
            // panelBtn
            // 
            this.panelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.panelBtn.Controls.Add(this.buttonRefresh);
            this.panelBtn.Controls.Add(this.textSearch);
            this.panelBtn.Controls.Add(this.btnSearch);
            this.panelBtn.Controls.Add(this.btnFilter);
            this.panelBtn.Controls.Add(this.btnAdd);
            this.panelBtn.Controls.Add(this.btnEdit);
            this.panelBtn.Controls.Add(this.btnDel);
            this.panelBtn.Controls.Add(this.labelButton);
            this.panelBtn.Location = new System.Drawing.Point(238, 111);
            this.panelBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(372, 188);
            this.panelBtn.TabIndex = 3;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Image = global::ComputerWinform.Properties.Resources.refresh_30px;
            this.buttonRefresh.Location = new System.Drawing.Point(129, 91);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(42, 39);
            this.buttonRefresh.TabIndex = 10;
            this.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textSearch
            // 
            this.textSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.Location = new System.Drawing.Point(129, 39);
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
            this.btnSearch.Location = new System.Drawing.Point(17, 39);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 39);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Image = global::ComputerWinform.Properties.Resources.filter_30px;
            this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilter.Location = new System.Drawing.Point(16, 91);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(101, 39);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Filter";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::ComputerWinform.Properties.Resources.add_30px;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(17, 143);
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
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::ComputerWinform.Properties.Resources.edit_30px;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(129, 143);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 39);
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
            this.btnDel.Location = new System.Drawing.Point(236, 143);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(118, 39);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Delete";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // labelButton
            // 
            this.labelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelButton.AutoSize = true;
            this.labelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelButton.Location = new System.Drawing.Point(14, 5);
            this.labelButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelButton.Name = "labelButton";
            this.labelButton.Size = new System.Drawing.Size(69, 24);
            this.labelButton.TabIndex = 1;
            this.labelButton.Text = "Button";
            // 
            // dataGridViewCatetgory
            // 
            this.dataGridViewCatetgory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCatetgory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCatetgory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCatetgory.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCatetgory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewCatetgory.Name = "dataGridViewCatetgory";
            this.dataGridViewCatetgory.RowHeadersWidth = 51;
            this.dataGridViewCatetgory.RowTemplate.Height = 24;
            this.dataGridViewCatetgory.Size = new System.Drawing.Size(229, 310);
            this.dataGridViewCatetgory.TabIndex = 0;
            this.dataGridViewCatetgory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCatetgory_CellContentClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id";
            // 
            // textCategoryId
            // 
            this.textCategoryId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textCategoryId.Enabled = false;
            this.textCategoryId.Location = new System.Drawing.Point(129, 38);
            this.textCategoryId.Margin = new System.Windows.Forms.Padding(2);
            this.textCategoryId.Name = "textCategoryId";
            this.textCategoryId.Size = new System.Drawing.Size(225, 20);
            this.textCategoryId.TabIndex = 7;
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 310);
            this.Controls.Add(this.panelCategory);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCategory";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.FormCategory_LoadAsync);
            this.panelCategory.ResumeLayout(false);
            this.panelFill.ResumeLayout(false);
            this.panelFill.PerformLayout();
            this.panelBtn.ResumeLayout(false);
            this.panelBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatetgory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCategory;
        private System.Windows.Forms.DataGridView dataGridViewCatetgory;
        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label labelButton;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.TextBox textCategoryName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCategoryId;
    }
}