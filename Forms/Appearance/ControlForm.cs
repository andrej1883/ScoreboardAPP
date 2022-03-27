using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using Scoreboard.Classes.Appearance;
using Scoreboard.Forms.MainGameForms;

namespace Scoreboard.Forms.Appearance;

public partial class ControlForm : Form
{
    private readonly ColorDialog _colorDial;
    private readonly FontDialog _fontDial;
    private readonly ScoreboardForm _formScoreBoard;

    private bool _fOpen;


    public ControlForm(ScoreboardForm parForm)
    {
        _formScoreBoard = parForm;
#pragma warning disable IDE0017 // Simplify object initialization
        _colorDial = new ColorDialog();
#pragma warning restore IDE0017 // Simplify object initialization
        _colorDial.AllowFullOpen = true;
        _colorDial.AnyColor = true;
        _colorDial.SolidColorOnly = false;
        _fontDial = new FontDialog();
        InitializeComponent();
    }

    public bool BlackActive { get; private set; }

    public Form BlacForm { get; private set; }

    private void InitDropdowns()
    {
        if (!_formScoreBoard.IsActive) return;
        scoreBWidth.Value = _formScoreBoard.Width;
        scoreBHeight.Value = _formScoreBoard.Height;
        gridSizeNumeric.Value = _formScoreBoard.GridSize;
        logoHeightBox.Value = _formScoreBoard.LogoSize.Height;
        logoWidthBox.Value = _formScoreBoard.LogoSize.Width;
        for (var i = 1; i < 5; i++) _formScoreBoard.ShowPenalty(i);
    }

    private void ScoreBWidthValueChanged(object parSender, EventArgs parE)
    {
        if (!_fOpen)
        {
            scoreBWidth.Value = _formScoreBoard.Width;
            _fOpen = true;
        }


        _formScoreBoard.Width = decimal.ToInt32(scoreBWidth.Value);
        _formScoreBoard.MoveComponents();
    }

    private void ScoreBHeightValueChanged(object parSender, EventArgs parE)
    {
        if (!_fOpen)
        {
            scoreBHeight.Value = _formScoreBoard.Height;
            _fOpen = true;
        }

        _formScoreBoard.Height = decimal.ToInt32(scoreBHeight.Value);
        _formScoreBoard.MoveComponents();
    }

    private void BlackBcgrBtnClick(object parSender, EventArgs parE)
    {
        if (!BlackActive)
        {
#pragma warning disable IDE0017 // Simplify object initialization
            BlacForm = new Form();
#pragma warning restore IDE0017 // Simplify object initialization
            BlacForm.MinimizeBox = false;
            BlacForm.MaximizeBox = false;
            BlacForm.ControlBox = false;
            BlacForm.FormBorderStyle = FormBorderStyle.None;
            Text = string.Empty;
            BlacForm.Size = Size;
            BlacForm.BackColor = Color.Black;
            var screens = Screen.AllScreens;
            var bounds = screens[1].Bounds;
            BlacForm.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
            BlacForm.StartPosition = FormStartPosition.Manual;
            BlacForm.Show();
            BlackActive = true;
            blackBcgrBtn.ForeColor = Color.DarkRed;
        }
        else
        {
            BlacForm.Dispose();
            BlackActive = false;
            blackBcgrBtn.ForeColor = DefaultForeColor;
        }
    }

    private void CenterScoreBtnClick1(object parSender, EventArgs parE)
    {
        SelectPosition(5);
    }

    private void Kv1BtnClick(object parSender, EventArgs parE)
    {
        SelectPosition(1);
    }

    private void Kv2BtnClick(object parSender, EventArgs parE)
    {
        SelectPosition(2);
    }

    private void Kv3BtnClick(object parSender, EventArgs parE)
    {
        SelectPosition(3);
    }

    private void Kv4BtnClick(object parSender, EventArgs parE)
    {
        SelectPosition(4);
    }

