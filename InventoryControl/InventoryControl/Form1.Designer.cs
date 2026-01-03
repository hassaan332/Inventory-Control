namespace InventoryControl
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtItemID = new TextBox();
            txtSerialNo = new TextBox();
            txtDescription = new TextBox();
            txtModel = new TextBox();
            txtLocation = new TextBox();
            dtpStockDate = new DateTimePicker();
            chkAvailable = new CheckBox();
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(55, 132);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "ItemID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(58, 166);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Serial No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(55, 395);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 4;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(58, 206);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 6;
            label4.Text = "Model";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(58, 246);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 8;
            label5.Text = "Location";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(58, 292);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 10;
            label6.Text = "Stock Date";
            // 
            // txtItemID
            // 
            txtItemID.Location = new Point(158, 126);
            txtItemID.Name = "txtItemID";
            txtItemID.Size = new Size(280, 23);
            txtItemID.TabIndex = 1;
            // 
            // txtSerialNo
            // 
            txtSerialNo.Location = new Point(158, 166);
            txtSerialNo.Name = "txtSerialNo";
            txtSerialNo.Size = new Size(280, 23);
            txtSerialNo.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(55, 430);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(450, 149);
            txtDescription.TabIndex = 5;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(158, 206);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(280, 23);
            txtModel.TabIndex = 7;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(158, 243);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(280, 23);
            txtLocation.TabIndex = 9;
            // 
            // dtpStockDate
            // 
            dtpStockDate.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStockDate.CalendarMonthBackground = SystemColors.HighlightText;
            dtpStockDate.Location = new Point(158, 286);
            dtpStockDate.Name = "dtpStockDate";
            dtpStockDate.Size = new Size(280, 23);
            dtpStockDate.TabIndex = 11;
            // 
            // chkAvailable
            // 
            chkAvailable.Location = new Point(158, 348);
            chkAvailable.Name = "chkAvailable";
            chkAvailable.Size = new Size(130, 24);
            chkAvailable.TabIndex = 12;
            chkAvailable.Text = "Available";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.Location = new Point(571, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(497, 402);
            dataGridView1.TabIndex = 13;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Maroon;
            btnDelete.Location = new Point(900, 492);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 53);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.Location = new Point(710, 492);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 53);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(0, 192, 192);
            btnEdit.Location = new Point(805, 492);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 53);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(45, 38);
            label7.Name = "label7";
            label7.Size = new Size(276, 32);
            label7.TabIndex = 17;
            label7.Text = "INVENTORY CONTROL";
            // 
            // Form1
            // 
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1117, 679);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(txtItemID);
            Controls.Add(label2);
            Controls.Add(txtSerialNo);
            Controls.Add(label3);
            Controls.Add(txtDescription);
            Controls.Add(label4);
            Controls.Add(txtModel);
            Controls.Add(label5);
            Controls.Add(txtLocation);
            Controls.Add(label6);
            Controls.Add(dtpStockDate);
            Controls.Add(chkAvailable);
            Controls.Add(dataGridView1);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            ForeColor = SystemColors.Control;
            Name = "Form1";
            Text = "Inventory Control";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtItemID;
        private TextBox txtSerialNo;
        private TextBox txtDescription;
        private TextBox txtModel;
        private TextBox txtLocation;
        private DateTimePicker dtpStockDate;
        private CheckBox chkAvailable;
        private DataGridView dataGridView1;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnEdit;
        private Label label7;
    }
}
