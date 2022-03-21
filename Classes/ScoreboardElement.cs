﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Scoreboard.Classes;

[Serializable]
public class ScoreboardElement
{
    private string _elementName;

    private int _color;
    private Point _position;
    private string _font;
    private float _size;

    public string Font
    {
        get => _font;
        set => _font = value;
    }

    public float Size
    {
        get => _size;
        set => _size = value;
    }

    public string ElementName
    {
        get => _elementName;
        set => _elementName = value;
    }



    public int Color
    {
        get => _color;
        set => _color = value;
    }

    public Point Position
    {
        get => _position;
        set => _position = value;
    }

    public ScoreboardElement()
    {
    }
}