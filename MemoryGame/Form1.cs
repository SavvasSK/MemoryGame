using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        bool selected = false;
        bool custom = false;
        PictureBox[] boxes = new PictureBox[24];
        Random rand = new Random();
        Image[] eikones = new Image[24];
        int [] comp = new int[24];
        int tries;
        int check;
        int first;
        int second;
        int sec = 0;

        public Form1()
        {
            InitializeComponent();
            boxes[0] = pictureBox1;
            boxes[1] = pictureBox2;
            boxes[2] = pictureBox3;
            boxes[3] = pictureBox4;
            boxes[4] = pictureBox5;
            boxes[5] = pictureBox6;
            boxes[6] = pictureBox7;
            boxes[7] = pictureBox8;
            boxes[8] = pictureBox9;
            boxes[9] = pictureBox10;
            boxes[10] = pictureBox11;
            boxes[11] = pictureBox12;
            boxes[12] = pictureBox13;
            boxes[13] = pictureBox14;
            boxes[14] = pictureBox15;
            boxes[15] = pictureBox16;
            boxes[16] = pictureBox17;
            boxes[17] = pictureBox18;
            boxes[18] = pictureBox19;
            boxes[19] = pictureBox20;
            boxes[20] = pictureBox21;
            boxes[21] = pictureBox22;
            boxes[22] = pictureBox23;
            boxes[23] = pictureBox24;           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            tries = 0;
            check = 0;
            first = 30;
            second = 30;
            sec = 0;

            for (int i = 0; i < 24; i++)
            {
                boxes[i].Enabled = true;
            }

            if (selected == false)
            {
                if (custom == false)
                {
                    eikones[0] = Properties.Resources._1;
                    eikones[1] = Properties.Resources._2;
                    eikones[2] = Properties.Resources._3;
                    eikones[3] = Properties.Resources._4;
                    eikones[4] = Properties.Resources._5;
                    eikones[5] = Properties.Resources._6;
                    eikones[6] = Properties.Resources._7;
                    eikones[7] = Properties.Resources._8;
                    eikones[8] = Properties.Resources._9;
                    eikones[9] = Properties.Resources._10;
                    eikones[10] = Properties.Resources._11;
                    eikones[11] = Properties.Resources._12;
                    eikones[12] = Properties.Resources._1;
                    eikones[13] = Properties.Resources._2;
                    eikones[14] = Properties.Resources._3;
                    eikones[15] = Properties.Resources._4;
                    eikones[16] = Properties.Resources._5;
                    eikones[17] = Properties.Resources._6;
                    eikones[18] = Properties.Resources._7;
                    eikones[19] = Properties.Resources._8;
                    eikones[20] = Properties.Resources._9;
                    eikones[21] = Properties.Resources._10;
                    eikones[22] = Properties.Resources._11;
                    eikones[23] = Properties.Resources._12;
                }
                else
                {
                    OpenFileDialog dlg = new OpenFileDialog();
                    dlg.Title = "Open Image";
                    dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.bmp, *.png) | *.jpg; *.jpeg; *.jpe; *.bmp; *.png";

                    for (int i = 0; i < 12; i++)
                    {
                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            eikones[i] = Image.FromFile(dlg.FileName);
                        }
                    }
                    for (int y = 0; y < 12; y++)
                    {
                        eikones[y + 12] = eikones[y];
                    }

                }
            }

            comp[0] = 1;
            comp[1] = 2;
            comp[2] = 3;
            comp[3] = 4;
            comp[4] = 5;
            comp[5] = 6;
            comp[6] = 7;
            comp[7] = 8;
            comp[8] = 9;
            comp[9] = 10;
            comp[10] = 11;
            comp[11] = 12;
            comp[12] = 1;
            comp[13] = 2;
            comp[14] = 3;
            comp[15] = 4;
            comp[16] = 5;
            comp[17] = 6;
            comp[18] = 7;
            comp[19] = 8;
            comp[20] = 9;
            comp[21] = 10;
            comp[22] = 11;
            comp[23] = 12;

            Image tempim;
            int tempid;

            for (int i = 0; i < 24; i++)
            {
                int mpla = rand.Next(0, 23);

                tempim = eikones[mpla];
                eikones[mpla] = eikones[i];
                eikones[i] = tempim;

                tempid = comp[mpla];
                comp[mpla] = comp[i];
                comp[i] = tempid;
            }

            timer1.Start();

            pictureBox1.Image = eikones[0];
            pictureBox2.Image = eikones[1];
            pictureBox3.Image = eikones[2];
            pictureBox4.Image = eikones[3];
            pictureBox5.Image = eikones[4];
            pictureBox6.Image = eikones[5];
            pictureBox7.Image = eikones[6];
            pictureBox8.Image = eikones[7];
            pictureBox9.Image = eikones[8];
            pictureBox10.Image = eikones[9];
            pictureBox11.Image = eikones[10];
            pictureBox12.Image = eikones[11];
            pictureBox13.Image = eikones[12];
            pictureBox14.Image = eikones[13];
            pictureBox15.Image = eikones[14];
            pictureBox16.Image = eikones[15];
            pictureBox17.Image = eikones[16];
            pictureBox18.Image = eikones[17];
            pictureBox19.Image = eikones[18];
            pictureBox20.Image = eikones[19];
            pictureBox21.Image = eikones[20];
            pictureBox22.Image = eikones[21];
            pictureBox23.Image = eikones[22];
            pictureBox24.Image = eikones[23];
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           pictureBox1.Image = eikones[0];

           if (first == 30)
           {
               first = 0;
               boxes[first].Enabled = false;
           }
           else if (first != 30)
           {
               second = 0;
               tries += 1;
               if (comp[0] == comp[first])
               {
                   pictureBox1.Enabled = false;
                   boxes[first].Enabled = false;
                   first = 30;
                   check += 1;
               }
               else if (comp[0] != comp[first])
               {
                   timer2.Start();
               }
            
           }

           if (check == 12)
           {
               timer3.Stop();
               System.IO.File.AppendAllText("saved/scores.txt", "The User " + textBox1.Text + " Made " + tries.ToString() + " tries and " + sec + " seconds" + Environment.NewLine);
               MessageBox.Show("The player made " + tries.ToString() + " tries and " + sec + " seconds" );
           }   

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image= eikones[1];

            if (first == 30)
            {
                first = 1;
                boxes[first].Enabled = false;
            }
            else if (first != 30)
            {
                second = 1;
                tries += 1;
                if (comp[1] == comp[first])
                {
                    pictureBox2.Enabled = false;
                    boxes[first].Enabled = false;
                    first = 30;
                    check += 1;
                }
                else if (comp[1] != comp[first])
                {
                    timer2.Start();
                }             
            }

            if (check == 12)
            {
                timer3.Stop();
                System.IO.File.AppendAllText("saved/scores.txt", "The User " + textBox1.Text + " Made " + tries.ToString() + " tries and " + sec + " seconds" + Environment.NewLine);
                MessageBox.Show("The player made " + tries.ToString() + " tries and " + sec + " seconds");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = eikones[2];

            if (first == 30)
            {
                first = 2;
                boxes[first].Enabled = false;
            }
            else if (first != 30)
            {
                second = 2;
                tries += 1;
                if (comp[2] == comp[first])
                {
                    pictureBox3.Enabled = false;
                    boxes[first].Enabled = false;
                    first = 30;
                    check += 1;
                }
                else if (comp[2] != comp[first])
                {
                    timer2.Start();
                }                
            }

            if (check == 12)
            {
                timer3.Stop();
                System.IO.File.AppendAllText("saved/scores.txt", "The User " + textBox1.Text + " Made " + tries.ToString() + " tries and " + sec + " seconds" + Environment.NewLine);
                MessageBox.Show("The player made " + tries.ToString() + " tries and " + sec + " seconds");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = eikones[3];

            if (first == 30)
            {
                first = 3;
                boxes[first].Enabled = false;
            }
            else if (first != 30)
            {
                second = 3;
                tries += 1;
                if (comp[3] == comp[first])
                {
                    pictureBox4.Enabled = false;
                    boxes[first].Enabled = false;
                    first = 30;
                    check += 1;
                }
                else if (comp[3] != comp[first])
                {
                    timer2.Start();
                }             
            }
            if (check == 12)
            {
                timer3.Stop();
                System.IO.File.AppendAllText("saved/scores.txt", "The User " + textBox1.Text + " Made " + tries.ToString() + " tries and " + sec + " seconds" + Environment.NewLine);
                MessageBox.Show("The player made " + tries.ToString() + " tries and " + sec + " seconds");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = eikones[4];

            if (first == 30)
            {
                first = 4;
                boxes[first].Enabled = false;
            }
            else if (first != 30)
            {
                second = 4;
                tries += 1;
                if (comp[4] == comp[first])
                {
                    pictureBox5.Enabled = false;
                    boxes[first].Enabled = false;
                    first = 30;
                    check += 1;
                }
                else if (comp[4] != comp[first])
                {
                    timer2.Start();
                } 
              
            }
            if (check == 12)
            {
                timer3.Stop();
                System.IO.File.AppendAllText("saved/scores.txt", "The User " + textBox1.Text + " Made " + tries.ToString() + " tries and " + sec + " seconds" + Environment.NewLine);
                MessageBox.Show("The player made " + tries.ToString() + " tries and " + sec + " seconds");
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = eikones[5];

            if (first == 30)
            {
                first = 5;
                boxes[first].Enabled = false;
            }
            else if (first != 30)
            {
                second = 5;
                tries += 1;
                if (comp[5] == comp[first])
                {
                    pictureBox6.Enabled = false;
                    boxes[first].Enabled = false;
                    first = 30;
                    check += 1;
                }
                else if (comp[5] != comp[first])
                {
                    timer2.Start();
                }
                
            }
            if (check == 12)
            {
                timer3.Stop();
                System.IO.File.AppendAllText("saved/scores.txt", "The User " + textBox1.Text + " Made " + tries.ToString() + " tries and " + sec + " seconds" + Environment.NewLine);
                MessageBox.Show("The player made " + tries.ToString() + " tries and " + sec + " seconds");
            }   
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = eikones[6];

            if (first == 30)
            {
                first = 6;
                boxes[first].Enabled = false;
            }
            else if (first != 30)
            {
                second = 6;
                tries += 1;
                if (comp[6] == comp[first])
                {
                    pictureBox7.Enabled = false;
                    boxes[first].Enabled = false;
                    first = 30;
                    check += 1;
                }
                else if (comp[6] != comp[first])
                {
                    timer2.Start();
                }             
            }
            if (check == 12)
            {
                timer3.Stop();
                System.IO.File.AppendAllText("saved/scores.txt", "The User " + textBox1.Text + " Made " + tries.ToString() + " tries and " + sec + " seconds" + Environment.NewLine);
                MessageBox.Show("The player made " + tries.ToString() + " tries and " + sec + " seconds");
            }   
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = eikones[7];

            if (first == 30)
            {
                first = 7;
                boxes[first].Enabled = false;
            }
            else if (first != 30)
            {
                second = 7;
                tries += 1;
                if (comp[7] == comp[first])
                {
                    pictureBox8.Enabled = false;
                    boxes[first].Enabled = false;
                    first = 30;
                    check += 1;
                }
                else if (comp[7] != comp[first])
                {
                    timer2.Start();
                }
                
            }
            if (check == 12)
            {
                timer3.Stop();
                System.IO.File.AppendAllText("saved/scores.txt", "The User " + textBox1.Text + " Made " + tries.ToString() + " tries and " + sec + " seconds" + Environment.NewLine);
                MessageBox.Show("The player made " + tries.ToString() + " tries and " + sec + " seconds");
            }   
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = eikones[8];

            if (first == 30)
            {
                first = 8;
                boxes[first].Enabled = false;
            }
            else if (first != 30)
            {
                second = 8;
                tries += 1;
                if (comp[8] == comp[first])
                {
                    pictureBox9.Enabled = false;
                    boxes[first].Enabled = false;
                    first = 30;
                    check += 1;
                }
                else if (comp[8] != comp[first])
                {
                    timer2.Start();
                }
               
            }
            if (check == 12)
            {
                timer3.Stop();
                System.IO.File.AppendAllText("saved/scores.txt", "The User " + textBox1.Text + " Made " + tries.ToString() + " tries and " + sec + " seconds" + Environment.NewLine);
                MessageBox.Show("The player made " + tries.ToString() + " tries and " + sec + " seconds");
            }   
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Image = eikones[9];

            if (first == 30)
            {
                first = 9;
                boxes[first].Enabled = false;
            }
            else if (first != 30)
            {
                second = 9;
                tries += 1;
                 if (comp[9] == comp[first])
                {
                    pictureBox10.Enabled = false;
                    boxes[first].Enabled = false;
                    first = 30;
                    check += 1;

                }
                else if (comp[9] != comp[first])
                {
                    timer2.Start();
                }
               
            }
            if (check == 12)
            {
                timer3.Stop();
                System.IO.File.AppendAllText("saved/scores.txt", "The User " + textBox1.Text + " Made " + tries.ToString() + " tries and " + sec + " seconds"+ Environment.NewLine);
                MessageBox.Show("The player made " + tries.ToString() + " tries and " + sec + " seconds");
            }   
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = eikones[10];

            if (first == 30)
            {
                first = 10;
                boxes[first].Enabled = false;
            }
            else if (first != 30)
            {
                second = 10;
                tries += 1;
                if (comp[10] == comp[first])
                {
                    pictureBox11.Enabled = false;
                    boxes[first].Enabled = false;
                    first = 30;
                    check += 1;
                }
                else if (comp[10] != comp[first])
                {
                    timer2.Start();
                }
                
            }
            if (check == 12)
            {
                timer3.Stop();
                System.IO.File.AppendAllText("saved/scores.txt", "The User " + textBox1.Text + " Made " + tries.ToString() + " tries and " + sec + " seconds" + Environment.NewLine);
                MessageBox.Show("The player made " + tries.ToString() + " tries and " + sec + " seconds");
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Image = eikones[11];

            if (first == 30)
            {
                first = 11;
                boxes[first].Enabled = false;
            }
            else if (first != 30)
            {
                second = 11;
                tries += 1;
                if (comp[11] == comp[first])
                {
                    pictureBox12.Enabled = false;
                    boxes[first].Enabled = false;
                    first = 30;
                    check += 1;
                }
                else if (comp[11] != comp[first])
                {
                    timer2.Start();
                }
                

            }
            if (check == 12)
            {
                timer3.Stop();
                System.IO.File.AppendAllText("saved/scores.txt", "The User " + textBox1.Text + " Made " + tries.ToString() + " tries and " + sec + " seconds" + Environment.NewLine);
                MessageBox.Show("The player made " + tries.ToString() + " tries and " + sec + " seconds");
            }   
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.Image = eikones[12];

            if (first == 30)
            {
                first = 12;
                boxes[first].Enabled = false;
            }
            else if (first != 30)
            {
                second = 12;
                tries += 1;
                if (comp[12] == comp[first])
                {
                    pictureBox13.Enabled = false;
                    boxes[first].Enabled = false;
                    first = 30;
                    check += 1;
                }
                else if (comp[12] != comp[first])
                {
                    timer2.Start();
                }
                
            }
            if (check == 12)
            {
                timer3.Stop();
                System.IO.File.AppendAllText("saved/scores.txt", "The User " + textBox1.Text + " Made " + tries.ToString() + " tries and " + sec + " seconds" + Environment.NewLine);
                MessageBox.Show("The player made " + tries.ToString() + " tries and " + sec + " seconds");
            }   
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = eikones[13];

            if (first == 30)
            {
                first = 13;
                boxes[first].Enabled = false;
            }
            else if (first != 30)
            {
                second = 13;
                tries += 1;
                if (comp[13] == comp[first])
                {
                    pictureBox14.Enabled = false;
                    boxes[first].Enabled = false;
                    first = 30;
                    check += 1;
                }
                else if (comp[13] != comp[first])
                {
                    timer2.Start();
                }
                
            }
            if (check == 12)
            {
                timer3.Stop();
                System.IO.File.AppendAllText("saved/scores.txt", "The User " + textBox1.Text + " Made " + tries.ToString() + " tries and " + sec + " seconds" + Environment.NewLine);
                MessageBox.Show("The player made " + tries.ToString() + " tries and " + sec + " seconds");
            }   
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox15.Image = eikones[14];

            if (first == 30)
            {
                first = 14;
                boxes[first].Enabled = false;
            }
            else if (first != 30)
            {
                second = 14;
                tries += 1;
                if (comp[14] == comp[first])
                {
                    pictureBox15.Enabled = false;
                    boxes[first].Enabled = false;
                    first = 30;
                    check += 1;
                }
                else if (comp[14] != comp[first])
                {
                    timer2.Start();
                }
               
            }
            if (check == 12)
            {
                timer3.Stop();
                System.IO.File.AppendAllText("saved/scores.txt", "The User " + textBox1.Text + " Made " + tries.ToString() + " tries and " + sec + " seconds" + Environment.NewLine);
                MessageBox.Show("The player made " + tries.ToString() + " tries and " + sec + " seconds");
            }   
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.Image = eikones[15];

            if (first == 30)
            {
                first = 15;
                boxes[first].Enabled = false;
            }
            else if (first != 30)
            {
                second = 15;
                tries += 1;
                if (comp[15] == comp[first])
                {
                    pictureBox16.Enabled = false;
                    boxes[first].Enabled = false;
                    first = 30;
                    check += 1;
                }
                else if (comp[15] != comp[first])
                {
                    timer2.Start();
                }
                
            }
            if (check == 12)
            {
                timer3.Stop();
                System.IO.File.AppendAllText("saved/scores.txt", "The User " + textBox1.Text + " Made " + tries.ToString() + " tries and " + sec + " seconds" + Environment.NewLine);
                MessageBox.Show("The player made " + tries.ToString() + " tries and " + sec + " seconds");
            }   
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox17.Image = eikones[16];

            if (first == 30)
            {
                first = 16;
                boxes[first].Enabled = false;
            }
            else if (first != 30)
            {
                second = 16;
                tries += 1;
                if (comp[16] == comp[first])
                {
                    pictureBox17.Enabled = false;
                    boxes[first].Enabled = false;
                    first = 30;
                    check += 1;
                }
                else if (comp[16] != comp[first])
                {
                    timer2.Start();
                }
                
            }
            if (check == 12)
            {
                timer3.Stop();
                System.IO.File.AppendAllText("saved/scores.txt", "The User " + textBox1.Text + " Made " + tries.ToString() + " tries and " + sec + " seconds" + Environment.NewLine);
                MessageBox.Show("The player made " + tries.ToString() + " tries and " + sec + " seconds");
            }   
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pictureBox18.Image = eikones[17];

            if (first == 30)
            {
                first = 17;
                boxes[first].Enabled = false;
            }        
            else if (first != 30)
            {
                second = 17;
                tries += 1;
                if (comp[17] == comp[first])
                {
                    pictureBox18.Enabled = false;
                    boxes[first].Enabled = false;
                    first = 30;
                    check += 1;
                }
                else if (comp[17] != comp[first])
                {
                    timer2.Start();
                }
               
            }
            if (check == 12)
            {
                timer3.Stop();
                System.IO.File.AppendAllText("saved/scores.txt", "The User " + textBox1.Text + " Made " + tries.ToString() + " tries and " + sec + " seconds" + Environment.NewLine);
                MessageBox.Show("The player made " + tries.ToString() + " tries and " + sec + " seconds");
            }   
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            pictureBox19.Image = eikones[18];

            if (first == 30)
            {
                first = 18;
                boxes[first].Enabled = false;
            }
            else if (first != 30)
            {
                tries += 1;
                second = 18;
                if (comp[18] == comp[first])
                {
                    pictureBox19.Enabled = false;
                    boxes[first].Enabled = false;
                    first = 30;
                    check += 1;
                }
                else if (comp[18] != comp[first])
                {
                    timer2.Start();
                }
                
            }
            if (check == 12)
            {
                timer3.Stop();
                System.IO.File.AppendAllText("saved/scores.txt", "The User " + textBox1.Text + " Made " + tries.ToString() + " tries and " + sec + " seconds" + Environment.NewLine);
                MessageBox.Show("The player made " + tries.ToString() + " tries and " + sec + " seconds");
            }   
        }


        private void pictureBox20_Click(object sender, EventArgs e)
        {
            pictureBox20.Image = eikones[19];

            if (first == 30)
            {
                first = 19;
                boxes[first].Enabled = false;
            }
            else if (first != 30)
            {
                second = 19;
                tries += 1;
                if (comp[19] == comp[first])
                {
                    pictureBox20.Enabled = false;
                    boxes[first].Enabled = false;
                    first = 30;
                    check += 1;
                }
                else if (comp[19] != comp[first])
                {
                    timer2.Start();
                }
            }
            if (check == 12)
            {
                timer3.Stop();
                System.IO.File.AppendAllText("saved/scores.txt", "The User " + textBox1.Text + " Made " + tries.ToString() + " tries and " + sec + " seconds" + Environment.NewLine);
                MessageBox.Show("The player made " + tries.ToString() + " tries and " + sec + " seconds");
            }   
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            pictureBox21.Image = eikones[20];

            if (first == 30)
            {
                first = 20;
                boxes[first].Enabled = false;
            }
            else if (first != 30)
            {
                second = 20;
                tries += 1;
                if (comp[20] == comp[first])
                {
                    pictureBox21.Enabled = false;
                    boxes[first].Enabled = false;
                    first = 30;
                    check += 1;
                }
                else if (comp[20] != comp[first])
                {
                    timer2.Start();
                }
                
            }
            if (check == 12)
            {
                timer3.Stop();
                System.IO.File.AppendAllText("saved/scores.txt", "The User " + textBox1.Text + " Made " + tries.ToString() + " tries and " + sec + " seconds" + Environment.NewLine);
                MessageBox.Show("The player made " + tries.ToString() + " tries and " + sec + " seconds");
            }   
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            pictureBox22.Image = eikones[21];

            if (first == 30)
            {
                first = 21;
                boxes[first].Enabled = false;
            }
            else if (first != 30)
            {
                second = 21;
                tries += 1;
                if (comp[21] == comp[first])
                {
                    pictureBox22.Enabled = false;
                    boxes[first].Enabled = false;
                    first = 30;
                    check += 1;
                }
                else if (comp[21] != comp[first])
                {
                    timer2.Start();
                }
               
            }
            if (check == 12)
            {
                timer3.Stop();
                System.IO.File.AppendAllText("saved/scores.txt", "The User " + textBox1.Text + " Made " + tries.ToString() + " tries and " + sec + " seconds" + Environment.NewLine);
                MessageBox.Show("The player made " + tries.ToString() + " tries and " + sec + " seconds");
            }   
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            pictureBox23.Image = eikones[22];

            if (first == 30)
            {
                first = 22;
                boxes[first].Enabled = false;
            }
            else if (first != 30)
            {
                second = 22;
                tries += 1;
                if (comp[22] == comp[first])
                {
                    pictureBox23.Enabled = false;
                    boxes[first].Enabled = false;
                    first = 30;
                    check += 1;
                }
                else if (comp[22] != comp[first])
                {
                    timer2.Start();
                }
                
            }
            if (check == 12)
            {
                timer3.Stop();
                System.IO.File.AppendAllText("saved/scores.txt", "The User " + textBox1.Text + " Made " + tries.ToString() + " tries and " + sec + " seconds" + Environment.NewLine);
                MessageBox.Show("The player made " + tries.ToString() + " tries and " + sec + " seconds");
            }   
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            pictureBox24.Image = eikones[23];

            if (first == 30)
            {
                first = 23;
                boxes[first].Enabled = false;
            }
            else if (first != 30)
            {
                second = 23;
                tries += 1;

                if (comp[23] == comp[first])
                {
                    pictureBox24.Enabled = false;
                    boxes[first].Enabled = false;
                    first = 30;
                    check += 1;
                }
                else if (comp[23] != comp[first])
                {
                    timer2.Start();
                }
               
            }
            if (check == 12)
            {
                timer3.Stop();
                System.IO.File.AppendAllText("saved/scores.txt", "The User " + textBox1.Text + " Made " + tries.ToString() + " tries and " + sec + " seconds" + Environment.NewLine);
                MessageBox.Show("The player made " + tries.ToString() + " tries and " + sec + " seconds");
            }   
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++)
            {
              
                boxes[i].Image = Properties.Resources.qm;
                timer1.Stop();
                timer3.Start();
                
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            boxes[first].Image = Properties.Resources.qm;
            boxes[second].Image = Properties.Resources.qm;


            boxes[first].Enabled = true;

            timer2.Stop();
            first = 30;

            
           
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            sec += 1;
        }

       

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
            Application.Exit();
        }

        private void chooseYourOwnCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            custom = true;
            Form1_Load(sender, e);
        }

        private void useDefaultCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selected = false;
            custom = false;
            Form1_Load(sender, e);
        }

        private void keepTheSelectedCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selected = true;
            Form1_Load(sender, e);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Memmory Game! The rules are simple, give a quick look when the game loads to see where each image is, and try to match the same pairs. ATTENTION! When the game loads, it has the default cards. However from the menu you can pic your own. BUT BE CAREFULL! you have to choose 12 DIFFERENT images! Have Fun :)");
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }      
    }
}
