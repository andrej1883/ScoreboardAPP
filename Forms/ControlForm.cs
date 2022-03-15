using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Scoreboard.Forms.MainGameForms;

namespace Scoreboard.Forms
{
    public partial class ControlForm : Form
    {

        private ScoreboardForm _formScoreBoard;
        private bool _blackActive = false;
        private Form _blacForm = null;
        private bool _fOpen = false;
        private ColorDialog _colorDial;
        private FontDialog _fontDial;

        public ControlForm(ScoreboardForm parForm)
        {
            _formScoreBoard = parForm;
            _colorDial = new ColorDialog();
            _colorDial.AllowFullOpen = true;
            _colorDial.AnyColor = true;
            _colorDial.SolidColorOnly = false;
            _fontDial = new FontDialog();
            InitializeComponent();
        }

        private void InitDropdowns()
        {
            if (_formScoreBoard.IsActive)
            {
                scoreBWidth.Value = (int) _formScoreBoard.Width;
                scoreBHeight.Value = (int) _formScoreBoard.Height;
            }
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (!_fOpen)
            {
                scoreBWidth.Value = _formScoreBoard.Width;
                _fOpen = true;
            }

            
            _formScoreBoard.Width = decimal.ToInt32(scoreBWidth.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (!_fOpen)
            {
                scoreBHeight.Value = _formScoreBoard.Height;
                _fOpen = true;
            }
            
            _formScoreBoard.Height = decimal.ToInt32(scoreBHeight.Value);
        }

        private void blackBcgrBtn_Click(object sender, EventArgs e)
        {
            if (!_blackActive)
            {
                _blacForm = new Form();
                _blacForm.MinimizeBox = false;
                _blacForm.MaximizeBox = false;
                _blacForm.ControlBox = false;
                _blacForm.FormBorderStyle = FormBorderStyle.None;
                Text = string.Empty;
                _blacForm.Size = Size;
                _blacForm.BackColor = Color.Black;
                var screens = Screen.AllScreens;
                var bounds = screens[1].Bounds;
                _blacForm.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
                _blacForm.StartPosition = FormStartPosition.Manual;
                _blacForm.Show();
                _blackActive = true;
            }
            else
            {
                _blacForm.Dispose();
                _blackActive = false;
            }

        }

        private void centerScoreBtn_Click_1(object sender, EventArgs e)
        {
            SelectPosition(5);
        }

        private void kv1Btn_Click(object sender, EventArgs e)
        {
            SelectPosition(1);
        }

        private void kv2Btn_Click(object sender, EventArgs e)
        {
            SelectPosition(2);
        }

        private void kv3Btn_Click(object sender, EventArgs e)
        {
            SelectPosition(3);
        }

        private void kv4Btn_Click(object sender, EventArgs e)
        {
            SelectPosition(4);
        }

        private void SelectPosition(int position)
        {
            Screen[] screens = Screen.AllScreens;
            if (_formScoreBoard != null)
            {
                var area = Screen.AllScreens[1].Bounds;
                var location = area.Location;

                switch (position)
                {
                    case 1:
                        location.Offset((area.Width - _formScoreBoard.Width), (0));
                        break;
                    case 2:
                        location.Offset((0), (0));
                        break;
                    case 3:
                        location.Offset((0), (area.Height - _formScoreBoard.Height));
                        break;
                    case 4:
                        location.Offset((area.Width - _formScoreBoard.Width), (area.Height - _formScoreBoard.Height));
                        break;
                    default:
                        location.Offset((area.Width - _formScoreBoard.Width) / 2, (area.Height - _formScoreBoard.Height) / 2);
                        break;
                }
                _formScoreBoard.Location = location;
            }
        }

        private void ControlForm_Load(object sender, EventArgs e)
        {
            InitDropdowns();
        }

        private void importSettings_Click(object sender, EventArgs e)
        {
            string[] settings;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text files(*.txt)|*.txt";
            if (open.ShowDialog() == DialogResult.OK) 
            {
                importPath.Text = open.FileName;
                StreamReader reader = File.OpenText( importPath.Text);
                string line;
                while ((line = reader.ReadLine()) != null) 
                {
                    settings = line.Split('|');
                    _formScoreBoard.BackgrColor = Color.FromArgb(int.Parse(settings[0]));
                    _formScoreBoard.PenaltyDColor = Color.FromArgb(int.Parse(settings[1]));
                    _formScoreBoard.PenaltyLColor = Color.FromArgb(int.Parse(settings[2]));
                    _formScoreBoard.PeriodColor = Color.FromArgb(int.Parse(settings[3]));
                    _formScoreBoard.PeriodLColor = Color.FromArgb(int.Parse(settings[4]));
                    _formScoreBoard.TimeLColor = Color.FromArgb(int.Parse(settings[5]));
                    _formScoreBoard.ScoLColor = Color.FromArgb(int.Parse(settings[6]));
                    _formScoreBoard.ScoSColor = Color.FromArgb(int.Parse(settings[7]));
                    _formScoreBoard.TimeCColor = Color.FromArgb(int.Parse(settings[8]));
                    _formScoreBoard.PenaltyDFont = _formScoreBoard.SetFontSize(float.Parse(settings[9]));
                    _formScoreBoard.PenaltyLFont = _formScoreBoard.SetFontSize(float.Parse(settings[10]));
                    _formScoreBoard.PeriodLFont = _formScoreBoard.SetFontSize(float.Parse(settings[11]));
                    _formScoreBoard.PeriodPFont = _formScoreBoard.SetFontSize(float.Parse(settings[12]));
                    _formScoreBoard.TimeLFont = _formScoreBoard.SetFontSize(float.Parse(settings[13]));
                    _formScoreBoard.ScoLFont = _formScoreBoard.SetFontSize(float.Parse(settings[14]));
                    _formScoreBoard.ScoSFont =_formScoreBoard.SetFontSize( float.Parse(settings[15]));
                    _formScoreBoard.TimeCFont = _formScoreBoard.SetFontSize(float.Parse(settings[16]));
                    _formScoreBoard.Width = int.Parse(settings[17]);
                    _formScoreBoard.Height = int.Parse(settings[18]);
                    InitDropdowns();
                }
            }
        }

        private void exportSettings_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
 
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2 ;
            saveFileDialog1.RestoreDirectory = true ;
 
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string text = _formScoreBoard.ToString();
                File.WriteAllText(saveFileDialog1.FileName, text);
            }
        }

