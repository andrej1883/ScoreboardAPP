using System;
using System.Windows.Forms;

namespace Scoreboard.Forms.AppSettings;

public partial class ExportStatsForm : Form
{
    public string Path { get; private set; }

    public bool Export { get; private set; } = true;

    public ExportStatsForm()
    {
        InitializeComponent();
        pathTextBox.Text = $@"{Environment.CurrentDirectory}\Events";
        MaximizeBox = false;
    }

    private void ExportEventsBoxCheckedChanged(object parSender, EventArgs parE)
    {
        Export = exportEventsBox.Checked;
    }

    private void ConfirmClick(object parSender, EventArgs parE)
    {
        if (!string.IsNullOrWhiteSpace(pathTextBox.Text))
        {
            Path = pathTextBox.Text;
        }
        Hide();
        DialogResult = DialogResult.OK;
    }

    private void SelectPathClick(object parSender, EventArgs parE)
    {
        var browserDialog = new FolderBrowserDialog();
        var res = browserDialog.ShowDialog();
        if (res != DialogResult.OK) return;
        Path = browserDialog.SelectedPath;
        pathTextBox.Text = Path;
    }
}