
namespace Database_CSharp_2._0
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ContragentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_Contagent_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Change_Contragent_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HotelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_Hotel_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Change_Hotel_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContragentsToolStripMenuItem,
            this.HotelsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ContragentsToolStripMenuItem
            // 
            this.ContragentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_Contagent_ToolStripMenuItem,
            this.Change_Contragent_ToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.ContragentsToolStripMenuItem.Name = "ContragentsToolStripMenuItem";
            this.ContragentsToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.ContragentsToolStripMenuItem.Text = "Contragents";
            // 
            // Add_Contagent_ToolStripMenuItem
            // 
            this.Add_Contagent_ToolStripMenuItem.Name = "Add_Contagent_ToolStripMenuItem";
            this.Add_Contagent_ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.Add_Contagent_ToolStripMenuItem.Text = "Add";
            this.Add_Contagent_ToolStripMenuItem.Click += new System.EventHandler(this.Add_Contagent_ToolStripMenuItem_Click);
            // 
            // Change_Contragent_ToolStripMenuItem
            // 
            this.Change_Contragent_ToolStripMenuItem.Name = "Change_Contragent_ToolStripMenuItem";
            this.Change_Contragent_ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.Change_Contragent_ToolStripMenuItem.Text = "Change";
            this.Change_Contragent_ToolStripMenuItem.Click += new System.EventHandler(this.Change_Contragent_ToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // HotelsToolStripMenuItem
            // 
            this.HotelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_Hotel_ToolStripMenuItem1,
            this.Change_Hotel_ToolStripMenuItem1});
            this.HotelsToolStripMenuItem.Name = "HotelsToolStripMenuItem";
            this.HotelsToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.HotelsToolStripMenuItem.Text = "Hotels";
            // 
            // Add_Hotel_ToolStripMenuItem1
            // 
            this.Add_Hotel_ToolStripMenuItem1.Name = "Add_Hotel_ToolStripMenuItem1";
            this.Add_Hotel_ToolStripMenuItem1.Size = new System.Drawing.Size(142, 26);
            this.Add_Hotel_ToolStripMenuItem1.Text = "Add";
            this.Add_Hotel_ToolStripMenuItem1.Click += new System.EventHandler(this.Add_Hotel_ToolStripMenuItem1_Click);
            // 
            // Change_Hotel_ToolStripMenuItem1
            // 
            this.Change_Hotel_ToolStripMenuItem1.Name = "Change_Hotel_ToolStripMenuItem1";
            this.Change_Hotel_ToolStripMenuItem1.Size = new System.Drawing.Size(142, 26);
            this.Change_Hotel_ToolStripMenuItem1.Text = "Change";
            this.Change_Hotel_ToolStripMenuItem1.Click += new System.EventHandler(this.Change_Hotel_ToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(772, 500);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(772, 528);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Program";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ContragentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Add_Contagent_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Change_Contragent_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HotelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Add_Hotel_ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Change_Hotel_ToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
    }
}

