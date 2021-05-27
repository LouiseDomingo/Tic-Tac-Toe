using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            btnOne.FlatStyle = FlatStyle.Flat;
            btnOne.FlatAppearance.BorderColor = Color.Black;
            btnOne.FlatAppearance.BorderSize = 1;
            //
            btnTwo.FlatStyle = FlatStyle.Flat;
            btnTwo.FlatAppearance.BorderColor = Color.Black;
            btnTwo.FlatAppearance.BorderSize = 1;
            //
            btnThree.FlatStyle = FlatStyle.Flat;
            btnThree.FlatAppearance.BorderColor = Color.Black;
            btnThree.FlatAppearance.BorderSize = 1;
            //
            btnFour.FlatStyle = FlatStyle.Flat;
            btnFour.FlatAppearance.BorderColor = Color.Black;
            btnFour.FlatAppearance.BorderSize = 1;
            //
            btnFive.FlatStyle = FlatStyle.Flat;
            btnFive.FlatAppearance.BorderColor = Color.Black;
            btnFive.FlatAppearance.BorderSize = 1;
            //
            btnSix.FlatStyle = FlatStyle.Flat;
            btnSix.FlatAppearance.BorderColor = Color.Black;
            btnSix.FlatAppearance.BorderSize = 1;
            //
            btnSeven.FlatStyle = FlatStyle.Flat;
            btnSeven.FlatAppearance.BorderColor = Color.Black;
            btnSeven.FlatAppearance.BorderSize = 1;
            //
            btnEight.FlatStyle = FlatStyle.Flat;
            btnEight.FlatAppearance.BorderColor = Color.Black;
            btnEight.FlatAppearance.BorderSize = 1;
            //
            btnNine.FlatStyle = FlatStyle.Flat;
            btnNine.FlatAppearance.BorderColor = Color.Black;
            btnNine.FlatAppearance.BorderSize = 1;
        }

        int turn_count = 0;
        private void btnOne_Click(object sender, EventArgs e)
        {
            if(turn_count % 2 == 0)
            {
                btnOne.Text = "X";
                screenDisplay.Text = "O turn";
            }
            else
            {
                btnOne.Text = "O";
                screenDisplay.Text = "X turn";
            }

            btnOne.Enabled = false;
            turn_count++;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (turn_count % 2 == 0)
            {
                btnTwo.Text = "X";
                screenDisplay.Text = "O turn";
            }
            else
            {
                btnTwo.Text = "O";
                screenDisplay.Text = "X turn";
            }

            btnTwo.Enabled = false;
            turn_count++;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (turn_count % 2 == 0)
            {
                btnThree.Text = "X";
                screenDisplay.Text = "O turn";
            }
            else
            {
                btnThree.Text = "O";
                screenDisplay.Text = "X turn";
            }

            btnThree.Enabled = false;
            turn_count++;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (turn_count % 2 == 0)
            {
                btnFour.Text = "X";
                screenDisplay.Text = "O turn";
            }
            else
            {
                btnFour.Text = "O";
                screenDisplay.Text = "X turn";
            }

            btnFour.Enabled = false;
            turn_count++;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (turn_count % 2 == 0)
            {
                btnFive.Text = "X";
                screenDisplay.Text = "O turn";
            }
            else
            {
                btnFive.Text = "O";
                screenDisplay.Text = "X turn";
            }

            btnFive.Enabled = false;
            turn_count++;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (turn_count % 2 == 0)
            {
                btnSix.Text = "X";
                screenDisplay.Text = "O turn";
            }
            else
            {
                btnSix.Text = "O";
                screenDisplay.Text = "X turn";
            }

            btnSix.Enabled = false;
            turn_count++;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (turn_count % 2 == 0)
            {
                btnSeven.Text = "X";
                screenDisplay.Text = "O turn";
            }
            else
            {
                btnSeven.Text = "O";
                screenDisplay.Text = "X turn";
            }

            btnSeven.Enabled = false;
            turn_count++;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (turn_count % 2 == 0)
            {
                btnEight.Text = "X";
                screenDisplay.Text = "O turn";
            }
            else
            {
                btnEight.Text = "O";
                screenDisplay.Text = "X turn";
            }

            btnEight.Enabled = false;
            turn_count++;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (turn_count % 2 == 0)
            {
                btnNine.Text = "X";
                screenDisplay.Text = "O turn";
            }
            else
            {
                btnNine.Text = "O";
                screenDisplay.Text = "X turn";
            }

            btnNine.Enabled = false;
            turn_count++;
        }
    }
}
