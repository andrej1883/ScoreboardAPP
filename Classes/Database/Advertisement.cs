using System;

namespace Scoreboard.Classes.Database;

[Serializable]
// class for storing information about advertisement in database
// it is serializable because we can save Database class and all its content to xml
public class Advertisement
{
    private string _name;
    private string _path;

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
        return $"{Name}";
    }
}