    private void SelectPosition(int parPosition)
    {
        if (_formScoreBoard == null) return;
        var area = Screen.AllScreens[1].Bounds;
        var location = area.Location;

        switch (parPosition)
        {
            case 1:
                location.Offset(area.Width - _formScoreBoard.Width, 0);
                break;
            case 2:
                location.Offset(0, 0);
                break;
            case 3:
                location.Offset(0, area.Height - _formScoreBoard.Height);
                break;
            case 4:
                location.Offset(area.Width - _formScoreBoard.Width, area.Height - _formScoreBoard.Height);
                break;
            default:
                location.Offset((area.Width - _formScoreBoard.Width) / 2, (area.Height - _formScoreBoard.Height) / 2);
                break;
        }

        _formScoreBoard.Location = location;
    }

    private void ControlFormLoad(object parSender, EventArgs parE)
    {
        InitDropdowns();
    }

    private void ControlImport()
    {
        ScoreboardSettings set = new();
        TextReader textReader = null;
        try
        {
            OpenFileDialog open = new();
            open.Filter = @"xml files (*.xml)|*.xml";
            open.InitialDirectory = Environment.CurrentDirectory;
            if (open.ShowDialog() != DialogResult.OK) return;
            XmlSerializer deserializer = new(typeof(ScoreboardSettings));
            textReader = new StreamReader(open.FileName);
            set = (ScoreboardSettings) deserializer.Deserialize(textReader);
        }
        catch (Exception ex)
        {
            set = new ScoreboardSettings();
            MessageBox.Show(ex.Message, @"Import appearance error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            textReader?.Close();
            set?.SetElements(_formScoreBoard);
        }
    }

    private void ImportSettingsClick(object parSender, EventArgs parE)
    {
        ControlImport();
    }

    private void ControlExport()
    {
        SaveFileDialog saveFileDialog1 = new();
        saveFileDialog1.Filter = @"xml files (*.xml)|*.xml";
        saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
        TextWriter textWriter = null;
        ScoreboardSettings set = new();
        set.AddElements(_formScoreBoard);
        try
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            XmlSerializer serializer = new(typeof(ScoreboardSettings));
            textWriter = new StreamWriter(saveFileDialog1.FileName);
            serializer.Serialize(textWriter, set);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, @"Export appearance error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            textWriter?.Close();
        }
    }

    private void ExportSettingsClick(object parSender, EventArgs parE)
    {
        ControlExport();
    }

    private void BackgrColorClick(object parSender, EventArgs parE)
    {
        _colorDial.Color = _formScoreBoard.BackgrColor;
        if (_colorDial.ShowDialog() == DialogResult.OK) _formScoreBoard.BackgrColor = _colorDial.Color;
    }

    private void SetColorSlClick(object parSender, EventArgs parE)
    {
        _colorDial.Color = _formScoreBoard.ScoLColor;
        if (_colorDial.ShowDialog() == DialogResult.OK) _formScoreBoard.ScoLColor = _colorDial.Color;
    }

    private void SetColorTlClick(object parSender, EventArgs parE)
    {
        _colorDial.Color = _formScoreBoard.TimeLColor;
        if (_colorDial.ShowDialog() == DialogResult.OK) _formScoreBoard.TimeLColor = _colorDial.Color;
    }

    private void SetColorTcClick(object parSender, EventArgs parE)
    {
        _colorDial.Color = _formScoreBoard.TimeCColor;
        if (_colorDial.ShowDialog() == DialogResult.OK) _formScoreBoard.TimeCColor = _colorDial.Color;
    }

    private void SetColorPlClick(object parSender, EventArgs parE)
    {
        _colorDial.Color = _formScoreBoard.PeriodLColor;
        if (_colorDial.ShowDialog() == DialogResult.OK) _formScoreBoard.PeriodLColor = _colorDial.Color;
    }

    private void SetColorPpClick(object parSender, EventArgs parE)
    {
        _colorDial.Color = _formScoreBoard.PeriodColor;
        if (_colorDial.ShowDialog() == DialogResult.OK) _formScoreBoard.PeriodColor = _colorDial.Color;
    }

