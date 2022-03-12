using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scoreboard.Forms;

namespace Scoreboard.Classes
{
    public class Team
    {
        private const int PlayersMax = 20;

        private string _name;
        private string _videoPath;
        private List<Player> _players;

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

        }

        public void AddPlayer(Player parPlayer)
        {
            if (_players.Count < PlayersMax && !_players.Contains(parPlayer))
            {
                _players.Add(parPlayer);
            }
            else
            {
                MessageBox.Show("Maximum players allowed: " + PlayersMax + "! Each player only once!" , "Add player Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
