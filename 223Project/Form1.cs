using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace _223Project
{
    public partial class Form1 : Form
    {
        //SqlConnection con = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
        }

        public SqlConnection conn;
        public SqlDataAdapter adap;
        public SqlCommand comm;
        public DataSet data;
        public SqlDataReader datar;



        private void librarianBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.librarianBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.modelDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'modelDataSet.Librarian' table. You can move, or remove it, as needed.
            this.librarianTableAdapter.Fill(this.modelDataSet.Librarian);

            label5.Visible = false;
            label7.Visible = false;
            label8.Visible = false;

            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\223\Project\223Project\223Project\Librarian.mdf;Integrated Security=True");
            conn.Open();
            comm = new SqlCommand("Select * FROM Librarian", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            da.SelectCommand = comm;
            dt.Clear();
            da.Fill(dt);

            dgvDelete.DataSource = dt;
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\223\Project\223Project\223Project\Librarian.mdf;Integrated Security=True");
            conn.Open();

            bool flag;
            flag = true;

            if (tbID == null)
                flag = false;

            if (tbLName == null)
                flag = false;

            if (tbPassword == null)
                flag = false;

            if ((tbPassword.TextLength > 30) && (tbPassword.TextLength < 6))
            {
                flag = false;
                label7.Visible = true;
            }

            if (tbID.TextLength < 8)
            {
                flag = false;
                label5.Visible = true;
            }


            if (flag == false)
            {
                label8.Visible = true;
            }
            else
            {
                //insert stelling
                comm = new SqlCommand("INSERT INTO Librarian (Librarian_ID, Librarian_Name, Librarian_Password, Date_Of_Hire) VALUES (@Librarian_ID, @Librarian_Name, @Librarian_Password, @Date_Of_Hire)", conn);
                comm.Parameters.AddWithValue("@Librarian_ID", tbID.Text);
                comm.Parameters.AddWithValue("@Librarian_Name", tbLName.Text);
                comm.Parameters.AddWithValue("@Librarian_Password", tbPassword.Text);
                DateTime today = DateTime.Today;
                comm.Parameters.AddWithValue("@Date_Of_Hire", today);
                comm.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                comm = new SqlCommand("Select * FROM Librarian", conn);
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                da.SelectCommand = comm;
                dt.Clear();
                da.Fill(dt);

                dgvLibrarian.DataSource = dt;
                conn.Close();
            }

            
        }

        private void tbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            tbID.MaxLength = 8;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool flag;
            flag = true;

            if (tbNew.Text != tbConfirm.Text)
            {
                flag = false;
                lbText.Text = "New password and confirm password fields does not match.";
            }




            if (flag == true)
            {
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\223\Project\223Project\223Project\Librarian.mdf;Integrated Security=True");
                conn.Open();


                comm = new SqlCommand("UPDATE Librarian SET Librarian_Password = @lPassword WHERE Librarian_ID = @ID", conn);
                comm.Parameters.AddWithValue("@lPassword", tbNew.Text);
                comm.Parameters.AddWithValue("@ID", tbIDp.Text);
                comm.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Password changed successfully");
            }
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbIDp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            tbID.MaxLength = 8;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            conn.Open();
            comm = new SqlCommand("Select * FROM Librarian", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            da.SelectCommand = comm;
            dt.Clear();
            da.Fill(dt);

            dgvDelete.DataSource = dt;
            conn.Close();
        }

        private void dgvDelete_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int libID = Convert.ToInt32(dgvDelete.Rows[e.RowIndex].Cells["Librarian_ID"].Value);
            conn.Open();
            //SqlCommand c = new SqlCommand("DELETE Librarian WHERE Librarian_ID = '"+ libID +"'", conn);
            //c.ExecuteNonQuery();
            //conn.Close();

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this cell?", "Delete now?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand c = new SqlCommand("DELETE Librarian WHERE Librarian_ID = '" + libID + "'", conn);
                c.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Successfully deleted");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Delete aborted");
            }

            conn.Close();



            conn.Open();
            comm = new SqlCommand("Select * FROM Librarian", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            da.SelectCommand = comm;
            dt.Clear();
            da.Fill(dt);

            dgvDelete.DataSource = dt;
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
