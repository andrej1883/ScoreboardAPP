using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Scoreboard.Forms.MainGameForms;

namespace Scoreboard.Classes.Appearance;

[Serializable]
// class responsible for setting elements of scoreboard and also for size and background color of scoreboard.
// Class is used when exporting / importing appearance settings of scoreboard
// AddElements is used when exporting _elements to xml
// SetElements is used when loading appearance from xml file for setting specific elements on scoreboard
public class ScoreboardSettings
{
    private List<ScoreboardElement> _elements;
    private int _backGrColor;
    private Size _boardSize;

    public int BackGrColor
    {
        get => _backGrColor;
        set => _backGrColor = value;
    }

    public Size BoardSize
    {
        get => _boardSize;
        set => _boardSize = value;
    }

    public List<ScoreboardElement> Elements
    {
        get => _elements;
        set => _elements = value;
    }

    public ScoreboardSettings()
    {
        _elements = new List<ScoreboardElement>();
    }

    public void AddElements(ScoreboardForm parForm)
    {
        foreach (Control ctrl in parForm.Controls)
        {
            var help = new ScoreboardElement {Color = ctrl.ForeColor.ToArgb(), ElementName = ctrl.Name, Position = ctrl.Location};
            switch (ctrl)
            {
                case Label:
                    help = new ScoreboardElement {Color = ctrl.ForeColor.ToArgb(), ElementName = ctrl.Name, Position = ctrl.Location, Size = ctrl.Font.Size, Font = ctrl.Font.Name};
                    break;
                case PictureBox:
                    help = new ScoreboardElement {ElementName = ctrl.Name, Position = ctrl.Location, LogoSize = ctrl.Size};
                    break;
            }

            _elements.Add(help);
        }

        BackGrColor = parForm.BackGrColor.ToArgb();
        BoardSize = parForm.Size;
    }

    public void SetElements(ScoreboardForm parForm)
    {
        foreach (Control ctrl in parForm.Controls)
        {
            var help = FindByName(ctrl.Name);
            if (help != null)
            {
                ctrl.Name = help.ElementName;
                ctrl.ForeColor = Color.FromArgb(help.Color);
                ctrl.Location = help.Position;
                switch (ctrl)
                {
                    case Label:
                        ctrl.Font = new Font(help.Font,help.Size);
                        break;
                    case PictureBox:
                        ctrl.Size = help.LogoSize;
                        break;
                }
            }
        }
        parForm.Size = BoardSize;
        parForm.BackGrColor = Color.FromArgb(BackGrColor);
    }

    private ScoreboardElement FindByName(string parName)
    {
        return Elements.FirstOrDefault(parElement => parElement.ElementName == parName);
    }
}