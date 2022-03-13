using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoreboard.Classes
{
    internal class AdvertisementVideo
    {
        private string _name;
        private string _videoPath;

        public AdvertisementVideo()
        {
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string VideoPath
        {
            get => _videoPath;
            set => _videoPath = value;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
