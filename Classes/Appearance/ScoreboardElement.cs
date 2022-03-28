using System;
using System.Drawing;

namespace Scoreboard.Classes.Appearance;

[Serializable]
// class used for exporting scoreboard appearance to xml file. Elements are scoreboard items like logos or labels
public class ScoreboardElement
{
    private string _elementName;

    private int _color;
    private Point _position;
    private string _font;
    private float _size;
    private Size _logoSize;

    public Size LogoSize
    {
        get => _logoSize;
        set => _logoSize = value;
    }

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
}