﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace library
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static SqlDataReader rd;


        //private OleDbConnection connection;
        //public static OleDbDataReader rd;

        //public Logowanie()
        //{
        //    InitializeComponent();
        //    string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Baza danych nowa.accdb;";
        //    connection = new OleDbConnection(connectionString);
        //}

        //private void bt_switchToRegistation_Click(object sender, EventArgs e)
        //{
        //    string username = tb_login.Text;
        //    string password = tb_passLogin.Text;

        //    if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        //    {
        //        MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    try
        //    {
        //        connection.Open();

        //        string query = "SELECT Email, Hasło FROM Pacjent WHERE Email = @username AND Hasło = @password";

        //        using (OleDbCommand command = new OleDbCommand(query, connection))
        //        {
        //            command.Parameters.Clear();

        //            command.Parameters.AddWithValue("@Email", username.Trim().ToString());
        //            command.Parameters.AddWithValue("@Hasło", password.Trim().ToString());

        //            rd = command.ExecuteReader();

        //            if (rd.HasRows)
        //            {
        //                Dane.Username = tb_login.Text;

        //                Menu newLevel = new Menu(/*username*/); // + username dla visits
        //                this.Hide();
        //                newLevel.Show();

        //                while (rd.Read())
        //                {
        //                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                }

        //                username = string.Empty;
        //                password = string.Empty;
        //            }
        //            else
        //            {
        //                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        //rd.Close(); 
        //        connection.Close();
        //    }
        //}


        private void Bt_passMask_Click(object sender, EventArgs e)
        {
            if (Tb_LoginPassword.UseSystemPasswordChar == false)
            {
                Tb_LoginPassword.UseSystemPasswordChar = true;
            }
            else if (Tb_LoginPassword.UseSystemPasswordChar == true)
            {
                Tb_LoginPassword.UseSystemPasswordChar = false;
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Tb_LoginPassword_TextChanged(object sender, EventArgs e)
        {
            Tb_LoginPassword.UseSystemPasswordChar = true;
        }

        private void LabelLoginSwitchToRegistration_Click(object sender, EventArgs e)
        {
            Registration1 newLevel = new Registration1();
            this.Hide();
            newLevel.Show();

        }

        private void Bt_LoginLogIn_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=leader-nest.database.windows.net;Initial Catalog=Biblioteka;User ID=papa";

            SqlConnection connection = new SqlConnection(ConnectionString);

            string username = Tb_LoginEmail.Text;
            string password = Tb_LoginPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                connection.Open();

                string query = "SELECT Email, Haslo FROM Uzytkownicy WHERE Email = '" + username + "' AND Haslo = '" + password + "'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();

                    command.Parameters.AddWithValue("@Email", username.Trim().ToString());
                    command.Parameters.AddWithValue("@Haslo", password.Trim().ToString());

                    rd = command.ExecuteReader();

                    if (rd.HasRows)
                    {
                        Menu newLevel = new Menu();
                        this.Hide();
                        newLevel.Show();

                        while (rd.Read())
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        username = string.Empty;
                        password = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
