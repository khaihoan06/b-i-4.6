namespace bài_4._6
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
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.GroupBox groupBoxInputs;
        private System.Windows.Forms.Button btnChooseAvatar;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;

        private void InitializeComponent()
        {
            dgvStudents = new DataGridView();
            groupBoxInputs = new GroupBox();
            btnChooseAvatar = new Button();
            pbAvatar = new PictureBox();
            cmbGender = new ComboBox();
            txtAge = new TextBox();
            txtFullName = new TextBox();
            txtStudentId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBoxActions = new GroupBox();
            btnExportCsv = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            groupBoxInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            groupBoxActions.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(12, 12);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 62;
            dgvStudents.RowTemplate.Height = 25;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(480, 426);
            dgvStudents.TabIndex = 0;
            // 
            // groupBoxInputs
            // 
            groupBoxInputs.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxInputs.Controls.Add(btnChooseAvatar);
            groupBoxInputs.Controls.Add(pbAvatar);
            groupBoxInputs.Controls.Add(cmbGender);
            groupBoxInputs.Controls.Add(txtAge);
            groupBoxInputs.Controls.Add(txtFullName);
            groupBoxInputs.Controls.Add(txtStudentId);
            groupBoxInputs.Controls.Add(label5);
            groupBoxInputs.Controls.Add(label4);
            groupBoxInputs.Controls.Add(label3);
            groupBoxInputs.Controls.Add(label2);
            groupBoxInputs.Location = new Point(642, 12);
            groupBoxInputs.Name = "groupBoxInputs";
            groupBoxInputs.Size = new Size(290, 300);
            groupBoxInputs.TabIndex = 1;
            groupBoxInputs.TabStop = false;
            groupBoxInputs.Text = "Student Details";
            // 
            // btnChooseAvatar
            // 
            btnChooseAvatar.Location = new Point(175, 236);
            btnChooseAvatar.Name = "btnChooseAvatar";
            btnChooseAvatar.Size = new Size(100, 49);
            btnChooseAvatar.TabIndex = 9;
            btnChooseAvatar.Text = "Choose Avatar";
            btnChooseAvatar.UseVisualStyleBackColor = true;
            btnChooseAvatar.Click += btnChooseAvatar_Click;
            // 
            // pbAvatar
            // 
            pbAvatar.BorderStyle = BorderStyle.FixedSingle;
            pbAvatar.Location = new Point(15, 160);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(120, 125);
            pbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pbAvatar.TabIndex = 8;
            pbAvatar.TabStop = false;
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            cmbGender.Location = new Point(100, 120);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(180, 33);
            cmbGender.TabIndex = 7;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(100, 85);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(180, 31);
            txtAge.TabIndex = 6;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(100, 50);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(180, 31);
            txtFullName.TabIndex = 5;
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(100, 20);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(180, 31);
            txtStudentId.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 124);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 3;
            label5.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 88);
            label4.Name = "label4";
            label4.Size = new Size(44, 25);
            label4.TabIndex = 2;
            label4.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 53);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 1;
            label3.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 23);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 0;
            label2.Text = "Student Id";
            // 
            // groupBoxActions
            // 
            groupBoxActions.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBoxActions.Controls.Add(btnExportCsv);
            groupBoxActions.Controls.Add(btnUpdate);
            groupBoxActions.Controls.Add(btnDelete);
            groupBoxActions.Controls.Add(btnAdd);
            groupBoxActions.Location = new Point(642, 318);
            groupBoxActions.Name = "groupBoxActions";
            groupBoxActions.Size = new Size(290, 120);
            groupBoxActions.TabIndex = 2;
            groupBoxActions.TabStop = false;
            groupBoxActions.Text = "Actions";
            // 
            // btnExportCsv
            // 
            btnExportCsv.Location = new Point(15, 80);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(260, 34);
            btnExportCsv.TabIndex = 3;
            btnExportCsv.Text = "Export CSV";
            btnExportCsv.UseVisualStyleBackColor = true;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(180, 30);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(95, 30);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(95, 30);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 30);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(15, 30);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 30);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 450);
            Controls.Add(groupBoxActions);
            Controls.Add(groupBoxInputs);
            Controls.Add(dgvStudents);
            Name = "Form1";
            Text = "Student Manager";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            groupBoxInputs.ResumeLayout(false);
            groupBoxInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            groupBoxActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
