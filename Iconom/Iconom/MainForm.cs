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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            GetIconom(0);
        }
        int n = 1; // Брой на записите
        SqlConnection connection = new SqlConnection(ConnectionString.DbConnection);
        //SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;AttachDbFilename=D:\\ExamplesSQL\\TableMagasin\\myMagasin.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        // Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BazeIconom\Iconom\Iconom\BD_Iconom.mdf;Integrated Security=True;Connect Timeout=30


        public int GetLength()
        {
            //Create command link
            SqlCommand cmdIconom = new SqlCommand("Select * from Inhabitant", connection);
            connection.Open();
            //Create data adapter
            SqlDataAdapter daIconom = new SqlDataAdapter(cmdIconom);
            //Create table link
            DataTable dataIconom = new DataTable();
            //Read data from table
            daIconom.Fill(dataIconom);
            connection.Close();
            daIconom.Dispose();

            return dataIconom.Rows.Count;
        }
        public void GetIconom(int x)
        {
            //Create command link
            SqlCommand cmdIconom = new SqlCommand("Select * from Inhabitant", connection);
            connection.Open();
             //Create data adapter
            SqlDataAdapter daIconom = new SqlDataAdapter(cmdIconom);
            //Create table link
            DataTable dataIconom = new DataTable();
            //Read data from table
            daIconom.Fill(dataIconom);
            connection.Close();
            daIconom.Dispose();

            //string date;

            txtName.Text = dataIconom.Rows[x][1].ToString();
            txtNumberApp.Text = dataIconom.Rows[x][2].ToString();
            txtStatus.Text = dataIconom.Rows[x][3].ToString();
            txtYearBorn.Text = dataIconom.Rows[x][4].ToString();

            DateTime dateInput = (DateTime)dataIconom.Rows[x][5];
            int yearInput = dateInput.Year;
            string monthInput = dateInput.Month.ToString().Length < 2 ? $"0{dateInput.Month}" : dateInput.Month.ToString();
            string dayInput = dateInput.Day.ToString().Length < 2 ? $"0{dateInput.Day}" : dateInput.Day.ToString();

            txtDateInput.Text = $"{yearInput}-{monthInput}-{dayInput}";

            if (dataIconom.Rows[x][6].ToString() != "")
            {
                DateTime dateOuput = (DateTime)dataIconom.Rows[x][6];
                int yearOuput = dateOuput.Year;
                string monthOuput = dateOuput.Month.ToString().Length < 2 ? $"0{dateOuput.Month}" : dateOuput.Month.ToString();
                string dayOuput = dateOuput.Day.ToString().Length < 2 ? $"0{dateOuput.Day}" : dateOuput.Day.ToString();

                txtDateOutput.Text = $"{yearOuput}-{monthOuput}-{dayOuput}";
            }

            txtPhoneNumber.Text = dataIconom.Rows[x][7].ToString();
        }

        private void btnPrev_Click(object sender, EventArgs e)//ПРЕДИШЕН
        {
            GetIconom(n);
            if (n == 0)
                n = GetLength() - 1;
            else
                n = n - 1;
        }

        private void btnNext_Click(object sender, EventArgs e)//СЛЕДВАЩ
        {
            GetIconom(n);
            if (n == GetLength() - 1)
                n = 0;
            else
                n = n + 1; //n++    n += 1
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewInhabitantForm_Click(object sender, EventArgs e)//Нов живущ
        {
            this.Hide();
            NewInhabitantForm log = new NewInhabitantForm();//прави нов обект 
            log.StartPosition = FormStartPosition.CenterParent;
            log.ShowDialog();
        }

        private void btnCorrection_Click(object sender, EventArgs e)//Корекция
        {
            this.Hide();
            CorrectionForm log = new CorrectionForm();
            log.txtName.Text = txtName.Text;
            log.txtNumberApp.Text = txtNumberApp.Text;
            log.txtStatus.Text = txtStatus.Text;
            log.txtYearBorn.Text = txtYearBorn.Text;
            log.txtDateInput.Text = txtDateInput.Text;
            log.txtDateOutput.Text = txtDateOutput.Text;
            log.textPhoneNumber.Text = txtPhoneNumber.Text;
            log.StartPosition = FormStartPosition.CenterParent;
            log.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)//изтриване
        {
            this.Hide();
            DeleteForm log = new DeleteForm(); 
            log.txtName.Text = txtName.Text;
            log.txtNumberApp.Text = txtNumberApp.Text;
            log.txtStatus.Text = txtStatus.Text;
            log.txtYearBorn.Text = txtYearBorn.Text;
            log.txtDateInput.Text = txtDateInput.Text;
            log.txtDateOutput.Text = txtDateOutput.Text;
            log.textPhoneNumber.Text = txtPhoneNumber.Text;
            log.StartPosition = FormStartPosition.CenterParent;
            log.ShowDialog();

        }
        
    }
}
