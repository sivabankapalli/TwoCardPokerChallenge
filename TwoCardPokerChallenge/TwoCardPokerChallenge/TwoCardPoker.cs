using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
using TwoCardPokerChallenge.Contract;

namespace TwoCardPokerChallenge
{
    [ExcludeFromCodeCoverage]
    public partial class TwoCardPoker : Form
    {
        public static int CardsSuffled = 0;
        public static int CurrentRound { get; set; }
        public List<HandComparisonItem> EachRoundList = new List<HandComparisonItem>();
        public int GetNumberOfPlayers()
        {
            return NumberOfPlayers1;
        }

        public void SetNumberOfPlayers(int value)
        {
            NumberOfPlayers1 = value;
        }

        public int NumberOfRounds { get; set; }

        public int NumberOfPlayers1 { get => NumberOfPlayers2; set => NumberOfPlayers2 = value; }
        public int NumberOfPlayers2 { get => NumberOfPlayers; set => NumberOfPlayers = value; }
        public int NumberOfPlayers { get; set; }


        public TwoCardPoker()
        {
            using (new InputForm())
            {
            }
        }
        public TwoCardPoker(int noOfPlayers,int noOfRounds)
        {
            InitializeComponent();
            gameRounds.Text = noOfRounds.ToString();
            numOfPlayers.Text = noOfPlayers.ToString();
            SetNumberOfPlayers(noOfPlayers);
            NumberOfRounds = noOfRounds;
        }

        private void ShuffleDeck_Click(object sender, EventArgs e)
        {
            DeckOfCards myDeck = new DeckOfCards(true);
            if (string.IsNullOrEmpty(numberOfTimes.Text))
            {
                MessageBox.Show(@"Enter shuffle numbers");
            }
            else
            {
                myDeck.ShuffleCards(Int32.Parse(numberOfTimes.Text));
                DealCard.Visible = true;
            }
        }

        private void DealCard_Click(object sender, EventArgs e)
        {
            CurrentRound++;
            DealCards dealCards = new DealCards(GetNumberOfPlayers(), NumberOfRounds);
            List<HandComparisonItem> cards;
            cards = dealCards.GetPlayerHand(GetNumberOfPlayers());
            roundNumber.Text = (CurrentRound).ToString();
            
            cards.ForEach(item => DisplayResult.Text+= item.PlayerName +@", "+@"Rank: " + item.Rank +
                                                       @", Poker Hand: " + Utilities.PokerHandsToShortString(item.Hand) +
                                                       @", Hand Type: " + Utilities.EnumToTitle(item.HandType)+@"
");
            if (CurrentRound == 1)
                EachRoundList = cards;
            else
            {
                foreach (var t in cards)
                {
                    EachRoundList.Add(t);
                }
            }

            DealCard.Visible = false;
            DisplayResult.Text += @"-------------------------------------------------------
";

            if (CurrentRound == NumberOfRounds)
            {
                ShuffleDeck.Visible = false;
                DealCard.Visible = false;
                errorMessage.Visible = true;
                errorMessage.Text = @"GAME FINISHED... PRESS RESTART FOR FRESH GAME";
                ArrayList finalResult;
                DetermineWinner determineWinner = new DetermineWinner();
                finalResult = determineWinner.FinalWinner(EachRoundList);

                DisplayResult.Text += @"

Final Winner is " + finalResult[0].ToString().Split(' ')[0];

                DisplayResult.Text += @"

Final Score and Ranking List

"
                    +@"Name  "+@"Score    "+@"Rank 
------------------------------------------------
";
                foreach(var list in finalResult)
                {
                    DisplayResult.Text += list+@"
";
                }
            }
        }

        private void ReStart_Click(object sender, EventArgs e)
        {
            CurrentRound = 0;
            Visible = false;
            InputForm startGame = new InputForm();
            startGame.Show();
        }

        private void TwoCardPoker_Load(object sender, EventArgs e)
        {

        }

        private void DisplayResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
