using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Urok_5
{
    public partial class Catalogs : Form
    {
        public Catalogs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // создать директорию
            Directory.CreateDirectory("C:\\Chick");

            DirectoryInfo papka = new DirectoryInfo("C:\\Chick_2");
            if (papka.Exists)
            {
                papka.Create();
            }

            // получение каталогов
            string[] catalogs = Directory.GetDirectories("C:\\");
            foreach (string dir in catalogs)
            {
                // MessageBox.Show(dir);
            }

            File.Create("C:\\Chick\\Dolli.pptx");

            FileInfo info = new FileInfo("C:\\Chick\\Dolli.txt");
            info.Create();
        }
    }
}
