using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spremanje__prikaz_i_filtriranje_EM
{
    public partial class Form4 : Form
    {
        List<Učenik> listaUcenika = new List<Učenik>();

        String mojiDokumenti = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "csvTransformerPodaci");


        String putanja = Path.Combine()
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Directory.Exist(putanja))
            {

                Directory.CreateDirectory(putanja);
            }
            StreamWriter sw = new StreamWriter(putanja + "/podaci.csv");
                

            foreach(Učenik uc in listaUcenika)
            {

                sw.Write(uc.Ispis());
            }

            sw.Close();

            Form3 frmPocetna = new Form3();
            frmPocetna.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text.Contains('@'))
                {
                    Učenik objUcenik = new Učenik(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);

                    listaUcenika.Add(objUcenik);


                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    MessageBox.Show("Podaci su uneseni.", "Unos OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message, "Greska");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
