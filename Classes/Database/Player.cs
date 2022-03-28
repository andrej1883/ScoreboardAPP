using System;

namespace Scoreboard.Classes.Database;

[Serializable]
// stores all information about player which is stored in team in database
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

    public override string ToString()
    {
        return $"{Name} {Number}";
    }
}