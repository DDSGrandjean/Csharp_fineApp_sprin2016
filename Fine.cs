using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FineApp
{
    class Fine
    {
        private string fullName;
        private int speed,
                    speedLimit;
        private char offense;

        private bool badData = false;
        private int milesOverLimit;
        private double offenseCharge,
                       fine;

        public Fine(){}

        public string Name { set { fullName = value; } }
        public int Speed { set { speed = value; } }
        public int SpeedLimit { set { speedLimit = value; } }
        public char Offense { set { offense = value; } }

        private void FineAmount()
        {
            if (speed <= speedLimit)
            {
                badData = true;
            }
            else
            {
                milesOverLimit = speed - speedLimit;
                if (milesOverLimit >= 20)
                {
                    fine = milesOverLimit * 20;
                }
                else
                {
                    fine = milesOverLimit * 10;
                }
                fine += GetOffenseCharge();
            }
        }

        private double GetOffenseCharge()
        {
            switch (offense)
            {
                case '1':     offenseCharge = 0;      break;
                case '2':     offenseCharge = 100;    break;
                case '3':     offenseCharge = 200;    break;
                case '4':     offenseCharge = 500;    break;
                default:      badData = true;         break;
            }

            return offenseCharge;
        }

        public override string ToString()
        {
            FineAmount();

            if (badData)
            { 
                return "Bad Data";
            }
            else
            {
                return "Name: "                  + fullName +
                       "\nSpeed limit: "         + speedLimit +
                       "\nSpeed: "               + speed +
                       "\nMiles over limit: "    + milesOverLimit +
                       "\nOffense charge: "      + offenseCharge.ToString("c") +
                       "\nFine: "                + fine.ToString("c");
            }
        }
    }
}
