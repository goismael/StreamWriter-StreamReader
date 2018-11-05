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

namespace WriteToDataFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void WriteDateToFile_Click(object sender, EventArgs e)
        {
                StreamWriter Sw = new StreamWriter(@"C:\CC6\CurrentDate.txt", true);
                Sw.WriteLine(DateTime.Now.ToString());
                Sw.Close();

        }

        private void ReadFile_Click(object sender, EventArgs e)
        {
            StreamReader Sr = new StreamReader(@"C:\CC6\CurrentDate.txt");
            string line = Sr.ReadLine();
            while(line!=null)
            {
                Results.Text += line;
                line = Sr.ReadLine();
            }
            Sr.Close();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Results.Text = " ";
        }
    }
}
