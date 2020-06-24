using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRolls
{
    
    public partial class Form1 : Form
    {
        int result;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            int sides;
            int numDie;

            //get number of die
            if (rdOne.Checked == true)
            {
                numDie = 1;
            }
            else if (rdTwo.Checked == true)
            {
                numDie = 2;
            }
            else if (rdThree.Checked == true)
            {
                numDie = 3;
            }
            else if (rdFour.Checked == true)
            {
                numDie = 4;
            }
            else
            {
                MessageBox.Show("You need to select how many die to roll", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //get number of sides
            if (rdD6.Checked == true)
            {
                sides = 6;
            }
            else if (rdD10.Checked == true)
            {
                sides = 10;
            }
            else if (rdD12.Checked == true)
            {
                sides = 12;
            }
            else if (rdD20.Checked == true)
            {
                sides = 20;
            }
            else
            {
                MessageBox.Show("You need to select how many sides", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //clear textbox and prepare for roll
            txtResult.Clear();

            //Roll die and display values
            for (int i = 0; i < numDie; i++)
            {
                diceRoll(sides);
                txtResult.Text += result + " ";
            }
            
            return;
        }


        private int diceRoll(int sides)
        {
            result = rnd.Next(1, sides);
            return result;
        }

    }
}
