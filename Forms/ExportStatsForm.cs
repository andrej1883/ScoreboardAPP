﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scoreboard.Forms
{
    public partial class ExportStatsForm : Form
    {
        private string _path;
        private bool _export = true;

        public string Path
        {
            get => _path;
            set => _path = value;
        }

        public bool Export
        {
            get => _export;
            set => _export = value;
        }

        public ExportStatsForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void exportEventsBox_CheckedChanged(object sender, EventArgs e)
        {
            if (exportEventsBox.Checked)
            {
                _export = true;
            }
            else
            {
                _export = false;
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(pathTextBox.Text))
            {
                _path = pathTextBox.Text;
            }
            Hide();
            DialogResult = DialogResult.OK;
        }

        private void selectPath_Click(object sender, EventArgs e)
        {
            var browserDialog = new FolderBrowserDialog();
            DialogResult res = browserDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                _path = browserDialog.SelectedPath;
                pathTextBox.Text = _path;
            }
        }
    }
}