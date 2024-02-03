using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermekekLIstBox
{
    public partial class UjTermekFelvetel : Form
    {
        //művelet letárolására osztályváltozó inkább numerikus szokott lenni
        string muvelet;
        public UjTermekFelvetel(string muvelet, Object param=null)
        {
            InitializeComponent();
            this.muvelet = muvelet;
            //egy switchben vizsgáljuk meg a műveleteket

            switch (muvelet) //button feliratok módosítása 
            {
                case "insert":
                    button1.Text = "Rögzítés";
                    this.Text = "Új termék adata";
                    break;

                case "update":
                    button1.Text = "Módosít";
                    this.Text = "Új termék módosítása";
                    //modositott listaelem felvételének példánya - kiválasztott elem tulajdonságai
                    Termekek termekek = (Termekek)param;
                    textBox_id.Text = termekek.Termekkod.ToString();
                    textBox_nev.Text = termekek.Nev.ToString();
                    textBox_mennyiseg.Text = termekek.Mennyiseg.ToString();

                    break;

                case "delete":
                    button1.Text = "Eltávolítás";
                    this.Text = "Termék eltávolítása";
                    break;
                default:
                    break;
            }
        }

        private void UjTermekFelvetel_Load(object sender, EventArgs e)
        {
            // adatbevitel
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (muvelet)
            {
                case "insert":
                    Ujtermek_felvetel();
                    break;
                case "update":
                    modosít();
                    break;
            }  
        }

        private void modosít()
        {
            ulong termekkod = ulong.Parse(textBox_id.Text);

            if (String.IsNullOrEmpty(textBox_nev.Text))//ha üres
            {
                MessageBox.Show("Hiányzó név");
                textBox_nev.Focus();//kurzor betétele
                return;
            }
            string nev = textBox_nev.Text;

            if (!int.TryParse(textBox_mennyiseg.Text, out int mennyiseg) || mennyiseg < 0)
            {
                MessageBox.Show("Érvénytelen mennyiség");
                textBox_mennyiseg.Focus();
                return;
            }

            //mennyiség ne legyen minusz

            Termekek termekek = new Termekek(termekkod, nev, mennyiseg);

            Program.nyitoForm.listBox_Termekek.Items.Add(termekek);
        }

        void Ujtermek_felvetel()
        {
            ulong termekkod = (ulong)Program.nyitoForm.listBox_Termekek.Items.Count + 1;

            if (String.IsNullOrEmpty(textBox_nev.Text))//ha üres
            {
                MessageBox.Show("Hiányzó név");
                textBox_nev.Focus();//kurzor betétele
                return;
            }
            string nev = textBox_nev.Text;

            if (!int.TryParse(textBox_mennyiseg.Text, out int mennyiseg) || mennyiseg < 0)
            {
                MessageBox.Show("Érvénytelen mennyiség");
                textBox_mennyiseg.Focus();
                return;
            }


            //mennyiség ne legyen minusz

            Termekek ujTermek = new Termekek(termekkod, nev, mennyiseg);
            foreach (Termekek item in Program.nyitoForm.listBox_Termekek.Items)
            {
                if (item.Termekkod == termekkod)
                {
                    Program.nyitoForm.listBox_Termekek.Items.Remove(item);
                }
            }
            Program.nyitoForm.listBox_Termekek.Items.Add(ujTermek);//az új terméket itemként adjuk hozzá a listboxhoz.
            this.Close();
        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
