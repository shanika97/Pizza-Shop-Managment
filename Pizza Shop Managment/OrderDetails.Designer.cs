namespace Pizza_Shop_Managment
{
    partial class OrderDetails
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.buttonclose = new System.Windows.Forms.Button();
            this.buttonUpdated = new System.Windows.Forms.Button();
            this.buttondel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(747, 365);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(334, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Place Order";
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.White;
            this.btnback.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnback.ForeColor = System.Drawing.Color.Red;
            this.btnback.Location = new System.Drawing.Point(681, 468);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(107, 35);
            this.btnback.TabIndex = 10;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnsubmitorder_Click);
            // 
            // buttonclose
            // 
            this.buttonclose.BackColor = System.Drawing.Color.White;
            this.buttonclose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonclose.ForeColor = System.Drawing.Color.Red;
            this.buttonclose.Location = new System.Drawing.Point(547, 468);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(107, 35);
            this.buttonclose.TabIndex = 11;
            this.buttonclose.Text = "Close";
            this.buttonclose.UseVisualStyleBackColor = false;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click);
            // 
            // buttonUpdated
            // 
            this.buttonUpdated.BackColor = System.Drawing.Color.White;
            this.buttonUpdated.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdated.ForeColor = System.Drawing.Color.Red;
            this.buttonUpdated.Location = new System.Drawing.Point(395, 468);
            this.buttonUpdated.Name = "buttonUpdated";
            this.buttonUpdated.Size = new System.Drawing.Size(107, 35);
            this.buttonUpdated.TabIndex = 12;
            this.buttonUpdated.Text = "Update";
            this.buttonUpdated.UseVisualStyleBackColor = false;
            // 
            // buttondel
            // 
            this.buttondel.BackColor = System.Drawing.Color.White;
            this.buttondel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttondel.ForeColor = System.Drawing.Color.Red;
            this.buttondel.Location = new System.Drawing.Point(238, 468);
            this.buttondel.Name = "buttondel";
            this.buttondel.Size = new System.Drawing.Size(107, 35);
            this.buttondel.TabIndex = 13;
            this.buttondel.Text = "Delete";
            this.buttondel.UseVisualStyleBackColor = false;
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.buttondel);
            this.Controls.Add(this.buttonUpdated);
            this.Controls.Add(this.buttonclose);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrderDetails";
            this.Text = "OrderDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button btnback;
        private Button buttonclose;
        private Button buttonUpdated;
        private Button buttondel;
    }
}