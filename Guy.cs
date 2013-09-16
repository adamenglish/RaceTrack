using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaceTrack
{
    public class Guy
    {
        public string Name; // The guy's name
        public Bet MyBet; // An instance of Bet() that has his bet
        public int Cash; // How much cash he has

        //The last two fields are the guy's GUI controls on the form
        public RadioButton MyRadioButton;
        public Label MyLabel;
                
        public Guy(string Name, Bet MyBet, int Cash, RadioButton MyRadioButton, Label MyLabel)
        {
            this.Name = Name;
            this.MyBet = MyBet;
            this.Cash = Cash;
            this.MyRadioButton = MyRadioButton;
            this.MyLabel = MyLabel;
        }

        public void UpdateLabels()
        {
            //Set my label to my bet's description, and the label on my radio button to show my cash ("Joe has 43 bucks")

            if (MyBet == null)
            {
                MyLabel.Text = String.Format("{0} hasn't placed any bets", Name);
            }
            else
            {
                MyLabel.Text = MyBet.GetDescription();
            }
            MyRadioButton.Text = Name + " has " + Cash + " bucks";
        }

        public void ClearBet() // Reset my bet so it's zero
        {
            MyBet.Amount = 0;
        }

        public bool PlaceBet(int Amount, int Dog) // Place a new bet and store it in my bet field, Return true if the guy had enough money to bet
        {
            if (Amount <= Cash)
            {
                MyBet = new Bet(Amount, Dog, this);
                return true;
            }
            return false;
        }

        public void Collect(int Winner) // Ask my bet to pay out
        {
            Cash += MyBet.PayOut(Winner);
        }

    }
}