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

namespace Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Create(@"E:\file.txt");
            MessageBox.Show("File Created");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Delete(@"E:\file.txt");
            MessageBox.Show("File Deleted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"E:\file.txt"))
            {
                MessageBox.Show("file exist");
            }
            else
            {
                MessageBox.Show("file not exist");
            }
        }

        

        

        private void button6_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"E:\file.txt"))
            {
                File.Copy(@"E:\file.txt", @"E:\file1.txt");
                MessageBox.Show("file copied");
            }
            else
            {
                MessageBox.Show("File Not Exist");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"E:\file.txt"))
            {
                File.Move(@"E:\file.txt", @"E:\New folder\file.txt");
                MessageBox.Show("file moved");
            }
            else
            {
                MessageBox.Show("File Not Exist");
            }
        }
    }
}