        private void backgrColor_Click(object sender, EventArgs e)
        {
            _colorDial.Color = _formScoreBoard.BackgrColor;
            if (_colorDial.ShowDialog() == DialogResult.OK) _formScoreBoard.BackgrColor = _colorDial.Color;
        }

        private void SetColorSL_Click(object sender, EventArgs e)
        {
            _colorDial.Color = _formScoreBoard.ScoLColor;
            if (_colorDial.ShowDialog() == DialogResult.OK) _formScoreBoard.ScoLColor = _colorDial.Color;
        }

        private void setColorTL_Click(object sender, EventArgs e)
        {
            _colorDial.Color = _formScoreBoard.TimeLColor;
            if (_colorDial.ShowDialog() == DialogResult.OK) _formScoreBoard.TimeLColor = _colorDial.Color;
        }

        private void setColorTC_Click(object sender, EventArgs e)
        {
            _colorDial.Color = _formScoreBoard.TimeCColor;
            if (_colorDial.ShowDialog() == DialogResult.OK) _formScoreBoard.TimeCColor = _colorDial.Color;
        }

        private void setColorPL_Click(object sender, EventArgs e)
        {
            _colorDial.Color = _formScoreBoard.PeriodLColor;
            if (_colorDial.ShowDialog() == DialogResult.OK) _formScoreBoard.PeriodLColor = _colorDial.Color;
        }

