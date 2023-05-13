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

        //създавам празни променливи
        int id = int.MinValue;
        string fullName = string.Empty;
        int? appNumber = int.MinValue;
        string status = string.Empty;
        int? birthYear = int.MinValue;
        string enterDate = string.Empty;
        string leavingDate = null;
        string phoneNumber = string.Empty;

        public CorrectionForm()
        {
            InitializeComponent();
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
            phoneNumber = textPhoneNumber.Text;

            SelectQueryProperties();
            connection.Open();
            //UPDATE заявка към базата
            SqlCommand command =
                new SqlCommand(
                    "UPDATE [Inhabitant] SET [FullName] = @Value1, [AppartementNumber] = @Value2, [Status] = @Value3, [BirthYear] = @Value4, [EnterDate] = @Value5, [LeavingDate] = @Value6 WHERE [PhoneNumber] = @phoneNumber",
                    connection);

            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            command.Parameters.AddWithValue("@Value1", fullName);
            command.Parameters.AddWithValue("@Value2", appNumber);
            command.Parameters.AddWithValue("@Value3", status);
            command.Parameters.AddWithValue("@Value4", birthYear);
            command.Parameters.AddWithValue("@Value5", DateTime.Parse(enterDate));
            command.Parameters.AddWithValue("@Value6", DateTime.Parse(leavingDate));

            //изпълни заявката
            command.ExecuteNonQuery();

            MessageBox.Show($" {txtName.Text} е редактиран(a).");
            connection.Close();

            txtName.Text = "";
            txtNumberApp.Text = "";
            txtStatus.Text = "";
            txtYearBorn.Text = "";
            txtDateInput.Text = "";
            txtDateOutput.Text = "";
            textPhoneNumber.Text = "";

        }


        private void SelectQueryProperties()
        {
            connection.Open();
            //SELECT заявка към базата
            string query = "SELECT * FROM [Inhabitant] WHERE [PhoneNumber] = @phoneNumber";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);

            //изпълвам променливите
            //давам им стойности
            fullName = txtName.Text;
            appNumber = int.Parse(txtNumberApp.Text);
            status = txtStatus.Text;
            birthYear = int.Parse(txtYearBorn.Text);
            enterDate = txtDateInput.Text;
            leavingDate = txtDateOutput.Text == string.Empty ? null : txtDateOutput.Text;

            connection.Close();
        }

    }
}
