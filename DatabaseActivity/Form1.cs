using System.Data.OleDb;
using System.Data;
using Microsoft.VisualBasic.Logging;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Xml.Linq;

namespace DatabaseActivity
{
    public partial class Form1 : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        private string selectedTable;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\Shan Michael\\source\\repos\\RABOY, SHAN MICHAEL V. [SchoolDatabase].accdb");
            ds = new DataSet();
            myConn.Open();
            System.Windows.Forms.MessageBox.Show("Connected successfully!", "Database Connected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            myConn.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\Shan Michael\\source\\repos\\RABOY, SHAN MICHAEL V. [SchoolDatabase].accdb");
            if (string.IsNullOrEmpty(selectedTable))
            {
                MessageBox.Show("No table selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            da = new OleDbDataAdapter($"SELECT *FROM {selectedTable}", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, selectedTable);
            dgvStudentInfo.DataSource = ds.Tables[selectedTable];
            myConn.Close();
            DisplayControls(selectedTable);
            tbxID.Text = "";
            tbxLname.Text = "";
            tbxFname.Text = "";
            tbxCourse.Text = "";
            tbxYearLevel.Text = "";
            tbxLastCol.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string query = null;
            cmd = new OleDbCommand(); 
            cmd.Connection = myConn;

            if (selectedTable == "Student")
            {
                query = "INSERT INTO Student (LastName, FirstName, Course, YearLevel) VALUES (@LName, @FName, @Course, @YearLevel)";
                cmd.Parameters.AddWithValue("@LName", tbxLname.Text);
                cmd.Parameters.AddWithValue("@FName", tbxFname.Text);
                cmd.Parameters.AddWithValue("@Course", tbxCourse.Text);
                cmd.Parameters.AddWithValue("@YearLevel", tbxYearLevel.Text);
            }
            else if (selectedTable == "FinalGrade")
            {
                query = "INSERT INTO FinalGrade (FG1, FG2, FG3, FG4, FG5) VALUES (@FG1, @FG2, @FG3, @FG4, @FG5)";
                cmd.Parameters.AddWithValue("@FG1", tbxLname.Text);
                cmd.Parameters.AddWithValue("@FG2", tbxFname.Text);
                cmd.Parameters.AddWithValue("@FG3", tbxCourse.Text);
                cmd.Parameters.AddWithValue("@FG4", tbxYearLevel.Text);
                cmd.Parameters.AddWithValue("@FG5", tbxLastCol.Text);
            }
            else if (selectedTable == "SubjectsEnrolled")
            {
                query = "INSERT INTO SubjectsEnrolled (CourseNum1, CourseNum2, CourseNum3, CourseNum4, CourseNum5) VALUES (@CourseNum1, @CourseNum2, @CourseNum3, @CourseNum4, @CourseNum5)";
                cmd.Parameters.AddWithValue("@CourseNum1", tbxLname.Text);
                cmd.Parameters.AddWithValue("@CourseNum2", tbxFname.Text);
                cmd.Parameters.AddWithValue("@CourseNum3", tbxCourse.Text);
                cmd.Parameters.AddWithValue("@CourseNum4", tbxYearLevel.Text);
                cmd.Parameters.AddWithValue("@CourseNum5", tbxLastCol.Text);
            }

            if (query != null) 
            {
                cmd.CommandText = query;
                myConn.Open();
                cmd.ExecuteNonQuery();
                myConn.Close();

                da = new OleDbDataAdapter($"SELECT * FROM {selectedTable}", myConn);
                ds = new DataSet();
                myConn.Open();
                da.Fill(ds, selectedTable);
                dgvStudentInfo.DataSource = ds.Tables[selectedTable];
                myConn.Close();
            }
            else
            {
                MessageBox.Show("Invalid table selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearTextFields();
        }

        private void dgvStudentInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dgvStudentInfo.Rows[indexRow];
            tbxID.Text = row.Cells[0].Value.ToString();
            tbxLname.Text = row.Cells[1].Value.ToString();
            tbxFname.Text = row.Cells[2].Value.ToString();
            tbxCourse.Text = row.Cells[3].Value.ToString();
            tbxYearLevel.Text = row.Cells[4].Value.ToString();
            if(dgvStudentInfo.ColumnCount > 5)
            {
                tbxLastCol.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = $"Delete From {selectedTable} Where StudentID = @id";
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@id",
            dgvStudentInfo.CurrentRow.Cells[0].Value);

            myConn.Open();
            cmd.ExecuteNonQuery();
            da = new OleDbDataAdapter($"SELECT *FROM {selectedTable}", myConn);
            ds = new DataSet();
            da.Fill(ds, selectedTable);
            dgvStudentInfo.DataSource = ds.Tables[selectedTable];
            myConn.Close();
            ClearTextFields();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = null;
            cmd = new OleDbCommand();
            cmd.Connection = myConn;

            if (selectedTable == "Student")
            {
                query = "UPDATE Student SET LastName = @LName, FirstName = @FName, Course = @Course, YearLevel = @YearLevel WHERE StudentID = @ID";
                cmd.Parameters.AddWithValue("@LName", tbxLname.Text);
                cmd.Parameters.AddWithValue("@FName", tbxFname.Text);
                cmd.Parameters.AddWithValue("@Course", tbxCourse.Text);
                cmd.Parameters.AddWithValue("@YearLevel", tbxYearLevel.Text);
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(tbxID.Text));
            }
            else if (selectedTable == "FinalGrade")
            {
                query = "UPDATE FinalGrade SET FG1 = @FG1, FG2 = @FG2, FG3 = @FG3, FG4 = @FG4, FG5 = @FG5 WHERE StudentID = @ID";
                cmd.Parameters.AddWithValue("@FG1", tbxLname.Text);
                cmd.Parameters.AddWithValue("@FG2", tbxFname.Text);
                cmd.Parameters.AddWithValue("@FG3", tbxCourse.Text);
                cmd.Parameters.AddWithValue("@FG4", tbxYearLevel.Text);
                cmd.Parameters.AddWithValue("@FG5", tbxLastCol.Text);
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(tbxID.Text));
            }
            else if (selectedTable == "SubjectsEnrolled")
            {
                query = "UPDATE SubjectsEnrolled SET CourseNum1 = @CourseNum1, CourseNum2 = @CourseNum2, CourseNum3 = @CourseNum3, CourseNum4 = @CourseNum4, CourseNum5 = @CourseNum5 WHERE StudentID = @ID";
                cmd.Parameters.AddWithValue("@CourseNum1", tbxLname.Text);
                cmd.Parameters.AddWithValue("@CourseNum2", tbxFname.Text);
                cmd.Parameters.AddWithValue("@CourseNum3", tbxCourse.Text);
                cmd.Parameters.AddWithValue("@CourseNum4", tbxYearLevel.Text);
                cmd.Parameters.AddWithValue("@CourseNum5", tbxLastCol.Text);
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(tbxID.Text));
            }

