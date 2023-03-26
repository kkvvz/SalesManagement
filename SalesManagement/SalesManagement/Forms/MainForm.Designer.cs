namespace SalesManagement
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.storageListView = new System.Windows.Forms.ListView();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.removePurchaseButton = new System.Windows.Forms.Button();
            this.addPurchaseButton = new System.Windows.Forms.Button();
            this.purchasesListView = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.removeSaleButton = new System.Windows.Forms.Button();
            this.addSaleButton = new System.Windows.Forms.Button();
            this.salesListView = new System.Windows.Forms.ListView();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // storageListView
            // 
            this.storageListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.storageListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.storageListView.FullRowSelect = true;
            this.storageListView.GridLines = true;
            this.storageListView.Location = new System.Drawing.Point(7, 8);
            this.storageListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.storageListView.Name = "storageListView";
            this.storageListView.Size = new System.Drawing.Size(832, 539);
            this.storageListView.TabIndex = 0;
            this.storageListView.UseCompatibleStateImageBehavior = false;
            this.storageListView.View = System.Windows.Forms.View.Details;
            this.storageListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.storageListView_MouseDoubleClick);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Id";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Наименование";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Описание";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Стоимость";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Количество";
            this.columnHeader4.Width = 100;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(853, 593);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.removePurchaseButton);
            this.tabPage3.Controls.Add(this.addPurchaseButton);
            this.tabPage3.Controls.Add(this.purchasesListView);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(845, 560);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Закупки";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // removePurchaseButton
            // 
            this.removePurchaseButton.Location = new System.Drawing.Point(736, 49);
            this.removePurchaseButton.Name = "removePurchaseButton";
            this.removePurchaseButton.Size = new System.Drawing.Size(106, 35);
            this.removePurchaseButton.TabIndex = 2;
            this.removePurchaseButton.Text = "Удалить";
            this.removePurchaseButton.UseVisualStyleBackColor = true;
            this.removePurchaseButton.Click += new System.EventHandler(this.removePurchaseButton_Click);
            // 
            // addPurchaseButton
            // 
            this.addPurchaseButton.Location = new System.Drawing.Point(736, 8);
            this.addPurchaseButton.Name = "addPurchaseButton";
            this.addPurchaseButton.Size = new System.Drawing.Size(106, 35);
            this.addPurchaseButton.TabIndex = 1;
            this.addPurchaseButton.Text = "Добавить";
            this.addPurchaseButton.UseVisualStyleBackColor = true;
            this.addPurchaseButton.Click += new System.EventHandler(this.addPurchaseButton_Click);
            // 
            // purchasesListView
            // 
            this.purchasesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.purchasesListView.FullRowSelect = true;
            this.purchasesListView.GridLines = true;
            this.purchasesListView.Location = new System.Drawing.Point(7, 8);
            this.purchasesListView.Name = "purchasesListView";
            this.purchasesListView.Size = new System.Drawing.Size(723, 549);
            this.purchasesListView.TabIndex = 0;
            this.purchasesListView.UseCompatibleStateImageBehavior = false;
            this.purchasesListView.View = System.Windows.Forms.View.Details;
            this.purchasesListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.purchasesListView_MouseDoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Номер накладной";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Поставщик";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Дата закупки";
            this.columnHeader7.Width = 160;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.storageListView);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(845, 560);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Склад";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.removeSaleButton);
            this.tabPage2.Controls.Add(this.addSaleButton);
            this.tabPage2.Controls.Add(this.salesListView);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(845, 560);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Продажи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // removeSaleButton
            // 
            this.removeSaleButton.Location = new System.Drawing.Point(733, 49);
            this.removeSaleButton.Name = "removeSaleButton";
            this.removeSaleButton.Size = new System.Drawing.Size(106, 35);
            this.removeSaleButton.TabIndex = 4;
            this.removeSaleButton.Text = "Удалить";
            this.removeSaleButton.UseVisualStyleBackColor = true;
            this.removeSaleButton.Click += new System.EventHandler(this.removeSaleButton_Click);
            // 
            // addSaleButton
            // 
            this.addSaleButton.Location = new System.Drawing.Point(733, 7);
            this.addSaleButton.Name = "addSaleButton";
            this.addSaleButton.Size = new System.Drawing.Size(106, 35);
            this.addSaleButton.TabIndex = 3;
            this.addSaleButton.Text = "Добавить";
            this.addSaleButton.UseVisualStyleBackColor = true;
            this.addSaleButton.Click += new System.EventHandler(this.addSaleButton_Click);
            // 
            // salesListView
            // 
            this.salesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.salesListView.FullRowSelect = true;
            this.salesListView.GridLines = true;
            this.salesListView.Location = new System.Drawing.Point(5, 8);
            this.salesListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.salesListView.Name = "salesListView";
            this.salesListView.Size = new System.Drawing.Size(722, 547);
            this.salesListView.TabIndex = 0;
            this.salesListView.UseCompatibleStateImageBehavior = false;
            this.salesListView.View = System.Windows.Forms.View.Details;
            this.salesListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.salesListView_MouseDoubleClick);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Id";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Дата продажи";
            this.columnHeader10.Width = 160;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Сумма";
            this.columnHeader11.Width = 100;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 605);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Учётный помощник";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView storageListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListView salesListView;
        private TabPage tabPage3;
        private ListView purchasesListView;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Button removePurchaseButton;
        private Button addPurchaseButton;
        private ColumnHeader columnHeader8;
        private Button removeSaleButton;
        private Button addSaleButton;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
    }
}