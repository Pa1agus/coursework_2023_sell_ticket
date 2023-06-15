using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------------------------------
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections;


namespace coursework_2023_sell_ticket
{
    public partial class Sell : Form
    {
        private Color currentColor = Color.LightGreen; // начальный цвет кнопки
        public Button selectedButton;
        private string sid;
        public SqlConnection sqlConnection = null;

        public Sell()
        {
            InitializeComponent();
        }

        private void Sell_Load(object sender, EventArgs e)
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
                    label_departure.Text = "Звідки - куди";
                    label_departure_date.Text = "Дата";
                    check_seats.Text = "Перевірка наявності місць";
                    label_emeil.Text = "Введіть свій emeil";
                    label_nomer.Text = "Введіть номер телефону";
                    label_first_name.Text = "Введіть ім'я";
                    label_last_name.Text = "Введіть прізвище";
                    label_passport_number.Text = "Введіть серію паспорта";
                    Verifi_bat.Text = "Подтвердить";
                    label1.Text = "Посадковий квиток";
                    label4.Text = "Прізвище";
                    label6.Text = "Ім'я";
                    label7.Text = "З";
                    label8.Text = "У";
                    label9.Text = "Дата";
                    label10.Text = "Номер рейсу";
                    label2.Text = "Посадковий квиток";
                    label3.Text = "Прізвище";
                    label5.Text = "Ім'я";
                    label_teckst.Text = "З";
                    label_text_09.Text = "У";
                    label_text_08.Text = "Дата";
                    label_text_07.Text = "Номер рейсу";
                    label11.Text = "Сидіння";
                    button_language.Text = "УКР";
                }
                else if (choice == 2)
                {
                    label_departure.Text = "From - To";
                    label_departure_date.Text = "Date";
                    check_seats.Text = "Check Seat Availability";
                    label_emeil.Text = "Enter your email";
                    label_nomer.Text = "Enter phone number";
                    label_first_name.Text = "Enter first name";
                    label_last_name.Text = "Enter last name";
                    label_passport_number.Text = "Enter passport series";
                    Verifi_bat.Text = "Verify";
                    label1.Text = "Boarding Pass";
                    label4.Text = "Last Name";
                    label6.Text = "First Name";
                    label7.Text = "From";
                    label8.Text = "To";
                    label9.Text = "Date";
                    label10.Text = "Flight Number";
                    label2.Text = "Boarding Pass";
                    label3.Text = "Last Name";
                    label5.Text = "First Name";
                    label_teckst.Text = "From";
                    label_text_09.Text = "To";
                    label_text_08.Text = "Date";
                    label_text_07.Text = "Flight Number";
                    label11.Text = "Seat";
                    button_language.Text = "ENG";
                }

            }

            else
            {
                Console.WriteLine("Результат из базы данных равен null или не удалось преобразовать в число");
            }
        }

        private void button_language_Click_1(object sender, EventArgs e)
        {
            if (button_language.Text == "УКР")
            {
                label_departure.Text = "From - To";
                label_departure_date.Text = "Date";
                check_seats.Text = "Check Seat Availability";
                label_emeil.Text = "Enter your email";
                label_nomer.Text = "Enter phone number";
                label_first_name.Text = "Enter first name";
                label_last_name.Text = "Enter last name";
                label_passport_number.Text = "Enter passport series";
                Verifi_bat.Text = "Verify";
                label1.Text = "Boarding Pass";
                label4.Text = "Last Name";
                label6.Text = "First Name";
                label7.Text = "From";
                label8.Text = "To";
                label9.Text = "Date";
                label10.Text = "Flight Number";
                label2.Text = "Boarding Pass";
                label3.Text = "Last Name";
                label5.Text = "First Name";
                label_teckst.Text = "From";
                label_text_09.Text = "To";
                label_text_08.Text = "Date";
                label_text_07.Text = "Flight Number";
                label11.Text = "Seat";
                button_language.Text = "ENG";

                string updateQuery = "UPDATE [Language] SET [choice] = 2 WHERE [id] = 1"; // Запрос для изменения значения на 2
                SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
                updateCommand.ExecuteNonQuery(); // Выполняем запрос обновления

            }
            else if (button_language.Text == "ENG")
            {
                label_departure.Text = "Звідки - куди";
                label_departure_date.Text = "Дата";
                check_seats.Text = "Перевірка наявності місць";
                label_emeil.Text = "Введіть свій emeil";
                label_nomer.Text = "Введіть номер телефону";
                label_first_name.Text = "Введіть ім'я";
                label_last_name.Text = "Введіть прізвище";
                label_passport_number.Text = "Введіть серію паспорта";
                Verifi_bat.Text = "Подтвердить";
                label1.Text = "Посадковий квиток";
                label4.Text = "Прізвище";
                label6.Text = "Ім'я";
                label7.Text = "З";
                label8.Text = "У";
                label9.Text = "Дата";
                label10.Text = "Номер рейсу";
                label2.Text = "Посадковий квиток";
                label3.Text = "Прізвище";
                label5.Text = "Ім'я";
                label_teckst.Text = "З";
                label_text_09.Text = "У";
                label_text_08.Text = "Дата";
                label_text_07.Text = "Номер рейсу";
                label11.Text = "Сидіння";
                button_language.Text = "УКР";

                string updateQuery = "UPDATE [Language] SET [choice] = 1 WHERE [id] = 1"; // Запрос для изменения значения на 1
                SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
                updateCommand.ExecuteNonQuery(); // Выполняем запрос обновления
            }
        }

        private void check_seats_Click(object sender, EventArgs e)
        {
            for (char row = 'A'; row <= 'E'; row++)
            {
                for (int col = 1; col <= 9; col++)
                {
                    string buttonName = $"{row}{col}";
                    Button button = Controls.Find(buttonName, true).FirstOrDefault() as Button;

                    if (button != null)
                    {
                        button.BackColor = Color.LightGreen; // Изменяем цвет кнопки на красный
                        button.ForeColor = Color.Black;
                    }
                }
            }
            //--------------------------------------------Проверка-мест---------------------------------------------------------
            if (comboBox_departure.Text == "Київ, Україна - Торонто, Канада" && comboBox_departure_date.Text == "06-07-2023")
            {
                string selectQuery = "SELECT [Seats] FROM [Sids] WHERE [SeatsBusi] = 1 AND [Id] BETWEEN 1 AND 18";
                SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);

                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string seat = reader.IsDBNull(0) ? null : reader.GetString(0); // Получаем значение из столбца [Seats], обрабатывая возможное значение null

                        // Ищем кнопку с соответствующим именем
                        Button button = Controls.Find(seat, true).FirstOrDefault() as Button;

                        if (button != null)
                        {
                            button.BackColor = Color.Black; // Изменяем цвет кнопки на 
                            button.ForeColor = Color.White; // Изменяет цвет текста на белый
                        }
                    }
                }
                check_seats.BackColor = Color.LightGreen;
            }
            //-------------------------------------------------------------------------------------------------------------------
            else
            {
                if (comboBox_departure.Text == "Полтава, Україна - Вовківка, Україна" && comboBox_departure_date.Text == "06-07-2023")
                {
                    string selectQuery = "SELECT [Seats] FROM [Sids] WHERE [SeatsBusi] = 1 AND [Id] BETWEEN 20 AND 37";
                    SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string seat = reader.IsDBNull(0) ? null : reader.GetString(0); // Получаем значение из столбца [Seats], обрабатывая возможное значение null

                            // Ищем кнопку с соответствующим именем
                            Button button = Controls.Find(seat, true).FirstOrDefault() as Button;

                            if (button != null)
                            {
                                button.BackColor = Color.Black; // Изменяем цвет кнопки на красный
                                button.ForeColor = Color.White; // Изменяет цвет текста на белый
                            }
                        }
                    }
                    check_seats.BackColor = Color.LightGreen;
                }
                //---------------------------------------------------------------------------------------------------------------------
                else
                {
                    eror_vvod_m_d eror_vvod_m_d = new eror_vvod_m_d();
                    eror_vvod_m_d.Show();
                }
                //---------------------------------------------------------------------------------------------------------------------
            }


        }
        private void Verifi_bat_Click(object sender, EventArgs e)
        {
            //---------------------------------------------------------------------------------------------------------------------
            if (string.IsNullOrEmpty(comboBox_departure.Text) || string.IsNullOrEmpty(comboBox_departure_date.Text) || string.IsNullOrEmpty(textBox_emeil.Text) || string.IsNullOrEmpty(textBox_nomer.Text) || string.IsNullOrEmpty(textBox_first_name.Text) || string.IsNullOrEmpty(textBox_last_name.Text) || string.IsNullOrEmpty(textBox_passport_number.Text))
            {
                // Выполнить код, если текст в comboBox_departure или comboBox_departure_date пустой или равен null
                eror_null eror_null = new eror_null();
                eror_null.Show();
            }
            else
            {
                // Выполнить код, если текст в comboBox_departure и comboBox_departure_date не являются пустыми или null

                if (sid != null)
                {                    
                    if (check_seats.BackColor == Color.LightGreen )
                    {
                        string phoneNumber = textBox_nomer.Text;
                        Button button = Controls.Find(sid, true).FirstOrDefault() as Button;
                        if (button.BackColor != Color.Black)
                        {
                            if (phoneNumber.Length == 12)
                            {
                                //-------------------------Переменные-------------------------------
                                string Departure = comboBox_departure.SelectedItem.ToString();
                                string Departure_date = comboBox_departure_date.SelectedItem.ToString();
                                string Email = textBox_emeil.Text;
                                string Nomer = textBox_nomer.Text;
                                string First_name = textBox_first_name.Text;
                                string Last_name = textBox_last_name.Text;
                                string Passport_number = textBox_passport_number.Text;
                                //-----------------Удаление "-" из selectedDeparture----------------
                                string[] cities = Departure.Split('-');
                                string departure = cities[0].Trim();
                                string destination = cities[1].Trim();
                                //-----------------------Дата тоже самое*---------------------------
                                string[] data = Departure_date.Split('-');
                                string Month = data[0].Trim();
                                string Day = data[1].Trim();
                                string Year = data[2].Trim();
                                //-------------------------Вывод------------------------------------
                                label_last_name_viv_2.Text = Last_name;
                                label_last_name_viv.Text = Last_name;
                                label_first_name_viv_2.Text = First_name;
                                label_first_name_viv.Text = First_name;
                                label_from_2.Text = departure;
                                label_from.Text = departure;
                                label_to_2.Text = destination;
                                label_to.Text = destination;
                                label_data_time_2.Text = Departure_date;
                                label_data_time.Text = Departure_date;
                                if (comboBox_departure.Text == "Київ, Україна - Торонто, Канада" && comboBox_departure_date.Text == "06-07-2023")
                                {
                                    label_nomber_res_2.Text = "KYTK-6_7_223";
                                    label_nomber_res.Text = "KYTK-6_7_223";
                                }
                                else
                                {
                                    if (comboBox_departure.Text == "Полтава, Україна - Вовківка, Україна" && comboBox_departure_date.Text == "06-07-2023")
                                    {
                                        label_nomber_res_2.Text = "PYVY-6_7_223";
                                        label_nomber_res.Text = "PYVY-6_7_223";
                                    }
                                }
                                sidenie.Text = Convert.ToString(sid);
                                Verifi_bat.BackColor = Color.LimeGreen;
                                //--------------------------Users-------------------------------------

                                SqlCommand command = new SqlCommand("INSERT INTO [Users] (FirstName, LastName, Email, PhoneNumber, PassportSeries, Departure_Destination, Seats, Time) VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @PassportSeries, @Departure_Destination, @Seats, @Time)", sqlConnection);

                                command.Parameters.AddWithValue("@FirstName", First_name);
                                command.Parameters.AddWithValue("@LastName", Last_name);
                                command.Parameters.AddWithValue("@Email", Email);
                                command.Parameters.AddWithValue("@PhoneNumber", Nomer);
                                command.Parameters.AddWithValue("@PassportSeries", Passport_number);
                                command.Parameters.AddWithValue("@Departure_Destination", Departure);
                                command.Parameters.AddWithValue("@Seats", sid);
                                command.Parameters.AddWithValue("@Time", Departure_date);

                                command.ExecuteNonQuery().ToString();

                                //------------------------Sids-------------------------------------------
                                if (comboBox_departure.Text == "Київ, Україна - Торонто, Канада" && comboBox_departure_date.Text == "06-07-2023")
                                {
                                    string updateQuery = "UPDATE [Sids] SET [SeatsBusi] = 1 WHERE [Id] BETWEEN 1 AND 18 AND [Seats] = @Seats";

                                    SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);

                                    updateCommand.Parameters.AddWithValue("@Seats", sid);

                                    updateCommand.ExecuteNonQuery();
                                }
                                if (comboBox_departure.Text == "Полтава, Україна - Вовківка, Україна" && comboBox_departure_date.Text == "06-07-2023")
                                {
                                    string updateQuery = "UPDATE [Sids] SET [SeatsBusi] = 1 WHERE [Id] BETWEEN 20 AND 37 AND [Seats] = @Seats";

                                    SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);

                                    updateCommand.Parameters.AddWithValue("@Seats", sid);

                                    updateCommand.ExecuteNonQuery();
                                }
                                //------------------------Предотвращение спама----------------------------
                                comboBox_departure.Text = "";
                                comboBox_departure_date.Text = "";
                                textBox_emeil.Text = "@gmail.com";
                                textBox_nomer.Text = "380";
                                textBox_first_name.Text = "";
                                textBox_last_name.Text = "";
                                textBox_passport_number.Text = "";
                                sid = null;

                            }
                            else
                            {
                                check_seats eror_check = new check_seats();
                                eror_check.Show();
                            }
                        }
                        else
                        {
                            eror_sid eror_sid = new eror_sid();
                            eror_sid.Show();
                        }
                    }
                    
                }
                else
                {
                    eror_sid eror_sid = new eror_sid();
                    eror_sid.Show();
                }
            }
        }

        private void Admin_Panel_Click(object sender, EventArgs e)
        {
            Admin_panel adminPanel = new Admin_panel();
            adminPanel.Show();
        }

        private void A1_Click(object sender, EventArgs e)
        {
            Button seatButton = (Button)sender;
            if (seatButton.BackColor != Color.Black)
            {
                if (selectedButton != null)
                {
                    selectedButton.BackColor = Color.LightGreen;
                }


                seatButton.BackColor = Color.Red;
                selectedButton = seatButton;

                if (seatButton.BackColor == Color.Red)
                {
                    sid = seatButton.Text;
                }
            }
        }
        private void A2_Click(object sender, EventArgs e)
        {
            Button seatButton = (Button)sender;
            if (seatButton.BackColor != Color.Black)
            {
                if (selectedButton != null)
                {
                    selectedButton.BackColor = Color.LightGreen;
                }


                seatButton.BackColor = Color.Red;
                selectedButton = seatButton;

                if (seatButton.BackColor == Color.Red)
                {
                    sid = seatButton.Text;
                }
            }
        }

        private void A3_Click(object sender, EventArgs e)
        {
            Button seatButton = (Button)sender;
            if (seatButton.BackColor != Color.Black)
            {
                if (selectedButton != null)
                {
                    selectedButton.BackColor = Color.LightGreen;
                }


                seatButton.BackColor = Color.Red;
                selectedButton = seatButton;

                if (seatButton.BackColor == Color.Red)
                {
                    sid = seatButton.Text;
                }
            }
        }

        private void A4_Click(object sender, EventArgs e)
        {
            Button seatButton = (Button)sender;
            if (seatButton.BackColor != Color.Black)
            {
                if (selectedButton != null)
                {
                    selectedButton.BackColor = Color.LightGreen;
                }


                seatButton.BackColor = Color.Red;
                selectedButton = seatButton;

                if (seatButton.BackColor == Color.Red)
                {
                    sid = seatButton.Text;
                }
            }
        }

        private void A5_Click(object sender, EventArgs e)
        {
            Button seatButton = (Button)sender;
            if (seatButton.BackColor != Color.Black)
            {
                if (selectedButton != null)
                {
                    selectedButton.BackColor = Color.LightGreen;
                }


                seatButton.BackColor = Color.Red;
                selectedButton = seatButton;

                if (seatButton.BackColor == Color.Red)
                {
                    sid = seatButton.Text;
                }
            }
        }

        private void A6_Click(object sender, EventArgs e)
        {
            Button seatButton = (Button)sender;
            if (seatButton.BackColor != Color.Black)
            {
                if (selectedButton != null)
                {
                    selectedButton.BackColor = Color.LightGreen;
                }


                seatButton.BackColor = Color.Red;
                selectedButton = seatButton;

                if (seatButton.BackColor == Color.Red)
                {
                    sid = seatButton.Text;
                }
            }
        }

        private void A7_Click(object sender, EventArgs e)
        {
            Button seatButton = (Button)sender;
            if (seatButton.BackColor != Color.Black)
            {
                if (selectedButton != null)
                {
                    selectedButton.BackColor = Color.LightGreen;
                }


                seatButton.BackColor = Color.Red;
                selectedButton = seatButton;

                if (seatButton.BackColor == Color.Red)
                {
                    sid = seatButton.Text;
                }
            }
        }

        private void A8_Click(object sender, EventArgs e)
        {
            Button seatButton = (Button)sender;
            if (seatButton.BackColor != Color.Black)
            {
                if (selectedButton != null)
                {
                    selectedButton.BackColor = Color.LightGreen;
                }


                seatButton.BackColor = Color.Red;
                selectedButton = seatButton;

                if (seatButton.BackColor == Color.Red)
                {
                    sid = seatButton.Text;
                }
            }
        }

        private void A9_Click(object sender, EventArgs e)
        {
            Button seatButton = (Button)sender;
            if (seatButton.BackColor != Color.Black)
            {
                if (selectedButton != null)
                {
                    selectedButton.BackColor = Color.LightGreen;
                }


                seatButton.BackColor = Color.Red;
                selectedButton = seatButton;

                if (seatButton.BackColor == Color.Red)
                {
                    sid = seatButton.Text;
                }
            }
        }

        private void E1_Click(object sender, EventArgs e)
        {
            Button seatButton = (Button)sender;
            if (seatButton.BackColor != Color.Black)
            {
                if (selectedButton != null)
                {
                    selectedButton.BackColor = Color.LightGreen;
                }


                seatButton.BackColor = Color.Red;
                selectedButton = seatButton;

                if (seatButton.BackColor == Color.Red)
                {
                    sid = seatButton.Text;
                }
            }
        }

        private void E2_Click(object sender, EventArgs e)
        {
            Button seatButton = (Button)sender;
            if (seatButton.BackColor != Color.Black)
            {
                if (selectedButton != null)
                {
                    selectedButton.BackColor = Color.LightGreen;
                }


                seatButton.BackColor = Color.Red;
                selectedButton = seatButton;

                if (seatButton.BackColor == Color.Red)
                {
                    sid = seatButton.Text;
                }
            }
        }

        private void E3_Click(object sender, EventArgs e)
        {
            Button seatButton = (Button)sender;
            if (seatButton.BackColor != Color.Black)
            {
                if (selectedButton != null)
                {
                    selectedButton.BackColor = Color.LightGreen;
                }


                seatButton.BackColor = Color.Red;
                selectedButton = seatButton;

                if (seatButton.BackColor == Color.Red)
                {
                    sid = seatButton.Text;
                }
            }
        }

        private void E4_Click(object sender, EventArgs e)
        {
            Button seatButton = (Button)sender;
            if (seatButton.BackColor != Color.Black)
            {
                if (selectedButton != null)
                {
                    selectedButton.BackColor = Color.LightGreen;
                }


                seatButton.BackColor = Color.Red;
                selectedButton = seatButton;

                if (seatButton.BackColor == Color.Red)
                {
                    sid = seatButton.Text;
                }
            }
        }

        private void E5_Click(object sender, EventArgs e)
        {
            Button seatButton = (Button)sender;
            if (seatButton.BackColor != Color.Black)
            {
                if (selectedButton != null)
                {
                    selectedButton.BackColor = Color.LightGreen;
                }


                seatButton.BackColor = Color.Red;
                selectedButton = seatButton;

                if (seatButton.BackColor == Color.Red)
                {
                    sid = seatButton.Text;
                }
            }
        }

        private void E6_Click(object sender, EventArgs e)
        {
            Button seatButton = (Button)sender;
            if (seatButton.BackColor != Color.Black)
            {
                if (selectedButton != null)
                {
                    selectedButton.BackColor = Color.LightGreen;
                }


                seatButton.BackColor = Color.Red;
                selectedButton = seatButton;

                if (seatButton.BackColor == Color.Red)
                {
                    sid = seatButton.Text;
                }
            }
        }

        private void E7_Click(object sender, EventArgs e)
        {
            Button seatButton = (Button)sender;
            if (seatButton.BackColor != Color.Black)
            {
                if (selectedButton != null)
                {
                    selectedButton.BackColor = Color.LightGreen;
                }


                seatButton.BackColor = Color.Red;
                selectedButton = seatButton;

                if (seatButton.BackColor == Color.Red)
                {
                    sid = seatButton.Text;
                }
            }
        }

        private void E8_Click(object sender, EventArgs e)
        {
            Button seatButton = (Button)sender;
            if (seatButton.BackColor != Color.Black)
            {
                if (selectedButton != null)
                {
                    selectedButton.BackColor = Color.LightGreen;
                }


                seatButton.BackColor = Color.Red;
                selectedButton = seatButton;

                if (seatButton.BackColor == Color.Red)
                {
                    sid = seatButton.Text;
                }
            }
        }

        private void E9_Click(object sender, EventArgs e)
        {
            Button seatButton = (Button)sender;
            if (seatButton.BackColor != Color.Black)
            {
                if (selectedButton != null)
                {
                    selectedButton.BackColor = Color.LightGreen;
                }


                seatButton.BackColor = Color.Red;
                selectedButton = seatButton;

                if (seatButton.BackColor == Color.Red)
                {
                    sid = seatButton.Text;
                }
            }
        }
    }
}
