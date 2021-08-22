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

namespace lol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Succesfully Dowloaded");
            await Task.Delay(TimeSpan.FromSeconds(10));
            Process.Start(@"C:\\Users\\Tanush\\Personal\\Other-Stuff\\lol.bat");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\\Users\\Tanush\\Personal\\Other-Stuff\\lol3.bat");
            await Task.Delay(TimeSpan.FromSeconds(5));
            Process.Start(@"C:\\Users\\Tanush\\Personal\\Other-Stuff\\lol.bat");
        }
    }
}
