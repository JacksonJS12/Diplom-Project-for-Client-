using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iconom
{
    public partial class DeleteForm : Form
    {
        private SqlConnection connection = new SqlConnection(ConnectionString.DbConnection);

        int id = int.MinValue;
        string fullName = string.Empty;
        int? appNumber = int.MinValue;
        string status = string.Empty;
        int? birthYear = int.MinValue;
        DateTime? enterDate = DateTime.MinValue;
        DateTime? leavingDate = DateTime.MinValue;

        public DeleteForm()
        {
            InitializeComponent();
            txtSerachBox.Text = "Търси по име";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            MainForm log = new MainForm();
            log.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SelectQuery();
            connection.Open();
            SqlCommand command =
                new SqlCommand(
                    "DELETE FROM [Inhabitant] WHERE Id = @id",
                    connection);

            command.Parameters.AddWithValue("@id", id);

            txtName.Text = "";
            txtNumberApp.Text = "";
            txtStatus.Text = "";
            txtYearBorn.Text = "";
            txtDateInput.Text = "";
            txtDateOutput.Text = "";

            txtSerachBox.Text = "Търси по име";

            int rowsAffected = command.ExecuteNonQuery();

            MessageBox.Show(rowsAffected + " запис(а) е изтрит от дневника.");
            connection.Close();


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "SELECT * FROM Inhabitant WHERE FullName = @searchedName";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@searchedName", txtSerachBox.Text);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Get the values of the columns for the record
                        id = reader.GetInt32(0);
                        txtName.Text = reader.GetString(1);
                        txtNumberApp.Text = reader.GetInt32(2).ToString();
                        txtStatus.Text = reader.GetString(3).ToString();
                        txtYearBorn.Text = reader.GetInt32(4).ToString();

                        DateTime dateInput = reader.GetDateTime(5);

                        int yearInput = dateInput.Year;
                        int monthInput = dateInput.Month;
                        int dayInput = dateInput.Day;

                        string printMonthInput = monthInput.ToString().Length < 2 ? $"0{monthInput}" : $"{monthInput}";
                        string printDayInput = dayInput.ToString().Length < 2 ? $"0{dayInput}" : $"{dayInput}";
                        txtDateInput.Text = $"{yearInput}-{printMonthInput}-{printDayInput}";

                        if (reader.IsDBNull(6))
                        {
                            txtDateOutput.Text = "---";
                        }
                        else
                        {
                            /*txtDateOutput.Text*/
                            DateTime date = reader.GetDateTime(6);

                            int year = date.Year;
                            int month = date.Month;
                            int day = date.Day;

                            string printMonth = month.ToString().Length < 2 ? $"0{month}" : $"{month}";
                            string printDay = day.ToString().Length < 2 ? $"0{day}" : $"{day}";

                            txtDateOutput.Text = $"{year}-{printMonth}-{printDay}";
                        }
                        //MessageBox.Show("Открит запис.");

                        txtSerachBox.Text = "Търси по име";
                    }
                    else
                    {
                        MessageBox.Show("Няма открит запис.");
                    }
                    connection.Close();
                }
            }
        }

        private void SelectQuery()
        {
            connection.Open();
            string query = "SELECT * FROM [Inhabitant] WHERE [Id] = @id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    fullName = reader.GetString(1);
                    appNumber = reader.GetInt32(2);
                    status = reader.GetString(3);
                    birthYear = reader.GetInt32(4);
                    if (!reader.IsDBNull(5))
                    {
                        enterDate = reader.GetDateTime(5);
                    }
                    else
                    {
                        enterDate = null;
                    }

                    if (!reader.IsDBNull(6))
                    {
                        leavingDate = reader.GetDateTime(6);
                    }
                    else
                    {
                        leavingDate = null;
                    }

                    break;
                }
            }
            connection.Close();
        }
        
    }
}

