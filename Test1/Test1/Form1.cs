using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Test1
{
    public partial class Form1 : Form
    {
        const string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database.accdb";
        int count = 0;
        List<string> Twin1 = new List<string>();
        List<string> Twin2 = new List<string>();
        List<string> Double1 = new List<string>();
        List<string> Double2 = new List<string>();
        List<string> King1 = new List<string>();
        List<string> King2 = new List<string>();
        List<string> Suite1 = new List<string>();
        List<string> Suite2 = new List<string>();
        List<string> placeholderTwin1 = new List<string>();
        List<string> placeholderTwin2 = new List<string>();
        List<string> placeholderDouble1 = new List<string>();
        List<string> placeholderDouble2 = new List<string>();
        List<string> placeholderKing1 = new List<string>();
        List<string> placeholderKing2 = new List<string>();
        List<string> placeholderSuite1 = new List<string>();
        List<string> placeholderSuite2 = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                while (true)
                {
                    DateTime now = DateTime.Now;

                    if (lName.Text == "" || lName.Text == " " || fName.Text == "" || fName.Text == " ")
                    {
                        MessageBox.Show("Please enter in values for your name.");
                        lName.Text = "";
                        numID.Value = 0;                                                                                                                                                                                      
                        checkIn.Value = now.Date;
                        checkOut.Value = now.Date;
                        break;
                    }

                    else if (rooms.SelectedItems.Count < 1)
                    {
                        MessageBox.Show("Please select a room you would like to order.");
                        fName.Text = "";
                        numID.Value = 0;
                        checkIn.Value = now.Date;
                        checkOut.Value = now.Date;
                        break;
                    }

                    else if (checkIn.Value > checkOut.Value || checkIn.Value < now.Date)
                    {
                        MessageBox.Show("Please make sure your check-in date is before your check out date, as well as making sure your check-in date is not any prior days.");
                        numID.Value = 0;
                        checkIn.Value = now.Date;
                        checkOut.Value = now.Date;
                        break;
                    }
                    else
                    {
                        var roomId = rooms.SelectedItems[0].Text;
                        bool isTrue = false;

                        DateTime start = new DateTime();
                        start = checkIn.Value;
                        DateTime end = new DateTime();
                        end = checkOut.Value;

                        if (count == 0)
                        {
                            switch (roomId)
                            {
                                case "Twin #0001":
                                    Twin1 = AddToList(Twin1, start, end);
                                    break;
                                case "Twin #0002":
                                    Twin2 = AddToList(Twin2, start, end);
                                    break;
                                case "Double #0003":
                                    Double1 = AddToList(Double1, start, end);
                                    break;
                                case "Double #0004":
                                    Double2 = AddToList(Double2, start, end);
                                    break;
                                case "King #0005":
                                    King1 = AddToList(King1, start, end);
                                    break;
                                case "King #0006":
                                    King2 = AddToList(King2, start, end);
                                    break;
                                case "Suite #0007":
                                    Suite1 = AddToList(Suite1, start, end);
                                    break;
                                case "Suite #0008":
                                    Suite2 = AddToList(Suite2, start, end);
                                    break;
                                default:
                                    break;
                            }
                            count++; 
                        }
                        else
                        {
                            switch (roomId)
                            {
                                case "Twin #0001":
                                    placeholderTwin1 = AddToList(placeholderTwin1, start, end);
                                    isTrue = CompareList(Twin1, placeholderTwin1);
                                    if(isTrue == true)
                                    {
                                        MessageBox.Show("You have selected a date or dates that someone else has already booked.");

                                        if(CompareList(Double1, placeholderTwin1) == false)
                                        {
                                            MessageBox.Show("Our Double #0003 room is open if you would like to book that though.");

                                        }
                                        else if(CompareList(Double2, placeholderTwin2) == false)
                                        {
                                            MessageBox.Show("Our Double #0004 room is open if you would like to book that though.");
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Twin1 = AddMoreToList(Twin1, placeholderTwin1);
                                    }
                                    placeholderTwin1.Clear();
                                    break;
                                case "Twin #0002":
                                    placeholderTwin2 = AddToList(placeholderTwin2, start, end);
                                    isTrue = CompareList(Twin2, placeholderTwin2);
                                    if (isTrue == true)
                                    {
                                        MessageBox.Show("You have selected a date or dates that someone else has already booked.");
                                        if (CompareList(Double1, placeholderTwin1) == false)
                                        {
                                            MessageBox.Show("Our Double #0003 room is open if you would like to book that though.");

                                        }
                                        else if (CompareList(Double2, placeholderTwin2) == false)
                                        {
                                            MessageBox.Show("Our Double #0004 room is open if you would like to book that though.");
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Twin2.Add(AddToList(placeholderTwin2, start, end).ToString());
                                    }
                                    placeholderTwin2.Clear();
                                    break;
                                case "Double #0003":
                                    placeholderDouble1 = AddToList(placeholderDouble1, start, end);
                                    isTrue = CompareList(Double1, placeholderDouble1);
                                    if (isTrue == true)
                                    {
                                        MessageBox.Show("You have selected a date or dates that someone else has already booked.");

                                        if (CompareList(King1, placeholderDouble1) == false)
                                        {
                                            MessageBox.Show("Our King #0005 room is open if you would like to book that though.");

                                        }
                                        else if (CompareList(King2, placeholderDouble2) == false)
                                        {
                                            MessageBox.Show("Our King #0006 room is open if you would like to book that though.");
                                        }

                                        break;
                                    }
                                    else
                                    {
                                        Double1.Add(AddToList(placeholderDouble1, start, end).ToString());
                                    }
                                    placeholderDouble1.Clear();
                                    break;
                                case "Double #0004":
                                    placeholderDouble2 = AddToList(placeholderDouble2, start, end);
                                    isTrue = CompareList(Double2, placeholderDouble2);
                                    if (isTrue == true)
                                    {
                                        MessageBox.Show("You have selected a date or dates that someone else has already booked.");

                                        if (CompareList(King1, placeholderDouble1) == false)
                                        {
                                            MessageBox.Show("Our King #0005 room is open if you would like to book that though.");

                                        }
                                        else if (CompareList(King2, placeholderDouble2) == false)
                                        {
                                            MessageBox.Show("Our King #0006 room is open if you would like to book that though.");
                                        }

                                        break;
                                    }
                                    else
                                    {
                                        Double2.Add(AddToList(placeholderDouble2, start, end).ToString());
                                    }
                                    placeholderDouble2.Clear();
                                    break;
                                case "King #0005":
                                    placeholderKing1 = AddToList(placeholderKing1, start, end);
                                    isTrue = CompareList(King1, placeholderKing1);
                                    if (isTrue == true)
                                    {
                                        MessageBox.Show("You have selected a date or dates that someone else has already booked.");

                                        if (CompareList(Suite1, placeholderKing1) == false)
                                        {
                                            MessageBox.Show("Our Suite #0007 room is open if you would like to book that though.");

                                        }
                                        else if (CompareList(Suite2, placeholderKing2) == false)
                                        {
                                            MessageBox.Show("Our Suite #0008 room is open if you would like to book that though.");
                                        }

                                        break;
                                    }
                                    else
                                    {
                                        King1.Add(AddToList(placeholderKing1, start, end).ToString());
                                    }
                                    placeholderKing1.Clear();
                                    break;
                                case "King #0006":
                                    placeholderKing2 = AddToList(placeholderKing2, start, end);
                                    isTrue = CompareList(King2, placeholderKing2);
                                    if (isTrue == true)
                                    {
                                        MessageBox.Show("You have selected a date or dates that someone else has already booked.");

                                        if (CompareList(Suite1, placeholderKing1) == false)
                                        {
                                            MessageBox.Show("Our Suite #0007 room is open if you would like to book that though.");

                                        }
                                        else if (CompareList(Suite2, placeholderKing2) == false)
                                        {
                                            MessageBox.Show("Our Suite #0008 room is open if you would like to book that though.");
                                        }

                                        break;
                                    }
                                    else
                                    {
                                        King2.Add(AddToList(placeholderKing2, start, end).ToString());
                                    }
                                    placeholderKing2.Clear();
                                    break;
                                case "Suite #0007":
                                    placeholderSuite1 = AddToList(placeholderSuite1, start, end);
                                    isTrue = CompareList(Suite1, placeholderSuite1);
                                    if (isTrue == true)
                                    {
                                        MessageBox.Show("You have selected a date or dates that someone else has already booked.");

                                        break;
                                    }
                                    else
                                    {
                                        Suite1.Add(AddToList(placeholderSuite1, start, end).ToString());
                                    }
                                    placeholderSuite1.Clear();
                                    break;
                                case "Suite #0008":
                                    placeholderSuite2 = AddToList(placeholderSuite2, start, end);
                                    isTrue = CompareList(Suite2, placeholderSuite2);
                                    if (isTrue == true)
                                    {
                                        MessageBox.Show("You have selected a date or dates that someone else has already booked.");
                                        break;
                                    }
                                    else
                                    {
                                        Suite2.Add(AddToList(placeholderSuite2, start, end).ToString());
                                    }
                                    placeholderSuite2.Clear();
                                    break;
                                default:
                                    break;
                            }
                        }

                        if(isTrue == false)
                        {
                            connection.Open();

                            OleDbCommand command = new OleDbCommand("INSERT INTO Customers ([First Name],[Last Name],[ID],[CheckIn],[CheckOut]) VALUES ('" + fName.Text + "', '" + lName.Text + "', '" + numID.Value + "', '" + checkIn.Value.ToShortDateString() + "', '" + checkOut.Value.ToShortDateString() + "')", connection);
                            command.ExecuteNonQuery();

                            command = new OleDbCommand(@"UPDATE Customers SET Room= @rooms WHERE ID= @Id AND [First Name]= @fName AND [Last Name]= @lName", connection);
                            command.Parameters.AddWithValue("@room", roomId);
                            command.Parameters.AddWithValue("@Id", numID.Value);
                            command.Parameters.AddWithValue("@fName", fName.Text);
                            command.Parameters.AddWithValue("@lName", lName.Text);
                            command.ExecuteNonQuery();

                            connection.Close();
                        }

                        lName.Text = "";
                        fName.Text = "";
                        numID.Value = 0;
                        checkIn.Value = now.Date;
                        checkOut.Value = now.Date;

                        break;
                    }
                }

            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {

            string strSQL = "SELECT * FROM Customers";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(strSQL, connection);
                try
                {
                    connection.Open();

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            MessageBox.Show($"{reader["First Name"].ToString()} {reader["Last Name"].ToString()} {reader["ID"].ToString()} {reader["Room"].ToString()} {reader["CheckIn"].ToString()} {reader["CheckOut"].ToString()}");
                        }
                    }
                    connection.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                DateTime now = DateTime.Now;
                connection.Open();

                OleDbCommand command = new OleDbCommand("DELETE FROM Customers WHERE [First Name]= @fName AND [Last Name]= @lName AND [ID]= @Id AND [Room]= @Room AND [CheckIn]= @CheckIn AND [CheckOut] = @CheckOut", connection);
                command.Parameters.AddWithValue("@fName", fName.Text);
                command.Parameters.AddWithValue("@lName", lName.Text);
                command.Parameters.AddWithValue("@Id", numID.Value.ToString());
                command.Parameters.AddWithValue("@Room", rooms.SelectedItems[0].Text);
                command.Parameters.AddWithValue("@CheckIn", checkIn.Value.ToShortDateString());
                command.Parameters.AddWithValue("@CheckOut", checkOut.Value.ToShortDateString());
                command.ExecuteNonQuery();

                connection.Close();

                fName.Text = "";
                lName.Text = "";
                numID.Value = 0;
                checkIn.Value = now.Date;
                checkOut.Value = now.Date;
            }
        }

        public static List<string> AddToList(List<string> Room, DateTime start, DateTime end)
        {
            for (var dt = start; dt < end.AddDays(1); dt = dt.AddDays(1))
            {
                Room.Add(dt.ToShortDateString());

            }

            return Room;
        }

        public static List<string> AddMoreToList(List<string> Original, List<string> palceholder)
        {
            for (int i = 0; i < palceholder.Count; i++)
            {
                Original.Add(palceholder[i]);
            }

            return Original;
        }

        public static bool CompareList(List<string> Original, List<string> Placeholder)
        {
            bool hasMatch = Original.Any(x => Placeholder.Any(y => y.Contains(x)));
            return hasMatch;
        }

        /// <summary>
        /// Will show all customers in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_show_Click_1(object sender, EventArgs e)
        {
            string strSQL = "SELECT * FROM Customers";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(strSQL, connection);
                try
                {
                    connection.Open();

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            MessageBox.Show($"{reader["First Name"].ToString()} {reader["Last Name"].ToString()} {reader["ID"].ToString()} {reader["Room"].ToString()} {reader["CheckIn"].ToString()} {reader["CheckOut"].ToString()}");
                        }
                    }
                    connection.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
    }
