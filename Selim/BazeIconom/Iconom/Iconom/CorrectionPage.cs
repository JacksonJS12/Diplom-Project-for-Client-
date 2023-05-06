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
using System.Xml.Linq;

namespace Iconom
{
    public partial class CorrectionPage : Form
    {
        private SqlConnection connection = new SqlConnection(ConnectionString.DbConnection);

        int id = int.MinValue;
        string fullName = string.Empty;
        int? appNumber = int.MinValue;
        string status = string.Empty;
        int? birthYear = int.MinValue;
        DateTime? enterDate = DateTime.MinValue;
        DateTime? leavingDate = DateTime.MinValue;

        public CorrectionPage()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            MainPage log = new MainPage();
            log.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SelectQuery();
            connection.Open();
            SqlCommand command =
                new SqlCommand(
                    "UPDATE Inhabitant SET [FullName] = @Value1, [AppartementNumber] = @Value2, [Status] = @Value3, [BirthYear] = @Value4, [EnterDate] = @Value5, [LeavingDate] = @Value6 WHERE Id = @id",
                    connection);

            command.Parameters.AddWithValue("@id", id);
            //name
            if (txtName.Text == "")
            {
                command.Parameters.AddWithValue("@Value1", fullName);
            }
            else
            {
                command.Parameters.AddWithValue("@Value1", txtName.Text);
            }
            //appartement number
            if (txtNumberApp.Text == "")
            {
                command.Parameters.AddWithValue("@Value2", appNumber);
            }
            else
            {
                command.Parameters.AddWithValue("@Value2", txtNumberApp.Text);
            }

            //status
            if (txtStatus.Text == "")
            {
                command.Parameters.AddWithValue("@Value3", status);
            }
            else
            {
                command.Parameters.AddWithValue("@Value3", txtStatus.Text);
            }

            //birth year
            if (txtYearBorn.Text == "")
            {
                command.Parameters.AddWithValue("@Value4", birthYear);
            }
            else
            {
                command.Parameters.AddWithValue("@Value4", txtYearBorn.Text);
            }

            //enter date
            if (txtDateInput.Text == "")
            {
                if (enterDate == null)
                {
                    command.Parameters.AddWithValue("@Value5", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@Value5", enterDate);
                }
            }
            else
            {
                command.Parameters.AddWithValue("@Value5", txtDateInput.Text);
            }

            //leaving date
            if (txtDateOutput.Text == "")
            {
                if (leavingDate == null)
                {
                    command.Parameters.AddWithValue("@Value6", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@Value6", leavingDate);
                }
            }
            else
            {
                command.Parameters.AddWithValue("@Value6", txtDateOutput.Text);
            }
            
            int rowsAffected = command.ExecuteNonQuery();

            MessageBox.Show(rowsAffected + " row(s) updated.");
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
                        MessageBox.Show("Record found.");
                    }
                    else
                    {
                        MessageBox.Show("Record not found.");
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
