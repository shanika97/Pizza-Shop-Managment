namespace Pizza_Shop_Managment
{
    partial class UserOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBoxTake = new System.Windows.Forms.GroupBox();
            this.rdbDelivery = new System.Windows.Forms.RadioButton();
            this.rdbDine = new System.Windows.Forms.RadioButton();
            this.rdbTake = new System.Windows.Forms.RadioButton();
            this.groupBoxSize = new System.Windows.Forms.GroupBox();
            this.rdbLarge = new System.Windows.Forms.RadioButton();
            this.rdbMedium = new System.Windows.Forms.RadioButton();
            this.rdbsmall = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chksosages = new System.Windows.Forms.CheckBox();
            this.chkOnions = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstBoxchoice = new System.Windows.Forms.ListBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsubmitorder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcontac = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.btnItems = new System.Windows.Forms.Button();
            this.labelstatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBoxTake.SuspendLayout();
            this.groupBoxSize.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.groupBoxTake);
            this.panel1.Controls.Add(this.groupBoxSize);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lstBoxchoice);
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.btnsubmitorder);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtcontac);
            this.panel1.Controls.Add(this.txtdate);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtOrderId);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbCategory);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(124, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 568);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(428, 461);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 51);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBoxTake
            // 
            this.groupBoxTake.Controls.Add(this.rdbDelivery);
            this.groupBoxTake.Controls.Add(this.rdbDine);
            this.groupBoxTake.Controls.Add(this.rdbTake);
            this.groupBoxTake.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxTake.Location = new System.Drawing.Point(362, 297);
            this.groupBoxTake.Name = "groupBoxTake";
            this.groupBoxTake.Size = new System.Drawing.Size(244, 117);
            this.groupBoxTake.TabIndex = 24;
            this.groupBoxTake.TabStop = false;
            this.groupBoxTake.Text = "Taken Type";
            // 
            // rdbDelivery
            // 
            this.rdbDelivery.AutoSize = true;
            this.rdbDelivery.Location = new System.Drawing.Point(15, 74);
            this.rdbDelivery.Name = "rdbDelivery";
            this.rdbDelivery.Size = new System.Drawing.Size(70, 20);
            this.rdbDelivery.TabIndex = 2;
            this.rdbDelivery.TabStop = true;
            this.rdbDelivery.Text = "Delivery";
            this.rdbDelivery.UseVisualStyleBackColor = true;
            this.rdbDelivery.CheckedChanged += new System.EventHandler(this.rdbDelivery_CheckedChanged);
            // 
            // rdbDine
            // 
            this.rdbDine.AutoSize = true;
            this.rdbDine.Location = new System.Drawing.Point(15, 48);
            this.rdbDine.Name = "rdbDine";
            this.rdbDine.Size = new System.Drawing.Size(65, 20);
            this.rdbDine.TabIndex = 1;
            this.rdbDine.TabStop = true;
            this.rdbDine.Text = "Dine-in";
            this.rdbDine.UseVisualStyleBackColor = true;
            this.rdbDine.CheckedChanged += new System.EventHandler(this.rdbDine_CheckedChanged);
            // 
            // rdbTake
            // 
            this.rdbTake.AutoSize = true;
            this.rdbTake.Location = new System.Drawing.Point(15, 22);
            this.rdbTake.Name = "rdbTake";
            this.rdbTake.Size = new System.Drawing.Size(69, 20);
            this.rdbTake.TabIndex = 0;
            this.rdbTake.TabStop = true;
            this.rdbTake.Text = "Take-In";
            this.rdbTake.UseVisualStyleBackColor = true;
            this.rdbTake.CheckedChanged += new System.EventHandler(this.rdbTake_CheckedChanged);
            // 
            // groupBoxSize
            // 
            this.groupBoxSize.Controls.Add(this.rdbLarge);
            this.groupBoxSize.Controls.Add(this.rdbMedium);
            this.groupBoxSize.Controls.Add(this.rdbsmall);
            this.groupBoxSize.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSize.Location = new System.Drawing.Point(362, 128);
            this.groupBoxSize.Name = "groupBoxSize";
            this.groupBoxSize.Size = new System.Drawing.Size(244, 117);
            this.groupBoxSize.TabIndex = 23;
            this.groupBoxSize.TabStop = false;
            this.groupBoxSize.Text = "Size";
            // 
            // rdbLarge
            // 
            this.rdbLarge.AutoSize = true;
            this.rdbLarge.Location = new System.Drawing.Point(15, 74);
            this.rdbLarge.Name = "rdbLarge";
            this.rdbLarge.Size = new System.Drawing.Size(121, 20);
            this.rdbLarge.TabIndex = 2;
            this.rdbLarge.TabStop = true;
            this.rdbLarge.Text = "Large ( Rs.2200)";
            this.rdbLarge.UseVisualStyleBackColor = true;
            this.rdbLarge.CheckedChanged += new System.EventHandler(this.rdbLarge_CheckedChanged);
            // 
            // rdbMedium
            // 
            this.rdbMedium.AutoSize = true;
            this.rdbMedium.Location = new System.Drawing.Point(15, 48);
            this.rdbMedium.Name = "rdbMedium";
            this.rdbMedium.Size = new System.Drawing.Size(138, 20);
            this.rdbMedium.TabIndex = 1;
            this.rdbMedium.TabStop = true;
            this.rdbMedium.Text = "Medium ( Rs. 1850)";
            this.rdbMedium.UseVisualStyleBackColor = true;
            this.rdbMedium.CheckedChanged += new System.EventHandler(this.rdbMedium_CheckedChanged);
            // 
            // rdbsmall
            // 
            this.rdbsmall.AutoSize = true;
            this.rdbsmall.Location = new System.Drawing.Point(15, 22);
            this.rdbsmall.Name = "rdbsmall";
            this.rdbsmall.Size = new System.Drawing.Size(114, 20);
            this.rdbsmall.TabIndex = 0;
            this.rdbsmall.TabStop = true;
            this.rdbsmall.Text = "Small ( Rs.850)";
            this.rdbsmall.UseVisualStyleBackColor = true;
            this.rdbsmall.CheckedChanged += new System.EventHandler(this.rdbsmall_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chksosages);
            this.groupBox1.Controls.Add(this.chkOnions);
            this.groupBox1.Controls.Add(this.chkMushrooms);
            this.groupBox1.Controls.Add(this.chkCheese);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(28, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 90);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toppings";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chksosages
            // 
            this.chksosages.AutoSize = true;
            this.chksosages.Location = new System.Drawing.Point(138, 52);
            this.chksosages.Name = "chksosages";
            this.chksosages.Size = new System.Drawing.Size(107, 20);
            this.chksosages.TabIndex = 3;
            this.chksosages.Text = "Extra Sosages";
            this.chksosages.UseVisualStyleBackColor = true;
            // 
            // chkOnions
            // 
            this.chkOnions.AutoSize = true;
            this.chkOnions.Location = new System.Drawing.Point(10, 52);
            this.chkOnions.Name = "chkOnions";
            this.chkOnions.Size = new System.Drawing.Size(65, 20);
            this.chkOnions.TabIndex = 2;
            this.chkOnions.Text = "Onions";
            this.chkOnions.UseVisualStyleBackColor = true;
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(138, 26);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(92, 20);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Text = "Muchrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.Location = new System.Drawing.Point(10, 26);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(101, 20);
            this.chkCheese.TabIndex = 0;
            this.chkCheese.Text = "Extra Cheese";
            this.chkCheese.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(28, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Choice";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(28, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Food Categories";
            // 
            // lstBoxchoice
            // 
            this.lstBoxchoice.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstBoxchoice.FormattingEnabled = true;
            this.lstBoxchoice.ItemHeight = 18;
            this.lstBoxchoice.Location = new System.Drawing.Point(144, 201);
            this.lstBoxchoice.Name = "lstBoxchoice";
            this.lstBoxchoice.Size = new System.Drawing.Size(150, 94);
            this.lstBoxchoice.TabIndex = 18;
            this.lstBoxchoice.SelectedIndexChanged += new System.EventHandler(this.lstBoxchoice_SelectedIndexChanged);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.IndianRed;
            this.btnclear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclear.Location = new System.Drawing.Point(47, 461);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(107, 51);
            this.btnclear.TabIndex = 17;
            this.btnclear.Text = "Order Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsubmitorder
            // 
            this.btnsubmitorder.BackColor = System.Drawing.Color.IndianRed;
            this.btnsubmitorder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsubmitorder.Location = new System.Drawing.Point(236, 461);
            this.btnsubmitorder.Name = "btnsubmitorder";
            this.btnsubmitorder.Size = new System.Drawing.Size(107, 51);
            this.btnsubmitorder.TabIndex = 9;
            this.btnsubmitorder.Text = "Submit Order";
            this.btnsubmitorder.UseVisualStyleBackColor = false;
            this.btnsubmitorder.Click += new System.EventHandler(this.btnsubmitorder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(409, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Contac*";
            // 
            // txtcontac
            // 
            this.txtcontac.Location = new System.Drawing.Point(479, 68);
            this.txtcontac.Name = "txtcontac";
            this.txtcontac.Size = new System.Drawing.Size(137, 27);
            this.txtcontac.TabIndex = 15;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(479, 26);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(137, 27);
            this.txtdate.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(144, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 27);
            this.txtName.TabIndex = 13;
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(144, 23);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(150, 27);
            this.txtOrderId.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(409, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(28, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Order  ID*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(28, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name*";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Classic",
            "Signature",
            "Favourite",
            "Supreme"});
            this.cmbCategory.Location = new System.Drawing.Point(144, 128);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(150, 29);
            this.cmbCategory.TabIndex = 0;
            this.cmbCategory.Text = "Category";
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(760, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(12, 627);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(380, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Place Order";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblstatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblstatus.Location = new System.Drawing.Point(533, 635);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(0, 18);
            this.lblstatus.TabIndex = 21;
            // 
            // btnItems
            // 
            this.btnItems.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnItems.Location = new System.Drawing.Point(12, 59);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(75, 23);
            this.btnItems.TabIndex = 6;
            this.btnItems.Text = "Items";
            this.btnItems.UseVisualStyleBackColor = true;
            // 
            // labelstatus
            // 
            this.labelstatus.AutoSize = true;
            this.labelstatus.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelstatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelstatus.Location = new System.Drawing.Point(517, 635);
            this.labelstatus.Name = "labelstatus";
            this.labelstatus.Size = new System.Drawing.Size(0, 18);
            this.labelstatus.TabIndex = 26;
            this.labelstatus.Click += new System.EventHandler(this.labelstatus_Click);
            // 
            // UserOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(857, 662);
            this.Controls.Add(this.labelstatus);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "UserOrder";
            this.Text = "UserOrder";
            this.Load += new System.EventHandler(this.UserOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxTake.ResumeLayout(false);
            this.groupBoxTake.PerformLayout();
            this.groupBoxSize.ResumeLayout(false);
            this.groupBoxSize.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Button btnback;
        private ComboBox cmbCategory;
        private Label label1;
        private Label label8;
        private Label label7;
        private ListBox lstBoxchoice;
        private Button btnclear;
        private Button btnsubmitorder;
        private Label label6;
        private TextBox txtcontac;
        private TextBox txtdate;
        private TextBox txtName;
        private TextBox txtOrderId;
        private Label label5;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBoxSize;
        private CheckBox chksosages;
        private CheckBox chkOnions;
        private CheckBox chkMushrooms;
        private CheckBox chkCheese;
        private Button btnExit;
        private GroupBox groupBoxTake;
        private RadioButton rdbDelivery;
        private RadioButton rdbDine;
        private RadioButton rdbTake;
        private RadioButton rdbLarge;
        private RadioButton rdbMedium;
        private RadioButton rdbsmall;
        private Label lblstatus;
        private Button btnItems;
        private Label labelstatus;
    }
}