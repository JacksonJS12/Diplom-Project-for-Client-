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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            GetIconom(0);
        }
        int n = 1; // Брой на записите
        SqlConnection connIconom = new SqlConnection(ConnectionString.DbConnection);
        //SqlConnection connIconom = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;AttachDbFilename=D:\\ExamplesSQL\\TableMagasin\\myMagasin.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        // Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BazeIconom\Iconom\Iconom\BD_Iconom.mdf;Integrated Security=True;Connect Timeout=30


        public int GetLength()
        {
            //Create command link
            SqlCommand cmdIconom = new SqlCommand("Select * from Inhabitant", connIconom);
            connIconom.Open();
            //Create data adapter
            SqlDataAdapter daIconom = new SqlDataAdapter(cmdIconom);
            //Create table link
            DataTable dataIconom = new DataTable();
            //Read data from table
            daIconom.Fill(dataIconom);
            connIconom.Close();
            daIconom.Dispose();

            return dataIconom.Rows.Count;
        }
        public void GetIconom(int x)
        {
            //Create command link
            SqlCommand cmdIconom = new SqlCommand("Select * from Inhabitant", connIconom);
            connIconom.Open();
            //Create data adapter
            SqlDataAdapter daIconom = new SqlDataAdapter(cmdIconom);
            //Create table link
            DataTable dataIconom = new DataTable();
            //Read data from table
            daIconom.Fill(dataIconom);
            connIconom.Close();
            daIconom.Dispose();

            //string date;
            txtName.Text = dataIconom.Rows[x][1].ToString();
            txtNumberApp.Text = dataIconom.Rows[x][2].ToString();
            txtStatus.Text = dataIconom.Rows[x][3].ToString();
            txtYearBorn.Text = dataIconom.Rows[x][4].ToString();
            txtDateInput.Text = dataIconom.Rows[x][5].ToString();
            if (dataIconom.Rows[x][6].ToString() == "")
            {
                txtDateOutput.Text = "---";
            }
            else
            {
                txtDateOutput.Text = dataIconom.Rows[x][6].ToString();

            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            GetIconom(n);
            if (n == 0)
                n = GetLength() - 1;
            else
                n = n - 1;
        }

        private void btnNext_Click(object sender, EventArgs e)
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

        private void btnNewLocataire_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewInhabitantPage log = new NewInhabitantPage();
            log.Show();
        }

        private void btnCorrection_Click(object sender, EventArgs e)
        {
            this.Hide();
            CorrectionPage log = new CorrectionPage();
            log.Show();
        }
    }
}