            if (query != null)
            {
                cmd.CommandText = query;
                myConn.Open();
                cmd.ExecuteNonQuery();
                myConn.Close();

                da = new OleDbDataAdapter($"SELECT * FROM {selectedTable}", myConn);
                ds = new DataSet();
                myConn.Open();
                da.Fill(ds, selectedTable);
                dgvStudentInfo.DataSource = ds.Tables[selectedTable];
                myConn.Close();
            }
            else
            {
                MessageBox.Show("Invalid table selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearTextFields();
        }



        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTables.SelectedItem != null)
            {
                selectedTable = cmbTables.SelectedItem.ToString();
            }
        }

        private void RefreshDataGridView()
        {
            da = new OleDbDataAdapter($"SELECT * FROM {selectedTable}", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, selectedTable);
            dgvStudentInfo.DataSource = ds.Tables[selectedTable];
            myConn.Close();
        }

        private void ClearTextFields()
        {
            tbxID.Text = "";
            tbxLname.Text = "";
            tbxFname.Text = "";
            tbxCourse.Text = "";
            tbxYearLevel.Text = "";
            tbxLastCol.Text = "";
        }

        private void DisplayControls(string currentTable)
        {
            if(currentTable == "Student")
            {
                pnlControls.Visible = true;
                lblCourse.Visible = true;
                lblFirstName.Visible = true;
                lblLastName.Visible = true;
                lblStudentID.Visible = true;
                lblTableName.Visible = true;
                lblYearLevel.Visible = true;
                lblTableName.Text = "STUDENT INFORMATION";
                lblLastName.Text = "Last Name:";
                lblFirstName.Text = "First Name:";
                lblCourse.Text = "Course:";
                lblYearLevel.Text = "Year Level:";
                if (lblLastCol.Visible == true)
                {
                    lblLastCol.Visible = false;
                    tbxLastCol.Visible = false;
                }
            }
            else if(currentTable == "FinalGrade")
            {
                pnlControls.Visible = true;
                lblCourse.Visible = true;
                lblFirstName.Visible = true;
                lblLastName.Visible = true;
                lblStudentID.Visible = true;
                lblTableName.Visible = true;
                lblYearLevel.Visible = true;
                lblLastCol.Visible = true;
                tbxLastCol.Visible = true;
                lblTableName.Text = "FINAL GRADES";
                lblLastName.Text = "    FG1:";
                lblFirstName.Text = "    FG2:";
                lblCourse.Text = "    FG3:";
                lblYearLevel.Text = "    FG4:";
                lblLastCol.Text = "    FG5:";
            }
            else if(currentTable == "SubjectsEnrolled")
            {
                pnlControls.Visible = true;
                lblCourse.Visible = true;
                lblFirstName.Visible = true;
                lblLastName.Visible = true;
                lblStudentID.Visible = true;
                lblTableName.Visible = true;
                lblYearLevel.Visible = true;
                lblLastCol.Visible = true;
                tbxLastCol.Visible = true;
                lblTableName.Text = "SUBJECTS ENROLLED";
                lblLastName.Text = "CourseNum1:";
                lblFirstName.Text = "CourseNum2:";
                lblCourse.Text = "CourseNum3:";
                lblYearLevel.Text = "CourseNum4:";
                lblLastCol.Text = "CourseNum5:";
            }
        }
    }
}
