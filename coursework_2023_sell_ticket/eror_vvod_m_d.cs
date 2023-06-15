﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework_2023_sell_ticket
{
    public partial class eror_vvod_m_d : Form
    {
        public SqlConnection sqlConnection = null;
        public eror_vvod_m_d()
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
                    label1.Text = "Невірний номер";
                    label2.Text = "телефона";
                }
                else if (choice == 2)
                {
                    label1.Text = "Invalid";
                    label2.Text = "phone number";
                }

            }

            else
            {
                Console.WriteLine("Результат из базы данных равен null или не удалось преобразовать в число");
            }
        }
    }
}
