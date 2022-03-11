using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoreboard.Forms
{
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
