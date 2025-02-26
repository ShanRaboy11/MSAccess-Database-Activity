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
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\Shan Michael\\source\\repos\\RABOY, SHAN MICHAEL V. [SchoolDatabase].accdb");
            ds = new DataSet();
            myConn.Open();
            System.Windows.Forms.MessageBox.Show("Connected successfully!", "Database Connected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            myConn.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\Shan Michael\\source\\repos\\RABOY, SHAN MICHAEL V. [SchoolDatabase].accdb");

            da = new OleDbDataAdapter("SELECT *FROM Student", myConn);
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
            da = new OleDbDataAdapter("SELECT *FROM Student", myConn);
            ds = new DataSet();
            da.Fill(ds, "Student");
            dgvStudentInfo.DataSource = ds.Tables["Student"];
            myConn.Close();
            tbxID.Text = "";
            tbxLname.Text = "";
            tbxFname.Text = "";
        }

        private void dgvStudentInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dgvStudentInfo.Rows[indexRow];
            tbxID.Text = row.Cells[0].Value.ToString();
            tbxLname.Text = row.Cells[1].Value.ToString();
            tbxFname.Text = row.Cells[2].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "Delete From Student Where StudentID = @id";
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@id",
            dgvStudentInfo.CurrentRow.Cells[0].Value);

            myConn.Open();
            cmd.ExecuteNonQuery();
            da = new OleDbDataAdapter("SELECT *FROM Student", myConn);
            ds = new DataSet();
            da.Fill(ds, "Student");
            dgvStudentInfo.DataSource = ds.Tables["Student"];
            myConn.Close();
            tbxID.Text = "";
            tbxLname.Text = "";
            tbxFname.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update Student Set LastName = @Lname, FirstName = @Fname Where StudentID = @id";
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@Lname", tbxLname.Text);
            cmd.Parameters.AddWithValue("@Fname", tbxFname.Text); 
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(tbxID.Text));

            myConn.Open();
            cmd.ExecuteNonQuery();
            da = new OleDbDataAdapter("SELECT *FROM Student", myConn);
            ds = new DataSet();
            da.Fill(ds, "Student");
            dgvStudentInfo.DataSource = ds.Tables["Student"];
            myConn.Close();
            tbxID.Text = "";
            tbxLname.Text = "";
            tbxFname.Text = "";
        }
    }
}
