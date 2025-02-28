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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            connectionTestToolStripMenuItem = new ToolStripMenuItem();
            loadFileToolStripMenuItem = new ToolStripMenuItem();
            btnInsert = new Button();
            cmbTables = new ComboBox();
            label4 = new Label();
            tbxLname = new TextBox();
            tbxID = new TextBox();
            tbxFname = new TextBox();
            lblLastName = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            lblStudentID = new Label();
            lblFirstName = new Label();
            pnlControls = new Panel();
            pbDatabaseIcon = new PictureBox();
            tbxLastCol = new TextBox();
            lblLastCol = new Label();
            tbxYearLevel = new TextBox();
            tbxCourse = new TextBox();
            lblYearLevel = new Label();
            lblCourse = new Label();
            btnLoad = new Button();
            btnConnect = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            lblTableName = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudentInfo).BeginInit();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDatabaseIcon).BeginInit();
            panel3.SuspendLayout();
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
            dgvStudentInfo.Size = new Size(671, 506);
            dgvStudentInfo.TabIndex = 0;
            dgvStudentInfo.CellClick += dgvStudentInfo_CellClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Helvetica Neue", 10.749999F);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { insertToolStripMenuItem, updateToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(129, 70);
            // 
            // insertToolStripMenuItem
            // 
            insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            insertToolStripMenuItem.Size = new Size(128, 22);
            insertToolStripMenuItem.Text = "Insert";
            insertToolStripMenuItem.Click += btnInsert_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(128, 22);
            updateToolStripMenuItem.Text = "Update";
            updateToolStripMenuItem.Click += btnUpdate_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(128, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += btnDelete_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Helvetica Neue", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, connectionTestToolStripMenuItem, loadFileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1067, 26);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportToolStripMenuItem, openToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(43, 22);
            fileToolStripMenuItem.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(180, 22);
            exportToolStripMenuItem.Text = "Export";
            exportToolStripMenuItem.Click += ExportToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
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
            // btnInsert
            // 
            btnInsert.Font = new Font("Helvetica Neue", 11.9999981F);
            btnInsert.Location = new Point(24, 219);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(78, 32);
            btnInsert.TabIndex = 12;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // cmbTables
            // 
            cmbTables.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTables.Font = new Font("Helvetica Neue", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbTables.FormattingEnabled = true;
            cmbTables.Location = new Point(112, 15);
            cmbTables.Name = "cmbTables";
            cmbTables.Size = new Size(194, 26);
            cmbTables.TabIndex = 15;
            cmbTables.TabStop = false;
            cmbTables.SelectedIndexChanged += cmbTables_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(157, 214, 231);
            label4.Font = new Font("Helvetica Neue", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(22, 18);
            label4.Name = "label4";
            label4.Size = new Size(68, 22);
            label4.TabIndex = 12;
            label4.Text = "Table:";
            // 
            // tbxLname
            // 
            tbxLname.BorderStyle = BorderStyle.None;
            tbxLname.Font = new Font("Helvetica Neue", 12.5F);
            tbxLname.Location = new Point(127, 47);
            tbxLname.Name = "tbxLname";
            tbxLname.Size = new Size(174, 19);
            tbxLname.TabIndex = 8;
            tbxLname.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxID
            // 
            tbxID.BorderStyle = BorderStyle.None;
            tbxID.Font = new Font("Helvetica Neue", 12.5F);
            tbxID.Location = new Point(127, 12);
            tbxID.Name = "tbxID";
            tbxID.Size = new Size(174, 19);
            tbxID.TabIndex = 5;
            tbxID.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxFname
            // 
            tbxFname.BorderStyle = BorderStyle.None;
            tbxFname.Font = new Font("Helvetica Neue", 12.5F);
            tbxFname.Location = new Point(128, 82);
            tbxFname.Name = "tbxFname";
            tbxFname.Size = new Size(174, 19);
            tbxFname.TabIndex = 10;
            tbxFname.TextAlign = HorizontalAlignment.Center;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.FromArgb(157, 214, 231);
            lblLastName.Font = new Font("Helvetica Neue", 12.25F);
            lblLastName.Location = new Point(13, 47);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(94, 19);
            lblLastName.TabIndex = 7;
            lblLastName.Text = "Last Name:";
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Helvetica Neue", 11.9999981F);
            btnDelete.Location = new Point(219, 219);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 32);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Helvetica Neue", 11.9999981F);
            btnUpdate.Location = new Point(119, 219);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(78, 32);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.BackColor = Color.FromArgb(157, 214, 231);
            lblStudentID.Font = new Font("Helvetica Neue", 12.25F);
            lblStudentID.Location = new Point(13, 12);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(93, 19);
            lblStudentID.TabIndex = 6;
            lblStudentID.Text = "Student ID:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.FromArgb(157, 214, 231);
            lblFirstName.Font = new Font("Helvetica Neue", 12.25F);
            lblFirstName.Location = new Point(13, 82);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(93, 19);
            lblFirstName.TabIndex = 9;
            lblFirstName.Text = "First Name:";
            // 
            // pnlControls
            // 
            pnlControls.BackColor = Color.FromArgb(157, 214, 231);
            pnlControls.Controls.Add(pbDatabaseIcon);
            pnlControls.Controls.Add(tbxLastCol);
            pnlControls.Controls.Add(lblLastCol);
            pnlControls.Controls.Add(tbxYearLevel);
            pnlControls.Controls.Add(tbxCourse);
            pnlControls.Controls.Add(lblYearLevel);
            pnlControls.Controls.Add(lblCourse);
            pnlControls.Controls.Add(lblFirstName);
            pnlControls.Controls.Add(lblStudentID);
            pnlControls.Controls.Add(btnInsert);
            pnlControls.Controls.Add(btnUpdate);
            pnlControls.Controls.Add(btnDelete);
            pnlControls.Controls.Add(lblLastName);
            pnlControls.Controls.Add(tbxFname);
            pnlControls.Controls.Add(tbxID);
            pnlControls.Controls.Add(tbxLname);
            pnlControls.Location = new Point(718, 194);
            pnlControls.Name = "pnlControls";
            pnlControls.Size = new Size(328, 270);
            pnlControls.TabIndex = 13;
            pnlControls.Visible = false;
            // 
            // pbDatabaseIcon
            // 
            pbDatabaseIcon.Image = Properties.Resources.NY0y;
            pbDatabaseIcon.Location = new Point(0, 0);
            pbDatabaseIcon.Name = "pbDatabaseIcon";
            pbDatabaseIcon.Size = new Size(328, 251);
            pbDatabaseIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbDatabaseIcon.TabIndex = 20;
            pbDatabaseIcon.TabStop = false;
            // 
            // tbxLastCol
            // 
            tbxLastCol.BorderStyle = BorderStyle.None;
            tbxLastCol.Font = new Font("Helvetica Neue", 12.5F);
            tbxLastCol.Location = new Point(128, 179);
            tbxLastCol.Name = "tbxLastCol";
            tbxLastCol.Size = new Size(174, 19);
            tbxLastCol.TabIndex = 18;
            tbxLastCol.TextAlign = HorizontalAlignment.Center;
            tbxLastCol.Visible = false;
            // 
            // lblLastCol
            // 
            lblLastCol.AutoSize = true;
            lblLastCol.BackColor = Color.FromArgb(157, 214, 231);
            lblLastCol.Font = new Font("Helvetica Neue", 12.25F);
            lblLastCol.Location = new Point(13, 179);
            lblLastCol.Name = "lblLastCol";
            lblLastCol.Size = new Size(88, 19);
            lblLastCol.TabIndex = 17;
            lblLastCol.Text = "Year Level:";
            lblLastCol.Visible = false;
            // 
            // tbxYearLevel
            // 
            tbxYearLevel.BorderStyle = BorderStyle.None;
            tbxYearLevel.Font = new Font("Helvetica Neue", 12.5F);
            tbxYearLevel.Location = new Point(127, 146);
            tbxYearLevel.Name = "tbxYearLevel";
            tbxYearLevel.Size = new Size(174, 19);
            tbxYearLevel.TabIndex = 16;
            tbxYearLevel.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxCourse
            // 
            tbxCourse.BorderStyle = BorderStyle.None;
            tbxCourse.Font = new Font("Helvetica Neue", 12.5F);
            tbxCourse.Location = new Point(127, 115);
            tbxCourse.Name = "tbxCourse";
            tbxCourse.Size = new Size(174, 19);
            tbxCourse.TabIndex = 15;
            tbxCourse.TextAlign = HorizontalAlignment.Center;
            // 
            // lblYearLevel
            // 
            lblYearLevel.AutoSize = true;
            lblYearLevel.BackColor = Color.FromArgb(157, 214, 231);
            lblYearLevel.Font = new Font("Helvetica Neue", 12.25F);
            lblYearLevel.Location = new Point(13, 146);
            lblYearLevel.Name = "lblYearLevel";
            lblYearLevel.Size = new Size(88, 19);
            lblYearLevel.TabIndex = 14;
            lblYearLevel.Text = "Year Level:";
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.BackColor = Color.FromArgb(157, 214, 231);
            lblCourse.Font = new Font("Helvetica Neue", 12.25F);
            lblCourse.Location = new Point(13, 115);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(66, 19);
            lblCourse.TabIndex = 13;
            lblCourse.Text = "Course:";
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Helvetica Neue", 11.9999981F);
            btnLoad.Location = new Point(179, 13);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(127, 32);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load File";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnConnect
            // 
            btnConnect.Font = new Font("Helvetica Neue", 11.9999981F);
            btnConnect.Location = new Point(17, 13);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(149, 33);
            btnConnect.TabIndex = 1;
            btnConnect.Text = "Connection Test";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(157, 214, 231);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(cmbTables);
            panel3.Location = new Point(718, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(328, 58);
            panel3.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(157, 214, 231);
            panel2.Controls.Add(btnConnect);
            panel2.Controls.Add(btnLoad);
            panel2.Location = new Point(718, 505);
            panel2.Name = "panel2";
            panel2.Size = new Size(328, 59);
            panel2.TabIndex = 14;
            // 
            // lblTableName
            // 
            lblTableName.BackColor = Color.FromArgb(157, 214, 231);
            lblTableName.Font = new Font("Helvetica Neue", 16F, FontStyle.Bold);
            lblTableName.ImageAlign = ContentAlignment.BottomCenter;
            lblTableName.Location = new Point(718, 156);
            lblTableName.Name = "lblTableName";
            lblTableName.Size = new Size(328, 44);
            lblTableName.TabIndex = 19;
            lblTableName.Text = "STUDENT INFORMATION";
            lblTableName.TextAlign = ContentAlignment.MiddleCenter;
            lblTableName.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(190, 229, 176);
            ClientSize = new Size(1067, 590);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(panel3);
            Controls.Add(dgvStudentInfo);
            Controls.Add(menuStrip1);
            Controls.Add(pnlControls);
            Controls.Add(panel2);
            Controls.Add(lblTableName);
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
            pnlControls.ResumeLayout(false);
            pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbDatabaseIcon).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudentInfo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem connectionTestToolStripMenuItem;
        private ToolStripMenuItem loadFileToolStripMenuItem;
        private Button btnInsert;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem insertToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ComboBox cmbTables;
        private Label label4;
        private TextBox tbxLname;
        private TextBox tbxID;
        private TextBox tbxFname;
        private Label lblLastName;
        private Button btnDelete;
        private Button btnUpdate;
        private Label lblStudentID;
        private Label lblFirstName;
        private Panel pnlControls;
        private Button btnLoad;
        private Button btnConnect;
        private Panel panel3;
        private Panel panel2;
        private Label lblYearLevel;
        private Label lblCourse;
        private TextBox tbxLastCol;
        private Label lblLastCol;
        private TextBox tbxYearLevel;
        private TextBox tbxCourse;
        private Label lblTableName;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private PictureBox pbDatabaseIcon;
    }
}
