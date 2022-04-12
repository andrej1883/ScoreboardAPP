using System.Windows.Forms;
using AxWMPLib;

namespace Scoreboard.Forms.MainGameForms;

// form used for playing videos - advertisement spots or team intros 
// windows media player is used as a video player
// implements play method which plays video which is stored on VideoPath
public partial class VideoPlayerForm : Form
{
    public AxWindowsMediaPlayer MediaPlayer => mediaPlayer;

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
        mediaPlayer.URL = VideoPath;
        mediaPlayer.Ctlcontrols.play();
    }
}