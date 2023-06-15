namespace coursework_2023_sell_ticket
{
    partial class Admin_panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_panel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_load_tabl = new System.Windows.Forms.Button();
            this.comboBox_vibor_tabl = new System.Windows.Forms.ComboBox();
            this.textBox_idUser = new System.Windows.Forms.TextBox();
            this.label_text_1 = new System.Windows.Forms.Label();
            this.label_text_2 = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label_text_3 = new System.Windows.Forms.Label();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.label_text_4 = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_text_5 = new System.Windows.Forms.Label();
            this.textBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.label_text_6 = new System.Windows.Forms.Label();
            this.textBox_PassportSeries = new System.Windows.Forms.TextBox();
            this.label_text_7 = new System.Windows.Forms.Label();
            this.textBox_Departure_Destination = new System.Windows.Forms.TextBox();
            this.label_text_8 = new System.Windows.Forms.Label();
            this.textBox_Seats = new System.Windows.Forms.TextBox();
            this.label_text_9 = new System.Windows.Forms.Label();
            this.textBox_Time = new System.Windows.Forms.TextBox();
            this.button_change_user = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_text_13 = new System.Windows.Forms.Label();
            this.textBox_SeatsBusi = new System.Windows.Forms.TextBox();
            this.label_text_11 = new System.Windows.Forms.Label();
            this.textBox_SeatsSid = new System.Windows.Forms.TextBox();
            this.label_text_10 = new System.Windows.Forms.Label();
            this.textBox_idSids = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_update = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel1.Controls.Add(this.comboBox_vibor_tabl);
            this.panel1.Controls.Add(this.button_load_tabl);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 43);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(1, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1087, 485);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel3.Controls.Add(this.label_text_9);
            this.panel3.Controls.Add(this.textBox_Time);
            this.panel3.Controls.Add(this.label_text_8);
            this.panel3.Controls.Add(this.label_text_7);
            this.panel3.Controls.Add(this.textBox_Seats);
            this.panel3.Controls.Add(this.textBox_Departure_Destination);
            this.panel3.Controls.Add(this.label_text_6);
            this.panel3.Controls.Add(this.textBox_PassportSeries);
            this.panel3.Controls.Add(this.label_text_5);
            this.panel3.Controls.Add(this.textBox_PhoneNumber);
            this.panel3.Controls.Add(this.label_text_4);
            this.panel3.Controls.Add(this.textBox_Email);
            this.panel3.Controls.Add(this.label_text_3);
            this.panel3.Controls.Add(this.textBox_LastName);
            this.panel3.Controls.Add(this.label_text_2);
            this.panel3.Controls.Add(this.textBox_FirstName);
            this.panel3.Controls.Add(this.label_text_1);
            this.panel3.Controls.Add(this.textBox_idUser);
            this.panel3.Location = new System.Drawing.Point(1, 528);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1087, 47);
            this.panel3.TabIndex = 2;
            // 
            // button_load_tabl
            // 
            this.button_load_tabl.Location = new System.Drawing.Point(954, 10);
            this.button_load_tabl.Name = "button_load_tabl";
            this.button_load_tabl.Size = new System.Drawing.Size(130, 21);
            this.button_load_tabl.TabIndex = 0;
            this.button_load_tabl.Text = "Вывести таблицу";
            this.button_load_tabl.UseVisualStyleBackColor = true;
            this.button_load_tabl.Click += new System.EventHandler(this.button_load_tabl_Click);
            // 
            // comboBox_vibor_tabl
            // 
            this.comboBox_vibor_tabl.FormattingEnabled = true;
            this.comboBox_vibor_tabl.Items.AddRange(new object[] {
            "Sids",
            "Users"});
            this.comboBox_vibor_tabl.Location = new System.Drawing.Point(818, 10);
            this.comboBox_vibor_tabl.Name = "comboBox_vibor_tabl";
            this.comboBox_vibor_tabl.Size = new System.Drawing.Size(130, 21);
            this.comboBox_vibor_tabl.TabIndex = 1;
            // 
            // textBox_idUser
            // 
            this.textBox_idUser.Location = new System.Drawing.Point(11, 19);
            this.textBox_idUser.Name = "textBox_idUser";
            this.textBox_idUser.Size = new System.Drawing.Size(100, 20);
            this.textBox_idUser.TabIndex = 0;
            // 
            // label_text_1
            // 
            this.label_text_1.AutoSize = true;
            this.label_text_1.Location = new System.Drawing.Point(12, 4);
            this.label_text_1.Name = "label_text_1";
            this.label_text_1.Size = new System.Drawing.Size(15, 13);
            this.label_text_1.TabIndex = 1;
            this.label_text_1.Text = "id";
            // 
            // label_text_2
            // 
            this.label_text_2.AutoSize = true;
            this.label_text_2.Location = new System.Drawing.Point(118, 4);
            this.label_text_2.Name = "label_text_2";
            this.label_text_2.Size = new System.Drawing.Size(54, 13);
            this.label_text_2.TabIndex = 3;
            this.label_text_2.Text = "FirstName";
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(117, 19);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(100, 20);
            this.textBox_FirstName.TabIndex = 2;
            // 
            // label_text_3
            // 
            this.label_text_3.AutoSize = true;
            this.label_text_3.Location = new System.Drawing.Point(224, 4);
            this.label_text_3.Name = "label_text_3";
            this.label_text_3.Size = new System.Drawing.Size(55, 13);
            this.label_text_3.TabIndex = 5;
            this.label_text_3.Text = "LastName";
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(223, 19);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(100, 20);
            this.textBox_LastName.TabIndex = 4;
            // 
            // label_text_4
            // 
            this.label_text_4.AutoSize = true;
            this.label_text_4.Location = new System.Drawing.Point(330, 4);
            this.label_text_4.Name = "label_text_4";
            this.label_text_4.Size = new System.Drawing.Size(32, 13);
            this.label_text_4.TabIndex = 7;
            this.label_text_4.Text = "Email";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(329, 19);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(100, 20);
            this.textBox_Email.TabIndex = 6;
            // 
            // label_text_5
            // 
            this.label_text_5.AutoSize = true;
            this.label_text_5.Location = new System.Drawing.Point(436, 4);
            this.label_text_5.Name = "label_text_5";
            this.label_text_5.Size = new System.Drawing.Size(75, 13);
            this.label_text_5.TabIndex = 9;
            this.label_text_5.Text = "PhoneNumber";
            // 
            // textBox_PhoneNumber
            // 
            this.textBox_PhoneNumber.Location = new System.Drawing.Point(435, 19);
            this.textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            this.textBox_PhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textBox_PhoneNumber.TabIndex = 8;
            // 
            // label_text_6
            // 
            this.label_text_6.AutoSize = true;
            this.label_text_6.Location = new System.Drawing.Point(542, 4);
            this.label_text_6.Name = "label_text_6";
            this.label_text_6.Size = new System.Drawing.Size(77, 13);
            this.label_text_6.TabIndex = 11;
            this.label_text_6.Text = "PassportSeries";
            // 
            // textBox_PassportSeries
            // 
            this.textBox_PassportSeries.Location = new System.Drawing.Point(541, 19);
            this.textBox_PassportSeries.Name = "textBox_PassportSeries";
            this.textBox_PassportSeries.Size = new System.Drawing.Size(100, 20);
            this.textBox_PassportSeries.TabIndex = 10;
            // 
            // label_text_7
            // 
            this.label_text_7.AutoSize = true;
            this.label_text_7.Location = new System.Drawing.Point(648, 4);
            this.label_text_7.Name = "label_text_7";
            this.label_text_7.Size = new System.Drawing.Size(99, 13);
            this.label_text_7.TabIndex = 13;
            this.label_text_7.Text = "Departure_Destin...";
            // 
            // textBox_Departure_Destination
            // 
            this.textBox_Departure_Destination.Location = new System.Drawing.Point(647, 19);
            this.textBox_Departure_Destination.Name = "textBox_Departure_Destination";
            this.textBox_Departure_Destination.Size = new System.Drawing.Size(100, 20);
            this.textBox_Departure_Destination.TabIndex = 12;
            // 
            // label_text_8
            // 
            this.label_text_8.AutoSize = true;
            this.label_text_8.Location = new System.Drawing.Point(754, 4);
            this.label_text_8.Name = "label_text_8";
            this.label_text_8.Size = new System.Drawing.Size(34, 13);
            this.label_text_8.TabIndex = 13;
            this.label_text_8.Text = "Seats";
            // 
            // textBox_Seats
            // 
            this.textBox_Seats.Location = new System.Drawing.Point(753, 19);
            this.textBox_Seats.Name = "textBox_Seats";
            this.textBox_Seats.Size = new System.Drawing.Size(100, 20);
            this.textBox_Seats.TabIndex = 12;
            // 
            // label_text_9
            // 
            this.label_text_9.AutoSize = true;
            this.label_text_9.Location = new System.Drawing.Point(860, 4);
            this.label_text_9.Name = "label_text_9";
            this.label_text_9.Size = new System.Drawing.Size(30, 13);
            this.label_text_9.TabIndex = 15;
            this.label_text_9.Text = "Time";
            // 
            // textBox_Time
            // 
            this.textBox_Time.Location = new System.Drawing.Point(859, 19);
            this.textBox_Time.Name = "textBox_Time";
            this.textBox_Time.Size = new System.Drawing.Size(100, 20);
            this.textBox_Time.TabIndex = 14;
            // 
            // button_change_user
            // 
            this.button_change_user.Location = new System.Drawing.Point(859, 19);
            this.button_change_user.Name = "button_change_user";
            this.button_change_user.Size = new System.Drawing.Size(100, 25);
            this.button_change_user.TabIndex = 16;
            this.button_change_user.Text = "Изменить";
            this.button_change_user.UseVisualStyleBackColor = true;
            this.button_change_user.Click += new System.EventHandler(this.button_change_user_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Location = new System.Drawing.Point(1, 573);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1087, 10);
            this.panel4.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel5.Controls.Add(this.button_change_user);
            this.panel5.Controls.Add(this.button_update);
            this.panel5.Controls.Add(this.label_text_13);
            this.panel5.Controls.Add(this.textBox_SeatsBusi);
            this.panel5.Controls.Add(this.label_text_11);
            this.panel5.Controls.Add(this.textBox_SeatsSid);
            this.panel5.Controls.Add(this.label_text_10);
            this.panel5.Controls.Add(this.textBox_idSids);
            this.panel5.Location = new System.Drawing.Point(1, 581);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1087, 58);
            this.panel5.TabIndex = 17;
            // 
            // label_text_13
            // 
            this.label_text_13.AutoSize = true;
            this.label_text_13.Location = new System.Drawing.Point(224, 4);
            this.label_text_13.Name = "label_text_13";
            this.label_text_13.Size = new System.Drawing.Size(54, 13);
            this.label_text_13.TabIndex = 5;
            this.label_text_13.Text = "SeatsBusi";
            // 
            // textBox_SeatsBusi
            // 
            this.textBox_SeatsBusi.Location = new System.Drawing.Point(223, 19);
            this.textBox_SeatsBusi.Name = "textBox_SeatsBusi";
            this.textBox_SeatsBusi.Size = new System.Drawing.Size(100, 20);
            this.textBox_SeatsBusi.TabIndex = 4;
            // 
            // label_text_11
            // 
            this.label_text_11.AutoSize = true;
            this.label_text_11.Location = new System.Drawing.Point(118, 4);
            this.label_text_11.Name = "label_text_11";
            this.label_text_11.Size = new System.Drawing.Size(34, 13);
            this.label_text_11.TabIndex = 3;
            this.label_text_11.Text = "Seats";
            // 
            // textBox_SeatsSid
            // 
            this.textBox_SeatsSid.Location = new System.Drawing.Point(117, 19);
            this.textBox_SeatsSid.Name = "textBox_SeatsSid";
            this.textBox_SeatsSid.Size = new System.Drawing.Size(100, 20);
            this.textBox_SeatsSid.TabIndex = 2;
            // 
            // label_text_10
            // 
            this.label_text_10.AutoSize = true;
            this.label_text_10.Location = new System.Drawing.Point(12, 4);
            this.label_text_10.Name = "label_text_10";
            this.label_text_10.Size = new System.Drawing.Size(15, 13);
            this.label_text_10.TabIndex = 1;
            this.label_text_10.Text = "id";
            // 
            // textBox_idSids
            // 
            this.textBox_idSids.Location = new System.Drawing.Point(11, 19);
            this.textBox_idSids.Name = "textBox_idSids";
            this.textBox_idSids.Size = new System.Drawing.Size(100, 20);
            this.textBox_idSids.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1087, 485);
            this.dataGridView1.TabIndex = 1;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(968, 19);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(100, 25);
            this.button_update.TabIndex = 17;
            this.button_update.Text = "Обновить";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // Admin_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 639);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin_panel";
            this.Text = "Admin panel";
            this.Load += new System.EventHandler(this.Admin_panel_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_load_tabl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox_vibor_tabl;
        private System.Windows.Forms.Label label_text_7;
        private System.Windows.Forms.TextBox textBox_Departure_Destination;
        private System.Windows.Forms.Label label_text_6;
        private System.Windows.Forms.TextBox textBox_PassportSeries;
        private System.Windows.Forms.Label label_text_5;
        private System.Windows.Forms.TextBox textBox_PhoneNumber;
        private System.Windows.Forms.Label label_text_4;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_text_3;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.Label label_text_2;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Label label_text_1;
        private System.Windows.Forms.TextBox textBox_idUser;
        private System.Windows.Forms.Button button_change_user;
        private System.Windows.Forms.Label label_text_9;
        private System.Windows.Forms.TextBox textBox_Time;
        private System.Windows.Forms.Label label_text_8;
        private System.Windows.Forms.TextBox textBox_Seats;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label_text_13;
        private System.Windows.Forms.TextBox textBox_SeatsBusi;
        private System.Windows.Forms.Label label_text_11;
        private System.Windows.Forms.TextBox textBox_SeatsSid;
        private System.Windows.Forms.Label label_text_10;
        private System.Windows.Forms.TextBox textBox_idSids;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_update;
    }
}