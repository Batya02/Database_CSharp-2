
namespace Database_CSharp_2._0
{
    partial class Add_Hotels_Form
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
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.country_textBox = new System.Windows.Forms.TextBox();
            this.city_textBox = new System.Windows.Forms.TextBox();
            this.hotel_textBox = new System.Windows.Forms.TextBox();
            this.price_for_one_day_textBox = new System.Windows.Forms.TextBox();
            this.count_stars_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.add_hotel_btn = new System.Windows.Forms.Button();
            this.sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            this.transfer_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(298, 74);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(183, 22);
            this.name_textBox.TabIndex = 0;
            this.name_textBox.TextChanged += new System.EventHandler(this.name_textBox_TextChanged);
            // 
            // country_textBox
            // 
            this.country_textBox.Location = new System.Drawing.Point(298, 117);
            this.country_textBox.Name = "country_textBox";
            this.country_textBox.Size = new System.Drawing.Size(183, 22);
            this.country_textBox.TabIndex = 1;
            this.country_textBox.TextChanged += new System.EventHandler(this.country_textBox_TextChanged);
            // 
            // city_textBox
            // 
            this.city_textBox.Location = new System.Drawing.Point(298, 160);
            this.city_textBox.Name = "city_textBox";
            this.city_textBox.Size = new System.Drawing.Size(183, 22);
            this.city_textBox.TabIndex = 2;
            this.city_textBox.TextChanged += new System.EventHandler(this.city_textBox_TextChanged);
            // 
            // hotel_textBox
            // 
            this.hotel_textBox.Location = new System.Drawing.Point(298, 202);
            this.hotel_textBox.Name = "hotel_textBox";
            this.hotel_textBox.Size = new System.Drawing.Size(183, 22);
            this.hotel_textBox.TabIndex = 3;
            this.hotel_textBox.TextChanged += new System.EventHandler(this.hotel_textBox_TextChanged);
            // 
            // price_for_one_day_textBox
            // 
            this.price_for_one_day_textBox.Location = new System.Drawing.Point(298, 327);
            this.price_for_one_day_textBox.Name = "price_for_one_day_textBox";
            this.price_for_one_day_textBox.Size = new System.Drawing.Size(183, 22);
            this.price_for_one_day_textBox.TabIndex = 5;
            this.price_for_one_day_textBox.TextChanged += new System.EventHandler(this.price_for_one_day_textBox_TextChanged);
            // 
            // count_stars_textBox
            // 
            this.count_stars_textBox.Location = new System.Drawing.Point(298, 244);
            this.count_stars_textBox.Name = "count_stars_textBox";
            this.count_stars_textBox.Size = new System.Drawing.Size(183, 22);
            this.count_stars_textBox.TabIndex = 6;
            this.count_stars_textBox.TextChanged += new System.EventHandler(this.count_stars_textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(149, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(149, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(149, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(149, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hotel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(149, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Count stars";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(149, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Transfer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(149, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Price for one day";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(319, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Input Data";
            // 
            // add_hotel_btn
            // 
            this.add_hotel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_hotel_btn.Location = new System.Drawing.Point(298, 388);
            this.add_hotel_btn.Name = "add_hotel_btn";
            this.add_hotel_btn.Size = new System.Drawing.Size(183, 36);
            this.add_hotel_btn.TabIndex = 15;
            this.add_hotel_btn.Text = "Add hotel";
            this.add_hotel_btn.UseVisualStyleBackColor = true;
            this.add_hotel_btn.Click += new System.EventHandler(this.add_hotel_btn_Click);
            // 
            // sqliteCommand1
            // 
            this.sqliteCommand1.CommandTimeout = 30;
            this.sqliteCommand1.Connection = null;
            this.sqliteCommand1.Transaction = null;
            this.sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // transfer_comboBox
            // 
            this.transfer_comboBox.FormattingEnabled = true;
            this.transfer_comboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.transfer_comboBox.Location = new System.Drawing.Point(298, 285);
            this.transfer_comboBox.Name = "transfer_comboBox";
            this.transfer_comboBox.Size = new System.Drawing.Size(183, 24);
            this.transfer_comboBox.TabIndex = 16;
            this.transfer_comboBox.SelectedIndexChanged += new System.EventHandler(this.transfer_comboBox_SelectedIndexChanged);
            // 
            // Add_Hotels_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transfer_comboBox);
            this.Controls.Add(this.add_hotel_btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.count_stars_textBox);
            this.Controls.Add(this.price_for_one_day_textBox);
            this.Controls.Add(this.hotel_textBox);
            this.Controls.Add(this.city_textBox);
            this.Controls.Add(this.country_textBox);
            this.Controls.Add(this.name_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Add_Hotels_Form";
            this.Text = "Add Hotels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox country_textBox;
        private System.Windows.Forms.TextBox city_textBox;
        private System.Windows.Forms.TextBox hotel_textBox;
        private System.Windows.Forms.TextBox price_for_one_day_textBox;
        private System.Windows.Forms.TextBox count_stars_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button add_hotel_btn;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private System.Windows.Forms.ComboBox transfer_comboBox;
    }
}