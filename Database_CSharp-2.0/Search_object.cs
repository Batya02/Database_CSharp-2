using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Database_CSharp_2._0
{
    public partial class Search_object : Form
    {
        public Search_object()
        {
            InitializeComponent();
            connect_to_database();
        }

        struct Find_Data {
            public string first_name;
            public string last_name;
            public string patronymic;
            public string phone;
        }

        string connect_string;
        string sql_query;

        SqlConnection connect;
        SqlCommand cmd;

        private void connect_to_database() {
            connect_string = @"Server=localhost\SQLEXPRESS01;Database=master;Trusted_Connection=True;";
            connect = new SqlConnection(connect_string);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void first_name_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void last_name_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void patronymic_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void find_object_button_Click(object sender, EventArgs e)
        {

            Find_Data find_data;
            find_data.first_name = first_name_textBox.Text;
            find_data.last_name = last_name_textBox.Text;
            find_data.patronymic = patronymic_textBox.Text;
            find_data.phone = phone_textBox.Text;

            if (find_data.first_name == "" || find_data.last_name == ""
                                           ||
                find_data.patronymic == "" || find_data.phone == "")
            {
                MessageBox.Show("Fileds not should be empty!");
            }
            else
            { 
                dataGridView1.ColumnCount = 5;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Columns[0].Name = "Id";
                dataGridView1.Columns[1].Name = "First Name";
                dataGridView1.Columns[2].Name = "Last Name";
                dataGridView1.Columns[3].Name = "Patronymic";
                dataGridView1.Columns[4].Name = "Phone";

                connect.Open();
                sql_query = "SELECT * FROM users WHERE first_name LIKE '@first_name' and last_name LIKE '@last_name' and patronymic LIKE '@patronymic' and phone LIKE '@phone'";
                cmd = new SqlCommand(sql_query, connect);
                cmd.Parameters.AddWithValue("@first_name", find_data.first_name);
                cmd.Parameters.AddWithValue("@last_name", find_data.last_name);
                cmd.Parameters.AddWithValue("@patronymic", find_data.patronymic);
                cmd.Parameters.AddWithValue("@phone", find_data.phone);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                SqlDataReader readData = cmd.ExecuteReader();

                while (readData.Read()) {
                    dataGridView1.Rows.Add(
                        readData.GetInt32(0), readData.GetString(1),
                        readData.GetString(2), readData.GetString(3)
                        );
                }
                readData.Close();
                connect.Close();
            }
        }
    }
}
