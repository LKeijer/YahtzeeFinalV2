using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeFinalV2
{
    public partial class Form1 : Form
    {
        #region Declarations
        Random rngeesus;
        Image[] diceImages;
        int[] diceResults;
        int[] dice;
        bool player1;
        bool player2;
        int rollCounter;
        bool onePair, twoPair, threeKind, fullHouse, lowStraight, highStraight, fourKind, yahtzee, ones, twos, threes, fours, fives, sixes, chance;
        int onePairScore, twoPairScore, threeKindScore, fullHouseScore, lowStraightScore, highStraightScore, fourKindScore, yahtzeeScore, chanceScore;

        #endregion

        #region Initialization
        public Form1()
        {
            InitializeComponent();
            rngeesus = new Random();
            diceImages = new Image[8];
            dice = new int[5] { 0, 0, 0, 0, 0 };
            diceResults = new int[6] { 0, 0, 0, 0, 0, 0 };
            LoadImages();
            player1 = true;
            player2 = false;
            rollCounter = 0;

        }
        #endregion

        #region Test Methods used to checking values
        private void CheckdiceResults()
        {
            foreach (int i in diceResults)
            {
                MessageBox.Show(i.ToString());
            }
        }

        private void CheckBoolValues()
        {
            if (onePair == true)
                MessageBox.Show("pair yes");
            if (twoPair == true)
                MessageBox.Show("2 pair yes");
            if (threeKind == true)
                MessageBox.Show("3 of a kind yes");
            if (fourKind == true)
                MessageBox.Show("4 of a kind yes");
            if (yahtzee == true)
                MessageBox.Show("yahtzee yes");
            if (lowStraight == true)
                MessageBox.Show("lowstraight yes");
            if (highStraight == true)
                MessageBox.Show("high straight yes");
            if (fullHouse == true)
                MessageBox.Show("full house yes");
        }


        #endregion

        #region LoadImages() Loads dice images into diceImages array.
        private void LoadImages()
        {
            diceImages[0] = Properties.Resources._0;
            diceImages[1] = Properties.Resources._1;
            diceImages[2] = Properties.Resources._2;
            diceImages[3] = Properties.Resources._3;
            diceImages[4] = Properties.Resources._4;
            diceImages[5] = Properties.Resources._5;
            diceImages[6] = Properties.Resources._6;
            diceImages[7] = Properties.Resources._7;
        }
        #endregion

        #region RollTheDice() rolls the dice and sets the corresponding images in pictureboxes 1-5
        private void RollTheDice()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = rngeesus.Next(1, 7);
            }

            if (pictureBox6.Image == null)
                pictureBox1.Image = diceImages[dice[0]];
            if (pictureBox7.Image == null)
                pictureBox2.Image = diceImages[dice[1]];
            if (pictureBox8.Image == null)
                pictureBox3.Image = diceImages[dice[2]];
            if (pictureBox9.Image == null)
                pictureBox4.Image = diceImages[dice[3]];
            if (pictureBox10.Image == null)
                pictureBox5.Image = diceImages[dice[4]];
        }
        #endregion

        #region InsertRollsIntoResults() adds the 'saved' dice into the diceResults array.
        private void InsertRollsIntoResults()
        {
            if (pictureBox6.Image == diceImages[1])
            {
                diceResults[0]++;
            }
            else if (pictureBox6.Image == diceImages[2])
            {
                diceResults[1]++;
            }
            else if (pictureBox6.Image == diceImages[3])
            {
                diceResults[2]++;
            }
            else if (pictureBox6.Image == diceImages[4])
            {
                diceResults[3]++;
            }
            else if (pictureBox6.Image == diceImages[5])
            {
                diceResults[4]++;
            }
            else if (pictureBox6.Image == diceImages[6])
            {
                diceResults[5]++;
            }

            if (pictureBox7.Image == diceImages[1])
            {
                diceResults[0]++;
            }
            else if (pictureBox7.Image == diceImages[2])
            {
                diceResults[1]++;
            }
            else if (pictureBox7.Image == diceImages[3])
            {
                diceResults[2]++;
            }
            else if (pictureBox7.Image == diceImages[4])
            {
                diceResults[3]++;
            }
            else if (pictureBox7.Image == diceImages[5])
            {
                diceResults[4]++;
            }
            else if (pictureBox7.Image == diceImages[6])
            {
                diceResults[5]++;
            }

            if (pictureBox8.Image == diceImages[1])
            {
                diceResults[0]++;
            }
            else if (pictureBox8.Image == diceImages[2])
            {
                diceResults[1]++;
            }
            else if (pictureBox8.Image == diceImages[3])
            {
                diceResults[2]++;
            }
            else if (pictureBox8.Image == diceImages[4])
            {
                diceResults[3]++;
            }
            else if (pictureBox8.Image == diceImages[5])
            {
                diceResults[4]++;
            }
            else if (pictureBox8.Image == diceImages[6])
            {
                diceResults[5]++;
            }

            if (pictureBox9.Image == diceImages[1])
            {
                diceResults[0]++;
            }
            else if (pictureBox9.Image == diceImages[2])
            {
                diceResults[1]++;
            }
            else if (pictureBox9.Image == diceImages[3])
            {
                diceResults[2]++;
            }
            else if (pictureBox9.Image == diceImages[4])
            {
                diceResults[3]++;
            }
            else if (pictureBox9.Image == diceImages[5])
            {
                diceResults[4]++;
            }
            else if (pictureBox9.Image == diceImages[6])
            {
                diceResults[5]++;
            }

            if (pictureBox10.Image == diceImages[1])
            {
                diceResults[0]++;
            }
            else if (pictureBox10.Image == diceImages[2])
            {
                diceResults[1]++;
            }
            else if (pictureBox10.Image == diceImages[3])
            {
                diceResults[2]++;
            }
            else if (pictureBox10.Image == diceImages[4])
            {
                diceResults[3]++;
            }
            else if (pictureBox10.Image == diceImages[5])
            {
                diceResults[4]++;
            }
            else if (pictureBox10.Image == diceImages[6])
            {
                diceResults[5]++;
            }
        }
        #endregion

        #region SetBoolValuesScoreCount() sets possible combination to true and counts the points scored
        private void SetBoolValuesScoreCount()
        {
            

            for (int i = 0; i < diceResults.Length; i++)
            {
                if (diceResults[i] == 2 || diceResults[i] == 3)
                {
                    onePair = true;
                    for (int j = i+1; j < diceResults.Length; j++)
                    {
                        if(diceResults[j] == 2)
                        {
                            twoPair = true;
                        }
                    }
                }
                if (diceResults[i] == 3)
                {
                    threeKind = true;
                    for (int k = 0; k < diceResults.Length; k++)
                    {
                        if (diceResults[k] == 2)
                        {
                            fullHouse = true;
                        }
                    }
                }
                if (diceResults[i] == 4)
                {
                    fourKind = true;
                }
                if (diceResults[i] == 5)
                {
                    yahtzee = true;
                }
            }
            
            // Possible combinations for the low straight
            if (diceResults[0] == 1 && diceResults[1] == 1 && diceResults[2] == 1 && diceResults[3] == 1)
            {
                lowStraight = true;
            }
            if (diceResults[4] == 1 && diceResults[1] == 1 && diceResults[2] == 1 && diceResults[3] == 1)
            {
                lowStraight = true;
            }
            if (diceResults[2] == 1 && diceResults[3] == 1 && diceResults[4] == 1 && diceResults[5] == 1)
            {
                lowStraight = true;
            }

            // Possible combinations for the high straight
            if (diceResults[0] == 1 && diceResults[1] == 1 && diceResults[2] == 1 && diceResults[3] == 1 && diceResults[4] == 1)
            {
                highStraight = true;
            }
            if (diceResults[5] == 1 && diceResults[1] == 1 && diceResults[2] == 1 && diceResults[3] == 1 && diceResults[4] == 1)
            {
                highStraight = true;
            }
        }

        #endregion


         
        private void rollDiceBtn_Click(object sender, EventArgs e) 
        {
            if (rollCounter <= 2)
            {
                RollTheDice();
                rollCounter++;
            }
            else
            {
                MessageBox.Show("Maximum of 3 rolls allowed.");
                rollDiceBtn.Hide();
                doneBtn.Show();
            }

        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null && pictureBox2.Image == null && pictureBox3.Image == null && pictureBox4.Image == null && pictureBox5.Image == null)
            {
                InsertRollsIntoResults();
                CheckdiceResults();
                SetBoolValuesScoreCount();
                CheckBoolValues();

            }
            else
            {
                MessageBox.Show("Please select all the dice.");
            }
        }

        #region All the pictureBox click events still have to come up with a way to turn this into a function
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < diceImages.Length; i++)
            {
                if (pictureBox1.Image == diceImages[i])
                {
                    pictureBox6.Image = diceImages[i];
                    pictureBox1.Image = null;
                }
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < diceImages.Length; i++)
            {
                if (pictureBox2.Image == diceImages[i])
                {
                    pictureBox7.Image = diceImages[i];
                    pictureBox2.Image = null;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < diceImages.Length; i++)
            {
                if (pictureBox3.Image == diceImages[i])
                {
                    pictureBox8.Image = diceImages[i];
                    pictureBox3.Image = null;
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < diceImages.Length; i++)
            {
                if (pictureBox4.Image == diceImages[i])
                {
                    pictureBox9.Image = diceImages[i];
                    pictureBox4.Image = null;
                }
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < diceImages.Length; i++)
            {
                if (pictureBox5.Image == diceImages[i])
                {
                    pictureBox10.Image = diceImages[i];
                    pictureBox5.Image = null;
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < diceImages.Length; i++)
            {
                if (pictureBox6.Image == diceImages[i])
                {
                    pictureBox1.Image = diceImages[i];
                    pictureBox6.Image = null;
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < diceImages.Length; i++)
            {
                if (pictureBox7.Image == diceImages[i])
                {
                    pictureBox2.Image = diceImages[i];
                    pictureBox7.Image = null;
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < diceImages.Length; i++)
            {
                if (pictureBox8.Image == diceImages[i])
                {
                    pictureBox3.Image = diceImages[i];
                    pictureBox8.Image = null;
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < diceImages.Length; i++)
            {
                if (pictureBox9.Image == diceImages[i])
                {
                    pictureBox4.Image = diceImages[i];
                    pictureBox9.Image = null;
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < diceImages.Length; i++)
            {
                if (pictureBox10.Image == diceImages[i])
                {
                    pictureBox5.Image = diceImages[i];
                    pictureBox10.Image = null;
                }
            }
        }
        #endregion
    }
}
