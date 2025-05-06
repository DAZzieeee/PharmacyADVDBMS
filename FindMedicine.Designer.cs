namespace PharmacyLogin
{
    partial class FindMedicine
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnSortNameAsc = new System.Windows.Forms.Button();
            this.btnSortNameDesc = new System.Windows.Forms.Button();
            this.btnSortIDAsc = new System.Windows.Forms.Button();
            this.btnSortIDDesc = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(322, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "FIND MEDICINE";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(34, 53);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(571, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(617, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(686, 435);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(743, 96);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(114, 25);
            this.btnViewAll.TabIndex = 4;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnSortNameAsc
            // 
            this.btnSortNameAsc.Location = new System.Drawing.Point(743, 139);
            this.btnSortNameAsc.Name = "btnSortNameAsc";
            this.btnSortNameAsc.Size = new System.Drawing.Size(114, 25);
            this.btnSortNameAsc.TabIndex = 5;
            this.btnSortNameAsc.Text = "ASC by NAME";
            this.btnSortNameAsc.UseVisualStyleBackColor = true;
            this.btnSortNameAsc.Click += new System.EventHandler(this.btnSortNameAsc_Click);
            // 
            // btnSortNameDesc
            // 
            this.btnSortNameDesc.Location = new System.Drawing.Point(743, 171);
            this.btnSortNameDesc.Name = "btnSortNameDesc";
            this.btnSortNameDesc.Size = new System.Drawing.Size(114, 25);
            this.btnSortNameDesc.TabIndex = 6;
            this.btnSortNameDesc.Text = "DESC by NAME";
            this.btnSortNameDesc.UseVisualStyleBackColor = true;
            this.btnSortNameDesc.Click += new System.EventHandler(this.btnSortNameDesc_Click);
            // 
            // btnSortIDAsc
            // 
            this.btnSortIDAsc.Location = new System.Drawing.Point(743, 213);
            this.btnSortIDAsc.Name = "btnSortIDAsc";
            this.btnSortIDAsc.Size = new System.Drawing.Size(114, 25);
            this.btnSortIDAsc.TabIndex = 7;
            this.btnSortIDAsc.Text = "ASC by ID";
            this.btnSortIDAsc.UseVisualStyleBackColor = true;
            this.btnSortIDAsc.Click += new System.EventHandler(this.btnSortIDAsc_Click);
            // 
            // btnSortIDDesc
            // 
            this.btnSortIDDesc.Location = new System.Drawing.Point(743, 245);
            this.btnSortIDDesc.Name = "btnSortIDDesc";
            this.btnSortIDDesc.Size = new System.Drawing.Size(114, 25);
            this.btnSortIDDesc.TabIndex = 8;
            this.btnSortIDDesc.Text = "DESC by ID";
            this.btnSortIDDesc.UseVisualStyleBackColor = true;
            this.btnSortIDDesc.Click += new System.EventHandler(this.btnSortIDDesc_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(743, 516);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 32);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FindMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 596);
            this.Controls.Add(this.btnSortIDDesc);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnSortNameAsc);
            this.Controls.Add(this.btnSortNameDesc);
            this.Controls.Add(this.btnSortIDAsc);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FindMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Medicine";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnSortNameAsc;
        private System.Windows.Forms.Button btnSortNameDesc;
        private System.Windows.Forms.Button btnSortIDAsc;
        private System.Windows.Forms.Button btnSortIDDesc;
        private System.Windows.Forms.Button btnBack;
    }
}