using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Iconom
{
    public partial class NewInhabitantForm : Form
    {
        private SqlConnection connection = new SqlConnection(ConnectionString.DbConnection);
        public NewInhabitantForm()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)//изход
        {
            //this.Hide();
            MainForm log = new MainForm();
            log.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            connection.Open();
            //INSERT заявка към базата
            SqlCommand command = new SqlCommand("INSERT INTO Inhabitant (FullName, AppartementNumber, Status, BirthYear, EnterDate, LeavingDate, PhoneNumber) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7)", connection);

            //параметри
            command.Parameters.AddWithValue("@Value1", txtName.Text);
            command.Parameters.AddWithValue("@Value2", txtNumberApp.Text);
            command.Parameters.AddWithValue("@Value3", txtStatus.Text);
            command.Parameters.AddWithValue("@Value4", txtYearBorn.Text);
            command.Parameters.AddWithValue("@Value5", txtDateInput.Text);
            command.Parameters.AddWithValue("@Value6", txtDateOutput.Text);
            command.Parameters.AddWithValue("@Value7", textPhoneNumber.Text);

            command.ExecuteNonQuery();

            MessageBox.Show($" {txtName.Text} е добавен(a).");
            connection.Close();

            //оставя празни полета
            txtName.Text = "";
            txtNumberApp.Text = "";
            txtStatus.Text = "";
            txtYearBorn.Text = "";
            txtDateInput.Text = "";
            txtDateOutput.Text = "";
            textPhoneNumber.Text = "";
        }

    }
}
