﻿using System;

namespace Scoreboard.Classes.Database;

[Serializable]
public class Advertisement
{
    private string _name;
    private string _path;

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