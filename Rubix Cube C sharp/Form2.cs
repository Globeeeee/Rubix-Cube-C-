using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Drawing2D;



namespace Rubix_Cube_C_sharp
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public Form2()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void openingi(object obj)
        {
            Application.Run(new Form1());
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void shuff_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by the Section of 3A");
            MessageBox.Show("Group members");
            MessageBox.Show("Muhammad Qasim 37137");
            MessageBox.Show("Imran 38621");
        }

        private void st_Click(object sender, EventArgs e)
        {

            this.Close();
            Thread th = new Thread(openingi);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
