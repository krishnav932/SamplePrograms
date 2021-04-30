using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
    public partial class Form1 : Form
    {
        TextBox t1, t2, t3; //declaring textboxes globally
        public Form1() //constructor
        {
            Label l1 = new Label();
            l1.Text = "First Number";
            l1.Location = new Point(20, 20);
            this.Controls.Add(l1); //adding control l1 on windows form

            t1 = new TextBox();
            t1.Location = new Point(120, 20);
            this.Controls.Add(t1);

            Label l2 = new Label();
            l2.Text = "Second Number";
            l2.Location = new Point(20, 80);
            this.Controls.Add(l2);

            t2 = new TextBox();
            t2.Location = new Point(120, 80);
            this.Controls.Add(t2);

            Label l3 = new Label();
            l3.Text = "Result";
            l3.Location = new Point(20, 140);
            this.Controls.Add(l3);

            t3 = new TextBox();
            t3.Location = new Point(120, 140);
            this.Controls.Add(t3);

            Button b = new Button();
            b.Text = "Addition";
            b.Location = new Point(120, 200);
            this.Controls.Add(b);
            b.Click += b_add; //click event on addition button
        }

        void b_add(object sender, EventArgs e) //address of function i.e event function. event args contain event data
        {
            int fn = int.Parse(t1.Text);
            int sn = int.Parse(t2.Text);
            int r = fn + sn;
            t3.Text = r.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             Form1 f1 = new Form1(); //creating object of form1 class
            Application.Run(f1); // displays eecuted window form
        }
    }
}
