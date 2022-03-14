using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoreboard.Classes
{
    [Serializable]
    public class Advertisment
    {
        private string _name;
        private string _path;

        public Advertisment()
        {
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Path
        {
            get => _path;
            set
            {
                _path = value;
                _name = System.IO.Path.GetFileName(value);
            }
        }

        public override string ToString()
        {
            return $"{_name}";
        }
    }
}
