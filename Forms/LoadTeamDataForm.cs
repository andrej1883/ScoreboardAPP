using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Scoreboard.Forms
{
    public partial class LoadTeamDataForm : Form
    {
        public LoadTeamDataForm()
        {
            InitializeComponent();
        }

        private void loadXML_Click(object sender, EventArgs e)
        {
            List<Player> l1 = new List<Player>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Player>));

            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\test.xml", FileMode.Open, FileAccess.Read))
            {
                l1 = serial.Deserialize(fs) as List<Player>;
            }

            dataGridView1.DataSource = l1;
            listBox1.DataSource = l1;
        }

        private void savedData_Click(object sender, EventArgs e)
        {
            List<Player> l1 = new List<Player>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Player>));
            l1.Add(new Player() {Name = "Franto", Number = "10"});
            l1.Add(new Player() {Name = "Pepa", Number = "12"});
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\test.xml", FileMode.Create, FileAccess.Write))
            {
                serial.Serialize(fs, l1);
                MessageBox.Show("created");
            }
        }

        private int xPos;
        private int yPos;

        private void pictureBox7_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                xPos = e.X;
                yPos = e.Y;
            }
        }

        private void pictureBox7_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            PictureBox p = sender as PictureBox;

            if (p != null)
            {
                if (e.Button == MouseButtons.Left)
                {
                    p.Top += (e.Y - yPos);
                    p.Left += (e.X - xPos);
                }
            }

        }

    }

}
