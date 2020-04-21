namespace Assignment_2
{
    partial class Form1
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
            this.Tab = new System.Windows.Forms.TabControl();
            this.tabCoffee = new System.Windows.Forms.TabPage();
            this.addCofCharges = new System.Windows.Forms.Label();
            this.cbxCoffee = new System.Windows.Forms.CheckedListBox();
            this.cbxCofSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCoffee = new System.Windows.Forms.Label();
            this.cbxCofType = new System.Windows.Forms.ComboBox();
            this.tabTea = new System.Windows.Forms.TabPage();
            this.addTeaCharges = new System.Windows.Forms.Label();
            this.cbxTea = new System.Windows.Forms.CheckedListBox();
            this.cbxTeaSize = new System.Windows.Forms.ComboBox();
            this.lblTeaSize = new System.Windows.Forms.Label();
            this.cbxTeaType = new System.Windows.Forms.ComboBox();
            this.lblTeaType = new System.Windows.Forms.Label();
            this.tabPastries = new System.Windows.Forms.TabPage();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbChip = new System.Windows.Forms.Label();
            this.lbCarrot = new System.Windows.Forms.Label();
            this.lbBrown = new System.Windows.Forms.Label();
            this.lbPastry = new System.Windows.Forms.Label();
            this.btOrder = new System.Windows.Forms.Button();
            this.tbxTip = new System.Windows.Forms.TextBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Tab.SuspendLayout();
            this.tabCoffee.SuspendLayout();
            this.tabTea.SuspendLayout();
            this.tabPastries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.tabCoffee);
            this.Tab.Controls.Add(this.tabTea);
            this.Tab.Controls.Add(this.tabPastries);
            this.Tab.Location = new System.Drawing.Point(12, 12);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(292, 187);
            this.Tab.TabIndex = 0;
            // 
            // tabCoffee
            // 
            this.tabCoffee.BackColor = System.Drawing.Color.Transparent;
            this.tabCoffee.Controls.Add(this.addCofCharges);
            this.tabCoffee.Controls.Add(this.cbxCoffee);
            this.tabCoffee.Controls.Add(this.cbxCofSize);
            this.tabCoffee.Controls.Add(this.label1);
            this.tabCoffee.Controls.Add(this.lblCoffee);
            this.tabCoffee.Controls.Add(this.cbxCofType);
            this.tabCoffee.Location = new System.Drawing.Point(4, 22);
            this.tabCoffee.Name = "tabCoffee";
            this.tabCoffee.Padding = new System.Windows.Forms.Padding(3);
            this.tabCoffee.Size = new System.Drawing.Size(284, 161);
            this.tabCoffee.TabIndex = 0;
            this.tabCoffee.Text = "Coffee";
            // 
            // addCofCharges
            // 
            this.addCofCharges.AutoSize = true;
            this.addCofCharges.Location = new System.Drawing.Point(129, 26);
            this.addCofCharges.Name = "addCofCharges";
            this.addCofCharges.Size = new System.Drawing.Size(95, 13);
            this.addCofCharges.TabIndex = 5;
            this.addCofCharges.Text = "Additional Charges";
            // 
            // cbxCoffee
            // 
            this.cbxCoffee.FormattingEnabled = true;
            this.cbxCoffee.Items.AddRange(new object[] {
            "Cream-- $0.00",
            "Sugar-- $0.00",
            "Cinnamon-- $3.00",
            "Cocoa-- $3.00",
            "Whipped Cream-- $2.00"});
            this.cbxCoffee.Location = new System.Drawing.Point(128, 43);
            this.cbxCoffee.Name = "cbxCoffee";
            this.cbxCoffee.Size = new System.Drawing.Size(153, 79);
            this.cbxCoffee.TabIndex = 4;
            this.cbxCoffee.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // cbxCofSize
            // 
            this.cbxCofSize.FormattingEnabled = true;
            this.cbxCofSize.Items.AddRange(new object[] {
            "12 Ounces",
            "16 Ounces"});
            this.cbxCofSize.Location = new System.Drawing.Point(2, 101);
            this.cbxCofSize.Name = "cbxCofSize";
            this.cbxCofSize.Size = new System.Drawing.Size(121, 21);
            this.cbxCofSize.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coffee Size";
            // 
            // lblCoffee
            // 
            this.lblCoffee.AutoSize = true;
            this.lblCoffee.Location = new System.Drawing.Point(-1, 26);
            this.lblCoffee.Name = "lblCoffee";
            this.lblCoffee.Size = new System.Drawing.Size(82, 13);
            this.lblCoffee.TabIndex = 1;
            this.lblCoffee.Text = "Flavor of Coffee";
            this.lblCoffee.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbxCofType
            // 
            this.cbxCofType.FormattingEnabled = true;
            this.cbxCofType.Items.AddRange(new object[] {
            "Iced Coffee $3.00/ $3.50",
            "Cappuccino $3.50/ $4.00",
            "Latte $3.50/ $4.00",
            "Mocha $3.50/ $4.00"});
            this.cbxCofType.Location = new System.Drawing.Point(2, 42);
            this.cbxCofType.Name = "cbxCofType";
            this.cbxCofType.Size = new System.Drawing.Size(121, 21);
            this.cbxCofType.TabIndex = 0;
            this.cbxCofType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabTea
            // 
            this.tabTea.BackColor = System.Drawing.Color.Transparent;
            this.tabTea.Controls.Add(this.addTeaCharges);
            this.tabTea.Controls.Add(this.cbxTea);
            this.tabTea.Controls.Add(this.cbxTeaSize);
            this.tabTea.Controls.Add(this.lblTeaSize);
            this.tabTea.Controls.Add(this.cbxTeaType);
            this.tabTea.Controls.Add(this.lblTeaType);
            this.tabTea.Location = new System.Drawing.Point(4, 22);
            this.tabTea.Name = "tabTea";
            this.tabTea.Padding = new System.Windows.Forms.Padding(3);
            this.tabTea.Size = new System.Drawing.Size(284, 161);
            this.tabTea.TabIndex = 1;
            this.tabTea.Text = "Tea";
            // 
            // addTeaCharges
            // 
            this.addTeaCharges.AutoSize = true;
            this.addTeaCharges.Location = new System.Drawing.Point(135, 30);
            this.addTeaCharges.Name = "addTeaCharges";
            this.addTeaCharges.Size = new System.Drawing.Size(95, 13);
            this.addTeaCharges.TabIndex = 5;
            this.addTeaCharges.Text = "Additional Charges";
            this.addTeaCharges.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbxTea
            // 
            this.cbxTea.FormattingEnabled = true;
            this.cbxTea.Items.AddRange(new object[] {
            "Cream-- $0.00",
            "Sugar-- $0.00",
            "Caramel-- $1.00",
            "Vanilla-- $1.00"});
            this.cbxTea.Location = new System.Drawing.Point(129, 47);
            this.cbxTea.Name = "cbxTea";
            this.cbxTea.Size = new System.Drawing.Size(120, 79);
            this.cbxTea.TabIndex = 4;
            this.cbxTea.SelectedIndexChanged += new System.EventHandler(this.cbxTea_SelectedIndexChanged);
            // 
            // cbxTeaSize
            // 
            this.cbxTeaSize.FormattingEnabled = true;
            this.cbxTeaSize.Items.AddRange(new object[] {
            "12 Ounce",
            "16 Ounces"});
            this.cbxTeaSize.Location = new System.Drawing.Point(7, 103);
            this.cbxTeaSize.Name = "cbxTeaSize";
            this.cbxTeaSize.Size = new System.Drawing.Size(121, 21);
            this.cbxTeaSize.TabIndex = 3;
            // 
            // lblTeaSize
            // 
            this.lblTeaSize.AutoSize = true;
            this.lblTeaSize.Location = new System.Drawing.Point(7, 86);
            this.lblTeaSize.Name = "lblTeaSize";
            this.lblTeaSize.Size = new System.Drawing.Size(49, 13);
            this.lblTeaSize.TabIndex = 2;
            this.lblTeaSize.Text = "Tea Size";
            // 
            // cbxTeaType
            // 
            this.cbxTeaType.FormattingEnabled = true;
            this.cbxTeaType.Items.AddRange(new object[] {
            "Berry Black $3.50 / $4.00",
            "HoneyBush $3.50 / $4.00",
            "JasmineGreen  $3.50 / $4.00"});
            this.cbxTeaType.Location = new System.Drawing.Point(7, 47);
            this.cbxTeaType.Name = "cbxTeaType";
            this.cbxTeaType.Size = new System.Drawing.Size(121, 21);
            this.cbxTeaType.TabIndex = 1;
            // 
            // lblTeaType
            // 
            this.lblTeaType.AutoSize = true;
            this.lblTeaType.Location = new System.Drawing.Point(3, 30);
            this.lblTeaType.Name = "lblTeaType";
            this.lblTeaType.Size = new System.Drawing.Size(70, 13);
            this.lblTeaType.TabIndex = 0;
            this.lblTeaType.Text = "Flavor of Tea";
            // 
            // tabPastries
            // 
            this.tabPastries.BackColor = System.Drawing.Color.Transparent;
            this.tabPastries.Controls.Add(this.label2);
            this.tabPastries.Controls.Add(this.numericUpDown3);
            this.tabPastries.Controls.Add(this.numericUpDown2);
            this.tabPastries.Controls.Add(this.numericUpDown1);
            this.tabPastries.Controls.Add(this.lbChip);
            this.tabPastries.Controls.Add(this.lbCarrot);
            this.tabPastries.Controls.Add(this.lbBrown);
            this.tabPastries.Controls.Add(this.lbPastry);
            this.tabPastries.Location = new System.Drawing.Point(4, 22);
            this.tabPastries.Name = "tabPastries";
            this.tabPastries.Size = new System.Drawing.Size(284, 161);
            this.tabPastries.TabIndex = 2;
            this.tabPastries.Text = "Pastries";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(136, 34);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 6;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(136, 60);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(136, 91);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // lbChip
            // 
            this.lbChip.AutoSize = true;
            this.lbChip.Location = new System.Drawing.Point(5, 98);
            this.lbChip.Name = "lbChip";
            this.lbChip.Size = new System.Drawing.Size(100, 13);
            this.lbChip.TabIndex = 3;
            this.lbChip.Text = "Chip Cookie-- $2.50";
            // 
            // lbCarrot
            // 
            this.lbCarrot.AutoSize = true;
            this.lbCarrot.Location = new System.Drawing.Point(3, 69);
            this.lbCarrot.Name = "lbCarrot";
            this.lbCarrot.Size = new System.Drawing.Size(102, 13);
            this.lbCarrot.TabIndex = 2;
            this.lbCarrot.Text = "Carrot Cake -- $2.50";
            // 
            // lbBrown
            // 
            this.lbBrown.AutoSize = true;
            this.lbBrown.Location = new System.Drawing.Point(3, 41);
            this.lbBrown.Name = "lbBrown";
            this.lbBrown.Size = new System.Drawing.Size(84, 13);
            this.lbBrown.TabIndex = 1;
            this.lbBrown.Text = "Brownie -- $2.50";
            this.lbBrown.Click += new System.EventHandler(this.lbBrown_Click);
            // 
            // lbPastry
            // 
            this.lbPastry.AutoSize = true;
            this.lbPastry.Location = new System.Drawing.Point(0, 0);
            this.lbPastry.Name = "lbPastry";
            this.lbPastry.Size = new System.Drawing.Size(80, 13);
            this.lbPastry.TabIndex = 0;
            this.lbPastry.Text = "Flavor of Pastry";
            this.lbPastry.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // btOrder
            // 
            this.btOrder.Location = new System.Drawing.Point(197, 227);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(75, 23);
            this.btOrder.TabIndex = 1;
            this.btOrder.Text = "Place Order";
            this.btOrder.UseVisualStyleBackColor = true;
            this.btOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // tbxTip
            // 
            this.tbxTip.Location = new System.Drawing.Point(12, 229);
            this.tbxTip.Name = "tbxTip";
            this.tbxTip.Size = new System.Drawing.Size(100, 20);
            this.tbxTip.TabIndex = 2;
            this.tbxTip.Text = "0.00";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(12, 210);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(50, 13);
            this.lblTip.TabIndex = 3;
            this.lblTip.Text = "Enter Tip";
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(118, 226);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 4;
            this.btClear.Text = "Clear Order";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number of Pastry/Pastries";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 268);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.tbxTip);
            this.Controls.Add(this.btOrder);
            this.Controls.Add(this.Tab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tab.ResumeLayout(false);
            this.tabCoffee.ResumeLayout(false);
            this.tabCoffee.PerformLayout();
            this.tabTea.ResumeLayout(false);
            this.tabTea.PerformLayout();
            this.tabPastries.ResumeLayout(false);
            this.tabPastries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage tabCoffee;
        private System.Windows.Forms.TabPage tabTea;
        private System.Windows.Forms.TabPage tabPastries;
        private System.Windows.Forms.Label lblCoffee;
        private System.Windows.Forms.ComboBox cbxCofType;
        private System.Windows.Forms.Button btOrder;
        private System.Windows.Forms.ComboBox cbxCofSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTip;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label addCofCharges;
        private System.Windows.Forms.ComboBox cbxTeaSize;
        private System.Windows.Forms.Label lblTeaSize;
        private System.Windows.Forms.ComboBox cbxTeaType;
        private System.Windows.Forms.Label lblTeaType;
        private System.Windows.Forms.Label addTeaCharges;
        private System.Windows.Forms.CheckedListBox cbxTea;
        private System.Windows.Forms.CheckedListBox cbxCoffee;
        private System.Windows.Forms.Label lbPastry;
        private System.Windows.Forms.Label lbBrown;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbChip;
        private System.Windows.Forms.Label lbCarrot;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Label label2;
    }
}

