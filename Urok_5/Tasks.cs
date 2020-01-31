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
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {


                StreamWriter stream;
                FileInfo file = new FileInfo(saveFileDialog1.FileName);

                stream = file.AppendText();

                stream.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {


                StreamReader stream = new StreamReader(openFileDialog1.FileName);

                string str = "";
                while (!stream.EndOfStream)
                {
                    str += stream.ReadLine();
                }

                foreach(char word in str)
                {
                    if(word == 'а')
                    {
                        MessageBox.Show("найдено"+word);
                    }
                }
               

                stream.Close();
            }
        }
    }
}
