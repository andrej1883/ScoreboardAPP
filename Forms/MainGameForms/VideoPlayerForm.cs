using System.Windows.Forms;
using AxWMPLib;

namespace Scoreboard.Forms.MainGameForms
{
    public partial class VideoPlayerForm : Form
    {
        private string _videoPath;

        public AxWindowsMediaPlayer MediaPlayer
        {
            get => mediaPlayer;
            set => mediaPlayer = value;
        }

        public string VideoPath
        {
            get => _videoPath;
            set => _videoPath = value;
        }

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
            if (VideoPath != null)
            {
                mediaPlayer.URL = VideoPath;
                mediaPlayer.Ctlcontrols.play();
            }
        }
    }
}
