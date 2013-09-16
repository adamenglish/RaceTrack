C# Lab: A Day at the Races 
Project from "Head First C#", Stellman and Greene, O'Reilly publishing

This lab provides a spec that describes a racetrack simulator program.

Concept:

Three guys love going to the racetrack and betting on the dogs.  3 guys start with varying dollar amounts, before each race they decide how much to bet, and can change bets up to the start of the race, but bets are finalized once the race starts.

Betting parlor: keeps track of sufficient cash and bets.
Every bet is double or nothing with a minimum of 5 bucks.
If the dog wins, the bettor ends up with twice the amount wagered after the race is done.
If the bettor loses, he cash goes down by the bet amount.

The race: 4 dogs run on a single straight track, winner is the first to cross finish line.

To-do: Write a handicap system.

Uses 3 main classes and a form (GUI).  Array of three Guy objects to keep track of the three guys and their winnigns and an array of four Greyhound objects that actually run the race.  Each instance of Guy object should have its own Bet object that keeps track of his bet and handles cash at the end of the race.

Greyhound Class
*Starting Location
*Racetrack Length
*MyPictureBox
*Location
*MyRandom
Run()
TakeStartingPosition()

Guy Class
*Name
*MyBet
*Cash
*MyRadioButton
*MyLabel
UpdateLabels()
PlaceBet()
ClearBet()
Collect()

Bet Class
*Amount
*Dog
*Bettor
GetDescription()
Payout()