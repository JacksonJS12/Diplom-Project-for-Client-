using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iconom
{
    public partial class InputOutputFormulaire : Form
    {
        public InputOutputFormulaire()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ReferenceLocataires log = new ReferenceLocataires();
            log.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ReferenceLocataires log = new ReferenceLocataires();
            log.Show();
        }
    }
}
