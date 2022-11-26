﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public string setImage(string str)
        {
            string fileLocation = "";
            switch (str)
            {
                //spades
                case "1 Spades":
                    fileLocation = "images/ace_of_spades.png";
                    break;
                case "2 Spades":
                    fileLocation = "images/2_of_spades.png";
                    break;
                case "3 Spades":
                    fileLocation = "images/3_of_spades.png";
                    break;
                case "4 Spades":
                    fileLocation = "images/4_of_spades.png";
                    break;
                case "5 Spades":
                    fileLocation = "images/5_of_spades.png";
                    break;
                case "6 Spades":
                    fileLocation = "images/6_of_spades.png";
                    break;
                case "7 Spades":
                    fileLocation = "images/7_of_spades.png";
                    break;
                case "8 Spades":
                    fileLocation = "images/8_of_spades.png";
                    break;
                case "9 Spades":
                    fileLocation = "images/9_of_spades.png";
                    break;
                case "10 Spades":
                    fileLocation = "images/10_of_spades.png";
                    break;
                case "11 Spades":
                    fileLocation = "images/jack_of_spades.png";
                    break;
                case "12 Spades":
                    fileLocation = "images/queen_of_spades.png";
                    break;
                case "13 Spades":
                    fileLocation = "images/king_of_spades.png";
                    break;
                //clubs
                case "1 Clubs":
                    fileLocation = "images/ace_of_clubs.png";
                    break;
                case "2 Clubs":
                    fileLocation = "images/2_of_clubs.png";
                    break;
                case "3 Clubs":
                    fileLocation = "images/3_of_clubs.png";
                    break;
                case "4 Clubs":
                    fileLocation = "images/4_of_clubs.png";
                    break;
                case "5 Clubs":
                    fileLocation = "images/5_of_clubs.png";
                    break;
                case "6 Clubs":
                    fileLocation = "images/6_of_clubs.png";
                    break;
                case "7 Clubs":
                    fileLocation = "images/7_of_clubs.png";
                    break;
                case "8 Clubs":
                    fileLocation = "images/8_of_clubs.png";
                    break;
                case "9 Clubs":
                    fileLocation = "images/9_of_clubs.png";
                    break;
                case "10 Clubs":
                    fileLocation = "images/10_of_clubs.png";
                    break;
                case "11 Clubs":
                    fileLocation = "images/jack_of_clubs.png";
                    break;
                case "12 Clubs":
                    fileLocation = "images/queen_of_clubs.png";
                    break;
                case "13 Clubs":
                    fileLocation = "images/king_of_clubs.png";
                    break;
                //hearts
                case "1 Hearts":
                    fileLocation = "images/ace_of_hearts.png";
                    break;
                case "2 Hearts":
                    fileLocation = "images/2_of_hearts.png";
                    break;
                case "3 Hearts":
                    fileLocation = "images/3_of_hearts.png";
                    break;
                case "4 Hearts":
                    fileLocation = "images/4_of_hearts.png";
                    break;
                case "5 Hearts":
                    fileLocation = "images/5_of_hearts.png";
                    break;
                case "6 Hearts":
                    fileLocation = "images/6_of_hearts.png";
                    break;
                case "7 Hearts":
                    fileLocation = "images/7_of_hearts.png";
                    break;
                case "8 Hearts":
                    fileLocation = "images/8_of_hearts.png";
                    break;
                case "9 Hearts":
                    fileLocation = "images/9_of_hearts.png";
                    break;
                case "10 Hearts":
                    fileLocation = "images/10_of_hearts.png";
                    break;
                case "11 Hearts":
                    fileLocation = "images/jack_of_hearts.png";
                    break;
                case "12 Hearts":
                    fileLocation = "images/queen_of_hearts.png";
                    break;
                case "13 Hearts":
                    fileLocation = "images/king_of_hearts.png";
                    break;
                //diamonds
                case "1 Diamonds":
                    fileLocation = "images/ace_of_diamonds.png";
                    break;
                case "2 Diamonds":
                    fileLocation = "images/2_of_diamonds.png";
                    break;
                case "3 Diamonds":
                    fileLocation = "images/3_of_diamonds.png";
                    break;
                case "4 Diamonds":
                    fileLocation = "images/4_of_diamonds.png";
                    break;
                case "5 Diamonds":
                    fileLocation = "images/5_of_diamonds.png";
                    break;
                case "6 Diamonds":
                    fileLocation = "images/6_of_diamonds.png";
                    break;
                case "7 Diamonds":
                    fileLocation = "images/7_of_diamonds.png";
                    break;
                case "8 Diamonds":
                    fileLocation = "images/8_of_diamonds.png";
                    break;
                case "9 Diamonds":
                    fileLocation = "images/9_of_diamonds.png";
                    break;
                case "10 Diamonds":
                    fileLocation = "images/10_of_diamonds.png";
                    break;
                case "11 Diamonds":
                    fileLocation = "images/jack_of_diamonds.png";
                    break;
                case "12 Diamonds":
                    fileLocation = "images/queen_of_diamonds.png";
                    break;
                case "13 Diamonds":
                    fileLocation = "images/king_of_diamonds.png";
                    break;
            }

            return fileLocation;


        }

        public string generateCard()
        {
            string newCard = "";
            Random rnd = new Random();

            List<int> CardNumber = new List<int>();
            for (int i = 1; i < 14; i++)
            {
                CardNumber.Add(i);
            }

            int r = rnd.Next(CardNumber.Count);
            newCard += CardNumber[r].ToString();



            List<string> CardSuite = new List<string>();
            CardSuite.Add("Spades");
            CardSuite.Add("Hearts");
            CardSuite.Add("Clubs");
            CardSuite.Add("Diamonds");

            int s = rnd.Next(CardSuite.Count);
            newCard += " "+ CardSuite[s];

            return newCard;


        }

        List<string> playerCards = new List<string>();
        List<string> pcCards = new List<string>();

        public void checkWinner()
        {
            int playerCardValue = 0;
            int pcCardValue = 0;
            int playerFinalBalance = 0;
            int pcFinalBalance = 0;
            foreach(string card in playerCards)
            {
                if(card.Substring(1,1) == " ")
                {
                    playerCardValue = Convert.ToInt32(card.Substring(0, 1));
                    if(playerCardValue == 11)
                    {
                        playerFinalBalance += 10;
                    }
                    else if(playerCardValue == 12)
                    {
                        playerFinalBalance += 10;
                    }
                    else if(playerCardValue == 13)
                    {
                        playerFinalBalance += 10;
                    }
                    else
                    {
                        playerFinalBalance += playerCardValue;
                    }
                    
                }
                else if(card.Substring(1,1) != " ")
                {
                    playerCardValue = Convert.ToInt32(card.Substring(0, 2));
                    if (playerCardValue == 11)
                    {
                        playerFinalBalance += 10;
                    }
                    else if (playerCardValue == 12)
                    {
                        playerFinalBalance += 10;
                    }
                    else if (playerCardValue == 13)
                    {
                        playerFinalBalance += 10;
                    }
                    else
                    {
                        playerFinalBalance += playerCardValue;
                    }
                }
                
            }

            foreach(string card in pcCards)
            {
                if(card.Substring(1,1) == " ")
                {
                    pcCardValue = Convert.ToInt32(card.Substring(0, 1));
                    if (pcCardValue == 11)
                    {
                        pcFinalBalance += 10;
                    }
                    else if (pcCardValue == 12)
                    {
                        pcFinalBalance += 10;
                    }
                    else if (pcCardValue == 13)
                    {
                        pcFinalBalance += 10;
                    }
                    else
                    {
                        pcFinalBalance += pcCardValue;
                    }
                }
                else if(card.Substring(1,1) != " ")
                {
                    pcCardValue = Convert.ToInt32(card.Substring(0, 2));
                    if (pcCardValue == 11)
                    {
                        pcFinalBalance += 10;
                    }
                    else if (pcCardValue == 12)
                    {
                        pcFinalBalance += 10;
                    }
                    else if (pcCardValue == 13)
                    {
                        pcFinalBalance += 10;
                    }
                    else
                    {
                        pcFinalBalance += pcCardValue;
                    }
                }
                
            }

            if(pcFinalBalance > 21)
            {
                label2.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
                button4.Visible = true;

            }
            else if(playerFinalBalance > pcFinalBalance && pcFinalBalance < 22)
            {
                label5.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
                button4.Visible = true;
            }
            else if(playerFinalBalance == pcFinalBalance)
            {
                label7.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
                button4.Visible = true;
            }
            else if(playerFinalBalance < pcFinalBalance && pcFinalBalance < 22)
            {
                label6.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
                button4.Visible = true;
            }


        }

        public async void startRound()
        {
            string playerCard1 = "";
            playerCard1 = generateCard();
            playerCards.Add(playerCard1);
            pictureBox8.Visible = true;
            string player1cardImage = setImage(playerCard1);
            pictureBox8.Image = Image.FromFile(player1cardImage);
            playerPicBoxes.Add(pictureBox8);
            await Task.Delay(1000);

            string pcCard1 = "";
            pcCard1 = generateCard();
            pcCards.Add(pcCard1);
            pictureBox10.Visible = true;
            string pcCard1Image = setImage(pcCard1);
            pictureBox10.Image = Image.FromFile(pcCard1Image);
            pcPicBoxes.Add(pictureBox10);
            await Task.Delay(1000);


            string playerCard2 = "";
            playerCard2 = generateCard();
            playerCards.Add(playerCard2);
            pictureBox7.Visible = true;
            string playercard2Image = setImage(playerCard2);
            pictureBox7.Image = Image.FromFile(playercard2Image);
            playerPicBoxes.Add(pictureBox7);
            await Task.Delay(1000);

            
            pictureBox11.Visible = true;
            pictureBox11.Image = Image.FromFile("images/faceDown.jpg");
            pcPicBoxes.Add(pictureBox11);

            getPlayerBalance();
            getPcBalance();
            checkPlayerBust();

        }

        public void getPlayerBalance()
        {
            int playerBalance = 0;
            foreach(string card in playerCards)
            {
                string cardValue = card.Substring(0, 2);
                if(cardValue == "11")
                {
                    playerBalance += 10;
                }
                else if (cardValue == "12")
                {
                    playerBalance += 10;
                }
                else if (cardValue == "13")
                {
                    playerBalance += 10;
                }
                else
                {
                    playerBalance += Convert.ToInt32(cardValue);
                }
                

            }

            textBox1.Text = playerBalance.ToString();
            label3.Visible = true;
            label3.Text = playerBalance.ToString();

        }

        public void getPcBalance()
        {
            int pcBalance = 0;
            foreach (string card in pcCards)
            {
                string cardValue = card.Substring(0, 2);
                if (cardValue == "11")
                {
                    pcBalance += 10;
                }
                else if (cardValue == "12")
                {
                    pcBalance += 10;
                }
                else if (cardValue == "13")
                {
                    pcBalance += 10;
                }
                else
                {
                    pcBalance += Convert.ToInt32(cardValue);
                }

            }

            textBox2.Text = pcBalance.ToString();
            label4.Visible = true;
            label4.Text = pcBalance.ToString();

        }

        


        public void Hit()
        {
            string hitCard = generateCard();
            playerCards.Add(hitCard);

            foreach(PictureBox picBox in playerPicBoxes)
            {
                if(picBox.Visible == false)
                {
                    picBox.Visible = true;
                    picBox.Image = Image.FromFile(setImage(hitCard));
                    break;
                    
                }
            }

            getPlayerBalance();
            checkPlayerBust();

        }

        public void checkPlayerBust()
        {
            int playerBalance = Convert.ToInt32(textBox1.Text);
            if(playerBalance > 21)
            {
                label1.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
                button4.Visible = true;

            }

        }

        public void revealSecondDealerCard()
        {
            string secondPcCard = generateCard();
            pcCards.Add(secondPcCard);
            pictureBox11.Visible = true;
            pictureBox11.Image = Image.FromFile(setImage(secondPcCard));
            getPcBalance();
            


        }

        public async void revealDealerCards()
        {
            int dealerBalance = Convert.ToInt32(textBox2.Text);
            if(dealerBalance < 17)
            {
                foreach (PictureBox picBox in pcPicBoxes)
                {
                    dealerBalance = Convert.ToInt32(textBox2.Text);
                    if (picBox.Visible == false && dealerBalance < 17)
                    {
                        string randomPcCard = generateCard();
                        pcCards.Add(randomPcCard);
                        picBox.Visible = true;
                        picBox.Image = Image.FromFile(setImage(randomPcCard));
                        getPcBalance();
                        await Task.Delay(1000);


                    }
                    getPcBalance();
                }

            }
        }

        public void checkFinalWinner(string str, string str2)
        {
            int playerNumber = Convert.ToInt32(str);
            int pcNumber = Convert.ToInt32(str2);

            if(playerNumber > pcNumber && pcNumber < playerNumber)
            {
                label5.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
                button4.Visible = true;
            }
            if(playerNumber < pcNumber && pcNumber > playerNumber && label2.Visible == false)
            {
                label6.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
                button4.Visible = true;
            }
            if (playerNumber == pcNumber)
            {
                label7.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
                button4.Visible = true;
            }
        }

        
        

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            Hit();
        }

        List<PictureBox> playerPicBoxes = new List<PictureBox>();
        List<PictureBox> pcPicBoxes = new List<PictureBox>();

        private async void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            button3.Visible = false;
            await Task.Delay(1500);

            playerPicBoxes.Add(pictureBox8);
            playerPicBoxes.Add(pictureBox7);
            playerPicBoxes.Add(pictureBox6);
            playerPicBoxes.Add(pictureBox5);
            playerPicBoxes.Add(pictureBox4);
            playerPicBoxes.Add(pictureBox3);
            playerPicBoxes.Add(pictureBox2);

            
            pcPicBoxes.Add(pictureBox12);
            pcPicBoxes.Add(pictureBox14);
            pcPicBoxes.Add(pictureBox15);
            pcPicBoxes.Add(pictureBox16);
            startRound();

            await Task.Delay(4000);
            button1.Visible = true;
            button2.Visible = true;


        }
        

        private async void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            revealSecondDealerCard();
            revealDealerCards();
            getPcBalance();
            getPlayerBalance();
            await Task.Delay(3000);
            //checkFinalWinner(textBox1.Text, textBox2.Text);
            checkWinner();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