        private void setColorPP_Click(object sender, EventArgs e)
        {
            _colorDial.Color = _formScoreBoard.PeriodColor;
            if (_colorDial.ShowDialog() == DialogResult.OK) _formScoreBoard.PeriodColor = _colorDial.Color;
        }

        private void setColorPenL_Click(object sender, EventArgs e)
        {
            _colorDial.Color = _formScoreBoard.PenaltyLColor;
            if (_colorDial.ShowDialog() == DialogResult.OK) _formScoreBoard.PenaltyLColor = _colorDial.Color;
        }

        private void setColorPenData_Click(object sender, EventArgs e)
        {
            _colorDial.Color = _formScoreBoard.PenaltyDColor;
            if (_colorDial.ShowDialog() == DialogResult.OK) _formScoreBoard.PenaltyDColor = _colorDial.Color;
        }

        private void setColorSS_Click(object sender, EventArgs e)
        {
            _colorDial.Color = _formScoreBoard.ScoSColor;
            if (_colorDial.ShowDialog() == DialogResult.OK) _formScoreBoard.ScoSColor = _colorDial.Color;
        }

        private void setSizeSL_Click(object sender, EventArgs e)
        {
            _fontDial.Font = _formScoreBoard.ScoLFont;
            if (_fontDial.ShowDialog() == DialogResult.OK) _formScoreBoard.ScoLFont = _fontDial.Font;
        }

        private void setSizeSS_Click(object sender, EventArgs e)
        {
            _fontDial.Font = _formScoreBoard.ScoSFont;
            if (_fontDial.ShowDialog() == DialogResult.OK) _formScoreBoard.ScoSFont = _fontDial.Font;
        }

        private void setSizeTL_Click(object sender, EventArgs e)
        {
            _fontDial.Font = _formScoreBoard.TimeLFont;
            if (_fontDial.ShowDialog() == DialogResult.OK) _formScoreBoard.TimeLFont = _fontDial.Font;
        }

        private void setSizeTC_Click(object sender, EventArgs e)
        {
            _fontDial.Font = _formScoreBoard.TimeCFont;
            if (_fontDial.ShowDialog() == DialogResult.OK) _formScoreBoard.TimeCFont = _fontDial.Font;
        }

        private void setSizePL_Click(object sender, EventArgs e)
        {
            _fontDial.Font = _formScoreBoard.PeriodLFont;
            if (_fontDial.ShowDialog() == DialogResult.OK) _formScoreBoard.PeriodLFont = _fontDial.Font;
        }

        private void setSizePP_Click(object sender, EventArgs e)
        {
            _fontDial.Font = _formScoreBoard.PeriodPFont;
            if (_fontDial.ShowDialog() == DialogResult.OK) _formScoreBoard.PeriodPFont = _fontDial.Font;
        }

        private void setSizePenL_Click(object sender, EventArgs e)
        {
            _fontDial.Font = _formScoreBoard.PenaltyLFont;
            if (_fontDial.ShowDialog() == DialogResult.OK) _formScoreBoard.PenaltyLFont = _fontDial.Font;
        }

        private void setSizePenData_Click(object sender, EventArgs e)
        {
            _fontDial.Font = _formScoreBoard.PenaltyDFont;
            if (_fontDial.ShowDialog() == DialogResult.OK) _formScoreBoard.PenaltyDFont = _fontDial.Font;
        }

        private void unlockScoreboard_Click(object sender, EventArgs e)
        {
            if (_formScoreBoard.IsLocked)
            {
                _formScoreBoard.IsLocked = false;
                unlockScoreboard.ForeColor = Color.DarkRed;
            }
            else
            {
                _formScoreBoard.IsLocked = true;
                unlockScoreboard.ForeColor = DefaultForeColor;
            }
        }
    }
}
