using System;
using System.Windows.Forms;

namespace EnergyUsageSimulator
{
    public partial class EnergySimulator : Form
    {
        public EnergySimulator()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nodeManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NodeForm nf = new NodeForm();
            nf.Show();
        }
    }
}