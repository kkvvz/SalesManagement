namespace SalesManagement.Forms
{
    partial class PurchaseForm
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
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.importerTextBox = new System.Windows.Forms.TextBox();
            this.itemsListView = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.toPurchaseButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.purchaseListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.removePurchaseItemButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(12, 28);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.PlaceholderText = "Обязательно";
            this.numberTextBox.Size = new System.Drawing.Size(249, 27);
            this.numberTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер накладной:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поставщик:";
            // 
            // importerTextBox
            // 
            this.importerTextBox.Location = new System.Drawing.Point(12, 87);
            this.importerTextBox.Name = "importerTextBox";
            this.importerTextBox.PlaceholderText = "Обязательно";
            this.importerTextBox.Size = new System.Drawing.Size(249, 27);
            this.importerTextBox.TabIndex = 2;
            // 
            // itemsListView
            // 
            this.itemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2});
            this.itemsListView.FullRowSelect = true;
            this.itemsListView.GridLines = true;
            this.itemsListView.Location = new System.Drawing.Point(287, 28);
            this.itemsListView.Name = "itemsListView";
            this.itemsListView.Size = new System.Drawing.Size(371, 155);
            this.itemsListView.TabIndex = 4;
            this.itemsListView.UseCompatibleStateImageBehavior = false;
            this.itemsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Id";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Наименование";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Описание";
            this.columnHeader2.Width = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Товары:";
            // 
            // toPurchaseButton
            // 
            this.toPurchaseButton.Location = new System.Drawing.Point(287, 189);
            this.toPurchaseButton.Name = "toPurchaseButton";
            this.toPurchaseButton.Size = new System.Drawing.Size(94, 29);
            this.toPurchaseButton.TabIndex = 6;
            this.toPurchaseButton.Text = "В закупку";
            this.toPurchaseButton.UseVisualStyleBackColor = true;
            this.toPurchaseButton.Click += new System.EventHandler(this.toPurchaseButton_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(664, 28);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(106, 30);
            this.addItemButton.TabIndex = 7;
            this.addItemButton.Text = "Добавить";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Закупка:";
            // 
            // purchaseListView
            // 
            this.purchaseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader5});
            this.purchaseListView.FullRowSelect = true;
            this.purchaseListView.GridLines = true;
            this.purchaseListView.Location = new System.Drawing.Point(287, 250);
            this.purchaseListView.Name = "purchaseListView";
            this.purchaseListView.Size = new System.Drawing.Size(371, 155);
            this.purchaseListView.TabIndex = 8;
            this.purchaseListView.UseCompatibleStateImageBehavior = false;
            this.purchaseListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Наименование";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Количество";
            this.columnHeader5.Width = 100;
            // 
            // removePurchaseItemButton
            // 
            this.removePurchaseItemButton.Location = new System.Drawing.Point(664, 250);
            this.removePurchaseItemButton.Name = "removePurchaseItemButton";
            this.removePurchaseItemButton.Size = new System.Drawing.Size(106, 30);
            this.removePurchaseItemButton.TabIndex = 10;
            this.removePurchaseItemButton.Text = "Удалить";
            this.removePurchaseItemButton.UseVisualStyleBackColor = true;
            this.removePurchaseItemButton.Click += new System.EventHandler(this.removePurchaseItemButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(287, 411);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 29);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 452);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.removePurchaseItemButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.purchaseListView);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.toPurchaseButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itemsListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.importerTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PurchaseForm";
            this.Text = "Закупка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox numberTextBox;
        private Label label1;
        private Label label2;
        private TextBox importerTextBox;
        private ListView itemsListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label label3;
        private Button toPurchaseButton;
        private Button addItemButton;
        private Label label4;
        private ListView purchaseListView;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader5;
        private Button removePurchaseItemButton;
        private Button saveButton;
        private ColumnHeader columnHeader4;
    }
}