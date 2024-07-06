using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Net
{
    public partial class admin : Form
    {
        
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {

            loadData();

        }

        public void loadData()
        {
            var database = new Database();
            if (database.connect_db())
            {
                String query = "SELECT Name,Address,Contact,Email,Food,NumberOfGuest FROM data";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mysqlconnection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingsoure = new BindingSource();
                bindingsoure.DataSource = dt;


                dataGridView1.DataSource = bindingsoure;
                database.close_db();

            }
            else
            {
                MessageBox.Show("database error");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var database = new Database();
            if (database.connect_db())
            {
                String query = "DELETE FROM data where Name='" + textBox1.Text + "'";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mysqlconnection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingsoure = new BindingSource();
                bindingsoure.DataSource = dt;
            }
            else
            {
                MessageBox.Show("can not delet");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            var database = new Database();
            if (database.connect_db())
            {
                String query = " SELECT FROM data Name,Address,Contact,Email,Food,RoomType,NumberOfGuest  WHERE CONCAT(`Name`, `Address`, `Contact`, `Email`, `Food`, `RoomType`, `NumberOfGuest`) like '%" + dataGridView1 + "%'";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mysqlconnection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingsoure = new BindingSource();
                bindingsoure.DataSource = dt;
            }
            else
            {
                MessageBox.Show("empty");
            }
        }
    }
}
