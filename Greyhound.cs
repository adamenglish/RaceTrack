using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaceTrack
{
    public class Greyhound
    {
        public int StartingPosition; //Where my PictureBox starts
        public int RacetrackLength; //How long the racetrack is
        public PictureBox MyPictureBox = null; //My Picturebox object
        public int Location = 0; //My location on the racetrack
        public Random MyRandom; //An instance of Random

        public bool Run() 
            //Move forward either 1, 2, 3 or 4 spaces at random.
            //Update the position of my PictureBox on the form
            //Return true if I won the race
        {
            MyRandom = new Random();
            int distance = MyRandom.Next(1, 5);

            MoveMyPictureBox(distance);

            Location += distance;
            if (Location >= (RacetrackLength - StartingPosition))
            {
                return true;
            }
            return false;
        }

        public void TakeStartingPosition() //Reset my position to the starting line
        {
            MoveMyPictureBox(-Location);
            Location = 0;
        }

        public void MoveMyPictureBox(int distance)
        {
            Point p = MyPictureBox.Location;
            p.X += distance;
            MyPictureBox.Location = p;
        }
    }
}