    private void SetColorPenLClick(object parSender, EventArgs parE)
    {
        _colorDial.Color = _formScoreBoard.PenaltyLColor;
        if (_colorDial.ShowDialog() == DialogResult.OK) _formScoreBoard.PenaltyLColor = _colorDial.Color;
    }

    private void SetColorPenDataClick(object parSender, EventArgs parE)
    {
        _colorDial.Color = _formScoreBoard.PenaltyDColor;
        if (_colorDial.ShowDialog() == DialogResult.OK) _formScoreBoard.PenaltyDColor = _colorDial.Color;
        for (var i = 1; i < 5; i++) _formScoreBoard.ShowPenalty(i);
    }

    private void SetColorSsClick(object parSender, EventArgs parE)
    {
        _colorDial.Color = _formScoreBoard.ScoSColor;
        if (_colorDial.ShowDialog() == DialogResult.OK) _formScoreBoard.ScoSColor = _colorDial.Color;
    }

    private void SetSizeSlClick(object parSender, EventArgs parE)
    {
        _fontDial.Font = _formScoreBoard.ScoLFont;
        if (_fontDial.ShowDialog() == DialogResult.OK) _formScoreBoard.ScoLFont = _fontDial.Font;
    }

    private void SetSizeSsClick(object parSender, EventArgs parE)
    {
        _fontDial.Font = _formScoreBoard.ScoSFont;
        if (_fontDial.ShowDialog() == DialogResult.OK) _formScoreBoard.ScoSFont = _fontDial.Font;
    }

    private void SetSizeTlClick(object parSender, EventArgs parE)
    {
        _fontDial.Font = _formScoreBoard.TimeLFont;
        if (_fontDial.ShowDialog() == DialogResult.OK) _formScoreBoard.TimeLFont = _fontDial.Font;
    }

    private void SetSizeTcClick(object parSender, EventArgs parE)
    {
        _fontDial.Font = _formScoreBoard.TimeCFont;
        if (_fontDial.ShowDialog() == DialogResult.OK) _formScoreBoard.TimeCFont = _fontDial.Font;
    }

    private void SetSizePlClick(object parSender, EventArgs parE)
    {
        _fontDial.Font = _formScoreBoard.PeriodLFont;
        if (_fontDial.ShowDialog() == DialogResult.OK) _formScoreBoard.PeriodLFont = _fontDial.Font;
    }

    private void SetSizePpClick(object parSender, EventArgs parE)
    {
        _fontDial.Font = _formScoreBoard.PeriodPFont;
        if (_fontDial.ShowDialog() == DialogResult.OK) _formScoreBoard.PeriodPFont = _fontDial.Font;
    }

    private void SetSizePenLClick(object parSender, EventArgs parE)
    {
        _fontDial.Font = _formScoreBoard.PenaltyLFont;
        if (_fontDial.ShowDialog() == DialogResult.OK) _formScoreBoard.PenaltyLFont = _fontDial.Font;
    }

    private void SetSizePenDataClick(object parSender, EventArgs parE)
    {
        _fontDial.Font = _formScoreBoard.PenaltyDFont;
        if (_fontDial.ShowDialog() == DialogResult.OK) _formScoreBoard.PenaltyDFont = _fontDial.Font;
        for (var i = 1; i < 5; i++) _formScoreBoard.ShowPenalty(i);
    }

    private void UnlockScoreboardClick(object parSender, EventArgs parE)
    {
        for (var i = 1; i < 5; i++) _formScoreBoard.ShowPenalty(i);


        if (_formScoreBoard.IsLocked)
        {
            _formScoreBoard.IsLocked = false;
            unlockScoreboard.ForeColor = Color.DarkRed;
            unlockScoreboard.Text = @"Lock";
        }
        else
        {
            _formScoreBoard.IsLocked = true;
            unlockScoreboard.ForeColor = DefaultForeColor;
            unlockScoreboard.Text = @"Unlock";
        }
    }

