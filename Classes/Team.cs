using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Scoreboard.Forms;

namespace Scoreboard.Classes
{
    [Serializable]
    public class Team
    {
        private string _name;
        private string _videoPath;
        private string _logoPath;
        private List<Player> _players;

        public string LogoPath
        {
            get => _logoPath;
            set => _logoPath = value;
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

        public List<Player> Players
        {
            get => _players;
            set => _players = value;
        }

        public Team()
        {
            Players = new List<Player>();
        }

        public void AddPlayer(Player parPlayer)
        {
            if (!_players.Contains(parPlayer))
            {
                _players.Add(parPlayer);
            }
            else
            {
                MessageBox.Show( "! Each player only once!" , "Add player Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemovePlayer(Player parPlayer)
        {
            if (_players.Contains(parPlayer))
            {
                _players.Remove(parPlayer);
            }
            else
            {
                MessageBox.Show("Player not found", "Remove player Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
