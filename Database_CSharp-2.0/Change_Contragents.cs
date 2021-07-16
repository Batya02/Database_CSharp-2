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
    public partial class Change_Contragents : Form
    {
        string connectString;
        string sql_query;
        int user_id=0;

        SqlConnection connect;
        SqlCommand cmd; 

        public Change_Contragents()
        {
            InitializeComponent();
            connect_to_database();
            Change_Contragents_Load();
        }


        private void connect_to_database() {
            //Connect to database
            connectString = @"Server=localhost\SQLEXPRESS01;Database=master;Trusted_Connection=True;";
            connect = new SqlConnection(connectString);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            first_name_txtBox.Enabled = true;
            last_name_txtBox.Enabled = true;
            patronymic_txtBox.Enabled = true;
            phone_txtBox.Enabled = true;

            user_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            first_name_txtBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            last_name_txtBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            patronymic_txtBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            phone_txtBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Console.WriteLine(true);
        }

        private void Change_Contragents_Load() {

            connect.Open();

            sql_query = "SELECT * FROM users"; //Set SQL request

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql_query, connect);  

            DataTable data = new DataTable();
            dataAdapter.Fill(data);

            dataGridView1.DataSource = data;

            connect.Close();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void update_data_contragents_btn_Click(object sender, EventArgs e)
        {
            if (first_name_txtBox.Text == "" || last_name_txtBox.Text == "" || patronymic_txtBox.Text == "" || phone_txtBox.Text == "") {
                MessageBox.Show("Fields not should be empty!");
            }
            else
            {
                connect.Open();
                sql_query = String.Format(
                        "UPDATE users SET first_name = '{0}', last_name = '{1}', patronymic = '{2}', phone = '{3}' WHERE id = '{4}'",
                        first_name_txtBox.Text, last_name_txtBox.Text,
                        patronymic_txtBox.Text, phone_txtBox.Text,
                        user_id
                        );

                cmd = new SqlCommand(sql_query, connect);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                connect.Close();

                dataGridView1.CurrentRow.Cells[1].Value = first_name_txtBox.Text;
                dataGridView1.CurrentRow.Cells[2].Value = last_name_txtBox.Text;
                dataGridView1.CurrentRow.Cells[3].Value = patronymic_txtBox.Text;
                dataGridView1.CurrentRow.Cells[4].Value = phone_txtBox.Text;
            }
        }

        private void delete_data_contragents_btn_Click(object sender, EventArgs e)
        {
            if (user_id == 0)
            {
                MessageBox.Show("Your are don't selected user!");
            }
            else
            {
                connect.Open();
                sql_query = String.Format("DELETE FROM users WHERE id={0}", user_id);
                cmd = new SqlCommand(sql_query, connect);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                connect.Close();

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Cells[0].RowIndex);
            }
        }

        private void first_name_txtBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void last_name_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void patronymic_txtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
