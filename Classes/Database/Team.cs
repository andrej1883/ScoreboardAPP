using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Scoreboard.Classes.Database;

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
        if (!ContainsPlayer(parPlayer.Number, parPlayer.Name))
        {
            _players.Add(parPlayer);
        }
        else
        {
            if(parPlayer.Name != "" && parPlayer.Number != "")
                MessageBox.Show( @"! Each player only once!" , @"Add player Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void RemovePlayer(Player parPlayer)
    {
        if (ContainsPlayer(parPlayer.Number, parPlayer.Name))
        {
            _players.Remove(parPlayer);
        }
        else
        {
            MessageBox.Show(@"Player not found", @"Remove player Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private bool ContainsPlayer(string parNumber, string parName)
    {
        return _players.Any(parT => parT.Name == parName && parT.Number == parNumber);
    }

    public override string ToString()
    {
        return $"{Name}";
    }
}