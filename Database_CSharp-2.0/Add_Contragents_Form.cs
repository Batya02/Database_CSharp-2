using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace Database_CSharp_2._0
{
    public partial class Add_Contragents_Form : Form
    {
        struct InsertVars {
            public string first_name;
            public string last_name;
            public string patronymic;
            public string phone;
        }

        InsertVars insertVars;

        public Add_Contragents_Form()
        {
            InitializeComponent();
        }

        private void textBox_first_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_last_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_patronymic_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_add_data_Click(object sender, EventArgs e)
        {
            string connectionString;
            string sql_query;

            SqlConnection conn;
            SqlCommand command;

            connectionString = @"Server=localhost\SQLEXPRESS01;Database=master;Trusted_Connection=True;";
            conn = new SqlConnection(connectionString);
            conn.Open();

            sql_query = "If not exists (select name from sysobjects where name = 'users') CREATE TABLE users(id INTEGER PRIMARY KEY IDENTITY, first_name TEXT NOT NULL, last_name TEXT NOT NULL, patronymic TEXT NOT NULL, phone TEXT NOT NULL)";

            command = new SqlCommand(sql_query, conn);
            command.ExecuteNonQuery();
            command.Dispose();

            insertVars.first_name = textBox_first_name.Text;
            insertVars.last_name = textBox_last_name.Text;
            insertVars.patronymic = textBox_patronymic.Text;
            insertVars.phone = textBox_phone.Text;

            if (insertVars.first_name == "" || insertVars.last_name == "" || insertVars.patronymic == "" || insertVars.phone == "")
            {
                MessageBox.Show("Fields should not be empty!");
            }
            else
            {
                sql_query = "INSERT INTO users(first_name, last_name, patronymic, phone) VALUES(@first_name, @last_name, @patronymic, @phone)";
                command = new SqlCommand(sql_query, conn);
                command.Parameters.AddWithValue("@first_name", insertVars.first_name);
                command.Parameters.AddWithValue("@last_name", insertVars.last_name);
                command.Parameters.AddWithValue("@patronymic", insertVars.patronymic);
                command.Parameters.AddWithValue("@phone", insertVars.phone);

                command.ExecuteNonQuery();
                command.Dispose();

                conn.Close();
                MessageBox.Show("User added successfully!");
            }           
        }
    }
}
