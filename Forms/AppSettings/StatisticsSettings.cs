using System;
using System.Windows.Forms;

namespace Scoreboard.Forms.AppSettings;

public partial class StatisticsSettings : Form
{
    public bool[] ActiveStatistics { get; }

    public StatisticsSettings()
    {
        ActiveStatistics = new bool[3];
        for (var i = 0; i < ActiveStatistics.Length; i++)
        {
            ActiveStatistics[i] = true;
        }
        InitializeComponent();
        MaximizeBox = false;
        ControlBox = false;
    }

    private void TimeoutsBoxCheckedChanged(object parSender, EventArgs parE)
    {
        if (!timeoutsBox.Checked)
        {
            ActiveStatistics[0] = false;
        }
        else
        {
            ActiveStatistics[0] = true;
        }
    }

    private void FaceOffsBoxCheckedChanged(object parSender, EventArgs parE)
    {
        if (!faceOffsBox.Checked)
        {
            ActiveStatistics[1] = false;
        }
        else
        {
            ActiveStatistics[1] = true;
        }
    }

    private void ShotsBoxCheckedChanged(object parSender, EventArgs parE)
    {
        if (!shotsBox.Checked)
        {
            ActiveStatistics[2] = false;
        }
        else
        {
            ActiveStatistics[2] = true;
        }
    }

    private void OkBtnClick(object parSender, EventArgs parE)
    {
        DialogResult = DialogResult.OK;
        Hide();
    }
}