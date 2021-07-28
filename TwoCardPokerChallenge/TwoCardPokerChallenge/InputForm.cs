using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
using TwoCardPokerChallenge.Contract;

namespace TwoCardPokerChallenge
{
    [ExcludeFromCodeCoverage]
    public partial class InputForm : Form
    {
        public int NumberOfPlayersInput { get; set; }

        public int NumberOfRoundsInput { get; set; }

        public InputForm()
        {
            InitializeComponent();
        }

        private void gameStart_Click(object sender, EventArgs e)
        {
            try
            {
                bool playersResult;
                bool roundsResult;
                inputError.Visible = false;
                Utilities validate = new Utilities();
                NumberOfPlayersInput = Int32.Parse((numberOfPlayers.Text));
                playersResult = validate.ValidateNoOfPlayersInput(NumberOfPlayersInput);
                NumberOfRoundsInput = Int32.Parse((numberOfRounds.Text));
                if (playersResult)
                {
                    MessageBox.Show(@"Enter Number of Players between 2 to 6");
                    numberOfPlayers.Text = "0";
                }
                    
                roundsResult = validate.ValidateNoOfRoundsInput(NumberOfRoundsInput);
                if (roundsResult)
                {
                    MessageBox.Show(@"Enter Number of Rounds between 2 to 6");
                    numberOfRounds.Text = "0";
                }

                if (!(playersResult || roundsResult))
                {
                    TwoCardPoker twoCardPoker = new TwoCardPoker(NumberOfPlayersInput, NumberOfRoundsInput);
                    twoCardPoker.Show();
                    Visible = false;
                }
            }
            catch(Exception ex)
            {
                inputError.Visible = true;
                inputError.Text = @"Make sure to enter both players and rounds"+ex.Message;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"THANK YOU AND COME SOON!!!");
            Close();
            Visible = false;
        }
    }
}
