using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Data.Sqlite;

namespace Database_CSharp_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Contagent_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Contragents_Form add_contragents_form = new Add_Contragents_Form();
            add_contragents_form.Show();
        }

        private void Change_Contragent_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Contragents change_contragents_form = new Change_Contragents();
            change_contragents_form.Show();
        }

        private void Add_Hotel_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Add_Hotels_Form add_hotels_form = new Add_Hotels_Form();
            add_hotels_form.Show();
        }

        private void Change_Hotel_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Change_Hotels_Form change_hotels_form = new Change_Hotels_Form();
            change_hotels_form.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_object search_object = new Search_object();
            search_object.Show();
        }
    }
}
