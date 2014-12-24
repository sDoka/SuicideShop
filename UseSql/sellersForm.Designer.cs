namespace UseSql
{
    partial class sellersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sellersForm));
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.dgw1 = new System.Windows.Forms.DataGridView();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ll3 = new System.Windows.Forms.LinkLabel();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.ll4 = new System.Windows.Forms.LinkLabel();
            this.unlock_producer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb1
            // 
            this.cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(12, 31);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(121, 21);
            this.cb1.TabIndex = 0;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.cb1_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(12, 12);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(122, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Выберите поставщика";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.select_Seller);
            // 
            // dgw1
            // 
            this.dgw1.AllowUserToAddRows = false;
            this.dgw1.AllowUserToDeleteRows = false;
            this.dgw1.AllowUserToResizeColumns = false;
            this.dgw1.AllowUserToResizeRows = false;
            this.dgw1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgw1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgw1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw1.Location = new System.Drawing.Point(228, 31);
            this.dgw1.Name = "dgw1";
            this.dgw1.ReadOnly = true;
            this.dgw1.RowHeadersVisible = false;
            this.dgw1.Size = new System.Drawing.Size(321, 150);
            this.dgw1.TabIndex = 3;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(225, 12);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(162, 13);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Все товары этого поставщика";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Занести в чёрный список";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.add2_blackList);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 35);
            this.button3.TabIndex = 6;
            this.button3.Text = "Заставить побегать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 64);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(195, 35);
            this.button4.TabIndex = 7;
            this.button4.Text = "Добавить поставщика";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ll3
            // 
            this.ll3.ActiveLinkColor = System.Drawing.Color.Red;
            this.ll3.AutoSize = true;
            this.ll3.LinkColor = System.Drawing.Color.Red;
            this.ll3.Location = new System.Drawing.Point(406, 12);
            this.ll3.Name = "ll3";
            this.ll3.Size = new System.Drawing.Size(143, 13);
            this.ll3.TabIndex = 8;
            this.ll3.TabStop = true;
            this.ll3.Text = "Поставщик заблокирован!";
            this.ll3.Visible = false;
            // 
            // pb1
            // 
            this.pb1.Image = global::UseSql.Properties.Resources._75741;
            this.pb1.Location = new System.Drawing.Point(228, 31);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(321, 150);
            this.pb1.TabIndex = 9;
            this.pb1.TabStop = false;
            this.pb1.Visible = false;
            // 
            // ll4
            // 
            this.ll4.ActiveLinkColor = System.Drawing.Color.Black;
            this.ll4.AutoSize = true;
            this.ll4.LinkColor = System.Drawing.Color.Black;
            this.ll4.Location = new System.Drawing.Point(294, 184);
            this.ll4.Name = "ll4";
            this.ll4.Size = new System.Drawing.Size(223, 13);
            this.ll4.TabIndex = 10;
            this.ll4.TabStop = true;
            this.ll4.Text = "На складе нет товаров этого поставщика.";
            // 
            // unlock_producer
            // 
            this.unlock_producer.Location = new System.Drawing.Point(12, 105);
            this.unlock_producer.Name = "unlock_producer";
            this.unlock_producer.Size = new System.Drawing.Size(195, 35);
            this.unlock_producer.TabIndex = 11;
            this.unlock_producer.Text = "Разблокировать поставщика";
            this.unlock_producer.UseVisualStyleBackColor = true;
            this.unlock_producer.Visible = false;
            this.unlock_producer.Click += new System.EventHandler(this.unlock_producer_Click);
            // 
            // sellersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 206);
            this.Controls.Add(this.unlock_producer);
            this.Controls.Add(this.ll4);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.ll3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.dgw1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "sellersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с поставщиками";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sellersForm_FormClosing);
            this.Load += new System.EventHandler(this.sellersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgw1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.LinkLabel ll3;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.LinkLabel ll4;
        private System.Windows.Forms.Button unlock_producer;
    }
}