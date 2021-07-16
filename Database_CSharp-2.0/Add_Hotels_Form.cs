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
    public partial class Add_Hotels_Form : Form
    {
        struct DB_Data {
            public string name;
            public string country;
            public string city;
            public string hotel;
            public int count_stars;
            public byte transfer;
            public string price_for_one_day;
        };

        string connectString;
        string sql_query;

        SqlConnection connect;
        SqlCommand cmd;

        public Add_Hotels_Form()
        {
            InitializeComponent();
        }

        private void name_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void country_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void city_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hotel_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void count_stars_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void price_for_one_day_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_hotel_btn_Click(object sender, EventArgs e)
        {

            DB_Data db_data;
            try
            {
                db_data.name = name_textBox.Text;
                db_data.country = country_textBox.Text;
                db_data.city = city_textBox.Text;
                db_data.hotel = hotel_textBox.Text;
                db_data.count_stars = Convert.ToInt32(count_stars_textBox.Text);
                db_data.price_for_one_day = price_for_one_day_textBox.Text;

                if (db_data.name == "" || db_data.country == "" 
                                       || 
                    db_data.city == "" || db_data.hotel == "" 
                                       || 
                    db_data.price_for_one_day == "" )
                {
                    MessageBox.Show("Fields should not be empty");
                }
                else {
                    if (transfer_comboBox.Text == "Yes")
                    {
                        db_data.transfer = 1;
                    }
                    else if (transfer_comboBox.Text == "No")
                    {
                        db_data.transfer = 0;
                    }
                    else
                    {
                        db_data.transfer = 127;
                    }

                    if (db_data.transfer == 127)
                    {
                        MessageBox.Show("Your need to select a value (Yes or No)!");
                    }
                    else
                    {
                        connectString = @"Server=localhost\SQLEXPRESS01;Database=master;Trusted_Connection=True;";
                        connect = new SqlConnection(connectString);

                        connect.Open();

                        sql_query = "If not exists (select name from sysobjects where name = 'hotels_data') CREATE TABLE hotels_data(id INTEGER PRIMARY KEY IDENTITY, name TEXT NOT NULL, country TEXT NOT NULL, city TEXT NOT NULL, hotel TEXT NOT NULL, count_stars INTEGER NOT NULL, transfer BIT NOT NULL, price_for_one_day TEXT NOT NULL)";
                        cmd = new SqlCommand(sql_query, connect);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();

                        sql_query = "INSERT INTO hotels_data(name, country, city, hotel, count_stars, transfer, price_for_one_day) VALUES(@name, @country, @city, @hotel, @count_stars, @transfer, @price_for_one_day)";
                        cmd = new SqlCommand(sql_query, connect);
                        cmd.Parameters.AddWithValue("@name", db_data.name);
                        cmd.Parameters.AddWithValue("@country", db_data.country);
                        cmd.Parameters.AddWithValue("@city", db_data.city);
                        cmd.Parameters.AddWithValue("@hotel", db_data.hotel);
                        cmd.Parameters.AddWithValue("@count_stars", db_data.count_stars);
                        cmd.Parameters.AddWithValue("@transfer", db_data.transfer);
                        cmd.Parameters.AddWithValue("@price_for_one_day", db_data.price_for_one_day);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        connect.Close();
                    }                
                }
            }
            catch (FormatException){
                MessageBox.Show("Value <count stars> should be integer!");
                //MessageBox.Show("Count stars should be integer value!");
            }
        }

        private void transfer_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
