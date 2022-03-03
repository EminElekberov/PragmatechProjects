﻿
namespace ParfumUI.Users
{
    partial class UserSaleMonitor
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
            this.dataGridViewShearch = new System.Windows.Forms.DataGridView();
            this.textcatogory = new System.Windows.Forms.Label();
            this.btn_allparfums = new System.Windows.Forms.Button();
            this.combCatogory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSale = new System.Windows.Forms.Button();
            this.combUser = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.dataGridViewSales = new System.Windows.Forms.DataGridView();
            this.ParfumId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParfumN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParfumPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeSale = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textSearchName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.combEmploye = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkUser = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkEmp = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewShearch
            // 
            this.dataGridViewShearch.AllowUserToAddRows = false;
            this.dataGridViewShearch.AllowUserToDeleteRows = false;
            this.dataGridViewShearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewShearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShearch.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewShearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShearch.Location = new System.Drawing.Point(4, 107);
            this.dataGridViewShearch.Name = "dataGridViewShearch";
            this.dataGridViewShearch.ReadOnly = true;
            this.dataGridViewShearch.RowHeadersWidth = 51;
            this.dataGridViewShearch.RowTemplate.Height = 24;
            this.dataGridViewShearch.Size = new System.Drawing.Size(1018, 237);
            this.dataGridViewShearch.TabIndex = 37;
            this.dataGridViewShearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShearch_CellDoubleClick);
            // 
            // textcatogory
            // 
            this.textcatogory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textcatogory.AutoSize = true;
            this.textcatogory.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.textcatogory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textcatogory.Location = new System.Drawing.Point(586, 64);
            this.textcatogory.Name = "textcatogory";
            this.textcatogory.Size = new System.Drawing.Size(133, 31);
            this.textcatogory.TabIndex = 36;
            this.textcatogory.Text = "Catogory";
            // 
            // btn_allparfums
            // 
            this.btn_allparfums.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_allparfums.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_allparfums.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_allparfums.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_allparfums.Location = new System.Drawing.Point(908, 64);
            this.btn_allparfums.Name = "btn_allparfums";
            this.btn_allparfums.Size = new System.Drawing.Size(110, 37);
            this.btn_allparfums.TabIndex = 35;
            this.btn_allparfums.Text = "All Parfums";
            this.btn_allparfums.UseVisualStyleBackColor = false;
            this.btn_allparfums.Click += new System.EventHandler(this.btn_allparfums_Click);
            // 
            // combCatogory
            // 
            this.combCatogory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combCatogory.BackColor = System.Drawing.SystemColors.HighlightText;
            this.combCatogory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.combCatogory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.combCatogory.FormattingEnabled = true;
            this.combCatogory.Location = new System.Drawing.Point(182, 71);
            this.combCatogory.Name = "combCatogory";
            this.combCatogory.Size = new System.Drawing.Size(204, 28);
            this.combCatogory.TabIndex = 34;
            this.combCatogory.SelectedIndexChanged += new System.EventHandler(this.combCatogory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(7, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 33;
            this.label1.Text = "Catogory";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(4, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 31);
            this.label2.TabIndex = 42;
            this.label2.Text = "User:";
            // 
            // btnSale
            // 
            this.btnSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSale.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSale.Location = new System.Drawing.Point(134, 10);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(110, 37);
            this.btnSale.TabIndex = 44;
            this.btnSale.Text = "Sale";
            this.btnSale.UseVisualStyleBackColor = false;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // combUser
            // 
            this.combUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combUser.BackColor = System.Drawing.SystemColors.HighlightText;
            this.combUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.combUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.combUser.FormattingEnabled = true;
            this.combUser.Location = new System.Drawing.Point(87, 12);
            this.combUser.Name = "combUser";
            this.combUser.Size = new System.Drawing.Size(134, 28);
            this.combUser.TabIndex = 45;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(7, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 37);
            this.btnClear.TabIndex = 46;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dataGridViewSales
            // 
            this.dataGridViewSales.AllowUserToAddRows = false;
            this.dataGridViewSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSales.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParfumId,
            this.PriceId,
            this.ParfumN,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.ParfumPrice,
            this.BaseCount,
            this.SaleCount});
            this.dataGridViewSales.Location = new System.Drawing.Point(3, 48);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.RowHeadersWidth = 51;
            this.dataGridViewSales.RowTemplate.Height = 24;
            this.dataGridViewSales.Size = new System.Drawing.Size(1022, 210);
            this.dataGridViewSales.TabIndex = 47;
            this.dataGridViewSales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSales_CellDoubleClick);
            // 
            // ParfumId
            // 
            this.ParfumId.HeaderText = "Id";
            this.ParfumId.MinimumWidth = 6;
            this.ParfumId.Name = "ParfumId";
            // 
            // PriceId
            // 
            this.PriceId.HeaderText = "PriceId";
            this.PriceId.MinimumWidth = 6;
            this.PriceId.Name = "PriceId";
            // 
            // ParfumN
            // 
            this.ParfumN.HeaderText = "Name";
            this.ParfumN.MinimumWidth = 6;
            this.ParfumN.Name = "ParfumN";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Description";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Brend";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Gender";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Density";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Size";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // ParfumPrice
            // 
            this.ParfumPrice.HeaderText = "Price";
            this.ParfumPrice.MinimumWidth = 6;
            this.ParfumPrice.Name = "ParfumPrice";
            // 
            // BaseCount
            // 
            this.BaseCount.HeaderText = "Base Count";
            this.BaseCount.MinimumWidth = 6;
            this.BaseCount.Name = "BaseCount";
            // 
            // SaleCount
            // 
            this.SaleCount.HeaderText = "SaleCount";
            this.SaleCount.MinimumWidth = 6;
            this.SaleCount.Name = "SaleCount";
            // 
            // dateTimeSale
            // 
            this.dateTimeSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimeSale.Location = new System.Drawing.Point(3, 12);
            this.dateTimeSale.Name = "dateTimeSale";
            this.dateTimeSale.Size = new System.Drawing.Size(279, 26);
            this.dateTimeSale.TabIndex = 54;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(908, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 37);
            this.btnSearch.TabIndex = 57;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textSearchName
            // 
            this.textSearchName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSearchName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.textSearchName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textSearchName.Location = new System.Drawing.Point(286, 11);
            this.textSearchName.Name = "textSearchName";
            this.textSearchName.Size = new System.Drawing.Size(517, 28);
            this.textSearchName.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(9, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 37);
            this.label4.TabIndex = 55;
            this.label4.Text = "Search Name : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textSearchName);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.combCatogory);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_allparfums);
            this.panel1.Controls.Add(this.textcatogory);
            this.panel1.Controls.Add(this.dataGridViewShearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 347);
            this.panel1.TabIndex = 58;
            // 
            // combEmploye
            // 
            this.combEmploye.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combEmploye.BackColor = System.Drawing.SystemColors.HighlightText;
            this.combEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.combEmploye.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.combEmploye.FormattingEnabled = true;
            this.combEmploye.Location = new System.Drawing.Point(148, 12);
            this.combEmploye.Name = "combEmploye";
            this.combEmploye.Size = new System.Drawing.Size(108, 28);
            this.combEmploye.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(7, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 31);
            this.label5.TabIndex = 59;
            this.label5.Text = "Emoloye:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.checkUser);
            this.panel2.Controls.Add(this.combUser);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 33);
            this.panel2.TabIndex = 58;
            // 
            // checkUser
            // 
            this.checkUser.AutoSize = true;
            this.checkUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.checkUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkUser.Location = new System.Drawing.Point(9, 0);
            this.checkUser.Name = "checkUser";
            this.checkUser.Size = new System.Drawing.Size(63, 21);
            this.checkUser.TabIndex = 58;
            this.checkUser.Text = "Using";
            this.checkUser.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.checkEmp);
            this.panel3.Controls.Add(this.combEmploye);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(231, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 33);
            this.panel3.TabIndex = 59;
            // 
            // checkEmp
            // 
            this.checkEmp.AutoSize = true;
            this.checkEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.checkEmp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkEmp.Location = new System.Drawing.Point(12, -3);
            this.checkEmp.Name = "checkEmp";
            this.checkEmp.Size = new System.Drawing.Size(63, 21);
            this.checkEmp.TabIndex = 59;
            this.checkEmp.Text = "Using";
            this.checkEmp.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewSales, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 347);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.38035F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.61964F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1028, 261);
            this.tableLayoutPanel1.TabIndex = 59;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.44149F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.55851F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 283F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247F));
            this.tableLayoutPanel2.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1022, 39);
            this.tableLayoutPanel2.TabIndex = 48;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Controls.Add(this.btnSale);
            this.panel4.Location = new System.Drawing.Point(777, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(242, 33);
            this.panel4.TabIndex = 60;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.dateTimeSale);
            this.panel5.Location = new System.Drawing.Point(494, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(277, 33);
            this.panel5.TabIndex = 61;
            // 
            // UserSaleMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1028, 608);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "UserSaleMonitor";
            this.Text = "User Sale Monitor";
            this.Load += new System.EventHandler(this.UserSaleMonitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShearch;
        private System.Windows.Forms.Label textcatogory;
        private System.Windows.Forms.Button btn_allparfums;
        private System.Windows.Forms.ComboBox combCatogory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.ComboBox combUser;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dataGridViewSales;
        private System.Windows.Forms.DateTimePicker dateTimeSale;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textSearchName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox combEmploye;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox checkUser;
        private System.Windows.Forms.CheckBox checkEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParfumId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParfumN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParfumPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleCount;
    }
}