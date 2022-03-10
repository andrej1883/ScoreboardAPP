using System;
using System.Windows.Forms;
using Scoreboard.Forms;

namespace Scoreboard.Classes
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GameForm(new ScoreboardForm()));
        }
    }
}
