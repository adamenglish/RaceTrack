using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaceTrack
{
    public class Bet
    {
        public int Amount; //The amount of cash wagered
        public int Dog; // The number of the dog the bet is on
        public Guy Bettor; //The person who placed the bet
        public string GetDescription() { 
        //Return a string that says who placed the bet, how much cash was bet, and which dog he bet on.  If the amount is zero, no bet was placed.
            string description = "";

            if (Amount > 0)
            {
                description = String.Format("{0} bets {1} on dog #{2}",
                    Bettor.Name, Amount, Dog);
            }
            else
            {
                description = String.Format("{0} hasn't placed any bets",
                    Bettor.Name);
            }
            return description;

        }
        public int Payout(int winner) { //The parameter is the winner of the race.  If the dog won, return the amount bet.  Otherwise, return the negative of the amount bet.
        if (Dog == winner) {
            return Amount;
        }
            return -Amount;
    }
}