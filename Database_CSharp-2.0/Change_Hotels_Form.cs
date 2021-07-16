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
    public partial class Change_Hotels_Form : Form
    {
        public Change_Hotels_Form()
        {
            InitializeComponent();
            connect_to_database();
            Change_Hotels_Load();
        }

        string connectString;
        string sql_query;
        int hotel_id;

        SqlConnection connect;
        SqlCommand cmd;

        private void connect_to_database() {
            //Connect to database
            connectString = @"Server=localhost\SQLEXPRESS01;Database=master;Trusted_Connection=True;";
            connect = new SqlConnection(connectString);
        }

        private void Change_Hotels_Load() {

            connect.Open();

            sql_query = "SELECT * FROM hotels_data"; //Set SQL request

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql_query, connect);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            DataTable data = new DataTable();
            dataAdapter.Fill(data);

            dataGridView1.DataSource = data;

            connect.Close();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void update_data_hotels_btn_Click(object sender, EventArgs e)
        {
            if (name_txtBox.Text == "" || country_txtBox.Text == "" || city_txtBox.Text == "" || hotel_txtBox.Text == "" ||
                count_stars_txtBox.Text == "" || transfer_comboBox.Text == "" || price_for_one_day_txtBox.Text == "")
            {

                MessageBox.Show("Fields not should be empty!");
            }
            else {
                int transfer;
                if (transfer_comboBox.Text == "Yes") {
                    transfer = 1;
                }
                else
                {
                    transfer = 0;
                }
                connect.Open();
                sql_query = String.Format("UPDATE hotels_data SET name = '{0}', country = '{1}', city = '{2}', hotel = '{3}', count_stars = '{4}', transfer = '{5}', price_for_one_day = '{6}' WHERE id = '{7}'", 
                    name_txtBox.Text, country_txtBox.Text, city_txtBox.Text, hotel_txtBox.Text, count_stars_txtBox.Text, transfer, price_for_one_day_txtBox.Text, hotel_id);
                cmd = new SqlCommand(sql_query, connect);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                connect.Close();

                dataGridView1.CurrentRow.Cells[1].Value = name_txtBox.Text;
                dataGridView1.CurrentRow.Cells[2].Value = country_txtBox.Text;
                dataGridView1.CurrentRow.Cells[3].Value = city_txtBox.Text;
                dataGridView1.CurrentRow.Cells[4].Value = hotel_txtBox.Text;
                dataGridView1.CurrentRow.Cells[5].Value = count_stars_txtBox.Text;
                dataGridView1.CurrentRow.Cells[6].Value = Convert.ToInt32(transfer);
                dataGridView1.CurrentRow.Cells[7].Value = price_for_one_day_txtBox.Text;
            }
        }

        private void delete_data_hotels_btn_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                sql_query = String.Format("DELETE FROM hotels_data WHERE id = '{0}'", hotel_id);
                cmd = new SqlCommand(sql_query, connect);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                connect.Close();

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Cells[0].RowIndex);
            }
            catch (FormatException)
            {
                MessageBox.Show("Id should be integer type!");
            }
        }

        private void Change_Hotels_Form_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            name_txtBox.Enabled = true;
            country_txtBox.Enabled = true;
            city_txtBox.Enabled = true;
            hotel_txtBox.Enabled = true;
            count_stars_txtBox.Enabled = true;
            transfer_comboBox.Enabled = true;
            price_for_one_day_txtBox.Enabled = true;

            hotel_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            name_txtBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            country_txtBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            city_txtBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            hotel_txtBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            count_stars_txtBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            transfer_comboBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            price_for_one_day_txtBox.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void name_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void country_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void city_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hotel_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void count_stars_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void transfer_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void price_for_one_day_txtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
