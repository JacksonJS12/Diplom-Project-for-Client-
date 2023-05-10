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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            MainForm log = new MainForm();
            log.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Inhabitant (FullName, AppartementNumber, Status, BirthYear, EnterDate, LeavingDate) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6)", connection);

            command.Parameters.AddWithValue("@Value1", txtName.Text);
            command.Parameters.AddWithValue("@Value2", txtNumberApp.Text);
            command.Parameters.AddWithValue("@Value3", txtStatus.Text);
            command.Parameters.AddWithValue("@Value4", txtYearBorn.Text);
            command.Parameters.AddWithValue("@Value5", txtDateInput.Text);
            if (txtDateOutput.Text == "")
            {
                command.Parameters.AddWithValue("@Value6", DBNull.Value);
            }
            else { command.Parameters.AddWithValue("@Value6", txtDateOutput.Text); }

            int rowsAffected = command.ExecuteNonQuery();

            MessageBox.Show(rowsAffected +$" {txtName.Text} е добавен(a).");
            connection.Close();

            txtName.Text = "";
            txtNumberApp.Text = "";
            txtStatus.Text = "";
            txtYearBorn.Text = "";
            txtDateInput.Text = "";
            txtDateOutput.Text = "";
        }
    }
}
