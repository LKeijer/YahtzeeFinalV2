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
    public partial class p2_lowerBox : Form
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
        int onePairScore, twoPairScore, threeKindScore, fullHouseScore, lowStraightScore, highStraightScore, fourKindScore, yahtzeeScore, chanceScore, onesScore, twosScore, threesScore, foursScore, fivesScore, sixesScore;
        bool p1onePair, p1twoPair, p1threeKind, p1fourKind, p1yahtzee, p1lowStraight, p1highStraight, p1chance, p1fullHouse, p2onePair, p2twoPair, p2threeKind, p2fourKind, p2yahtzee, p2lowStraight, p2highStraight, p2chance, p2fullHouse;
        bool[] comboBool;
        int[] comboScore;






        #endregion

        #region Initialization
        public p2_lowerBox()
        {
            player1 = true;
            InitializeComponent();
            rngeesus = new Random();
            diceImages = new Image[8];
            dice = new int[5] { 0, 0, 0, 0, 0 };
            diceResults = new int[6] { 0, 0, 0, 0, 0, 0 };
            LoadImages();
            rollCounter = 0;
            comboBool = new bool[] { onePair, twoPair, threeKind, fullHouse, lowStraight, highStraight, fourKind, yahtzee, chance };
            comboScore = new int[] { onePairScore, twoPairScore, threeKindScore, fullHouseScore, lowStraightScore, highStraightScore, fourKindScore, yahtzeeScore, chanceScore };
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

        private void label21_Click(object sender, EventArgs e)
        {

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

                if (diceResults[i] == 2 || diceResults[i] == 3 || diceResults[i] == 4 || diceResults[i] == 5)
                {
                    onePair = true;

                    onePairScore = ((i + 1) * 2);


                    for (int j = i + 1; j < diceResults.Length; j++)
                    {
                        if (diceResults[j] == 2 || diceResults[j] == 3)
                        {
                            twoPair = true;
                            twoPairScore = onePairScore + ((j + 1) * 2);

                        }
                    }
                }
                if (diceResults[i] == 3 || diceResults[i] == 4 || diceResults[i] == 5)
                {
                    threeKind = true;
                    threeKindScore = ((i + 1) * 3);
                    for (int k = 0; k < diceResults.Length; k++)
                    {
                        if (diceResults[k] == 2)
                        {
                            fullHouse = true;
                            fullHouseScore = (((k + 1) * 2) + threeKindScore);
                        }
                    }
                }
                if (diceResults[i] == 4 || diceResults[i] == 5)
                {
                    fourKind = true;
                    fourKindScore = ((i + 1) * 4);
                }
                if (diceResults[i] == 5)
                {
                    yahtzee = true;
                    yahtzeeScore = ((i + 1) * 5); 
                }

                // Possible combinations for the low straight
                if ((diceResults[0] == 1 || diceResults[0] == 2) && (diceResults[1] == 1 || diceResults[1] == 1) && (diceResults[2] == 1 || diceResults[2] == 2) && (diceResults[3] == 1 || diceResults[3] == 2))
                {
                    lowStraight = true;
                    lowStraightScore = 10;
                }
                if ((diceResults[4] == 1 || diceResults[4] == 2) && (diceResults[1] == 1 || diceResults[1] == 2) && (diceResults[2] == 1 || diceResults[2] == 2) && (diceResults[3] == 1 || diceResults[3] == 2))
                {
                    lowStraight = true;
                    lowStraightScore = 14;
                }
                if ((diceResults[2] == 1 || diceResults[2] == 2) && (diceResults[3] == 1 || diceResults[3] == 2) && (diceResults[4] == 1 || diceResults[4] == 2) && (diceResults[5] == 1 || diceResults[5] == 2))
                {
                    lowStraight = true;
                    lowStraightScore = 18;
                }

                // Possible combinations for the high straight
                if ((diceResults[0] == 1 || diceResults[0] == 2) && (diceResults[1] == 1 || diceResults[1] == 2) && (diceResults[2] == 1 || diceResults[2] == 2) && (diceResults[3] == 1 || diceResults[3] == 2) && (diceResults[4] == 1 || diceResults[4] == 2))
                {
                    highStraight = true;
                    highStraightScore = 15;
                }
                if ((diceResults[1] == 1 || diceResults[1] == 2) && (diceResults[2] == 1 || diceResults[2] == 2) && (diceResults[3] == 1 || diceResults[3] == 2) && (diceResults[4] == 1 || diceResults[4] == 2) && (diceResults[5] == 1 || diceResults[5] == 2))
                {
                    highStraight = true;
                    highStraightScore = 16;
                }
            }
            chance = true;
            chanceScore = dice[0] + dice[1] + dice[2] + dice[3] + dice[4];

            if (diceResults[0] == 1 || diceResults[0] == 2 || diceResults[0] == 3 || diceResults[0] == 4 || diceResults[0] == 5)
            {
                ones = true;
                if (diceResults[0] == 1)
                {
                    onesScore = 1;
                }
                else if (diceResults[0] == 2)
                {
                    onesScore = 2;
                }
                else if (diceResults[0] == 3)
                {
                    onesScore = 3;
                }
                else if (diceResults[0] == 4)
                {
                    onesScore = 4;
                }
                else if (diceResults[0] == 5)
                {
                    onesScore = 5;
                }
            }
            if (diceResults[1] == 1 || diceResults[1] == 2 || diceResults[1] == 3 || diceResults[1] == 4 || diceResults[1] == 5)
            {
                twos = true;
                if (diceResults[1] == 1)
                {
                    twosScore = 2;
                }
                if (diceResults[1] == 2)
                {
                    twosScore = 4;
                }
                if (diceResults[1] == 3)
                {
                    twosScore = 6;
                }
                if (diceResults[1] == 4)
                {
                    twosScore = 8;
                }
                if (diceResults[1] == 5)
                {
                    twosScore = 10;
                }
            }

                if (diceResults[2] == 1 || diceResults[2] == 2 || diceResults[2] == 3 || diceResults[2] == 4 || diceResults[2] == 5)
                {
                    threes = true;
                    if (diceResults[2] == 1)
                    {
                        threesScore = 3;
                    }
                    if (diceResults[2] == 2)
                    {
                        threesScore = 6;
                    }
                    if (diceResults[2] == 3)
                    {
                        threesScore = 9;
                    }
                    if (diceResults[2] == 4)
                    {
                        threesScore = 12;
                    }
                    if (diceResults[2] == 5)
                    {
                        threesScore = 15;
                    }
                }
            if (diceResults[3] == 1 || diceResults[3] == 2 || diceResults[3] == 3 || diceResults[3] == 4 || diceResults[3] == 5)
            {
                twos = true;
                if (diceResults[3] == 1)
                {
                    twosScore = 4;
                }
                if (diceResults[3] == 2)
                {
                    twosScore = 8;
                }
                if (diceResults[3] == 3)
                {
                    twosScore = 12;
                }
                if (diceResults[3] == 4)
                {
                    twosScore = 16;
                }
                if (diceResults[3] == 5)
                {
                    twosScore = 20;
                }
            }
            if (diceResults[4] == 4 || diceResults[4] == 2 || diceResults[4] == 3 || diceResults[4] == 4 || diceResults[4] == 5)
            {
                twos = true;
                if (diceResults[4] == 1)
                {
                    twosScore = 5;
                }
                if (diceResults[4] == 2)
                {
                    twosScore = 10;
                }
                if (diceResults[4] == 3)
                {
                    twosScore = 15;
                }
                if (diceResults[4] == 4)
                {
                    twosScore = 20;
                }
                if (diceResults[4] == 5)
                {
                    twosScore = 25;
                }
            }
            if (diceResults[5] == 1 || diceResults[5] == 2 || diceResults[5] == 3 || diceResults[5] == 4 || diceResults[5] == 5)
            {
                twos = true;
                if (diceResults[5] == 1)
                {
                    twosScore = 6;
                }
                if (diceResults[5] == 2)
                {
                    twosScore = 12;
                }
                if (diceResults[5] == 3)
                {
                    twosScore = 18;
                }
                if (diceResults[5] == 4)
                {
                    twosScore = 24;
                }
                if (diceResults[5] == 5)
                {
                    twosScore = 30;
                }
            }

        }

        #endregion

        #region UpdateLabel() updates the int labels to what was scored && sets corresponding buttons to visable
        private void UpdateLabel()
        {
            if (player1 == true)
            {

                if (ones == true)
                {
                    if(p1_onesScore.Text == "")
                    {
                        p1_onesScore.Text = onesScore.ToString();
                        p1_onesBtn.Show();
                    }
                }
                if (twos == true)
                {
                    if(p1_twoPairScore.Text == "")
                    {
                        p1_twosScore.Text = twosScore.ToString();
                        p1_twosBtn.Show(); 
                    }
                }
                if (threes == true)
                {
                    if (p1_threesScore.Text == "")
                    {
                        p1_threesScore.Text = threesScore.ToString();
                        p1_threesBtn.Show();
                    }
                }
                if (fours == true)
                {
                    if (p1_foursScore.Text == "")
                    {
                        p1_foursScore.Text = foursScore.ToString();
                        p1_foursBtn.Show();
                    }
                }
                if (fives == true)
                {
                    if (p1_fivesScore.Text == "")
                    {
                        p1_fivesScore.Text = fivesScore.ToString();
                        p1_fivesBtn.Show();
                    }
                }
                if (sixes == true)
                {
                    if (p1_sixesScore.Text == "")
                    {
                        p1_fivesScore.Text = fivesScore.ToString();
                        p1_fivesBtn.Show();
                    }
                }
                if (onePair == true)
                {
                    if (p1_onePairScore.Text == "")
                    {
                        p1_onePairScore.Text = onePairScore.ToString();
                        p1_onePairBtn.Show();
                    }
                }
                if (twoPair == true)
                {
                    if (p1_twoPairScore.Text == "")
                    {
                        p1_twoPairScore.Text = twoPairScore.ToString();
                        p1_twoPairBtn.Show();
                    }
                }
                if (threeKind == true)
                {
                    if (p1_threeKindScore.Text == "")
                    {
                        p1_threeKindScore.Text = threeKindScore.ToString();
                        p1_threeKindBtn.Show();
                    }
                }
                if (fourKind == true)
                {
                    if (p1_fourKindScore.Text == "")
                    {
                        p1_fourKindScore.Text = fourKindScore.ToString();
                        p1_fourKindBtn.Show();
                    }
                }
                if (yahtzee == true)
                {
                    if (p1_yahtzeeScore.Text == "")
                    {
                        p1_yahtzeeScore.Text = yahtzeeScore.ToString();
                        p1_yahtzeeBtn.Show();
                    }
                }
                if (lowStraight == true)
                {
                    if (p1_lowStraightScore.Text == "")
                    {
                        p1_lowStraightScore.Text = lowStraightScore.ToString();
                        p1_lowStraightBtn.Show();
                    }
                }
                if (highStraight == true)
                {
                    if (p1_highStraightScore.Text == "")
                    {
                        p1_highStraightScore.Text = highStraightScore.ToString();
                        p1_highStraightBtn.Show();
                    }
                }
                if (fullHouse == true)
                {
                    if (p1_fullHouseScore.Text == "")
                    {
                        p1_fullHouseScore.Text = fullHouseScore.ToString();
                        p1_fullHouseBtn.Show();
                    }
                }
                if (chance == true)
                {
                    if (p1_chanceScore.Text == "")
                    {
                        p1_chanceScore.Text = chanceScore.ToString();
                        p1_chanceBtn.Show();
                    }
                }
            }

            if (player2 == true)
            {
                if (ones == true)
                {
                    if (p1_onesScore.Text == "")
                    {
                        p1_onesScore.Text = onesScore.ToString();
                        p1_onesBtn.Show();
                    }
                }
                if (twos == true)
                {
                    if (p1_twoPairScore.Text == "")
                    {
                        p1_twosScore.Text = twosScore.ToString();
                        p1_twosBtn.Show();
                    }
                }
                if (threes == true)
                {
                    if (p1_threesScore.Text == "")
                    {
                        p1_threesScore.Text = threesScore.ToString();
                        p1_threesBtn.Show();
                    }
                }
                if (fours == true)
                {
                    if (p1_foursScore.Text == "")
                    {
                        p1_foursScore.Text = foursScore.ToString();
                        p1_foursBtn.Show();
                    }
                }
                if (fives == true)
                {
                    if (p1_fivesScore.Text == "")
                    {
                        p1_fivesScore.Text = fivesScore.ToString();
                        p1_fivesBtn.Show();
                    }
                }
                if (sixes == true)
                {
                    if (p1_sixesScore.Text == "")
                    {
                        p1_fivesScore.Text = fivesScore.ToString();
                        p1_fivesBtn.Show();
                    }
                }
                if (onePair == true)
                {
                    if (p2_onePairScore.Text == "")
                    {
                        p2_onePairScore.Text = onePairScore.ToString();
                        p2_onePairBtn.Show();
                    }
                }
                if (twoPair == true)
                {
                    if (p2_twoPairScore.Text == "")
                    {
                        p2_twoPairScore.Text = twoPairScore.ToString();
                        p2_twoPairBtn.Show();
                    }
                }
                if (threeKind == true)
                {
                    if (p2_threeKindScore.Text == "")
                    {
                        p2_threeKindScore.Text = threeKindScore.ToString();
                        p2_threeKindBtn.Show();
                    }
                }
                if (fourKind == true)
                {
                    if (p2_fourKindScore.Text == "")
                    {
                        p2_fourKindScore.Text = fourKindScore.ToString();
                        p2_fourKindBtn.Show();
                    }
                }
                if (yahtzee == true)
                {
                    if (p2_yahtzeeScore.Text == "")
                    {
                        p2_yahtzeeScore.Text = yahtzeeScore.ToString();
                        p2_yahtzeeBtn.Show();
                    }
                }
                if (lowStraight == true)
                {
                    if (p2_lowStraightScore.Text == "")
                    {
                        p2_lowStraightScore.Text = lowStraightScore.ToString();
                        p2_lowStraightBtn.Show();
                    }
                }
                if (highStraight == true)
                {
                    if (p2_highStraightScore.Text == "")
                    {
                        p2_highStraightScore.Text = highStraightScore.ToString();
                        p2_highStraightBtn.Show();
                    }
                }
                if (fullHouse == true)
                {
                    if (p2_fullHouseScore.Text == "")
                    {
                        p2_fullHouseScore.Text = fullHouseScore.ToString();
                        p2_fullHouseBtn.Show();
                    }
                }
                if (chance == true)
                {
                    if (p2_chanceScore.Text == "")
                    {
                        p2_chanceScore.Text = chanceScore.ToString();
                        p2_chanceBtn.Show();
                    }
                }
            }
        }
        #endregion

        #region UpdateScoring() Updates the label and sets the non-selected combinations to zero // not working + not implemented
        private void UpdateScoring()
        {
            if (twoPair == true && p1twoPair != true)
                p1_twoPairScore.Text = null;
            if (threeKind == true && p1threeKind != true)
                p1_threeKindScore.Text = null;
            if (fullHouse == true && p1fullHouse != true)
                p1_fullHouseScore.Text = null;
            if (lowStraight == true && p1lowStraight != true)
                p1_lowStraightScore.Text = null;
            if (highStraight == true && p1highStraight != true)
                p1_highStraightScore.Text = null;
            if (fourKind == true && p1fourKind != true)
                p1_fourKindScore.Text = null;
            if (yahtzee == true && p1yahtzee != true)
                p1_yahtzeeScore.Text = null;
            if (onePair == true && p1onePair != true)
                p1_onePairScore.Text = null;
        }
        #endregion

        #region Reset() Resets all the arrays, bool values and int values to null/0
        private void Reset()
        {
            for (int i = 0; i < diceResults.Length; i++)
                diceResults[i] = 0;
            for (int i = 0; i < dice.Length; i++)
                dice[i] = 0;

            //for (int i = 0; i < comboBool.Length; i++)
            //  comboBool[i] = false;
            //for (int i = 0; i < comboScore.Length; i++)
            //    comboScore[i] = 0;

            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            pictureBox10.Image = null;
            rollCounter = 0;
            onePair = false; twoPair = false; threeKind = false; fourKind = false; yahtzee = false; lowStraight = false; highStraight = false; chance = false; fullHouse = false;
            onePairScore = 0; twoPairScore = 0; threeKindScore = 0; fourKindScore = 0; yahtzeeScore = 0; fullHouseScore = 0; lowStraightScore = 0; highStraightScore = 0; chanceScore = 0;

            if (player1 == true)
            {
                player1 = false;
                player2 = true;
                currentPlayerLbl.Text = "Current player: 2";
            }
            else
            {
                player1 = true;
                player2 = false;
                currentPlayerLbl.Text = "Current player: 1";
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
                // CheckdiceResults();
                SetBoolValuesScoreCount();
                // CheckBoolValues();
                UpdateLabel();
                doneBtn.Hide();
            }
            else
            { 
                MessageBox.Show("Please select all the dice.");
            }
        }

        private void nextPlayerBtn_Click(object sender, EventArgs e)
        {
            nextPlayerBtn.Hide();
            doneBtn.Hide();
            rollDiceBtn.Show();
            Reset();

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


        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region p1_Btn contains all the combination click events for player 1

        private void p1_sixesBtn_Click(object sender, EventArgs e)
        {

        }

        private void p1_fivesBtn_Click(object sender, EventArgs e)
        {

        }

        private void p1_foursBtn_Click(object sender, EventArgs e)
        {

        }

        private void p1_threesBtn_Click(object sender, EventArgs e)
        {

        }

        private void p1_twosBtn_Click(object sender, EventArgs e)
        {

        }

        private void p1_onesBtn_Click(object sender, EventArgs e)
        {

        }

        private void p1_chanceBtn_Click(object sender, EventArgs e)
        {


            p1chance = true;
            nextPlayerBtn.Show();

            if (chance == true && p1chance != true) // check
                p1_chanceScore.Text = chanceScore.ToString();
            if (twoPair == true && p1twoPair != true)
                p1_twoPairScore.Text = null;
            if (threeKind == true && p1threeKind != true)
                p1_threeKindScore.Text = null;
            if (fullHouse == true && p1fullHouse != true)
                p1_fullHouseScore.Text = null;
            if (lowStraight == true && p1lowStraight != true)
                p1_lowStraightScore.Text = null;
            if (highStraight == true && p1highStraight != true)
                p1_highStraightScore.Text = null;
            if (fourKind == true && p1fourKind != true)
                p1_fourKindScore.Text = null;
            if (yahtzee == true && p1yahtzee != true)
                p1_yahtzeeScore.Text = null;
            if (onePair == true && p1onePair != true)
                p1_onePairScore.Text = null;
           // if (ones == true && p1)

            p1_chanceBtn.Hide();
            p1_onePairBtn.Hide();
            p1_twoPairBtn.Hide();
            p1_threeKindBtn.Hide();
            p1_fullHouseBtn.Hide();
            p1_lowStraightBtn.Hide();
            p1_highStraightBtn.Hide();
            p1_fourKindBtn.Hide();
            p1_yahtzeeBtn.Hide();
            doneBtn.Hide();
        }

        private void p1_onePairBtn_Click(object sender, EventArgs e)
        {
            p1onePair = true;
            nextPlayerBtn.Show();

            if (twoPair == true && p1twoPair != true)
                p1_twoPairScore.Text = null;
            if (threeKind == true && p1threeKind != true)
                p1_threeKindScore.Text = null;
            if (fullHouse == true && p1fullHouse != true)
                p1_fullHouseScore.Text = null;
            if (lowStraight == true && p1lowStraight != true)
                p1_lowStraightScore.Text = null;
            if (highStraight == true && p1highStraight != true)
                p1_highStraightScore.Text = null;
            if (fourKind == true && p1fourKind != true)
                p1_fourKindScore.Text = null;
            if (yahtzee == true && p1yahtzee != true)
                p1_yahtzeeScore.Text = null;
            if (chance == true && p1chance != true)
                p1_chanceScore.Text = null;

            p1_chanceBtn.Hide();
            p1_onePairBtn.Hide();
            p1_twoPairBtn.Hide();
            p1_threeKindBtn.Hide();
            p1_fullHouseBtn.Hide();
            p1_lowStraightBtn.Hide();
            p1_highStraightBtn.Hide();
            p1_fourKindBtn.Hide();
            p1_yahtzeeBtn.Hide();
            p1_chanceBtn.Hide();
            doneBtn.Hide();
        }

        private void p1_twoPairBtn_Click(object sender, EventArgs e)
        {
            p1twoPair = true;
            nextPlayerBtn.Show();

            if (chance == true && p1chance != true)
                p1_chanceScore.Text = null;
            if (threeKind == true && p1threeKind != true)
                p1_threeKindScore.Text = null;
            if (fullHouse == true && p1fullHouse != true)
                p1_fullHouseScore.Text = null;
            if (lowStraight == true && p1lowStraight != true)
                p1_lowStraightScore.Text = null;
            if (highStraight == true && p1highStraight != true)
                p1_highStraightScore.Text = null;
            if (fourKind == true && p1fourKind != true)
                p1_fourKindScore.Text = null;
            if (yahtzee == true && p1yahtzee != true)
                p1_yahtzeeScore.Text = null;
            if (onePair == true && p1onePair != true)
                p1_onePairScore.Text = null;

            p1_chanceBtn.Hide();

            p1_onePairBtn.Hide();
            p1_twoPairBtn.Hide();
            p1_threeKindBtn.Hide();
            p1_fullHouseBtn.Hide();
            p1_lowStraightBtn.Hide();
            p1_highStraightBtn.Hide();
            p1_fourKindBtn.Hide();
            p1_yahtzeeBtn.Hide();
            p1_chanceBtn.Hide();
            doneBtn.Hide();
        }

        private void p1_threeKindBtn_Click(object sender, EventArgs e)
        {
            p1threeKind = true;
            nextPlayerBtn.Show();

            if (twoPair == true && p1twoPair != true)
                p1_twoPairScore.Text = null;
            if (chance == true && p1chance != true)
                p1_chanceScore.Text = null;
            if (fullHouse == true && p1fullHouse != true)
                p1_fullHouseScore.Text = null;
            if (lowStraight == true && p1lowStraight != true)
                p1_lowStraightScore.Text = null;
            if (highStraight == true && p1highStraight != true)
                p1_highStraightScore.Text = null;
            if (fourKind == true && p1fourKind != true)
                p1_fourKindScore.Text = null;
            if (yahtzee == true && p1yahtzee != true)
                p1_yahtzeeScore.Text = null;
            if (onePair == true && p1onePair != true)
                p1_onePairScore.Text = null;

            p1_chanceBtn.Hide();

            p1_onePairBtn.Hide();
            p1_twoPairBtn.Hide();
            p1_threeKindBtn.Hide();
            p1_fullHouseBtn.Hide();
            p1_lowStraightBtn.Hide();
            p1_highStraightBtn.Hide();
            p1_fourKindBtn.Hide();
            p1_yahtzeeBtn.Hide();
            p1_chanceBtn.Hide();
            doneBtn.Hide();
        }

        private void p1_lowStraightBtn_Click(object sender, EventArgs e)
        {
            p1lowStraight = true;
            nextPlayerBtn.Show();

            if (twoPair == true && p1twoPair != true)
                p1_twoPairScore.Text = null;
            if (threeKind == true && p1threeKind != true)
                p1_threeKindScore.Text = null;
            if (fullHouse == true && p1fullHouse != true)
                p1_fullHouseScore.Text = null;
            if (chance == true && p1chance != true)
                p1_chanceScore.Text = null;
            if (highStraight == true && p1highStraight != true)
                p1_highStraightScore.Text = null;
            if (fourKind == true && p1fourKind != true)
                p1_fourKindScore.Text = null;
            if (yahtzee == true && p1yahtzee != true)
                p1_yahtzeeScore.Text = null;
            if (onePair == true && p1onePair != true)
                p1_onePairScore.Text = null;

            p1_chanceBtn.Hide();

            p1_onePairBtn.Hide();
            p1_twoPairBtn.Hide();
            p1_threeKindBtn.Hide();
            p1_fullHouseBtn.Hide();
            p1_lowStraightBtn.Hide();
            p1_highStraightBtn.Hide();
            p1_fourKindBtn.Hide();
            p1_yahtzeeBtn.Hide();
            p1_chanceBtn.Hide();
            doneBtn.Hide();
        }

        private void p1_highStraightBtn_Click(object sender, EventArgs e)
        {
            p1highStraight = true;
            nextPlayerBtn.Show();

            if (twoPair == true && p1twoPair != true)
                p1_twoPairScore.Text = null;
            if (threeKind == true && p1threeKind != true)
                p1_threeKindScore.Text = null;
            if (fullHouse == true && p1fullHouse != true)
                p1_fullHouseScore.Text = null;
            if (lowStraight == true && p1lowStraight != true)
                p1_lowStraightScore.Text = null;
            if (chance == true && p1chance != true)
                p1_chanceScore.Text = null;
            if (fourKind == true && p1fourKind != true)
                p1_fourKindScore.Text = null;
            if (yahtzee == true && p1yahtzee != true)
                p1_yahtzeeScore.Text = null;
            if (onePair == true && p1onePair != true)
                p1_onePairScore.Text = null;

            p1_chanceBtn.Hide();

            p1_onePairBtn.Hide();
            p1_twoPairBtn.Hide();
            p1_threeKindBtn.Hide();
            p1_fullHouseBtn.Hide();
            p1_lowStraightBtn.Hide();
            p1_highStraightBtn.Hide();
            p1_fourKindBtn.Hide();
            p1_yahtzeeBtn.Hide();
            p1_chanceBtn.Hide();
            doneBtn.Hide();
        }

        private void p1_fourKindBtn_Click(object sender, EventArgs e)
        {
            p1fourKind = true;
            nextPlayerBtn.Show();

            if (twoPair == true && p1twoPair != true)
                p1_twoPairScore.Text = null;
            if (threeKind == true && p1threeKind != true)
                p1_threeKindScore.Text = null;
            if (fullHouse == true && p1fullHouse != true)
                p1_fullHouseScore.Text = null;
            if (lowStraight == true && p1lowStraight != true)
                p1_lowStraightScore.Text = null;
            if (highStraight == true && p1highStraight != true)
                p1_highStraightScore.Text = null;
            if (chance == true && p1chance != true)
                p1_chanceScore.Text = null;
            if (yahtzee == true && p1yahtzee != true)
                p1_yahtzeeScore.Text = null;
            if (onePair == true && p1onePair != true)
                p1_onePairScore.Text = null;

            p1_chanceBtn.Hide();

            p1_onePairBtn.Hide();
            p1_twoPairBtn.Hide();
            p1_threeKindBtn.Hide();
            p1_fullHouseBtn.Hide();
            p1_lowStraightBtn.Hide();
            p1_highStraightBtn.Hide();
            p1_fourKindBtn.Hide();
            p1_yahtzeeBtn.Hide();
            p1_chanceBtn.Hide();
            doneBtn.Hide();
        }

        private void p1_yahtzeeBtn_Click(object sender, EventArgs e)
        {
            p1yahtzee = true;
            nextPlayerBtn.Show();

            if (twoPair == true && p1twoPair != true)
                p1_twoPairScore.Text = null;
            if (threeKind == true && p1threeKind != true)
                p1_threeKindScore.Text = null;
            if (fullHouse == true && p1fullHouse != true)
                p1_fullHouseScore.Text = null;
            if (lowStraight == true && p1lowStraight != true)
                p1_lowStraightScore.Text = null;
            if (highStraight == true && p1highStraight != true)
                p1_highStraightScore.Text = null;
            if (fourKind == true && p1fourKind != true)
                p1_fourKindScore.Text = null;
            if (chance == true && p1chance != true)
                p1_chanceScore.Text = null;
            if (onePair == true && p1onePair != true)
                p1_onePairScore.Text = null;

            p1_chanceBtn.Hide();

            p1_onePairBtn.Hide();
            p1_twoPairBtn.Hide();
            p1_threeKindBtn.Hide();
            p1_fullHouseBtn.Hide();
            p1_lowStraightBtn.Hide();
            p1_highStraightBtn.Hide();
            p1_fourKindBtn.Hide();
            p1_yahtzeeBtn.Hide();
            p1_chanceBtn.Hide();
            doneBtn.Hide();
        }

        private void p1_fullHouseBtn_Click(object sender, EventArgs e)
        {
            p1fullHouse = true;
            nextPlayerBtn.Show();

            if (twoPair == true && p1twoPair != true)
                p1_twoPairScore.Text = null;
            if (threeKind == true && p1threeKind != true)
                p1_threeKindScore.Text = null;
            if (chance == true && p1chance != true)
                p1_chanceScore.Text = null;
            if (lowStraight == true && p1lowStraight != true)
                p1_lowStraightScore.Text = null;
            if (highStraight == true && p1highStraight != true)
                p1_highStraightScore.Text = null;
            if (fourKind == true && p1fourKind != true)
                p1_fourKindScore.Text = null;
            if (yahtzee == true && p1yahtzee != true)
                p1_yahtzeeScore.Text = null;
            if (onePair == true && p1onePair != true)
                p1_onePairScore.Text = null;

            p1_chanceBtn.Hide();

            p1_onePairBtn.Hide();
            p1_twoPairBtn.Hide();
            p1_threeKindBtn.Hide();
            p1_fullHouseBtn.Hide();
            p1_lowStraightBtn.Hide();
            p1_highStraightBtn.Hide();
            p1_fourKindBtn.Hide();
            p1_yahtzeeBtn.Hide();
            doneBtn.Hide();

        }
        #endregion

        #region p2_Btn contains all the combination click events for player 2

        private void p2_sixesBtn_Click(object sender, EventArgs e)
        {

        }

        private void p2_fivesBtn_Click(object sender, EventArgs e)
        {

        }

        private void p2_foursBtn_Click(object sender, EventArgs e)
        {

        }

        private void p2_threesBtn_Click(object sender, EventArgs e)
        {

        }

        private void p2_twosBtn_Click(object sender, EventArgs e)
        {

        }

        private void p2_onesBtn_Click(object sender, EventArgs e)
        {

        }

        private void p2_chanceBtn_Click(object sender, EventArgs e)
        {
            p2chance = true;
            nextPlayerBtn.Show();

            if (twoPair == true && p2twoPair != true)
                p2_twoPairScore.Text = null;
            if (threeKind == true && p2threeKind != true)
                p2_threeKindScore.Text = null;
            if (fullHouse == true && p2fullHouse != true)
                p2_fullHouseScore.Text = null;
            if (lowStraight == true && p2lowStraight != true)
                p2_lowStraightScore.Text = null;
            if (highStraight == true && p2highStraight != true)
                p2_highStraightScore.Text = null;
            if (fourKind == true && p2fourKind != true)
                p2_fourKindScore.Text = null;
            if (yahtzee == true && p2yahtzee != true)
                p2_yahtzeeScore.Text = null;
            if (onePair == true && p2onePair != true)
                p2_onePairScore.Text = null;

            p2_chanceBtn.Hide();
            p2_onePairBtn.Hide();
            p2_twoPairBtn.Hide();
            p2_threeKindBtn.Hide();
            p2_fullHouseBtn.Hide();
            p2_lowStraightBtn.Hide();
            p2_highStraightBtn.Hide();
            p2_fourKindBtn.Hide();
            p2_yahtzeeBtn.Hide();
            doneBtn.Hide();
        }

        private void p2_onePairBtn_Click(object sender, EventArgs e)
        {
            p2onePair = true;
            nextPlayerBtn.Show();

            if (twoPair == true && p2twoPair != true)
                p2_twoPairScore.Text = null;
            if (threeKind == true && p2threeKind != true)
                p2_threeKindScore.Text = null;
            if (fullHouse == true && p2fullHouse != true)
                p2_fullHouseScore.Text = null;
            if (lowStraight == true && p2lowStraight != true)
                p2_lowStraightScore.Text = null;
            if (highStraight == true && p2highStraight != true)
                p2_highStraightScore.Text = null;
            if (fourKind == true && p2fourKind != true)
                p2_fourKindScore.Text = null;
            if (yahtzee == true && p2yahtzee != true)
                p2_yahtzeeScore.Text = null;
            if (chance == true && p2chance != true)
                p2_chanceScore.Text = null;

            p2_chanceBtn.Hide();
            p2_onePairBtn.Hide();
            p2_twoPairBtn.Hide();
            p2_threeKindBtn.Hide();
            p2_fullHouseBtn.Hide();
            p2_lowStraightBtn.Hide();
            p2_highStraightBtn.Hide();
            p2_fourKindBtn.Hide();
            p2_yahtzeeBtn.Hide();
            p2_chanceBtn.Hide();
            doneBtn.Hide();
        }

        private void p2_twoPairBtn_Click(object sender, EventArgs e)
        {
            p2twoPair = true;
            nextPlayerBtn.Show();

            if (chance == true && p2chance != true)
                p2_chanceScore.Text = null;
            if (threeKind == true && p2threeKind != true)
                p2_threeKindScore.Text = null;
            if (fullHouse == true && p2fullHouse != true)
                p2_fullHouseScore.Text = null;
            if (lowStraight == true && p2lowStraight != true)
                p2_lowStraightScore.Text = null;
            if (highStraight == true && p2highStraight != true)
                p2_highStraightScore.Text = null;
            if (fourKind == true && p2fourKind != true)
                p2_fourKindScore.Text = null;
            if (yahtzee == true && p2yahtzee != true)
                p2_yahtzeeScore.Text = null;
            if (onePair == true && p2onePair != true)
                p2_onePairScore.Text = null;

            p2_chanceBtn.Hide();

            p2_onePairBtn.Hide();
            p2_twoPairBtn.Hide();
            p2_threeKindBtn.Hide();
            p2_fullHouseBtn.Hide();
            p2_lowStraightBtn.Hide();
            p2_highStraightBtn.Hide();
            p2_fourKindBtn.Hide();
            p2_yahtzeeBtn.Hide();
            p2_chanceBtn.Hide();
            doneBtn.Hide();
        }

        private void p2_threeKindBtn_Click(object sender, EventArgs e)
        {
            p2threeKind = true;
            nextPlayerBtn.Show();

            if (twoPair == true && p2twoPair != true)
                p2_twoPairScore.Text = null;
            if (chance == true && p2chance != true)
                p2_chanceScore.Text = null;
            if (fullHouse == true && p2fullHouse != true)
                p2_fullHouseScore.Text = null;
            if (lowStraight == true && p2lowStraight != true)
                p2_lowStraightScore.Text = null;
            if (highStraight == true && p2highStraight != true)
                p2_highStraightScore.Text = null;
            if (fourKind == true && p2fourKind != true)
                p2_fourKindScore.Text = null;
            if (yahtzee == true && p2yahtzee != true)
                p2_yahtzeeScore.Text = null;
            if (onePair == true && p2onePair != true)
                p2_onePairScore.Text = null;

            p2_chanceBtn.Hide();

            p2_onePairBtn.Hide();
            p2_twoPairBtn.Hide();
            p2_threeKindBtn.Hide();
            p2_fullHouseBtn.Hide();
            p2_lowStraightBtn.Hide();
            p2_highStraightBtn.Hide();
            p2_fourKindBtn.Hide();
            p2_yahtzeeBtn.Hide();
            p2_chanceBtn.Hide();
            doneBtn.Hide();
        }

        private void p2_lowStraightBtn_Click(object sender, EventArgs e)
        {
            p2lowStraight = true;
            nextPlayerBtn.Show();

            if (twoPair == true && p2twoPair != true)
                p2_twoPairScore.Text = null;
            if (threeKind == true && p2threeKind != true)
                p2_threeKindScore.Text = null;
            if (fullHouse == true && p2fullHouse != true)
                p2_fullHouseScore.Text = null;
            if (chance == true && p2chance != true)
                p2_chanceScore.Text = null;
            if (highStraight == true && p2highStraight != true)
                p2_highStraightScore.Text = null;
            if (fourKind == true && p2fourKind != true)
                p2_fourKindScore.Text = null;
            if (yahtzee == true && p2yahtzee != true)
                p2_yahtzeeScore.Text = null;
            if (onePair == true && p2onePair != true)
                p2_onePairScore.Text = null;

            p2_chanceBtn.Hide();

            p2_onePairBtn.Hide();
            p2_twoPairBtn.Hide();
            p2_threeKindBtn.Hide();
            p2_fullHouseBtn.Hide();
            p2_lowStraightBtn.Hide();
            p2_highStraightBtn.Hide();
            p2_fourKindBtn.Hide();
            p2_yahtzeeBtn.Hide();
            p2_chanceBtn.Hide();
            doneBtn.Hide();
        }

        private void p2_highStraightBtn_Click(object sender, EventArgs e)
        {
            p2highStraight = true;
            nextPlayerBtn.Show();

            if (twoPair == true && p2twoPair != true)
                p2_twoPairScore.Text = null;
            if (threeKind == true && p2threeKind != true)
                p2_threeKindScore.Text = null;
            if (fullHouse == true && p2fullHouse != true)
                p2_fullHouseScore.Text = null;
            if (lowStraight == true && p2lowStraight != true)
                p2_lowStraightScore.Text = null;
            if (chance == true && p2chance != true)
                p2_chanceScore.Text = null;
            if (fourKind == true && p2fourKind != true)
                p2_fourKindScore.Text = null;
            if (yahtzee == true && p2yahtzee != true)
                p2_yahtzeeScore.Text = null;
            if (onePair == true && p2onePair != true)
                p2_onePairScore.Text = null;

            p2_chanceBtn.Hide();

            p2_onePairBtn.Hide();
            p2_twoPairBtn.Hide();
            p2_threeKindBtn.Hide();
            p2_fullHouseBtn.Hide();
            p2_lowStraightBtn.Hide();
            p2_highStraightBtn.Hide();
            p2_fourKindBtn.Hide();
            p2_yahtzeeBtn.Hide();
            p2_chanceBtn.Hide();
            doneBtn.Hide();
        }

        private void p2_fourKindBtn_Click(object sender, EventArgs e)
        {
            p2fourKind = true;
            nextPlayerBtn.Show();

            if (twoPair == true && p2twoPair != true)
                p2_twoPairScore.Text = null;
            if (threeKind == true && p2threeKind != true)
                p2_threeKindScore.Text = null;
            if (fullHouse == true && p2fullHouse != true)
                p2_fullHouseScore.Text = null;
            if (lowStraight == true && p2lowStraight != true)
                p2_lowStraightScore.Text = null;
            if (highStraight == true && p2highStraight != true)
                p2_highStraightScore.Text = null;
            if (chance == true && p2chance != true)
                p2_chanceScore.Text = null;
            if (yahtzee == true && p2yahtzee != true)
                p2_yahtzeeScore.Text = null;
            if (onePair == true && p2onePair != true)
                p2_onePairScore.Text = null;

            p2_chanceBtn.Hide();

            p2_onePairBtn.Hide();
            p2_twoPairBtn.Hide();
            p2_threeKindBtn.Hide();
            p2_fullHouseBtn.Hide();
            p2_lowStraightBtn.Hide();
            p2_highStraightBtn.Hide();
            p2_fourKindBtn.Hide();
            p2_yahtzeeBtn.Hide();
            p2_chanceBtn.Hide();
            doneBtn.Hide();
        }

        private void p2_yahtzeeBtn_Click(object sender, EventArgs e)
        {
            p2yahtzee = true;
            nextPlayerBtn.Show();

            if (twoPair == true && p2twoPair != true)
                p2_twoPairScore.Text = null;
            if (threeKind == true && p2threeKind != true)
                p2_threeKindScore.Text = null;
            if (fullHouse == true && p2fullHouse != true)
                p2_fullHouseScore.Text = null;
            if (lowStraight == true && p2lowStraight != true)
                p2_lowStraightScore.Text = null;
            if (highStraight == true && p2highStraight != true)
                p2_highStraightScore.Text = null;
            if (fourKind == true && p2fourKind != true)
                p2_fourKindScore.Text = null;
            if (chance == true && p2chance != true)
                p2_chanceScore.Text = null;
            if (onePair == true && p2onePair != true)
                p2_onePairScore.Text = null;

            p2_chanceBtn.Hide();

            p2_onePairBtn.Hide();
            p2_twoPairBtn.Hide();
            p2_threeKindBtn.Hide();
            p2_fullHouseBtn.Hide();
            p2_lowStraightBtn.Hide();
            p2_highStraightBtn.Hide();
            p2_fourKindBtn.Hide();
            p2_yahtzeeBtn.Hide();
            p2_chanceBtn.Hide();
            doneBtn.Hide();
        }

        private void p2_fullHouseBtn_Click(object sender, EventArgs e)
        {
            p2fullHouse = true;
            nextPlayerBtn.Show();

            if (twoPair == true && p2twoPair != true)
                p2_twoPairScore.Text = null;
            if (threeKind == true && p2threeKind != true)
                p2_threeKindScore.Text = null;
            if (chance == true && p2chance != true)
                p2_chanceScore.Text = null;
            if (lowStraight == true && p2lowStraight != true)
                p2_lowStraightScore.Text = null;
            if (highStraight == true && p2highStraight != true)
                p2_highStraightScore.Text = null;
            if (fourKind == true && p2fourKind != true)
                p2_fourKindScore.Text = null;
            if (yahtzee == true && p2yahtzee != true)
                p2_yahtzeeScore.Text = null;
            if (onePair == true && p2onePair != true)
                p2_onePairScore.Text = null;

            p2_chanceBtn.Hide();

            p2_onePairBtn.Hide();
            p2_twoPairBtn.Hide();
            p2_threeKindBtn.Hide();
            p2_fullHouseBtn.Hide();
            p2_lowStraightBtn.Hide();
            p2_highStraightBtn.Hide();
            p2_fourKindBtn.Hide();
            p2_yahtzeeBtn.Hide();
            doneBtn.Hide();
            #endregion
        }

    }
}
