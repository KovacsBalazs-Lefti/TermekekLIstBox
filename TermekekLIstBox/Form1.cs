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

namespace TermekekLIstBox
{
    public partial class Form_Termek : Form
    {
        public Form_Termek()
        {
            InitializeComponent();
        }

        private void listBox_Termekek_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button3_UjTermek_Click(object sender, EventArgs e)
        {
            UjTermekFelvetel ujTermekFelvetel = new UjTermekFelvetel("insert");
            ujTermekFelvetel.ShowDialog();
        }
        private void button1_Betoltes_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string adatfile = openFileDialog.FileName;
                using (StreamReader sr = new StreamReader(adatfile))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] sor = sr.ReadLine().Split(';');
                        if (sor.Length == 3)
                        {
                            if (ulong.TryParse(sor[0], out ulong termekkod) && int.TryParse(sor[2], out int mennyiseg))
                            {
                                Termekek uj = new Termekek(termekkod, sor[1], mennyiseg);
                                listBox_Termekek.Items.Add(uj);
                            }
                            else
                            {
                                MessageBox.Show("Érvénytelen adatok a fájlban.");
                                // További hibakezelés vagy az egész fájl beolvasásának leállítása
                                break;
                            }
                        }
                    }
                }
            }

        }

 

        private void Form_Termek_Load(object sender, EventArgs e)
        {

        }

        private void button4_Modosit_Click(object sender, EventArgs e)
        {
            if (listBox_Termekek.SelectedIndex < 0) 
            {
                MessageBox.Show("Nincs kiválasztott Termék");
                return;//ki kell lépni
            }
            Termekek termekek
                = (Termekek)listBox_Termekek.SelectedItem;
            listBox_Termekek.Items.Remove(termekek);
            UjTermekFelvetel ujTermekFelvetel = new UjTermekFelvetel("update",termekek);
            ujTermekFelvetel.ShowDialog();
        }

        private void button5_Torles_Click(object sender, EventArgs e)
        {
            if (listBox_Termekek.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott termék");
                return;
            }
            Termekek termekek = (Termekek)listBox_Termekek .SelectedItem;
            listBox_Termekek.Items.Remove (termekek);



        }

        private void button2_Mentes_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                using (StreamWriter mystream = new StreamWriter(filename))
                {
                    {
                        foreach (Termekek item in listBox_Termekek.Items)
                        {
                            mystream.WriteLine(item.toTxt());
                        }
                        mystream.Flush();
                    }
                }

            }
        }
    }
}
