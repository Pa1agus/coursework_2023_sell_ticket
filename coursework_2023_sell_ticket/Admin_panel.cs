using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Data.Common;
using System.Collections.ObjectModel;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace coursework_2023_sell_ticket
{
    public partial class Admin_panel : Form
    {
        private Color currentColor = Color.LightGreen; // начальный цвет кнопки
        public Button selectedButton;
        private string sid;
        public SqlConnection sqlConnection = null;
        public Admin_panel()
        {
            InitializeComponent();
        }

        private void Admin_panel_Load(object sender, EventArgs e)
        {
            //-------------------------BD-Connect---------------------------------------------------------------
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_Fly"].ConnectionString);
            sqlConnection.Open();
            //--------------------------------------------------------------------------------------------------
        }

        private void button_load_tabl_Click(object sender, EventArgs e)
        {
            if (comboBox_vibor_tabl.Text == "Users")
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * FROM Users", sqlConnection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            else
            {
                if (comboBox_vibor_tabl.Text == "Sids")
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * FROM Sids", sqlConnection);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    dataGridView1.DataSource = dataSet.Tables[0];
                }
                else
                {
                    MessageBox.Show("Выбирите таблицу","eror!");
                }
            }
        }

        private void button_change_user_Click(object sender, EventArgs e)
        {
            if (comboBox_vibor_tabl.Text == "Users")
            {
                string updateQuery = "UPDATE [Users] SET FirstName = @FirstName, LastName = @LastName, Email = @Email, PhoneNumber = @PhoneNumber, PassportSeries = @PassportSeries, Departure_Destination = @Departure_Destination, Seats = @Seats, Time = @Time WHERE id = @id";

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_Fly"].ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Параметризовані значення
                        command.Parameters.AddWithValue("@FirstName", textBox_FirstName.Text);
                        command.Parameters.AddWithValue("@LastName", textBox_LastName.Text);
                        command.Parameters.AddWithValue("@Email", textBox_Email.Text);
                        command.Parameters.AddWithValue("@PhoneNumber", textBox_PhoneNumber.Text);
                        command.Parameters.AddWithValue("@PassportSeries", textBox_PassportSeries.Text);
                        command.Parameters.AddWithValue("@Departure_Destination", textBox_Departure_Destination.Text);
                        command.Parameters.AddWithValue("@Seats", textBox_Seats.Text);
                        command.Parameters.AddWithValue("@Time", textBox_Time.Text);
                        command.Parameters.AddWithValue("@id", textBox_idUser.Text);

                        // Виконуємо запит на оновлення
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Оновлення пройшло успішно
                            MessageBox.Show("Дані оновлено.");
                        }
                        else
                        {
                            // Жоден запис не було оновлено
                            MessageBox.Show("Не вдалося оновити дані.");
                        }
                    }
                }
            }
            else
            {
                if (comboBox_vibor_tabl.Text == "Sids")
                {
                    string updateQuery = "UPDATE [Sids] SET Seats = @Seats, SeatsBusi = @SeatsBusi WHERE id = @id";

                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_Fly"].ConnectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            // Параметризовані значення
                            command.Parameters.AddWithValue("@Seats", textBox_SeatsSid.Text);
                            command.Parameters.AddWithValue("@SeatsBusi", textBox_SeatsBusi.Text);
                            command.Parameters.AddWithValue("@id", textBox_idSids.Text);

                            // Виконуємо запит на оновлення
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Оновлення пройшло успішно
                                MessageBox.Show("Дані оновлено.");
                            }
                            else
                            {
                                // Жоден запис не було оновлено
                                MessageBox.Show("Не вдалося оновити дані.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выбирите таблицу", "eror!");
                }
            }
            
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (comboBox_vibor_tabl.Text == "Users")
            {
                string queryString = $"SELECT FirstName, LastName, Email, PhoneNumber, PassportSeries, Departure_Destination, Seats, Time FROM Users WHERE id = {textBox_idUser.Text}";
                //"FirstNam LastName Emai PhoneNumber PassportSeries Departure_Destination Seats Time WHERE id"
                DataTable dataTable = new DataTable();
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_Fly"].ConnectionString))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, connection))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }

                if (dataTable.Rows.Count > 0)
                {
                    string FirstNam = dataTable.Rows[0]["FirstName"].ToString();
                    string LastName = dataTable.Rows[0]["LastName"].ToString();
                    string Email = dataTable.Rows[0]["Email"].ToString();
                    string PhoneNumber = dataTable.Rows[0]["PhoneNumber"].ToString();
                    string PassportSeries = dataTable.Rows[0]["PassportSeries"].ToString();
                    string Departure_Destination = dataTable.Rows[0]["Departure_Destination"].ToString();
                    string Seats = dataTable.Rows[0]["Seats"].ToString();
                    string Time = dataTable.Rows[0]["Time"].ToString();

                    textBox_FirstName.Text = FirstNam;
                    textBox_LastName.Text = LastName;
                    textBox_Email.Text = Email;
                    textBox_PhoneNumber.Text = PhoneNumber;
                    textBox_PassportSeries.Text = PassportSeries;
                    textBox_Departure_Destination.Text = Departure_Destination;
                    textBox_Seats.Text = Seats;
                    textBox_Time.Text = Time;
                }
            }
            else
            {
                if (comboBox_vibor_tabl.Text == "Sids")
                {
                    string queryString = $"SELECT Seats, SeatsBusi FROM Sids WHERE id = {textBox_idSids.Text}";
                    //"FirstNam LastName Emai PhoneNumber PassportSeries Departure_Destination Seats Time WHERE id"
                    DataTable dataTable = new DataTable();
                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_Fly"].ConnectionString))
                    {
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, connection))
                        {
                            dataAdapter.Fill(dataTable);
                        }
                    }

                    if (dataTable.Rows.Count > 0)
                    {
                        string Seats = dataTable.Rows[0]["Seats"].ToString();
                        string SeatsBusi = dataTable.Rows[0]["SeatsBusi"].ToString();


                        textBox_SeatsSid.Text = Seats;
                        textBox_SeatsBusi.Text = SeatsBusi;
                    }
                }
                else
                {
                    MessageBox.Show("Выбирите таблицу", "eror!");
                }
            }
        }
    }
}
