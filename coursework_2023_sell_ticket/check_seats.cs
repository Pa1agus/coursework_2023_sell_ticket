﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework_2023_sell_ticket
{
    public partial class check_seats : Form
    {
        public SqlConnection sqlConnection = null;
        public check_seats()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Закрываем текущую форму
            this.Close();
        }

        private void check_seats_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //-------------------------BD-----------------------------------------------------------------------
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_Fly"].ConnectionString);

            sqlConnection.Open();
            //--------------------------------------------------------------------------------------------------
            //---------------------------------------------Language---------------------------------------------
            string selectQuery = "SELECT [choice] FROM [Language] WHERE [id] = @Id";
            SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
            selectCommand.Parameters.AddWithValue("@Id", 1);

            object result = selectCommand.ExecuteScalar();
            if (result != null && int.TryParse(result.ToString(), out int choice))
            {
                if (choice == 1)
                {
                    label1.Text = "Ви не перевірили";
                    label2.Text = "місця";
                }
                else if (choice == 2)
                {
                    label1.Text = "You haven't";
                    label2.Text = "checked the seats";
                }

            }

            else
            {
                Console.WriteLine("Результат из базы данных равен null или не удалось преобразовать в число");
            }
        }
    }
}
