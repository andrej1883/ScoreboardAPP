using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Scoreboard.Forms.MainGameForms;

namespace Scoreboard.Classes.Appearance
{
    [Serializable]
    public class ScoreboardSettings
    {
        private List<ScoreboardElement> _elements;

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
                var help = new ScoreboardElement()
                    {Color = ctrl.ForeColor.ToArgb(), ElementName = ctrl.Name, Position = ctrl.Location};
                if (ctrl is Label)
                {
                    help = new ScoreboardElement()
                        {Color = ctrl.ForeColor.ToArgb(), ElementName = ctrl.Name, Position = ctrl.Location, Size = ctrl.Font.Size, Font = ctrl.Font.Name};
                }
                _elements.Add(help);
            }
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
                    if (ctrl is Label)
                    {
                        ctrl.Font = new Font(help.Font,help.Size);
                    }
                }
            }
        }

        private ScoreboardElement FindByName(string parName)
        {
            foreach (ScoreboardElement element in Elements)
            {
                if (element.ElementName == parName)
                {
                    return element;
                }
            }
            return null;
        }
    }
}

