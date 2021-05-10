using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spremanje__prikaz_i_filtriranje_EM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Unos frmUnos = new Unos();
            frmUnos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 frmPregled = new Form4();
            frmPregled.Show();
            this.Hide();
        }
    }
}
