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


    public partial class Form1 : Form
    {
        public static Form1 instance;
        Button[] fr1;
        Button[] fr2;k
        Button[] fr3;
        Button[] fc1;
        Button[] fc2;
        Button[] fc3;

        public Form1()
        {
            InitializeComponent();

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            st1.Visible = false;
            st2.Visible = false;
            st3.Visible = false;
            fr1 = new Button[] { row1_1, row1_2, row1_3, row1_4, row1_5, row1_6, row1_7, row1_8, row1_9, row1_10, row1_11, row1_12 };
            fr2 = new Button[] { row2_1, row2_2, row2_3, row2_4, row2_5, row2_6, row2_7, row2_8, row2_9, row2_10, row2_11, row2_12 };
            fr3 = new Button[] { row3_1, row3_2, row3_3, row3_4, row3_5, row3_6, row3_7, row3_8, row3_9, row3_10, row3_11, row3_12 };
            fc1 = new Button[] { row1_1, row2_1, row3_1, col1_4, col1_5, col1_6, row1_7, row2_7, row3_7, col1_10, col1_11, col1_12 };
            fc2 = new Button[] { row1_2, row2_2, row3_2, col2_4, col2_5, col2_6, row1_8, row2_8, row3_8, col2_10, col2_11, col2_12 };
            fc3 = new Button[] { row1_3, row2_3, row3_3, col3_4, col3_5, col3_6, row1_9, row2_9, row3_9, col3_10, col3_11, col3_12 };
       

        }
        

        //left movement <------
        public void button1_Click_1(object sender, EventArgs e)
        {
            Button[] store = { st1, st2, st3 };
            for (int i = 0; i < 3; i++)
            {
                store[i].BackColor = fr1[i].BackColor;

            }
            for (int a = 0; a < 9; a++)
            {
                fr1[a].BackColor = fr1[a + 3].BackColor;
            }
            int j = 0;
            for (int i = 9; i < 12; i++)
            {
                fr1[i].BackColor = store[j].BackColor;
                j++;
            }
            fc1[0] = fr1[0];
            fc2[0] = fr1[1];
            fc3[0] = fr1[2];

            fc1[6] = fr1[6];
            fc2[6] = fr1[7];
            fc3[6] = fr1[8];


        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Button[] store = { st1, st2, st3 };
            for (int i = 0; i < 3; i++)
            {
                store[i].BackColor = fr2[i].BackColor;

            }
            for (int a = 0; a < 9; a++)
            {
                fr2[a].BackColor = fr2[a + 3].BackColor;
            }
            int j = 0;
            for (int i = 9; i < 12; i++)
            {
                fr2[i].BackColor = store[j].BackColor;
                j++;
            }
            fc1[1] = fr2[0];
            fc2[1] = fr2[1];
            fc3[1] = fr2[2];

            fc1[7] = fr2[6];
            fc2[7] = fr2[7];
            fc3[7] = fr2[8];

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Button[] store = { st1, st2, st3 };
            for (int i = 0; i < 3; i++)
            {
                store[i].BackColor = fr3[i].BackColor;

            }
            for (int a = 0; a < 9; a++)
            {
                fr3[a].BackColor = fr3[a + 3].BackColor;
            }
            int j = 0;
            for (int i = 9; i < 12; i++)
            {
                fr3[i].BackColor = store[j].BackColor;
                j++;
            }
            fc1[2] = fr3[0];
            fc2[2] = fr3[1];
            fc3[2] = fr3[2];

            fc1[8] = fr3[6];
            fc2[8] = fr3[7];
            fc3[8] = fr3[8];
        }

        //right movement  ---->

        private void button4_Click_1(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Button[] store = { st1, st2, st3 };
            int a = 0;
            for (int i = 9; i < 12; i++)
            {
                store[a].BackColor = fr1[i].BackColor;
                a++;
            }
            for (a = 8; a >= 0; a--)
            {
                fr1[a + 3].BackColor = fr1[a].BackColor;
            }

            for (int i = 0; i < 3; i++)
            {
                fr1[i].BackColor = store[i].BackColor;
            }
            fc1[0] = fr1[0];
            fc2[0] = fr1[1];
            fc3[0] = fr1[2];

            fc1[6] = fr1[6];
            fc2[6] = fr1[7];
            fc3[6] = fr1[8];
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            Button[] store = { st1, st2, st3 };
            int a = 0;
            for (int i = 9; i < 12; i++)
            {
                store[a].BackColor = fr2[i].BackColor;
                a++;
            }
            for (a = 8; a >= 0; a--)
            {
                fr2[a + 3].BackColor = fr2[a].BackColor;
            }

            for (int i = 0; i < 3; i++)
            {
                fr2[i].BackColor = store[i].BackColor;
            }
            fc1[1] = fr2[0];
            fc2[1] = fr2[1];
            fc3[1] = fr2[2];

            fc1[7] = fr2[6];
            fc2[7] = fr2[7];
            fc3[7] = fr2[8];
        }

        private void button4_Click_3(object sender, EventArgs e)
        {
            Button[] store = { st1, st2, st3 };
            int a = 0;
            for (int i = 9; i < 12; i++)
            {
                store[a].BackColor = fr3[i].BackColor;
                a++;
            }
            for (a = 8; a >= 0; a--)
            {
                fr3[a + 3].BackColor = fr3[a].BackColor;
            }

            for (int i = 0; i < 3; i++)
            {
                fr3[i].BackColor = store[i].BackColor;
            }
            fc1[2] = fr3[0];
            fc2[2] = fr3[1];
            fc3[2] = fr3[2];

            fc1[8] = fr3[6];
            fc2[8] = fr3[7];
            fc3[8] = fr3[8];
        }




        // up movement   ^
        //              |
        private void button2_Click_1(object sender, EventArgs e)
        {

            Button[] store = { st1, st2, st3 };
            for (int i = 0; i < 3; i++)
            {
                store[i].BackColor = fc1[i].BackColor;

            }
            for (int a = 0; a < 9; a++)
            {
                fc1[a].BackColor = fc1[a + 3].BackColor;
            }
            int j = 0;
            for (int i = 9; i < 12; i++)
            {
                fc1[i].BackColor = store[j].BackColor;
                j++;
            }
            fr1[0] = fc1[0];
            fr2[0] = fc1[1];
            fr3[0] = fc1[2];

            fr1[6] = fc1[6];
            fr2[6] = fc1[7];
            fr3[6] = fc1[8];
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Button[] store = { st1, st2, st3 };
            for (int i = 0; i < 3; i++)
            {
                store[i].BackColor = fc2[i].BackColor;

            }
            for (int a = 0; a < 9; a++)
            {
                fc2[a].BackColor = fc2[a + 3].BackColor;
            }
            int j = 0;
            for (int i = 9; i < 12; i++)
            {
                fc2[i].BackColor = store[j].BackColor;
                j++;
            }
            fr1[1] = fc2[0];
            fr3[1] = fc2[2];
            fr2[1] = fc2[1];

            fr2[7] = fc2[7];
            fr1[7] = fc2[6];
            fr3[7] = fc2[8];
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            Button[] store = { st1, st2, st3 };
            for (int i = 0; i < 3; i++)
            {
                store[i].BackColor = fc3[i].BackColor;

            }
            for (int a = 0; a < 9; a++)
            {
                fc3[a].BackColor = fc3[a + 3].BackColor;
            }
            int j = 0;
            for (int i = 9; i < 12; i++)
            {
                fc3[i].BackColor = store[j].BackColor;
                j++;
            }
            fr1[2] = fc3[0];
            fr3[2] = fc3[2];
            fr2[2] = fc3[1];

            fr2[8] = fc3[7];
            fr1[8] = fc3[6];
            fr3[8] = fc3[8];
        }


        //              |
        //down movement v

        private void button3_Click_1(object sender, EventArgs e)
        {
            Button[] store = { st1, st2, st3 };
            int a = 0;
            for (int i = 9; i < 12; i++)
            {
                store[a].BackColor = fc1[i].BackColor;
                a++;
            }
            for (a = 8; a >= 0; a--)
            {
                fc1[a + 3].BackColor = fc1[a].BackColor;
            }

            for (int i = 0; i < 3; i++)
            {
                fc1[i].BackColor = store[i].BackColor;
            }
            fr1[0] = fc1[0];
            fr2[0] = fc1[1];
            fr3[0] = fc1[2];

            fr1[6] = fc1[6];
            fr2[6] = fc1[7];
            fr3[6] = fc1[8];

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Button[] store = { st1, st2, st3 };
            int a = 0;
            for (int i = 9; i < 12; i++)
            {
                store[a].BackColor = fc2[i].BackColor;
                a++;
            }
            for (a = 8; a >= 0; a--)
            {
                fc2[a + 3].BackColor = fc2[a].BackColor;
            }

            for (int i = 0; i < 3; i++)
            {
                fc2[i].BackColor = store[i].BackColor;
            }
            fr1[1] = fc2[0];
            fr2[1] = fc2[1];
            fr3[1] = fc2[2];

            fr1[7] = fc2[6];
            fr2[7] = fc2[7];
            fr3[7] = fc2[8];


        }

        private void button3_Click_3(object sender, EventArgs e)
        {
            Button[] store = { st1, st2, st3 };
            int a = 0;
            for (int i = 9; i < 12; i++)
            {
                store[a].BackColor = fc3[i].BackColor;
                a++;
            }
            for (a = 8; a >= 0; a--)
            {
                fc3[a + 3].BackColor = fc3[a].BackColor;
            }

            for (int i = 0; i < 3; i++)
            {
                fc3[i].BackColor = store[i].BackColor;
            }
            fr1[2] = fc3[0];
            fr2[2] = fc3[1];
            fr3[2] = fc3[2];

            fr1[2] = fc3[6];
            fr2[2] = fc3[7];
            fr3[2] = fc3[8];

        }

        public void button3_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(5, 25);
            for (int i = 0; i < randomNumber; i++)
            {
                button1_Click_1(sender, e);
                button2_Click_1(sender, e);
                button3_Click_1(sender, e);
                button4_Click_1(sender, e);
                button3_Click_3(sender, e);
                button1_Click_2(sender, e);
                button2_Click_3(sender, e);
                button1_Click_1(sender, e);
                button3_Click_2(sender, e);
                button4_Click_1(sender, e);
                button3_Click_2(sender, e);
                button2_Click_3(sender, e);
                button1_Click_1(sender, e);
                button4_Click_3(sender, e);
                button4_Click_1(sender, e);
            }
        }
       


        private void button4_Click(object sender, EventArgs e)
        {

            Form newForm = new Form1(); 
            newForm.Show(); 
            this.Hide();
           
        }
        public void openingi(object obj)
        {
            Application.Run(new Form2());
        }
        private void back(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openingi);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }

}
