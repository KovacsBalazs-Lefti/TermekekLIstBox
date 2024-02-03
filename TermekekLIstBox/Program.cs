using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermekekLIstBox
{
    internal static class Program
    {

        public static Form_Termek nyitoForm = null;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            nyitoForm = new Form_Termek(); //nyitoform példányosítása
            Application.Run(nyitoForm); //Elérhetővé tesszük a listbox adatokat és a publikus részeket
        }
    }
}
