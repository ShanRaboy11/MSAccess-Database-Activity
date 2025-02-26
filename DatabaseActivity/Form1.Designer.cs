namespace DatabaseActivity
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dgvStudentInfo = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            insertToolStripMenuItem = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            btnConnect = new Button();
            btnLoad = new Button();
            btnUpdate = new Button();
            menuStrip1 = new MenuStrip();
            connectionTestToolStripMenuItem = new ToolStripMenuItem();
            loadFileToolStripMenuItem = new ToolStripMenuItem();
            tbxID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbxLname = new TextBox();
            label3 = new Label();
            tbxFname = new TextBox();
            btnDelete = new Button();
            btnInsert = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvStudentInfo).BeginInit();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStudentInfo
            // 
            dgvStudentInfo.BackgroundColor = Color.FromArgb(248, 230, 189);
            dgvStudentInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentInfo.ContextMenuStrip = contextMenuStrip1;
            dgvStudentInfo.Location = new Point(23, 46);
            dgvStudentInfo.Name = "dgvStudentInfo";
            dgvStudentInfo.ReadOnly = true;
            dgvStudentInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudentInfo.Size = new Size(671, 497);
            dgvStudentInfo.TabIndex = 0;
            dgvStudentInfo.CellClick += dgvStudentInfo_CellClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 10F);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { insertToolStripMenuItem, updateToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(124, 76);
            // 
            // insertToolStripMenuItem
            // 
            insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            insertToolStripMenuItem.Size = new Size(123, 24);
            insertToolStripMenuItem.Text = "Insert";
            insertToolStripMenuItem.Click += btnInsert_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(123, 24);
            updateToolStripMenuItem.Text = "Update";
            updateToolStripMenuItem.Click += btnUpdate_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(123, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += btnDelete_Click;
            // 
            // btnConnect
            // 
            btnConnect.Font = new Font("Segoe UI", 11F);
            btnConnect.Location = new Point(14, 15);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(134, 26);
            btnConnect.TabIndex = 1;
            btnConnect.Text = "Connection Test";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 11F);
            btnLoad.Location = new Point(873, 479);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(113, 26);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load File";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 11F);
            btnUpdate.Location = new Point(821, 213);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(78, 26);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 11F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { connectionTestToolStripMenuItem, loadFileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1024, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // connectionTestToolStripMenuItem
            // 
            connectionTestToolStripMenuItem.Name = "connectionTestToolStripMenuItem";
            connectionTestToolStripMenuItem.Size = new Size(130, 24);
            connectionTestToolStripMenuItem.Text = "Connection Test ";
            connectionTestToolStripMenuItem.Click += btnConnect_Click;
            // 
            // loadFileToolStripMenuItem
            // 
            loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            loadFileToolStripMenuItem.Size = new Size(81, 24);
            loadFileToolStripMenuItem.Text = "Load File";
            loadFileToolStripMenuItem.Click += btnLoad_Click;
            // 
            // tbxID
            // 
            tbxID.BorderStyle = BorderStyle.None;
            tbxID.Font = new Font("Segoe UI", 11F);
            tbxID.Location = new Point(814, 91);
            tbxID.Name = "tbxID";
            tbxID.Size = new Size(174, 20);
            tbxID.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(157, 214, 231);
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(13, 13);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 6;
            label1.Text = "Student ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(157, 214, 231);
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(11, 52);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 7;
            label2.Text = "Last Name:";
            // 
            // tbxLname
            // 
            tbxLname.BorderStyle = BorderStyle.None;
            tbxLname.Font = new Font("Segoe UI", 11F);
            tbxLname.Location = new Point(814, 130);
            tbxLname.Name = "tbxLname";
            tbxLname.Size = new Size(174, 20);
            tbxLname.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(157, 214, 231);
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(13, 92);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 9;
            label3.Text = "First Name:";
            // 
            // tbxFname
            // 
            tbxFname.BorderStyle = BorderStyle.None;
            tbxFname.Font = new Font("Segoe UI", 11F);
            tbxFname.Location = new Point(814, 169);
            tbxFname.Name = "tbxFname";
            tbxFname.Size = new Size(174, 20);
            tbxFname.TabIndex = 10;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 11F);
            btnDelete.Location = new Point(907, 213);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 26);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI", 11F);
            btnInsert.Location = new Point(734, 213);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(78, 26);
            btnInsert.TabIndex = 12;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(157, 214, 231);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(715, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 174);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(157, 214, 231);
            panel2.Controls.Add(btnConnect);
            panel2.Location = new Point(715, 464);
            panel2.Name = "panel2";
            panel2.Size = new Size(287, 56);
            panel2.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(190, 229, 176);
            ClientSize = new Size(1024, 567);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(btnInsert);
            Controls.Add(btnDelete);
            Controls.Add(tbxFname);
            Controls.Add(tbxLname);
            Controls.Add(tbxID);
            Controls.Add(btnUpdate);
            Controls.Add(btnLoad);
            Controls.Add(dgvStudentInfo);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Database";
            ((System.ComponentModel.ISupportInitialize)dgvStudentInfo).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudentInfo;
        private Button btnConnect;
        private Button btnLoad;
        private Button btnUpdate;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem connectionTestToolStripMenuItem;
        private TextBox tbxID;
        private Label label1;
        private Label label2;
        private TextBox tbxLname;
        private Label label3;
        private TextBox tbxFname;
        private ToolStripMenuItem loadFileToolStripMenuItem;
        private Button btnDelete;
        private Button btnInsert;
        private Panel panel1;
        private Panel panel2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem insertToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}
