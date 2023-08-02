using System;

namespace ElonMusk
{
    class Car
    {
        private string _colour = "";
        /// <summary>
        /// Colour of car
        /// </summary>
        public string Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }


        private byte _battery;
        /// <summary>
        /// Battery remaining
        /// </summary>
        public byte Battery
        {
            get { return _battery; }
            set { _battery = value; }
        }


        private int _distance;
        /// <summary>
        /// Distance driven in metres
        /// </summary>
        public int Distance
        {
            get { return _distance; }
            set { _distance = value; }
        }

        /// <summary>
        /// Drains the battery by 1% and drives 20 metres
        /// </summary>
        public void Drive()
        {
            if (_battery > 0)
            {
                _battery--;
                _distance += 20;
                Console.WriteLine("Battery is now " + _battery + "%");
                Console.WriteLine("You have driven " + _distance + " metres");
            }
            else
            {
                Console.WriteLine("Not enough battery");
            }
        }
    }
}