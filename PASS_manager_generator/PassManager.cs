using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PASS_manager_generator
{
    public partial class PassManager : Form
    {
        int length = 32;
        public PassManager()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var pass = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                pass.Append((char)rnd.Next(33, 126));
            }
            maintextbox.Text = pass.ToString();
            Clipboard.SetText(maintextbox.Text);
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            length = (int)numericUpDown1.Value;
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            maintextbox.Text = "https://github.com/Faurazeko";
            Clipboard.SetText(maintextbox.Text);
        }
    }
}
