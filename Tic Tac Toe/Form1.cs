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
    }
}
