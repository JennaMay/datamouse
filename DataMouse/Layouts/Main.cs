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


namespace DataMouse.Layouts
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] lineOfContents = File.ReadAllLines("profiles.txt");
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split('#');
                profilesComboBox.Items.Add(tokens[0]);
            }
        }
    }
}
