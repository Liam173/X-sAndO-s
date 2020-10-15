using Project_2._0__X_s_and_O_s_.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2._0__X_s_and_O_s_
{
    public partial class Form1 : Form
    {
        Image o = Resources.O;
        Image x = Resources.X;
        Image def = Resources._default;
        bool yeyOrNey = true;

        int boxOne = 0;
        int boxTwo = 0;
        int boxThree = 0;
        int boxFour = 0;
        int boxFive = 0;
        int boxSix = 0;
        int boxSeven = 0;
        int boxEight = 0;
        int boxNine = 0;

        public Form1()
        {
            InitializeComponent();
            setDefault();
            setTBEnabledOff();
            setBoxEnabledOn();
        }

        private void result()
        {
            if ((boxOne == 1) & (boxTwo == 1) & (boxThree == 1))
            {
                //Print player one won the game
                MessageBox.Show("Player one won the game");
                setBoxEnabledOff();
            } else if ((boxOne == 2) & (boxTwo == 2) & (boxThree == 2))
            {
                //Print player two won the game
                MessageBox.Show("Player two won the game");
                setBoxEnabledOff();
            } else if ((boxFour == 1) & (boxFive == 1) & (boxSix == 1))
            {
                //Print player one won the game
                MessageBox.Show("Player one won the game");
                setBoxEnabledOff();
            } else if ((boxFour == 2) & (boxFive == 2) & (boxSix == 2))
            {
                //Print player two won the game
                MessageBox.Show("Player two won the game");
                setBoxEnabledOff();
            } else if ((boxSeven == 1) & (boxEight == 1) & (boxNine == 1))
            {
                //Print player one won the game
                MessageBox.Show("Player one won the game");
                setBoxEnabledOff();
            } else if ((boxSeven == 2) & (boxEight == 2) & (boxNine == 2))
            {
                //Print player two won the game
                MessageBox.Show("Player two won the game");
                setBoxEnabledOff();
            } else if ((boxOne == 1) & (boxFour == 1) & (boxSeven == 1))
            {
                //Print player one won the game
                MessageBox.Show("Player one won the game");
                setBoxEnabledOff();
            } else if ((boxOne == 2) & (boxFour == 2) & (boxSeven == 2))
            {
                //Print player two won the game
                MessageBox.Show("Player two won the game");
                setBoxEnabledOff();
            } else if ((boxTwo == 1) & (boxFive == 1) & (boxEight == 1))
            {
                //Print player one won the game
                MessageBox.Show("Player one won the game");
                setBoxEnabledOff();
            } else if ((boxTwo == 2) & (boxFive == 2) & (boxEight == 2))
            {
                //Print player two won the game
                MessageBox.Show("Player two won the game");
                setBoxEnabledOff();
            } else if ((boxThree == 1)&(boxSix == 1)&(boxNine == 1))
            {
                //Print player one won the game
                MessageBox.Show("Player one won the game");
                setBoxEnabledOff();
            } else if ((boxThree == 2) & (boxSix == 2) & (boxNine == 2))
            {
                //Print player two won the game
                MessageBox.Show("Player two won the game");
                setBoxEnabledOff();
            } else if ((boxOne == 1) & (boxFive == 1) & (boxNine == 1))
            {
                //Print player one won the game
                MessageBox.Show("Player one won the game");
                setBoxEnabledOff();
            } else if ((boxOne == 2) & (boxFive == 2) & (boxNine == 2))
            {
                //Print player two won the game
                MessageBox.Show("Player two won the game");
                setBoxEnabledOff();
            } else if ((boxThree == 1)&(boxFive == 1)&(boxSeven == 1))
            {
                //Print player one won the game
                MessageBox.Show("Player one won the game");
                setBoxEnabledOff();
            } else if ((boxThree == 2) &(boxFive == 2) & (boxSeven == 2))
            {
                //Print player two won the game
                MessageBox.Show("Player two won the game");
                setBoxEnabledOff();
            }
        }

        private void setDefault()
        {
            pictureBox1.Image = def;
            pictureBox2.Image = def;
            pictureBox3.Image = def;
            pictureBox4.Image = def;
            pictureBox5.Image = def;
            pictureBox6.Image = def;
            pictureBox7.Image = def;
            pictureBox8.Image = def;
            pictureBox9.Image = def;
        }

        private void setBoxEnabledOn()
        {
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
        }

        private void setBoxEnabledOff()
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
        }

        private void setTBEnabledOff()
        {
            richTextBox1.Enabled = false;
            richTextBox2.Enabled = false;
            richTextBox3.Enabled = false;
            richTextBox4.Enabled = false;
            richTextBox5.Enabled = false;
            richTextBox6.Enabled = false;
            richTextBox7.Enabled = false;
            richTextBox8.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            if (yeyOrNey == true)
            {
                pictureBox1.Image = o;
                yeyOrNey = false;
                boxOne = 1;
            }
            else
            {
                pictureBox1.Image = x;
                yeyOrNey = true;
                boxOne = 2;
            }
            result();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Enabled = false;
            if (yeyOrNey == true)
            {
                pictureBox2.Image = o;
                yeyOrNey = false;
                boxTwo = 1;
            }
            else
            {
                pictureBox2.Image = x;
                yeyOrNey = true;
                boxTwo = 2;
            }
            result();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Enabled = false;
            if (yeyOrNey == true)
            {
                pictureBox3.Image = o;
                yeyOrNey = false;
                boxThree = 1;
            }
            else
            {
                pictureBox3.Image = x;
                yeyOrNey = true;
                boxThree = 2;
            }
            result();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Enabled = false;
            if (yeyOrNey == true)
            {
                pictureBox4.Image = o;
                yeyOrNey = false;
                boxFour = 1;
            }
            else
            {
                pictureBox4.Image = x;
                yeyOrNey = true;
                boxFour = 2;
            }
            result();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Enabled = false;
            if (yeyOrNey == true)
            {
                pictureBox5.Image = o;
                yeyOrNey = false;
                boxFive = 1;
            }
            else
            {
                pictureBox5.Image = x;
                yeyOrNey = true;
                boxFive = 2;
            }
            result();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Enabled = false;
            if (yeyOrNey == true)
            {
                pictureBox6.Image = o;
                yeyOrNey = false;
                boxSix = 1;
            }
            else
            {
                pictureBox6.Image = x;
                yeyOrNey = true;
                boxSix = 2;
            }
            result();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Enabled = false;
            if (yeyOrNey == true)
            {
                pictureBox7.Image = o;
                yeyOrNey = false;
                boxSeven = 1;
            }
            else
            {
                pictureBox7.Image = x;
                yeyOrNey = true;
                boxSeven = 2;
            }
            result();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Enabled = false;
            if (yeyOrNey == true)
            {
                pictureBox8.Image = o;
                yeyOrNey = false;
                boxEight = 1;
            }
            else
            {
                pictureBox8.Image = x;
                yeyOrNey = true;
                boxEight = 2;
            }
            result();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Enabled = false;
            if (yeyOrNey == true)
            {
                pictureBox9.Image = o;
                yeyOrNey = false;
                boxNine = 1;
            }
            else
            {
                pictureBox9.Image = x;
                yeyOrNey = true;
                boxNine = 2;
            }
            result();
        }
    }
}
