
namespace Database_CSharp_2._0
{
    partial class Change_Contragents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Change_Contragents));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.update_data_contragents_btn = new System.Windows.Forms.Button();
            this.delete_data_contragents_btn = new System.Windows.Forms.Button();
            this.first_name_lbl = new System.Windows.Forms.Label();
            this.first_name_txtBox = new System.Windows.Forms.TextBox();
            this.last_name_lbl = new System.Windows.Forms.Label();
            this.last_name_txtBox = new System.Windows.Forms.TextBox();
            this.patronymic_lbl = new System.Windows.Forms.Label();
            this.patronymic_txtBox = new System.Windows.Forms.TextBox();
            this.phone_lbl = new System.Windows.Forms.Label();
            this.phone_txtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // update_data_contragents_btn
            // 
            resources.ApplyResources(this.update_data_contragents_btn, "update_data_contragents_btn");
            this.update_data_contragents_btn.Name = "update_data_contragents_btn";
            this.update_data_contragents_btn.UseVisualStyleBackColor = true;
            this.update_data_contragents_btn.Click += new System.EventHandler(this.update_data_contragents_btn_Click);
            // 
            // delete_data_contragents_btn
            // 
            resources.ApplyResources(this.delete_data_contragents_btn, "delete_data_contragents_btn");
            this.delete_data_contragents_btn.Name = "delete_data_contragents_btn";
            this.delete_data_contragents_btn.UseVisualStyleBackColor = true;
            this.delete_data_contragents_btn.Click += new System.EventHandler(this.delete_data_contragents_btn_Click);
            // 
            // first_name_lbl
            // 
            resources.ApplyResources(this.first_name_lbl, "first_name_lbl");
            this.first_name_lbl.Name = "first_name_lbl";
            // 
            // first_name_txtBox
            // 
            resources.ApplyResources(this.first_name_txtBox, "first_name_txtBox");
            this.first_name_txtBox.Name = "first_name_txtBox";
            this.first_name_txtBox.TextChanged += new System.EventHandler(this.first_name_txtBox_TextChanged);
            // 
            // last_name_lbl
            // 
            resources.ApplyResources(this.last_name_lbl, "last_name_lbl");
            this.last_name_lbl.Name = "last_name_lbl";
            // 
            // last_name_txtBox
            // 
            resources.ApplyResources(this.last_name_txtBox, "last_name_txtBox");
            this.last_name_txtBox.Name = "last_name_txtBox";
            this.last_name_txtBox.TextChanged += new System.EventHandler(this.last_name_txtBox_TextChanged);
            // 
            // patronymic_lbl
            // 
            resources.ApplyResources(this.patronymic_lbl, "patronymic_lbl");
            this.patronymic_lbl.Name = "patronymic_lbl";
            // 
            // patronymic_txtBox
            // 
            resources.ApplyResources(this.patronymic_txtBox, "patronymic_txtBox");
            this.patronymic_txtBox.Name = "patronymic_txtBox";
            this.patronymic_txtBox.TextChanged += new System.EventHandler(this.patronymic_txtBox_TextChanged);
            // 
            // phone_lbl
            // 
            resources.ApplyResources(this.phone_lbl, "phone_lbl");
            this.phone_lbl.Name = "phone_lbl";
            // 
            // phone_txtBox
            // 
            resources.ApplyResources(this.phone_txtBox, "phone_txtBox");
            this.phone_txtBox.Name = "phone_txtBox";
            this.phone_txtBox.TextChanged += new System.EventHandler(this.phone_txtBox_TextChanged);
            // 
            // Change_Contragents
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.phone_txtBox);
            this.Controls.Add(this.phone_lbl);
            this.Controls.Add(this.patronymic_txtBox);
            this.Controls.Add(this.patronymic_lbl);
            this.Controls.Add(this.last_name_txtBox);
            this.Controls.Add(this.last_name_lbl);
            this.Controls.Add(this.first_name_txtBox);
            this.Controls.Add(this.first_name_lbl);
            this.Controls.Add(this.delete_data_contragents_btn);
            this.Controls.Add(this.update_data_contragents_btn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Change_Contragents";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button update_data_contragents_btn;
        private System.Windows.Forms.Button delete_data_contragents_btn;
        private System.Windows.Forms.Label first_name_lbl;
        private System.Windows.Forms.TextBox first_name_txtBox;
        private System.Windows.Forms.Label last_name_lbl;
        private System.Windows.Forms.TextBox last_name_txtBox;
        private System.Windows.Forms.Label patronymic_lbl;
        private System.Windows.Forms.TextBox patronymic_txtBox;
        private System.Windows.Forms.Label phone_lbl;
        private System.Windows.Forms.TextBox phone_txtBox;
    }
}