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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Z:\\L65Y12W25\\RABOY, SHAN MICHAEL V. [SchoolDatabase].accdb");
            ds = new DataSet();
            myConn.Open();
            System.Windows.Forms.MessageBox.Show("Connected successfully!");
            myConn.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Z:\\L65Y12W25\\RABOY, SHAN MICHAEL V. [SchoolDatabase].accdb");

            da = new OleDbDataAdapter("SELECT *FROM Student", myConn);
            //or da = new OleDbDataAdapter("SELECT Student.LastName, Student.FirstName, 
            //Student.Course, SubjectsEnrolled.*, FinalGrade.StudentID\r\nFROM (Student 
            //INNER JOIN SubjectsEnrolled ON Student.StudentID = 
            //SubjectsEnrolled.StudentID) INNER JOIN FinalGrade ON Student.StudentID = 
            //FinalGrade.StudentID", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Student");
            dgvStudentInfo.DataSource = ds.Tables["Student"];
            myConn.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string query = "Insert into Student (LastName, FirstName) values (@LName, @FName)";
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@LName", tbxLname.Text);
            cmd.Parameters.AddWithValue("@FName", tbxFname.Text);
            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();
        }

        private void dgvStudentInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dgvStudentInfo.Rows[indexRow];
            tbxID.Text = row.Cells[0].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "Delete From Student Where StudentID = @id";
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@id",
            dgvStudentInfo.CurrentRow.Cells[0].Value);
            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update Student Set LastName = @Lname Where StudentID = @id";
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@ln", tbxLname.Text);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(tbxID.Text));
            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();
        }
    }
}
