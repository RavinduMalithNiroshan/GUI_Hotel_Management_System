using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Net
{
    public partial class booking : UserControl
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password= ");

        public booking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

             String insertQuery = "INSERT INTO bookingdata.data(Name, Address, Contact, Email, Food, InDate, NumberOfGuest, OutDate, RoomType) VALUES ('"+ textBox2.Text +"','"+ textBox1.Text +"',"+ textBox4.Text +",'"+ textBox3.Text +"','"+ comboBox1.SelectedItem +"','"+ dateTimePicker1.Value.TimeOfDay +"',"+ numericUpDown1.Value + ",'"+ dateTimePicker2.Value.TimeOfDay + "','"+ comboBox3.SelectedItem +"')";
           

            con.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, con);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data inserted");
                }
                else
                {
                    MessageBox.Show("Data not insert");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }

            con.Close();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void booking_Load(object sender, EventArgs e)
        {

        }
    }
}
