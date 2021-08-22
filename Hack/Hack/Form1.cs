using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Hack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        public async void lol()
        {
            
                MessageBox.Show("LOl Destroying ur computer hahahhahaha in 1, 2, 3 .... lol");
            
            Process.Start(@"C:\\Users\\Tanush\\Personal\\Other-Stuff\\lol1.bat");
            await Task.Delay(TimeSpan.FromSeconds(5));
            Process.Start(@"C:\\Users\\Tanush\\Personal\\Other-Stuff\\lol2.bat");
            await Task.Delay(TimeSpan.FromSeconds(3));
            MessageBox.Show("VirIOus Downloading...");
            await Task.Delay(TimeSpan.FromSeconds(3));
            Process.Start(@"C:\\Users\\Tanush\\source\\repos\\lol\\lol\bin\\Debug\\net5.0-windows\\lol.exe");

        }


        private void button1_Click(object sender, EventArgs e)
        {
            lol();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lol();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lol(); 
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            lol();
        }
    }
}
