using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iconom
{
    public partial class DeleteForm : Form
    {
        private SqlConnection connection = new SqlConnection(ConnectionString.DbConnection);

        //създавам празни променливи
        int id = int.MinValue;
        string fullName = string.Empty;
        int? appNumber = int.MinValue;
        string status = string.Empty;
        int? birthYear = int.MinValue;
        string enterDate = string.Empty;
        string leavingDate = string.Empty;
        string phoneNumber = string.Empty;

        public DeleteForm()
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            phoneNumber = textPhoneNumber.Text;
            SelectQuery();
            connection.Open();
            //DELETE заявка към базата и изтриваме записа
            SqlCommand command =
                new SqlCommand(
                    "DELETE FROM [Inhabitant] WHERE [PhoneNumber] = @phoneNumber",
                    connection);

            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);


            DialogResult dr = MessageBox.Show("Сигурни ли сте, че искате да изтриете записа?",
                "", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    txtName.Text = "";
                    txtNumberApp.Text = "";
                    txtStatus.Text = "";
                    txtYearBorn.Text = "";
                    txtDateInput.Text = "";
                    txtDateOutput.Text = "";
                    textPhoneNumber.Text = "";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Записът е изтрит от дневника.");
                    break;
                case DialogResult.No:
                    break;
            }

            connection.Close();


        }
        
        private void SelectQuery()
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
            leavingDate = txtDateOutput.Text;

            connection.Close();
        }

    }
}

