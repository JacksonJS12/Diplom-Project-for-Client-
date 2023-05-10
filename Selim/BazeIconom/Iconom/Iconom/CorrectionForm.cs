using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Iconom
{
    public partial class CorrectionForm : Form
    {
        private SqlConnection connection = new SqlConnection(ConnectionString.DbConnection);

        int id = int.MinValue;
        string fullName = string.Empty;
        int? appNumber = int.MinValue;
        string status = string.Empty;
        int? birthYear = int.MinValue;
        string enterDate = string.Empty;
        string leavingDate = null;



        public CorrectionForm()
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty)
            {
                fullName = txtName.Text;
                appNumber = int.Parse(txtNumberApp.Text);
                status = txtStatus.Text;
                birthYear = int.Parse(txtYearBorn.Text);
                enterDate = txtDateInput.Text;
                leavingDate = txtDateOutput.Text;

                SelectQueryId(fullName);
            }
            SelectQueryProperties();
            connection.Open();
            SqlCommand command =
                new SqlCommand(
                    "UPDATE Inhabitant SET [FullName] = @Value1, [AppartementNumber] = @Value2, [Status] = @Value3, [BirthYear] = @Value4, [EnterDate] = @Value5, [LeavingDate] = @Value6 WHERE Id = @id",
                    connection);

            

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@Value1", fullName);
            command.Parameters.AddWithValue("@Value2", appNumber);
            command.Parameters.AddWithValue("@Value3", status);
            command.Parameters.AddWithValue("@Value4", birthYear);
            command.Parameters.AddWithValue("@Value5", DateTime.Parse(enterDate));
            command.Parameters.AddWithValue("@Value6", DateTime.Parse(leavingDate));
            

            int rowsAffected = command.ExecuteNonQuery();

            MessageBox.Show($" {txtName.Text} е редактиран(a).");
            connection.Close();

            txtName.Text = "";
            txtNumberApp.Text = "";
            txtStatus.Text = "";
            txtYearBorn.Text = "";
            txtDateInput.Text = "";
            txtDateOutput.Text = "";

            txtSerachBox.Text = "Търси по име";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "SELECT * FROM [Inhabitant] WHERE [FullName] = @searchedName";

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
                        string monthInput = dateInput.Month.ToString().Length < 2 ? $"0{dateInput.Month}" : dateInput.Month.ToString();
                        string dayInput = dateInput.Day.ToString().Length < 2 ? $"0{dateInput.Day}" : dateInput.Day.ToString();

                        txtDateInput.Text = $"{yearInput}-{monthInput}-{dayInput}";

                        if (reader.GetDateTime(6).ToString() != "")
                        {
                            DateTime dateOuput = reader.GetDateTime(6);
                            int yearOuput = dateOuput.Year;
                            string monthOuput = dateOuput.Month.ToString().Length < 2 ? $"0{dateOuput.Month}" : dateOuput.Month.ToString();
                            string dayOuput = dateOuput.Day.ToString().Length < 2 ? $"0{dateOuput.Day}" : dateOuput.Day.ToString();

                            txtDateOutput.Text = $"{yearOuput}-{monthOuput}-{dayOuput}";
                        }


                        //MessageBox.Show("Открит запис.");
                    }
                    else
                    {
                        MessageBox.Show("Няма открит запис.");
                    }
                    connection.Close();
                }
            }

            txtSerachBox.Text = "Търси по име";
        }

        private void SelectQueryId(string fullName)
        {
            connection.Open();
            string query = "SELECT * FROM [Inhabitant] WHERE [FullName] = @fullName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@fullName", fullName);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
            }
            connection.Close();
        }
        private void SelectQueryProperties()
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
                        enterDate = reader.GetDateTime(5).ToString();
                    }
                    else
                    {
                        enterDate = null;
                    }

                    if (!reader.IsDBNull(6))
                    {
                        leavingDate = reader.GetDateTime(6).ToString();
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
