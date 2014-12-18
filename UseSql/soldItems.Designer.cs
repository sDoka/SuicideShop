namespace UseSql
{
    partial class soldItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(soldItems));
            this.dgw1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.sell_button = new System.Windows.Forms.Button();
            this.ll1 = new System.Windows.Forms.LinkLabel();
            this.ll2 = new System.Windows.Forms.LinkLabel();
            this.final_sell_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw1
            // 
            this.dgw1.AllowUserToAddRows = false;
            this.dgw1.AllowUserToDeleteRows = false;
            this.dgw1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgw1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgw1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgw1.GridColor = System.Drawing.SystemColors.Window;
            this.dgw1.Location = new System.Drawing.Point(-2, 1);
            this.dgw1.MultiSelect = false;
            this.dgw1.Name = "dgw1";
            this.dgw1.ReadOnly = true;
            this.dgw1.RowHeadersVisible = false;
            this.dgw1.Size = new System.Drawing.Size(653, 169);
            this.dgw1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sell_button
            // 
            this.sell_button.Location = new System.Drawing.Point(384, 176);
            this.sell_button.Name = "sell_button";
            this.sell_button.Size = new System.Drawing.Size(159, 23);
            this.sell_button.TabIndex = 5;
            this.sell_button.Text = "Зарегистрировать продажу";
            this.sell_button.UseVisualStyleBackColor = true;
            this.sell_button.Click += new System.EventHandler(this.new_sell);
            // 
            // ll1
            // 
            this.ll1.AutoSize = true;
            this.ll1.LinkColor = System.Drawing.Color.Black;
            this.ll1.Location = new System.Drawing.Point(13, 176);
            this.ll1.Name = "ll1";
            this.ll1.Size = new System.Drawing.Size(208, 13);
            this.ll1.TabIndex = 6;
            this.ll1.TabStop = true;
            this.ll1.Text = "Сейчас отображены проданные товары";
            // 
            // ll2
            // 
            this.ll2.AutoSize = true;
            this.ll2.LinkColor = System.Drawing.Color.Black;
            this.ll2.Location = new System.Drawing.Point(12, 176);
            this.ll2.Name = "ll2";
            this.ll2.Size = new System.Drawing.Size(202, 13);
            this.ll2.TabIndex = 7;
            this.ll2.TabStop = true;
            this.ll2.Text = "Сейчас отображены товары в наличии";
            this.ll2.Visible = false;
            // 
            // final_sell_button
            // 
            this.final_sell_button.Location = new System.Drawing.Point(384, 176);
            this.final_sell_button.Name = "final_sell_button";
            this.final_sell_button.Size = new System.Drawing.Size(159, 23);
            this.final_sell_button.TabIndex = 8;
            this.final_sell_button.Text = "Подтвердить регистрацию";
            this.final_sell_button.UseVisualStyleBackColor = true;
            this.final_sell_button.Visible = false;
            this.final_sell_button.Click += new System.EventHandler(this.final_sell_button_Click);
            // 
            // soldItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 211);
            this.Controls.Add(this.final_sell_button);
            this.Controls.Add(this.ll2);
            this.Controls.Add(this.ll1);
            this.Controls.Add(this.sell_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgw1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "soldItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проданные товары";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.soldItems_FormClosing);
            this.Load += new System.EventHandler(this.sold_items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sell_button;
        private System.Windows.Forms.LinkLabel ll1;
        private System.Windows.Forms.LinkLabel ll2;
        private System.Windows.Forms.Button final_sell_button;

    }
}