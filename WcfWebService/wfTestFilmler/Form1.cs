using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfTestFilmler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        WSFilmServis.WSFilmler servis = new WSFilmServis.WSFilmler();

        private void cbFilmler_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = servis.GetAllFilmlerByFilmTuru(cbFilmler.SelectedItem.ToString());
            dgvFilmler.DataSource = ds.Tables["Filmler"];
        }
    }
}
