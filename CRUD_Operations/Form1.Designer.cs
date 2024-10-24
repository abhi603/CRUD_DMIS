namespace CRUD_Operations
{
    partial class Form1
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
            label1 = new Label();
            txtStudentName = new TextBox();
            button1 = new Button();
            StudentRecordDataGridView = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFatherName = new TextBox();
            txtRollNumber = new TextBox();
            txtMobile = new TextBox();
            txtAddress = new TextBox();
            ((System.ComponentModel.ISupportInitialize)StudentRecordDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(122, 79);
            label1.Name = "label1";
            label1.Size = new Size(108, 32);
            label1.TabIndex = 0;
            label1.Text = "S.Name:";
            // 
            // txtStudentName
            // 
            txtStudentName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtStudentName.Location = new Point(239, 79);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(287, 39);
            txtStudentName.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(71, 431);
            button1.Name = "button1";
            button1.Size = new Size(225, 60);
            button1.TabIndex = 2;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // StudentRecordDataGridView
            // 
            StudentRecordDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StudentRecordDataGridView.BackgroundColor = SystemColors.ControlLight;
            StudentRecordDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentRecordDataGridView.Location = new Point(27, 511);
            StudentRecordDataGridView.Name = "StudentRecordDataGridView";
            StudentRecordDataGridView.RowHeadersWidth = 51;
            StudentRecordDataGridView.RowTemplate.Height = 29;
            StudentRecordDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StudentRecordDataGridView.Size = new Size(1266, 315);
            StudentRecordDataGridView.TabIndex = 3;
            StudentRecordDataGridView.CellClick += StudentRecordDataGridView_CellClick;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(387, 431);
            button2.Name = "button2";
            button2.Size = new Size(225, 60);
            button2.TabIndex = 4;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(703, 431);
            button3.Name = "button3";
            button3.Size = new Size(225, 60);
            button3.TabIndex = 5;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(1019, 431);
            button4.Name = "button4";
            button4.Size = new Size(225, 60);
            button4.TabIndex = 6;
            button4.Text = "Reset";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(795, 86);
            label2.Name = "label2";
            label2.Size = new Size(105, 32);
            label2.TabIndex = 7;
            label2.Text = "F.Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(122, 184);
            label3.Name = "label3";
            label3.Size = new Size(106, 32);
            label3.TabIndex = 8;
            label3.Text = "Roll No.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(795, 184);
            label4.Name = "label4";
            label4.Size = new Size(101, 32);
            label4.TabIndex = 9;
            label4.Text = "Mobile:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(122, 296);
            label5.Name = "label5";
            label5.Size = new Size(113, 32);
            label5.TabIndex = 10;
            label5.Text = "Address:";
            // 
            // txtFatherName
            // 
            txtFatherName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtFatherName.Location = new Point(932, 86);
            txtFatherName.Name = "txtFatherName";
            txtFatherName.Size = new Size(287, 39);
            txtFatherName.TabIndex = 11;
            // 
            // txtRollNumber
            // 
            txtRollNumber.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtRollNumber.Location = new Point(239, 181);
            txtRollNumber.Name = "txtRollNumber";
            txtRollNumber.Size = new Size(287, 39);
            txtRollNumber.TabIndex = 12;
            // 
            // txtMobile
            // 
            txtMobile.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtMobile.Location = new Point(932, 184);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(287, 39);
            txtMobile.TabIndex = 13;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtAddress.Location = new Point(239, 296);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(287, 39);
            txtAddress.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1341, 742);
            Controls.Add(txtAddress);
            Controls.Add(txtMobile);
            Controls.Add(txtRollNumber);
            Controls.Add(txtFatherName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(StudentRecordDataGridView);
            Controls.Add(button1);
            Controls.Add(txtStudentName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student information";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)StudentRecordDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtStudentName;
        private Button button1;
        private DataGridView StudentRecordDataGridView;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtFatherName;
        private TextBox txtRollNumber;
        private TextBox txtMobile;
        private TextBox txtAddress;
    }
}