    private void SetGridClick(object parSender, EventArgs parE)
    {
        _formScoreBoard.GridSize = (int) gridSizeNumeric.Value;
    }

    private void SetLogoSizeClick(object parSender, EventArgs parE)
    {
        _formScoreBoard.LogoSize = new Size((int) logoWidthBox.Value, (int) logoHeightBox.Value);
    }

    private void SetSizeShLClick(object parSender, EventArgs parE)
    {
        _fontDial.Font = _formScoreBoard.ShotsLFont;
        if (_fontDial.ShowDialog() == DialogResult.OK) _formScoreBoard.ShotsLFont = _fontDial.Font;
    }

    private void SetSizeShShotClick(object parSender, EventArgs parE)
    {
        _fontDial.Font = _formScoreBoard.ShotsSFont;
        if (_fontDial.ShowDialog() == DialogResult.OK) _formScoreBoard.ShotsSFont = _fontDial.Font;
    }

    private void SetSizeTimeoLClick(object parSender, EventArgs parE)
    {
        _fontDial.Font = _formScoreBoard.TimeoutLFont;
        if (_fontDial.ShowDialog() == DialogResult.OK) _formScoreBoard.TimeoutLFont = _fontDial.Font;
    }

    private void SetSizeTimeoutClick(object parSender, EventArgs parE)
    {
        _fontDial.Font = _formScoreBoard.TimeoutTFont;
        if (_fontDial.ShowDialog() == DialogResult.OK) _formScoreBoard.TimeoutTFont = _fontDial.Font;
    }

    private void SetSizeFaceLClick(object parSender, EventArgs parE)
    {
        _fontDial.Font = _formScoreBoard.FaceOffLFont;
        if (_fontDial.ShowDialog() == DialogResult.OK) _formScoreBoard.FaceOffLFont = _fontDial.Font;
    }

    private void SetSizeFaceClick(object parSender, EventArgs parE)
    {
        _fontDial.Font = _formScoreBoard.FaceOffFaceFont;
        if (_fontDial.ShowDialog() == DialogResult.OK) _formScoreBoard.FaceOffFaceFont = _fontDial.Font;
    }

    private void SetColorShLClick(object parSender, EventArgs parE)
    {
        _colorDial.Color = _formScoreBoard.ShotsLColor;
        if (_colorDial.ShowDialog() == DialogResult.OK) _formScoreBoard.ShotsLColor = _colorDial.Color;
    }

    private void SetColorShShotClick(object parSender, EventArgs parE)
    {
        _colorDial.Color = _formScoreBoard.ShotsSColor;
        if (_colorDial.ShowDialog() == DialogResult.OK) _formScoreBoard.ShotsSColor = _colorDial.Color;
    }

    private void SetColorTimeoLClick(object parSender, EventArgs parE)
    {
        _colorDial.Color = _formScoreBoard.TimeoutLColor;
        if (_colorDial.ShowDialog() == DialogResult.OK) _formScoreBoard.TimeoutLColor = _colorDial.Color;
    }

    private void SetColorTimeoutClick(object parSender, EventArgs parE)
    {
        _colorDial.Color = _formScoreBoard.TimeoutTColor;
        if (_colorDial.ShowDialog() == DialogResult.OK) _formScoreBoard.TimeoutTColor = _colorDial.Color;
    }

    private void SetColorFaceLClick(object parSender, EventArgs parE)
    {
        _colorDial.Color = _formScoreBoard.FaceOffLColor;
        if (_colorDial.ShowDialog() == DialogResult.OK) _formScoreBoard.FaceOffLColor = _colorDial.Color;
    }

    private void SetColorFaceClick(object parSender, EventArgs parE)
    {
        _colorDial.Color = _formScoreBoard.FaceOffFaceColor;
        if (_colorDial.ShowDialog() == DialogResult.OK) _formScoreBoard.FaceOffFaceColor = _colorDial.Color;
    }
}