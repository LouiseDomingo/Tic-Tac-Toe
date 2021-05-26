
namespace Tic_Tac_Toe
{
    partial class TicTacToe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.screenDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOne
            // 
            this.btnOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOne.Location = new System.Drawing.Point(19, 258);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(70, 75);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            // 
            // btnTwo
            // 
            this.btnTwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTwo.Location = new System.Drawing.Point(88, 258);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(70, 75);
            this.btnTwo.TabIndex = 1;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            // 
            // btnThree
            // 
            this.btnThree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThree.Location = new System.Drawing.Point(157, 258);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(70, 75);
            this.btnThree.TabIndex = 2;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            // 
            // btnFour
            // 
            this.btnFour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFour.Location = new System.Drawing.Point(157, 185);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(70, 75);
            this.btnFour.TabIndex = 3;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            // 
            // btnFive
            // 
            this.btnFive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFive.Location = new System.Drawing.Point(88, 185);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(70, 75);
            this.btnFive.TabIndex = 4;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            // 
            // btnSix
            // 
            this.btnSix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSix.Location = new System.Drawing.Point(19, 185);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(70, 75);
            this.btnSix.TabIndex = 5;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            // 
            // btnSeven
            // 
            this.btnSeven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeven.Location = new System.Drawing.Point(19, 112);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(70, 75);
            this.btnSeven.TabIndex = 6;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            // 
            // btnEight
            // 
            this.btnEight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEight.Location = new System.Drawing.Point(88, 112);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(70, 75);
            this.btnEight.TabIndex = 7;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            // 
            // btnNine
            // 
            this.btnNine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNine.Location = new System.Drawing.Point(157, 112);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(70, 75);
            this.btnNine.TabIndex = 8;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            // 
            // screenDisplay
            // 
            this.screenDisplay.AutoSize = true;
            this.screenDisplay.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.screenDisplay.Location = new System.Drawing.Point(50, 42);
            this.screenDisplay.Name = "screenDisplay";
            this.screenDisplay.Size = new System.Drawing.Size(153, 24);
            this.screenDisplay.TabIndex = 9;
            this.screenDisplay.Text = "Let\'s Play!";
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 381);
            this.Controls.Add(this.screenDisplay);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Name = "TicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Label screenDisplay;
    }
}

