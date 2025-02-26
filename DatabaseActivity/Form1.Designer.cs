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
            dgvStudentInfo.Location = new Point(23, 58);
            dgvStudentInfo.Name = "dgvStudentInfo";
            dgvStudentInfo.ReadOnly = true;
            dgvStudentInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudentInfo.Size = new Size(671, 439);
            dgvStudentInfo.TabIndex = 0;
            dgvStudentInfo.CellClick += dgvStudentInfo_CellClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Helvetica Neue", 10.749999F);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { insertToolStripMenuItem, updateToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 92);
            // 
            // insertToolStripMenuItem
            // 
            insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            insertToolStripMenuItem.Size = new Size(180, 22);
            insertToolStripMenuItem.Text = "Insert";
            insertToolStripMenuItem.Click += btnInsert_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(180, 22);
            updateToolStripMenuItem.Text = "Update";
            updateToolStripMenuItem.Click += btnUpdate_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(180, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += btnDelete_Click;
            // 
            // btnConnect
            // 
            btnConnect.Font = new Font("Helvetica Neue", 11.9999981F);
            btnConnect.Location = new Point(13, 13);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(144, 33);
            btnConnect.TabIndex = 1;
            btnConnect.Text = "Connection Test";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Helvetica Neue", 11.9999981F);
            btnLoad.Location = new Point(169, 13);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(120, 32);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load File";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Helvetica Neue", 11.9999981F);
            btnUpdate.Location = new Point(113, 120);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(78, 32);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Helvetica Neue", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            menuStrip1.Items.AddRange(new ToolStripItem[] { connectionTestToolStripMenuItem, loadFileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1046, 26);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // connectionTestToolStripMenuItem
            // 
            connectionTestToolStripMenuItem.Name = "connectionTestToolStripMenuItem";
            connectionTestToolStripMenuItem.Size = new Size(136, 22);
            connectionTestToolStripMenuItem.Text = "Connection Test ";
            connectionTestToolStripMenuItem.Click += btnConnect_Click;
            // 
            // loadFileToolStripMenuItem
            // 
            loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            loadFileToolStripMenuItem.Size = new Size(82, 22);
            loadFileToolStripMenuItem.Text = "Load File";
            loadFileToolStripMenuItem.Click += btnLoad_Click;
            // 
            // tbxID
            // 
            tbxID.BorderStyle = BorderStyle.None;
            tbxID.Font = new Font("Helvetica Neue", 12.5F);
            tbxID.Location = new Point(112, 15);
            tbxID.Name = "tbxID";
            tbxID.Size = new Size(174, 19);
            tbxID.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(157, 214, 231);
            label1.Font = new Font("Helvetica Neue", 12.25F);
            label1.Location = new Point(13, 16);
            label1.Name = "label1";
            label1.Size = new Size(93, 19);
            label1.TabIndex = 6;
            label1.Text = "Student ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(157, 214, 231);
            label2.Font = new Font("Helvetica Neue", 12.25F);
            label2.Location = new Point(11, 51);
            label2.Name = "label2";
            label2.Size = new Size(94, 19);
            label2.TabIndex = 7;
            label2.Text = "Last Name:";
            // 
            // tbxLname
            // 
            tbxLname.BorderStyle = BorderStyle.None;
            tbxLname.Font = new Font("Helvetica Neue", 12.5F);
            tbxLname.Location = new Point(112, 50);
            tbxLname.Name = "tbxLname";
            tbxLname.Size = new Size(174, 19);
            tbxLname.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(157, 214, 231);
            label3.Font = new Font("Helvetica Neue", 12.25F);
            label3.Location = new Point(13, 86);
            label3.Name = "label3";
            label3.Size = new Size(93, 19);
            label3.TabIndex = 9;
            label3.Text = "First Name:";
            // 
            // tbxFname
            // 
            tbxFname.BorderStyle = BorderStyle.None;
            tbxFname.Font = new Font("Helvetica Neue", 12.5F);
            tbxFname.Location = new Point(113, 85);
            tbxFname.Name = "tbxFname";
            tbxFname.Size = new Size(174, 19);
            tbxFname.TabIndex = 10;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Helvetica Neue", 11.9999981F);
            btnDelete.Location = new Point(208, 120);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 32);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Helvetica Neue", 11.9999981F);
            btnInsert.Location = new Point(737, 180);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(78, 32);
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
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbxFname);
            panel1.Controls.Add(tbxID);
            panel1.Controls.Add(tbxLname);
            panel1.Location = new Point(718, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 163);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(157, 214, 231);
            panel2.Controls.Add(btnConnect);
            panel2.Controls.Add(btnLoad);
            panel2.Location = new Point(718, 438);
            panel2.Name = "panel2";
            panel2.Size = new Size(306, 59);
            panel2.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(190, 229, 176);
            ClientSize = new Size(1046, 522);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(btnInsert);
            Controls.Add(dgvStudentInfo);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Helvetica Neue", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
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
