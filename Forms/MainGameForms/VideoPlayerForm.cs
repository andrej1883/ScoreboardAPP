using System.Windows.Forms;
using AxWMPLib;

namespace Scoreboard.Forms.MainGameForms;

public partial class VideoPlayerForm : Form
{
    public AxWindowsMediaPlayer MediaPlayer { get; private set; }

    public string VideoPath { get; set; }

    public VideoPlayerForm()
    {
        InitializeComponent();
        FormBorderStyle = FormBorderStyle.None; 
        MinimizeBox = false;
        MaximizeBox = false;
        ControlBox = false; 
        var area = Screen.AllScreens[1].Bounds;
        Location = area.Location;
        MediaPlayer.uiMode = "none";
        SetBounds(area.X, area.Y, area.Width, area.Height);
    }

    public void PlayVideo()
    {
        if (VideoPath == null) return;
        MediaPlayer.URL = VideoPath;
        MediaPlayer.Ctlcontrols.play();
    }
}