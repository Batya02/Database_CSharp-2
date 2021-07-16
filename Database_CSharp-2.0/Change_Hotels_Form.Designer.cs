
namespace Database_CSharp_2._0
{
    partial class Change_Hotels_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delete_data_hotels_btn = new System.Windows.Forms.Button();
            this.update_data_hotels_btn = new System.Windows.Forms.Button();
            this.name_lbl = new System.Windows.Forms.Label();
            this.name_txtBox = new System.Windows.Forms.TextBox();
            this.country_lbl = new System.Windows.Forms.Label();
            this.country_txtBox = new System.Windows.Forms.TextBox();
            this.city_lbl = new System.Windows.Forms.Label();
            this.city_txtBox = new System.Windows.Forms.TextBox();
            this.hotel_lbl = new System.Windows.Forms.Label();
            this.hotel_txtBox = new System.Windows.Forms.TextBox();
            this.count_stars_lbl = new System.Windows.Forms.Label();
            this.count_stars_txtBox = new System.Windows.Forms.TextBox();
            this.transfer_comboBox = new System.Windows.Forms.ComboBox();
            this.transfer_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.price_for_one_day_txtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1102, 348);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // delete_data_hotels_btn
            // 
            this.delete_data_hotels_btn.Location = new System.Drawing.Point(12, 560);
            this.delete_data_hotels_btn.Name = "delete_data_hotels_btn";
            this.delete_data_hotels_btn.Size = new System.Drawing.Size(177, 31);
            this.delete_data_hotels_btn.TabIndex = 3;
            this.delete_data_hotels_btn.Text = "Delete";
            this.delete_data_hotels_btn.UseVisualStyleBackColor = true;
            this.delete_data_hotels_btn.Click += new System.EventHandler(this.delete_data_hotels_btn_Click);
            // 
            // update_data_hotels_btn
            // 
            this.update_data_hotels_btn.Location = new System.Drawing.Point(12, 521);
            this.update_data_hotels_btn.Name = "update_data_hotels_btn";
            this.update_data_hotels_btn.Size = new System.Drawing.Size(176, 33);
            this.update_data_hotels_btn.TabIndex = 4;
            this.update_data_hotels_btn.Text = "Update Data";
            this.update_data_hotels_btn.UseVisualStyleBackColor = true;
            this.update_data_hotels_btn.Click += new System.EventHandler(this.update_data_hotels_btn_Click);
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_lbl.Location = new System.Drawing.Point(12, 383);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(57, 20);
            this.name_lbl.TabIndex = 5;
            this.name_lbl.Text = "Name";
            // 
            // name_txtBox
            // 
            this.name_txtBox.Enabled = false;
            this.name_txtBox.Location = new System.Drawing.Point(86, 381);
            this.name_txtBox.Name = "name_txtBox";
            this.name_txtBox.Size = new System.Drawing.Size(170, 22);
            this.name_txtBox.TabIndex = 6;
            this.name_txtBox.TextChanged += new System.EventHandler(this.name_txtBox_TextChanged);
            // 
            // country_lbl
            // 
            this.country_lbl.AutoSize = true;
            this.country_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.country_lbl.Location = new System.Drawing.Point(317, 383);
            this.country_lbl.Name = "country_lbl";
            this.country_lbl.Size = new System.Drawing.Size(74, 20);
            this.country_lbl.TabIndex = 7;
            this.country_lbl.Text = "Country";
            // 
            // country_txtBox
            // 
            this.country_txtBox.Enabled = false;
            this.country_txtBox.Location = new System.Drawing.Point(499, 381);
            this.country_txtBox.Name = "country_txtBox";
            this.country_txtBox.Size = new System.Drawing.Size(170, 22);
            this.country_txtBox.TabIndex = 8;
            this.country_txtBox.TextChanged += new System.EventHandler(this.country_txtBox_TextChanged);
            // 
            // city_lbl
            // 
            this.city_lbl.AutoSize = true;
            this.city_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.city_lbl.Location = new System.Drawing.Point(740, 381);
            this.city_lbl.Name = "city_lbl";
            this.city_lbl.Size = new System.Drawing.Size(42, 20);
            this.city_lbl.TabIndex = 9;
            this.city_lbl.Text = "City";
            // 
            // city_txtBox
            // 
            this.city_txtBox.Enabled = false;
            this.city_txtBox.Location = new System.Drawing.Point(893, 381);
            this.city_txtBox.Name = "city_txtBox";
            this.city_txtBox.Size = new System.Drawing.Size(170, 22);
            this.city_txtBox.TabIndex = 10;
            this.city_txtBox.TextChanged += new System.EventHandler(this.city_txtBox_TextChanged);
            // 
            // hotel_lbl
            // 
            this.hotel_lbl.AutoSize = true;
            this.hotel_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotel_lbl.Location = new System.Drawing.Point(12, 440);
            this.hotel_lbl.Name = "hotel_lbl";
            this.hotel_lbl.Size = new System.Drawing.Size(54, 20);
            this.hotel_lbl.TabIndex = 11;
            this.hotel_lbl.Text = "Hotel";
            // 
            // hotel_txtBox
            // 
            this.hotel_txtBox.Enabled = false;
            this.hotel_txtBox.Location = new System.Drawing.Point(86, 440);
            this.hotel_txtBox.Name = "hotel_txtBox";
            this.hotel_txtBox.Size = new System.Drawing.Size(170, 22);
            this.hotel_txtBox.TabIndex = 12;
            this.hotel_txtBox.TextChanged += new System.EventHandler(this.hotel_txtBox_TextChanged);
            // 
            // count_stars_lbl
            // 
            this.count_stars_lbl.AutoSize = true;
            this.count_stars_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_stars_lbl.Location = new System.Drawing.Point(317, 440);
            this.count_stars_lbl.Name = "count_stars_lbl";
            this.count_stars_lbl.Size = new System.Drawing.Size(107, 20);
            this.count_stars_lbl.TabIndex = 13;
            this.count_stars_lbl.Text = "Count stars";
            // 
            // count_stars_txtBox
            // 
            this.count_stars_txtBox.Enabled = false;
            this.count_stars_txtBox.Location = new System.Drawing.Point(499, 440);
            this.count_stars_txtBox.Name = "count_stars_txtBox";
            this.count_stars_txtBox.Size = new System.Drawing.Size(170, 22);
            this.count_stars_txtBox.TabIndex = 14;
            this.count_stars_txtBox.TextChanged += new System.EventHandler(this.count_stars_txtBox_TextChanged);
            // 
            // transfer_comboBox
            // 
            this.transfer_comboBox.Enabled = false;
            this.transfer_comboBox.FormattingEnabled = true;
            this.transfer_comboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.transfer_comboBox.Location = new System.Drawing.Point(893, 440);
            this.transfer_comboBox.Name = "transfer_comboBox";
            this.transfer_comboBox.Size = new System.Drawing.Size(121, 24);
            this.transfer_comboBox.TabIndex = 15;
            this.transfer_comboBox.SelectedIndexChanged += new System.EventHandler(this.transfer_comboBox_SelectedIndexChanged);
            // 
            // transfer_lbl
            // 
            this.transfer_lbl.AutoSize = true;
            this.transfer_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transfer_lbl.Location = new System.Drawing.Point(740, 440);
            this.transfer_lbl.Name = "transfer_lbl";
            this.transfer_lbl.Size = new System.Drawing.Size(80, 20);
            this.transfer_lbl.TabIndex = 16;
            this.transfer_lbl.Text = "Transfer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(317, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Price for one day";
            // 
            // price_for_one_day_txtBox
            // 
            this.price_for_one_day_txtBox.Enabled = false;
            this.price_for_one_day_txtBox.Location = new System.Drawing.Point(499, 498);
            this.price_for_one_day_txtBox.Name = "price_for_one_day_txtBox";
            this.price_for_one_day_txtBox.Size = new System.Drawing.Size(170, 22);
            this.price_for_one_day_txtBox.TabIndex = 18;
            this.price_for_one_day_txtBox.TextChanged += new System.EventHandler(this.price_for_one_day_txtBox_TextChanged);
            // 
            // Change_Hotels_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 603);
            this.Controls.Add(this.price_for_one_day_txtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transfer_lbl);
            this.Controls.Add(this.transfer_comboBox);
            this.Controls.Add(this.count_stars_txtBox);
            this.Controls.Add(this.count_stars_lbl);
            this.Controls.Add(this.hotel_txtBox);
            this.Controls.Add(this.hotel_lbl);
            this.Controls.Add(this.city_txtBox);
            this.Controls.Add(this.city_lbl);
            this.Controls.Add(this.country_txtBox);
            this.Controls.Add(this.country_lbl);
            this.Controls.Add(this.name_txtBox);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.update_data_hotels_btn);
            this.Controls.Add(this.delete_data_hotels_btn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Change_Hotels_Form";
            this.Text = "Change_Hotels_Form";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Change_Hotels_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delete_data_hotels_btn;
        private System.Windows.Forms.Button update_data_hotels_btn;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.TextBox name_txtBox;
        private System.Windows.Forms.Label country_lbl;
        private System.Windows.Forms.TextBox country_txtBox;
        private System.Windows.Forms.Label city_lbl;
        private System.Windows.Forms.TextBox city_txtBox;
        private System.Windows.Forms.Label hotel_lbl;
        private System.Windows.Forms.TextBox hotel_txtBox;
        private System.Windows.Forms.Label count_stars_lbl;
        private System.Windows.Forms.TextBox count_stars_txtBox;
        private System.Windows.Forms.Label transfer_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox price_for_one_day_txtBox;
        private System.Windows.Forms.ComboBox transfer_comboBox;
    }
}