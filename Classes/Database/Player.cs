using System;

namespace Scoreboard.Classes.Database
{
    [Serializable]
    public class Player
    {
        private string _name;
        private string _number;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Number
        {
            get => _number;
            set => _number = value;
        }

        public Player()
        {
        }
    }
}
