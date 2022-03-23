using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using Scoreboard.Classes.Appearance;
using Scoreboard.Forms.MainGameForms;

namespace Scoreboard.Forms.Appearance
{
    public partial class ControlForm : Form
    {

        private ScoreboardForm _formScoreBoard;
        private bool _blackActive = false;
        private Form _blacForm = null;
        private bool _fOpen = false;
        private ColorDialog _colorDial;
        private FontDialog _fontDial;

        public bool BlackActive
        {
            get => _blackActive;
            set => _blackActive = value;
        }

        public Form BlacForm
        {
            get => _blacForm;
            set => _blacForm = value;
        }

        public ControlForm(ScoreboardForm parForm)
        {
            _formScoreBoard = parForm;
            _colorDial = new ColorDialog();
            _colorDial.AllowFullOpen = true;
            _colorDial.AnyColor = true;
            _colorDial.SolidColorOnly = false;
            _fontDial = new FontDialog();
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void InitDropdowns()
        {
            if (_formScoreBoard.IsActive)
            {
                scoreBWidth.Value = _formScoreBoard.Width;
                scoreBHeight.Value = _formScoreBoard.Height;
                gridSizeNumeric.Value = _formScoreBoard.GridSize;
                logoHeightBox.Value = _formScoreBoard.LogoSize.Height;
                logoWidthBox.Value = _formScoreBoard.LogoSize.Width;
            }
        }

        private void ResizeControls()
        {
            foreach (Control ctr in _formScoreBoard.Controls)
            {
                
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

        public void ControlImport()
        {
            ScoreboardSettings set = new ScoreboardSettings();
            TextReader textReader = null;
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "xml files (*.xml)|*.xml";
                open.InitialDirectory = Environment.CurrentDirectory;
                if (open.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(ScoreboardSettings));
                    textReader = new StreamReader(open.FileName);
                    set = (ScoreboardSettings)deserializer.Deserialize(textReader);
                }
            }
            catch (Exception ex)
            {
                set = new ScoreboardSettings();
                MessageBox.Show(ex.Message, "nazovProgramuString", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (textReader != null)
                    textReader.Close();
                if (set != null)
                {
                    set.SetElements(_formScoreBoard);
                }
            }
        }

        private void importSettings_Click(object sender, EventArgs e)
        { 
           ControlImport();
        }

        public void ControlExport()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xml files (*.xml)|*.xml";
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            TextWriter textWriter = null;
            ScoreboardSettings set = new ScoreboardSettings();
            set.AddElements(_formScoreBoard);
            try
            {
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ScoreboardSettings));
                    textWriter = new StreamWriter(saveFileDialog1.FileName);
                    serializer.Serialize(textWriter, set);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "nazovProgramuString", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (textWriter != null)
                    textWriter.Close();
            }
        }

        private void exportSettings_Click(object sender, EventArgs e)
        {
            ControlExport();
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
            for (int i = 1; i < 5; i++)
            {
                _formScoreBoard.ShowPenalty(i);
            }
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
            for (int i = 1; i < 5; i++)
            {
                _formScoreBoard.ShowPenalty(i);
            }
        }

        private void unlockScoreboard_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 5; i++)
            {
                _formScoreBoard.ShowPenalty(i);
            }
            

            if (_formScoreBoard.IsLocked)
            {
                _formScoreBoard.IsLocked = false;
                unlockScoreboard.ForeColor = Color.DarkRed;
                unlockScoreboard.Text = "Lock";
            }
            else
            {
                _formScoreBoard.IsLocked = true;
                unlockScoreboard.ForeColor = DefaultForeColor;
                unlockScoreboard.Text = "Unlock";
            }
        }

        private void setGrid_Click(object sender, EventArgs e)
        {
            _formScoreBoard.GridSize = (int)gridSizeNumeric.Value;
        }

        private void setLogoSize_Click(object sender, EventArgs e)
        {
            _formScoreBoard.LogoSize = new Size((int) logoWidthBox.Value, (int) logoHeightBox.Value);
        }

        private void setSizeShL_Click(object sender, EventArgs e)
        {
            _fontDial.Font = _formScoreBoard.ShotsLFont;
            if (_fontDial.ShowDialog() == DialogResult.OK) _formScoreBoard.ShotsLFont = _fontDial.Font;
        }

        private void setSizeShShot_Click(object sender, EventArgs e)
        {
            _fontDial.Font = _formScoreBoard.ShotsSFont;
            if (_fontDial.ShowDialog() == DialogResult.OK) _formScoreBoard.ShotsSFont = _fontDial.Font;
        }

        private void setSizeTimeoL_Click(object sender, EventArgs e)
        {
            _fontDial.Font = _formScoreBoard.TimeoutLFont;
            if (_fontDial.ShowDialog() == DialogResult.OK) _formScoreBoard.TimeoutLFont = _fontDial.Font;
        }

        private void setSizeTimeout_Click(object sender, EventArgs e)
        {
            _fontDial.Font = _formScoreBoard.TimeoutTFont;
            if (_fontDial.ShowDialog() == DialogResult.OK) _formScoreBoard.TimeoutTFont = _fontDial.Font;
        }

        private void setSizeFaceL_Click(object sender, EventArgs e)
        {
            _fontDial.Font = _formScoreBoard.FaceOffLFont;
            if (_fontDial.ShowDialog() == DialogResult.OK) _formScoreBoard.FaceOffLFont = _fontDial.Font;
        }

        private void setSizeFace_Click(object sender, EventArgs e)
        {
            _fontDial.Font = _formScoreBoard.FaceOffFaceFont;
            if (_fontDial.ShowDialog() == DialogResult.OK) _formScoreBoard.FaceOffFaceFont = _fontDial.Font;
        }

        private void setColorShL_Click(object sender, EventArgs e)
        {
            _colorDial.Color = _formScoreBoard.ShotsLColor;
            if (_colorDial.ShowDialog() == DialogResult.OK) _formScoreBoard.ShotsLColor = _colorDial.Color;
        }

        private void setColorShShot_Click(object sender, EventArgs e)
        {
            _colorDial.Color = _formScoreBoard.ShotsSColor;
            if (_colorDial.ShowDialog() == DialogResult.OK) _formScoreBoard.ShotsSColor = _colorDial.Color;
        }

        private void setColorTimeoL_Click(object sender, EventArgs e)
        {
            _colorDial.Color = _formScoreBoard.TimeoutLColor;
            if (_colorDial.ShowDialog() == DialogResult.OK) _formScoreBoard.TimeoutLColor = _colorDial.Color;
        }

        private void setColorTimeout_Click(object sender, EventArgs e)
        {
            _colorDial.Color = _formScoreBoard.TimeoutTColor;
            if (_colorDial.ShowDialog() == DialogResult.OK) _formScoreBoard.TimeoutTColor = _colorDial.Color;
        }

        private void setColorFaceL_Click(object sender, EventArgs e)
        {
            _colorDial.Color = _formScoreBoard.FaceOffLColor;
            if (_colorDial.ShowDialog() == DialogResult.OK) _formScoreBoard.FaceOffLColor = _colorDial.Color;
        }

        private void setColorFace_Click(object sender, EventArgs e)
        {
            _colorDial.Color = _formScoreBoard.FaceOffFaceColor;
            if (_colorDial.ShowDialog() == DialogResult.OK) _formScoreBoard.FaceOffFaceColor = _colorDial.Color;
        }
    }
}
