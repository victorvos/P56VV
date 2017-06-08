namespace WindowsFormsApp2
{
    partial class StoreForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.storeInventoryList = new System.Windows.Forms.ListBox();
            this.StoreProductsList = new System.Windows.Forms.ListBox();
            this.storeLabelSaldo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(366, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Products";
            // 
            // storeInventoryList
            // 
            this.storeInventoryList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.storeInventoryList.FormattingEnabled = true;
            this.storeInventoryList.ItemHeight = 17;
            this.storeInventoryList.Location = new System.Drawing.Point(74, 65);
            this.storeInventoryList.Name = "storeInventoryList";
            this.storeInventoryList.Size = new System.Drawing.Size(212, 123);
            this.storeInventoryList.TabIndex = 2;
            this.storeInventoryList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // StoreProductsList
            // 
            this.StoreProductsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.StoreProductsList.FormattingEnabled = true;
            this.StoreProductsList.ItemHeight = 17;
            this.StoreProductsList.Location = new System.Drawing.Point(369, 65);
            this.StoreProductsList.Name = "StoreProductsList";
            this.StoreProductsList.Size = new System.Drawing.Size(212, 123);
            this.StoreProductsList.TabIndex = 3;
            this.StoreProductsList.SelectedIndexChanged += new System.EventHandler(this.StoreProductsList_SelectedIndexChanged);
            // 
            // storeLabelSaldo
            // 
            this.storeLabelSaldo.AutoSize = true;
            this.storeLabelSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.storeLabelSaldo.Location = new System.Drawing.Point(71, 214);
            this.storeLabelSaldo.Name = "storeLabelSaldo";
            this.storeLabelSaldo.Size = new System.Drawing.Size(121, 24);
            this.storeLabelSaldo.TabIndex = 4;
            this.storeLabelSaldo.Text = "Money left: € ";
            this.storeLabelSaldo.Click += new System.EventHandler(this.storeLabelSaldo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(492, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(366, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "ProductName , Amount, Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(72, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "ProductName , Amount, Price";
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(603, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.storeLabelSaldo);
            this.Controls.Add(this.StoreProductsList);
            this.Controls.Add(this.storeInventoryList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StoreForm";
            this.Text = "Store";
            this.Load += new System.EventHandler(this.Store_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox storeInventoryList;
        private System.Windows.Forms.ListBox StoreProductsList;
        private System.Windows.Forms.Label storeLabelSaldo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}