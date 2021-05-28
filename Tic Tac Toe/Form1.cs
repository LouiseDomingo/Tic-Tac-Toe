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
                gettingTheWinner();
            }
            else
            {
                btnOne.Text = "O";
                screenDisplay.Text = "X turn";
                gettingTheWinner();
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
                gettingTheWinner();
            }
            else
            {
                btnTwo.Text = "O";
                screenDisplay.Text = "X turn";
                gettingTheWinner();
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
                gettingTheWinner();
            }
            else
            {
                btnThree.Text = "O";
                screenDisplay.Text = "X turn";
                gettingTheWinner();
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
                gettingTheWinner();
            }
            else
            {
                btnFour.Text = "O";
                screenDisplay.Text = "X turn";
                gettingTheWinner();
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
                gettingTheWinner();
            }
            else
            {
                btnFive.Text = "O";
                screenDisplay.Text = "X turn";
                gettingTheWinner();
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
                gettingTheWinner();
            }
            else
            {
                btnSix.Text = "O";
                screenDisplay.Text = "X turn";
                gettingTheWinner();
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
                gettingTheWinner();
            }
            else
            {
                btnSeven.Text = "O";
                screenDisplay.Text = "X turn";
                gettingTheWinner();
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
                gettingTheWinner();
            }
            else
            {
                btnEight.Text = "O";
                screenDisplay.Text = "X turn";
                gettingTheWinner();
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
                gettingTheWinner();
            }
            else
            {
                btnNine.Text = "O";
                screenDisplay.Text = "X turn";
                gettingTheWinner();
            }

            btnNine.Enabled = false;
            turn_count++;
        }

        bool wins = false;
        public void gettingTheWinner()
        {
            // horizontal
            if(btnOne.Text != ("") && btnOne.Text.Equals(btnTwo.Text) && btnOne.Text.Equals(btnThree.Text))
            {
                winnerShow(btnOne, btnTwo, btnThree);
                wins = true;
            }

            if (btnFour.Text != ("") && btnFour.Text.Equals(btnFive.Text) && btnFour.Text.Equals(btnSix.Text))
            {
                winnerShow(btnFour, btnFive, btnSix);
                wins = true;
            }

            if (btnSeven.Text != ("") && btnSeven.Text.Equals(btnEight.Text) && btnSeven.Text.Equals(btnNine.Text))
            {
                winnerShow(btnSeven, btnEight, btnNine);
                wins = true;
            }

            // vertical
            if (btnOne.Text != ("") && btnOne.Text.Equals(btnSix.Text) && btnOne.Text.Equals(btnSeven.Text))
            {
                winnerShow(btnOne, btnSix, btnSeven);
                wins = true;
            }

            if (btnTwo.Text != ("") && btnTwo.Text.Equals(btnFive.Text) && btnTwo.Text.Equals(btnEight.Text))
            {
                winnerShow(btnTwo, btnFive, btnEight);
                wins = true;
            }

            if (btnThree.Text != ("") && btnThree.Text.Equals(btnFour.Text) && btnThree.Text.Equals(btnNine.Text))
            {
                winnerShow(btnThree, btnFour, btnNine);
                wins = true;
            }

            // diagonal
            if (btnOne.Text != ("") && btnOne.Text.Equals(btnFive.Text) && btnOne.Text.Equals(btnNine.Text))
            {
                winnerShow(btnOne, btnFive, btnNine);
                wins = true;
            }

            if (btnThree.Text != ("") && btnThree.Text.Equals(btnFive.Text) && btnThree.Text.Equals(btnSeven.Text))
            {
                winnerShow(btnThree, btnFive, btnSeven);
                wins = true;
            }

            // tie
            if (btnOne.Text != ("") && btnTwo.Text != ("") && btnThree.Text != ("") && btnFour.Text != ("") && btnFive.Text != ("")
                && btnSix.Text != ("") && btnSeven.Text != ("") && btnEight.Text != ("") && btnNine.Text != (""))
            {
                MessageBox.Show("It's a draw!");
                wins = false;
            }
        }

        public void winnerShow(Button btnOne, Button btnTwo, Button btnThree)
        {
            btnOne.BackColor = Color.LightGreen;
            btnTwo.BackColor = Color.LightGreen;
            btnThree.BackColor = Color.LightGreen;

            MessageBox.Show(btnOne.Text + " Wins!");

            btnOne.Enabled = false;
            btnTwo.Enabled = false;
            btnThree.Enabled = false;
            btnFour.Enabled = false;
            btnFive.Enabled = false;
            btnSix.Enabled = false;
            btnSeven.Enabled = false;
            btnEight.Enabled = false;
            btnNine.Enabled = false;
        }

    }
}
